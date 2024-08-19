using QuanLyCafe_FormNew.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;// biểu đồ 
using System.Globalization;// kiểm tra kí tự

namespace QuanLyCafe_FormNew.ADMIN
{
    public partial class Thongke_DoanhThu : UserControl
    {
        public Thongke_DoanhThu()
        {
            InitializeComponent();
            comboBox1.Items.Add("2023");
            comboBox1.Items.Add("2024");
            dataProvider = DataProvider.Instance;
            dataGridView_DoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                dateTime_End.Enabled = true; // Cho phép truy cập chọn ngày
            }
            else
            {
                dateTime_End.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboBox1.Enabled = true; // Cho phép truy cập ComboBox
            }
            else
            {
                comboBox1.Enabled = false;
            }
        }
        private DataProvider dataProvider;
        private void BT_ThongKe_Click(object sender, EventArgs e)
        {
            if (dateTime_End.Enabled)
            {
                // Thống kê theo ngày
                DateTime selectedDate = dateTime_End.Value;
                string formattedDate = selectedDate.ToString("yyyy-MM-dd");

                // Thực hiện truy vấn và cập nhật dữ liệu
                string query = $"EXEC dbo.GetSalesByDateProcedure '{formattedDate}'";
                DataTable result = dataProvider.ExecuteQuery(query);
                dataGridView_DoanhThu.DataSource = result;

                // Tính tổng tiền theo ngày
                string query2 = $"EXEC dbo.GetTotalSalesByDate '{formattedDate}'";
                string totalSales = dataProvider.ExecuteScaler(query2).ToString();
                textBox1.Text = totalSales;

                // Biểu  đồ
                Series series = new Series();
                series.Name = "Sản phẩm";
                Color[] colors = new Color[] { Color.Red, Color.Blue, Color.Green, Color.Yellow };
                // Lặp qua từng dòng trong kết quả truy vấn
                for (int i = 0; i < result.Rows.Count; i++)
                {
                    DataRow row = result.Rows[i];
                    string monAn = row["TÊN SẢN PHẨM"].ToString();
                    int soLuong = Convert.ToInt32(row["SỐ LƯỢNG BÁN"]);

                    // Tạo một điểm mới với giá trị và màu tương ứng
                    DataPoint dataPoint = new DataPoint();
                    dataPoint.AxisLabel = monAn;
                    dataPoint.YValues = new double[] { soLuong };
                    dataPoint.Color = colors[i % colors.Length]; // Chọn màu theo vòng lặp
                    series.Points.Add(dataPoint);
                }

                chart1.Series.Clear();
                chart1.Series.Add(series);
            }
            else if (comboBox1.Enabled)
            {
                // Thống kê theo tháng
                string selectedYear = comboBox1.SelectedItem.ToString();

                // Thực hiện truy vấn và cập nhật dữ liệu
                string query3 = $"EXEC GetSalesByMonth @Year = '{selectedYear}'";
                DataTable result3 = dataProvider.ExecuteQuery(query3);
                dataGridView_DoanhThu.DataSource = result3;

                // Tính tổng tiền trong năm
                string query4 = $"EXEC GetTotalSalesByYear @Year = '{selectedYear}'";
                string totalSales1 = dataProvider.ExecuteScaler(query4).ToString();
                textBox1.Text = totalSales1;

                // Biểu đồ
                Series series1 = new Series();
                series1.Name = "Các tháng";
                foreach (DataRow row in result3.Rows)
                {
                    string thang = row["THANG"].ToString();
                    string tongTienBan = row["TONG_TIEN_BAN"].ToString();
                    tongTienBan = tongTienBan.Replace(" VNĐ", "");

                    int tongTien;
                    if (int.TryParse(tongTienBan, NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out tongTien))
                    {
                        series1.Points.AddXY(thang, tongTien);
                    }
                    else
                    {
                        Console.WriteLine("Lỗi: Chuỗi không hợp lệ - " + tongTienBan);
                    }
                }
                chart1.Series.Clear();
                chart1.Series.Add(series1);
            }
        }
    }
}
