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

namespace QuanLyCafe_FormNew.ADMIN
{
    public partial class QL_TaiKhoan : UserControl
    {
        public QL_TaiKhoan()
        {
            InitializeComponent();
          
        }


 

        private void dsNV_Click(object sender, EventArgs e)
        {
            string query = " Select * from LOGINNV";
            DataProvider provider = new DataProvider();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = provider.ExecuteQuery(query);
        }

        private void DSKH_Click(object sender, EventArgs e)
        {
            string query = " Select * from LOGINKH";
            DataProvider provider = new DataProvider();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = provider.ExecuteQuery(query);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dataGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[index];
                txtID.Text = selectedRow.Cells[0].Value.ToString();
                pass.Text = selectedRow.Cells[1].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            pass.Clear();
        }

        private void BT_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Lấy dòng được chọn
                    DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                    int index = selectedRow.Index;

                    // Xóa dòng được chọn từ DataGridView
                    dataGridView.Rows.RemoveAt(index);

                    // Cập nhật lại view (nếu cần thiết)
                    dataGridView.Refresh();

                    MessageBox.Show("Xóa tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã hủy xóa tài khoản!", "Hủy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BT_TimHD_Click(object sender, EventArgs e)
        {
            string timMa = Tim.Text.Trim(); 
            if (!string.IsNullOrEmpty(timMa))
            {
                bool timThay = false;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    string ma = row.Cells[0].Value.ToString();
                    if (ma == timMa)
                    {
                        row.Selected = true;
                        dataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        txtID.Text = row.Cells[0].Value.ToString();
                        pass.Text = row.Cells[1].Value.ToString();

                        timThay = true;
                        break;
                    }
                }

                if (!timThay)
                {
                    MessageBox.Show("Không tìm thấy mã tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
