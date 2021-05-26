using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtyTinLuong
{
    public partial class frmBoSungCongNhanMay_Dot : Form
    {
        private void LuuDuLieu()
        {
            DataTable dv3 = (DataTable)gridControl1.DataSource;
            clsPhieu_ChiTietPhieu_New_BoSungCongNhan_MayDot cls1 = new CtyTinLuong.clsPhieu_ChiTietPhieu_New_BoSungCongNhan_MayDot();
            cls1.iID_SoPhieu = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.MIiiiid_SoPhieu;           
            cls1.Delete_All_W_ID_SoPhieu();

            for (int i = 0; i < dv3.Rows.Count; i++)
            {
                cls1.iID_SoPhieu = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.MIiiiid_SoPhieu;
                cls1.iID_CongNhan = Convert.ToInt32(dv3.Rows[i]["ID_CongNhan"].ToString());
                cls1.iID_CaTruong = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.mi_ID_Catruong;
                cls1.daNgaySanXuat = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.mdaNgaySanXuatDot;
                cls1.sCaSanXuat = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.msCaSXDot;
                cls1.bGuiDuLieu = true;
                cls1.bCheck_MayDot_True_May_Cat_False = true; 
                cls1.Insert();
            }

        }
        private void Load_LockUp()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=11";
            DataView dvCaTruong = dtNguoi.DefaultView;
            DataTable newdtCaTruong = dvCaTruong.ToTable();

            gridMaNhanVien.DataSource = newdtCaTruong;
            gridMaNhanVien.ValueMember = "ID_NhanSu";
            gridMaNhanVien.DisplayMember = "MaNhanVien";

           
        }
        private void HienThi()
        {
            Load_LockUp();
            dteNgaySanXuat_May_DOT.EditValue = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.mdaNgaySanXuatDot;
            cbCaSanXuat_May_DOT.Text = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.msCaSXDot.ToString();

            clsNhanSu_tbNhanSu cls1 = new clsNhanSu_tbNhanSu();
            cls1.iID_NhanSu = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.mi_ID_COngNhanh_MayDot_ToTruong;
            DataTable dt1 = cls1.SelectOne();
            txtToTruong.Text = cls1.sTenNhanVien.Value;

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_ChiTietPhieu_BoSungMayDot"); // ID của tbChi tiet don hàng
            dt2.Columns.Add("ID_SoPhieu");
            dt2.Columns.Add("ID_CongNhan");
            dt2.Columns.Add("NgaySanXuat", typeof(DateTime));
            dt2.Columns.Add("CaSanXuat", typeof(string));
            dt2.Columns.Add("TenNhanVien");
            dt2.Columns.Add("HienThi", typeof(string));
            dt2.Columns.Add("MaNhanVien", typeof(string));
            clsPhieu_ChiTietPhieu_New_BoSungCongNhan_MayDot cls = new CtyTinLuong.clsPhieu_ChiTietPhieu_New_BoSungCongNhan_MayDot();
            cls.iID_SoPhieu = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.MIiiiid_SoPhieu;
            DataTable dt3 = cls.SelectAll_W_ID_SoPhieu();
            if(dt3.Rows.Count>0)
            {
            
                for (int i = 0; i < dt3.Rows.Count; i++)
                {                   
                    DataRow _ravi = dt2.NewRow();
                    _ravi["ID_ChiTietPhieu_BoSungMayDot"] = dt3.Rows[i]["ID_ChiTietPhieu_BoSungMayDot"].ToString();
                    _ravi["ID_SoPhieu"] = dt3.Rows[i]["ID_SoPhieu"].ToString();
                    _ravi["ID_CongNhan"] = dt3.Rows[i]["ID_CongNhan"].ToString();
                    _ravi["MaNhanVien"] = dt3.Rows[i]["ID_CongNhan"].ToString();
                    _ravi["TenNhanVien"] = dt3.Rows[i]["TenNhanVien"].ToString();                    
                    _ravi["HienThi"] = "1";
                    dt2.Rows.Add(_ravi);
                }              
                             
            }
            gridControl1.DataSource = dt2;
        }
        public frmBoSungCongNhanMay_Dot()
        {
            InitializeComponent();
        }

        private void frmBoSungCongNhanMay_Dot_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            LuuDuLieu();
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == clMaNhanVien)
            {
                clsNhanSu_tbNhanSu cls = new clsNhanSu_tbNhanSu();
                cls.iID_NhanSu = Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, e.Column));
                int kk = Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, e.Column));
                DataTable dt = cls.SelectOne();
                if (dt != null)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clID_CongNhan, kk);
                    gridView1.SetRowCellValue(e.RowHandle, clTenNhanVien, cls.sTenNhanVien.Value);                   
                    gridView1.SetRowCellValue(e.RowHandle, clHienThi, "1");
                   
                }
            }
        }

        private void gridView1_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            GridView view = sender as GridView;
            DataView dv = view.DataSource as DataView;
            if (dv[e.ListSourceRow]["HienThi"].ToString().Trim() == "0")
            {
                e.Visible = false;
                e.Handled = true;
            }
        }

        private void btXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, clHienThi, "0");
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, clTenNhanVien, "");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, clHienThi, "0");
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, clTenNhanVien, "");
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
