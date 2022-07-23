using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Entity.Models
{
    public partial class Hoadon
    {
        public Hoadon()
        {
            CtHds = new HashSet<CtHd>();
        }

        public int Id { get; set; }
        public int Soban { get; set; }

        public virtual Ban SobanNavigation { get; set; }
        public virtual ICollection<CtHd> CtHds { get; set; }
    }
}
