using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ESCPrinting
{

    class PrinterControl
    {
        TcpClient mClient = new TcpClient();
        NetworkStream mStream = null;
        StringBuilder mBuffer = new StringBuilder();
        MemoryStream mMemory = new MemoryStream();
        Encoding mEncoding = new ASCIIEncoding();

        public void connect(String ip, int port)
        {
            mClient = new TcpClient();
            IAsyncResult res = mClient.BeginConnect(ip, port, null, null);
            bool success = res.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1));
            if (!success)
            {
                throw new Exception("Failed to connect " + ip + ":" + port);
            }
            // we have connected
            mClient.EndConnect(res);
            //mClient.Connect(ip, port);
            mStream = mClient.GetStream();
            mMemory.SetLength(0);
        }

        public bool isConnected()
        {
            return mClient.Connected;
        }

        public void close()
        {
            if (mStream != null)
                mStream.Close();
            mClient.Close();
        }

        void sendPkt()
        {
            try
            {
                byte[] pkt = mMemory.ToArray();
                mStream.Write(pkt, 0, pkt.Length);
                mMemory.SetLength(0);
            }catch(Exception ex)
            { }
        }

        public void lineFeed()
        {
            mMemory.WriteByte((byte)10);
            sendPkt();
        }

        public void lineFeed(int lines)
        {
            mMemory.WriteByte((byte)27);
            mMemory.WriteByte((byte)100);
            mMemory.WriteByte((byte)lines);
            sendPkt();
        }

        public void paperCut()
        {
            mMemory.WriteByte((byte)29);
            mMemory.WriteByte((byte)86);
            mMemory.WriteByte((byte)1);
            sendPkt();
        }

        public void print(String text)
        {
            
            byte[] data = mEncoding.GetBytes(text);
            mMemory.Write(data, 0, data.Length);
            sendPkt();
        }

        public void printLine(String text)
        {
            print(text);
        }

        public void style(bool on, bool bold, bool doubleHeight, bool doubleWidth, bool underline)
        {
            byte DoubleHeight = 1 << 4;
            byte DoubleWidth = 1 << 5;
            byte Bold = 1 << 3;
            byte Underline = 1 << 7;

            if (!doubleWidth)
                DoubleWidth = 0;
            if (!doubleHeight)
                DoubleHeight = 0;
            if (!bold)
                Bold = 0;
            if (!underline)
                Underline = 0;


            mMemory.WriteByte((byte)27);
            mMemory.WriteByte((byte)33);

            if (on)
                mMemory.WriteByte((byte)(DoubleHeight | DoubleWidth | Bold | Underline));
            else mMemory.WriteByte((byte)0);

            sendPkt();
        }

        public void alignLeft()
        {
            mMemory.WriteByte((byte)27);
            mMemory.WriteByte((byte)97);
            mMemory.WriteByte((byte)0);

            sendPkt();
        }

        public void alignCenter()
        {
            mMemory.WriteByte((byte)27);
            mMemory.WriteByte((byte)97);
            mMemory.WriteByte((byte)1);

            sendPkt();
        }

        public void alignRight()
        {
            mMemory.WriteByte((byte)27);
            mMemory.WriteByte((byte)97);
            mMemory.WriteByte((byte)2);

            sendPkt();
        }

        public void beep()
        {
            mMemory.WriteByte(ControlChars.Ch_RS);

            sendPkt();
        }

        public void sendCharset(string name)
        {
            byte charsetID = 0;          

            switch(name)
            {
                case "CP852":
                    mEncoding = Encoding.GetEncoding(852);
                    charsetID = 18;
                    break;

                case "CP850":
                    mEncoding = Encoding.GetEncoding(850);
                    charsetID = 2;
                    break;


                case "UTF-8":
                    mEncoding = Encoding.GetEncoding(65001);
                    charsetID = 127;
                    break;

                case "ASCII":
                default:
                    mEncoding = new ASCIIEncoding();
                    charsetID = 0;
                    break;


            }

            mMemory.WriteByte((byte)27);
            mMemory.WriteByte((byte)116);
            mMemory.WriteByte((byte)charsetID);

            sendPkt();
        }

        public void sendImage(string fileName)
        {
            Bitmap bitmap = new Bitmap(fileName);

            int x;
            int y;
            int i;
            int RowBytes;
            byte n;
            Color Pixels;
            byte[,] ImageArray = new byte[bitmap.Width, bitmap.Height];

            // Calculate output size
            RowBytes = (bitmap.Width + 7) / 8;
            // Generate body of array

            int w = bitmap.Width / 8;
            if (bitmap.Width < 8)
                w = 1;

            for (y = 0; y < bitmap.Height; y++)
            { // Each row...
                for (x = 0; x < w; x++)
                { // Each 8-pixel block within row...
                    ImageArray[x, y] = 0;
                    for (n = 0; n < 8; n++)
                    { // Each pixel within block...

                        if (x * 8 + n >= bitmap.Width)
                            continue;

                        Pixels = bitmap.GetPixel(x * 8 + n, y);
                        if (Pixels.GetBrightness() < 0.5)
                        {
                            ImageArray[x, y] += (byte)(1 << (7 - n));
                        }
                    }
                }
            }

            mMemory.WriteByte((byte)0x1d);//GS
            mMemory.WriteByte((byte)'v');
            mMemory.WriteByte((byte)'0');
            mMemory.WriteByte((byte)0);

            mMemory.WriteByte((byte)(RowBytes & 0xff));
            mMemory.WriteByte((byte)((RowBytes >> 8) & 0xff)); 
            mMemory.WriteByte((byte)(bitmap.Height & 0xff)); 
            mMemory.WriteByte((byte)((bitmap.Height >> 8) & 0xff)); 

            for (y = 0; y < bitmap.Height; y++)
            {
                for (x = 0; x < RowBytes; x++)
                {
                    mMemory.WriteByte(ImageArray[x, y]); //[d1 ..... dn]
                }
            }
            sendPkt();
        }

        public void printImage(byte mode)
        {
            mMemory.WriteByte((byte)29);//GS
            mMemory.WriteByte((byte)48);// /
            mMemory.WriteByte((byte)mode);
            sendPkt();
        }

    }
}
