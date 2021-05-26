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
    public partial class KhoBTP_ChiTiet_DaNhapKho : Form
    {
        private void HienThi_Gridcontrol()
        {
            clsKhoBTP_tbChiTietNhapKho cls2 = new clsKhoBTP_tbChiTietNhapKho();
            cls2.iID_NhapKho = UCBanThanhPham_DaNhapKhoTheoLenhSanXuat.miiID_NhapKhoBTP;
            DataTable dt3 = cls2.Select__W_ID_NhapKho_HienThi_SuaDonHang();
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_ChiTietNhapKho", typeof(int));
            dt2.Columns.Add("ID_NhapKho", typeof(int));
            dt2.Columns.Add("ID_VTHH", typeof(int));
            dt2.Columns.Add("SoLuongNhap", typeof(float));
            dt2.Columns.Add("SoLuongTon", typeof(float));
            dt2.Columns.Add("DonGia", typeof(float));

            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("TenVTHH", typeof(string));
            dt2.Columns.Add("DonViTinh", typeof(string));
            
            dt2.Columns.Add("ThanhTien", typeof(float));
            dt2.Columns.Add("HienThi", typeof(string));

            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                Double xxsoluongNHAP = Convert.ToDouble(dt3.Rows[i]["SoLuongNhap"].ToString());
                Double xxsoluongtON = Convert.ToDouble(dt3.Rows[i]["SoLuongTon"].ToString());
                Double xxdongia = Convert.ToDouble(dt3.Rows[i]["DonGia"].ToString());
                DataRow _ravi = dt2.NewRow();
                _ravi["ID_ChiTietNhapKho"] = dt3.Rows[i]["ID_ChiTietNhapKho"].ToString();
                _ravi["ID_NhapKho"] = dt3.Rows[i]["ID_NhapKho"].ToString();
                _ravi["ID_VTHH"] = dt3.Rows[i]["ID_VTHH"].ToString();

                _ravi["SoLuongNhap"] = xxsoluongNHAP;
                _ravi["SoLuongTon"] = xxsoluongtON;
                _ravi["DonGia"] = xxdongia;
                _ravi["MaVT"] = dt3.Rows[i]["ID_VTHH"].ToString();
                _ravi["TenVTHH"] = dt3.Rows[i]["TenVTHH"].ToString();
                _ravi["DonViTinh"] = dt3.Rows[i]["DonViTinh"].ToString();
                _ravi["ThanhTien"] = Convert.ToDecimal(xxsoluongNHAP * xxdongia);
                _ravi["HienThi"] = "1";
                dt2.Rows.Add(_ravi);
            }
            gridControl1.DataSource = dt2;
        }
        
        private void HienThi()
        {
            clsKhoBTP_tbNhapKho cls1 = new clsKhoBTP_tbNhapKho();
            cls1.iID_NhapKhoBTP = UCBanThanhPham_DaNhapKhoTheoLenhSanXuat.miiID_NhapKhoBTP;
            DataTable dt1 = cls1.SelectOne();
            txtSoChungTuNhapKhoNPL.Text = cls1.sSoChungTu.Value;
            dteNgayChungTuNPL.EditValue = cls1.daNgayChungTu.Value;
            gridNguoiLap.EditValue = cls1.iID_NguoiNhap.Value;
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
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=4";
            DataView dvCaTruong = dtNguoi.DefaultView;
            DataTable newdtCaTruong = dvCaTruong.ToTable();

            gridNguoiLap.Properties.DataSource = newdtCaTruong;
            gridNguoiLap.Properties.ValueMember = "ID_NhanSu";
            gridNguoiLap.Properties.DisplayMember = "MaNhanVien";

        }
        public KhoBTP_ChiTiet_DaNhapKho()
        {
            InitializeComponent();
        }

        private void KhoBTP_ChiTiet_DaNhapKho_Load(object sender, EventArgs e)
        {
            Load_LockUp();
            HienThi();
        }

        private void btThoat2_Click(object sender, EventArgs e)
        {
            this.Close();
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
                clsncc.iID_NhanSu = Convert.ToInt16(gridNguoiLap.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtNguoiMuaHang.Text = dt.Rows[0]["TenNhanVien"].ToString();

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
    }
}
