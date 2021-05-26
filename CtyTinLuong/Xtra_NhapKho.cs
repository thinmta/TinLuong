using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CtyTinLuong
{
    public partial class Xtra_NhapKho : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtra_NhapKho()
        {
            InitializeComponent();
        }
        
        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.mbPrint_Chitiet_Da_NhapKho_TuMuaHang == false)
            {
                pTenPhieu.Value = "PHIẾU NHẬP KHO";
                pChungTuMuaHang.Value = KhoNPL_frmChiTiet_MuaHang_NhapKho.msSoChungTu_MuaHang;
                pChungTuNhapKho.Value = KhoNPL_frmChiTiet_MuaHang_NhapKho.msSoChungTu_NhapKho;
                //pKeToanTruong.Value = frmMain.msKeToanTruong;
                //pGiamDoc.Value = frmMain.msGiamDoc;
                DateTime ngaychungtu = KhoNPL_frmChiTiet_MuaHang_NhapKho.mdaNgayNhapKho;
                string ngay = ngaychungtu.ToString("dd");
                string thang = ngaychungtu.ToString("MM");
                string nam = ngaychungtu.ToString("yyyy");
                pNgayThang.Value = "Ngày " + ngay.ToString() + " tháng " + thang.ToString() + " năm " + nam.ToString() + "";
                DateTime ngaymuahang = KhoNPL_frmChiTiet_MuaHang_NhapKho.mdaNgayMuaHang;
                pNgayMuaHang.Value = ngaymuahang.ToString("dd/MM/yyyy");
                pNguoiLap.Value = KhoNPL_frmChiTiet_MuaHang_NhapKho.msNguoiMuaHang;
                pThuKho.Value = KhoNPL_frmChiTiet_MuaHang_NhapKho.msThuKho;
            }
            else
            {
                pTenPhieu.Value = "PHIẾU NHẬP KHO";
                pChungTuMuaHang.Value = KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.msSoChungTu_MuaHang;
                pChungTuNhapKho.Value = KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.msSoChungTu_NhapKho;
                //pKeToanTruong.Value = frmMain.msKeToanTruong;
                //pGiamDoc.Value = frmMain.msGiamDoc;
                DateTime ngaychungtu = KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.mdaNgayNhapKho;
                string ngay = ngaychungtu.ToString("dd");
                string thang = ngaychungtu.ToString("MM");
                string nam = ngaychungtu.ToString("yyyy");
                pNgayThang.Value = "Ngày " + ngay.ToString() + " tháng " + thang.ToString() + " năm " + nam.ToString() + "";
                DateTime ngaymuahang = KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.mdaNgayMuaHang;
                pNgayMuaHang.Value = ngaymuahang.ToString("dd/MM/yyyy");
                pNguoiLap.Value = KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.msNguoiMuaHang;
                pThuKho.Value = KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.msThuKho;
            }

        
        }

    }
}
