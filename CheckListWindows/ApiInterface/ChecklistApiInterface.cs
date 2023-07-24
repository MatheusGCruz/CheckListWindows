using CheckListWindows.models;
using CheckListWindows.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckListWindows.ApiInterface
{
    class ChecklistApiInterface
    {
        public static List<ShowChecklistNameDto> getListNames()
        {
            List<ShowChecklistNameDto> listNames = new List<ShowChecklistNameDto>();

            for(int i = 1; i <= 5; i++)
            {
                ShowChecklistNameDto mockShowList = new ShowChecklistNameDto();
                ChecklistNameDto mockListName = new ChecklistNameDto();
                mockListName.id = i;
                mockListName.name = "List " + i.ToString();

                mockShowList.chkItens = 1;
                mockShowList.numItens = 5;
                mockShowList.isActive = false;
                mockShowList.checklist = mockListName;

                listNames.Add(mockShowList);
            }

            return listNames;
        }

        public static List<ShowChecklistItemDto> getListItens(int listId)
        {
            List<ShowChecklistItemDto> showChecklistItems = new List<ShowChecklistItemDto>();
            for (int i = 1; i <= 5; i++)
            {
                ShowChecklistItemDto showChecklistItem = new ShowChecklistItemDto();
                ChecklistItemDto mockListItem = new ChecklistItemDto();
                mockListItem.id = i;
                mockListItem.name = "Item " + i.ToString();
                mockListItem.checklistId = listId;
                showChecklistItem.checkItem = mockListItem;

                showChecklistItems.Add(showChecklistItem);
            }

            return showChecklistItems;
        }

        public static List<CheckedItemDto> GetCheckedItems(int listId)
        {
            List<CheckedItemDto> listItens = new List<CheckedItemDto>();
            for (int i = 1; i <= 5; i++)
            {
                CheckedItemDto mockcheckedItem = new CheckedItemDto();
                mockcheckedItem.id = i;
                mockcheckedItem.checklistItemId = i;
                mockcheckedItem.checklistId = listId;
                listItens.Add(mockcheckedItem);
            }

            return listItens;
        }


        public static List<ShowChecklistNameDto> getMineListNames()
        {
            List<ShowChecklistNameDto> listNames = new List<ShowChecklistNameDto>();

            for (int i = 1; i <= 5; i++)
            {
                ShowChecklistNameDto mockShowList = new ShowChecklistNameDto();
                ChecklistNameDto mockListName = new ChecklistNameDto();
                mockListName.id = i;
                mockListName.name = "List " + i.ToString();

                mockShowList.chkItens = 1;
                mockShowList.numItens = 5;
                mockShowList.isActive = false;
                mockShowList.checklist = mockListName;

                listNames.Add(mockShowList);
            }

            return listNames;
        }
    }
}
