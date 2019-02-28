using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_WF.DTO;
namespace Do_An_WF.DAO
{
    class ThucDonDAO
    {
        private static volatile ThucDonDAO instance;
        private ThucDonDAO() { }

        internal static ThucDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThucDonDAO();
                return instance;
            }
            private set => instance = value;
        }
        public List<ThucDon> GetListThucDon()
        {
            List<ThucDon> list = new List<ThucDon>();
            string query = "Select * From ThucDon";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ThucDon td = new ThucDon(item);
                list.Add(td);
            }
            return list;
        }
        public bool ThemTD(string ma, string ten, string donvitinh,string trangthai, decimal dongia, string tenloai)
        {

            string query = "PRO_ThemThucDon @Id , @Ten , @donvitinh , @trangthai , @dongia , @tenloai";
            int res = DataProvider.Instance.ExcuteNonQuery(query,new object[] { ma, ten, donvitinh, trangthai, dongia, tenloai });
            return res > 0;
        }
        public bool XoaTD(string ma)
        {
            string query = "Pro_XoaThucDon @Id";
            return DataProvider.Instance.ExcuteNonQuery(query,new object[] { ma }) > 0;
        }
        public bool SuaTD(string ma, string ten, string donvitinh, string trangthai, decimal dongia, string tenloai)
        {

            string query = "Pro_SuaThucDon @Id , @Ten , @donvitinh , @trangthai , @dongia , @tenloai";
            int res = DataProvider.Instance.ExcuteNonQuery(query,new object[] { ma, ten, donvitinh, trangthai, dongia, tenloai });
            return res > 0;
        }
        public List<ThucDon> timKiem(string find)
        {
            List<ThucDon> list = new List<ThucDon>();
            string query = "PRO_TimKiemTD @find";
            //   DataProvider.Instance.ExcuteQuery(query, new object[] { });
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { find });
            foreach (DataRow item in data.Rows)
            {
                ThucDon td = new ThucDon(item);
                list.Add(td);
            }
            return list;
        }

    }
}
