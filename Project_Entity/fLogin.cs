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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            string user = tbUser.Text.Trim();
            string pass = tbPass.Text.Trim();
            User u = context.Users.Where(x => x.UserName == user && x.Password == pass).FirstOrDefault();   

           

            if(user == string.Empty && pass == string.Empty)
            {
                MessageBox.Show("Rỗng");
            }
            var CorrectAccount = context.Users.FirstOrDefault(x => x.UserName.Equals(tbUser.Text));

            if(CorrectAccount != null)
            {
                if (CorrectAccount.Password.Equals(tbPass.Text))
                {
                    Account.role = (int)u.Priority;
                    fHome home = new fHome();
                    this.Hide();
                    home.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Mật khẩu sai");
                } 
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit???", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            } 
                
        }
    }
}
