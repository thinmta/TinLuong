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
    public partial class UCBanThanhPham_NhapKho_TuDaiLy : UserControl
    {
        public static int miID_XuatKho_DaiLy;
    
        private void HienThi()
        {
            if (dteTuNgay.EditValue != null & dteNgay.EditValue != null)
            {
                clsDaiLy_tbXuatKho cls = new clsDaiLy_tbXuatKho();
                DataTable dtxx = cls.SelectAll_W_TenDaiLy_W_MaVT();
                dtxx.DefaultView.RowFilter = "DaXuatKho = True and CheckNhapKho_ThanhPham_True_nhapKhoBTP_False = False";
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
                    dv2.Sort = "NgayChungTu DESC, TrangThaiXuatNhap_ThanhPham_TuDaiLyVe ASC";
                    DataTable dxxxx = dv2.ToTable();
                    gridControl1.DataSource = dxxxx;

                }
            }

        }
        private void HienThi_ALL()
        {
            clsDaiLy_tbXuatKho cls = new clsDaiLy_tbXuatKho();
            DataTable dt = cls.SelectAll_W_TenDaiLy_W_MaVT();           
            if (dt.Rows.Count > 0)
            {
                dt.DefaultView.RowFilter = "DaXuatKho = True and CheckNhapKho_ThanhPham_True_nhapKhoBTP_False = False";
                DataView dv = dt.DefaultView;
                dv.Sort = "NgayChungTu DESC, TrangThaiXuatNhap_ThanhPham_TuDaiLyVe ASC";
                DataTable dxxxx = dv.ToTable();
                gridControl1.DataSource = dxxxx;
            }
        }
        public UCBanThanhPham_NhapKho_TuDaiLy()
        {
            InitializeComponent();
        }

        private void UCBanThanhPham_NhapKho_TuDaiLy_Load(object sender, EventArgs e)
        {
            clNgungTheoDoi.Caption = "Ngừng\ntheo dõi";
            dteNgay.EditValue = null;
            dteTuNgay.EditValue = null;
            HienThi_ALL();
           
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UCBanThanhPham_NhapKho_TuDaiLy_Load( sender,  e);
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
            miID_XuatKho_DaiLy = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_XuatKhoDaiLy).ToString());
           
            //cls1xx.sThamChieu = gridView1.GetFocusedRowCellValue(clThamChieu).ToString();
            //DataTable dt1 = cls1xx.SelectOne_W_ThamChieu_SoChungTu_XuatKho_DaiLy();
            //if (dt1.Rows.Count > 0)
            //{
            //    mbool_ThemMoi_xuatkhoBTP_Ra_DaiLy = false;
            //}
            //else
            //{
            //    mbool_ThemMoi_xuatkhoBTP_Ra_DaiLy = true;
            //}
            KhoBTP_ChiTietNhapKho_HangGiaCongTuDaiLyVe ff = new KhoBTP_ChiTietNhapKho_HangGiaCongTuDaiLyVe();
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
                bool category = Convert.ToBoolean(View.GetRowCellValue(e.RowHandle, View.Columns["TrangThaiXuatNhap_ThanhPham_TuDaiLyVe"]));
                if (category == false)
                {
                    e.Appearance.BackColor = Color.Orange;
                }
            }
        }
    }
}
