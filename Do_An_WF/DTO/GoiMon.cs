using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_WF.DTO
{
    class GoiMon
    {
        private string maban, mathucdon, tenthucdon;
        private int soluong;
        private decimal dongia;
        private DateTime thoigian;
        private decimal thanhtien;

        public string Maban { get => maban; set => maban = value; }
        public string Mathucdon { get => mathucdon; set => mathucdon = value; }
        public string Tenthucdon { get => tenthucdon; set => tenthucdon = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public decimal Dongia { get => dongia; set => dongia = value; }
        public DateTime Thoigian { get => thoigian; set => thoigian = value; }
        public decimal Thanhtien { get => thanhtien; set => thanhtien = value; }
        public GoiMon() { }
        public GoiMon(string maban, string mathucdon, string tenthucdon, int soluong, decimal Dongia, DateTime thoigian, decimal thanhtien)
        {
            this.Maban = maban;
            this.Mathucdon = mathucdon;
            this.Tenthucdon = tenthucdon;
            this.Soluong = soluong;
            this.dongia = Dongia;
            this.Thoigian = thoigian;
            this.Thanhtien = thanhtien;
        }
        public GoiMon(DataRow row)
        {
            this.maban = row["IdBan"].ToString();
            this.mathucdon = row["IdThucDon"].ToString();
            this.tenthucdon = row["TenThucDon"].ToString();
            this.soluong = int.Parse(row["SoLuong"].ToString());
            this.dongia = decimal.Parse(row["DonGia"].ToString());
            this.thoigian = DateTime.Parse(row["ThoiGian"].ToString());
            if (row["ThanhTien"].ToString() != "")
                this.Thanhtien = decimal.Parse(row["ThanhTien"].ToString());
            else this.thanhtien = 0;
        }
    }
}
