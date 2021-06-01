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
    public partial class frmPrint_Nhap_Xuat_Kho : Form
    {
        public frmPrint_Nhap_Xuat_Kho()
        {
            InitializeComponent();
        }

        private void Xuat_Kho_NPL_Khac(DataTable dt3)
        {


            Xtra_Nhap_XuatKho xtr111 = new Xtra_Nhap_XuatKho();

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
        private void NhapKho_NPL(DataTable dt3)
        {
          
           
            Xtra_Nhap_XuatKho xtr111 = new Xtra_Nhap_XuatKho();       

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

        private void Xuat_Kho_NPL(DataTable dt3)
        {


            Xtra_Nhap_XuatKho xtr111 = new Xtra_Nhap_XuatKho();

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
                _ravi["SoLuong"] = Convert.ToDouble(dt3.Rows[i]["SoLuongXuat"].ToString());
                _ravi["DonGia"] = Convert.ToDouble(dt3.Rows[i]["DonGia"].ToString());
                _ravi["MaVT"] = cls.sMaVT.Value;
                _ravi["TenVTHH"] = cls.sTenVTHH.Value;
                _ravi["DonViTinh"] = cls.sDonViTinh.Value;
                _ravi["ThanhTien"] = Convert.ToDouble(dt3.Rows[i]["SoLuongXuat"].ToString()) * Convert.ToDouble(dt3.Rows[i]["DonGia"].ToString());
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
        private void frmPrint_NhapKho_Load(object sender, EventArgs e)
        {
            if (KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.mbPrint == true)
                NhapKho_NPL(KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.mdtPrint);
            if (KhoNPL_ChiTiet_NhapKho_Khac.mbPrint == true)
                NhapKho_NPL(KhoNPL_ChiTiet_NhapKho_Khac.mdtPrint);
            if (frmKhoNPL_DaXuatKho.mbPrint == true)
                Xuat_Kho_NPL(frmKhoNPL_DaXuatKho.mdtPrint);
            if (KhoNPL_ChiTiet_XuatKho_Khac.mbPrint == true)
                Xuat_Kho_NPL_Khac(KhoNPL_ChiTiet_XuatKho_Khac.mdtPrint);
        }

        private void frmPrint_Nhap_Xuat_Kho_FormClosed(object sender, FormClosedEventArgs e)
        {
            KhoNPL_frmChiTiet_Da_NhapKho_TuMuaHang.mbPrint = false;
            KhoNPL_ChiTiet_NhapKho_Khac.mbPrint = false;
            frmKhoNPL_DaXuatKho.mbPrint = false;
            KhoNPL_ChiTiet_XuatKho_Khac.mbPrint = false;
        }
    }
}
