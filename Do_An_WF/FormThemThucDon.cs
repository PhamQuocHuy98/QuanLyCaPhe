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
    public partial class FormThemThucDon : Form
    {
        public FormThemThucDon()
        {
            InitializeComponent();
            //cmbLoai.DataSource=
            
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string ma, ten, donvitinh, trangthai, dongia, tenloai, chucnang;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormThemThucDon_Load(object sender, EventArgs e)
        {
            txtMaThucDon.Text = ma;
            txtTenThucDon.Text = ten;
            txtDonViTinh.Text = donvitinh;
            txtTrangThai.Text = trangthai;
            txtDonGia.Text = dongia;
            cmbLoai.Text = tenloai;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            decimal dongia;
            if (decimal.TryParse(txtDonGia.Text, out dongia) == false)
                return;
            if (dongia < 0)
            {
                MessageBox.Show("Đơn Giá Không Được Âm");
                return;
            }
            if (chucnang == "Sua")
            {
                DialogResult res = MyMesseage.ShowMessage("Bạn có muốn sửa " + txtTenThucDon.Text + " Không ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;
                
                try
                {
                   
                    ThucDonDAO.Instance.SuaTD(txtMaThucDon.Text, txtTenThucDon.Text, txtDonViTinh.Text, txtTrangThai.Text, dongia, cmbLoai.Text);
                    MyMesseage.ShowMessage("Cập nhật " + txtTenThucDon.Text + " thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // MessageBox.Show("Lỗi Khi Cạp Nhật");
                    MyMesseage.ShowMessage("Lỗi khi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (chucnang == "Them")
            {

                DialogResult res = MyMesseage.ShowMessage("Bạn có muốn thêm " + txtTenThucDon.Text + " không ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;
                try
                {
                    ThucDonDAO.Instance.ThemTD(txtMaThucDon.Text, txtTenThucDon.Text, txtDonViTinh.Text, txtTrangThai.Text, dongia, cmbLoai.Text);
                    MyMesseage.ShowMessage("Thêm " + txtTenThucDon.Text + " thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Lỗi Khi Thêm");
                    MyMesseage.ShowMessage("Lỗi khi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
    }
}
