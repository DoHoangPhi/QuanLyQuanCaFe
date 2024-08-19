
using QuanLyCafe_FormNew.All_User_Controlls;
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
using System.Windows.Forms;

namespace QuanLyCafe_FormNew
{
    public partial class Login : Form
    {
  

        public Login()
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

        // Property để lưu giá trị của Account_txt

        private async void BT_DangNhap_Click(object sender, EventArgs e)
        {
            string userName = Accout_txt.Text;
            string passWord = Password_txt.Text;
            // Lưu giá trị của Account_txt vào property     

            if (Logins(userName,passWord))
            {
                QuanLyQuanCafe main = new QuanLyQuanCafe(userName);
                QuanLy_Admin adm = new QuanLy_Admin();
                if (KiemTraChuois("AD*", Accout_txt.Text))
                {
                    //loading1.Visible = true;
                    //loading1.BringToFront();

                    //// Chờ đợi 10 giây (10000 milliseconds) không làm đóng băng giao diện người dùng
                    //await Task.Delay(10000);

                    //// Đóng form loading1 và hiển thị form admin
                    //loading1.Visible = false;
                    this.Hide();
                    adm.ShowDialog();
                    this.Show();
                }
                else if (KiemTraChuois("KH*", Accout_txt.Text) || KiemTraChuois("NV*", Accout_txt.Text))
                {
                    main.EnableKH = true;
                    this.Hide();
                    main.ShowDialog();
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

            if (ckB_Remember.Checked == false)
            {
                Accout_txt.Clear();
                Password_txt.Clear();
            }
        }
        
        bool Logins(string userName, string passWord)
        {
            if (KiemTraChuois("AD*",Accout_txt.Text))
            {
                return AccoutDAO.Instance.LoginNV(userName, passWord);
            }
            if(KiemTraChuois("KH*",Accout_txt.Text) || KiemTraChuois("NV*", Accout_txt.Text))
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
            return guna2Button1;
        }
        public void guna2Button1_Click(object sender, EventArgs e)
        {
            QuanLyQuanCafe main = new QuanLyQuanCafe(null);
            this.Hide();
            main.ShowDialog();
            this.Show();
            //main.EnableButton2 = true;
        }

        private void cbhienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhienthi.Checked)
            {
                // Hiển thị ký tự thực khi ô kiểm được chọn
                Password_txt.PasswordChar = '\0';
            }
            else
            {
                // Hiển thị '*' khi ô kiểm không được chọn
                Password_txt.PasswordChar = '●';
            }
        }
        private string username;
        private void Accout_txt_TextChanged(object sender, EventArgs e)
        {
            username = Accout_txt.Text;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKi formQuenMK = new DangKi();
            formQuenMK.Show();
            this.Hide();
        }
    }
}
