using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe_FormNew
{
    public partial class QuanLyQuanCafe : Form
    {
        private string username;
        public QuanLyQuanCafe(string userName)
        {
            InitializeComponent();
            this.username = userName;
        }
        public bool EnableKH { get ; set; }
        public bool EnableAdmin { get; set; }
        private void QuanLyQuanCafe_Load(object sender, EventArgs e)
        {
            taiKhoan1.Visible = false;
            BT_QLChung.PerformClick();

            BT_TTTK.Enabled = EnableKH;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_QLChung_Click(object sender, EventArgs e)
        {
            qL_BanCF1.Visible = true;
            qL_BanCF1.BringToFront();
        }
        private void BT_TTTK_Click(object sender, EventArgs e)
        { 
            QuenMK formQuenMK = new QuenMK(username);
            this.Hide();
            formQuenMK.ShowDialog();
            this.Show();
        }
        private void BT_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Admin_Click(object sender, EventArgs e)
        {
           
        }
        
    }
}
