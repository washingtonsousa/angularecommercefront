using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class SecApps
    {
        public SecApps()
        {
            SecGroupsApps = new HashSet<SecGroupsApps>();
        }

        public string AppName { get; set; }
        public string AppType { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SecGroupsApps> SecGroupsApps { get; set; }
    }
}
