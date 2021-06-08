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
        public void LoadData_Thin(bool islandau)
        {
            isload = true;
            if (islandau)
            {
                DateTime dtnow = DateTime.Now;
                txtNam.Text = dtnow.Year.ToString();
                txtThang.Text = dtnow.Month.ToString();
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

                using (clsThin clsThin_ = new clsThin())
                {
                    DataTable dt_ = clsThin_.T_NhanSu_tbBoPhan_SA();

                    cbBoPhan.DisplayMember = "TenBoPhan";
                    cbBoPhan.ValueMember = "ID_BoPhan";
                    cbBoPhan.DataSource = dt_;
                    cbBoPhan.SelectedValue = 18;
                    cbBoPhan.Enabled = true;


                    _dataLoaiHang = clsThin_.T_LoaiHangSX_SF(-1);

                    DataRow row = _dataLoaiHang.NewRow();
                    row["ID_VTHH"] = 0;
                    row["TenVTHH"] = "-->Tất cả";
                    _dataLoaiHang.Rows.InsertAt(row, 0);
                    cbLoaiHangSX.DataSource = _dataLoaiHang;
                    cbLoaiHangSX.DisplayMember = "TenVTHH";
                    cbLoaiHangSX.ValueMember = "ID_VTHH";
                    cbLoaiHangSX.Enabled = true;

                    _id_dinhmuc_togapdan = 0;
                    txtDinhMuc.Text = "";

                    try
                    {
                        _id_vthh = (int)cbLoaiHangSX.SelectedValue;
                        _id_bophan = (int)cbBoPhan.SelectedValue;
                        if (_id_vthh == 0)
                        {
                            _ten_vthh = "";
                        }
                        else
                        {
                            _ten_vthh = cbLoaiHangSX.Text;
                        }
                    }
                    catch { }
                }
            }
            else
            {
            }
            _nam = DateTime.Now.Year;
            _thang = DateTime.Now.Month;

            using (clsThin clsThin_ = new clsThin())
            {
                _data = clsThin_.T_Huu_CongNhat_ChiTiet_ChamCong_ToGapDan_CaTruong_SO(_nam, _thang, _id_bophan, _id_vthh, "");
                ds_id_congnhan = new List<int>();

                int Ngay1 = 0;
                int Ngay2 = 0;
                int Ngay3 = 0;
                int Ngay4 = 0;
                int Ngay5 = 0;
                int Ngay6 = 0;
                int Ngay7 = 0;
                int Ngay8 = 0;
                int Ngay9 = 0;
                int Ngay10 = 0;
                int Ngay11 = 0;
                int Ngay12 = 0;
                int Ngay13 = 0;
                int Ngay14 = 0;
                int Ngay15 = 0;
                int Ngay16 = 0;
                int Ngay17 = 0;
                int Ngay18 = 0;
                int Ngay19 = 0;
                int Ngay20 = 0;
                int Ngay21 = 0;
                int Ngay22 = 0;
                int Ngay23 = 0;
                int Ngay24 = 0;
                int Ngay25 = 0;
                int Ngay26 = 0;
                int Ngay27 = 0;
                int Ngay28 = 0;
                int Ngay29 = 0;
                int Ngay30 = 0;
                int Ngay31 = 0;

                for (int i = 0; i < _data.Rows.Count; ++i)
                {
                    ds_id_congnhan.Add(Convert.ToInt32(_data.Rows[i]["ID_NhanSu"].ToString()));

                    if (_id_vthh == 0)
                    {
                        int id_vthh_ = Convert.ToInt32(_data.Rows[i]["ID_VTHH"].ToString());
                        _data.Rows[i]["ID_VTHH"] = id_vthh_;
                        _data.Rows[i]["TenVTHH"] = _data.Rows[i]["TenVTHH"].ToString();
                        //
                    }
                    else
                    {
                        _data.Rows[i]["ID_VTHH"] = _id_vthh;
                        _data.Rows[i]["TenVTHH"] = _id_vthh;
                    }
                    Ngay1 = Convert.ToInt32(_data.Rows[i]["Ngay1"].ToString());
                    Ngay2 = Convert.ToInt32(_data.Rows[i]["Ngay2"].ToString());
                    Ngay3 = Convert.ToInt32(_data.Rows[i]["Ngay3"].ToString());
                    Ngay4 = Convert.ToInt32(_data.Rows[i]["Ngay4"].ToString());
                    Ngay5 = Convert.ToInt32(_data.Rows[i]["Ngay5"].ToString());
                    Ngay6 = Convert.ToInt32(_data.Rows[i]["Ngay6"].ToString());
                    Ngay7 = Convert.ToInt32(_data.Rows[i]["Ngay7"].ToString());
                    Ngay8 = Convert.ToInt32(_data.Rows[i]["Ngay8"].ToString());
                    Ngay9 = Convert.ToInt32(_data.Rows[i]["Ngay9"].ToString());
                    Ngay10 = Convert.ToInt32(_data.Rows[i]["Ngay10"].ToString());
                    Ngay11 = Convert.ToInt32(_data.Rows[i]["Ngay11"].ToString());
                    Ngay12 = Convert.ToInt32(_data.Rows[i]["Ngay12"].ToString());
                    Ngay13 = Convert.ToInt32(_data.Rows[i]["Ngay13"].ToString());
                    Ngay14 = Convert.ToInt32(_data.Rows[i]["Ngay14"].ToString());
                    Ngay15 = Convert.ToInt32(_data.Rows[i]["Ngay15"].ToString());
                    Ngay16 = Convert.ToInt32(_data.Rows[i]["Ngay16"].ToString());
                    Ngay17 = Convert.ToInt32(_data.Rows[i]["Ngay17"].ToString());
                    Ngay18 = Convert.ToInt32(_data.Rows[i]["Ngay18"].ToString());
                    Ngay19 = Convert.ToInt32(_data.Rows[i]["Ngay19"].ToString());
                    Ngay20 = Convert.ToInt32(_data.Rows[i]["Ngay20"].ToString());
                    Ngay21 = Convert.ToInt32(_data.Rows[i]["Ngay21"].ToString());
                    Ngay22 = Convert.ToInt32(_data.Rows[i]["Ngay22"].ToString());
                    Ngay23 = Convert.ToInt32(_data.Rows[i]["Ngay23"].ToString());
                    Ngay24 = Convert.ToInt32(_data.Rows[i]["Ngay24"].ToString());
                    Ngay25 = Convert.ToInt32(_data.Rows[i]["Ngay25"].ToString());
                    Ngay26 = Convert.ToInt32(_data.Rows[i]["Ngay26"].ToString());
                    Ngay27 = Convert.ToInt32(_data.Rows[i]["Ngay27"].ToString());
                    Ngay28 = Convert.ToInt32(_data.Rows[i]["Ngay28"].ToString());
                    Ngay29 = Convert.ToInt32(_data.Rows[i]["Ngay29"].ToString());
                    Ngay30 = Convert.ToInt32(_data.Rows[i]["Ngay30"].ToString());
                    Ngay31 = Convert.ToInt32(_data.Rows[i]["Ngay31"].ToString());
                    //
                    _data.Rows[i]["Ngay1"] = Ngay1.ToString("N0");
                    _data.Rows[i]["Ngay2"] = Ngay2.ToString("N0");
                    _data.Rows[i]["Ngay3"] = Ngay3.ToString("N0");
                    _data.Rows[i]["Ngay4"] = Ngay4.ToString("N0");
                    _data.Rows[i]["Ngay5"] = Ngay5.ToString("N0");
                    _data.Rows[i]["Ngay6"] = Ngay6.ToString("N0");
                    _data.Rows[i]["Ngay7"] = Ngay7.ToString("N0");
                    _data.Rows[i]["Ngay8"] = Ngay8.ToString("N0");
                    _data.Rows[i]["Ngay9"] = Ngay9.ToString("N0");
                    _data.Rows[i]["Ngay10"] = Ngay10.ToString("N0");
                    _data.Rows[i]["Ngay11"] = Ngay11.ToString("N0");
                    _data.Rows[i]["Ngay12"] = Ngay12.ToString("N0");
                    _data.Rows[i]["Ngay13"] = Ngay13.ToString("N0");
                    _data.Rows[i]["Ngay14"] = Ngay14.ToString("N0");
                    _data.Rows[i]["Ngay15"] = Ngay15.ToString("N0");
                    _data.Rows[i]["Ngay16"] = Ngay16.ToString("N0");
                    _data.Rows[i]["Ngay17"] = Ngay17.ToString("N0");
                    _data.Rows[i]["Ngay18"] = Ngay18.ToString("N0");
                    _data.Rows[i]["Ngay19"] = Ngay19.ToString("N0");
                    _data.Rows[i]["Ngay20"] = Ngay20.ToString("N0");
                    _data.Rows[i]["Ngay21"] = Ngay21.ToString("N0");
                    _data.Rows[i]["Ngay22"] = Ngay22.ToString("N0");
                    _data.Rows[i]["Ngay23"] = Ngay23.ToString("N0");
                    _data.Rows[i]["Ngay24"] = Ngay24.ToString("N0");
                    _data.Rows[i]["Ngay25"] = Ngay25.ToString("N0");
                    _data.Rows[i]["Ngay26"] = Ngay26.ToString("N0");
                    _data.Rows[i]["Ngay27"] = Ngay27.ToString("N0");
                    _data.Rows[i]["Ngay28"] = Ngay28.ToString("N0");
                    _data.Rows[i]["Ngay29"] = Ngay29.ToString("N0");
                    _data.Rows[i]["Ngay30"] = Ngay30.ToString("N0");
                    _data.Rows[i]["Ngay31"] = Ngay31.ToString("N0");

                    Tong_Ngay1 += Ngay1;
                    Tong_Ngay2 += Ngay2;
                    Tong_Ngay3 += Ngay3;
                    Tong_Ngay4 += Ngay4;
                    Tong_Ngay5 += Ngay5;
                    Tong_Ngay6 += Ngay6;
                    Tong_Ngay7 += Ngay7;
                    Tong_Ngay8 += Ngay8;
                    Tong_Ngay9 += Ngay9;
                    Tong_Ngay10 += Ngay10;
                    Tong_Ngay11 += Ngay11;
                    Tong_Ngay12 += Ngay12;
                    Tong_Ngay13 += Ngay13;
                    Tong_Ngay14 += Ngay14;
                    Tong_Ngay15 += Ngay15;
                    Tong_Ngay16 += Ngay16;
                    Tong_Ngay17 += Ngay17;
                    Tong_Ngay18 += Ngay18;
                    Tong_Ngay19 += Ngay19;
                    Tong_Ngay20 += Ngay20;
                    Tong_Ngay21 += Ngay21;
                    Tong_Ngay22 += Ngay22;
                    Tong_Ngay23 += Ngay23;
                    Tong_Ngay24 += Ngay24;
                    Tong_Ngay25 += Ngay25;
                    Tong_Ngay26 += Ngay26;
                    Tong_Ngay27 += Ngay27;
                    Tong_Ngay28 += Ngay28;
                    Tong_Ngay29 += Ngay29;
                    Tong_Ngay30 += Ngay30;
                    Tong_Ngay31 += Ngay31;
                }
            }
            LoadCongNhanVaoBang(_id_bophan);

            isload = false;
        }
        private void LoadData(int ID_CongNhanxxx, DateTime xxtungay, DateTime xxdenngay)
        {
            gridControl1.DataSource = null;


            DataTable dt2 = new DataTable();
            dt2 = new DataTable();
            dt2.Columns.Add("STT", typeof(string));           
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
          
            DataTable dtxxxx = new DataTable();
            dtxxxx = cls.SelectAll_distinct_ID_VTHH_Ra_W_NgayThang_CongNhan(ID_CongNhanxxx, xxtungay, xxdenngay);

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
                    _ravi["STT"] = k + 1;                    
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

            gridControl1.DataSource = dt2;

        }
        public SanLuong_ChiTiet_Luong()
        {
            InitializeComponent();
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
            Load_LockUp();
            dteTuNgay.EditValue = SanLuong_To_DOT_DAP.mdatungay;
            dteDenNgay.EditValue = SanLuong_To_DOT_DAP.mdadenngay;
            gridCongNhan.EditValue = SanLuong_To_DOT_DAP.miID_VTHH_Ra;

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
