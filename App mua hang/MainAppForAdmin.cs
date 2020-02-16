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
    public partial class MainAppForAdmin : Form
    {
        //int panelWidth;
        //bool Hidden;

        public MainAppForAdmin()
        {
            InitializeComponent();
            //panelWidth = viewMenu.Width;
            //Hidden = false;
        }

        /*private void timer1_Tick(object sender, EventArgs e)
        {
            if(Hidden)
            {
                panelSlide.Width = panelSlide.Width + 10;
                if(panelSlide.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelSlide.Width = panelSlide.Width - 10;
                if(panelSlide.Width < 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        //private void viewMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }*/
    }
}
