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
    public partial class UC_KhoNVL_frmChoNhapKho : UserControl
    {
        //public static bool mb_TheMoi_DonHang;
        public static int miID_MuaHang_NhapKho;

        public UC_KhoNVL_frmChoNhapKho()
        {
            InitializeComponent();
        }

        private void UC_KhoNVL_frmChoNhapKho_Load(object sender, EventArgs e)
        {
            clsMH_tbMuaHang clsmuahang = new clsMH_tbMuaHang();
            DataTable dt2 = clsmuahang.SelectAll();
            dt2.DefaultView.RowFilter = "GuiDuLieu=True and MuaHangNhapKho=True and TonTai= True and NgungTheoDoi=false and TrangThaiNhapKho=False and check_BaoVe = True and check_LaiXe=True";
            DataView dv = dt2.DefaultView;
            dv.Sort = "NgayChungTu DESC, ID_MuaHang DESC";
            DataTable dxxxx = dv.ToTable();
            gridControl1.DataSource = dxxxx;           
        }

       
        private void gridView1_CustomDrawCell_1(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.GetFocusedRowCellValue(clID).ToString() != "")
                {
                    miID_MuaHang_NhapKho = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID).ToString());
                    KhoNPL_frmChiTiet_MuaHang_NhapKho ff = new KhoNPL_frmChiTiet_MuaHang_NhapKho();
                    ff.Show();
                }
            }
            catch
            {

            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UC_KhoNVL_frmChoNhapKho_Load( sender,  e);
        }
    }
}
