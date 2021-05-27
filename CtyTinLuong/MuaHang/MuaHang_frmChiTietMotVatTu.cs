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
    public partial class MuaHang_frmChiTietMotVatTu : Form
    {
        private void HienThi(int xxID_VTHH, DateTime xxtungay, DateTime xxdenngay)
        {

            DataTable dt2 = new DataTable();

            dt2.Columns.Add("SoChungTu", typeof(string));
            dt2.Columns.Add("DienGiai", typeof(string));
            dt2.Columns.Add("SoLuong", typeof(double));
            dt2.Columns.Add("DonGia", typeof(double));
            dt2.Columns.Add("ThanhTien", typeof(double));
            dt2.Columns.Add("NgayChungTu", typeof(DateTime));
            clsMH_tbChiTietMuaHang cls = new CtyTinLuong.clsMH_tbChiTietMuaHang();
            cls.iID_VTHH = xxID_VTHH;
            DataTable dt = cls.SelectAll_W_ID_VTHH_SoChungTu_NgayThang_DienGiai();
            dt.DefaultView.RowFilter = " NgayChungTu<='" + xxdenngay + "'";
            DataView dv = dt.DefaultView;
            DataTable dt22 = dv.ToTable();
            dt22.DefaultView.RowFilter = " NgayChungTu>='" + xxtungay + "'";
            DataView dv2 = dt22.DefaultView;
            dv2.Sort = "NgayChungTu DESC";
            DataTable dxxxx = dv2.ToTable();
            for (int i = 0; i < dxxxx.Rows.Count; i++)
            {
                double DonGia = Convert.ToDouble(dxxxx.Rows[i]["DonGia"].ToString());
                double SoLuong = Convert.ToDouble(dxxxx.Rows[i]["SoLuong"].ToString());
                DataRow _ravi = dt2.NewRow();
               
                _ravi["SoChungTu"] = dxxxx.Rows[i]["SoChungTu"].ToString();
                _ravi["DienGiai"] = dxxxx.Rows[i]["DienGiai"].ToString();
                _ravi["SoLuong"] = SoLuong;
                _ravi["NgayChungTu"] = Convert.ToDateTime(dxxxx.Rows[i]["NgayChungTu"].ToString());               
                _ravi["DonGia"] = DonGia;
                _ravi["ThanhTien"] = SoLuong * DonGia;
                dt2.Rows.Add(_ravi);
            }
            gridControl1.DataSource = dt2;


        }
        private void HienThi_ALL(int xxID_VTHH)
        {
            DataTable dt2 = new DataTable();
          
            dt2.Columns.Add("SoChungTu", typeof(string));
            dt2.Columns.Add("DienGiai", typeof(string));
            dt2.Columns.Add("SoLuong", typeof(double));           
            dt2.Columns.Add("DonGia", typeof(double));
            dt2.Columns.Add("ThanhTien", typeof(double));
            dt2.Columns.Add("NgayChungTu", typeof(DateTime));

            //NgayThang

            clsMH_tbChiTietMuaHang cls = new CtyTinLuong.clsMH_tbChiTietMuaHang();
            cls.iID_VTHH = xxID_VTHH;
            DataTable dxxxx = cls.SelectAll_W_ID_VTHH_SoChungTu_NgayThang_DienGiai();
        
            for (int i = 0; i < dxxxx.Rows.Count; i++)
            {
                double DonGia = Convert.ToDouble(dxxxx.Rows[i]["DonGia"].ToString());
                double SoLuong = Convert.ToDouble(dxxxx.Rows[i]["SoLuong"].ToString());
                DataRow _ravi = dt2.NewRow();                
                _ravi["SoChungTu"] = dxxxx.Rows[i]["SoChungTu"].ToString();
                _ravi["DienGiai"] = dxxxx.Rows[i]["DienGiai"].ToString();
                _ravi["SoLuong"] = SoLuong;
                _ravi["NgayChungTu"] = Convert.ToDateTime(dxxxx.Rows[i]["NgayChungTu"].ToString());               
                _ravi["DonGia"] = DonGia;
                _ravi["ThanhTien"] = SoLuong * DonGia;
                dt2.Rows.Add(_ravi);
            }
            gridControl1.DataSource = dt2;


        }
        public MuaHang_frmChiTietMotVatTu()
        {
            InitializeComponent();
        }
        private void Load_Lockup()
        {

            clsTbVatTuHangHoa clsvthhh = new clsTbVatTuHangHoa();
            DataTable dtvthh = clsvthhh.SelectAll();
            dtvthh.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False";
            DataView dvvthh = dtvthh.DefaultView;
            DataTable newdtvthh = dvvthh.ToTable();


            gridMaVT.Properties.DataSource = newdtvthh;
            gridMaVT.Properties.ValueMember = "ID_VTHH";
            gridMaVT.Properties.DisplayMember = "MaVT";
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MuaHang_frmChiTietMotVatTu_Load(object sender, EventArgs e)
        {
            Load_Lockup();
            gridMaVT.EditValue = UCMuaHang_ChiTietTatCa.miID_VTHH;
            dteDenNgay.EditValue = null;
            dteTuNgay.EditValue = null;
            HienThi_ALL(UCMuaHang_ChiTietTatCa.miID_VTHH);
        }

        private void gridMaVT_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsTbVatTuHangHoa cls = new clsTbVatTuHangHoa();
                int iiID = Convert.ToInt32(gridMaVT.EditValue.ToString());
                cls.iID_VTHH = iiID;
                DataTable dt = cls.SelectOne();
                txtTenVT.Text = cls.sTenVTHH.Value;
                txtDVT.Text = cls.sDonViTinh.Value;
            }
            catch
            { }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            MuaHang_frmChiTietMotVatTu_Load( sender,  e);
        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            if (dteDenNgay.EditValue != null & dteTuNgay.EditValue != null)
            {
                HienThi(UCMuaHang_ChiTietTatCa.miID_VTHH,dteTuNgay.DateTime, dteDenNgay.DateTime.AddDays(1));
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
