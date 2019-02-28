using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_WF.DTO
{
    class Login
    {
        private string taikhoan, matkhau;
        private int quyen;

        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public int Quyen { get => quyen; set => quyen = value; }

        public Login() { }

        public Login(string taikhoan,string matkhau,int quyen)
        {
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.quyen = quyen;
        }

        public Login(DataRow row)
        {
            this.taikhoan = row["Username"].ToString();
            this.matkhau = row["Pass"].ToString();
            this.quyen = int.Parse(row["quyen"].ToString());
        }

    }
}
