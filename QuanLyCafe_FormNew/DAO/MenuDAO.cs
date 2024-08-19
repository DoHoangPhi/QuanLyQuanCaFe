using QuanLyCafe_FormNew.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe_FormNew.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MenuDAO();
                return MenuDAO.instance;
            }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }

        public List<MenuTG> GetListMenuTGByTable(string id)
        {
            List<MenuTG> listMenu = new List<MenuTG>();
            string query = $"SELECT * FROM dbo.GetSalesDataTable('{id}');";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                MenuTG mn = new MenuTG(item);
                listMenu.Add(mn);
            }    
            return listMenu;
        }
    }
}
