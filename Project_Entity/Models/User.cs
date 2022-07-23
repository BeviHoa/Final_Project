using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Entity.Models
{
    public partial class User
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? Priority { get; set; }
    }
}
