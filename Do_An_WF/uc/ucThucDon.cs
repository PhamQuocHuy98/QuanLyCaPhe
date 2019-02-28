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
    public partial class ucThucDon : UserControl
    {
        public ucThucDon()
        {
            InitializeComponent();
        }
        List<ThucDon> list;
        private void ucThucDon_Load(object sender, EventArgs e)
        {
            list = ThucDonDAO.Instance.GetListThucDon();
            gvThucDon.DataSource = list;


            cmbTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            
            foreach (ThucDon item in list)
            {
                cmbTimKiem.AutoCompleteCustomSource.Add(item.Ma);
                cmbTimKiem.AutoCompleteCustomSource.Add(item.Ten);
                cmbTimKiem.AutoCompleteCustomSource.Add(item.Tenloai);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemThucDon.ma = "";
            FormThemThucDon.ten = "";
            FormThemThucDon.donvitinh = "";
            FormThemThucDon.trangthai = "";
            FormThemThucDon.dongia = "";
            FormThemThucDon.tenloai = "";
            FormThemThucDon.chucnang = "Them";
            FormThemThucDon frm = new FormThemThucDon();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            ucThucDon_Load(sender, e);
            //MessageBox.Show("")
        }
        int index = -1;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            //int index = gvThucDon.CurrentRow.Cells["Ma"]
            if (index == -1)
            {
                MessageBox.Show("Bạn Chưa Chọn Dòng Để Xóa");
                return;
            }
            try
            {
                string ma = gvThucDon.Rows[index].Cells[0].Value.ToString();
                MessageBox.Show(ma);
                //GoiMonDAO.Instance.XoaMon()
                ChiTietHoaDonDAO.Instance.XoaCTHD(ma);
                ThucDonDAO.Instance.XoaTD(ma);
                ucThucDon_Load(sender, e);
                MyMesseage.ShowMessage("Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // MyMesseage.ShowMessage("Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }

        private void gvThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (index == -1 || index >= gvThucDon.RowCount)
            {
                MessageBox.Show("Vui Lòng Chọn Thực Đơn Để Sửa");
                return;
            }
            FormThemThucDon.ma = gvThucDon.Rows[index].Cells[0].Value.ToString();
            FormThemThucDon.ten = gvThucDon.Rows[index].Cells[1].Value.ToString();
            FormThemThucDon.donvitinh = gvThucDon.Rows[index].Cells[2].Value.ToString();
            FormThemThucDon.trangthai = gvThucDon.Rows[index].Cells[3].Value.ToString();
            FormThemThucDon.dongia = gvThucDon.Rows[index].Cells[4].Value.ToString();
            FormThemThucDon.tenloai = gvThucDon.Rows[index].Cells[5].Value.ToString();
            FormThemThucDon.chucnang = "Sua";
            FormThemThucDon frm = new FormThemThucDon();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();

            ucThucDon_Load(sender, e);
        }
    
        private void cmbTimKiem_TextChanged(object sender, EventArgs e)
        {
            
            cmbTimKiem.Text = cmbTimKiem.Text.Replace("'", "");
            try
            {
                gvThucDon.DataSource = ThucDonDAO.Instance.timKiem(cmbTimKiem.Text);
            }
            catch(Exception ex)
            {
                MyMesseage.ShowMessage("Lỗi khi tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
