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
    public partial class NPLChiTietNhapKho_GapDan_SUaaaaaaaaaaaaaaa : Form
    {
        public static DateTime mdaPrintNgayXuatKho;
        public static DataTable mdtPrint_ChiTietXuatKho;
        public static string msPrintSoChungTu, msPrintDienGiaig, msPrintThuKho, msPrintNguoiNhan, msPrintNguoiLap;
        private void HienThi_ThemMoi_XuatKho()
        {
            gridNguoiLap.EditValue = 14;
            txtSoLuongXuat.Text = "1";
            dteNgayChungTu.EditValue = DateTime.Today;
            clsKhoNPL_tbXuatKho cls3 = new clsKhoNPL_tbXuatKho();
            DataTable dt1 = cls3.SelectAll();
            dt1.DefaultView.RowFilter = " TonTai= True and NgungTheoDoi=false";
            DataView dv = dt1.DefaultView;
            DataTable dv3 = dv.ToTable();
            int k = dv3.Rows.Count;
            if (k == 0)
                txtSoChungTu.Text = "XKNPL 1";
            else
            {
                string xxx = dv3.Rows[k - 1]["SoChungTu"].ToString();
                int xxx2 = Convert.ToInt32(xxx.Substring(5).Trim()) + 1;
                if (xxx2 >= 10000)
                    txtSoChungTu.Text = "XKNPL 1";
                else txtSoChungTu.Text = "XKNPL " + xxx2 + "";

            }
            string sochungtuNhapKho_GapDan;
            clsGapDan_tbNhapKho cls = new clsGapDan_tbNhapKho();
            DataTable dt1222 = cls.SelectAll();
            dt1222.DefaultView.RowFilter = " TonTai= True and NgungTheoDoi=false";
            DataView dvxxx = dt1222.DefaultView;
            DataTable dv3xxx = dvxxx.ToTable();
            int k2 = dv3xxx.Rows.Count;
            if (k2 == 0)
                sochungtuNhapKho_GapDan = "NKGD 1";
            else
            {
                string xxx = dv3xxx.Rows[k2 - 1]["SoChungTu"].ToString();
                int xxx2 = Convert.ToInt32(xxx.Substring(4).Trim()) + 1;
                if (xxx2 >= 10000)
                    sochungtuNhapKho_GapDan = "NKGD 1";
                sochungtuNhapKho_GapDan = "NKGD " + xxx2 + "";

            }
            txtSoChungTuGapDan.Text = sochungtuNhapKho_GapDan;
        }
        private void HienThi_Sua_XuatKho()
        {

            clsGapDan_tbNhapKho cls1 = new clsGapDan_tbNhapKho();
            cls1.iID_NhapKho = UCNPL_XuatKho_ToGapDan_NEwwwwwwwwwwwwwww.miID_NhapKho_GapDan;
            DataTable dt22222 = cls1.SelectOne();
            if (cls1.bTrangThai_XuatKho_NPL == true)
            {
                btLuu_Copy.Enabled = false;
                btLuu_Dong.Enabled = false;
                btLuu_Gui_Copy.Enabled = false;
                btLuu_Gui_Dong.Enabled = false;

                clsKhoNPL_tbXuatKho cls2 = new CtyTinLuong.clsKhoNPL_tbXuatKho();
                cls2.sThamChieu = cls1.sSoChungTu.Value;
                DataTable dt2xxx = cls2.SelectOne_W_ThamChieu_NhapKho_GapDan();
                dteNgayChungTu.EditValue = Convert.ToDateTime(dt2xxx.Rows[0]["NgayChungTu"].ToString());
                txtDienGiai.Text = dt2xxx.Rows[0]["DienGiai"].ToString();
                txtSoChungTu.Text = dt2xxx.Rows[0]["SoChungTu"].ToString();

            }
            else
            {
                clsKhoNPL_tbXuatKho cls3 = new clsKhoNPL_tbXuatKho();
                DataTable dt1 = cls3.SelectAll();
                dt1.DefaultView.RowFilter = " TonTai= True and NgungTheoDoi=false";
                DataView dv = dt1.DefaultView;
                DataTable dv3 = dv.ToTable();
                int k = dv3.Rows.Count;
                if (k == 0)
                    txtSoChungTu.Text = "XKNPL 1";
                else
                {
                    string xxx = dv3.Rows[k - 1]["SoChungTu"].ToString();
                    int xxx2 = Convert.ToInt32(xxx.Substring(5).Trim()) + 1;
                    if (xxx2 >= 10000)
                        txtSoChungTu.Text = "XKNPL 1";
                    else txtSoChungTu.Text = "XKNPL " + xxx2 + "";

                }
            }
            txtSoLuongXuat.Text = cls1.fSoLuongThanhPham_QuyDoi.Value.ToString();
            gridDinhMucGapDan.EditValue = cls1.iID_DinhMuc_ToGapDan.Value;
            txtSoChungTuGapDan.Text = cls1.sSoChungTu.Value;
            gridNguoiLap.EditValue = cls1.iID_NguoiNhap.Value;
            dteNgayChungTu.EditValue = cls1.daNgayChungTu.Value;

            double iisoluongxuat = Convert.ToDouble(txtSoLuongXuat.Text.ToString());

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_VTHH", typeof(int));
            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("TenVTHH", typeof(string));
            dt2.Columns.Add("DonViTinh", typeof(string));
            dt2.Columns.Add("DinhMuc", typeof(float));
            dt2.Columns.Add("SoLuongTheoDinhMuc", typeof(float));
            dt2.Columns.Add("SoLuong", typeof(float));
            dt2.Columns.Add("SoLuongTon", typeof(float));
            dt2.Columns.Add("DonGia", typeof(double));
            dt2.Columns.Add("GhiChu", typeof(string));
            dt2.Columns.Add("HienThi", typeof(string));
            dt2.Columns.Add("ThanhTien", typeof(double));
            dt2.Columns.Add("Check_VatTu_Phu", typeof(bool));

            clsGapDan_ChiTiet_NhapKho cls = new CtyTinLuong.clsGapDan_ChiTiet_NhapKho();
            cls.iID_NhapKho = UCNPL_XuatKho_ToGapDan_NEwwwwwwwwwwwwwww.miID_NhapKho_GapDan;
           
            DataTable dtchitiet1 = cls.SelectAll_W_ID_NhapKho();
            dtchitiet1.DefaultView.RowFilter = "Check_VatTu_Phu = True";
            DataView dv2 = dtchitiet1.DefaultView;
            DataTable dtchitietnhapkho = dv2.ToTable();
            for (int i = 0; i < dtchitietnhapkho.Rows.Count; i++)
            {
                double SoLuong = Convert.ToDouble(dtchitietnhapkho.Rows[i]["SoLuongNhap"].ToString());
                double dongiaxxx333 = Convert.ToDouble(dtchitietnhapkho.Rows[i]["DonGia"].ToString());
               
                int ID_VTHHxx = Convert.ToInt32(dtchitietnhapkho.Rows[i]["ID_VTHH"].ToString());

                clsTbVatTuHangHoa clvthh = new clsTbVatTuHangHoa();
                clvthh.iID_VTHH = ID_VTHHxx;
                DataTable dtvth = clvthh.SelectOne();
                clsKhoNPL_tbChiTietNhapKho xcls = new clsKhoNPL_tbChiTietNhapKho();
                xcls.iID_VTHH = ID_VTHHxx;
                DataTable dtbtp = xcls.Select_W_ID_VTHH();
                clsDinhMuc_ChiTiet_DinhMuc_ToGapDan clsdm = new CtyTinLuong.clsDinhMuc_ChiTiet_DinhMuc_ToGapDan();
                clsdm.iID_DinhMuc_ToGapDan= Convert.ToInt32(dtchitietnhapkho.Rows[i]["ID_DinhMuc_ToGapDan"].ToString());
                clsdm.iID_VTHH = ID_VTHHxx;
                DataTable dtdm = clsdm.SelectOne_W_ID_DinhMuc_ToGapDan_AND_ID_VTHH();

                double xxsoluongdinhmuc = Convert.ToDouble(dtdm.Rows[0]["SoLuong"].ToString());
                //var xxdinhmuc = Math.Round(double.Parse(xxsoluong), 3);

                DataRow _ravi3 = dt2.NewRow();
                _ravi3["ID_VTHH"] = ID_VTHHxx;
                _ravi3["MaVT"] = ID_VTHHxx;
                _ravi3["DinhMuc"] = xxsoluongdinhmuc;
                _ravi3["SoLuongTheoDinhMuc"] = xxsoluongdinhmuc * iisoluongxuat;
                _ravi3["TenVTHH"] = clvthh.sTenVTHH.Value;
                _ravi3["DonViTinh"] = clvthh.sDonViTinh.Value;
                _ravi3["SoLuong"] = SoLuong;
                if (dtbtp.Rows.Count > 0)
                    _ravi3["SoLuongTon"] = Convert.ToDouble(dtbtp.Rows[0]["SoLuongTon"].ToString());
                _ravi3["DonGia"] = dongiaxxx333;// lay kho NPL
                _ravi3["GhiChu"] = dtchitietnhapkho.Rows[i]["GhiChu"].ToString();
                _ravi3["HienThi"] = "1";
                _ravi3["ThanhTien"] = SoLuong * dongiaxxx333;
                _ravi3["Check_VatTu_Phu"] = false;

                dt2.Rows.Add(_ravi3);

            }
            gridControl1.DataSource = dt2;           
            double deTOngtien;
            string shienthi = "1";
            object xxxx = dt2.Compute("sum(ThanhTien)", "HienThi=" + shienthi + " and Check_VatTu_Phu = True");
            if (xxxx.ToString() != "")
                deTOngtien = Convert.ToDouble(xxxx);
            else deTOngtien = 0;
            txtTongTienHang.Text = deTOngtien.ToString();

        }
        private void Load_LockUp()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=5";
            DataView dvCaTruong = dtNguoi.DefaultView;
            DataTable newdtCaTruong = dvCaTruong.ToTable();

            gridNguoiLap.Properties.DataSource = newdtCaTruong;
            gridNguoiLap.Properties.ValueMember = "ID_NhanSu";
            gridNguoiLap.Properties.DisplayMember = "MaNhanVien";

            clsTbVatTuHangHoa cls = new clsTbVatTuHangHoa();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv2 = dt.DefaultView;
            DataTable dtxx2 = dv2.ToTable();

            repositoryItemLookUpEdit2.DataSource = dtxx2;
            repositoryItemLookUpEdit2.ValueMember = "ID_VTHH";
            repositoryItemLookUpEdit2.DisplayMember = "MaVT";



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
            DataTable dv3 = new DataTable();
            if (gridControl1.DataSource != null)
            {
                string shienthi = "1";
                DataTable dttttt2 = (DataTable)gridControl1.DataSource;
                dttttt2.DefaultView.RowFilter = "HienThi=" + shienthi + "";
                DataView dv = dttttt2.DefaultView;
                dv3 = dv.ToTable();
            }

            if (gridControl1.DataSource == null)
            {
                MessageBox.Show("chưa có hàng hoá");
                return false;
            }


            else if (gridDinhMucGapDan.EditValue.ToString() == "")
            {
                MessageBox.Show("chưa chọn định mức nguyên phụ liệu");
                return false;
            }
            else if (dteNgayChungTu.Text.ToString() == "")
            {
                MessageBox.Show("Không để trống ngày chứng từ");
                return false;
            }
            else if (dv3.Rows.Count == 0)
            {
                MessageBox.Show("Chưa chọn hàng hóa ");
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
        private bool Luu_ChiLuu()
        {
            if (!KiemTraLuu()) return false;
            else
            {
                int iiID_Nhapkho;
                clsGapDan_tbNhapKho cls1 = new clsGapDan_tbNhapKho();
                cls1.daNgayChungTu = dteNgayChungTu.DateTime;
                cls1.sSoChungTu = txtSoChungTuGapDan.Text.ToString();
                cls1.sDienGiai = txtDienGiai.Text.ToString();
                cls1.iID_VTHH_ThanhPham_QuyDoi = Convert.ToInt32(txtID_ThanhPham.Text.ToString());
                cls1.fDonGia_ThanhPham_QuyDoi = Convert.ToDouble(txtDonGiaThanhPhamQuyDoi.Text.ToString());
                cls1.fSoLuongThanhPham_QuyDoi = Convert.ToDouble(txtSoLuongXuat.Text.ToString());
                cls1.fTongTienHang = Convert.ToDouble(txtTongTienHang.Text.ToString());
                cls1.iID_NguoiNhap = Convert.ToInt32(gridNguoiLap.EditValue.ToString());
                cls1.sThamChieu = txtSoChungTuGapDan.Text.ToString();
                cls1.iID_DinhMuc_ToGapDan = Convert.ToInt32(gridDinhMucGapDan.EditValue.ToString());
                cls1.bBool_TonDauKy = false;
                cls1.bTrangThai_XuatKho_NPL = false;
                cls1.bTrangThai_XuatKho_BTP = false;
                cls1.bTrangThai_NhapKho_GapDan = false;
                cls1.bDaNhapKho = false;
                cls1.bTonTai = true;
                cls1.bNgungTheoDoi = false;
                if (UCNPL_XuatKho_ToGapDan_NEwwwwwwwwwwwwwww.mbThemMoi_nhapKho_GapDan == true)
                {
                    cls1.Insert();
                    iiID_Nhapkho = cls1.iID_NhapKho.Value;
                }
                else
                {
                    cls1.iID_NhapKho = UCNPL_XuatKho_ToGapDan_NEwwwwwwwwwwwwwww.miID_NhapKho_GapDan;
                    iiID_Nhapkho = UCNPL_XuatKho_ToGapDan_NEwwwwwwwwwwwwwww.miID_NhapKho_GapDan;
                    cls1.Update();
                }

                clsGapDan_ChiTiet_NhapKho cls2 = new clsGapDan_ChiTiet_NhapKho();

                // xóa trước
                cls2.iID_NhapKho = iiID_Nhapkho;
                cls2.Delete_ALL_W_ID_NhapKho();
                string shienthi = "1";
                DataTable dtkkk = (DataTable)gridControl1.DataSource;
                dtkkk.DefaultView.RowFilter = "HienThi=" + shienthi + "";
                DataView dv2232xx = dtkkk.DefaultView;
                DataTable dttttt2 = dv2232xx.ToTable();

                // Nhap kho Thành pham quy doi
                cls2.iID_NhapKho = iiID_Nhapkho;

                cls2.iID_VTHH = Convert.ToInt32(txtID_ThanhPham.Text.ToString());
                cls2.fSoLuongNhap = Convert.ToDouble(txtSoLuongXuat.Text.ToString());
                cls2.fSoLuongTon = Convert.ToDouble(txtSoLuongXuat.Text.ToString());
                if (txtDonGiaThanhPhamQuyDoi.Text.ToString() == "")
                    cls2.fDonGia = 0;
                else cls2.fDonGia = Convert.ToDouble(txtDonGiaThanhPhamQuyDoi.Text.ToString());
                cls2.sGhiChu = "";
                cls2.bTonTai = true;
                cls2.bNgungTheoDoi = false;
                cls2.bDaNhapKho = false;
                cls2.bBoolTonDauKy = false;
                cls2.bCheck_ThanhPham = true;
                cls2.bCheck_VatTu_Chinh = false;
                cls2.bCheck_VatTu_Phu = false;
                cls2.Insert();

                // Nhap kho Vật tư chính
                cls2.iID_NhapKho = iiID_Nhapkho;

                cls2.iID_VTHH = Convert.ToInt32(txtID_VatTuChinh.Text.ToString());
                cls2.fSoLuongNhap = Convert.ToDouble(txtSoLuongVTChinh.Text.ToString());
                cls2.fSoLuongTon = Convert.ToDouble(txtSoLuongVTChinh.Text.ToString());
                if (txtDonGiaThanhPhamQuyDoi.Text.ToString() == "")
                    cls2.fDonGia = 0;
                else cls2.fDonGia = Convert.ToDouble(txtDonGiaThanhPhamQuyDoi.Text.ToString());
                cls2.sGhiChu = "";
                cls2.bTonTai = true;
                cls2.bNgungTheoDoi = false;
                cls2.bDaNhapKho = false;
                cls2.bBoolTonDauKy = false;
                cls2.bCheck_ThanhPham = false;
                cls2.bCheck_VatTu_Chinh = true;
                cls2.bCheck_VatTu_Phu = false;
                cls2.Insert();

                for (int i = 0; i < dttttt2.Rows.Count; i++)
                {
                    cls2.iID_NhapKho = iiID_Nhapkho;
                    cls2.iID_VTHH = Convert.ToInt32(dttttt2.Rows[i]["ID_VTHH"].ToString());
                    cls2.fSoLuongNhap = Convert.ToDouble(dttttt2.Rows[i]["SoLuong"].ToString());
                    cls2.fSoLuongTon = Convert.ToDouble(dttttt2.Rows[i]["SoLuong"].ToString());
                    if (dttttt2.Rows[i]["DonGia"].ToString() == "")
                        cls2.fDonGia = 0;
                    else cls2.fDonGia = Convert.ToDouble(dttttt2.Rows[i]["DonGia"].ToString());
                    cls2.sGhiChu = dttttt2.Rows[i]["GhiChu"].ToString();
                    cls2.bTonTai = true;
                    cls2.bNgungTheoDoi = false;
                    cls2.bDaNhapKho = false;
                    cls2.bBoolTonDauKy = false;
                    cls2.bCheck_ThanhPham = false;
                    cls2.bCheck_VatTu_Chinh = false;
                    cls2.bCheck_VatTu_Phu = true;
                    cls2.Insert();
                }

                // Luu xuatkho NPL

                //double deTOngtien_NPL;
                //dtkkk.DefaultView.RowFilter = "HienThi=" + shienthi + " and BoolVTChinh=False";
                //DataView dvmoi = dtkkk.DefaultView;
                //DataTable dtmoi = dvmoi.ToTable();
                //object xxxx = dtmoi.Compute("sum(ThanhTien)", "HienThi=" + shienthi + "");
                //if (xxxx.ToString() != "")
                //    deTOngtien_NPL = Convert.ToDouble(xxxx);
                //else deTOngtien_NPL = 0;
                //clsKhoNPL_tbXuatKho clsnplxk = new clsKhoNPL_tbXuatKho();
                //clsnplxk.sDienGiai = txtDienGiai.Text.ToString();
                //clsnplxk.daNgayChungTu = dteNgayChungTu.DateTime;
                //clsnplxk.sSoChungTu = txtSoChungTu.Text.ToString();
                //clsnplxk.fTongTienHang = deTOngtien_NPL;
                //clsnplxk.iID_NguoiXuatKho = Convert.ToInt32(gridNguoiLap.EditValue.ToString());
                //clsnplxk.sThamChieu = txtSoChungTuGapDan.Text.ToString();
                //clsnplxk.bTonTai = true;
                //clsnplxk.bNgungTheoDoi = false;
                //clsnplxk.bDaXuatKho = false;
                //if (UCNPL_XuatKho_ToGapDan_NEwwwwwwwwwwwwwww.mbThemMoi_nhapKho_GapDan == true)
                //{
                //    clsnplxk.Insert();

                //}
                //else
                //{

                //    clsnplxk.sThamChieu = txtSoChungTuGapDan.Text.ToString();
                //    DataTable dt2npl = clsnplxk.SelectOne_W_ThamChieu_NhapKho_GapDan();
                //    clsnplxk.iID_XuatKhoNPL = Convert.ToInt32(dt2npl.Rows[0]["ID_XuatKhoNPL"].ToString());
                //    clsnplxk.iID_XuatKhoNPL = UCNPL_XuatKho_ToGapDan_NEwwwwwwwwwwwwwww.miID_NhapKho_GapDan;               
                //    clsnplxk.Update();
                //}

                //// insert tbChiTietNhapKho

                //int iiiiIDID_XuatKhoNPL = clsnplxk.iID_XuatKhoNPL.Value;
                //clsKhoNPL_tbChiTietXuatKho clschitietxuatkho = new clsKhoNPL_tbChiTietXuatKho();
                //clschitietxuatkho.iID_XuatKho = iiiiIDID_XuatKhoNPL;
                //clschitietxuatkho.Delete_W_ID_XuatKho();
                //for (int i = 0; i < dtmoi.Rows.Count; i++)
                //{
                //    clschitietxuatkho.iID_XuatKho = iiiiIDID_XuatKhoNPL;
                //    clschitietxuatkho.iID_VTHH = Convert.ToInt32(dtmoi.Rows[i]["ID_VTHH"].ToString());
                //    clschitietxuatkho.fSoLuongXuat = Convert.ToDouble(dtmoi.Rows[i]["SoLuong"].ToString());
                //    clschitietxuatkho.fDonGia = Convert.ToDouble(dtmoi.Rows[i]["DonGia"].ToString());
                //    clschitietxuatkho.bTonTai = true;
                //    clschitietxuatkho.bNgungTheoDoi = false;
                //    clschitietxuatkho.sGhiChu = dtmoi.Rows[i]["GhiChu"].ToString();
                //    clschitietxuatkho.bDaXuatKho = false;
                //    clschitietxuatkho.Insert();

                //    // update soluong ton tbnhapkho
                //    clsKhoNPL_tbChiTietNhapKho clschitietnhapkho = new CtyTinLuong.clsKhoNPL_tbChiTietNhapKho();
                //    int iiiID_VTHH = Convert.ToInt32(dtmoi.Rows[i]["ID_VTHH"].ToString());
                //    double soluongxuat = Convert.ToDouble(dtmoi.Rows[i]["SoLuong"].ToString());
                //    clschitietnhapkho.iID_VTHH = iiiID_VTHH;
                //    DataTable dt2 = clschitietnhapkho.Select_W_ID_VTHH();
                //    Double douSoLuongTonCu;
                //    douSoLuongTonCu = Convert.ToDouble(dt2.Rows[0]["SoLuongTon"].ToString());
                //    clschitietnhapkho.iID_ChiTietNhapKho = Convert.ToInt32(dt2.Rows[0]["ID_ChiTietNhapKho"].ToString());
                //    clschitietnhapkho.fSoLuongTon = douSoLuongTonCu - soluongxuat;
                //    clschitietnhapkho.Update_SoLuongTon();
                //}

                return true;

            }
        }

        private bool Luu_Va_Gui_DuLieu()
        {
            if (!KiemTraLuu()) return false;
            else
            {
                int iiID_Nhapkho;
                clsGapDan_tbNhapKho cls1 = new clsGapDan_tbNhapKho();
                cls1.daNgayChungTu = dteNgayChungTu.DateTime;
                cls1.sSoChungTu = txtSoChungTuGapDan.Text.ToString();
                cls1.sDienGiai = txtDienGiai.Text.ToString();
                cls1.iID_VTHH_ThanhPham_QuyDoi = Convert.ToInt32(txtID_ThanhPham.Text.ToString());
                cls1.fDonGia_ThanhPham_QuyDoi = Convert.ToDouble(txtDonGiaThanhPhamQuyDoi.Text.ToString());
                cls1.fSoLuongThanhPham_QuyDoi = Convert.ToDouble(txtSoLuongXuat.Text.ToString());
                cls1.fTongTienHang = Convert.ToDouble(txtTongTienHang.Text.ToString());
                cls1.iID_NguoiNhap = Convert.ToInt32(gridNguoiLap.EditValue.ToString());
                cls1.sThamChieu = txtSoChungTu.Text.ToString();
                cls1.iID_DinhMuc_ToGapDan = Convert.ToInt32(gridDinhMucGapDan.EditValue.ToString());
                cls1.bBool_TonDauKy = false;
                cls1.bTrangThai_XuatKho_NPL = true;
                cls1.bTrangThai_XuatKho_BTP = false;
                cls1.bTrangThai_NhapKho_GapDan = false;
                cls1.bDaNhapKho = false;
                cls1.bTonTai = true;
                cls1.bNgungTheoDoi = false;
                if (UCNPL_XuatKho_ToGapDan_NEwwwwwwwwwwwwwww.mbThemMoi_nhapKho_GapDan == true)
                {
                    cls1.Insert();
                    iiID_Nhapkho = cls1.iID_NhapKho.Value;
                }
                else
                {
                    cls1.iID_NhapKho = UCNPL_XuatKho_ToGapDan_NEwwwwwwwwwwwwwww.miID_NhapKho_GapDan;
                    iiID_Nhapkho = UCNPL_XuatKho_ToGapDan_NEwwwwwwwwwwwwwww.miID_NhapKho_GapDan;
                    cls1.Update();
                }

                clsGapDan_ChiTiet_NhapKho cls2 = new clsGapDan_ChiTiet_NhapKho();

                // xóa trước
                cls2.iID_NhapKho = iiID_Nhapkho;
                cls2.Delete_ALL_W_ID_NhapKho();
                string shienthi = "1";
                DataTable dtkkk = (DataTable)gridControl1.DataSource;
                dtkkk.DefaultView.RowFilter = "HienThi=" + shienthi + "";
                DataView dv2232xx = dtkkk.DefaultView;
                DataTable dttttt2 = dv2232xx.ToTable();

                // Nhap kho Thành pham quy doi
                cls2.iID_NhapKho = iiID_Nhapkho;

                cls2.iID_VTHH = Convert.ToInt32(txtID_ThanhPham.Text.ToString());
                cls2.fSoLuongNhap = Convert.ToDouble(txtSoLuongXuat.Text.ToString());
                cls2.fSoLuongTon = Convert.ToDouble(txtSoLuongXuat.Text.ToString());
                if (txtDonGiaThanhPhamQuyDoi.Text.ToString() == "")
                    cls2.fDonGia = 0;
                else cls2.fDonGia = Convert.ToDouble(txtDonGiaThanhPhamQuyDoi.Text.ToString());
                cls2.sGhiChu = "";
                cls2.bTonTai = true;
                cls2.bNgungTheoDoi = false;
                cls2.bDaNhapKho = false;
                cls2.bBoolTonDauKy = false;
                cls2.bCheck_ThanhPham = true;
                cls2.bCheck_VatTu_Chinh = false;
                cls2.bCheck_VatTu_Phu = false;
                cls2.Insert();

                // Nhap kho Vật tư chính
                cls2.iID_NhapKho = iiID_Nhapkho;

                cls2.iID_VTHH = Convert.ToInt32(txtID_VatTuChinh.Text.ToString());
                cls2.fSoLuongNhap = Convert.ToDouble(txtSoLuongVTChinh.Text.ToString());
                cls2.fSoLuongTon = Convert.ToDouble(txtSoLuongVTChinh.Text.ToString());
                if (txtDonGiaThanhPhamQuyDoi.Text.ToString() == "")
                    cls2.fDonGia = 0;
                else cls2.fDonGia = Convert.ToDouble(txtDonGiaThanhPhamQuyDoi.Text.ToString());
                cls2.sGhiChu = "";
                cls2.bTonTai = true;
                cls2.bNgungTheoDoi = false;
                cls2.bDaNhapKho = false;
                cls2.bBoolTonDauKy = false;
                cls2.bCheck_ThanhPham = false;
                cls2.bCheck_VatTu_Chinh = true;
                cls2.bCheck_VatTu_Phu = false;
                cls2.Insert();

                for (int i = 0; i < dttttt2.Rows.Count; i++)
                {
                    cls2.iID_NhapKho = iiID_Nhapkho;
                    cls2.iID_VTHH = Convert.ToInt32(dttttt2.Rows[i]["ID_VTHH"].ToString());
                    cls2.fSoLuongNhap = Convert.ToDouble(dttttt2.Rows[i]["SoLuong"].ToString());
                    cls2.fSoLuongTon = Convert.ToDouble(dttttt2.Rows[i]["SoLuong"].ToString());
                    if (dttttt2.Rows[i]["DonGia"].ToString() == "")
                        cls2.fDonGia = 0;
                    else cls2.fDonGia = Convert.ToDouble(dttttt2.Rows[i]["DonGia"].ToString());
                    cls2.sGhiChu = dttttt2.Rows[i]["GhiChu"].ToString();
                    cls2.bTonTai = true;
                    cls2.bNgungTheoDoi = false;
                    cls2.bBoolTonDauKy = false;
                    cls2.bCheck_ThanhPham = false;
                    cls2.bCheck_VatTu_Chinh = false;
                    cls2.bDaNhapKho = true;
                    cls2.bCheck_VatTu_Phu = true;
                    cls2.Insert();
                }

                // Luu xuatkho NPL

                double deTOngtien_NPL;
                dtkkk.DefaultView.RowFilter = "HienThi=" + shienthi + " and Check_VatTu_Phu=False";
                DataView dvmoi = dtkkk.DefaultView;
                DataTable dtmoi = dvmoi.ToTable();
                object xxxx = dtmoi.Compute("sum(ThanhTien)", "HienThi=" + shienthi + "");
                if (xxxx.ToString() != "")
                    deTOngtien_NPL = Convert.ToDouble(xxxx);
                else deTOngtien_NPL = 0;
                clsKhoNPL_tbXuatKho clsnplxk = new clsKhoNPL_tbXuatKho();
                clsnplxk.sDienGiai = txtDienGiai.Text.ToString();
                clsnplxk.daNgayChungTu = dteNgayChungTu.DateTime;
                clsnplxk.sSoChungTu = txtSoChungTu.Text.ToString();
                clsnplxk.fTongTienHang = deTOngtien_NPL;
                clsnplxk.iID_NguoiXuatKho = Convert.ToInt32(gridNguoiLap.EditValue.ToString());
                clsnplxk.sThamChieu = txtSoChungTuGapDan.Text.ToString();
                clsnplxk.bTonTai = true;
                clsnplxk.bNgungTheoDoi = false;
                clsnplxk.bDaXuatKho = true;

                /// chỉ khi gửi dữ liệu mới insert vào Xuất kho NPL
                //if (UCNPL_XuatKho_ToGapDan_NEwwwwwwwwwwwwwww.mbThemMoi_nhapKho_GapDan == true)
                //{
                clsnplxk.Insert();

                //}
                //else
                //{

                //    clsnplxk.sThamChieu = txtSoChungTuGapDan.Text.ToString();
                //    DataTable dt2npl = clsnplxk.SelectOne_W_ThamChieu_NhapKho_GapDan();
                //    clsnplxk.iID_XuatKhoNPL = Convert.ToInt32(dt2npl.Rows[0]["ID_XuatKhoNPL"].ToString());
                //    clsnplxk.iID_XuatKhoNPL = UCNPL_XuatKho_ToGapDan_NEwwwwwwwwwwwwwww.miID_NhapKho_GapDan;
                //    clsnplxk.Update();
                //}

                // insert tbChiTietNhapKho

                int iiiiIDID_XuatKhoNPL = clsnplxk.iID_XuatKhoNPL.Value;
                clsKhoNPL_tbChiTietXuatKho clschitietxuatkho = new clsKhoNPL_tbChiTietXuatKho();
                clschitietxuatkho.iID_XuatKho = iiiiIDID_XuatKhoNPL;
                clschitietxuatkho.Delete_W_ID_XuatKho();
                for (int i = 0; i < dtmoi.Rows.Count; i++)
                {
                    clschitietxuatkho.iID_XuatKho = iiiiIDID_XuatKhoNPL;
                    clschitietxuatkho.iID_VTHH = Convert.ToInt32(dtmoi.Rows[i]["ID_VTHH"].ToString());
                    clschitietxuatkho.fSoLuongXuat = Convert.ToDouble(dtmoi.Rows[i]["SoLuong"].ToString());
                    clschitietxuatkho.fDonGia = Convert.ToDouble(dtmoi.Rows[i]["DonGia"].ToString());
                    clschitietxuatkho.bTonTai = true;
                    clschitietxuatkho.bNgungTheoDoi = false;
                    clschitietxuatkho.sGhiChu = dtmoi.Rows[i]["GhiChu"].ToString();
                    clschitietxuatkho.bDaXuatKho = true;
                    clschitietxuatkho.Insert();

                    // update soluong ton tbnhapkho
                    clsKhoNPL_tbChiTietNhapKho clschitietnhapkho = new CtyTinLuong.clsKhoNPL_tbChiTietNhapKho();
                    int iiiID_VTHH = Convert.ToInt32(dtmoi.Rows[i]["ID_VTHH"].ToString());
                    double soluongxuat = Convert.ToDouble(dtmoi.Rows[i]["SoLuong"].ToString());
                    clschitietnhapkho.iID_VTHH = iiiID_VTHH;
                    DataTable dt2 = clschitietnhapkho.Select_W_ID_VTHH();
                    Double douSoLuongTonCu;
                    douSoLuongTonCu = Convert.ToDouble(dt2.Rows[0]["SoLuongTon"].ToString());
                    clschitietnhapkho.iID_ChiTietNhapKho = Convert.ToInt32(dt2.Rows[0]["ID_ChiTietNhapKho"].ToString());
                    clschitietnhapkho.fSoLuongTon = douSoLuongTonCu - soluongxuat;
                    clschitietnhapkho.Update_SoLuongTon();
                }

                return true;

            }


        }
        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
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

        private void gridDinhMucGapDan_EditValueChanged(object sender, EventArgs e)
        {
            clsTbVatTuHangHoa clsvt = new clsTbVatTuHangHoa();
            clsDinhMuc_ChiTiet_DinhMuc_ToGapDan cls = new CtyTinLuong.clsDinhMuc_ChiTiet_DinhMuc_ToGapDan();
            cls.iID_DinhMuc_ToGapDan = Convert.ToInt32(gridDinhMucGapDan.EditValue.ToString());
            DataTable dt = cls.SelectAll_W_ID_DinhMuc_ToGapDan();
            if (dt.Rows.Count > 0)
            {
                double xxsoluongxuat = Convert.ToDouble(txtSoLuongXuat.Text.ToString());
                DataTable dt422 = dt.Copy();
                dt422.DefaultView.RowFilter = " Check_ThanhPham = True";
                DataView dv1 = dt422.DefaultView;
                DataTable dt22 = dv1.ToTable();
                txtID_ThanhPham.Text = dt22.Rows[0]["ID_VTHH"].ToString();
                txtMaTPQuyDoi.Text = dt22.Rows[0]["MaVT"].ToString();
                txtTenThanhPhamQuyDoi.Text = dt22.Rows[0]["TenVTHH"].ToString();
                txtDVTThanhPhamQuyDoi.Text = dt22.Rows[0]["DonViTinh"].ToString();

                DataTable dt322 = dt.Copy();
                dt322.DefaultView.RowFilter = " Check_VatTu_Chinh = True";
                DataView dv2 = dt322.DefaultView;
                DataTable dt223 = dv2.ToTable();
                txtID_VatTuChinh.Text = dt223.Rows[0]["ID_VTHH"].ToString();
                txtMaVTChinh.Text = dt223.Rows[0]["MaVT"].ToString();
                txtTenVatTu_Chinh.Text = dt223.Rows[0]["TenVTHH"].ToString();

                txtDVT_VT_CHinh.Text = dt223.Rows[0]["DonViTinh"].ToString();

                double SoLuong_VTChinh_DinhMuc = Convert.ToDouble(dt223.Rows[0]["SoLuong"].ToString());
                txtSoLuongVTChinh.Text = (SoLuong_VTChinh_DinhMuc * xxsoluongxuat).ToString();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            double ffdongia, fffsoluong, fffthanhtien;
            if (e.Column == clSoLuong)
            {
                if (gridView1.GetFocusedRowCellValue(clDonGia).ToString() == "")
                    ffdongia = 0;
                else
                    ffdongia = Convert.ToDouble(gridView1.GetFocusedRowCellValue(clDonGia));
                if (gridView1.GetFocusedRowCellValue(clSoLuong).ToString() == "")
                    fffsoluong = 0;
                else
                    fffsoluong = Convert.ToDouble(gridView1.GetFocusedRowCellValue(clSoLuong));
                fffthanhtien = fffsoluong * ffdongia;
                gridView1.SetFocusedRowCellValue(clThanhTien, fffthanhtien);
            }
            if (e.Column == clDonGia)
            {
                if (gridView1.GetFocusedRowCellValue(clDonGia).ToString() == "")
                    ffdongia = 0;
                else
                    ffdongia = Convert.ToDouble(gridView1.GetFocusedRowCellValue(clDonGia));
                if (gridView1.GetFocusedRowCellValue(clSoLuong).ToString() == "")
                    fffsoluong = 0;
                else
                    fffsoluong = Convert.ToDouble(gridView1.GetFocusedRowCellValue(clSoLuong));
                fffthanhtien = fffsoluong * ffdongia;
                gridView1.SetFocusedRowCellValue(clThanhTien, fffthanhtien);
            }
            double deTOngtien;
            DataTable dataTable = (DataTable)gridControl1.DataSource;
            string shienthi = "1";
            object xxxx = dataTable.Compute("sum(ThanhTien)", "HienThi=" + shienthi + "");
            if (xxxx.ToString() != "")
                deTOngtien = Convert.ToDouble(xxxx);
            else deTOngtien = 0;
            txtTongTienHang.Text = deTOngtien.ToString();
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

        private void txtDonGiaThanhPhamQuyDoi_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDonGiaThanhPhamQuyDoi.Text);
                txtDonGiaThanhPhamQuyDoi.Text = String.Format("{0:#,##0.00}", value);

            }
            catch
            {

            }
        }

       
        public NPLChiTietNhapKho_GapDan_SUaaaaaaaaaaaaaaa()
        {
            InitializeComponent();
        }

        private void NPLChiTietNhapKho_GapDan_SUaaaaaaaaaaaaaaa_Load(object sender, EventArgs e)
        {
            clsTbVatTuHangHoa clsvthhh = new clsTbVatTuHangHoa();
            DataTable dtvthh = clsvthhh.SelectAll();
            dtvthh.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvvthh = dtvthh.DefaultView;
            DataTable newdtvthh = dvvthh.ToTable();


            repositoryItemLookUpEdit2.DataSource = newdtvthh;
            repositoryItemLookUpEdit2.ValueMember = "ID_VTHH";
            repositoryItemLookUpEdit2.DisplayMember = "MaVT";



            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_VTHH", typeof(int));
            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("TenVTHH", typeof(string));
            dt2.Columns.Add("DonViTinh", typeof(string));
            dt2.Columns.Add("DinhMuc", typeof(float));
            dt2.Columns.Add("SoLuongTheoDinhMuc", typeof(float));
            dt2.Columns.Add("SoLuong", typeof(float));
            dt2.Columns.Add("SoLuongTon", typeof(float));
            dt2.Columns.Add("DonGia", typeof(double));
            dt2.Columns.Add("GhiChu", typeof(string));
            dt2.Columns.Add("HienThi", typeof(string));
            dt2.Columns.Add("ThanhTien", typeof(double));
            dt2.Columns.Add("Check_VatTu_Phu", typeof(bool));
            gridControl1.DataSource = dt2;

            Load_LockUp();

            HienThi_Sua_XuatKho();

        }

        private void btLuu_Dong_Click(object sender, EventArgs e)
        {
            if (!KiemTraLuu()) return;
            else if (!Luu_ChiLuu()) return;
            else
            {
                MessageBox.Show("Đã lưu");
                this.Close();
            }
        }

        private void btLuu_Copy_Click(object sender, EventArgs e)
        {

            if (!KiemTraLuu()) return;
            else if (!Luu_ChiLuu()) return;
            else
            {
                HienThi_ThemMoi_XuatKho();
                MessageBox.Show("Đã lưu");
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

        private void btLuu_Gui_Copy_Click(object sender, EventArgs e)
        {
            if (!KiemTraLuu()) return;
            else if (!Luu_Va_Gui_DuLieu()) return;
            else
            {

                HienThi_ThemMoi_XuatKho();
                MessageBox.Show("Đã lưu");
            }
        }
    }
}
