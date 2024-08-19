using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe_FormNew.All_User_Controlls
{
    public partial class Loading : UserControl
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //public Timer timer1 = new Timer();
        public void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 10;
            if (panel1.Width >= 599)
            {
                timer1.Stop();  
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }
    }
}
