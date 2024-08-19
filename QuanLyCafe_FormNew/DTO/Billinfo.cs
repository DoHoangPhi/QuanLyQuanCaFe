using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe_FormNew.DTO
{
    class Billinfo
    {
        public Billinfo(string iD, string maSP, int sL)
        {
            this.ID = iD;
            this.MaSP = maSP;
            this.SL = sL;
        }
        public Billinfo(DataRow row)
        {
            this.ID = row["MAHDBH"].ToString();
            this.MaSP = row["MASP"].ToString();
            this.SL = (int)row["SOLUONG"];
        }
        private string iD;
        private string maSP;
        private int sL;

        public string ID { get => iD; set => iD = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SL { get => sL; set => sL = value; }
    }
}
