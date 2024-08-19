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
    public partial class TaiKhoan : UserControl
    {
        public TaiKhoan()
        {
            InitializeComponent();

        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            
        }
        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }
    } 
}
