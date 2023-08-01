using System;


namespace CheckListWindows.Models
{
    class AuthUserDto
    {
		public int id { get; set; }
		public String username { get; set; }
		public String password { get; set; }
		public DateTime createdAt { get; set; }
		public int isActive { get; set; }
	}
}
