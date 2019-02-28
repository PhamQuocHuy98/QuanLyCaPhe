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
    public partial class ucGoiMon : UserControl
    {
        ErrorProvider er = new ErrorProvider();
        public ucGoiMon()
        {
            InitializeComponent();
            btnThem.MouseHover += BtnThem_MouseHover;
            btnThem.MouseLeave += BtnThem_MouseLeave;
            btnXoa.MouseHover += BtnXoa_MouseHover;
            btnXoa.MouseLeave += BtnXoa_MouseLeave;
            btnSua.MouseHover += BtnSua_MouseHover; ;
            btnSua.MouseLeave += BtnSua_MouseLeave; ;
        }

        private void BtnSua_MouseLeave(object sender, EventArgs e)
        {
            btnSua.BackColor = Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
        }

        private void BtnSua_MouseHover(object sender, EventArgs e)
        {
            btnSua.BackColor = Color.SeaGreen;
        }

        private void BtnXoa_MouseLeave(object sender, EventArgs e)
        {
            btnXoa.BackColor = Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
        }

        private void BtnXoa_MouseHover(object sender, EventArgs e)
        {
            btnXoa.BackColor = Color.SeaGreen;
        }

        private void BtnThem_MouseLeave(object sender, EventArgs e)
        {
            btnThem.BackColor = Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
        }

        private void BtnThem_MouseHover(object sender, EventArgs e)
        {

            btnThem.BackColor = Color.SeaGreen;
        }

        List<ThucDon> ltd;
        List<GoiMon> gm ;
        private void ucGoiMon_Load(object sender, EventArgs e)
        {
            gm = GoiMonDAO.Instance.GetListGoiMon();


            // cộng dồn số lượng

           
            gvDanhSach.DataSource = gm;

            DuaDuLieuLenComBoBox();
        }
        void DuaDuLieuLenComBoBox()
        {
            // Đưa Danh Sách Bàn Lên Combobox
            cmbTenThucDon.Items.Clear();
            cmbMaBan.Items.Clear();
            cmbMaThucDon.Items.Clear();
            List<Ban> lb = BanDAO.Instance.GetListBan();
            foreach (Ban item in lb)
            {
                cmbMaBan.Items.Add(item.Maban);
            }
            cmbMaBan.SelectedIndex = 0;


            // Đưa Danh Sách Thực Đơn

            ltd = ThucDonDAO.Instance.GetListThucDon();

            foreach (ThucDon item in ltd)
            {
                cmbTenThucDon.Items.Add(item.Ten);
            }
            cmbTenThucDon.SelectedIndex = 0;
        }
        void KiemTraDuLieuHopLe(decimal dongia,int soluong)
        {
            
            

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            decimal dongia;
            int soluong;
            decimal.TryParse(txtDonGia.Text, out dongia);
            if (int.TryParse(txtSoLuong.Text, out soluong) == false)
            {
                er.SetError(txtSoLuong, "Dữ liệu không hợp lệ");
                txtDonGia.Focus();
                return;
            }
            if (int.TryParse(txtSoLuong.Text, out soluong) == true && soluong <= 0)
            {
                
                er.SetError(txtSoLuong, "Số Lượng phải lớn hơn 0");
                txtDonGia.Focus();
                return;
            }
            er.SetError(txtSoLuong, null);
            try
            {

                dtpThoiGian.Value = DateTime.Now;
                DateTime dt = Convert.ToDateTime(dtpThoiGian.Value);
                int ngay = dt.Day;
                int thang = dt.Month;
                int nam = dt.Year;
                DateTime thoigian = new DateTime(nam, thang, ngay);
                decimal thanhtien = soluong * dongia;
                DialogResult res = MyMesseage.ShowMessage("Bạn Có Muốn Gọi " + cmbTenThucDon.Text + " Không ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;
                // Cộng dồn số lượng
                int demsoluong = 0;

                foreach (GoiMon item in gm)
                {
                    if (item.Maban.Equals(cmbMaBan.Text) && item.Mathucdon.Equals(cmbMaThucDon.Text))
                    {
                        demsoluong += item.Soluong;
                        //MessageBox.Show(item.Soluong.ToString());
                    }
                }
                if (demsoluong != 0)
                {
                    GoiMonDAO.Instance.XoaMon(cmbMaBan.Text, cmbMaThucDon.Text);
                    
                }

                GoiMonDAO.Instance.themMon(cmbMaBan.Text, cmbMaThucDon.Text, cmbTenThucDon.Text, dongia, soluong + demsoluong, thoigian, (soluong+demsoluong)*dongia);
                // Cập nhật bàn thành có người
                string tenban = cmbMaBan.Text;
                tenban = tenban.Remove(0, 1);

                BanDAO.Instance.SuaBan(cmbMaBan.Text, "Bàn " + tenban, "Có Người");

                MyMesseage.ShowMessage(" Gọi món " + cmbTenThucDon.Text + " thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucGoiMon_Load(sender, e);
            }
            catch (Exception ex)
            {
                //MyMesseage.ShowMessage("Lỗi khi gọi "+cmbTenThucDon.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
            
           // MessageBox.Show("Sua thanh công");

            // MessageBox.Show(thoigian.ToString());
            
        }

        private void cmbTenThucDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ten = cmbTenThucDon.SelectedItem.ToString();
            cmbMaThucDon.Items.Clear();
            
            foreach (ThucDon item in ltd)
            {
                if (ten == item.Ten)
                {
                    // MessageBox.Show("aaâ");
                    cmbMaThucDon.Items.Add(item.Ma);
                    txtDonGia.Text = item.Dongia.ToString();
                    break;
                }
            }
            cmbMaThucDon.SelectedIndex = 0;

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            int soluong;
            if (int.TryParse(txtSoLuong.Text, out soluong) == true && soluong > 0)
            {
                lblTongTien.Text = (int.Parse(txtSoLuong.Text) * int.Parse(txtDonGia.Text)).ToString();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MyMesseage.ShowMessage("Đồng ý xóa ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
                return;
            try
            {
                GoiMonDAO.Instance.XoaMon(cmbMaBan.Text, cmbMaThucDon.Text);

                byte dem = 0;
                foreach (GoiMon item in gm)
                {
                    if (item.Maban == cmbMaBan.Text)
                    {
                        dem++;
                        //MessageBox.Show(item.Maban);
                        //break;
                        if (dem == 2)
                            break;
                    }
                }
                if (dem < 2)
                {
                    string tenban = cmbMaBan.Text;
                    tenban = tenban.Remove(0, 1);
                    BanDAO.Instance.SuaBan(cmbMaBan.Text, "Bàn " + tenban, "Còn Trống");
                }
                MyMesseage.ShowMessage(" Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MyMesseage.ShowMessage(" Có lỗi khi xóa ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            ucGoiMon_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult res = MyMesseage.ShowMessage("Đồng ý sửa ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
                return;
            try
            {
                decimal dongia;
                int soluong;
                decimal.TryParse(txtDonGia.Text, out dongia);
                if (int.TryParse(txtSoLuong.Text, out soluong) == false)
                {
                    er.SetError(txtSoLuong, "Dữ liệu không hợp lệ");
                    txtDonGia.Focus();
                    return;
                }
                if (int.TryParse(txtSoLuong.Text, out soluong) == true && soluong <= 0)
                {

                    er.SetError(txtSoLuong, "Số lượng phải lớn hơn 0");
                    txtDonGia.Focus();
                    return;
                }
                er.SetError(txtSoLuong, null);
                dtpThoiGian.Value = DateTime.Now;
                DateTime dt = Convert.ToDateTime(dtpThoiGian.Value);
                int ngay = dt.Day;
                int thang = dt.Month;
                int nam = dt.Year;
                DateTime thoigian = new DateTime(nam, thang, ngay);
                decimal thanhtien = soluong * dongia;
                GoiMonDAO.Instance.SuaMon(cmbMaBan.Text, cmbMaThucDon.Text, soluong, thanhtien, cmbTenThucDon.Text, dongia, thoigian);
                MyMesseage.ShowMessage("Cập nhật thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ucGoiMon_Load(sender, e);
            }
            catch(Exception ex)
            {
                //MyMesseage.ShowMessage(" Có lỗi khi sửa ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }

        private void gvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow index = gvDanhSach.CurrentRow;
            //int index = int.Parse(gvDanhSach.CurrentRow.ToString());
            cmbMaBan.Text=index.Cells[0].Value.ToString();
            cmbMaThucDon.Text = index.Cells[1].Value.ToString();
            cmbTenThucDon.Text = index.Cells[2].Value.ToString();


        }
    }
}
