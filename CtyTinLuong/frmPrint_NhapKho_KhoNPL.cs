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
    public partial class frmPrint_NhapKho_KhoNPL : Form
    {
        public frmPrint_NhapKho_KhoNPL()
        {
            InitializeComponent();
        }

        private void frmPrint_NhapKho_KhoNPL_Load(object sender, EventArgs e)
        {
            DataTable dt3 = new DataTable();
           if(KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.mbPrint_Chitiet_Da_NhapKho_TuMuaHang == false)
             dt3 = KhoNPL_frmChiTiet_MuaHang_NhapKho.mdt_ChiTietNhapKho;
           else dt3 = KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.mdt_ChiTietNhapKho;
            Xtra_NhapKho xtr111 = new Xtra_NhapKho();
            DataTable mdt_ChiTietNhapKho = new DataTable();
            mdt_ChiTietNhapKho.Columns.Add("STT");
            mdt_ChiTietNhapKho.Columns.Add("SoLuong", typeof(double));
            mdt_ChiTietNhapKho.Columns.Add("DonGia", typeof(double));
            mdt_ChiTietNhapKho.Columns.Add("MaVT");// tb VTHH
            mdt_ChiTietNhapKho.Columns.Add("TenVTHH");
            mdt_ChiTietNhapKho.Columns.Add("DonViTinh");
            mdt_ChiTietNhapKho.Columns.Add("ThanhTien", typeof(double));
            mdt_ChiTietNhapKho.Columns.Add("GhiChu", typeof(string));
           
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
    }
}
