using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace CtyTinLuong
{
    public partial class UCDaiLy_XuatKho_GapDan : UserControl
    {
        public static int miID_XuatKho_GapDan;
        public static bool mbthemmoi, mbsua, mbcopy;
        private void Load_LockUp()
        {
            clsTbVatTuHangHoa clsvthhh = new clsTbVatTuHangHoa();
            DataTable dtvthh = clsvthhh.SelectAll();
            dtvthh.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvvthh = dtvthh.DefaultView;
            DataTable newdtvthh = dvvthh.ToTable();


            gridMaVT.DataSource = newdtvthh;
            gridMaVT.ValueMember = "ID_VTHH";
            gridMaVT.DisplayMember = "MaVT";


        }
        private void HienThiGridControl_2(int xxID_nhapkho)
        {

            DataTable dt2 = new DataTable();
            clsGapDan_ChiTiet_XuatKho cls2 = new CtyTinLuong.clsGapDan_ChiTiet_XuatKho();
            cls2.iID_XuatKho = xxID_nhapkho;
            DataTable dtxxxx = cls2.SelectAll_ID_XuatKho();
            dt2.Columns.Add("ID_VTHH", typeof(int));
            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("DonViTinh", typeof(string));
            dt2.Columns.Add("TenVTHH", typeof(string));
            dt2.Columns.Add("SoLuong", typeof(float));
            dt2.Columns.Add("HienThi", typeof(string));
            dt2.Columns.Add("DonGia", typeof(float));
            dt2.Columns.Add("ThanhTien", typeof(float));
            dt2.Columns.Add("GhiChu", typeof(string));
            clsTbVatTuHangHoa cls = new clsTbVatTuHangHoa();

            for (int i = 0; i < dtxxxx.Rows.Count; i++)
            {
                double soluong, dongia;
                DataRow _ravi = dt2.NewRow();
                int iiDI_Vthh = Convert.ToInt16(dtxxxx.Rows[i]["ID_VTHH"].ToString());
                _ravi["ID_VTHH"] = iiDI_Vthh;
                cls.iID_VTHH = Convert.ToInt16(dtxxxx.Rows[i]["ID_VTHH"].ToString());
                DataTable dtVT_vao = cls.SelectOne();
                _ravi["MaVT"] = iiDI_Vthh;
                _ravi["DonViTinh"] = cls.sDonViTinh.Value;
                _ravi["TenVTHH"] = cls.sTenVTHH.Value;
                _ravi["SoLuong"] = Convert.ToDouble(dtxxxx.Rows[i]["SoLuongXuat"].ToString());
                _ravi["DonGia"] = Convert.ToDouble(dtxxxx.Rows[i]["DonGia"].ToString());
                soluong = Convert.ToDouble(dtxxxx.Rows[i]["SoLuongXuat"].ToString());
                dongia = Convert.ToDouble(dtxxxx.Rows[i]["DonGia"].ToString());
                _ravi["ThanhTien"] = soluong * dongia;
                _ravi["HienThi"] = "1";
                _ravi["GhiChu"] = dtxxxx.Rows[i]["GhiChu"].ToString();
                dt2.Rows.Add(_ravi);
            }

            gridControl3.DataSource = dt2;
        }
        private void HienThi()
        {
            if (dteTuNgay.EditValue != null & dteDenNgay.EditValue != null)
            {
                DateTime denngay = dteDenNgay.DateTime;
                DateTime tungay = dteTuNgay.DateTime;
                DataTable dt2 = new DataTable();
                dt2.Columns.Add("ID_XuatKho", typeof(int));
                dt2.Columns.Add("DienGiai", typeof(string));
                dt2.Columns.Add("NgayChungTu", typeof(DateTime));
                dt2.Columns.Add("SoChungTu", typeof(string));
                dt2.Columns.Add("TongTienHang", typeof(double));
                dt2.Columns.Add("ThamChieu", typeof(string));
                dt2.Columns.Add("ID_VTHH_ThanhPham_QuyDoi", typeof(int));
                dt2.Columns.Add("DonGia_ThanhPham_QuyDoi", typeof(double));
                dt2.Columns.Add("SoLuongThanhPham_QuyDoi", typeof(double));              
                dt2.Columns.Add("ID_DinhMuc_ToGapDan", typeof(int));
                dt2.Columns.Add("MaDinhMuc", typeof(string));
                dt2.Columns.Add("MaVT", typeof(string));
                dt2.Columns.Add("TenVTHH", typeof(string));
                dt2.Columns.Add("DonViTinh", typeof(string));
                dt2.Columns.Add("DaXuatKho", typeof(bool));

                clsGapDan_tbXuatKho cls = new CtyTinLuong.clsGapDan_tbXuatKho();
                DataTable dt = cls.SelectAll_HienThi();
                dt.DefaultView.RowFilter = " NgayChungTu<='" + denngay + "'";
                DataView dv = dt.DefaultView;
                DataTable dt22 = dv.ToTable();
                dt22.DefaultView.RowFilter = " NgayChungTu>='" + tungay + "'";
                DataView dv2 = dt22.DefaultView;
                dv2.Sort = "NgayChungTu DESC, ID_XuatKho DESC";
                DataTable dxxxx = dv2.ToTable();
                for (int i = 0; i < dxxxx.Rows.Count; i++)
                {
                    double DonGia_ThanhPham_QuyDoi = Convert.ToDouble(dxxxx.Rows[i]["DonGia_ThanhPham_QuyDoi"].ToString());
                    double SoLuongThanhPham_QuyDoi = Convert.ToDouble(dxxxx.Rows[i]["SoLuongThanhPham_QuyDoi"].ToString());
                    int ID_VTHH_ThanhPham_QuyDoixxx = Convert.ToInt16(dxxxx.Rows[i]["ID_VTHH_ThanhPham_QuyDoi"].ToString());
                    DataRow _ravi = dt2.NewRow();

                    _ravi["ID_XuatKho"] = Convert.ToInt16(dxxxx.Rows[i]["ID_XuatKho"].ToString());
                    _ravi["DienGiai"] = dxxxx.Rows[i]["DienGiai"].ToString();
                    _ravi["NgayChungTu"] = Convert.ToDateTime(dxxxx.Rows[i]["NgayChungTu"].ToString());
                    _ravi["SoChungTu"] = dxxxx.Rows[i]["SoChungTu"].ToString();
                    _ravi["ID_VTHH_ThanhPham_QuyDoi"] = Convert.ToInt16(dxxxx.Rows[i]["ID_VTHH_ThanhPham_QuyDoi"].ToString());
                    _ravi["DonGia_ThanhPham_QuyDoi"] = DonGia_ThanhPham_QuyDoi;
                    _ravi["SoLuongThanhPham_QuyDoi"] = SoLuongThanhPham_QuyDoi;
                    _ravi["TongTienHang"] = DonGia_ThanhPham_QuyDoi * SoLuongThanhPham_QuyDoi;
                    _ravi["ID_DinhMuc_ToGapDan"] = Convert.ToInt16(dxxxx.Rows[i]["ID_DinhMuc_ToGapDan"].ToString());
                    _ravi["MaDinhMuc"] = dxxxx.Rows[i]["MaDinhMuc"].ToString();
                    _ravi["MaVT"] = dxxxx.Rows[i]["MaVT"].ToString();
                    _ravi["TenVTHH"] = dxxxx.Rows[i]["TenVTHH"].ToString();
                    _ravi["DaXuatKho"] = Convert.ToBoolean(dxxxx.Rows[i]["DaXuatKho"].ToString());
                    _ravi["DonViTinh"] = dxxxx.Rows[i]["DonViTinh"].ToString();

                    dt2.Rows.Add(_ravi);
                }
                gridControl1.DataSource = dt2;
            }

        }
        private void HienThi_ALL()
        {
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_XuatKho", typeof(int));
            dt2.Columns.Add("DienGiai", typeof(string));
            dt2.Columns.Add("NgayChungTu", typeof(DateTime));
            dt2.Columns.Add("SoChungTu", typeof(string));
            dt2.Columns.Add("TongTienHang", typeof(double));        
            dt2.Columns.Add("DaXuatKho", typeof(bool));            
            clsGapDan_tbXuatKho cls = new CtyTinLuong.clsGapDan_tbXuatKho();
            DataTable dt = cls.SelectAll();
            gridControl1.DataSource = dt;
            ////   dt.DefaultView.RowFilter = "TrangThai_XuatKho_NPL=True and TrangThai_XuatKho_BTP = True";
            //   DataView dv = dt.DefaultView;
            //   dv.Sort = "NgayChungTu DESC, ID_XuatKho DESC";
            //   DataTable dxxxx = dv.ToTable();
            //   for (int i = 0; i < dxxxx.Rows.Count; i++)
            //   {
            //       double DonGia_ThanhPham_QuyDoi = Convert.ToDouble(dxxxx.Rows[i]["DonGia_ThanhPham_QuyDoi"].ToString());
            //       double SoLuongThanhPham_QuyDoi = Convert.ToDouble(dxxxx.Rows[i]["SoLuongThanhPham_QuyDoi"].ToString());
            //       int ID_VTHH_ThanhPham_QuyDoixxx = Convert.ToInt16(dxxxx.Rows[i]["ID_VTHH_ThanhPham_QuyDoi"].ToString());
            //       DataRow _ravi = dt2.NewRow();

            //       _ravi["ID_XuatKho"] = Convert.ToInt16(dxxxx.Rows[i]["ID_XuatKho"].ToString());

            //       _ravi["DienGiai"] = dxxxx.Rows[i]["DienGiai"].ToString();
            //       _ravi["NgayChungTu"] = Convert.ToDateTime(dxxxx.Rows[i]["NgayChungTu"].ToString());
            //       _ravi["SoChungTu"] = dxxxx.Rows[i]["SoChungTu"].ToString();
            //       _ravi["ID_VTHH_ThanhPham_QuyDoi"] = Convert.ToInt16(dxxxx.Rows[i]["ID_VTHH_ThanhPham_QuyDoi"].ToString());
            //       _ravi["DonGia_ThanhPham_QuyDoi"] = DonGia_ThanhPham_QuyDoi;
            //       _ravi["SoLuongThanhPham_QuyDoi"] = SoLuongThanhPham_QuyDoi;
            //       _ravi["TongTienHang"] = DonGia_ThanhPham_QuyDoi * SoLuongThanhPham_QuyDoi;
            //       _ravi["ID_DinhMuc_ToGapDan"] = Convert.ToInt16(dxxxx.Rows[i]["ID_DinhMuc_ToGapDan"].ToString());
            //       _ravi["MaDinhMuc"] = dxxxx.Rows[i]["MaDinhMuc"].ToString();
            //       _ravi["MaVT"] = dxxxx.Rows[i]["MaVT"].ToString();
            //       _ravi["TenVTHH"] = dxxxx.Rows[i]["TenVTHH"].ToString();
            //       _ravi["DaXuatKho"] = Convert.ToBoolean(dxxxx.Rows[i]["DaXuatKho"].ToString());
            //       _ravi["DonViTinh"] = dxxxx.Rows[i]["DonViTinh"].ToString();

            //       dt2.Rows.Add(_ravi);
            //   }
            //gridControl1.DataSource = dt2;

        }
        public UCDaiLy_XuatKho_GapDan()
        {
            InitializeComponent();
        }

        private void UCDaiLy_XuatKho_GapDan_Load(object sender, EventArgs e)
        {
            Load_LockUp();
            dteDenNgay.EditValue = DateTime.Today;
            dteTuNgay.EditValue = null;
            HienThi_ALL();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UCDaiLy_XuatKho_GapDan_Load( sender,  e);
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if(gridView1.GetFocusedRowCellValue(clID_XuatKho).ToString()!="")
            {
                mbthemmoi = false;
                mbsua = true;
                mbcopy = false;
                miID_XuatKho_GapDan = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_XuatKho).ToString());
                DaiLy_FrmChiTiet_XuatKho_GapDan ff = new DaiLy_FrmChiTiet_XuatKho_GapDan();
                ff.Show();
            }
           
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(clID_XuatKho).ToString() != "")
            {
                int iiIDnhapKhp = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clID_XuatKho).ToString());
                HienThiGridControl_2(iiIDnhapKhp);
            }
        }

        private void gridView4_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT2)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool category = Convert.ToBoolean(View.GetRowCellValue(e.RowHandle, View.Columns["DaXuatKho"]));
                if (category == false)
                {
                    e.Appearance.BackColor = Color.Bisque;

                }
            }
        }

        private void btThemMoi_Click(object sender, EventArgs e)
        {
           
            mbthemmoi = true;
            mbsua = false;
            mbcopy = false;
            DaiLy_FrmChiTiet_XuatKho_GapDan ff = new DaiLy_FrmChiTiet_XuatKho_GapDan();
            ff.Show();
        }
    }
}
