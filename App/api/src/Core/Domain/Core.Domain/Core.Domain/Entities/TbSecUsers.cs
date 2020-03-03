using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbSecUsers
    {
        public TbSecUsers()
        {
            TbSecUsersGroups = new HashSet<TbSecUsersGroups>();
        }

        public string Login { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pswd { get; set; }
        public string Active { get; set; }
        public string ActivationCode { get; set; }
        public string PrivAdmin { get; set; }

        public virtual ICollection<TbSecUsersGroups> TbSecUsersGroups { get; set; }
    }
}
