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
    public partial class UCSanXuat_LuongCongNhanMay_DOT : UserControl
    {
        private void HienThi()
        {
            DateTime tungay, dennagy;
            tungay = dteTuNgay.DateTime;
            dennagy = dteDenNgay.DateTime;
            clsPhieu_ChiTietPhieu_May_DOT cls = new CtyTinLuong.clsPhieu_ChiTietPhieu_May_DOT();
            DataTable dt = cls.SelectAll_TinhLuong_may_DOT_TheoSanLuong();
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
            dt2.Columns.Add("SoLuongNhap_May_DOT", typeof(double));
            dt2.Columns.Add("SanLuongThuong_May_DOT", typeof(double));
            dt2.Columns.Add("SanLuongTangCa_May_DOT", typeof(double));
            dt2.Columns.Add("SanLuongTong_May_DOT", typeof(double));
            dt2.Columns.Add("NgayLapPhieu", typeof(DateTime));
            //dt2.Columns.Add("MaDinhMuc", typeof(string));
            dt2.Columns.Add("DinhMuc_KhongTang", typeof(decimal));
            dt2.Columns.Add("DinhMuc_Tang", typeof(decimal));
            dt2.Columns.Add("ThanhTien", typeof(decimal));
            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("TenVTHH", typeof(string));
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                Decimal SoLuongNhap_May_DOT, SanLuongThuong_May_DOT, SanLuongTangCa_May_DOT, SanLuongTong_May_DOT;
                SoLuongNhap_May_DOT = Convert.ToDecimal(dt3.Rows[i]["SoLuongNhap_May_DOT"].ToString());
                SanLuongThuong_May_DOT = Convert.ToDecimal(dt3.Rows[i]["SanLuongThuong_May_DOT"].ToString());
                SanLuongTangCa_May_DOT = Convert.ToDecimal(dt3.Rows[i]["SanLuongTangCa_May_DOT"].ToString());
                SanLuongTong_May_DOT = Convert.ToDecimal(dt3.Rows[i]["SanLuongTong_May_DOT"].ToString());
                decimal DinhMuc_KhongTang, DinhMuc_Tang, ThanhTien;
                DinhMuc_KhongTang = Convert.ToDecimal(dt3.Rows[i]["DinhMuc_KhongTang"].ToString());
                DinhMuc_Tang = Convert.ToDecimal(dt3.Rows[i]["DinhMuc_Tang"].ToString());
                ThanhTien = SanLuongThuong_May_DOT * DinhMuc_KhongTang + SanLuongTangCa_May_DOT * DinhMuc_Tang;
                DataRow _ravi = dt2.NewRow();
                _ravi["ID_SoPhieu"] = dt3.Rows[i]["ID_SoPhieu"].ToString();
                _ravi["MaPhieu"] = dt3.Rows[i]["MaPhieu"].ToString();
                _ravi["CaLamViec"] = dt3.Rows[i]["CaLamViec"].ToString();
                _ravi["MaNhanVien"] = dt3.Rows[i]["MaNhanVien"].ToString();
                _ravi["TenNhanVien"] = dt3.Rows[i]["TenNhanVien"].ToString();
                _ravi["MaMay"] = dt3.Rows[i]["MaMay"].ToString();
                _ravi["TenMay"] = dt3.Rows[i]["TenMay"].ToString();
                _ravi["SoLuongNhap_May_DOT"] = SoLuongNhap_May_DOT;
                _ravi["SanLuongThuong_May_DOT"] = SanLuongThuong_May_DOT;
                _ravi["SanLuongTangCa_May_DOT"] = SanLuongTangCa_May_DOT;
                _ravi["SanLuongTong_May_DOT"] = SanLuongTong_May_DOT;
                _ravi["DinhMuc_KhongTang"] = DinhMuc_KhongTang;
                _ravi["DinhMuc_Tang"] = DinhMuc_Tang;
                _ravi["ThanhTien"] = ThanhTien;
                _ravi["MaVT"] = dt3.Rows[i]["MaVT"].ToString();
                _ravi["TenVTHH"] = dt3.Rows[i]["TenVTHH"].ToString();
                _ravi["NgayLapPhieu"] = Convert.ToDateTime(dt3.Rows[i]["NgayLapPhieu"].ToString());
                dt2.Rows.Add(_ravi);
            }

            gridControl1.DataSource = dt2;


        }
        public UCSanXuat_LuongCongNhanMay_DOT()
        {
            InitializeComponent();
        }

        private void UCSanXuat_LuongCongNhanMay_DOT_Load(object sender, EventArgs e)
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
            UCSanXuat_LuongCongNhanMay_DOT_Load( sender,  e);
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
    }
}
