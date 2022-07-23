using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Entity.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Catrucs = new HashSet<Catruc>();
        }

        public int Manv { get; set; }
        public string Tenhanvien { get; set; }
        public string Gioitinh { get; set; }
        public string Dienthoai { get; set; }

        public virtual ICollection<Catruc> Catrucs { get; set; }
    }
}
