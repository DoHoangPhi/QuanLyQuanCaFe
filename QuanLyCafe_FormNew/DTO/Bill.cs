using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe_FormNew.DTO
{
    class Bill
    {
        public Bill(string iDHD,string maNV,DateTime datebuy, int tongTien, string giamGia, string maKH, string idBan)
        {
            this.IDHD = iDHD;
            this.MaNV = maNV;
            this.DateBuy = dateBuy;
            this.tongTien = TongTien;
            this.GiamGia = giamGia;
            this.MaKH = MaKH;
            this.IdBan = idBan;
        }
        public Bill(DataRow row)
        {
            this.IDHD = row["MAHDBH"].ToString();
            this.MaNV = row["MANV"].ToString();
            var dateCheckday = row["NGAYHDBH"];
            if (dateCheckday.ToString() != "")
            {
                this.DateBuy = (DateTime?)dateCheckday;
            }
            this.TongTien = (int)row["TONGTIEN"];
            this.GiamGia = row["GIAMGIA"].ToString();
            this.MaKH = row["MAKH"].ToString();
            this.IdBan = row["IDBAN"].ToString();
        }
        private string iDHD;
        private string maNV;
        private DateTime?dateBuy;
        private int tongTien;
        private string giamGia;
        private string maKH;
        private string idBan;

        public string IDHD { get => iDHD; set => iDHD = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime? DateBuy { get => dateBuy; set => dateBuy = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public string GiamGia { get => giamGia; set => giamGia = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string IdBan { get => idBan; set => idBan = value; }
    }
}
