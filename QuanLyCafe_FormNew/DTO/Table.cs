using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe_FormNew.DTO
{
    public class Table
    {
        public Table(string name, string status,string id,int tongtien)
        {
            this.Name = name;
            this.Status = status;
            this.Id = id;
            this.Tongtien = tongtien;
        }

        private int tongtien;
        private string status;
        private string name;
        private string id;

        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public string Id { get => id; set => id = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }

        public Table(DataRow row)
        {
            this.Name = row["TENBAN"].ToString();
            this.Status = row["TRANGTHAI"].ToString();
            this.Id = row["IDBAN"].ToString();
        }
    }
    public class Menuu
    {
        public Menuu(string masp, string tensp, int giasp)
        {
            this.Masp = masp;
            this.Tensp = tensp;
            this.Giasp = giasp;
            this.Imgsp = imgsp;
        }

        private string masp;
        private string tensp;
        private int giasp;
        private string imgsp;

        public string Masp { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public int Giasp { get => giasp; set => giasp = value; }
        public string Imgsp { get => imgsp; set => imgsp = value; }

        public Menuu(DataRow row)
        {
            this.Masp = row["MASP"].ToString();
            this.Tensp = row["TENSP"].ToString();
            this.Giasp = (int)row["GIASP"];
            this.Imgsp = row["HINHANH"].ToString();
        }
    }
}
