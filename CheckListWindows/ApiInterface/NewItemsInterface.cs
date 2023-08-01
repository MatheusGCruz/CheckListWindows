using CheckListWindows.Models;

namespace CheckListWindows.ApiInterface
{
    class NewItemsInterface
    {
        public static ShowChecklistNameDto addChecklistNameDto()
        {
            ShowChecklistNameDto showChecklistName = new ShowChecklistNameDto();
            ChecklistNameDto newChecklistName = new ChecklistNameDto();
            newChecklistName.name = "Add new list";
            newChecklistName.id = 0;
            showChecklistName.checklist = newChecklistName;

            return showChecklistName;
        }

        internal static ShowChecklistItemDto addChecklistItemDto()
        {
            ShowChecklistItemDto showChecklistItem = new ShowChecklistItemDto();
            ChecklistItemDto newChecklistItem = new ChecklistItemDto();
            newChecklistItem.name = "Add new item";
            newChecklistItem.id = 0;
            showChecklistItem.checkItem = newChecklistItem;

            return showChecklistItem;
        }
    }
}
