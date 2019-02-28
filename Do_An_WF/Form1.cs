using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An_WF.uc;
namespace Do_An_WF
{
    public partial class FormMain : Form
    {
        Timer time = new Timer();
        public FormMain()
        {
            InitializeComponent();
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            lblThongtin.Text = "Xin chào " + FormLogin.taikhoan;

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void ptcClose_Click(object sender, EventArgs e)
        {
            DialogResult res = MyMesseage.ShowMessage("Bạn Có Muốn Thoát Không ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                this.Close();
            
        }
        public void NoiDungUserControl(string tenuc)
        {
            // xóa hết các usercontrol trên pannel content
           
            /*foreach (UserControl uc in panelContainer.Controls.OfType<UserControl>())
            {
                uc.Dispose();
            }*/
            panelContainer.Controls.Clear();
            if (tenuc == "ucNhanVien")
            {
                ucNhanVien uc = new ucNhanVien();
                uc.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(uc);
                //panelContainer.Controls["ucNhanVien"].BringToFront();
            }
            else if (tenuc == "ucThucDon")
            {
                ucThucDon ucthucdon = new ucThucDon();
                ucthucdon.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(ucthucdon);
                // panelContainer.Controls["ucThucDon"].BringToFront();
            }
            else if (tenuc == "ucTrangChu")
            {
                ucTrangChu uc = new ucTrangChu();
                uc.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(uc);
            }
            else if (tenuc == "ucBan")
            {
                ucBan uc = new ucBan();
                uc.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(uc);

            }
            else if (tenuc == "ucGoiMon")
            {
                ucGoiMon uc = new ucGoiMon();
                uc.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(uc);
                // panelContainer.Dock = DockStyle.Fill;

            }
            else if(tenuc=="ucThongKe")
            {
                ucThongKe uc = new ucThongKe();
                uc.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(uc);
            }
            else if(tenuc=="ucHeThong")
            {
                ucHeThong uc = new ucHeThong();
                uc.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(uc);
            }
            else if(tenuc=="ucThongTin")
            {
                ucThongTin uc = new ucThongTin();
                uc.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(uc);
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            time.Interval = 1000;
            time.Tick += Time_Tick;
            time.Start();
            btnTrangChu.PerformClick();

        }

        private void Time_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = DateTime.Now.ToString("HH:mm:ss:tt");
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            
            NoiDungUserControl("ucNhanVien");
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            
            NoiDungUserControl("ucThucDon");
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            NoiDungUserControl("ucTrangChu");
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            NoiDungUserControl("ucBan");
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            NoiDungUserControl("ucGoiMon");
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            NoiDungUserControl("ucThongTin");
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if(FormLogin.quyen!=1)
            {
                MyMesseage.ShowMessage("Bạn không có quyền này", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NoiDungUserControl("ucThongKe");
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            NoiDungUserControl("ucHeThong");
        }
    }
}
