using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Entity.Logics
{
    public class Bill
    {
        private int iD;
        private int soban;
 

        public Bill()
        {
        }

        
        public Bill(int iD, int soban)
        {
            this.ID = iD;
            this.Soban = soban;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Soban = (int)row["soban"];
        }

        public int ID { get => iD; set => iD = value; }
        public int Soban { get => soban; set => soban = value; }
    }
}
