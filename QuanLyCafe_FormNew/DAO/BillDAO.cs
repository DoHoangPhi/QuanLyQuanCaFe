using QuanLyCafe_FormNew.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe_FormNew.DAO
{
    class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value;  }
        }
        private BillDAO() { }
        public string GetUncheckBillIDByTableID(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery($"SELECT* FROM dbo.HDBANHANG WHERE NGAYHDBH = '2023-09-19' and IDBAN = '{id}'");

            if (data.Rows.Count>0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.IDHD;
            }
            return "";
        }

        public void InsertBill(string id, int tongtien)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBil @idTable , @tongtien", new object[] {$"{id}",tongtien});
        }
        public string GetMaxIDBill()
        {
            try
            {
                return (string)DataProvider.Instance.ExecuteScaler("Select MAX(MAHDBH) from dbo.HDBANHANG");
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
