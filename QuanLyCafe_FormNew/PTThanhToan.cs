using QuanLyCafe_FormNew.All_User_Controlls;
using QuanLyCafe_FormNew.DAO;
using QuanLyCafe_FormNew.NganHangIcons;
using QuanLyCafe_FormNew.ThanhToan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe_FormNew
{
    public partial class PTThanhToan : Form
    {
        public PTThanhToan()
        {
            InitializeComponent();
            GG.Text = "0";
        }

        private bool pictureBoxClicked = false;

        private string connectionString = @"Data Source=LAPTOP-Q3IDAGJ3\SQLEXPRESS;Initial Catalog=QL_CAFE_QUAN;Integrated Security=True";
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);
                e.Graphics.FillRectangle(new SolidBrush(Color.DarkGray), e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
        }
        private void SearchIDKH()
        {
            string MAKH = idKH.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM dbo.TTThanhToan(@MAKH)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MAKH", MAKH);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    tenKH.Text = reader["TenKH"].ToString();
                    LTV.Text = reader["TenLKH"].ToString();
                    DTL.Text = reader["DIEMTL"].ToString();
                    GG.Text = string.Format("{0}%", reader["GIAMGIA"]);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng.");
                }

                reader.Close();
            }
        }
        private void idKH_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SearchIDKH();
            }
            string giaTriText = GG.Text; // Giả sử giá trị trong TextBox là "5%"
            giaTriText = giaTriText.Trim('%');
            int giamGia;
            if (int.TryParse(giaTriText, out giamGia))
            {
                double c = (double)giamGia / 100;
                double d = (double)b * c;
                double tongTienSauGiamGia = (int)b - d;
                TongTien_txt.Text = tongTienSauGiamGia.ToString();
            }
            else
            {
                MessageBox.Show("Lỗi!!!");
            }
        }
        private bool checkimg1 = false;
        private Image originalImage1;
        private bool checkimg2 = false;
        private Image originalImage2;
        private bool checkimg3 = false;
        private Image originalImage3;
        private bool checkimg4 = false;
        private Image originalImage4;
        private bool checkimg7 = false;
        private Image originalImage7;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (checkimg1)
            {
                pictureBox1.Image = originalImage1;
                checkimg1 = false;
            }
            else
            {
                originalImage1 = pictureBox1.Image;
                pictureBox1.Image = Image.FromFile(@"E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\tickMM.png");
                checkimg1 = true;
            }


            if (checkimg1 == true)
            {
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox7.Enabled = false;
            }
            else
            {
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox7.Enabled = true;
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (checkimg2)
            {
                pictureBox2.Image = originalImage2;
                checkimg2 = false;
            }
            else
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory; // Đường dẫn gốc của ứng dụng
                string imagePath = Path.Combine(basePath, "img/tickVC.png"); // Kết hợp đường dẫn gốc với đường dẫn tương đối của tệp tin ảnh
                originalImage2 = pictureBox2.Image;
                pictureBox2.Image = Image.FromFile(imagePath);
                checkimg2 = true;
            }

            if (checkimg2 == true)
            {
                pictureBox1.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox7.Enabled = false;
            }
            else
            {
                pictureBox1.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox7.Enabled = true;
            }



        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (checkimg3)
            {
                pictureBox3.Image = originalImage3;
                checkimg3 = false;
            }
            else
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory; // Đường dẫn gốc của ứng dụng
                string imagePath = Path.Combine(basePath, "img/tickTP.png"); // Kết hợp đường dẫn gốc với đường dẫn tương đối của tệp tin ảnh
                originalImage3 = pictureBox3.Image;
                pictureBox3.Image = Image.FromFile(imagePath);
                checkimg3 = true;
            }
            if (checkimg3 == true)
            {
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox7.Enabled = false;
            }
            else
            {
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox7.Enabled = true;
            }


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (checkimg4)
            {
                pictureBox4.Image = originalImage4;
                checkimg4 = false;
            }
            else
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory; // Đường dẫn gốc của ứng dụng
                string imagePath = Path.Combine(basePath, "img/tickZL.png"); // Kết hợp đường dẫn gốc với đường dẫn tương đối của tệp tin ảnh

                originalImage4 = pictureBox4.Image;
                pictureBox4.Image = Image.FromFile(imagePath);
                checkimg4 = true;
            }
            if (checkimg4 == true)
            {
                pictureBox1.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox7.Enabled = false;
            }
            else
            {
                pictureBox1.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox7.Enabled = true;
            }


        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (checkimg7)
            {
                pictureBox7.Image = originalImage7;
                checkimg7 = false;
            }
            else
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory; // Đường dẫn gốc của ứng dụng
                string imagePath = Path.Combine(basePath, "img/tick.png"); // Kết hợp đường dẫn gốc với đường dẫn tương đối của tệp tin ảnh
                originalImage7 = pictureBox7.Image;
                pictureBox7.Image = Image.FromFile(imagePath);
                checkimg7 = true;
            }
            if (checkimg7 == true)
            {
                pictureBox1.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox2.Enabled = false;
            }
            else
            {
                pictureBox1.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkimg1 == true)
            {
                PTMomo momo = new PTMomo();
                //this.Hide();
                momo.ShowDialog();
                this.Show();
            }
            else if (checkimg2 == true)
            {
                VCB vcb = new VCB();
                //this.Hide();
                vcb.ShowDialog();
                this.Show();
            }
            else if (checkimg3 == true)
            {
                TPBank tp = new TPBank();
                //this.Hide();
                tp.ShowDialog();
                this.Show();
            }
            else if (checkimg4 == true)
            {
                MBBank zl = new MBBank();
                //this.Hide();
                zl.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("CẢM ƠN QUÝ KHÁCH - THANKS SO MUCH!!!", "THANK YOU", MessageBoxButtons.OK);
            }
            PrintBill();
            this.Close();

        }
        public void SetBillItems(ListView.ListViewItemCollection items)
        {
            listView_ThanhToan.Items.AddRange(items.Cast<ListViewItem>().Select(item => (ListViewItem)item.Clone()).ToArray());
        }

        private void PrintBill()
        {
            // Tạo đối tượng PrintDocument
            System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();

            // Gán sự kiện PrintPage cho việc in hóa đơn
            printDocument.PrintPage += (sender, e) =>
            {
                // Thiết lập font chữ và độ dày
                Font font = new Font("Time New Roman", 14, FontStyle.Regular);

                // Thiết lập các thông tin cần in
                string header = "HÓA ĐƠN THANH TOÁN";
                string line = "--------------------------------------";
                string footer = "Cảm ơn quý khách đã sử dụng dịch vụ!";

                // Thiết lập vị trí in
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                float lineOffset = font.GetHeight();

                // In tiêu đề
                e.Graphics.DrawString(header, font, Brushes.Black, x, y);
                y += lineOffset;

                // In danh sách sản phẩm và giá tiền từ ListView
                foreach (ListViewItem item in listView_ThanhToan.Items)
                {
                    string productName = item.SubItems[0].Text;
                    string quantity = item.SubItems[1].Text;
                    string price = item.SubItems[2].Text;

                    string lineItem = $"{productName} - {quantity} x {price}";
                    e.Graphics.DrawString(lineItem, font, Brushes.Black, x, y);
                    y += lineOffset;
                }

                // In dòng kẻ
                e.Graphics.DrawString(line, font, Brushes.Black, x, y);
                y += lineOffset;

                // In tổng cộng
                string totalLabel = "Tổng cộng:";
                // Tính tổng giá trị hóa đơn từ cột "Thành tiền" trong ListView
                string total;
                total = TongTien_txt.Text;
                string totalAmount = total.ToString();
                string totalLine = $"{totalLabel} {totalAmount}";

                e.Graphics.DrawString(totalLine, font, Brushes.Black, x, y);
                y += lineOffset;

                // In dòng kẻ
                e.Graphics.DrawString(line, font, Brushes.Black, x, y);
                y += lineOffset;

                // In chân trang
                e.Graphics.DrawString(footer, font, Brushes.Black, x, y);
            };

            // Hiển thị hộp thoại in
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void PTThanhToan_Load(object sender, EventArgs e)
        {

        }
        // Định nghĩa một phương thức public để nhận giá trị từ form QL_CF
        int b = 0;
        public void NhanGiaTriTuFormQL_CF(string giaTri, int a)
        {
            TongTien_txt.Text = giaTri;
            b = a;
        }

        private void TongTien_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void GG_TextChanged(object sender, EventArgs e)
        {

        }

        private void TongTien_txt_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void idKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
