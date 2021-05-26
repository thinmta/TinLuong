﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace CtyTinLuong
{
    public partial class UC_SanXuat_PhieuSanXuat : UserControl
    {
        public static int mID_iD_SoPhieu;
        public static bool mb_ThemMoi_SoPhieu, mb_Sua_SoPhieu, mbCopy_Phieu;
        public static string msTenSoPhieu;
       
        public static DateTime madaNgayPhieu;
        private void HienThi_ALL()
        {
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_SoPhieu", typeof(int));
            dt2.Columns.Add("MaPhieu", typeof(string));
            dt2.Columns.Add("NgayLapPhieu", typeof(DateTime));
            dt2.Columns.Add("GhiChu", typeof(string));
            dt2.Columns.Add("GuiDuLieu", typeof(bool));
            dt2.Columns.Add("ID_CaTruong", typeof(int));
            dt2.Columns.Add("DaKetThuc", typeof(bool));
            dt2.Columns.Add("TenNhanVien", typeof(string));
            dt2.Columns.Add("MaHang", typeof(string));
            dt2.Columns.Add("CaSanXuat", typeof(string));
            clsPhieu_tbPhieu cls = new clsPhieu_tbPhieu();
            DataTable dt = cls.SelectAll_W_TenCaTruong();
            dt.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=False";
            DataView dv = dt.DefaultView;
            dv.Sort = "GuiDuLieu ASC, NgayLapPhieu DESC, ID_SoPhieu DESC, CaSanXuat DESC";
            DataTable dxxxx = dv.ToTable();
            if(dxxxx.Rows.Count>0)
            {
               
                for (int i=0; i<dxxxx.Rows.Count; i++)
                {
                    int ID_SoPhieu = Convert.ToInt32(dxxxx.Rows[i]["ID_SoPhieu"].ToString());
                    DataRow _ravi = dt2.NewRow();
                    _ravi["ID_SoPhieu"] = ID_SoPhieu;
                    _ravi["MaPhieu"] = dxxxx.Rows[i]["MaPhieu"].ToString();
                    _ravi["NgayLapPhieu"] = Convert.ToDateTime(dxxxx.Rows[i]["NgayLapPhieu"].ToString());
                    _ravi["GhiChu"] = dxxxx.Rows[i]["GhiChu"].ToString();
                    _ravi["CaSanXuat"] = dxxxx.Rows[i]["CaSanXuat"].ToString();
                    _ravi["GuiDuLieu"] = Convert.ToBoolean(dxxxx.Rows[i]["GuiDuLieu"].ToString());
                    _ravi["ID_CaTruong"] = Convert.ToInt32(dxxxx.Rows[i]["ID_CaTruong"].ToString());
                    _ravi["DaKetThuc"] = Convert.ToBoolean(dxxxx.Rows[i]["DaKetThuc"].ToString());
                    _ravi["TenNhanVien"] = dxxxx.Rows[i]["TenNhanVien"].ToString();
                    clsPhieu_ChiTietPhieu_New clsphieu = new clsPhieu_ChiTietPhieu_New();
                    clsphieu.iID_SoPhieu = ID_SoPhieu;
                    DataTable dtphieu = clsphieu.SelectAll_W_iID_SoPhieu();
                    if(dtphieu.Rows.Count>0)
                    {
                        dtphieu.DefaultView.RowFilter = "bMay_IN= True";
                        DataView dvphieu = dtphieu.DefaultView;                      
                        DataTable dxxxxphieu = dvphieu.ToTable();
                        if (dxxxxphieu.Rows.Count > 0)
                        {
                            int ID_VTHH_Ra= Convert.ToInt32(dxxxxphieu.Rows[0]["ID_VTHH_Ra"].ToString());
                            clsTbVatTuHangHoa clsvt = new clsTbVatTuHangHoa();
                            clsvt.iID_VTHH = ID_VTHH_Ra;
                            DataTable dtvt = clsvt.SelectOne();
                            _ravi["MaHang"] = clsvt.sTenVTHH.Value;
                        }
                          
                    }
                   
                    dt2.Rows.Add(_ravi);
                }
            }
            gridControl1.DataSource = dt2;
        }
        private void HienThi(DateTime xxtungay, DateTime xxdenngay)
        {
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_SoPhieu", typeof(int));
            dt2.Columns.Add("MaPhieu", typeof(string));
            dt2.Columns.Add("NgayLapPhieu", typeof(DateTime));
            dt2.Columns.Add("GhiChu", typeof(string));
            dt2.Columns.Add("GuiDuLieu", typeof(bool));
            dt2.Columns.Add("ID_CaTruong", typeof(int));
            dt2.Columns.Add("DaKetThuc", typeof(bool));
            dt2.Columns.Add("TenNhanVien", typeof(string));
            dt2.Columns.Add("MaHang", typeof(string));
            dt2.Columns.Add("CaSanXuat", typeof(string));
            clsPhieu_tbPhieu cls = new clsPhieu_tbPhieu();
            DataTable dt = cls.SelectAll_W_TenCaTruong();           
            dt.DefaultView.RowFilter = " NgayLapPhieu<='" + xxdenngay + "'";
            DataView dv = dt.DefaultView;
            DataTable dt22 = dv.ToTable();
            dt22.DefaultView.RowFilter = " NgayLapPhieu>='" + xxtungay + "'";
            DataView dv2 = dt22.DefaultView;
            dv2.Sort = "GuiDuLieu ASC, NgayLapPhieu DESC, ID_SoPhieu DESC, CaSanXuat DESC";
            DataTable dxxxx = dv2.ToTable();

            if (dxxxx.Rows.Count > 0)
            {

                for (int i = 0; i < dxxxx.Rows.Count; i++)
                {
                    int ID_SoPhieu = Convert.ToInt32(dxxxx.Rows[i]["ID_SoPhieu"].ToString());
                    DataRow _ravi = dt2.NewRow();
                    _ravi["ID_SoPhieu"] = ID_SoPhieu;
                    _ravi["MaPhieu"] = dxxxx.Rows[i]["MaPhieu"].ToString();
                    _ravi["NgayLapPhieu"] = Convert.ToDateTime(dxxxx.Rows[i]["NgayLapPhieu"].ToString());
                    _ravi["GhiChu"] = dxxxx.Rows[i]["GhiChu"].ToString();

                    _ravi["GuiDuLieu"] = Convert.ToBoolean(dxxxx.Rows[i]["GuiDuLieu"].ToString());
                    _ravi["ID_CaTruong"] = Convert.ToInt32(dxxxx.Rows[i]["ID_CaTruong"].ToString());
                    _ravi["DaKetThuc"] = Convert.ToBoolean(dxxxx.Rows[i]["DaKetThuc"].ToString());
                    _ravi["TenNhanVien"] = dxxxx.Rows[i]["TenNhanVien"].ToString();
                    _ravi["CaSanXuat"] = dxxxx.Rows[i]["CaSanXuat"].ToString();
                    clsPhieu_ChiTietPhieu_New clsphieu = new clsPhieu_ChiTietPhieu_New();
                    clsphieu.iID_SoPhieu = ID_SoPhieu;
                    DataTable dtphieu = clsphieu.SelectAll_W_iID_SoPhieu();
                    if (dtphieu.Rows.Count > 0)
                    {
                        dtphieu.DefaultView.RowFilter = "bMay_IN= True";
                        DataView dvphieu = dtphieu.DefaultView;
                        DataTable dxxxxphieu = dvphieu.ToTable();
                        if (dxxxxphieu.Rows.Count > 0)
                        {
                            int ID_VTHH_Ra = Convert.ToInt32(dxxxxphieu.Rows[0]["ID_VTHH_Ra"].ToString());
                            clsTbVatTuHangHoa clsvt = new clsTbVatTuHangHoa();
                            clsvt.iID_VTHH = ID_VTHH_Ra;
                            DataTable dtvt = clsvt.SelectOne();
                            _ravi["MaHang"] = clsvt.sTenVTHH.Value;
                        }

                    }

                    dt2.Rows.Add(_ravi);
                }
            }
            gridControl1.DataSource = dt2;
           
        }
        public UC_SanXuat_PhieuSanXuat()
        {
            InitializeComponent();
        }

        private void UC_SanXuat_PhieuSanXuat_Load(object sender, EventArgs e)
        {
            dteDenNgay.EditValue = null;
            dteTuNgay.EditValue = null;
            clCaLamViec.Caption = "Ca\n làm việc";
            HienThi_ALL();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UC_SanXuat_PhieuSanXuat_Load(sender, e);
        }

        private void checked_ALL_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkTheoDoi_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkNgungTheoDoi_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.GetFocusedRowCellValue(CLID_SoPhieu).ToString() != "")
                {
                    mb_ThemMoi_SoPhieu = false;
                    mb_Sua_SoPhieu = true;
                    mbCopy_Phieu = false;
                    msTenSoPhieu = gridView1.GetFocusedRowCellValue(clMaPhieu).ToString();
                    mID_iD_SoPhieu = Convert.ToInt16(gridView1.GetFocusedRowCellValue(CLID_SoPhieu).ToString());
                    SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222 ff = new CtyTinLuong.SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222();
                    ff.Show();
                }
            }
            catch
            {

            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            clsPhieu_tbPhieu cls1 = new clsPhieu_tbPhieu();
            cls1.iID_SoPhieu = Convert.ToInt32(gridView1.GetFocusedRowCellValue(CLID_SoPhieu).ToString());
            DataTable dt1 = cls1.SelectOne();
            if (cls1.bGuiDuLieu==true)
            {
                MessageBox.Show("Đã gửi dữ liệu, không thể xoá");
                return;

            }
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Xóa dữ liệu này. Lưu ý sẽ mất hế dữ liệu?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {

                    cls1.iID_SoPhieu = Convert.ToInt32(gridView1.GetFocusedRowCellValue(CLID_SoPhieu).ToString());
                    cls1.Delete();
                    clsPhieu_ChiTietPhieu_New cls2 = new clsPhieu_ChiTietPhieu_New();
                    cls2.iID_SoPhieu = Convert.ToInt32(gridView1.GetFocusedRowCellValue(CLID_SoPhieu).ToString());
                    cls2.Delete_All_W_ID_SoPhieu();
                    MessageBox.Show("Đã xóa");
                    if (dteDenNgay.EditValue != null & dteTuNgay.EditValue != null)
                    {
                        HienThi(dteTuNgay.DateTime, dteDenNgay.DateTime);
                    }
                    else HienThi_ALL();
                    
                }
            }
            
        }

        private void btThemMoi_Click(object sender, EventArgs e)
        {
            mb_ThemMoi_SoPhieu = true;
            SanXuat_frmThemMoi_SoPhieu ff = new SanXuat_frmThemMoi_SoPhieu();
            ff.Show();
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {

                clsPhieu_tbPhieu cls = new clsPhieu_tbPhieu();
                cls.iID_SoPhieu = Convert.ToInt16(gridView1.GetFocusedRowCellValue(CLID_SoPhieu).ToString());
                cls.bNgungTheoDoi = Convert.ToBoolean(gridView1.GetFocusedRowCellValue(clNgungTheoDoi).ToString());
                cls.Update_NgungTheoDoi();
            }
            catch
            {

            }
        }

        private void btAPP_Click(object sender, EventArgs e)
        {
            Thin_SanXuat_APP_May_IN ff = new Thin_SanXuat_APP_May_IN();
            ff.Show();
        }

        private void btChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.GetFocusedRowCellValue(CLID_SoPhieu).ToString() != "")
                {
                    msTenSoPhieu = gridView1.GetFocusedRowCellValue(clMaPhieu).ToString();
                    mID_iD_SoPhieu = Convert.ToInt16(gridView1.GetFocusedRowCellValue(CLID_SoPhieu).ToString());
                    SanXuat_frmChiTietSoPhieu_RutGon ff = new CtyTinLuong.SanXuat_frmChiTietSoPhieu_RutGon();
                    ff.Show();
                }
            }
            catch
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.GetFocusedRowCellValue(CLID_SoPhieu).ToString() != "")
                {
                    mb_ThemMoi_SoPhieu = false;
                    mb_Sua_SoPhieu = true;
                    mbCopy_Phieu = true;
                    msTenSoPhieu = gridView1.GetFocusedRowCellValue(clMaPhieu).ToString();
                    mID_iD_SoPhieu = Convert.ToInt16(gridView1.GetFocusedRowCellValue(CLID_SoPhieu).ToString());
                    SanXuat_frmChiTietSoPhieu_RutGon ff = new CtyTinLuong.SanXuat_frmChiTietSoPhieu_RutGon();
                    ff.Show();
                }
            }
            catch
            {

            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool category = Convert.ToBoolean(View.GetRowCellValue(e.RowHandle, View.Columns["GuiDuLieu"]));
                if (category == false)
                {
                    e.Appearance.BackColor = Color.Bisque;
                  
                }
            }
        }

        private void btThemMoi_Click_1(object sender, EventArgs e)
        {
            mb_ThemMoi_SoPhieu = true;
            mb_Sua_SoPhieu = false;
            mbCopy_Phieu = false;
            SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222 ff = new CtyTinLuong.SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222();
            ff.Show();
        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            if (dteDenNgay.EditValue != null & dteTuNgay.EditValue != null)
            {
                HienThi(dteTuNgay.DateTime, dteDenNgay.DateTime);
            }
        }

        private void btCopY_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.GetFocusedRowCellValue(CLID_SoPhieu).ToString() != "")
                {
                    mb_ThemMoi_SoPhieu = false;
                    mb_Sua_SoPhieu = false;
                    mbCopy_Phieu = true;
                    msTenSoPhieu = gridView1.GetFocusedRowCellValue(clMaPhieu).ToString();
                    mID_iD_SoPhieu = Convert.ToInt16(gridView1.GetFocusedRowCellValue(CLID_SoPhieu).ToString());
                    SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222 ff = new CtyTinLuong.SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222();
                    ff.Show();
                }
            }
            catch
            {

            }
            
        }
    }
}
