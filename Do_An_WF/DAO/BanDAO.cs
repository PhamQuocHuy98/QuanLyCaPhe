using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_WF.DTO;
namespace Do_An_WF.DAO
{
    class BanDAO
    {
        private static BanDAO instance;

        internal static BanDAO Instance
        {
            get
            {
                if (instance == null)
                {
                   instance = new BanDAO();
                }
                return instance;
            }
            set => instance = value;
        }

        public List<Ban> GetListBan()
        {
            List<Ban> list = new List<Ban>();
            string query = "Select * From Ban";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Ban bn = new Ban(item);
                list.Add(bn);
            }
            return list;
        }
        public bool ThemBan(string maban,string tenban,string trangthai)
        {
            string query = "PRO_ThemBan @Idban , @Tenban , @Trangthai";
            return DataProvider.Instance.ExcuteNonQuery(query,new object[] {maban,tenban,trangthai })>0;
        }
        public bool XoaBan(string maban)
        {
            string query = "PRO_XoaBan @Idban";
            return DataProvider.Instance.ExcuteNonQuery(query,new object[] {maban }) > 0;
        }
        public bool SuaBan(string maban,string tenban,string trangthai)
        {
            string query = "PRO_SuaBan @Idban , @Tenban , @Trangthai";
            return DataProvider.Instance.ExcuteNonQuery(query,new object[] { maban, tenban, trangthai }) > 0;
        }
    }
}
