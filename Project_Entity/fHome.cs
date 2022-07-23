using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Project_Entity.DataAccess;
using Project_Entity.Logics;
using Project_Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Entity
{
    public partial class fHome : Form
    {

        public static int TableWidth = 125;
        public static int TableHeight = 125;
        private object db;

        public fHome()
        {
            InitializeComponent();
            formLoad();
        }

        private void formLoad()
        {
            flowLayoutPanel1.Controls.Clear();
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            List<Ban> Table = context.Bans.ToList<Ban>();
            foreach (var item in Table)
            {
                Button btn = new Button() { Width = TableWidth, Height = TableWidth};
                btn.Click += btn_Click;
                idban = item.Soban;
                btn.Tag = item;
                Random random = new Random();
                btn.Location = new Point(random.Next(0, TableHeight), TableHeight);
                btn.Text = "Bàn " + item.Soban + Environment.NewLine + item.Tinhtrang;
                if (item.Tinhtrang.Equals("Trống"))
                {
                    btn.BackColor = Color.White;
                }
                else
                {
                    btn.BackColor = Color.DeepSkyBlue;
                }
                flowLayoutPanel1.Controls.Add(btn);
            }
        }



        void ShowBill(int id)
        {
            listView1.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            
            float totalPrice = 0;
            foreach(Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                listView1.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("en-US");

            txbTotalPrice.Text = totalPrice.ToString("c",culture);
        }

        

        private void btn_Click(object? sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Ban).Soban;
            this.idban = tableID;
            listView1.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        



        public List<Button> GetButtonTable()
        {
            List<Button> list = new List<Button>();
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            List<Ban> Table = context.Bans.ToList();
            foreach (var item in Table)
            {
                Button btn = new Button();
                btn.Text = "Bàn " + item.Soban + Environment.NewLine + item.Tinhtrang;
                
                if (item.Tinhtrang.Equals("Trống"))
                {
                    btn.BackColor = Color.White;
                }
                else
                {
                    btn.BackColor = Color.Red;
                }
                btn.Tag = item.Soban.ToString();
                btn.Text = item.Tinhtrang.ToString();
                btn.Tag = item.Tinhtrang.ToString();
                flowLayoutPanel1.Controls.Add((Button)btn);
                btn.Controls.Add(btn);
                list.Add(btn);  
            }
            return list;
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            List<Button> list = GetButtonTable();
            foreach (var item in list)
            {
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        private int idban { get; set; }

        

       

        //Category




        private void fHome_Load(object sender, EventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            cbFood.DataSource = context.Douongs.Select(x => x.Tendouong).Distinct().ToList();
            if (Account.role == 0)
            {
                btFoodManager.Visible = false;
                btManagerAccount.Visible = false;
                btNhanVien.Visible = false;
                btManagerTable.Visible = false;
                btDeleteTable.Visible = false;
            }
          
            
                
            
            
        }


        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            

            
        }

        private void btControl_Click(object sender, EventArgs e)
        {
            fStaff staff = new fStaff();
            
            staff.ShowDialog();
        }


        private void btFoodManager_Click(object sender, EventArgs e)
        {

                fFoodManager fFoodManager = new fFoodManager();
                fFoodManager.ShowDialog();
                fFoodManager.Hide();
            
        }

        private void btManagerAccount_Click(object sender, EventArgs e)
        {
           
            fRegister fRegister = new fRegister();
            fRegister.ShowDialog();
            fRegister.Hide();
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            Douong d = new Douong();
            int MaHoaDon = context.Hoadons.Where(x => x.Soban == idban).FirstOrDefault().Id;
            int MaSP = context.Douongs.Where(x => x.Tendouong.Equals(cbFood.Text)).FirstOrDefault().Id;
            DateTime Ngay = DateTime.Now;
            
            int SoLuong = (int)numericUpDown1.Value;
            float DonGia = (float)context.Douongs.Where(x => x.Tendouong.Equals(cbFood.Text)).FirstOrDefault().Giatien;
            
            
            
            CtHd ctHd = new CtHd();
            ctHd.Soban = idban;
            ctHd.MaHoaDon = MaHoaDon;
            ctHd.MaSp = MaSP;
            ctHd.Ngayban = Ngay;
            ctHd.SoLuong = SoLuong;
            ctHd.DonGia = DonGia;
            ctHd.ThanhTien = DonGia * SoLuong;
            numericUpDown1.Maximum = d.Soluong;
            if (d.Soluong < numericUpDown1.Value)
            {
                MessageBox.Show("Out of stock!");
            }
            else
            {
                context.CtHds.Add(ctHd);
                context.SaveChanges();




                Ban b = context.Bans.Find(idban);
                b.Tinhtrang = "Có người";
                context.Bans.Update(b);
                context.SaveChanges();
                formLoad();
                ShowBill(ctHd.Soban);
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btPayment_Click(object sender, EventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            List<CtHd> ctHd = context.CtHds.Where(x => x.Soban == idban).ToList();
            foreach(CtHd item in ctHd)
            {
                context.CtHds.Remove(item);
               
            }
            context.SaveChanges();
            MessageBox.Show("Bạn thanh toán thành công");
            Ban b = context.Bans.Find(idban);
            b.Tinhtrang = "Trống";
            context.Bans.Update(b);
            context.SaveChanges();
            formLoad();



            ShowBill(idban);
            
        }

        private void btManagerTable_Click(object sender, EventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            Ban b = new Ban();
            b.Soban = context.Bans.Select(x => x.Soban).Max() + 1;
            b.Tinhtrang = "Trống";
            context.Bans.Add(b);
            context.SaveChanges();
            Hoadon h = new Hoadon();
            h.Soban = b.Soban;
            context.Hoadons.Add(h);
            context.SaveChanges();
            formLoad();
        }

        private void btDeleteTable_Click(object sender, EventArgs e)
        {

            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            Ban b = context.Bans.Find(idban);
            
            
            context.Bans.Remove(b);
            context.SaveChanges();
            formLoad();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
