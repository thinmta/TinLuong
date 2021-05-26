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
    public partial class UC_KhoNVL_frmDaNhapKho : UserControl
    {
        public static int miD_NhapKho;
        public static string msThamChieuMuaHang;
        private void HienThi()
        {
            if (dteTuNgay.EditValue != null & dteNgay.EditValue != null)
            {
                DateTime denngay = dteNgay.DateTime;
                DateTime tungay = dteTuNgay.DateTime;

                clsKhoNPL_tbNhapKho cls = new CtyTinLuong.clsKhoNPL_tbNhapKho();
                DataTable dt2xx = cls.SelectAll();
                dt2xx.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=false";
                DataView dv22xxx = dt2xx.DefaultView;
                dv22xxx.Sort = "NgayChungTu DESC, ID_NhapKho DESC";
                DataTable dt2 = dv22xxx.ToTable();

                dt2.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=false";
                DataView dv = dt2.DefaultView;
                dv.Sort = "NgayChungTu DESC, ID_NhapKho DESC";
                DataTable dt = dv.ToTable();

                dt.DefaultView.RowFilter = " NgayChungTu<='" + denngay + "'";
                DataView dvxxx = dt.DefaultView;
                DataTable dt22 = dvxxx.ToTable();
                dt22.DefaultView.RowFilter = " NgayChungTu>='" + tungay + "'";
                DataView dv2 = dt22.DefaultView;
                dv2.Sort = "NgayChungTu DESC, ID_NhapKho DESC";
                DataTable dxxxx = dv2.ToTable();

                gridControl1.DataSource = dxxxx;
            }

        }
        private void HienThi_ALL()
        {            

            clsKhoNPL_tbNhapKho cls = new CtyTinLuong.clsKhoNPL_tbNhapKho();
            DataTable dt2 = cls.SelectAll();
            dt2.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=false";
            DataView dv = dt2.DefaultView;
            dv.Sort = "NgayChungTu DESC, ID_NhapKho DESC";
            DataTable dxxxx = dv.ToTable();
            gridControl1.DataSource = dxxxx;


        }
        private void HienThi2222()
        {
            clsKhoNPL_tbNhapKho cls = new CtyTinLuong.clsKhoNPL_tbNhapKho();
            DataTable dt2 = cls.SelectAll();
            dt2.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=false";
            DataView dv = dt2.DefaultView;
            dv.Sort = "NgayChungTu DESC, ID_NhapKho DESC";
            DataTable dxxxx = dv.ToTable();
            gridControl1.DataSource = dxxxx;
        }
        
      
        public UC_KhoNVL_frmDaNhapKho()
        {
            InitializeComponent();
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
                if (gridView1.GetFocusedRowCellValue(clID_NhapKhoNPL).ToString() != "")
                {
                    msThamChieuMuaHang = gridView1.GetFocusedRowCellValue(clThamChieu).ToString();
                    miD_NhapKho = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_NhapKhoNPL).ToString());
                    KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang ff = new KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang();
                    ff.Show();
                }
            }
            catch
            {

            }
        }

        private void UC_KhoNVL_frmDaNhapKho_Load(object sender, EventArgs e)
        {
            dteNgay.EditValue = null;
            dteTuNgay.EditValue = null;
            HienThi_ALL();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UC_KhoNVL_frmDaNhapKho_Load(sender, e);
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
