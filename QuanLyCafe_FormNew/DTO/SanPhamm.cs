using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe_FormNew.DTO
{
    public class SanPhamm
    {
        public SanPhamm(string tenSP, int giaSP)
        {
            this.TenSP = tenSP;
            this.GiaSP = giaSP;
        }
        public SanPhamm(DataRow row)
        {
            this.TenSP = row["TENSP"].ToString();
            this.GiaSP = (int)row["GIASP"];
        }
        private string tenSP;
        private int giaSP;

        public string TenSP { get => tenSP; set => tenSP = value; }
        public int GiaSP { get => giaSP; set => giaSP = value; }
    }
}
