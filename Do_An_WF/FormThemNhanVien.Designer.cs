namespace Do_An_WF
{
    partial class FormThemNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdbKhac = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.cmbChucVu = new System.Windows.Forms.ComboBox();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Label();
            this.btnCanel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.rdbKhac);
            this.panel1.Controls.Add(this.rdbNam);
            this.panel1.Controls.Add(this.rdbNu);
            this.panel1.Controls.Add(this.btnCanel);
            this.panel1.Controls.Add(this.txtDienThoai);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.txtGmail);
            this.panel1.Controls.Add(this.txtMaNhanVien);
            this.panel1.Controls.Add(this.cmbChucVu);
            this.panel1.Controls.Add(this.txtTenNhanVien);
            this.panel1.Controls.Add(this.txtLuong);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dtpNgaySinh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 678);
            this.panel1.TabIndex = 0;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(306, 237);
            this.dtpNgaySinh.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(313, 34);
            this.dtpNgaySinh.TabIndex = 21;
            // 
            // rdbKhac
            // 
            this.rdbKhac.AutoSize = true;
            this.rdbKhac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(119)))));
            this.rdbKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKhac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbKhac.Location = new System.Drawing.Point(642, 282);
            this.rdbKhac.Name = "rdbKhac";
            this.rdbKhac.Size = new System.Drawing.Size(79, 29);
            this.rdbKhac.TabIndex = 20;
            this.rdbKhac.TabStop = true;
            this.rdbKhac.Text = "Khác";
            this.rdbKhac.UseVisualStyleBackColor = false;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(119)))));
            this.rdbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbNu.Location = new System.Drawing.Point(522, 282);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(58, 29);
            this.rdbNu.TabIndex = 19;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = false;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(119)))));
            this.rdbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbNam.Location = new System.Drawing.Point(408, 282);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(74, 29);
            this.rdbNam.TabIndex = 18;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = false;
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.cmbChucVu.FormattingEnabled = true;
            this.cmbChucVu.Items.AddRange(new object[] {
            "Bảo Vệ",
            "Phục Vụ",
            "Pha Chế"});
            this.cmbChucVu.Location = new System.Drawing.Point(408, 509);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(314, 37);
            this.cmbChucVu.TabIndex = 15;
            // 
            // txtGmail
            // 
            this.txtGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtGmail.Location = new System.Drawing.Point(408, 449);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(313, 34);
            this.txtGmail.TabIndex = 14;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtDienThoai.Location = new System.Drawing.Point(408, 398);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(313, 34);
            this.txtDienThoai.TabIndex = 13;
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtLuong.Location = new System.Drawing.Point(408, 337);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(313, 34);
            this.txtLuong.TabIndex = 12;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtTenNhanVien.Location = new System.Drawing.Point(408, 177);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(313, 34);
            this.txtTenNhanVien.TabIndex = 7;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(408, 117);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(313, 34);
            this.txtMaNhanVien.TabIndex = 6;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOK.Location = new System.Drawing.Point(260, 599);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(153, 52);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.btnCanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCanel.Location = new System.Drawing.Point(522, 599);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(162, 52);
            this.btnCanel.TabIndex = 23;
            this.btnCanel.Text = "Canel";
            this.btnCanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(903, 678);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(408, 235);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(313, 22);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // FormThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 678);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThemNhanVien";
            this.Text = "FormThemNhanVien";
            this.Load += new System.EventHandler(this.FormThemNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbChucVu;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.RadioButton rdbKhac;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label btnCanel;
        private System.Windows.Forms.Label btnOK;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}