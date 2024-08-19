using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe_FormNew.DAO;


namespace QuanLyCafe_FormNew.ADMIN
{
    public partial class QL_NhanVien : UserControl
    {
        public QL_NhanVien()
        {
            InitializeComponent();
            comboBox1.Items.Add("Nhân Viên");
            comboBox1.Items.Add("Quản Lí");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        // HIỆN DS NHÂN VIÊN 
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            string query = " Select * from NHANVIEN";
            DataProvider provider = new DataProvider();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = provider.ExecuteQuery(query);
        }
        // HIỆN THÔNG TIN TRÊN TEXTBOX
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                txtMaNV.Text = selectedRow.Cells[0].Value.ToString();
                txtTenNV.Text = selectedRow.Cells[1].Value.ToString();
                string gioiTinh = selectedRow.Cells[2].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    radioBoy.Checked = true;
                    radioGirl.Checked = false;
                }
                else
                {
                    radioBoy.Checked = false;
                    radioGirl.Checked = true;
                }
                comboBox1.Text = selectedRow.Cells[3].Value.ToString();
                dtpNgayVL.Value = DateTime.Parse(selectedRow.Cells[4].Value.ToString());
                txtDC.Text = selectedRow.Cells[5].Value.ToString();
                txtSDT.Text = selectedRow.Cells[6].Value.ToString();
            }
        }
        // thêm NHÂN VIÊN
        private void btnAddNhanVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(txtDC.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }

            // Kiểm tra ngày vào làm không được sau ngày hiện tại
            if (dtpNgayVL.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày vào làm không thể là ngày trong tương lai.");
                return;
            }

            string gioiTinh;
            if (radioBoy.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (radioGirl.Checked)
            {
                gioiTinh = "Nu";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giới tính.");
                return;
            }

            // Kiểm tra giá trị của gioiTinh với điều kiện ràng buộc
            if (gioiTinh != "Nam" && gioiTinh != "Nu")
            {
                MessageBox.Show("Giới tính không hợp lệ.");
                return;
            }

            // Get selected item from comboBox1
            string chucVu = comboBox1.SelectedItem.ToString();

            string query = $"INSERT INTO NHANVIEN (MANV, TenNV, GioiTinh, ChucVu, NgayVaoLam, DiaChi, SDT) " +
                           $"VALUES ('{txtMaNV.Text}', N'{txtTenNV.Text}', N'{gioiTinh}', " +
                           $"N'{chucVu}', '{dtpNgayVL.Value.ToString("yyyy-MM-dd")}', " +
                           $"N'{txtDC.Text}', '{txtSDT.Text}')";

            DataProvider provider = new DataProvider();
            int rowsAffected = provider.ExecuteNonQuery(query);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Thêm nhân viên thành công");
                // Gọi lại hàm để cập nhật DataGridView
                btnShowAll_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa");
                return;
            }

            // Kiểm tra tính hợp lệ của các trường dữ liệu
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(txtDC.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }

            // Kiểm tra ngày vào làm không được sau ngày hiện tại
            if (dtpNgayVL.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày vào làm không thể là ngày trong tương lai.");
                return;
            }

            string query = $"UPDATE NHANVIEN SET TenNV = '{txtTenNV.Text}', " +
                           $"GioiTinh = '{(radioBoy.Checked ? "Nam" : "Nu")}', " +
                           $"ChucVu = '{comboBox1.Text}', " +
                           $"NgayVaoLam = '{dtpNgayVL.Value.ToString("yyyy-MM-dd")}', " +
                           $"DiaChi = '{txtDC.Text}', " +
                           $"SDT = '{txtSDT.Text}' " +
                           $"WHERE MANV = '{txtMaNV.Text}'";

            DataProvider provider = new DataProvider();
            int rowsAffected = provider.ExecuteNonQuery(query);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Sửa thông tin nhân viên thành công");
                // Gọi lại hàm để cập nhật DataGridView
                btnShowAll_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa thông tin nhân viên thất bại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa");
                return;
            }

            string query = $"DELETE FROM NHANVIEN WHERE MANV = '{txtMaNV.Text}'";

            DataProvider provider = new DataProvider();
            int rowsAffected = provider.ExecuteNonQuery(query);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Xóa nhân viên thành công");
                // Gọi lại hàm để cập nhật DataGridView
                btnShowAll_Click(sender, e);
                txtMaNV.Clear();
                txtTenNV.Clear();
                txtDC.Clear();
                txtSDT.Clear();
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {        
            string gender = "";
            string manv = txtMaNV.Text;
            string cvu = comboBox1.Text;
            if (checkBox1.Checked)
            {
                
                if (radioBoy.Checked)
                {
                    gender = "Nam";
                }
                else if (radioGirl.Checked)
                {
                    gender = "Nữ";
                }
                // Gọi thủ tục tìm kiếm nhân viên theo giới tính
                DataProvider provider = new DataProvider();
                string query = $"EXEC SearchNhanVienByGender @Gender = N'{gender}'";
                DataTable result = provider.ExecuteQuery(query);
                dataGridView1.DataSource = result;
                checkBox1.Checked = false;
                checkBox2.Enabled = true;
                check1.Enabled = true;
            }
            else if (check1.Checked)
            {
                // Gọi thủ tục tìm kiếm nhân viên theo giới tính
                DataProvider provider = new DataProvider();
                string query = $"EXEC [dbo].[SearchNhanVienByMaNhanVien] @MaNhanVien = N'{manv}'";
                DataTable result = provider.ExecuteQuery(query);
                dataGridView1.DataSource = result;
                check1.Checked = false;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
            }
            else if (checkBox2.Checked)
            {
                // Gọi thủ tục tìm kiếm nhân viên theo giới tính
                DataProvider provider = new DataProvider();
                string query = $"EXEC [dbo].[SearchNhanVienByChucVu] @ChucVu = N'{cvu}'";
                DataTable result = provider.ExecuteQuery(query);
                dataGridView1.DataSource = result;
                checkBox2.Checked = false;
                checkBox1.Enabled = true;
                check1.Enabled = true;
            }

            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDC.Clear();
            txtSDT.Clear();
            comboBox1.Items.Clear();
            dtpNgayVL.Value = DateTime.Now;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDC.Clear();
            txtSDT.Clear();
            comboBox1.Items.Clear();
            dtpNgayVL.Value = DateTime.Now;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = false;
            checkBox1.Enabled = false;
            check1.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = false;
            checkBox1.Enabled = true;
            check1.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = true;
            checkBox1.Enabled = false;
            check1.Enabled = false;
        }

        private void QL_NhanVien_Load(object sender, EventArgs e)
        {
            
        }
    }
}