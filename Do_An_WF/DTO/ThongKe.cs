using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_WF.DTO
{
    class ThongKe
    {
        string mahoadon,mathucdon, tenthucdon;
        int soluong;
        decimal dongia, thanhtien;
        DateTime ngay;


        public string Mahoadon { get => mahoadon; set => mahoadon = value; }
        public string Mathucdon { get => mathucdon; set => mathucdon = value; }
        public string Tenthucdon { get => tenthucdon; set => tenthucdon = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public decimal Dongia { get => dongia; set => dongia = value; }
        public decimal Thanhtien { get => thanhtien; set => thanhtien = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        
        public ThongKe() { }
        public ThongKe(string mahd,string matd,string tentd,int soluong,decimal dongia,decimal thanhtien,DateTime ngay)
        {
            this.mahoadon = mahd;
            this.mathucdon = matd;
            this.tenthucdon = tentd;
            this.soluong = soluong;
            this.dongia = dongia;
            this.thanhtien = thanhtien;
            this.ngay = ngay;
        }
        public ThongKe(DataRow row)
        {
            this.mahoadon = row["IdHoaDon"].ToString();
            this.mathucdon = row["IdThucDon"].ToString();
            this.tenthucdon = row["TenThucDon"].ToString();
            this.soluong = int.Parse(row["Soluong"].ToString());
            this.dongia = decimal.Parse(row["DonGia"].ToString());
            this.thanhtien = decimal.Parse(row["ThanhTien"].ToString());
            this.ngay = Convert.ToDateTime(row["GioDen"].ToString());
        }

    }
}
