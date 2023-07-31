using CheckListWindows.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckListWindows.Models
{
    class ShowChecklistNameDto
    {
        public bool isActive { get; set; }
        public ChecklistNameDto checklist {get; set;}
        public int numItens { get; set; }
        public int chkItens { get; set; }
        public bool isCompleted { get; set; }
        public bool isOwned { get; set; }

    }
}
