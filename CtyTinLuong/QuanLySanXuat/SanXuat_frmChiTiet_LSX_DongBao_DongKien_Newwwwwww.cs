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
    public partial class SanXuat_frmChiTiet_LSX_DongBao_DongKien_Newwwwwww : Form
    {
        private bool KiemTraLuu()
        {          

            if (txtLenhSX.Text.ToString() == "")
            {
                MessageBox.Show("Chưa có mã lệnh");
                return false;
            }
           
            else if (cbCaSX.Text.ToString() == "")
            {
                MessageBox.Show("Chưa chọn ca sản xuất");
                return false;
            }
            else if (dteNgaySX.EditValue == null)
            {
                MessageBox.Show("Chưa chọn ngày tháng");
                return false;
            }
            else if (gridMaCaTruong.EditValue == null)
            {
                MessageBox.Show("Chưa chọn ca trưởng");
                return false;
            }
            else if (gridMaCN.EditValue == null)
            {
                MessageBox.Show("Chưa chọn công nhân");
                return false;
            }
            else if (gridMaNguoiLap.EditValue == null)
            {
                MessageBox.Show("Chưa chọn người lập");
                return false;
            }
            else if (gridDinhMucSLMay_IN.EditValue == null)
            {
                MessageBox.Show("Chưa chọn định mức lương");
                return false;
            }                      
            else if (gridThanhPham.EditValue == null)
            {
                MessageBox.Show("chưa có mã thành phẩm");
                return false;
            }
            if (txtSanLuong.Text.ToString() == "" || Convert.ToDouble(txtSanLuong.Text.ToString()) == 0)
            {
                MessageBox.Show("Chưa có sản lương thành phẩm");
                return false;
            }
            else return true;

        }
        private void Luu_Chi_Luu_ThemMoi_LenhSanXuat()
        {
            if (!KiemTraLuu()) return;
            else
            {

                clsHUU_LenhSanXuat_DongBaoDongKien cls1 = new clsHUU_LenhSanXuat_DongBaoDongKien();
                cls1.sMaLenhSanXuat = txtLenhSX.Text.ToString();
                cls1.sCaSanXuat = cbCaSX.Text.ToString();
                cls1.daNgayThangSanXuat = dteNgaySX.DateTime;
                cls1.iID_CongNhan = Convert.ToInt32(gridMaCN.EditValue.ToString());
                cls1.iID_CaTruong = Convert.ToInt32(gridMaCaTruong.EditValue.ToString());
                cls1.sGhiChu = txtGhiChu.Text.ToString();
                cls1.bTonTai = true;
                cls1.bNgungTheoDoi = false;
                cls1.iID_NguoiLap = Convert.ToInt32(gridMaNguoiLap.EditValue.ToString());
                cls1.bTrangThai_NhapKho_ThanhPham = false;
                cls1.bTrangThai_XuatKho_VatTuChinh = false;
                cls1.bTrangThai_XuatKho_VatTuPhu = false;
                cls1.iID_VTHH_ThanhPham = Convert.ToInt32(gridThanhPham.EditValue.ToString());
                cls1.fDonGia_ThanhPham = Convert.ToDouble(txtDonGiaThanhTpham.Text.ToString());
                cls1.fThanhTien_ThanhPham = Convert.ToDouble(txtThanhTien.Text.ToString());
                cls1.fSoLuong_ThanhPham = Convert.ToDouble(txtSanLuong.Text.ToString());
                cls1.fPhePham = Convert.ToDouble(txtPhePham.Text.ToString());
                cls1.bGuiDuLieu = false;               
                cls1.iID_DinhMuc_Luong_SanLuong = Convert.ToInt32(gridDinhMucSLMay_IN.EditValue.ToString());
                cls1.bCheck_DongBao = checkDongBao.Checked;
                if (UCSanXuat_LenhSanXuat_DongBao_DongKien_Newwwwwwww.mbThemMoi_LenhSX == true)
                    cls1.Insert();
                else
                {
                    cls1.iID_LenhSanXuat = UCSanXuat_LenhSanXuat_DongBao_DongKien_Newwwwwwww.mID_iD_LenhSanXuat;
                    cls1.Update();
                }
                
                MessageBox.Show("Đã lưu");
                //this.Close();
            }
        }
        private void Luu_ThemMoi_LenhSanXuat_va_GuiDuLuu()
        {
            if (!KiemTraLuu()) return;
            else
            {
                clsHUU_LenhSanXuat_DongBaoDongKien cls1 = new clsHUU_LenhSanXuat_DongBaoDongKien();
                cls1.sMaLenhSanXuat = txtLenhSX.Text.ToString();
                cls1.sCaSanXuat = cbCaSX.Text.ToString();
                cls1.daNgayThangSanXuat = dteNgaySX.DateTime;
                cls1.iID_CongNhan = Convert.ToInt32(gridMaCN.EditValue.ToString());
                cls1.iID_CaTruong = Convert.ToInt32(gridMaCaTruong.EditValue.ToString());
                cls1.sGhiChu = txtGhiChu.Text.ToString();
                cls1.bTonTai = true;
                cls1.bNgungTheoDoi = false;
                cls1.iID_NguoiLap = Convert.ToInt32(gridMaNguoiLap.EditValue.ToString());
                cls1.bTrangThai_NhapKho_ThanhPham = false;
                cls1.bTrangThai_XuatKho_VatTuChinh = false;
                cls1.bTrangThai_XuatKho_VatTuPhu = false;
                cls1.iID_VTHH_ThanhPham = Convert.ToInt32(gridThanhPham.EditValue.ToString());
                cls1.fDonGia_ThanhPham = Convert.ToDouble(txtDonGiaThanhTpham.Text.ToString());
                cls1.fThanhTien_ThanhPham = Convert.ToDouble(txtThanhTien.Text.ToString());
                cls1.fSoLuong_ThanhPham = Convert.ToDouble(txtSanLuong.Text.ToString());
                cls1.fPhePham = Convert.ToDouble(txtPhePham.Text.ToString());
                cls1.bGuiDuLieu = true;
                cls1.iID_DinhMuc_Luong_SanLuong = Convert.ToInt32(gridDinhMucSLMay_IN.EditValue.ToString());
                cls1.bCheck_DongBao = checkDongBao.Checked;
                if (UCSanXuat_LenhSanXuat_DongBao_DongKien_Newwwwwwww.mbThemMoi_LenhSX == true)
                    cls1.Insert();
                else
                {
                    cls1.iID_LenhSanXuat = UCSanXuat_LenhSanXuat_DongBao_DongKien_Newwwwwwww.mID_iD_LenhSanXuat;
                    cls1.Update();
                }

                MessageBox.Show("Đã lưu");
                this.Close();
            }
        }
        private void HienThi_ThemMoi_LenhSX()
        {
            gridMaNguoiLap.EditValue = 12;
            clsHUU_LenhSanXuat_DongBaoDongKien cls1 = new CtyTinLuong.clsHUU_LenhSanXuat_DongBaoDongKien();
            DataTable dt1 = cls1.SelectAll();
            dt1.DefaultView.RowFilter = " TonTai= True and NgungTheoDoi=false";
            DataView dv = dt1.DefaultView;
            DataTable dv3 = dv.ToTable();
            int k = dv3.Rows.Count;

            if (dv3.Rows.Count == 0)
                txtLenhSX.Text = "LSX_DB_DK_1";
            else
            {
                string xxx = dt1.Rows[k - 1]["MaLenhSanXuat"].ToString();
                int xxx2 = Convert.ToInt32(xxx.Substring(10).Trim()) + 1;
                txtLenhSX.Text = "LSX_DB_DK_" + xxx2 + "";
            }
            dteNgaySX.EditValue = DateTime.Today;
            checkDongBao.Checked = true;
        }
        private void HienThi_Sua_LenhSX()
        {
            clsHUU_LenhSanXuat_DongBaoDongKien cls = new clsHUU_LenhSanXuat_DongBaoDongKien();
            cls.iID_LenhSanXuat = UCSanXuat_LenhSanXuat_DongBao_DongKien_Newwwwwwww.mID_iD_LenhSanXuat;
            DataTable dt = cls.SelectOne();
            if (cls.bGuiDuLieu.Value == true)
            {
                btLuuu22222.Enabled = false;
                btChiLuu.Enabled = false;
                btLuu_GUi_Dong.Enabled = false;
                btChiLuu_Dong.Enabled = false;
            }
            else
            {
                btLuuu22222.Enabled = true;
                btChiLuu.Enabled = true;
                btLuu_GUi_Dong.Enabled = true;
                btChiLuu_Dong.Enabled = true;
            }
            txtLenhSX.Text = cls.sMaLenhSanXuat.Value.ToString();
            dteNgaySX.EditValue = cls.daNgayThangSanXuat.Value;
            cbCaSX.Text = cls.sCaSanXuat.Value.ToString();
            gridMaCaTruong.EditValue = cls.iID_CaTruong.Value;
            gridMaCN.EditValue = cls.iID_CongNhan.Value;
            gridMaNguoiLap.EditValue = cls.iID_NguoiLap.Value;
            txtGhiChu.Text = cls.sGhiChu.Value.ToString();
            gridThanhPham.EditValue = cls.iID_VTHH_ThanhPham.Value;
            txtPhePham.Text = cls.fPhePham.Value.ToString();
            txtSanLuong.Text = cls.fSoLuong_ThanhPham.Value.ToString();
            txtDonGiaThanhTpham.Text = cls.fDonGia_ThanhPham.Value.ToString();
            gridDinhMucSLMay_IN.EditValue = cls.iID_DinhMuc_Luong_SanLuong.Value;
            checkDongBao.Checked = cls.bCheck_DongBao.Value;
            if (cls.bCheck_DongBao.Value == false)
                checkDongKien.Checked = true;
        }


        private void Load_lockUP_EDIT()
        {
          

            clsTbVatTuHangHoa clsxx = new clsTbVatTuHangHoa();
            DataTable dtkksss = clsxx.SelectAll();
            dtkksss.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvcxxx = dtkksss.DefaultView;
            DataTable vdtrhh = dvcxxx.ToTable();

            gridThanhPham.Properties.DataSource = vdtrhh;
            gridThanhPham.Properties.ValueMember = "ID_VTHH";
            gridThanhPham.Properties.DisplayMember = "MaVT";

         


            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=8";
            DataView dvCaTruong = dtNguoi.DefaultView;
            DataTable newdtCaTruong = dvCaTruong.ToTable();

            gridMaCaTruong.Properties.DataSource = newdtCaTruong;
            gridMaCaTruong.Properties.ValueMember = "ID_NhanSu";
            gridMaCaTruong.Properties.DisplayMember = "MaNhanVien";


            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=4";
            DataView dvnguoilap = dtNguoi.DefaultView;
            DataTable newdtnguoilap = dvnguoilap.ToTable();

            gridMaNguoiLap.Properties.DataSource = newdtnguoilap;
            gridMaNguoiLap.Properties.ValueMember = "ID_NhanSu";
            gridMaNguoiLap.Properties.DisplayMember = "MaNhanVien";

            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_ChucVu=3";
            DataView dvcongnhan = dtNguoi.DefaultView;
            DataTable newdvcongnhan = dvcongnhan.ToTable();

            gridMaCN.Properties.DataSource = newdvcongnhan;
            gridMaCN.Properties.ValueMember = "ID_NhanSu";
            gridMaCN.Properties.DisplayMember = "MaNhanVien";


            clsDinhMuc_DinhMuc_Luong_TheoSanLuong clssanluong = new CtyTinLuong.clsDinhMuc_DinhMuc_Luong_TheoSanLuong();
            DataTable dtDinhMucSanLuong = clssanluong.SelectAll();
            dtDinhMucSanLuong.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvsanluiong = dtDinhMucSanLuong.DefaultView;
            DataTable newdtsanluong = dvsanluiong.ToTable();

            gridDinhMucSLMay_IN.Properties.DataSource = newdtsanluong;
            gridDinhMucSLMay_IN.Properties.ValueMember = "ID_DinhMuc_Luong_SanLuong";
            gridDinhMucSLMay_IN.Properties.DisplayMember = "MaDinhMuc";

        }

        public SanXuat_frmChiTiet_LSX_DongBao_DongKien_Newwwwwww()
        {
            InitializeComponent();
        }

        private void SanXuat_frmChiTiet_LSX_DongBao_DongKien_Newwwwwww_Load(object sender, EventArgs e)
        {
            Load_lockUP_EDIT();
            if (UCSanXuat_LenhSanXuat_DongBao_DongKien_Newwwwwwww.mbThemMoi_LenhSX == true)
            {
                HienThi_ThemMoi_LenhSX();
            }
            else if (UCSanXuat_LenhSanXuat_DongBao_DongKien_Newwwwwwww.mbThemMoi_LenhSX == false)
            {
                HienThi_Sua_LenhSX();
            }
        }

        private void gridThanhPham_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsTbVatTuHangHoa clsncc = new clsTbVatTuHangHoa();

                clsncc.iID_VTHH = Convert.ToInt32(gridThanhPham.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenThanhPham.Text = dt.Rows[0]["TenVTHH"].ToString();
                    txtDVTThanhPham.Text = dt.Rows[0]["DonViTinh"].ToString();

                }
            }
            catch
            {

            }
        }

        private void gridMaCaTruong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                int iiiIDiID_CaTruong = Convert.ToInt32(gridMaCaTruong.EditValue.ToString());
                clsncc.iID_NhanSu = iiiIDiID_CaTruong;
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenCaTruong.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }

            }
            catch
            {

            }
        }

        private void gridMaCN_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt32(gridMaCN.EditValue.ToString());
                int iiiiID_CongNhan = Convert.ToInt32(gridMaCN.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenCN.Text = dt.Rows[0]["TenNhanVien"].ToString();
                    if (Convert.ToInt32(dt.Rows[0]["ID_DinhMuc_Luong_SanLuong"].ToString()) > 0)
                        gridDinhMucSLMay_IN.EditValue = Convert.ToInt32(dt.Rows[0]["ID_DinhMuc_Luong_SanLuong"].ToString());
                }
            }
            catch
            {

            }
        }

        private void gridMaNguoiLap_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt32(gridMaNguoiLap.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenNguoilap.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }
            }
            catch
            {

            }
        }

        private void btThoat2222_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btChiLuu_Click(object sender, EventArgs e)
        {
            Luu_Chi_Luu_ThemMoi_LenhSanXuat();
            UCSanXuat_LenhSanXuat_DongBao_DongKien_Newwwwwwww.mbThemMoi_LenhSX = true;
            clsHUU_LenhSanXuat_DongBaoDongKien cls1 = new CtyTinLuong.clsHUU_LenhSanXuat_DongBaoDongKien();
            DataTable dt1 = cls1.SelectAll();
            dt1.DefaultView.RowFilter = " TonTai= True and NgungTheoDoi=false";
            DataView dv = dt1.DefaultView;
            DataTable dv3 = dv.ToTable();
            int k = dv3.Rows.Count;

            if (dv3.Rows.Count == 0)
                txtLenhSX.Text = "LSX_DB_DK_1";
            else
            {
                string xxx = dt1.Rows[k - 1]["MaLenhSanXuat"].ToString();
                int xxx2 = Convert.ToInt32(xxx.Substring(10).Trim()) + 1;
                txtLenhSX.Text = "LSX_DB_DK_" + xxx2 + "";
            }
        }

        private void gridDinhMucSLMay_IN_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsDinhMuc_DinhMuc_Luong_TheoSanLuong clsncc = new clsDinhMuc_DinhMuc_Luong_TheoSanLuong();
                clsncc.iID_DinhMuc_Luong_SanLuong = Convert.ToInt32(gridDinhMucSLMay_IN.EditValue.ToString());
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

        private void txtDonGiaThanhTpham_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDonGiaThanhTpham.Text);
                txtDonGiaThanhTpham.Text = String.Format("{0:#,##0.00}", value);
                if (txtDonGiaThanhTpham.Text.ToString() != "" & txtSanLuong.Text.ToString() != "")
                {
                    double dongia = Convert.ToDouble(txtDonGiaThanhTpham.Text.ToString());
                    double soluong = Convert.ToDouble(txtSanLuong.Text.ToString());
                    txtThanhTien.Text = (dongia * soluong).ToString();
                }

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

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtThanhTien.Text);
                txtThanhTien.Text = String.Format("{0:#,##0.00}", value);
            }
            catch
            {

            }
        }

        private void btLuuu22222_Click(object sender, EventArgs e)
        {
            Luu_ThemMoi_LenhSanXuat_va_GuiDuLuu();
            UCSanXuat_LenhSanXuat_DongBao_DongKien_Newwwwwwww.mbThemMoi_LenhSX = true;
            clsHUU_LenhSanXuat_DongBaoDongKien cls1 = new CtyTinLuong.clsHUU_LenhSanXuat_DongBaoDongKien();
            DataTable dt1 = cls1.SelectAll();
            dt1.DefaultView.RowFilter = " TonTai= True and NgungTheoDoi=false";
            DataView dv = dt1.DefaultView;
            DataTable dv3 = dv.ToTable();
            int k = dv3.Rows.Count;

            if (dv3.Rows.Count == 0)
                txtLenhSX.Text = "LSX_DB_DK_1";
            else
            {
                string xxx = dt1.Rows[k - 1]["MaLenhSanXuat"].ToString();
                int xxx2 = Convert.ToInt32(xxx.Substring(10).Trim()) + 1;
                txtLenhSX.Text = "LSX_DB_DK_" + xxx2 + "";
            }
        }

        private void checkDongBao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDongBao.Checked == true)
                checkDongKien.Checked = false;
        }

        private void checkDongKien_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDongKien.Checked == true)
                checkDongBao.Checked = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Luu_Chi_Luu_ThemMoi_LenhSanXuat();
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Luu_ThemMoi_LenhSanXuat_va_GuiDuLuu();
            this.Close();
        }
    }
}
