using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CtyTinLuong
{
    public partial class Xtra_XuatKho : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtra_XuatKho()
        {
            InitializeComponent();
        }

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (NPLChiTietNhapKho_DaiLy_ThemMoi.mbPrint_Chitiet_XuatKho_DaiLyGiaCong == true)
            {
                pNguoiNhan.Value = NPLChiTietNhapKho_DaiLy_ThemMoi.msNguoiNhan;
                pDienGiai.Value = NPLChiTietNhapKho_DaiLy_ThemMoi.msDienGiaig;
                pChungTuXuatKho.Value = NPLChiTietNhapKho_DaiLy_ThemMoi.msSoChungTu;
               // pKeToanTruong.Value = frmMain.msKeToanTruong;
                ////pGiamDoc.Value = frmMain.msGiamDoc;
                DateTime ngaychungtu = NPLChiTietNhapKho_DaiLy_ThemMoi.mdaNgayXuatKho;
                string ngay = ngaychungtu.ToString("dd");
                string thang = ngaychungtu.ToString("MM");
                string nam = ngaychungtu.ToString("yyyy");
                pNgayThang.Value = "Ngày " + ngay.ToString() + " tháng " + thang.ToString() + " năm " + nam.ToString() + "";               
                pNguoiLap.Value = NPLChiTietNhapKho_DaiLy_ThemMoi.msNguoiLap;
                pThuKho.Value = NPLChiTietNhapKho_DaiLy_ThemMoi.msThuKho;
                pGhiChuThanhPham.Value = NPLChiTietNhapKho_DaiLy_ThemMoi.msTenThanhPham;
                pSoLuongThanhPhamQuyDoi.Value = NPLChiTietNhapKho_DaiLy_ThemMoi.mfPrint_soluongtpqiuydoi;
            }
        }

    }
}
