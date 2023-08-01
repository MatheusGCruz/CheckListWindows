using System;

namespace CheckListWindows.Models
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
