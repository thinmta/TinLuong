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
    public partial class UCBanThanhPham_DaNhapKhoTheoLenhSanXuat : UserControl
    {
        public static int miiID_NhapKhoBTP;
        private void HienThi()
        {
            clsKhoBTP_tbNhapKho cls = new CtyTinLuong.clsKhoBTP_tbNhapKho();
            DataTable dt2 = cls.SelectAll();
            dt2.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=false";
            DataView dv = dt2.DefaultView;
            dv.Sort = "NgayChungTu DESC, ID_NhapKhoBTP DESC";
            DataTable dxxxx = dv.ToTable();
            gridControl1.DataSource = dxxxx;
        }
        public UCBanThanhPham_DaNhapKhoTheoLenhSanXuat()
        {
            InitializeComponent();
        }

        private void UCBanThanhPham_DaNhapKhoTheoLenhSanXuat_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UCBanThanhPham_DaNhapKhoTheoLenhSanXuat_Load(sender, e);
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
                if (gridView1.GetFocusedRowCellValue(clID_NhapKhoBTP).ToString() != "")
                {
                    miiID_NhapKhoBTP = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_NhapKhoBTP).ToString());
                    KhoBTP_ChiTiet_DaNhapKho ff = new KhoBTP_ChiTiet_DaNhapKho();
                    ff.Show();
                }
            }
            catch
            {

            }
        }
    }
}
