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
    public partial class UCKhoNPL_DaXuatKho : UserControl
    {
        public static int miD_XuatKhoNPL;

        private void HienThi()
        {
            if (dteTuNgay.EditValue != null & dteNgay.EditValue != null)
            {
                DateTime denngay = dteNgay.DateTime;
                DateTime tungay = dteTuNgay.DateTime;
                clsKhoNPL_tbXuatKho cls = new CtyTinLuong.clsKhoNPL_tbXuatKho();
                DataTable dt2 = cls.SelectAll();
                dt2.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=false";
                DataView dv = dt2.DefaultView;
                dv.Sort = "NgayChungTu DESC, ID_XuatKhoNPL DESC";
                DataTable dt = dv.ToTable();

               
                dt.DefaultView.RowFilter = " NgayChungTu<='" + denngay + "'";
                DataView dvxxx = dt.DefaultView;
                DataTable dt22 = dvxxx.ToTable();
                dt22.DefaultView.RowFilter = " NgayChungTu>='" + tungay + "'";
                DataView dv2 = dt22.DefaultView;
                dv2.Sort = "NgayChungTu DESC, ID_XuatKho DESC";
                DataTable dxxxx = dv2.ToTable();

                gridControl1.DataSource = dxxxx;
            }

        }
        private void HienThi_ALL()
        {
            clsKhoNPL_tbXuatKho cls = new CtyTinLuong.clsKhoNPL_tbXuatKho();
            DataTable dt2 = cls.SelectAll();
            dt2.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=false";
            DataView dv = dt2.DefaultView;
            dv.Sort = "NgayChungTu DESC, ID_XuatKhoNPL DESC";
            DataTable dxxxx = dv.ToTable();
            gridControl1.DataSource = dxxxx;


        }
       
        public UCKhoNPL_DaXuatKho()
        {
            InitializeComponent();
        }

        private void UCKhoNPL_DaXuatKho_Load(object sender, EventArgs e)
        {
            dteNgay.EditValue = null;
            dteTuNgay.EditValue = null;
            HienThi_ALL();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UCKhoNPL_DaXuatKho_Load( sender,  e);
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
                if (gridView1.GetFocusedRowCellValue(clID_XuatKhoNPL).ToString() != "")
                {
                    miD_XuatKhoNPL = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_XuatKhoNPL).ToString());
                    frmKhoNPL_DaXuatKho ff = new frmKhoNPL_DaXuatKho();
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
    }
}
