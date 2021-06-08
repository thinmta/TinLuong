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
    public partial class SanLuong_ChiTiet_Luong : Form
    {
        private void Load_LockUp()
        {
            

            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvCaTruong = dtNguoi.DefaultView;
            DataTable newdtCaTruong = dvCaTruong.ToTable();

            gridCongNhan.Properties.DataSource = newdtCaTruong;
            gridCongNhan.Properties.ValueMember = "ID_NhanSu";
            gridCongNhan.Properties.DisplayMember = "MaNhanVien";

          
        }

        private void LoadData(int iiDcongnnhan, DateTime xxtungay, DateTime xxdenngay)
        {
            gridControl1.DataSource = null;
            DataTable dt = new DataTable();
            clsPhieu_ChiTietPhieu_New cls = new clsPhieu_ChiTietPhieu_New();
            dt = cls.SelectAll_W_ID_VTHH_Ra_TenCN_NgayThang_DOT(iiDcongnnhan, xxtungay, xxdenngay);
            if (dt.Rows.Count > 0)
                gridControl1.DataSource = dt;

        }
        public SanLuong_ChiTiet_Luong()
        {
            InitializeComponent();
        }

        private void gridView2_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridCongNhan_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt32(gridCongNhan.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();

                txtHoTen.Text = clsncc.sTenNhanVien.Value;
                int xxID = Convert.ToInt32(gridCongNhan.EditValue.ToString());
                LoadData(xxID, dteTuNgay.DateTime, dteDenNgay.DateTime);

            }
            catch
            {

            }
        }

        private void SanLuong_ChiTiet_Luong_Load(object sender, EventArgs e)
        {
            Load_LockUp();
            dteTuNgay.EditValue = SanLuong_To_DOT_DAP.mdatungay;
            dteDenNgay.EditValue = SanLuong_To_DOT_DAP.mdadenngay;
            gridCongNhan.EditValue = SanLuong_To_DOT_DAP.miID_VTHH_Ra;

            LoadData(SanLuong_To_DOT_DAP.miID_VTHH_Ra, SanLuong_To_DOT_DAP.mdatungay, SanLuong_To_DOT_DAP.mdadenngay);
        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            if (dteDenNgay.EditValue != null & dteTuNgay.EditValue != null)
            {
                int xxID = Convert.ToInt32(gridCongNhan.EditValue.ToString());
                LoadData(xxID, dteTuNgay.DateTime, dteDenNgay.DateTime);

            }
        }

        private void btRefesh_Click(object sender, EventArgs e)
        {
            SanLuong_ChiTiet_Luong_Load( sender,  e);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            //DataTable DatatableABC = (DataTable)gridControl1.DataSource;
            //CriteriaOperator op = gridView2.ActiveFilterCriteria; // filterControl1.FilterCriteria
            //string filterString = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(op);
            //DataView dv1212 = new DataView(DatatableABC);
            //dv1212.RowFilter = filterString;
            //mdtPrint = dv1212.ToTable();

            //if (mdtPrint.Rows.Count > 0)
            //{
            //    mbPrint = true;
            //    mdatungay = dteTuNgay.DateTime;
            //    mdadenngay = dteDenNgay.DateTime;
            //    miID_VThh = Convert.ToInt32(GridMaVT.EditValue.ToString());
            //    msMaVT = GridMaVT.Text.ToString();
            //    msTenVT = txtTenVTHH.Text;
            //    msDVT = txtDVT.Text;
            //    clsPhieu_ChiTietPhieu_New cls = new clsPhieu_ChiTietPhieu_New();
            //    DataTable dt3 = new DataTable();
                //if (xxximay_in_1_Cat_2_dot_3 == 1)
                //    dt3 = cls.Select_SUM_SanLuong_W_IDVTHH_NgayThang_IN(miID_VThh, mdatungay, mdadenngay);
                //else if (xxximay_in_1_Cat_2_dot_3 == 2)
                //    dt3 = cls.Select_SUM_SanLuong_W_IDVTHH_NgayThang_CAT(miID_VThh, mdatungay, mdadenngay);

                //sanluongthuowng = Convert.ToDouble(dt3.Rows[0]["SanLuong_Thuong"].ToString());
                //sanluongtangca = Convert.ToDouble(dt3.Rows[0]["SanLuong_TangCa"].ToString());
                //sanluongtong = Convert.ToDouble(dt3.Rows[0]["SanLuong_Tong"].ToString());
                //phepham = Convert.ToDouble(dt3.Rows[0]["PhePham"].ToString());
                //frmPrint_SanLuongToMayIn ff = new frmPrint_SanLuongToMayIn();
                //ff.Show();

            //}
        }
    }
}
