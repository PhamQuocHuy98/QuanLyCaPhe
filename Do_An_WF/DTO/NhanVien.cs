using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_WF.DTO
{
    class NhanVien
    {
        string ma, ten;
        DateTime ngaysinh;
        string gioitinh;
        decimal luong;
        string dienthoai,gmail;
        string chucvu;

        public NhanVien() { }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
       
        
        public decimal Luong { get => luong; set => luong = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }
        public string Gmail { get => gmail; set => gmail = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }

        public NhanVien(string ma, string ten, DateTime ngaysinh,string gioitinh, decimal luong,string dienthoai,string gmail, string chucvu)
        {
            this.ma = ma;
            this.ten = ten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.Luong = luong;
            this.dienthoai = dienthoai;
            this.gmail = gmail;
            this.chucvu = chucvu;
        }
        public NhanVien(DataRow row)
        {
            this.ma = row["IdNhanVien"].ToString();
            this.ten = row["TenNhanVien"].ToString();
            this.ngaysinh = Convert.ToDateTime(row["NgaySinh"]);
            this.gioitinh = row["GioiTinh"].ToString();
            this.Luong = decimal.Parse(row["Luong"].ToString());
            this.dienthoai = row["DienThoai"].ToString();
            this.gmail = row["Gmail"].ToString();
            this.chucvu = row["ChucVu"].ToString();
        }
    }
}
