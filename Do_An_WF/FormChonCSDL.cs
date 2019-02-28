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
    public partial class FormChonCSDL : Form
    {
        public FormChonCSDL()
        {
            InitializeComponent();
        }
        public static string source = "", database = "", user = "", pass = "";

        private void btnok_Click(object sender, EventArgs e)
        {
            source = txtservername.Text;
            database = txtdatabasename.Text;
            user = txtusername.Text;
            pass = txtpass.Text;

            FormLogin frm = new FormLogin();
            frm.ShowDialog();
            
        }
    }
}
