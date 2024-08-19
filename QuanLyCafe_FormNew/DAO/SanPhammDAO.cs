using QuanLyCafe_FormNew.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe_FormNew.DAO
{
    class SanPhammDAO
    {
        private static SanPhammDAO instance;

        public static SanPhammDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanPhammDAO();
                return SanPhammDAO.instance;
            }
            private set { SanPhammDAO.instance = value; }
        }
        private SanPhammDAO() { }

        public List<SanPhamm> GetFoodByID(string id)
        {
            List<SanPhamm> listSP = new List<SanPhamm>();
            string query = $"select TENSP,GIASP from dbo.SANPHAM where MASP = '{id}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SanPhamm sp = new SanPhamm(item);
                listSP.Add(sp);
            }
            return listSP;
        }

    }
}
