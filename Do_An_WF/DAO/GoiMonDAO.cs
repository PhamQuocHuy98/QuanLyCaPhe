using Do_An_WF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_WF.DAO
{
    class GoiMonDAO
    {
        private static volatile GoiMonDAO instance;
        private GoiMonDAO() { }

        internal static GoiMonDAO Instance
        {
            get
            {
                if (instance == null) instance = new GoiMonDAO();
                return instance;
            }
            private set => instance = value;
        }
        public List<GoiMon> GetListGoiMon()
        {
            List<GoiMon> list = new List<GoiMon>();
            string query = "select * from GoiMon";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                GoiMon gm = new GoiMon(item);
                list.Add(gm);
            }
            return list;
        }
        public List<GoiMon> DanhSachGoiMonLenLV(string id)
        {
            List<GoiMon> list = new List<GoiMon>();

            string query = "Pro_DanhSachGoiMonLenLV @id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                GoiMon gm = new GoiMon(item);
                list.Add(gm);
            }
            return list;

        }
        
        public bool themMon(string maban, string mathucdon, string tenthucdon, decimal dongia, int soluong, DateTime thoigian, decimal thanhtien)
        {
            string query = "PRO_ThemGoiMon @IdBan , @IdThucDon , @tenthucdon , @dongia , @soluong , @thoigian , @thanhtien";
           // string query = string.Format("INSERT into GoiMon (IdBan,IdThucDon,TenThucDon,DonGia,SoLuong,ThoiGian,ThanhTien)VALUES(N'{0}',N'{1}',N'{2}','{3}','{4}',N'{5}','{6}')", maban, mathucdon, tenthucdon, dongia, soluong, thoigian.ToString("yyyy-MM-dd HH:mm:ss"), thanhtien);
            int res = DataProvider.Instance.ExcuteNonQuery(query,new object[] { maban,mathucdon,tenthucdon,dongia,soluong,thoigian,thanhtien});
            return res > 0;
        }

        public bool XoaMon(string IdBan, string IdThucDon)
        {
            string query = "PRO_XoaGoiMon @IdBan , @Idthucdon";
            int res = DataProvider.Instance.ExcuteNonQuery(query,new object[] { IdBan, IdThucDon });
            return res > 0;
        }

        public bool SuaMon(string maban, string mathucdon, int soluong, decimal thanhtien, string tenthucdon, decimal dongia, DateTime thoigian)
        {
            string query = "PRO_SuaGoiMon @IdBan , @IdThucDon , @tenthucdon , @dongia , @soluong , @thoigian , @thanhtien";
            return DataProvider.Instance.ExcuteNonQuery(query,new object[] {maban,mathucdon,tenthucdon,dongia,soluong,thoigian,thanhtien }) > 0;
        }
        public bool XoaTatCa(string IdBan)
        {
            string query = "PRO_XoaTatCatGoiMon @IdBan";
            int res = DataProvider.Instance.ExcuteNonQuery(query,new object[] { IdBan });
            return res > 0;
        }
    }
}
