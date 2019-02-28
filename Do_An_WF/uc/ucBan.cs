using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An_WF.DAO;
using Do_An_WF.DTO;
namespace Do_An_WF.uc
{
    public partial class ucBan : UserControl
    {
        public ucBan()
        {
            InitializeComponent();

        }
        public static string banhienthihoadon = "";
        public static decimal sumtien = 0;
        List<Ban> list;
        List<GoiMon> listgm;
        void LoadBan()
        {
            flowtable.Controls.Clear();
            list = BanDAO.Instance.GetListBan();
            foreach (Ban item in list)
            {
                Button btn = new Button() { Width = 155, Height = 150 };
                //    btn.Size = new Size()
                btn.Name = item.Maban;

                btn.ForeColor = Color.White;
                btn.Click += Btn_Click;
                btn.MouseHover += Btn_MouseHover;
                btn.MouseLeave += Btn_MouseLeave;
                btn.BackColor = Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
                btn.ContextMenuStrip = contextMenuStrip1;
                if (!item.Trangthai.Equals("Còn Trống"))
                {
                    btn.BackgroundImage =new Bitmap(Application.StartupPath+"\\Images\\anhban1.png");
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    // MessageBox.Show(item.Maban);
                }


                btn.Text = item.Tenban;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

                flowtable.Controls.Add(btn);
            }
        }
        private void ucBan_Load(object sender, EventArgs e)
        {
            lvDanhSach.Visible = false;
            LoadBan();
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button but = sender as Button;
            //
            //  but.BackgroundImage = Image.FromFile("D:\\Do_An_WF\\Do_An_WF\\bin\\Debug\\Images/anhban1.png");
            //  but.BackgroundImageLayout = ImageLayout.Stretch;
            but.ForeColor = Color.White;
            but.TextAlign = ContentAlignment.BottomCenter;
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            Button but = sender as Button;
            // but.BackgroundImage = null;
            but.ForeColor = Color.White;
            but.TextAlign = ContentAlignment.MiddleCenter;
            but.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            lvDanhSach.Visible = true;
            sumtien = 0;
            Button btn = ((sender as Button));
            //MessageBox.Show("Click Ban " + btn.Name);
            maban = btn.Name;
            banhienthihoadon = maban;

            // Hiên thị danh sách gọi món lên lisview

            lvDanhSach.Items.Clear();
            listgm = GoiMonDAO.Instance.DanhSachGoiMonLenLV(maban);
            foreach (GoiMon item in listgm)
            {
                ListViewItem lv = new ListViewItem(item.Maban);
                lv.SubItems.Add(item.Tenthucdon);
                lv.SubItems.Add(item.Soluong.ToString());
                lv.SubItems.Add(item.Dongia.ToString());
                decimal thanhtien = item.Soluong * item.Dongia;
                lv.SubItems.Add(thanhtien.ToString());
                lvDanhSach.Items.Add(lv);
                sumtien += thanhtien;
            }

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            // BanDAO.Instance.ThemBan()
            FormThemBan.luachon = "Them";
            FormThemBan frm = new FormThemBan();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (kiemtracanelhayok == true)
                ucBan_Load(sender, e);
        }
        string maban = "";
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maban == "") return;
            BanDAO.Instance.XoaBan(maban);

            ucBan_Load(sender, e);

        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            //FormGoiMon frm = new FormGoiMon();
            //frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.ShowDialog();
        }
        public static bool kiemtracanelhayok = true;
        private void btnSua_Click(object sender, EventArgs e)
        {

            if (maban == "")
            {
                MessageBox.Show("Chọn Bàn để sửa");
                return;
            }
            FormThemBan.ma = maban;
            foreach (Ban item in list)
            {
                if (item.Maban == maban)
                {
                    FormThemBan.ten = item.Tenban;
                    FormThemBan.trangthai = item.Trangthai;
                    FormThemBan.luachon = "Sua";
                    break;
                }
            }
            // FormThemBan.ten = btn.Text;
            FormThemBan frm = new FormThemBan();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
            // DialogResult res = FormThemBan.Yes
            if (kiemtracanelhayok == true)
                ucBan_Load(sender, e);
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            // hiển thị form nhập bàn cần chuyển -> bàn đích.
            //if(banhienthihoadon)
            FormChuyenGopBan.luachon = "ChuyenBan";
            FormChuyenGopBan frm = new FormChuyenGopBan();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();


            ucBan_Load(sender, e);
        }

        private void btnGopBan_Click(object sender, EventArgs e)
        {
            FormChuyenGopBan.luachon = "GopBan";
            FormChuyenGopBan frm = new FormChuyenGopBan();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();


            ucBan_Load(sender, e);
        }
        void ThemHoaDon(string mahoadon, string maban, DateTime ngaylap, decimal sotien)
        {
            HoaDonDAO.Instance.ThemHoaDon(mahoadon, maban, ngaylap, sotien);
        }
        void MaHoaDonTuDongTang()
        {
            List<string> mahoadon = HoaDonDAO.Instance.LayDanhSachMaHoaDon();
            string ma = "";
            if (mahoadon.Count <= 0)
            {
                ma = "HD0000001";
            }
            else
            {
                int max = 0;
                ma = "HD";
                foreach (string i in mahoadon)
                {
                    if (max < Convert.ToInt32(i.Substring(2, 7)))
                        max = Convert.ToInt32(i.Substring(2, 7));
                }
                max += 1;
                if (max < 10)
                {
                    ma = ma + "000000";
                }
                else if (max < 100)
                {
                    ma = ma + "00000";
                }
                else if (max < 1000)
                {
                    ma = ma + "0000";
                }
                else if (max < 10000)
                {
                    ma = ma + "000";
                }
                else if (max < 100000)
                {
                    ma = ma + "00";
                }
                else if (max < 1000000)
                {
                    ma = ma + "0";
                }
                ma = ma + max.ToString();

            }
            ThemHoaDon(ma, banhienthihoadon, DateTime.Now, sumtien);
            foreach (GoiMon item in listgm)
            {
                ChiTietHoaDonDAO.Instance.ThemCTHD(ma, item.Mathucdon, item.Soluong, item.Dongia);
            }


        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult res = MyMesseage.ShowMessage("Thanh toán bàn " + banhienthihoadon + " ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;
            if (banhienthihoadon == "")
            {
                MessageBox.Show("Chọn bàn để thanh toán");
                return;
            }
            try
            {
                FormHoaDon frm = new FormHoaDon();
                //frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();

                // Mã Hóa Đơn Tự Động Tăng
                MaHoaDonTuDongTang();
                GoiMonDAO.Instance.XoaTatCa(banhienthihoadon);
                string tenban = banhienthihoadon;
                tenban = tenban.Remove(0, 1);
                BanDAO.Instance.SuaBan(banhienthihoadon, "Bàn " + tenban, "Còn Trống");
                MyMesseage.ShowMessage("Thanh toán thành công ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucBan_Load(sender, e);
            }
            catch (Exception ex)
            {
                MyMesseage.ShowMessage("Thanh toán thất bại ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }

        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucBan_Load(sender, e);
        }

        private void chuyểnBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnChuyenBan.PerformClick();
        }

        private void gọpBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnGopBan.PerformClick();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThanhToan.PerformClick();
        }
    }
}
