using DevExpress.Data.Filtering;
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
    public partial class KhoNPL_frmChiTietXuatKhoDaiLyGiaCong : Form
    {
       
        int miID_DinhMucNPL_XXx;       
        //private void HienThi_taiKhoanKeToan()
        //{
        //    clsKhoNPL_tbXuatKho cls = new CtyTinLuong.clsKhoNPL_tbXuatKho();
        //    cls.iID_XuatKhoNPL = UCNPL_XuatKhoPhuLieuRaDaiLyGiaCong.miID_NhapKhoDaiLy;
        //    DataTable dt = cls.SelectOne();
        //    if(dt.Rows.Count>0)
        //    {
        //        if (dt.Rows[0]["ID_TKNo"].ToString() != "" & dt.Rows[0]["ID_TKCo"].ToString() != "")
        //        {
        //            gridTKNo.EditValue = cls.iID_TKNo.Value;
        //            gridTKCo.EditValue = cls.iID_TKCo.Value;
        //            clsNganHang_ChiTietBienDongTaiKhoanKeToan clstaikhoan = new CtyTinLuong.clsNganHang_ChiTietBienDongTaiKhoanKeToan();
        //            clstaikhoan.iID_ChungTu = UCNPL_XuatKhoPhuLieuRaDaiLyGiaCong.miID_NhapKhoDaiLy;
        //            clstaikhoan.sSoChungTu = cls.sSoChungTu.Value;
        //            clstaikhoan.daNgayThang = cls.daNgayChungTu.Value;
        //            DataTable dttaikhoanm = clstaikhoan.Select_W_iID_ChungTu_sSoChungTu_daNgayThang();
        //            if (dttaikhoanm.Rows.Count > 0)
        //            {
        //                for (int i = 0; i < dttaikhoanm.Rows.Count; i++)
        //                {
        //                    if (Convert.ToBoolean(dttaikhoanm.Rows[i]["BoolTK_No"].ToString()) == true)
        //                        txtTienNo.Text = dttaikhoanm.Rows[i]["No"].ToString();
        //                    if (Convert.ToBoolean(dttaikhoanm.Rows[i]["BoolTK_Co"].ToString()) == true)
        //                        txtTienCo.Text = dttaikhoanm.Rows[i]["Co"].ToString();
        //                }
        //            }

        //        }
        //    }
            

        //}
        private void Load_LockUp()
        {


            clsNganHang_TaiKhoanKeToanCon clsme = new clsNganHang_TaiKhoanKeToanCon();
            DataTable dtme = clsme.SelectAll();
            dtme.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=false";
            DataView dvme = dtme.DefaultView;
            DataTable newdtme = dvme.ToTable();

            //gridTKCo.Properties.DataSource = newdtme;
            //gridTKCo.Properties.ValueMember = "ID_TaiKhoanKeToanCon";
            //gridTKCo.Properties.DisplayMember = "SoTaiKhoanCon";


            //gridTKNo.Properties.DataSource = newdtme;
            //gridTKNo.Properties.ValueMember = "ID_TaiKhoanKeToanCon";
            //gridTKNo.Properties.DisplayMember = "SoTaiKhoanCon";

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

            clsTbDanhMuc_DaiLy clsdaily = new clsTbDanhMuc_DaiLy();
            DataTable dtdaily = clsdaily.SelectAll();
            dtdaily.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv = dtdaily.DefaultView;
            DataTable dtxx = dv.ToTable();
            gridMaDaiLy.Properties.DataSource = dtxx;
            gridMaDaiLy.Properties.ValueMember = "ID_DaiLy";
            gridMaDaiLy.Properties.DisplayMember = "MaDaiLy";


            clsDinhMuc_tbDM_NguyenPhuLieu clsdinhmucnpl = new clsDinhMuc_tbDM_NguyenPhuLieu();
            DataTable dt2 = clsdinhmucnpl.SelectAll();
            dt2.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvnpl = dt2.DefaultView;
            DataTable newdtnpl = dvnpl.ToTable();


            gridMaDinhMucNPL.Properties.DataSource = newdtnpl;
            gridMaDinhMucNPL.Properties.ValueMember = "ID_DinhMuc_NPL";
            gridMaDinhMucNPL.Properties.DisplayMember = "MaDinhMuc";

            clsDinhMuc_tbDinhMuc_DOT clsdinhmucdot = new clsDinhMuc_tbDinhMuc_DOT();
            DataTable dt3 = clsdinhmucdot.SelectAll();
            dt3.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv3 = dt3.DefaultView;
            dv3.Sort = "NgayThang DESC";
            DataTable dtxx3 = dv3.ToTable();


            gridMaDinhMucDot.Properties.DataSource = dtxx3;
            gridMaDinhMucDot.Properties.ValueMember = "ID_DinhMuc_Dot";
            gridMaDinhMucDot.Properties.DisplayMember = "SoHieu";


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
            else if (dteNgayChungTuNPL.EditValue == null)
            {
                MessageBox.Show("Chưa chọn ngày chứng từ ");
                return false;
            }            
            else return true;


        }
        private void Luu_XuatKho_NPL_Va_taiKhoanKeToan()
        {
            if (!KiemTraLuu()) return;
            else
            {
                double tongtienhang;
                tongtienhang = Convert.ToDouble(txtTongTienHang.Text.ToString());
                clsKhoNPL_tbXuatKho cls1 = new clsKhoNPL_tbXuatKho();
                cls1.sDienGiai = txtDienGiaiNPL.Text.ToString();
                cls1.daNgayChungTu = dteNgayChungTuNPL.DateTime;
                cls1.sSoChungTu = txtSoChungTu.Text.ToString();
                cls1.fTongTienHang = tongtienhang;
                cls1.iID_NguoiXuatKho = Convert.ToInt16(gridNguoiLap.EditValue.ToString());
                cls1.sThamChieu = txtThamChieu.Text.ToString();
                cls1.bTonTai = true;
                cls1.bDaXuatKho = true;
                cls1.bNgungTheoDoi = false;
                //if (gridTKCo.EditValue != null)
                //    cls1.iID_TKCo = Convert.ToInt16(gridTKCo.EditValue.ToString());
                //if (gridTKNo.EditValue != null)
                //    cls1.iID_TKNo = Convert.ToInt16(gridTKNo.EditValue.ToString());
                cls1.Insert();
                // insert tbChiTietNhapKho
                string shienthi = "1";
                int iiiiIDID_XuatKhoNPL = cls1.iID_XuatKhoNPL.Value;
                clsKhoNPL_tbChiTietXuatKho clschitietxuatkho = new clsKhoNPL_tbChiTietXuatKho();
                DataTable dttttt2 = (DataTable)gridControl1.DataSource;
                dttttt2.DefaultView.RowFilter = "HienThi=" + shienthi + " and BoolVTChinh=False";
                DataView dvmoi = dttttt2.DefaultView;
                DataTable dtmoi = dvmoi.ToTable();
                for (int i = 0; i < dtmoi.Rows.Count; i++)
                {
                    clschitietxuatkho.iID_XuatKho = iiiiIDID_XuatKhoNPL;
                    clschitietxuatkho.iID_VTHH = Convert.ToInt16(dtmoi.Rows[i]["ID_VTHH"].ToString());
                    clschitietxuatkho.fSoLuongXuat = Convert.ToDouble(dtmoi.Rows[i]["SoLuong"].ToString());
                    clschitietxuatkho.fDonGia = Convert.ToDouble(dtmoi.Rows[i]["DonGia"].ToString());
                    clschitietxuatkho.bTonTai = true;
                    clschitietxuatkho.bNgungTheoDoi = false;
                    clschitietxuatkho.bDaXuatKho = true;
                    clschitietxuatkho.Insert();

                    // update soluong ton tbnhapkho
                    clsKhoNPL_tbChiTietNhapKho clschitietnhapkho = new CtyTinLuong.clsKhoNPL_tbChiTietNhapKho();
                    int iiiID_VTHH = Convert.ToInt16(dtmoi.Rows[i]["ID_VTHH"].ToString());
                    double soluongxuat = Convert.ToDouble(dtmoi.Rows[i]["SoLuong"].ToString());
                    clschitietnhapkho.iID_VTHH = iiiID_VTHH;
                    DataTable dt2 = clschitietnhapkho.Select_W_ID_VTHH();
                    Double douSoLuongTonCu;
                    douSoLuongTonCu = Convert.ToDouble(dt2.Rows[0]["SoLuongTon"].ToString());
                    clschitietnhapkho.iID_ChiTietNhapKho = Convert.ToInt16(dt2.Rows[0]["ID_ChiTietNhapKho"].ToString());
                    clschitietnhapkho.fSoLuongTon = douSoLuongTonCu - soluongxuat;
                    clschitietnhapkho.Update_SoLuongTon();
                }

                /// Update trang thai xuat nhapm kho dai ly
                clsDaiLy_tbNhapKho clsxxx = new CtyTinLuong.clsDaiLy_tbNhapKho();
                clsxxx.iID_NhapKhoDaiLy = UCNPL_XuatKhoPhuLieuRaDaiLyGiaCong.miID_NhapKhoDaiLy;
                clsxxx.Update_TrangThaiXuatNhap_Kho_NPL();

                //// luu bien dong tai khoan ke toán
                //if (gridTKCo.EditValue != null & gridTKNo.EditValue != null)
                //{
                //    clsNganHang_ChiTietBienDongTaiKhoanKeToan cls = new CtyTinLuong.clsNganHang_ChiTietBienDongTaiKhoanKeToan();
                //    cls.iID_TaiKhoanKeToanCon = Convert.ToInt16(gridTKNo.EditValue.ToString());
                //    clsNganHang_TaiKhoanKeToanCon clscon = new clsNganHang_TaiKhoanKeToanCon();
                //    clscon.iID_TaiKhoanKeToanCon = Convert.ToInt16(gridTKNo.EditValue.ToString());
                //    DataTable dtcon = clscon.SelectOne();
                    
                //    cls.iID_ChungTu = iiiiIDID_XuatKhoNPL;
                //    cls.sSoChungTu = txtSoChungTu.Text.ToString();
                //    cls.daNgayThang = dteNgayChungTuNPL.DateTime;
                //    cls.fCo = 0;
                //    cls.fNo = Convert.ToDouble(txtTienNo.Text.ToString());
                //    cls.bNgungTheoDoi = false;
                //    cls.bTonTai = true;
                //    cls.fTiGia = 1;
                //    cls.bTienUSD = false;
                  
                //    cls.Insert();
                //    // Có
                //    cls.iID_TaiKhoanKeToanCon = Convert.ToInt16(gridTKCo.EditValue.ToString());
                //    clsNganHang_TaiKhoanKeToanCon clscon2 = new clsNganHang_TaiKhoanKeToanCon();
                //    clscon2.iID_TaiKhoanKeToanCon = Convert.ToInt16(gridTKCo.EditValue.ToString());
                //    DataTable dtcon2 = clscon2.SelectOne();
                   
                //    cls.iID_ChungTu = iiiiIDID_XuatKhoNPL;
                //    cls.sSoChungTu = txtSoChungTu.Text.ToString();
                //    cls.daNgayThang = dteNgayChungTuNPL.DateTime;
                //    cls.fCo = Convert.ToDouble(txtTienCo.Text.ToString());
                //    cls.fNo = 0;
                //    cls.bNgungTheoDoi = false;
                //    cls.bTonTai = true;
                //    cls.fTiGia = 1;
                //    cls.bTienUSD = false;
              
                //    cls.Insert();
                //}

                MessageBox.Show("Đã xuất kho");
                this.Close();
            }
        }      
        private void HienThi_ThongTin_DaiLy()
        {
            clsDaiLy_tbNhapKho cls1 = new clsDaiLy_tbNhapKho();
            cls1.iID_NhapKhoDaiLy = UCNPL_XuatKhoPhuLieuRaDaiLyGiaCong.miID_NhapKhoDaiLy;
            DataTable dt = cls1.SelectOne();           
          
            dteNgayChungTu.EditValue = cls1.daNgayChungTu.Value;
            gridMaDaiLy.EditValue = cls1.iID_DaiLy.Value;
            txtThamChieu.Text = cls1.sSoChungTu.Value.ToString();
            txtDienGiai.Text = cls1.sDienGiai.Value.ToString();
            //txtSoLuongXuat.Text = cls1.fSoLuongXuatTheoBao.Value.ToString();
            //gridMaDinhMucDot.EditValue = cls1.iID_DinhMucDot.Value;
            gridMaDinhMucNPL.EditValue = cls1.iID_DinhMucNguenPhuLieu.Value;       
        }
        private void HienThiChungTuXuatKho()
        {
            clsKhoNPL_tbXuatKho cls = new CtyTinLuong.clsKhoNPL_tbXuatKho();

        }     
        private void HienThi_GridControl_Moiiiiiiiiiiii()
        {

            double iisoluongxuat = 1;
            if (txtSoLuongXuat.Text.ToString() == "")
                iisoluongxuat = 1;
            else iisoluongxuat = Convert.ToDouble(txtSoLuongXuat.Text.ToString());
            double soKg1baoxxx = Convert.ToDouble(txtSoKG1Bao.Text.ToString());
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
            clsDinhMuc_tbDM_NguyenPhuLieu cls1 = new CtyTinLuong.clsDinhMuc_tbDM_NguyenPhuLieu();
            cls1.iID_DinhMuc_NPL = Convert.ToInt16(gridMaDinhMucNPL.EditValue.ToString());
            DataTable dt1 = cls1.SelectOne();
            int iiID_DinhMucNPL = Convert.ToInt16(dt1.Rows[0]["ID_DinhMuc_NPL"].ToString());
            int iiID_VatTuChinh1 = Convert.ToInt16(dt1.Rows[0]["ID_VTHH_Chinh1"].ToString());
            clsKhoBTP_tbChiTietNhapKho clskhoBTP = new clsKhoBTP_tbChiTietNhapKho();
            clskhoBTP.iID_VTHH = iiID_VatTuChinh1;
            DataTable dtkhoBTPvtuchinh1 = clskhoBTP.Select_W_ID_VTHH_w_Ten_VTHH_KhoDaiLy();
            
            if (dtkhoBTPvtuchinh1.Rows.Count > 0)
            {
                double dongiaxxx = Convert.ToDouble(dtkhoBTPvtuchinh1.Rows[0]["DonGia"].ToString());
                DataRow _ravi = dt2.NewRow();
                _ravi["ID_VTHH"] = iiID_VatTuChinh1;
                _ravi["MaVT"] = dtkhoBTPvtuchinh1.Rows[0]["MaVT"].ToString();
                _ravi["TenVTHH"] = dtkhoBTPvtuchinh1.Rows[0]["TenVTHH"].ToString();
                _ravi["DonViTinh"] = dtkhoBTPvtuchinh1.Rows[0]["DonViTinh"].ToString();
                _ravi["DinhMuc"] = 1;
                _ravi["SoLuongTon"] = Convert.ToDouble(dtkhoBTPvtuchinh1.Rows[0]["SoLuongTon"].ToString());
                _ravi["SoLuongTheoDinhMuc"] = soKg1baoxxx * iisoluongxuat;
                _ravi["SoLuong"] = soKg1baoxxx * iisoluongxuat;
                _ravi["DonGia"] = dongiaxxx;
                _ravi["GhiChu"] = "";
                _ravi["HienThi"] = "1";
                _ravi["ThanhTien"] = soKg1baoxxx * iisoluongxuat * dongiaxxx;
                _ravi["BoolVTChinh"] = true;

                dt2.Rows.Add(_ravi);

                if (dt1.Rows[0]["ID_VTHH_Chinh2"].ToString() != "")
                {

                    clsKhoNPL_tbChiTietNhapKho clsNPLnhapkho = new CtyTinLuong.clsKhoNPL_tbChiTietNhapKho();
                    clsNPLnhapkho.iID_VTHH = Convert.ToInt16(dt1.Rows[0]["ID_VTHH_Chinh2"].ToString());
                    DataTable dtkhoBTPvtuchinh2 = clsNPLnhapkho.SelectOne_W_ID_VTHH_w_Ten_VTHH();
                    if (dtkhoBTPvtuchinh2.Rows.Count > 0)
                    {
                        double dongiaxxx222 = Convert.ToDouble(dtkhoBTPvtuchinh2.Rows[0]["DonGia"].ToString());
                        DataRow _ravi2 = dt2.NewRow();
                        _ravi2["ID_VTHH"] = Convert.ToInt16(dt1.Rows[0]["ID_VTHH_Chinh2"].ToString());
                        _ravi2["MaVT"] = dtkhoBTPvtuchinh2.Rows[0]["MaVT"].ToString();
                        _ravi2["TenVTHH"] = dtkhoBTPvtuchinh2.Rows[0]["TenVTHH"].ToString();
                        _ravi2["DonViTinh"] = dtkhoBTPvtuchinh2.Rows[0]["DonViTinh"].ToString();
                        _ravi2["DinhMuc"] = 1;
                        _ravi2["SoLuongTon"] = Convert.ToDouble(dtkhoBTPvtuchinh2.Rows[0]["SoLuongTon"].ToString());
                        _ravi2["SoLuongTheoDinhMuc"] = iisoluongxuat;
                        _ravi2["SoLuong"] = iisoluongxuat;
                        _ravi2["DonGia"] = dongiaxxx222;
                        _ravi2["GhiChu"] = "";
                        _ravi2["HienThi"] = "1";
                        _ravi2["ThanhTien"] = iisoluongxuat * dongiaxxx222;
                        _ravi2["BoolVTChinh"] = false;

                        dt2.Rows.Add(_ravi2);
                    }


                }
                clsDinhMuc_ChiTiet_DM_NPL clschitietDMNPL = new clsDinhMuc_ChiTiet_DM_NPL();
                clschitietDMNPL.iID_DinhMuc_NPL = iiID_DinhMucNPL;
                DataTable dtchitietDMNPL = clschitietDMNPL.Select_W_ID_DinhMuc_NPL_khoDaiLy();
                for (int i = 0; i < dtchitietDMNPL.Rows.Count; i++)
                {
                    double dongiaxxx333 = Convert.ToDouble(dtchitietDMNPL.Rows[i]["DonGia"].ToString());
                    DataRow _ravi3 = dt2.NewRow();
                    _ravi3["ID_VTHH"] = Convert.ToInt16(dtchitietDMNPL.Rows[i]["ID_VTHH"].ToString());
                    _ravi3["MaVT"] = dtchitietDMNPL.Rows[i]["MaVT"].ToString();
                    _ravi3["TenVTHH"] = dtchitietDMNPL.Rows[i]["TenVTHH"].ToString();
                    _ravi3["DonViTinh"] = dtchitietDMNPL.Rows[i]["DonViTinh"].ToString();
                    _ravi3["SoLuongTon"] = Convert.ToDouble(dtchitietDMNPL.Rows[i]["SoLuongTon"].ToString());
                    string xxsoluong = dtchitietDMNPL.Rows[i]["SoLuong"].ToString();
                    var xxdinhmuc = Math.Round(double.Parse(xxsoluong), 3);
                    _ravi3["DinhMuc"] = xxdinhmuc;
                    _ravi3["SoLuongTheoDinhMuc"] = xxdinhmuc * iisoluongxuat;
                    _ravi3["SoLuong"] = xxdinhmuc * iisoluongxuat;
                    _ravi3["DonGia"] = dongiaxxx333;// lay kho NPL
                                                    // _ravi3["GhiChu"] = "";
                    _ravi3["HienThi"] = "1";
                    _ravi3["ThanhTien"] = xxdinhmuc * iisoluongxuat * dongiaxxx333;
                    _ravi3["BoolVTChinh"] = false;

                    dt2.Rows.Add(_ravi3);

                }
                gridControl1.DataSource = dt2;

                double deTOngtien;

                string shienthi = "1";
                object xxxx = dt2.Compute("sum(ThanhTien)", "HienThi=" + shienthi + "");
                if (xxxx.ToString() != "")
                    deTOngtien = Convert.ToDouble(xxxx);
                else deTOngtien = 0;
                txtTongTienHang.Text = deTOngtien.ToString();

            }
            else
            {
                gridControl1.DataSource = null;
                return;
            }


        }      

        public KhoNPL_frmChiTietXuatKhoDaiLyGiaCong()
        {
            InitializeComponent();
        }

        private void gridMaCaTruong_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridMaCN_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void KhoNPL_frmChiTietXuatKhoDaiLyGiaCong_Load(object sender, EventArgs e)
        {
           
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

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
                object xxxx = dt2.Compute("sum(ThanhTien)", "HienThi=" + shienthi + "");
                if (xxxx.ToString() != "")
                    deTOngtien = Convert.ToDouble(xxxx);
                else deTOngtien = 0;
                txtTongTienHang.Text = deTOngtien.ToString();
            }
        }

        private void txtTienNo_TextAlignChanged(object sender, EventArgs e)
        {

        }

        //private void txtTienNo_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        decimal value = decimal.Parse(txtTienNo.Text);
        //        txtTienNo.Text = String.Format("{0:#,##0.00}", value);

        //    }
        //    catch
        //    {

        //    }
        //}

        //private void txtTienCo_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        decimal value = decimal.Parse(txtTienCo.Text);
        //        txtTienCo.Text = String.Format("{0:#,##0.00}", value);
        //    }
        //    catch
        //    {

        //    }
        //}

        private void btLuuVaNhapKho_Click(object sender, EventArgs e)
        {
            Luu_XuatKho_NPL_Va_taiKhoanKeToan();
        }

        //private void checkTienNo_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkTienNo.Checked == true)
        //    {
        //        txtTienNo.Text = txtTongTienHang.Text;
        //        txtTienCo.Text = txtTongTienHang.Text;
        //    }

        //    if (checkTienNo.Checked == false)
        //    {
        //        txtTienNo.Text = "0";
        //        txtTienCo.Text = "0";
        //    }
        //}

        private void dteNgayChungTuNPL_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuongXuat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSoLuongXuat.Text.ToString() != "" & txtSoKien1Bao.Text.ToString() != "")
                {
                    double soluongxuat = Convert.ToDouble(txtSoLuongXuat.Text.ToString());
                    double sokien1baoxxx = Convert.ToDouble(txtSoKien1Bao.Text.ToString());

                    txtSoLuongThanhPhamQuyDoi.Text = (soluongxuat * sokien1baoxxx).ToString();

                }
                HienThi_GridControl_Moiiiiiiiiiiii();


            }
            catch
            {

            }
        }

        private void gridMaDinhMucDot_EditValueChanged(object sender, EventArgs e)
        {
            clsDinhMuc_tbDinhMuc_DOT clsncc = new clsDinhMuc_tbDinhMuc_DOT();
            string manccc = gridMaDinhMucDot.SelectedText.ToString();
            clsncc.iID_DinhMuc_Dot = Convert.ToInt16(gridMaDinhMucDot.EditValue.ToString());
            DataTable dt = clsncc.SelectOne();
            if (dt.Rows.Count > 0)
            {
                txtSoKG1Bao.Text = dt.Rows[0]["SoKG_MotBao"].ToString();
                txtSoKien1Bao.Text = dt.Rows[0]["SoKienMotBao"].ToString();

            }
        }

        private void txtSoKien1Bao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSoLuongXuat.Text.ToString() != "" & txtSoKien1Bao.Text.ToString() != "")
                {
                    double soluongxuat = Convert.ToDouble(txtSoLuongXuat.Text.ToString());
                    double sokien1baoxxx = Convert.ToDouble(txtSoKien1Bao.Text.ToString());
                    txtSoLuongThanhPhamQuyDoi.Text = (soluongxuat * sokien1baoxxx).ToString();

                }
            }
            catch
            {

            }
        }

        private void gridMaDinhMucNPL_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsDinhMuc_tbDM_NguyenPhuLieu clsncc = new clsDinhMuc_tbDM_NguyenPhuLieu();

                clsncc.iID_DinhMuc_NPL = Convert.ToInt16(gridMaDinhMucNPL.EditValue.ToString());
                miID_DinhMucNPL_XXx = Convert.ToInt16(gridMaDinhMucNPL.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {                    
                    HienThi_GridControl_Moiiiiiiiiiiii();
                }

            }
            catch
            {

            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            //mbPrint_Chitiet_Da_XuatKho_DaiLyGiaCong = true;
          
            //DataTable DatatableABC = (DataTable)gridControl1.DataSource;
            //CriteriaOperator op = gridView1.ActiveFilterCriteria; // filterControl1.FilterCriteria
            //string filterString = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(op);
            //DataView dv1212 = new DataView(DatatableABC);
            //dv1212.RowFilter = filterString;
            //DataTable dttttt2 = dv1212.ToTable();
            //string shienthi = "1";
            //dttttt2.DefaultView.RowFilter = "HienThi=" + shienthi + "";
            //DataView dv = dttttt2.DefaultView;
            //mdt_ChiTietNhapKho = dv.ToTable();

            //mdaNgayNhapKho = dteNgayChungTuNPL.DateTime;
            //msSoChungTu_NhapKho = txtSoChungTuNhapKhoNPL.Text.ToString();
            //clsKhoNPL_tbNhapKho cls1 = new clsKhoNPL_tbNhapKho();
            //cls1.iID_NhapKho = UC_KhoNVL_frmDaNhapKho.miD_NhapKho;
            //DataTable dt1 = cls1.SelectOne();
            //string sochungtumuahang = cls1.sThamChieu.Value;
            //clsMH_tbMuaHang cls2 = new clsMH_tbMuaHang();
            //cls2.sSoChungTu = sochungtumuahang;
            //DataTable dt2 = cls2.SelectOne_W_SoChungTu();
            //msSoChungTu_MuaHang = sochungtumuahang;
            //msThuKho = txtNguoNhap.Text.ToString();
            //mdaNgayMuaHang = Convert.ToDateTime(dt2.Rows[0]["NgayChungTu"].ToString());
            //int iID_NguoiMua = Convert.ToInt32(dt2.Rows[0]["ID_NguoiMua"].ToString());
            //clsNhanSu_tbNhanSu cls3 = new clsNhanSu_tbNhanSu();
            //cls3.iID_NhanSu = iID_NguoiMua;
            //DataTable dt3 = cls3.SelectOne();
            //msNguoiMuaHang = cls3.sTenNhanVien.Value;
            //frmPrint_NhapKho_KhoNPL ff = new frmPrint_NhapKho_KhoNPL();
            //ff.Show();
        }

        private void KhoNPL_frmChiTietXuatKhoDaiLyGiaCong_FormClosed(object sender, FormClosedEventArgs e)
        {
            //mbPrint_Chitiet_Da_XuatKho_DaiLyGiaCong = false;
        }
    }
}
