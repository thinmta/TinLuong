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
    public partial class frmMain : Form
    {
      //
        private void QuyenTruyCap()
        {
           // thiếtLậpBanĐầuToolStripMenuItem.Enabled = false;
            clsTbDangNhap cls = new CtyTinLuong.clsTbDangNhap();
            cls.iID_DangNhap = frmDangNhap.miID_DangNhap;
            DataTable dt = cls.SelectOne();
            
            if(dt.Rows.Count>0)
            {
               

                if (cls.bBMuaHang.Value == false)
                    btMuaHang.Enabled = false;
                if (cls.bBBanHang.Value == false)
                    btBanHang.Enabled = false;
                if (cls.bBNguyenPhuLieu.Value == false)
                    btNguyenPhuLieu.Enabled = false;
                if (cls.bBBanThanhPham.Value == false)
                    btBanThanhPham.Enabled = false;
                if (cls.bBDaiLy.Value == false)
                    btDaily.Enabled = false;
                if (cls.bBThanhPham.Value == false)
                    btThanhPham.Enabled = false;
                if (cls.bBQuanLySanXuat.Value == false)
                    btQuanLySanXuat.Enabled = false;
                if (cls.bBLuongChamCong.Value == false)
                    btLuongChamCong.Enabled = false;
                if (cls.bBQuyNganHang.Value == false)
                    btQuyNganHang.Enabled = false;
                if (cls.bBQuanTri.Value == true)
                {
                    stripQuanTri.Enabled = true;
                    stripHeThong.Enabled = true;
                }

                else
                {
                    stripQuanTri.Enabled = false;
                    stripHeThong.Enabled = false;
                }
                    
            }
        }
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void quảnTrịTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan ff = new CtyTinLuong.frmQuanLyTaiKhoan();
            ff.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmMuaHang2222 ff = new frmMuaHang2222();
            ff.Show();
        }

        private void btThooat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            KhoNPL_frmNPL ff = new KhoNPL_frmNPL();
            ff.Show();
                
        }

        private void quảnTrịVTHHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVatTuHangHoa ff = new frmVatTuHangHoa();
            ff.Show();
        }

        private void quảnTrịNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanSu ff = new frmNhanSu();
            ff.Show();
        }

        private void quảnTrịKháchHầngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang ff = new frmKhachHang();
            ff.Show();
        }

        private void quảnTrịNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap ff = new frmNhaCungCap();
            ff.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            QuyenTruyCap();
            
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
           
        }

        private void importDuLieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_imPortDuLieu_Moiiiiiiiiiiiiiiiiiiiiiiiiiii ff = new CtyTinLuong.frm_imPortDuLieu_Moiiiiiiiiiiiiiiiiiiiiiiiiiii();
            ff.Show();
        }

        private void btDinhMucDot_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnTrịĐơnVịTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyDonViTinh ff = new frmQuanLyDonViTinh();
            ff.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frmQuanLyKhoDaiLy ff = new frmQuanLyKhoDaiLy();
            ff.Show();
        }

        private void quảnTrịĐạiLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyDaiLy ff = new frmQuanLyDaiLy();
            ff.Show();
        }

        private void quảnTrịMáySảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyMayMoc ff = new CtyTinLuong.frmQuanLyMayMoc();
            ff.Show();
        }

        private void btQuanLySanXuat_Click(object sender, EventArgs e)
        {
            SanXuat_frmQuanLySanXuat ff = new SanXuat_frmQuanLySanXuat();
            ff.Show();
        }

        private void quảnTrịĐịnhMứcLươngCôngNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyDinhMucLuong ff = new frmQuanLyDinhMucLuong();
            ff.Show();
        }

        private void quảnTrịĐịnhMứcLươngTheoSảnLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyDinhMucLuongTheoSanLuong ff = new frmQuanLyDinhMucLuongTheoSanLuong();
            ff.Show();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            frmQuanLy_Luong_ChamCong ff = new CtyTinLuong.frmQuanLy_Luong_ChamCong();
            ff.Show();
        }

        private void btKhoThanhPham_Click(object sender, EventArgs e)
        {
            frmQuanLyKhoThanhPham ff = new CtyTinLuong.frmQuanLyKhoThanhPham();
            ff.Show();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {

            frmQuanLyBanHang ff = new CtyTinLuong.frmQuanLyBanHang();
            ff.Show();
        }

        private void quảnTrịHệThốngTàiKhoảnKếToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoanKeToan ff = new CtyTinLuong.frmQuanLyTaiKhoanKeToan();
            ff.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frmQuy_NganHang_Newwwwwwwwwwwwwwwww ff = new CtyTinLuong.frmQuy_NganHang_Newwwwwwwwwwwwwwwww();
            ff.Show();
        }

        private void quảnTrịTàiKhoảnGửiNgânHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void vvvvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmQuanLyKhoBanThanhPham ff = new CtyTinLuong.frmQuanLyKhoBanThanhPham();
            ff.Show();
        }

        private void thiếtLậpBanĐầuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_imPortDuLieu_Moiiiiiiiiiiiiiiiiiiiiiiiiiii ggg = new frm_imPortDuLieu_Moiiiiiiiiiiiiiiiiiiiiiiiiiii();
            ggg.Show();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            clsDelete_ALL_newwww cls = new clsDelete_ALL_newwww();
            cls.HUU_Delete_ALL();
            MessageBox.Show("Đã xoá ALLL");
        }

       
        private void simpleButton10_Click_1(object sender, EventArgs e)
        {
            clsNganHang_ChiTietBienDongTaiKhoanKeToan cls = new clsNganHang_ChiTietBienDongTaiKhoanKeToan();
           
            MessageBox.Show("Đã xong");
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap ff = new frmDangNhap();
            ff.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau ff = new frmDoiMatKhau();
            ff.Show();
        }

        private void tắtChươngTrìnhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            clsMH_tbMuaHang cls1 = new clsMH_tbMuaHang();
            cls1.daNgayChungTu = DateTime.Today;
            cls1.sSoChungTu = "MH 1";
            cls1.sSoHoaDon = "";
            cls1.iIDNhaCungCap = 3;
            cls1.sDienGiai = "";
            cls1.fTongTienHangChuaVAT = 17000000;
            cls1.fTongTienHangCoVAT = 18700000;
            cls1.iID_NguoiMua = 12;
            cls1.bTonTai = true;
            cls1.bNgungTheoDoi = false;
            //cls1.iID_TKNo = 46;
            //cls1.iID_TKCo = 291;
            //cls1.iID_TKVAT = 79;
            cls1.bTienUSD = false;
            cls1.fPhanTramVAT = 10;
            cls1.fTienVAT = 1700000;
            cls1.bMuaHangNhapKho = true;
            cls1.bGuiDuLieu = true;
            cls1.bCheck_BaoVe = true;
            cls1.bCheck_LaiXe = true;
            cls1.bTrangThaiNhapKho = false;
            cls1.Insert();
            int iiDIMuahang = cls1.iID_MuaHang.Value;

            clsMH_tbChiTietMuaHang cls2 = new clsMH_tbChiTietMuaHang();
            cls2.iID_MuaHang = iiDIMuahang;
            cls2.iID_VTHH = 741;
            cls2.fSoLuong = 100;
            cls2.fDonGia = 100000;
            cls2.bTonTai = true;
            cls2.bNgungTheoDoi = false;
            cls2.sGhiChu = "test";
            cls2.Insert();

            cls2.iID_MuaHang = iiDIMuahang;
            cls2.iID_VTHH = 108;
            cls2.fSoLuong = 10000;
            cls2.fDonGia = 100;
            cls2.bTonTai = true;
            cls2.bNgungTheoDoi = false;
            cls2.sGhiChu = "test";
            cls2.Insert();

            cls2.iID_MuaHang = iiDIMuahang;
            cls2.iID_VTHH = 1116;
            cls2.fSoLuong = 10000;
            cls2.fDonGia = 100;
            cls2.bTonTai = true;
            cls2.bNgungTheoDoi = false;
            cls2.sGhiChu = "test";
            cls2.Insert();

            cls2.iID_MuaHang = iiDIMuahang;
            cls2.iID_VTHH = 938;
            cls2.fSoLuong = 10000;
            cls2.fDonGia = 100;
            cls2.bTonTai = true;
            cls2.bNgungTheoDoi = false;
            cls2.sGhiChu = "test";
            cls2.Insert();

            cls2.iID_MuaHang = iiDIMuahang;
            cls2.iID_VTHH = 440;
            cls2.fSoLuong = 10000;
            cls2.fDonGia = 100;
            cls2.bTonTai = true;
            cls2.bNgungTheoDoi = false;
            cls2.sGhiChu = "test";
            cls2.Insert();

            cls2.iID_MuaHang = iiDIMuahang;
            cls2.iID_VTHH = 104;
            cls2.fSoLuong = 10000;
            cls2.fDonGia = 100;
            cls2.bTonTai = true;
            cls2.bNgungTheoDoi = false;
            cls2.sGhiChu = "test";
            cls2.Insert();

            cls2.iID_MuaHang = iiDIMuahang;
            cls2.iID_VTHH = 43;
            cls2.fSoLuong = 10000;
            cls2.fDonGia = 100;
            cls2.bTonTai = true;
            cls2.bNgungTheoDoi = false;
            cls2.sGhiChu = "test";
            cls2.Insert();

            cls2.iID_MuaHang = iiDIMuahang;
            cls2.iID_VTHH = 471;
            cls2.fSoLuong = 10000;
            cls2.fDonGia = 100;
            cls2.bTonTai = true;
            cls2.bNgungTheoDoi = false;
            cls2.sGhiChu = "test";
            cls2.Insert();

           

            MessageBox.Show("Đã xong");
        }

        private void càiĐặtMặcĐịnhNgườiKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrint_NguoiKy ff = new frmPrint_NguoiKy();
            ff.Show();
        }

        private void kếHoạchSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKeHoachSanXuat ff = new frmKeHoachSanXuat();
            ff.Show();

        }

        private void insertPhieuSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImPortPhieuSanXuat_banDau ff = new frmImPortPhieuSanXuat_banDau();
            ff.Show();
        }

        private void ngânHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImPortPhieuNganHang ff = new frmImPortPhieuNganHang();
            ff.Show();
        }

        private void nXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoNXT ff = new frmBaoCaoNXT();
            ff.Show();
        }
    }
}
