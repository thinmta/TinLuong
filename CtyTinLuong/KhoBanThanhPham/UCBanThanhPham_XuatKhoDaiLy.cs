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
    public partial class UCBanThanhPham_XuatKhoDaiLy : UserControl
    {
        public static int miID_NhapKhoDaiLy;
        public static bool mbool_ThemMoi_xuatkhoBTP_Ra_DaiLy;
        private void HienThi()
        {
            if (dteTuNgay.EditValue != null & dteNgay.EditValue != null)
            {
                clsDaiLy_tbNhapKho cls = new clsDaiLy_tbNhapKho();
                DataTable dtxx = cls.SelectAll_W_TenDaiLy_W_DinhMuc();
                dtxx.DefaultView.RowFilter = "TrangThaiXuatNhap_Kho_NPL = True";
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
                    dv2.Sort = "TrangThaiXuatNhap_Kho_BTP, NgayChungTu DESC, ID_NhapKhoDaiLy DESC";
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
                dt.DefaultView.RowFilter = "TrangThaiXuatNhap_Kho_NPL = True";
                DataView dv = dt.DefaultView;
                dv.Sort = "TrangThaiXuatNhap_Kho_BTP, NgayChungTu DESC, ID_NhapKhoDaiLy DESC";
                DataTable dxxxx = dv.ToTable();
                gridControl1.DataSource = dxxxx;
            }
        }
        //private void HienThi()
        //{
        //    clsDaiLy_tbNhapKho cls = new clsDaiLy_tbNhapKho();
        //    DataTable dt = cls.SelectAll_W_TenDaiLy_W_DinhMuc_HienThi_XuatKho_BanThanhPham_RaDaiLyGiaCong();
        //    dt.DefaultView.RowFilter = "NgungTheoDoi=False and TonTai= True";
        //    DataView dv = dt.DefaultView;
        //    dv.Sort = "NgayChungTu DESC, ID_NhapKhoDaiLy DESC";
        //    DataTable dxxxx = dv.ToTable();
        //    gridControl1.DataSource = dxxxx;
        //}
        public UCBanThanhPham_XuatKhoDaiLy()
        {
            InitializeComponent();
        }

        private void UCBanThanhPham_XuatKhoDaiLy_Load(object sender, EventArgs e)
        {
            clNgungTheoDoi.Caption = "Ngừng\ntheo dõi";
            dteNgay.EditValue = null;
            dteTuNgay.EditValue = null;
            HienThi_ALL();
            mbool_ThemMoi_xuatkhoBTP_Ra_DaiLy = false;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UCBanThanhPham_XuatKhoDaiLy_Load( sender,  e);
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

            miID_NhapKhoDaiLy = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_NhapKhoDaiLy).ToString());            
            clsKhoBTP_tbXuatKho cls1xx = new clsKhoBTP_tbXuatKho();
            cls1xx.sThamChieu = gridView1.GetFocusedRowCellValue(clThamChieu).ToString();
            DataTable dt1 = cls1xx.SelectOne_W_ThamChieu_SoChungTu_XuatKho_DaiLy();
            if (dt1.Rows.Count > 0)
            {
                mbool_ThemMoi_xuatkhoBTP_Ra_DaiLy = false;
            }
            else
            {
                mbool_ThemMoi_xuatkhoBTP_Ra_DaiLy = true;
            }
            KhoBTP_frmChiTietXuatKhoDaiLyGiaCong ff = new KhoBTP_frmChiTietXuatKhoDaiLyGiaCong();
            ff.Show();
            
          
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
                bool category = Convert.ToBoolean(View.GetRowCellValue(e.RowHandle, View.Columns["TrangThaiXuatNhap_Kho_BTP"]));
                if (category == false)
                {
                    e.Appearance.BackColor = Color.Orange;                  
                }
            }

        }
    }
}
