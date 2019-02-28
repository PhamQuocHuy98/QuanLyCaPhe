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
    public partial class ucHeThongXemTatCaThongTin : UserControl
    {
        public ucHeThongXemTatCaThongTin()
        {
            InitializeComponent();
        }

        private void ucHeThongXemTatCaThongTin_Load(object sender, EventArgs e)
        {
            gvDanhSach.DataSource = LoginDAO.Instance.LayDanhSach();
        }

       
        private void gvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gvDanhSach.CurrentRow;
            txtTaiKhoan.Text = row.Cells[0].Value.ToString();
            txtMatKhau.Text = row.Cells[1].Value.ToString();
            txtQuyen.Text = row.Cells[2].Value.ToString();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MyMesseage.ShowMessage("Bạn có muốn thêm " + txtTaiKhoan.Text + " ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res==DialogResult.No)
            {
                return;
            }
            try
            {
                LoginDAO.Instance.Them(txtTaiKhoan.Text, txtMatKhau.Text, int.Parse(txtQuyen.Text));
                MyMesseage.ShowMessage("Thêm thành công ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucHeThongXemTatCaThongTin_Load(sender, e);
            }
            catch(Exception ex)
            {
                MyMesseage.ShowMessage("Lỗi khi thêm ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text=="")
            {
                MyMesseage.ShowMessage("Chọn dữ liệu để xóa ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult res = MyMesseage.ShowMessage("Bạn có muốn xóa " + txtTaiKhoan.Text + " ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                return;
            }
            try
            {
                LoginDAO.Instance.Xoa(txtTaiKhoan.Text);
                ucHeThongXemTatCaThongTin_Load(sender, e);
                MyMesseage.ShowMessage("Xóa thành công ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MyMesseage.ShowMessage("Xóa thất bại ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult res = MyMesseage.ShowMessage("Bạn có muốn sửa " + txtTaiKhoan.Text + " ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                return;
            }
            try
            {
                LoginDAO.Instance.Sua(txtTaiKhoan.Text, txtMatKhau.Text, int.Parse(txtQuyen.Text));
                MyMesseage.ShowMessage("Sửa thành công ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucHeThongXemTatCaThongTin_Load(sender, e);
            }
            catch (Exception ex)
            {
                MyMesseage.ShowMessage("Lỗi khi sửa ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
