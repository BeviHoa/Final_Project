using Project_Entity.Logics;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Entity.DataAccess
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance 
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; } 
            private set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO() { }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM ct_hd where MaHoaDon = " + id);
            foreach(DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }
        public void InsertBillInfo(int ID, int MaHoaDon, int MaSP, DateTime ngayban, int soban, int SoLuong, int DonGia, int ThanhTien)
        {
            DataProvider.Instance.ExcuteNonQuery("USP_InsertBillInfo @ID int, @MaHoaDon int, @MaSP int, @ngayban date, @soban int, @SoLuong int, @DonGia int, @ThanhTien int", new object[] { ID,  MaHoaDon,  MaSP,  ngayban,  soban,  SoLuong,  DonGia,  ThanhTien });
        }
    }
}
