using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCPrinting
{
    class ControlChars
    {
        static public byte Ch_ENQ = ((byte)0x05);
        static public byte Ch_BEL = ((byte)0x07);
        static public byte Ch_CR = ((byte)0x0D);
        static public byte Ch_DLE = ((byte)0x10);
        static public byte Ch_CAN = ((byte)0x18);
        static public byte Ch_ESC = ((byte)0x1B);
        static public byte Ch_RS = ((byte)0x1E);
        static public byte Ch_SP = ((byte)0x20);
        static public byte Ch_Semiclon = ((byte)';');
        static public byte Ch_Slash = ((byte)'/');
        static public byte Ch_BSlash = ((byte)'\\');
        static public byte Ch_PBegin = ((byte)'P');
        static public byte Ch_FF = ((byte)0xFF);
    }
}
