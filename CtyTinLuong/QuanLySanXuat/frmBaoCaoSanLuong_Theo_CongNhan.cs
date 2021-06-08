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
        public static DataTable mdtPrint;
        public static bool mbPrint_ALL, mbPrint_RutGon;

        public static DateTime mdatungay, mdadenngay;
        public static int miID_VTHH_Ra;

       
        public static DateTime GetFistDayInMonth(int year, int month)
        {
            DateTime aDateTime = new DateTime(year, month, 1);
            return aDateTime;
        }
        public void LoadData( DateTime xxtungay, DateTime xxdenngay)
        {

            gridControl1.DataSource = null;

            DataTable dt2 = new DataTable();
            dt2 = new DataTable();
            dt2.Columns.Add("STT", typeof(string));
            dt2.Columns.Add("ID_CongNhan", typeof(string));
            dt2.Columns.Add("TenNhanVien", typeof(string));
            dt2.Columns.Add("ID_VTHH_Ra", typeof(string));
            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("TenVTHH", typeof(string));
            dt2.Columns.Add("DonViTinh", typeof(string));
            dt2.Columns.Add("ID_DinhMuc_Luong", typeof(string));
            dt2.Columns.Add("SanLuong_Thuong", typeof(string));
            dt2.Columns.Add("SanLuong_TangCa", typeof(string));
            dt2.Columns.Add("DinhMuc_KhongTang", typeof(double));
            dt2.Columns.Add("DinhMuc_Tang", typeof(double));
            dt2.Columns.Add("ThanhTien", typeof(double));



            clsPhieu_ChiTietPhieu_New cls = new clsPhieu_ChiTietPhieu_New();
            clsTbVatTuHangHoa clsvt = new clsTbVatTuHangHoa();
            clsNhanSu_tbNhanSu clsnhansu = new clsNhanSu_tbNhanSu();
            clsDinhMuc_DinhMuc_Luong_TheoSanLuong clsdm = new clsDinhMuc_DinhMuc_Luong_TheoSanLuong();
            DataTable dtcongnhan = cls.SelectAll_distinct_ID_CongNhan_W_NgayThang(xxtungay, xxdenngay);
            if (dtcongnhan.Rows.Count > 0)
            {
                for (int i = 0; i < dtcongnhan.Rows.Count; i++)
                {
                    int ID_CongNhanxxx = Convert.ToInt32(dtcongnhan.Rows[i]["ID_CongNhan"].ToString());
                    clsnhansu.iID_NhanSu = ID_CongNhanxxx;
                    DataTable dtns = clsnhansu.SelectOne();
                    string stencongnhan = clsnhansu.sTenNhanVien.Value;


                    //DataRow _ravi1 = dt2.NewRow();
                    //_ravi1["STT"] = "";
                    //_ravi1["TenNhanVien"] = stencongnhan;
                    //_ravi1["ThanhTien"] = deTOngtien;
                    //dt2.Rows.Add(_ravi1);


                    DataTable dtxxxx = new DataTable();
                    dtxxxx = cls.SelectAll_distinct_ID_VTHH_Ra_W_NgayThang_CongNhan(ID_CongNhanxxx, xxtungay, xxdenngay);


                    if (dtxxxx.Rows.Count > 0)
                    {
                        for (int k = 0; k < dtxxxx.Rows.Count; k++)
                        {
                            int xxID_VTHH_Ra = Convert.ToInt32(dtxxxx.Rows[k]["ID_VTHH_Ra"].ToString());
                            DataTable dttong = cls.Select_SUM_W_ID_VTHH_Ra_NgayThang_CongNhan(xxID_VTHH_Ra, ID_CongNhanxxx, xxtungay, xxdenngay);
                            DataTable dtdinhmuc = cls.Select_W_ID_VTHH_Ra_W_CongNhan_NgayThang(xxID_VTHH_Ra, ID_CongNhanxxx, xxtungay, xxdenngay);

                            double deTOngtien;
                            object xxxx = dttong.Compute("sum(ThanhTien)", "ThanhTien > 0");
                            if (xxxx.ToString() != "")
                                deTOngtien = Convert.ToDouble(xxxx);
                            else deTOngtien = 0;
                           
                            if (dtdinhmuc.Rows.Count > 0)
                            {
                                double dongia = Convert.ToDouble(dtdinhmuc.Rows[0]["DinhMuc_KhongTang"].ToString());
                                double dongia_Tang = Convert.ToDouble(dtdinhmuc.Rows[0]["DinhMuc_Tang"].ToString());
                                int ID_DinhMuc_Luongxx = Convert.ToInt32(dtdinhmuc.Rows[0]["ID_DinhMuc_Luong"].ToString());

                                DataRow _ravi = dt2.NewRow();
                                clsvt.iID_VTHH = xxID_VTHH_Ra;
                                DataTable dtvt_Ra = clsvt.SelectOne();
                                string MaVT_Ra = clsvt.sMaVT.Value;
                                string DonViTinh_Ra = clsvt.sDonViTinh.Value;
                                string TenVatTu_Ra = clsvt.sTenVTHH.Value;
                                _ravi["STT"] = k+1;
                                _ravi["ID_CongNhan"] = ID_CongNhanxxx;
                                _ravi["TenNhanVien"] = stencongnhan;
                                _ravi["ID_VTHH_Ra"] = xxID_VTHH_Ra;
                                _ravi["MaVT"] = MaVT_Ra;
                                _ravi["TenVTHH"] = TenVatTu_Ra;
                                _ravi["DonViTinh"] = DonViTinh_Ra;
                                _ravi["ID_DinhMuc_Luong"] = ID_DinhMuc_Luongxx;
                                _ravi["SanLuong_Thuong"] = Convert.ToDouble(dttong.Rows[0]["SanLuong_Thuong"].ToString());
                                _ravi["SanLuong_TangCa"] = Convert.ToDouble(dttong.Rows[0]["SanLuong_TangCa"].ToString());
                                _ravi["DinhMuc_KhongTang"] = dongia;
                                _ravi["DinhMuc_Tang"] = dongia_Tang;
                                _ravi["ThanhTien"] = Convert.ToDouble(dttong.Rows[0]["ThanhTien"].ToString());

                                dt2.Rows.Add(_ravi);

                            }

                        }

                    }

                }

            }

            gridControl1.DataSource = dt2;
           
        }
     
        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            if (dteDenNgay.EditValue != null & dteTuNgay.EditValue != null)
            {
                
                LoadData(dteTuNgay.DateTime, dteDenNgay.DateTime);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView2_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //if (e.Column == clSTT)
            //    e.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            if (gridView2.GetFocusedRowCellValue(clID_VTHH_Ra).ToString() != "")
            {
                miID_VTHH_Ra = Convert.ToInt32(gridView2.GetFocusedRowCellValue(clID_VTHH_Ra).ToString());
                mdatungay = dteTuNgay.DateTime;
                mdadenngay = dteDenNgay.DateTime;
                SanLuong_ChiTiet_Luong ff = new SanLuong_ChiTiet_Luong();
                ff.Show();

            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            DataTable DatatableABC = (DataTable)gridControl1.DataSource;
            CriteriaOperator op = gridView2.ActiveFilterCriteria; // filterControl1.FilterCriteria
            string filterString = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(op);
            DataView dv1212 = new DataView(DatatableABC);
            dv1212.RowFilter = filterString;
            mdtPrint = dv1212.ToTable();
            if (mdtPrint.Rows.Count > 0)
            {
                mbPrint_RutGon = true;
                mbPrint_ALL = false;
                mdatungay = dteTuNgay.DateTime;
                mdadenngay = dteDenNgay.DateTime;
                frmPrint_SanLuongToMayIn ff = new frmPrint_SanLuongToMayIn();
                ff.Show();

            }
        }

        private void btprint_ALL_Click(object sender, EventArgs e)
        {
            DataTable DatatableABC = (DataTable)gridControl1.DataSource;
            CriteriaOperator op = gridView2.ActiveFilterCriteria; // filterControl1.FilterCriteria
            string filterString = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(op);
            DataView dv1212 = new DataView(DatatableABC);
            dv1212.RowFilter = filterString;
            mdtPrint = dv1212.ToTable();

            if (mdtPrint.Rows.Count > 0)
            {
                mbPrint_RutGon = false;
                mbPrint_ALL = true;
                mdatungay = dteTuNgay.DateTime;
                mdadenngay = dteDenNgay.DateTime;
                frmPrint_SanLuongToMayIn ff = new frmPrint_SanLuongToMayIn();
                ff.Show();

            }
        }

        private void btRefesh_Click(object sender, EventArgs e)
        {
            frmBaoCaoSanLuong_Theo_CongNhan_Load( sender,  e);
        }

        public frmBaoCaoSanLuong_Theo_CongNhan()
        {
            InitializeComponent();
        }

        private void frmBaoCaoSanLuong_Theo_CongNhan_Load(object sender, EventArgs e)
        {
            DateTime ngayhomnay = DateTime.Today;
            int nam = Convert.ToInt16(ngayhomnay.ToString("yyyy"));
            int thang = Convert.ToInt16(ngayhomnay.ToString("MM"));

            dteDenNgay.DateTime = DateTime.Today;
            dteTuNgay.DateTime = GetFistDayInMonth(nam, thang);
            
            LoadData( dteTuNgay.DateTime, dteDenNgay.DateTime);
            gridView2.ExpandAllGroups();
        }

      
    }
}
