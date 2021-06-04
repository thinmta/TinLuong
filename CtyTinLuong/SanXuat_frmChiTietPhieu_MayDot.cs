using DevExpress.XtraGrid.Views.Grid;
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
    public partial class SanXuat_frmChiTietPhieu_MayDot : Form
    {
        private void LuuDuLieu_BoSungCongNhan()
        {
            DataTable dv3 = (DataTable)gridControl1.DataSource;
            clsPhieu_ChiTietPhieu_New_BoSungCongNhan_MayDot cls1 = new CtyTinLuong.clsPhieu_ChiTietPhieu_New_BoSungCongNhan_MayDot();
            cls1.iID_SoPhieu = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.MIiiiid_SoPhieu;
            cls1.Delete_All_W_ID_SoPhieu();

            for (int i = 0; i < dv3.Rows.Count; i++)
            {
                cls1.iID_SoPhieu = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.MIiiiid_SoPhieu;
                cls1.iID_CongNhan = Convert.ToInt32(dv3.Rows[i]["ID_CongNhan"].ToString());
                cls1.iID_CaTruong = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.mi_ID_Catruong;
                cls1.daNgaySanXuat = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.mdaNgaySanXuatDot;
                cls1.sCaSanXuat = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.msCaSXDot;
                cls1.bGuiDuLieu = true;
                cls1.bCheck_MayDot_True_May_Cat_False = true;
                cls1.Insert();
            }

        }
        private void Load_LockUp_congNhan()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=11";
            DataView dvCaTruong = dtNguoi.DefaultView;
            DataTable newdtCaTruong = dvCaTruong.ToTable();

            gridMaNhanVien.DataSource = newdtCaTruong;
            gridMaNhanVien.ValueMember = "ID_NhanSu";
            gridMaNhanVien.DisplayMember = "MaNhanVien";


        }
        private void HienThi_CongNhan()
        {
            Load_LockUp_congNhan();
            dteNgaySanXuat_May_DOT.EditValue = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.mdaNgaySanXuatDot;
            cbCaSanXuat_May_DOT.Text = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.msCaSXDot.ToString();

            clsNhanSu_tbNhanSu cls1 = new clsNhanSu_tbNhanSu();
            cls1.iID_NhanSu = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.mi_ID_COngNhanh_MayDot_ToTruong;
            DataTable dt1 = cls1.SelectOne();
            

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_ChiTietPhieu_BoSungMayDot"); // ID của tbChi tiet don hàng
            dt2.Columns.Add("ID_SoPhieu");
            dt2.Columns.Add("ID_CongNhan");
            dt2.Columns.Add("NgaySanXuat", typeof(DateTime));
            dt2.Columns.Add("CaSanXuat", typeof(string));
            dt2.Columns.Add("TenNhanVien");
            dt2.Columns.Add("HienThi", typeof(string));
            dt2.Columns.Add("MaNhanVien", typeof(string));
            clsPhieu_ChiTietPhieu_New_BoSungCongNhan_MayDot cls = new CtyTinLuong.clsPhieu_ChiTietPhieu_New_BoSungCongNhan_MayDot();
            cls.iID_SoPhieu = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.MIiiiid_SoPhieu;
            DataTable dt3 = cls.SelectAll_W_ID_SoPhieu();
            if (dt3.Rows.Count > 0)
            {

                for (int i = 0; i < dt3.Rows.Count; i++)
                {
                    DataRow _ravi = dt2.NewRow();
                    _ravi["ID_ChiTietPhieu_BoSungMayDot"] = dt3.Rows[i]["ID_ChiTietPhieu_BoSungMayDot"].ToString();
                    _ravi["ID_SoPhieu"] = dt3.Rows[i]["ID_SoPhieu"].ToString();
                    _ravi["ID_CongNhan"] = dt3.Rows[i]["ID_CongNhan"].ToString();
                    _ravi["MaNhanVien"] = dt3.Rows[i]["ID_CongNhan"].ToString();
                    _ravi["TenNhanVien"] = dt3.Rows[i]["TenNhanVien"].ToString();
                    _ravi["HienThi"] = "1";
                    dt2.Rows.Add(_ravi);
                }

            }
            gridControl1.DataSource = dt2;
        }
       
        private void HienThi_May_DOT()
        {
            if (UC_SanXuat_PhieuSanXuat.mb_ThemMoi_SoPhieu == false)
            {
                clsPhieu_ChiTietPhieu_New cls = new clsPhieu_ChiTietPhieu_New();
                cls.iID_SoPhieu = UC_SanXuat_PhieuSanXuat.mID_iD_SoPhieu;
                DataTable dxxxx = cls.SelectAll_W_iID_SoPhieu();
                dxxxx.DefaultView.RowFilter = "bMay_DOT = True";
                DataView dv = dxxxx.DefaultView;
                DataTable dt = dv.ToTable();

                if (dt.Rows.Count > 0)
                {
                    //mbThemMoi_DOT = false;
                    int ID_ChiTietPhieu = Convert.ToInt32(dt.Rows[0]["ID_ChiTietPhieu"].ToString());
                    int ID_SoPhieu = Convert.ToInt32(dt.Rows[0]["ID_SoPhieu"].ToString());
                    int ID_May = Convert.ToInt32(dt.Rows[0]["ID_May"].ToString());
                    int ID_CongNhan = Convert.ToInt32(dt.Rows[0]["ID_CongNhan"].ToString());
                    int ID_CaTruong = Convert.ToInt32(dt.Rows[0]["ID_CaTruong"].ToString());
                    DateTime NgaySanXuat = Convert.ToDateTime(dt.Rows[0]["NgaySanXuat"].ToString());
                    string GhiChu = dt.Rows[0]["GhiChu"].ToString();
                    string CaSanXuat = dt.Rows[0]["CaSanXuat"].ToString();
                    int ID_DinhMuc_Luong = Convert.ToInt32(dt.Rows[0]["ID_DinhMuc_Luong"].ToString());
                    int ID_VTHH_Vao = Convert.ToInt32(dt.Rows[0]["ID_VTHH_Vao"].ToString());
                    double SoLuong_Vao = Convert.ToDouble(dt.Rows[0]["SoLuong_Vao"].ToString());
                    double DonGia_Vao = Convert.ToDouble(dt.Rows[0]["DonGia_Vao"].ToString());
                    int ID_VTHH_Ra = Convert.ToInt32(dt.Rows[0]["ID_VTHH_Ra"].ToString());

                    double SanLuong_Thuong = Convert.ToDouble(dt.Rows[0]["SanLuong_Thuong"].ToString());
                    double SanLuong_TangCa = Convert.ToDouble(dt.Rows[0]["SanLuong_TangCa"].ToString());
                    double SanLuong_Tong = Convert.ToDouble(dt.Rows[0]["SanLuong_Tong"].ToString());
                    double DonGia_Xuat = Convert.ToDouble(dt.Rows[0]["DonGia_Xuat"].ToString());
                    double PhePham = Convert.ToDouble(dt.Rows[0]["PhePham"].ToString());

                    gridMaCaTruong_May_DOT.EditValue = ID_CaTruong;
                    dteNgaySanXuat_May_DOT.EditValue = NgaySanXuat;
                    cbCaSanXuat_May_DOT.Text = CaSanXuat;
                    gridHangHoaVao_may_DOT.EditValue = ID_VTHH_Vao;
                    gridMaMay_DOT.EditValue = ID_May;

                    gridDinhMucSLMay_DOT.EditValue = ID_DinhMuc_Luong;
                    txtSoLuongNhap_May_DOT.Text = SoLuong_Vao.ToString();
                    txtDonGiaXuat_May_DOT.Text = DonGia_Vao.ToString();
                    txtDonGiaNhap_May_DOT.Text = DonGia_Vao.ToString();
                    txtSanLuong_may_DOT.Text = SanLuong_Thuong.ToString();
                    if (dt.Rows[0]["SoKG_MotBao_May_Dot"].ToString() == "")
                    {
                        txtSoKGMotBao.Text = "1";
                        txtQuyDoiRaKG.Text = SanLuong_Thuong.ToString();
                    }
                    else
                    {
                        double SoKGMotBao = Convert.ToDouble(dt.Rows[0]["SoKG_MotBao_May_Dot"].ToString());
                        txtSoKGMotBao.Text = dt.Rows[0]["SoKG_MotBao_May_Dot"].ToString();
                        txtQuyDoiRaKG.Text = (SanLuong_Thuong * SoKGMotBao).ToString();
                    }

                    gridHangHoaXuat_May_DOT.EditValue = ID_VTHH_Ra;
                    txtPhePham_May_DOT.Text = PhePham.ToString();
                    txtGhiChu_May_DOT.Text = GhiChu.ToString();
                    gridMaCongNhan_May_DOT.EditValue = ID_CongNhan;
                }

            }
        }

        private bool KiemTraLuu_May_DOT()
        {
            if (txtQuyDoiRaKG.Text.ToString() == "")
            {
                MessageBox.Show("Chưa có sản lượng ");
                return false;
            }
            else if (gridHangHoaVao_may_DOT.EditValue == null)
            {
                MessageBox.Show("Chưa chọn vật tư vào  ");
                return false;
            }
            else if (gridHangHoaXuat_May_DOT.EditValue == null)
            {
                MessageBox.Show("Chưa chọn vật tư ra  ");
                return false;
            }
            else if (gridMaMay_DOT.EditValue == null)
            {
                MessageBox.Show("Chưa chọn máy gia công  ");
                return false;
            }

            else if (gridMaCongNhan_May_DOT.EditValue == null)
            {
                MessageBox.Show("Chưa chọn công nhân  ");
                return false;
            }
            else if (gridDinhMucSLMay_DOT.EditValue == null)
            {
                MessageBox.Show("Chưa định mức lương sản lượng  ");
                return false;
            }
            else return true;

        }
        private void Luu_Va_GuiDuLieu_May_DOT()
        {
            if (!KiemTraLuu_May_DOT()) return;
            else
            {
                clsPhieu_ChiTietPhieu_New cls = new clsPhieu_ChiTietPhieu_New();
                cls.iID_SoPhieu = UC_SanXuat_PhieuSanXuat.mID_iD_SoPhieu;
                cls.sCaSanXuat = cbCaSanXuat_May_DOT.Text.ToString();
                cls.daNgaySanXuat = dteNgaySanXuat_May_DOT.DateTime;
                DataTable dt3 = cls.SelectAll_W_iID_SoPhieu_W_NgayThangSX_W_Ca_SX_Chon_May_DOT();
                if (dt3.Rows.Count > 0)
                {

                    int ID_ChiTietPhieu = Convert.ToInt32(dt3.Rows[0]["ID_ChiTietPhieu"].ToString());
                    int ID_SoPhieu = Convert.ToInt32(dt3.Rows[0]["ID_SoPhieu"].ToString());
                    int ID_May = Convert.ToInt32(gridMaMay_DOT.EditValue.ToString());
                    int ID_CongNhan = Convert.ToInt32(gridMaCongNhan_May_DOT.EditValue.ToString());
                    int ID_CaTruong = Convert.ToInt32(gridMaCaTruong_May_DOT.EditValue.ToString());
                    DateTime NgaySanXuat = Convert.ToDateTime(dteNgaySanXuat_May_DOT.EditValue.ToString());
                    string GhiChu = txtGhiChu_May_DOT.Text.ToString();
                    string CaSanXuat = cbCaSanXuat_May_DOT.Text.ToString();
                    int ID_DinhMuc_Luong = Convert.ToInt32(gridDinhMucSLMay_DOT.EditValue.ToString());
                    int ID_VTHH_Vao = Convert.ToInt32(gridHangHoaVao_may_DOT.EditValue.ToString());
                    double SoLuong_Vao = Convert.ToDouble(txtSoLuongNhap_May_DOT.Text.ToString());
                    double DonGia_Vao = Convert.ToDouble(txtDonGiaNhap_May_DOT.Text.ToString());
                    int ID_VTHH_Ra = Convert.ToInt32(gridHangHoaXuat_May_DOT.EditValue.ToString());
                    double SanLuong_Thuong = Convert.ToDouble(txtQuyDoiRaKG.Text.ToString());
                    double SanLuong_TangCa = 0;
                    double SanLuong_Tong = Convert.ToDouble(txtQuyDoiRaKG.Text.ToString());
                    double DonGia_Xuat = Convert.ToDouble(txtDonGiaXuat_May_DOT.Text.ToString());
                    double PhePham = Convert.ToDouble(txtPhePham_May_DOT.Text.ToString());
                    bool bbbbbTrangThaiXuatNhap = Convert.ToBoolean(dt3.Rows[0]["TrangThaiXuatNhap"].ToString());
                    bool bbbbbTrangThaiTaoLenhSanXuat = Convert.ToBoolean(dt3.Rows[0]["TrangThaiTaoLenhSanXuat"].ToString());
                    cls.iID_ChiTietPhieu = ID_ChiTietPhieu;
                    cls.iID_SoPhieu = ID_SoPhieu;
                    cls.iID_May = ID_May;
                    cls.iID_CongNhan = ID_CongNhan;
                    cls.iID_CaTruong = ID_CaTruong;
                    cls.daNgaySanXuat = NgaySanXuat;
                    cls.sGhiChu = GhiChu;
                    cls.sCaSanXuat = CaSanXuat;
                    cls.iID_DinhMuc_Luong = ID_DinhMuc_Luong;
                    cls.iID_VTHH_Vao = ID_VTHH_Vao;
                    cls.fSoLuong_Vao = SoLuong_Vao;
                    cls.fDonGia_Vao = DonGia_Vao;
                    cls.iID_VTHH_Ra = ID_VTHH_Ra;
                    cls.fSanLuong_Thuong = SanLuong_Thuong;
                    cls.fSanLuong_TangCa = SanLuong_TangCa;
                    cls.fSanLuong_Tong = SanLuong_Tong;
                    cls.fDonGia_Xuat = DonGia_Xuat;
                    cls.fPhePham = PhePham;
                    cls.bBMay_IN = false;
                    cls.bBMay_CAT = false;
                    cls.bBMay_DOT = true;
                    cls.bTrangThaiXuatNhap = bbbbbTrangThaiXuatNhap;
                    cls.bGuiDuLieu = true;
                    cls.bTrangThaiTaoLenhSanXuat = bbbbbTrangThaiTaoLenhSanXuat;
                    cls.fSoKG_MotBao_May_Dot = Convert.ToDouble(txtSoKGMotBao.Text.ToString());
                    cls.Update();
                }

            }

        }

        private void TaoLenhSanXuat_DOT()
        {
            clsPhieu_ChiTietPhieu_New cls = new clsPhieu_ChiTietPhieu_New();
            if (cbCaSanXuat_May_DOT.Text.ToString() != "" & dteNgaySanXuat_May_DOT.Text.ToString() != "")
            {
                cls.iID_SoPhieu = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.MIiiiid_SoPhieu;
                cls.sCaSanXuat = cbCaSanXuat_May_DOT.Text.ToString();
                cls.daNgaySanXuat = dteNgaySanXuat_May_DOT.DateTime;
                DataTable dt3 = cls.SelectAll_W_iID_SoPhieu_W_NgayThangSX_W_Ca_SX_Chon_May_DOT();

                if (dt3.Rows.Count > 0)
                {

                    if (Convert.ToBoolean(dt3.Rows[0]["TrangThaiTaoLenhSanXuat"].ToString()) == false)
                    {

                        int ID_ChiTietPhieu = Convert.ToInt32(dt3.Rows[0]["ID_ChiTietPhieu"].ToString());
                        int ID_May = Convert.ToInt32(gridMaMay_DOT.EditValue.ToString());
                        int ID_CongNhan = Convert.ToInt32(gridMaCongNhan_May_DOT.EditValue.ToString());
                        int ID_CaTruong = Convert.ToInt32(gridMaCaTruong_May_DOT.EditValue.ToString());
                        DateTime NgaySanXuat = Convert.ToDateTime(dteNgaySanXuat_May_DOT.EditValue.ToString());
                        string CaSanXuat = cbCaSanXuat_May_DOT.Text.ToString();

                        int ID_VTHH_Vao = Convert.ToInt32(gridHangHoaVao_may_DOT.EditValue.ToString());
                        double SoLuong_Vao = Convert.ToDouble(txtSoLuongNhap_May_DOT.Text.ToString());
                        double DonGia_Vao = Convert.ToDouble(txtDonGiaNhap_May_DOT.Text.ToString());
                        int ID_VTHH_Ra = Convert.ToInt32(gridHangHoaXuat_May_DOT.EditValue.ToString());
                        double SanLuong_Thuong = Convert.ToDouble(txtQuyDoiRaKG.Text.ToString());
                        //double SanLuong_TangCa = Convert.ToDouble(txtSanLuong_tangca_May_DOT.Text.ToString());
                        //double SanLuong_Tong = Convert.ToDouble(txtSanLuongTong_May_DOT.Text.ToString());
                        double DonGia_Xuat = Convert.ToDouble(txtDonGiaXuat_May_DOT.Text.ToString());
                        double PhePham = Convert.ToDouble(txtPhePham_May_DOT.Text.ToString());

                        clsHUU_LenhSanXuat clsLSX = new clsHUU_LenhSanXuat();
                        clsLSX.iID_CaTruong = ID_CaTruong;
                        clsLSX.iID_LoaiMay = 3;
                        clsLSX.iID_CongNhan = ID_CongNhan;
                        clsLSX.daNgayThangSanXuat = NgaySanXuat;
                        clsLSX.sCaSanXuat = CaSanXuat;
                        DataTable dxLSX1 = clsLSX.SelectAll_TaoLenhSX_May_CaTruong_CongNhan_Ngay_CaSX_May_DOT();
                        if (dxLSX1.Rows.Count > 0)
                        {
                            int ID_LenhSanXuat = Convert.ToInt32(dxLSX1.Rows[0]["ID_LenhSanXuat"].ToString());
                            clsHUU_LenhSanXuat_ChiTietLenhSanXuat clsLSX_chitiet = new clsHUU_LenhSanXuat_ChiTietLenhSanXuat();
                            clsLSX_chitiet.iID_LenhSanXuat = ID_LenhSanXuat;
                            clsLSX_chitiet.iID_SoPhieu = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.MIiiiid_SoPhieu;
                            clsLSX_chitiet.iID_ChiTietPhieu = ID_ChiTietPhieu;
                            clsLSX_chitiet.iID_VTHHVao = ID_VTHH_Vao;
                            clsLSX_chitiet.fSoLuongVao = SoLuong_Vao;
                            clsLSX_chitiet.iID_VTHHRa = ID_VTHH_Ra;
                            clsLSX_chitiet.fSanLuongThuong = SanLuong_Thuong;
                            clsLSX_chitiet.fSanLuongTangCa = 0;
                            clsLSX_chitiet.fPhePham = PhePham;
                            clsLSX_chitiet.fDonGiaVao = DonGia_Vao;
                            clsLSX_chitiet.fDonGiaRa = DonGia_Xuat;
                            clsLSX_chitiet.bNgungTheoDoi = false;
                            clsLSX_chitiet.bTonTai = true;
                            clsLSX_chitiet.Insert();

                        }
                        else if (dxLSX1.Rows.Count == 0)
                        {
                            clsHUU_LenhSanXuat cls1 = new CtyTinLuong.clsHUU_LenhSanXuat();
                            DataTable xxdt1 = cls1.SelectAll();
                            xxdt1.DefaultView.RowFilter = " TonTai= True and NgungTheoDoi=false";
                            DataView xxxdv = xxdt1.DefaultView;
                            DataTable xxxdv3 = xxxdv.ToTable();
                            int k = xxxdv3.Rows.Count;
                            string MaLenhSanXuat;
                            if (xxxdv3.Rows.Count == 0)
                                MaLenhSanXuat = "LSX1";
                            else
                            {
                                string xxx = xxxdv3.Rows[k - 1]["MaLenhSanXuat"].ToString();
                                int xxx2 = Convert.ToInt16(xxx.Substring(3).Trim()) + 1;
                                MaLenhSanXuat = "LSX" + xxx2 + "";
                            }

                            // them moi lenh SX chi tiet lSX 
                            clsLSX.iID_CaTruong = ID_CaTruong;
                            clsLSX.iID_LoaiMay = 3;
                            clsLSX.iID_CongNhan = ID_CongNhan;
                            clsLSX.iID_NguoiLap = 12;
                            clsLSX.daNgayThangSanXuat = NgaySanXuat;
                            clsLSX.sCaSanXuat = CaSanXuat;
                            clsLSX.sGhiChu = "";
                            clsLSX.bTonTai = true;
                            clsLSX.bNgungTheoDoi = false;
                            clsLSX.sMaLenhSanXuat = MaLenhSanXuat;
                            clsLSX.bGuiDuLieu = false;
                            clsLSX.bBoolMayIn = false;
                            clsLSX.bBoolMayCat = false;
                            clsLSX.bBoolMayDot = true;
                            clsLSX.bTrangThai_NhapKho_May_IN = false;
                            clsLSX.bTrangThai_XuatKho_May_IN = false;
                            clsLSX.bTrangThai_NhapKho_May_CAT = false;
                            clsLSX.bTrangThai_XuatKho_May_CAT = false;
                            clsLSX.bTrangThai_NhapKho_May_DOT = false;
                            clsLSX.bTrangThai_XuatKho_May_DOT = false;
                            clsLSX.Insert();

                            int ID_LenhSanXuat = clsLSX.iID_LenhSanXuat.Value;
                            clsHUU_LenhSanXuat_ChiTietLenhSanXuat clsLSX_chitiet = new clsHUU_LenhSanXuat_ChiTietLenhSanXuat();
                            clsLSX_chitiet.iID_LenhSanXuat = ID_LenhSanXuat;
                            clsLSX_chitiet.iID_SoPhieu = SanXuat_frmChiTietSoPhieu_IN_CAT_DOT_NEW2222.MIiiiid_SoPhieu; 
                            clsLSX_chitiet.iID_ChiTietPhieu = ID_ChiTietPhieu;
                            clsLSX_chitiet.iID_VTHHVao = ID_VTHH_Vao;
                            clsLSX_chitiet.fSoLuongVao = SoLuong_Vao;
                            clsLSX_chitiet.iID_VTHHRa = ID_VTHH_Ra;
                            clsLSX_chitiet.fSanLuongThuong = SanLuong_Thuong;
                            clsLSX_chitiet.fSanLuongTangCa = 0;
                            clsLSX_chitiet.fPhePham = PhePham;
                            clsLSX_chitiet.fDonGiaVao = DonGia_Vao;
                            clsLSX_chitiet.fDonGiaRa = DonGia_Xuat;
                            clsLSX_chitiet.bNgungTheoDoi = false;
                            clsLSX_chitiet.bTonTai = true;
                            clsLSX_chitiet.Insert();
                        }
                        clsPhieu_ChiTietPhieu_New clschietphieunnewwwwwwww = new CtyTinLuong.clsPhieu_ChiTietPhieu_New();
                        clschietphieunnewwwwwwww.iID_ChiTietPhieu = Convert.ToInt32(dt3.Rows[0]["ID_ChiTietPhieu"].ToString());
                        clschietphieunnewwwwwwww.Update_TrangThaiTaoLenhSanXuat();
                    }
                }
            }

        }
        private void Load_lockUP_EDIT_May_DOT()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=11";
            DataView dvCongNhan = dtNguoi.DefaultView;
            DataTable newdtCongNhan = dvCongNhan.ToTable();

            gridMaCongNhan_May_DOT.Properties.DataSource = newdtCongNhan;
            gridMaCongNhan_May_DOT.Properties.ValueMember = "ID_NhanSu";
            gridMaCongNhan_May_DOT.Properties.DisplayMember = "MaNhanVien";

            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=8";
            DataView dvCaTruong = dtNguoi.DefaultView;
            DataTable newdtCaTruong = dvCaTruong.ToTable();

            gridMaCaTruong_May_DOT.Properties.DataSource = newdtCaTruong;
            gridMaCaTruong_May_DOT.Properties.ValueMember = "ID_NhanSu";
            gridMaCaTruong_May_DOT.Properties.DisplayMember = "MaNhanVien";

            clsTbVatTuHangHoa clsVTxxxx = new clsTbVatTuHangHoa();
            DataTable dtVTxxx = clsVTxxxx.SelectAll();
            dtVTxxx.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvVTxxx = dtVTxxx.DefaultView;
            DataTable xxxxnewdtVT = dvVTxxx.ToTable();
            gridHangHoaVao_may_DOT.Properties.DataSource = xxxxnewdtVT;
            gridHangHoaVao_may_DOT.Properties.ValueMember = "ID_VTHH";
            gridHangHoaVao_may_DOT.Properties.DisplayMember = "MaVT";

            clsTbVatTuHangHoa clsxx = new clsTbVatTuHangHoa();
            DataTable dtkksss = clsxx.SelectAll();
            dtkksss.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvcxxx = dtkksss.DefaultView;
            DataTable vdtrhh = dvcxxx.ToTable();
            gridHangHoaXuat_May_DOT.Properties.DataSource = vdtrhh;
            gridHangHoaXuat_May_DOT.Properties.ValueMember = "ID_VTHH";
            gridHangHoaXuat_May_DOT.Properties.DisplayMember = "MaVT";


            clsT_MayMoc clsMayMoc = new clsT_MayMoc();
            DataTable dtMayIN = clsMayMoc.SelectAll();
            dtMayIN.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and id_loai=3";
            DataView dvMayIn = dtMayIN.DefaultView;
            DataTable newdtMayIn = dvMayIn.ToTable();

            gridMaMay_DOT.Properties.DataSource = newdtMayIn;
            gridMaMay_DOT.Properties.ValueMember = "id";
            gridMaMay_DOT.Properties.DisplayMember = "MaMay";


            clsDinhMuc_DinhMuc_Luong_TheoSanLuong clssanluong = new CtyTinLuong.clsDinhMuc_DinhMuc_Luong_TheoSanLuong();
            DataTable dtDinhMucSanLuong = clssanluong.SelectAll();
            dtDinhMucSanLuong.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvsanluiong = dtDinhMucSanLuong.DefaultView;
            DataTable newdtsanluong = dvsanluiong.ToTable();

            gridDinhMucSLMay_DOT.Properties.DataSource = newdtsanluong;
            gridDinhMucSLMay_DOT.Properties.ValueMember = "ID_DinhMuc_Luong_SanLuong";
            gridDinhMucSLMay_DOT.Properties.DisplayMember = "MaDinhMuc";


        }
      
        public SanXuat_frmChiTietPhieu_MayDot()
        {
            InitializeComponent();
        }

        private void SanXuat_frmChiTietPhieu_MayDot_Load(object sender, EventArgs e)
        {
            HienThi_CongNhan();
            Load_lockUP_EDIT_May_DOT();
            HienThi_May_DOT();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == clMaNhanVien)
            {
                clsNhanSu_tbNhanSu cls = new clsNhanSu_tbNhanSu();
                cls.iID_NhanSu = Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, e.Column));
                int kk = Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, e.Column));
                DataTable dt = cls.SelectOne();
                if (dt != null)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clID_CongNhan, kk);
                    gridView1.SetRowCellValue(e.RowHandle, clTenNhanVien, cls.sTenNhanVien.Value);
                    gridView1.SetRowCellValue(e.RowHandle, clHienThi, "1");

                }
            }
        }

        private void gridView1_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            GridView view = sender as GridView;
            DataView dv = view.DataSource as DataView;
            if (dv[e.ListSourceRow]["HienThi"].ToString().Trim() == "0")
            {
                e.Visible = false;
                e.Handled = true;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, clHienThi, "0");
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, clTenNhanVien, "");
        }

        private void gridHangHoaVao_may_DOT_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsTbVatTuHangHoa clsncc = new clsTbVatTuHangHoa();
                int kk = Convert.ToInt32(gridHangHoaVao_may_DOT.EditValue.ToString());

                clsncc.iID_VTHH = kk;
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenHangHoaVao_May_DOT.Text = dt.Rows[0]["TenVTHH"].ToString();
                    txtDVT_HangVao_MayDOT.Text = dt.Rows[0]["DonViTinh"].ToString();
                }

                clsKhoBTP_tbChiTietNhapKho cls2 = new clsKhoBTP_tbChiTietNhapKho();

                cls2.iID_VTHH = Convert.ToInt32(gridHangHoaVao_may_DOT.EditValue.ToString());
                DataTable dt2 = cls2.Select_W_ID_VTHH();
                if (dt2.Rows.Count > 0)
                {

                    //txtSoLuongTon_May_DOT.Text = dt2.Rows[0]["SoLuongTon"].ToString();
                    txtDonGiaNhap_May_DOT.Text = dt2.Rows[0]["DonGia"].ToString();

                }
                else
                {
                    //txtSoLuongTon_May_DOT.Text = "0";
                    txtDonGiaNhap_May_DOT.Text = "0";
                }

            }
            catch
            {

            }
        }

        private void gridHangHoaXuat_May_DOT_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsTbVatTuHangHoa clsncc = new clsTbVatTuHangHoa();

                clsncc.iID_VTHH = Convert.ToInt32(gridHangHoaXuat_May_DOT.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenHangHoaRa_May_DOT.Text = dt.Rows[0]["TenVTHH"].ToString();
                    txtDVT_HangRa_MayDOT.Text = dt.Rows[0]["DonViTinh"].ToString();

                }
            }
            catch
            {

            }
        }

        private void gridMaMay_DOT_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsT_MayMoc clsncc = new clsT_MayMoc();
                clsncc.iId = Convert.ToInt32(gridMaMay_DOT.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenMay_DOT.Text = dt.Rows[0]["TenMay"].ToString();

                }
            }
            catch
            {

            }
        }

        private void gridMaCongNhan_May_DOT_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt32(gridMaCongNhan_May_DOT.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenCongNhan_may_DOT.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }
                txtSanLuong_TrongNgay_DOT.ResetText();
                clsPhieu_ChiTietPhieu_New cls = new clsPhieu_ChiTietPhieu_New();
                int iiID_Congnnhan = Convert.ToInt32(gridMaCongNhan_May_DOT.EditValue.ToString());
                int iiID_ID_VTHH_Ran = Convert.ToInt32(gridHangHoaXuat_May_DOT.EditValue.ToString());
                DateTime daNgaySanXuatxxxxxxn = dteNgaySanXuat_May_DOT.DateTime;
                DataTable dtin = new DataTable();
                dtin = cls.SUM_TinhSanLuong_W_ID_CongNHan_NgayThang_ID_VTHH_Ra(iiID_Congnnhan, daNgaySanXuatxxxxxxn, iiID_ID_VTHH_Ran);
                txtSanLuong_TrongNgay_DOT.Text = dtin.Rows[0]["SanLuong_Thuong"].ToString();

            }
            catch
            {

            }
        }

        private void gridDinhMucSLMay_DOT_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsDinhMuc_DinhMuc_Luong_TheoSanLuong clsncc = new clsDinhMuc_DinhMuc_Luong_TheoSanLuong();
                clsncc.iID_DinhMuc_Luong_SanLuong = Convert.ToInt32(gridDinhMucSLMay_DOT.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtDinhMucKhongTang_May_DOT.Text = dt.Rows[0]["DinhMuc_KhongTang"].ToString();
                    txtDinhMucTang_May_DOT.Text = dt.Rows[0]["DinhMuc_Tang"].ToString();

                }
            }
            catch
            {

            }
        }

        private void txtSanLuong_may_DOT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSanLuong_may_DOT.Text.ToString() != "" & txtSoKGMotBao.Text.ToString() != "")
                {
                    double d1 = Convert.ToDouble(txtSanLuong_may_DOT.Text.ToString());
                    double d2 = Convert.ToDouble(txtSoKGMotBao.Text.ToString());
                    double d3 = d1 * d2;
                    txtQuyDoiRaKG.Text = d3.ToString();
                }

            }
            catch
            {

            }
        }

        private void txtDonGiaNhap_May_DOT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDonGiaNhap_May_DOT.Text);
                txtDonGiaNhap_May_DOT.Text = String.Format("{0:#,##0.00}", value);
            }
            catch
            {

            }
        }

        private void txtDonGiaXuat_May_DOT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDonGiaXuat_May_DOT.Text);
                txtDonGiaXuat_May_DOT.Text = String.Format("{0:#,##0.00}", value);
            }
            catch
            {

            }
        }

        private void txtDinhMucKhongTang_May_DOT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDinhMucKhongTang_May_DOT.Text);
                txtDinhMucKhongTang_May_DOT.Text = String.Format("{0:#,##0.00}", value);
            }
            catch
            {

            }
        }

        private void txtDinhMucTang_May_DOT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDinhMucTang_May_DOT.Text);
                txtDinhMucTang_May_DOT.Text = String.Format("{0:#,##0.00}", value);
            }
            catch
            {

            }
        }

        private void gridMaCaTruong_May_DOT_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt32(gridMaCaTruong_May_DOT.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenCaTruong_May_DOT.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }
            }
            catch
            {

            }
        }

        private void txtSoKGMotBao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSanLuong_may_DOT.Text.ToString() != "" & txtSoKGMotBao.Text.ToString() != "")
                {
                    double d1 = Convert.ToDouble(txtSanLuong_may_DOT.Text.ToString());
                    double d2 = Convert.ToDouble(txtSoKGMotBao.Text.ToString());
                    double d3 = d1 * d2;
                    txtQuyDoiRaKG.Text = d3.ToString();
                }

            }
            catch
            {

            }
        }
    }
}
