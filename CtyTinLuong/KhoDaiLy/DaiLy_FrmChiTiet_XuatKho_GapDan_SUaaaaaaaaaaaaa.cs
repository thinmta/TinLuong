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
    public partial class DaiLy_FrmChiTiet_XuatKho_GapDan_SUaaaaaaaaaaaaa : Form
    {
        private void HienThi_Sua_XuatKho()
        {

            clsGapDan_tbXuatKho cls1 = new clsGapDan_tbXuatKho();
            cls1.iID_XuatKho = UCDaiLy_XuatKho_GapDan.miID_XuatKho_GapDan;
            DataTable dt22222 = cls1.SelectOne();
            txtSoChungTu.Text = cls1.sSoChungTu.Value;
            txtThamChieu.Text = cls1.sThamChieu.Value;
            txtSoLuongXuat.Text = cls1.fSoLuongThanhPham_QuyDoi.Value.ToString();
            gridDinhMucGapDan.EditValue = cls1.iID_DinhMuc_ToGapDan.Value;
            txtDonGiaThanhPhamQuyDoi.Text = cls1.fDonGia_ThanhPham_QuyDoi.Value.ToString();
            txtTongTienHang.Text = cls1.fTongTienHang.Value.ToString();
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
                clsdm.iID_DinhMuc_ToGapDan = Convert.ToInt32(gridDinhMucGapDan.EditValue.ToString());
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
                cls1.iID_VTHH_ThanhPham_QuyDoi = Convert.ToInt32(txtID_ThanhPham.Text.ToString());
                cls1.fDonGia_ThanhPham_QuyDoi = Convert.ToDouble(txtDonGiaThanhPhamQuyDoi.Text.ToString());
                cls1.fSoLuongThanhPham_QuyDoi = Convert.ToDouble(txtSoLuongXuat.Text.ToString());
                cls1.fTongTienHang = Convert.ToDouble(txtTongTienHang.Text.ToString());
                cls1.iID_NguoiNhap = Convert.ToInt32(gridNguoiLap.EditValue.ToString());
                cls1.sThamChieu = txtThamChieu.Text.ToString();
                cls1.iID_DinhMuc_ToGapDan = Convert.ToInt32(gridDinhMucGapDan.EditValue.ToString());
                //cls1.bBool_TonDauKy = false;
                cls1.bDaXuatKho = true;
                //cls1.bTrangThai_XuatKho_BTP = true;
                //cls1.bTrangThai_NhapKho_GapDan = true;
                //cls1.bDaNhapKho = true;
                cls1.bTonTai = true;
                cls1.bNgungTheoDoi = false;
                cls1.Insert();
                int III_ID_XuatKho = cls1.iID_XuatKho.Value;

                clsGapDan_ChiTiet_XuatKho cls2 = new clsGapDan_ChiTiet_XuatKho();
                string shienthi = "1";
                DataTable dtkkk = (DataTable)gridControl1.DataSource;
                dtkkk.DefaultView.RowFilter = "HienThi=" + shienthi + "";
                DataView dv2232xx = dtkkk.DefaultView;
                DataTable dttttt2 = dv2232xx.ToTable();


                // Nhap kho Thành pham quy doi
                cls2.iID_XuatKho = III_ID_XuatKho;
                cls2.iID_VTHH = Convert.ToInt32(txtID_ThanhPham.Text.ToString());
                cls2.fSoLuongXuat = Convert.ToDouble(txtSoLuongXuat.Text.ToString());
                if (txtDonGiaThanhPhamQuyDoi.Text.ToString() == "")
                    cls2.fDonGia = 0;
                else cls2.fDonGia = Convert.ToDouble(txtDonGiaThanhPhamQuyDoi.Text.ToString());
                cls2.sGhiChu = dttttt2.Rows[0]["GhiChu"].ToString();
                cls2.bTonTai = true;
                cls2.bNgungTheoDoi = false;
                cls2.bDaXuatKho = true;
                cls2.bCheck_ThanhPham = true;
                cls2.bCheck_VatTu_Chinh = false;
                cls2.bCheck_VatTu_Phu = false;
                cls2.Insert();

                // Nhap kho Vật tư chính
                cls2.iID_XuatKho = III_ID_XuatKho;
                cls2.iID_VTHH = Convert.ToInt32(dttttt2.Rows[1]["ID_VTHH"].ToString());
                cls2.fSoLuongXuat = Convert.ToDouble(dttttt2.Rows[1]["SoLuong"].ToString());
                if (txtDonGiaThanhPhamQuyDoi.Text.ToString() == "")
                    cls2.fDonGia = 0;
                else cls2.fDonGia = Convert.ToDouble(dttttt2.Rows[1]["DonGia"].ToString());
                cls2.sGhiChu = dttttt2.Rows[1]["GhiChu"].ToString();
                cls2.bTonTai = true;
                cls2.bNgungTheoDoi = false;
                cls2.bDaXuatKho = true;

                cls2.bCheck_ThanhPham = false;
                cls2.bCheck_VatTu_Chinh = true;
                cls2.bCheck_VatTu_Phu = false;
                cls2.Insert();
                for (int i = 2; i < dttttt2.Rows.Count; i++)
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
                }

                return true;

            }

        }
        public DaiLy_FrmChiTiet_XuatKho_GapDan_SUaaaaaaaaaaaaa()
        {
            InitializeComponent();
        }

        private void DaiLy_FrmChiTiet_XuatKho_GapDan_SUaaaaaaaaaaaaa_Load(object sender, EventArgs e)
        {
            Load_LockUp();
            HienThi_Sua_XuatKho();
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
                //txtMaTPQuyDoi.Text = dt22.Rows[0]["MaVT"].ToString();
                //txtTenThanhPhamQuyDoi.Text = dt22.Rows[0]["TenVTHH"].ToString();
                //txtDVTThanhPhamQuyDoi.Text = dt22.Rows[0]["DonViTinh"].ToString();

                //DataTable dt322 = dt.Copy();
                //dt322.DefaultView.RowFilter = " Check_VatTu_Chinh = True";
                //DataView dv2 = dt322.DefaultView;
                //DataTable dt223 = dv2.ToTable();
                //txtID_VatTuChinh.Text = dt223.Rows[0]["ID_VTHH"].ToString();
                //txtMaVTChinh.Text = dt223.Rows[0]["MaVT"].ToString();
                //txtTenVatTu_Chinh.Text = dt223.Rows[0]["TenVTHH"].ToString();

                //txtDVT_VT_CHinh.Text = dt223.Rows[0]["DonViTinh"].ToString();

                //double SoLuong_VTChinh_DinhMuc = Convert.ToDouble(dt223.Rows[0]["SoLuong"].ToString());
                //txtSoLuongVTChinh.Text = (SoLuong_VTChinh_DinhMuc * xxsoluongxuat).ToString();
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

        private void txtDonGiaThanhPhamQuyDoi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double soluongxuat = Convert.ToDouble(txtSoLuongXuat.Text.ToString());
                double dongia = Convert.ToDouble(txtDonGiaThanhPhamQuyDoi.Text.ToString());
                txtTongTienHang.Text = (soluongxuat * dongia).ToString();
            }
            catch
            {

            }
        }

        private void txtSoLuongXuat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSoLuongXuat.Text.ToString() != "" & gridDinhMucGapDan.EditValue.ToString() != "")
                {
                    clsDinhMuc_ChiTiet_DinhMuc_ToGapDan cls = new CtyTinLuong.clsDinhMuc_ChiTiet_DinhMuc_ToGapDan();
                    cls.iID_DinhMuc_ToGapDan = Convert.ToInt32(gridDinhMucGapDan.EditValue.ToString());
                    DataTable dt = cls.SelectAll_W_ID_DinhMuc_ToGapDan();
                    double xxsoluongxuat = Convert.ToDouble(txtSoLuongXuat.Text.ToString());                   


                }

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
    }
}
