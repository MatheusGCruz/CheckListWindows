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

        private static Font resetFont(Font font)
        {
            return new Font(font, FontStyle.Regular);
        }
        private static Font setItalic(Font font)
        {
            return new Font(font, FontStyle.Italic);
        }
        private static Font setBold(Font font)
        {
            return new Font(font, FontStyle.Bold);
        }
        private static Font setStrikeout(Font font)
        {
            return new Font(font, FontStyle.Strikeout);
        }
        private static Font setUnderscore(Font font)
        {
            return new Font(font, FontStyle.Underline);
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

        public static Font itemChange(Font font, int itemId, bool isChecked, bool isActiveItem)
        {
            font = resetFont(font);
            if (itemId == 0)
            {
                return font;
            }
            if (isActiveItem)
            {
                font = setBold(font);
            }
            if (isChecked)
            {
                font = setStrikeout(font);
            }
            return font;
        }



    }
}
