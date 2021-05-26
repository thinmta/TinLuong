using DevExpress.XtraLayout.Utils;
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
    public partial class KhoBTP_frmChiTietXuatKhoDaiLyGiaCong : Form
    {
        int ID_XuatKhoBTP;
       
        
        private void TinhTongSoKg_TongSoKien()
        {
            try
            {
                double soluongbaoto, soluongbaobe, sokg1baoto, sokg1baobe, sokien1baoto, sokien1baobe;
                soluongbaoto = Convert.ToDouble(txtSoLuongBaoTo.Text.ToString());
                soluongbaobe = Convert.ToDouble(txtSoLuongBaoBe.Text.ToString());
                sokg1baoto = Convert.ToDouble(txtSoKG1Bao_To.Text.ToString());
                sokg1baobe = Convert.ToDouble(txtSoKG1Bao_Be.Text.ToString());
                sokien1baobe = Convert.ToDouble(txtSoKien_1_BaoBe.Text.ToString());
                sokien1baoto = Convert.ToDouble(txtSoKien_1_BaoTo.Text.ToString());
               
                txtSoLuongThanhPhamQuyDoi.Text = (soluongbaobe * sokien1baobe + soluongbaoto * sokien1baoto).ToString();
                txtTongSoKG.Text = (soluongbaobe * sokg1baobe + soluongbaoto * sokg1baoto).ToString();
                if (checkHangNhu.Checked == true)
                    txtTongSoKG.Text = txtSoLuongBaoTo.Text;
            }
            catch
            {

            }
        }
        private void Load_LockUp()
        {
            clsDinhMuc_tbDM_NguyenPhuLieu clsdinhmucnpl = new clsDinhMuc_tbDM_NguyenPhuLieu();
            DataTable dt2 = clsdinhmucnpl.SelectAll();
            dt2.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvnpl = dt2.DefaultView;
            DataTable newdtnpl = dvnpl.ToTable();


            gridMaDinhMucNPL.Properties.DataSource = newdtnpl;
            gridMaDinhMucNPL.Properties.ValueMember = "ID_DinhMuc_NPL";
            gridMaDinhMucNPL.Properties.DisplayMember = "MaDinhMuc";

            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=4";
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

            clsTbDanhMuc_DaiLy clsdaily = new clsTbDanhMuc_DaiLy();
            DataTable dtdaily = clsdaily.SelectAll();
            dtdaily.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv = dtdaily.DefaultView;
            DataTable dtxx = dv.ToTable();
            gridMaDaiLy.Properties.DataSource = dtxx;
            gridMaDaiLy.Properties.ValueMember = "ID_DaiLy";
            gridMaDaiLy.Properties.DisplayMember = "MaDaiLy";


          
            clsDinhMuc_tbDinhMuc_DOT clsdinhmucdot = new clsDinhMuc_tbDinhMuc_DOT();
            DataTable dt3 = clsdinhmucdot.SelectAll();
            dt3.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv3 = dt3.DefaultView;
            dv3.Sort = "NgayThang DESC";
            DataTable dtxx3 = dv3.ToTable();


            gridMaDinhMucDot_BaoTo.Properties.DataSource = dtxx3;
            gridMaDinhMucDot_BaoTo.Properties.ValueMember = "ID_DinhMuc_Dot";
            gridMaDinhMucDot_BaoTo.Properties.DisplayMember = "SoHieu";

            gridMaDinhMucDot_BaoBe.Properties.DataSource = dtxx3;
            gridMaDinhMucDot_BaoBe.Properties.ValueMember = "ID_DinhMuc_Dot";
            gridMaDinhMucDot_BaoBe.Properties.DisplayMember = "SoHieu";


        }
        private bool KiemTraLuu()
        {
            if (txtSoChungTu.Text.ToString() == "")
            {
                MessageBox.Show("Chưa có số CT ");
                return false;
            }

            else if (gridNguoiLap.EditValue == null)
            {
                MessageBox.Show("Chưa có người nhập kho ");
                return false;
            }
            else if (dteNgayChungTuBTP.EditValue == null)
            {
                MessageBox.Show("Chưa chọn ngày chứng từ ");
                return false;
            }
            else return true;


        }
        private void Luu__Va_XuatKho_BTP()
        {
            if (!KiemTraLuu()) return;
            else
            {
                double tongtienhang;
                tongtienhang = Convert.ToDouble(txtTongTienHang.Text.ToString());
                clsKhoBTP_tbXuatKho cls1 = new clsKhoBTP_tbXuatKho();
                cls1.sDienGiai = txtDienGiaiNPL.Text.ToString();
                cls1.daNgayChungTu = dteNgayChungTuBTP.DateTime;
                cls1.sSoChungTu = txtSoChungTu.Text.ToString();
                cls1.fTongTienHang = tongtienhang;
                cls1.iID_NguoiNhap = Convert.ToInt32(gridNguoiLap.EditValue.ToString());
                cls1.sThamChieu = txtThamChieu.Text.ToString();
                cls1.bTonTai = true;
                cls1.bNgungTheoDoi = false;
              
                cls1.bDaXuatKho = true;

                clsKhoBTP_ChiTietXuatKho clschitietxuatkho = new clsKhoBTP_ChiTietXuatKho();
                if (UCBanThanhPham_XuatKhoDaiLy.mbool_ThemMoi_xuatkhoBTP_Ra_DaiLy == true)
                {
                    cls1.Insert();
                }
                else
                {
                    cls1.iID_XuatKhoBTP = ID_XuatKhoBTP;
                    cls1.Update();
                    

                    // xoa chi tiet xuat kho
                    clschitietxuatkho.iID_XuatKhoBTP = ID_XuatKhoBTP;
                    clschitietxuatkho.Delete_ALL_W_ID_XuatKhoBTP();

                }
                   
                // insert tbChiTietNhapKho
                string shienthi = "1";
                int iiiiIDID_XuatKhoBTP = cls1.iID_XuatKhoBTP.Value;
                
                DataTable dttttt2 = (DataTable)gridControl1.DataSource;
                dttttt2.DefaultView.RowFilter = "HienThi=" + shienthi + " and BoolVTChinh=True";
                DataView dvmoi = dttttt2.DefaultView;
                DataTable dtmoi = dvmoi.ToTable();

                clschitietxuatkho.iID_XuatKhoBTP = iiiiIDID_XuatKhoBTP;
                clschitietxuatkho.iID_VTHH = Convert.ToInt32(dtmoi.Rows[0]["ID_VTHH"].ToString());
                clschitietxuatkho.fSoLuongXuat = Convert.ToDouble(dtmoi.Rows[0]["SoLuong"].ToString());
                clschitietxuatkho.fDonGia = Convert.ToDouble(dtmoi.Rows[0]["DonGia"].ToString());
                clschitietxuatkho.bTonTai = true;
                clschitietxuatkho.bNgungTheoDoi = false;
                clschitietxuatkho.bDaXuatKho = true;
                clschitietxuatkho.sGhiChu = dtmoi.Rows[0]["GhiChu"].ToString();
                clschitietxuatkho.Insert();

                //update soluong ton tbnhapkho
                if (UCBanThanhPham_XuatKhoDaiLy.mbool_ThemMoi_xuatkhoBTP_Ra_DaiLy == false)
                {
                    clsKhoBTP_tbChiTietNhapKho clschitietnhapkho = new CtyTinLuong.clsKhoBTP_tbChiTietNhapKho();
                    int iiiID_VTHH = Convert.ToInt32(dtmoi.Rows[0]["ID_VTHH"].ToString());
                    double soluongxuat = Convert.ToDouble(dtmoi.Rows[0]["SoLuong"].ToString());
                    clschitietnhapkho.iID_VTHH = iiiID_VTHH;
                    DataTable dt2 = clschitietnhapkho.Select_W_ID_VTHH();
                    Double douSoLuongTonCu;
                    douSoLuongTonCu = Convert.ToDouble(dt2.Rows[0]["SoLuongTon"].ToString());
                    clschitietnhapkho.iID_ChiTietNhapKho = Convert.ToInt32(dt2.Rows[0]["ID_ChiTietNhapKho"].ToString());
                    clschitietnhapkho.fSoLuongTon = douSoLuongTonCu - soluongxuat;
                    clschitietnhapkho.Update_SoLuongTon();
                }
               

                /// Update trang thai xuat nhapm kho dai ly
                clsDaiLy_tbNhapKho clsxxx = new CtyTinLuong.clsDaiLy_tbNhapKho();
                clsxxx.iID_NhapKhoDaiLy = UCBanThanhPham_XuatKhoDaiLy.miID_NhapKhoDaiLy;
                clsxxx.Update_TrangThaiXuatNhap_Kho_banThanhPham();
                /// Update soluong nhập thuc te
                clsDaiLy_tbChiTietNhapKho clschitietnhapkhodaily = new clsDaiLy_tbChiTietNhapKho();
                clschitietnhapkhodaily.iID_NhapKhoDaiLy = UCBanThanhPham_XuatKhoDaiLy.miID_NhapKhoDaiLy;
                clschitietnhapkhodaily.iID_VTHH = Convert.ToInt32(dtmoi.Rows[0]["ID_VTHH"].ToString());
                clschitietnhapkhodaily.fSoLuongNhap = Convert.ToDouble(dtmoi.Rows[0]["SoLuong"].ToString());
                clschitietnhapkhodaily.iID_DaiLy = Convert.ToInt32(gridMaDaiLy.EditValue.ToString());
                clschitietnhapkhodaily.fDonGia = Convert.ToDouble(dtmoi.Rows[0]["DonGia"].ToString());
                clschitietnhapkhodaily.Update_SoLuongNhap_and_DonGia_W_ID_NhapKho_and_ID_VTHH_and_ID_DaiLy();
              
                MessageBox.Show("Đã xuất kho");
                this.Close();
            }
        }
        private void Luu_ChiLuu()
        {

            if (!KiemTraLuu()) return;
            else
            {
                double tongtienhang;
                tongtienhang = Convert.ToDouble(txtTongTienHang.Text.ToString());
                clsKhoBTP_tbXuatKho cls1 = new clsKhoBTP_tbXuatKho();
                cls1.sDienGiai = txtDienGiaiNPL.Text.ToString();
                cls1.daNgayChungTu = dteNgayChungTuBTP.DateTime;
                cls1.sSoChungTu = txtSoChungTu.Text.ToString();
                cls1.fTongTienHang = tongtienhang;
                cls1.iID_NguoiNhap = Convert.ToInt32(gridNguoiLap.EditValue.ToString());
                cls1.sThamChieu = txtThamChieu.Text.ToString();
                cls1.bTonTai = true;
                cls1.bNgungTheoDoi = false;
               
                cls1.bDaXuatKho = false;

                clsKhoBTP_ChiTietXuatKho clschitietxuatkho = new clsKhoBTP_ChiTietXuatKho();
                if (UCBanThanhPham_XuatKhoDaiLy.mbool_ThemMoi_xuatkhoBTP_Ra_DaiLy == true)
                {
                    cls1.Insert();
                }
                else
                {
                    cls1.iID_XuatKhoBTP = ID_XuatKhoBTP;
                    cls1.Update();
                    
                    // xoa chi tiet xuat kho
                    clschitietxuatkho.iID_XuatKhoBTP = ID_XuatKhoBTP;
                    clschitietxuatkho.Delete_ALL_W_ID_XuatKhoBTP();

                }

                // insert tbChiTietNhapKho
                string shienthi = "1";
                int iiiiIDID_XuatKhoBTP = cls1.iID_XuatKhoBTP.Value;

                DataTable dttttt2 = (DataTable)gridControl1.DataSource;
                dttttt2.DefaultView.RowFilter = "HienThi=" + shienthi + " and BoolVTChinh=True";
                DataView dvmoi = dttttt2.DefaultView;
                DataTable dtmoi = dvmoi.ToTable();

                clschitietxuatkho.iID_XuatKhoBTP = iiiiIDID_XuatKhoBTP;
                clschitietxuatkho.iID_VTHH = Convert.ToInt32(dtmoi.Rows[0]["ID_VTHH"].ToString());
                clschitietxuatkho.fSoLuongXuat = Convert.ToDouble(dtmoi.Rows[0]["SoLuong"].ToString());
                clschitietxuatkho.fDonGia = Convert.ToDouble(dtmoi.Rows[0]["DonGia"].ToString());
                clschitietxuatkho.bTonTai = true;
                clschitietxuatkho.bNgungTheoDoi = false;
                clschitietxuatkho.bDaXuatKho = false;
                clschitietxuatkho.sGhiChu = dtmoi.Rows[0]["GhiChu"].ToString();
                clschitietxuatkho.Insert();

                ////update soluong ton tbnhapkho
                //if (UCBanThanhPham_XuatKhoDaiLy.mbool_ThemMoi_xuatkhoBTP_Ra_DaiLy == false)
                //{
                //    clsKhoBTP_tbChiTietNhapKho clschitietnhapkho = new CtyTinLuong.clsKhoBTP_tbChiTietNhapKho();
                //    int iiiID_VTHH = Convert.ToInt32(dtmoi.Rows[0]["ID_VTHH"].ToString());
                //    double soluongxuat = Convert.ToDouble(dtmoi.Rows[0]["SoLuong"].ToString());
                //    clschitietnhapkho.iID_VTHH = iiiID_VTHH;
                //    DataTable dt2 = clschitietnhapkho.Select_W_ID_VTHH();
                //    Double douSoLuongTonCu;
                //    douSoLuongTonCu = Convert.ToDouble(dt2.Rows[0]["SoLuongTon"].ToString());
                //    clschitietnhapkho.iID_ChiTietNhapKho = Convert.ToInt32(dt2.Rows[0]["ID_ChiTietNhapKho"].ToString());
                //    clschitietnhapkho.fSoLuongTon = douSoLuongTonCu - soluongxuat;
                //    clschitietnhapkho.Update_SoLuongTon();
                //}


                ///// Update trang thai xuat nhapm kho dai ly
                //clsDaiLy_tbNhapKho clsxxx = new CtyTinLuong.clsDaiLy_tbNhapKho();
                //clsxxx.iID_NhapKhoDaiLy = UCBanThanhPham_XuatKhoDaiLy.miID_NhapKhoDaiLy;
                //clsxxx.Update_TrangThaiXuatNhap_Kho_banThanhPham();

                // luu bien dong tai khoan ke toán
                // xóa truoc
               

                MessageBox.Show("Đã lưu");
                this.Close();
            }
        }
     
        private void HienThi_ThemMoi_XuatKhoBTP_ra_DaiLy()
        {
            gridNguoiLap.EditValue = 12;
            clsDaiLy_tbNhapKho cls1 = new clsDaiLy_tbNhapKho();
            cls1.iID_NhapKhoDaiLy = UCBanThanhPham_XuatKhoDaiLy.miID_NhapKhoDaiLy;
            DataTable dt = cls1.SelectOne();
            if (cls1.iHangDoT_1_hangNhu_2_ConLai3 == 1)
                checkHangDot.Checked = true;
            gridMaDinhMucNPL.EditValue = cls1.iID_DinhMucNguenPhuLieu.Value;
            txtSoLuongThanhPhamQuyDoi.Text = cls1.fSoLuongThanhPhamQuyDoi.Value.ToString();
            txtSoLuongBaoTo.Text = cls1.fSoLuongXuat_BaoTo.Value.ToString();
            txtSoLuongBaoBe.Text = cls1.fSoLuongXuat_BaoBe.Value.ToString();

            dteNgayChungTu.EditValue = cls1.daNgayChungTu.Value;
            gridMaDaiLy.EditValue = cls1.iID_DaiLy.Value;
            txtThamChieu.Text = cls1.sSoChungTu.Value.ToString();
            txtDienGiai.Text = cls1.sDienGiai.Value.ToString();
           
            gridMaDinhMucDot_BaoTo.EditValue = cls1.iID_DinhMucDot_BaoTo.Value;
            gridMaDinhMucDot_BaoBe.EditValue = cls1.iID_DinhMucDot_BaoBe.Value;
            dteNgayChungTuBTP.EditValue = DateTime.Today;

            //clsTbVatTuHangHoa clsvt = new clsTbVatTuHangHoa();
            //clsvt.iID_VTHH = cls1.iID_VTHH_TPQuyDoi.Value;
            //DataTable dtvt = clsvt.SelectOne();
            //txtTenThanhPham.Text = clsvt.sTenVTHH.Value;

            clsKhoBTP_tbXuatKho cls1xx = new clsKhoBTP_tbXuatKho();
            DataTable dt1 = cls1xx.SelectAll();
            dt1.DefaultView.RowFilter = " TonTai= True and NgungTheoDoi=false";
            DataView dv = dt1.DefaultView;
            DataTable dv3 = dv.ToTable();
            int k = dv3.Rows.Count;
            if (k == 0)
            {
                txtSoChungTu.Text = "XKBTP 1";
            }
            else
            {
                string xxx = dt1.Rows[k - 1]["SoChungTu"].ToString();
                int xxx2 = Convert.ToInt32(xxx.Substring(5).Trim()) + 1;
                txtSoChungTu.Text = "XKBTP " + xxx2.ToString() + "";
            }
        }

        private void HienThi_Sua_XuatKhoBTP_ra_DaiLy()
        {
           
            clsDaiLy_tbNhapKho cls1 = new clsDaiLy_tbNhapKho();
            cls1.iID_NhapKhoDaiLy = UCBanThanhPham_XuatKhoDaiLy.miID_NhapKhoDaiLy;
            DataTable dt = cls1.SelectOne();
            if (cls1.iHangDoT_1_hangNhu_2_ConLai3 == 1)
                checkHangDot.Checked = true;
            gridMaDinhMucNPL.EditValue = cls1.iID_DinhMucNguenPhuLieu.Value;
            clsTbVatTuHangHoa clsvt = new clsTbVatTuHangHoa();
            clsvt.iID_VTHH = cls1.iID_VTHH_TPQuyDoi.Value;
            DataTable dtvt = clsvt.SelectOne();
            txtTenThanhPham.Text = clsvt.sTenVTHH.Value;

            txtSoLuongThanhPhamQuyDoi.Text = cls1.fSoLuongThanhPhamQuyDoi.Value.ToString();
            txtSoLuongBaoTo.Text = cls1.fSoLuongXuat_BaoTo.Value.ToString();
            txtSoLuongBaoBe.Text = cls1.fSoLuongXuat_BaoBe.Value.ToString();

            dteNgayChungTu.EditValue = cls1.daNgayChungTu.Value;
            gridMaDaiLy.EditValue = cls1.iID_DaiLy.Value;
            txtThamChieu.Text = cls1.sSoChungTu.Value.ToString();
            txtDienGiai.Text = cls1.sDienGiai.Value.ToString();

            gridMaDinhMucDot_BaoTo.EditValue = cls1.iID_DinhMucDot_BaoTo.Value;
            gridMaDinhMucDot_BaoBe.EditValue = cls1.iID_DinhMucDot_BaoBe.Value;
            dteNgayChungTuBTP.EditValue = DateTime.Today;
            ///////

            clsKhoBTP_tbXuatKho cls1xx = new clsKhoBTP_tbXuatKho();
            cls1xx.sThamChieu = txtThamChieu.Text.ToString();
            DataTable dt1 = cls1xx.SelectOne_W_ThamChieu_SoChungTu_XuatKho_DaiLy();
            ID_XuatKhoBTP = Convert.ToInt32(dt1.Rows[0]["ID_XuatKhoBTP"].ToString());
            cls1xx.iID_XuatKhoBTP = ID_XuatKhoBTP;
            DataTable dt2xx = cls1xx.SelectOne();
            txtSoChungTu.Text = cls1xx.sSoChungTu.Value;
            dteNgayChungTuBTP.EditValue = cls1xx.daNgayChungTu.Value;
            gridNguoiLap.EditValue = cls1xx.iID_NguoiNhap.Value;
            txtDienGiai.Text = cls1xx.sDienGiai.Value;
            txtTongTienHang.Text = cls1xx.fTongTienHang.Value.ToString();
            if (cls1.bTrangThaiXuatNhap_Kho_BTP == true)
            {
                btLuu_Gui_Dong.Enabled = false;
                btLuu_Dong.Enabled = false;
            }
            else
            {
                btLuu_Gui_Dong.Enabled = true;
                btLuu_Dong.Enabled = true;
            }
           

            HienThi_GridControl_Sua();
        }
        private void HienThi_GridControl_Moiiiiiiiiiiii()
        {
            double soluongthanhphamquydoi = Convert.ToDouble(txtSoLuongThanhPhamQuyDoi.Text.ToString());
            double tongsokg = Convert.ToDouble(txtTongSoKG.Text.ToString());
            DataTable dt2 = new DataTable();

            dt2.Columns.Add("ID_VTHH", typeof(int));
            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("TenVTHH", typeof(string));
            dt2.Columns.Add("DonViTinh", typeof(string));
            dt2.Columns.Add("DinhMuc", typeof(double));
            dt2.Columns.Add("SoLuongTheoDinhMuc", typeof(double));
            dt2.Columns.Add("SoLuong", typeof(double));
            dt2.Columns.Add("SoLuongTon", typeof(double));
            dt2.Columns.Add("DonGia", typeof(double));
            dt2.Columns.Add("GhiChu", typeof(string));
            dt2.Columns.Add("HienThi", typeof(string));
            dt2.Columns.Add("ThanhTien", typeof(double));
            dt2.Columns.Add("BoolVTChinh", typeof(bool));
            dt2.Columns.Add("BoolNPL", typeof(bool));
            clsDinhMuc_tbDM_NguyenPhuLieu cls1 = new CtyTinLuong.clsDinhMuc_tbDM_NguyenPhuLieu();
            cls1.iID_DinhMuc_NPL = Convert.ToInt32(gridMaDinhMucNPL.EditValue.ToString());
            DataTable dt1 = cls1.SelectOne();
            int iiID_DinhMucNPL = Convert.ToInt32(dt1.Rows[0]["ID_DinhMuc_NPL"].ToString());
            int iiID_VatTuChinh1 = Convert.ToInt32(dt1.Rows[0]["ID_VTHH_Chinh"].ToString());
            clsKhoBTP_tbChiTietNhapKho clskhoBTP = new clsKhoBTP_tbChiTietNhapKho();
            clskhoBTP.iID_VTHH = iiID_VatTuChinh1;
            DataTable dtkhoBTPvtuchinh1 = clskhoBTP.Select_W_ID_VTHH_w_Ten_VTHH_KhoDaiLy();
            if (dtkhoBTPvtuchinh1.Rows.Count > 0)
            {
                double dongiaxxx = Convert.ToDouble(dtkhoBTPvtuchinh1.Rows[0]["DonGia"].ToString());
                DataRow _ravi = dt2.NewRow();
                _ravi["ID_VTHH"] = iiID_VatTuChinh1;
                _ravi["MaVT"] = iiID_VatTuChinh1;
                _ravi["TenVTHH"] = dtkhoBTPvtuchinh1.Rows[0]["TenVTHH"].ToString();
                _ravi["DonViTinh"] = dtkhoBTPvtuchinh1.Rows[0]["DonViTinh"].ToString();
                _ravi["DinhMuc"] = 1;
                _ravi["SoLuongTon"] = Convert.ToDouble(dtkhoBTPvtuchinh1.Rows[0]["SoLuongTon"].ToString());
                _ravi["SoLuongTheoDinhMuc"] = tongsokg;
                _ravi["SoLuong"] = tongsokg;
                _ravi["DonGia"] = dongiaxxx;
                _ravi["GhiChu"] = "";
                _ravi["HienThi"] = "1";
                _ravi["ThanhTien"] = tongsokg * dongiaxxx;
                _ravi["BoolVTChinh"] = true;
                dt2.Rows.Add(_ravi);
            }
            else
            {
                DataRow _ravi2 = dt2.NewRow();
                _ravi2["ID_VTHH"] = iiID_VatTuChinh1;
                _ravi2["MaVT"] = iiID_VatTuChinh1;
                clsTbVatTuHangHoa clsvt = new clsTbVatTuHangHoa();
                clsvt.iID_VTHH = iiID_VatTuChinh1;
                DataTable dtvt = clsvt.SelectOne();
                _ravi2["TenVTHH"] = clsvt.sTenVTHH.Value;
                _ravi2["DonViTinh"] = clsvt.sDonViTinh.Value;
                _ravi2["DinhMuc"] = 1;
                _ravi2["SoLuongTon"] = 0;
                _ravi2["SoLuongTheoDinhMuc"] = tongsokg;
                _ravi2["SoLuong"] = tongsokg;
                _ravi2["DonGia"] = 0;
                _ravi2["GhiChu"] = "";
                _ravi2["HienThi"] = "1";
                _ravi2["ThanhTien"] = 0;
                _ravi2["BoolVTChinh"] = true;
                dt2.Rows.Add(_ravi2);
            }

            gridControl1.DataSource = dt2;

            double deTOngtien;

            string shienthi = "1";
            object xxxx = dt2.Compute("sum(ThanhTien)", "HienThi=" + shienthi + " and BoolVTChinh = True");
            if (xxxx.ToString() != "")
                deTOngtien = Convert.ToDouble(xxxx);
            else deTOngtien = 0;
            txtTongTienHang.Text = deTOngtien.ToString();

        }

        private void HienThi_GridControl_Sua()
        {
            double soluongthanhpham = Convert.ToDouble(txtSoLuongThanhPhamQuyDoi.Text.ToString());
            double TongsoKG = Convert.ToDouble(txtTongSoKG.Text.ToString());

            gridControl1.DataSource = null;
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
            dt2.Columns.Add("BoolVTChinh", typeof(bool));
            dt2.Columns.Add("BoolNPL", typeof(bool));

            clsDaiLy_tbChiTietNhapKho cls = new CtyTinLuong.clsDaiLy_tbChiTietNhapKho();
            cls.iID_NhapKhoDaiLy = UCBanThanhPham_XuatKhoDaiLy.miID_NhapKhoDaiLy;
            cls.iID_DaiLy = Convert.ToInt32(gridMaDaiLy.EditValue.ToString());
            DataTable dt_ChiTiet_nhapkho_DaiLy = cls.SelectAll_W_ID_NhapKhoDaiLy();

            clsDinhMuc_tbDM_NguyenPhuLieu cls1 = new CtyTinLuong.clsDinhMuc_tbDM_NguyenPhuLieu();
            cls1.iID_DinhMuc_NPL = Convert.ToInt32(gridMaDinhMucNPL.EditValue.ToString());
            DataTable dt1 = cls1.SelectOne();
            int iiID_DinhMucNPL = Convert.ToInt32(dt1.Rows[0]["ID_DinhMuc_NPL"].ToString());
            int iiID_VatTuChinh1 = Convert.ToInt32(dt1.Rows[0]["ID_VTHH_Chinh"].ToString());
            clsKhoBTP_tbChiTietNhapKho clskhoBTP = new clsKhoBTP_tbChiTietNhapKho();
            clskhoBTP.iID_VTHH = iiID_VatTuChinh1;
            DataTable dtkhoBTPvtuchinh1 = clskhoBTP.Select_W_ID_VTHH_w_Ten_VTHH_KhoDaiLy();
            DataRow _ravi = dt2.NewRow();
            if (dtkhoBTPvtuchinh1.Rows.Count > 0)
            {
                _ravi["TenVTHH"] = dtkhoBTPvtuchinh1.Rows[0]["TenVTHH"].ToString();
                _ravi["DonViTinh"] = dtkhoBTPvtuchinh1.Rows[0]["DonViTinh"].ToString();
            }
            else
            {
                clsTbVatTuHangHoa clsvt = new clsTbVatTuHangHoa();
                clsvt.iID_VTHH = iiID_VatTuChinh1;
                DataTable dtvt = clsvt.SelectOne();
                _ravi["TenVTHH"] = clsvt.sTenVTHH.Value;
                _ravi["DonViTinh"] = clsvt.sMaVT.Value;
            }
            cls.iID_NhapKhoDaiLy = UCBanThanhPham_XuatKhoDaiLy.miID_NhapKhoDaiLy;
            cls.iID_DaiLy = Convert.ToInt32(gridMaDaiLy.EditValue.ToString());
            double soluongxuat = Convert.ToDouble(dt_ChiTiet_nhapkho_DaiLy.Rows[1]["SoLuongNhap"].ToString());
            double dongiaxxx = Convert.ToDouble(dt_ChiTiet_nhapkho_DaiLy.Rows[1]["DonGia"].ToString());

            _ravi["ID_VTHH"] = iiID_VatTuChinh1;
            _ravi["MaVT"] = iiID_VatTuChinh1;

            _ravi["DinhMuc"] = 1;
            // _ravi["SoLuongTon"] = Convert.ToDouble(dtkhoBTPvtuchinh1.Rows[0]["SoLuongTon"].ToString());
            _ravi["SoLuongTheoDinhMuc"] = TongsoKG;
            _ravi["SoLuong"] = soluongxuat;
            _ravi["DonGia"] = dongiaxxx;
            _ravi["GhiChu"] = "";
            _ravi["HienThi"] = "1";
            _ravi["ThanhTien"] = soluongxuat * dongiaxxx;
            _ravi["BoolVTChinh"] = true;

            dt2.Rows.Add(_ravi);
            gridControl1.DataSource = dt2;

            double deTOngtien;
            string shienthi = "1";
            object xxxx = dt2.Compute("sum(ThanhTien)", "HienThi=" + shienthi + " and BoolVTChinh = False");
            if (xxxx.ToString() != "")
                deTOngtien = Convert.ToDouble(xxxx);
            else deTOngtien = 0;
            txtTongTienHang.Text = deTOngtien.ToString();

        }
       
        public KhoBTP_frmChiTietXuatKhoDaiLyGiaCong()
        {
            InitializeComponent();
        }

        private void KhoBTP_frmChiTietXuatKhoDaiLyGiaCong_Load(object sender, EventArgs e)
        {
            Load_LockUp();
            if (UCBanThanhPham_XuatKhoDaiLy.mbool_ThemMoi_xuatkhoBTP_Ra_DaiLy == true)
                HienThi_ThemMoi_XuatKhoBTP_ra_DaiLy();
            else HienThi_Sua_XuatKhoBTP_ra_DaiLy();
               
           
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
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

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            double fffsoluong = 0;
            double ffdongia = 0;
            double fffthanhtien = 0;
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

                double deTOngtien;

                string shienthi = "1";
                DataTable dt2 = (DataTable)gridControl1.DataSource;
                object xxxx = dt2.Compute("sum(ThanhTien)", "HienThi=" + shienthi + " and BoolVTChinh = True");
                if (xxxx.ToString() != "")
                    deTOngtien = Convert.ToDouble(xxxx);
                else deTOngtien = 0;
                txtTongTienHang.Text = deTOngtien.ToString();
            }
        }

        private void txtSoLuongXuat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TinhTongSoKg_TongSoKien();
                clsDaiLy_tbNhapKho cls1 = new clsDaiLy_tbNhapKho();
                cls1.iID_NhapKhoDaiLy = UCBanThanhPham_XuatKhoDaiLy.miID_NhapKhoDaiLy;
                DataTable dt = cls1.SelectOne();
                txtSoLuongThanhPhamQuyDoi.Text = cls1.fSoLuongThanhPhamQuyDoi.ToString();
                if (UCBanThanhPham_XuatKhoDaiLy.mbool_ThemMoi_xuatkhoBTP_Ra_DaiLy == true)
                    HienThi_GridControl_Moiiiiiiiiiiii();                
            }
            catch
            {

            }
        }
        
        private void btLuu_Gui_Dong_Click(object sender, EventArgs e)
        {
            Luu__Va_XuatKho_BTP();
        }

        private void btLuu_Dong_Click(object sender, EventArgs e)
        {
            Luu_ChiLuu();
        }

        private void gridMaDinhMucDot_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridMaDinhMucDot_BaoTo_EditValueChanged(object sender, EventArgs e)
        {
            clsDinhMuc_tbDinhMuc_DOT clsncc = new clsDinhMuc_tbDinhMuc_DOT();

            clsncc.iID_DinhMuc_Dot = Convert.ToInt32(gridMaDinhMucDot_BaoTo.EditValue.ToString());
            DataTable dt = clsncc.SelectOne();
            try
            {
                
                double SoKG_1BaoTo = Convert.ToDouble(dt.Rows[0]["SoKG_MotBao"].ToString());
                double SoKienMotBao_To = Convert.ToDouble(dt.Rows[0]["SoKienMotBao"].ToString());
                txtSoKG1Bao_To.Text = SoKG_1BaoTo.ToString();
                txtSoKien_1_BaoTo.Text = SoKienMotBao_To.ToString();
                TinhTongSoKg_TongSoKien();
                if (UCBanThanhPham_XuatKhoDaiLy.mbool_ThemMoi_xuatkhoBTP_Ra_DaiLy == true)
                    HienThi_GridControl_Moiiiiiiiiiiii();
            }
            catch
            {

            }
        }

        private void gridMaDinhMucDot_BaoBe_EditValueChanged(object sender, EventArgs e)
        {
            clsDinhMuc_tbDinhMuc_DOT clsncc = new clsDinhMuc_tbDinhMuc_DOT();
            clsncc.iID_DinhMuc_Dot = Convert.ToInt32(gridMaDinhMucDot_BaoBe.EditValue.ToString());
            DataTable dt = clsncc.SelectOne();
            try
            {

                double SoKG_1BaoBe = Convert.ToDouble(dt.Rows[0]["SoKG_MotBao"].ToString());
                double SoKienMotBao_Be = Convert.ToDouble(dt.Rows[0]["SoKienMotBao"].ToString());
                txtSoKG1Bao_Be.Text = SoKG_1BaoBe.ToString();
                txtSoKien_1_BaoBe.Text = SoKienMotBao_Be.ToString();

                TinhTongSoKg_TongSoKien();
                if (UCBanThanhPham_XuatKhoDaiLy.mbool_ThemMoi_xuatkhoBTP_Ra_DaiLy == true)
                    HienThi_GridControl_Moiiiiiiiiiiii();
            }
            catch
            {

            }
        }

        private void txtSoLuongBaoBe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TinhTongSoKg_TongSoKien();
                if (UCBanThanhPham_XuatKhoDaiLy.mbool_ThemMoi_xuatkhoBTP_Ra_DaiLy == true)
                    HienThi_GridControl_Moiiiiiiiiiiii();

            }
            catch
            {

            }
        }

        private void gridMaDinhMucNPL_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                
                    if (UCBanThanhPham_XuatKhoDaiLy.mbool_ThemMoi_xuatkhoBTP_Ra_DaiLy == true)
                        HienThi_GridControl_Moiiiiiiiiiiii();
                  
               

            }
            catch
            {

            }
        }

        private void checkHangDot_CheckedChanged(object sender, EventArgs e)
        {

            if (checkHangDot.Checked == true)
            {
                //Load_LockUp_DinhMucDot();
                checkHangNhu.Checked = false;

                layoutControlItem1_duoi.Visibility = LayoutVisibility.Always;
                layoutControlItem7_duoi.Visibility = LayoutVisibility.Always;                
                layoutControlItem11_duoi.Visibility = LayoutVisibility.Always;
                layoutControlItem14_duoi.Visibility = LayoutVisibility.Always;

                layoutControlItem10_tren.Text = "Kg/ 1bao";
                layoutControlItem15_tren.Text = "SL Bao To";
                layoutControlItem17.Text = "Tổng số Kg";
            }
        }

        private void checkHangNhu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHangNhu.Checked == true)
            {
                //Load_LockUp_DinhMucDot();
                checkHangDot.Checked = false;
                layoutControlItem1_duoi.Visibility = LayoutVisibility.Never;
                layoutControlItem7_duoi.Visibility = LayoutVisibility.Never;
                layoutControlItem11_duoi.Visibility = LayoutVisibility.Never;
                layoutControlItem14_duoi.Visibility = LayoutVisibility.Never;

                layoutControlItem10_tren.Text = "Cục/ 1bao";
                layoutControlItem15_tren.Text = "Số lượng xuất";
                layoutControlItem17.Text = "Tổng số cục";
            }
        }
    }
}
