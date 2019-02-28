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
    public partial class ucThongKe : UserControl
    {
        ErrorProvider er = new ErrorProvider();
        public ucThongKe()
        {
            InitializeComponent();
            lblDoanhThu.Text = "";
        }

        private void ucThongKe_Load(object sender, EventArgs e)
        {
            gvThongKe.Visible = false;
            cmbNgay1.Items.Clear();
            cmbNgay2.Items.Clear();
            cmbThang1.Items.Clear();
            cmbThang2.Items.Clear();
            cmbNam1.Items.Clear();
            cmbNam2.Items.Clear();

            lbldenngay.Text = "";
            lbltungay.Text = "";

            //---------------------------//
            cmbNgay1.Items.Add("Ngày");
            cmbNgay2.Items.Add("Ngày");
            cmbThang1.Items.Add("Tháng");
            cmbThang2.Items.Add("Tháng");
            cmbNam1.Items.Add("Năm");
            cmbNam2.Items.Add("Năm");
            
            for (int i=1;i<=31;i++)
            {
                cmbNgay1.Items.Add(i);
                cmbNgay2.Items.Add(i);
            }
           for(int i=1;i<=12;i++)
            {
                cmbThang1.Items.Add(i);
                cmbThang2.Items.Add(i);
            }
            int nam = DateTime.Now.Year;
           for(int i=2018;i<=nam;i++)
           {
                cmbNam1.Items.Add(i);
                cmbNam2.Items.Add(i);
           }
            cmbNgay1.SelectedIndex = 0;
            cmbNgay2.SelectedIndex = 0;
            cmbThang1.SelectedIndex = 0;
            cmbThang2.SelectedIndex = 0;
            cmbNam1.SelectedIndex = 0;
            cmbNam2.SelectedIndex = 0;
        }

        bool KiemTraDuLieuHopLe(int ngay,int thang,int nam)
        {
            if(ngay==31)
            {
                if (thang == 2 || thang == 4 || thang == 6 || thang == 9 || thang == 11)
                    return false;
                return true;
            }
            else if(ngay>28 && ngay<=31) 
            {
                if (thang == 2)
                    return false;
                return true;
            }
            return true;
        }
      
        private void cmbNgay1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNgay1.Text != "Ngày" && cmbThang1.Text!="Tháng" && cmbNam1.Text!="Năm")
            {
                int ngay = int.Parse(cmbNgay1.Text);
                int thang = int.Parse(cmbThang1.Text);
                int nam = int.Parse(cmbNam1.Text);
                bool check =KiemTraDuLieuHopLe(ngay, thang, nam);
                if (check == false)
                {
                    er.SetError(lbltungay, "Dữ liệu không hợp lệ");
                }
                else
                {
                    er.SetError(lbltungay, null);
                }
            }
                
          
        }

        private void cmbThang1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNgay1.Text != "Ngày" && cmbThang1.Text != "Tháng" && cmbNam1.Text != "Năm")
            {
                int ngay = int.Parse(cmbNgay1.Text);
                int thang = int.Parse(cmbThang1.Text);
                int nam = int.Parse(cmbNam1.Text);
                bool check = KiemTraDuLieuHopLe(ngay, thang, nam);
                if (check == false)
                {
                    er.SetError(lbltungay, "Dữ liệu không hợp lệ");
                    //btnThongKe.Enabled = false;
                }
                else
                {
                    er.SetError(lbltungay, null);
                }

            }
        }

        private void cmbNgay2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNgay2.Text != "Ngày" && cmbThang2.Text != "Tháng" && cmbNam2.Text != "Năm")
            {
                int ngay = int.Parse(cmbNgay2.Text);
                int thang = int.Parse(cmbThang2.Text);
                int nam = int.Parse(cmbNam2.Text);
                bool check = KiemTraDuLieuHopLe(ngay, thang, nam);
                if (check == false)
                {
                    er.SetError(lbldenngay, "Dữ liệu không hợp lệ");
                   // btnThongKe.Enabled = false;
                }
                else
                {
                    er.SetError(lbldenngay, null);
                    
                }
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            gvThongKe.Visible = true;
            try
            {
                if (cmbNgay2.Text != "Ngày" && cmbThang2.Text != "Tháng" && cmbNam2.Text != "Năm" && (cmbNgay2.Text != "Ngày" && cmbThang2.Text != "Tháng" && cmbNam2.Text != "Năm"))
                {
                    string tungay = cmbNam1.Text + "-" + cmbThang1.Text + "-" + cmbNgay1.Text;
                    string denngay = cmbNam2.Text + "-" + cmbThang2.Text + "-" + (int.Parse(cmbNgay2.Text) + 1).ToString();
                    //    MessageBox.Show(tungay + "\n" + denngay);
                    gvThongKe.DataSource = ThongKeDAO.Instance.GetLissThongKe(tungay, denngay);

                    decimal doanhthu = 0;
                    for (int i = 0; i < gvThongKe.RowCount; i++)
                    {
                        doanhthu += decimal.Parse(gvThongKe.Rows[i].Cells[5].Value.ToString());
                    }
                    lblDoanhThu.Text = "Tổng Doanh Thu " + doanhthu.ToString() + " VNĐ";

                }
                else
                {
                    MessageBox.Show("Bạn phải chọn ngày");
                }
            }
            catch(Exception ex)
            {
                MyMesseage.ShowMessage("Lỗi dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
