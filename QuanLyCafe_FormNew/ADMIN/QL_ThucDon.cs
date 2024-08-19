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
using System.Data.SqlClient;
using System.IO;

namespace QuanLyCafe_FormNew.ADMIN
{
    public partial class QL_ThucDon : UserControl
    {
        public QL_ThucDon()
        {
            InitializeComponent();
            dataGridView_DSNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QL_ThucDon_Load(object sender, EventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            string trc = "EXECUTE GetProductInfo";
            DataProvider providerr = new DataProvider();
            dataGridView_DSNV.DataSource = providerr.ExecuteQuery(trc);
        }

        private void dataGridView_DSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dataGridView_DSNV.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_DSNV.Rows[index];
                txtMaLSP.Text = selectedRow.Cells[0].Value.ToString();
                CbB_LoaiMon.Text = selectedRow.Cells[1].Value.ToString();
                MOTA.Text = selectedRow.Cells[2].Value.ToString();
                ID_txt.Text = selectedRow.Cells[3].Value.ToString();
                TenMon_txt.Text = selectedRow.Cells[4].Value.ToString();
                GiaMon_txt.Text = selectedRow.Cells[5].Value.ToString();
            }
        }

        private void btnAddNhanVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLSP.Text) || string.IsNullOrEmpty(CbB_LoaiMon.Text) ||
                string.IsNullOrEmpty(MOTA.Text) || string.IsNullOrEmpty(ID_txt.Text) ||
            string.IsNullOrEmpty(TenMon_txt.Text) || string.IsNullOrEmpty(GiaMon_txt.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"EXEC ThemSanPham " +
                           $"@MALSP = '{txtMaLSP.Text}', " +
                           $"@TENLSP = N'{CbB_LoaiMon.Text}', " +
                           $"@MOTA = N'{MOTA.Text}', " +
                           $"@MASP = '{ID_txt.Text}', " +
                           $"@TENSP = N'{TenMon_txt.Text}', " +
                           $"@GIASP = {GiaMon_txt.Text}, " +
                           $"@HINHANH = '{txtDuongDan.Text}'";

            DataProvider provider = new DataProvider();
            int rowsAffected = provider.ExecuteNonQuery(query);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Thêm món ăn thành công");
                // Cập nhật DataGridView cho menu
                btnShowAll_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm món ăn thất bại");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ID_txt.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa");
                return;
            }

            // Kiểm tra tính hợp lệ của các trường dữ liệu
            if (string.IsNullOrEmpty(txtMaLSP.Text) || string.IsNullOrEmpty(CbB_LoaiMon.Text) ||
                string.IsNullOrEmpty(MOTA.Text) || string.IsNullOrEmpty(ID_txt.Text) ||
            string.IsNullOrEmpty(TenMon_txt.Text) || string.IsNullOrEmpty(GiaMon_txt.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"UPDATE SANPHAM " +
                            $"SET TENSP = N'{TenMon_txt.Text}', " +
                           $"SANPHAM.MALSP = '{txtMaLSP.Text}', " +
                           $"GIASP = {GiaMon_txt.Text} " +
                           $"FROM SANPHAM " +
                           $"JOIN LOAISANPHAM ON SANPHAM.MALSP = LOAISANPHAM.MALSP " +
                           $"WHERE SANPHAM.MASP = '{ID_txt.Text}'";

            DataProvider provider = new DataProvider();
            int rowsAffected = provider.ExecuteNonQuery(query);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Sửa thông tin sản phẩm thành công");
                btnShowAll_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa thông tin sản phẩm thất bại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ID_txt.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa");
                return;
            }

            string query = $"DELETE FROM SANPHAM WHERE MASP = '{ID_txt.Text}'";

            DataProvider provider = new DataProvider();
            int rowsAffected = provider.ExecuteNonQuery(query);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Xóa sản phẩm thành công");
                // Cập nhật DataGridView cho menu
                btnShowAll_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại");
            }
        }

        private void IDMon_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaLSP.Clear();
            CbB_LoaiMon.Clear();
            MOTA.Clear();
            ID_txt.Clear();
            TenMon_txt.Clear();
            GiaMon_txt.Clear();
        }

        private void btnTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            string masp = ID_txt.Text;
            if (check1.Checked)
            {
                DataProvider provider = new DataProvider();
                string query = $"EXEC [dbo].[SearchNhanVienByMaSanPham] @MaSP = N'{masp}'";
                DataTable result = provider.ExecuteQuery(query);
                dataGridView_DSNV.DataSource = result;


                

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string masp = ID_txt.Text;
            if (check1.Checked)
            {
                
                DataProvider provider = new DataProvider();
                string query = $"EXEC [dbo].[SearchNhanVienByMaSanPham] @MaSP = N'{masp}'";
                DataTable result = provider.ExecuteQuery(query);
                dataGridView_DSNV.DataSource = result;

            }
        }

        private void BT_ANH_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                string appDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                string imgDirectory = Path.Combine(appDirectory, "img");
                string relativePath = selectedImagePath.Replace(imgDirectory + "\\", "");

                string fileName = Path.GetFileName(relativePath);
                txtDuongDan.Text = "img\\" + fileName;
            }
        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            if (check1.Checked)
            {
                txtMaLSP.Enabled = false;
                CbB_LoaiMon.Enabled = false;
                MOTA.Enabled = false;
                TenMon_txt.Enabled = false;
                GiaMon_txt.Enabled = false;
            }
            else
            {
                txtMaLSP.Enabled = true;
                CbB_LoaiMon.Enabled = true;
                MOTA.Enabled = true;
                TenMon_txt.Enabled = true;
                GiaMon_txt.Enabled = true;
            }
        }
    }
}
