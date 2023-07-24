using CheckListWindows.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckListWindows.Auxiliary
{
    class TextEditions
    {
        public static String getListText(ShowChecklistNameDto listName)
        {
            String returnString = "List: ";
            returnString += listName.checklist.name;
            returnString += " (" + listName.chkItens.ToString();
            returnString += "/" + listName.numItens.ToString() + ") ";

            return returnString;
        }

        public static String getItemText(ShowChecklistItemDto itemName)
        {
            String returnString = "\t-\tItem: ";
            returnString += itemName.checkItem.name;


            return returnString;
        }

        public static String generateLabelName(String type, int id)
        {
            if (id == 0)
            {
                return "new" + type;
            }
            else
            {
                return type + "-" + id;
            }
        }

    }
}
