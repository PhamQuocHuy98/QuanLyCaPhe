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
using Do_An_WF.uc;
namespace Do_An_WF
{
    public partial class FormThemNhanVien : Form
    {
        ErrorProvider error = new ErrorProvider();
        public FormThemNhanVien()
        {
           
            InitializeComponent();
            txtMaNhanVien.Text = ma;
            txtTenNhanVien.Text = ten;
            dateTimePicker1.Text = ngaysinh;
            if (gioitinh == "Nam")
            {
                rdbNam.Checked = true;
            }
            else if (gioitinh == "Nữ")
            {
                rdbNu.Checked = true;
            }
            else rdbKhac.Checked = true;

            txtLuong.Text = luong;
            txtDienThoai.Text = dienthoai;
            txtGmail.Text = gmail;
            cmbChucVu.Text = chucvu;

        }
      
        private void btnCanel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.Location.X + "\n" + this.Location.Y);
            this.Close();
        }
        public static string ma, ten, ngaysinh, gioitinh, luong, dienthoai, gmail, chucvu, chucnang;



        private void FormThemNhanVien_Load(object sender, EventArgs e)
        {
            if (chucnang == "Sua")
            {
                //MessageBox.Show("Sua");
                txtMaNhanVien.Enabled = false;
            }
            else txtMaNhanVien.Enabled = true;
        }
        private bool KiemTraNhapLieu()
        {
            
            if (txtMaNhanVien.Text == "")
            {
                error.SetError(txtMaNhanVien, "Bạn Chưa Nhập Mã");
                txtMaNhanVien.Focus();
            }
            else if (txtTenNhanVien.Text == "")
            {
                error.SetError(txtMaNhanVien, null);
                error.SetError(txtTenNhanVien, "Bạn Chưa Nhập Tên Nhân Viên");
                txtTenNhanVien.Focus();
            }
            else if (txtLuong.Text == "")
            {
                error.SetError(txtTenNhanVien, null);
                error.SetError(txtLuong, "Bạn Chưa Nhập Lương");
                txtLuong.Focus();
            }
            else if (txtDienThoai.Text == "")
            {
                error.SetError(txtLuong, null);
                error.SetError(txtDienThoai, "Bạn Chưa Nhập SDT");
                txtDienThoai.Focus();
            }
            else if (txtGmail.Text == "")
            {
                error.SetError(txtDienThoai, null);
                error.SetError(txtGmail, "Bạn Chưa Nhập Gmail");
                txtGmail.Focus();
            }
            else if (cmbChucVu.Text == "")
            {
                error.SetError(txtGmail, null);
                error.SetError(cmbChucVu, "Bạn Chưa Chức Vụ");
                cmbChucVu.Focus();
            }
            else return true;
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu() == false) return;
            string gioitinh = "";
            if (rdbNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else if (rdbNu.Checked == true)
            {
                gioitinh = "Nữ";
            }
            else gioitinh = "Khác";


            if (chucnang=="Sua")
            {
                DialogResult res = MyMesseage.ShowMessage("Bạn có muốn cập nhật " + txtTenNhanVien.Text + " không ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;
                try
                {
                    DateTime dt = Convert.ToDateTime(dateTimePicker1.Value);
                    int ngay = dt.Day;
                    int thang = dt.Month;
                    int nam = dt.Year;
                    DateTime temp = new DateTime(nam, thang, ngay);
                    decimal luong = decimal.Parse(txtLuong.Text);
                    NhanVienDAO.Instance.SuaNV(txtMaNhanVien.Text,txtTenNhanVien.Text, temp, gioitinh, luong, txtDienThoai.Text, txtGmail.Text, cmbChucVu.Text);
                    MyMesseage.ShowMessage("Cập nhật " + txtTenNhanVien.Text + " thành công",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MyMesseage.ShowMessage("Lỗi khi cập nhật ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else if(chucnang=="Them")
            {
                DialogResult res = MyMesseage.ShowMessage("Bạn có muốn thêm " + txtTenNhanVien.Text + " không ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;
                try
                {
                    DateTime dt = Convert.ToDateTime(dateTimePicker1.Value);
                    int ngay = dt.Day;
                    int thang = dt.Month;
                    int nam = dt.Year;
                    DateTime temp = new DateTime(nam, thang, ngay);
                    decimal luong = decimal.Parse(txtLuong.Text);
                    NhanVienDAO.Instance.ThemNV(txtMaNhanVien.Text, txtTenNhanVien.Text, temp, gioitinh, luong, txtDienThoai.Text, txtGmail.Text, cmbChucVu.Text);
                    MyMesseage.ShowMessage("Thêm " + txtTenNhanVien.Text + " thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MyMesseage.ShowMessage("Lỗi khi thêm ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

    }
}
