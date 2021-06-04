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
    public partial class DaiLy_FrmChiTiet_XuatKho_GapDan : Form
    {
        private void HienThi_GridControl_Moiiiiiiiiiiii(double soluongxuatxxx)
        {

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
            //cls.iID_NhapKho = Convert.ToInt32(gridThamChieu.EditValue.ToString());

            DataTable dtchitiet1 = cls.SelectAll_W_ID_NhapKho();
            //  dtchitiet1.DefaultView.RowFilter = "Check_VatTu_Phu = True";
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
                clsdm.iID_DinhMuc_ToGapDan = Convert.ToInt32(dtchitietnhapkho.Rows[i]["ID_DinhMuc_ToGapDan"].ToString());
                clsdm.iID_VTHH = ID_VTHHxx;
                DataTable dtdm = clsdm.SelectOne_W_ID_DinhMuc_ToGapDan_AND_ID_VTHH();

                double xxsoluongdinhmuc = Convert.ToDouble(dtdm.Rows[0]["SoLuong"].ToString());
                //var xxdinhmuc = Math.Round(double.Parse(xxsoluong), 3);

                DataRow _ravi3 = dt2.NewRow();
                _ravi3["ID_VTHH"] = ID_VTHHxx;
                _ravi3["MaVT"] = ID_VTHHxx;
                _ravi3["DinhMuc"] = xxsoluongdinhmuc;
                _ravi3["SoLuongTheoDinhMuc"] = xxsoluongdinhmuc * soluongxuatxxx;
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
            //double deTOngtien;
            //string shienthi = "1";
            //object xxxx = dt2.Compute("sum(ThanhTien)", "HienThi=" + shienthi + " and Check_VatTu_Phu = True");
            //if (xxxx.ToString() != "")
            //    deTOngtien = Convert.ToDouble(xxxx);
            //else deTOngtien = 0;
            //txtTongTienHang.Text = deTOngtien.ToString();

        }
        public static DateTime mdaPrintNgayXuatKho;
        public static DataTable mdtPrint_ChiTietXuatKho;
        public static string msPrintSoChungTu, msPrintDienGiaig, msPrintThuKho, msPrintNguoiNhan, msPrintNguoiLap;
        private void HienThi_ThemMoi_XuatKho()
        {
            checkNhapKhoThanhPham.Checked = true;
            checkNhapKho_banThanhPham.Checked = false;
            gridNguoiLap.EditValue = 11;
            //txtSoLuongXuat.Text = "1";
            dteNgayChungTu.EditValue = DateTime.Today;
            clsGapDan_tbXuatKho cls3 = new clsGapDan_tbXuatKho();
            DataTable dt1 = cls3.SelectAll();
            dt1.DefaultView.RowFilter = " TonTai= True and NgungTheoDoi=false";
            DataView dv = dt1.DefaultView;
            DataTable dv3 = dv.ToTable();
            int k = dv3.Rows.Count;
            if (k == 0)
                txtSoChungTu.Text = "XKGD 1";
            else
            {
                string xxx = dv3.Rows[k - 1]["SoChungTu"].ToString();
                int xxx2 = Convert.ToInt32(xxx.Substring(4).Trim()) + 1;             
                 txtSoChungTu.Text = "XKGD " + xxx2 + "";

            }
           
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

            DataTable dt22xx = new DataTable();
            dt22xx.Columns.Add("ID_XuatKhoGapDan", typeof(int));            
            dt22xx.Columns.Add("ID_VTHH", typeof(int));
            dt22xx.Columns.Add("ID_DinhMuc_ToGapDan", typeof(int));
            dt22xx.Columns.Add("TenVTHH", typeof(string));
            dt22xx.Columns.Add("DonViTinh", typeof(string));
            dt22xx.Columns.Add("MaDinhMuc");           
            dt22xx.Columns.Add("SoLuongXuat", typeof(double));
            dt22xx.Columns.Add("TiLe", typeof(double));
            dt22xx.Columns.Add("DonGia", typeof(double));
            dt22xx.Columns.Add("GhiChu", typeof(string));
            dt22xx.Columns.Add("HienThi", typeof(string));
            dt22xx.Columns.Add("ThanhTien", typeof(double));
            gridControl2.DataSource = dt22xx;


        }
        private void HienThi_Sua_XuatKho()
        {

            clsGapDan_tbXuatKho cls1 = new clsGapDan_tbXuatKho();
            cls1.iID_XuatKho = UCDaiLy_XuatKho_GapDan.miID_XuatKho_GapDan;
            DataTable dt22222 = cls1.SelectOne();
            txtSoChungTu.Text = cls1.sSoChungTu.Value;
            //txtThamChieu.Text = cls1.sThamChieu.Value;
            //txtSoLuongXuat.Text = cls1.fSoLuongThanhPham_QuyDoi.Value.ToString();
            //gridDinhMucGapDan.EditValue = cls1.iID_DinhMuc_ToGapDan.Value;
            //txtDonGiaThanhPhamQuyDoi.Text = cls1.fDonGia_ThanhPham_QuyDoi.Value.ToString();
            //txtTongTienHang.Text = cls1.fTongTienHang.Value.ToString();
            if (cls1.bDaXuatKho == true)
            {
                //btLuu_Gui_Dong.Enabled = false;
                dteNgayChungTu.EditValue = cls1.daNgayChungTu.Value;
                gridNguoiLap.EditValue = cls1.iID_NguoiNhap.Value;
            }
            else
            {
                dteNgayChungTu.EditValue = DateTime.Today;
                gridNguoiLap.EditValue = 11;
            }

            //double iisoluongxuat = Convert.ToDouble(txtSoLuongXuat.Text.ToString());
            double iisoluongxuat = 1;
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

            clsGapDan_ChiTiet_XuatKho cls = new CtyTinLuong.clsGapDan_ChiTiet_XuatKho();
            cls.iID_XuatKho = UCDaiLy_XuatKho_GapDan.miID_XuatKho_GapDan;

            DataTable dtchitiet1 = cls.SelectAll_ID_XuatKho();
            //  dtchitiet1.DefaultView.RowFilter = "Check_VatTu_Phu = True";
            DataView dv2 = dtchitiet1.DefaultView;
            DataTable dtchitietnhapkho = dv2.ToTable();
            for (int i = 0; i < dtchitietnhapkho.Rows.Count; i++)
            {
                double SoLuong = Convert.ToDouble(dtchitietnhapkho.Rows[i]["SoLuongXuat"].ToString());
                double dongiaxxx333 = Convert.ToDouble(dtchitietnhapkho.Rows[i]["DonGia"].ToString());
                int ID_VTHHxx = Convert.ToInt32(dtchitietnhapkho.Rows[i]["ID_VTHH"].ToString());
                clsTbVatTuHangHoa clvthh = new clsTbVatTuHangHoa();
                clvthh.iID_VTHH = ID_VTHHxx;
                DataTable dtvth = clvthh.SelectOne();
                clsKhoNPL_tbChiTietNhapKho xcls = new clsKhoNPL_tbChiTietNhapKho();
                xcls.iID_VTHH = ID_VTHHxx;
                DataTable dtbtp = xcls.Select_W_ID_VTHH();
                clsDinhMuc_ChiTiet_DinhMuc_ToGapDan clsdm = new CtyTinLuong.clsDinhMuc_ChiTiet_DinhMuc_ToGapDan();
                //clsdm.iID_DinhMuc_ToGapDan = Convert.ToInt32(gridDinhMucGapDan.EditValue.ToString());
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

            clsTbVatTuHangHoa cls = new clsTbVatTuHangHoa();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv2 = dt.DefaultView;
            DataTable dtxx2 = dv2.ToTable();

            gridMaVT.DataSource = dtxx2;
            gridMaVT.ValueMember = "ID_VTHH";
            gridMaVT.DisplayMember = "MaVT";

            clsDinhMuc_DinhMuc_ToGapDan clsdinhmucnpl = new clsDinhMuc_DinhMuc_ToGapDan();
            DataTable dt2 = clsdinhmucnpl.SelectAll();
            dt2.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvnpl = dt2.DefaultView;
            DataTable newdtnpl = dvnpl.ToTable();

           

            gridDinhMucGapDan.DataSource = newdtnpl;
            gridDinhMucGapDan.ValueMember = "ID_DinhMuc_ToGapDan";
            gridDinhMucGapDan.DisplayMember = "MaDinhMuc";
            //ID_DinhMuc_ToGapDan
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
        private bool Luu_Va_Gui_DuLieu()
        {
            if (!KiemTraLuu()) return false;
            else
            {
                clsGapDan_tbXuatKho cls1 = new clsGapDan_tbXuatKho();
                cls1.iID_XuatKho = UCDaiLy_XuatKho_GapDan.miID_XuatKho_GapDan;
                cls1.daNgayChungTu = dteNgayChungTu.DateTime;
                cls1.sSoChungTu = txtSoChungTu.Text.ToString();
                cls1.sDienGiai = txtDienGiai.Text.ToString();
                //cls1.iID_VTHH_ThanhPham_QuyDoi = Convert.ToInt32(txtID_ThanhPham.Text.ToString());
                //cls1.fDonGia_ThanhPham_QuyDoi = Convert.ToDouble(txtDonGiaThanhPhamQuyDoi.Text.ToString());
                //cls1.fSoLuongThanhPham_QuyDoi = Convert.ToDouble(txtSoLuongXuat.Text.ToString());
                //cls1.fTongTienHang = Convert.ToDouble(txtTongTienHang.Text.ToString());
                //cls1.iID_NguoiNhap = Convert.ToInt32(gridNguoiLap.EditValue.ToString());
                //cls1.sThamChieu = gridThamChieu.Text.ToString();
                //cls1.iID_DinhMuc_ToGapDan = Convert.ToInt32(gridDinhMucGapDan.EditValue.ToString());              
                cls1.bDaXuatKho = true;              
                cls1.bTonTai = true;
                cls1.bNgungTheoDoi = false;
                cls1.bTrangThaiNhapKhoBTP_ThanhPham = false;
                cls1.Insert();
                int III_ID_XuatKho = cls1.iID_XuatKho.Value;

                clsGapDan_ChiTiet_XuatKho cls2 = new clsGapDan_ChiTiet_XuatKho();
                string shienthi = "1";
                DataTable dtkkk = (DataTable)gridControl1.DataSource;
                dtkkk.DefaultView.RowFilter = "HienThi=" + shienthi + "";
                DataView dv2232xx = dtkkk.DefaultView;
                DataTable dttttt2 = dv2232xx.ToTable();


                // xuất kho Thành pham quy doi
                cls2.iID_XuatKho = III_ID_XuatKho;
                cls2.iID_VTHH = Convert.ToInt32(txtID_ThanhPham.Text.ToString());
                cls2.fSoLuongXuat = Convert.ToDouble(dttttt2.Rows[0]["SoLuong"].ToString());   
                //if (txtDonGiaThanhPhamQuyDoi.Text.ToString() == "")
                //    cls2.fDonGia = 0;
                //else cls2.fDonGia = Convert.ToDouble(txtDonGiaThanhPhamQuyDoi.Text.ToString());
                cls2.sGhiChu = "";
                cls2.bTonTai = true;
                cls2.bNgungTheoDoi = false;
                cls2.bDaXuatKho = true;              
                cls2.bCheck_ThanhPham = true;
                cls2.bCheck_VatTu_Chinh = false;
                cls2.bCheck_VatTu_Phu = false;
                cls2.Insert();

                clsGapDan_ChiTiet_NhapKho clschitietnhapkho = new CtyTinLuong.clsGapDan_ChiTiet_NhapKho();
                clschitietnhapkho.iID_VTHH = Convert.ToInt32(dttttt2.Rows[0]["ID_VTHH"].ToString());
                //clschitietnhapkho.iID_NhapKho = Convert.ToInt32(gridThamChieu.EditValue.ToString());                
                DataTable dt2 = clschitietnhapkho.SelectOne_W_ID_NhapKho_W_ID_VTHH();
                double soluongxuat = Convert.ToDouble(dttttt2.Rows[0]["SoLuong"].ToString());          
                Double douSoLuongTonCu_ThanhPham;
                douSoLuongTonCu_ThanhPham = Convert.ToDouble(dt2.Rows[0]["SoLuongTon"].ToString());
                clschitietnhapkho.iID_ChiTietNhapKho = Convert.ToInt32(dt2.Rows[0]["ID_ChiTietNhapKho"].ToString());
                clschitietnhapkho.fSoLuongTon = douSoLuongTonCu_ThanhPham - soluongxuat;
                clschitietnhapkho.Update_SoLuongTon();

                // xuất kho Vật tư chính
                cls2.iID_XuatKho = III_ID_XuatKho;
                cls2.iID_VTHH = Convert.ToInt32(dttttt2.Rows[1]["ID_VTHH"].ToString());
                cls2.fSoLuongXuat = Convert.ToDouble(dttttt2.Rows[1]["SoLuong"].ToString());            
                //if (txtDonGiaThanhPhamQuyDoi.Text.ToString() == "")
                //    cls2.fDonGia = 0;
                //else cls2.fDonGia = Convert.ToDouble(dttttt2.Rows[1]["DonGia"].ToString());
                cls2.sGhiChu = "";
                cls2.bTonTai = true;
                cls2.bNgungTheoDoi = false;
                cls2.bDaXuatKho = true;
              
                cls2.bCheck_ThanhPham = false;
                cls2.bCheck_VatTu_Chinh = true;
                cls2.bCheck_VatTu_Phu = false;
                cls2.Insert();

                clschitietnhapkho.iID_VTHH = Convert.ToInt32(dttttt2.Rows[1]["ID_VTHH"].ToString());
                //clschitietnhapkho.iID_NhapKho = Convert.ToInt32(gridThamChieu.EditValue.ToString());
                DataTable dt222 = clschitietnhapkho.SelectOne_W_ID_NhapKho_W_ID_VTHH();
                double soluongxuat222 = Convert.ToDouble(dttttt2.Rows[1]["SoLuong"].ToString());
                Double douSoLuongTonCu_VatTuChinh;
                douSoLuongTonCu_VatTuChinh = Convert.ToDouble(dt222.Rows[0]["SoLuongTon"].ToString());
                clschitietnhapkho.iID_ChiTietNhapKho = Convert.ToInt32(dt222.Rows[0]["ID_ChiTietNhapKho"].ToString());
                clschitietnhapkho.fSoLuongTon = douSoLuongTonCu_VatTuChinh - soluongxuat222;
                clschitietnhapkho.Update_SoLuongTon();

                for (int i =2; i < dttttt2.Rows.Count; i++)
                {
                    cls2.iID_XuatKho = III_ID_XuatKho;
                    cls2.iID_VTHH = Convert.ToInt32(dttttt2.Rows[i]["ID_VTHH"].ToString());
                    cls2.fSoLuongXuat = Convert.ToDouble(dttttt2.Rows[i]["SoLuong"].ToString());                   
                    if (dttttt2.Rows[i]["DonGia"].ToString() == "")
                        cls2.fDonGia = 0;
                    else cls2.fDonGia = Convert.ToDouble(dttttt2.Rows[i]["DonGia"].ToString());
                    cls2.sGhiChu = dttttt2.Rows[i]["GhiChu"].ToString();
                    cls2.bTonTai = true;
                    cls2.bDaXuatKho = true;
                    cls2.bNgungTheoDoi = false;                  
                    cls2.bCheck_ThanhPham = false;
                    cls2.bCheck_VatTu_Chinh = false;
                    cls2.bCheck_VatTu_Phu = true;
                    cls2.Insert();

                    clschitietnhapkho.iID_VTHH = Convert.ToInt32(dttttt2.Rows[i]["ID_VTHH"].ToString());
                    //clschitietnhapkho.iID_NhapKho = Convert.ToInt32(gridThamChieu.EditValue.ToString());
                    DataTable dt22xxxx2 = clschitietnhapkho.SelectOne_W_ID_NhapKho_W_ID_VTHH();
                    double soluongxuat222moii = Convert.ToDouble(dttttt2.Rows[i]["SoLuong"].ToString());
                    Double douSoLuongTonCu_VatTu_Phu;
                    douSoLuongTonCu_VatTu_Phu = Convert.ToDouble(dt22xxxx2.Rows[0]["SoLuongTon"].ToString());
                    clschitietnhapkho.iID_ChiTietNhapKho = Convert.ToInt32(dt22xxxx2.Rows[0]["ID_ChiTietNhapKho"].ToString());
                    clschitietnhapkho.fSoLuongTon = douSoLuongTonCu_VatTu_Phu - soluongxuat222moii;
                    clschitietnhapkho.Update_SoLuongTon();

                }

                return true;

            }


        }

        public DaiLy_FrmChiTiet_XuatKho_GapDan()
        {
            InitializeComponent();
        }

        private void DaiLy_FrmChiTiet_XuatKho_GapDan_Load(object sender, EventArgs e)
        {
            Load_LockUp();
            if (UCDaiLy_XuatKho_GapDan.mbthemmoi == true)
                HienThi_ThemMoi_XuatKho();
            else HienThi_Sua_XuatKho();
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT2)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {

            gridControl1.DataSource = null;
            DataTable dt2 = new DataTable();

            dt2.Columns.Add("ID_VTHH", typeof(string));
            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("TenVTHH", typeof(string));
            dt2.Columns.Add("DonViTinh", typeof(string));
            dt2.Columns.Add("SoLuong", typeof(double));
            dt2.Columns.Add("DonGia", typeof(double));
            dt2.Columns.Add("GhiChu", typeof(string));
            dt2.Columns.Add("HienThi", typeof(string));
            dt2.Columns.Add("ThanhTien", typeof(double));

            dt2.Columns.Add("Check_ThanhPham", typeof(bool));
            dt2.Columns.Add("Check_VatTu_Chinh", typeof(bool));
            dt2.Columns.Add("Check_VatTu_Phu", typeof(bool));

            DataTable new_Table = new DataTable();



            string shienthi = "1";
            DataTable dtkkk = (DataTable)gridControl2.DataSource;
            dtkkk.DefaultView.RowFilter = "HienThi=" + shienthi + "";
            DataView dv2232xx = dtkkk.DefaultView;
            DataTable dt = dv2232xx.ToTable();          
            clsDinhMuc_ChiTiet_DinhMuc_ToGapDan cls = new CtyTinLuong.clsDinhMuc_ChiTiet_DinhMuc_ToGapDan();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                double soluongxuat= Convert.ToDouble(dt.Rows[i]["SoLuongXuat"].ToString());
                int ID_DinhMuc_ToGapDan = Convert.ToInt32(dt.Rows[i]["ID_DinhMuc_ToGapDan"].ToString());
                cls.iID_DinhMuc_ToGapDan = ID_DinhMuc_ToGapDan;
                DataTable dtmnoi = cls.SelectAll_W_ID_DinhMuc_ToGapDan();
                for (int j = 0; j < dtmnoi.Rows.Count; j++)
                {
                    DataRow _ravi2 = dt2.NewRow();                   
                    _ravi2["ID_VTHH"] = dtmnoi.Rows[j]["ID_VTHH"].ToString();
                    _ravi2["MaVT"] = dtmnoi.Rows[j]["ID_VTHH"].ToString();
                    _ravi2["TenVTHH"] = dtmnoi.Rows[j]["TenVTHH"].ToString();
                    _ravi2["DonViTinh"] = dtmnoi.Rows[j]["DonViTinh"].ToString();
                    _ravi2["SoLuong"] = soluongxuat* Convert.ToDouble(dtmnoi.Rows[j]["SoLuong"].ToString());
                  //  _ravi2["DonGia"] = Convert.ToDouble(dtmnoi.Rows[j]["DonGia"].ToString());
                    _ravi2["HienThi"] = "1";
                   // _ravi2["ThanhTien"] = soluongxuat* Convert.ToDouble(dtmnoi.Rows[j]["SoLuong"].ToString()) * Convert.ToDouble(dtmnoi.Rows[j]["DonGia"].ToString());
                    _ravi2["Check_ThanhPham"] = Convert.ToBoolean(dtmnoi.Rows[j]["Check_ThanhPham"].ToString());
                    _ravi2["Check_VatTu_Chinh"] = Convert.ToBoolean(dtmnoi.Rows[j]["Check_VatTu_Chinh"].ToString());
                    _ravi2["Check_VatTu_Phu"] = Convert.ToBoolean(dtmnoi.Rows[j]["Check_VatTu_Phu"].ToString());
                    dt2.Rows.Add(_ravi2);

                }

            }

         
            new_Table.Columns.Add("ID_VTHH", typeof(string));
            new_Table.Columns.Add("MaVT", typeof(string));
            new_Table.Columns.Add("TenVTHH", typeof(string));
            new_Table.Columns.Add("DonViTinh", typeof(string));
            new_Table.Columns.Add("SoLuong", typeof(double));
            new_Table.Columns.Add("DonGia", typeof(double));
            new_Table.Columns.Add("GhiChu", typeof(string));
            new_Table.Columns.Add("HienThi", typeof(string));
            new_Table.Columns.Add("HienThi2", typeof(string));
            new_Table.Columns.Add("ThanhTien", typeof(double));
            new_Table.Columns.Add("NhapKho_TP_1_BTP_2_NPL_3", typeof(string));
            new_Table.Columns.Add("MaKho", typeof(string));
            //new_Table.Columns.Add("Check_ThanhPham", typeof(bool));
            //new_Table.Columns.Add("Check_VatTu_Chinh", typeof(bool));
            //new_Table.Columns.Add("Check_VatTu_Phu", typeof(bool));

            var groupedByState = dt2.AsEnumerable()
                .GroupBy(r => r.Field<String>("ID_VTHH"));
            foreach (var group in groupedByState)
            {
                DataRow maxPremRow = group.OrderByDescending(r => r.Field<String>("ID_VTHH")).First();
                DataRow newRow = new_Table.Rows.Add();

                newRow.SetField("ID_VTHH", maxPremRow.Field<string>("ID_VTHH"));
                newRow.SetField("SoLuong", group.Sum(r => r.Field<double?>("SoLuong")));
                newRow.SetField("MaVT", maxPremRow.Field<string>("ID_VTHH"));
                newRow.SetField("TenVTHH", maxPremRow.Field<string>("TenVTHH"));
                newRow.SetField("DonViTinh", maxPremRow.Field<string>("DonViTinh"));
                newRow.SetField("GhiChu", "");
                newRow.SetField("DonGia", 0);
                newRow.SetField("ThanhTien", 0);
                newRow.SetField("HienThi", "1");
                newRow.SetField("HienThi2", "0");
                newRow.SetField("NhapKho_TP_1_BTP_2_NPL_3", "");
                newRow.SetField("MaKho", "");
                //newRow.SetField("Check_ThanhPham", maxPremRow.Field<string>("Check_ThanhPham"));
                //newRow.SetField("Check_VatTu_Chinh", maxPremRow.Field<string>("Check_VatTu_Chinh"));
                //newRow.SetField("Check_VatTu_Phu", maxPremRow.Field<string>("Check_VatTu_Phu"));
            }
            gridControl1.DataSource = new_Table;
        }

        private void gridView4_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            double fffsoluong = 0;
            double ffdongia = 0;
            double fffthanhtien = 0;
            if (e.Column == clMaDinhMuc1)
            {
                clsDinhMuc_ChiTiet_DinhMuc_ToGapDan cls = new clsDinhMuc_ChiTiet_DinhMuc_ToGapDan();
             
              int ID_DinhMuc_ToGapDanxxx= Convert.ToInt32(gridView4.GetRowCellValue(e.RowHandle, e.Column));
                cls.iID_DinhMuc_ToGapDan = ID_DinhMuc_ToGapDanxxx;
                DataTable dt = cls.SelectAll_W_ID_DinhMuc_ToGapDan();
                dt.DefaultView.RowFilter = " Check_ThanhPham = True";
                DataView dv = dt.DefaultView;
                DataTable dt22 = dv.ToTable();

                int iiiID_ThanhPham = Convert.ToInt32(dt22.Rows[0]["ID_VTHH"].ToString());
                clsTbVatTuHangHoa clsvt = new clsTbVatTuHangHoa();
                clsvt.iID_VTHH = iiiID_ThanhPham;
                DataTable dtvt = clsvt.SelectOne();          
               
                gridView4.SetRowCellValue(e.RowHandle, clTenVTHH1, clsvt.sTenVTHH.Value);
                gridView4.SetRowCellValue(e.RowHandle, clDonViTinh1, clsvt.sDonViTinh.Value);
                //gridView4.SetRowCellValue(e.RowHandle, clMaDinhMuc1, clsvt.sMaVT.Value);
                gridView4.SetRowCellValue(e.RowHandle, clHienThi1, "1");

                gridView4.SetRowCellValue(e.RowHandle, clSoLuongXuat1, 0);               
                gridView4.SetRowCellValue(e.RowHandle, clDonGia1, 0);
                gridView4.SetRowCellValue(e.RowHandle, clThanhTien1, 0);
                gridView4.SetRowCellValue(e.RowHandle, clID_VTHH1, iiiID_ThanhPham);
                gridView4.SetRowCellValue(e.RowHandle, clID_DinhMuc_ToGapDan1, ID_DinhMuc_ToGapDanxxx);

            }
            try
            {
                if (e.Column == clSoLuongXuat1)
                {
                  
                
                    if (gridView4.GetFocusedRowCellValue(clSoLuongXuat1).ToString() == "")
                        fffsoluong = 0;
                    else
                        fffsoluong = Convert.ToDouble(gridView4.GetFocusedRowCellValue(clSoLuongXuat1));                   

                    if (gridView4.GetFocusedRowCellValue(clDonGia1).ToString() == "")
                        ffdongia = 0;
                    else
                        ffdongia = Convert.ToDouble(gridView4.GetFocusedRowCellValue(clDonGia1));
                   
                    fffthanhtien = fffsoluong * ffdongia;
                    gridView4.SetFocusedRowCellValue(clThanhTien1, fffthanhtien);
                }
                if (e.Column == clDonGia1)
                {

                    if (gridView4.GetFocusedRowCellValue(clSoLuongXuat1).ToString() == "")
                        fffsoluong = 0;
                    else
                        fffsoluong = Convert.ToDouble(gridView4.GetFocusedRowCellValue(clSoLuongXuat1));


                    if (gridView4.GetFocusedRowCellValue(clDonGia1).ToString() == "")
                        ffdongia = 0;
                    else
                        ffdongia = Convert.ToDouble(gridView4.GetFocusedRowCellValue(clDonGia1));

                    fffthanhtien = fffsoluong * ffdongia;
                    gridView4.SetFocusedRowCellValue(clThanhTien1, fffthanhtien);

                }
            }
            catch
            {

            }
        }

        private void gridView4_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT1)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void btXoa1_Click(object sender, EventArgs e)
        {
            gridView4.SetRowCellValue(gridView4.FocusedRowHandle, clHienThi1, "0");
            gridView4.SetRowCellValue(gridView4.FocusedRowHandle, clSoLuongXuat1, 0);
        }

        private void gridView4_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            GridView view = sender as GridView;
            DataView dv = view.DataSource as DataView;
            if (dv[e.ListSourceRow]["HienThi"].ToString().Trim() == "0")
            {
                e.Visible = false;
                e.Handled = true;
            }
        }

      

        private void gridView1_CustomDrawCell_1(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT2)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView1_CustomRowFilter_1(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            GridView view = sender as GridView;
            DataView dv = view.DataSource as DataView;
            if (dv[e.ListSourceRow]["HienThi"].ToString().Trim() == "0")
            {
                e.Visible = false;
                e.Handled = true;
            }
        }

        private void btXoaGrid2_Click(object sender, EventArgs e)
        {

            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, clHienThi1, "0");
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, clSoLuongXuat1, 0);
        }

        private void gridView1_CellValueChanged_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == clMaVT2)
            {
                clsTbVatTuHangHoa cls = new clsTbVatTuHangHoa();
                cls.iID_VTHH = Convert.ToInt16(gridView1.GetRowCellValue(e.RowHandle, e.Column));
                int kk = Convert.ToInt16(gridView1.GetRowCellValue(e.RowHandle, e.Column));
                DataTable dt = cls.SelectOne();
                if (dt != null)
                {
                    gridView1.SetRowCellValue(e.RowHandle, clID_VTHH2, kk);
                    gridView1.SetRowCellValue(e.RowHandle, clTenVTHH2, dt.Rows[0]["TenVTHH"].ToString());
                    gridView1.SetRowCellValue(e.RowHandle, clDonViTinh2, dt.Rows[0]["DonViTinh"].ToString());
                    gridView1.SetRowCellValue(e.RowHandle, clHienThi2, "1");
                    gridView1.SetRowCellValue(e.RowHandle, clSoLuong2, 0);
                    gridView1.SetRowCellValue(e.RowHandle, clDonGia2, 0);


                }
            }

            if (e.Column == clNhapKho_TP_1_BTP_2_NPL_3_22222)
            {
                if (gridView1.GetFocusedRowCellValue(clNhapKho_TP_1_BTP_2_NPL_3_22222).ToString() != "")
                    gridView1.SetRowCellValue(e.RowHandle, clHienThi2222, "1");

                if (gridView1.GetFocusedRowCellValue(clNhapKho_TP_1_BTP_2_NPL_3_22222).ToString() == "Kho TP")
                    gridView1.SetRowCellValue(e.RowHandle, clMaKho, "1");
                else if (gridView1.GetFocusedRowCellValue(clNhapKho_TP_1_BTP_2_NPL_3_22222).ToString() == "Kho BTP")
                    gridView1.SetRowCellValue(e.RowHandle, clMaKho, "2");
                else if (gridView1.GetFocusedRowCellValue(clNhapKho_TP_1_BTP_2_NPL_3_22222).ToString() == "Kho NPL")
                    gridView1.SetRowCellValue(e.RowHandle, clMaKho, "3");
                else gridView1.SetRowCellValue(e.RowHandle, clMaKho, "");

            }

            try
            {
                double fffsoluong = 0;
                double ffdongia = 0;
                double fffthanhtien = 0;
                if (e.Column == clSoLuong2)
                {

                    if (gridView1.GetFocusedRowCellValue(clDonGia2).ToString() == "")
                        ffdongia = 0;
                    else
                        ffdongia = Convert.ToDouble(gridView1.GetFocusedRowCellValue(clDonGia2));
                    if (gridView1.GetFocusedRowCellValue(clSoLuong2).ToString() == "")
                        fffsoluong = 0;
                    fffsoluong = Convert.ToDouble(gridView1.GetFocusedRowCellValue(clSoLuong2));
                    fffthanhtien = fffsoluong * ffdongia;
                    gridView1.SetFocusedRowCellValue(clThanhTien2, fffthanhtien);
                }
                if (e.Column == clDonGia2)
                {
                    if (gridView4.GetFocusedRowCellValue(clDonGia2).ToString() == "")
                        ffdongia = 0;
                    else
                        ffdongia = Convert.ToDouble(gridView4.GetFocusedRowCellValue(clDonGia2));
                    if (gridView4.GetFocusedRowCellValue(clSoLuong2).ToString() == "")
                        fffsoluong = 0;
                    else
                        fffsoluong = Convert.ToDouble(gridView4.GetFocusedRowCellValue(clSoLuong2));
                    fffthanhtien = fffsoluong * ffdongia;
                    gridView4.SetFocusedRowCellValue(clThanhTien2, fffthanhtien);

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

   

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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

    
     
    }
}
