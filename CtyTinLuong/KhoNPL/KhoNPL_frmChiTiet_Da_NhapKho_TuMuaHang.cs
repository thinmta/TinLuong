using DevExpress.Data.Filtering;
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
    public partial class KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang : Form
    {
        public static bool mbPrint_Chitiet_Da_NhapKho_TuMuaHang;
        public static DateTime mdaNgayMuaHang, mdaNgayNhapKho;
        public static DataTable mdt_ChiTietNhapKho;
        public static double mdeTongTienHang_KhongVAT, mdeTienNo, mdeTienCo, mdeTienVAT, mdeTongTienHang_CoVAT;
        public static string msSoChungTu_MuaHang, msSoHoaDon_MuaHang, msSoChungTu_NhapKho, msNguoiMuaHang, msThuKho, msTKNo, msTKCo, msTKVAT;

        private void HienThi_Gridcontrol()
        {
            clsKhoNPL_tbChiTietNhapKho cls2 = new clsKhoNPL_tbChiTietNhapKho();
            cls2.iID_NhapKho = UC_KhoNVL_frmDaNhapKho.miD_NhapKho;
            DataTable dt3 = cls2.Select_W_ID_NhapKho_HienThi_SuaDonHang();
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_ChiTietNhapKho"); // ID của tbChi tiet don hàng
            dt2.Columns.Add("ID_NhapKho");
            dt2.Columns.Add("ID_VTHH");
            dt2.Columns.Add("SoLuong", typeof(float));
            dt2.Columns.Add("DonGia", typeof(decimal));

            dt2.Columns.Add("MaVT");// tb VTHH
            dt2.Columns.Add("TenVTHH");
            dt2.Columns.Add("DonViTinh");
            dt2.Columns.Add("GhiChu");

            dt2.Columns.Add("ThanhTien", typeof(decimal));
            dt2.Columns.Add("HienThi", typeof(string));

            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                Decimal xxsoluong = Convert.ToDecimal(dt3.Rows[i]["SoLuongNhap"].ToString());
                Decimal xxdongia = Convert.ToDecimal(dt3.Rows[i]["DonGia"].ToString());
                DataRow _ravi = dt2.NewRow();
                _ravi["ID_ChiTietNhapKho"] = dt3.Rows[i]["ID_ChiTietNhapKho"].ToString();
                _ravi["ID_NhapKho"] = dt3.Rows[i]["ID_NhapKho"].ToString();
                _ravi["ID_VTHH"] = dt3.Rows[i]["ID_VTHH"].ToString();

                _ravi["SoLuong"] = xxsoluong;
                _ravi["DonGia"] = xxdongia;
                _ravi["MaVT"] = dt3.Rows[i]["ID_VTHH"].ToString();
                _ravi["TenVTHH"] = dt3.Rows[i]["TenVTHH"].ToString();
                _ravi["DonViTinh"] = dt3.Rows[i]["DonViTinh"].ToString();
                _ravi["ThanhTien"] = Convert.ToDecimal(xxsoluong * xxdongia);
                _ravi["HienThi"] = "1";
                _ravi["GhiChu"] = dt3.Rows[i]["GhiChu"].ToString();
                dt2.Rows.Add(_ravi);
            }
            gridControl1.DataSource = dt2;
        }


        private void HienThi()
        {
            clsKhoNPL_tbNhapKho cls1 = new clsKhoNPL_tbNhapKho();
            cls1.iID_NhapKho = UC_KhoNVL_frmDaNhapKho.miD_NhapKho;
            DataTable dt1 = cls1.SelectOne();
            txtSoChungTuNhapKhoNPL.Text = cls1.sSoChungTu.Value;
            dteNgayChungTuNPL.EditValue = cls1.daNgayChungTu.Value;
            gridNguoiLap.EditValue = cls1.iID_NguoiNhapKho.Value;
            txtDienGiaiNhapKhoNPL.Text = cls1.sDienGiai.Value;
            txtTongTienHangCoVAT.Text = cls1.fTongTienHang.Value.ToString();
           
            HienThi_Gridcontrol();
        }
        private void Load_LockUp()
        {
            clsTbVatTuHangHoa clsvthhh = new clsTbVatTuHangHoa();
            DataTable dtvthh = clsvthhh.SelectAll();
            dtvthh.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvvthh = dtvthh.DefaultView;
            DataTable newdtvthh = dvvthh.ToTable();


            repositoryItemLookUpEdit1.DataSource = newdtvthh;
            repositoryItemLookUpEdit1.ValueMember = "ID_VTHH";
            repositoryItemLookUpEdit1.DisplayMember = "MaVT";



            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=5";
            DataView dvCaTruong = dtNguoi.DefaultView;
            DataTable newdtCaTruong = dvCaTruong.ToTable();

            gridNguoiLap.Properties.DataSource = newdtCaTruong;
            gridNguoiLap.Properties.ValueMember = "ID_NhanSu";
            gridNguoiLap.Properties.DisplayMember = "MaNhanVien";

        }
        public KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang()
        {
            InitializeComponent();
        }

        
        private void KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang_Load_1(object sender, EventArgs e)
        {

            mbPrint_Chitiet_Da_NhapKho_TuMuaHang = false;
            Load_LockUp();
            HienThi();
        }

        private void btThoat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void txtTongTienHangCoVAT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtTongTienHangCoVAT.Text);
                txtTongTienHangCoVAT.Text = String.Format("{0:#,##0.00}", value);
            }
            catch
            {

            }
        }

        private void gridNguoiLap_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt32(gridNguoiLap.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtNguoNhap.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }

            }
            catch
            {

            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            mbPrint_Chitiet_Da_NhapKho_TuMuaHang = true;
            DataTable DatatableABC = (DataTable)gridControl1.DataSource;
            CriteriaOperator op = gridView1.ActiveFilterCriteria; // filterControl1.FilterCriteria
            string filterString = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(op);
            DataView dv1212 = new DataView(DatatableABC);
            dv1212.RowFilter = filterString;
            DataTable dttttt2 = dv1212.ToTable();
            string shienthi = "1";
            dttttt2.DefaultView.RowFilter = "HienThi=" + shienthi + "";
            DataView dv = dttttt2.DefaultView;
            mdt_ChiTietNhapKho = dv.ToTable();
          
            mdaNgayNhapKho = dteNgayChungTuNPL.DateTime;         
            msSoChungTu_NhapKho = txtSoChungTuNhapKhoNPL.Text.ToString();
            clsKhoNPL_tbNhapKho cls1 = new clsKhoNPL_tbNhapKho();
            cls1.iID_NhapKho = UC_KhoNVL_frmDaNhapKho.miD_NhapKho;
            DataTable dt1 = cls1.SelectOne();
            string sochungtumuahang = cls1.sThamChieu.Value;
            clsMH_tbMuaHang cls2 = new clsMH_tbMuaHang();
            cls2.sSoChungTu = sochungtumuahang;
            DataTable dt2 = cls2.SelectOne_W_SoChungTu();
            msSoChungTu_MuaHang = sochungtumuahang;
            msThuKho = txtNguoNhap.Text.ToString();
            mdaNgayMuaHang = Convert.ToDateTime(dt2.Rows[0]["NgayChungTu"].ToString());
            int iID_NguoiMua = Convert.ToInt32(dt2.Rows[0]["ID_NguoiMua"].ToString());
            clsNhanSu_tbNhanSu cls3 = new clsNhanSu_tbNhanSu();
            cls3.iID_NhanSu = iID_NguoiMua;
            DataTable dt3 = cls3.SelectOne();
            msNguoiMuaHang = cls3.sTenNhanVien.Value;
            frmPrint_NhapKho_KhoNPL ff = new frmPrint_NhapKho_KhoNPL();
            ff.Show();

        }

        private void KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            mbPrint_Chitiet_Da_NhapKho_TuMuaHang = false;
        }
    }
}
