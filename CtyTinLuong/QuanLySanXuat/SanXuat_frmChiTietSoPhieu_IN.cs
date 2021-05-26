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
    public partial class SanXuat_frmChiTietSoPhieu_IN : Form
    {
        bool bthemmoi_chietiet_mayIn;
        int iiiID_ChiTietPhieuMayIn;       
     
        private void LuuDuLieu_VaGuiDuLieu()
        {
            if (!KiemTraLuu_MayIn()) return;
            else
            {
                clsPhieu_ChiTietPhieu_May_IN cls = new clsPhieu_ChiTietPhieu_May_IN();
                cls.iID_SoPhieu = UC_SanXuat_PhieuSanXuat.mID_iD_SoPhieu;
                if (bthemmoi_chietiet_mayIn == true) // themmoi
                {
                    //cls.iID_VTHH_Vao_May_IN = Convert.ToInt16(gridHangHoaVao_may_IN.EditValue.ToString());
                    //cls.iID_May_IN = Convert.ToInt16(gridMaMay_IN.EditValue.ToString());
                    //cls.iID_CongNhan_May_IN = Convert.ToInt16(gridMaCongNhan_May_IN.EditValue.ToString());
                    //cls.iID_DinhMuc_Luong_SanLuong_May_IN = Convert.ToInt16(gridDinhMucSLMay_IN.EditValue.ToString());
                    //cls.fSoLuongNhap_May_IN = Convert.ToDouble(txtSoLuongNhap_May_IN.Text.ToString());
                    //cls.fDonGiaNhap_May_IN = Convert.ToDouble(txtDonGiaNhap_May_IN.Text.ToString());
                    //cls.fSanLuongThuong_May_IN = Convert.ToDouble(txtSanLuong_may_IN.Text.ToString());
                    //cls.fSanLuongTong_May_IN = Convert.ToDouble(txtSanLuongTong_May_IN.Text.ToString());
                    //cls.fDonGiaXuat_May_IN = Convert.ToDouble(txtDonGiaXuat_May_IN.Text.ToString());
                    //cls.fSanLuongTangCa_May_IN = Convert.ToDouble(txtSanLuong_tangca_May_IN.Text.ToString());
                    //cls.iID_VTHH_Ra_May_IN = Convert.ToInt16(gridHangHoaXuat_May_IN.EditValue.ToString());
                    //cls.fPhePham_May_IN = Convert.ToDouble(txtPhePham_May_IN.Text.ToString());
                    //cls.sGhiChu_May_IN = txtGhiChu_May_IN.Text.ToString();
                    //cls.bGuiDuLieu = true;
                    //cls.bTrangThaiXuatNhap_May_IN = false;
                    //cls.Insert();
                    ////Luu_Xuat_kho_NPL_NhapKho_BTP();
                }
                else // sua
                {
                    //cls.iID_ChiTietPhieu_May_IN = iiiID_ChiTietPhieuMayIn;
                    //cls.iID_VTHH_Vao_May_IN = Convert.ToInt16(gridHangHoaVao_may_IN.EditValue.ToString());
                    //cls.iID_May_IN = Convert.ToInt16(gridMaMay_IN.EditValue.ToString());
                    //cls.iID_CongNhan_May_IN = Convert.ToInt16(gridMaCongNhan_May_IN.EditValue.ToString());
                    //cls.iID_DinhMuc_Luong_SanLuong_May_IN = Convert.ToInt16(gridDinhMucSLMay_IN.EditValue.ToString());
                    //cls.fSoLuongNhap_May_IN = Convert.ToDouble(txtSoLuongNhap_May_IN.Text.ToString());
                    //cls.fDonGiaNhap_May_IN = Convert.ToDouble(txtDonGiaNhap_May_IN.Text.ToString());
                    //cls.fSanLuongThuong_May_IN = Convert.ToDouble(txtSanLuong_may_IN.Text.ToString());
                    //cls.fSanLuongTong_May_IN = Convert.ToDouble(txtSanLuongTong_May_IN.Text.ToString());
                    //cls.fDonGiaXuat_May_IN = Convert.ToDouble(txtDonGiaXuat_May_IN.Text.ToString());
                    //cls.fSanLuongTangCa_May_IN = Convert.ToDouble(txtSanLuong_tangca_May_IN.Text.ToString());
                    //cls.iID_VTHH_Ra_May_IN = Convert.ToInt16(gridHangHoaXuat_May_IN.EditValue.ToString());
                    //cls.fPhePham_May_IN = Convert.ToDouble(txtPhePham_May_IN.Text.ToString());
                    //cls.sGhiChu_May_IN = txtGhiChu_May_IN.Text.ToString();
                    //cls.bGuiDuLieu = true;
                    //cls.bTrangThaiXuatNhap_May_IN = false;
                    //cls.Update();
                    ////Luu_Xuat_kho_NPL_NhapKho_BTP();
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
            clsPhieu_ChiTietPhieu_May_IN cls = new clsPhieu_ChiTietPhieu_May_IN();
            cls.iID_SoPhieu = UC_SanXuat_PhieuSanXuat.mID_iD_SoPhieu;
            DataTable dt = cls.SelectOne_W_ID_SoPhieu();
            if (dt.Rows.Count == 0)
            {
                bthemmoi_chietiet_mayIn = true;               
            }
            else
            {
                iiiID_ChiTietPhieuMayIn = Convert.ToInt16(dt.Rows[0]["ID_ChiTietPhieu_May_IN"].ToString());
                bthemmoi_chietiet_mayIn = false;

                if (dt.Rows[0]["ID_VTHH_Vao_May_IN"].ToString() != "")
                    gridHangHoaVao_may_IN.EditValue = Convert.ToInt16(dt.Rows[0]["ID_VTHH_Vao_May_IN"].ToString());
                if (dt.Rows[0]["ID_May_IN"].ToString() != "")
                    gridMaMay_IN.EditValue = Convert.ToInt16(dt.Rows[0]["ID_May_IN"].ToString());
                if (dt.Rows[0]["ID_CongNhan_May_IN"].ToString() != "")
                    gridMaCongNhan_May_IN.EditValue = Convert.ToInt16(dt.Rows[0]["ID_CongNhan_May_IN"].ToString());
                if (dt.Rows[0]["ID_DinhMuc_Luong_SanLuong_May_IN"].ToString() != "")
                    gridDinhMucSLMay_IN.EditValue = Convert.ToInt16(dt.Rows[0]["ID_DinhMuc_Luong_SanLuong_May_IN"].ToString());
                if (dt.Rows[0]["SoLuongNhap_May_IN"].ToString() != "")
                    txtSoLuongNhap_May_IN.Text = dt.Rows[0]["SoLuongNhap_May_IN"].ToString();
                else txtSoLuongNhap_May_IN.Text = "0";
                if (dt.Rows[0]["DonGiaNhap_May_IN"].ToString() != "")
                    txtDonGiaNhap_May_IN.Text = dt.Rows[0]["DonGiaNhap_May_IN"].ToString();
                else txtDonGiaNhap_May_IN.Text = "0";
                if (dt.Rows[0]["SanLuongThuong_May_IN"].ToString() != "")
                    txtSanLuong_may_IN.Text = dt.Rows[0]["SanLuongThuong_May_IN"].ToString();
                else txtSanLuong_may_IN.Text = "0";
                if (dt.Rows[0]["SanLuongTong_May_IN"].ToString() != "")
                    txtSanLuongTong_May_IN.Text = dt.Rows[0]["SanLuongTong_May_IN"].ToString();
                else txtSanLuongTong_May_IN.Text = "0";
                if (dt.Rows[0]["DonGiaXuat_May_IN"].ToString() != "")
                    txtDonGiaXuat_May_IN.Text = dt.Rows[0]["DonGiaXuat_May_IN"].ToString();
                else txtDonGiaXuat_May_IN.Text = "0";
                if (dt.Rows[0]["SanLuongTangCa_May_IN"].ToString() != "")
                    txtSanLuong_tangca_May_IN.Text = dt.Rows[0]["SanLuongTangCa_May_IN"].ToString();
                else txtSanLuong_tangca_May_IN.Text = "0";
                if (dt.Rows[0]["ID_VTHH_Ra_May_IN"].ToString() != "")
                    gridHangHoaXuat_May_IN.EditValue = Convert.ToInt16(dt.Rows[0]["ID_VTHH_Ra_May_IN"].ToString());
                if (dt.Rows[0]["PhePham_May_IN"].ToString() != "")
                    txtPhePham_May_IN.Text = dt.Rows[0]["PhePham_May_IN"].ToString();
                else txtPhePham_May_IN.Text = "0";                
                txtGhiChu_May_IN.Text = dt.Rows[0]["GhiChu_May_IN"].ToString();
            }
        }

        private bool KiemTraLuu_MayIn()
        {
           if (txtSanLuongTong_May_IN.Text.ToString() == "")
            {
                MessageBox.Show("Chưa có sản lượng ");
                return false;
            }
            else if (gridHangHoaVao_may_IN.EditValue == null)
            {
                MessageBox.Show("Chưa chọn vật tư vào  ");
                return false;
            }
            else if (gridHangHoaXuat_May_IN.EditValue == null)
            {
                MessageBox.Show("Chưa chọn vật tư ra  ");
                return false;
            }
            else if (gridMaMay_IN.EditValue == null)
            {
                MessageBox.Show("Chưa chọn máy gia công  ");
                return false;
            }

            else if (gridMaCongNhan_May_IN.EditValue == null)
            {
                MessageBox.Show("Chưa chọn công nhân  ");
                return false;
            }
            else if (gridDinhMucSLMay_IN.EditValue == null)
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

            gridMaCongNhan_May_IN.Properties.DataSource = newdtCongNhan;
            gridMaCongNhan_May_IN.Properties.ValueMember = "ID_NhanSu";
            gridMaCongNhan_May_IN.Properties.DisplayMember = "MaNhanVien";



            clsKhoNPL_tbChiTietNhapKho clsVT = new clsKhoNPL_tbChiTietNhapKho();
            DataTable dtVT = clsVT.Select_distinct_HienThiLockUpEdit();         
            DataView dvVT = dtVT.DefaultView;
            DataTable newdtVT = dvVT.ToTable();

            gridHangHoaVao_may_IN.Properties.DataSource = newdtVT;
            gridHangHoaVao_may_IN.Properties.ValueMember = "ID_VTHH";
            gridHangHoaVao_may_IN.Properties.DisplayMember = "MaVT";

            clsTbVatTuHangHoa clsxx = new clsTbVatTuHangHoa();
            DataTable dtkksss = clsxx.SelectAll();
            dtkksss.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvcxxx = dtkksss.DefaultView;
            DataTable vdtrhh = dvcxxx.ToTable();

            gridHangHoaXuat_May_IN.Properties.DataSource = vdtrhh;
            gridHangHoaXuat_May_IN.Properties.ValueMember = "ID_VTHH";
            gridHangHoaXuat_May_IN.Properties.DisplayMember = "MaVT";      


            clsT_MayMoc clsMayMoc = new clsT_MayMoc();
            DataTable dtMayIN = clsMayMoc.SelectAll();
            dtMayIN.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvMayIn = dtMayIN.DefaultView;
            DataTable newdtMayIn = dvMayIn.ToTable();

            gridMaMay_IN.Properties.DataSource = newdtMayIn;
            gridMaMay_IN.Properties.ValueMember = "id";
            gridMaMay_IN.Properties.DisplayMember = "MaMay";
         

            clsDinhMuc_DinhMuc_Luong_TheoSanLuong clssanluong = new CtyTinLuong.clsDinhMuc_DinhMuc_Luong_TheoSanLuong();
            DataTable dtDinhMucSanLuong = clssanluong.SelectAll();
            dtDinhMucSanLuong.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvsanluiong = dtDinhMucSanLuong.DefaultView;
            DataTable newdtsanluong = dvsanluiong.ToTable();

            gridDinhMucSLMay_IN.Properties.DataSource = newdtsanluong;
            gridDinhMucSLMay_IN.Properties.ValueMember = "ID_DinhMuc_Luong_SanLuong";
            gridDinhMucSLMay_IN.Properties.DisplayMember = "MaDinhMuc";


        }

        public SanXuat_frmChiTietSoPhieu_IN()
        {
            InitializeComponent();
        }

        private void SanXuat_frmChiTietSoPhieu_IN_Load(object sender, EventArgs e)
        {

            clsPhieu_tbPhieu clsphieu = new CtyTinLuong.clsPhieu_tbPhieu();
            clsphieu.iID_SoPhieu = UC_SanXuat_PhieuSanXuat.mID_iD_SoPhieu;
            DataTable dtphieuxx = clsphieu.SelectOne();
            if (Convert.ToBoolean(clsphieu.bGuiDuLieu.Value.ToString()) == true)
            {
                labelMayIn.Text = "Đã gửi dữ liệu. Không thể sửa";
                btluuVaXuatNhapKho.Enabled = false;
            }
            else
            {
                btluuVaXuatNhapKho.Enabled = true;
                labelMayIn.Visible = false;
            }
            label1.Text = "Số phiếu: " + UC_SanXuat_PhieuSanXuat.msTenSoPhieu + "";
            Load_lockUP_EDIT();          
            bthemmoi_chietiet_mayIn = false;
            HienThi();
        }
        
        private void gridHangHoaVao_may_IN_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsTbVatTuHangHoa clsncc = new clsTbVatTuHangHoa();
                int kk = Convert.ToInt16(gridHangHoaVao_may_IN.EditValue.ToString());

                clsncc.iID_VTHH = kk;
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenHangHoaVao_May_IN.Text = dt.Rows[0]["TenVTHH"].ToString();
                    txtDVT_HangVao_MayIN.Text = dt.Rows[0]["DonViTinh"].ToString();
                }

                clsKhoNPL_tbChiTietNhapKho cls2 = new clsKhoNPL_tbChiTietNhapKho();

                cls2.iID_VTHH = Convert.ToInt16(gridHangHoaVao_may_IN.EditValue.ToString());
                DataTable dt2 = cls2.Select_W_ID_VTHH();
                if (dt2.Rows.Count > 0)
                {

                    txtSoLuongTon_May_IN.Text = dt2.Rows[0]["SoLuongTon"].ToString();
                    txtDonGiaNhap_May_IN.Text = dt2.Rows[0]["DonGia"].ToString();

                }
                else
                {
                    txtSoLuongTon_May_IN.Text = "0";
                    txtDonGiaNhap_May_IN.Text = "0";
                }

            }
            catch
            {

            }
        }

        private void txtSoLuongNhap_May_IN_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtSoLuongNhap_May_IN.Text.ToString()) > Convert.ToDouble(txtSoLuongTon_May_IN.Text.ToString()))
            {
                MessageBox.Show("Số lượng xuất không vượt quá số lượng tồn kho NPL");
                txtSoLuongNhap_May_IN.Text = "0";
                return;
            }   
        }

        private void gridHangHoaXuat_May_IN_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                clsTbVatTuHangHoa clsncc = new clsTbVatTuHangHoa();

                clsncc.iID_VTHH = Convert.ToInt16(gridHangHoaXuat_May_IN.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenHangHoaRa_May_IN.Text = dt.Rows[0]["TenVTHH"].ToString();
                    txtDVT_HangRa_MayIN.Text = dt.Rows[0]["DonViTinh"].ToString();

                }
            }
            catch
            {

            }
        }

        private void gridMaMay_IN_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsT_MayMoc clsncc = new clsT_MayMoc();
                clsncc.iId = Convert.ToInt16(gridMaMay_IN.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenMay_IN.Text = dt.Rows[0]["TenMay"].ToString();

                }
            }
            catch
            {

            }
        }

        private void gridMaCongNhan_May_IN_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt16(gridMaCongNhan_May_IN.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenCongNhan_may_IN.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }
            }
            catch
            {

            }
        }

        private void gridDinhMucSLMay_IN_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsDinhMuc_DinhMuc_Luong_TheoSanLuong clsncc = new clsDinhMuc_DinhMuc_Luong_TheoSanLuong();
                clsncc.iID_DinhMuc_Luong_SanLuong = Convert.ToInt16(gridDinhMucSLMay_IN.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtDinhMucKhongTang_May_IN.Text = dt.Rows[0]["DinhMuc_KhongTang"].ToString();
                    txtDinhMucTang_May_IN.Text = dt.Rows[0]["DinhMuc_Tang"].ToString();

                }
            }
            catch
            {

            }
        }

        private void btluuVaXuatNhapKho_Click(object sender, EventArgs e)
        {
            LuuDuLieu_VaGuiDuLieu();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSanLuong_may_IN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSanLuong_may_IN.Text.ToString() != "" & txtSanLuong_tangca_May_IN.Text.ToString() != "")
                {
                    double d1 = Convert.ToDouble(txtSanLuong_may_IN.Text.ToString());
                    double d2 = Convert.ToDouble(txtSanLuong_tangca_May_IN.Text.ToString());
                    double d3 = d1 + d2;
                    txtSanLuongTong_May_IN.Text = d3.ToString();
                }

            }
            catch
            {

            }
        }

        private void txtSanLuong_tangca_May_IN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSanLuong_may_IN.Text.ToString() != "" & txtSanLuong_tangca_May_IN.Text.ToString() != "")
                {
                    double d1 = Convert.ToDouble(txtSanLuong_may_IN.Text.ToString());
                    double d2 = Convert.ToDouble(txtSanLuong_tangca_May_IN.Text.ToString());
                    double d3 = d1 + d2;
                    txtSanLuongTong_May_IN.Text = d3.ToString();
                }

            }
            catch
            {

            }
        }

        private void txtDonGiaNhap_May_IN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDonGiaNhap_May_IN.Text);
                txtDonGiaNhap_May_IN.Text = String.Format("{0:#,##0.00}", value);
            }
            catch
            {

            }
        }

        private void txtDonGiaXuat_May_IN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDonGiaXuat_May_IN.Text);
                txtDonGiaXuat_May_IN.Text = String.Format("{0:#,##0.00}", value);
            }
            catch
            {

            }
        }

        private void txtDinhMucKhongTang_May_IN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDinhMucKhongTang_May_IN.Text);
                txtDinhMucKhongTang_May_IN.Text = String.Format("{0:#,##0.00}", value);
            }
            catch
            {

            }
        }

        private void txtDinhMucTang_May_IN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDinhMucTang_May_IN.Text);
                txtDinhMucTang_May_IN.Text = String.Format("{0:#,##0.00}", value);
            }
            catch
            {

            }
        }

        private void gridHangHoaVao_may_IN_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }

        private void txtDonGiaXuat_May_IN_Validated(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDonGiaXuat_May_IN.Text);
                txtDonGiaXuat_May_IN.Text = String.Format("{0:#,##0.00}", value);
            }
            catch
            {

            }
        }
    }
}
