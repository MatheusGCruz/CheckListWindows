using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CheckListWindows.Auxiliary
{
    class FontsEdits
    {
        private static Font simpleFont(Font font)
        {
            return new Font(font, FontStyle.Regular);
        }

        private static Font underscoreFont(Font font)
        {
            return new Font(font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
        }

        private static Font newItemFont(Font font)
        {
            return new Font(font, FontStyle.Italic);
        }

        public static Font newItemBoldFont(Font font)
        {
            return new Font(font, FontStyle.Italic | FontStyle.Bold);
        }

        public static Font strikedItalic(Font font)
        {
            return new Font(font, FontStyle.Italic | FontStyle.Strikeout);
        }



        public static Font listChange(Font font, bool isActive, int listId, bool isCompleted)
        {
            if(listId == 0)
            {
                return newItemFont(font);
            }
            if (isActive)
            {
                return underscoreFont(font);
            }
            if (isCompleted)
            {
                return strikedItalic(font);
            }
            return simpleFont(font);
        }

        public static Font itemChange(Font font, int itemId, bool isChecked)
        {
            if (itemId == 0)
            {
                return newItemFont(font);
            }
            if (isChecked)
            {
                return strikedItalic(font);
            }
            return simpleFont(font);
        }



    }
}
