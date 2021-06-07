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
        private void Print_SanLuong_To_May_IN(DataTable dt3)
        {
            Xtra_SanLuongToMay_IN xtr111 = new Xtra_SanLuongToMay_IN();

            DataSet_TinLuong ds = new DataSet_TinLuong();
            ds.tbNhapKho_XuatKho.Clone();
            ds.tbNhapKho_XuatKho.Clear();
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                DataRow _ravi = ds.tbNhapKho_XuatKho.NewRow();
                _ravi["STT"] = (i + 1).ToString();
                int ID_VTHH = Convert.ToInt32(dt3.Rows[i]["ID_VTHH"].ToString());
                clsTbVatTuHangHoa cls = new clsTbVatTuHangHoa();
                cls.iID_VTHH = ID_VTHH;
                DataTable dt = cls.SelectOne();
                _ravi["SoLuong"] = Convert.ToDouble(dt3.Rows[i]["SoLuong"].ToString());
                _ravi["DonGia"] = Convert.ToDouble(dt3.Rows[i]["DonGia"].ToString());
                _ravi["MaVT"] = cls.sMaVT.Value;
                _ravi["TenVTHH"] = cls.sTenVTHH.Value;
                _ravi["DonViTinh"] = cls.sDonViTinh.Value;
                _ravi["ThanhTien"] = Convert.ToDouble(dt3.Rows[i]["SoLuong"].ToString()) * Convert.ToDouble(dt3.Rows[i]["DonGia"].ToString());
                _ravi["GhiChu"] = dt3.Rows[i]["GhiChu"].ToString();
                ds.tbNhapKho_XuatKho.Rows.Add(_ravi);
            }

            xtr111.DataSource = null;
            xtr111.DataSource = ds.tbNhapKho_XuatKho;
            xtr111.DataMember = "tbNhapKho_XuatKho";
            // xtr111.IntData(sgiamdoc);
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
                Print_SanLuong_To_May_IN(SanLuong_To_May_IN.mdtPrint);
        }

        private void frmPrint_SanLuongToMayIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            SanLuong_To_May_IN.mbPrint_ALL = false;
             
        }
    }
}
