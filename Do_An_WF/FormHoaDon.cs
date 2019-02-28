using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace Do_An_WF
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyNuocDataSet.GoiMon' table. You can move, or remove it, as needed.
           // this.GoiMonTableAdapter.Fill(this.QuanLyNuocDataSet.GoiMon);

        }
        private void DoiThamSo(string thamso)
        {
            
            ReportParameter rp = new ReportParameter("MaBan");
            rp.Values.Add(thamso);
            reportViewer1.LocalReport.SetParameters(rp);

        }
        private void FormHoaDon_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyNuocDataSet.GoiMon' table. You can move, or remove it, as needed.
            this.GoiMonTableAdapter.Fill(this.QuanLyNuocDataSet.GoiMon);

            DoiThamSo(uc.ucBan.banhienthihoadon);


            ReportParameter rp = new ReportParameter("TongTien");
            rp.Values.Add(uc.ucBan.sumtien.ToString());
            reportViewer1.LocalReport.SetParameters(rp);
            this.reportViewer1.RefreshReport();
        }
    }
}
