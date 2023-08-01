using System;

namespace CheckListWindows.Models
{
    class CheckedItemDto
    {
		public int id { get; set; }
		public int checklistItemId { get; set; }
		public int checklistId { get; set; }
		public int userId { get; set; }
		public DateTime checkedAt { get; set; }
		public int isPermanent { get; set; }
		public string name { get; set; }
	}
}
