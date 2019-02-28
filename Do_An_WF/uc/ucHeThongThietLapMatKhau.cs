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
namespace Do_An_WF.uc
{
    public partial class ucHeThongThietLapMatKhau : UserControl
    {
        public ucHeThongThietLapMatKhau()
        {
            InitializeComponent();
            txtTaiKhoan.Text = FormLogin.taikhoan;

            txtTaiKhoan.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
          if(txtMatKhauCu.Text.Equals(FormLogin.matkhau)==false)
            {
                MyMesseage.ShowMessage("Mật khẩu không chính xác ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           DialogResult res = MyMesseage.ShowMessage("Bạn có muốn thay đổi mật khẩu ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
                return;

            try
            {
                LoginDAO.Instance.DoiMatKhau(txtTaiKhoan.Text, txtMatKhauMoi.Text);
                MyMesseage.ShowMessage("Đổi mật khẩu thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MyMesseage.ShowMessage("Lỗi khi đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
