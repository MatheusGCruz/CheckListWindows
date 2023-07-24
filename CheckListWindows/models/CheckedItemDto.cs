using System;
using System.Collections.Generic;
using System.Text;

namespace CheckListWindows.models
{
    class CheckedItemDto
    {
		public int id { get; set; }
		public int checklistItemId { get; set; }
		public int checklistId { get; set; }
		public int userId { get; set; }
		public DateTime checkedAt { get; set; }
		public int isPermanent { get; set; }
	}
}
