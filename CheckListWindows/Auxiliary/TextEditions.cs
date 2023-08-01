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
            String returnString = "";
            if (listName.checklist.id >0)
            {
                returnString = "List: ";
                returnString += listName.checklist.name;
                returnString += " (" + listName.chkItens.ToString();
                returnString += "/" + listName.numItens.ToString() + ") ";
            }
            else
            {
                returnString += listName.checklist.name;
            }
            

            return returnString;
        }

        public static String getItemText(ShowChecklistItemDto itemName)
        {
            String returnString = "\t-\t";
            if(itemName.checkItem.id > 0)
            {
                returnString += "Item: ";
            }           

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
