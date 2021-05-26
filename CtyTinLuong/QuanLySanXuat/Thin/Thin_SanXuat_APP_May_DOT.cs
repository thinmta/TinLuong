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
    public partial class Thin_SanXuat_APP_May_DOT : Form
    {
        bool mbthemmoi;
        int miID_ChiTietPhieu;
        private bool KiemTraLuu() // Thìn kiểm tra lại hàm này, bắt hết lỗi, không để trống trường nào cả
        {
            if (txtSanLuong_may_IN.Text.ToString() == "")
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
            else if (gridMaCaTruong.EditValue == null)
            {
                MessageBox.Show("Chưa chọn ca trưởng  ");
                return false;
            }
            else return true;

        }
        private void Load_lockUP_EDIT()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=11";
            DataView dvCongNhan = dtNguoi.DefaultView;
            DataTable newdtCongNhan = dvCongNhan.ToTable();

            gridMaCongNhan_May_IN.Properties.DataSource = newdtCongNhan;
            gridMaCongNhan_May_IN.Properties.ValueMember = "ID_NhanSu";
            gridMaCongNhan_May_IN.Properties.DisplayMember = "MaNhanVien";


            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=8";
            DataView dvCaTruong = dtNguoi.DefaultView;
            DataTable newdtCaTruong = dvCaTruong.ToTable();

            gridMaCaTruong.Properties.DataSource = newdtCaTruong;
            gridMaCaTruong.Properties.ValueMember = "ID_NhanSu";
            gridMaCaTruong.Properties.DisplayMember = "MaNhanVien";


            //clsKhoBTP_tbChiTietNhapKho clsVT = new clsKhoBTP_tbChiTietNhapKho();
            //DataTable dtVT = clsVT.Select_distinct_HienThiLockUpEdit();
            //DataView dvVT = dtVT.DefaultView;
            //DataTable newdtVT = dvVT.ToTable();

            //gridHangHoaVao_may_IN.Properties.DataSource = newdtVT;
            //gridHangHoaVao_may_IN.Properties.ValueMember = "ID_VTHH";
            //gridHangHoaVao_may_IN.Properties.DisplayMember = "MaVT";

            clsTbVatTuHangHoa clsxx = new clsTbVatTuHangHoa();
            DataTable dtkksss = clsxx.SelectAll();
            dtkksss.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvcxxx = dtkksss.DefaultView;
            DataTable vdtrhh = dvcxxx.ToTable();

            gridHangHoaXuat_May_IN.Properties.DataSource = vdtrhh;
            gridHangHoaXuat_May_IN.Properties.ValueMember = "ID_VTHH";
            gridHangHoaXuat_May_IN.Properties.DisplayMember = "MaVT";

            gridHangHoaVao_may_IN.Properties.DataSource = vdtrhh;
            gridHangHoaVao_may_IN.Properties.ValueMember = "ID_VTHH";
            gridHangHoaVao_may_IN.Properties.DisplayMember = "MaVT";

            clsT_MayMoc clsMayMoc = new clsT_MayMoc();
            DataTable dtMayIN = clsMayMoc.SelectAll();
            dtMayIN.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and id_loai=3";
            DataView dvMayIn = dtMayIN.DefaultView;
            DataTable newdtMayIn = dvMayIn.ToTable();

            gridMaMay_IN.Properties.DataSource = newdtMayIn;
            gridMaMay_IN.Properties.ValueMember = "id";
            gridMaMay_IN.Properties.DisplayMember = "MaMay";
            
        }
        private void LuuDuLieu_ChiLuu()
        {
            if (!KiemTraLuu()) return;
            else
            {
                if (mbthemmoi == true)
                {
                    clsPhieu_ChiTietPhieu_CaTruong cls = new clsPhieu_ChiTietPhieu_CaTruong();
                    cls.iID_SoPhieu = Convert.ToInt16(gridMaPhieu.EditValue.ToString());
                    cls.iID_May = Convert.ToInt16(gridMaMay_IN.EditValue.ToString());
                    cls.iID_VTHH_Vao = Convert.ToInt16(gridHangHoaVao_may_IN.EditValue.ToString());
                    cls.iID_VTHH_Ra = Convert.ToInt16(gridHangHoaXuat_May_IN.EditValue.ToString());
                    cls.iID_CaTruong = Convert.ToInt16(gridMaCaTruong.EditValue.ToString());
                    cls.iID_CongNhan = Convert.ToInt16(gridMaCongNhan_May_IN.EditValue.ToString());
                    cls.daNgaySanXuat = dteNgaySanXuat.DateTime;
                    cls.bBMay_IN = false;
                    cls.bBMay_CAT = false;
                    cls.bBMay_DOT = true;
                    cls.sCaSanXuat = cbCaSanXuat.Text.ToString();
                    cls.fSoLuong_Vao = Convert.ToDouble(txtSoLuongNhap_May_IN.Text.ToString());
                    double sanluongthuog = Convert.ToDouble(txtSanLuong_may_IN.Text.ToString());
                    double sanluongtangca = Convert.ToDouble(txtSanLuong_tangca_May_IN.Text.ToString());
                    cls.fSanLuong_Thuong = Convert.ToDouble(txtSanLuong_may_IN.Text.ToString());
                    cls.fSanLuong_TangCa = Convert.ToDouble(txtSanLuong_tangca_May_IN.Text.ToString());
                    cls.fSanLuong_Tong = sanluongtangca + sanluongthuog;
                    cls.fPhePham = Convert.ToDouble(txtPhePham_May_IN.Text.ToString());
                    cls.sGhiChu = txtGhiChu_May_IN.Text.ToString();
                    cls.bGuiDuLieu = false;
                    cls.Insert();
                }
                else
                {
                    clsPhieu_ChiTietPhieu_CaTruong cls = new clsPhieu_ChiTietPhieu_CaTruong();
                    cls.iID_ChiTietPhieu = miID_ChiTietPhieu;
                    cls.iID_SoPhieu = Convert.ToInt16(gridMaPhieu.EditValue.ToString());
                    cls.iID_May = Convert.ToInt16(gridMaMay_IN.EditValue.ToString());
                    cls.iID_VTHH_Vao = Convert.ToInt16(gridHangHoaVao_may_IN.EditValue.ToString());
                    cls.iID_VTHH_Ra = Convert.ToInt16(gridHangHoaXuat_May_IN.EditValue.ToString());
                    cls.iID_CaTruong = Convert.ToInt16(gridMaCaTruong.EditValue.ToString());
                    cls.iID_CongNhan = Convert.ToInt16(gridMaCongNhan_May_IN.EditValue.ToString());
                    cls.daNgaySanXuat = dteNgaySanXuat.DateTime;
                    cls.bBMay_IN = false;
                   cls.bBMay_CAT = false;
                    cls.bBMay_DOT = true;
                    cls.sCaSanXuat = cbCaSanXuat.Text.ToString();
                    cls.fSoLuong_Vao = Convert.ToDouble(txtSoLuongNhap_May_IN.Text.ToString());
                    double sanluongthuog = Convert.ToDouble(txtSanLuong_may_IN.Text.ToString());
                    double sanluongtangca = Convert.ToDouble(txtSanLuong_tangca_May_IN.Text.ToString());
                    cls.fSanLuong_Thuong = Convert.ToDouble(txtSanLuong_may_IN.Text.ToString());
                    cls.fSanLuong_TangCa = Convert.ToDouble(txtSanLuong_tangca_May_IN.Text.ToString());
                    cls.fSanLuong_Tong = sanluongtangca + sanluongthuog;
                    cls.fPhePham = Convert.ToDouble(txtPhePham_May_IN.Text.ToString());
                    cls.sGhiChu = txtGhiChu_May_IN.Text.ToString();
                    cls.bGuiDuLieu = false;
                    cls.Update();
                }

            }
        }
        private void LuuDuLieu_VaGui()
        {
            if (!KiemTraLuu()) return;
            else
            {
                if (mbthemmoi == true)
                {
                    clsPhieu_ChiTietPhieu_CaTruong cls = new clsPhieu_ChiTietPhieu_CaTruong();
                    cls.iID_SoPhieu = Convert.ToInt16(gridMaPhieu.EditValue.ToString());
                    cls.iID_May = Convert.ToInt16(gridMaMay_IN.EditValue.ToString());
                    cls.iID_VTHH_Vao = Convert.ToInt16(gridHangHoaVao_may_IN.EditValue.ToString());
                    cls.iID_VTHH_Ra = Convert.ToInt16(gridHangHoaXuat_May_IN.EditValue.ToString());
                    cls.iID_CaTruong = Convert.ToInt16(gridMaCaTruong.EditValue.ToString());
                    cls.iID_CongNhan = Convert.ToInt16(gridMaCongNhan_May_IN.EditValue.ToString());
                    cls.daNgaySanXuat = dteNgaySanXuat.DateTime;
                    cls.bBMay_IN = false;
                    cls.bBMay_CAT = false;
                    cls.bBMay_DOT = true;
                    cls.sCaSanXuat = cbCaSanXuat.Text.ToString();
                    cls.fSoLuong_Vao = Convert.ToDouble(txtSoLuongNhap_May_IN.Text.ToString());
                    double sanluongthuog = Convert.ToDouble(txtSanLuong_may_IN.Text.ToString());
                    double sanluongtangca = Convert.ToDouble(txtSanLuong_tangca_May_IN.Text.ToString());
                    cls.fSanLuong_Thuong = Convert.ToDouble(txtSanLuong_may_IN.Text.ToString());
                    cls.fSanLuong_TangCa = Convert.ToDouble(txtSanLuong_tangca_May_IN.Text.ToString());
                    cls.fSanLuong_Tong = sanluongtangca + sanluongthuog;
                    cls.fPhePham = Convert.ToDouble(txtPhePham_May_IN.Text.ToString());
                    cls.sGhiChu = txtGhiChu_May_IN.Text.ToString();
                    cls.bGuiDuLieu = true;
                    cls.Insert();
                }
                else
                {
                    clsPhieu_ChiTietPhieu_CaTruong cls = new clsPhieu_ChiTietPhieu_CaTruong();
                    cls.iID_ChiTietPhieu = miID_ChiTietPhieu;
                    cls.iID_SoPhieu = Convert.ToInt16(gridMaPhieu.EditValue.ToString());
                    cls.iID_May = Convert.ToInt16(gridMaMay_IN.EditValue.ToString());
                    cls.iID_VTHH_Vao = Convert.ToInt16(gridHangHoaVao_may_IN.EditValue.ToString());
                    cls.iID_VTHH_Ra = Convert.ToInt16(gridHangHoaXuat_May_IN.EditValue.ToString());
                    cls.iID_CaTruong = Convert.ToInt16(gridMaCaTruong.EditValue.ToString());
                    cls.iID_CongNhan = Convert.ToInt16(gridMaCongNhan_May_IN.EditValue.ToString());
                    cls.daNgaySanXuat = dteNgaySanXuat.DateTime;
                    cls.bBMay_IN = false;
                   cls.bBMay_CAT = false;
                   cls.bBMay_DOT = true;
                    cls.sCaSanXuat = cbCaSanXuat.Text.ToString();
                    cls.fSoLuong_Vao = Convert.ToDouble(txtSoLuongNhap_May_IN.Text.ToString());
                    double sanluongthuog = Convert.ToDouble(txtSanLuong_may_IN.Text.ToString());
                    double sanluongtangca = Convert.ToDouble(txtSanLuong_tangca_May_IN.Text.ToString());
                    cls.fSanLuong_Thuong = Convert.ToDouble(txtSanLuong_may_IN.Text.ToString());
                    cls.fSanLuong_TangCa = Convert.ToDouble(txtSanLuong_tangca_May_IN.Text.ToString());
                    cls.fSanLuong_Tong = sanluongtangca + sanluongthuog;
                    cls.fPhePham = Convert.ToDouble(txtPhePham_May_IN.Text.ToString());
                    cls.sGhiChu = txtGhiChu_May_IN.Text.ToString();
                    cls.bGuiDuLieu = true;
                    cls.Update();
                }

            }

        }
        private void LuuDuLieu_Vao_BangChiTietPhieu()
        {
            if (!KiemTraLuu()) return;
            else
            {
                clsPhieu_ChiTietPhieu_New cls = new clsPhieu_ChiTietPhieu_New();
                cls.iID_SoPhieu = Convert.ToInt16(gridMaPhieu.EditValue.ToString());
                cls.iID_May = Convert.ToInt16(gridMaMay_IN.EditValue.ToString());
                cls.iID_VTHH_Vao = Convert.ToInt16(gridHangHoaVao_may_IN.EditValue.ToString());
                cls.iID_VTHH_Ra = Convert.ToInt16(gridHangHoaXuat_May_IN.EditValue.ToString());
                cls.iID_CaTruong = Convert.ToInt16(gridMaCaTruong.EditValue.ToString());
                cls.iID_CongNhan = Convert.ToInt16(gridMaCongNhan_May_IN.EditValue.ToString());
                cls.daNgaySanXuat = dteNgaySanXuat.DateTime;
                cls.bBMay_IN = false;
               cls.bBMay_CAT = false;
               cls.bBMay_DOT = true;
                cls.sCaSanXuat = cbCaSanXuat.Text.ToString();
                cls.fSoLuong_Vao = Convert.ToDouble(txtSoLuongNhap_May_IN.Text.ToString());
                double sanluongthuog = Convert.ToDouble(txtSanLuong_may_IN.Text.ToString());
                double sanluongtangca = Convert.ToDouble(txtSanLuong_tangca_May_IN.Text.ToString());
                cls.fSanLuong_Thuong = Convert.ToDouble(txtSanLuong_may_IN.Text.ToString());
                cls.fSanLuong_TangCa = Convert.ToDouble(txtSanLuong_tangca_May_IN.Text.ToString());
                cls.fSanLuong_Tong = sanluongtangca + sanluongthuog;
                cls.fPhePham = Convert.ToDouble(txtPhePham_May_IN.Text.ToString());
                cls.sGhiChu = txtGhiChu_May_IN.Text.ToString();
                cls.bGuiDuLieu = false;
                clsKhoBTP_tbChiTietNhapKho clsnhapkho = new clsKhoBTP_tbChiTietNhapKho();
                clsnhapkho.iID_VTHH = Convert.ToInt32(gridHangHoaVao_may_IN.EditValue.ToString());
                DataTable dtnhapkho = clsnhapkho.Select_W_ID_VTHH();
                if (dtnhapkho.Rows.Count > 0)
                    cls.fDonGia_Vao = Convert.ToDouble(dtnhapkho.Rows[0]["DonGia"].ToString());
                else cls.fDonGia_Vao = 0;
                clsNhanSu_tbNhanSu clsnguoi = new clsNhanSu_tbNhanSu();
                clsnguoi.iID_NhanSu = Convert.ToInt32(gridMaCongNhan_May_IN.EditValue.ToString());
                DataTable dtnguoi = clsnguoi.SelectOne();
                if (dtnguoi.Rows[0]["ID_DinhMuc_Luong_SanLuong"].ToString() != "")
                    cls.iID_DinhMuc_Luong = clsnguoi.iID_DinhMuc_Luong_SanLuong.Value;
                else cls.iID_DinhMuc_Luong = 1;
                cls.fDonGia_Xuat = 0;
                cls.bTrangThaiXuatNhap = false;
                cls.bTrangThaiTaoLenhSanXuat = false;
                cls.fSoKG_MotBao_May_Dot = 1;
                cls.Insert();
            }

        }
        private void LuuDuLieu_TrangThai_Phieu()
        {
            if (!KiemTraLuu()) return;
            else
            {
                clsPhieu_tbPhieu cls = new clsPhieu_tbPhieu();
                cls.iID_SoPhieu = Convert.ToInt16(gridMaPhieu.EditValue.ToString());
                cls.iBienTrangThai = 4;
                cls.Update_BienTrangThai();
            }

        }
        private void HienThi_MacDinh()
        {
            if (dteNgayLap.EditValue != null & gridMaPhieu.EditValue != null)
            {
                clsPhieu_tbPhieu cls = new CtyTinLuong.clsPhieu_tbPhieu();
                cls.iID_SoPhieu = Convert.ToInt16(gridMaPhieu.EditValue.ToString());
                DataTable dt = cls.SelectOne();
                gridMaCaTruong.EditValue = cls.iID_CaTruong.Value;
                dteNgaySanXuat.EditValue = cls.daNgayLapPhieu.Value;
                cbCaSanXuat.Text = cls.sCaSanXuat.Value;
                clsPhieu_ChiTietPhieu_CaTruong clsxx = new CtyTinLuong.clsPhieu_ChiTietPhieu_CaTruong();
                clsxx.iID_SoPhieu = Convert.ToInt16(gridMaPhieu.EditValue.ToString());
                DataTable dtxx = clsxx.SelectAll_W_ID_SoPhieu();
                dtxx.DefaultView.RowFilter = " bMay_DOT=True";
                DataView dvxx = dtxx.DefaultView;
                DataTable newdxxxx = dvxx.ToTable();
                if (newdxxxx.Rows.Count > 0)
                {
                    mbthemmoi = false;
                    miID_ChiTietPhieu = Convert.ToInt32(newdxxxx.Rows[0]["ID_ChiTietPhieu"].ToString());
                    gridMaCaTruong.EditValue = Convert.ToInt32(newdxxxx.Rows[0]["ID_CaTruong"].ToString());
                    gridMaCongNhan_May_IN.EditValue = Convert.ToInt32(newdxxxx.Rows[0]["ID_CongNhan"].ToString());
                    gridMaMay_IN.EditValue = Convert.ToInt32(newdxxxx.Rows[0]["ID_May"].ToString());
                    gridHangHoaVao_may_IN.EditValue = Convert.ToInt32(newdxxxx.Rows[0]["ID_VTHH_Vao"].ToString());
                    gridHangHoaXuat_May_IN.EditValue = Convert.ToInt32(newdxxxx.Rows[0]["ID_VTHH_Ra"].ToString());
                    dteNgaySanXuat.EditValue = Convert.ToDateTime(newdxxxx.Rows[0]["NgaySanXuat"].ToString());
                    cbCaSanXuat.Text = newdxxxx.Rows[0]["CaSanXuat"].ToString();
                    txtSoLuongNhap_May_IN.Text = newdxxxx.Rows[0]["SoLuong_Vao"].ToString();
                    txtSanLuong_may_IN.Text = newdxxxx.Rows[0]["SanLuong_Thuong"].ToString();
                    txtSanLuong_tangca_May_IN.Text = newdxxxx.Rows[0]["SanLuong_TangCa"].ToString();
                    txtPhePham_May_IN.Text = newdxxxx.Rows[0]["PhePham"].ToString();
                    txtGhiChu_May_IN.Text = newdxxxx.Rows[0]["GhiChu"].ToString();
                    if (Convert.ToBoolean(newdxxxx.Rows[0]["GuiDuLieu"].ToString()) == true)
                    {
                        btChiLuu.Enabled = false;
                        btLuu_VaGui.Enabled = false;
                    }
                    else
                    {
                        btChiLuu.Enabled = true;
                        btLuu_VaGui.Enabled = true;

                    }
                }
                else
                {
                    mbthemmoi = true;
                    btChiLuu.Enabled = true;
                    btLuu_VaGui.Enabled = true;
                }
            }
        }
        private void HienThi_MaPhieu()
        {
            clsPhieu_tbPhieu cls = new CtyTinLuong.clsPhieu_tbPhieu();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.RowFilter = " NgayLapPhieu ='" + dteNgayLap.DateTime + "'";
            DataView dv = dt.DefaultView;
            DataTable dxxxx = dv.ToTable();
            gridMaPhieu.Properties.DataSource = dxxxx;
            gridMaPhieu.Properties.ValueMember = "ID_SoPhieu";
            gridMaPhieu.Properties.DisplayMember = "MaPhieu";

        }
        public Thin_SanXuat_APP_May_DOT()
        {
            InitializeComponent();
        }

        private void Thin_SanXuat_APP_May_DOT_Load(object sender, EventArgs e)
        {
            Load_lockUP_EDIT();
            dteNgayLap.DateTime = DateTime.Today;
            //btChiLuu.Enabled = false;
            //btLuu_VaGui.Enabled = false;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dteNgayLap_EditValueChanged(object sender, EventArgs e)
        {
            if (dteNgayLap.EditValue != null)
            {
                HienThi_MaPhieu();

            }
        }

        private void gridMaPhieu_EditValueChanged(object sender, EventArgs e)
        {
            if (dteNgayLap.EditValue != null & gridMaPhieu.EditValue != null)
            {
                HienThi_MacDinh();

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

        private void gridMaCaTruong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt16(gridMaCaTruong.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenCaTruongmayIn.Text = dt.Rows[0]["TenNhanVien"].ToString();

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

                }



            }
            catch
            {

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

                }
            }
            catch
            {

            }
        }

        private void btChiLuu_Click(object sender, EventArgs e)
        {
            LuuDuLieu_ChiLuu();
            MessageBox.Show("Đã lưu");
            HienThi_MacDinh();
        }

        private void btLuu_VaGui_Click(object sender, EventArgs e)
        {
            LuuDuLieu_VaGui();
            LuuDuLieu_Vao_BangChiTietPhieu();
            LuuDuLieu_TrangThai_Phieu();
            MessageBox.Show("Đã lưu va gửi dữ liệu");
            HienThi_MacDinh();
        }
    }
}
