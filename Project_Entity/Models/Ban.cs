using System;
using System.Collections.Generic;
using System.Data;

#nullable disable

namespace Project_Entity.Models
{
    public partial class Ban
    {

        
        public Ban()
        {
            CtHds = new HashSet<CtHd>();
            Hoadons = new HashSet<Hoadon>();
        }
        
       
        

        public int Soban { get; set; }
        public string Tinhtrang { get; set; }

        public virtual ICollection<CtHd> CtHds { get; set; }
        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
