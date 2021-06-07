using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace CtyTinLuong
{
    public partial class Xtra_BaoCaoSanLuong_ToMay_IN : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtra_BaoCaoSanLuong_ToMay_IN()
        {
            InitializeComponent();
        }

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //pNguoiLap.Value = SanXuat_frmChiTietSoPhieu_RutGon.ms
            clsAaatbMacDinhNguoiKy cls = new CtyTinLuong.clsAaatbMacDinhNguoiKy();
            cls.iID_DangNhap = frmDangNhap.miID_DangNhap;
            DataTable dt = cls.SelectAll_ID_DangNhap();
           
            if (dt.Rows.Count > 0)
            {               
                pGiamDoc.Value = dt.Rows[6]["HoTen"].ToString();
                pTruongPhong.Value = dt.Rows[4]["HoTen"].ToString();
                pNguoiLap.Value = dt.Rows[1]["HoTen"].ToString();
            }
            else
            {
                //pNguoiLap.Value = frmMain.msQuanLySX;
                //pGiamDoc.Value = frmMain.msGiamDoc;
                //pTruongPhong.Value = frmMain.msTruongPhongTH;
            }
            //if (frmBaoCaoSanLuongTheoNhomMay_IN_CAT_DOT.mbPrint == true)
            //{
            //    if (frmBaoCaoSanLuongTheoNhomMay_IN_CAT_DOT.miPrtint_ALL_0_IN_1_CAT_2_Dot_3 == 0)
            //        pTieuDe.Value = "BÁO CÁO SẢN LƯỢNG TỔ MÁY IN - CẮT - ĐỘT";
            //    if (frmBaoCaoSanLuongTheoNhomMay_IN_CAT_DOT.miPrtint_ALL_0_IN_1_CAT_2_Dot_3 == 1)
            //        pTieuDe.Value = "BÁO CÁO SẢN LƯỢNG TỔ MÁY IN";
            //    if (frmBaoCaoSanLuongTheoNhomMay_IN_CAT_DOT.miPrtint_ALL_0_IN_1_CAT_2_Dot_3 == 2)
            //        pTieuDe.Value = "BÁO CÁO SẢN LƯỢNG TỔ MÁY CẮT";
            //    if (frmBaoCaoSanLuongTheoNhomMay_IN_CAT_DOT.miPrtint_ALL_0_IN_1_CAT_2_Dot_3 == 3)
            //        pTieuDe.Value = "BÁO CÁO SẢN LƯỢNG TỔ MÁY ĐỘT";
            //    if (frmBaoCaoSanLuongTheoNhomMay_IN_CAT_DOT.mbNgayThang_null == true)
            //        pNgayThang.Value = "Từ ngày " + frmBaoCaoSanLuongTheoNhomMay_IN_CAT_DOT.mdaTuNgay.ToString("dd/MM/yyyy") + " đến ngày " + frmBaoCaoSanLuongTheoNhomMay_IN_CAT_DOT.mdaDenNgay.ToString("dd/MM/yyyy") + "";
            //    else pNgayThang.Value = "Ngày " + DateTime.Today.ToString("dd/MM/yyyy") + "";
            //}


            //if (frmBaoCaoSanLuongTheoMaHang_IN_CAT_DOT.mbPrint == true)
            //{
            //    if (frmBaoCaoSanLuongTheoMaHang_IN_CAT_DOT.miPrtint_ALL_0_IN_1_CAT_2_Dot_3 == 0)
            //        pTieuDe.Value = "BÁO CÁO SẢN LƯỢNG TỔ MÁY IN - CẮT - ĐỘT";
            //    if (frmBaoCaoSanLuongTheoMaHang_IN_CAT_DOT.miPrtint_ALL_0_IN_1_CAT_2_Dot_3 == 1)
            //        pTieuDe.Value = "BÁO CÁO SẢN LƯỢNG TỔ MÁY IN";
            //    if (frmBaoCaoSanLuongTheoMaHang_IN_CAT_DOT.miPrtint_ALL_0_IN_1_CAT_2_Dot_3 == 2)
            //        pTieuDe.Value = "BÁO CÁO SẢN LƯỢNG TỔ MÁY CẮT";
            //    if (frmBaoCaoSanLuongTheoMaHang_IN_CAT_DOT.miPrtint_ALL_0_IN_1_CAT_2_Dot_3 == 3)
            //        pTieuDe.Value = "BÁO CÁO SẢN LƯỢNG TỔ MÁY ĐỘT";
            //    if (frmBaoCaoSanLuongTheoMaHang_IN_CAT_DOT.mbNgayThang_null == true)
            //        pNgayThang.Value = "Từ ngày " + frmBaoCaoSanLuongTheoMaHang_IN_CAT_DOT.mdaTuNgay.ToString("dd/MM/yyyy") + " đến ngày " + frmBaoCaoSanLuongTheoMaHang_IN_CAT_DOT.mdaDenNgay.ToString("dd/MM/yyyy") + "";
            //    else pNgayThang.Value = "Ngày " + DateTime.Today.ToString("dd/MM/yyyy") + "";
            //}
            

        }

    }
}
