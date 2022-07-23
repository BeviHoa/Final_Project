using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Entity.Models
{
    public partial class Thongke
    {
        public int Id { get; set; }
        public string TenSanPham { get; set; }
        public int? Soluong { get; set; }
        public DateTime? Ngaylap { get; set; }
        public double? Doanhthu { get; set; }
    }
}
