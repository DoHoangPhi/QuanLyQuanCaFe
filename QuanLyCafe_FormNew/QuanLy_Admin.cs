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
    public partial class QuanLy_Admin : Form
    {
        public QuanLy_Admin()
        {
            InitializeComponent();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void qL_NhanVien1_Load(object sender, EventArgs e)
        {

        }

        private void qL_NhanVien1_Load_1(object sender, EventArgs e)
        {
            qL_NhanVien1.Visible = true;
            qL_ThucDon1.Visible = false;
            qL_KhachHang1.Visible = false;
            hoaDon1.Visible = false;
            thongke_DoanhThu1.Visible = false;
            qL_TaiKhoan1.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            qL_NhanVien1.Visible = true;
            qL_NhanVien1.BringToFront();
        }

        private void BT_QLChung_Click(object sender, EventArgs e)
        {
            qL_ThucDon1.Visible = true;
            qL_ThucDon1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            qL_KhachHang1.Visible = true;
            qL_KhachHang1.BringToFront();
        }

        private void thongke_DoanhThu1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            hoaDon1.Visible = true;
            hoaDon1.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            thongke_DoanhThu1.Visible = true;
            thongke_DoanhThu1.BringToFront();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            //QuanLy_Admin frmAD = new QuanLy_Admin();
            //frmAD.Show();
            this.Close();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            qL_TaiKhoan1.Visible = true;
            qL_TaiKhoan1.BringToFront();
        }

        private void QuanLy_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
