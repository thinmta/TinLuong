using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace CtyTinLuong
{
    public partial class Xtra_BanHang : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtra_BanHang()
        {
            InitializeComponent();
        }
        public void printMuahang()
        {
            pSoChungTu.Value = "Số: " + frmChiTietMuaHang3333333333.mssochungtu + "";

            DateTime ngaychungtu = frmChiTietMuaHang3333333333.mdangaythang;
            string ngay = ngaychungtu.ToString("dd");
            string thang = ngaychungtu.ToString("MM");
            string nam = ngaychungtu.ToString("yyyy");
            pNgayThang.Value = "Ngày " + ngay.ToString() + " tháng " + thang.ToString() + " năm " + nam.ToString() + "";

            //pNguoiGiao.Value = frmChiTietMuaHang3333333333.msNguoiGiaoHang;

            //pTKNo.Value = frmChiTietMuaHang3333333333.msTKNo;
            //pTKVAT.Value = frmChiTietMuaHang3333333333.msTKVAT;
            //pTKCo.Value = frmChiTietMuaHang3333333333.msTKCo;

            //pSoTienNo.Value = frmChiTietMuaHang3333333333.mdcSoTienNo;
            //pSoTienCo.Value = frmChiTietMuaHang3333333333.mdcSoTienCo;
            //if (frmChiTietMuaHang3333333333.mdcSoTienVAT > 0)
            //    pSoTienVAT.Value = frmChiTietMuaHang3333333333.mdcSoTienVAT;
            //else pSoTienVAT.Value = "";
            //pTongTienCoVAT.Value = frmChiTietMuaHang3333333333.mdcTongTienCoVAT;
            

            clsSoTienBangChu cls = new clsSoTienBangChu();
            pSoTienBangChu.Value = cls.DocTienBangChu(Convert.ToDouble(frmChiTietMuaHang3333333333.mdcSoTienNo), "đồng.");
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

            if (frmChiTietMuaHang3333333333.mbPrint == true)
                printMuahang();
        }
    }
}
