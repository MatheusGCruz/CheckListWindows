using System;
using System.Collections.Generic;
using System.Text;

namespace CheckListWindows.Auxiliary
{
    class Symbols
    {
        public static String getCheckMark()
        {
            return ((char)0x2714).ToString();
        }

        public static String getCloseMark()
        {
            return ((char)0x0158).ToString();
        }
    }
}
