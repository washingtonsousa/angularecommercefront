using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class SecGroupsApps
    {
        public int GroupId { get; set; }
        public string AppName { get; set; }
        public string PrivAccess { get; set; }
        public string PrivInsert { get; set; }
        public string PrivDelete { get; set; }
        public string PrivUpdate { get; set; }
        public string PrivExport { get; set; }
        public string PrivPrint { get; set; }

        public virtual SecApps AppNameNavigation { get; set; }
        public virtual SecGroups Group { get; set; }
    }
}
