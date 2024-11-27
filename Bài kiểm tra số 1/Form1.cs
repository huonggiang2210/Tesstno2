using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_kiểm_tra_số_1
{
    public partial class Form1 : Form
    {
        public double d = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btt3_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void btt2_Click(object sender, EventArgs e)
        {

            if (d <= 5.0)
            {
                txtd.Text = "Trung Bình";
            }
            else if (d >= 5.0 && d <= 7.0)
            {
                txtd.Text = "Khá";
            }
            else
            {
                txtd.Text = "Giỏi";
            }
        }

       

        private void btt1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txta.Text);
                double b = double.Parse(txtb.Text);
                double c = double.Parse(txtc.Text);

                 d = (a + b + c) / 3;

                txt4.Text = d.ToString();
            }
            catch 
            {
                MessageBox.Show("Vui 1234 lòng nhập lại số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar)&&!Char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&&!Char.IsControl(e.KeyChar)&&e.KeyChar!='.') { 
                e.Handled = true;
            }
            if(e.KeyChar=='.'&&(sender as TextBox).Text.IndexOf(".")>=0) {
                e.Handled=true;
            }
        }
    }
}
