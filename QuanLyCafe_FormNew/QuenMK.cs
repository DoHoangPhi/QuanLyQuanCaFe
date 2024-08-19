
using QuanLyCafe_FormNew.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyCafe_FormNew
{
    public partial class QuenMK : Form
    {
        private string username;

        public QuenMK(string username)
        {
            InitializeComponent();
            this.username = username;
            txtUsername.Text = username;
            txtUsername.Enabled = false; // Ngăn không cho người dùng nhập liệu vào txtUsername
        }
        public QuenMK()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void BT_DangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord = txtNewPassword.Text;
            if (Logins(userName,passWord))
            {
                QuanLyQuanCafe main = new QuanLyQuanCafe(userName);
                QuanLy_Admin adm = new QuanLy_Admin();
                if (KiemTraChuois("AD*", txtUsername.Text))
                {
                    this.Hide();
                    adm.ShowDialog();
                    this.Show();
                }
                else
                {
                    this.Hide();
                    main.ShowDialog();
                    this.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập. Vui lòng nhập lại!!!", "Thông báo",MessageBoxButtons.OK);
            }
            txtUsername.Clear();
            txtNewPassword.Clear();
        }

        bool Logins(string userName, string passWord)
        {
            if (KiemTraChuois("NV*", txtUsername.Text) || KiemTraChuois("AD*",txtUsername.Text))
            {
                return AccoutDAO.Instance.LoginNV(userName, passWord);
            }
            if(KiemTraChuois("KH*",txtUsername.Text))
            {
                return AccoutDAO.Instance.LoginKH(userName, passWord);
            }
            else
            {
                return false;
            }
        }
        public bool KiemTraChuois(string mau, string chuoi)
        {
            Regex regex = new Regex(mau);
            return regex.IsMatch(chuoi);
        }
        public Guna.UI2.WinForms.Guna2Button khachVangLai()
        {
            return doiMK;
        }
        public void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (newPassword == confirmPassword)
            {
                try
                {
                    // Thực hiện câu truy vấn và cập nhật dữ liệu
                    DataProvider provider = new DataProvider();
                    string query = $"EXECUTE ChangePassword @Username = '{username}', @NewPassword = '{newPassword}';";
                    provider.ExecuteQuery(query);

                    MessageBox.Show("Đổi mật khẩu thành công!");

                    // Quay trở lại FormLogin
                    Login formLogin = new Login();
                    formLogin.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!");
            }
        }
    }
}
