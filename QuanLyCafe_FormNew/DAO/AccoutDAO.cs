using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe_FormNew.DAO
{
    public class AccoutDAO
    {
        private static AccoutDAO instance;
        public static AccoutDAO Instance
        {
            get{if (instance == null) instance = new AccoutDAO();return instance; }
            private set { instance = value; }
        }

        private AccoutDAO() { }

        public bool LoginNV(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] {userName,passWord});
            return result.Rows.Count > 0 ;
        }
        public bool LoginKH(string userName, string passWord)
        {
            string query = "USP_LoginKH @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }

    }
}
