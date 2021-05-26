using System;
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
    public partial class UC_DaiLy_NhapKho_ChoGhiSo : UserControl
    {
        public static bool mbThemMoi_nhapKhoDaiLy;
        public static int miID_NhapKhoDaiLy;

        private void HienThi()
        {
            if (dteTuNgay.EditValue != null & dteNgay.EditValue != null)
            {
                clsDaiLy_tbNhapKho cls = new clsDaiLy_tbNhapKho();
                DataTable dtxx = cls.SelectAll_W_TenDaiLy_W_DinhMuc();
                dtxx.DefaultView.RowFilter = "TrangThaiXuatNhap_Kho_BTP = True and TrangThaiXuatNhap_Kho_NPL = True";
                DataView dvxxx = dtxx.DefaultView;
                DataTable dt = dvxxx.ToTable();
                if (dtxx.Rows.Count > 0)
                {
                    DateTime denngay = dteNgay.DateTime;
                    DateTime tungay = dteTuNgay.DateTime;
                    dt.DefaultView.RowFilter = " NgayChungTu<='" + denngay + "'";
                    DataView dv = dt.DefaultView;
                    DataTable dt22 = dv.ToTable();
                    dt22.DefaultView.RowFilter = " NgayChungTu>='" + tungay + "'";
                    DataView dv2 = dt22.DefaultView;
                    dv2.Sort = "TrangThaiXuatNhap_KhoDaiLy ASC, NgayChungTu DESC, ID_NhapKhoDaiLy DESC";
                    DataTable dxxxx = dv2.ToTable();
                    gridControl1.DataSource = dxxxx;
                    
                }
            }

        }
        private void HienThi_ALL()
        {
            clsDaiLy_tbNhapKho cls = new clsDaiLy_tbNhapKho();
            DataTable dt = cls.SelectAll_W_TenDaiLy_W_DinhMuc();            
            if (dt.Rows.Count > 0)
            {
                dt.DefaultView.RowFilter = "TrangThaiXuatNhap_Kho_BTP = True and TrangThaiXuatNhap_Kho_NPL = True";
                DataView dv = dt.DefaultView;
                dv.Sort = "TrangThaiXuatNhap_KhoDaiLy ASC, NgayChungTu DESC, ID_NhapKhoDaiLy DESC";
                DataTable dxxxx = dv.ToTable();
                gridControl1.DataSource = dxxxx;
            }
        }

        public UC_DaiLy_NhapKho_ChoGhiSo()
        {
            InitializeComponent();
        }

        private void UC_DaiLy_NhapKho_Load(object sender, EventArgs e)
        {
            clNgungTheoDoi.Caption= "Ngừng\ntheo dõi";
            dteNgay.EditValue = null;
            dteTuNgay.EditValue = null;
            HienThi_ALL();
            
            mbThemMoi_nhapKhoDaiLy = false;
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
            mbThemMoi_nhapKhoDaiLy = false;
            miID_NhapKhoDaiLy= Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_NhapKhoDaiLy).ToString());
            DaiLy_FrmChiTietNhapKho_Newwwwwwwwwwwwwww ff = new DaiLy_FrmChiTietNhapKho_Newwwwwwwwwwwwwww();
            ff.Show();
        }

 

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UC_DaiLy_NhapKho_Load(sender, e);
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {

                clsDaiLy_tbNhapKho cls = new clsDaiLy_tbNhapKho();
                cls.iID_NhapKhoDaiLy = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_NhapKhoDaiLy).ToString());
                cls.bNgungTheoDoi = Convert.ToBoolean(gridView1.GetFocusedRowCellValue(clNgungTheoDoi).ToString());
                cls.Update_NgungTheoDoi();
            }
            catch
            {

            }
        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            if (dteNgay.EditValue != null & dteTuNgay.EditValue != null)
            {
                HienThi();
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool category = Convert.ToBoolean(View.GetRowCellValue(e.RowHandle, View.Columns["TrangThaiXuatNhap_KhoDaiLy"]));
                if (category == false)
                {
                    e.Appearance.BackColor = Color.Bisque;
                    //e.Appearance.BackColor = Color.Salmon;
                    //e.Appearance.BackColor2 = Color.SeaShell;

                }
            }

           
        }
    }
}
