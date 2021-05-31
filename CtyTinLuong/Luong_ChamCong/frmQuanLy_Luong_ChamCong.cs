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
    public partial class frmQuanLy_Luong_ChamCong : Form
    {
        frmMain _frmMain;
        frmChamCongToGapDan _frmChamCongToGapDan;
        public frmQuanLy_Luong_ChamCong(frmMain frm)
        {
            _frmMain = frm;
            InitializeComponent();
            _frmChamCongToGapDan = new frmChamCongToGapDan();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCBangLuong uccc_DaNhapKho = new UCBangLuong();
            uccc_DaNhapKho.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uccc_DaNhapKho);
            uccc_DaNhapKho.BringToFront();
        }

        private void navNhapKho_TuMuaHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCLuong_ChieTiet_ALL uccc_DaNhapKho = new UCLuong_ChieTiet_ALL();
            uccc_DaNhapKho.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uccc_DaNhapKho);
            uccc_DaNhapKho.BringToFront();
        }

        private void btThooat_Click(object sender, EventArgs e)
        {
            _frmMain.Show();
            this.Close();
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCLuong_TamUng uccc_DaNhapKho = new UCLuong_TamUng();
            uccc_DaNhapKho.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uccc_DaNhapKho);
            uccc_DaNhapKho.BringToFront();
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCLuong_TraLuongNewwwwwwwwww uccc_DaNhapKho = new UCLuong_TraLuongNewwwwwwwwww();
            uccc_DaNhapKho.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uccc_DaNhapKho);
            uccc_DaNhapKho.BringToFront();
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmChamCongToGapDan ff = new frmChamCongToGapDan();
            ff.Show();
        }

        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmCaiMacDinnhMaHangToGapDan ff = new frmCaiMacDinnhMaHangToGapDan();
            ff.Show();
        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            _frmChamCongToGapDan.LoadData(true);
            _frmChamCongToGapDan.Show();
        }

        private void frmQuanLy_Luong_ChamCong_Load(object sender, EventArgs e)
        {

        }

        private void frmQuanLy_Luong_ChamCong_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmMain.Show();
            this.Close();
        }
    }
}
