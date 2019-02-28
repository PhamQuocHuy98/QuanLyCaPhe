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
    public partial class ucNhanVien : UserControl
    {
       
        public ucNhanVien()
        {
            InitializeComponent();
        }
        
        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            
            List<NhanVien> list = NhanVienDAO.Instance.GetListNhanVien();
            gvNhanVien.DataSource = list;

            gvNhanVien.Columns[4].DefaultCellStyle.Format = "#,###";


            cmbTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            foreach (NhanVien item in list)
            {
               // MessageBox.Show("??");
                cmbTimKiem.AutoCompleteCustomSource.Add(item.Ma);
                cmbTimKiem.AutoCompleteCustomSource.Add(item.Ten);
                cmbTimKiem.AutoCompleteCustomSource.Add(item.Chucvu);
            }
        }
        public void NhanDuLieu(string dualieu)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(FormLogin.quyen!=1)
            {
                MyMesseage.ShowMessage("Bạn không có quyền này", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //FormThemNhanVien.chucnang = "Them";
            FormThemNhanVien.ma = "";
            FormThemNhanVien.ten = "";
            FormThemNhanVien.ngaysinh = "";
            FormThemNhanVien.gioitinh = "";
            FormThemNhanVien.luong = "";
            FormThemNhanVien.dienthoai = "";
            FormThemNhanVien.gmail = "";
            FormThemNhanVien.chucvu = "";
            FormThemNhanVien.chucnang = "Them";
            FormThemNhanVien frm = new FormThemNhanVien();

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            ucNhanVien_Load(sender, e);
        }
        int index = -1;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (FormLogin.quyen != 1)
            {
                MyMesseage.ShowMessage("Bạn không có quyền này", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult res = MyMesseage.ShowMessage("Đồng ý xóa ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
                return;
            /*if (index == -1 && index>=gvNhanVien.RowCount)
            {
                MessageBox.Show("Bạn Chưa Chọn Dòng Để Xóa");
                return;
            }*/
            try
            {
                string ma = gvNhanVien.Rows[index].Cells[0].Value.ToString();
                NhanVienDAO.Instance.XoaNV(ma);
                ucNhanVien_Load(sender, e);
                MyMesseage.ShowMessage("Xóa " + ten + " thành công",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MyMesseage.ShowMessage("Xóa " + ten + " thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public string ma, ten, ngaysinh, gioitinh, luong, dienthoai, gmail, chucvu, chucnangsua;

        private void cmbTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnTimKiem.PerformClick();
            }
        }

        private void cmbTimKiem_TextChanged(object sender, EventArgs e)
        {
            
            cmbTimKiem.Text=cmbTimKiem.Text.Replace("'","");
           
           // MessageBox.Show(cmbTimKiem.Text);
            try
            {
                gvNhanVien.DataSource = NhanVienDAO.Instance.timKiem(cmbTimKiem.Text.ToString());
                //  MessageBox.Show("??");

            }
            catch (Exception ex)
            {

                MyMesseage.ShowMessage("Lỗi Khi Tìm Kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        DataGridViewCellStyle style = new DataGridViewCellStyle();
        DataGridViewCellStyle style1 = new DataGridViewCellStyle();
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            style.BackColor = Color.White;
            for (int i=0;i<gvNhanVien.RowCount;i++)
            {
                gvNhanVien.Rows[i].DefaultCellStyle = style;
            }
            style1.BackColor = Color.Yellow;
           
            for (int i=0; i<gvNhanVien.RowCount;i++)
            {
                if(gvNhanVien.Rows[i].Cells[1].Value.ToString().ToLower().Contains(cmbTimKiem.Text.ToLower())
                    || gvNhanVien.Rows[i].Cells[0].Value.ToString().ToLower().Contains( cmbTimKiem.Text.ToLower())
                    || gvNhanVien.Rows[i].Cells[7].Value.ToString().ToLower().Contains(cmbTimKiem.Text.ToLower()))
                {
                    gvNhanVien.Rows[i].DefaultCellStyle = style1;
                    //MessageBox.Show(gvNhanVien.Rows[i].Cells[1].Value.ToString());
                }
            }
        }

        private void gvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
               index = e.RowIndex;
           // MessageBox.Show(index.ToString());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (FormLogin.quyen != 1)
            {
                MyMesseage.ShowMessage("Bạn không có quyền này", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (index == -1 || index>=gvNhanVien.RowCount)
            {
                //MessageBox.Show("Vui Lòng Chọn Nhân Viên Để Cập Nhật");
                MyMesseage.ShowMessage("Chọn nhân viên để cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormThemNhanVien.ma =gvNhanVien.Rows[index].Cells[0].Value.ToString();
            FormThemNhanVien.ten = gvNhanVien.Rows[index].Cells[1].Value.ToString();
            FormThemNhanVien.ngaysinh = gvNhanVien.Rows[index].Cells[2].Value.ToString();
            FormThemNhanVien.gioitinh = gvNhanVien.Rows[index].Cells[3].Value.ToString();
            FormThemNhanVien.luong = gvNhanVien.Rows[index].Cells[4].Value.ToString();
            FormThemNhanVien.dienthoai = gvNhanVien.Rows[index].Cells[5].Value.ToString();
            FormThemNhanVien.gmail = gvNhanVien.Rows[index].Cells[6].Value.ToString();
            FormThemNhanVien.chucvu = gvNhanVien.Rows[index].Cells[7].Value.ToString();
            FormThemNhanVien.chucnang = "Sua";
            FormThemNhanVien frm = new FormThemNhanVien();
            frm.StartPosition = FormStartPosition.CenterParent;
            
            frm.ShowDialog();
          
            ucNhanVien_Load(sender, e);
        }
    }
}
