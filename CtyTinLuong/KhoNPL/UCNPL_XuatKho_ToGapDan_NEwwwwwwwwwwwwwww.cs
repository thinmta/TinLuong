using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace CtyTinLuong
{
    public partial class UCNPL_XuatKho_ToGapDan_NEwwwwwwwwwwwwwww : UserControl
    {
        public static int miID_NhapKho_GapDan;
        public static bool mbThemMoi_nhapKho_GapDan;
        private void HienThi()
        {
            if (dteTuNgay.EditValue != null & dteNgay.EditValue != null)
            {
                DateTime denngay = dteNgay.DateTime;
                DateTime tungay = dteTuNgay.DateTime;
                DataTable dt2 = new DataTable();
                dt2.Columns.Add("ID_NhapKho", typeof(int));
                dt2.Columns.Add("DienGiai", typeof(string));
                dt2.Columns.Add("NgayChungTu", typeof(DateTime));
                dt2.Columns.Add("SoChungTu", typeof(string));
                dt2.Columns.Add("ID_VTHH_ThanhPham_QuyDoi", typeof(int));
                dt2.Columns.Add("DonGia_ThanhPham_QuyDoi", typeof(double));
                dt2.Columns.Add("SoLuongThanhPham_QuyDoi", typeof(double));
                dt2.Columns.Add("TongTienHang", typeof(double));
                dt2.Columns.Add("ID_DinhMuc_ToGapDan", typeof(int));
                dt2.Columns.Add("MaDinhMuc", typeof(string));               
                dt2.Columns.Add("MaVT", typeof(string));
                dt2.Columns.Add("TenVTHH", typeof(string));               
                dt2.Columns.Add("DonViTinh", typeof(string));
                dt2.Columns.Add("TrangThai_XuatKho_NPL", typeof(bool));
                clsGapDan_tbNhapKho cls = new CtyTinLuong.clsGapDan_tbNhapKho();
                DataTable dt = cls.SelectAll_HienThi();
                dt.DefaultView.RowFilter = " NgayChungTu<='" + denngay + "'";
                DataView dv = dt.DefaultView;
                DataTable dt22 = dv.ToTable();
                dt22.DefaultView.RowFilter = " NgayChungTu>='" + tungay + "'";
                DataView dv2 = dt22.DefaultView;
                dv2.Sort = "NgayChungTu DESC, ID_NhapKho DESC";
                DataTable dxxxx = dv2.ToTable();
                for (int i = 0; i < dxxxx.Rows.Count; i++)
                {
                    double DonGia_ThanhPham_QuyDoi = Convert.ToDouble(dxxxx.Rows[i]["DonGia_ThanhPham_QuyDoi"].ToString());
                    double SoLuongThanhPham_QuyDoi = Convert.ToDouble(dxxxx.Rows[i]["SoLuongThanhPham_QuyDoi"].ToString());
                    int ID_VTHH_ThanhPham_QuyDoixxx = Convert.ToInt16(dxxxx.Rows[i]["ID_VTHH_ThanhPham_QuyDoi"].ToString());
                    DataRow _ravi = dt2.NewRow();

                    _ravi["ID_NhapKho"] = Convert.ToInt16(dxxxx.Rows[i]["ID_NhapKho"].ToString());
                 
                    _ravi["DienGiai"] = dxxxx.Rows[i]["DienGiai"].ToString();
                    _ravi["NgayChungTu"] = Convert.ToDateTime(dxxxx.Rows[i]["NgayChungTu"].ToString());
                    _ravi["SoChungTu"] = dxxxx.Rows[i]["SoChungTu"].ToString();
                    _ravi["ID_VTHH_ThanhPham_QuyDoi"] = Convert.ToInt16(dxxxx.Rows[i]["ID_VTHH_ThanhPham_QuyDoi"].ToString());
                    _ravi["DonGia_ThanhPham_QuyDoi"] = DonGia_ThanhPham_QuyDoi;
                    _ravi["SoLuongThanhPham_QuyDoi"] = SoLuongThanhPham_QuyDoi;
                    _ravi["TongTienHang"] = DonGia_ThanhPham_QuyDoi * SoLuongThanhPham_QuyDoi;
                    _ravi["ID_DinhMuc_ToGapDan"] = Convert.ToInt16(dxxxx.Rows[i]["ID_DinhMuc_ToGapDan"].ToString());
                    _ravi["MaDinhMuc"] = dxxxx.Rows[i]["MaDinhMuc"].ToString();
                    _ravi["MaVT"] = dxxxx.Rows[i]["MaVT"].ToString();
                    _ravi["TenVTHH"] = dxxxx.Rows[i]["TenVTHH"].ToString();
                    _ravi["TrangThai_XuatKho_NPL"] = Convert.ToBoolean(dxxxx.Rows[i]["TrangThai_XuatKho_NPL"].ToString());   
                    _ravi["DonViTinh"] = dxxxx.Rows[i]["DonViTinh"].ToString();
                  
                    dt2.Rows.Add(_ravi);
                }
                gridControl1.DataSource = dt2;
            }

        }
        private void HienThi_ALL()
        {
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_NhapKho", typeof(int));
            dt2.Columns.Add("DienGiai", typeof(string));
            dt2.Columns.Add("NgayChungTu", typeof(DateTime));
            dt2.Columns.Add("SoChungTu", typeof(string));
            dt2.Columns.Add("ID_VTHH_ThanhPham_QuyDoi", typeof(int));
            dt2.Columns.Add("DonGia_ThanhPham_QuyDoi", typeof(double));
            dt2.Columns.Add("SoLuongThanhPham_QuyDoi", typeof(double));
            dt2.Columns.Add("TongTienHang", typeof(double));
            dt2.Columns.Add("ID_DinhMuc_ToGapDan", typeof(int));
            dt2.Columns.Add("MaDinhMuc", typeof(string));
            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("TenVTHH", typeof(string));
            dt2.Columns.Add("DonViTinh", typeof(string));
            dt2.Columns.Add("TrangThai_XuatKho_NPL", typeof(bool));
            //TrangThai_XuatKho_NPL
            clsGapDan_tbNhapKho cls = new CtyTinLuong.clsGapDan_tbNhapKho();
            DataTable dt = cls.SelectAll_HienThi();           
            DataView dv = dt.DefaultView;           
            dv.Sort = "NgayChungTu DESC, ID_NhapKho DESC";
            DataTable dxxxx = dv.ToTable();
            for (int i = 0; i < dxxxx.Rows.Count; i++)
            {
                double DonGia_ThanhPham_QuyDoi = Convert.ToDouble(dxxxx.Rows[i]["DonGia_ThanhPham_QuyDoi"].ToString());
                double SoLuongThanhPham_QuyDoi = Convert.ToDouble(dxxxx.Rows[i]["SoLuongThanhPham_QuyDoi"].ToString());
                int ID_VTHH_ThanhPham_QuyDoixxx = Convert.ToInt16(dxxxx.Rows[i]["ID_VTHH_ThanhPham_QuyDoi"].ToString());
                DataRow _ravi = dt2.NewRow();

                _ravi["ID_NhapKho"] = Convert.ToInt16(dxxxx.Rows[i]["ID_NhapKho"].ToString());

                _ravi["DienGiai"] = dxxxx.Rows[i]["DienGiai"].ToString();
                _ravi["NgayChungTu"] = Convert.ToDateTime(dxxxx.Rows[i]["NgayChungTu"].ToString());
                _ravi["SoChungTu"] = dxxxx.Rows[i]["SoChungTu"].ToString();
                _ravi["ID_VTHH_ThanhPham_QuyDoi"] = Convert.ToInt16(dxxxx.Rows[i]["ID_VTHH_ThanhPham_QuyDoi"].ToString());
                _ravi["DonGia_ThanhPham_QuyDoi"] = DonGia_ThanhPham_QuyDoi;
                _ravi["SoLuongThanhPham_QuyDoi"] = SoLuongThanhPham_QuyDoi;
                _ravi["TongTienHang"] = DonGia_ThanhPham_QuyDoi * SoLuongThanhPham_QuyDoi;
                _ravi["ID_DinhMuc_ToGapDan"] = Convert.ToInt16(dxxxx.Rows[i]["ID_DinhMuc_ToGapDan"].ToString());
                _ravi["MaDinhMuc"] = dxxxx.Rows[i]["MaDinhMuc"].ToString();
                _ravi["MaVT"] = dxxxx.Rows[i]["MaVT"].ToString();
                _ravi["TenVTHH"] = dxxxx.Rows[i]["TenVTHH"].ToString();
                _ravi["TrangThai_XuatKho_NPL"] = Convert.ToBoolean(dxxxx.Rows[i]["TrangThai_XuatKho_NPL"].ToString());   
                _ravi["DonViTinh"] = dxxxx.Rows[i]["DonViTinh"].ToString();

                dt2.Rows.Add(_ravi);
            }
            gridControl1.DataSource = dt2;

        }
      
        public UCNPL_XuatKho_ToGapDan_NEwwwwwwwwwwwwwww()
        {
            InitializeComponent();
        }

        private void UCNPL_XuatKho_ToGapDan_NEwwwwwwwwwwwwwww_Load(object sender, EventArgs e)
        {
            dteNgay.EditValue = null;
            dteTuNgay.EditValue = null;
            HienThi_ALL();

           
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UCNPL_XuatKho_ToGapDan_NEwwwwwwwwwwwwwww_Load(sender, e);
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(clID_NhapKho).ToString() != "")
            {
                mbThemMoi_nhapKho_GapDan = false;
                miID_NhapKho_GapDan = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_NhapKho).ToString());
                NPLChiTietNhapKho_GapDan_SUaaaaaaaaaaaaaaa ff = new NPLChiTietNhapKho_GapDan_SUaaaaaaaaaaaaaaa();
                ff.Show();
            }
          
        }

        private void btThemMoi_Click(object sender, EventArgs e)
        {
            mbThemMoi_nhapKho_GapDan = true;
            NPLChiTietNhapKho_GapDan ff = new NPLChiTietNhapKho_GapDan();
            ff.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //clsNganHang_ChiTietBienDongTaiKhoanKeToan cls = new clsNganHang_ChiTietBienDongTaiKhoanKeToan();
            //cls.HUU_DELETE_GapDan_ChiTiet_NhapKho();
            //cls.HUU_DELETE_GapDan_ChiTiet_XuatKho();
            //cls.HUU_DELETE_GapDan_tbNhapKho();
            //cls.HUU_DELETE_GapDan_tbXuatKho();
            //MessageBox.Show("Đã xoá ALLL");
        }

        private void gridView1_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {

        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool category = Convert.ToBoolean(View.GetRowCellValue(e.RowHandle, View.Columns["TrangThai_XuatKho_NPL"]));
                if (category == false)
                {
                    e.Appearance.BackColor = Color.Bisque;
                    
                }
            }
        }
    }
}
