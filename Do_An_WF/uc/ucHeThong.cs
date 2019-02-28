using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_WF.uc
{
    public partial class ucHeThong : UserControl
    {
        public ucHeThong()
        {
            InitializeComponent();
        }

        private void btnThietLap_Click(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();
            ucHeThongThietLapMatKhau uc = new ucHeThongThietLapMatKhau();
            uc.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(uc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(FormLogin.quyen!=1)
            {
                MyMesseage.ShowMessage("Bạn không có quyền này ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.panelMain.Controls.Clear();
            ucHeThongXemTatCaThongTin uc = new ucHeThongXemTatCaThongTin();
            uc.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(uc);
        }
    }
}
