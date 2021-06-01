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
    public partial class KhoBTP_ChiTietDaXuatKho : Form
    {
        public static bool mbPrint;
        public static DateTime mdaNgayChungTu;
        public static DataTable mdtPrint;
        public static string msSoChungTu, msNguoiGiaoHang, msDienGiai;
        public static double mdbTongSotien;
        private void Load_lockUP_EDIT()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=8";
            DataView dvCaTruong = dtNguoi.DefaultView;
            DataTable newdtCaTruong = dvCaTruong.ToTable();

            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=4";
            DataView dvnguoilap = dtNguoi.DefaultView;
            DataTable newdtnguoilap = dvnguoilap.ToTable();
            gridNguoiLap.Properties.DataSource = newdtnguoilap;
            gridNguoiLap.Properties.ValueMember = "ID_NhanSu";
            gridNguoiLap.Properties.DisplayMember = "MaNhanVien";

            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_ChucVu=3";
            DataView dvcongnhan = dtNguoi.DefaultView;
            DataTable newdvcongnhan = dvcongnhan.ToTable();

         

        }

        private void HienThi_SUa_GridConTrolt()
        {
            DataTable dt2 = new DataTable();
            clsKhoBTP_ChiTietXuatKho cls2 = new CtyTinLuong.clsKhoBTP_ChiTietXuatKho();
            cls2.iID_XuatKhoBTP = UCbanThanhPham_DaXuatKho.miiID_XuatKhoBTP;
            DataTable dtxxxx = cls2.SelectAll_HienThiSuaChiTietXuatKHo();

            dt2.Columns.Add("ID_ChiTietXuatKho", typeof(int));
            dt2.Columns.Add("ID_XuatKho", typeof(int));
            dt2.Columns.Add("ID_VTHH", typeof(int));
            dt2.Columns.Add("SoLuongXuat", typeof(float));
            dt2.Columns.Add("DonGia", typeof(float));

            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("TenVTHH", typeof(string));
            dt2.Columns.Add("DonViTinh", typeof(string));                    //
            dt2.Columns.Add("HienThi", typeof(string));
            dt2.Columns.Add("SoLuongTon", typeof(float));
            dt2.Columns.Add("ThanhTien", typeof(float));
            clsKhoBTP_tbChiTietNhapKho clsnhapkho = new clsKhoBTP_tbChiTietNhapKho();
            for (int i = 0; i < dtxxxx.Rows.Count; i++)
            {
                double soluong, dongia;
                DataRow _ravi = dt2.NewRow();
                _ravi["ID_ChiTietXuatKho"] = Convert.ToInt16(dtxxxx.Rows[i]["ID_ChiTietXuatKhoBTP"].ToString());
                _ravi["ID_XuatKho"] = Convert.ToInt16(dtxxxx.Rows[i]["ID_XuatKhoBTP"].ToString());
                int iiDI_Vthh = Convert.ToInt16(dtxxxx.Rows[i]["ID_VTHH"].ToString());
                _ravi["ID_VTHH"] = iiDI_Vthh;
                _ravi["SoLuongXuat"] = Convert.ToDouble(dtxxxx.Rows[i]["SoLuongXuat"].ToString());
                _ravi["DonGia"] = Convert.ToDouble(dtxxxx.Rows[i]["DonGia"].ToString());
                _ravi["MaVT"] = dtxxxx.Rows[i]["MaVT"].ToString();
                _ravi["TenVTHH"] = dtxxxx.Rows[i]["TenVTHH"].ToString();
                _ravi["DonViTinh"] = dtxxxx.Rows[i]["DonViTinh"].ToString();
                soluong = Convert.ToDouble(dtxxxx.Rows[i]["SoLuongXuat"].ToString());
                dongia = Convert.ToDouble(dtxxxx.Rows[i]["DonGia"].ToString());
                _ravi["ThanhTien"] = soluong * dongia;
                _ravi["HienThi"] = "1";
                clsnhapkho.iID_VTHH = iiDI_Vthh;
                DataTable dtnhapkho = new DataTable();
                dtnhapkho = clsnhapkho.Select_W_ID_VTHH();
                if (dtnhapkho.Rows.Count > 0)
                    _ravi["SoLuongTon"] = Convert.ToDouble(dtnhapkho.Rows[0]["SoLuongTon"].ToString());
                else _ravi["SoLuongTon"] = 0;
                dt2.Rows.Add(_ravi);

            }
            gridControl1.DataSource = dt2;


        }
        private void HienThi()
        {
            clsKhoBTP_tbXuatKho cls = new CtyTinLuong.clsKhoBTP_tbXuatKho();
            cls.iID_XuatKhoBTP = UCbanThanhPham_DaXuatKho.miiID_XuatKhoBTP;
            DataTable dt = cls.SelectOne();
            txtDienGiaiNPL.Text = cls.sDienGiai.Value.ToString();
            txtSoChungTu.Text = cls.sSoChungTu.Value.ToString();
            txtTongTienHang.Text = cls.fTongTienHang.Value.ToString();
            dteNgayChungTuNPL.EditValue = cls.daNgayChungTu.Value;
            gridNguoiLap.EditValue = cls.iID_NguoiNhap.Value;
            txtThamChieu.Text = cls.sThamChieu.Value.ToString();
            txtNguoiNhanHang.Text = cls.sNguoiNhanHang.Value.ToString();
            
        }
        public KhoBTP_ChiTietDaXuatKho()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KhoBTP_ChiTietDaXuatKho_Load(object sender, EventArgs e)
        {

            Load_lockUP_EDIT();

            HienThi_SUa_GridConTrolt();
            HienThi();
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

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
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
        

        private void btXoa_Click(object sender, EventArgs e)
        {
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, clHienThi, "0");
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, clSoLuongXuat, 0);
        }


    }
}
