using Project_Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Entity
{
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
        }

       

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataForDGV()
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            dataGridView1.DataSource = context.Nhanviens.ToList();
            dataGridView1.Columns["Catrucs"].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();    
        }

        private void fStaff_Load(object sender, EventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            LoadDataForDGV();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txbId.Text = row.Cells[0].Value.ToString();
                txbName.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString().Equals("Girl"))
                {
                    rbGirl.Checked = true;
                }
                else
                {
                    rbBoy.Checked = true;
                }
                txbPhone.Text = row.Cells[3].Value.ToString();
            }
        }

        private Nhanvien GetNhanvienInfo()
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            Nhanvien s = new Nhanvien();
            if (txbId.Text.Equals(""))
            {
                s.Manv = context.Nhanviens.Select(x => x.Manv).Max()+1;

            }
            else
            {
                s.Manv = int.Parse(txbId.Text.Trim());
            }
            
            s.Tenhanvien = txbName.Text.Trim();
            
            s.Gioitinh = rbGirl.Text.Trim();

            s.Dienthoai = txbPhone.Text.ToString();
            
            return s;
        }
        
        private void btAdd_Click(object sender, EventArgs e)
        {
            
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            
            Nhanvien s = GetNhanvienInfo();
            s.Manv = context.Nhanviens.Select(x => x.Manv).Max() + 1;
            Nhanvien s1 = context.Nhanviens.Where(x => x.Tenhanvien.Equals(txbName.Text) || x.Dienthoai.Equals(txbPhone.Text)).FirstOrDefault();
            if(s1 != null)
            {
                MessageBox.Show("Constain Name or Phone");
                LoadDataForDGV();
                return;
            }
            if (txbName.Text == "")
            {
                MessageBox.Show("Name not null");
            }
            else
            {
                context.Nhanviens.Add(s);
                context.SaveChanges();
                LoadDataForDGV();
            }
            
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbId.Text);
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            Nhanvien n = context.Nhanviens.Find(id);

            n.Tenhanvien = txbName.Text.Trim();
            n.Gioitinh = rbBoy.Checked ? "Boy" : "Girl";
            n.Dienthoai = txbPhone.Text.Trim();
            context.Nhanviens.Update(n);
            context.SaveChanges();
            LoadDataForDGV();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            Nhanvien s = GetNhanvienInfo();
            context.Nhanviens.Remove(s);
            context.SaveChanges();
            LoadDataForDGV();
        }
    }
}
