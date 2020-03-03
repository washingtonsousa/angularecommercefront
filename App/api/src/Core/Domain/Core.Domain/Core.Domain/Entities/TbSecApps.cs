﻿using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
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
