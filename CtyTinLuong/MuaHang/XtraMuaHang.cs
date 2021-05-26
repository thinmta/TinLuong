using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace CtyTinLuong
{
    public partial class XtraMuaHang : DevExpress.XtraReports.UI.XtraReport
    {
        public void IntData(string msgiamdoc)
        {
           

        }

        public XtraMuaHang()
        {
            InitializeComponent();
        }

        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            
        }

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            clsAaatbMacDinhNguoiKy cls = new CtyTinLuong.clsAaatbMacDinhNguoiKy();
            cls.iID_DangNhap = frmDangNhap.miID_DangNhap;
            DataTable dt = cls.SelectAll_ID_DangNhap();
            if (dt.Rows.Count > 0)
            {
                pKeToanTruong.Value = dt.Rows[5]["HoTen"].ToString();
                pGiamDoc.Value = dt.Rows[6]["HoTen"].ToString();

                //txtNguoiGiao.Text = dt.Rows[0]["HoTen"].ToString();
                //txtNguoiLap.Text = dt.Rows[1]["HoTen"].ToString();
                //txtNguoiNhan.Text = dt.Rows[2]["HoTen"].ToString();
                //txtthuKhonewww.Text = dt.Rows[3]["HoTen"].ToString();
                //txtTruongPhongKH.Text = dt.Rows[4]["HoTen"].ToString();
                //txtKeToanTruong.Text = dt.Rows[5]["HoTen"].ToString();
                //txtGiamDoc.Text = dt.Rows[6]["HoTen"].ToString();
                //txtCaTruong.Text = dt.Rows[7]["HoTen"].ToString();
                //txtNguoiGiao.Text = dt.Rows[0]["HoTen"].ToString();
            }
            else
            {
                //pKeToanTruong.Value = frmMain.msKeToanTruong;
                //pGiamDoc.Value = frmMain.msGiamDoc;
            }
           

            pSoChungTu.Value = frmChiTietMuaHang3333333333.mssochungtu;
            pSoHoaDon.Value = frmChiTietMuaHang3333333333.mssohoadon;           
            DateTime ngaychungtu = frmChiTietMuaHang3333333333.mdangaythang;
            string ngay = ngaychungtu.ToString("dd");
            string thang = ngaychungtu.ToString("MM");
            string nam = ngaychungtu.ToString("yyyy");
            pNgayThang.Value = "Ngày " + ngay.ToString() + " tháng " + thang.ToString() + " năm " + nam.ToString() + "";
            pNguoiGiao.Value = frmChiTietMuaHang3333333333.msNguoiGiaoHang;
            pNguoiNhan.Value = frmChiTietMuaHang3333333333.msNguoiMuaHang;
            pTKNo.Value = "Nợ: " + frmChiTietMuaHang3333333333.msTKNo + "";
            pTKCo.Value = "Có: " + frmChiTietMuaHang3333333333.msTKCo + "";
            pTKVAT.Value = "VAT: " + frmChiTietMuaHang3333333333.msTKVAT + "";
            pSoTienNo.Value = frmChiTietMuaHang3333333333.mdcSoTienNo;
            pSoTienCo.Value = frmChiTietMuaHang3333333333.mdcSoTienCo;
            pSoTienVAT.Value = frmChiTietMuaHang3333333333.mdcSoTienVAT;
            pTongTienCoVAT.Value = frmChiTietMuaHang3333333333.mdcTongTienCoVAT;
        }

    }
}
