using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_WF.DTO
{
    class HoaDon
    {
        private string idhoadon;
        private string idban;
        private DateTime ngaylap;
        private decimal thanhtien;

        public string Idhoadon { get => idhoadon; set => idhoadon = value; }
        public string Idban { get => idban; set => idban = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public decimal Thanhtien { get => thanhtien; set => thanhtien = value; }

        public HoaDon() { }
        public HoaDon(string idhoadon, string idban, DateTime ngaylap, decimal thanhtien)
        {
            this.Idhoadon = idhoadon;
            this.idban = idban;
            this.ngaylap = ngaylap;
            this.thanhtien = thanhtien;
        }
        public HoaDon(DataRow row)
        {
            this.Idhoadon = row["IdHoaDon"].ToString();
            this.idban = row["IdBan"].ToString();
            this.ngaylap = Convert.ToDateTime(row["GioDen"]);
            this.thanhtien = decimal.Parse(row["TongTien"].ToString());
        }
    }
}
