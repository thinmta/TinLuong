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
    public partial class frmQuanLyKhoBanThanhPham : Form
    {
        private void HienThi_Caption()
        {
            clsHUU_LenhSanXuat cls1 = new clsHUU_LenhSanXuat();
            DataTable dxxxx1 = cls1.SelectAll_NhapKho_KhoBanThanhPham_Tat_CA();
            int k1 = dxxxx1.Rows.Count;
            if (k1 > 0)
            {
                NK_LSX_In_Cat_Dot.Caption = "NK LSX I_C_Đ (" + k1.ToString() + ")";                
                NK_LSX_In_Cat_Dot.Appearance.Font = new Font(NK_LSX_In_Cat_Dot.Appearance.Font, FontStyle.Bold);
            }

            DataTable dxxxx2 = cls1.SelectAll_NhapKho_KhoBanThanhPham_Tat_CA();
            int k2 = dxxxx2.Rows.Count;
            if (k2 > 0)
            {
                nav_XK_LSX_I_C_D.Caption = "XK LSX I_C_Đ (" + k2.ToString() + ")";
                nav_XK_LSX_I_C_D.Appearance.Font = new Font(nav_XK_LSX_I_C_D.Appearance.Font, FontStyle.Bold);
            }

            clsDaiLy_tbNhapKho cls3 = new clsDaiLy_tbNhapKho();
            DataTable dxxxx3xx = cls3.SelectAll();
            dxxxx3xx.DefaultView.RowFilter = "NgungTheoDoi=False and TonTai= True and TrangThaiXuatNhap_Kho_BTP=False and TrangThaiXuatNhap_Kho_NPL=True";
            DataView dv3 = dxxxx3xx.DefaultView;
           
            DataTable dxxxx3 = dv3.ToTable();
            int k3 = dxxxx3.Rows.Count;
            if (k3 > 0)
            {
                navXuatKhoRaDaiLyGiaCong.Caption = "Đại lý gia công (" + k3.ToString() + ")";
                navXuatKhoRaDaiLyGiaCong.Appearance.Font = new Font(navXuatKhoRaDaiLyGiaCong.Appearance.Font, FontStyle.Bold);
            }

            clsKhoBTP_tbNhapKho cls4 = new CtyTinLuong.clsKhoBTP_tbNhapKho();
            DataTable dxxxx3xx4 = cls4.SelectAll();
            dxxxx3xx4.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=false";
            DataView dvdxxxx3xx4 = dxxxx3xx4.DefaultView;
         
            DataTable dxxxx4 = dvdxxxx3xx4.ToTable();
            int k4 = dxxxx4.Rows.Count;
            if (k4 > 0)
            {
                navDaNhapKho.Caption = "Đã nhập kho (" + k4.ToString() + ")";              
            }
            clsKhoBTP_tbXuatKho cls5 = new CtyTinLuong.clsKhoBTP_tbXuatKho();
            DataTable dxxxx3xx5 = cls5.SelectAll();
            dxxxx3xx5.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=false";
            DataView dvdxxxx3xx5 = dxxxx3xx5.DefaultView;

            DataTable dxxxx5 = dvdxxxx3xx5.ToTable();
            int k5 = dxxxx5.Rows.Count;
            if (k5 > 0)
            {
                navDaXuatKho.Caption = "Đã xuất kho (" + k5.ToString() + ")";
            }

            clsHUU_LenhSanXuat cls6 = new clsHUU_LenhSanXuat();
            DataTable dt6 = cls6.SelectAll_Xuat_Kho_KhoBanThanhPham_Tat_CA();
            int k6 = dt6.Rows.Count;
            if (k6 > 0)
            {
                nav_XK_LSX_I_C_D.Caption = "XK LSX I-C-Đ (" + k6.ToString() + ")";
                nav_XK_LSX_I_C_D.Appearance.Font = new Font(nav_XK_LSX_I_C_D.Appearance.Font, FontStyle.Bold);
            }

            clsGapDan_tbNhapKho cls7 = new clsGapDan_tbNhapKho();
            DataTable dt7 = cls7.SelectAll_HienThi();
            dt7.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=false and TrangThai_XuatKho_BTP=False";
            DataView dv7 = dt7.DefaultView;
            DataTable dxxxx7 = dv7.ToTable();
            int k7 = dxxxx7.Rows.Count;
            if (k7 > 0)
            {
                navXuatKhoGapDan.Caption = "Xuất kho Gấp dán (" + k7.ToString() + ")";
                navXuatKhoGapDan.Appearance.Font = new Font(navXuatKhoGapDan.Appearance.Font, FontStyle.Bold);
            }

            clsDaiLy_tbXuatKho cls8 = new clsDaiLy_tbXuatKho();
            //cls8.bTrangThaiXuatNhap_ThanhPham_TuDaiLyVe
            DataTable dt8 = cls8.SelectAll();
            //string s1 = "TrangThaiXuatNhap_ThanhPham_TuDaiLyVe";
            //string s2 = "CheckNhapKho_ThanhPham_True_nhapKhoBTP_False";
            //dt8.DefaultView.RowFilter = "'"+s1+"'=Fase and '"+s2+"'=False";
            dt8.DefaultView.RowFilter = "TrangThaiXuatNhap_ThanhPham_TuDaiLyVe=0 and CheckNhapKho_ThanhPham_True_nhapKhoBTP_False=0";
            //dt8.DefaultView.RowFilter = "TrangThaiXuatNhap_ThanhPham_TuDaiLyVe = Fase and DaXuatKho =True and CheckNhapKho_ThanhPham_True_nhapKhoBTP_False = False";
            //dt8.DefaultView.RowFilter = "DaXuatKho=True and CheckNhapKho_ThanhPham_True_nhapKhoBTP_False = False";
            //"DaXuatKho = True and CheckNhapKho_ThanhPham_True_nhapKhoBTP_False = False";
            DataView dv8 = dt8.DefaultView;
            DataTable dxxxx8 = dv8.ToTable();
            int k8 = dxxxx8.Rows.Count;
            if (k8 > 0)
            {
                navNhapKhoDaiLy2222222222222.Caption = "Nhập kho từ Đại lý (" + k8.ToString() + ")";
                navNhapKhoDaiLy2222222222222.Appearance.Font = new Font(navNhapKhoDaiLy2222222222222.Appearance.Font, FontStyle.Bold);
            }
            //navNhapKhoGapDan
            clsGapDan_tbXuatKho cls9 = new clsGapDan_tbXuatKho();
            DataTable dt9 = cls9.SelectAll_HienThi();
            dt9.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=false and DaXuatKho=True and TrangThaiNhapKhoBTP_ThanhPham=False";
            DataView dv9 = dt9.DefaultView;
            DataTable dxxxx9 = dv9.ToTable();
            int k9 = dxxxx9.Rows.Count;
            if (k9 > 0)
            {
                navNhapKhoGapDan.Caption = "Nhập kho Gấp dán (" + k9.ToString() + ")";
                navNhapKhoGapDan.Appearance.Font = new Font(navNhapKhoGapDan.Appearance.Font, FontStyle.Bold);
            }

        }
       
        public frmQuanLyKhoBanThanhPham()
        {
            InitializeComponent();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCBanThanhPham_NhapKhoTheoLenhSanXuat uccc_DaNhapKho = new UCBanThanhPham_NhapKhoTheoLenhSanXuat();
            uccc_DaNhapKho.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uccc_DaNhapKho);
            uccc_DaNhapKho.BringToFront();
        }

        private void btThooat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCBanThanhPham_DaNhapKhoTheoLenhSanXuat uccc_DaNhapKho = new UCBanThanhPham_DaNhapKhoTheoLenhSanXuat();
            uccc_DaNhapKho.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uccc_DaNhapKho);
            uccc_DaNhapKho.BringToFront();
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCBanThanhPham_XuatKhoTheoLenhSanXuat uccc_DaNhapKho = new UCBanThanhPham_XuatKhoTheoLenhSanXuat();
            uccc_DaNhapKho.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uccc_DaNhapKho);
            uccc_DaNhapKho.BringToFront();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCBanThanhPham_XuatKhoDaiLy uccc_DaNhapKho = new UCBanThanhPham_XuatKhoDaiLy();
            uccc_DaNhapKho.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uccc_DaNhapKho);
            uccc_DaNhapKho.BringToFront();
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCbanThanhPham_DaXuatKho uccc_DaNhapKho = new UCbanThanhPham_DaXuatKho();
            uccc_DaNhapKho.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uccc_DaNhapKho);
            uccc_DaNhapKho.BringToFront();
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCBanThanhPham_TongHopTonKho uccc_DaNhapKho = new UCBanThanhPham_TongHopTonKho();
            uccc_DaNhapKho.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uccc_DaNhapKho);
            uccc_DaNhapKho.BringToFront();
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCBanThanhPham_ChiTiet_DaNhapKho_ALL uccc_DaNhapKho = new UCBanThanhPham_ChiTiet_DaNhapKho_ALL();
            uccc_DaNhapKho.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uccc_DaNhapKho);
            uccc_DaNhapKho.BringToFront();
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCBanThanhPham_ChiTietDaXuatKho_ALL uccc_DaNhapKho = new UCBanThanhPham_ChiTietDaXuatKho_ALL();
            uccc_DaNhapKho.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uccc_DaNhapKho);
            uccc_DaNhapKho.BringToFront();
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmBaoCaoNhapXuatTon_BanThanhPham uccc_DaNhapKho = new frmBaoCaoNhapXuatTon_BanThanhPham();
            uccc_DaNhapKho.Show();
        }

        private void frmQuanLyKhoBanThanhPham_Load(object sender, EventArgs e)
        {
            HienThi_Caption();
        }

        private void navBarItem1_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmQuanLyKhoBanThanhPham_Load( sender,  e);
        }

        private void navXuatKhoGapDan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCBanThanhPham_XuatKho_ToGapDan uccc_DaNhapKho = new UCBanThanhPham_XuatKho_ToGapDan();
            uccc_DaNhapKho.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uccc_DaNhapKho);
            uccc_DaNhapKho.BringToFront();
        }

        private void navNhapKhoDaiLy_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCBanThanhPham_NhapKho_TuDaiLy uccc_DaNhapKho = new UCBanThanhPham_NhapKho_TuDaiLy();
            uccc_DaNhapKho.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uccc_DaNhapKho);
            uccc_DaNhapKho.BringToFront();
        }

        private void navNhapKhoGapDan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCBanThanhPham_NhapKho_Tu_GapDan uccc_DaNhapKho = new UCBanThanhPham_NhapKho_Tu_GapDan();
            uccc_DaNhapKho.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uccc_DaNhapKho);
            uccc_DaNhapKho.BringToFront();
        }

        private void navBarItem2_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCBanThanhPham_NhapKho_Khac uccc_DaNhapKho = new UCBanThanhPham_NhapKho_Khac();
            uccc_DaNhapKho.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uccc_DaNhapKho);
            uccc_DaNhapKho.BringToFront();
        }

        private void navBarItem3_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UCBanThanhPham_XuatKho_Khac uccc_DaNhapKho = new UCBanThanhPham_XuatKho_Khac();
            uccc_DaNhapKho.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uccc_DaNhapKho);
            uccc_DaNhapKho.BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPrint_NguoiKy ff = new CtyTinLuong.frmPrint_NguoiKy();
            ff.Show();
        }
    }
}
