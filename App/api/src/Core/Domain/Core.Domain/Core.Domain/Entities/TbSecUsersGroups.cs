using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbSecUsersGroups
    {
        public string Login { get; set; }
        public int GroupId { get; set; }

        public virtual TbSecGroups Group { get; set; }
        public virtual TbSecUsers LoginNavigation { get; set; }
    }
}
