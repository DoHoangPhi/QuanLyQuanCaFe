using System;
using QuanLyCafe_FormNew.DAO;
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
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_DK_Click(object sender, EventArgs e)
        {
            //string userName = txt_TKH.Text;
            //string password = Password_txt.Text;

            //// Kiểm tra thông tin đăng ký không được để trống
            //if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            //{
            //    MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng ký.", "Thông báo", MessageBoxButtons.OK);
            //    return;
            //}
            //DataProvider provider = new DataProvider();
            //string query = $"EXEC AddLoginAccount @MAKH = N'{txt_TKH.Text}', @PASSKH = N'{Password_txt.Text}' ";
            //DataTable result = provider.ExecuteQuery(query);
            //// Xóa dữ liệu đã nhập trong các trường thông tin
            //txt_TKH.Clear();
            //Password_txt.Clear();

            string userName = txt_TKH.Text;
            string password = Password_txt.Text;

            // Kiểm tra thông tin đăng ký không được để trống
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng ký.", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            DataProvider provider = new DataProvider();

            // Kiểm tra MAKH đã tồn tại trong SQL
            string checkQuery = $"SELECT COUNT(*) FROM KHACHHANG WHERE MAKH = N'{userName}'";
            int count = Convert.ToInt32(provider.ExecuteScaler(checkQuery));
            if (count > 0)
            {
                MessageBox.Show("Tài khoản này đã được sử dụng.", "Thông báo", MessageBoxButtons.OK);
                // Xóa dữ liệu đã nhập trong các trường thông tin
                txt_TKH.Clear();
                Password_txt.Clear();
                return;
            }

            // Thực hiện thêm tài khoản
            string query = $"EXEC AddLoginAccount @MAKH = N'{userName}', @PASSKH = N'{password}'";
            int result = provider.ExecuteNonQuery(query);

            // Kiểm tra kết quả thêm tài khoản
            if (result > 0)
            {
                MessageBox.Show("Đăng ký thành công.", "Thông báo", MessageBoxButtons.OK);
                Login formLogin = new Login();
                formLogin.Show();
            }
            else
            {
                MessageBox.Show("Đăng ký không thành công.", "Thông báo", MessageBoxButtons.OK);
            }

            // Xóa dữ liệu đã nhập trong các trường thông tin
            txt_TKH.Clear();
            Password_txt.Clear();
        }
       

        private void txt_TKH_TextChanged(object sender, EventArgs e)
        {
            if (!txt_TKH.Text.Contains("KH"))
            {
                // Thêm chuỗi "KH" vào đầu TextBox
                txt_TKH.Text = "KH" + txt_TKH.Text;

                // Di chuyển con trỏ về cuối TextBox
                txt_TKH.SelectionStart = txt_TKH.Text.Length;
            }
        }

        private void DangKi_Load(object sender, EventArgs e)
        {

        }

        private void DangKi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
