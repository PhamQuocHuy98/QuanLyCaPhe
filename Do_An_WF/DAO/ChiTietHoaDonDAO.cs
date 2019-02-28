using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_WF.DTO;
namespace Do_An_WF.DAO
{
    class ChiTietHoaDonDAO
    {
        private static  ChiTietHoaDonDAO instance;
        private ChiTietHoaDonDAO() { }

        internal static ChiTietHoaDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new ChiTietHoaDonDAO();
                return instance;
            }
            private set => instance = value;
        }
        
        public bool ThemCTHD(string mahd,string mathucdon,int soluong,decimal dongia)
        {
            string query = "PRO_ThemCTHD @Idhoadon , @Idthucdon , @soluong , @dongia";
            return DataProvider.Instance.ExcuteNonQuery(query,new object[] { mahd, mathucdon, soluong, dongia })>0;

        }
        public bool XoaCTHD(string idthucdon)
        {
            string query = "PRO_XoaCTHD @Idthucdon";
            return DataProvider.Instance.ExcuteNonQuery(query,new object[] { idthucdon}) > 0;
        }
    }
}
