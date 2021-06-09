using DevExpress.XtraGrid.Columns;
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
    public partial class SanLuong_ChiTiet_Luong : Form
    {
        private List<GridColumn> ds_grid = new List<GridColumn>();
        private void Load_LockUp()
        {
            

            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvCaTruong = dtNguoi.DefaultView;
            DataTable newdtCaTruong = dvCaTruong.ToTable();

            gridCongNhan.Properties.DataSource = newdtCaTruong;
            gridCongNhan.Properties.ValueMember = "ID_NhanSu";
            gridCongNhan.Properties.DisplayMember = "MaNhanVien";

          
        }
        private string LayThu(DateTime date)
        {
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    return "T2";
                case DayOfWeek.Tuesday:
                    return "T3";
                case DayOfWeek.Wednesday:
                    return "T4";
                case DayOfWeek.Thursday:
                    return "T5";
                case DayOfWeek.Friday:
                    return "T6";
                case DayOfWeek.Saturday:
                    return "T7";
                case DayOfWeek.Sunday:
                    return "CN";
            }
            return "";
        }
<<<<<<< HEAD

        DataTable dt2;

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
        public void LoadData(int xxID_CongNhan)
=======
        public void LoadData_Thin()
>>>>>>> ed0cb8e58a6732b7bb506f91b6146ac81a50d948
        {
            //
           //đ
                DateTime dtnow = DateTime.Now;
              
                DateTime date_ = new DateTime(dtnow.Year, dtnow.Month, 1);
                int ngaycuathang_ = (((new DateTime(dtnow.Year, dtnow.Month, 1)).AddMonths(1)).AddDays(-1)).Day;
                if (ngaycuathang_ == 28)
                {
                    Ngay31.Visible = false;
                    Ngay30.Visible = false;
                    Ngay29.Visible = false;
                }
                else if (ngaycuathang_ == 29)
                {
                    Ngay31.Visible = false;
                    Ngay30.Visible = false;
                    Ngay29.Visible = true;
                }
                else if (ngaycuathang_ == 30)
                {
                    Ngay31.Visible = false;
                    Ngay30.Visible = true;
                    Ngay29.Visible = true;
                }
                else if (ngaycuathang_ == 31)
                {
                    Ngay31.Visible = true;
                    Ngay30.Visible = true;
                    Ngay29.Visible = true;
                }
                string thu_ = LayThu(date_);
                for (int i = 0; i < ngaycuathang_; ++i)
                {
                    ds_grid[i].Caption = (i + 1) + "\n" + LayThu(new DateTime(dtnow.Year, dtnow.Month, (i + 1)));
                    if (ds_grid[i].Caption.Contains("CN"))
                    {
                        ds_grid[i].AppearanceCell.BackColor = Color.LightGray;
                        ds_grid[i].AppearanceHeader.BackColor = Color.LightGray;
                        ds_grid[i].AppearanceHeader.ForeColor = Color.Red;
                        ds_grid[i].AppearanceCell.ForeColor = Color.Red;
                    }
                }

<<<<<<< HEAD
             dt2 = new DataTable();

           
            dt2.Columns.Add("TenVTHH", typeof(string));
            dt2.Columns.Add("NoiDung", typeof(string));

            dt2.Columns.Add("Ngay1", typeof(string));
            dt2.Columns.Add("Ngay2", typeof(string));
            dt2.Columns.Add("Ngay3", typeof(string));
            dt2.Columns.Add("Ngay4", typeof(string));
            dt2.Columns.Add("Ngay5", typeof(string));
            dt2.Columns.Add("Ngay6", typeof(string));
            dt2.Columns.Add("Ngay7", typeof(string));
            dt2.Columns.Add("Ngay8", typeof(string));
            dt2.Columns.Add("Ngay9", typeof(string));
            dt2.Columns.Add("Ngay10", typeof(string));
            dt2.Columns.Add("Ngay11", typeof(string));
            dt2.Columns.Add("Ngay12", typeof(string));
            dt2.Columns.Add("Ngay13", typeof(string));
            dt2.Columns.Add("Ngay14", typeof(string));
            dt2.Columns.Add("Ngay15", typeof(string));
            dt2.Columns.Add("Ngay16", typeof(string));
            dt2.Columns.Add("Ngay17", typeof(string));
            dt2.Columns.Add("Ngay18", typeof(string));
            dt2.Columns.Add("Ngay19", typeof(string));
            dt2.Columns.Add("Ngay20", typeof(string));

            dt2.Columns.Add("Ngay21", typeof(string));
            dt2.Columns.Add("Ngay22", typeof(string));
            dt2.Columns.Add("Ngay23", typeof(string));
            dt2.Columns.Add("Ngay24", typeof(string));
            dt2.Columns.Add("Ngay25", typeof(string));
            dt2.Columns.Add("Ngay26", typeof(string));
            dt2.Columns.Add("Ngay27", typeof(string));
            dt2.Columns.Add("Ngay28", typeof(string));
            dt2.Columns.Add("Ngay29", typeof(string));
            dt2.Columns.Add("Ngay30", typeof(string));

            dt2.Columns.Add("Ngay31", typeof(string));

            dt2.Columns.Add("Tong", typeof(string));

            clsTbVatTuHangHoa clsvt = new clsTbVatTuHangHoa();
            clsPhieu_ChiTietPhieu_New cls = new clsPhieu_ChiTietPhieu_New();
            DataTable dtxxxx = new DataTable();
            dtxxxx = cls.SelectAll_distinct_ID_VTHH_Ra_W_NgayThang_CongNhan(xxID_CongNhan, ngaydauthang, ngaycuoithang);
            int days = DateTime.DaysInMonth(Convert.ToInt32(txtNam.Text.ToString()), Convert.ToInt32(txtThang.Text.ToString()));

            DataRow _ravi_1 = dt2.NewRow();
            DataRow _ravi_2 = dt2.NewRow();
           
            int id_vthh_cu_ = 0;
            double tong1 = 0, tong2 = 0;
            for (int k = 0; k < dtxxxx.Rows.Count; k++)
            {
                double snluong_thuong = Convert.ToDouble(dtxxxx.Rows[k]["SanLuong_Thuong"].ToString());
                double snluong_tangca = Convert.ToDouble(dtxxxx.Rows[k]["SanLuong_TangCa"].ToString());
                //int xxid_vthh= Convert.ToInt32(dtxxxx.Rows[k]["ID_VTHH_Ra"].ToString());
                //tong1 = Convert.ToDouble(dtxxxx.Compute("sum(SanLuong_Thuong)", "ID_VTHH_Ra=" + xxid_vthh + ""));
           
                int ngay_ = (Convert.ToDateTime(dtxxxx.Rows[k]["NgaySanXuat"].ToString()).Day);
                _ravi_1["Ngay" + (ngay_)] = snluong_thuong.ToString();
                _ravi_2["Ngay" + (ngay_)] = snluong_tangca.ToString();
                tong1 += snluong_thuong;
                tong2 += snluong_tangca;
                _ravi_1["Tong"]  = tong1.ToString();
                _ravi_2["Tong"] = tong2;
                //
                int id_vthh_ = 0;
                if (k < dtxxxx.Rows.Count - 1)
                {
                    id_vthh_ = Convert.ToInt32(dtxxxx.Rows[k+1]["ID_VTHH_Ra"].ToString());

                    if (dtxxxx.Rows[k ]["ID_VTHH_Ra"].ToString() != dtxxxx.Rows[k + 1]["ID_VTHH_Ra"].ToString())
                    { 
                        _ravi_1["TenVTHH"] = dtxxxx.Rows[k]["TenVTHH"].ToString();
                        _ravi_1["NoiDung"] = "Thường";
                        
                        _ravi_2["TenVTHH"] = "";
                        _ravi_2["NoiDung"] = "Tăng ca";
                      

                        dt2.Rows.Add(_ravi_1);
                        dt2.Rows.Add(_ravi_2);
                        tong1 = 0;
                        tong2 = 0;
                        _ravi_1 = dt2.NewRow();
                        _ravi_2 = dt2.NewRow();
                        id_vthh_cu_ = id_vthh_;
                    }
                    else
                    { }
                }
                else
                {
                    _ravi_1["TenVTHH"] = dtxxxx.Rows[k]["TenVTHH"].ToString();
                    _ravi_1["NoiDung"] = "Thường";

                    _ravi_2["TenVTHH"] = "";
                    _ravi_2["NoiDung"] = "Tăng ca";
                  

                    dt2.Rows.Add(_ravi_1);
                    dt2.Rows.Add(_ravi_2);

                    tong1 = 0;
                    tong2 = 0;
                    _ravi_1 = dt2.NewRow();
                    _ravi_2 = dt2.NewRow();
                }                 
            } 
         
            gridControl2.DataSource = dt2;
            
=======
             
>>>>>>> ed0cb8e58a6732b7bb506f91b6146ac81a50d948
        }
        private void LoadData(int ID_CongNhanxxx, DateTime xxtungay, DateTime xxdenngay)
        {
            //gridControl1.DataSource = null;


            //DataTable dt2 = new DataTable();
            //dt2 = new DataTable();
            //dt2.Columns.Add("STT", typeof(string));           
            //dt2.Columns.Add("ID_VTHH_Ra", typeof(string));
            //dt2.Columns.Add("MaVT", typeof(string));
            //dt2.Columns.Add("TenVTHH", typeof(string));
            //dt2.Columns.Add("DonViTinh", typeof(string));
            //dt2.Columns.Add("ID_DinhMuc_Luong", typeof(string));
            //dt2.Columns.Add("SanLuong_Thuong", typeof(string));
            //dt2.Columns.Add("SanLuong_TangCa", typeof(string));
            //dt2.Columns.Add("DinhMuc_KhongTang", typeof(double));
            //dt2.Columns.Add("DinhMuc_Tang", typeof(double));
            //dt2.Columns.Add("ThanhTien", typeof(double));

            //clsPhieu_ChiTietPhieu_New cls = new clsPhieu_ChiTietPhieu_New();
            //clsTbVatTuHangHoa clsvt = new clsTbVatTuHangHoa();
            //clsNhanSu_tbNhanSu clsnhansu = new clsNhanSu_tbNhanSu();
            //clsDinhMuc_DinhMuc_Luong_TheoSanLuong clsdm = new clsDinhMuc_DinhMuc_Luong_TheoSanLuong();        
          
            //DataTable dtxxxx = new DataTable();
            //dtxxxx = cls.SelectAll_distinct_ID_VTHH_Ra_W_NgayThang_CongNhan(ID_CongNhanxxx, xxtungay, xxdenngay);

            //for (int k = 0; k < dtxxxx.Rows.Count; k++)
            //{
            //    int xxID_VTHH_Ra = Convert.ToInt32(dtxxxx.Rows[k]["ID_VTHH_Ra"].ToString());
            //    DataTable dttong = cls.Select_SUM_W_ID_VTHH_Ra_NgayThang_CongNhan(xxID_VTHH_Ra, ID_CongNhanxxx, xxtungay, xxdenngay);
            //    DataTable dtdinhmuc = cls.Select_W_ID_VTHH_Ra_W_CongNhan_NgayThang(xxID_VTHH_Ra, ID_CongNhanxxx, xxtungay, xxdenngay);

            //    double deTOngtien;
            //    object xxxx = dttong.Compute("sum(ThanhTien)", "ThanhTien > 0");
            //    if (xxxx.ToString() != "")
            //        deTOngtien = Convert.ToDouble(xxxx);
            //    else deTOngtien = 0;

            //    if (dtdinhmuc.Rows.Count > 0)
            //    {
            //        double dongia = Convert.ToDouble(dtdinhmuc.Rows[0]["DinhMuc_KhongTang"].ToString());
            //        double dongia_Tang = Convert.ToDouble(dtdinhmuc.Rows[0]["DinhMuc_Tang"].ToString());
            //        int ID_DinhMuc_Luongxx = Convert.ToInt32(dtdinhmuc.Rows[0]["ID_DinhMuc_Luong"].ToString());

            //        DataRow _ravi = dt2.NewRow();
            //        clsvt.iID_VTHH = xxID_VTHH_Ra;
            //        DataTable dtvt_Ra = clsvt.SelectOne();
            //        string MaVT_Ra = clsvt.sMaVT.Value;
            //        string DonViTinh_Ra = clsvt.sDonViTinh.Value;
            //        string TenVatTu_Ra = clsvt.sTenVTHH.Value;
            //        _ravi["STT"] = k + 1;                    
            //        _ravi["ID_VTHH_Ra"] = xxID_VTHH_Ra;
            //        _ravi["MaVT"] = MaVT_Ra;
            //        _ravi["TenVTHH"] = TenVatTu_Ra;
            //        _ravi["DonViTinh"] = DonViTinh_Ra;
            //        _ravi["ID_DinhMuc_Luong"] = ID_DinhMuc_Luongxx;
            //        _ravi["SanLuong_Thuong"] = Convert.ToDouble(dttong.Rows[0]["SanLuong_Thuong"].ToString());
            //        _ravi["SanLuong_TangCa"] = Convert.ToDouble(dttong.Rows[0]["SanLuong_TangCa"].ToString());
            //        _ravi["DinhMuc_KhongTang"] = dongia;
            //        _ravi["DinhMuc_Tang"] = dongia_Tang;
            //        _ravi["ThanhTien"] = Convert.ToDouble(dttong.Rows[0]["ThanhTien"].ToString());

            //        dt2.Rows.Add(_ravi);

            //    }

            //}

            //gridControl1.DataSource = dt2;

        }
        public SanLuong_ChiTiet_Luong()
        {
            InitializeComponent();
            ds_grid = new List<GridColumn>();
            ds_grid.Add(Ngay1); ds_grid.Add(Ngay2); ds_grid.Add(Ngay3); ds_grid.Add(Ngay4); ds_grid.Add(Ngay5);
            ds_grid.Add(Ngay6); ds_grid.Add(Ngay7); ds_grid.Add(Ngay8); ds_grid.Add(Ngay9); ds_grid.Add(Ngay10);
            ds_grid.Add(Ngay11); ds_grid.Add(Ngay12); ds_grid.Add(Ngay13); ds_grid.Add(Ngay14); ds_grid.Add(Ngay15);
            ds_grid.Add(Ngay16); ds_grid.Add(Ngay17); ds_grid.Add(Ngay18); ds_grid.Add(Ngay19); ds_grid.Add(Ngay20);
            ds_grid.Add(Ngay21); ds_grid.Add(Ngay22); ds_grid.Add(Ngay23); ds_grid.Add(Ngay24); ds_grid.Add(Ngay25);
            ds_grid.Add(Ngay26); ds_grid.Add(Ngay27); ds_grid.Add(Ngay28); ds_grid.Add(Ngay29); ds_grid.Add(Ngay30);
            ds_grid.Add(Ngay31);
        }

        private void gridView2_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridCongNhan_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt32(gridCongNhan.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();

                txtHoTen.Text = clsncc.sTenNhanVien.Value;
                int xxID = Convert.ToInt32(gridCongNhan.EditValue.ToString());
                LoadData(xxID, dteTuNgay.DateTime, dteDenNgay.DateTime);

            }
            catch
            {

            }
        }

        private void SanLuong_ChiTiet_Luong_Load(object sender, EventArgs e)
        {
            LoadData_Thin();
            //Load_LockUp();
            //dteTuNgay.EditValue = SanLuong_To_DOT_DAP.mdatungay;
            //dteDenNgay.EditValue = SanLuong_To_DOT_DAP.mdadenngay;
            //gridCongNhan.EditValue = SanLuong_To_DOT_DAP.miID_VTHH_Ra;

            LoadData(SanLuong_To_DOT_DAP.miID_VTHH_Ra, SanLuong_To_DOT_DAP.mdatungay, SanLuong_To_DOT_DAP.mdadenngay);
        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            if (dteDenNgay.EditValue != null & dteTuNgay.EditValue != null)
            {
                int xxID = Convert.ToInt32(gridCongNhan.EditValue.ToString());
                LoadData(xxID, dteTuNgay.DateTime, dteDenNgay.DateTime);

            }
        }

        private void btRefesh_Click(object sender, EventArgs e)
        {
            SanLuong_ChiTiet_Luong_Load( sender,  e);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView3_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
           
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            //DataTable DatatableABC = (DataTable)gridControl1.DataSource;
            //CriteriaOperator op = gridView2.ActiveFilterCriteria; // filterControl1.FilterCriteria
            //string filterString = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(op);
            //DataView dv1212 = new DataView(DatatableABC);
            //dv1212.RowFilter = filterString;
            //mdtPrint = dv1212.ToTable();

            //if (mdtPrint.Rows.Count > 0)
            //{
            //    mbPrint = true;
            //    mdatungay = dteTuNgay.DateTime;
            //    mdadenngay = dteDenNgay.DateTime;
            //    miID_VThh = Convert.ToInt32(GridMaVT.EditValue.ToString());
            //    msMaVT = GridMaVT.Text.ToString();
            //    msTenVT = txtTenVTHH.Text;
            //    msDVT = txtDVT.Text;
            //    clsPhieu_ChiTietPhieu_New cls = new clsPhieu_ChiTietPhieu_New();
            //    DataTable dt3 = new DataTable();
                //if (xxximay_in_1_Cat_2_dot_3 == 1)
                //    dt3 = cls.Select_SUM_SanLuong_W_IDVTHH_NgayThang_IN(miID_VThh, mdatungay, mdadenngay);
                //else if (xxximay_in_1_Cat_2_dot_3 == 2)
                //    dt3 = cls.Select_SUM_SanLuong_W_IDVTHH_NgayThang_CAT(miID_VThh, mdatungay, mdadenngay);

                //sanluongthuowng = Convert.ToDouble(dt3.Rows[0]["SanLuong_Thuong"].ToString());
                //sanluongtangca = Convert.ToDouble(dt3.Rows[0]["SanLuong_TangCa"].ToString());
                //sanluongtong = Convert.ToDouble(dt3.Rows[0]["SanLuong_Tong"].ToString());
                //phepham = Convert.ToDouble(dt3.Rows[0]["PhePham"].ToString());
                //frmPrint_SanLuongToMayIn ff = new frmPrint_SanLuongToMayIn();
                //ff.Show();

            //}
        }
    }
}
