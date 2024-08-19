using QuanLyCafe_FormNew.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe_FormNew.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        internal static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }
        public static int TableWidth = 95;
        public static int TableHeigh = 90;
        public static int MenuWidth = 140;
        public static int MenuHeigh = 150;
        private TableDAO() { }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.USP_GetTableList");

            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }
        public List<Menuu> LoadMenuList()
        {
            List<Menuu> menuList = new List<Menuu>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.USP_GetMenuList");

            foreach (DataRow item in data.Rows)
            {
                Menuu menu = new Menuu(item);
                menuList.Add(menu);
            }

            return menuList;
        }
    }
}
