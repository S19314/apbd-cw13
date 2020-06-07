using System;
using System.Collections.Generic;

namespace Przykladowy_kolos_2_version_DbFirst.Models
{
    public partial class Project
    {
        public Project()
        {
            Task = new HashSet<Task>();
        }

        public int IdProject { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }

        public virtual ICollection<Task> Task { get; set; }
    }
}
