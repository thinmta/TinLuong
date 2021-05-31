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
        private void Print_NhapKho_NPL()
        {
            pTieuDeNguoiNhap_Giao.Value = "Người giao hàng";
            pTieuDe.Value = "PHIẾU NHẬP KHO";
            pKho.Value = "Nhập tại kho: Kho Nguyên Phụ Liệu";
            pNguoiGiao_Nhan_TieuDe.Value = "Họ tên người giao hàng: "+ KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.msNguoiGiaoHang+ "";
            pDienGiai.Value = "Lý do nhập kho";
            pNguoiNhan_Giao.Value = KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.msNguoiGiaoHang;
            clsSoTienBangChu cls = new clsSoTienBangChu();
            pSoTienBangChu.Value = cls.DocTienBangChu(Convert.ToDouble(KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.mdbTongSotien), "đồng");
        }
        private void Print_NhapKho_NPL_NhapKhoKhac()
        {
            pTieuDeNguoiNhap_Giao.Value = "Người giao hàng";
            pTieuDe.Value = "PHIẾU NHẬP KHO";
            pKho.Value = "Nhập tại kho: Kho Nguyên Phụ Liệu";
            pNguoiGiao_Nhan_TieuDe.Value = "Họ tên người giao hàng: " + KhoNPL_ChiTiet_NhapKho_Khac.msNguoiGiaoHang + "";
            pDienGiai.Value = "Lý do nhập kho";
            pNguoiNhan_Giao.Value = KhoNPL_ChiTiet_NhapKho_Khac.msNguoiGiaoHang;
            clsSoTienBangChu cls = new clsSoTienBangChu();
            pSoTienBangChu.Value = cls.DocTienBangChu(Convert.ToDouble(KhoNPL_ChiTiet_NhapKho_Khac.mdbTongSotien), "đồng");
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
        }
    }
}
