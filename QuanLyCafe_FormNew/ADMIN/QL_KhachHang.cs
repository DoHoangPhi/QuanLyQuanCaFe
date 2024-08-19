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
    public partial class QL_KhachHang : UserControl
    {
        public QL_KhachHang()
        {
            InitializeComponent();
            dataGridView_DSKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            string queryy = "EXEC sp_XuatThongTinKhachHang;";
            DataProvider providerr = new DataProvider();
            dataGridView_DSKH.DataSource = providerr.ExecuteQuery(queryy);
        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IDKH_txt.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa");
                return;
            }

            // Kiểm tra tính hợp lệ của các trường dữ liệu
            if (string.IsNullOrWhiteSpace(TenKH_txt.Text) ||
                string.IsNullOrWhiteSpace(CbB_MaLoaiKH.Text) ||
                string.IsNullOrWhiteSpace(DiaChiKH_txt.Text) ||
                string.IsNullOrWhiteSpace(SDTKH_txt.Text) ||
                string.IsNullOrWhiteSpace(TichLuyKH_txt.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng.");
                return;
            }
            string query = $"UPDATE KHACHHANG SET MaLKH = '{CbB_MaLoaiKH.Text}', " +
                           $"TenKH = '{TenKH_txt.Text}', " +
                           $"DiaChi = '{DiaChiKH_txt.Text}', " +
                           $"SDT = '{SDTKH_txt.Text}', " +
                           $"DIEMTL = '{TichLuyKH_txt.Text}' " +
                           $"WHERE MAKH = '{IDKH_txt.Text}'";

            DataProvider provider = new DataProvider();
            int rowsAffected = provider.ExecuteNonQuery(query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Sửa thông tin khách hàng thành công");
                // Gọi lại hàm để cập nhật DataGridView
                btnShowAll_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa thông tin khách hàng thất bại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IDKH_txt.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa");
                return;
            }

            string query = $"EXECUTE GopXoaDuLieu @MAKH = '{IDKH_txt.Text}'";

            DataProvider provider = new DataProvider();
            int rowsAffected = provider.ExecuteNonQuery(query);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Xóa khách hàng thành công");
                // Gọi lại hàm để cập nhật DataGridView
                btnShowAll_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thất bại");
            }
        }

        private void dataGridView_DSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_DSKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int index = e.RowIndex;
            if (index >= 0 && index < dataGridView_DSKH.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_DSKH.Rows[index];
                IDKH_txt.Text = selectedRow.Cells[0].Value.ToString();
                CbB_MaLoaiKH.Text = selectedRow.Cells[1].Value.ToString();
                TenKH_txt.Text = selectedRow.Cells[2].Value.ToString();
                DiaChiKH_txt.Text = selectedRow.Cells[3].Value.ToString();
                SDTKH_txt.Text = selectedRow.Cells[4].Value.ToString();
                TichLuyKH_txt.Text = selectedRow.Cells[5].Value.ToString();
                textBox1.Text = selectedRow.Cells[6].Value.ToString();
                textBox2.Text = selectedRow.Cells[7].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            IDKH_txt.Clear();
            CbB_MaLoaiKH.Clear();
            CbB_MaLoaiKH.Clear();
            TenKH_txt.Clear();
            DiaChiKH_txt.Clear();
            SDTKH_txt.Clear();
            TichLuyKH_txt.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sdt = input.Text;
            DataProvider provider = new DataProvider();
            string query = $"EXEC SearchCustomerByPhoneNumber @PhoneNumber = N'{sdt}'";
            DataTable result = provider.ExecuteQuery(query);
            dataGridView_DSKH.DataSource = result;
        }
    }
}
