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
    public partial class frmPrint_SanLuongToMayIn : Form
    {
        private void Print_SanLuong_To_May_IN(DataTable dt3, DateTime xxtungay, DateTime xxdenngay)
        {
            Xtra_SanLuongToMay_IN xtr111 = new Xtra_SanLuongToMay_IN();
            DataSet_TinLuong ds = new DataSet_TinLuong();
            ds.tbChiTietPhieuSanXuat.Clone();
            ds.tbChiTietPhieuSanXuat.Clear();
            for (int i = 0; i < dt3.Rows.Count; i++)
            {

                int ID_VTHHxx = Convert.ToInt32(dt3.Rows[i]["ID_VTHH_Ra"].ToString());
                clsTbVatTuHangHoa clsxx = new clsTbVatTuHangHoa();
                clsxx.iID_VTHH = ID_VTHHxx;
                DataTable dtxx = clsxx.SelectOne();
                string xxmavt, xxtenvt, xxdvt;
                xxmavt = clsxx.sMaVT.Value;
                xxtenvt = clsxx.sTenVTHH.Value;
                xxdvt = clsxx.sDonViTinh.Value;
                double sanluongthuowng = Convert.ToDouble(dt3.Rows[i]["SanLuong_Thuong"].ToString());
                double sanluongtangca = Convert.ToDouble(dt3.Rows[i]["SanLuong_TangCa"].ToString());
                double sanluongtong = Convert.ToDouble(dt3.Rows[i]["SanLuong_Tong"].ToString());
                double phepham = Convert.ToDouble(dt3.Rows[i]["PhePham"].ToString());
                clsPhieu_ChiTietPhieu_New cls = new clsPhieu_ChiTietPhieu_New();
                DataTable dtchitiet = new DataTable();
                dtchitiet = cls.SelectAll_W_ID_VTHH_Ra_TenCN_NgayThang_IN(ID_VTHHxx, xxtungay, xxdenngay);

                for (int k = 0; k < dtchitiet.Rows.Count; k++)
                {
                    DataRow _ravi = ds.tbChiTietPhieuSanXuat.NewRow();
                    _ravi["MaVT_Ra_IN"] = xxmavt;
                    _ravi["DonViTinh_Ra_IN"] = xxdvt;
                    _ravi["TenVatTu_Ra_IN"] = xxtenvt;
                    _ravi["STT"] = (k + 1).ToString();
                    _ravi["SanLuong_Thuong_CAT"] = sanluongthuowng;
                    _ravi["SanLuong_TangCa_CAT"] = sanluongtangca;
                    _ravi["SoLuong_Ra_CAT"] = sanluongtong;
                    _ravi["PhePham_CAT"] = phepham;
                    DateTime ngaysanxuat = Convert.ToDateTime(dtchitiet.Rows[k]["NgaySanXuat"].ToString());
                    _ravi["MaPhieu"] = dtchitiet.Rows[k]["MaPhieu"].ToString();
                    _ravi["SanLuong_Thuong_IN"] = Convert.ToDouble(dtchitiet.Rows[k]["SanLuong_Thuong"].ToString());
                    _ravi["SanLuong_TangCa_IN"] = Convert.ToDouble(dtchitiet.Rows[k]["SanLuong_TangCa"].ToString());
                    _ravi["SoLuong_Ra_IN"] = Convert.ToDouble(dtchitiet.Rows[k]["SanLuong_Tong"].ToString());
                    _ravi["PhePham_IN"] = Convert.ToDouble(dtchitiet.Rows[k]["PhePham"].ToString());
                    _ravi["NgaySanXuat_IN"] = ngaysanxuat.ToString("dd/MM/yyyy");
                    _ravi["CaSanXuat_IN"] = dtchitiet.Rows[k]["CaSanXuat"].ToString();
                    _ravi["CongNhan_IN"] = dtchitiet.Rows[k]["TenNhanVien"].ToString();
                    _ravi["MaMay_IN"] = dtchitiet.Rows[k]["MaMay"].ToString();
                    ds.tbChiTietPhieuSanXuat.Rows.Add(_ravi);
                }

            }

            xtr111.DataSource = null;
            xtr111.DataSource = ds.tbChiTietPhieuSanXuat;
            xtr111.DataMember = "tbChiTietPhieuSanXuat";
            xtr111.CreateDocument();
            documentViewer1.DocumentSource = xtr111;
        }
        public frmPrint_SanLuongToMayIn()
        {
            InitializeComponent();
        }

        private void frmPrint_SanLuongToMayIn_Load(object sender, EventArgs e)
        {
            if (SanLuong_To_May_IN.mbPrint_ALL == true)
                Print_SanLuong_To_May_IN(SanLuong_To_May_IN.mdtPrint, SanLuong_To_May_IN.mdatungay, SanLuong_To_May_IN.mdadenngay);
        }

        private void frmPrint_SanLuongToMayIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            SanLuong_To_May_IN.mbPrint_ALL = false;
             
        }
    }
}
