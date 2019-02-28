using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_WF.uc
{
    public partial class ucTrangChu : UserControl
    {
        Timer time = new Timer();
        public ucTrangChu()
        {
            InitializeComponent();
        }
        int x1, y1,x2,y2,x3,y3,x4,y4,x5,y5,x6,y6;
        private void ucTrangChu_Load(object sender, EventArgs e)
        {
            x1 = ptr1.Location.X;
            y1 = ptr1.Location.Y;
            x2 = ptr2.Location.X;
            y2 = ptr2.Location.Y;
            x3 = ptr3.Location.X;
            y3 = ptr3.Location.Y;
            x4 = ptr4.Location.X;
            y4 = ptr4.Location.Y;
            x5 = ptr5.Location.X;
            y5 = ptr5.Location.Y;
            x6 = ptr6.Location.X;
            y6 = ptr6.Location.Y;
            time.Interval = 1000;
            time.Tick += Time_Tick;

            time.Start();
        }

       
        //string []mangmau = { "Red", "Yellow", "Orange", "AliceBlue" };
        private void Time_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            int mau = rd.Next(0, 4);
            if (mau == 0)
                lblSanPhamBanChay.ForeColor = Color.Red;
            else if (mau == 1)
                lblSanPhamBanChay.ForeColor = Color.Black;
            else if (mau == 2)
                lblSanPhamBanChay.ForeColor = Color.Tomato;
            else lblSanPhamBanChay.ForeColor = Color.Blue;
        }

       
        private void ptr1_MouseHover(object sender, EventArgs e)
        {
            ptr1.Location = new Point(32, 15);
        }

      
        private void ptr1_MouseLeave(object sender, EventArgs e)
        {
            ptr1.Location = new Point(x1, y1);
        }
        //-------------------------------------------------------------//


        private void ptr2_MouseHover(object sender, EventArgs e)
        {
            ptr2.Location = new Point(32, 15);
        }

        private void ptr2_MouseLeave(object sender, EventArgs e)
        {
            ptr2.Location = new Point(x2, y2);
        }
        //-------------------------------------------------------------//

        private void ptr3_MouseHover(object sender, EventArgs e)
        {
            ptr3.Location = new Point(32, 15);
        }

        private void ptr3_MouseLeave(object sender, EventArgs e)
        {
            ptr3.Location = new Point(x3, y3);
        }

        //-----------------------------------------------------------------//

        private void ptr4_MouseHover(object sender, EventArgs e)
        {
            ptr4.Location = new Point(32, 15);
        }

        private void ptr4_MouseLeave(object sender, EventArgs e)
        {
            ptr4.Location = new Point(x4, y4);
        }

        //------------------------------------------------------------------//
        private void ptr5_MouseHover(object sender, EventArgs e)
        {
            ptr5.Location = new Point(32, 15);
        }

        private void ptr5_MouseLeave(object sender, EventArgs e)
        {
            ptr5.Location = new Point(x5, y5);
        }
        //-----------------------------------------------------------------//

        private void ptr6_MouseHover(object sender, EventArgs e)
        {
            ptr6.Location = new Point(32, 15);
        }

        private void ptr6_MouseLeave(object sender, EventArgs e)
        {
            ptr6.Location = new Point(x6, y6);
        }

    }
}
