using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtyTinLuong
{
  
    public partial class frmDangNhap : Form
    {
        public static int miID_DangNhap;
        private void KiemTraDangNhap()
        {
            clsTbDangNhap cls = new clsTbDangNhap();
            DataTable dt = cls.SelectAll();
        }
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            miID_DangNhap = 1;
            txtTen.ResetText();
            txtMatKhau.ResetText();
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;

            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;

            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            clsTbDangNhap cls = new clsTbDangNhap();
            cls.sTen = txtTen.Text.ToString();
            cls.sMatKhau = txtMatKhau.Text.ToString();
            DataTable dt = cls.pr_tbDangNhap_KiemTraDangNhap();
            if (dt.Rows.Count > 0)
            {
                miID_DangNhap = Convert.ToInt16(dt.Rows[0]["ID_DangNhap"].ToString());
                this.Hide();
                frmMain ff = new frmMain();
                ff.Show();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại Tên đăng nhập hoặc mật khẩu");
                txtTen.ResetText();
                txtMatKhau.ResetText();
                txtTen.Focus();
            }
        }
    }
}
