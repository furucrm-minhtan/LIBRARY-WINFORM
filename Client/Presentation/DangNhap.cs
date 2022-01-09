using Server.BUS;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Presentation
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(textBox1, "Nhập số thẻ");
        }

        private void passwordBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(passwordBox, "Nhập mật khẩu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maDocGia = textBox1.Text;
            string matKhau = passwordBox.Text;
            if (maDocGia == "" || matKhau == "")
            {
                MessageBox.Show("Mã đọc giả hoặc mật khẩu không được bỏ trống");
            }
            else
            {
                DocGiaDTO docgia = DocGiaBUS.DangNhap(maDocGia, matKhau);
                if (docgia != null)
                {
                    this.Hide();
                    TrangChu trangChu = new TrangChu();
                    trangChu.Show();
                }
            }

        }
    }
}
