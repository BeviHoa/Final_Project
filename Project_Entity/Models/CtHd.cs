using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Entity.Models
{
    public partial class CtHd
    {
        public int Id { get; set; }
        public int MaHoaDon { get; set; }
        public int MaSp { get; set; }
        public DateTime Ngayban { get; set; }
        public int Soban { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien { get; set; }

        public virtual Hoadon MaHoaDonNavigation { get; set; }
        public virtual Douong MaSpNavigation { get; set; }
        public virtual Ban SobanNavigation { get; set; }
    }
}
