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

        private int _SoTrang = 1;
        private bool isload = false;
        public static DateTime GetFistDayInMonth(int year, int month)
        {
            DateTime aDateTime = new DateTime(year, month, 1);
            return aDateTime;
        }
        public void LoadData(int sotrang, bool isLoadLanDau, DateTime xxtungay, DateTime xxdenngay)
        {
            isload = true;
            _SoTrang = sotrang;
            gridControl1.DataSource = null;

            DataTable dt2 = new DataTable();
            dt2 = new DataTable();

            dt2.Columns.Add("ID_CongNhan", typeof(string));
            dt2.Columns.Add("TenNhanVien", typeof(string));
            dt2.Columns.Add("ID_VTHH_Ra", typeof(string));
            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("TenVTHH", typeof(string));
            dt2.Columns.Add("DonViTinh", typeof(string));
            dt2.Columns.Add("ID_DinhMuc_Luong", typeof(string));
            dt2.Columns.Add("SanLuong_Thuong", typeof(string));
            dt2.Columns.Add("SanLuong_TangCa", typeof(string));
            dt2.Columns.Add("DinhMuc_KhongTang", typeof(string));
            dt2.Columns.Add("DinhMuc_Tang", typeof(string));
            dt2.Columns.Add("ThanhTien", typeof(string));
           
           

            clsPhieu_ChiTietPhieu_New cls = new clsPhieu_ChiTietPhieu_New();
            clsTbVatTuHangHoa clsvt = new clsTbVatTuHangHoa();
            clsNhanSu_tbNhanSu clsnhansu = new clsNhanSu_tbNhanSu();
            clsDinhMuc_DinhMuc_Luong_TheoSanLuong clsdm = new clsDinhMuc_DinhMuc_Luong_TheoSanLuong();
            DataTable dtcongnhan = cls.SelectAll_distinct_ID_CongNhan_W_NgayThang(xxtungay,xxdenngay);
            if (dtcongnhan.Rows.Count > 0)
            {
                for (int i = 0; i < dtcongnhan.Rows.Count; i++)
                {
                    int ID_CongNhanxxx = Convert.ToInt32(dtcongnhan.Rows[i]["ID_CongNhan"].ToString());
                  
                    DataTable dtxxxx = new DataTable();
                    dtxxxx = cls.SelectAll_distinct_ID_VTHH_Ra_W_NgayThang_CongNhan(ID_CongNhanxxx, xxtungay, xxdenngay);
                    if (dtxxxx.Rows.Count > 0)
                    {
                        for(int k=0; k<dtxxxx.Rows.Count; k++)
                        {
                            int xxID_VTHH_Ra = Convert.ToInt32(dtxxxx.Rows[k]["ID_VTHH_Ra"].ToString());
                            DataTable dttong = cls.Select_SUM_W_ID_VTHH_Ra_NgayThang_CongNhan(xxID_VTHH_Ra, ID_CongNhanxxx, xxtungay, xxdenngay);
                            DataTable dtdinhmuc=cls.Select_W_ID_VTHH_Ra_W_CongNhan_NgayThang(xxID_VTHH_Ra, ID_CongNhanxxx, xxtungay, xxdenngay);
                            if(dtdinhmuc.Rows.Count>0)
                            {
                                double dongia = Convert.ToDouble(dtdinhmuc.Rows[0]["DinhMuc_KhongTang"].ToString());
                                double dongia_Tang = Convert.ToDouble(dtdinhmuc.Rows[0]["DinhMuc_Tang"].ToString());
                                int ID_DinhMuc_Luongxx= Convert.ToInt32(dtdinhmuc.Rows[0]["ID_DinhMuc_Luong"].ToString());
                                if (Convert.ToDouble(dttong.Rows[0]["ThanhTien"].ToString()) > 0)
                                {
                                    DataRow _ravi = dt2.NewRow();
                                    clsvt.iID_VTHH = xxID_VTHH_Ra;
                                    DataTable dtvt_Ra = clsvt.SelectOne();
                                    string MaVT_Ra = clsvt.sMaVT.Value;
                                    string DonViTinh_Ra = clsvt.sDonViTinh.Value;
                                    string TenVatTu_Ra = clsvt.sTenVTHH.Value;

                                    clsnhansu.iID_NhanSu = ID_CongNhanxxx;
                                    DataTable dtns = clsnhansu.SelectOne();
                                    string stencongnhan = clsnhansu.sTenNhanVien.Value;
                                    
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
               
            }

            gridControl1.DataSource = dt2;
            isload = false;
        }
        private void Load_PhieuSX(bool islandau)
        {
            int sotrang_ = 1;
            try
            {
                sotrang_ = Convert.ToInt32(txtSoTrang.Text);
            }
            catch
            {
                sotrang_ = 1;
                txtSoTrang.Text = "1";
            }
            LoadData(sotrang_, true, dteTuNgay.DateTime, dteDenNgay.DateTime);
        }
        public void ResetSoTrang(DateTime xxtungay, DateTime xxdenngay)
        {
            btnTrangSau.Visible = true;
            btnTrangTiep.Visible = true;
            lbTongSoTrang.Visible = true;
            txtSoTrang.Visible = true;
            btnTrangSau.LinkColor = Color.Black;
            btnTrangTiep.LinkColor = Color.Blue;
            txtSoTrang.Text = "1";

            using (clsHUU_LenhSanXuat cls = new clsHUU_LenhSanXuat())
            {
                DataTable dt_ = cls.SelectAll_Tinh_SoLenh_SX(xxtungay, xxdenngay);
                if (dt_ != null && dt_.Rows.Count > 0)
                {
                    lbTongSoTrang.Text = "/" + (Math.Ceiling(Convert.ToDouble(dt_.Rows[0]["tongso"].ToString()) / (double)20)).ToString();
                }
                else
                {
                    lbTongSoTrang.Text = "/1";
                }
            }
            if (lbTongSoTrang.Text == "0")
                lbTongSoTrang.Text = "/1";
            if (lbTongSoTrang.Text == "/1")
            {
                btnTrangSau.LinkColor = Color.Black;
                btnTrangTiep.LinkColor = Color.Black;
            }
        }
        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            if (dteDenNgay.EditValue != null & dteTuNgay.EditValue != null)
            {
                ResetSoTrang(dteTuNgay.DateTime, dteDenNgay.DateTime);
                LoadData(1, true, dteTuNgay.DateTime, dteDenNgay.DateTime);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView2_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            if (gridView2.GetFocusedRowCellValue(clID_VTHH_Ra).ToString() != "")
            {
                miID_VTHH_Ra = Convert.ToInt32(gridView2.GetFocusedRowCellValue(clID_VTHH_Ra).ToString());
                mdatungay = dteTuNgay.DateTime;
                mdadenngay = dteDenNgay.DateTime;
                SanLuong_ChiTiet_SanLuong_Dot_Dap ff = new SanLuong_ChiTiet_SanLuong_Dot_Dap();
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

        private void btnTrangTiep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isload)
                return;
            if (btnTrangTiep.LinkColor == Color.Black)
                return;
            if (btnTrangSau.LinkColor == Color.Black)
                btnTrangSau.LinkColor = Color.Blue;

            int sotrang_;
            try
            {
                sotrang_ = Convert.ToInt32(txtSoTrang.Text);
                int max_ = Convert.ToInt32(lbTongSoTrang.Text.Replace(" ", "").Replace("/", ""));
                if (sotrang_ < max_)
                {
                    txtSoTrang.Text = (sotrang_ + 1).ToString();

                    Load_PhieuSX(false);
                }
                else
                {
                    txtSoTrang.Text = (max_).ToString();
                    btnTrangTiep.LinkColor = Color.Black;
                }
            }
            catch
            {
                btnTrangTiep.LinkColor = Color.Black;
                sotrang_ = 1;
                txtSoTrang.Text = "1";
            }
        }

        private void btnTrangSau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isload)
                return;
            if (btnTrangSau.LinkColor == Color.Black)
                return;
            if (btnTrangTiep.LinkColor == Color.Black)
                btnTrangTiep.LinkColor = Color.Blue;

            int sotrang_;
            try
            {
                sotrang_ = Convert.ToInt32(txtSoTrang.Text);
                if (sotrang_ <= 1)
                {
                    txtSoTrang.Text = "1";
                    btnTrangSau.LinkColor = Color.Black;

                }
                else
                {
                    txtSoTrang.Text = (sotrang_ - 1).ToString();
                    Load_PhieuSX(false);
                }
            }
            catch
            {
                btnTrangSau.LinkColor = Color.Black;
                sotrang_ = 1;
                txtSoTrang.Text = "1";
            }
        }

        private void txtSoTrang_TextChanged(object sender, EventArgs e)
        {
            if (isload)
                return;
            Load_PhieuSX(false);
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

          

         
            LoadData(1, true, dteTuNgay.DateTime, dteDenNgay.DateTime);
            ResetSoTrang(dteTuNgay.DateTime, dteDenNgay.DateTime);
        }

      
    }
}
