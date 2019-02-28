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
using Do_An_WF.DTO;
namespace Do_An_WF
{
    public partial class FormThemBan : Form
    {
        public FormThemBan()
        {
            InitializeComponent();

            txtMaBan.Text = ma;
            txtTenBan.Text = ten;
            cmbTrangThai.Text = trangthai;
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            uc.ucBan.kiemtracanelhayok = false;
            this.Close();
        }
        public static string ma="", ten="", trangthai="",luachon="";
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(luachon=="Them")
            {
                DialogResult res = MyMesseage.ShowMessage("Bạn Có Muốn Thêm " + txtTenBan.Text + " Không ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;
                try
                {
                    BanDAO.Instance.ThemBan(txtMaBan.Text, txtTenBan.Text, cmbTrangThai.Text);

                    MyMesseage.ShowMessage("Thêm " + txtTenBan.Text + " thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MyMesseage.ShowMessage("Lỗi khi thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(luachon=="Sua")
            {
                DialogResult res = MyMesseage.ShowMessage("Bạn Có Muốn Sửa " + txtTenBan.Text + " Không ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;
                try
                {
                    BanDAO.Instance.SuaBan(txtMaBan.Text,txtTenBan.Text, cmbTrangThai.Text);
                    this.Close();
                    MyMesseage.ShowMessage("Cập nhật " + txtTenBan.Text + " thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MyMesseage.ShowMessage("Lỗi khi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   // MessageBox.Show(ex.Message);
                }
            }
            uc.ucBan.kiemtracanelhayok = true;

        }
    }
}
