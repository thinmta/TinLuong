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
    public partial class UCSanXuat_LenhSanXuat_ToGapDan : UserControl
    {
        public static bool mbThemMoi_LenhSX;
        public static int mID_iD_LenhSanXuat;
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
            if (dteTuNgay.EditValue != null & dteNgay.EditValue != null)
            {
                DateTime denngay = dteNgay.DateTime;
                DateTime tungay = dteTuNgay.DateTime;
                DataTable dt2 = new DataTable();
                dt2.Columns.Add("ID_LenhSanXuat", typeof(int));
                dt2.Columns.Add("MaLenhSanXuat", typeof(string));
                dt2.Columns.Add("CaSanXuat", typeof(string));
                dt2.Columns.Add("NgayThangSanXuat", typeof(DateTime));
                dt2.Columns.Add("ID_CongNhan", typeof(int));
                dt2.Columns.Add("ID_CaTruong", typeof(int));
                dt2.Columns.Add("ID_NguoiLap", typeof(int));
                dt2.Columns.Add("GuiDuLieu", typeof(bool));
                dt2.Columns.Add("TrangThai_XuatKho_VatTuChinh", typeof(bool));
                dt2.Columns.Add("TrangThai_XuatKho_VatTuPhu", typeof(bool));
                dt2.Columns.Add("TrangThai_NhapKho_ThanhPham", typeof(bool));
                dt2.Columns.Add("CongNhan", typeof(string));
                dt2.Columns.Add("CaTruong", typeof(string));
                dt2.Columns.Add("GhiChu", typeof(string));         
                clsHUU_LenhSanXuat_ToGapDan cls = new CtyTinLuong.clsHUU_LenhSanXuat_ToGapDan();
                DataTable dt = cls.SelectAll();
                dt.DefaultView.RowFilter = " NgayThangSanXuat<='" + denngay + "'";
                DataView dv = dt.DefaultView;
                DataTable dt22 = dv.ToTable();
                dt22.DefaultView.RowFilter = " NgayThangSanXuat>='" + tungay + "'";
                DataView dv2 = dt22.DefaultView;
                dv2.Sort = "NgayThangSanXuat DESC, ID_LenhSanXuat DESC";
                DataTable dxxxx = dv2.ToTable();
                for (int i = 0; i < dxxxx.Rows.Count; i++)
                {
                    int ID_CongNhan = Convert.ToInt32(dxxxx.Rows[i]["ID_CongNhan"].ToString());
                    int ID_CaTruong = Convert.ToInt32(dxxxx.Rows[i]["ID_CaTruong"].ToString());
                    
                    clsNhanSu_tbNhanSu clscc1 = new clsNhanSu_tbNhanSu();
                    clscc1.iID_NhanSu = ID_CongNhan;
                    DataTable dtcc1 = clscc1.SelectOne();
                    clsNhanSu_tbNhanSu clscc2 = new clsNhanSu_tbNhanSu();
                    clscc2.iID_NhanSu = ID_CaTruong;
                    DataTable dtcc2 = clscc2.SelectOne();                   
                    DataRow _ravi = dt2.NewRow();
                    _ravi["ID_LenhSanXuat"] = Convert.ToInt16(dxxxx.Rows[i]["ID_LenhSanXuat"].ToString());
                    _ravi["MaLenhSanXuat"] = dxxxx.Rows[i]["MaLenhSanXuat"].ToString();
                    _ravi["CaSanXuat"] = dxxxx.Rows[i]["CaSanXuat"].ToString();
                    _ravi["NgayThangSanXuat"] =Convert.ToDateTime(dxxxx.Rows[i]["NgayThangSanXuat"].ToString());
                    _ravi["ID_CongNhan"] = ID_CongNhan;
                    _ravi["ID_CaTruong"] = ID_CaTruong;
                    _ravi["ID_NguoiLap"] = Convert.ToInt16(dxxxx.Rows[i]["ID_NguoiLap"].ToString());
                    _ravi["GuiDuLieu"] = Convert.ToBoolean(dxxxx.Rows[i]["GuiDuLieu"].ToString());
                    _ravi["TrangThai_XuatKho_VatTuChinh"] = Convert.ToBoolean(dxxxx.Rows[i]["TrangThai_XuatKho_VatTuChinh"].ToString());
                    _ravi["TrangThai_XuatKho_VatTuPhu"] = Convert.ToBoolean(dxxxx.Rows[i]["TrangThai_XuatKho_VatTuPhu"].ToString());
                    _ravi["TrangThai_NhapKho_ThanhPham"] = Convert.ToBoolean(dxxxx.Rows[i]["TrangThai_NhapKho_ThanhPham"].ToString());
                    _ravi["CongNhan"] = clscc1.sTenNhanVien.Value;
                    _ravi["CaTruong"] = clscc2.sTenNhanVien.Value; ;
                    //GhiChu
                    _ravi["GhiChu"] = dxxxx.Rows[i]["GhiChu"].ToString();
                    dt2.Rows.Add(_ravi);
                }
                gridControl1.DataSource = dt2;
            }

        }
        private void HienThi_ALL()
        {
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_LenhSanXuat", typeof(int));
            dt2.Columns.Add("MaLenhSanXuat", typeof(string));
            dt2.Columns.Add("CaSanXuat", typeof(string));
            dt2.Columns.Add("NgayThangSanXuat", typeof(DateTime));
            dt2.Columns.Add("ID_CongNhan", typeof(int));
            dt2.Columns.Add("ID_CaTruong", typeof(int));
            dt2.Columns.Add("ID_NguoiLap", typeof(int));
            dt2.Columns.Add("GuiDuLieu", typeof(bool));
            dt2.Columns.Add("TrangThai_XuatKho_VatTuChinh", typeof(bool));
            dt2.Columns.Add("TrangThai_XuatKho_VatTuPhu", typeof(bool));
            dt2.Columns.Add("TrangThai_NhapKho_ThanhPham", typeof(bool));
            dt2.Columns.Add("CongNhan", typeof(string));
            dt2.Columns.Add("CaTruong", typeof(string));
            dt2.Columns.Add("GhiChu", typeof(string));      
            clsHUU_LenhSanXuat_ToGapDan cls = new CtyTinLuong.clsHUU_LenhSanXuat_ToGapDan();
            DataTable dt = cls.SelectAll();
           
            DataView dv2 = dt.DefaultView;
            dv2.Sort = "NgayThangSanXuat DESC, ID_LenhSanXuat DESC";
            DataTable dxxxx = dv2.ToTable();
            for (int i = 0; i < dxxxx.Rows.Count; i++)
            {
                int ID_CongNhan = Convert.ToInt32(dxxxx.Rows[i]["ID_CongNhan"].ToString());
                int ID_CaTruong = Convert.ToInt32(dxxxx.Rows[i]["ID_CaTruong"].ToString());

                clsNhanSu_tbNhanSu clscc1 = new clsNhanSu_tbNhanSu();
                clscc1.iID_NhanSu = ID_CongNhan;
                DataTable dtcc1 = clscc1.SelectOne();
                clsNhanSu_tbNhanSu clscc2 = new clsNhanSu_tbNhanSu();
                clscc2.iID_NhanSu = ID_CaTruong;
                DataTable dtcc2 = clscc2.SelectOne();
                DataRow _ravi = dt2.NewRow();
                _ravi["ID_LenhSanXuat"] = Convert.ToInt16(dxxxx.Rows[i]["ID_LenhSanXuat"].ToString());
                _ravi["MaLenhSanXuat"] = dxxxx.Rows[i]["MaLenhSanXuat"].ToString();
                _ravi["CaSanXuat"] = dxxxx.Rows[i]["CaSanXuat"].ToString();
                _ravi["NgayThangSanXuat"] = Convert.ToDateTime(dxxxx.Rows[i]["NgayThangSanXuat"].ToString());
                _ravi["ID_CongNhan"] = ID_CongNhan;
                _ravi["ID_CaTruong"] = ID_CaTruong;
                _ravi["ID_NguoiLap"] = Convert.ToInt16(dxxxx.Rows[i]["ID_NguoiLap"].ToString());
                _ravi["GuiDuLieu"] = Convert.ToBoolean(dxxxx.Rows[i]["GuiDuLieu"].ToString());
                _ravi["TrangThai_XuatKho_VatTuChinh"] = Convert.ToBoolean(dxxxx.Rows[i]["TrangThai_XuatKho_VatTuChinh"].ToString());
                _ravi["TrangThai_XuatKho_VatTuPhu"] = Convert.ToBoolean(dxxxx.Rows[i]["TrangThai_XuatKho_VatTuPhu"].ToString());
                _ravi["TrangThai_NhapKho_ThanhPham"] = Convert.ToBoolean(dxxxx.Rows[i]["TrangThai_NhapKho_ThanhPham"].ToString());
                _ravi["CongNhan"] = clscc1.sTenNhanVien.Value;
                _ravi["CaTruong"] = clscc2.sTenNhanVien.Value;
                _ravi["GhiChu"] = dxxxx.Rows[i]["GhiChu"].ToString();
                dt2.Rows.Add(_ravi);
            }
            gridControl1.DataSource = dt2;

        }
        public UCSanXuat_LenhSanXuat_ToGapDan()
        {
            InitializeComponent();
        }

        private void UCSanXuat_LenhSanXuat_ToGapDan_Load(object sender, EventArgs e)
        {
            mbThemMoi_LenhSX = true;
            //DateTime ngaydautien, ngaycuoicung;
            //DateTime ngayhomnay = DateTime.Today;
            //int nam = Convert.ToInt16(ngayhomnay.ToString("yyyy"));
            //int thang = Convert.ToInt16(ngayhomnay.ToString("MM"));
            //ngaydautien = GetFistDayInMonth(nam, thang);
            //ngaycuoicung = GetLastDayInMonth(nam, thang);
            //dteNgay.EditValue = ngaycuoicung;
            //dteTuNgay.EditValue = ngaydautien;
            dteNgay.EditValue = null;
            dteTuNgay.EditValue = null;
            HienThi_ALL();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UCSanXuat_LenhSanXuat_ToGapDan_Load( sender,  e);
        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            if (dteNgay.EditValue != null & dteTuNgay.EditValue != null)
            {
                HienThi();
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void btThemMoi_Click(object sender, EventArgs e)
        {
            mbThemMoi_LenhSX = true;
            SanXuat_frmChiTiet_LSX_ToGapDan ff = new SanXuat_frmChiTiet_LSX_ToGapDan();
            ff.Show();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           
                if (gridView1.GetFocusedRowCellValue(clID_LenhSanXuat).ToString() != "")
                {
                    mbThemMoi_LenhSX = false;
                    mID_iD_LenhSanXuat = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clID_LenhSanXuat).ToString());
                    SanXuat_frmChiTiet_LSX_ToGapDan ff = new SanXuat_frmChiTiet_LSX_ToGapDan();
                    ff.Show();
                    
                }
        }
    }
}
