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
    public partial class UCNPL_XuatKho_TheoLenhSanXuat_mayIN : UserControl
    {
        public static int mID_iD_LenhSanXuat;
      
        private void HienThi()
        {
            clsHUU_LenhSanXuat cls = new clsHUU_LenhSanXuat();
            DataTable dt = cls.SelectAll_XuatkhoNPL();

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
            dv.Sort = "NgayThangSanXuat DESC, CaSanXuat DESC, ID_LenhSanXuat DESC";
            DataTable dxxxx = dv.ToTable();
            gridControl1.DataSource = dxxxx;
        }
        public UCNPL_XuatKho_TheoLenhSanXuat_mayIN()
        {
            InitializeComponent();
        }

        private void UCNPL_XuatKho_TheoLenhSanXuat_mayIN_Load(object sender, EventArgs e)
        {
            checkALL.Checked = true;
            HienThi();
        }

        private void btfresh_Click(object sender, EventArgs e)
        {
            UCNPL_XuatKho_TheoLenhSanXuat_mayIN_Load(sender, e);
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.GetFocusedRowCellValue(clID_LenhSanXuat).ToString() != "")
                {

                    mID_iD_LenhSanXuat = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_LenhSanXuat).ToString());
                    NPL_ChiTietLenhSanXuat ff = new NPL_ChiTietLenhSanXuat();
                    ff.Show();
                }
            }
            catch
            {

            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
