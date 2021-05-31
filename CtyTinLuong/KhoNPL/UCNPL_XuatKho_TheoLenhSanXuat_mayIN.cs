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
    public partial class UCNPL_XuatKho_TheoLenhSanXuat_mayIN : UserControl
    {
        public static int mID_iD_LenhSanXuat;

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
        private void HienThiGridControl_2(int xxID_lenhsanxuat)
        {

            DataTable dt2 = new DataTable();
            clsHUU_LenhSanXuat_ChiTietLenhSanXuat cls2 = new CtyTinLuong.clsHUU_LenhSanXuat_ChiTietLenhSanXuat();
            cls2.iID_LenhSanXuat = xxID_lenhsanxuat;
            DataTable dtxxxx = cls2.SelectAll_w_iID_LenhSanXuat();         
            dt2.Columns.Add("ID_VTHH", typeof(int));          
            dt2.Columns.Add("MaVT", typeof(string));          
            dt2.Columns.Add("DonViTinh", typeof(string));        
            dt2.Columns.Add("TenVTHH", typeof(string));           
            dt2.Columns.Add("SoLuong", typeof(float));               
            dt2.Columns.Add("HienThi", typeof(string));
            dt2.Columns.Add("DonGia", typeof(float));           
            dt2.Columns.Add("ThanhTien", typeof(float));
            clsTbVatTuHangHoa clsVT_Vao = new clsTbVatTuHangHoa();
          
            for (int i = 0; i < dtxxxx.Rows.Count; i++)
            {
                double soluong, dongia;
                DataRow _ravi = dt2.NewRow();              
                int iiDI_Vthh_vao = Convert.ToInt16(dtxxxx.Rows[i]["ID_VTHHVao"].ToString());
                _ravi["ID_VTHH"] = iiDI_Vthh_vao;
                clsVT_Vao.iID_VTHH = Convert.ToInt16(dtxxxx.Rows[i]["ID_VTHHVao"].ToString());
                DataTable dtVT_vao = clsVT_Vao.SelectOne();
                _ravi["MaVT"] = iiDI_Vthh_vao;
                _ravi["DonViTinh"] = clsVT_Vao.sDonViTinh.Value;
                _ravi["TenVTHH"] = clsVT_Vao.sTenVTHH.Value;
                _ravi["SoLuong"] = Convert.ToDouble(dtxxxx.Rows[i]["SoLuongVao"].ToString());
                _ravi["DonGia"] = Convert.ToDouble(dtxxxx.Rows[i]["DonGiaVao"].ToString());              
                soluong = Convert.ToDouble(dtxxxx.Rows[i]["SoLuongVao"].ToString());
                dongia = Convert.ToDouble(dtxxxx.Rows[i]["DonGiaVao"].ToString());
                _ravi["ThanhTien"] = soluong * dongia;
                _ravi["HienThi"] = "1";             
                dt2.Rows.Add(_ravi);
            }
            
            gridControl2.DataSource = dt2;
        }
        private void HienThi(DateTime xxtungay, DateTime xxdenngay)
        {
            clsHUU_LenhSanXuat cls = new clsHUU_LenhSanXuat();
            DataTable dt2xx = cls.SelectAll_XuatkhoNPL();
            dt2xx.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=false";
            DataView dv22xxx = dt2xx.DefaultView;
            DataTable dt = dv22xxx.ToTable();
            dt.DefaultView.RowFilter = " NgayThangSanXuat<='" + xxdenngay + "'";
            DataView dvxxx = dt.DefaultView;
            DataTable dt22 = dvxxx.ToTable();
            dt22.DefaultView.RowFilter = " NgayThangSanXuat>='" + xxtungay + "'";
            DataView dv2 = dt22.DefaultView;
            dv2.Sort = "NgayThangSanXuat DESC, CaSanXuat DESC, ID_LenhSanXuat DESC";
            DataTable dxxxx = dv2.ToTable();
            gridControl1.DataSource = dxxxx;

        }
       
        private void HienThi_ALL()
        {
            clsHUU_LenhSanXuat cls = new clsHUU_LenhSanXuat();
            DataTable dt = cls.SelectAll_XuatkhoNPL();
            dt.DefaultView.RowFilter = " TonTai= True";
            DataView dv = dt.DefaultView;
            dv.Sort = "NgayThangSanXuat DESC, CaSanXuat DESC, ID_LenhSanXuat DESC";
            DataTable dxxxx = dv.ToTable();
            gridControl1.DataSource = dxxxx;
        }
        public UCNPL_XuatKho_TheoLenhSanXuat_mayIN()
        {
            InitializeComponent();
        }

        private void UCNPL_XuatKho_TheoLenhSanXuat_mayIN_Load(object sender, EventArgs e)
        {
            Load_LockUp();
            dteDenNgay.EditValue = null;
            dteTuNgay.EditValue = null;
            HienThi_ALL();
        }

        private void btfresh_Click(object sender, EventArgs e)
        {
            UCNPL_XuatKho_TheoLenhSanXuat_mayIN_Load(sender, e);
        }
        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.GetFocusedRowCellValue(clID_LenhSanXuat).ToString() != "")
                {

                    mID_iD_LenhSanXuat = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_LenhSanXuat).ToString());
                    NPL_ChiTietLenhSanXuat ff = new NPL_ChiTietLenhSanXuat();
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

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            if (dteDenNgay.EditValue != null & dteTuNgay.EditValue != null)
            {
                HienThi(dteTuNgay.DateTime, dteDenNgay.DateTime.AddDays(1));
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(clID_LenhSanXuat).ToString() != "")
            {
                int iiIDnhapKhp = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clID_LenhSanXuat).ToString());
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
    }
}
