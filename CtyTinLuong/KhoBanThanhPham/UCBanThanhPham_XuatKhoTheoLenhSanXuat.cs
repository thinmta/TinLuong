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
    public partial class UCBanThanhPham_XuatKhoTheoLenhSanXuat : UserControl
    {
        public static int mID_iD_LenhSanXuat;

        private void HienThi()
        {
            clsHUU_LenhSanXuat cls = new clsHUU_LenhSanXuat();
            DataTable dt = cls.SelectAll_Xuat_Kho_KhoBanThanhPham_Tat_CA();

            if (checkALL.Checked == true)
            {
                dt.DefaultView.RowFilter = " TonTai= True";
            }
            else
            {
                if (checkMayIN.Checked == true)
                {
                    dt.DefaultView.RowFilter = " TonTai= True and ID_LoaiMay=1";

                }
                else if (checkMayCat.Checked == true)
                {
                    dt.DefaultView.RowFilter = " TonTai= True and ID_LoaiMay=2";

                }
                else
                {
                    dt.DefaultView.RowFilter = " TonTai= True and ID_LoaiMay=3";
                }

            }
            DataView dv = dt.DefaultView;
            dv.Sort = "NgayThangSanXuat DESC, CaSanXuat DESC, ID_LenhSanXuat ASC";
            DataTable dxxxx = dv.ToTable();
            gridControl1.DataSource = dxxxx;
        }
        public UCBanThanhPham_XuatKhoTheoLenhSanXuat()
        {
            InitializeComponent();
        }

        private void UCBanThanhPham_XuatKhoTheoLenhSanXuat_Load(object sender, EventArgs e)
        {
            checkALL.Checked = true;
            HienThi();
        }

        private void btfresh_Click(object sender, EventArgs e)
        {
            UCBanThanhPham_XuatKhoTheoLenhSanXuat_Load( sender,  e);
        }

        private void checkALL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkALL.Checked == true)
            {
                checkMayDOT.Checked = false;
                checkMayIN.Checked = false;
                checkMayCat.Checked = false;
            }
            HienThi();
        }

        private void checkMayIN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMayIN.Checked == true)
            {
                checkMayDOT.Checked = false;
                checkMayCat.Checked = false;
                checkALL.Checked = false;
            }
            HienThi();
        }

        private void checkMayCat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMayCat.Checked == true)
            {
                checkMayDOT.Checked = false;
                checkMayIN.Checked = false;
                checkALL.Checked = false;
            }
            HienThi();
        }

        private void checkMayDOT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMayDOT.Checked == true)
            {
                checkMayIN.Checked = false;
                checkMayCat.Checked = false;
                checkALL.Checked = false;
            }
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
            try
            {
                if (gridView1.GetFocusedRowCellValue(clID_LenhSanXuat).ToString() != "")
                {
                    mID_iD_LenhSanXuat = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_LenhSanXuat).ToString());
                    int iiD_LoaiMay = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_LoaiMay).ToString());
                    if (iiD_LoaiMay == 1)
                    {
                        //KhoBTP_ChiTietNhapKhoTheoLenhSanXuat_May_IN ff = new KhoBTP_ChiTietNhapKhoTheoLenhSanXuat_May_IN();
                        //ff.Show();
                    }
                    else if (iiD_LoaiMay == 2)
                    {
                        KhoBTP_ChiTiet_XuatKho_TheoLenhSanXuat_May_CAT ff = new KhoBTP_ChiTiet_XuatKho_TheoLenhSanXuat_May_CAT();
                        ff.Show();
                    }
                    else if (iiD_LoaiMay == 3)
                    {
                        KhoBTP_ChiTiet_XuatKho_TheoLenhSanXuat_May_DOT ff = new KhoBTP_ChiTiet_XuatKho_TheoLenhSanXuat_May_DOT();
                        ff.Show();
                    }
                    //KhoBTP_ChiTiet_XuatKho_TheoLenhSanXuat_May_DOT
                }
            }
            catch
            {

            }
        }
    }
}
