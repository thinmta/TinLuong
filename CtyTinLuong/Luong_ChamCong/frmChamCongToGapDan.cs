using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public void LoadData()
        {

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
            labelControl1.Text = "Bảng lương tháng: " + UCBangLuong.miiThang.ToString() + " năm " + UCBangLuong.miiNam.ToString() + "";

            clMaDinhMucLuongCongNhat.Caption = "ĐM\n Lương";
            clSLTangCa.Caption = "Tăng\nca";

            clSLThuong.Caption = "Ngày\nthường";
            Load_caption_gridControl();
            HienThi();
            mbBosungCongNhantrongthang = false;
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            #region
            if (gridView1.GetFocusedRowCellValue(clID_ChiTietChamCong).ToString() != "")
            {
                clsHUU_CongNhat_ChiTiet_ChamCong cls = new CtyTinLuong.clsHUU_CongNhat_ChiTiet_ChamCong();
                double ngay1 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay1).ToString());
                double ngay2 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay2).ToString());
                double ngay3 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay3).ToString());
                double ngay4 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay4).ToString());
                double ngay5 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay5).ToString());
                double ngay6 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay6).ToString());
                double ngay7 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay7).ToString());
                double ngay8 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay8).ToString());
                double ngay9 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay9).ToString());
                double ngay10 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay10).ToString());
                double ngay11 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay11).ToString());
                double ngay12 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay12).ToString());
                double ngay13 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn13).ToString());
                double ngay14 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn14).ToString());
                double ngay15 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn15).ToString());
                double ngay16 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn16).ToString());
                double ngay17 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn17).ToString());
                double ngay18 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn18).ToString());
                double ngay19 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn19).ToString());
                double ngay20 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn20).ToString());
                double ngay21 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn21).ToString());
                double ngay22 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn22).ToString());
                double ngay23 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn23).ToString());
                double ngay24 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn24).ToString());
                double ngay25 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn25).ToString());
                double ngay26 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn26).ToString());
                double ngay27 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay27).ToString());
                double ngay28 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay28).ToString());
                double ngay29 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn29).ToString());
                double ngay30 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn30).ToString());
                double ngay31 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn31).ToString());
                double tongcong = Convert.ToDouble(gridView1.GetFocusedRowCellValue(clTongCong).ToString());
                int ID_ChiTietChamCong = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clID_ChiTietChamCong).ToString());
                if (e.RowHandle % 2 == 0)
                {
                    cls.iID_ChiTietChamCong = ID_ChiTietChamCong;
                    cls.fSLThuong = tongcong;
                    cls.fNgay1 = ngay1;
                    cls.fNgay2 = ngay2;
                    cls.fNgay3 = ngay3;
                    cls.fNgay4 = ngay4;
                    cls.fNgay5 = ngay5;
                    cls.fNgay6 = ngay6;
                    cls.fNgay7 = ngay7;
                    cls.fNgay8 = ngay8;
                    cls.fNgay9 = ngay9;
                    cls.fNgay10 = ngay10;
                    cls.fNgay11 = ngay11;
                    cls.fNgay12 = ngay12;
                    cls.fNgay13 = ngay13;
                    cls.fNgay14 = ngay14;
                    cls.fNgay15 = ngay15;
                    cls.fNgay16 = ngay16;
                    cls.fNgay17 = ngay17;
                    cls.fNgay18 = ngay18;
                    cls.fNgay19 = ngay19;
                    cls.fNgay20 = ngay20;
                    cls.fNgay21 = ngay21;
                    cls.fNgay22 = ngay22;
                    cls.fNgay23 = ngay23;
                    cls.fNgay24 = ngay24;
                    cls.fNgay25 = ngay25;
                    cls.fNgay26 = ngay26;
                    cls.fNgay27 = ngay27;
                    cls.fNgay28 = ngay28;
                    cls.fNgay29 = ngay29;
                    cls.fNgay30 = ngay30;
                    cls.fNgay31 = ngay31;
                    cls.Update_CongNhat_SanLuongThuong();
                }
                else if (e.RowHandle % 2 == 1)
                {
                    cls.iID_ChiTietChamCong = ID_ChiTietChamCong;
                    cls.fSLTangCa = tongcong;
                    cls.fTCNgay1 = ngay1;
                    cls.fTCNgay2 = ngay2;
                    cls.fTCNgay3 = ngay3;
                    cls.fTCNgay4 = ngay4;
                    cls.fTCNgay5 = ngay5;
                    cls.fTCNgay6 = ngay6;
                    cls.fTCNgay7 = ngay7;
                    cls.fTCNgay8 = ngay8;
                    cls.fTCNgay9 = ngay9;
                    cls.fTCNgay10 = ngay10;
                    cls.fTCNgay11 = ngay11;
                    cls.fTCNgay12 = ngay12;
                    cls.fTCNgay13 = ngay13;
                    cls.fTCNgay14 = ngay14;
                    cls.fTCNgay15 = ngay15;
                    cls.fTCNgay16 = ngay16;
                    cls.fTCNgay17 = ngay17;
                    cls.fTCNgay18 = ngay18;
                    cls.fTCNgay19 = ngay19;
                    cls.fTCNgay20 = ngay20;
                    cls.fTCNgay21 = ngay21;
                    cls.fTCNgay22 = ngay22;
                    cls.fTCNgay23 = ngay23;
                    cls.fTCNgay24 = ngay24;
                    cls.fTCNgay25 = ngay25;
                    cls.fTCNgay26 = ngay26;
                    cls.fTCNgay27 = ngay27;
                    cls.fTCNgay28 = ngay28;
                    cls.fTCNgay29 = ngay29;
                    cls.fTCNgay30 = ngay30;
                    cls.fTCNgay31 = ngay31;
                    cls.Update_CongNhat_SanLuong_TangCa();
                }

            }
            #endregion
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            #region Tính tổng công làm việc

            double ngay1 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay1).ToString());
            double ngay2 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay2).ToString());
            double ngay3 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay3).ToString());
            double ngay4 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay4).ToString());
            double ngay5 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay5).ToString());
            double ngay6 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay6).ToString());
            double ngay7 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay7).ToString());
            double ngay8 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay8).ToString());
            double ngay9 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay9).ToString());
            double ngay10 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay10).ToString());
            double ngay11 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay11).ToString());
            double ngay12 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay12).ToString());
            double ngay13 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn13).ToString());
            double ngay14 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn14).ToString());
            double ngay15 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn15).ToString());
            double ngay16 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn16).ToString());
            double ngay17 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn17).ToString());
            double ngay18 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn18).ToString());
            double ngay19 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn19).ToString());
            double ngay20 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn20).ToString());
            double ngay21 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn21).ToString());
            double ngay22 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn22).ToString());
            double ngay23 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn23).ToString());
            double ngay24 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn24).ToString());
            double ngay25 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn25).ToString());
            double ngay26 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn26).ToString());
            double ngay27 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay27).ToString());
            double ngay28 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(Ngay28).ToString());
            double ngay29 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn29).ToString());
            double ngay30 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn30).ToString());
            double ngay31 = Convert.ToDouble(gridView1.GetFocusedRowCellValue(gridColumn31).ToString());

            double tongcong = ngay1 + ngay2 + ngay3 + ngay4 + ngay5 + ngay6 + ngay7 + ngay8 + ngay9 + ngay10
                + ngay11 + ngay12 + ngay13 + ngay14 + ngay15 + ngay16 + ngay17 + ngay18 + ngay19 + ngay20 +
             ngay21 + ngay22 + ngay23 + ngay24 + ngay25 + ngay26 + ngay27 + ngay28 + ngay29 + ngay30 + ngay31;


            if (e.Column == Ngay1)
            {

                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }

            }
            if (e.Column == Ngay2)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }

            }
            if (e.Column == Ngay3)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == Ngay4)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == Ngay5)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == Ngay6)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == Ngay7)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == Ngay8)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == Ngay9)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == Ngay10)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }

            if (e.Column == Ngay11)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == Ngay12)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == gridColumn13)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == gridColumn14)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == gridColumn15)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == gridColumn16)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == gridColumn17)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == gridColumn18)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == gridColumn19)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == gridColumn20)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == gridColumn21)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == gridColumn22)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == gridColumn23)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == gridColumn24)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == gridColumn25)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == gridColumn26)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == Ngay27)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == Ngay28)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == gridColumn29)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == gridColumn30)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            if (e.Column == gridColumn31)
            {
                gridView1.SetRowCellValue(e.RowHandle, clTongCong, tongcong);
                if (e.RowHandle % 2 == 0)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLThuong, tongcong);
                }
                else if (e.RowHandle % 2 == 1)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clSLTangCa, tongcong);
                }
            }
            #endregion            
        }

        public frmChamCongToGapDan()
        {
            InitializeComponent();
            txtNam.Text = DateTime.Now.Year.ToString();
            txtThang.Text = DateTime.Now.Month.ToString();
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
        }

        private void linkQuanLyMaHang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        private int _id_dinhmuc_togapdan;

        private void cbLoaiHangSX_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                        MessageBox.Show("Chưa cài đặt định mức! Vui lòng cài đặt định mức cho mã hàng này");
                    }
                    else
                    {

                    }
                }
                else
                {
                    txtDinhMuc.Text = "Chưa cài đặt định mức!";
                   MessageBox.Show("Chưa cài đặt định mức! Vui lòng cài đặt định mức cho mã hàng này");
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
