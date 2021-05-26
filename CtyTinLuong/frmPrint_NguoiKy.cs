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
    public partial class frmPrint_NguoiKy : Form
    {
       
          public static string sNguoiLap, sNguoiNhan, sThuKho, sKeToanTruong, 
            sGiamDoc, sCaTruong, sCongNhan, ssochungtu, ssohoadon, sngaythang;
        private void LuuDuLieu()
        {
            //xoa truoc

            //try
            //{
            clsAaatbMacDinhNguoiKy cls = new CtyTinLuong.clsAaatbMacDinhNguoiKy();
            cls.iID_DangNhap = frmDangNhap.miID_DangNhap;
            cls.Delete_All_ID_DangNhap();

            cls.iID_DangNhap = frmDangNhap.miID_DangNhap;
            cls.sChucVu = "row_0_Người giao";
            cls.sHoTen = txtNguoiGiao.Text.ToString();
            cls.Insert();


            cls.iID_DangNhap = frmDangNhap.miID_DangNhap;
            cls.sChucVu = "row_1_Người lập";
            cls.sHoTen = txtNguoiLap.Text.ToString();
            cls.Insert();


            cls.iID_DangNhap = frmDangNhap.miID_DangNhap;
            cls.sChucVu = "row_2_Người nhận";
            cls.sHoTen = txtNguoiNhan.Text.ToString();
            cls.Insert();



            cls.iID_DangNhap = frmDangNhap.miID_DangNhap;
            cls.sChucVu = "row_3_Thủ kho";
            cls.sHoTen = txtthuKhonewww.Text.ToString();
            cls.Insert();



            cls.iID_DangNhap = frmDangNhap.miID_DangNhap;
            cls.sChucVu = "row_4_Trưởng phòng KH";
            cls.sHoTen = txtTruongPhongKH.Text.ToString();
            cls.Insert();



            cls.iID_DangNhap = frmDangNhap.miID_DangNhap;
            cls.sChucVu = "row_5_Kế toán trưởng";
            cls.sHoTen = txtKeToanTruong.Text.ToString();
            cls.Insert();



            cls.iID_DangNhap = frmDangNhap.miID_DangNhap;
            cls.sChucVu = "row_6_Giám đốc";
            cls.sHoTen = txtGiamDoc.Text.ToString();
            cls.Insert();



            cls.iID_DangNhap = frmDangNhap.miID_DangNhap;
            cls.sChucVu = "row_7_Ca trưởng";
            cls.sHoTen = txtCaTruong.Text.ToString();
            cls.Insert();

            cls.iID_DangNhap = frmDangNhap.miID_DangNhap;
            cls.sChucVu = "row_8_Thủ Quy";
            cls.sHoTen = txtThuQuy.Text.ToString();
            cls.Insert();

            cls.iID_DangNhap = frmDangNhap.miID_DangNhap;
            cls.sChucVu = "row_9_NguoiNopTien";
            cls.sHoTen = txtNguoiNopTien.Text.ToString();
            cls.Insert();
            cls.iID_DangNhap = frmDangNhap.miID_DangNhap;
            cls.sChucVu = "row_10_BaoVe";
            cls.sHoTen = txtBaoVe.Text.ToString();
            cls.Insert();


            //}
            //catch
            //{

            //}



        }
        private void HienThi()
        {
            
            clsAaatbMacDinhNguoiKy cls = new CtyTinLuong.clsAaatbMacDinhNguoiKy();
            cls.iID_DangNhap = frmDangNhap.miID_DangNhap;
            DataTable dt = cls.SelectAll_ID_DangNhap();
            if (dt.Rows.Count > 0)
            {
                txtNguoiGiao.Text = dt.Rows[0]["HoTen"].ToString();
                txtNguoiLap.Text = dt.Rows[1]["HoTen"].ToString();
                txtNguoiNhan.Text = dt.Rows[2]["HoTen"].ToString();
                txtthuKhonewww.Text = dt.Rows[3]["HoTen"].ToString();
                txtTruongPhongKH.Text = dt.Rows[4]["HoTen"].ToString();
                txtKeToanTruong.Text = dt.Rows[5]["HoTen"].ToString();
                txtGiamDoc.Text = dt.Rows[6]["HoTen"].ToString();
                txtCaTruong.Text = dt.Rows[7]["HoTen"].ToString();
                txtThuQuy.Text= dt.Rows[8]["HoTen"].ToString();
                txtNguoiNopTien.Text = dt.Rows[9]["HoTen"].ToString();
            }
           
        }

        public void Load_LockUp_BaoVe()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv = dtNguoi.DefaultView;
            DataTable dt = dv.ToTable();
            gridBaoVe.Properties.DataSource = dt;
            gridBaoVe.Properties.ValueMember = "ID_NhanSu";
            gridBaoVe.Properties.DisplayMember = "MaNhanVien";
        }
        public void Load_LockUp_TruongPhong()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv = dtNguoi.DefaultView;
            DataTable dt = dv.ToTable();
            gridTruongPhongKH.Properties.DataSource = dt;
            gridTruongPhongKH.Properties.ValueMember = "ID_NhanSu";
            gridTruongPhongKH.Properties.DisplayMember = "MaNhanVien";
        }
        public void Load_LockUp_gridnguoilap()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv = dtNguoi.DefaultView;
            DataTable dt = dv.ToTable();
            gridNguoiLap.Properties.DataSource = dt;
            gridNguoiLap.Properties.ValueMember = "ID_NhanSu";
            gridNguoiLap.Properties.DisplayMember = "MaNhanVien";
        }

        public void Load_LockUp_gridNguoiNhan()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv = dtNguoi.DefaultView;
            DataTable dt = dv.ToTable();
            gridNguoiNhan.Properties.DataSource = dt;
            gridNguoiNhan.Properties.ValueMember = "ID_NhanSu";
            gridNguoiNhan.Properties.DisplayMember = "MaNhanVien";
        }

        public void Load_LockUp_gridThuKho()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv = dtNguoi.DefaultView;
            DataTable dt = dv.ToTable();
            gridThuKho.Properties.DataSource = dt;
            gridThuKho.Properties.ValueMember = "ID_NhanSu";
            gridThuKho.Properties.DisplayMember = "MaNhanVien";
        }

        public void Load_LockUp_gridKeToanTruong()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv = dtNguoi.DefaultView;
            DataTable dt = dv.ToTable();
            gridKeToanTruong.Properties.DataSource = dt;
            gridKeToanTruong.Properties.ValueMember = "ID_NhanSu";
            gridKeToanTruong.Properties.DisplayMember = "MaNhanVien";
        }

        public void Load_LockUp_gridGiamDoc()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv = dtNguoi.DefaultView;
            DataTable dt = dv.ToTable();
            gridGiamDoc.Properties.DataSource = dt;
            gridGiamDoc.Properties.ValueMember = "ID_NhanSu";
            gridGiamDoc.Properties.DisplayMember = "MaNhanVien";
        }

        public void Load_LockUp_gridCaTruong()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv = dtNguoi.DefaultView;
            DataTable dt = dv.ToTable();
            gridCaTruong.Properties.DataSource = dt;
            gridCaTruong.Properties.ValueMember = "ID_NhanSu";
            gridCaTruong.Properties.DisplayMember = "MaNhanVien";
        }

        public void Load_LockUp_gridNGuoiGiao()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv = dtNguoi.DefaultView;
            DataTable dt = dv.ToTable();
            gridNguoiGiao.Properties.DataSource = dt;
            gridNguoiGiao.Properties.ValueMember = "ID_NhanSu";
            gridNguoiGiao.Properties.DisplayMember = "MaNhanVien";
        }
        public void Load_LockUp_gridThuQuy()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv = dtNguoi.DefaultView;
            DataTable dt = dv.ToTable();
            gridThuQuy.Properties.DataSource = dt;
            gridThuQuy.Properties.ValueMember = "ID_NhanSu";
            gridThuQuy.Properties.DisplayMember = "MaNhanVien";
        }
        public void Load_LockUp_gridNguoiNopTieny()
        {
            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv = dtNguoi.DefaultView;
            DataTable dt = dv.ToTable();
            gridNguoiNopTien.Properties.DataSource = dt;
            gridNguoiNopTien.Properties.ValueMember = "ID_NhanSu";
            gridNguoiNopTien.Properties.DisplayMember = "MaNhanVien";
        }
        

        public frmPrint_NguoiKy()
        {
            InitializeComponent();
        }

        private void frmPrint_NguoiKy_Load(object sender, EventArgs e)
        {
            Load_LockUp_gridnguoilap();
            Load_LockUp_gridNguoiNhan();
            Load_LockUp_gridThuKho();
            Load_LockUp_gridKeToanTruong();
            Load_LockUp_gridGiamDoc();
            Load_LockUp_gridCaTruong();
            Load_LockUp_gridNGuoiGiao();
            Load_LockUp_gridThuQuy();
            Load_LockUp_gridNguoiNopTieny();
            Load_LockUp_TruongPhong();
            Load_LockUp_BaoVe();
            HienThi();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void gridTruongPhongKH_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt16(gridTruongPhongKH.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTruongPhongKH.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }

            }
            catch
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LuuDuLieu();
            MessageBox.Show("Đã lưu");
            this.Close();
        }

        private void gridNguoiGiao_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt16(gridNguoiGiao.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtNguoiGiao.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }

            }
            catch
            {

            }
        }

        private void gridThuQuy_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt16(gridThuQuy.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtThuQuy.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }

            }
            catch
            {

            }
        }

        private void gridNguoiNopTien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt16(gridNguoiNopTien.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtNguoiNopTien.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }

            }
            catch
            {

            }
        }

        private void gridBaoVe_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt16(gridBaoVe.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtBaoVe.Text = dt.Rows[0]["TenNhanVien"].ToString();

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
                    txtNguoiLap.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }

            }
            catch
            {

            }
        }

        private void gridNguoiNhan_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt16(gridNguoiNhan.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtNguoiNhan.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }

            }
            catch
            {

            }
        }

        private void gridThuKho_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt16(gridThuKho.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtthuKhonewww.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }

            }
            catch
            {

            }
        }

        private void gridKeToanTruong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt16(gridKeToanTruong.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtKeToanTruong.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }

            }
            catch
            {

            }
        }

        private void gridGiamDoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt16(gridGiamDoc.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtGiamDoc.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }

            }
            catch
            {

            }
        }

        private void gridCaTruong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt16(gridCaTruong.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtCaTruong.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }

            }
            catch
            {

            }
        }

        private void gridCongNhan_EditValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
            //    clsncc.iID_NhanSu = Convert.ToInt16(gridNguoiLap.EditValue.ToString());
            //    DataTable dt = clsncc.SelectOne();
            //    if (dt.Rows.Count > 0)
            //    {
            //        txtCongNhan.Text = dt.Rows[0]["TenNhanVien"].ToString();

            //    }

            //}
            //catch
            //{

            //}
        }

        private void frmPrint_NguoiKy_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btDongY_Click(object sender, EventArgs e)
        {
           
           
           
           
        }
    }
}
