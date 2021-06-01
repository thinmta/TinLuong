using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace CtyTinLuong
{
    public partial class Xtra_Nhap_XuatKho : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtra_Nhap_XuatKho()
        {
            InitializeComponent();
        }

        private void Print_KhoBTP_ChiTiet_XuatKho_Khac()
        {
            pTieuDeNguoiNhap_Giao.Value = "Người giao hàng";
            pTieuDe.Value = "PHIẾU XUẤT KHO";
            pKho.Value = "Xuất tại kho: Kho Bán Thành Phẩm";
            pNguoiGiao_Nhan_TieuDe.Value = "Họ tên người giao hàng: " + KhoBTP_ChiTiet_XuatKho_Khac.msNguoiGiaoHang + "";
            pDienGiai.Value = "Lý do xuất kho: " + KhoBTP_ChiTiet_XuatKho_Khac.msDienGiai + "";
            pNguoiNhan_Giao.Value = KhoBTP_ChiTiet_XuatKho_Khac.msNguoiGiaoHang;
            clsSoTienBangChu cls = new clsSoTienBangChu();
            pSoTienBangChu.Value = cls.DocTienBangChu(Convert.ToDouble(KhoBTP_ChiTiet_XuatKho_Khac.mdbTongSotien), " đồng");
            DateTime ngay = KhoBTP_ChiTiet_XuatKho_Khac.mdaNgayChungTu;
            pNgayThang.Value = "Ngày " + ngay.ToString("dd") + " tháng " + ngay.ToString("MM") + " năm " + ngay.ToString("yyyy") + "";
            pSoChungTu.Value = "Số: " + KhoBTP_ChiTiet_XuatKho_Khac.msSoChungTu + "";
        }
        private void Print_KhoBTP_ChiTietDaXuatKho()
        {
            pTieuDeNguoiNhap_Giao.Value = "Người giao hàng";
            pTieuDe.Value = "PHIẾU XUẤT KHO";
            pKho.Value = "Xuất tại kho: Kho Bán Thành Phẩm";
            pNguoiGiao_Nhan_TieuDe.Value = "Họ tên người giao hàng: " + KhoBTP_ChiTietDaXuatKho.msNguoiGiaoHang + "";
            pDienGiai.Value = "Lý do xuất kho: " + KhoBTP_ChiTietDaXuatKho.msDienGiai + "";
            pNguoiNhan_Giao.Value = KhoBTP_ChiTietDaXuatKho.msNguoiGiaoHang;
            clsSoTienBangChu cls = new clsSoTienBangChu();
            pSoTienBangChu.Value = cls.DocTienBangChu(Convert.ToDouble(KhoBTP_ChiTietDaXuatKho.mdbTongSotien), " đồng");
            DateTime ngay = KhoBTP_ChiTiet_DaNhapKho.mdaNgayChungTu;
            pNgayThang.Value = "Ngày " + ngay.ToString("dd") + " tháng " + ngay.ToString("MM") + " năm " + ngay.ToString("yyyy") + "";
            pSoChungTu.Value = "Số: " + KhoBTP_ChiTietDaXuatKho.msSoChungTu + "";
        }
        private void Print_KhoBTP_ChiTiet_DaNhapKho()
        {
            pTieuDeNguoiNhap_Giao.Value = "Người giao hàng";
            pTieuDe.Value = "PHIẾU NHẬP KHO";
            pKho.Value = "Nhập tại kho: Kho Bán Thành Phẩm";
            pNguoiGiao_Nhan_TieuDe.Value = "Họ tên người giao hàng: " + KhoBTP_ChiTiet_DaNhapKho.msNguoiGiaoHang + "";
            pDienGiai.Value = "Lý do nhập kho: " + KhoBTP_ChiTiet_DaNhapKho.msDienGiai + "";
            pNguoiNhan_Giao.Value = KhoBTP_ChiTiet_DaNhapKho.msNguoiGiaoHang;
            clsSoTienBangChu cls = new clsSoTienBangChu();
            pSoTienBangChu.Value = cls.DocTienBangChu(Convert.ToDouble(KhoBTP_ChiTiet_DaNhapKho.mdbTongSotien), " đồng");
            DateTime ngay = KhoBTP_ChiTiet_DaNhapKho.mdaNgayChungTu;
            pNgayThang.Value = "Ngày " + ngay.ToString("dd") + " tháng " + ngay.ToString("MM") + " năm " + ngay.ToString("yyyy") + "";
            pSoChungTu.Value = "Số: " + KhoBTP_ChiTiet_DaNhapKho.msSoChungTu + "";
        }
        private void Print_KhoBTP_ChiTiet_NhapKho_Khac()
        {
            pTieuDeNguoiNhap_Giao.Value = "Người giao hàng";
            pTieuDe.Value = "PHIẾU NHẬP KHO";
            pKho.Value = "Nhập tại kho: Kho Bán Thành Phẩm";
            pNguoiGiao_Nhan_TieuDe.Value = "Họ tên người giao hàng: " + KhoBTP_ChiTiet_NhapKho_Khac.msNguoiGiaoHang + "";
            pDienGiai.Value = "Lý do nhập kho: " + KhoBTP_ChiTiet_NhapKho_Khac.msDienGiai + "";
            pNguoiNhan_Giao.Value = KhoBTP_ChiTiet_NhapKho_Khac.msNguoiGiaoHang;
            clsSoTienBangChu cls = new clsSoTienBangChu();
            pSoTienBangChu.Value = cls.DocTienBangChu(Convert.ToDouble(KhoBTP_ChiTiet_NhapKho_Khac.mdbTongSotien), " đồng");
            DateTime ngay = KhoBTP_ChiTiet_NhapKho_Khac.mdaNgayChungTu;
            pNgayThang.Value = "Ngày " + ngay.ToString("dd") + " tháng " + ngay.ToString("MM") + " năm " + ngay.ToString("yyyy") + "";
            pSoChungTu.Value = "Số: " + KhoBTP_ChiTiet_NhapKho_Khac.msSoChungTu + "";
        }
        private void Print_KhoNPL_ChiTiet_XuatKho_Khac()
        {
            pTieuDeNguoiNhap_Giao.Value = "Người nhận hàng";
            pTieuDe.Value = "PHIẾU XUẤT KHO";
            pKho.Value = "Xuất tại kho: Kho Nguyên Phụ Liệu";
            pNguoiGiao_Nhan_TieuDe.Value = "Họ tên người nhận hàng: " + KhoNPL_ChiTiet_XuatKho_Khac.msNguoiNhanHang + "";
            pDienGiai.Value = "Lý do xuất kho: " + KhoNPL_ChiTiet_XuatKho_Khac.msDienGiai + "";
            pNguoiNhan_Giao.Value = KhoNPL_ChiTiet_XuatKho_Khac.msNguoiNhanHang;
            clsSoTienBangChu cls = new clsSoTienBangChu();
            pSoTienBangChu.Value = cls.DocTienBangChu(Convert.ToDouble(KhoNPL_ChiTiet_XuatKho_Khac.mdbTongSotien), " đồng");
            DateTime ngay = KhoNPL_ChiTiet_XuatKho_Khac.mdaNgayChungTu;
            pNgayThang.Value = "Ngày " + ngay.ToString("dd") + " tháng " + ngay.ToString("MM") + " năm " + ngay.ToString("yyyy") + "";
            pSoChungTu.Value = "Số: " + KhoNPL_ChiTiet_XuatKho_Khac.msSoChungTu + "";
        }
        private void Print_frmKhoNPL_DaXuatKho()
        {
            pTieuDeNguoiNhap_Giao.Value = "Người nhận hàng";
            pTieuDe.Value = "PHIẾU XUẤT KHO";
            pKho.Value = "Xuất tại kho: Kho Nguyên Phụ Liệu";
            pNguoiGiao_Nhan_TieuDe.Value = "Họ tên người nhận hàng: " + frmKhoNPL_DaXuatKho.msNguoiNhanHang + "";
            pDienGiai.Value = "Lý do xuất kho: "+ frmKhoNPL_DaXuatKho.msDienGiai+ "";
            pNguoiNhan_Giao.Value = frmKhoNPL_DaXuatKho.msNguoiNhanHang;
            clsSoTienBangChu cls = new clsSoTienBangChu();
            pSoTienBangChu.Value = cls.DocTienBangChu(Convert.ToDouble(frmKhoNPL_DaXuatKho.mdbTongSotien), " đồng");
            DateTime ngay = frmKhoNPL_DaXuatKho.mdaNgayChungTu;
            pNgayThang.Value = "Ngày " + ngay.ToString("dd") + " tháng " + ngay.ToString("MM") + " năm " + ngay.ToString("yyyy") + "";
            pSoChungTu.Value = "Số: " + frmKhoNPL_DaXuatKho.msSoChungTu + "";
        }
        private void Print_NhapKho_NPL()
        {
            pTieuDeNguoiNhap_Giao.Value = "Người giao hàng";
            pTieuDe.Value = "PHIẾU NHẬP KHO";
            pKho.Value = "Nhập tại kho: Kho Nguyên Phụ Liệu";
            pNguoiGiao_Nhan_TieuDe.Value = "Họ tên người giao hàng: "+ KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.msNguoiGiaoHang+ "";
            pDienGiai.Value = "Lý do nhập kho: "+ KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.msDienGiai + "";
            pNguoiNhan_Giao.Value = KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.msNguoiGiaoHang;
            clsSoTienBangChu cls = new clsSoTienBangChu();
            pSoTienBangChu.Value = cls.DocTienBangChu(Convert.ToDouble(KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.mdbTongSotien), " đồng");
            DateTime ngay = KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.mdaNgayChungTu;
            pNgayThang.Value = "Ngày " + ngay.ToString("dd") + " tháng " + ngay.ToString("MM") + " năm " + ngay.ToString("yyyy") + "";
            pSoChungTu.Value = KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.msSoChungTu;
            pSoChungTu.Value = "Số: " + KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.msSoChungTu + "";
        }
        private void Print_NhapKho_NPL_NhapKhoKhac()
        {
            pTieuDeNguoiNhap_Giao.Value = "Người giao hàng";
            pTieuDe.Value = "PHIẾU NHẬP KHO";
            pKho.Value = "Nhập tại kho: Kho Nguyên Phụ Liệu";
            pNguoiGiao_Nhan_TieuDe.Value = "Họ tên người giao hàng: " + KhoNPL_ChiTiet_NhapKho_Khac.msNguoiGiaoHang + "";
            pDienGiai.Value = "Lý do nhập kho: " + KhoNPL_ChiTiet_NhapKho_Khac.msDienGiai + "";
            pNguoiNhan_Giao.Value = KhoNPL_ChiTiet_NhapKho_Khac.msNguoiGiaoHang;
            clsSoTienBangChu cls = new clsSoTienBangChu();
            pSoTienBangChu.Value = cls.DocTienBangChu(Convert.ToDouble(KhoNPL_ChiTiet_NhapKho_Khac.mdbTongSotien), " đồng");

            DateTime ngay = KhoNPL_ChiTiet_NhapKho_Khac.mdaNgayChungTu;
            pNgayThang.Value = "Ngày " + ngay.ToString("dd") + " tháng " + ngay.ToString("MM") + " năm " + ngay.ToString("yyyy") + "";
            pSoChungTu.Value = "Số: "+ KhoNPL_ChiTiet_NhapKho_Khac.msSoChungTu + "";
        }
        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                clsAaatbMacDinhNguoiKy cls = new CtyTinLuong.clsAaatbMacDinhNguoiKy();
                cls.iID_DangNhap = frmDangNhap.miID_DangNhap;
                DataTable dt = cls.SelectAll_ID_DangNhap();
                if (dt.Rows.Count > 0)
                {
                    pNguoiLap.Value = dt.Rows[1]["HoTen"].ToString();
                    pKeToan.Value = dt.Rows[6]["HoTen"].ToString();
                    pThuKho.Value = dt.Rows[3]["HoTen"].ToString();
                    pGiamDoc.Value= dt.Rows[7]["HoTen"].ToString();
                }
            }
            catch
            { }

            if (KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.mbPrint==true)
                Print_NhapKho_NPL();
            if (KhoNPL_ChiTiet_NhapKho_Khac.mbPrint == true)
                Print_NhapKho_NPL_NhapKhoKhac();
            if (frmKhoNPL_DaXuatKho.mbPrint == true)
                Print_frmKhoNPL_DaXuatKho();

            if (KhoNPL_ChiTiet_XuatKho_Khac.mbPrint == true)
                Print_KhoNPL_ChiTiet_XuatKho_Khac();

            if (KhoBTP_ChiTiet_DaNhapKho.mbPrint == true)
                Print_KhoBTP_ChiTiet_DaNhapKho();
            if (KhoBTP_ChiTiet_NhapKho_Khac.mbPrint == true)
                Print_KhoBTP_ChiTiet_NhapKho_Khac();

            if (KhoBTP_ChiTietDaXuatKho.mbPrint == true)
                Print_KhoBTP_ChiTietDaXuatKho();

            if (KhoBTP_ChiTiet_XuatKho_Khac.mbPrint == true)
                Print_KhoBTP_ChiTiet_XuatKho_Khac();
        }
    }
}
