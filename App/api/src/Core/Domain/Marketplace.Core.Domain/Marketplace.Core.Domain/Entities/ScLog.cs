using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class ScLog
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
