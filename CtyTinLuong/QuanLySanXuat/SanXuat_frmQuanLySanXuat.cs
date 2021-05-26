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
    public partial class SanXuat_frmQuanLySanXuat : Form
    {
        

        public SanXuat_frmQuanLySanXuat()
        {
            InitializeComponent();
        }

       
        private void navBarItemPhieuSanXuat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UC_SanXuat_PhieuSanXuat ucc = new UC_SanXuat_PhieuSanXuat();
            ucc.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(ucc);
            ucc.BringToFront();
        }

        private void navBarItemLenhSanXuat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UC_SanXuat_LenhSanXuat ucc = new UC_SanXuat_LenhSanXuat();
            ucc.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(ucc);
            ucc.BringToFront();
        }

        private void btThooat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navBarItemCongNhat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //UC_SanXuat_frmChamCongNhat ucc = new UC_SanXuat_frmChamCongNhat();
            //ucc.Dock = DockStyle.Fill;
            //panelControl1.Controls.Add(ucc);
            //ucc.BringToFront();
        }

        private void navBarChamCongSanLuong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void navBarItemDinhMucDOt_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCDinhMucDot ucc = new UCDinhMucDot();
            ucc.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(ucc);
            ucc.BringToFront();
        }

        private void navBarItemDinhMucNPL_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucDinhMucNGuyenPhuLieu ucc = new ucDinhMucNGuyenPhuLieu();
            ucc.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(ucc);
            ucc.BringToFront();
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //UCSanXuat_baoCaoSanLuongTheoMay ucc = new UCSanXuat_baoCaoSanLuongTheoMay();
            //ucc.Dock = DockStyle.Fill;
            //panelControl1.Controls.Add(ucc);
            //ucc.BringToFront();
            SanXuat_frmChiTietSoPhieu_RutGon ff = new SanXuat_frmChiTietSoPhieu_RutGon();
            ff.Show();
        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCSanXuat_baoCaoSanLuong_May_CAT ucc = new UCSanXuat_baoCaoSanLuong_May_CAT();
            ucc.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(ucc);
            ucc.BringToFront();
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCSanXuat_baoCaoSanLuong_May_DOT ucc = new UCSanXuat_baoCaoSanLuong_May_DOT();
            ucc.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(ucc);
            ucc.BringToFront();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCSanXuat_LuongCongNhanMay_IN ucc = new UCSanXuat_LuongCongNhanMay_IN();
            ucc.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(ucc);
            ucc.BringToFront();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCSanXuat_LuongCongNhanMay_CAT ucc = new UCSanXuat_LuongCongNhanMay_CAT();
            ucc.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(ucc);
            ucc.BringToFront();
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCSanXuat_LuongCongNhanMay_DOT ucc = new UCSanXuat_LuongCongNhanMay_DOT();
            ucc.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(ucc);
            ucc.BringToFront();
        }

        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCSanXuat_baoCaoSanLuong_Theo_MaHang ucc = new UCSanXuat_baoCaoSanLuong_Theo_MaHang();
            ucc.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(ucc);
            ucc.BringToFront();
        }

        private void navBarItem18_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCSanXuat_baoCaoSanLuong_Theo_MaHang_May_CAT ucc = new UCSanXuat_baoCaoSanLuong_Theo_MaHang_May_CAT();
            ucc.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(ucc);
            ucc.BringToFront();
        }

        private void navBarItem19_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCSanXuat_baoCaoSanLuong_Theo_MaHang_May_DOT ucc = new UCSanXuat_baoCaoSanLuong_Theo_MaHang_May_DOT();
            ucc.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(ucc);
            ucc.BringToFront();
        }

        private void SanXuat_frmQuanLySanXuat_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
        }

        private void navBarItem20_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCSanXuat_CaiDatMacDinh ucc = new UCSanXuat_CaiDatMacDinh();
            ucc.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(ucc);
            ucc.BringToFront();
        }

       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmGuiDuLieuLuongTheoSanLuong ucc = new frmGuiDuLieuLuongTheoSanLuong();
            ucc.Show();
        }

        private void navBarItem1_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmBaoCaoSanLuongTheoMaHang_IN_CAT_DOT ucc = new frmBaoCaoSanLuongTheoMaHang_IN_CAT_DOT();
            ucc.Show();
        }

        private void navBarItem14_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           
        }

        private void navBarItem2_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmBaoCaoSanLuongTheoNhomMay_IN_CAT_DOT ucc = new frmBaoCaoSanLuongTheoNhomMay_IN_CAT_DOT();
            ucc.Show();
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void navBarItem13_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCSanXuat_DinhMuc_ToGapDan ucc = new UCSanXuat_DinhMuc_ToGapDan();
            ucc.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(ucc);
            ucc.BringToFront();
        }

        private void navBarItem15_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCSanXuat_LenhSanXuat_DongBao_DongKien_Newwwwwwww ucc = new UCSanXuat_LenhSanXuat_DongBao_DongKien_Newwwwwwww();
            ucc.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(ucc);
            ucc.BringToFront();
        }

        private void navBarItem16_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmBaoCaoSanLuongToGapDan ucc = new frmBaoCaoSanLuongToGapDan();
            ucc.Show();
        }

        private void navBarItem14_LinkClicked_2(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmBaoCaoSanLuong_Theo_CongNhan ucc = new frmBaoCaoSanLuong_Theo_CongNhan();
            ucc.Show();
        }

        private void navBarItem16_LinkClicked_2(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCDinhMucHangNhu ucc = new UCDinhMucHangNhu();
            ucc.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(ucc);
            ucc.BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPrint_NguoiKy ff = new CtyTinLuong.frmPrint_NguoiKy();
            ff.Show();
        }
    }
}
