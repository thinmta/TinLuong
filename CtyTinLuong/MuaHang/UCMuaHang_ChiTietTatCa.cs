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
    public partial class UCMuaHang_ChiTietTatCa : UserControl
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
        private void HienThi(DateTime xxtungay, DateTime xxdenngay)
        {

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_VTHH", typeof(int));
            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("TenVTHH", typeof(string));
            dt2.Columns.Add("SoLuong", typeof(double));
            dt2.Columns.Add("DonViTinh", typeof(string));
            dt2.Columns.Add("DonGia", typeof(double));
            dt2.Columns.Add("ThanhTien", typeof(double));
            dt2.Columns.Add("NgayChungTu", typeof(DateTime));
            dt2.Columns.Add("TenNhaCungCap", typeof(string));
           

            clsMH_tbChiTietMuaHang cls = new CtyTinLuong.clsMH_tbChiTietMuaHang();
            DataTable dtdistin = cls.SelectAll_DISTINCT_W_ID_VTHH();
            if(dtdistin.Rows.Count>0)
            {
                for(int i=0; i<dtdistin.Rows.Count; i++)
                {
                    int iiiID_VTHH= Convert.ToInt32(dtdistin.Rows[i]["ID_VTHH"].ToString());
                    cls.iID_VTHH= Convert.ToInt32(dtdistin.Rows[i]["ID_VTHH"].ToString());
                    DataTable dttong = cls.Select_Sum_SoLuong_ThanhTien_W_ID_VTHH();
                    if(dttong.Rows.Count>0)
                    {
                        DataRow _ravi = dt2.NewRow();
                        _ravi["ID_VTHH"] = iiiID_VTHH;
                        clsTbVatTuHangHoa clsvt = new clsTbVatTuHangHoa();
                        clsvt.iID_VTHH = iiiID_VTHH;
                        DataTable dtvt = clsvt.SelectOne();
                        _ravi["MaVT"] = clsvt.sMaVT.Value;
                        _ravi["TenVTHH"] = clsvt.sTenVTHH.Value;
                        _ravi["SoLuong"] = Convert.ToDouble(dttong.Rows[0]["SoLuong"].ToString());
                        _ravi["DonViTinh"] = clsvt.sDonViTinh.Value;
                        _ravi["ThanhTien"] = Convert.ToDouble(dttong.Rows[0]["ThanhTien"].ToString());
                        dt2.Rows.Add(_ravi);
                    }
                }
            }
            //DataTable dt = cls.SelectAll_HienThi_ALL();
            //dt.DefaultView.RowFilter = " NgayChungTu<='" + xxdenngay + "'";
            //DataView dv = dt.DefaultView;
            //DataTable dt22 = dv.ToTable();
            //dt22.DefaultView.RowFilter = " NgayChungTu>='" + xxtungay + "'";
            //DataView dv2 = dt22.DefaultView;
            //dv2.Sort = "NgayChungTu DESC, ID_MuaHang DESC";
            //DataTable dxxxx = dv2.ToTable();
            //for (int i = 0; i < dxxxx.Rows.Count; i++)
            //{
            //    int iiID_NCC = Convert.ToInt32(dxxxx.Rows[i]["IDNhaCungCap"].ToString());
            //    clsTbNhaCungCap clscc = new clsTbNhaCungCap();
            //    clscc.iID_NhaCungCap = iiID_NCC;
            //    DataTable dtcc = clscc.SelectOne();
            //    double DonGia = Convert.ToDouble(dxxxx.Rows[i]["DonGia"].ToString());
            //    double SoLuong = Convert.ToDouble(dxxxx.Rows[i]["SoLuong"].ToString());
            //    DataRow _ravi = dt2.NewRow();
            //    _ravi["ID_VTHH"] = Convert.ToInt16(dxxxx.Rows[i]["ID_VTHH"].ToString());
            //    _ravi["TenNhaCungCap"] = clscc.sTenNhaCungCap.Value;
            //    _ravi["MaVT"] = dxxxx.Rows[i]["MaVT"].ToString();
            //    _ravi["TenVTHH"] = dxxxx.Rows[i]["TenVTHH"].ToString();
            //    _ravi["SoLuong"] = SoLuong;
            //    _ravi["NgayChungTu"] = Convert.ToDateTime(dxxxx.Rows[i]["NgayChungTu"].ToString());
            //    _ravi["DonViTinh"] = dxxxx.Rows[i]["DonViTinh"].ToString();
            //    _ravi["DonGia"] = DonGia;
            //    _ravi["ThanhTien"] = SoLuong * DonGia;
            //    dt2.Rows.Add(_ravi);
            //}
            gridControl1.DataSource = dt2;


        }


        public UCMuaHang_ChiTietTatCa()
        {
            InitializeComponent();
        }

        private void UCMuaHang_ChiTietTatCa_Load(object sender, EventArgs e)
        {
            DateTime ngaydautien, ngaycuoicung;
            DateTime ngayhomnay = DateTime.Today;
            int nam = Convert.ToInt16(ngayhomnay.ToString("yyyy"));
            int thang = Convert.ToInt16(ngayhomnay.ToString("MM"));
            ngaydautien = GetFistDayInMonth(nam, thang);
            ngaycuoicung = GetLastDayInMonth(nam, thang);
            dteDenNgay.EditValue = ngaycuoicung;
            dteTuNgay.EditValue = ngaydautien;
            HienThi(ngaydautien, ngaycuoicung);
        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            if (dteDenNgay.EditValue != null & dteTuNgay.EditValue != null)
            {
                HienThi(dteTuNgay.DateTime, dteDenNgay.DateTime);
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UCMuaHang_ChiTietTatCa_Load( sender,  e);
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }
    }
}
