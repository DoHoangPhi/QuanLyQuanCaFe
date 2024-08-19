using QuanLyCafe_FormNew.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe_FormNew.DAO
{
    class BillinfoDAO
    {
        private static BillinfoDAO instance;

        internal static BillinfoDAO Instance
        {
            get { if (instance == null) instance = new BillinfoDAO(); return BillinfoDAO.instance; }
            private set { BillinfoDAO.instance = value; }
        }
        private BillinfoDAO() { }
        public List<Billinfo> GetListBillInfo(string id)
        {
            List<Billinfo> listBillInfo = new List<Billinfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery($"SELECT* FROM dbo.CHITIETBANHANG WHERE MAHDBH = '{id}'");

            foreach(DataRow item in data.Rows)
            {
                Billinfo info = new Billinfo(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }
        public bool CheckFoodExistInBill(string idFood)
        {
            string query = "SELECT COUNT(*) FROM Billinfo WHERE idFood = @idFood";
            object[] parameters = new object[] { idFood };

            int count = (int)DataProvider.Instance.ExecuteScaler(query, parameters);
            return count > 0;
        }
        public void InsertBillinfo(string idBill,string idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @idBill , @idFood , @count ", new object[] { $"{idBill}", $"{idFood}", count });
        }

    }
}
