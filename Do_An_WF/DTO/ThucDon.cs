using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_WF.DTO
{
    class ThucDon
    {
        string ma, ten, donvitinh,trangthai;
        decimal dongia;
        string tenloai;

        public ThucDon() { }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Donvitinh { get => donvitinh; set => donvitinh = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public decimal Dongia { get => dongia; set => dongia = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }

        public ThucDon(string ma,string ten,string donvitinh,string trangthai,decimal dongia,string tenloai)
        {
            this.ma = ma;
            this.ten = ten;
            this.donvitinh = donvitinh;
            this.trangthai = trangthai;
            this.dongia = dongia;
            this.tenloai = tenloai;
        }
        public ThucDon(DataRow row)
        {
            this.ma = row["IdThucDon"].ToString();
            this.ten = row["TenThucDon"].ToString();
            this.donvitinh = row["DonViTinh"].ToString();
            this.Trangthai = row["TrangThai"].ToString();
            this.Dongia = decimal.Parse(row["DonGia"].ToString());
            this.tenloai = row["TenLoaiThucDon"].ToString();

        }
    }
}
