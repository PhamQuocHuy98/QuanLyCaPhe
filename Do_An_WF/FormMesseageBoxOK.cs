using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_WF
{
    public partial class FormMesseageBoxOK : Form
    {
      
        public FormMesseageBoxOK()
        {
            InitializeComponent();

           
            time.Start();
        }

        private void Time1_Tick(object sender, EventArgs e)
        {
            
            //lblMesseage.Text = this.Opacity.ToString();
            if (this.Opacity<=0.1)
            {
                time.Dispose();
                time1.Dispose();
                this.Close();
            }
            else
            {

                this.Opacity -= 0.1;
               // this.Close();
                
            }
           
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show(this.Opacity.ToString());
            if (this.Opacity < 1)
            {
                this.Opacity += 0.1;
                
            }
           //if(this.Opacity==100)

        }

        public Image GetAnh
        {
            get { return ptrAnh.Image; }
            set { ptrAnh.Image = value; }
        }

        
        public string Message
        {
            get { return lblMesseage.Text; }
            set { lblMesseage.Text = value; }
        }
        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            time.Stop();
            time1.Start();
            //MessageBox.Show("kk");
            //this.Close();

            
        }
    }
}
