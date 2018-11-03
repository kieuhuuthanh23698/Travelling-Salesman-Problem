using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TimDuongDiNguoiGiaoHang
{
    public partial class Nhap : Form
    {
        public Nhap()
        {
            InitializeComponent();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtSoLuong.Text) > 25 || int.Parse(txtSoLuong.Text) <= 3)
            {
                MessageBox.Show("Số lượng thành phố không được quá 25 và lớn hơn 3");
                txtSoLuong.Text = "";
            }
            else
            {
                Main frm = new Main(int.Parse(txtSoLuong.Text));
                frm.Show();
                this.Hide(); ;
            }
        }
    }
}
