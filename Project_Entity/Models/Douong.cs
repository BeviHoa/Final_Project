using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Entity.Models
{
    public partial class Douong
    {
        public Douong()
        {
            CtHds = new HashSet<CtHd>();
        }

        public int Id { get; set; }
        public string Tendouong { get; set; }
        public string Ghichu { get; set; }
        public int Soluong { get; set; }
        public double Giatien { get; set; }

        public virtual ICollection<CtHd> CtHds { get; set; }
    }
}
