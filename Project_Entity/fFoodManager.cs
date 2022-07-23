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
    public partial class fFoodManager : Form
    {
        public fFoodManager()
        {
            InitializeComponent();
        }
        public int id;
        private void LoadDataForDGV()
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            dataGridView1.DataSource = context.Douongs.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txbId.Text = row.Cells[0].Value.ToString();
                this.id = int.Parse(txbId.Text);
                txbName.Text = row.Cells[1].Value.ToString();
                txbNotes.Text = row.Cells[2].Value.ToString();
                txbAmount.Text = row.Cells[3].Value.ToString();
                txbPrice.Text = row.Cells[4].Value.ToString();
            }
        }

        private void fFoodManager_Load(object sender, EventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            LoadDataForDGV();
        }

        private Douong GetDouongInfo()
        {
            Douong douong = new Douong();
            //if (txbId.Text != null && !string.IsNullOrWhiteSpace(txbId.Text))
            //{
            //    douong.Id = Convert.ToInt32(txbId.Text);
            //}
            douong.Tendouong = txbName.Text.Trim();

            douong.Ghichu = txbNotes.Text.Trim();

            douong.Soluong = Convert.ToInt32(txbAmount.Text.Trim());

            douong.Giatien = Convert.ToInt32(txbPrice.Text.Trim());

            return douong;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            Douong u =GetDouongInfo();
            context.Douongs.Add(u);
            context.SaveChanges();
            LoadDataForDGV();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();

            Douong n = context.Douongs.Find(id);
            //n.Id = u.Id;
            n.Tendouong = txbName.Text.Trim();
            n.Soluong = int.Parse(txbAmount.Text.Trim());
            n.Giatien = int.Parse(txbPrice.Text.Trim());
            n.Ghichu = txbNotes.Text.Trim();
            context.Douongs.Update(n);
            context.SaveChanges();
            LoadDataForDGV();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            Douong u = context.Douongs.Find(id);
            context.Douongs.Remove(u);
            context.SaveChanges();
            LoadDataForDGV();
        }
    }
}
