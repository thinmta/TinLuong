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
    public partial class SanXuat_frmChiTietSoPhieu_CAT : Form
    {
        bool bthemmoi_chietiet_may_CAT;
        int iiiID_ChiTietPhieuMay_CAT;    
        private void Luu_Va_GuiDuLieu()
        {
            if (!KiemTraLuu_May_CAT()) return;
            else
            {
                clsPhieu_ChiTietPhieu_May_CAT cls = new clsPhieu_ChiTietPhieu_May_CAT();
                cls.iID_SoPhieu = UC_SanXuat_PhieuSanXuat.mID_iD_SoPhieu;
                if (bthemmoi_chietiet_may_CAT == true) // themmoi
                {
                    //cls.iID_VTHH_Vao_May_CAT = Convert.ToInt16(gridHangHoaVao_may_CAT.EditValue.ToString());
                    //cls.iID_May_CAT = Convert.ToInt16(gridMaMay_CAT.EditValue.ToString());
                    //cls.iID_CongNhan_May_CAT = Convert.ToInt16(gridMaCongNhan_May_CAT.EditValue.ToString());
                    //cls.iID_DinhMuc_Luong_SanLuong_May_CAT = Convert.ToInt16(gridDinhMucSLMay_CAT.EditValue.ToString());
                    //cls.fSoLuongNhap_May_CAT = Convert.ToDouble(txtSoLuongNhap_May_CAT.Text.ToString());
                    //cls.fDonGiaNhap_May_CAT = Convert.ToDouble(txtDonGiaNhap_May_CAT.Text.ToString());
                    //cls.fSanLuongThuong_May_CAT = Convert.ToDouble(txtSanLuong_may_CAT.Text.ToString());
                    //cls.fSanLuongTong_May_CAT = Convert.ToDouble(txtSanLuongTong_May_CAT.Text.ToString());
                    //cls.fDonGiaXuat_May_CAT = Convert.ToDouble(txtDonGiaXuat_May_CAT.Text.ToString());
                    //cls.fSanLuongTangCa_May_CAT = Convert.ToDouble(txtSanLuong_tangca_May_CAT.Text.ToString());
                    //cls.iID_VTHH_Ra_May_CAT = Convert.ToInt16(gridHangHoaXuat_May_CAT.EditValue.ToString());
                    //cls.fPhePham_May_CAT = Convert.ToDouble(txtPhePham_May_CAT.Text.ToString());
                    //cls.sGhiChu_May_CAT = txtGhiChu_May_CAT.Text.ToString();
                    //cls.bGuiDuLieu = true;
                    //cls.bTrangThaiXuatNhap_May_CAT = false;
                    //cls.Insert();
                    
                }
                else // sua
                {
                    //cls.iID_ChiTietPhieu_May_CAT = iiiID_ChiTietPhieuMay_CAT;
                    //cls.iID_VTHH_Vao_May_CAT = Convert.ToInt16(gridHangHoaVao_may_CAT.EditValue.ToString());
                    //cls.iID_May_CAT = Convert.ToInt16(gridMaMay_CAT.EditValue.ToString());
                    //cls.iID_CongNhan_May_CAT = Convert.ToInt16(gridMaCongNhan_May_CAT.EditValue.ToString());
                    //cls.iID_DinhMuc_Luong_SanLuong_May_CAT = Convert.ToInt16(gridDinhMucSLMay_CAT.EditValue.ToString());
                    //cls.fSoLuongNhap_May_CAT = Convert.ToDouble(txtSoLuongNhap_May_CAT.Text.ToString());
                    //cls.fDonGiaNhap_May_CAT = Convert.ToDouble(txtDonGiaNhap_May_CAT.Text.ToString());
                    //cls.fSanLuongThuong_May_CAT = Convert.ToDouble(txtSanLuong_may_CAT.Text.ToString());
                    //cls.fSanLuongTong_May_CAT = Convert.ToDouble(txtSanLuongTong_May_CAT.Text.ToString());
                    //cls.fDonGiaXuat_May_CAT = Convert.ToDouble(txtDonGiaXuat_May_CAT.Text.ToString());
                    //cls.fSanLuongTangCa_May_CAT = Convert.ToDouble(txtSanLuong_tangca_May_CAT.Text.ToString());
                    //cls.iID_VTHH_Ra_May_CAT = Convert.ToInt16(gridHangHoaXuat_May_CAT.EditValue.ToString());
                    //cls.fPhePham_May_CAT = Convert.ToDouble(txtPhePham_May_CAT.Text.ToString());
                    //cls.sGhiChu_May_CAT = txtGhiChu_May_CAT.Text.ToString();
                    //cls.bGuiDuLieu = true;
                    //cls.bTrangThaiXuatNhap_May_CAT = false;
                    //cls.Update();
                    
                }
                clsPhieu_tbPhieu clsphieu = new CtyTinLuong.clsPhieu_tbPhieu();
                clsphieu.iID_SoPhieu = UC_SanXuat_PhieuSanXuat.mID_iD_SoPhieu;
                clsphieu.Update_Gui_DuLieu();
                MessageBox.Show("Đã lưu");
                this.Close();
            }
        }    
        private void HienThi()
        {
            clsPhieu_ChiTietPhieu_May_CAT cls = new clsPhieu_ChiTietPhieu_May_CAT();
            cls.iID_SoPhieu = UC_SanXuat_PhieuSanXuat.mID_iD_SoPhieu;
            DataTable dt = cls.SelectOne_W_ID_SoPhieu();
            if (dt.Rows.Count == 0)
            {
                bthemmoi_chietiet_may_CAT = true;
               txtGhiChu_May_CAT.Text="Cắt: "+UC_SanXuat_PhieuSanXuat.madaNgayPhieu.ToString("dd/MM/yyyy")+"";
            }
            else
            {
                iiiID_ChiTietPhieuMay_CAT = Convert.ToInt16(dt.Rows[0]["ID_ChiTietPhieu_May_CAT"].ToString());
                bthemmoi_chietiet_may_CAT = false;

                if (dt.Rows[0]["ID_VTHH_Vao_May_CAT"].ToString() != "")
                    gridHangHoaVao_may_CAT.EditValue = Convert.ToInt16(dt.Rows[0]["ID_VTHH_Vao_May_CAT"].ToString());
                if (dt.Rows[0]["ID_May_CAT"].ToString() != "")
                    gridMaMay_CAT.EditValue = Convert.ToInt16(dt.Rows[0]["ID_May_CAT"].ToString());
                if (dt.Rows[0]["ID_CongNhan_May_CAT"].ToString() != "")
                    gridMaCongNhan_May_CAT.EditValue = Convert.ToInt16(dt.Rows[0]["ID_CongNhan_May_CAT"].ToString());
                if (dt.Rows[0]["ID_DinhMuc_Luong_SanLuong_May_CAT"].ToString() != "")
                    gridDinhMucSLMay_CAT.EditValue = Convert.ToInt16(dt.Rows[0]["ID_DinhMuc_Luong_SanLuong_May_CAT"].ToString());
                if (dt.Rows[0]["SoLuongNhap_May_CAT"].ToString() != "")
                    txtSoLuongNhap_May_CAT.Text = dt.Rows[0]["SoLuongNhap_May_CAT"].ToString();
                else txtSoLuongNhap_May_CAT.Text = "0";
                if (dt.Rows[0]["DonGiaNhap_May_CAT"].ToString() != "")
                    txtDonGiaNhap_May_CAT.Text = dt.Rows[0]["DonGiaNhap_May_CAT"].ToString();
                else txtDonGiaNhap_May_CAT.Text = "0";
                if (dt.Rows[0]["SanLuongThuong_May_CAT"].ToString() != "")
                    txtSanLuong_may_CAT.Text = dt.Rows[0]["SanLuongThuong_May_CAT"].ToString();
                else txtSanLuong_may_CAT.Text = "0";
                if (dt.Rows[0]["SanLuongTong_May_CAT"].ToString() != "")
                    txtSanLuongTong_May_CAT.Text = dt.Rows[0]["SanLuongTong_May_CAT"].ToString();
                else txtSanLuongTong_May_CAT.Text = "0";
                if (dt.Rows[0]["DonGiaXuat_May_CAT"].ToString() != "")
                    txtDonGiaXuat_May_CAT.Text = dt.Rows[0]["DonGiaXuat_May_CAT"].ToString();
                else txtDonGiaXuat_May_CAT.Text = "0";
                if (dt.Rows[0]["SanLuongTangCa_May_CAT"].ToString() != "")
                    txtSanLuong_tangca_May_CAT.Text = dt.Rows[0]["SanLuongTangCa_May_CAT"].ToString();
                else txtSanLuong_tangca_May_CAT.Text = "0";
                if (dt.Rows[0]["ID_VTHH_Ra_May_CAT"].ToString() != "")
                    gridHangHoaXuat_May_CAT.EditValue = Convert.ToInt16(dt.Rows[0]["ID_VTHH_Ra_May_CAT"].ToString());
                if (dt.Rows[0]["PhePham_May_CAT"].ToString() != "")
                    txtPhePham_May_CAT.Text = dt.Rows[0]["PhePham_May_CAT"].ToString();
                else txtPhePham_May_CAT.Text = "0";                
                txtGhiChu_May_CAT.Text = dt.Rows[0]["GhiChu_May_CAT"].ToString();
            }
        }
        private bool KiemTraLuu_May_CAT()
        {
            if (txtSanLuongTong_May_CAT.Text.ToString() == "")
            {
                MessageBox.Show("Chưa có sản lượng ");
                return false;
            }
            else if (gridHangHoaVao_may_CAT.EditValue == null)
            {
                MessageBox.Show("Chưa chọn vật tư vào  ");
                return false;
            }
            else if (gridHangHoaXuat_May_CAT.EditValue == null)
            {
                MessageBox.Show("Chưa chọn vật tư ra  ");
                return false;
            }
            else if (gridMaMay_CAT.EditValue == null)
            {
                MessageBox.Show("Chưa chọn máy gia công  ");
                return false;
            }

            else if (gridMaCongNhan_May_CAT.EditValue == null)
            {
                MessageBox.Show("Chưa chọn công nhân  ");
                return false;
            }
            else if (gridDinhMucSLMay_CAT.EditValue == null)
            {
                MessageBox.Show("Chưa định mức lương sản lượng  ");
                return false;
            }
            else return true;

        }
        private void Load_lockUP_EDIT()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_ChucVu=3";
            DataView dvCongNhan = dtNguoi.DefaultView;
            DataTable newdtCongNhan = dvCongNhan.ToTable();

            gridMaCongNhan_May_CAT.Properties.DataSource = newdtCongNhan;
            gridMaCongNhan_May_CAT.Properties.ValueMember = "ID_NhanSu";
            gridMaCongNhan_May_CAT.Properties.DisplayMember = "MaNhanVien";


            clsKhoBTP_tbChiTietNhapKho clsVT = new clsKhoBTP_tbChiTietNhapKho();
           
            DataTable dtVT = clsVT.Select_distinct_HienThiLockUpEdit();
            //dtVT.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvVT = dtVT.DefaultView;
            DataTable newdtVT = dvVT.ToTable();

            gridHangHoaVao_may_CAT.Properties.DataSource = newdtVT;
            gridHangHoaVao_may_CAT.Properties.ValueMember = "ID_VTHH";
            gridHangHoaVao_may_CAT.Properties.DisplayMember = "MaVT";


            clsTbVatTuHangHoa clsxx = new clsTbVatTuHangHoa();
            DataTable dtkksss = clsxx.SelectAll();
            dtkksss.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvcxxx = dtkksss.DefaultView;
            DataTable vdtrhh = dvcxxx.ToTable();

            gridHangHoaXuat_May_CAT.Properties.DataSource = vdtrhh;
            gridHangHoaXuat_May_CAT.Properties.ValueMember = "ID_VTHH";
            gridHangHoaXuat_May_CAT.Properties.DisplayMember = "MaVT";


            clsT_MayMoc clsMayMoc = new clsT_MayMoc();
            DataTable dtMayIN = clsMayMoc.SelectAll();
            dtMayIN.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvMayIn = dtMayIN.DefaultView;
            DataTable newdtMayIn = dvMayIn.ToTable();

            gridMaMay_CAT.Properties.DataSource = newdtMayIn;
            gridMaMay_CAT.Properties.ValueMember = "id";
            gridMaMay_CAT.Properties.DisplayMember = "MaMay";


            clsDinhMuc_DinhMuc_Luong_TheoSanLuong clssanluong = new CtyTinLuong.clsDinhMuc_DinhMuc_Luong_TheoSanLuong();
            DataTable dtDinhMucSanLuong = clssanluong.SelectAll();
            dtDinhMucSanLuong.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvsanluiong = dtDinhMucSanLuong.DefaultView;
            DataTable newdtsanluong = dvsanluiong.ToTable();

            gridDinhMucSLMay_CAT.Properties.DataSource = newdtsanluong;
            gridDinhMucSLMay_CAT.Properties.ValueMember = "ID_DinhMuc_Luong_SanLuong";
            gridDinhMucSLMay_CAT.Properties.DisplayMember = "MaDinhMuc";


        }
        public SanXuat_frmChiTietSoPhieu_CAT()
        {
            InitializeComponent();
        }
        private void gridHangHoaVao_may_CAT_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsTbVatTuHangHoa clsncc = new clsTbVatTuHangHoa();
                int kk = Convert.ToInt16(gridHangHoaVao_may_CAT.EditValue.ToString());

                clsncc.iID_VTHH = kk;
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenHangHoaVao_May_CAT.Text = dt.Rows[0]["TenVTHH"].ToString();
                    txtDVT_HangVao_MayCAT.Text = dt.Rows[0]["DonViTinh"].ToString();
                }

                clsKhoBTP_tbChiTietNhapKho cls2 = new clsKhoBTP_tbChiTietNhapKho();

                cls2.iID_VTHH = Convert.ToInt16(gridHangHoaVao_may_CAT.EditValue.ToString());
                DataTable dt2 = cls2.Select_W_ID_VTHH();
                if (dt2.Rows.Count > 0)
                {

                    txtSoLuongTon_May_CAT.Text = dt2.Rows[0]["SoLuongTon"].ToString();
                    txtDonGiaNhap_May_CAT.Text = dt2.Rows[0]["DonGia"].ToString();

                }
                else
                {
                    txtSoLuongTon_May_CAT.Text = "0";
                    txtDonGiaNhap_May_CAT.Text = "0";
                }

            }
            catch
            {

            }
        }
        private void SanXuat_frmChiTietSoPhieu_CAT_Load(object sender, EventArgs e)
        {

            clsPhieu_tbPhieu clsphieu = new CtyTinLuong.clsPhieu_tbPhieu();
            clsphieu.iID_SoPhieu = UC_SanXuat_PhieuSanXuat.mID_iD_SoPhieu;
            DataTable dtphieuxx = clsphieu.SelectOne();
            if (Convert.ToBoolean(clsphieu.bGuiDuLieu.Value.ToString()) == true)
            {
                btluuVaXuatNhapKho.Enabled = false;
                labelMayIn.Text = "Đã gửi dữ liệu. Không thể sửa";
            }
            else
            {
                btluuVaXuatNhapKho.Enabled = true;
                labelMayIn.Visible = false;
            }
            label1.Text = "Số phiếu: " + UC_SanXuat_PhieuSanXuat.msTenSoPhieu + "";
            Load_lockUP_EDIT();
            bthemmoi_chietiet_may_CAT = false;
            HienThi();
        }        
        private void txtSoLuongNhap_May_CAT_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtSoLuongNhap_May_CAT.Text.ToString()) > Convert.ToDouble(txtSoLuongTon_May_CAT.Text.ToString()))
            {
                MessageBox.Show("Số lượng xuất không vượt quá số lượng tồn kho NPL");
                txtSoLuongNhap_May_CAT.Text = "0";
                return;
            }
        }
        private void gridHangHoaXuat_May_CAT_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsTbVatTuHangHoa clsncc = new clsTbVatTuHangHoa();

                clsncc.iID_VTHH = Convert.ToInt16(gridHangHoaXuat_May_CAT.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenHangHoaRa_May_CAT.Text = dt.Rows[0]["TenVTHH"].ToString();
                    txtDVT_HangRa_MayCAT.Text = dt.Rows[0]["DonViTinh"].ToString();

                }
            }
            catch
            {

            }
        }
        private void gridMaMay_CAT_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsT_MayMoc clsncc = new clsT_MayMoc();
                clsncc.iId = Convert.ToInt16(gridMaMay_CAT.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenMay_CAT.Text = dt.Rows[0]["TenMay"].ToString();

                }
            }
            catch
            {

            }
        }
        private void gridMaCongNhan_May_CAT_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt16(gridMaCongNhan_May_CAT.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenCongNhan_may_CAT.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }
            }
            catch
            {

            }
        }
        private void gridDinhMucSLMay_CAT_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsDinhMuc_DinhMuc_Luong_TheoSanLuong clsncc = new clsDinhMuc_DinhMuc_Luong_TheoSanLuong();
                clsncc.iID_DinhMuc_Luong_SanLuong = Convert.ToInt16(gridDinhMucSLMay_CAT.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtDinhMucKhongTang_May_CAT.Text = dt.Rows[0]["DinhMuc_KhongTang"].ToString();
                    txtDinhMucTang_May_CAT.Text = dt.Rows[0]["DinhMuc_Tang"].ToString();

                }
            }
            catch
            {

            }
        }
        private void btluuVaXuatNhapKho_Click(object sender, EventArgs e)
        {
            Luu_Va_GuiDuLieu();          
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtSanLuong_may_CAT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSanLuong_may_CAT.Text.ToString() != "" & txtSanLuong_tangca_May_CAT.Text.ToString() != "")
                {
                    double d1 = Convert.ToDouble(txtSanLuong_may_CAT.Text.ToString());
                    double d2 = Convert.ToDouble(txtSanLuong_tangca_May_CAT.Text.ToString());
                    double d3 = d1 + d2;
                    txtSanLuongTong_May_CAT.Text = d3.ToString();
                }

            }
            catch
            {

            }
        }
        private void txtSanLuong_tangca_May_CAT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSanLuong_may_CAT.Text.ToString() != "" & txtSanLuong_tangca_May_CAT.Text.ToString() != "")
                {
                    double d1 = Convert.ToDouble(txtSanLuong_may_CAT.Text.ToString());
                    double d2 = Convert.ToDouble(txtSanLuong_tangca_May_CAT.Text.ToString());
                    double d3 = d1 + d2;
                    txtSanLuongTong_May_CAT.Text = d3.ToString();
                }

            }
            catch
            {

            }
        }
        private void txtDonGiaNhap_May_CAT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDonGiaNhap_May_CAT.Text);
                txtDonGiaNhap_May_CAT.Text = String.Format("{0:#,##0.00}", value);
            }
            catch
            {

            }
        }
        private void txtDonGiaXuat_May_CAT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDonGiaXuat_May_CAT.Text);
                txtDonGiaXuat_May_CAT.Text = String.Format("{0:#,##0.00}", value);
            }
            catch
            {

            }
        }
        private void txtDinhMucKhongTang_May_CAT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDinhMucKhongTang_May_CAT.Text);
                txtDinhMucKhongTang_May_CAT.Text = String.Format("{0:#,##0.00}", value);
            }
            catch
            {

            }
        }
        private void txtDinhMucTang_May_CAT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDinhMucTang_May_CAT.Text);
                txtDinhMucTang_May_CAT.Text = String.Format("{0:#,##0.00}", value);
            }
            catch
            {

            }
        }
    }
}
