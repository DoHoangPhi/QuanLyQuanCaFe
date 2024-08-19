using QuanLyCafe_FormNew.DAO;
using QuanLyCafe_FormNew.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe_FormNew.All_User_Controlls
{
    public partial class QL_BanCF : UserControl
    {
        public QL_BanCF()
        {
            InitializeComponent();
            LoadTable();
            LoadMenu();

        }
       
        void LoadTable()
        {
            CallUpdateTableStatusProcedure();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            Image img;
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeigh };
                btn.Text = item.Name + Environment.NewLine;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.Font = new Font("Comic Sans MS", 9, FontStyle.Italic);
                btn.ForeColor = Color.Gray;
                btn.Click += btn_Click;
                btn.Tag = item;

                string basePath = AppDomain.CurrentDomain.BaseDirectory; // Đường dẫn gốc của ứng dụng
                string imagePath = Path.Combine(basePath, "icons/"); // Thay "\\" bằng "/"
                switch (item.Status)
                {
                    case "Trống":
                        imagePath += "Empty.png";
                        break;
                    default:
                        imagePath += "unEmpty.jpg";
                        break;
                }

                if (File.Exists(imagePath))
                {
                    img = Image.FromFile(imagePath);
                    btn.Image = img;
                }

                flPn_Table.Controls.Add(btn);
            }
        }
        void CallUpdateTableStatusProcedure()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-Q3IDAGJ3\SQLEXPRESS;Initial Catalog=QL_CAFE_QUAN;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateTableStatusProcedures", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        command.ExecuteNonQuery();
                        // Thực hiện thành công
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
        decimal sumTT = 0;
        int a = 0;
        void showBillMN(string id, int countFood)
        {
            int tongtien = 0;
            Table table = tag1 as Table;
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước!!!", "Thông báo");
                return;
            }
            else
            {
                string idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
                //listView_Bill.Items.Clear();
                Menuu idFood = tag2 as Menuu;
                string menuID = $"{idFood.Masp}";
                tongtien = countFood * (idFood.Giasp);
                if (idBill == "")
                {
                    if (NumUP_SL.Value > 0)
                    {
                        BillDAO.Instance.InsertBill(table.Id, tongtien);
                        BillinfoDAO.Instance.InsertBillinfo(BillDAO.Instance.GetMaxIDBill(), idFood.Masp.ToString(), countFood);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa món không có trong hóa đơn","Thông báo");
                    }
                }    
                    
                else
                {
                    BillinfoDAO.Instance.InsertBillinfo(idBill, idFood.Masp.ToString(), countFood);
                }
                if (countFood == 0)
                {
                    MessageBox.Show("Vui lòng chọn số lượng trước khi chọn món!!!", "Thông báo");
                    return;
                }
                else
                {
                    List<SanPhamm> listMenuInfo = SanPhammDAO.Instance.GetFoodByID(id);
                    foreach (SanPhamm item in listMenuInfo)
                    { 
                        ListViewItem lsvItem = new ListViewItem(item.TenSP.ToString());
                        lsvItem.SubItems.Add(countFood.ToString());
                        lsvItem.SubItems.Add(item.GiaSP.ToString());
                        //MessageBox.Show($"Giá trị của món là:{tongtien.ToString()}");
                        lsvItem.SubItems.Add(tongtien.ToString());
                        listView_Bill.Items.Add(lsvItem);
                        sumTT += tongtien;
                    }
                    CultureInfo culture = new CultureInfo("vi-VN");
                    Thread.CurrentThread.CurrentCulture = culture;
                    TongTien_txt.Text = sumTT.ToString("c", culture);
                }
            }
            // Xóa các nút bàn cũ
            flPn_Table.Controls.Clear();

            // Tải lại bàn mới
            LoadTable();

            showBill(table.Id);

            NumUP_SL.Value = 0;

        }
       
        void showBill(string id)
        {
            listView_Bill.Items.Clear();
            List<MenuTG> listBillInfo = MenuDAO.Instance.GetListMenuTGByTable(id);
            int sumTT = 0;
        
            foreach (MenuTG item in listBillInfo)
            {
                if (item.DateBuy.ToString() == "19/09/2023 12:00:00 SA")
                {
                    ListViewItem lsvItem = new ListViewItem(item.SanPham.ToString());
                    lsvItem.SubItems.Add(item.SoLuong.ToString());
                    lsvItem.SubItems.Add(item.Gia.ToString());
                    lsvItem.SubItems.Add(item.TongTien.ToString());
                    sumTT += item.TongTien;
                    listView_Bill.Items.Add(lsvItem);
                }
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            TongTien_txt.Text = sumTT.ToString("c", culture);
            a += (int)sumTT;
        }
        private object tag1;
        private object tag2;
        private void btn_Click(object sender, EventArgs e)
        {
            string tableID = ((sender as Button).Tag as Table).Id;
            tag1 = (sender as Button).Tag;
            showBill(tableID);
            sumTT = 0;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            int countFood = 0;
            string menuID = ((sender as Button).Tag as Menuu).Masp;
            tag2 = (sender as Button).Tag;
            countFood = (int)NumUP_SL.Value;
            showBillMN(menuID, countFood);
        }
        
        private void ThanhToan_BT_Click(object sender, EventArgs e)
        {
            PTThanhToan main = new PTThanhToan();
            main.SetBillItems(listView_Bill.Items);

            // Lấy giá trị từ TextBox TongTien_txt của form QL_CF
            string giaTri = TongTien_txt.Text;
            
            // Gọi phương thức NhanGiaTriTuFormQL_CF trên form PTThanhToan và truyền giá trị đã lấy
            main.NhanGiaTriTuFormQL_CF(giaTri,a);

            this.Hide();
            main.ShowDialog();
            this.Show();
        }
        void LoadMenu()
        {
            List<Menuu> menuList = TableDAO.Instance.LoadMenuList();
            foreach (Menuu item in menuList)
            {
                Button btn1 = new Button() { Width = TableDAO.MenuWidth, Height = TableDAO.MenuHeigh };
                btn1.Text = item.Tensp + Environment.NewLine + item.Giasp + " VNĐ" + Environment.NewLine;
                btn1.TextAlign = ContentAlignment.BottomCenter;
                btn1.Font = new Font("SATANTIC TYPEFACE", 10, FontStyle.Italic);
                btn1.ForeColor = Color.Black;
                btn1.TextImageRelation = TextImageRelation.TextAboveImage;
                btn1.BackColor = Color.LightGray;
                btn1.Click += btn1_Click;
                btn1.Tag = item;

                //Image originalImage = Image.FromFile(item.Imgsp);
                string basePath = AppDomain.CurrentDomain.BaseDirectory; // Đường dẫn gốc của ứng dụng
                string relativePath = item.Imgsp; // Đường dẫn lấy từ SQL Server
                string fullPath = Path.Combine(basePath, relativePath);
                Image originalImage = Image.FromFile(fullPath);
                int newWidth = 140;
                int newHeight = 110;
                Image resizedImage = originalImage.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);
                //Image img = Image.FromFile(item.Imgsp);
                btn1.Image = resizedImage;
                btn1.ImageAlign = ContentAlignment.TopCenter;
                flPN_SP.Controls.Add(btn1);
            }
        }


        
        public static List<string> dataToTransfer = new List<string>();
        private void listView_Bill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QL_BanCF_Load(object sender, EventArgs e)
        {

        }
    }
}
