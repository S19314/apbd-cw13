using System;
using System.Collections.Generic;

namespace Przykladowy_kolos_2_version_DbFirst.Models
{
    public partial class TeamMember
    {
        public TeamMember()
        {
            TaskIdAssignedToNavigation = new HashSet<Task>();
            TaskIdCreatorNavigation = new HashSet<Task>();
        }

        public int IdTeamMember { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Task> TaskIdAssignedToNavigation { get; set; }
        public virtual ICollection<Task> TaskIdCreatorNavigation { get; set; }
    }
}
