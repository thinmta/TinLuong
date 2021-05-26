using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtyTinLuong
{
    public partial class UCSanXuat_LuongCongNhanMay_IN : UserControl
    {
        public static DateTime GetFistDayInMonth(int year, int month)
        {
            DateTime aDateTime = new DateTime(year, month, 1);
            return aDateTime;
        }
        public static DateTime GetLastDayInMonth(int year, int month)
        {
            DateTime aDateTime = new DateTime(year, month, 1);
            DateTime retDateTime = aDateTime.AddMonths(1).AddDays(-1);
            return retDateTime;
        }
        private void HienThi()
        {
            DateTime tungay, dennagy;
            tungay = dteTuNgay.DateTime;
            dennagy = dteDenNgay.DateTime;
           

            clsPhieu_ChiTietPhieu_May_IN cls = new CtyTinLuong.clsPhieu_ChiTietPhieu_May_IN();
            DataTable dt = cls.SelectAll_TinhLuong_may_IN_TheoSanLuong();
            //dt.DefaultView.RowFilter = "'" + tungay + "'<= NgayLapPhieu <='" + dennagy + "'";
            dt.DefaultView.RowFilter = " NgayLapPhieu <='" + dennagy + "'";
            DataView dv = dt.DefaultView;
            DataTable dxxxx = dv.ToTable();
            dxxxx.DefaultView.RowFilter = " NgayLapPhieu >='" + tungay + "'";
            DataView dv222 = dxxxx.DefaultView;
            DataTable dt3 = dv222.ToTable();

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_SoPhieu", typeof(int));
            dt2.Columns.Add("MaPhieu", typeof(string));
            dt2.Columns.Add("CaLamViec", typeof(string));
            dt2.Columns.Add("MaNhanVien", typeof(string));
            dt2.Columns.Add("TenNhanVien", typeof(string));
            dt2.Columns.Add("MaMay", typeof(string));
            dt2.Columns.Add("TenMay", typeof(string));
            dt2.Columns.Add("SoLuongNhap_May_IN", typeof(double));
            dt2.Columns.Add("SanLuongThuong_May_IN", typeof(double));
            dt2.Columns.Add("SanLuongTangCa_May_IN", typeof(double));
            dt2.Columns.Add("SanLuongTong_May_IN", typeof(double));
            dt2.Columns.Add("NgayLapPhieu", typeof(DateTime));
            //dt2.Columns.Add("MaDinhMuc", typeof(string));
            dt2.Columns.Add("DinhMuc_KhongTang", typeof(decimal));
            dt2.Columns.Add("DinhMuc_Tang", typeof(decimal));
            dt2.Columns.Add("ThanhTien", typeof(decimal));
            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("TenVTHH", typeof(string));
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                Decimal SoLuongNhap_May_IN, SanLuongThuong_May_IN, SanLuongTangCa_May_IN, SanLuongTong_May_IN;
                SoLuongNhap_May_IN = Convert.ToDecimal(dt3.Rows[i]["SoLuongNhap_May_IN"].ToString());
                SanLuongThuong_May_IN = Convert.ToDecimal(dt3.Rows[i]["SanLuongThuong_May_IN"].ToString());
                SanLuongTangCa_May_IN = Convert.ToDecimal(dt3.Rows[i]["SanLuongTangCa_May_IN"].ToString());
                SanLuongTong_May_IN = Convert.ToDecimal(dt3.Rows[i]["SanLuongTong_May_IN"].ToString());
                decimal DinhMuc_KhongTang, DinhMuc_Tang, ThanhTien;
                DinhMuc_KhongTang = Convert.ToDecimal(dt3.Rows[i]["DinhMuc_KhongTang"].ToString());
                DinhMuc_Tang = Convert.ToDecimal(dt3.Rows[i]["DinhMuc_Tang"].ToString());
                ThanhTien = SanLuongThuong_May_IN* DinhMuc_KhongTang + SanLuongTangCa_May_IN* DinhMuc_Tang;                 
                DataRow _ravi = dt2.NewRow();
                _ravi["ID_SoPhieu"] = dt3.Rows[i]["ID_SoPhieu"].ToString();
                _ravi["MaPhieu"] = dt3.Rows[i]["MaPhieu"].ToString();
                _ravi["CaLamViec"] = dt3.Rows[i]["CaLamViec"].ToString();
                _ravi["MaNhanVien"] = dt3.Rows[i]["MaNhanVien"].ToString();
                _ravi["TenNhanVien"] = dt3.Rows[i]["TenNhanVien"].ToString();
                _ravi["MaMay"] = dt3.Rows[i]["MaMay"].ToString();
                _ravi["TenMay"] = dt3.Rows[i]["TenMay"].ToString();
                _ravi["SoLuongNhap_May_IN"] = SoLuongNhap_May_IN;
                _ravi["SanLuongThuong_May_IN"] = SanLuongThuong_May_IN;
                _ravi["SanLuongTangCa_May_IN"] = SanLuongTangCa_May_IN;
                _ravi["SanLuongTong_May_IN"] = SanLuongTong_May_IN;
                _ravi["DinhMuc_KhongTang"] = DinhMuc_KhongTang;
                _ravi["DinhMuc_Tang"] = DinhMuc_Tang;
                _ravi["ThanhTien"] = ThanhTien;
                _ravi["MaVT"] = dt3.Rows[i]["MaVT"].ToString();
                _ravi["TenVTHH"] = dt3.Rows[i]["TenVTHH"].ToString();
                _ravi["NgayLapPhieu"] = Convert.ToDateTime(dt3.Rows[i]["NgayLapPhieu"].ToString());
                dt2.Rows.Add(_ravi);
            }

            gridControl1.DataSource = dt2;

            int thang = Convert.ToInt16(tungay.ToString("MM"));
            int nam = Convert.ToInt16(tungay.ToString("yyyy"));
            ////clsHUU_BangLuong clsxx = new clsHUU_BangLuong();
            //clsxx.iThang = thang;
            //clsxx.iNam = nam;
          
        }
        public UCSanXuat_LuongCongNhanMay_IN()
        {
            InitializeComponent();
        }

        private void UCSanXuat_LuongCongNhanMay_IN_Load(object sender, EventArgs e)
        {
            DateTime ngayhomnay = DateTime.Today;
            DateTime ngaydautien, ngaycuoicung;
            int nam = Convert.ToInt16(ngayhomnay.ToString("yyyy"));
            int thang = Convert.ToInt16(ngayhomnay.ToString("MM"));
            ngaydautien = new DateTime(DateTime.Now.Year, thang, 1);
            ngaydautien = ngaydautien.AddDays((-ngaydautien.Day) + 1);
            dteTuNgay.EditValue = ngaydautien;
            ngaycuoicung = ngayhomnay.AddMonths(1);
            ngaycuoicung = ngaycuoicung.AddDays(-(ngaycuoicung.Day));
            dteDenNgay.EditValue = ngaycuoicung;
            if (dteTuNgay.EditValue != null & dteDenNgay.EditValue != null)
            {
                HienThi();

            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UCSanXuat_LuongCongNhanMay_IN_Load( sender,  e);
        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            if (dteTuNgay.EditValue != null & dteDenNgay.EditValue != null)
            {
                HienThi();

            }
        }

        private void dteTuNgay_EditValueChanged(object sender, EventArgs e)
        {
            if (dteTuNgay.EditValue != null & dteDenNgay.EditValue != null)
            {
                if (dteTuNgay.DateTime > dteDenNgay.DateTime)
                {
                    MessageBox.Show("Chọn Sai Từ ngay");
                    return;
                }
            }
        }

        private void dteDenNgay_EditValueChanged(object sender, EventArgs e)
        {
            if (dteTuNgay.EditValue != null & dteDenNgay.EditValue != null)
            {
                if (dteTuNgay.DateTime > dteDenNgay.DateTime)
                {
                    MessageBox.Show("Chọn Sai Đến ngay");
                    return;
                }

            }
        }

        private void btGuiDuLieu_Click(object sender, EventArgs e)
        {
        }

        private void btGuiDuLieu_Click_1(object sender, EventArgs e)
        {
            //DateTime ngaydautien, ngaycuoicung;
            //// DateTime ngayhomnay = 
            //int thang = Convert.ToInt16(dteTuNgay.DateTime.ToString("MM"));
            //int nam = Convert.ToInt16(dteTuNgay.DateTime.ToString("yyyy"));
            //ngaydautien = GetFistDayInMonth(nam, thang);
            //ngaycuoicung = GetLastDayInMonth(nam, thang);

            //clsHUU_CongNhat_ChiTiet_ChamCong cls = new clsHUU_CongNhat_ChiTiet_ChamCong();
            //DataTable dt3 = cls.SelectAll_W_TenNhanVien();
            //// update luong san luong
            //for (int i = 0; i < dt3.Rows.Count; i++)
            //{
            //    int iixxIDCongNhan = Convert.ToInt16(dt3.Rows[i]["ID_CongNhan"].ToString());
            //    cls.iID_CongNhan = iixxIDCongNhan;

            //    DataTable dt_may_IN = cls.SelectAll_TinhLuong_Theo_SanLuong_May_IN();
            //    dt_may_IN.DefaultView.RowFilter = " NgayLapPhieu <='" + ngaycuoicung + "'";
            //    DataView so1_dv_may_IN = dt_may_IN.DefaultView;
            //    DataTable so1_newdt_may_IN = so1_dv_may_IN.ToTable();
            //    so1_newdt_may_IN.DefaultView.RowFilter = " NgayLapPhieu >='" + ngaydautien + "'";
            //    DataView so2_dv_may_IN = so1_newdt_may_IN.DefaultView;
            //    DataTable so2_newdt_may_IN = so2_dv_may_IN.ToTable();

            //    DataTable dt_may_CAT = cls.SelectAll_TinhLuong_Theo_SanLuong_May_CAT();
            //    dt_may_CAT.DefaultView.RowFilter = " NgayLapPhieu <='" + ngaycuoicung + "'";
            //    DataView so1_dv_may_CAT = dt_may_CAT.DefaultView;
            //    DataTable so1_newdt_may_CAT = so1_dv_may_CAT.ToTable();
            //    so1_newdt_may_CAT.DefaultView.RowFilter = " NgayLapPhieu >='" + ngaydautien + "'";
            //    DataView so2_dv_may_CAT = so1_newdt_may_CAT.DefaultView;
            //    DataTable so2_newdt_may_CAT = so2_dv_may_CAT.ToTable();

            //    DataTable dt_may_DOT = cls.SelectAll_TinhLuong_Theo_SanLuong_May_DOT();
            //    dt_may_DOT.DefaultView.RowFilter = " NgayLapPhieu <='" + ngaycuoicung + "'";
            //    DataView so1_dv_may_DOT = dt_may_DOT.DefaultView;
            //    DataTable so1_newdt_may_DOT = so1_dv_may_DOT.ToTable();
            //    so1_newdt_may_DOT.DefaultView.RowFilter = " NgayLapPhieu >='" + ngaydautien + "'";
            //    DataView so2_dv_may_DOT = so1_newdt_may_DOT.DefaultView;
            //    DataTable so2_newdt_may_DOT = so2_dv_may_DOT.ToTable();


            //    if (so2_newdt_may_IN.Rows.Count > 0)
            //    {
            //        DataTable dtmayIN_xx1 = new DataTable();
            //        dtmayIN_xx1.Columns.Add("ThanhTien", typeof(decimal));
            //        dtmayIN_xx1.Columns.Add("HienThi", typeof(string));
            //        for (int imayin = 0; imayin < so2_newdt_may_IN.Rows.Count; imayin++)
            //        {
            //            Decimal SanLuongThuong_May_IN, SanLuongTangCa_May_IN;
            //            SanLuongThuong_May_IN = Convert.ToDecimal(so2_newdt_may_IN.Rows[imayin]["SanLuongThuong_May_IN"].ToString());
            //            SanLuongTangCa_May_IN = Convert.ToDecimal(so2_newdt_may_IN.Rows[imayin]["SanLuongTangCa_May_IN"].ToString());
            //            decimal DinhMuc_KhongTang, DinhMuc_Tang, ThanhTien;
            //            DinhMuc_KhongTang = Convert.ToDecimal(so2_newdt_may_IN.Rows[imayin]["DinhMuc_KhongTang"].ToString());
            //            DinhMuc_Tang = Convert.ToDecimal(so2_newdt_may_IN.Rows[imayin]["DinhMuc_Tang"].ToString());
            //            ThanhTien = SanLuongThuong_May_IN * DinhMuc_KhongTang + SanLuongTangCa_May_IN * DinhMuc_Tang;
            //            DataRow _ravi = dtmayIN_xx1.NewRow();
            //            _ravi["ThanhTien"] = ThanhTien;
            //            _ravi["HienThi"] = "1";
            //            dtmayIN_xx1.Rows.Add(_ravi);
            //        }
            //        string shienthi = "1";
            //        decimal deluongsanluong;
            //        object tongthanhtienxxx = dtmayIN_xx1.Compute("sum(ThanhTien)", "HienThi=" + shienthi + "");
            //        deluongsanluong = Convert.ToDecimal(tongthanhtienxxx);
            //        cls.iID_CongNhan = iixxIDCongNhan;
            //        cls.dcLuongSanLuong = deluongsanluong;
            //        cls.iThang = thang;
            //        cls.iNam = nam;
            //        DataTable dtmayIN_xx2 = cls.Select_One_W_ID_CongNhanh_W_thang_Nam();
            //        decimal luongcongnhat = Convert.ToDecimal(dtmayIN_xx2.Rows[0]["LuongCongNhat"].ToString());
            //        if (luongcongnhat >= deluongsanluong)
            //            cls.dcLuongLonNhat = luongcongnhat;
            //        else cls.dcLuongLonNhat = deluongsanluong;
            //        cls.Update_LuongSanLuong_and_LuongLonNhat_W_ID_CongNhan_W_thang_Nam();
            //    }
            //    else if (so2_newdt_may_CAT.Rows.Count > 0)
            //    {
            //        DataTable dtmayCAT_xx1 = new DataTable();
            //        dtmayCAT_xx1.Columns.Add("ThanhTien", typeof(decimal));
            //        dtmayCAT_xx1.Columns.Add("HienThi", typeof(string));
            //        for (int imay_CAT = 0; imay_CAT < so2_newdt_may_CAT.Rows.Count; imay_CAT++)
            //        {
            //            Decimal SanLuongThuong_May_CAT, SanLuongTangCa_May_CAT;
            //            SanLuongThuong_May_CAT = Convert.ToDecimal(so2_newdt_may_CAT.Rows[imay_CAT]["SanLuongThuong_May_CAT"].ToString());
            //            SanLuongTangCa_May_CAT = Convert.ToDecimal(so2_newdt_may_CAT.Rows[imay_CAT]["SanLuongTangCa_May_CAT"].ToString());
            //            decimal DinhMuc_KhongTang, DinhMuc_Tang, ThanhTien;
            //            DinhMuc_KhongTang = Convert.ToDecimal(so2_newdt_may_CAT.Rows[imay_CAT]["DinhMuc_KhongTang"].ToString());
            //            DinhMuc_Tang = Convert.ToDecimal(so2_newdt_may_CAT.Rows[imay_CAT]["DinhMuc_Tang"].ToString());
            //            ThanhTien = SanLuongThuong_May_CAT * DinhMuc_KhongTang + SanLuongTangCa_May_CAT * DinhMuc_Tang;
            //            DataRow _ravi = dtmayCAT_xx1.NewRow();
            //            _ravi["ThanhTien"] = ThanhTien;
            //            _ravi["HienThi"] = "1";
            //            dtmayCAT_xx1.Rows.Add(_ravi);
            //        }
            //        string shienthi = "1";
            //        decimal deluongsanluong;
            //        object tongthanhtienxxx = dtmayCAT_xx1.Compute("sum(ThanhTien)", "HienThi=" + shienthi + "");
            //        deluongsanluong = Convert.ToDecimal(tongthanhtienxxx);
            //        cls.iID_CongNhan = iixxIDCongNhan;
            //        cls.dcLuongSanLuong = deluongsanluong;
            //        cls.iThang = thang;
            //        cls.iNam = nam;
            //        DataTable dtmay_CAT_xx2 = cls.Select_One_W_ID_CongNhanh_W_thang_Nam();
            //        decimal luongcongnhat = Convert.ToDecimal(dtmay_CAT_xx2.Rows[0]["LuongCongNhat"].ToString());
            //        if (luongcongnhat >= deluongsanluong)
            //            cls.dcLuongLonNhat = luongcongnhat;
            //        else cls.dcLuongLonNhat = deluongsanluong;
            //        cls.Update_LuongSanLuong_and_LuongLonNhat_W_ID_CongNhan_W_thang_Nam();
            //    }
            //    else if (so2_newdt_may_DOT.Rows.Count > 0)
            //    {
            //        DataTable dtmay_DOT_xx1 = new DataTable();
            //        dtmay_DOT_xx1.Columns.Add("ThanhTien", typeof(decimal));
            //        dtmay_DOT_xx1.Columns.Add("HienThi", typeof(string));
            //        for (int imay_DOT = 0; imay_DOT < so2_newdt_may_DOT.Rows.Count; imay_DOT++)
            //        {
            //            Decimal SanLuongThuong_May_DOT, SanLuongTangCa_May_DOT;
            //            SanLuongThuong_May_DOT = Convert.ToDecimal(so2_newdt_may_DOT.Rows[imay_DOT]["SanLuongThuong_May_DOT"].ToString());
            //            SanLuongTangCa_May_DOT = Convert.ToDecimal(so2_newdt_may_DOT.Rows[imay_DOT]["SanLuongTangCa_May_DOT"].ToString());
            //            decimal DinhMuc_KhongTang, DinhMuc_Tang, ThanhTien;
            //            DinhMuc_KhongTang = Convert.ToDecimal(so2_newdt_may_DOT.Rows[imay_DOT]["DinhMuc_KhongTang"].ToString());
            //            DinhMuc_Tang = Convert.ToDecimal(so2_newdt_may_DOT.Rows[imay_DOT]["DinhMuc_Tang"].ToString());
            //            ThanhTien = SanLuongThuong_May_DOT * DinhMuc_KhongTang + SanLuongTangCa_May_DOT * DinhMuc_Tang;
            //            DataRow _ravi = dtmay_DOT_xx1.NewRow();
            //            _ravi["ThanhTien"] = ThanhTien;
            //            _ravi["HienThi"] = "1";
            //            dtmay_DOT_xx1.Rows.Add(_ravi);
            //        }
            //        string shienthi = "1";
            //        decimal deluongsanluong;
            //        object tongthanhtienxxx = dtmay_DOT_xx1.Compute("sum(ThanhTien)", "HienThi=" + shienthi + "");
            //        deluongsanluong = Convert.ToDecimal(tongthanhtienxxx);
            //        cls.iID_CongNhan = iixxIDCongNhan;
            //        cls.dcLuongSanLuong = deluongsanluong;
            //        cls.iThang = thang;
            //        cls.iNam = nam;
            //        DataTable dtmay_CAT_xx2 = cls.Select_One_W_ID_CongNhanh_W_thang_Nam();
            //        decimal luongcongnhat = Convert.ToDecimal(dtmay_CAT_xx2.Rows[0]["LuongCongNhat"].ToString());
            //        if (luongcongnhat >= deluongsanluong)
            //            cls.dcLuongLonNhat = luongcongnhat;
            //        else cls.dcLuongLonNhat = deluongsanluong;
            //        cls.Update_LuongSanLuong_and_LuongLonNhat_W_ID_CongNhan_W_thang_Nam();
            //    }
            //    else
            //    {
            //        cls.iID_CongNhan = iixxIDCongNhan;
            //        cls.dcLuongSanLuong = 0;
            //        cls.iThang = thang;
            //        cls.iNam = nam;
            //        decimal luongcongnhat = Convert.ToDecimal(dt3.Rows[i]["LuongCongNhat"].ToString());
            //        cls.dcLuongLonNhat = luongcongnhat;
            //        cls.Update_LuongSanLuong_and_LuongLonNhat_W_ID_CongNhan_W_thang_Nam();
            //    }
               
            //}
            //MessageBox.Show("Đã gửi dữ liệu lương tháng: " + thang.ToString() + " năm " + nam.ToString() + "");
        }
    }
}
