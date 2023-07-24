using CheckListWindows.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckListWindows.Models
{
    class ShowChecklistItemDto
    {
        public bool isChecked { get; set; }
        public ChecklistItemDto checkItem { get; set; }
    }
}
