using Project_Entity.Logics;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Entity.DataAccess
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; } 
            set { MenuDAO.instance = value; }
        
        }
        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "select d.tendouong, ct.SoLuong, d.giatien, d.giatien*ct.SoLuong as totalPrice from hoadon as h, ct_hd as ct, douong as d where ct.soban = h.soban and ct.MaSP = d.ID and h.soban = "+id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
