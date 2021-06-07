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
    public partial class SanLuong_To_May_IN : Form
    {

        public static string xxsotrang;
        public static DateTime mdatungay, mdadenngay;

        private int _SoTrang = 1;
        private bool isload = false;
        public void LoadData(int sotrang, bool isLoadLanDau, DateTime xxtungay, DateTime xxdenngay)
        {
            gridControl1.DataSource = null;
            isload = true;
            _SoTrang = sotrang;
            DataTable dt2 = new DataTable();
            dt2 = new DataTable();
         
            dt2.Columns.Add("ID_VTHH_Ra", typeof(string));         
            dt2.Columns.Add("MaVT_Ra", typeof(string));           
            dt2.Columns.Add("DonViTinh_Ra", typeof(string));         
            dt2.Columns.Add("TenVatTu_Ra", typeof(string));           
             
            dt2.Columns.Add("SanLuong_Tong", typeof(double));
            dt2.Columns.Add("SanLuong_Thuong", typeof(double));
            dt2.Columns.Add("SanLuong_TangCa", typeof(double));
            dt2.Columns.Add("PhePham", typeof(double));

            clsTbVatTuHangHoa clsvt = new clsTbVatTuHangHoa();           
            
            clsPhieu_ChiTietPhieu_New cls = new clsPhieu_ChiTietPhieu_New();            
           

            DataTable dtID_VTHH_Ra = cls.SelectAll_distinct_W_ID_VTHH_Ra();
            if (dtID_VTHH_Ra.Rows.Count > 0)
            {
                for (int i = 0; i < dtID_VTHH_Ra.Rows.Count; i++)
                {
                    int ID_VTHH_Raxx = Convert.ToInt32(dtID_VTHH_Ra.Rows[i]["ID_VTHH_Ra"].ToString());
                    cls.iID_VTHH_Ra = ID_VTHH_Raxx;
                    DataTable dt_IN = cls.Select_SUM_SanLuong_W_IDVTHH_NgayThang_IN(ID_VTHH_Raxx, xxtungay, xxdenngay);
                    if(dt_IN.Rows.Count>0)
                    {
                        if(Convert.ToDouble(dt_IN.Rows[0]["SanLuong_Tong"].ToString())>0)
                        {
                            DataRow _ravi = dt2.NewRow();
                            clsvt.iID_VTHH = ID_VTHH_Raxx;
                            DataTable dtvt_Ra = clsvt.SelectOne();
                            string MaVT_Ra = clsvt.sMaVT.Value;
                            string DonViTinh_Ra = clsvt.sDonViTinh.Value;
                            string TenVatTu_Ra = clsvt.sTenVTHH.Value;

                            _ravi["ID_VTHH_Ra"] = ID_VTHH_Raxx;
                            _ravi["MaVT_Ra"] = MaVT_Ra;
                            _ravi["DonViTinh_Ra"] = DonViTinh_Ra;
                            _ravi["TenVatTu_Ra"] = TenVatTu_Ra;
                            _ravi["SanLuong_Tong"] = Convert.ToDouble(dt_IN.Rows[0]["SanLuong_Tong"].ToString());
                            _ravi["SanLuong_Thuong"] = Convert.ToDouble(dt_IN.Rows[0]["SanLuong_Thuong"].ToString());
                            _ravi["SanLuong_TangCa"] = Convert.ToDouble(dt_IN.Rows[0]["SanLuong_TangCa"].ToString());
                            _ravi["PhePham"] = Convert.ToDouble(dt_IN.Rows[0]["PhePham"].ToString());
                            dt2.Rows.Add(_ravi);
                        }
                        
                    }
                   
                }
                gridControl1.DataSource = dt2;
            }

            isload = false;
        }
        private void Load_PhieuSX(bool islandau)
        {
            int sotrang_ = 1;
            try
            {
                sotrang_ = Convert.ToInt32(txtSoTrang.Text);
            }
            catch
            {
                sotrang_ = 1;
                txtSoTrang.Text = "1";
            }
            LoadData(sotrang_, true, dteTuNgay.DateTime, dteDenNgay.DateTime);
        }
        public void ResetSoTrang(DateTime xxtungay, DateTime xxdenngay)
        {

            btnTrangSau.Visible = true;
            btnTrangTiep.Visible = true;
            lbTongSoTrang.Visible = true;
            txtSoTrang.Visible = true;
            btnTrangSau.LinkColor = Color.Black;
            btnTrangTiep.LinkColor = Color.Blue;
            txtSoTrang.Text = "1";

            using (clsPhieu_tbPhieu cls = new clsPhieu_tbPhieu())
            {
                DataTable dt_ = cls.SelectAll_Tinh_SoPhieu_new(xxtungay, xxdenngay);
                if (dt_ != null && dt_.Rows.Count > 0)
                {
                    lbTongSoTrang.Text = "/" + (Math.Ceiling(Convert.ToDouble(dt_.Rows[0]["tongso"].ToString()) / (double)20)).ToString();
                }
                else
                {
                    lbTongSoTrang.Text = "/1";
                }
            }
            if (lbTongSoTrang.Text == "0")
                lbTongSoTrang.Text = "/1";
            if (lbTongSoTrang.Text == "/1")
            {
                btnTrangSau.LinkColor = Color.Black;
                btnTrangTiep.LinkColor = Color.Black;
            }
        }

        public static DateTime GetFistDayInMonth(int year, int month)
        {
            DateTime aDateTime = new DateTime(year, month, 1);
            return aDateTime;
        }
        public SanLuong_To_May_IN()
        {
            InitializeComponent();
        }

        private void btnTrangTiep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isload)
                return;
            if (btnTrangTiep.LinkColor == Color.Black)
                return;
            if (btnTrangSau.LinkColor == Color.Black)
                btnTrangSau.LinkColor = Color.Blue;

            int sotrang_;
            try
            {
                sotrang_ = Convert.ToInt32(txtSoTrang.Text);
                int max_ = Convert.ToInt32(lbTongSoTrang.Text.Replace(" ", "").Replace("/", ""));
                if (sotrang_ < max_)
                {
                    txtSoTrang.Text = (sotrang_ + 1).ToString();

                    Load_PhieuSX(false);
                }
                else
                {
                    txtSoTrang.Text = (max_).ToString();
                    btnTrangTiep.LinkColor = Color.Black;
                }
            }
            catch
            {
                btnTrangTiep.LinkColor = Color.Black;
                sotrang_ = 1;
                txtSoTrang.Text = "1";
            }
        }

        private void btnTrangSau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isload)
                return;
            if (btnTrangSau.LinkColor == Color.Black)
                return;
            if (btnTrangTiep.LinkColor == Color.Black)
                btnTrangTiep.LinkColor = Color.Blue;

            int sotrang_;
            try
            {
                sotrang_ = Convert.ToInt32(txtSoTrang.Text);
                if (sotrang_ <= 1)
                {
                    txtSoTrang.Text = "1";
                    btnTrangSau.LinkColor = Color.Black;

                }
                else
                {
                    txtSoTrang.Text = (sotrang_ - 1).ToString();
                    Load_PhieuSX(false);
                }
            }
            catch
            {
                btnTrangSau.LinkColor = Color.Black;
                sotrang_ = 1;
                txtSoTrang.Text = "1";
            }
        }

        private void txtSoTrang_TextChanged(object sender, EventArgs e)
        {
            if (isload)
                return;
            Load_PhieuSX(false);
        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            ResetSoTrang(dteTuNgay.DateTime, dteDenNgay.DateTime);
            LoadData(1, true, dteTuNgay.DateTime, dteDenNgay.DateTime);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SanLuong_To_May_IN_Load(object sender, EventArgs e)
        {
            DateTime ngayhomnay = DateTime.Today;
            int nam = Convert.ToInt16(ngayhomnay.ToString("yyyy"));
            int thang = Convert.ToInt16(ngayhomnay.ToString("MM"));

            dteDenNgay.DateTime = DateTime.Today;
            dteTuNgay.DateTime= GetFistDayInMonth(nam, thang);

            LoadData(1, true, dteTuNgay.DateTime, dteDenNgay.DateTime);

            ResetSoTrang(dteTuNgay.DateTime, dteDenNgay.DateTime);
        }
    }
}
