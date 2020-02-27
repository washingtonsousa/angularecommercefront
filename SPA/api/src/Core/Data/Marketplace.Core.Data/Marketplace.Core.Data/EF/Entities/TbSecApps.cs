using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbSecApps
    {
        public TbSecApps()
        {
            TbSecGroupsApps = new HashSet<TbSecGroupsApps>();
        }

        public string AppName { get; set; }
        public string AppType { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TbSecGroupsApps> TbSecGroupsApps { get; set; }
    }
}
