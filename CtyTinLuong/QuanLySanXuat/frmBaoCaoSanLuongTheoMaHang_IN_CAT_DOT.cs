﻿using DevExpress.Data.Filtering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtyTinLuong
{
    public partial class frmBaoCaoSanLuongTheoMaHang_IN_CAT_DOT : Form
    {
        public static DataTable mdtPrint_tbChiTietPhieu_baoCaoSanLuongTheoNgay;
        public static int miPrtint_ALL_0_IN_1_CAT_2_Dot_3;
        public static DateTime mdaTuNgay, mdaDenNgay;
        public static bool mbNgayThang_null, mbPrint=false;
        DataTable dt2 = new DataTable();
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
  
        public void TaoBangDatatable()
        {

            dt2 = new DataTable();           
            dt2.Columns.Add("ID_VTHH_Vao_IN", typeof(string));
            dt2.Columns.Add("ID_VTHH_Ra_IN", typeof(string));
            dt2.Columns.Add("MaVT_Vao_IN", typeof(string));
            dt2.Columns.Add("MaVT_Ra_IN", typeof(string));
            dt2.Columns.Add("DonViTinh_Vao_IN", typeof(string));
            dt2.Columns.Add("DonViTinh_Ra_IN", typeof(string));
            dt2.Columns.Add("TenVatTu_Vao_IN", typeof(string));
            dt2.Columns.Add("TenVatTu_Ra_IN", typeof(string));
            dt2.Columns.Add("SoLuong_Vao_IN", typeof(string));
            dt2.Columns.Add("SoLuong_Ra_IN", typeof(string));
            dt2.Columns.Add("PhePham_IN", typeof(string));
            //dt2.Columns.Add("NgaySanXuat_IN", typeof(DateTime));
         
            dt2.Columns.Add("bMay_IN", typeof(bool));
          //
            dt2.Columns.Add("bMay_CAT", typeof(bool));
            //
           
            dt2.Columns.Add("bMay_DOT", typeof(bool));
            clsTbVatTuHangHoa clsVT_Vao = new clsTbVatTuHangHoa();
            clsTbVatTuHangHoa clsVT_Ra = new clsTbVatTuHangHoa();
            clsNhanSu_tbNhanSu clsnhansu = new clsNhanSu_tbNhanSu();
            clsPhieu_ChiTietPhieu_New cls = new clsPhieu_ChiTietPhieu_New();
            clsPhieu_tbPhieu clsphieu = new clsPhieu_tbPhieu();
            clsT_MayMoc clsmaymoc = new clsT_MayMoc();
            DataTable dtID_VTHH_Ra = cls.SelectAll_distinct_W_ID_VTHH_Ra();
            DateTime denngay = dteDenNgay.DateTime;
            DateTime tungay = dteTuNgay.DateTime;

            if (dtID_VTHH_Ra.Rows.Count > 0)
            {
                for (int i = 0; i < dtID_VTHH_Ra.Rows.Count; i++)
                {
                    int ID_VTHH_Ra = Convert.ToInt32(dtID_VTHH_Ra.Rows[i]["ID_VTHH_Ra"].ToString());
                    cls.iID_VTHH_Ra = ID_VTHH_Ra;
                   
                    DataTable dtkhh1 = cls.SelectAll_W_ID_VTHH_Ra();

                    dtkhh1.DefaultView.RowFilter = " NgaySanXuat<='" + denngay + "'";
                    DataView dv = dtkhh1.DefaultView;
                    DataTable dt22 = dv.ToTable();
                    dt22.DefaultView.RowFilter = " NgaySanXuat>='" + tungay + "'";
                    DataView dv2 = dt22.DefaultView;
                    DataTable dt12222 = dv2.ToTable();

                    if (dt12222.Rows.Count > 0)
                    {
                        DataTable dttong = new DataTable();
                        dttong.Columns.Add("SanLuong_Tong", typeof(double));
                        dttong.Columns.Add("SanLuong_Thuong", typeof(double));
                        dttong.Columns.Add("SanLuong_TangCa", typeof(double));
                        dttong.Columns.Add("PhePham", typeof(double));
                        dttong.Columns.Add("HienThi", typeof(bool));
                        //PhePham_IN
                        for (int j = 0; j < dt12222.Rows.Count; j++)
                        {
                            DataRow rowwwww1 = dttong.NewRow();
                            rowwwww1["SanLuong_Tong"] = Convert.ToDouble(dt12222.Rows[j]["SanLuong_Tong"].ToString());
                            rowwwww1["SanLuong_Thuong"] = Convert.ToDouble(dt12222.Rows[j]["SanLuong_Thuong"].ToString());
                            rowwwww1["SanLuong_TangCa"] = Convert.ToDouble(dt12222.Rows[j]["SanLuong_TangCa"].ToString());
                            rowwwww1["PhePham"] = Convert.ToDouble(dt12222.Rows[j]["PhePham"].ToString());
                            rowwwww1["HienThi"] = true;
                            dttong.Rows.Add(rowwwww1);
                        }
                        double TongSanLuong_MOI_______TheoMaHang;
                     
                        object TongSanLuong_MOI_______TheoMaHangxxxxx = dttong.Compute("sum(SanLuong_Tong)", "HienThi=true");
                        TongSanLuong_MOI_______TheoMaHang = Convert.ToDouble(TongSanLuong_MOI_______TheoMaHangxxxxx);

                        double PhePham_MOI_______TheoMaHang;
                        object PhePham_MOI_______TheoMaHangxxxxx = dttong.Compute("sum(PhePham)", "HienThi=true");
                        PhePham_MOI_______TheoMaHang = Convert.ToDouble(PhePham_MOI_______TheoMaHangxxxxx);

                        DataRow _ravi = dt2.NewRow();

                        int ID_VTHH_Vao = Convert.ToInt32(dt12222.Rows[0]["ID_VTHH_Vao"].ToString());
                        clsVT_Vao.iID_VTHH = ID_VTHH_Vao;
                        DataTable dtvtvao = clsVT_Vao.SelectOne();
                        string MaVT_Vao = clsVT_Vao.sMaVT.Value;
                        string DonViTinh_Vao = clsVT_Vao.sDonViTinh.Value;
                        string TenVatTu_Vao = clsVT_Vao.sTenVTHH.Value;                      
                      
                        clsVT_Ra.iID_VTHH = ID_VTHH_Ra;
                        DataTable dtvt_Ra = clsVT_Ra.SelectOne();
                        string MaVT_Ra = clsVT_Ra.sMaVT.Value;
                        string DonViTinh_Ra = clsVT_Ra.sDonViTinh.Value;
                        string TenVatTu_Ra = clsVT_Ra.sTenVTHH.Value;                  
                      
                        _ravi["ID_VTHH_Vao_IN"] = ID_VTHH_Vao;
                        _ravi["ID_VTHH_Ra_IN"] = ID_VTHH_Ra;
                        _ravi["MaVT_Vao_IN"] = MaVT_Vao;
                        _ravi["MaVT_Ra_IN"] = MaVT_Ra;
                        _ravi["DonViTinh_Vao_IN"] = DonViTinh_Vao;
                        _ravi["DonViTinh_Ra_IN"] = DonViTinh_Ra;
                        _ravi["TenVatTu_Vao_IN"] = TenVatTu_Vao;
                        _ravi["TenVatTu_Ra_IN"] = TenVatTu_Ra;
                        _ravi["SoLuong_Ra_IN"] = TongSanLuong_MOI_______TheoMaHang;
                        _ravi["PhePham_IN"] = PhePham_MOI_______TheoMaHang;
                        _ravi["bMay_IN"] = Convert.ToBoolean(dt12222.Rows[0]["bMay_IN"].ToString());
                        _ravi["bMay_CAT"] = Convert.ToBoolean(dt12222.Rows[0]["bMay_CAT"].ToString());
                        _ravi["bMay_DOT"] = Convert.ToBoolean(dt12222.Rows[0]["bMay_DOT"].ToString());
                        dt2.Rows.Add(_ravi);
                    }
                    
                }

            }
        }
        public void HienThi_ALL()
        {
            TaoBangDatatable();
            if (checkALL.Checked == true)
            {
                gridControl1.DataSource = dt2;
            }
            else if (check_IN.Checked == true)
            {
                dt2.DefaultView.RowFilter = "bMay_IN = True";
                DataView dv1222 = dt2.DefaultView;
                DataTable dt1 = dv1222.ToTable();
                gridControl1.DataSource = dt1;
            }
            else if (check_CAT.Checked == true)
            {
                dt2.DefaultView.RowFilter = "bMay_CAT = True";
                DataView dv1222 = dt2.DefaultView;
                DataTable dt1 = dv1222.ToTable();
                gridControl1.DataSource = dt1;
            }
            else if (check_DOT.Checked == true)
            {
                dt2.DefaultView.RowFilter = "bMay_DOT = True";
                DataView dv1222 = dt2.DefaultView;
                DataTable dt1 = dv1222.ToTable();
                gridControl1.DataSource = dt1;
            }
        }
        public frmBaoCaoSanLuongTheoMaHang_IN_CAT_DOT()
        {
            InitializeComponent();
        }

        private void frmBaoCaoSanLuongTheoMaHang_IN_CAT_DOT_Load(object sender, EventArgs e)
        {
            checkALL.Checked = true;
            DateTime ngaydautien, ngaycuoicung;
            DateTime ngayhomnay = DateTime.Today;
            int nam = Convert.ToInt16(ngayhomnay.ToString("yyyy"));
            int thang = Convert.ToInt16(ngayhomnay.ToString("MM"));
            ngaydautien = GetFistDayInMonth(nam, thang);
            ngaycuoicung = GetLastDayInMonth(nam, thang);
            dteDenNgay.EditValue = ngaycuoicung;
            dteTuNgay.EditValue = ngaydautien;
            HienThi_ALL();
        }

        private void btTImKiem_Click(object sender, EventArgs e)
        {
            bandedGridView1.OptionsFind.AlwaysVisible = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmBaoCaoSanLuongTheoMaHang_IN_CAT_DOT_Load( sender,  e);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bandedGridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            
            if (dteTuNgay.EditValue != null & dteDenNgay.EditValue != null)
            {
                HienThi_ALL();
            }
        }

        private void btRefesh_Click(object sender, EventArgs e)
        {
             frmBaoCaoSanLuongTheoMaHang_IN_CAT_DOT_Load( sender,  e);
        }

        private void checkALL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkALL.Checked == true)
            {
                check_CAT.Checked = false;
                check_DOT.Checked = false;
                check_IN.Checked = false;
                HienThi_ALL();
                miPrtint_ALL_0_IN_1_CAT_2_Dot_3 = 0;
            }
        }

        private void check_IN_CheckedChanged(object sender, EventArgs e)
        {
            if (check_IN.Checked == true)
            {

                check_CAT.Checked = false;
                check_DOT.Checked = false;
                checkALL.Checked = false;
                HienThi_ALL();
                miPrtint_ALL_0_IN_1_CAT_2_Dot_3 = 1;

            }
        }

        private void check_CAT_CheckedChanged(object sender, EventArgs e)
        {
            if (check_CAT.Checked == true)
            {
                checkALL.Checked = false;
                check_DOT.Checked = false;
                check_IN.Checked = false;
                HienThi_ALL();
                miPrtint_ALL_0_IN_1_CAT_2_Dot_3 = 2;
            }
        }

        private void check_DOT_CheckedChanged(object sender, EventArgs e)
        {
            if (check_DOT.Checked == true)
            {
                check_CAT.Checked = false;
                checkALL.Checked = false;
                check_IN.Checked = false;
                HienThi_ALL();
                miPrtint_ALL_0_IN_1_CAT_2_Dot_3 = 3;
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            DataTable DatatableABC = (DataTable)gridControl1.DataSource;
            CriteriaOperator op = bandedGridView1.ActiveFilterCriteria; // filterControl1.FilterCriteria
            string filterString = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(op);
            DataView dv1212 = new DataView(DatatableABC);
            dv1212.RowFilter = filterString;
            mdtPrint_tbChiTietPhieu_baoCaoSanLuongTheoNgay = dv1212.ToTable();
            mdaTuNgay = dteTuNgay.DateTime;
            mdaDenNgay = dteDenNgay.DateTime;
            if (dteDenNgay.Text.ToString() == "" & dteTuNgay.Text.ToString() == "")
                mbNgayThang_null = false;
            else mbNgayThang_null = true;
            if (mdtPrint_tbChiTietPhieu_baoCaoSanLuongTheoNgay.Rows.Count > 0)
            {
                mbPrint = true;
                frmPrintChiTietPhieuSanXuat_BaoCaoSanLuong_TheoNgay ff = new frmPrintChiTietPhieuSanXuat_BaoCaoSanLuong_TheoNgay();
                ff.Show();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu");
            }
            
        }

        private void bandedGridView1_CustomDrawCell_1(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void bandedGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView2_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == gridColumn1)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
