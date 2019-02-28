using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_WF.DTO
{
    class ChiTietHoaDon
    {
        string mahoadon, mathucdon;
        int soluong;
        decimal dongia;

        public ChiTietHoaDon() { }
        public ChiTietHoaDon(string mahoadon,string mathucdon,int soluong,decimal dongia)
        {
            this.mahoadon = mahoadon;
            this.mathucdon = mathucdon;
            this.soluong = soluong;
            this.dongia = dongia;
        }
        public ChiTietHoaDon(DataRow row)
        {
            this.mahoadon = row["IdHoaDon"].ToString();
            this.mathucdon = row["IdThucDon"].ToString();
            this.soluong = int.Parse(row["Soluong"].ToString());
            this.dongia = int.Parse(row["DonGia"].ToString());
        }
        public string Mahoadon { get => mahoadon; set => mahoadon = value; }
        public string Mathucdon { get => mathucdon; set => mathucdon = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public decimal Dongia { get => dongia; set => dongia = value; }
    }
}
