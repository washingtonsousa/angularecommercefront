using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class SecGroups
    {
        public SecGroups()
        {
            SecGroupsApps = new HashSet<SecGroupsApps>();
            SecUsersGroups = new HashSet<SecUsersGroups>();
        }

        public int GroupId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SecGroupsApps> SecGroupsApps { get; set; }
        public virtual ICollection<SecUsersGroups> SecUsersGroups { get; set; }
    }
}
