using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtyTinLuong
{
    public partial class UCThanhPham_DaNhapKho : UserControl
    {
        public static int miiID_NhapKho_ThanhPham;
        private void HienThi()
        {
            clsKhoThanhPham_tbNhapKho cls = new CtyTinLuong.clsKhoThanhPham_tbNhapKho();
            DataTable dt2 = cls.SelectAll_W_DaiLy_hienThi_DaNhapKho();
            dt2.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=false";
            DataView dv = dt2.DefaultView;
            dv.Sort = "NgayChungTu DESC, ID_NhapKho_ThanhPham DESC";
            DataTable dxxxx = dv.ToTable();
            gridControl1.DataSource = dxxxx;
        }
        public UCThanhPham_DaNhapKho()
        {
            InitializeComponent();
        }

      

        private void UCThanhPham_DaNhapKho_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.GetFocusedRowCellValue(clID_NhapKhoThanhPham).ToString() != "")
                {
                    miiID_NhapKho_ThanhPham = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_NhapKhoThanhPham).ToString());
                    frmChiTietNhapKhoThanhPham_DaNhapKhoTP ff = new frmChiTietNhapKhoThanhPham_DaNhapKhoTP();
                    ff.Show();
                }
            }
            catch
            {

            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UCThanhPham_DaNhapKho_Load(sender, e);
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}
