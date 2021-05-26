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
    public partial class UC_SanXuat_LenhSanXuat : UserControl
    {
        public static int mID_iD_LenhSanXuat;
        public static bool mb_ThemMoi_LenhSanXuat;
        
       private void HienThi()
        {
            clsHUU_LenhSanXuat cls = new clsHUU_LenhSanXuat();
            DataTable dt = cls.SelectAll_W_TenCoNhan();

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
        public UC_SanXuat_LenhSanXuat()
        {
            InitializeComponent();
        }

        
        private void UC_SanXuat_LenhSanXuat_Load(object sender, EventArgs e)
        {
            
            clNgungTheoDoi.Caption = "Bỏ\ntheo dõi";
            clCaSanXuat.Caption = "Ca\n làm việc";
            checkALL.Checked = true;
            mb_ThemMoi_LenhSanXuat = false;
            HienThi();
        }

        private void btThemMoi_Click(object sender, EventArgs e)
        {
            mb_ThemMoi_LenhSanXuat = true;
            SanXuat_frmChiTietLenhSanXuat ff = new SanXuat_frmChiTietLenhSanXuat();
            ff.Show();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UC_SanXuat_LenhSanXuat_Load(sender, e);
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
                    mb_ThemMoi_LenhSanXuat = false;                   
                    mID_iD_LenhSanXuat = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_LenhSanXuat).ToString());                 
                    SanXuat_frmChiTietLenhSanXuat ff = new SanXuat_frmChiTietLenhSanXuat();
                    ff.Show();
                }
            }
            catch
            {

            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Xóa dữ liệu này?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (traloi == DialogResult.Yes)
            {
                if(gridView1.GetFocusedRowCellValue(clID_LenhSanXuat).ToString()=="")
                {
                    MessageBox.Show("Vui lòng chọn lại");
                }
                else
                {
                    clsHUU_LenhSanXuat cls1 = new clsHUU_LenhSanXuat();
                    cls1.iID_LenhSanXuat = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clID_LenhSanXuat).ToString());
                    cls1.Delete_W_TonTai();
                    MessageBox.Show("Đã xóa");
                    HienThi();
                }
               
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                clsPhieu_tbPhieu cls = new clsPhieu_tbPhieu();
                cls.iID_SoPhieu = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_LenhSanXuat).ToString());
                cls.bNgungTheoDoi = Convert.ToBoolean(gridView1.GetFocusedRowCellValue(clNgungTheoDoi).ToString());
                cls.Update_NgungTheoDoi();
            }
            catch
            {

            }
        }

        private void btThemMoi_Click_1(object sender, EventArgs e)
        {
                //mb_ThemMoi_LenhSanXuat = true;                
                //SanXuat_frmChiTietLenhSanXuat ff = new SanXuat_frmChiTietLenhSanXuat();
                //ff.Show();
        }

        private void checkMayIN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMayIN.Checked == true)
            {
                //clboolMayIn.Visible = true;
                //clboolMayCat.Visible = false;
                //clboolMayDot.Visible = false;
               
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
                //clboolMayIn.Visible = false;
                //clboolMayCat.Visible = true;
                //clboolMayDot.Visible = false;

               
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
                //clboolMayIn.Visible = false;
                //clboolMayCat.Visible = false;
                //clboolMayDot.Visible = true;
             

                checkMayIN.Checked = false;
                checkMayCat.Checked = false;
                checkALL.Checked = false;
            }
            HienThi();
        }

        private void checkALL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkALL.Checked == true)
            {
                //clboolMayIn.Visible = true;
                //clboolMayCat.Visible = true;
                //clboolMayDot.Visible = true;
               
                checkMayDOT.Checked = false;
                checkMayIN.Checked = false;
                checkMayCat.Checked = false;

            }
            HienThi();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //GridView View = sender as GridView;
            //if (e.RowHandle >= 0)
            //{
            //    bool category = Convert.ToBoolean(View.GetRowCellValue(e.RowHandle, View.Columns["GuiDuLieu"]));
            //    if (category == false)
            //    {
            //        e.Appearance.BackColor = Color.Bisque;

            //    }
            //}
        }
    }
}
