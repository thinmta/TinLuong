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
    public partial class frmBaoCaoSanLuongToGapDan : Form
    {
        private void hienthiGridControl22222()
        {
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_LenhSanXuat", typeof(int));
            dt2.Columns.Add("MaLenhSanXuat", typeof(string));
            dt2.Columns.Add("CaSanXuat", typeof(string));
            dt2.Columns.Add("NgayThangSanXuat", typeof(DateTime));            
            dt2.Columns.Add("CongNhan", typeof(string));         
            dt2.Columns.Add("CaTruong", typeof(string));
            dt2.Columns.Add("GhiChu", typeof(string));           
            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("DonViTinh", typeof(string));
            dt2.Columns.Add("TenVatTu", typeof(string));           
            dt2.Columns.Add("SoLuong_ThanhPham", typeof(double));
            dt2.Columns.Add("PhePham", typeof(string));   
            clsTbVatTuHangHoa clsVT_Ra = new clsTbVatTuHangHoa();
            clsNhanSu_tbNhanSu clsnhansu = new clsNhanSu_tbNhanSu();
            clsNhanSu_tbNhanSu clsnhansu2 = new clsNhanSu_tbNhanSu();
            clsHUU_LenhSanXuat_ToGapDan cls = new clsHUU_LenhSanXuat_ToGapDan();


            DataTable daaa = cls.SelectAll();
            daaa.DefaultView.RowFilter = " GuiDuLieu= True and NgungTheoDoi=false";
            DataView dvaaa = daaa.DefaultView;
            dvaaa.Sort = "NgayThangSanXuat DESC, ID_LenhSanXuat DESC";
            DataTable dt = dvaaa.ToTable();
          

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int ID_LenhSanXuat = Convert.ToInt32(dt.Rows[i]["ID_LenhSanXuat"].ToString());
                    int ID_CongNhan = Convert.ToInt32(dt.Rows[i]["ID_CongNhan"].ToString());
                    int ID_CaTruong = Convert.ToInt32(dt.Rows[i]["ID_CaTruong"].ToString());
                    int ID_VTHH_ThanhPham = Convert.ToInt32(dt.Rows[i]["ID_VTHH_ThanhPham"].ToString());
                    double SoLuong_ThanhPham = Convert.ToDouble(dt.Rows[i]["ID_VTHH_ThanhPham"].ToString());
                    double PhePham = Convert.ToDouble(dt.Rows[i]["PhePham"].ToString());
                    string MaLenhSanXuat = dt.Rows[i]["MaLenhSanXuat"].ToString();
                    string CaSanXuat = dt.Rows[i]["CaSanXuat"].ToString();
                    
                    string NgayThangSanXuat = dt.Rows[i]["NgayThangSanXuat"].ToString();
                    string GhiChu = dt.Rows[i]["GhiChu"].ToString();

                    string CongNhan, CaTruong, DonViTinh, MaVT, TenVatTu;

                    clsnhansu.iID_NhanSu = ID_CongNhan;
                    DataTable dtnhansu = clsnhansu.SelectOne();
                    CongNhan = clsnhansu.sTenNhanVien.Value;

                    clsnhansu2.iID_NhanSu = ID_CaTruong;
                    DataTable dtnhansu2 = clsnhansu2.SelectOne();
                    CaTruong = clsnhansu2.sTenNhanVien.Value;
                    DataRow _ravi = dt2.NewRow();

                    clsVT_Ra.iID_VTHH = ID_VTHH_ThanhPham;
                    DataTable dtvt_Ra = clsVT_Ra.SelectOne();
                    MaVT = clsVT_Ra.sMaVT.Value;
                    DonViTinh = clsVT_Ra.sDonViTinh.Value;
                    TenVatTu = clsVT_Ra.sTenVTHH.Value;

                    _ravi["ID_LenhSanXuat"] = ID_LenhSanXuat;                   
                    _ravi["SoLuong_ThanhPham"] = SoLuong_ThanhPham;
                    _ravi["PhePham"] = PhePham;
                    _ravi["MaLenhSanXuat"] = MaLenhSanXuat;
                    _ravi["CaSanXuat"] = CaSanXuat;
                    _ravi["CongNhan"] = CongNhan;
                    _ravi["CaTruong"] = CaTruong;
                    _ravi["MaVT"] = MaVT;
                    _ravi["DonViTinh"] = DonViTinh;
                    _ravi["TenVatTu"] = TenVatTu;
                    _ravi["NgayThangSanXuat"] = NgayThangSanXuat;
                    _ravi["GhiChu"] = GhiChu;                   
                    dt2.Rows.Add(_ravi);
                }
                gridControl1.DataSource = dt2;
            }

        }
        private void HienThi()
        {
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_LenhSanXuat", typeof(int));
            dt2.Columns.Add("MaLenhSanXuat", typeof(string));
            dt2.Columns.Add("CaSanXuat", typeof(string));
            dt2.Columns.Add("NgayThangSanXuat", typeof(DateTime));
            dt2.Columns.Add("CongNhan", typeof(string));
            dt2.Columns.Add("CaTruong", typeof(string));
            dt2.Columns.Add("GhiChu", typeof(string));
            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("DonViTinh", typeof(string));
            dt2.Columns.Add("TenVatTu", typeof(string));
            dt2.Columns.Add("SoLuong_ThanhPham", typeof(double));
            dt2.Columns.Add("PhePham", typeof(string));
            clsTbVatTuHangHoa clsVT_Ra = new clsTbVatTuHangHoa();
            clsNhanSu_tbNhanSu clsnhansu = new clsNhanSu_tbNhanSu();
            clsNhanSu_tbNhanSu clsnhansu2 = new clsNhanSu_tbNhanSu();
            clsHUU_LenhSanXuat_ToGapDan cls = new clsHUU_LenhSanXuat_ToGapDan();


            DataTable daaa = cls.SelectAll();
            daaa.DefaultView.RowFilter = " GuiDuLieu= True and NgungTheoDoi=false";
            DataView dvaaa = daaa.DefaultView;
            dvaaa.Sort = "NgayThangSanXuat DESC, ID_LenhSanXuat DESC";
            DataTable dt = dvaaa.ToTable();


            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int ID_LenhSanXuat = Convert.ToInt32(dt.Rows[i]["ID_LenhSanXuat"].ToString());
                    int ID_CongNhan = Convert.ToInt32(dt.Rows[i]["ID_CongNhan"].ToString());
                    int ID_CaTruong = Convert.ToInt32(dt.Rows[i]["ID_CaTruong"].ToString());
                    int ID_VTHH_ThanhPham = Convert.ToInt32(dt.Rows[i]["ID_VTHH_ThanhPham"].ToString());
                    double SoLuong_ThanhPham = Convert.ToDouble(dt.Rows[i]["ID_VTHH_ThanhPham"].ToString());
                    double PhePham = Convert.ToDouble(dt.Rows[i]["PhePham"].ToString());
                    string MaLenhSanXuat = dt.Rows[i]["MaLenhSanXuat"].ToString();
                    string CaSanXuat = dt.Rows[i]["CaSanXuat"].ToString();

                    string NgayThangSanXuat = dt.Rows[i]["NgayThangSanXuat"].ToString();
                    string GhiChu = dt.Rows[i]["GhiChu"].ToString();

                    string CongNhan, CaTruong, DonViTinh, MaVT, TenVatTu;

                    clsnhansu.iID_NhanSu = ID_CongNhan;
                    DataTable dtnhansu = clsnhansu.SelectOne();
                    CongNhan = clsnhansu.sTenNhanVien.Value;

                    clsnhansu2.iID_NhanSu = ID_CaTruong;
                    DataTable dtnhansu2 = clsnhansu2.SelectOne();
                    CaTruong = clsnhansu2.sTenNhanVien.Value;
                    DataRow _ravi = dt2.NewRow();

                    clsVT_Ra.iID_VTHH = ID_VTHH_ThanhPham;
                    DataTable dtvt_Ra = clsVT_Ra.SelectOne();
                    MaVT = clsVT_Ra.sMaVT.Value;
                    DonViTinh = clsVT_Ra.sDonViTinh.Value;
                    TenVatTu = clsVT_Ra.sTenVTHH.Value;

                    _ravi["ID_LenhSanXuat"] = ID_LenhSanXuat;
                    _ravi["SoLuong_ThanhPham"] = SoLuong_ThanhPham;
                    _ravi["PhePham"] = PhePham;
                    _ravi["MaLenhSanXuat"] = MaLenhSanXuat;
                    _ravi["CaSanXuat"] = CaSanXuat;
                    _ravi["CongNhan"] = CongNhan;
                    _ravi["CaTruong"] = CaTruong;
                    _ravi["MaVT"] = MaVT;
                    _ravi["DonViTinh"] = DonViTinh;
                    _ravi["TenVatTu"] = TenVatTu;
                    _ravi["NgayThangSanXuat"] = NgayThangSanXuat;
                    _ravi["GhiChu"] = GhiChu;
                    dt2.Rows.Add(_ravi);
                }
                gridControl1.DataSource = dt2;
            }

        }
        private void HienThi_ALL()
        {
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_LenhSanXuat", typeof(int));
            dt2.Columns.Add("MaLenhSanXuat", typeof(string));
            dt2.Columns.Add("CaSanXuat", typeof(string));
            dt2.Columns.Add("NgayThangSanXuat", typeof(DateTime));
            dt2.Columns.Add("CongNhan", typeof(string));
            dt2.Columns.Add("CaTruong", typeof(string));
            dt2.Columns.Add("GhiChu", typeof(string));
            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("DonViTinh", typeof(string));
            dt2.Columns.Add("TenVatTu", typeof(string));
            dt2.Columns.Add("SoLuong_ThanhPham", typeof(double));
            dt2.Columns.Add("PhePham", typeof(string));
            clsTbVatTuHangHoa clsVT_Ra = new clsTbVatTuHangHoa();
            clsNhanSu_tbNhanSu clsnhansu = new clsNhanSu_tbNhanSu();
            clsNhanSu_tbNhanSu clsnhansu2 = new clsNhanSu_tbNhanSu();
            clsHUU_LenhSanXuat_ToGapDan cls = new clsHUU_LenhSanXuat_ToGapDan();


            DataTable daaa = cls.SelectAll();
            daaa.DefaultView.RowFilter = " GuiDuLieu= True and NgungTheoDoi=false";
            DataView dvaaa = daaa.DefaultView;
            dvaaa.Sort = "NgayThangSanXuat DESC, ID_LenhSanXuat DESC";
            DataTable dt = dvaaa.ToTable();


            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int ID_LenhSanXuat = Convert.ToInt32(dt.Rows[i]["ID_LenhSanXuat"].ToString());
                    int ID_CongNhan = Convert.ToInt32(dt.Rows[i]["ID_CongNhan"].ToString());
                    int ID_CaTruong = Convert.ToInt32(dt.Rows[i]["ID_CaTruong"].ToString());
                    int ID_VTHH_ThanhPham = Convert.ToInt32(dt.Rows[i]["ID_VTHH_ThanhPham"].ToString());
                    double SoLuong_ThanhPham = Convert.ToDouble(dt.Rows[i]["ID_VTHH_ThanhPham"].ToString());
                    double PhePham = Convert.ToDouble(dt.Rows[i]["PhePham"].ToString());
                    string MaLenhSanXuat = dt.Rows[i]["MaLenhSanXuat"].ToString();
                    string CaSanXuat = dt.Rows[i]["CaSanXuat"].ToString();

                    string NgayThangSanXuat = dt.Rows[i]["NgayThangSanXuat"].ToString();
                    string GhiChu = dt.Rows[i]["GhiChu"].ToString();

                    string CongNhan, CaTruong, DonViTinh, MaVT, TenVatTu;

                    clsnhansu.iID_NhanSu = ID_CongNhan;
                    DataTable dtnhansu = clsnhansu.SelectOne();
                    CongNhan = clsnhansu.sTenNhanVien.Value;

                    clsnhansu2.iID_NhanSu = ID_CaTruong;
                    DataTable dtnhansu2 = clsnhansu2.SelectOne();
                    CaTruong = clsnhansu2.sTenNhanVien.Value;
                    DataRow _ravi = dt2.NewRow();

                    clsVT_Ra.iID_VTHH = ID_VTHH_ThanhPham;
                    DataTable dtvt_Ra = clsVT_Ra.SelectOne();
                    MaVT = clsVT_Ra.sMaVT.Value;
                    DonViTinh = clsVT_Ra.sDonViTinh.Value;
                    TenVatTu = clsVT_Ra.sTenVTHH.Value;

                    _ravi["ID_LenhSanXuat"] = ID_LenhSanXuat;
                    _ravi["SoLuong_ThanhPham"] = SoLuong_ThanhPham;
                    _ravi["PhePham"] = PhePham;
                    _ravi["MaLenhSanXuat"] = MaLenhSanXuat;
                    _ravi["CaSanXuat"] = CaSanXuat;
                    _ravi["CongNhan"] = CongNhan;
                    _ravi["CaTruong"] = CaTruong;
                    _ravi["MaVT"] = MaVT;
                    _ravi["DonViTinh"] = DonViTinh;
                    _ravi["TenVatTu"] = TenVatTu;
                    _ravi["NgayThangSanXuat"] = NgayThangSanXuat;
                    _ravi["GhiChu"] = GhiChu;
                    dt2.Rows.Add(_ravi);
                }
                gridControl1.DataSource = dt2;
            }

        }
        public frmBaoCaoSanLuongToGapDan()
        {
            InitializeComponent();
        }

        private void frmBaoCaoSanLuongToGapDan_Load(object sender, EventArgs e)
        {
            
            dteDenNgay.EditValue = null;
            dteTuNgay.EditValue = null;
            HienThi_ALL();
            bandedGridView1.OptionsFind.AlwaysVisible = false;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bandedGridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            frmBaoCaoSanLuongToGapDan_Load( sender,  e);
        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            if (dteDenNgay.EditValue != null & dteTuNgay.EditValue != null)
            {
                HienThi();
            }
        }
    }
}
