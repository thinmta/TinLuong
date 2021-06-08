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
    public partial class frmPrintChiTietPhieuSanXuat_BaoCaoSanLuong_TheoNgay : Form
    {
        private void Printxxxxxxxx_frmBaoCaoSanLuong_Theo_CongNhan()
        {
            Xtra_BaoCaoSanLuong_TheoCongNhan xtr111 = new Xtra_BaoCaoSanLuong_TheoCongNhan();
            DataTable dt3 = new DataTable();
            //dt3 = frmBaoCaoSanLuong_Theo_CongNhan.mdtPrint_tbChiTietPhieu_baoCaoSanLuongTheoCongNhan;

            DataSet_TinLuong ds = new DataSet_TinLuong();
            ds.tbChiTietPhieuSanXuat.Clone();
            ds.tbChiTietPhieuSanXuat.Clear();
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                string strNgaySanXuat_INxxx;
                if (dt3.Rows[i]["NgaySanXuat"].ToString() == "")
                    strNgaySanXuat_INxxx = "";
                else
                {
                    DateTime dteNgaySanXuat_IN = Convert.ToDateTime(dt3.Rows[i]["NgaySanXuat"].ToString());
                    strNgaySanXuat_INxxx = dteNgaySanXuat_IN.ToString("dd/MM/yyyy");
                }

                double SoLuong_Vao_IN, SoLuong_Ra_IN, PhePham_IN;

                if (dt3.Rows[i]["SoLuong_Vao"].ToString() == "")
                    SoLuong_Vao_IN = 0;
                else SoLuong_Vao_IN = Convert.ToDouble(dt3.Rows[i]["SoLuong_Vao"].ToString());

                if (dt3.Rows[i]["SanLuong_Tong"].ToString() == "")
                    SoLuong_Ra_IN = 0;
                else SoLuong_Ra_IN = Convert.ToDouble(dt3.Rows[i]["SanLuong_Tong"].ToString());

                if (dt3.Rows[i]["PhePham"].ToString() == "")
                    PhePham_IN = 0;
                else PhePham_IN = Convert.ToDouble(dt3.Rows[i]["PhePham"].ToString());

                DataRow _ravi = ds.tbChiTietPhieuSanXuat.NewRow();
                _ravi["STT"] = (i + 1).ToString();
                _ravi["MaPhieu"] = dt3.Rows[i]["MaPhieu"].ToString();
                _ravi["CongNhan_IN"] = dt3.Rows[i]["CongNhan"].ToString();
                _ravi["MaVT_Vao_IN"] = dt3.Rows[i]["MaVT_Vao"].ToString();
                _ravi["MaVT_Ra_IN"] = dt3.Rows[i]["MaVT_Ra"].ToString();
                _ravi["DonViTinh_Vao_IN"] = dt3.Rows[i]["DonViTinh_Vao"].ToString();
                _ravi["DonViTinh_Ra_IN"] = dt3.Rows[i]["DonViTinh_Ra"].ToString();
                _ravi["TenVatTu_Vao_IN"] = dt3.Rows[i]["TenVatTu_Vao"].ToString();
                _ravi["TenVatTu_Ra_IN"] = dt3.Rows[i]["TenVatTu_Ra"].ToString();
                _ravi["SoLuong_Vao_IN"] = SoLuong_Vao_IN;
                _ravi["SoLuong_Ra_IN"] = SoLuong_Ra_IN;
                _ravi["PhePham_IN"] = PhePham_IN;
                _ravi["NgaySanXuat_IN"] = strNgaySanXuat_INxxx;
                _ravi["CaSanXuat_IN"] = dt3.Rows[i]["CaSanXuat"].ToString();
                //_ravi["DinhMuc_KhongTang"] = dt3.Rows[i]["DinhMuc_KhongTang"].ToString();
                //_ravi["DinhMuc_Tang"] = dt3.Rows[i]["DinhMuc_Tang"].ToString();
                _ravi["MaMay_IN"] = dt3.Rows[i]["MaMay"].ToString();
                _ravi["SanLuong_Thuong_IN"] = dt3.Rows[i]["SanLuong_Thuong"].ToString();
                _ravi["SanLuong_TangCa_IN"] = dt3.Rows[i]["SanLuong_TangCa"].ToString();
                ds.tbChiTietPhieuSanXuat.Rows.Add(_ravi);
            }

            xtr111.DataSource = null;
            xtr111.DataSource = ds.tbChiTietPhieuSanXuat;
            xtr111.DataMember = "tbChiTietPhieuSanXuat";
            // xtr111.IntData(sgiamdoc);
            xtr111.CreateDocument();
            documentViewer1.DocumentSource = xtr111;
        }
   
        public frmPrintChiTietPhieuSanXuat_BaoCaoSanLuong_TheoNgay()
        {
            InitializeComponent();
        }

        private void frmPrintChiTietPhieuSanXuat_BaoCaoSanLuong_TheoNgay_Load(object sender, EventArgs e)
        {
         
        }

        private void frmPrintChiTietPhieuSanXuat_BaoCaoSanLuong_TheoNgay_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
