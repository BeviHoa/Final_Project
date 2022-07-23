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
    public partial class fRegister : Form
    {
        public fRegister()
        {
            InitializeComponent();
        }


        private User GetUserInfo()
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            User u = new User();
            u.Name = txbName.Text.Trim();
            u.UserName = txbUser.Text.Trim();
            u.Password = txbUser.Text.Trim();
            u.Priority = rbStaff.Checked ? 1 : 0;
            return u;
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            User u = GetUserInfo();
            if (u.UserName.Equals(txbUser.Text.Trim()))
            {
                MessageBox.Show("UserName exist");
                fRegister fRegister = new fRegister();
                fRegister.Show();
            }
            else
            {
                context.Users.Add(u);
                context.SaveChanges();
                MessageBox.Show("Add Thành công");
                
            }
            

        }
    }
}
