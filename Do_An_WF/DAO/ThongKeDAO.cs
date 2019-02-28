using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_WF.DTO;
namespace Do_An_WF.DAO
{
    class ThongKeDAO
    {
        private static ThongKeDAO instance;

        internal static ThongKeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongKeDAO();
                }
                return instance;
            }
            set => instance = value;
        }

        public List<ThongKe> GetLissThongKe(string tungay,string denngay)
        {
            List<ThongKe> list = new List<ThongKe>();
            string query = string.Format("select a.IdHoaDon, a.IDThucDon ,c.tenthucdon, soluong, a.dongia ,Thanhtien=soluong*a.dongia,GioDen from ChiTietHoaDon a, HoaDon b, ThucDon c where a.IdHoaDon = b.IdHoaDon  and a.IdThucDon = c.IdThucDon and GioDen between N'{0}' and N'{1}'",tungay,denngay);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ThongKe tk = new ThongKe(item);
                list.Add(tk);
            }
            return list;
        }
    }
}
