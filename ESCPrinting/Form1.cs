using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESCPrinting
{
    public partial class Form1 : Form
    {
        PrinterControl mPrinter = new PrinterControl();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ipTB.Text =
            Properties.Settings.Default.IP;

            portTB.Text = Properties.Settings.Default.Port;

        }

        private void connectB_Click(object sender, EventArgs e)
        {
            try
            {
                mPrinter.connect(ipTB.Text, int.Parse(portTB.Text));
                connectB.Enabled = false;
                disconnectB.Enabled = true;


                Properties.Settings.Default.IP = ipTB.Text;
                Properties.Settings.Default.Port = portTB.Text;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lineFeedB_Click(object sender, EventArgs e)
        {
            mPrinter.lineFeed();
        }

        private void paperCutB_Click(object sender, EventArgs e)
        {
            mPrinter.paperCut();
        }

        private void beepB_Click(object sender, EventArgs e)
        {
            mPrinter.beep();
        }

        private void alignLeftB_Click(object sender, EventArgs e)
        {
            mPrinter.alignLeft();
        }

        private void alignCenterB_Click(object sender, EventArgs e)
        {
            mPrinter.alignCenter();
        }

        private void alignRightB_Click(object sender, EventArgs e)
        {
            mPrinter.alignRight();
        }

        private void sendB_Click(object sender, EventArgs e)
        {
            mPrinter.style(true, boldCB.Checked, doubleHeightCB.Checked, doubleWidthCB.Checked, underlineCB.Checked);

            for (int i = 0; i < textTB.Lines.Length; i++)
            {
                mPrinter.printLine(textTB.Lines[i]);

                if (cbAppendLF.Checked)
                    mPrinter.lineFeed();
            }
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            textTB.Text = "";
        }

        private void chUTF8B_Click(object sender, EventArgs e)
        {
            mPrinter.sendCharset("UTF-8");
        }

        private void chCP852B_Click(object sender, EventArgs e)
        {
            mPrinter.sendCharset(((Button) sender).Text);
        }

        private void chASCIIB_Click(object sender, EventArgs e)
        {
            mPrinter.sendCharset(((Button)sender).Text);
        }

        private void disconnectB_Click(object sender, EventArgs e)
        {
            mPrinter.close();
            connectB.Enabled = true;
            disconnectB.Enabled = false;
        }

        private void chCP850B_Click(object sender, EventArgs e)
        {
            mPrinter.sendCharset(((Button)sender).Text);
        }

        private void clearImgB_Click(object sender, EventArgs e)
        {
            imgTB.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgTB.Text = openFileDialog1.FileName;
            }
        }

        private void sendImg_Click(object sender, EventArgs e)
        {
            if (imgTB.Text.Length > 0)
            {
                mPrinter.sendImage(imgTB.Text);                
            }
        }

        private void printB_Click(object sender, EventArgs e)
        {
            mPrinter.printImage(0);
        }

        private void buttonTestPrintout_Click(object sender, EventArgs e)
        {
            try
            {

                mPrinter.alignLeft();
                mPrinter.style(true, true, true, true, false);
                mPrinter.alignCenter();
                mPrinter.printLine("Example printout:");

                mPrinter.lineFeed();
                mPrinter.style(true, false, false, false, false);

                mPrinter.printLine("You can modify text aligment:");
                mPrinter.lineFeed();
                mPrinter.alignLeft();
                mPrinter.printLine("LEFT");
                mPrinter.lineFeed();
                mPrinter.alignCenter();
                mPrinter.printLine("CENTER");
                mPrinter.lineFeed();
                mPrinter.alignRight();
                mPrinter.printLine("RIGHT");
                mPrinter.lineFeed();

                mPrinter.lineFeed();
                mPrinter.alignCenter();

                mPrinter.printLine("You can modify text style:");
                mPrinter.lineFeed();
                mPrinter.style(true, true, false, false, false);
                mPrinter.printLine("BOLD");
                mPrinter.lineFeed();
                mPrinter.style(true, false, false, true, false);
                mPrinter.printLine("DOUBLE WIDTH");
                mPrinter.lineFeed();
                mPrinter.style(true, false, true, false, false);
                mPrinter.printLine("DOUBLE HEIGHT");
                mPrinter.lineFeed();
                mPrinter.style(true, false, false, false, true);
                mPrinter.printLine("UNDERLINE");
                mPrinter.lineFeed();

                mPrinter.lineFeed();
                mPrinter.style(true, false, false, false, false);
                mPrinter.alignCenter();



                if (imgTB.Text.Length > 0)
                {
                    mPrinter.printLine("You can print images:");
                    mPrinter.sendImage(imgTB.Text);
                }
                mPrinter.lineFeed();


               // mPrinter.printLine("QRCode");
               // mPrinter.lineFeed();
                //mPrinter.printQrCode("QRCode");

                //mPrinter.printBarCode("Barcode");
                //mPrinter.printLine("Barcode");
                //mPrinter.lineFeed();

                mPrinter.style(false, false, false, false, false);
                mPrinter.lineFeed();
                mPrinter.alignLeft();
                mPrinter.paperCut();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClearQrcode_Click(object sender, EventArgs e)
        {
            textBoxQRcode.Clear();
        }

        private void buttonClearBarcode_Click(object sender, EventArgs e)
        {
            textBoxBarcode.Clear();
        }

        private void buttonSendQRCode_Click(object sender, EventArgs e)
        {
            mPrinter.printQrCode(textBoxQRcode.Text);
        }

        private void buttonSendBarcode_Click(object sender, EventArgs e)
        {
            mPrinter.printBarCode(textBoxBarcode.Text);
        }
    }
}
