using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_WF.DTO;
namespace Do_An_WF.DAO
{
    class NhanVienDAO
    {
        private static volatile NhanVienDAO instance;
        private NhanVienDAO() { }

        internal static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
            private set => instance = value;
        }
        public List<NhanVien> GetListNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            string query = "Select * From NhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhanVien nv = new NhanVien(item);
                list.Add(nv);
            }
            return list;
        }
        public bool ThemNV(string ma, string ten, DateTime ngaysinh, string gioitinh,decimal luong,string dienthoai,string gmail, string chucvu)
        {
           
            string query = "Pro_ThemNhanVien @Id , @Ten , @ngaysinh , @gioitinh , @luong , @dienthoai , @gmail , @chucvu";
            int res = DataProvider.Instance.ExcuteNonQuery(query,new object[] { ma, ten,ngaysinh,gioitinh,luong,dienthoai,gmail,chucvu});
            return res > 0;
        }
        public bool XoaNV(string ma)
        {
            string query = "Pro_XoaNhanVien @Id ";
            return DataProvider.Instance.ExcuteNonQuery(query,new object[] {ma }) > 0;
        }
        public bool SuaNV(string ma, string ten, DateTime ngaysinh, string gioitinh, decimal luong, string dienthoai, string gmail, string chucvu)
        {

            string query = "Pro_SuaNv @Id , @Ten , @ngaysinh , @gioitinh , @luong , @dienthoai , @gmail , @chucvu";
            int res = DataProvider.Instance.ExcuteNonQuery(query,new object[] { ma, ten, ngaysinh, gioitinh, luong, dienthoai, gmail, chucvu });
            return res > 0;
        }
        public List<NhanVien> timKiem(string find)
        {
            List<NhanVien> list = new List<NhanVien>();
            string query = "Pro_TimKiemNv @find";
           // DataProvider.Instance.ExecuteQuery(query);
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { find });
            foreach (DataRow item in data.Rows)
            {
                NhanVien nv = new NhanVien(item);
                list.Add(nv);
            }
            return list;
        }
    }
}
