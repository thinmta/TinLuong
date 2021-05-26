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
    public partial class KhoBTP_ChiTietNhapKho_HangGiaCongTuDaiLyVe : Form
    {
        private void HienThi_Sua_NhapKho()
        {

            clsDaiLy_tbXuatKho cls1 = new clsDaiLy_tbXuatKho();
            cls1.iID_XuatKhoDaiLy = UCBanThanhPham_NhapKho_TuDaiLy.miID_XuatKho_DaiLy;
            DataTable dt22222 = cls1.SelectOne();

            gridMaDaiLy.EditValue = cls1.iID_DaiLy.Value;
            txtThamChieu.Text = cls1.sSoChungTu.Value;
            int iIDIThanhPham= cls1.iID_VTHH.Value;
            clsTbVatTuHangHoa clsvt = new CtyTinLuong.clsTbVatTuHangHoa();
            clsvt.iID_VTHH = iIDIThanhPham;
            DataTable dtvt = clsvt.SelectOne();
            txtMaTPQuyDoi.Text = clsvt.sMaVT.Value;
            txtTenThanhPhamQuyDoi.Text = clsvt.sTenVTHH.Value;
            txtDVTThanhPhamQuyDoi.Text = clsvt.sDonViTinh.Value;
            //txtSoLuongNhap_TheoDinhMuc.Text = cls1.fSoLuongXuat.Value.ToString();
            txtID_ThanhPham.Text = iIDIThanhPham.ToString();
            if (cls1.bTrangThaiXuatNhap_ThanhPham_TuDaiLyVe == true)
            {
                btLuu_Gui_Dong.Enabled = false;

                clsKhoBTP_tbNhapKho cls2 = new CtyTinLuong.clsKhoBTP_tbNhapKho();
                cls2.sThamChieu = cls1.sSoChungTu.Value;
                DataTable dt2xxx = cls2.SelectOne_W_ThamChieu_NhapKho_HangTuDaiLyVe();
                gridNguoiLap.EditValue = Convert.ToInt32(dt2xxx.Rows[0]["ID_NguoiNhap"].ToString());
                dteNgayChungTu.EditValue = Convert.ToDateTime(dt2xxx.Rows[0]["NgayChungTu"].ToString());
                txtSoChungTu.Text = dt2xxx.Rows[0]["SoChungTu"].ToString();
                txtDienGiai.Text = dt2xxx.Rows[0]["DienGiai"].ToString();

                clsKhoBTP_tbChiTietNhapKho cls3 = new CtyTinLuong.clsKhoBTP_tbChiTietNhapKho();
                cls3.iID_NhapKho = Convert.ToInt32(dt2xxx.Rows[0]["ID_NhapKhoBTP"].ToString());
                DataTable dt222 = cls3.Select__W_ID_NhapKho_HienThi_SuaDonHang();
                txtSoLuongNhapThucTe.Text = dt222.Rows[0]["SoLuongNhap"].ToString();
                txtDonGia.Text = dt222.Rows[0]["DonGia"].ToString();
                double aaaSoLuongXuatThucTe = Convert.ToDouble(dt222.Rows[0]["SoLuongNhap"].ToString());
                double aaatxtDonGia_VTChinh = Convert.ToDouble(dt222.Rows[0]["DonGia"].ToString());
                txtTongTienHang.Text = (aaaSoLuongXuatThucTe * aaatxtDonGia_VTChinh).ToString();
               
            }
            else
            {
                clsKhoBTP_tbNhapKho cls3 = new clsKhoBTP_tbNhapKho();
                DataTable dt1 = cls3.SelectAll();
                dt1.DefaultView.RowFilter = " TonTai= True and NgungTheoDoi=false";
                DataView dv = dt1.DefaultView;
                DataTable dv3 = dv.ToTable();
                int k = dv3.Rows.Count;
                if (k == 0)
                    txtSoChungTu.Text = "NKBTP 1";
                else
                {
                    string xxx = dv3.Rows[k - 1]["SoChungTu"].ToString();
                    int xxx2 = Convert.ToInt32(xxx.Substring(5).Trim()) + 1;
                    if (xxx2 >= 10000)
                        txtSoChungTu.Text = "NKBTP 1";
                    else txtSoChungTu.Text = "NKBTP " + xxx2 + "";

                }
                gridNguoiLap.EditValue = 12;
                dteNgayChungTu.EditValue = DateTime.Today;
             
                //txtSoLuongNhapThucTe.Text = cls1.fSoLuongXuat.Value.ToString();

            }

        }
        private bool KiemTraLuu()
        {
            if (gridMaDaiLy.EditValue.ToString() == "")
            {
                MessageBox.Show("chưa chọn định mức nguyên phụ liệu");
                return false;
            }
            else if (dteNgayChungTu.Text.ToString() == "")
            {
                MessageBox.Show("Không để trống ngày chứng từ");
                return false;
            }
            else if (txtSoChungTu.Text.ToString() == "")
            {
                MessageBox.Show("Chưa chọn số chứng từ ");
                return false;
            }
            else if (gridNguoiLap.EditValue.ToString() == "")
            {
                MessageBox.Show("chưa có người nhập kho");
                return false;
            }
            else return true;

        }

        private void Luu_NhapKho_BTP()
        {
            if (!KiemTraLuu()) return ;
            else
            {

                double tongtienhang;
                tongtienhang = Convert.ToDouble(txtTongTienHang.Text.ToString());
                clsKhoBTP_tbNhapKho cls1 = new clsKhoBTP_tbNhapKho();
                cls1.sDienGiai = txtDienGiai.Text.ToString();
                cls1.daNgayChungTu = dteNgayChungTu.DateTime;
                cls1.sSoChungTu = txtSoChungTu.Text.ToString();
                cls1.fTongTienHang = tongtienhang;
                cls1.iID_NguoiNhap = Convert.ToInt32(gridNguoiLap.EditValue.ToString());
                cls1.bTonTai = true;
                cls1.bNgungTheoDoi = false;
                cls1.sThamChieu = txtThamChieu.Text.ToString();
                cls1.bDaNhapKho = true;
                cls1.bBool_TonDauKy = false;
                cls1.Insert();

                clsKhoBTP_tbChiTietNhapKho clsnhapkhobtp = new clsKhoBTP_tbChiTietNhapKho();
                clsnhapkhobtp.iID_NhapKho = cls1.iID_NhapKhoBTP.Value; ;
                clsnhapkhobtp.iID_VTHH = Convert.ToInt32(txtID_ThanhPham.Text.ToString());
                clsnhapkhobtp.fSoLuongNhap = Convert.ToDouble(txtSoLuongNhapThucTe.Text.ToString());
                clsnhapkhobtp.fSoLuongTon= Convert.ToDouble(txtSoLuongNhapThucTe.Text.ToString());
                clsnhapkhobtp.fDonGia = Convert.ToDouble(txtDonGia.Text.ToString());
                clsnhapkhobtp.bTonTai = true;
                clsnhapkhobtp.bNgungTheoDoi = false;
                clsnhapkhobtp.bDaNhapKho = true;
                clsnhapkhobtp.sGhiChu = "";
                clsnhapkhobtp.bBoolTonDauKy = false;
                clsnhapkhobtp.Insert();
                //update so luong ton   
              

                /// Update trang thai trong tbDaiLy_XuatKho
                clsDaiLy_tbXuatKho clsxxx = new CtyTinLuong.clsDaiLy_tbXuatKho();
                clsxxx.iID_XuatKhoDaiLy = UCBanThanhPham_NhapKho_TuDaiLy.miID_XuatKho_DaiLy;
                clsxxx.Update_TrangThaiXuatNhap_Kho_ThanhPham();               
            }


        }

        private void Load_LockUp()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=4";
            DataView dvCaTruong = dtNguoi.DefaultView;
            DataTable newdtCaTruong = dvCaTruong.ToTable();

            gridNguoiLap.Properties.DataSource = newdtCaTruong;
            gridNguoiLap.Properties.ValueMember = "ID_NhanSu";
            gridNguoiLap.Properties.DisplayMember = "MaNhanVien";


            clsTbDanhMuc_DaiLy clsdaily = new clsTbDanhMuc_DaiLy();
            DataTable dtdaily = clsdaily.SelectAll();
            dtdaily.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv = dtdaily.DefaultView;
            DataTable dtxx = dv.ToTable();
            gridMaDaiLy.Properties.DataSource = dtxx;
            gridMaDaiLy.Properties.ValueMember = "ID_DaiLy";
            gridMaDaiLy.Properties.DisplayMember = "MaDaiLy";


         

        


        }
        public KhoBTP_ChiTietNhapKho_HangGiaCongTuDaiLyVe()
        {
            InitializeComponent();
        }

        private void KhoBTP_ChiTietNhapKho_HangGiaCongTuDaiLyVe_Load(object sender, EventArgs e)
        {
            Load_LockUp();
            HienThi_Sua_NhapKho();
        }

        private void gridMaDaiLy_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsTbDanhMuc_DaiLy clsncc = new clsTbDanhMuc_DaiLy();
                clsncc.iID_DaiLy = Convert.ToInt32(gridMaDaiLy.EditValue.ToString());
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

        private void gridNguoiLap_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt32(gridNguoiLap.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenNguoiLap.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }
            }
            catch
            {

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

        private void txtDonGia_VTChinh_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDonGia.Text);
                txtDonGia.Text = String.Format("{0:#,##0.00}", value);

            }
            catch
            {

            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double aaaSoLuongXuatThucTe = Convert.ToDouble(txtSoLuongNhapThucTe.Text.ToString());
                double aaatxtDonGia_VTChinh = Convert.ToDouble(txtDonGia.Text.ToString());
                txtTongTienHang.Text = (aaaSoLuongXuatThucTe * aaatxtDonGia_VTChinh).ToString();
            }
            catch
            {
               
            }
            
        }

        private void txtSoLuongNhapThucTe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double aaaSoLuongXuatThucTe = Convert.ToDouble(txtSoLuongNhapThucTe.Text.ToString());
                double aaatxtDonGia_VTChinh = Convert.ToDouble(txtDonGia.Text.ToString());
                txtTongTienHang.Text = (aaaSoLuongXuatThucTe * aaatxtDonGia_VTChinh).ToString();
            }
            catch
            {
               
            }
        }

        private void btLuu_Gui_Dong_Click(object sender, EventArgs e)
        {
            Luu_NhapKho_BTP();
            this.Close();
        }
    }
}
