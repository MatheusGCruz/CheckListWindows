using System;
using System.Collections.Generic;
using System.Text;

namespace CheckListWindows.models
{
    class ChecklistTokenDto
    {
		public int id { get; set; }
		public int userId { get; set; }
		public String token { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime expiresAt { get; set; }
	}
}
