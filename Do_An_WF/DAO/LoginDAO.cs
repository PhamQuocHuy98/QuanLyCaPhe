using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_WF.DTO;
namespace Do_An_WF.DAO
{
    class LoginDAO
    {
        private static LoginDAO instance;

        public LoginDAO() { }
        internal static LoginDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoginDAO();
                return instance;
            }
            set => instance = value;
        }
        public List<Login> LayDanhSach()
        {
            string query = "Select * from TaiKhoan";
            List<Login> list = new List<Login>();

            DataTable tb = DataProvider.Instance.ExecuteQuery(query,new object[]{});
            foreach(DataRow item in tb.Rows)
            {
                Login lg = new Login(item);
                list.Add(lg);
            }
            return list;
        }
      
        public int KiemTra(string taikhoan,string matkhau)
        {
            // return về quyền nv
            string query = "Pro_Login @user , @pass";
           // List<Login> list = new List<Login>();
            DataTable db = DataProvider.Instance.ExecuteQuery(query,new object[] { taikhoan, matkhau });
            if(db.Rows.Count==0)
            {
                return -1;
            }
            DataRow row = db.Rows[0];
            Login l = new Login(row);
            return l.Quyen;

        }
        public bool DoiMatKhau(string taikhoan,string matkhau)
        {
            string query = "PRO_DoiMatKhau @username , @pass";
            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { taikhoan, matkhau })>0;
        }
        public bool Them(string taikhoan,string matkhau,int quyen)
        {
            string query = "PRO_ThemTaiKhoan @taikhoan , @matkhau , @quyen ";
            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { taikhoan, matkhau, quyen }) >0;
        }
        public bool Xoa(string taikhoan)
        {
            string query = "PRO_XoaTaiKhoan @taikhoan";
            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { taikhoan })>0;
        }
        public bool Sua(string taikhoan, string matkhau, int quyen)
        {
            string query = "PRO_SuaTaiKhoan @taikhoan , @matkhau , @quyen ";
            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { taikhoan, matkhau, quyen }) > 0;
        }
    }
}
