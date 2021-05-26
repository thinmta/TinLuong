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
    public partial class UCThanhPham_baoCaoTonKho : UserControl
    {
        public DataTable tinhtoanNXT_NhapXuat_TrongKy()
        {

            clsKhoThanhPham_tbChiTietNhapKho clsnpl = new CtyTinLuong.clsKhoThanhPham_tbChiTietNhapKho();
            DataTable adt2 = clsnpl.SelectAll_BaoCao_Nhap_Xuat_Ton();
            DataTable dtDISTINCT = clsnpl.SelectAll_distinct();
            DataTable dtnpl = new DataTable();
            dtnpl.Columns.Add("ID_VTHH", typeof(int));
            dtnpl.Columns.Add("MaVT", typeof(string));
            dtnpl.Columns.Add("TenVTHH", typeof(string));
            dtnpl.Columns.Add("DonViTinh", typeof(string));
            dtnpl.Columns.Add("SoLuongNhap_TrongKy", typeof(double));
            dtnpl.Columns.Add("GiaTriNhap_TrongKy", typeof(double));
            dtnpl.Columns.Add("SoLuongXuat_TrongKy", typeof(double));
            dtnpl.Columns.Add("GiaTriXuat_TrongKy", typeof(double));
            if (dtDISTINCT.Rows.Count > 0)
            {
                for (int i = 0; i < dtDISTINCT.Rows.Count; i++)
                {
                    DataTable adt1 = new DataTable();
                    adt1.Columns.Add("ID_VTHH", typeof(int));
                    adt1.Columns.Add("SoLuongNhap_TrongKy", typeof(double));
                    adt1.Columns.Add("DonGiaNhap_TrongKy", typeof(double));
                    adt1.Columns.Add("GiaTriNhap_TrongKy", typeof(double));
                    adt1.Columns.Add("SoLuongXuat_TrongKy", typeof(double));
                    adt1.Columns.Add("DonGiaXuat_TrongKy", typeof(double));
                    adt1.Columns.Add("GiaTriXuat_TrongKy", typeof(double));
                    int ID_VTHH = Convert.ToInt16(dtDISTINCT.Rows[i]["ID_VTHH"].ToString());
                    clsnpl.iID_VTHH = ID_VTHH;
                    DataTable bdt = clsnpl.Select_One_NXT_TinhToan();
                    for (int j = 0; j < bdt.Rows.Count; j++)
                    {
                        double SoLuongNhap_TrongKy;
                        double DonGiaNhap_TrongKy;
                        double GiaTriNhap_TrongKy;
                        double SoLuongTon_TrongKy;
                        double SoLuongXuat_TrongKy;
                        double DonGiaXuat_TrongKy;
                        double GiaTriXuat_TrongKy;
                        SoLuongNhap_TrongKy = Convert.ToDouble(bdt.Rows[j]["SoLuongNhap_TrongKy"].ToString());
                        DonGiaNhap_TrongKy = Convert.ToDouble(bdt.Rows[j]["DonGiaNhap_TrongKy"].ToString());
                        SoLuongTon_TrongKy = Convert.ToDouble(bdt.Rows[j]["SoLuongTon_TrongKy"].ToString());
                        GiaTriNhap_TrongKy = SoLuongNhap_TrongKy * DonGiaNhap_TrongKy;
                        SoLuongXuat_TrongKy = SoLuongNhap_TrongKy - SoLuongTon_TrongKy;
                        DonGiaXuat_TrongKy = DonGiaNhap_TrongKy;
                        GiaTriXuat_TrongKy = DonGiaXuat_TrongKy * SoLuongXuat_TrongKy;
                        DataRow _ravi = adt1.NewRow();
                        _ravi["ID_VTHH"] = ID_VTHH;
                        _ravi["SoLuongNhap_TrongKy"] = SoLuongNhap_TrongKy;
                        _ravi["DonGiaNhap_TrongKy"] = DonGiaNhap_TrongKy;
                        _ravi["GiaTriNhap_TrongKy"] = GiaTriNhap_TrongKy;
                        _ravi["SoLuongXuat_TrongKy"] = SoLuongXuat_TrongKy;
                        _ravi["DonGiaXuat_TrongKy"] = DonGiaXuat_TrongKy;
                        _ravi["GiaTriXuat_TrongKy"] = GiaTriXuat_TrongKy;
                        adt1.Rows.Add(_ravi);
                    }
                    double deSoLuongNhap_TrongKy, deGiaTriNhap_TrongKy, deSoLuongXuat_TrongKy, deGiaTriXuat_TrongKy;
                    object xxdeSoLuongNhap_TrongKy = adt1.Compute("sum(SoLuongNhap_TrongKy)", "ID_VTHH=" + ID_VTHH + "");
                    deSoLuongNhap_TrongKy = Convert.ToDouble(xxdeSoLuongNhap_TrongKy);

                    object xxdeGiaTriNhap_TrongKy = adt1.Compute("sum(GiaTriNhap_TrongKy)", "ID_VTHH=" + ID_VTHH + "");
                    deGiaTriNhap_TrongKy = Convert.ToDouble(xxdeGiaTriNhap_TrongKy);

                    object xxdeSoLuongXuat_TrongKy = adt1.Compute("sum(SoLuongXuat_TrongKy)", "ID_VTHH=" + ID_VTHH + "");
                    deSoLuongXuat_TrongKy = Convert.ToDouble(xxdeSoLuongXuat_TrongKy);

                    object xxdeGiaTriXuat_TrongKy = adt1.Compute("sum(GiaTriXuat_TrongKy)", "ID_VTHH=" + ID_VTHH + "");
                    deGiaTriXuat_TrongKy = Convert.ToDouble(xxdeGiaTriXuat_TrongKy);

                    DataRow _ravi2 = dtnpl.NewRow();
                    _ravi2["ID_VTHH"] = ID_VTHH;
                    _ravi2["MaVT"] = bdt.Rows[0]["MaVT"].ToString();
                    _ravi2["TenVTHH"] = bdt.Rows[0]["TenVTHH"].ToString();
                    _ravi2["DonViTinh"] = bdt.Rows[0]["DonViTinh"].ToString();

                    _ravi2["SoLuongNhap_TrongKy"] = deSoLuongNhap_TrongKy;
                    _ravi2["GiaTriNhap_TrongKy"] = deGiaTriNhap_TrongKy;
                    _ravi2["SoLuongXuat_TrongKy"] = deSoLuongXuat_TrongKy;
                    _ravi2["GiaTriXuat_TrongKy"] = deGiaTriXuat_TrongKy;
                    dtnpl.Rows.Add(_ravi2);
                }
            }
            return dtnpl;
        }
        public DataTable tinhtoanNXT_Ton_DauKy()
        {
            clsKhoThanhPham_tbChiTietTonDauKy cls = new clsKhoThanhPham_tbChiTietTonDauKy();
            DataTable dt = cls.SelectAll_BaoCao_Nhap_Xuat_Ton();
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_VTHH", typeof(int));
            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("TenVTHH", typeof(string));
            dt2.Columns.Add("DonViTinh", typeof(string));
            dt2.Columns.Add("SoLuong_TonDauKy", typeof(double));
            dt2.Columns.Add("GiaTri_TonDauKy", typeof(double));
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                double SoLuong_TonDauKy;
                double DonGia_TonDauKy;
                double GiaTri_TonDauKy;
                SoLuong_TonDauKy = Convert.ToDouble(dt.Rows[i]["SoLuong_TonDauKy"].ToString());
                DonGia_TonDauKy = Convert.ToDouble(dt.Rows[i]["DonGia_TonDauKy"].ToString());
                GiaTri_TonDauKy = DonGia_TonDauKy * SoLuong_TonDauKy;

                DataRow _ravi = dt2.NewRow();
                _ravi["ID_VTHH"] = Convert.ToDouble(dt.Rows[i]["ID_VTHH"].ToString());
                _ravi["MaVT"] = dt.Rows[i]["MaVT"].ToString();
                _ravi["TenVTHH"] = dt.Rows[i]["TenVTHH"].ToString();
                _ravi["DonViTinh"] = dt.Rows[i]["DonViTinh"].ToString();
                _ravi["SoLuong_TonDauKy"] = SoLuong_TonDauKy;
                _ravi["GiaTri_TonDauKy"] = GiaTri_TonDauKy;
                dt2.Rows.Add(_ravi);
            }
            return dt2;


        }

        private void HienThi()
        {
            DataTable dtnpl = tinhtoanNXT_NhapXuat_TrongKy();
            DataTable dtTonDauKy = tinhtoanNXT_Ton_DauKy();
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_VTHH", typeof(int));
            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("TenVTHH", typeof(string));
            dt2.Columns.Add("DonViTinh", typeof(string));

            dt2.Columns.Add("SoLuong_TonDauKy", typeof(double));
            dt2.Columns.Add("GiaTri_TonDauKy", typeof(double));

            dt2.Columns.Add("SoLuongNhap_TrongKy", typeof(double));
            dt2.Columns.Add("GiaTriNhap_TrongKy", typeof(double));

            dt2.Columns.Add("SoLuongXuat_TrongKy", typeof(double));
            dt2.Columns.Add("GiaTriXuat_TrongKy", typeof(double));

            dt2.Columns.Add("SoLuongTon_CuoiKy", typeof(double));
            dt2.Columns.Add("GiaTriTon_CuoiKy", typeof(double));

            for (int i = 0; i < dtnpl.Rows.Count; i++)
            {
                int iiiiiID_VTHH;
                double SoLuong_TonDauKy;
                double GiaTri_TonDauKy;

                double SoLuongNhap_TrongKy;
                double GiaTriNhap_TrongKy;

                double SoLuongXuat_TrongKy;
                double GiaTriXuat_TrongKy;

                double SoLuongTon_CuoiKy;
                double GiaTriTon_CuoiKy;

                SoLuongNhap_TrongKy = Convert.ToDouble(dtnpl.Rows[i]["SoLuongNhap_TrongKy"].ToString());
                GiaTriNhap_TrongKy = Convert.ToDouble(dtnpl.Rows[i]["GiaTriNhap_TrongKy"].ToString());

                SoLuongXuat_TrongKy = Convert.ToDouble(dtnpl.Rows[i]["SoLuongXuat_TrongKy"].ToString());
                GiaTriXuat_TrongKy = Convert.ToDouble(dtnpl.Rows[i]["GiaTriXuat_TrongKy"].ToString());
                iiiiiID_VTHH = Convert.ToInt16(dtnpl.Rows[i]["ID_VTHH"].ToString());
                string filterExpression = "ID_VTHH=" + iiiiiID_VTHH + "";
                DataRow[] rows = dtTonDauKy.Select(filterExpression);
                if (rows.Length == 0)
                {
                    SoLuong_TonDauKy = 0;
                    GiaTri_TonDauKy = 0;
                    SoLuongTon_CuoiKy = SoLuong_TonDauKy + SoLuongNhap_TrongKy - SoLuongXuat_TrongKy;
                    GiaTriTon_CuoiKy = GiaTri_TonDauKy + GiaTriNhap_TrongKy - GiaTriXuat_TrongKy;

                    DataRow _ravi = dt2.NewRow();
                    _ravi["ID_VTHH"] = iiiiiID_VTHH;
                    _ravi["MaVT"] = dtnpl.Rows[i]["MaVT"].ToString();
                    _ravi["TenVTHH"] = dtnpl.Rows[i]["TenVTHH"].ToString();
                    _ravi["DonViTinh"] = dtnpl.Rows[i]["DonViTinh"].ToString();

                    _ravi["SoLuong_TonDauKy"] = SoLuong_TonDauKy;
                    _ravi["GiaTri_TonDauKy"] = GiaTri_TonDauKy;

                    _ravi["SoLuongNhap_TrongKy"] = SoLuongNhap_TrongKy;
                    _ravi["GiaTriNhap_TrongKy"] = GiaTriNhap_TrongKy;

                    _ravi["SoLuongXuat_TrongKy"] = SoLuongXuat_TrongKy;
                    _ravi["GiaTriXuat_TrongKy"] = GiaTriXuat_TrongKy;

                    _ravi["SoLuongTon_CuoiKy"] = SoLuongTon_CuoiKy;
                    _ravi["GiaTriTon_CuoiKy"] = GiaTriTon_CuoiKy;
                    dt2.Rows.Add(_ravi);
                }
                else
                {
                    clsKhoThanhPham_tbChiTietTonDauKy cls = new clsKhoThanhPham_tbChiTietTonDauKy();
                    cls.iID_VTHH = iiiiiID_VTHH;
                    DataTable dt = cls.SelectOne_SelectOne_W_ID_VTHH();
                    SoLuong_TonDauKy = Convert.ToDouble(dt.Rows[0]["SoLuong"].ToString());
                    double dongiatondauky = Convert.ToDouble(dt.Rows[0]["DonGia"].ToString());
                    GiaTri_TonDauKy = SoLuong_TonDauKy * dongiatondauky;
                    SoLuongTon_CuoiKy = SoLuong_TonDauKy + SoLuongNhap_TrongKy - SoLuongXuat_TrongKy;
                    GiaTriTon_CuoiKy = GiaTri_TonDauKy + GiaTriNhap_TrongKy - GiaTriXuat_TrongKy;

                    DataRow _ravi = dt2.NewRow();
                    _ravi["ID_VTHH"] = iiiiiID_VTHH;
                    _ravi["MaVT"] = dtnpl.Rows[i]["MaVT"].ToString();
                    _ravi["TenVTHH"] = dtnpl.Rows[i]["TenVTHH"].ToString();
                    _ravi["DonViTinh"] = dtnpl.Rows[i]["DonViTinh"].ToString();

                    _ravi["SoLuong_TonDauKy"] = SoLuong_TonDauKy;
                    _ravi["GiaTri_TonDauKy"] = GiaTri_TonDauKy;

                    _ravi["SoLuongNhap_TrongKy"] = SoLuongNhap_TrongKy;
                    _ravi["GiaTriNhap_TrongKy"] = GiaTriNhap_TrongKy;

                    _ravi["SoLuongXuat_TrongKy"] = SoLuongXuat_TrongKy;
                    _ravi["GiaTriXuat_TrongKy"] = GiaTriXuat_TrongKy;

                    _ravi["SoLuongTon_CuoiKy"] = SoLuongTon_CuoiKy;
                    _ravi["GiaTriTon_CuoiKy"] = GiaTriTon_CuoiKy;
                    dt2.Rows.Add(_ravi);
                }
            }
            for (int i = 0; i < dtTonDauKy.Rows.Count; i++)
            {
                int iiiiiID_VTHH;
                double SoLuong_TonDauKy;
                double GiaTri_TonDauKy;

                double SoLuongNhap_TrongKy;
                double GiaTriNhap_TrongKy;

                double SoLuongXuat_TrongKy;
                double GiaTriXuat_TrongKy;

                double SoLuongTon_CuoiKy;
                double GiaTriTon_CuoiKy;

                SoLuongNhap_TrongKy = 0;
                GiaTriNhap_TrongKy = 0;

                SoLuongXuat_TrongKy = 0;
                GiaTriXuat_TrongKy = 0;

                iiiiiID_VTHH = Convert.ToInt16(dtTonDauKy.Rows[i]["ID_VTHH"].ToString());
                string filterExpression = "ID_VTHH=" + iiiiiID_VTHH + "";
                DataRow[] rows = dtnpl.Select(filterExpression);
                if (rows.Length == 0)
                {
                    SoLuong_TonDauKy = Convert.ToDouble(dtTonDauKy.Rows[i]["SoLuong_TonDauKy"].ToString());
                    GiaTri_TonDauKy = Convert.ToDouble(dtTonDauKy.Rows[i]["GiaTri_TonDauKy"].ToString());
                    SoLuongNhap_TrongKy = 0;
                    GiaTriNhap_TrongKy = 0;

                    SoLuongXuat_TrongKy = 0;
                    GiaTriXuat_TrongKy = 0;
                    SoLuongTon_CuoiKy = SoLuong_TonDauKy + SoLuongNhap_TrongKy - SoLuongXuat_TrongKy;
                    GiaTriTon_CuoiKy = GiaTri_TonDauKy + GiaTriNhap_TrongKy - GiaTriXuat_TrongKy;
                    DataRow _ravi = dt2.NewRow();
                    _ravi["ID_VTHH"] = iiiiiID_VTHH;
                    _ravi["MaVT"] = dtTonDauKy.Rows[i]["MaVT"].ToString();
                    _ravi["TenVTHH"] = dtTonDauKy.Rows[i]["TenVTHH"].ToString();
                    _ravi["DonViTinh"] = dtTonDauKy.Rows[i]["DonViTinh"].ToString();

                    _ravi["SoLuong_TonDauKy"] = SoLuong_TonDauKy;
                    _ravi["GiaTri_TonDauKy"] = GiaTri_TonDauKy;

                    _ravi["SoLuongNhap_TrongKy"] = SoLuongNhap_TrongKy;
                    _ravi["GiaTriNhap_TrongKy"] = GiaTriNhap_TrongKy;

                    _ravi["SoLuongXuat_TrongKy"] = SoLuongXuat_TrongKy;
                    _ravi["GiaTriXuat_TrongKy"] = GiaTriXuat_TrongKy;

                    _ravi["SoLuongTon_CuoiKy"] = SoLuongTon_CuoiKy;
                    _ravi["GiaTriTon_CuoiKy"] = GiaTriTon_CuoiKy;
                    dt2.Rows.Add(_ravi);

                }
            }

            gridControl1.DataSource = dt2;

        }
        public UCThanhPham_baoCaoTonKho()
        {
            InitializeComponent();
        }

        private void UCThanhPham_baoCaoTonKho_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}
