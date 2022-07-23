using Project_Entity.Logics;
using Project_Entity.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Entity.DataAccess
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance 
        { 
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; } 
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }
        
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from hoadon where soban = " + id);
            if(data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Soban;
            }
            return -1;
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExcuteNonQuery("exec USP_InsertBill @idBan", new object[] { id });

        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select MAX(ID) from hoadon");
            }
            catch
            {
                return 1;
            }
           
        }
    }
}
