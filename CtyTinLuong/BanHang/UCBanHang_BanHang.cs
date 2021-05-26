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
    public partial class UCBanHang_BanHang : UserControl
    {
       
        public static int miiiID_BanHang;
        public static bool mbCopY;
        private void HienThi()
        {
            if (dteTuNgay.EditValue != null & dteNgay.EditValue != null)
            {
                DateTime denngay = dteNgay.DateTime;
                DateTime tungay = dteTuNgay.DateTime;

                clsBanHang_tbBanHang cls = new clsBanHang_tbBanHang();
                DataTable dt = cls.SelectAll_w_TenKH();
                dt.DefaultView.RowFilter = " NgayChungTu<='" + denngay + "'and TrangThai_KhoThanhPham= True";
                DataView dv = dt.DefaultView;
                DataTable dt22 = dv.ToTable();
                dt22.DefaultView.RowFilter = " NgayChungTu>='" + tungay + "'";
                DataView dv2 = dt22.DefaultView;
                dv2.Sort = " TrangThaiBanHang ASC, NgayChungTu DESC, ID_BanHang DESC";
                DataTable dxxxx = dv2.ToTable();
                gridControl1.DataSource = dxxxx;
            }

        }
        private void HienThi_ALL()
        {
            clsBanHang_tbBanHang cls = new clsBanHang_tbBanHang();
            DataTable dt = cls.SelectAll_w_TenKH();
            dt.DefaultView.RowFilter = " TrangThai_KhoThanhPham= True";
            DataView dv2 = dt.DefaultView;
            dv2.Sort = "TrangThaiBanHang ASC, NgayChungTu DESC, ID_BanHang DESC";
            DataTable dxxxx = dv2.ToTable();
            gridControl1.DataSource = dxxxx;
        }
       
        public UCBanHang_BanHang()
        {
            InitializeComponent();
        }

       


        private void btRefresh_Click(object sender, EventArgs e)
        {
            UCBanHang_BanHang_Load(sender, e);
        }

        private void UCBanHang_BanHang_Load(object sender, EventArgs e)
        {
            
            dteNgay.EditValue = null;
            dteTuNgay.EditValue = null;
            HienThi_ALL();
           
            clTongTienHang.Caption = "Tổng\ntiền hàng";
            clNgungTheoDoi.Caption = "Bỏ\n theo dõi";
           
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        //private void btThemMoi_Click(object sender, EventArgs e)
        //{
        //    mbbTheMoi_BanHang = true;
        //    frmThemMoi_BanHang ff = new frmThemMoi_BanHang();
        //    ff.Show();
        //}

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {

                clsBanHang_tbBanHang cls = new clsBanHang_tbBanHang();
                cls.iID_BanHang = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_BanHang).ToString());
                cls.bNgungTheoDoi = Convert.ToBoolean(gridView1.GetFocusedRowCellValue(clNgungTheoDoi).ToString());
                cls.Update_NgungTheoDoi();
            }
            catch
            {

            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.GetFocusedRowCellValue(clID_BanHang).ToString() != "")
                {//msDienGiai
                    miiiID_BanHang = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_BanHang).ToString());
                    BanHang_FrmChiTietBanHang_Newwwwwwww ff = new BanHang_FrmChiTietBanHang_Newwwwwwww();
                    ff.Show();
                }
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
                bool category = Convert.ToBoolean(View.GetRowCellValue(e.RowHandle, View.Columns["TrangThaiBanHang"]));
                if (category == false)
                {
                    e.Appearance.BackColor = Color.Bisque;

                }
            }
        }
    }
}
