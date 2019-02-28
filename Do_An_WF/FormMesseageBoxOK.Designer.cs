namespace Do_An_WF
{
    partial class FormMesseageBoxOK
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
            this.time1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Timer(this.components);
            this.btnChapNhan = new System.Windows.Forms.Button();
            this.lblMesseage = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.ptrAnh = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // time1
            // 
            this.time1.Interval = 10;
            this.time1.Tick += new System.EventHandler(this.Time1_Tick);
            // 
            // time
            // 
            this.time.Interval = 10;
            this.time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // btnChapNhan
            // 
            this.btnChapNhan.BackColor = System.Drawing.SystemColors.Control;
            this.btnChapNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChapNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnChapNhan.ForeColor = System.Drawing.Color.Gray;
            this.btnChapNhan.Location = new System.Drawing.Point(331, 237);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(166, 39);
            this.btnChapNhan.TabIndex = 5;
            this.btnChapNhan.Text = "Chấp Nhận";
            this.btnChapNhan.UseVisualStyleBackColor = false;
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // lblMesseage
            // 
            this.lblMesseage.AutoSize = true;
            this.lblMesseage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesseage.ForeColor = System.Drawing.Color.DimGray;
            this.lblMesseage.Location = new System.Drawing.Point(101, 105);
            this.lblMesseage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMesseage.Name = "lblMesseage";
            this.lblMesseage.Size = new System.Drawing.Size(148, 29);
            this.lblMesseage.TabIndex = 3;
            this.lblMesseage.Text = "Thông Báo!";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblThongBao.Location = new System.Drawing.Point(184, 40);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(163, 32);
            this.lblThongBao.TabIndex = 0;
            this.lblThongBao.Text = "Thông Báo";
            // 
            // ptrAnh
            // 
            this.ptrAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptrAnh.Location = new System.Drawing.Point(55, 137);
            this.ptrAnh.Name = "ptrAnh";
            this.ptrAnh.Size = new System.Drawing.Size(129, 139);
            this.ptrAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrAnh.TabIndex = 4;
            this.ptrAnh.TabStop = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(297, 277);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(228, 13);
            this.bunifuSeparator2.TabIndex = 7;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(138, 72);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(272, 13);
            this.bunifuSeparator1.TabIndex = 6;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // FormMesseageBoxOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(570, 316);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btnChapNhan);
            this.Controls.Add(this.ptrAnh);
            this.Controls.Add(this.lblMesseage);
            this.Controls.Add(this.lblThongBao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMesseageBoxOK";
            this.Opacity = 0.1D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMesseageBoxOK";
            ((System.ComponentModel.ISupportInitialize)(this.ptrAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer time1;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Button btnChapNhan;
        private System.Windows.Forms.Label lblMesseage;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.PictureBox ptrAnh;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}