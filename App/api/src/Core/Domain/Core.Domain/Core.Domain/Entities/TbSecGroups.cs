using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbSecGroups
    {
        public TbSecGroups()
        {
            TbSecGroupsApps = new HashSet<TbSecGroupsApps>();
            TbSecUsersGroups = new HashSet<TbSecUsersGroups>();
        }

        public int GroupId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TbSecGroupsApps> TbSecGroupsApps { get; set; }
        public virtual ICollection<TbSecUsersGroups> TbSecUsersGroups { get; set; }
    }
}
