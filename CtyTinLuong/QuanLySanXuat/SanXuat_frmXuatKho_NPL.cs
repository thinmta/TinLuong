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
    public partial class SanXuat_frmXuatKho_NPL : Form
    {
        public static bool bDongYXuatNhapKho;
       
        public SanXuat_frmXuatKho_NPL()
        {
            InitializeComponent();
        }

        private void btXuatNhapKho_Click(object sender, EventArgs e)
        {
            bDongYXuatNhapKho = true;
            this.Close();
           
        }

        private void SanXuat_frmXuatKho_NPL_Load(object sender, EventArgs e)
        {
            bDongYXuatNhapKho = false;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            bDongYXuatNhapKho = false;
            this.Close();
        }

        private void txtDonGiaXuat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDonGiaXuat.Text);
                txtDonGiaXuat.Text = String.Format("{0:#,##0.00}", value);
                
            }
            catch
            {

            }
        }

        private void txtDonGiaNhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDonGiaNhap.Text);
                txtDonGiaNhap.Text = String.Format("{0:#,##0.00}", value);

            }
            catch
            {

            }
        }

        private void SanXuat_frmXuatKho_NPL_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
