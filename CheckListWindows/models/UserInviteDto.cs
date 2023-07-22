using System;
using System.Collections.Generic;
using System.Text;

namespace CheckListWindows.models
{
	class UserInviteDto
	{
		public int id { get; set; }
		public String invitePinCode { get; set; }
		public DateTime createdAt { get; set; }
		public int currentCount { get; set; }
		public int maxCount { get; set; }
	}
}
