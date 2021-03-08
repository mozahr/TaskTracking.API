using System;
using System.Collections.Generic;
using System.Text;

namespace TT.Core.Domain
{
    public class Task: BaseEntity
    {
        public string Title { get; set; }
        public string Details { get; set; }
        public string Assignee_Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
