using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class SecUsersGroups
    {
        public string Login { get; set; }
        public int GroupId { get; set; }

        public virtual SecGroups Group { get; set; }
        public virtual SecUsers LoginNavigation { get; set; }
    }
}
