using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An_WF.DAO;
namespace Do_An_WF
{
    public partial class FormLogin : Form
    {
        ErrorProvider er = new ErrorProvider();
        public FormLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

           // MessageBox.Show(t)

        }
        
        public static int quyen = -1;
        public static string taikhoan ="";
        public static string matkhau = "";
         // quyền 1 là admin // quyền 0 là nhân viên // quyền 2 là thu ngân.

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text.Trim()=="")
            {
                er.SetError(txtTaiKhoan, "Dữ liệu không hợp lệ");
                txtTaiKhoan.Focus();
                return;
            }
            if(txtMatKhau.Text.Trim()=="")
            {
                er.SetError(txtTaiKhoan, null);
                er.SetError(txtMatKhau, "Dữ liệu không hợp lệ");
                txtMatKhau.Focus();
                return;
            }
            er.SetError(txtMatKhau, null);
            try
            {
                taikhoan = txtTaiKhoan.Text;
                matkhau = txtMatKhau.Text;
                int res = LoginDAO.Instance.KiemTra(txtTaiKhoan.Text, txtMatKhau.Text);
                if (res == -1)
                {
                    MyMesseage.ShowMessage("Login thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                quyen = res;

                FormMain frm = new FormMain();
                //  frm.StartPosition = FormStartPosition.CenterScreen;
                //this.Close();
                frm.ShowDialog();
            }
            catch(Exception ex)
            {
                MyMesseage.ShowMessage("Login thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message); // xuất cái lỗi ra nè
            }
        }

        private void ptrclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if(txtMatKhau.Text!="")
                {
                    btnDangNhap_Click(sender, e);
                }
                else
                {
                    txtMatKhau.Focus();
                }
            }
        }
    }
}
