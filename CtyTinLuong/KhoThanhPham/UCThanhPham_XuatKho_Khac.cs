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
    public partial class UCThanhPham_XuatKho_Khac : UserControl
    {

        public static int miID_XuatKho;
        public static bool mbThemMoi_XuatKho;
        private void HienThi()
        {
            if (dteTuNgay.EditValue != null & dteNgay.EditValue != null)
            {
                DateTime denngay = dteNgay.DateTime;
                DateTime tungay = dteTuNgay.DateTime;
                clsKhoThanhPham_tbXuatKho cls = new CtyTinLuong.clsKhoThanhPham_tbXuatKho();
                DataTable dt2 = cls.SelectAll();
                dt2.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=false and Check_XuatKho_Khac=True";
                DataView dv = dt2.DefaultView;
                //dv.Sort = "NgayChungTu DESC, ID_XuatKhoBTP DESC";
                DataTable dt = dv.ToTable();


                dt.DefaultView.RowFilter = " NgayChungTu<='" + denngay + "'";
                DataView dvxxx = dt.DefaultView;
                DataTable dt22 = dvxxx.ToTable();
                dt22.DefaultView.RowFilter = " NgayChungTu>='" + tungay + "'";
                DataView dv2 = dt22.DefaultView;
                dv2.Sort = "DaXuatKho ASC, NgayChungTu DESC, ID_XuatKho_ThanhPham DESC";
                DataTable dxxxx = dv2.ToTable();

                gridControl1.DataSource = dxxxx;
            }

        }
        private void HienThi_ALL()
        {
            clsKhoThanhPham_tbXuatKho cls = new CtyTinLuong.clsKhoThanhPham_tbXuatKho();
            DataTable dt2 = cls.SelectAll();
            dt2.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=false and Check_XuatKho_Khac=True";
            DataView dv = dt2.DefaultView;
            dv.Sort = "DaXuatKho ASC, NgayChungTu DESC, ID_XuatKho_ThanhPham DESC";
            DataTable dxxxx = dv.ToTable();
            gridControl1.DataSource = dxxxx;


        }
        public UCThanhPham_XuatKho_Khac()
        {
            InitializeComponent();
        }

        private void UCThanhPham_XuatKho_Khac_Load(object sender, EventArgs e)
        {
            dteNgay.EditValue = null;
            dteTuNgay.EditValue = null;
            HienThi_ALL();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UCThanhPham_XuatKho_Khac_Load( sender,  e);
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
            if (gridView1.GetFocusedRowCellValue(clID_XuatKho_ThanhPham).ToString() != "")
            {
                mbThemMoi_XuatKho = false;
                miID_XuatKho = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_XuatKho_ThanhPham).ToString());
                KhoThanhPham_ChiTiet_XuatKho_Khac ff = new KhoThanhPham_ChiTiet_XuatKho_Khac();
                ff.Show();
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool category = Convert.ToBoolean(View.GetRowCellValue(e.RowHandle, View.Columns["DaXuatKho"]));
                if (category == false)
                {
                    e.Appearance.BackColor = Color.Bisque;

                }
            }
        }

        private void btThemMoi_Click(object sender, EventArgs e)
        {
            mbThemMoi_XuatKho = true;
            KhoThanhPham_ChiTiet_XuatKho_Khac ff = new KhoThanhPham_ChiTiet_XuatKho_Khac();
            ff.Show();
        }
    }
}
