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
    public partial class FormMesseageBoxYesNo : Form
    {
        public FormMesseageBoxYesNo()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.CenterParent;
        }
       

        public string Message
        {
            get { return lblThongBao.Text; }
            set { lblThongBao.Text = value; }
        }

        private void ptrAnh_Click(object sender, EventArgs e)
        {

        }
    }
}
