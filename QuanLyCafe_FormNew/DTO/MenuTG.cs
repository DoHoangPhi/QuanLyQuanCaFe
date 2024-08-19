using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe_FormNew.DTO
{
    public class MenuTG
    {
        public MenuTG( string sanPham, int gia, string soLuong,  int tongTien)
        {
            this.SanPham = sanPham;
            this.SoLuong = soLuong;
            this.Gia = gia;
            this.tongTien = TongTien;
        }
        public MenuTG(DataRow row)
        {
            this.SanPham = row["TENSP"].ToString();
            this.SoLuong = row["SOLUONG"].ToString();
            this.Gia = (int)row["GIASP"];
            this.tongTien = (int)row["TONGTIEN"];
            var dateCheckday = row["NGAYHDBH"];
            if (dateCheckday.ToString() != "")
            {
                this.DateBuy = (DateTime?)dateCheckday;
            }
        }

        private string sanPham;
        private string soLuong;
        private int gia;
        private int tongTien;
        private DateTime? dateBuy;


        public string SanPham { get => sanPham; set => sanPham = value; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public int Gia { get => gia; set => gia = value; }
        public DateTime? DateBuy { get => dateBuy; set => dateBuy = value; }

    }
}

