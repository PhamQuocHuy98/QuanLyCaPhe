

namespace Do_An_WF
{
    partial class FormHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GoiMonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyNuocDataSet = new Do_An_WF.QuanLyNuocDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GoiMonTableAdapter = new Do_An_WF.QuanLyNuocDataSetTableAdapters.GoiMonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GoiMonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyNuocDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GoiMonBindingSource
            // 
            this.GoiMonBindingSource.DataMember = "GoiMon";
            this.GoiMonBindingSource.DataSource = this.QuanLyNuocDataSet;
            // 
            // QuanLyNuocDataSet
            // 
            this.QuanLyNuocDataSet.DataSetName = "QuanLyNuocDataSet";
            this.QuanLyNuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GoiMonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Do_An_WF.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(999, 587);
            this.reportViewer1.TabIndex = 0;
            // 
            // GoiMonTableAdapter
            // 
            this.GoiMonTableAdapter.ClearBeforeFill = true;
            // 
            // FormHoaDon
            // 
            this.ClientSize = new System.Drawing.Size(999, 587);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormHoaDon_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GoiMonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyNuocDataSet)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GoiMonBindingSource;
        private QuanLyNuocDataSet QuanLyNuocDataSet;
        private QuanLyNuocDataSetTableAdapters.GoiMonTableAdapter GoiMonTableAdapter;
    }
}