using System;
using System.Collections.Generic;
using System.Text;

namespace CheckListWindows.models
{
    class ChecklistItemDto
    {
		public int id { get; set; }
		public int checklistId { get; set; }
		public String name { get; set; }
		public DateTime? createdAt { get; set; }
		public DateTime? endedAt { get; set; }
		public int  isPermanent { get; set; }
		public int  ownerId { get; set; }
	}
}
