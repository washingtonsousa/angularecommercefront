using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
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
