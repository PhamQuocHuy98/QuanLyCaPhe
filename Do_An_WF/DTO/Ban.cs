using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_WF.DTO
{
    class Ban
    {
        string maban, tenban, trangthai;

        public string Maban { get => maban; set => maban = value; }
        public string Tenban { get => tenban; set => tenban = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }

        public Ban() { }
        public Ban(string maban,string tenban,string trangthai)
        {
            this.maban = maban;
            this.tenban = tenban;
            this.trangthai = trangthai;
        }
        public Ban(DataRow row)
        {
            this.maban = row["IdBan"].ToString();
            this.tenban = row["TenBan"].ToString();
            this.trangthai = row["TrangThai"].ToString();
        }
    }

}
