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
    public partial class frmChiTietNhapKhoThanhPham_DaNhapKhoTP : Form
    {
        private void Load_lockUP_EDIT()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=8";
            DataView dvCaTruong = dtNguoi.DefaultView;
            DataTable newdtCaTruong = dvCaTruong.ToTable();

            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=4";
            DataView dvnguoilap = dtNguoi.DefaultView;
            DataTable newdtnguoilap = dvnguoilap.ToTable();
            gridNguoiLap.Properties.DataSource = newdtnguoilap;
            gridNguoiLap.Properties.ValueMember = "ID_NhanSu";
            gridNguoiLap.Properties.DisplayMember = "MaNhanVien";


            clsNganHang_TaiKhoanKeToanCon clsme = new clsNganHang_TaiKhoanKeToanCon();
            DataTable dtme = clsme.SelectAll();
            dtme.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=false";
            DataView dvme = dtme.DefaultView;
            DataTable newdtme = dvme.ToTable();

            gridTKCo.Properties.DataSource = newdtme;
            gridTKCo.Properties.ValueMember = "ID_TaiKhoanKeToanCon";
            gridTKCo.Properties.DisplayMember = "SoTaiKhoanCon";


            gridTKNo.Properties.DataSource = newdtme;
            gridTKNo.Properties.ValueMember = "ID_TaiKhoanKeToanCon";
            gridTKNo.Properties.DisplayMember = "SoTaiKhoanCon";

            clsTbDanhMuc_DaiLy cls = new clsTbDanhMuc_DaiLy();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv = dt.DefaultView;
            DataTable dtxx = dv.ToTable();
            gridMaDaiLy.Properties.DataSource = dtxx;
            gridMaDaiLy.Properties.ValueMember = "ID_DaiLy";
            gridMaDaiLy.Properties.DisplayMember = "MaDaiLy";
        }

        private void HienThi_GridConTrolt()
        {
            DataTable dt2 = new DataTable();
            clsKhoThanhPham_tbChiTietNhapKho cls2 = new CtyTinLuong.clsKhoThanhPham_tbChiTietNhapKho();
            cls2.iID_NhapKho_ThanhPham = UCThanhPham_DaNhapKho.miiID_NhapKho_ThanhPham;
            DataTable dtxxxx = cls2.SelectAll_W_ID_NhapKho_HienThiDaNhapKho();
            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("TenVTHH", typeof(string));
            dt2.Columns.Add("DonViTinh", typeof(string));
            dt2.Columns.Add("SoLuongNhap", typeof(float));
            dt2.Columns.Add("DonGia", typeof(float));
            //dt2.Columns.Add("SoLuongTon", typeof(float));
            dt2.Columns.Add("ThanhTien", typeof(float));
           
            for (int i = 0; i < dtxxxx.Rows.Count; i++)
            {
                double soluong, dongia;
                DataRow _ravi = dt2.NewRow();

                int iiDI_Vthh = Convert.ToInt16(dtxxxx.Rows[i]["ID_VTHH"].ToString());

                _ravi["SoLuongNhap"] = Convert.ToDouble(dtxxxx.Rows[i]["SoLuongNhap"].ToString());
                _ravi["DonGia"] = Convert.ToDouble(dtxxxx.Rows[i]["DonGia"].ToString());
                _ravi["MaVT"] = dtxxxx.Rows[i]["MaVT"].ToString();
                _ravi["TenVTHH"] = dtxxxx.Rows[i]["TenVTHH"].ToString();
                _ravi["DonViTinh"] = dtxxxx.Rows[i]["DonViTinh"].ToString();
                soluong = Convert.ToDouble(dtxxxx.Rows[i]["SoLuongNhap"].ToString());
                dongia = Convert.ToDouble(dtxxxx.Rows[i]["DonGia"].ToString());
                _ravi["ThanhTien"] = soluong * dongia;                
                dt2.Rows.Add(_ravi);
            }
            gridControl1.DataSource = dt2;


        }
        private void HienThi()
        {
            clsKhoThanhPham_tbNhapKho cls = new CtyTinLuong.clsKhoThanhPham_tbNhapKho();
            cls.iID_NhapKho_ThanhPham = UCThanhPham_DaNhapKho.miiID_NhapKho_ThanhPham;
            DataTable dt = cls.SelectOne();
            txtDienGiaiNPL.Text = cls.sDienGiai.Value.ToString();
            txtSoChungTu.Text = cls.sSoChungTu.Value.ToString();
            txtTongTienHang.Text = cls.fTongTienHang.Value.ToString();
            dteNgayChungTuNPL.EditValue = cls.daNgayChungTu.Value;
            gridNguoiLap.EditValue = cls.iID_NguoiNhap.Value;
            if (dt.Rows[0]["ID_TKCo"].ToString() != "")
                gridTKCo.EditValue = cls.iID_TKCo.Value;
            if (dt.Rows[0]["ID_TKNo"].ToString() != "")
                gridTKNo.EditValue = cls.iID_TKNo.Value;
            if (dt.Rows[0]["ID_DaiLy"].ToString() != "")
                gridMaDaiLy.EditValue = cls.iID_DaiLy.Value;
            txtThamChieu.Text = cls.sThamChieu.Value.ToString();

            clsNganHang_ChiTietBienDongTaiKhoanKeToan clsnganhang = new CtyTinLuong.clsNganHang_ChiTietBienDongTaiKhoanKeToan();
            clsnganhang.iID_ChungTu = UCThanhPham_DaNhapKho.miiID_NhapKho_ThanhPham;
            clsnganhang.sSoChungTu = txtSoChungTu.Text.ToString();
            clsnganhang.daNgayThang = dteNgayChungTuNPL.DateTime;
            DataTable dtnganhang = clsnganhang.Select_W_iID_ChungTu_sSoChungTu_daNgayThang();
            for (int i = 0; i < dtnganhang.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtnganhang.Rows[i]["BoolTK_Co"].ToString()) == true)
                {
                    txtTienNo.Text = dtnganhang.Rows[i]["Co"].ToString();
                }
                if (Convert.ToBoolean(dtnganhang.Rows[i]["BoolTK_No"].ToString()) == true)
                {
                    txtTienCo.Text = dtnganhang.Rows[i]["No"].ToString();
                }

            }

        }
        public frmChiTietNhapKhoThanhPham_DaNhapKhoTP()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChiTietNhapKhoThanhPham_DaNhapKhoTP_Load(object sender, EventArgs e)
        {
            Load_lockUP_EDIT();
            HienThi();
            HienThi_GridConTrolt();
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
                    txtNguoiXuatKho.Text = dt.Rows[0]["TenNhanVien"].ToString();

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

        private void txtTongTienHang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtTongTienHang.Text);
                txtTongTienHang.Text = String.Format("{0:#,##0.00}", value);
            }
            catch
            {
            }
        }

        private void txtTienCo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtTienCo.Text);
                txtTienCo.Text = String.Format("{0:#,##0.00}", value);
            }
            catch
            {
            }
        }

        private void txtTienNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtTienNo.Text);
                txtTienNo.Text = String.Format("{0:#,##0.00}", value);
            }
            catch
            {
            }
        }

        private void gridMaDaiLy_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsTbDanhMuc_DaiLy clsncc = new clsTbDanhMuc_DaiLy();
                clsncc.iID_DaiLy = Convert.ToInt16(gridMaDaiLy.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenDaiLy.Text = dt.Rows[0]["TenDaiLy"].ToString();
                }

             
            }
            catch
            {

            }
        }
    }
}
