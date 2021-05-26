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
    public partial class KhoBTP_ChiTiet_NhapKho_Khac : Form
    {

        public static DateTime mdaNgayXuatKho_Print;
        public static DataTable mdt_ChiTietNhapKho_Print;
       
        public static string msSoChungTu_XuatKho_Print, msThuKho_Print;
        private bool KiemTraLuu()
        {

            string shienthi = "1";
            DataTable dttttt2 = (DataTable)gridControl1.DataSource;
            dttttt2.DefaultView.RowFilter = "HienThi=" + shienthi + "";
            DataView dv = dttttt2.DefaultView;
            DataTable dv3 = dv.ToTable();
            if (dv3.Rows.Count == 0)
            {
                MessageBox.Show("Chưa chọn hàng hóa ");
                return false;
            }
            else if (txtSoChungTu.Text.ToString() == "")
            {
                MessageBox.Show("Chưa có số CT ");
                return false;
            }

            else if (gridNguoiLap.EditValue == null)
            {
                MessageBox.Show("Chưa có người nhập kho ");
                return false;
            }
            else if (dteNgayChungTu.EditValue == null)
            {
                MessageBox.Show("Chưa chọn ngày chứng từ ");
                return false;
            }

            else return true;

        }
        private void Luu_ChiLuu()
        {
            if (!KiemTraLuu()) return;
            else
            {
                double tongtienhang;
                tongtienhang = Convert.ToDouble(txtTongTienHang.Text.ToString());
                clsKhoBTP_tbNhapKho cls1 = new clsKhoBTP_tbNhapKho();
                cls1.sDienGiai = txtDienGiai.Text.ToString();
                cls1.daNgayChungTu = dteNgayChungTu.DateTime;
                cls1.sSoChungTu = txtSoChungTu.Text.ToString();
                cls1.fTongTienHang = tongtienhang;
                cls1.iID_NguoiNhap = Convert.ToInt16(gridNguoiLap.EditValue.ToString());
                cls1.sThamChieu = "Khác";
                cls1.bTonTai = true;
                cls1.bDaNhapKho = false;
                cls1.bNgungTheoDoi = false;
                cls1.bCheck_NhapKho_Khac = true;
                cls1.bBool_TonDauKy = false;
                //if (gridTKCo.EditValue != null)
                //    cls1.iID_TKCo = Convert.ToInt16(gridTKCo.EditValue.ToString());
                //if (gridTKNo.EditValue != null)
                //    cls1.iID_TKNo = Convert.ToInt16(gridTKNo.EditValue.ToString());

                if (UCBanThanhPham_NhapKho_Khac.mbThemMoi_NhapKho == true)
                {
                    cls1.Insert();

                }
                else
                {
                    cls1.iID_NhapKhoBTP = UCBanThanhPham_NhapKho_Khac.miID_NhapKho_NPL;
                    cls1.Update();
                }

                // insert tbChiTietNhapKho
                // xoá trước
                clsKhoBTP_tbChiTietNhapKho clschitietNhapkho = new clsKhoBTP_tbChiTietNhapKho();
                if (UCBanThanhPham_NhapKho_Khac.mbThemMoi_NhapKho == false)
                {

                    clschitietNhapkho.iID_NhapKho = UCBanThanhPham_NhapKho_Khac.miID_NhapKho_NPL;
                    clschitietNhapkho.Delete_ALL_W_ID_NhapKho();
                }


                string shienthi = "1";

                DataTable dttttt2 = (DataTable)gridControl1.DataSource;
                dttttt2.DefaultView.RowFilter = "HienThi=" + shienthi + "";
                DataView dvmoi = dttttt2.DefaultView;
                DataTable dtmoi = dvmoi.ToTable();
                for (int i = 0; i < dtmoi.Rows.Count; i++)
                {
                    if (UCBanThanhPham_NhapKho_Khac.mbThemMoi_NhapKho == true)
                    {

                        clschitietNhapkho.iID_NhapKho = cls1.iID_NhapKhoBTP.Value;
                    }
                    else
                    {
                        clschitietNhapkho.iID_NhapKho = UCBanThanhPham_NhapKho_Khac.miID_NhapKho_NPL;
                    }
                    clschitietNhapkho.iID_VTHH = Convert.ToInt16(dtmoi.Rows[i]["ID_VTHH"].ToString());
                    clschitietNhapkho.fSoLuongNhap = Convert.ToDouble(dtmoi.Rows[i]["SoLuong"].ToString());
                    clschitietNhapkho.fSoLuongTon = Convert.ToDouble(dtmoi.Rows[i]["SoLuong"].ToString());
                    clschitietNhapkho.fDonGia = Convert.ToDouble(dtmoi.Rows[i]["DonGia"].ToString());
                    clschitietNhapkho.bTonTai = true;
                    clschitietNhapkho.bNgungTheoDoi = false;
                    clschitietNhapkho.bDaNhapKho = false;
                    clschitietNhapkho.sGhiChu = dtmoi.Rows[i]["GhiChu"].ToString();
                    clschitietNhapkho.bBoolTonDauKy = false;
                    clschitietNhapkho.Insert();

                }
                MessageBox.Show("Đã lưu");
            }
        }
        private void Luu_Va_XuatKho()
        {
            if (!KiemTraLuu()) return;
            else
            {
                double tongtienhang;
                tongtienhang = Convert.ToDouble(txtTongTienHang.Text.ToString());
                clsKhoBTP_tbNhapKho cls1 = new clsKhoBTP_tbNhapKho();
                cls1.sDienGiai = txtDienGiai.Text.ToString();
                cls1.daNgayChungTu = dteNgayChungTu.DateTime;
                cls1.sSoChungTu = txtSoChungTu.Text.ToString();
                cls1.fTongTienHang = tongtienhang;
                cls1.iID_NguoiNhap = Convert.ToInt16(gridNguoiLap.EditValue.ToString());
                cls1.sThamChieu = "Khác";
                cls1.bTonTai = true;
                cls1.bDaNhapKho = true;
                cls1.bNgungTheoDoi = false;
                cls1.bCheck_NhapKho_Khac = true;
                cls1.bBool_TonDauKy = false;
                //if (gridTKCo.EditValue != null)
                //    cls1.iID_TKCo = Convert.ToInt16(gridTKCo.EditValue.ToString());
                //if (gridTKNo.EditValue != null)
                //    cls1.iID_TKNo = Convert.ToInt16(gridTKNo.EditValue.ToString());

                if (UCBanThanhPham_NhapKho_Khac.mbThemMoi_NhapKho == true)
                {
                    cls1.Insert();

                }
                else
                {
                    cls1.iID_NhapKhoBTP = UCBanThanhPham_NhapKho_Khac.miID_NhapKho_NPL;
                    cls1.Update();
                }

                // insert tbChiTietNhapKho
                // xoá trước
                clsKhoBTP_tbChiTietNhapKho clschitietNhapkho = new clsKhoBTP_tbChiTietNhapKho();
                if (UCBanThanhPham_NhapKho_Khac.mbThemMoi_NhapKho == false)
                {

                    clschitietNhapkho.iID_NhapKho = UCBanThanhPham_NhapKho_Khac.miID_NhapKho_NPL;
                    clschitietNhapkho.Delete_ALL_W_ID_NhapKho();
                }


                string shienthi = "1";

                DataTable dttttt2 = (DataTable)gridControl1.DataSource;
                dttttt2.DefaultView.RowFilter = "HienThi=" + shienthi + "";
                DataView dvmoi = dttttt2.DefaultView;
                DataTable dtmoi = dvmoi.ToTable();
                for (int i = 0; i < dtmoi.Rows.Count; i++)
                {
                    if (UCBanThanhPham_NhapKho_Khac.mbThemMoi_NhapKho == true)
                    {

                        clschitietNhapkho.iID_NhapKho = cls1.iID_NhapKhoBTP.Value;
                    }
                    else
                    {
                        clschitietNhapkho.iID_NhapKho = UCBanThanhPham_NhapKho_Khac.miID_NhapKho_NPL;
                    }
                    clschitietNhapkho.iID_VTHH = Convert.ToInt16(dtmoi.Rows[i]["ID_VTHH"].ToString());
                    clschitietNhapkho.fSoLuongNhap = Convert.ToDouble(dtmoi.Rows[i]["SoLuong"].ToString());
                    clschitietNhapkho.fSoLuongTon = Convert.ToDouble(dtmoi.Rows[i]["SoLuong"].ToString());
                    clschitietNhapkho.fDonGia = Convert.ToDouble(dtmoi.Rows[i]["DonGia"].ToString());
                    clschitietNhapkho.bTonTai = true;
                    clschitietNhapkho.bNgungTheoDoi = false;
                    clschitietNhapkho.bDaNhapKho = true;
                    clschitietNhapkho.sGhiChu = dtmoi.Rows[i]["GhiChu"].ToString();
                    clschitietNhapkho.bBoolTonDauKy = false;
                    clschitietNhapkho.Insert();

                  

                }
                MessageBox.Show("Đã xuất kho");
            }
        }
        private void HienThi_Sua()
        {
            clsKhoBTP_tbNhapKho cls1 = new clsKhoBTP_tbNhapKho();
            cls1.iID_NhapKhoBTP = UCBanThanhPham_NhapKho_Khac.miID_NhapKho_NPL;
            DataTable dt = cls1.SelectOne();
            gridNguoiLap.EditValue = cls1.iID_NguoiNhap.Value;
            dteNgayChungTu.EditValue = cls1.daNgayChungTu.Value;
            txtSoChungTu.Text = cls1.sSoChungTu.Value;
            txtDienGiai.Text = cls1.sDienGiai.Value;
            if (cls1.bDaNhapKho == true)
            {
                btLuu_Copy.Enabled = false;
                btLuu_Dong.Enabled = false;
                btNhapKho_Copy.Enabled = false;
                btNhapKho_Dong.Enabled = false;
                gridView4.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
            clsKhoBTP_tbChiTietNhapKho cls2 = new clsKhoBTP_tbChiTietNhapKho();
            cls2.iID_NhapKho = UCBanThanhPham_NhapKho_Khac.miID_NhapKho_NPL;
            DataTable dtxx = cls2.SelectAll_W_ID_NhapKho();

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_VTHH");
            dt2.Columns.Add("SoLuong", typeof(float));
            dt2.Columns.Add("DonGia", typeof(double));
            dt2.Columns.Add("MaVT");// tb VTHH
            dt2.Columns.Add("TenVTHH");
            dt2.Columns.Add("DonViTinh");
            dt2.Columns.Add("ThanhTien", typeof(double));
            dt2.Columns.Add("HienThi", typeof(string));
            dt2.Columns.Add("GhiChu", typeof(string));
            for (int i = 0; i < dtxx.Rows.Count; i++)
            {
                double dongiaxxx333 = Convert.ToDouble(dtxx.Rows[i]["DonGia"].ToString());
                double SoLuongxxx333 = Convert.ToDouble(dtxx.Rows[i]["SoLuongNhap"].ToString());
                int ID_VTHHxxx = Convert.ToInt16(dtxx.Rows[i]["ID_VTHH"].ToString());
                clsTbVatTuHangHoa clsvt = new clsTbVatTuHangHoa();
                clsvt.iID_VTHH = ID_VTHHxxx;
                DataTable dtvt = clsvt.SelectOne();
                DataRow _ravi3 = dt2.NewRow();

                _ravi3["ID_VTHH"] = Convert.ToInt16(dtxx.Rows[i]["ID_VTHH"].ToString());
                _ravi3["MaVT"] = ID_VTHHxxx;
                _ravi3["TenVTHH"] = clsvt.sTenVTHH.Value;
                _ravi3["DonViTinh"] = clsvt.sDonViTinh.Value;
                _ravi3["SoLuong"] = SoLuongxxx333;
                _ravi3["DonGia"] = dongiaxxx333;// lay kho NPL
                _ravi3["GhiChu"] = dtxx.Rows[i]["GhiChu"].ToString();
                _ravi3["HienThi"] = "1";
                _ravi3["ThanhTien"] = SoLuongxxx333 * dongiaxxx333;
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
        private void HienThi_ThemMoi()
        {
            gridNguoiLap.EditValue = 12;
            dteNgayChungTu.EditValue = DateTime.Today;

            clsKhoBTP_tbNhapKho cls1 = new clsKhoBTP_tbNhapKho();
            DataTable dt1 = cls1.SelectAll();
            dt1.DefaultView.RowFilter = " TonTai= True and NgungTheoDoi=false";
            DataView dv = dt1.DefaultView;
            DataTable dv3 = dv.ToTable();
            int k = dv3.Rows.Count;
            if (k == 0)
            {
                txtSoChungTu.Text = "NKBTP 1";
            }
            else
            {
                string xxx = dt1.Rows[k - 1]["SoChungTu"].ToString();
                int xxx2 = Convert.ToInt32(xxx.Substring(5).Trim()) + 1;
                txtSoChungTu.Text = "NKBTP " + xxx2.ToString() + "";
            }

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_VTHH");
            dt2.Columns.Add("SoLuong", typeof(float));
            dt2.Columns.Add("DonGia", typeof(double));
            dt2.Columns.Add("MaVT");// tb VTHH
            dt2.Columns.Add("TenVTHH");
            dt2.Columns.Add("DonViTinh");
            dt2.Columns.Add("ThanhTien", typeof(double));
            dt2.Columns.Add("HienThi", typeof(string));
            dt2.Columns.Add("GhiChu", typeof(string));
            gridControl1.DataSource = dt2;
        }
        private void Load_LockUp()
        {
            clsTbVatTuHangHoa clsvthhh = new clsTbVatTuHangHoa();
            DataTable dtvthh = clsvthhh.SelectAll();
            dtvthh.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvvthh = dtvthh.DefaultView;
            DataTable newdtvthh = dvvthh.ToTable();


            repositoryItemGridLookUpEdit1.DataSource = newdtvthh;
            repositoryItemGridLookUpEdit1.ValueMember = "ID_VTHH";
            repositoryItemGridLookUpEdit1.DisplayMember = "MaVT";



            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=4";
            DataView dvCaTruong = dtNguoi.DefaultView;
            DataTable newdtCaTruong = dvCaTruong.ToTable();

            gridNguoiLap.Properties.DataSource = newdtCaTruong;
            gridNguoiLap.Properties.ValueMember = "ID_NhanSu";
            gridNguoiLap.Properties.DisplayMember = "MaNhanVien";

        }
        public KhoBTP_ChiTiet_NhapKho_Khac()
        {
            InitializeComponent();
        }

        private void KhoBTP_ChiTiet_NhapKho_Khac_Load(object sender, EventArgs e)
        {
            Load_LockUp();
            if (UCBanThanhPham_NhapKho_Khac.mbThemMoi_NhapKho == true)
                HienThi_ThemMoi();
            else HienThi_Sua();
        }

        private void btThoat2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void gridView4_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
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
                if (dt != null)
                {
                    gridView4.SetRowCellValue(e.RowHandle, clID_VTHH, kk);
                    gridView4.SetRowCellValue(e.RowHandle, clTenVTHH, dt.Rows[0]["TenVTHH"].ToString());
                    gridView4.SetRowCellValue(e.RowHandle, clDonViTinh, dt.Rows[0]["DonViTinh"].ToString());
                    gridView4.SetRowCellValue(e.RowHandle, clHienThi, "1");
                    gridView4.SetRowCellValue(e.RowHandle, clSoLuong, 1);
                    gridView4.SetRowCellValue(e.RowHandle, clDonGia, 0);

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

        private void gridNguoiLap_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt32(gridNguoiLap.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtNguoiNhap.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }

            }
            catch
            {

            }
        }

        private void btXoa2_Click(object sender, EventArgs e)
        {
            gridView4.SetRowCellValue(gridView4.FocusedRowHandle, clHienThi, "0");
            gridView4.SetRowCellValue(gridView4.FocusedRowHandle, clSoLuong, 0);
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

        private void btNhapKho_Dong_Click(object sender, EventArgs e)
        {
            Luu_Va_XuatKho();
            this.Close();
        }

        private void btLuu_Dong_Click(object sender, EventArgs e)
        {
            Luu_ChiLuu();
            this.Close();
        }

        private void btLuu_Copy_Click(object sender, EventArgs e)
        {
            Luu_ChiLuu();
            UCBanThanhPham_NhapKho_Khac.mbThemMoi_NhapKho = true;
            clsKhoBTP_tbNhapKho cls1 = new clsKhoBTP_tbNhapKho();
            DataTable dt1 = cls1.SelectAll();
            dt1.DefaultView.RowFilter = " TonTai= True and NgungTheoDoi=false";
            DataView dv = dt1.DefaultView;
            DataTable dv3 = dv.ToTable();
            int k = dv3.Rows.Count;
            if (k == 0)
            {
                txtSoChungTu.Text = "NKBTP 1";
            }
            else
            {
                string xxx = dt1.Rows[k - 1]["SoChungTu"].ToString();
                int xxx2 = Convert.ToInt32(xxx.Substring(5).Trim()) + 1;
                txtSoChungTu.Text = "NKBTP " + xxx2.ToString() + "";
            }
        }

        private void btNhapKho_Copy_Click(object sender, EventArgs e)
        {
            Luu_Va_XuatKho();
            UCBanThanhPham_NhapKho_Khac.mbThemMoi_NhapKho = true;
            clsKhoBTP_tbNhapKho cls1 = new clsKhoBTP_tbNhapKho();
            DataTable dt1 = cls1.SelectAll();
            dt1.DefaultView.RowFilter = " TonTai= True and NgungTheoDoi=false";
            DataView dv = dt1.DefaultView;
            DataTable dv3 = dv.ToTable();
            int k = dv3.Rows.Count;
            if (k == 0)
            {
                txtSoChungTu.Text = "NKBTP 1";
            }
            else
            {
                string xxx = dt1.Rows[k - 1]["SoChungTu"].ToString();
                int xxx2 = Convert.ToInt32(xxx.Substring(5).Trim()) + 1;
                txtSoChungTu.Text = "NKBTP " + xxx2.ToString() + "";
            }
        }
    }
}
