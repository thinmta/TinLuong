using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtyTinLuong
{
    public partial class UCNPL_XuatKhoTheoLSXToGapDan : UserControl
    {
        public static int mID_iD_LenhSanXuat;
        //private void HienThi()
        //{
        //    clsHUU_LenhSanXuat_ChiTietLenhSanXuat_ToGapDan cls = new clsHUU_LenhSanXuat_ChiTietLenhSanXuat_ToGapDan();
        //    DataTable dt = cls.SelectAll_GuiDuLieuBangTrue();
        //    dt.DefaultView.RowFilter = " TonTai= True and NgungTheoDoi=False and boolVatTuChinh=False";
        //    DataView dv = dt.DefaultView;
        //    dv.Sort = "NgayThangSanXuat DESC, CaSanXuat DESC, ID_LenhSanXuat DESC";
        //    DataTable dt3 = dv.ToTable();
        //    DataTable dt2 = new DataTable();
        //    dt2.Columns.Add("ID_ChiTietLenhSanXuat"); // ID của tbChi tiet don hàng
        //    dt2.Columns.Add("ID_LenhSanXuat");
        //    dt2.Columns.Add("ID_VTHH");
        //    dt2.Columns.Add("SoLuong", typeof(float));
        //    dt2.Columns.Add("DonGia", typeof(double));
        //    //dt2.Columns.Add("MaVT");// tb VTHH
        //    dt2.Columns.Add("TenVTHH");
        //    dt2.Columns.Add("DonViTinh");
        //    dt2.Columns.Add("ThanhTien", typeof(double));
        //    //dt2.Columns.Add("HienThi", typeof(string));
        //    dt2.Columns.Add("CongNhan", typeof(string));
        //    dt2.Columns.Add("CaTruong", typeof(string));
        //    for (int i = 0; i < dt3.Rows.Count; i++)
        //    {
        //        double xxsoluong = Convert.ToDouble(dt3.Rows[i]["SoLuong"].ToString());
        //        double xxdongia = Convert.ToDouble(dt3.Rows[i]["DonGia"].ToString());
        //        int ID_VTHH=Convert.ToInt32(dt3.Rows[i]["ID_VTHH"].ToString());
        //        int ID_CongNhan = Convert.ToInt32(dt3.Rows[i]["ID_CongNhan"].ToString());
        //        int ID_CaTruong = Convert.ToInt32(dt3.Rows[i]["ID_CaTruong"].ToString());
        //        clsTbVatTuHangHoa clsvt = new clsTbVatTuHangHoa();
        //        clsvt.iID_VTHH = ID_VTHH;
        //        DataTable dtvt = cls.SelectOne();
        //        clsNhanSu_tbNhanSu clsns1 = new clsNhanSu_tbNhanSu();
        //        clsns1.iID_NhanSu = ID_CongNhan;
        //        DataTable dtns1 = clsns1.SelectOne();
        //        clsNhanSu_tbNhanSu clsns2 = new clsNhanSu_tbNhanSu();
        //        clsns2.iID_NhanSu = ID_CaTruong;
        //        DataTable dtns2 = clsns2.SelectOne();
        //        DataRow _ravi = dt2.NewRow();
        //        _ravi["ID_ChiTietLenhSanXuat"] = dt3.Rows[i]["ID_ChiTietLenhSanXuat"].ToString();
        //        _ravi["ID_LenhSanXuat"] = dt3.Rows[i]["ID_LenhSanXuat"].ToString();
        //        _ravi["ID_VTHH"] = ID_VTHH;
        //        _ravi["SoLuong"] = xxsoluong;
        //        _ravi["DonGia"] = xxdongia;
        //        //_ravi["MaVT"] = clsvt.sMaVT.Value;
        //        //_ravi["TenVTHH"] = clsvt.sTenVTHH.Value;
        //        //_ravi["DonViTinh"] = clsvt.sDonViTinh.Value;
        //        _ravi["ThanhTien"] = Convert.ToDouble(dt3.Rows[i]["ThanhTien"].ToString());
        //        _ravi["CongNhan"] = clsns1.sTenNhanVien.Value;
        //        _ravi["CaTruong"] = clsns2.sTenNhanVien.Value;
               
        //        dt2.Rows.Add(_ravi);
        //    }

        //    gridControl1.DataSource = dt2;
           
        //}

        private void HienThi2222()
        {
            clsHUU_LenhSanXuat_ToGapDan cls = new clsHUU_LenhSanXuat_ToGapDan();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.RowFilter = " TonTai= True and NgungTheoDoi=False and GuiDuLieu=True";
            DataView dv = dt.DefaultView;
            dv.Sort = "NgayThangSanXuat DESC, CaSanXuat DESC, ID_LenhSanXuat DESC";
            DataTable dt3 = dv.ToTable();
            DataTable dt2 = new DataTable();
           
            dt2.Columns.Add("ID_LenhSanXuat");
            dt2.Columns.Add("MaLenhSanXuat");         
            dt2.Columns.Add("NgayThangSanXuat", typeof(DateTime));
            dt2.Columns.Add("CaSanXuat", typeof(string));
            dt2.Columns.Add("CongNhan", typeof(string));
            dt2.Columns.Add("CaTruong", typeof(string));
            for (int i = 0; i < dt3.Rows.Count; i++)
            {              
                int ID_CongNhan = Convert.ToInt32(dt3.Rows[i]["ID_CongNhan"].ToString());
                int ID_CaTruong = Convert.ToInt32(dt3.Rows[i]["ID_CaTruong"].ToString());              
                clsNhanSu_tbNhanSu clsns1 = new clsNhanSu_tbNhanSu();
                clsns1.iID_NhanSu = ID_CongNhan;
                DataTable dtns1 = clsns1.SelectOne();
                clsNhanSu_tbNhanSu clsns2 = new clsNhanSu_tbNhanSu();
                clsns2.iID_NhanSu = ID_CaTruong;
                DataTable dtns2 = clsns2.SelectOne();
                DataRow _ravi = dt2.NewRow();
               
                _ravi["ID_LenhSanXuat"] = dt3.Rows[i]["ID_LenhSanXuat"].ToString();
                _ravi["MaLenhSanXuat"] = dt3.Rows[i]["MaLenhSanXuat"].ToString();
                _ravi["NgayThangSanXuat"] = Convert.ToDateTime(dt3.Rows[i]["NgayThangSanXuat"].ToString());               
                _ravi["CaSanXuat"] = dt3.Rows[i]["CaSanXuat"].ToString();              
                _ravi["CongNhan"] = clsns1.sTenNhanVien.Value;
                _ravi["CaTruong"] = clsns2.sTenNhanVien.Value;

                dt2.Rows.Add(_ravi);
            }

            gridControl1.DataSource = dt2;

        }


        public UCNPL_XuatKhoTheoLSXToGapDan()
        {
            InitializeComponent();
        }

        private void UCNPL_XuatKhoTheoLSXToGapDan_Load(object sender, EventArgs e)
        {
            HienThi2222();
        }

        private void btfresh_Click(object sender, EventArgs e)
        {
            UCNPL_XuatKhoTheoLSXToGapDan_Load( sender,  e);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.GetFocusedRowCellValue(clID_LenhSanXuat).ToString() != "")
                {

                    mID_iD_LenhSanXuat = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_LenhSanXuat).ToString());
                    NPL_ChiTietLenhSanXuat_ToGapDan ff = new NPL_ChiTietLenhSanXuat_ToGapDan();
                    ff.Show();
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
    }
}
