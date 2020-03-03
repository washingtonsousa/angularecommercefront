using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbLog
    {
        public int Id { get; set; }
        public DateTime InsertedDate { get; set; }
        public string Username { get; set; }
        public string Application { get; set; }
        public string Creator { get; set; }
        public string IpUser { get; set; }
        public string Action { get; set; }
        public string Description { get; set; }
    }
}
