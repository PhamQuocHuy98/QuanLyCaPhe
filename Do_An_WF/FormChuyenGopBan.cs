using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An_WF.DAO;
using Do_An_WF.DTO;
namespace Do_An_WF
{
    public partial class FormChuyenGopBan : Form
    {
        public FormChuyenGopBan()
        {
            InitializeComponent();
        }
        public static string luachon = "";
        //public static decimal tongtien = 0;
        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<Ban> list;
        private void FormChuyenGopBan_Load(object sender, EventArgs e)
        {
            // lấy dữ liệu bàn có đưa lên combobox
            list = BanDAO.Instance.GetListBan();
            foreach (Ban item in list)
            {
                if (item.Trangthai == "Có Người")
                {
                    cmbBanDau.Items.Add(item.Maban);
                }
            }
            if(cmbBanDau.Items.Count!=0)
                cmbBanDau.SelectedIndex = 0;
        }

        private void cmbBanDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (luachon == "ChuyenBan")
            {
                cmbBanDich.Items.Clear();
                string ma = cmbBanDau.SelectedItem.ToString(); // lấy mã click
                foreach (Ban item in list)
                {
                    if (item.Maban != ma && item.Trangthai == "Còn Trống")
                    {
                        cmbBanDich.Items.Add(item.Maban);
                    }
                }
                if (cmbBanDich.Items.Count != 0)
                    cmbBanDich.SelectedIndex = 0;
            }
            else if (luachon == "GopBan")
            {
                cmbBanDich.Items.Clear();
                string ma = cmbBanDau.SelectedItem.ToString(); // lấy mã click
                foreach (Ban item in list)
                {
                    if (item.Maban != ma && item.Trangthai == "Có Người")
                    {
                        cmbBanDich.Items.Add(item.Maban);
                    }
                }
                //  cmbBanDich.SelectedIndex = 0;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu từ bàn đầu -> đổ sang dữ liệu bàn đích
            
            List<GoiMon> lgm = GoiMonDAO.Instance.GetListGoiMon();
            if (luachon == "ChuyenBan")
            {
                DialogResult res = MyMesseage.ShowMessage("Bạn muốn chuyển " + cmbBanDau.Text + " đến " + cmbBanDich.Text + " ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No) return;
                bool check = false;
                try
                {
                    foreach (GoiMon item in lgm)
                    {
                        //MessageBox.Show("Mã Ban" + item.Maban + "\n" + cmbBanDau.Text);
                        if (item.Maban == cmbBanDau.Text) // tìm mã bàn ban đầu.
                        {
                            // lấy dữ liệu chuyển -> bàn đích
                            //  MessageBox.Show("??");
                            GoiMonDAO.Instance.themMon(cmbBanDich.Text, item.Mathucdon, item.Tenthucdon, item.Dongia, item.Soluong, item.Thoigian, item.Thanhtien);
                            GoiMonDAO.Instance.XoaMon(item.Maban, item.Mathucdon);

                            check = true;
                            // MessageBox.Show("Chuyển Bàn Thành Công");
                            //return;
                        }


                    }
                    if (check == true)
                    {
                        string tenbandich = cmbBanDich.Text;
                        tenbandich = tenbandich.Remove(0, 1);

                        string tenbandau = cmbBanDau.Text;
                        tenbandau = tenbandau.Remove(0, 1);
                        // MessageBox.Show("Bàn " + tenban);
                        BanDAO.Instance.SuaBan(cmbBanDich.Text, "Bàn " + tenbandich, "Có Người");
                        BanDAO.Instance.SuaBan(cmbBanDau.Text, "Bàn " + tenbandau, "Còn Trống");
                        check = false;
                    }
                    //MessageBox.Show("Chuyển Bàn Thành Công");
                    MyMesseage.ShowMessage("Chuyển bàn thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MyMesseage.ShowMessage("Chuyển bàn thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (luachon == "GopBan")
            {
                DialogResult res = MyMesseage.ShowMessage("Bạn muốn gọp " + cmbBanDau.Text + " với " + cmbBanDich.Text + " ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No) return;
                bool check = false;
                try
                {
                    foreach (GoiMon item in lgm)
                    {
                        //MessageBox.Show("Mã Ban" + item.Maban + "\n" + cmbBanDau.Text);
                        int demsoluong = 0; // đếm xem nếu cái mã mình thêm vô đã có thì cộng dồn
                        decimal thanhtien = 0;
                        if (item.Maban == cmbBanDau.Text) // tìm mã bàn ban đầu.
                        {
                            foreach (GoiMon i in lgm)
                            {
                                if (i.Mathucdon == item.Mathucdon && i.Maban == cmbBanDich.Text) // tìm mã thực đơn ở bàn đích.
                                {
                                    demsoluong += i.Soluong;
                                    thanhtien += i.Thanhtien;
                                    break;
                                }
                            }
                            if (demsoluong == 0)
                            {
                                GoiMonDAO.Instance.themMon(cmbBanDich.Text, item.Mathucdon, item.Tenthucdon, item.Dongia, item.Soluong, item.Thoigian, item.Thanhtien);
                            }
                            else
                            {
                                GoiMonDAO.Instance.SuaMon(cmbBanDich.Text, item.Mathucdon, item.Soluong + demsoluong, item.Thanhtien + thanhtien, item.Tenthucdon, item.Dongia, item.Thoigian);
                            }
                            GoiMonDAO.Instance.XoaMon(item.Maban, item.Mathucdon);
                            check = true;
                        }

                    }
                    if (check == true)
                    {
                        string tenbandich = cmbBanDich.Text;
                        tenbandich = tenbandich.Remove(0, 1);

                        string tenbandau = cmbBanDau.Text;
                        tenbandau = tenbandau.Remove(0, 1);
                        // MessageBox.Show("Bàn " + tenban);
                        BanDAO.Instance.SuaBan(cmbBanDich.Text, "Bàn " + tenbandich, "Có Người");
                        BanDAO.Instance.SuaBan(cmbBanDau.Text, "Bàn " + tenbandau, "Còn Trống");
                        check = false;
                    }
                    MyMesseage.ShowMessage("Gọp bàn thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MyMesseage.ShowMessage("Gọp bàn thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
    }
}
