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
    public partial class HoaDon : UserControl
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            string query = " EXEC XuatThongTinHoaDon";
            DataProvider provider = new DataProvider();
            dataGridView_DSHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_DSHD.DataSource = provider.ExecuteQuery(query);
        }

        private void dataGridView_DSHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView_DSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dataGridView_DSHD.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_DSHD.Rows[index];
                txtMAHD.Text = selectedRow.Cells["MAHDBH"].Value.ToString();
                TENNV.Text = selectedRow.Cells["MANV"].Value.ToString();
                TIME.Text = selectedRow.Cells["NGAYHDBH"].Value.ToString();
                MAKH.Text = selectedRow.Cells["MAKH"].Value.ToString();
                TENLKH.Text = selectedRow.Cells["TENLKH"].Value.ToString();
                TKH.Text = selectedRow.Cells["TENKH"].Value.ToString();
                DC.Text = selectedRow.Cells["DIACHI"].Value.ToString();
                SDT.Text = selectedRow.Cells["SDT"].Value.ToString();
                DIEM.Text = selectedRow.Cells["DIEMTL"].Value.ToString();
                TT.Text = selectedRow.Cells["TONGTIEN"].Value.ToString();
            }
        }
    }
}
