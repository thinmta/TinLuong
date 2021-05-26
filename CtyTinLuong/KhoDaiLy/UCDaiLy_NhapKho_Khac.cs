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
    public partial class UCDaiLy_NhapKho_Khac : UserControl
    {

        public static int miID_NhapKho;
        public static bool mbThemMoi_NhapKho;
        private void HienThi()
        {
            if (dteTuNgay.EditValue != null & dteNgay.EditValue != null)
            {
                DateTime denngay = dteNgay.DateTime;
                DateTime tungay = dteTuNgay.DateTime;
                clsKhoBTP_tbNhapKho cls = new CtyTinLuong.clsKhoBTP_tbNhapKho();
                DataTable dt2 = cls.SelectAll();
                dt2.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=false and Check_NhapKho_Khac=True";
                DataView dv = dt2.DefaultView;
                dv.Sort = "NgayChungTu DESC, ID_NhapKhoBTP DESC";
                DataTable dt = dv.ToTable();


                dt.DefaultView.RowFilter = " NgayChungTu<='" + denngay + "'";
                DataView dvxxx = dt.DefaultView;
                DataTable dt22 = dvxxx.ToTable();
                dt22.DefaultView.RowFilter = " NgayChungTu>='" + tungay + "'";
                DataView dv2 = dt22.DefaultView;
                dv2.Sort = "DaNhapKho ASC, NgayChungTu DESC, ID_NhapKhoBTP DESC";
                DataTable dxxxx = dv2.ToTable();

                gridControl1.DataSource = dxxxx;
            }

        }
        private void HienThi_ALL()
        {
            clsKhoBTP_tbNhapKho cls = new CtyTinLuong.clsKhoBTP_tbNhapKho();
            DataTable dt2 = cls.SelectAll();
            dt2.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=false and Check_NhapKho_Khac=True";
            DataView dv = dt2.DefaultView;
            dv.Sort = "DaNhapKho ASC, NgayChungTu DESC, ID_NhapKhoBTP DESC";
            DataTable dxxxx = dv.ToTable();
            gridControl1.DataSource = dxxxx;


        }

        public UCDaiLy_NhapKho_Khac()
        {
            InitializeComponent();
        }

        private void UCDaiLy_NhapKho_Khac_Load(object sender, EventArgs e)
        {
            dteNgay.EditValue = null;
            dteTuNgay.EditValue = null;
            HienThi_ALL();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UCDaiLy_NhapKho_Khac_Load( sender,  e);
        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            if (dteNgay.EditValue != null & dteTuNgay.EditValue != null)
            {
                HienThi();
            }
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

            if (gridView1.GetFocusedRowCellValue(clID_NhapKhoBTP).ToString() != "")
            {
                mbThemMoi_NhapKho = false;
                miID_NhapKho = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_NhapKhoBTP).ToString());
                DaiLy_ChiTiet_NhapKho_Khac ff = new DaiLy_ChiTiet_NhapKho_Khac();
                ff.Show();
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool category = Convert.ToBoolean(View.GetRowCellValue(e.RowHandle, View.Columns["DaNhapKho"]));
                if (category == false)
                {
                    e.Appearance.BackColor = Color.Bisque;

                }
            }
        }

        private void btThemMoi_Click(object sender, EventArgs e)
        {
            mbThemMoi_NhapKho = true;
            DaiLy_ChiTiet_NhapKho_Khac ff = new DaiLy_ChiTiet_NhapKho_Khac();
            ff.Show();
        }
    }
}
