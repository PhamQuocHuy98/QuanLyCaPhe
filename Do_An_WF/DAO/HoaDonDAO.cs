using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_WF.DTO;
namespace Do_An_WF.DAO
{
    class HoaDonDAO
    {
        private static HoaDonDAO instance;

        private HoaDonDAO() { }
        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new HoaDonDAO();
                return HoaDonDAO.instance;

            }
            set => instance = value;
        }
        public List<HoaDon> LayDanhSachHoaDon()
        {
            string query = "Select * from HoaDon";
            List<HoaDon> list = new List<HoaDon>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                HoaDon hd = new HoaDon(row);
                list.Add(hd);
            }
            return list;
        }
        public List<string> LayDanhSachMaHoaDon()
        {
            string query = "Select * from HoaDon";
            List<string> list = new List<string>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                HoaDon hd = new HoaDon(row);
                list.Add(hd.Idhoadon);
            }
            return list;
        }
        public bool ThemHoaDon(string idHoaDon, string idban, DateTime ngaylap, decimal sotien)
        {
            string query = "PRO_ThemHoaDon @Idhoadon , @Idban , @ngaylap , @sotien";
            int res = DataProvider.Instance.ExcuteNonQuery(query,new object[] { idHoaDon, idban, ngaylap, sotien });
            return res > 0;
        }
    }
}
