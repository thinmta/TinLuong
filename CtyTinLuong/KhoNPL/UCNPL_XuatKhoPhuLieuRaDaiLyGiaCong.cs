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
    public partial class UCNPL_XuatKhoPhuLieuRaDaiLyGiaCong : UserControl
    {
        
        public static int miID_NhapKhoDaiLy;
        public static bool mbThemMoi_nhapKhoDaiLy, mbCopy, mbSua;
        private void HienThi()
        {
            clsDaiLy_tbNhapKho cls = new clsDaiLy_tbNhapKho();
            DataTable dt = cls.SelectAll_W_TenDaiLy_W_DinhMuc();
            dt.DefaultView.RowFilter = "NgungTheoDoi=False and TonTai= True";
            DataView dv = dt.DefaultView;
            dv.Sort = "TrangThaiXuatNhap_Kho_NPL ASC, NgayChungTu DESC, ID_NhapKhoDaiLy DESC";
            DataTable dxxxx = dv.ToTable();
            gridControl1.DataSource = dxxxx;
        }
        public UCNPL_XuatKhoPhuLieuRaDaiLyGiaCong()
        {
            InitializeComponent();
        }

        private void UCNPL_XuatKhoPhuLieuRaDaiLyGiaCong_Load(object sender, EventArgs e)
        {
            mbThemMoi_nhapKhoDaiLy = mbCopy=mbSua = false;
            clNgungTheoDoi.Caption = "Ngừng\ntheo dõi";            
            HienThi();
           
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
            if (gridView1.GetFocusedRowCellValue(clID_NhapKhoDaiLy).ToString() != "")
            {
                mbCopy = false;
                mbSua = true;
                mbThemMoi_nhapKhoDaiLy = false;
                miID_NhapKhoDaiLy = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_NhapKhoDaiLy).ToString());
                NPLChiTietNhapKho_DaiLy_ThemMoi ff = new NPLChiTietNhapKho_DaiLy_ThemMoi();
                ff.Show();
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UCNPL_XuatKhoPhuLieuRaDaiLyGiaCong_Load(sender, e);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btThemMoi_Click(object sender, EventArgs e)
        {
            mbThemMoi_nhapKhoDaiLy = true;
            mbSua = false;
            mbCopy = false;
            NPLChiTietNhapKho_DaiLy_ThemMoi ff = new NPLChiTietNhapKho_DaiLy_ThemMoi();
            ff.Show();
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool category = Convert.ToBoolean(View.GetRowCellValue(e.RowHandle, View.Columns["TrangThaiXuatNhap_Kho_NPL"]));
                if (category == false)
                {
                    e.Appearance.BackColor = Color.Bisque;
                    
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            clsDaiLy_tbNhapKho cls1 = new clsDaiLy_tbNhapKho();
            cls1.iID_NhapKhoDaiLy = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clID_NhapKhoDaiLy).ToString());
            DataTable dt1 = cls1.SelectOne();
            if (cls1.bTrangThaiXuatNhap_Kho_NPL.Value == true)
            {
                MessageBox.Show("Đã gửi dữ liệu, không thể xoá");
                return;

            }
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Xóa dữ liệu này?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {

                    cls1.iID_NhapKhoDaiLy = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clID_NhapKhoDaiLy).ToString());
                    cls1.Delete();
                    clsDaiLy_tbChiTietNhapKho cls2 = new clsDaiLy_tbChiTietNhapKho();
                    cls2.iID_NhapKhoDaiLy = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clID_NhapKhoDaiLy).ToString());
                    cls2.Delete_W_ID_NhapKhoDaiLy();
                    MessageBox.Show("Đã xóa");
                    HienThi();
                }
            }
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            if(gridView1.GetFocusedRowCellValue(clID_NhapKhoDaiLy).ToString()!="")
            {
                mbCopy = true;
                mbThemMoi_nhapKhoDaiLy = false;
                mbSua = false;
                miID_NhapKhoDaiLy = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_NhapKhoDaiLy).ToString());
                NPLChiTietNhapKho_DaiLy_ThemMoi ff = new NPLChiTietNhapKho_DaiLy_ThemMoi();
                ff.Show();
            }
           
        }
    }
}
