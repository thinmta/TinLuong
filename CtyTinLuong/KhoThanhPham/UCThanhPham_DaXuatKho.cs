﻿using System;
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

    public partial class UCThanhPham_DaXuatKho : UserControl
    {

        public static int miiID_XuatKho_ThanhPham;
        private void HienThi()
        {
            clsKhoThanhPham_tbXuatKho cls = new CtyTinLuong.clsKhoThanhPham_tbXuatKho();
            DataTable dt2 = cls.SelectAll();
            dt2.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=false";
            DataView dv = dt2.DefaultView;
            dv.Sort = "NgayChungTu DESC, ID_XuatKho_ThanhPham DESC";
            DataTable dxxxx = dv.ToTable();
            gridControl1.DataSource = dxxxx;
        }
        public UCThanhPham_DaXuatKho()
        {
            InitializeComponent();
        }

        private void UCThanhPham_DaXuatKho_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UCThanhPham_DaXuatKho_Load( sender,  e);
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
                if (gridView1.GetFocusedRowCellValue(clID_XuatKho_ThanhPham).ToString() != "")
                {
                    miiID_XuatKho_ThanhPham = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_XuatKho_ThanhPham).ToString());
                    KhoThanhPham_frmChiTiet_Da_XuatKho ff = new KhoThanhPham_frmChiTiet_Da_XuatKho();
                    ff.Show();
                }
            }
            catch
            {

            }
        }
    }
}
