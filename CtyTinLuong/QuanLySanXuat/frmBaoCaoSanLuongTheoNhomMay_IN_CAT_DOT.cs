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
    public partial class frmBaoCaoSanLuongTheoNhomMay_IN_CAT_DOT : Form
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
        public static DataTable mdtPrint_tbChiTietPhieu_baoCaoSanLuongTheoNgay;
        public static int miPrtint_ALL_0_IN_1_CAT_2_Dot_3;
        public static DateTime mdaTuNgay, mdaDenNgay;
        public static bool mbNgayThang_null, mbPrint = false;
        DataTable dt2 = new DataTable();
        public void TaoBangDatatable()
        {
            DateTime denngay = dteDenNgay.DateTime;
            DateTime tungay = dteTuNgay.DateTime;

            dt2 = new DataTable();
            dt2.Columns.Add("ID_SoPhieu", typeof(int));
            dt2.Columns.Add("MaPhieu", typeof(string));

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
            dt2.Columns.Add("NgaySanXuat_IN", typeof(DateTime));
            dt2.Columns.Add("CaSanXuat_IN", typeof(string));
            dt2.Columns.Add("CongNhan_IN", typeof(string));
            dt2.Columns.Add("MaMay_IN", typeof(string));
            dt2.Columns.Add("bMay_IN", typeof(bool));
            //
            dt2.Columns.Add("ID_VTHH_Vao_CAT", typeof(string));
            dt2.Columns.Add("ID_VTHH_Ra_CAT", typeof(string));
            dt2.Columns.Add("MaVT_Vao_CAT", typeof(string));
            dt2.Columns.Add("MaVT_Ra_CAT", typeof(string));
            dt2.Columns.Add("DonViTinh_Vao_CAT", typeof(string));
            dt2.Columns.Add("DonViTinh_Ra_CAT", typeof(string));
            dt2.Columns.Add("TenVatTu_Vao_CAT", typeof(string));
            dt2.Columns.Add("TenVatTu_Ra_CAT", typeof(string));
            dt2.Columns.Add("SoLuong_Vao_CAT", typeof(string));
            dt2.Columns.Add("SoLuong_Ra_CAT", typeof(string));
            dt2.Columns.Add("PhePham_CAT", typeof(string));
            dt2.Columns.Add("NgaySanXuat_CAT", typeof(DateTime));
            dt2.Columns.Add("CaSanXuat_CAT", typeof(string));
            dt2.Columns.Add("CongNhan_CAT", typeof(string));
            dt2.Columns.Add("MaMay_CAT", typeof(string));
            dt2.Columns.Add("bMay_CAT", typeof(bool));

            dt2.Columns.Add("ID_VTHH_Vao_DOT", typeof(string));
            dt2.Columns.Add("ID_VTHH_Ra_DOT", typeof(string));
            dt2.Columns.Add("MaVT_Vao_DOT", typeof(string));
            dt2.Columns.Add("MaVT_Ra_DOT", typeof(string));
            dt2.Columns.Add("DonViTinh_Vao_DOT", typeof(string));
            dt2.Columns.Add("DonViTinh_Ra_DOT", typeof(string));
            dt2.Columns.Add("TenVatTu_Vao_DOT", typeof(string));
            dt2.Columns.Add("TenVatTu_Ra_DOT", typeof(string));
            dt2.Columns.Add("SoLuong_Vao_DOT", typeof(string));
            dt2.Columns.Add("SoLuong_Ra_DOT", typeof(string));
            dt2.Columns.Add("PhePham_DOT", typeof(string));
            dt2.Columns.Add("NgaySanXuat_DOT", typeof(DateTime));
            dt2.Columns.Add("CaSanXuat_DOT", typeof(string));
            dt2.Columns.Add("CongNhan_DOT", typeof(string));
            dt2.Columns.Add("MaMay_DOT", typeof(string));
            dt2.Columns.Add("bMay_DOT", typeof(bool));
            clsTbVatTuHangHoa clsVT_Vao = new clsTbVatTuHangHoa();
            clsTbVatTuHangHoa clsVT_Ra = new clsTbVatTuHangHoa();
            clsNhanSu_tbNhanSu clsnhansu = new clsNhanSu_tbNhanSu();
            clsPhieu_ChiTietPhieu_New cls = new clsPhieu_ChiTietPhieu_New();
            clsPhieu_tbPhieu clsphieu = new clsPhieu_tbPhieu();
            clsT_MayMoc clsmaymoc = new clsT_MayMoc();
            DataTable daaa = clsphieu.SelectAll();

            DataView dvaaa = daaa.DefaultView;
            dvaaa.Sort = "NgayLapPhieu DESC, ID_SoPhieu DESC";
            DataTable dtphieu = dvaaa.ToTable();
            // textBox1.Text = dt.Rows.Count.ToString();

            if (dtphieu.Rows.Count > 0)
            {
                for (int i = 0; i < dtphieu.Rows.Count; i++)
                {
                    int ID_SoPhieu = Convert.ToInt32(dtphieu.Rows[i]["ID_SoPhieu"].ToString());

                    cls.iID_SoPhieu = ID_SoPhieu;
                    

                    DataTable dtkhh1 = cls.SelectAll_W_iID_SoPhieu();

                    dtkhh1.DefaultView.RowFilter = " NgaySanXuat<='" + denngay + "'";
                    DataView dv = dtkhh1.DefaultView;
                    DataTable dt22 = dv.ToTable();
                    dt22.DefaultView.RowFilter = " NgaySanXuat>='" + tungay + "'";
                    DataView dv2 = dt22.DefaultView;
                    DataTable dt12222 = dv2.ToTable();


                    dt12222.DefaultView.RowFilter = "bMay_IN = True";
                    DataView dv1222 = dt12222.DefaultView;
                    DataTable dt1 = dv1222.ToTable();

                    dt12222.DefaultView.RowFilter = "bMay_CAT = True";
                    DataView dvmaycat = dt12222.DefaultView;
                    DataTable dtmaycat = dvmaycat.ToTable();

                    dt12222.DefaultView.RowFilter = "bMay_DOT = True";
                    DataView dvmaydot = dt12222.DefaultView;
                    DataTable dtmaydot = dvmaydot.ToTable();

                    if (dt1.Rows.Count > 0)
                    {
                        DataRow _ravi = dt2.NewRow();
                        int ID_CongNhan = Convert.ToInt32(dt1.Rows[0]["ID_CongNhan"].ToString());
                        clsnhansu.iID_NhanSu = ID_CongNhan;
                        DataTable dtnhansu = clsnhansu.SelectOne();
                        string CongNhan = clsnhansu.sTenNhanVien.Value;
                        DateTime daNgaySanXuat = Convert.ToDateTime(dt1.Rows[0]["NgaySanXuat"].ToString());
                        //string NgaySanXuat = daNgaySanXuat.ToString("dd/MM/yyyy");
                        string CaSanXuat = dt1.Rows[0]["CaSanXuat"].ToString();
                        int ID_VTHH_Vao = Convert.ToInt32(dt1.Rows[0]["ID_VTHH_Vao"].ToString());
                        clsVT_Vao.iID_VTHH = ID_VTHH_Vao;
                        DataTable dtvtvao = clsVT_Vao.SelectOne();
                        string MaVT_Vao = clsVT_Vao.sMaVT.Value;
                        string DonViTinh_Vao = clsVT_Vao.sDonViTinh.Value;
                        string TenVatTu_Vao = clsVT_Vao.sTenVTHH.Value;
                        double SoLuong_Vao = Convert.ToDouble(dt1.Rows[0]["SoLuong_Vao"].ToString());
                        int ID_VTHH_Ra = Convert.ToInt32(dt1.Rows[0]["ID_VTHH_Ra"].ToString());
                        clsVT_Ra.iID_VTHH = ID_VTHH_Ra;
                        DataTable dtvt_Ra = clsVT_Ra.SelectOne();
                        string MaVT_Ra = clsVT_Ra.sMaVT.Value;
                        string DonViTinh_Ra = clsVT_Ra.sDonViTinh.Value;
                        string TenVatTu_Ra = clsVT_Ra.sTenVTHH.Value;
                        double SanLuong_Tong = Convert.ToDouble(dt1.Rows[0]["SanLuong_Tong"].ToString());
                        double PhePham = Convert.ToDouble(dt1.Rows[0]["PhePham"].ToString());
                        int ID_Mayxxx = Convert.ToInt32(dt1.Rows[0]["ID_May"].ToString());
                        clsmaymoc.iId = ID_Mayxxx;
                        DataTable dtmay = clsmaymoc.SelectOne();
                        string MaMay_IN = clsmaymoc.sMaMay.Value;
                        // dt2.Columns.Add("MaMay_DOT", typeof(string));

                        _ravi["ID_SoPhieu"] = ID_SoPhieu;
                        _ravi["MaPhieu"] = dtphieu.Rows[i]["MaPhieu"].ToString();
                        _ravi["ID_VTHH_Vao_IN"] = ID_VTHH_Vao;
                        _ravi["ID_VTHH_Ra_IN"] = ID_VTHH_Ra;
                        _ravi["MaVT_Vao_IN"] = MaVT_Vao;
                        _ravi["MaVT_Ra_IN"] = MaVT_Ra;
                        _ravi["DonViTinh_Vao_IN"] = DonViTinh_Vao;
                        _ravi["DonViTinh_Ra_IN"] = DonViTinh_Ra;
                        _ravi["TenVatTu_Vao_IN"] = TenVatTu_Vao;
                        _ravi["TenVatTu_Ra_IN"] = TenVatTu_Ra;
                        _ravi["SoLuong_Vao_IN"] = SoLuong_Vao.ToString();
                        _ravi["SoLuong_Ra_IN"] = SanLuong_Tong.ToString();
                        _ravi["PhePham_IN"] = PhePham;
                        _ravi["NgaySanXuat_IN"] = daNgaySanXuat;
                        _ravi["CaSanXuat_IN"] = CaSanXuat;
                        _ravi["CongNhan_IN"] = CongNhan;
                        _ravi["MaMay_IN"] = MaMay_IN;
                        _ravi["bMay_IN"] = true;
                        _ravi["bMay_CAT"] = false;
                        _ravi["bMay_DOT"] = false;

                        dt2.Rows.Add(_ravi);
                    }
                    if (dtmaycat.Rows.Count > 0)
                    {
                        DataRow _ravi = dt2.NewRow();
                        int ID_CongNhan = Convert.ToInt32(dtmaycat.Rows[0]["ID_CongNhan"].ToString());
                        clsnhansu.iID_NhanSu = ID_CongNhan;
                        DataTable dtnhansu = clsnhansu.SelectOne();
                        string CongNhan = clsnhansu.sTenNhanVien.Value;
                        DateTime daNgaySanXuat = Convert.ToDateTime(dtmaycat.Rows[0]["NgaySanXuat"].ToString());
                        //string NgaySanXuat = daNgaySanXuat.ToString("dd/MM/yyyy");
                        string CaSanXuat = dtmaycat.Rows[0]["CaSanXuat"].ToString();
                        int ID_VTHH_Vao = Convert.ToInt32(dtmaycat.Rows[0]["ID_VTHH_Vao"].ToString());
                        clsVT_Vao.iID_VTHH = ID_VTHH_Vao;
                        DataTable dtvtvao = clsVT_Vao.SelectOne();
                        string MaVT_Vao = clsVT_Vao.sMaVT.Value;
                        string DonViTinh_Vao = clsVT_Vao.sDonViTinh.Value;
                        string TenVatTu_Vao = clsVT_Vao.sTenVTHH.Value;
                        double SoLuong_Vao = Convert.ToDouble(dtmaycat.Rows[0]["SoLuong_Vao"].ToString());
                        int ID_VTHH_Ra = Convert.ToInt32(dtmaycat.Rows[0]["ID_VTHH_Ra"].ToString());
                        clsVT_Ra.iID_VTHH = ID_VTHH_Ra;
                        DataTable dtvt_Ra = clsVT_Ra.SelectOne();
                        string MaVT_Ra = clsVT_Ra.sMaVT.Value;
                        string DonViTinh_Ra = clsVT_Ra.sDonViTinh.Value;
                        string TenVatTu_Ra = clsVT_Ra.sTenVTHH.Value;
                        double SanLuong_Tong = Convert.ToDouble(dtmaycat.Rows[0]["SanLuong_Tong"].ToString());
                        double PhePham = Convert.ToDouble(dtmaycat.Rows[0]["PhePham"].ToString());
                        int ID_Mayxxx = Convert.ToInt32(dtmaycat.Rows[0]["ID_May"].ToString());
                        clsmaymoc.iId = ID_Mayxxx;
                        DataTable dtmay = clsmaymoc.SelectOne();
                        string MaMay_IN = clsmaymoc.sMaMay.Value;
                        // dt2.Columns.Add("MaMay_DOT", typeof(string));

                        _ravi["ID_SoPhieu"] = ID_SoPhieu;
                        _ravi["MaPhieu"] = dtphieu.Rows[i]["MaPhieu"].ToString();
                        _ravi["ID_VTHH_Vao_IN"] = ID_VTHH_Vao;
                        _ravi["ID_VTHH_Ra_IN"] = ID_VTHH_Ra;
                        _ravi["MaVT_Vao_IN"] = MaVT_Vao;
                        _ravi["MaVT_Ra_IN"] = MaVT_Ra;
                        _ravi["DonViTinh_Vao_IN"] = DonViTinh_Vao;
                        _ravi["DonViTinh_Ra_IN"] = DonViTinh_Ra;
                        _ravi["TenVatTu_Vao_IN"] = TenVatTu_Vao;
                        _ravi["TenVatTu_Ra_IN"] = TenVatTu_Ra;
                        _ravi["SoLuong_Vao_IN"] = SoLuong_Vao.ToString();
                        _ravi["SoLuong_Ra_IN"] = SanLuong_Tong.ToString();
                        _ravi["PhePham_IN"] = PhePham;
                        _ravi["NgaySanXuat_IN"] = daNgaySanXuat;
                        _ravi["CaSanXuat_IN"] = CaSanXuat;
                        _ravi["CongNhan_IN"] = CongNhan;
                        _ravi["MaMay_IN"] = MaMay_IN;
                        _ravi["bMay_IN"] = false;
                        _ravi["bMay_CAT"] = true;
                        _ravi["bMay_DOT"] = false;
                        dt2.Rows.Add(_ravi);
                    }

                    if (dtmaydot.Rows.Count > 0)
                    {
                        DataRow _ravi = dt2.NewRow();
                        int ID_CongNhan = Convert.ToInt32(dtmaydot.Rows[0]["ID_CongNhan"].ToString());
                        clsnhansu.iID_NhanSu = ID_CongNhan;
                        DataTable dtnhansu = clsnhansu.SelectOne();
                        string CongNhan = clsnhansu.sTenNhanVien.Value;
                        DateTime daNgaySanXuat = Convert.ToDateTime(dtmaydot.Rows[0]["NgaySanXuat"].ToString());
                        //string NgaySanXuat = daNgaySanXuat.ToString("dd/MM/yyyy");
                        string CaSanXuat = dtmaydot.Rows[0]["CaSanXuat"].ToString();
                        int ID_VTHH_Vao = Convert.ToInt32(dtmaydot.Rows[0]["ID_VTHH_Vao"].ToString());
                        clsVT_Vao.iID_VTHH = ID_VTHH_Vao;
                        DataTable dtvtvao = clsVT_Vao.SelectOne();
                        string MaVT_Vao = clsVT_Vao.sMaVT.Value;
                        string DonViTinh_Vao = clsVT_Vao.sDonViTinh.Value;
                        string TenVatTu_Vao = clsVT_Vao.sTenVTHH.Value;
                        double SoLuong_Vao = Convert.ToDouble(dtmaydot.Rows[0]["SoLuong_Vao"].ToString());
                        int ID_VTHH_Ra = Convert.ToInt32(dtmaydot.Rows[0]["ID_VTHH_Ra"].ToString());
                        clsVT_Ra.iID_VTHH = ID_VTHH_Ra;
                        DataTable dtvt_Ra = clsVT_Ra.SelectOne();
                        string MaVT_Ra = clsVT_Ra.sMaVT.Value;
                        string DonViTinh_Ra = clsVT_Ra.sDonViTinh.Value;
                        string TenVatTu_Ra = clsVT_Ra.sTenVTHH.Value;
                        double SanLuong_Tong = Convert.ToDouble(dtmaydot.Rows[0]["SanLuong_Tong"].ToString());
                        double PhePham = Convert.ToDouble(dtmaydot.Rows[0]["PhePham"].ToString());
                        int ID_Mayxxx = Convert.ToInt32(dtmaydot.Rows[0]["ID_May"].ToString());
                        clsmaymoc.iId = ID_Mayxxx;
                        DataTable dtmay = clsmaymoc.SelectOne();
                        string MaMay_IN = clsmaymoc.sMaMay.Value;
                        // dt2.Columns.Add("MaMay_DOT", typeof(string));

                        _ravi["ID_SoPhieu"] = ID_SoPhieu;
                        _ravi["MaPhieu"] = dtphieu.Rows[i]["MaPhieu"].ToString();
                        _ravi["ID_VTHH_Vao_IN"] = ID_VTHH_Vao;
                        _ravi["ID_VTHH_Ra_IN"] = ID_VTHH_Ra;
                        _ravi["MaVT_Vao_IN"] = MaVT_Vao;
                        _ravi["MaVT_Ra_IN"] = MaVT_Ra;
                        _ravi["DonViTinh_Vao_IN"] = DonViTinh_Vao;
                        _ravi["DonViTinh_Ra_IN"] = DonViTinh_Ra;
                        _ravi["TenVatTu_Vao_IN"] = TenVatTu_Vao;
                        _ravi["TenVatTu_Ra_IN"] = TenVatTu_Ra;
                        _ravi["SoLuong_Vao_IN"] = SoLuong_Vao.ToString();
                        _ravi["SoLuong_Ra_IN"] = SanLuong_Tong.ToString();
                        _ravi["PhePham_IN"] = PhePham;
                        _ravi["NgaySanXuat_IN"] = daNgaySanXuat;
                        _ravi["CaSanXuat_IN"] = CaSanXuat;
                        _ravi["CongNhan_IN"] = CongNhan;
                        _ravi["MaMay_IN"] = MaMay_IN;
                        _ravi["bMay_IN"] = false;
                        _ravi["bMay_CAT"] = false;
                        _ravi["bMay_DOT"] = true;
                        dt2.Rows.Add(_ravi);
                    }
                    
                }
             
            }
        }
        public void HienThi_ALL()
        {
            TaoBangDatatable();
            if(checkALL.Checked==true)
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
     
        public frmBaoCaoSanLuongTheoNhomMay_IN_CAT_DOT()
        {
            InitializeComponent();
        }

        private void frmBaoCaoSanLuongTheoNhomMay_IN_CAT_DOT_Load(object sender, EventArgs e)
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

        private void bandedGridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkALL_CheckedChanged(object sender, EventArgs e)
        {
            if(checkALL.Checked==true)
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
            frmBaoCaoSanLuongTheoNhomMay_IN_CAT_DOT_Load( sender,  e);
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
            CriteriaOperator op = bandedGridView1.ActiveFilterCriteria; // filterControl1.FilterCriteria
            string filterString = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(op);
            DataView dv1212 = new DataView(DatatableABC);
            dv1212.RowFilter = filterString;
            mdtPrint_tbChiTietPhieu_baoCaoSanLuongTheoNgay = dv1212.ToTable();
            if (dteDenNgay.Text.ToString() == "" & dteTuNgay.Text.ToString() == "")
                mbNgayThang_null = false;
            else mbNgayThang_null = true;
            mdaTuNgay = dteTuNgay.DateTime;
            mdaDenNgay = dteDenNgay.DateTime;
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
        }

        private void dteTuNgay_EditValueChanged(object sender, EventArgs e)
        {
            mdaTuNgay = dteTuNgay.DateTime;
        }

        private void dteDenNgay_EditValueChanged(object sender, EventArgs e)
        {
            mdaDenNgay = dteDenNgay.DateTime;
        }
    }
}
