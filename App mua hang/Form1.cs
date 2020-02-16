using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_mua_hang
{
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void adminLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Xử lý sự kiện khi ấn vào dấu "X" bên trên thanh công cụ.
            if(MessageBox.Show("Are you really want to close program ?", "WARNING !", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        public void Contact()
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/kalisdepasooo");
        }

        private void contactClick(object sender, EventArgs e)
        {
            Contact();
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi ấn login
            MainAppForAdmin mAFD = new MainAppForAdmin();
            this.Hide();
            mAFD.ShowDialog();
            this.Show();
        }
    }
}
