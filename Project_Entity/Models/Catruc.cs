using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Entity.Models
{
    public partial class Catruc
    {
        public int Id { get; set; }
        public string Ca { get; set; }
        public DateTime? Ngaytruc { get; set; }
        public int? Idnhanvien { get; set; }

        public virtual Nhanvien IdnhanvienNavigation { get; set; }
    }
}
