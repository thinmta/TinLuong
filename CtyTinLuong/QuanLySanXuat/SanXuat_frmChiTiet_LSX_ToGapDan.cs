using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace CtyTinLuong
{
    public partial class SanXuat_frmChiTiet_LSX_ToGapDan : Form
    {
        private bool KiemTraLuu()
        {
            DataTable dttttt2 = (DataTable)gridControl1.DataSource;

            if (txtLenhSX.Text.ToString() == "")
            {
                MessageBox.Show("Chưa có mã lệnh");
                return false;
            }
            else if (checkNhapKhoThanhPham.Checked == false & checkNhapKhoBTP.Checked == false )
            {
                MessageBox.Show("Chọn kho để nhập");
                return false;
            }
            else if (checkNhapKhoThanhPham.Checked.ToString() == "" & checkNhapKhoBTP.Checked.ToString() == "")
            {
                MessageBox.Show("Chọn kho để nhập");
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
            else if (gridVatTuCHinh.EditValue == null)
            {
                MessageBox.Show("Chưa chọn vật tư chính");
                return false;
            }
            else if (dttttt2.Rows.Count == 0)
            {
                MessageBox.Show("Dữ liệu trống");
                return false;
            }
            else if (gridThanhPham.EditValue == null)
            {
                MessageBox.Show("chưa có mã thành phẩm");
                return false;
            }
            if (txtSanLuong.Text.ToString() == "" || Convert.ToDouble(txtSanLuong.Text.ToString())==0)
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

                clsHUU_LenhSanXuat_ToGapDan cls1 = new clsHUU_LenhSanXuat_ToGapDan();
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
                cls1.bNhapKhoBTP = checkNhapKhoBTP.Checked;
                cls1.iID_DinhMuc_Luong_SanLuong = Convert.ToInt32(gridDinhMucSLMay_IN.EditValue.ToString());
                cls1.Insert();
                int miID_LenhSX = cls1.iID_LenhSanXuat.Value;
                clsHUU_LenhSanXuat_ChiTietLenhSanXuat_ToGapDan cls = new clsHUU_LenhSanXuat_ChiTietLenhSanXuat_ToGapDan();
                string shienthi = "1";
                DataTable dttttt2 = (DataTable)gridControl1.DataSource;
                dttttt2.DefaultView.RowFilter = "HienThi=" + shienthi + "";
                DataView dv = dttttt2.DefaultView;
                DataTable dv3 = dv.ToTable();

                // Vật tư chính
                cls.iID_LenhSanXuat = miID_LenhSX;
                cls.iID_VTHH = Convert.ToInt32(gridVatTuCHinh.EditValue.ToString());
                cls.fSoLuong = Convert.ToDouble(txtSoLuongVatTuChinh.Text.ToString());

                cls.fDonGia = Convert.ToDouble(txtDonGiaVatTuChinh.Text.ToString());
                cls.fThanhTien = Convert.ToDouble(txtThanhTienVatTuChinh.Text.ToString());
                cls.sGhiChu = "VT Chính";
                cls.bBoolVatTuChinh = true;
                cls.bTonTai = true;
                cls.bNgungTheoDoi = false;
                cls.Insert();


                for (int i = 0; i < dv3.Rows.Count; i++)
                {

                    cls.iID_LenhSanXuat = miID_LenhSX;
                    cls.iID_VTHH = Convert.ToInt32(dv3.Rows[i]["ID_VTHH"].ToString());
                    cls.fSoLuong = Convert.ToDouble(dv3.Rows[i]["SoLuong"].ToString());

                    cls.fDonGia = Convert.ToDouble(dv3.Rows[i]["DonGia"].ToString());
                    cls.fThanhTien = Convert.ToDouble(dv3.Rows[i]["ThanhTien"].ToString());
                    cls.sGhiChu = dv3.Rows[i]["GhiChu"].ToString();
                    cls.bBoolVatTuChinh = false;
                    cls.bTonTai = true;
                    cls.bNgungTheoDoi = false;
                    cls.Insert();

                }

                MessageBox.Show("Đã lưu");
                this.Close();
            }
        }
        private void Luu_ThemMoi_LenhSanXuat_va_GuiDuLuu()
        {
            if (!KiemTraLuu()) return;
            else
            {

                clsHUU_LenhSanXuat_ToGapDan cls1 = new clsHUU_LenhSanXuat_ToGapDan();
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
                cls1.bNhapKhoBTP = checkNhapKhoBTP.Checked;
                cls1.iID_DinhMuc_Luong_SanLuong = Convert.ToInt32(gridDinhMucSLMay_IN.EditValue.ToString());
                cls1.Insert();
                int miID_LenhSX = cls1.iID_LenhSanXuat.Value;
                clsHUU_LenhSanXuat_ChiTietLenhSanXuat_ToGapDan cls = new clsHUU_LenhSanXuat_ChiTietLenhSanXuat_ToGapDan();
                string shienthi = "1";
                DataTable dttttt2 = (DataTable)gridControl1.DataSource;
                dttttt2.DefaultView.RowFilter = "HienThi=" + shienthi + "";
                DataView dv = dttttt2.DefaultView;
                DataTable dv3 = dv.ToTable();

                // Vật tư chính
                cls.iID_LenhSanXuat = miID_LenhSX;
                cls.iID_VTHH = Convert.ToInt32(gridVatTuCHinh.EditValue.ToString());
                cls.fSoLuong = Convert.ToDouble(txtSoLuongVatTuChinh.Text.ToString());

                cls.fDonGia = Convert.ToDouble(txtDonGiaVatTuChinh.Text.ToString());
                cls.fThanhTien = Convert.ToDouble(txtThanhTienVatTuChinh.Text.ToString());
                cls.sGhiChu = "VT Chính";
                cls.bBoolVatTuChinh = true;               
                cls.bTonTai = true;
                cls.bNgungTheoDoi = false;
                cls.Insert();


                for (int i = 0; i < dv3.Rows.Count; i++)
                {
                   
                    cls.iID_LenhSanXuat = miID_LenhSX;
                    cls.iID_VTHH = Convert.ToInt32(dv3.Rows[i]["ID_VTHH"].ToString());
                    cls.fSoLuong = Convert.ToDouble(dv3.Rows[i]["SoLuong"].ToString());               
                    
                    cls.fDonGia = Convert.ToDouble(dv3.Rows[i]["DonGia"].ToString());
                    cls.fThanhTien = Convert.ToDouble(dv3.Rows[i]["ThanhTien"].ToString());
                    cls.sGhiChu = dv3.Rows[i]["GhiChu"].ToString();
                    cls.bBoolVatTuChinh = false;
                    cls.bTonTai = true;
                    cls.bNgungTheoDoi = false;
                    cls.Insert();
                  
                }

                MessageBox.Show("Đã lưu");
                this.Close();
            }
        }
        private void HienThi_ThemMoi_LenhSX()
        {
            gridMaNguoiLap.EditValue = 12;
            clsHUU_LenhSanXuat_ToGapDan cls1 = new CtyTinLuong.clsHUU_LenhSanXuat_ToGapDan();
            DataTable dt1 = cls1.SelectAll();
            dt1.DefaultView.RowFilter = " TonTai= True and NgungTheoDoi=false";
            DataView dv = dt1.DefaultView;
            DataTable dv3 = dv.ToTable();
            int k = dv3.Rows.Count;

            if (dv3.Rows.Count == 0)
                txtLenhSX.Text = "LSXGD_1";
            else
            {
                string xxx = dt1.Rows[k - 1]["MaLenhSanXuat"].ToString();
                int xxx2 = Convert.ToInt32(xxx.Substring(6).Trim()) + 1;
                txtLenhSX.Text = "LSXGD_" + xxx2 + "";
            }
            dteNgaySX.EditValue = DateTime.Today;

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_ChiTietLenhSanXuat"); // ID của tbChi tiet don hàng
            dt2.Columns.Add("ID_LenhSanXuat");
            dt2.Columns.Add("ID_VTHH");
            dt2.Columns.Add("SoLuong", typeof(float));
            dt2.Columns.Add("DonGia", typeof(double));            //  
            dt2.Columns.Add("MaVT");// tb VTHH
            dt2.Columns.Add("TenVTHH");
            dt2.Columns.Add("DonViTinh");
            dt2.Columns.Add("boolVatTuChinh", typeof(bool));
            dt2.Columns.Add("ThanhTien", typeof(double));
            dt2.Columns.Add("HienThi", typeof(string));
            dt2.Columns.Add("GhiChu", typeof(string));
            dt2.Columns.Add("SoLuongTon", typeof(string));
            //SoLuongTon
            gridControl1.DataSource = dt2;


        }
        private void HienThi_Sua_LenhSX()
        {
           

            clsHUU_LenhSanXuat_ChiTietLenhSanXuat_ToGapDan cls2 = new clsHUU_LenhSanXuat_ChiTietLenhSanXuat_ToGapDan();
            cls2.iID_LenhSanXuat = UCSanXuat_LenhSanXuat_ToGapDan.mID_iD_LenhSanXuat;
            DataTable dtxxx = cls2.SelectAll_w_iID_LenhSanXuat();
            dtxxx.DefaultView.RowFilter = "boolVatTuChinh=False";
            DataView dv = dtxxx.DefaultView;           
            DataTable dt3 = dv.ToTable();

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_ChiTietLenhSanXuat"); // ID của tbChi tiet don hàng
            dt2.Columns.Add("ID_LenhSanXuat");
            dt2.Columns.Add("ID_VTHH");
            dt2.Columns.Add("SoLuong", typeof(float));
            dt2.Columns.Add("DonGia", typeof(double));            //  
            dt2.Columns.Add("MaVT");// tb VTHH
            dt2.Columns.Add("TenVTHH");
            dt2.Columns.Add("DonViTinh");
            dt2.Columns.Add("GhiChu", typeof(string));
            dt2.Columns.Add("boolVatTuChinh", typeof(bool));
            dt2.Columns.Add("ThanhTien", typeof(double));
            dt2.Columns.Add("HienThi", typeof(string));
            dt2.Columns.Add("SoLuongTon", typeof(string));
            gridControl1.DataSource = dt2;

            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                int ID_VTHH = Convert.ToInt32(dt3.Rows[i]["ID_VTHH"].ToString());
                clsTbVatTuHangHoa clsvt = new clsTbVatTuHangHoa();
                clsvt.iID_VTHH = ID_VTHH;
                DataTable dtvt = clsvt.SelectOne();
                double xxsoluong = Convert.ToDouble(dt3.Rows[i]["SoLuong"].ToString());
                double xxdongia = Convert.ToDouble(dt3.Rows[i]["DonGia"].ToString());
                clsKhoNPL_tbChiTietNhapKho clsnhapkho = new clsKhoNPL_tbChiTietNhapKho();
                clsnhapkho.iID_VTHH = ID_VTHH;
                DataTable dtnhapkho = clsnhapkho.Select_W_ID_VTHH();
              
                DataRow _ravi = dt2.NewRow();
                _ravi["ID_ChiTietLenhSanXuat"] = dt3.Rows[i]["ID_ChiTietLenhSanXuat"].ToString();
                _ravi["ID_LenhSanXuat"] = dt3.Rows[i]["ID_LenhSanXuat"].ToString();
                _ravi["ID_VTHH"] = dt3.Rows[i]["ID_VTHH"].ToString();
                _ravi["SoLuong"] = xxsoluong;
                if (dtnhapkho.Rows.Count > 0)
                    _ravi["SoLuongTon"] = dtnhapkho.Rows[0]["SoLuongTon"].ToString();
                else _ravi["SoLuongTon"] = 0;
                _ravi["DonGia"] = xxdongia;
                _ravi["MaVT"] = dt3.Rows[i]["ID_VTHH"].ToString();
                _ravi["TenVTHH"] = clsvt.sTenVTHH.Value;
                _ravi["DonViTinh"] = clsvt.sDonViTinh.Value;
                _ravi["ThanhTien"] = Convert.ToDouble(dt3.Rows[i]["ThanhTien"].ToString());
                _ravi["GhiChu"] = dt3.Rows[i]["GhiChu"].ToString();
               _ravi["boolVatTuChinh"] = Convert.ToBoolean(dt3.Rows[i]["boolVatTuChinh"].ToString());
                _ravi["HienThi"] = "1";
                dt2.Rows.Add(_ravi);
            }

            gridControl1.DataSource = dt2;

            clsHUU_LenhSanXuat_ToGapDan cls = new clsHUU_LenhSanXuat_ToGapDan();
            cls.iID_LenhSanXuat = UCSanXuat_LenhSanXuat_ToGapDan.mID_iD_LenhSanXuat;
            DataTable dt = cls.SelectOne();
            if (cls.bGuiDuLieu.Value == true)
            {
                btLuuu22222.Enabled = false;
                btChiLuu.Enabled = false;
            }
            else
            {
                btLuuu22222.Enabled = true;
                btChiLuu.Enabled = true;
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
            if (cls.bNhapKhoBTP == true) 
                checkNhapKhoBTP.Checked = true;
            else checkNhapKhoThanhPham.Checked = true;
            dtxxx.DefaultView.RowFilter = "boolVatTuChinh=True";
            DataView dv222 = dtxxx.DefaultView;
            DataTable dt2223 = dv222.ToTable();
            gridVatTuCHinh.EditValue = Convert.ToInt32(dt2223.Rows[0]["ID_VTHH"].ToString());
            txtSoLuongVatTuChinh.Text = dt2223.Rows[0]["SoLuong"].ToString();
            txtDonGiaVatTuChinh.Text = dt2223.Rows[0]["DonGia"].ToString();
            txtThanhTienVatTuChinh.Text = dt2223.Rows[0]["ThanhTien"].ToString();
           
            clsKhoBTP_tbChiTietNhapKho clsbtpxx = new clsKhoBTP_tbChiTietNhapKho();
            clsbtpxx.iID_VTHH = Convert.ToInt32(dt2223.Rows[0]["ID_VTHH"].ToString()); 
            DataTable dtbtp = clsbtpxx.Select_W_ID_VTHH();
            if (dtbtp.Rows.Count > 0)
                txtTonVatTuChinh.Text = dtbtp.Rows[0]["SoLuongTon"].ToString();
            else txtTonVatTuChinh.Text = "0";
        }

      
        private void Load_lockUP_EDIT()
        {
            clsKhoNPL_tbChiTietNhapKho clsvthhh = new clsKhoNPL_tbChiTietNhapKho();
            DataTable dtvthh = clsvthhh.SelectAll__W_Ten_MaVT_HangHoa();
            dtvthh.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvvthh = dtvthh.DefaultView;
            DataTable newdtvthh = dvvthh.ToTable();
            repositoryItemGridLookUpEdit1.DataSource = newdtvthh;
            repositoryItemGridLookUpEdit1.ValueMember = "ID_VTHH";
            repositoryItemGridLookUpEdit1.DisplayMember = "MaVT";

            clsTbVatTuHangHoa clsxx = new clsTbVatTuHangHoa();
            DataTable dtkksss = clsxx.SelectAll();
            dtkksss.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvcxxx = dtkksss.DefaultView;
            DataTable vdtrhh = dvcxxx.ToTable();

            gridThanhPham.Properties.DataSource = vdtrhh;
            gridThanhPham.Properties.ValueMember = "ID_VTHH";
            gridThanhPham.Properties.DisplayMember = "MaVT";

            clsKhoBTP_tbChiTietNhapKho clsbtp = new clsKhoBTP_tbChiTietNhapKho();
            DataTable dtkksssclsbtp = clsbtp.SelectAll_HienThi_ALL_ChiTietNhapKho();
            dtkksssclsbtp.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvcxxxclsbtp = dtkksssclsbtp.DefaultView;
            DataTable vdtrhhclsbtp = dvcxxxclsbtp.ToTable();

            gridVatTuCHinh.Properties.DataSource = vdtrhhclsbtp;
            gridVatTuCHinh.Properties.ValueMember = "ID_VTHH";
            gridVatTuCHinh.Properties.DisplayMember = "MaVT"; 


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
        public SanXuat_frmChiTiet_LSX_ToGapDan()
        {
            InitializeComponent();
        }

        private void SanXuat_frmChiTiet_LSX_ToGapDan_Load(object sender, EventArgs e)
        {
            //checkNhapKhoBTP.Checked = true;
            
            Load_lockUP_EDIT();
            if (UCSanXuat_LenhSanXuat_ToGapDan.mbThemMoi_LenhSX == true)
            {
                HienThi_ThemMoi_LenhSX();
            }
            else if (UCSanXuat_LenhSanXuat_ToGapDan.mbThemMoi_LenhSX == false)
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

        private void gridView4_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            double fffsoluong = 0;
            double ffdongia = 0;
            double fffthanhtien = 0;
            if (e.Column == clMaVT)
            {
                clsTbVatTuHangHoa cls = new clsTbVatTuHangHoa();
                cls.iID_VTHH = Convert.ToInt32(gridView4.GetRowCellValue(e.RowHandle, e.Column));
                int kk = Convert.ToInt32(gridView4.GetRowCellValue(e.RowHandle, e.Column));
                DataTable dt = cls.SelectOne();
                if (dt.Rows.Count>0)
                {
                    clsKhoNPL_tbChiTietNhapKho clsnhapkho = new clsKhoNPL_tbChiTietNhapKho();
                    clsnhapkho.iID_VTHH = kk;
                    DataTable dtnhapkho = clsnhapkho.Select_W_ID_VTHH();
                    gridView4.SetRowCellValue(e.RowHandle, clSoLuongTon, dtnhapkho.Rows[0]["SoLuongTon"].ToString());

                    gridView4.SetRowCellValue(e.RowHandle, clID_VTHH, kk);
                    gridView4.SetRowCellValue(e.RowHandle, clTenVTHH, dt.Rows[0]["TenVTHH"].ToString());
                    gridView4.SetRowCellValue(e.RowHandle, clDonViTinh, dt.Rows[0]["DonViTinh"].ToString());
                    gridView4.SetRowCellValue(e.RowHandle, clHienThi, "1");
                    gridView4.SetRowCellValue(e.RowHandle, clSoLuong, 0);
                    gridView4.SetRowCellValue(e.RowHandle, clDonGia, 0);
                    gridView4.SetRowCellValue(e.RowHandle, clbBoolVatTuChinh, false);
                    if (gridView4.GetFocusedRowCellValue(clDonGia).ToString() == "")
                        ffdongia = 0;
                    else
                        ffdongia = Convert.ToDouble(gridView4.GetFocusedRowCellValue(clDonGia));
                    if (gridView4.GetFocusedRowCellValue(clSoLuong).ToString() == "")
                        fffsoluong = 0;
                    else
                        fffsoluong = Convert.ToDouble(gridView4.GetFocusedRowCellValue(clSoLuong));
                    fffthanhtien = fffsoluong * ffdongia;
                    gridView4.SetFocusedRowCellValue(clThanhTien, fffthanhtien);
                }
            }

            if (e.Column == clSoLuong)
            {
                if (gridView4.GetFocusedRowCellValue(clDonGia).ToString() == "")
                    ffdongia = 0;
                else
                    ffdongia = Convert.ToDouble(gridView4.GetFocusedRowCellValue(clDonGia));
                if (gridView4.GetFocusedRowCellValue(clSoLuong).ToString() == "")
                    fffsoluong = 0;
                else
                    fffsoluong = Convert.ToDouble(gridView4.GetFocusedRowCellValue(clSoLuong));
                fffthanhtien = fffsoluong * ffdongia;
                gridView4.SetFocusedRowCellValue(clThanhTien, fffthanhtien);

                gridView4.SetRowCellValue(e.RowHandle, clbBoolVatTuChinh, false);
            }
            if (e.Column == clDonGia)
            {
                if (gridView4.GetFocusedRowCellValue(clDonGia).ToString() == "")
                    ffdongia = 0;
                else
                    ffdongia = Convert.ToDouble(gridView4.GetFocusedRowCellValue(clDonGia));
                if (gridView4.GetFocusedRowCellValue(clSoLuong).ToString() == "")
                    fffsoluong = 0;
                else
                    fffsoluong = Convert.ToDouble(gridView4.GetFocusedRowCellValue(clSoLuong));
                fffthanhtien = fffsoluong * ffdongia;
                gridView4.SetFocusedRowCellValue(clThanhTien, fffthanhtien);

                gridView4.SetRowCellValue(e.RowHandle, clbBoolVatTuChinh, false);
            }
            
        }

        private void gridView4_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
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

        private void btXoa2_Click(object sender, EventArgs e)
        {
            gridView4.SetRowCellValue(gridView4.FocusedRowHandle, clHienThi, "0");
            gridView4.SetRowCellValue(gridView4.FocusedRowHandle, clSoLuong, 0);
        }

        private void btLuuu22222_Click(object sender, EventArgs e)
        {
            Luu_ThemMoi_LenhSanXuat_va_GuiDuLuu();
        }

        private void txtDonGiaThanhTpham_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSanLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
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

        private void gridVatTuCHinh_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsKhoBTP_tbChiTietNhapKho clsncc = new clsKhoBTP_tbChiTietNhapKho();

                clsncc.iID_VTHH = Convert.ToInt32(gridVatTuCHinh.EditValue.ToString());
                DataTable dt = clsncc.Select_W_ID_VTHH_w_Ten_VTHH_KhoDaiLy();
                if (dt.Rows.Count > 0)
                {
                    txtVatTuChinh.Text = dt.Rows[0]["TenVTHH"].ToString();
                    txtDVTVatTuChinh.Text = dt.Rows[0]["DonViTinh"].ToString();
                    txtDonGiaVatTuChinh.Text = dt.Rows[0]["DonGia"].ToString();
                    txtTonVatTuChinh.Text = dt.Rows[0]["SoLuongTon"].ToString();
                }
            }
            catch
            {

            }
        }

        private void txtSoLuongVatTuChinh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDonGiaVatTuChinh.Text.ToString() != "" & txtSoLuongVatTuChinh.Text.ToString() != "")
                {
                    double dongia = Convert.ToDouble(txtDonGiaVatTuChinh.Text.ToString());
                    double soluong = Convert.ToDouble(txtSoLuongVatTuChinh.Text.ToString());
                    txtThanhTienVatTuChinh.Text = (dongia * soluong).ToString();
                }
            }
            catch
            {

            }
        }

        private void txtDonGiaVatTuChinh_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtThanhTienVatTuChinh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtThanhTienVatTuChinh.Text);
                txtThanhTienVatTuChinh.Text = String.Format("{0:#,##0.00}", value);
            }
            catch
            {

            }
        }

        private void checkNhapKhoBTP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNhapKhoBTP.Checked == true)
                checkNhapKhoThanhPham.Checked = false;
        }

        private void checkNhapKhoThanhPham_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNhapKhoThanhPham.Checked == true)
                checkNhapKhoBTP.Checked = false;
        }

        private void btChiLuu_Click(object sender, EventArgs e)
        {
            Luu_Chi_Luu_ThemMoi_LenhSanXuat();
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

        private void txtDonGiaVatTuChinh_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(txtDonGiaVatTuChinh.Text);
                txtDonGiaVatTuChinh.Text = String.Format("{0:#,##0.00}", value);
                if (txtDonGiaVatTuChinh.Text.ToString() != "" & txtSoLuongVatTuChinh.Text.ToString() != "")
                {
                    double dongia = Convert.ToDouble(txtDonGiaVatTuChinh.Text.ToString());
                    double soluong = Convert.ToDouble(txtSoLuongVatTuChinh.Text.ToString());
                    txtThanhTienVatTuChinh.Text = (dongia * soluong).ToString();
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
    }
}
