using DevExpress.Data.Filtering;
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
    public partial class frmBaoCaoSanLuong_Theo_CongNhan : Form
    {
        public static DataTable mdtPrint_tbChiTietPhieu_baoCaoSanLuongTheoCongNhan;
        public static int miPrtint_ALL_0_IN_1_CAT_2_Dot_3;
        public static DateTime mdaTuNgay, mdaDenNgay;
        public static bool mbNgayThang_null, mbPrint = false;
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
          //  dt2.Columns.Add("STT", typeof(string));
            dt2.Columns.Add("ID_SoPhieu", typeof(int));
            dt2.Columns.Add("MaPhieu", typeof(string));

            dt2.Columns.Add("ID_VTHH_Vao", typeof(int));
            dt2.Columns.Add("ID_VTHH_Ra", typeof(int));
            dt2.Columns.Add("ID_CongNhan", typeof(int));
            dt2.Columns.Add("MaVT_Vao", typeof(string));
            dt2.Columns.Add("MaVT_Ra", typeof(string));
            dt2.Columns.Add("DonViTinh_Vao", typeof(string));
            dt2.Columns.Add("DonViTinh_Ra", typeof(string));
            dt2.Columns.Add("TenVatTu_Vao", typeof(string));
            dt2.Columns.Add("TenVatTu_Ra", typeof(string));
            dt2.Columns.Add("SoLuong_Vao", typeof(double));
            dt2.Columns.Add("SanLuong_Thuong", typeof(double));
            dt2.Columns.Add("SanLuong_TangCa", typeof(double));
            dt2.Columns.Add("SanLuong_Tong", typeof(double));
            dt2.Columns.Add("ID_DinhMuc_Luong", typeof(int));
            dt2.Columns.Add("DinhMuc_KhongTang", typeof(double));
            dt2.Columns.Add("DinhMuc_Tang", typeof(double));
            dt2.Columns.Add("PhePham", typeof(double));
            dt2.Columns.Add("NgaySanXuat", typeof(DateTime));
            dt2.Columns.Add("CaSanXuat", typeof(string));
            dt2.Columns.Add("CongNhan", typeof(string));
            dt2.Columns.Add("MaMay", typeof(string));
            dt2.Columns.Add("bMay_IN", typeof(bool));   
           
            dt2.Columns.Add("bMay_CAT", typeof(bool));            //

            dt2.Columns.Add("bMay_DOT", typeof(bool));
            clsDinhMuc_DinhMuc_Luong_TheoSanLuong clsdm = new clsDinhMuc_DinhMuc_Luong_TheoSanLuong();
            clsTbVatTuHangHoa clsVT_Vao = new clsTbVatTuHangHoa();
            clsTbVatTuHangHoa clsVT_Ra = new clsTbVatTuHangHoa();
            clsNhanSu_tbNhanSu clsnhansu = new clsNhanSu_tbNhanSu();
            clsPhieu_ChiTietPhieu_New cls = new clsPhieu_ChiTietPhieu_New();
            clsPhieu_tbPhieu clsphieu = new clsPhieu_tbPhieu();
            clsT_MayMoc clsmaymoc = new clsT_MayMoc();
            DataTable dtcongnhan = cls.SelectAll_distinct_W_ID_CongNhan();
            DateTime denngay = dteDenNgay.DateTime;
            DateTime tungay = dteTuNgay.DateTime;

            if (dtcongnhan.Rows.Count > 0)
            {
                for (int i = 0; i < dtcongnhan.Rows.Count; i++)
                {
                    int ID_CongNhanxxx = Convert.ToInt32(dtcongnhan.Rows[i]["ID_CongNhan"].ToString());
                    cls.iID_CongNhan = ID_CongNhanxxx;
                    DataTable dtkhh1 = cls.SelectAll_W_ID_CongNhan();

                    dtkhh1.DefaultView.RowFilter = " NgaySanXuat<='" + denngay + "'";
                    DataView dv = dtkhh1.DefaultView;
                    DataTable dt22 = dv.ToTable();
                    dt22.DefaultView.RowFilter = " NgaySanXuat>='" + tungay + "'";
                    DataView dv2 = dt22.DefaultView;
                    DataTable dt12222 = dv2.ToTable();

                    if (dt12222.Rows.Count > 0)
                    {
                        int ID_VTHH_Vao, ID_VTHH_Ra, ID_SoPhieu, ID_CongNhan, ID_May, ID_DinhMuc_Luong;
                        string MaVT_Vao, DonViTinh_Vao, TenVatTu_Vao, MaVT_Ra, DonViTinh_Ra, TenVatTu_Ra, MaMay;
                        string MaPhieu, CaSanXuat, CongNhan;
                        double SanLuong_Thuong, SanLuong_TangCa, SanLuong_Tong, PhePham ;
                        double DinhMuc_KhongTang, DinhMuc_Tang;
                        DateTime NgaySanXuat;

                        ID_DinhMuc_Luong = Convert.ToInt32(dt12222.Rows[0]["ID_DinhMuc_Luong"].ToString());
                        clsdm.iID_DinhMuc_Luong_SanLuong = ID_DinhMuc_Luong;
                        DataTable dt = clsdm.SelectOne();
                        DinhMuc_KhongTang = Convert.ToDouble(clsdm.dcDinhMuc_KhongTang.Value);
                        DinhMuc_Tang = Convert.ToDouble(clsdm.dcDinhMuc_Tang.Value);
                        ID_May = Convert.ToInt32(dt12222.Rows[0]["ID_May"].ToString());
                        clsmaymoc.iId = ID_May;
                        DataTable dtmay = clsmaymoc.SelectOne();
                        MaMay = clsmaymoc.sMaMay.Value;

                        ID_VTHH_Vao = Convert.ToInt32(dt12222.Rows[0]["ID_VTHH_Vao"].ToString());
                        ID_VTHH_Ra = Convert.ToInt32(dt12222.Rows[0]["ID_VTHH_Ra"].ToString());
                        clsVT_Vao.iID_VTHH = ID_VTHH_Vao;
                        DataTable dtvtvao = clsVT_Vao.SelectOne();
                        MaVT_Vao = clsVT_Vao.sMaVT.Value;
                        DonViTinh_Vao = clsVT_Vao.sDonViTinh.Value;
                        TenVatTu_Vao = clsVT_Vao.sTenVTHH.Value;

                        clsVT_Ra.iID_VTHH = ID_VTHH_Ra;
                        DataTable dtvt_Ra = clsVT_Ra.SelectOne();
                        MaVT_Ra = clsVT_Ra.sMaVT.Value;
                        DonViTinh_Ra = clsVT_Ra.sDonViTinh.Value;
                        TenVatTu_Ra = clsVT_Ra.sTenVTHH.Value;

                        ID_SoPhieu = Convert.ToInt32(dt12222.Rows[0]["ID_SoPhieu"].ToString());
                        clsphieu.iID_SoPhieu = ID_SoPhieu;
                        DataTable dtphieu1 = clsphieu.SelectOne();
                        MaPhieu = clsphieu.sMaPhieu.Value;

                        SanLuong_Thuong = Convert.ToDouble(dt12222.Rows[0]["SanLuong_Thuong"].ToString());
                        SanLuong_TangCa = Convert.ToDouble(dt12222.Rows[0]["SanLuong_TangCa"].ToString());
                        SanLuong_Tong = Convert.ToDouble(dt12222.Rows[0]["SanLuong_Tong"].ToString());
                        PhePham = Convert.ToDouble(dt12222.Rows[0]["PhePham"].ToString());

                        ID_CongNhan = Convert.ToInt32(dt12222.Rows[0]["ID_CongNhan"].ToString());
                        clsnhansu.iID_NhanSu = ID_CongNhan;
                        DataTable dtcongnhan1congnhan = clsnhansu.SelectOne();
                        CongNhan = clsnhansu.sTenNhanVien.Value;
                        CaSanXuat = dt12222.Rows[0]["CaSanXuat"].ToString();
                        NgaySanXuat = Convert.ToDateTime(dt12222.Rows[0]["NgaySanXuat"].ToString());

                        DataRow _ravi = dt2.NewRow();
                        //_ravi["STT"] = i+1;
                        _ravi["ID_SoPhieu"] = ID_SoPhieu;
                        _ravi["MaPhieu"] = MaPhieu;                       
                        _ravi["ID_VTHH_Vao"] = ID_VTHH_Vao;
                        _ravi["ID_VTHH_Ra"] = ID_VTHH_Ra;
                        _ravi["ID_CongNhan"] = ID_CongNhan;
                        _ravi["MaVT_Vao"] = MaVT_Vao;
                        _ravi["MaVT_Ra"] = MaVT_Ra;
                        _ravi["DonViTinh_Vao"] = DonViTinh_Vao;
                        _ravi["DonViTinh_Ra"] = DonViTinh_Ra;
                        _ravi["TenVatTu_Vao"] = TenVatTu_Vao;
                        _ravi["TenVatTu_Ra"] = TenVatTu_Ra;
                        _ravi["SanLuong_Thuong"] = SanLuong_Thuong;
                        _ravi["SanLuong_TangCa"] = SanLuong_TangCa;
                        _ravi["SanLuong_Tong"] = SanLuong_Tong;
                       
                        _ravi["ID_DinhMuc_Luong"] = ID_DinhMuc_Luong;
                        _ravi["DinhMuc_KhongTang"] = DinhMuc_KhongTang;
                        _ravi["DinhMuc_Tang"] = DinhMuc_Tang;

                        _ravi["PhePham"] = PhePham;
                        _ravi["NgaySanXuat"] = NgaySanXuat;
                        _ravi["CaSanXuat"] = CaSanXuat;
                        _ravi["CongNhan"] = CongNhan;
                        _ravi["MaMay"] = MaMay;  
                        _ravi["bMay_IN"] = Convert.ToBoolean(dt12222.Rows[0]["bMay_IN"].ToString());
                        _ravi["bMay_CAT"] = Convert.ToBoolean(dt12222.Rows[0]["bMay_CAT"].ToString());
                        _ravi["bMay_DOT"] = Convert.ToBoolean(dt12222.Rows[0]["bMay_DOT"].ToString());
                      
                        dt2.Rows.Add(_ravi);
                        if (dt12222.Rows.Count > 1)
                        {
                            for (int j = 1; j < dt12222.Rows.Count; j++)
                            {
                                ID_DinhMuc_Luong = Convert.ToInt32(dt12222.Rows[j]["ID_DinhMuc_Luong"].ToString());
                                clsdm.iID_DinhMuc_Luong_SanLuong = ID_DinhMuc_Luong;
                                DataTable dtluong = clsdm.SelectOne();
                                DinhMuc_KhongTang = Convert.ToDouble(clsdm.dcDinhMuc_KhongTang.Value);
                                DinhMuc_Tang = Convert.ToDouble(clsdm.dcDinhMuc_Tang.Value);

                                ID_May = Convert.ToInt32(dt12222.Rows[j]["ID_May"].ToString());
                                clsmaymoc.iId = ID_May;
                                DataTable dtmay222 = clsmaymoc.SelectOne();
                                MaMay = clsmaymoc.sMaMay.Value;


                                ID_VTHH_Vao = Convert.ToInt32(dt12222.Rows[j]["ID_VTHH_Vao"].ToString());
                                ID_VTHH_Ra = Convert.ToInt32(dt12222.Rows[j]["ID_VTHH_Ra"].ToString());
                                clsVT_Vao.iID_VTHH = ID_VTHH_Vao;
                                DataTable dtvtvao2 = clsVT_Vao.SelectOne();
                                MaVT_Vao = clsVT_Vao.sMaVT.Value;
                                DonViTinh_Vao = clsVT_Vao.sDonViTinh.Value;
                                TenVatTu_Vao = clsVT_Vao.sTenVTHH.Value;

                                clsVT_Ra.iID_VTHH = ID_VTHH_Ra;
                                DataTable dtvt_Ra2 = clsVT_Ra.SelectOne();
                                MaVT_Ra = clsVT_Ra.sMaVT.Value;
                                DonViTinh_Ra = clsVT_Ra.sDonViTinh.Value;
                                TenVatTu_Ra = clsVT_Ra.sTenVTHH.Value;

                                ID_SoPhieu = Convert.ToInt32(dt12222.Rows[j]["ID_SoPhieu"].ToString());
                                clsphieu.iID_SoPhieu = ID_SoPhieu;
                                DataTable dtphieu12 = clsphieu.SelectOne();
                                MaPhieu = clsphieu.sMaPhieu.Value;

                                SanLuong_Thuong = Convert.ToDouble(dt12222.Rows[j]["SanLuong_Thuong"].ToString());
                                SanLuong_TangCa = Convert.ToDouble(dt12222.Rows[j]["SanLuong_TangCa"].ToString());
                                SanLuong_Tong = Convert.ToDouble(dt12222.Rows[j]["SanLuong_Tong"].ToString());
                                PhePham = Convert.ToDouble(dt12222.Rows[j]["PhePham"].ToString());

                                ID_CongNhan = Convert.ToInt32(dt12222.Rows[j]["ID_CongNhan"].ToString());
                                clsnhansu.iID_NhanSu = ID_CongNhan;
                                DataTable dtcongnhan1congnhan22 = clsnhansu.SelectOne();
                                CongNhan = clsnhansu.sTenNhanVien.Value;
                                CaSanXuat = dt12222.Rows[j]["CaSanXuat"].ToString();
                                NgaySanXuat = Convert.ToDateTime(dt12222.Rows[j]["NgaySanXuat"].ToString());


                                DataRow _ravi2 = dt2.NewRow();
                             //   _ravi2["STT"] = "";
                                _ravi2["ID_SoPhieu"] = ID_SoPhieu;
                                _ravi2["MaPhieu"] = MaPhieu;
                                _ravi2["ID_VTHH_Vao"] = ID_VTHH_Vao;
                                _ravi2["ID_VTHH_Ra"] = ID_VTHH_Ra;
                                _ravi2["ID_CongNhan"] = ID_CongNhan;
                                _ravi2["MaVT_Vao"] = MaVT_Vao;
                                _ravi2["MaVT_Ra"] = MaVT_Ra;
                                _ravi2["DonViTinh_Vao"] = DonViTinh_Vao;
                                _ravi2["DonViTinh_Ra"] = DonViTinh_Ra;
                                _ravi2["TenVatTu_Vao"] = TenVatTu_Vao;
                                _ravi2["TenVatTu_Ra"] = TenVatTu_Ra;
                                _ravi2["SanLuong_Thuong"] = SanLuong_Thuong;
                                _ravi2["SanLuong_TangCa"] = SanLuong_TangCa;
                                _ravi2["SanLuong_Tong"] = SanLuong_Tong;
                                _ravi["ID_DinhMuc_Luong"] = ID_DinhMuc_Luong;
                                _ravi["DinhMuc_KhongTang"] = DinhMuc_KhongTang;
                                _ravi["DinhMuc_Tang"] = DinhMuc_Tang;
                                _ravi2["PhePham"] = PhePham;
                                _ravi2["NgaySanXuat"] = NgaySanXuat;
                                _ravi2["CaSanXuat"] = CaSanXuat;
                                _ravi2["MaMay"] = MaMay;
                                _ravi2["CongNhan"] = CongNhan;
                                _ravi2["bMay_IN"] = Convert.ToBoolean(dt12222.Rows[0]["bMay_IN"].ToString());
                                _ravi2["bMay_CAT"] = Convert.ToBoolean(dt12222.Rows[0]["bMay_CAT"].ToString());
                                _ravi2["bMay_DOT"] = Convert.ToBoolean(dt12222.Rows[0]["bMay_DOT"].ToString());

                                dt2.Rows.Add(_ravi2);
                            }
                        }
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
        public frmBaoCaoSanLuong_Theo_CongNhan()
        {
            InitializeComponent();
        }

        private void frmBaoCaoSanLuong_Theo_CongNhan_Load(object sender, EventArgs e)
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

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            
            if (dteTuNgay.EditValue != null & dteDenNgay.EditValue != null)
            {
                HienThi_ALL();
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            DataTable DatatableABC = (DataTable)gridControl1.DataSource;
            CriteriaOperator op = gridView2.ActiveFilterCriteria; // filterControl1.FilterCriteria
            string filterString = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(op);
            DataView dv1212 = new DataView(DatatableABC);
            dv1212.RowFilter = filterString;
            mdtPrint_tbChiTietPhieu_baoCaoSanLuongTheoCongNhan = dv1212.ToTable();
            if (dteDenNgay.Text.ToString() == "" & dteTuNgay.Text.ToString() == "")
                mbNgayThang_null = false;
            else mbNgayThang_null = true;
            mdaTuNgay = dteTuNgay.DateTime;
            mdaDenNgay = dteDenNgay.DateTime;
            if (mdtPrint_tbChiTietPhieu_baoCaoSanLuongTheoCongNhan.Rows.Count > 0)
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmBaoCaoSanLuong_Theo_CongNhan_Load( sender,  e);
        }

        private void gridView2_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}
