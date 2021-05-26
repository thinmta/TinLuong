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
    public partial class frmCaiDatBangGia_BanHang : Form
    {
        private void Load_LockUp()
        {
            clsTbVatTuHangHoa clsvthhh = new clsTbVatTuHangHoa();
            DataTable dtvthh = clsvthhh.SelectAll();
            dtvthh.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvvthh = dtvthh.DefaultView;
            DataTable newdtvthh = dvvthh.ToTable();


            GridLookUpEdit_MaVatTu.DataSource = newdtvthh;
            GridLookUpEdit_MaVatTu.ValueMember = "ID_VTHH";
            GridLookUpEdit_MaVatTu.DisplayMember = "MaVT";

            clsTbKhachHang cls = new clsTbKhachHang();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dv = dt.DefaultView;
            DataTable newdt = dv.ToTable();

            GridLookUpEdit_MaKhachHang.DataSource = newdt;
            GridLookUpEdit_MaKhachHang.ValueMember = "ID_KhachHang";
            GridLookUpEdit_MaKhachHang.DisplayMember = "MaKH";
            
        }

        private void HienThi()
        {
            Load_LockUp();
            

            clsBanHang_BangGia cls = new clsBanHang_BangGia();
        
            DataTable dt3 = cls.SelectAll();

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_BangGia"); // ID của tbChi tiet don hàng
            dt2.Columns.Add("ID_VTHH");
            dt2.Columns.Add("ID_KhachHang");   
            dt2.Columns.Add("DonGia");
            dt2.Columns.Add("TienUSD", typeof(bool));
            dt2.Columns.Add("DienGiai");
            dt2.Columns.Add("GhiChu");
            dt2.Columns.Add("NgayLap", typeof(DateTime));

            dt2.Columns.Add("MaVT");
            dt2.Columns.Add("TenVTHH");
            dt2.Columns.Add("DonViTinh");

            dt2.Columns.Add("MaKH");
            dt2.Columns.Add("TenKH");
            if(dt3.Rows.Count>0)
            {
                for (int i = 0; i < dt3.Rows.Count; i++)
                {
                    DataRow _ravi = dt2.NewRow();
                    _ravi["ID_BangGia"] = dt3.Rows[i]["ID_BangGia"].ToString();
                    _ravi["ID_VTHH"] = dt3.Rows[i]["ID_VTHH"].ToString();
                    _ravi["ID_KhachHang"] = dt3.Rows[i]["ID_KhachHang"].ToString();                  
                    _ravi["DonGia"] = dt3.Rows[i]["DonGia"].ToString(); 
                    _ravi["TienUSD"] =Convert.ToBoolean(dt3.Rows[i]["TienUSD"].ToString());
                    _ravi["DienGiai"] = dt3.Rows[i]["DienGiai"].ToString();
                    _ravi["GhiChu"] = dt3.Rows[i]["GhiChu"].ToString();
                    _ravi["NgayLap"] =Convert.ToDateTime(dt3.Rows[i]["NgayLap"].ToString());
                    _ravi["GhiChu"] = dt3.Rows[i]["GhiChu"].ToString();
                    clsTbVatTuHangHoa cls1 = new clsTbVatTuHangHoa();
                    clsTbKhachHang cls2 = new clsTbKhachHang();
                    cls1.iID_VTHH = Convert.ToInt32(dt3.Rows[i]["ID_VTHH"].ToString());
                    DataTable dt1 = cls1.SelectOne();
                    cls2.iID_KhachHang = Convert.ToInt32(dt3.Rows[i]["ID_KhachHang"].ToString());
                    DataTable dt2212772 = cls2.SelectOne();
                    _ravi["MaVT"] = cls1.iID_VTHH.Value.ToString();
                    _ravi["TenVTHH"] = cls1.sTenVTHH.Value;
                    _ravi["DonViTinh"] = cls1.sDonViTinh.Value;
                    _ravi["MaKH"] = cls2.iID_KhachHang.Value.ToString();
                    _ravi["TenKH"] = cls2.sTenKH.Value;
                    dt2.Rows.Add(_ravi);
                }
            }            

            gridControl1.DataSource = dt2;
            
        }
        public frmCaiDatBangGia_BanHang()
        {
            InitializeComponent();
        }

        private void gridView4_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == clMaVT)
            {
                clsTbVatTuHangHoa cls1 = new clsTbVatTuHangHoa();
                cls1.iID_VTHH = Convert.ToInt32(gridView4.GetRowCellValue(e.RowHandle, e.Column));
                int kk = Convert.ToInt32(gridView4.GetRowCellValue(e.RowHandle, e.Column));
                DataTable dt = cls1.SelectOne();

                gridView4.SetRowCellValue(e.RowHandle, clID_VTHH, kk);
                gridView4.SetRowCellValue(e.RowHandle, clTenVTHH, cls1.sTenVTHH.Value);
                gridView4.SetRowCellValue(e.RowHandle, clDonViTinh, cls1.sMaVT.Value);
                gridView4.SetRowCellValue(e.RowHandle, clDonGia, 0);
                gridView4.SetRowCellValue(e.RowHandle, clTienUSD, true);
                if (gridView4.GetFocusedRowCellValue(clID_BangGia).ToString() == "")
                    gridView4.SetRowCellValue(e.RowHandle, clNgayLap, DateTime.Today);

            }
            if (e.Column == clMaKH)
            {
                clsTbKhachHang cls2 = new clsTbKhachHang();
                cls2.iID_KhachHang = Convert.ToInt32(gridView4.GetRowCellValue(e.RowHandle, e.Column));
                int kk = Convert.ToInt32(gridView4.GetRowCellValue(e.RowHandle, e.Column));
                DataTable dt = cls2.SelectOne();
              
                    gridView4.SetRowCellValue(e.RowHandle, clID_KhachHang, kk);
                    gridView4.SetRowCellValue(e.RowHandle, clTenKH, cls2.sTenKH.Value);
                   
            }
        }

        private void frmCaiDatBangGia_BanHang_Load(object sender, EventArgs e)
        {
            
            HienThi();
        }

        private void btXoa2_Click(object sender, EventArgs e)
        {
            if (gridView4.GetFocusedRowCellValue(clID_BangGia).ToString() != "")
            {
                DialogResult traloi;             
                traloi = MessageBox.Show("Xóa dữ liệu này. Lưu ý sẽ mất hế dữ liệu?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    clsBanHang_BangGia cls = new clsBanHang_BangGia();
                    cls.iID_BangGia = Convert.ToInt32(gridView4.GetFocusedRowCellValue(clID_BangGia).ToString());
                    cls.Delete();
                    MessageBox.Show("Đã xoá");
                    HienThi();

                }
            }
        }

        private void gridView4_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (gridView4.GetFocusedRowCellValue(clID_VTHH).ToString() != "" & gridView4.GetFocusedRowCellValue(clID_KhachHang).ToString() != "")
            {
                clsBanHang_BangGia cls = new clsBanHang_BangGia();
                cls.iID_KhachHang = Convert.ToInt32(gridView4.GetFocusedRowCellValue(clID_KhachHang).ToString());
                cls.iID_VTHH = Convert.ToInt32(gridView4.GetFocusedRowCellValue(clID_VTHH).ToString());
                cls.fDonGia = Convert.ToDouble(gridView4.GetFocusedRowCellValue(clDonGia).ToString());
                cls.bTienUSD = Convert.ToBoolean(gridView4.GetFocusedRowCellValue(clTienUSD).ToString());
                cls.sDienGiai = gridView4.GetFocusedRowCellValue(clDienGiai).ToString();
                cls.sGhiChu = gridView4.GetFocusedRowCellValue(clGhiChu).ToString();
                cls.daNgayLap = Convert.ToDateTime(gridView4.GetFocusedRowCellValue(clNgayLap).ToString());
                if (gridView4.GetFocusedRowCellValue(clID_BangGia).ToString() != "") // sửa
                {
                    cls.iID_BangGia = Convert.ToInt32(gridView4.GetFocusedRowCellValue(clID_BangGia).ToString());
                    cls.Update();
                }
                else
                {
                    cls.Insert();
                }
            }
        }

        private void gridView4_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}
