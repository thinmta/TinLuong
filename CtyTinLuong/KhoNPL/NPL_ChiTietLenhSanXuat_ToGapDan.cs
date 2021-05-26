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
    public partial class NPL_ChiTietLenhSanXuat_ToGapDan : Form

    {
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
            //else if (gridTKCo.EditValue == null)
            //{
            //    MessageBox.Show("Chưa chọn TK có");
            //    return false;
            //}
            //else if (gridTKNo.EditValue == null)
            //{
            //    MessageBox.Show("Chưa chọn TK nợ");
            //    return false;
            //}

            else return true;

        }        
        private void Luu_XuatKho_NPL()
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
                cls1.sThamChieu = txtLenhSX.Text.ToString();
                cls1.bTonTai = true;
                cls1.bNgungTheoDoi = false;
                cls1.bDaXuatKho = true;
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
                dttttt2.DefaultView.RowFilter = "HienThi=" + shienthi + "";
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

                /// Update trang thai nhap lenh san xuất
                clsHUU_LenhSanXuat_ToGapDan clsxxx = new CtyTinLuong.clsHUU_LenhSanXuat_ToGapDan();
                clsxxx.iID_LenhSanXuat = UCNPL_XuatKhoTheoLSXToGapDan.mID_iD_LenhSanXuat;
                clsxxx.Update_TrangThaiXuatKho_VatTuPhu();


                // luu bien dong tai khoan ke toán
                //if(gridTKCo.EditValue != null & gridTKNo.EditValue != null)
                //{
                //    clsNganHang_ChiTietBienDongTaiKhoanKeToan cls = new CtyTinLuong.clsNganHang_ChiTietBienDongTaiKhoanKeToan();
                //    cls.iID_TaiKhoanKeToanCon = Convert.ToInt16(gridTKNo.EditValue.ToString());
                //    clsNganHang_TaiKhoanKeToanCon clscon = new clsNganHang_TaiKhoanKeToanCon();
                //    clscon.iID_TaiKhoanKeToanCon = Convert.ToInt16(gridTKNo.EditValue.ToString());
                //    DataTable dtcon = clscon.SelectOne();
                //    cls.iID_TaiKhoanKeToanMe = clscon.iID_TaiKhoanKeToanMe.Value;
                //    cls.iID_ChungTu = iiiiIDID_XuatKhoNPL;
                //    cls.sSoChungTu = txtSoChungTu.Text.ToString();
                //    cls.daNgayThang = dteNgayChungTuNPL.DateTime;
                //    cls.fCo = 0;
                //    cls.fNo = Convert.ToDouble(txtTienNo.Text.ToString());
                //    cls.bNgungTheoDoi = false;
                //    cls.bTonTai = true;
                //    cls.fTiGia = 1;
                //    cls.bTienUSD = false;
                //    cls.bBoolTK_No = true;
                //    cls.bBoolTK_Co = false;
                //    cls.bBoolTKVAT = false;
                //    cls.Insert();
                //    // Có
                //    cls.iID_TaiKhoanKeToanCon = Convert.ToInt16(gridTKCo.EditValue.ToString());
                //    clsNganHang_TaiKhoanKeToanCon clscon2 = new clsNganHang_TaiKhoanKeToanCon();
                //    clscon2.iID_TaiKhoanKeToanCon = Convert.ToInt16(gridTKCo.EditValue.ToString());
                //    DataTable dtcon2 = clscon2.SelectOne();
                //    cls.iID_TaiKhoanKeToanMe = clscon2.iID_TaiKhoanKeToanMe.Value;
                //    cls.iID_ChungTu = iiiiIDID_XuatKhoNPL;
                //    cls.sSoChungTu = txtSoChungTu.Text.ToString();
                //    cls.daNgayThang = dteNgayChungTuNPL.DateTime;
                //    cls.fCo = Convert.ToDouble(txtTienCo.Text.ToString());
                //    cls.fNo = 0;
                //    cls.bNgungTheoDoi = false;
                //    cls.bTonTai = true;
                //    cls.fTiGia = 1;
                //    cls.bTienUSD = false;
                //    cls.bBoolTK_No = false;
                //    cls.bBoolTK_Co = true;
                //    cls.bBoolTKVAT = false;
                //    cls.Insert();
                //}
                
                MessageBox.Show("Đã xuất kho");
                this.Close();
            }
        }
       
        private void Load_lockUP_EDIT()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=8";
            DataView dvCaTruong = dtNguoi.DefaultView;
            DataTable newdtCaTruong = dvCaTruong.ToTable();

            gridMaCaTruong.Properties.DataSource = newdtCaTruong;
            gridMaCaTruong.Properties.ValueMember = "ID_NhanSu";
            gridMaCaTruong.Properties.DisplayMember = "MaNhanVien";


            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=5";
            DataView dvnguoilap = dtNguoi.DefaultView;
            DataTable newdtnguoilap = dvnguoilap.ToTable();

            gridNguoiLap.Properties.DataSource = newdtnguoilap;
            gridNguoiLap.Properties.ValueMember = "ID_NhanSu";
            gridNguoiLap.Properties.DisplayMember = "MaNhanVien";

            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_ChucVu=3";
            DataView dvcongnhan = dtNguoi.DefaultView;
            DataTable newdvcongnhan = dvcongnhan.ToTable();

            gridMaCN.Properties.DataSource = newdvcongnhan;
            gridMaCN.Properties.ValueMember = "ID_NhanSu";
            gridMaCN.Properties.DisplayMember = "MaNhanVien";

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


        }
        private void HienThi_SUa_LenhSanXuat()
        {
            gridNguoiLap.EditValue = 14;
            clsHUU_LenhSanXuat_ChiTietLenhSanXuat_ToGapDan cls2 = new clsHUU_LenhSanXuat_ChiTietLenhSanXuat_ToGapDan();
            cls2.iID_LenhSanXuat = UCNPL_XuatKhoTheoLSXToGapDan.mID_iD_LenhSanXuat;
            DataTable dtxxx3 = cls2.SelectAll_w_iID_LenhSanXuat();
            if (Convert.ToBoolean(dtxxx3.Rows[0]["TrangThai_XuatKho_VatTuPhu"].ToString()) == true)
            {
                btXuatKho.Enabled = false;
            }
            dtxxx3.DefaultView.RowFilter = "boolVatTuChinh=False and GuiDuLieu = True";
            DataView dv = dtxxx3.DefaultView;           
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
            gridControl1.DataSource = dt2;

            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                int ID_VTHH = Convert.ToInt32(dt3.Rows[i]["ID_VTHH"].ToString());
                clsTbVatTuHangHoa clsvt = new clsTbVatTuHangHoa();
                clsvt.iID_VTHH = ID_VTHH;
                DataTable dtvt = clsvt.SelectOne();
                double xxsoluong = Convert.ToDouble(dt3.Rows[i]["SoLuong"].ToString());
                double xxdongia = Convert.ToDouble(dt3.Rows[i]["DonGia"].ToString());
                DataRow _ravi = dt2.NewRow();
                _ravi["ID_ChiTietLenhSanXuat"] = dt3.Rows[i]["ID_ChiTietLenhSanXuat"].ToString();
                _ravi["ID_LenhSanXuat"] = dt3.Rows[i]["ID_LenhSanXuat"].ToString();
                _ravi["ID_VTHH"] = dt3.Rows[i]["ID_VTHH"].ToString();
                _ravi["SoLuong"] = xxsoluong;
                _ravi["DonGia"] = xxdongia;
                _ravi["MaVT"] = clsvt.sMaVT.Value;
                _ravi["TenVTHH"] = clsvt.sTenVTHH.Value;
                _ravi["DonViTinh"] = clsvt.sDonViTinh.Value;
                _ravi["ThanhTien"] = Convert.ToDouble(dt3.Rows[i]["ThanhTien"].ToString());
                _ravi["GhiChu"] = dt3.Rows[i]["GhiChu"].ToString();
                _ravi["boolVatTuChinh"] = Convert.ToBoolean(dt3.Rows[i]["boolVatTuChinh"].ToString());
                _ravi["HienThi"] = "1";
                dt2.Rows.Add(_ravi);
            }

            gridControl1.DataSource = dt2;         

            double deTOngtien;
        
            string shienthi = "1";
            object xxxx = dt2.Compute("sum(ThanhTien)", "HienThi=" + shienthi + "");
            if (xxxx.ToString() != "")
                deTOngtien = Convert.ToDouble(xxxx);
            else deTOngtien = 0;
            txtTongTienHang.Text = deTOngtien.ToString();


            clsHUU_LenhSanXuat_ToGapDan cls = new clsHUU_LenhSanXuat_ToGapDan();
            cls.iID_LenhSanXuat = UCNPL_XuatKhoTheoLSXToGapDan.mID_iD_LenhSanXuat;
            DataTable dt = cls.SelectOne();

            txtLenhSX.Text = cls.sMaLenhSanXuat.Value.ToString();
            dteNgaySX.EditValue = cls.daNgayThangSanXuat.Value;
            cbCaSX.Text = cls.sCaSanXuat.Value.ToString();
            //checkNgungTheoDoi.Checked = cls.bNgungTheoDoi.Value;
            gridMaCaTruong.EditValue = cls.iID_CaTruong.Value;
            gridMaCN.EditValue = cls.iID_CongNhan.Value;            
            txtGhiChu.Text = cls.sGhiChu.Value.ToString();            
            dteNgayChungTuNPL.DateTime = DateTime.Today;
        }        
        
        public NPL_ChiTietLenhSanXuat_ToGapDan()
        {
            InitializeComponent();
        }

        private void NPL_ChiTietLenhSanXuat_ToGapDan_Load(object sender, EventArgs e)
        {
            
            
            Load_lockUP_EDIT();
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
            gridControl1.DataSource = dt2;
            HienThi_SUa_LenhSanXuat();

            clsKhoNPL_tbXuatKho cls1 = new clsKhoNPL_tbXuatKho();
            DataTable dt1 = cls1.SelectAll();
            dt1.DefaultView.RowFilter = " TonTai= True and NgungTheoDoi=false";
            DataView dv = dt1.DefaultView;
            DataTable dv3 = dv.ToTable();
            int k = dv3.Rows.Count;
            if (k == 0)
            {
                txtSoChungTu.Text = "XKNPL 1";
            }
            else
            {
                string xxx = dt1.Rows[k - 1]["SoChungTu"].ToString();
                int xxx2 = Convert.ToInt16(xxx.Substring(5).Trim()) + 1;
                if(xxx2>=10000)
                    txtSoChungTu.Text = "XKNPL 1";
               else  txtSoChungTu.Text = "XKNPL " + xxx2.ToString() + "";
            }
        }

        private void btThoat2222_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView4_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gridMaCaTruong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                int iiiIDiID_CaTruong = Convert.ToInt16(gridMaCaTruong.EditValue.ToString());
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
                clsncc.iID_NhanSu = Convert.ToInt16(gridMaCN.EditValue.ToString());

                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenCN.Text = dt.Rows[0]["TenNhanVien"].ToString();
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
                clsncc.iID_NhanSu = Convert.ToInt16(gridNguoiLap.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtNguoiXuatKho.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }
            }
            catch
            {

            }
        }

        private void gridView4_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            double fffsoluong = 0;
            double ffdongia = 0;
            double fffthanhtien = 0;

            if (e.Column == clSoLuong)
            {
                if (gridView4.GetFocusedRowCellValue(clDonGia).ToString() == "")
                    ffdongia = 0;
                else
                    ffdongia = Convert.ToDouble(gridView4.GetFocusedRowCellValue(clDonGia));
               
                fffthanhtien = fffsoluong * ffdongia;
                gridView4.SetFocusedRowCellValue(clThanhTien, fffthanhtien);
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

       

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void btXuatKho_Click(object sender, EventArgs e)
        {
            Luu_XuatKho_NPL();
        }
    }
}
