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
    public partial class KhoBTP_ChiTietNhapKho_ToGapDan_SauKhi_Gia_Cong_Xong : Form
    {
        private void HienThi_Sua_XuatKho()
        {

            clsGapDan_tbXuatKho cls1 = new clsGapDan_tbXuatKho();
            cls1.iID_XuatKho = UCBanThanhPham_NhapKho_Tu_GapDan.miID_XuatKho_GapDan;
            DataTable dt22222 = cls1.SelectOne();

            gridDinhMucGapDan.EditValue = cls1.iID_DinhMuc_ToGapDan.Value;
            txtSoChungTuGapDan.Text = cls1.sSoChungTu.Value;
            if (cls1.bTrangThaiNhapKhoBTP_ThanhPham == true)
            {
                btLuu_Gui_Dong.Enabled = false;
                clsKhoBTP_tbNhapKho cls2 = new CtyTinLuong.clsKhoBTP_tbNhapKho();
                cls2.sThamChieu = cls1.sSoChungTu.Value;
                DataTable dt2xxx = cls2.SelectOne_W_ThamChieu_XuatKho_ToGapDan();
                gridNguoiLap.EditValue = Convert.ToInt32(dt2xxx.Rows[0]["ID_NguoiNhap"].ToString());
                dteNgayChungTu.EditValue = Convert.ToDateTime(dt2xxx.Rows[0]["NgayChungTu"].ToString());
                txtSoChungTu.Text = dt2xxx.Rows[0]["SoChungTu"].ToString();
                txtDienGiai.Text = dt2xxx.Rows[0]["DienGiai"].ToString();

                clsKhoBTP_tbChiTietNhapKho cls3 = new CtyTinLuong.clsKhoBTP_tbChiTietNhapKho();
                cls3.iID_NhapKho = Convert.ToInt32(dt2xxx.Rows[0]["ID_NhapKhoBTP"].ToString());
                DataTable dt222 = cls3.Select__W_ID_NhapKho_HienThi_SuaDonHang();
                txtSoLuongNhapThucTe.Text = dt222.Rows[0]["SoLuongNhap"].ToString();
                txtDonGia_VTChinh.Text = dt222.Rows[0]["DonGia"].ToString();
                double aaaSoLuongXuatThucTe = Convert.ToDouble(dt222.Rows[0]["SoLuongNhap"].ToString());
                double aaatxtDonGia_VTChinh = Convert.ToDouble(dt222.Rows[0]["DonGia"].ToString());
                txtTongTienHang.Text = (aaaSoLuongXuatThucTe * aaatxtDonGia_VTChinh).ToString();
               
            }
            else
            {
                clsKhoBTP_tbXuatKho cls3 = new clsKhoBTP_tbXuatKho();
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
                    //if (xxx2 >= 10000)
                    //    txtSoChungTu.Text = "XKBTP 1";
                    //else 
                    txtSoChungTu.Text = "NKBTP " + xxx2 + "";

                }
                gridNguoiLap.EditValue = 12;
                dteNgayChungTu.EditValue = DateTime.Today;
                //txtSoLuongXuat.Text = cls1.fSoLuongThanhPham_QuyDoi.Value.ToString();
                txtSoLuongNhapThucTe.Text = cls1.fSoLuongThanhPham_QuyDoi.Value.ToString();
                txtDonGia_VTChinh.Text = cls1.fDonGia_ThanhPham_QuyDoi.Value.ToString();
            }

        }
        private void Load_LockUp()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvCaTruong = dtNguoi.DefaultView;
            DataTable newdtCaTruong = dvCaTruong.ToTable();

            gridNguoiLap.Properties.DataSource = newdtCaTruong;
            gridNguoiLap.Properties.ValueMember = "ID_NhanSu";
            gridNguoiLap.Properties.DisplayMember = "MaNhanVien";



            clsDinhMuc_DinhMuc_ToGapDan clsdinhmucnpl = new clsDinhMuc_DinhMuc_ToGapDan();
            DataTable dt2 = clsdinhmucnpl.SelectAll();
            dt2.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvnpl = dt2.DefaultView;
            DataTable newdtnpl = dvnpl.ToTable();


            gridDinhMucGapDan.Properties.DataSource = newdtnpl;
            gridDinhMucGapDan.Properties.ValueMember = "ID_DinhMuc_ToGapDan";
            gridDinhMucGapDan.Properties.DisplayMember = "MaDinhMuc";




        }
        private bool KiemTraLuu()
        {
            if (gridDinhMucGapDan.EditValue.ToString() == "")
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

        private bool Luu_Va_Gui_DuLieu()
        {
            if (!KiemTraLuu()) return false;
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
                cls1.sThamChieu = txtSoChungTuGapDan.Text.ToString();
                cls1.bDaNhapKho = true;
                cls1.bBool_TonDauKy = false;
                cls1.Insert();

                clsKhoBTP_tbChiTietNhapKho clsxuatkhobtp = new clsKhoBTP_tbChiTietNhapKho();
                clsxuatkhobtp.iID_NhapKho = cls1.iID_NhapKhoBTP.Value; ;
                clsxuatkhobtp.iID_VTHH = Convert.ToInt32(txtID_ThanhPham.Text.ToString());
                clsxuatkhobtp.fSoLuongNhap = Convert.ToDouble(txtSoLuongNhapThucTe.Text.ToString());
                clsxuatkhobtp.fSoLuongTon = Convert.ToDouble(txtSoLuongNhapThucTe.Text.ToString());
                clsxuatkhobtp.fDonGia = Convert.ToDouble(txtDonGia_VTChinh.Text.ToString());
                clsxuatkhobtp.bTonTai = true;
                clsxuatkhobtp.bNgungTheoDoi = false;
                clsxuatkhobtp.bDaNhapKho = true;
                clsxuatkhobtp.sGhiChu = "";
                clsxuatkhobtp.bBoolTonDauKy = false;
                clsxuatkhobtp.Insert();
               

                /// Update trang thai nhâp kho BTP trong tbGapDan
                clsGapDan_tbXuatKho clsxxx = new CtyTinLuong.clsGapDan_tbXuatKho();
                clsxxx.iID_XuatKho = UCBanThanhPham_NhapKho_Tu_GapDan.miID_XuatKho_GapDan;
                clsxxx.Update_TrangThaiNhapKhoBTP_ThanhPham();             
                return true;

            }


        }
        public KhoBTP_ChiTietNhapKho_ToGapDan_SauKhi_Gia_Cong_Xong()
        {
            InitializeComponent();
        }

        private void KhoBTP_ChiTietNhapKho_ToGapDan_SauKhi_Gia_Cong_Xong_Load(object sender, EventArgs e)
        {
            Load_LockUp();
            HienThi_Sua_XuatKho();
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

        private void gridDinhMucGapDan_EditValueChanged(object sender, EventArgs e)
        {
            clsTbVatTuHangHoa clsvt = new clsTbVatTuHangHoa();
            clsDinhMuc_ChiTiet_DinhMuc_ToGapDan cls = new CtyTinLuong.clsDinhMuc_ChiTiet_DinhMuc_ToGapDan();
            cls.iID_DinhMuc_ToGapDan = Convert.ToInt32(gridDinhMucGapDan.EditValue.ToString());
            DataTable dt = cls.SelectAll_W_ID_DinhMuc_ToGapDan();
            if (dt.Rows.Count > 0)
            {
                double xxsoluongxuat = Convert.ToDouble(txtSoLuongNhapThucTe.Text.ToString());
                DataTable dt422 = dt.Copy();
                dt422.DefaultView.RowFilter = " Check_ThanhPham = True";
                DataView dv1 = dt422.DefaultView;
                DataTable dt22 = dv1.ToTable();
                txtID_ThanhPham.Text = dt22.Rows[0]["ID_VTHH"].ToString();
                txtMaTPQuyDoi.Text = dt22.Rows[0]["MaVT"].ToString();
                txtTenThanhPhamQuyDoi.Text = dt22.Rows[0]["TenVTHH"].ToString();
                txtDVTThanhPhamQuyDoi.Text = dt22.Rows[0]["DonViTinh"].ToString();

                //DataTable dt322 = dt.Copy();
                //dt322.DefaultView.RowFilter = " Check_VatTu_Chinh = True";
                //DataView dv2 = dt322.DefaultView;
                //DataTable dt223 = dv2.ToTable();
                //txtID_VatTuChinh.Text = dt223.Rows[0]["ID_VTHH"].ToString();
                ////txtMaVTChinh.Text = dt223.Rows[0]["MaVT"].ToString();
                ////txtTenVatTu_Chinh.Text = dt223.Rows[0]["TenVTHH"].ToString();

                ////txtDVT_VT_CHinh.Text = dt223.Rows[0]["DonViTinh"].ToString();

                //double SoLuong_VTChinh_DinhMuc = Convert.ToDouble(dt223.Rows[0]["SoLuong"].ToString());
                //txtSoLuongNhapKhoBTP_TheoDinhMuc.Text = (SoLuong_VTChinh_DinhMuc * xxsoluongxuat).ToString();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btLuu_Gui_Dong_Click(object sender, EventArgs e)
        {
            if (!KiemTraLuu()) return;
            else if (!Luu_Va_Gui_DuLieu()) return;
            else
            {
                MessageBox.Show("Đã lưu");
                this.Close();
            }
        }

        private void txtSoLuongXuatThucTe_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtSoLuongXuat.Text.ToString() != "" & gridDinhMucGapDan.EditValue.ToString() != "")
            //    {
            //        clsDinhMuc_ChiTiet_DinhMuc_ToGapDan cls = new CtyTinLuong.clsDinhMuc_ChiTiet_DinhMuc_ToGapDan();
            //        cls.iID_DinhMuc_ToGapDan = Convert.ToInt32(gridDinhMucGapDan.EditValue.ToString());
            //        DataTable dt = cls.SelectAll_W_ID_DinhMuc_ToGapDan();

            //        double xxsoluongxuat = Convert.ToDouble(txtSoLuongXuat.Text.ToString());
            //        DataTable dt422 = dt.Copy();

            //        DataTable dt322 = dt.Copy();
            //        dt322.DefaultView.RowFilter = " Check_VatTu_Chinh = True";
            //        DataView dv2 = dt322.DefaultView;
            //        DataTable dt223 = dv2.ToTable();

            //        double SoLuong_VTChinh_DinhMuc = Convert.ToDouble(dt223.Rows[0]["SoLuong"].ToString());
            //        txtSoLuongNhapKhoBTP_TheoDinhMuc.Text = (SoLuong_VTChinh_DinhMuc * xxsoluongxuat).ToString();



            //    }

            //}
            //catch
            //{

            //}
        }

        private void txtDonGia_VTChinh_TextChanged(object sender, EventArgs e)
        {
            double dongia = Convert.ToDouble(txtDonGia_VTChinh.Text.ToString());
            double soluong = Convert.ToDouble(txtSoLuongNhapThucTe.Text.ToString());
            txtTongTienHang.Text = (dongia * soluong).ToString();
        }

        private void txtDonGia_VTChinh_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDonGia_VTChinh.Text);
                txtDonGia_VTChinh.Text = String.Format("{0:#,##0.00}", value);

            }
            catch
            {

            }
        }

        private void txtDonGia_VTChinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    decimal value = decimal.Parse(txtDonGia_VTChinh.Text);
                    txtDonGia_VTChinh.Text = String.Format("{0:#,##0.00}", value);

                }
                catch
                {

                }
            }
        }
    }
}
