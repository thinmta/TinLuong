using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtyTinLuong
{
    public partial class frmChamCongToGapDan : Form
    {
        public static int miiID_chiTietChamCong, miiD_DinhMuc_Luong, miID_congNhan;
        public static int miiID_ChamCong;
        public static bool mbBosungCongNhantrongthang;
        public static DataTable mdataatbaleDanhSachChamCOng;
        public static int miThang, miNam;
        public static string msTenNhanVien;

        private int _nam, _thang, _id_bophan, _id_vthh;
        public string _tennhanvien = "",_ten_vthh;
        private DataTable _data;
        private bool isload = true; 
        public void LoadData(bool islandau)
        {
            isload = true;
            if (islandau)
            {
                txtNam.Text = DateTime.Now.Year.ToString();
                txtThang.Text = DateTime.Now.Month.ToString();
                txtTimKiem.Text = "";
                   
                using (clsThin clsThin_ = new clsThin())
                {
                    DataTable dt_ = clsThin_.T_NhanSu_tbBoPhan_SA();

                    cbBoPhan.DisplayMember = "TenBoPhan";
                    cbBoPhan.ValueMember = "ID_BoPhan";
                    cbBoPhan.DataSource = dt_;
                    cbBoPhan.SelectedValue = 18;
                    cbBoPhan.Enabled = true;


                    DataTable dt2_ = clsThin_.T_LoaiHangSX_SF(10);

                    cbLoaiHangSX.DisplayMember = "TenVTHH";
                    cbLoaiHangSX.ValueMember = "ID_VTHH";
                    cbLoaiHangSX.DataSource = dt2_;

                    cbLoaiHangSX.Enabled = true;

                }
                _id_vthh = (int)cbLoaiHangSX.SelectedValue;
                _id_bophan = (int)cbBoPhan.SelectedValue;
                _ten_vthh = (string)cbLoaiHangSX.Text;
            }
            else
            { 
            } 
            _nam = DateTime.Now.Year;
            _thang = DateTime.Now.Month;
            _tennhanvien = txtTimKiem.Text;

            using (clsThin clsThin_ = new clsThin())
            {
                _data = clsThin_.T_Huu_CongNhat_ChiTiet_ChamCong_ToGapDan_CaTruong_SO(_nam,_thang,_id_bophan,_id_vthh);
                int tong_tatca = 0;
                for (int i = 0; i < _data.Rows.Count; ++i)
                {
                    tong_tatca += Convert.ToInt32(_data.Rows[i]["Tong"].ToString());
                    _data.Rows[i]["ID_VTHH"] = _id_vthh;
                    _data.Rows[i]["TenVTHH"] = _ten_vthh;
                }
                //txttong
                /*
                if (dxcongnhat.Rows.Count > 0)
                {
                    repositoryItemGridLookUpEdit1.DataSource = dxcongnhat;
                    repositoryItemGridLookUpEdit1.ValueMember = "ID_DinhMucLuong_CongNhat";
                    repositoryItemGridLookUpEdit1.DisplayMember = "MaDinhMucLuongCongNhat";
                } 
                */  
            }
            gridControl1.DataSource = _data;
             
            isload = false;
        }
        private void HienThi()
        {
            clsHUU_DinhMucLuong_CongNhat clsluong = new clsHUU_DinhMucLuong_CongNhat();
            DataTable dtcongnhat = clsluong.SelectAll();
            dtcongnhat.DefaultView.RowFilter = " TonTai=True and NgungTheoDoi=false";
            DataView dvcongnhat = dtcongnhat.DefaultView;
            DataTable dxcongnhat = dvcongnhat.ToTable();

            if (dxcongnhat.Rows.Count > 0)
            {
                repositoryItemGridLookUpEdit1.DataSource = dxcongnhat;
                repositoryItemGridLookUpEdit1.ValueMember = "ID_DinhMucLuong_CongNhat";
                repositoryItemGridLookUpEdit1.DisplayMember = "MaDinhMucLuongCongNhat";
            }
            DataTable dt2 = new DataTable();

           
            dt2.Columns.Add("TenNhanVien", typeof(string));
            dt2.Columns.Add("NoiDung", typeof(string));
            dt2.Columns.Add("TongCong", typeof(double));

            dt2.Columns.Add("ID_ChiTietChamCong", typeof(int));
            dt2.Columns.Add("ID_ChamCong", typeof(int));
            dt2.Columns.Add("ID_CongNhan", typeof(int));
            dt2.Columns.Add("ID_DinhMucLuong_CongNhat", typeof(int));
            dt2.Columns.Add("SLThuong", typeof(double));
            dt2.Columns.Add("SLTangCa", typeof(double));
            // dt2.Columns.Add("TongLuong", typeof(string));
            dt2.Columns.Add("Thang", typeof(string));
            dt2.Columns.Add("Nam", typeof(string));
            dt2.Columns.Add("GuiDuLieu", typeof(bool));

            dt2.Columns.Add("Ngay1", typeof(double));
            dt2.Columns.Add("Ngay2", typeof(double));
            dt2.Columns.Add("Ngay3", typeof(double));
            dt2.Columns.Add("Ngay4", typeof(double));
            dt2.Columns.Add("Ngay5", typeof(double));
            dt2.Columns.Add("Ngay6", typeof(double));
            dt2.Columns.Add("Ngay7", typeof(double));
            dt2.Columns.Add("Ngay8", typeof(double));
            dt2.Columns.Add("Ngay9", typeof(double));
            dt2.Columns.Add("Ngay10", typeof(double));
            dt2.Columns.Add("Ngay11", typeof(double));
            dt2.Columns.Add("Ngay12", typeof(double));
            dt2.Columns.Add("Ngay13", typeof(double));
            dt2.Columns.Add("Ngay14", typeof(double));
            dt2.Columns.Add("Ngay15", typeof(double));
            dt2.Columns.Add("Ngay16", typeof(double));
            dt2.Columns.Add("Ngay17", typeof(double));
            dt2.Columns.Add("Ngay18", typeof(double));
            dt2.Columns.Add("Ngay19", typeof(double));
            dt2.Columns.Add("Ngay20", typeof(double));
            dt2.Columns.Add("Ngay21", typeof(double));
            dt2.Columns.Add("Ngay22", typeof(double));
            dt2.Columns.Add("Ngay23", typeof(double));
            dt2.Columns.Add("Ngay24", typeof(double));
            dt2.Columns.Add("Ngay25", typeof(double));
            dt2.Columns.Add("Ngay26", typeof(double));
            dt2.Columns.Add("Ngay27", typeof(double));
            dt2.Columns.Add("Ngay28", typeof(double));
            dt2.Columns.Add("Ngay29", typeof(double));
            dt2.Columns.Add("Ngay30", typeof(double));
            dt2.Columns.Add("Ngay31", typeof(double));


            dt2.Columns.Add("HienThi", typeof(string));

            clsHUU_CongNhat_ChiTiet_ChamCong cls = new clsHUU_CongNhat_ChiTiet_ChamCong();
            cls.iID_ChamCong = UCBangLuong.mID_iD_ChamCong;

            DataTable dt3xxx = cls.SelectAll_HienThi_ALL_ChiTiet_TheoThang();
            dt3xxx.DefaultView.RowFilter = " Check_ChamCongGapDan= True";
            DataView dvkf3232 = dt3xxx.DefaultView;

            DataTable dt3 = dvkf3232.ToTable();
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                int ID_CongNhanxx = Convert.ToInt32(dt3.Rows[i]["ID_CongNhan"].ToString());
                int ithangxxx = UCBangLuong.miiThang;
                int inamxxx = UCBangLuong.miiNam;
                clsHuu_CongNhat_ChiTiet_ChamCong_ToGapDan clsmahang = new clsHuu_CongNhat_ChiTiet_ChamCong_ToGapDan();
                clsmahang.iID_CongNhan=ID_CongNhanxx;
                clsmahang.iThang=ithangxxx;
                clsmahang.iNam=inamxxx;
                DataTable dtmahang = clsmahang.SelectAll_W_Thang_W_Nam_W_ID_CongNhan();
                if (dtmahang.Rows.Count > 0)
                {
                   

                    for (int j = 0; j < dtmahang.Rows.Count; j++)
                    {
                        DataRow _ravi_hang1 = dt2.NewRow();
                       
                        _ravi_hang1["TenNhanVien"] = dt3.Rows[i]["TenNhanVien"].ToString();
                        _ravi_hang1["NoiDung"] = dtmahang.Rows[j]["MaVT"].ToString();
                        _ravi_hang1["TongCong"] = Convert.ToDouble(dt3.Rows[i]["SLThuong"].ToString());

                        _ravi_hang1["ID_ChiTietChamCong"] = Convert.ToInt32(dt3.Rows[i]["ID_ChiTietChamCong"].ToString());
                        _ravi_hang1["ID_ChamCong"] = Convert.ToInt32(dt3.Rows[i]["ID_ChamCong"].ToString());
                        _ravi_hang1["ID_CongNhan"] = Convert.ToInt32(dt3.Rows[i]["ID_CongNhan"].ToString());
                        _ravi_hang1["ID_DinhMucLuong_CongNhat"] = dt3.Rows[i]["ID_DinhMucLuong_CongNhat"].ToString();
                        _ravi_hang1["Thang"] = Convert.ToInt32(dt3.Rows[i]["Thang"].ToString());
                        _ravi_hang1["Nam"] = Convert.ToInt32(dt3.Rows[i]["Nam"].ToString());
                        _ravi_hang1["SLThuong"] = Convert.ToDouble(dt3.Rows[i]["SLThuong"].ToString());
                        _ravi_hang1["SLTangCa"] = Convert.ToDouble(dt3.Rows[i]["SLTangCa"].ToString());

                        _ravi_hang1["GuiDuLieu"] = Convert.ToBoolean(dt3.Rows[i]["GuiDuLieu"].ToString());

                        _ravi_hang1["Ngay1"] = Convert.ToDouble(dt3.Rows[i]["Ngay1"].ToString());
                        _ravi_hang1["Ngay2"] = Convert.ToDouble(dt3.Rows[i]["Ngay2"].ToString());
                        _ravi_hang1["Ngay3"] = Convert.ToDouble(dt3.Rows[i]["Ngay3"].ToString());
                        _ravi_hang1["Ngay4"] = Convert.ToDouble(dt3.Rows[i]["Ngay4"].ToString());
                        _ravi_hang1["Ngay5"] = Convert.ToDouble(dt3.Rows[i]["Ngay5"].ToString());
                        _ravi_hang1["Ngay6"] = Convert.ToDouble(dt3.Rows[i]["Ngay6"].ToString());
                        _ravi_hang1["Ngay7"] = Convert.ToDouble(dt3.Rows[i]["Ngay7"].ToString());
                        _ravi_hang1["Ngay8"] = Convert.ToDouble(dt3.Rows[i]["Ngay8"].ToString());
                        _ravi_hang1["Ngay9"] = Convert.ToDouble(dt3.Rows[i]["Ngay9"].ToString());
                        _ravi_hang1["Ngay10"] = Convert.ToDouble(dt3.Rows[i]["Ngay10"].ToString());

                        _ravi_hang1["Ngay11"] = Convert.ToDouble(dt3.Rows[i]["Ngay11"].ToString());
                        _ravi_hang1["Ngay12"] = Convert.ToDouble(dt3.Rows[i]["Ngay12"].ToString());
                        _ravi_hang1["Ngay13"] = Convert.ToDouble(dt3.Rows[i]["Ngay13"].ToString());
                        _ravi_hang1["Ngay14"] = Convert.ToDouble(dt3.Rows[i]["Ngay14"].ToString());
                        _ravi_hang1["Ngay15"] = Convert.ToDouble(dt3.Rows[i]["Ngay15"].ToString());
                        _ravi_hang1["Ngay16"] = Convert.ToDouble(dt3.Rows[i]["Ngay16"].ToString());
                        _ravi_hang1["Ngay17"] = Convert.ToDouble(dt3.Rows[i]["Ngay17"].ToString());
                        _ravi_hang1["Ngay18"] = Convert.ToDouble(dt3.Rows[i]["Ngay18"].ToString());
                        _ravi_hang1["Ngay19"] = Convert.ToDouble(dt3.Rows[i]["Ngay19"].ToString());

                        _ravi_hang1["Ngay20"] = Convert.ToDouble(dt3.Rows[i]["Ngay20"].ToString());
                        _ravi_hang1["Ngay21"] = Convert.ToDouble(dt3.Rows[i]["Ngay21"].ToString());
                        _ravi_hang1["Ngay22"] = Convert.ToDouble(dt3.Rows[i]["Ngay22"].ToString());
                        _ravi_hang1["Ngay23"] = Convert.ToDouble(dt3.Rows[i]["Ngay23"].ToString());
                        _ravi_hang1["Ngay24"] = Convert.ToDouble(dt3.Rows[i]["Ngay24"].ToString());
                        _ravi_hang1["Ngay25"] = Convert.ToDouble(dt3.Rows[i]["Ngay25"].ToString());
                        _ravi_hang1["Ngay26"] = Convert.ToDouble(dt3.Rows[i]["Ngay26"].ToString());
                        _ravi_hang1["Ngay27"] = Convert.ToDouble(dt3.Rows[i]["Ngay27"].ToString());
                        _ravi_hang1["Ngay28"] = Convert.ToDouble(dt3.Rows[i]["Ngay28"].ToString());
                        _ravi_hang1["Ngay29"] = Convert.ToDouble(dt3.Rows[i]["Ngay29"].ToString());
                        _ravi_hang1["Ngay30"] = Convert.ToDouble(dt3.Rows[i]["Ngay30"].ToString());
                        _ravi_hang1["Ngay31"] = Convert.ToDouble(dt3.Rows[i]["Ngay31"].ToString());
                        _ravi_hang1["HienThi"] = "1";
                        dt2.Rows.Add(_ravi_hang1);
                    }
                    
                }
              

             

            }
            gridControl1.DataSource = dt2;

            clsHuu_CongNhat clsxx = new clsHuu_CongNhat();
            clsxx.iID_ChamCong = UCBangLuong.mID_iD_ChamCong;
            DataTable dtxx = clsxx.SelectOne();
            if (Convert.ToBoolean(dtxx.Rows[0]["GuiDuLieu"].ToString()) == true)
            {
                btGuiDuLieu.Enabled = false;
              
                Ngay1.OptionsColumn.AllowEdit = Ngay2.OptionsColumn.AllowEdit =
                    Ngay3.OptionsColumn.AllowEdit = Ngay4.OptionsColumn.AllowEdit =
                    Ngay5.OptionsColumn.AllowEdit = Ngay6.OptionsColumn.AllowEdit =
                    Ngay7.OptionsColumn.AllowEdit = Ngay8.OptionsColumn.AllowEdit =
                    Ngay9.OptionsColumn.AllowEdit = Ngay10.OptionsColumn.AllowEdit =
                    Ngay11.OptionsColumn.AllowEdit = Ngay12.OptionsColumn.AllowEdit =
                    gridColumn13.OptionsColumn.AllowEdit = gridColumn14.OptionsColumn.AllowEdit =
                    gridColumn15.OptionsColumn.AllowEdit = gridColumn16.OptionsColumn.AllowEdit =
                    gridColumn17.OptionsColumn.AllowEdit = gridColumn18.OptionsColumn.AllowEdit =
                    gridColumn19.OptionsColumn.AllowEdit = gridColumn20.OptionsColumn.AllowEdit =
                    gridColumn21.OptionsColumn.AllowEdit = gridColumn22.OptionsColumn.AllowEdit =
                    gridColumn23.OptionsColumn.AllowEdit = gridColumn24.OptionsColumn.AllowEdit =
                    gridColumn25.OptionsColumn.AllowEdit = gridColumn26.OptionsColumn.AllowEdit =
                    Ngay27.OptionsColumn.AllowEdit = Ngay28.OptionsColumn.AllowEdit =
                    gridColumn29.OptionsColumn.AllowEdit = gridColumn30.OptionsColumn.AllowEdit =
                    gridColumn31.OptionsColumn.AllowEdit = false;
                clSLTangCa.OptionsColumn.AllowEdit = false;

            }
        }
        private string thutrongtuanxyz(int ewwd)
        {

            string xxx = "";
            if (ewwd == 0)
                xxx = "Thứ 7";
            else if (ewwd.ToString() == "1")
                xxx = "Chủ nhật ";
            else xxx = "Thứ " + ewwd.ToString() + "";
            return xxx;
        }
        private void Load_caption_gridControl()
        {
            int ithang = UCBangLuong.miiThang;
            int inam = UCBangLuong.miiNam;
            int days = DateTime.DaysInMonth(inam, ithang);

            DateTime ngaydautien = new DateTime(inam, ithang, 1);
            int intday;
            intday = (int)ngaydautien.DayOfWeek;
            string thutrongtuan = "";

            thutrongtuan = thutrongtuanxyz(intday);
            Ngay1.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            Ngay2.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";


            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            Ngay3.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            Ngay4.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            Ngay5.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            Ngay6.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            Ngay7.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            Ngay8.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            Ngay9.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            Ngay10.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            Ngay11.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            Ngay12.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            gridColumn13.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            gridColumn14.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            gridColumn15.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            gridColumn16.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            gridColumn17.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            gridColumn18.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            gridColumn19.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            gridColumn20.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            gridColumn21.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            gridColumn22.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            gridColumn23.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            gridColumn24.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            gridColumn25.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            gridColumn26.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            Ngay27.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            ngaydautien = ngaydautien.AddDays(1);
            intday = (int)ngaydautien.DayOfWeek;
            thutrongtuan = thutrongtuanxyz(intday);
            Ngay28.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

            if (days == 28)
            {
                gridColumn29.Visible = false;
                gridColumn30.Visible = false;
                gridColumn31.Visible = false;
            }
            else if (days == 29)
            {
                ngaydautien = ngaydautien.AddDays(1);
                intday = (int)ngaydautien.DayOfWeek;
                thutrongtuan = thutrongtuanxyz(intday);
                gridColumn29.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";
                gridColumn30.Visible = false;
                gridColumn31.Visible = false;
            }
            else if (days == 30)
            {
                ngaydautien = ngaydautien.AddDays(1);
                intday = (int)ngaydautien.DayOfWeek;
                thutrongtuan = thutrongtuanxyz(intday);
                gridColumn29.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

                ngaydautien = ngaydautien.AddDays(1);
                intday = (int)ngaydautien.DayOfWeek;
                thutrongtuan = thutrongtuanxyz(intday);
                gridColumn30.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

                gridColumn31.Visible = false;
            }
            else if (days == 31)
            {
                ngaydautien = ngaydautien.AddDays(1);
                intday = (int)ngaydautien.DayOfWeek;
                thutrongtuan = thutrongtuanxyz(intday);
                gridColumn29.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

                ngaydautien = ngaydautien.AddDays(1);
                intday = (int)ngaydautien.DayOfWeek;
                thutrongtuan = thutrongtuanxyz(intday);
                gridColumn30.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";

                ngaydautien = ngaydautien.AddDays(1);
                intday = (int)ngaydautien.DayOfWeek;
                thutrongtuan = thutrongtuanxyz(intday);
                gridColumn31.Caption = "" + ngaydautien.ToString("dd/MM/yyyy") + "\n " + thutrongtuan + "";
            }


        }

        private void frmChamCongToGapDan_Load(object sender, EventArgs e)
        { 
        }
         
        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int index_ = e.RowHandle;
            string name_ = e.Column.FieldName;
            if (name_.Contains("Ngay"))
            {
                _data.Rows[index_][name_] = gridView1.GetFocusedRowCellValue(name_);
                if (_data.Rows.Count > index_)
                {
                    _data.Rows[index_]["Tong"] =
                    Convert.ToInt32(_data.Rows[index_][name_].ToString())
                    + Convert.ToInt32(_data.Rows[index_]["Tong"].ToString());
                }
            }
           // gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong); 
        }

        public frmChamCongToGapDan()
        {
            InitializeComponent();
        }

        private void linkQuanLyMaHang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (isload)
                return;
            if (e.KeyChar == (char)13)
            {
                HoanThanhThang();
            }
        }

        private void txtThang_Leave(object sender, EventArgs e)
        {
            if (isload)
                return;

            HoanThanhThang();
        }
        private void HoanThanhThang()
        {
            try
            {
                _thang = Convert.ToInt32(txtThang.Text);
                LoadData(false);
            }
            catch {
                MessageBox.Show("Tháng không hợp lệ");
            }
        }
        private void HoanThanhNam()
        {
            try
            {
                _nam = Convert.ToInt32(txtNam.Text);
                LoadData(false);
            }
            catch
            {
                MessageBox.Show("Tháng không hợp lệ");
            }
        }

        private void txtNam_Leave(object sender, EventArgs e)
        {
            if (isload)
                return;

            HoanThanhNam();
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isload)
                return;
            if (e.KeyChar == (char)13)
            {
                HoanThanhNam();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        { 
            if (isload)
                return;

            _tennhanvien = txtTimKiem.Text;
            LoadData(false);
        }

        private int _id_dinhmuc_togapdan;

        private void cbLoaiHangSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isload)
                return;
            txtDinhMuc.ForeColor = Color.Black;
            _id_vthh = cbLoaiHangSX.SelectedIndex;
            _ten_vthh = cbLoaiHangSX.Text;
            using (clsThin clsThin_ = new clsThin())
            {
                int nam_, thang_;
                try {
                    thang_ = Convert.ToInt32(txtThang.Text);
                }
                catch {
                    MessageBox.Show("Tháng không hợp lệ");
                    return;
                }
                try
                {
                    nam_ = Convert.ToInt32(txtNam.Text);
                }
                catch
                {
                    MessageBox.Show("Năm không hợp lệ");
                    return;
                }
                int id_vthh_ = cbLoaiHangSX.SelectedIndex;
                DataTable dt_ = clsThin_.T_DinhMuc_DinhMuc_Luong_TheoSanLuong_SO(id_vthh_, thang_, nam_);
                 
                if (dt_ != null && dt_.Rows.Count > 0)
                {
                    _id_dinhmuc_togapdan = Convert.ToInt32(dt_.Rows[0]["ID_DinhMuc_Luong_SanLuong"]);
                    float dinhmuc_ = ConvertToFloat(dt_.Rows[0]["DinhMuc_KhongTang"].ToString());
                    txtDinhMuc.Text = dt_.Rows[0]["MaDinhMuc"] + " (" + dinhmuc_.ToString("N0") + ")";
                    if (_id_dinhmuc_togapdan == 0)
                    {
                        txtDinhMuc.Text = "Chưa cài đặt định mức!";
                        txtDinhMuc.ForeColor = Color.Red; 
                    }
                    else
                    {

                    }
                } 
                else
                {
                    txtDinhMuc.Text = "Chưa cài đặt định mức!";
                    txtDinhMuc.ForeColor = Color.Red;
                    _id_dinhmuc_togapdan = 0;
                }
                //
                /*
                 
                for (int i = 0; i < _Ds_ChamCong_ToGapDan_model.Count; ++i)
                {
                    _Ds_ChamCong_ToGapDan_model[i].ID_DinhMuc_Luong_SanLuong = _id_dinhmuc_togapdan;
                    _Ds_ChamCong_ToGapDan_model[i].ID_VTHH = _ID_VTHH;
                    _Ds_ChamCong_ToGapDan_model[i].MaVT = _MaVT;
                    _Ds_ChamCong_ToGapDan_model[i].TenVTHH = _TenVTHH;
                }
                lst_Bill.ItemsSource = _Ds_ChamCong_ToGapDan_model;
                */
            }
            LoadData(false);
        }
        private float ConvertToFloat(string s)
        {
            char systemSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
            double result = 0;
            try
            {
                if (s != null)
                    if (!s.Contains(","))
                        result = double.Parse(s, CultureInfo.InvariantCulture);
                    else
                        result = Convert.ToDouble(s.Replace(".", systemSeparator.ToString()).Replace(",", systemSeparator.ToString()));
            }
            catch (Exception e)
            {
                try
                {
                    result = Convert.ToDouble(s);
                }
                catch
                {
                    try
                    {
                        result = Convert.ToDouble(s.Replace(",", ";").Replace(".", ",").Replace(";", "."));
                    }
                    catch
                    {
                        throw new Exception("Wrong string-to-double format");
                    }
                }
            }
            return (float)result;
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(clID_ChiTietChamCong).ToString() != "")
            {
                miiID_chiTietChamCong = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clID_ChiTietChamCong).ToString());
                miiD_DinhMuc_Luong = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clID_DinhMucLuong_CongNhat).ToString());
                miID_congNhan = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clID_CongNhan).ToString());
                miThang = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clThang).ToString());
                miNam = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clNam).ToString());
                msTenNhanVien = gridView1.GetFocusedRowCellValue(clTenNhanVien).ToString();
                frmMaHang_ChamCong_ToGapDan ff = new frmMaHang_ChamCong_ToGapDan();
                ff.Show();
            }

           
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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
    }
}
