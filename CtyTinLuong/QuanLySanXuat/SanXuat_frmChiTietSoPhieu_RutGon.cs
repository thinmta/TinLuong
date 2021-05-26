using DevExpress.Data.Filtering;
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
    public partial class SanXuat_frmChiTietSoPhieu_RutGon : Form
    {
        public static DataTable mdtPrint_tbChiTietPhieu;


        private void HienThi()
        {
            gridControl1.DataSource = null;
            if (dteTuNgay.EditValue != null & dteDenNgay.EditValue != null)
            {
                DateTime denngay = dteDenNgay.DateTime;
                DateTime tungay = dteTuNgay.DateTime;
              

                DataTable dt2 = new DataTable();
                dt2.Columns.Add("ID_SoPhieu", typeof(int));
                dt2.Columns.Add("MaPhieu", typeof(string));

                dt2.Columns.Add("ID_VTHH_Vao_IN", typeof(string));
                dt2.Columns.Add("ID_VTHH_Ra_IN", typeof(string));
                dt2.Columns.Add("MaVT_Vao_IN", typeof(string));
                dt2.Columns.Add("MaVT_Ra_IN", typeof(string));
                dt2.Columns.Add("DonViTinh_Vao_IN", typeof(string));
                dt2.Columns.Add("DonViTinh_Ra_IN", typeof(string));
                dt2.Columns.Add("TenVatTu_Vao_IN", typeof(string));
                dt2.Columns.Add("TenVatTu_Ra_IN", typeof(string));
                dt2.Columns.Add("SoLuong_Vao_IN", typeof(string));
                dt2.Columns.Add("SoLuong_Ra_IN", typeof(string));
                dt2.Columns.Add("PhePham_IN", typeof(string));
                dt2.Columns.Add("NgaySanXuat_IN", typeof(string));
                dt2.Columns.Add("CaSanXuat_IN", typeof(string));
                dt2.Columns.Add("CongNhan_IN", typeof(string));
                dt2.Columns.Add("MaMay_IN", typeof(string));

                dt2.Columns.Add("ID_VTHH_Vao_CAT", typeof(string));
                dt2.Columns.Add("ID_VTHH_Ra_CAT", typeof(string));
                dt2.Columns.Add("MaVT_Vao_CAT", typeof(string));
                dt2.Columns.Add("MaVT_Ra_CAT", typeof(string));
                dt2.Columns.Add("DonViTinh_Vao_CAT", typeof(string));
                dt2.Columns.Add("DonViTinh_Ra_CAT", typeof(string));
                dt2.Columns.Add("TenVatTu_Vao_CAT", typeof(string));
                dt2.Columns.Add("TenVatTu_Ra_CAT", typeof(string));
                dt2.Columns.Add("SoLuong_Vao_CAT", typeof(string));
                dt2.Columns.Add("SoLuong_Ra_CAT", typeof(string));
                dt2.Columns.Add("PhePham_CAT", typeof(string));
                dt2.Columns.Add("NgaySanXuat_CAT", typeof(string));
                dt2.Columns.Add("CaSanXuat_CAT", typeof(string));
                dt2.Columns.Add("CongNhan_CAT", typeof(string));
                dt2.Columns.Add("MaMay_CAT", typeof(string));

                dt2.Columns.Add("ID_VTHH_Vao_DOT", typeof(string));
                dt2.Columns.Add("ID_VTHH_Ra_DOT", typeof(string));
                dt2.Columns.Add("MaVT_Vao_DOT", typeof(string));
                dt2.Columns.Add("MaVT_Ra_DOT", typeof(string));
                dt2.Columns.Add("DonViTinh_Vao_DOT", typeof(string));
                dt2.Columns.Add("DonViTinh_Ra_DOT", typeof(string));
                dt2.Columns.Add("TenVatTu_Vao_DOT", typeof(string));
                dt2.Columns.Add("TenVatTu_Ra_DOT", typeof(string));
                dt2.Columns.Add("SoLuong_Vao_DOT", typeof(string));
                dt2.Columns.Add("SoLuong_Ra_DOT", typeof(string));
                dt2.Columns.Add("PhePham_DOT", typeof(string));
                dt2.Columns.Add("NgaySanXuat_DOT", typeof(string));
                dt2.Columns.Add("CaSanXuat_DOT", typeof(string));
                dt2.Columns.Add("CongNhan_DOT", typeof(string));
                dt2.Columns.Add("MaMay_DOT", typeof(string));

                clsTbVatTuHangHoa clsVT_Vao = new clsTbVatTuHangHoa();
                clsTbVatTuHangHoa clsVT_Ra = new clsTbVatTuHangHoa();
                clsNhanSu_tbNhanSu clsnhansu = new clsNhanSu_tbNhanSu();
                clsPhieu_ChiTietPhieu_New cls = new clsPhieu_ChiTietPhieu_New();
                clsPhieu_tbPhieu clsphieu = new clsPhieu_tbPhieu();
                clsT_MayMoc clsmaymoc = new clsT_MayMoc();
                DataTable daaa = clsphieu.SelectAll();


                daaa.DefaultView.RowFilter = "NgayLapPhieu<='" + denngay + "'";
                DataView dvpjieu1 = daaa.DefaultView;
                DataTable dtphieu1 = dvpjieu1.ToTable();
                dtphieu1.DefaultView.RowFilter = " NgayLapPhieu>='" + tungay + "'";
                DataView dvphieu2 = dtphieu1.DefaultView;
                DataTable dtphieu = dvphieu2.ToTable(); 

                if (dtphieu.Rows.Count > 0)
                {
                    for (int i = 0; i < dtphieu.Rows.Count; i++)
                    {
                        int ID_SoPhieu = Convert.ToInt32(dtphieu.Rows[i]["ID_SoPhieu"].ToString());

                        DataRow _ravi = dt2.NewRow();
                        _ravi["ID_SoPhieu"] = ID_SoPhieu;
                        _ravi["MaPhieu"] = dtphieu.Rows[i]["MaPhieu"].ToString();


                        cls.iID_SoPhieu = ID_SoPhieu;
                        DataTable dt12222 = cls.SelectAll_W_iID_SoPhieu();
                        if (dt12222.Rows.Count > 0)
                        {
                            // in
                            dt12222.DefaultView.RowFilter = " bMay_IN = True and NgaySanXuat<='" + denngay + "'";
                            DataView dvIn1 = dt12222.DefaultView;
                            DataTable dt22In1 = dvIn1.ToTable();
                            dt22In1.DefaultView.RowFilter = " NgaySanXuat>='" + tungay + "'";
                            DataView dv2In2 = dt22In1.DefaultView;
                            DataTable dt1 = dv2In2.ToTable();

                            // cat

                            dt12222.DefaultView.RowFilter = " bMay_CAT = True and NgaySanXuat<='" + denngay + "'";
                            DataView dvCat1 = dt12222.DefaultView;
                            DataTable dt22Cat1 = dvCat1.ToTable();
                            dt22Cat1.DefaultView.RowFilter = " NgaySanXuat>='" + tungay + "'";
                            DataView dv2Cat2 = dt22Cat1.DefaultView;
                            DataTable dtmaycat = dv2Cat2.ToTable();

                            // dot


                            dt12222.DefaultView.RowFilter = " bMay_CAT = True and NgaySanXuat<='" + denngay + "'";
                            DataView dvDot1 = dt12222.DefaultView;
                            DataTable dt22Dot1 = dvDot1.ToTable();
                            dt22Dot1.DefaultView.RowFilter = " NgaySanXuat>='" + tungay + "'";
                            DataView dv2Dot2 = dt22Dot1.DefaultView;
                            DataTable dtmaydot = dv2Dot2.ToTable();


                            if (dt1.Rows.Count > 0)
                            {
                                int ID_CongNhan = Convert.ToInt32(dt1.Rows[0]["ID_CongNhan"].ToString());
                                clsnhansu.iID_NhanSu = ID_CongNhan;
                                DataTable dtnhansu = clsnhansu.SelectOne();
                                string CongNhan = clsnhansu.sTenNhanVien.Value;
                                DateTime daNgaySanXuat = Convert.ToDateTime(dt1.Rows[0]["NgaySanXuat"].ToString());
                                string NgaySanXuat = daNgaySanXuat.ToString("dd/MM/yyyy");
                                string CaSanXuat = dt1.Rows[0]["CaSanXuat"].ToString();
                                int ID_VTHH_Vao = Convert.ToInt32(dt1.Rows[0]["ID_VTHH_Vao"].ToString());
                                clsVT_Vao.iID_VTHH = ID_VTHH_Vao;
                                DataTable dtvtvao = clsVT_Vao.SelectOne();
                                string MaVT_Vao = clsVT_Vao.sMaVT.Value;
                                string DonViTinh_Vao = clsVT_Vao.sDonViTinh.Value;
                                string TenVatTu_Vao = clsVT_Vao.sTenVTHH.Value;
                                double SoLuong_Vao = Convert.ToDouble(dt1.Rows[0]["SoLuong_Vao"].ToString());
                                int ID_VTHH_Ra = Convert.ToInt32(dt1.Rows[0]["ID_VTHH_Ra"].ToString());
                                clsVT_Ra.iID_VTHH = ID_VTHH_Ra;
                                DataTable dtvt_Ra = clsVT_Ra.SelectOne();
                                string MaVT_Ra = clsVT_Ra.sMaVT.Value;
                                string DonViTinh_Ra = clsVT_Ra.sDonViTinh.Value;
                                string TenVatTu_Ra = clsVT_Ra.sTenVTHH.Value;
                                double SanLuong_Tong = Convert.ToDouble(dt1.Rows[0]["SanLuong_Tong"].ToString());
                                double PhePham = Convert.ToDouble(dt1.Rows[0]["PhePham"].ToString());
                                int ID_Mayxxx = Convert.ToInt32(dt1.Rows[0]["ID_May"].ToString());
                                clsmaymoc.iId = ID_Mayxxx;
                                DataTable dtmay = clsmaymoc.SelectOne();
                                string MaMay_IN = clsmaymoc.sMaMay.Value;
                                // dt2.Columns.Add("MaMay_DOT", typeof(string));
                                _ravi["ID_VTHH_Vao_IN"] = ID_VTHH_Vao;
                                _ravi["ID_VTHH_Ra_IN"] = ID_VTHH_Ra;
                                _ravi["MaVT_Vao_IN"] = MaVT_Vao;
                                _ravi["MaVT_Ra_IN"] = MaVT_Ra;
                                _ravi["DonViTinh_Vao_IN"] = DonViTinh_Vao;
                                _ravi["DonViTinh_Ra_IN"] = DonViTinh_Ra;
                                _ravi["TenVatTu_Vao_IN"] = TenVatTu_Vao;
                                _ravi["TenVatTu_Ra_IN"] = TenVatTu_Ra;
                                _ravi["SoLuong_Vao_IN"] = SoLuong_Vao.ToString();
                                _ravi["SoLuong_Ra_IN"] = SanLuong_Tong.ToString();
                                _ravi["PhePham_IN"] = PhePham;
                                _ravi["NgaySanXuat_IN"] = NgaySanXuat;
                                _ravi["CaSanXuat_IN"] = CaSanXuat;
                                _ravi["CongNhan_IN"] = CongNhan;
                                _ravi["MaMay_IN"] = MaMay_IN;
                            }
                            //else
                            //{
                            //    _ravi["ID_VTHH_Vao_IN"] = "";
                            //    _ravi["ID_VTHH_Ra_IN"] = "";
                            //    _ravi["MaVT_Vao_IN"] = "";
                            //    _ravi["MaVT_Ra_IN"] = "";
                            //    _ravi["DonViTinh_Vao_IN"] = "";
                            //    _ravi["DonViTinh_Ra_IN"] = "";
                            //    _ravi["TenVatTu_Vao_IN"] = "";
                            //    _ravi["TenVatTu_Ra_IN"] = "";
                            //    _ravi["SoLuong_Vao_IN"] = "";
                            //    _ravi["SoLuong_Ra_IN"] = "";
                            //    _ravi["PhePham_IN"] = "";
                            //    _ravi["NgaySanXuat_IN"] = "";
                            //    _ravi["CaSanXuat_IN"] = "";
                            //    _ravi["CongNhan_IN"] = "";
                            //    _ravi["MaMay_IN"] = "";
                            //}
                            if (dtmaycat.Rows.Count > 0)
                            {
                                int ID_CongNhan = Convert.ToInt32(dtmaycat.Rows[0]["ID_CongNhan"].ToString());
                                clsnhansu.iID_NhanSu = ID_CongNhan;
                                DataTable dtnhansu = clsnhansu.SelectOne();
                                string CongNhan = clsnhansu.sTenNhanVien.Value;
                                DateTime daNgaySanXuat = Convert.ToDateTime(dtmaycat.Rows[0]["NgaySanXuat"].ToString());
                                string NgaySanXuat = daNgaySanXuat.ToString("dd/MM/yyyy");
                                string CaSanXuat = dtmaycat.Rows[0]["CaSanXuat"].ToString();
                                int ID_VTHH_Vao = Convert.ToInt32(dtmaycat.Rows[0]["ID_VTHH_Vao"].ToString());
                                clsVT_Vao.iID_VTHH = ID_VTHH_Vao;
                                DataTable dtvtvao = clsVT_Vao.SelectOne();
                                string MaVT_Vao = clsVT_Vao.sMaVT.Value;
                                string DonViTinh_Vao = clsVT_Vao.sDonViTinh.Value;
                                string TenVatTu_Vao = clsVT_Vao.sTenVTHH.Value;
                                double SoLuong_Vao = Convert.ToDouble(dtmaycat.Rows[0]["SoLuong_Vao"].ToString());
                                int ID_VTHH_Ra = Convert.ToInt32(dtmaycat.Rows[0]["ID_VTHH_Ra"].ToString());
                                clsVT_Ra.iID_VTHH = ID_VTHH_Ra;
                                DataTable dtvt_Ra = clsVT_Ra.SelectOne();
                                string MaVT_Ra = clsVT_Ra.sMaVT.Value;
                                string DonViTinh_Ra = clsVT_Ra.sDonViTinh.Value;
                                string TenVatTu_Ra = clsVT_Ra.sTenVTHH.Value;
                                double SanLuong_Tong = Convert.ToDouble(dtmaycat.Rows[0]["SanLuong_Tong"].ToString());
                                double PhePham = Convert.ToDouble(dtmaycat.Rows[0]["PhePham"].ToString());
                                int ID_Mayxxx = Convert.ToInt32(dtmaycat.Rows[0]["ID_May"].ToString());
                                clsmaymoc.iId = ID_Mayxxx;
                                DataTable dtmay = clsmaymoc.SelectOne();
                                string MaMay_CAT = clsmaymoc.sMaMay.Value;

                                _ravi["ID_VTHH_Vao_CAT"] = ID_VTHH_Vao;
                                _ravi["ID_VTHH_Ra_CAT"] = ID_VTHH_Ra;
                                _ravi["MaVT_Vao_CAT"] = MaVT_Vao;
                                _ravi["MaVT_Ra_CAT"] = MaVT_Ra;
                                _ravi["DonViTinh_Vao_CAT"] = DonViTinh_Vao;
                                _ravi["DonViTinh_Ra_CAT"] = DonViTinh_Ra;
                                _ravi["TenVatTu_Vao_CAT"] = TenVatTu_Vao;
                                _ravi["TenVatTu_Ra_CAT"] = TenVatTu_Ra;
                                _ravi["SoLuong_Vao_CAT"] = SoLuong_Vao.ToString();
                                _ravi["SoLuong_Ra_CAT"] = SanLuong_Tong.ToString();
                                _ravi["PhePham_CAT"] = PhePham;
                                _ravi["NgaySanXuat_CAT"] = NgaySanXuat;
                                _ravi["CaSanXuat_CAT"] = CaSanXuat;
                                _ravi["CongNhan_CAT"] = CongNhan;
                                _ravi["MaMay_CAT"] = MaMay_CAT;
                            }
                            //else
                            //{
                            //    _ravi["ID_VTHH_Vao_CAT"] = "";
                            //    _ravi["ID_VTHH_Ra_CAT"] = "";
                            //    _ravi["MaVT_Vao_CAT"] = "";
                            //    _ravi["MaVT_Ra_CAT"] = "";
                            //    _ravi["DonViTinh_Vao_CAT"] = "";
                            //    _ravi["DonViTinh_Ra_CAT"] = "";
                            //    _ravi["TenVatTu_Vao_CAT"] = "";
                            //    _ravi["TenVatTu_Ra_CAT"] = "";
                            //    _ravi["SoLuong_Vao_CAT"] = "";
                            //    _ravi["SoLuong_Ra_CAT"] = "";
                            //    _ravi["PhePham_CAT"] = "";
                            //    _ravi["NgaySanXuat_CAT"] = "";
                            //    _ravi["CaSanXuat_CAT"] = "";
                            //    _ravi["CongNhan_CAT"] = "";
                            //    _ravi["MaMay_CAT"] = "";
                            //}

                            if (dtmaydot.Rows.Count > 0)
                            {
                                int ID_CongNhan = Convert.ToInt32(dtmaydot.Rows[0]["ID_CongNhan"].ToString());
                                clsnhansu.iID_NhanSu = ID_CongNhan;
                                DataTable dtnhansu = clsnhansu.SelectOne();
                                string CongNhan = clsnhansu.sTenNhanVien.Value;
                                DateTime daNgaySanXuat = Convert.ToDateTime(dtmaydot.Rows[0]["NgaySanXuat"].ToString());
                                string NgaySanXuat = daNgaySanXuat.ToString("dd/MM/yyyy");
                                string CaSanXuat = dtmaydot.Rows[0]["CaSanXuat"].ToString();
                                int ID_VTHH_Vao = Convert.ToInt32(dtmaydot.Rows[0]["ID_VTHH_Vao"].ToString());
                                clsVT_Vao.iID_VTHH = ID_VTHH_Vao;
                                DataTable dtvtvao = clsVT_Vao.SelectOne();
                                string MaVT_Vao = clsVT_Vao.sMaVT.Value;
                                string DonViTinh_Vao = clsVT_Vao.sDonViTinh.Value;
                                string TenVatTu_Vao = clsVT_Vao.sTenVTHH.Value;
                                double SoLuong_Vao = Convert.ToDouble(dtmaydot.Rows[0]["SoLuong_Vao"].ToString());
                                int ID_VTHH_Ra = Convert.ToInt32(dtmaydot.Rows[0]["ID_VTHH_Ra"].ToString());
                                clsVT_Ra.iID_VTHH = ID_VTHH_Ra;
                                DataTable dtvt_Ra = clsVT_Ra.SelectOne();
                                string MaVT_Ra = clsVT_Ra.sMaVT.Value;
                                string DonViTinh_Ra = clsVT_Ra.sDonViTinh.Value;
                                string TenVatTu_Ra = clsVT_Ra.sTenVTHH.Value;
                                double SanLuong_Tong = Convert.ToDouble(dtmaydot.Rows[0]["SanLuong_Tong"].ToString());
                                double PhePham = Convert.ToDouble(dtmaydot.Rows[0]["PhePham"].ToString());
                                int ID_Mayxxx = Convert.ToInt32(dtmaydot.Rows[0]["ID_May"].ToString());
                                clsmaymoc.iId = ID_Mayxxx;
                                DataTable dtmay = clsmaymoc.SelectOne();
                                string MaMay_DOT = clsmaymoc.sMaMay.Value;
                                _ravi["ID_VTHH_Vao_DOT"] = ID_VTHH_Vao;
                                _ravi["ID_VTHH_Ra_DOT"] = ID_VTHH_Ra;
                                _ravi["MaVT_Vao_DOT"] = MaVT_Vao;
                                _ravi["MaVT_Ra_DOT"] = MaVT_Ra;
                                _ravi["DonViTinh_Vao_DOT"] = DonViTinh_Vao;
                                _ravi["DonViTinh_Ra_DOT"] = DonViTinh_Ra;
                                _ravi["TenVatTu_Vao_DOT"] = TenVatTu_Vao;
                                _ravi["TenVatTu_Ra_DOT"] = TenVatTu_Ra;
                                _ravi["SoLuong_Vao_DOT"] = SoLuong_Vao.ToString();
                                _ravi["SoLuong_Ra_DOT"] = SanLuong_Tong.ToString();
                                _ravi["PhePham_DOT"] = PhePham;
                                _ravi["NgaySanXuat_DOT"] = NgaySanXuat;
                                _ravi["CaSanXuat_DOT"] = CaSanXuat;
                                _ravi["CongNhan_DOT"] = CongNhan;
                                _ravi["MaMay_DOT"] = MaMay_DOT;
                            }
                            //else
                            //{
                            //    _ravi["ID_VTHH_Vao_DOT"] = "";
                            //    _ravi["ID_VTHH_Ra_DOT"] = "";
                            //    _ravi["MaVT_Vao_DOT"] = "";
                            //    _ravi["MaVT_Ra_DOT"] = "";
                            //    _ravi["DonViTinh_Vao_DOT"] = "";
                            //    _ravi["DonViTinh_Ra_DOT"] = "";
                            //    _ravi["TenVatTu_Vao_DOT"] = "";
                            //    _ravi["TenVatTu_Ra_DOT"] = "";
                            //    _ravi["SoLuong_Vao_DOT"] = "";
                            //    _ravi["SoLuong_Ra_DOT"] = "";
                            //    _ravi["PhePham_DOT"] = "";
                            //    _ravi["NgaySanXuat_DOT"] = "";
                            //    _ravi["CaSanXuat_DOT"] = "";
                            //    _ravi["CongNhan_DOT"] = "";
                            //    _ravi["MaMay_DOT"] = "";
                            //}
                            dt2.Rows.Add(_ravi);
                        }
                    }
                    gridControl1.DataSource = dt2;
                }
            }
            
        }
        private void HienThi_ALL()
        {
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_SoPhieu", typeof(int));
            dt2.Columns.Add("MaPhieu", typeof(string));

            dt2.Columns.Add("ID_VTHH_Vao_IN", typeof(string));
            dt2.Columns.Add("ID_VTHH_Ra_IN", typeof(string));
            dt2.Columns.Add("MaVT_Vao_IN", typeof(string));
            dt2.Columns.Add("MaVT_Ra_IN", typeof(string));
            dt2.Columns.Add("DonViTinh_Vao_IN", typeof(string));
            dt2.Columns.Add("DonViTinh_Ra_IN", typeof(string));
            dt2.Columns.Add("TenVatTu_Vao_IN", typeof(string));
            dt2.Columns.Add("TenVatTu_Ra_IN", typeof(string));
            dt2.Columns.Add("SoLuong_Vao_IN", typeof(string));
            dt2.Columns.Add("SoLuong_Ra_IN", typeof(string));
            dt2.Columns.Add("PhePham_IN", typeof(string));
            dt2.Columns.Add("NgaySanXuat_IN", typeof(string));
            dt2.Columns.Add("CaSanXuat_IN", typeof(string));
            dt2.Columns.Add("CongNhan_IN", typeof(string));
            dt2.Columns.Add("MaMay_IN", typeof(string));

            dt2.Columns.Add("ID_VTHH_Vao_CAT", typeof(string));
            dt2.Columns.Add("ID_VTHH_Ra_CAT", typeof(string));
            dt2.Columns.Add("MaVT_Vao_CAT", typeof(string));
            dt2.Columns.Add("MaVT_Ra_CAT", typeof(string));
            dt2.Columns.Add("DonViTinh_Vao_CAT", typeof(string));
            dt2.Columns.Add("DonViTinh_Ra_CAT", typeof(string));
            dt2.Columns.Add("TenVatTu_Vao_CAT", typeof(string));
            dt2.Columns.Add("TenVatTu_Ra_CAT", typeof(string));
            dt2.Columns.Add("SoLuong_Vao_CAT", typeof(string));
            dt2.Columns.Add("SoLuong_Ra_CAT", typeof(string));
            dt2.Columns.Add("PhePham_CAT", typeof(string));
            dt2.Columns.Add("NgaySanXuat_CAT", typeof(string));
            dt2.Columns.Add("CaSanXuat_CAT", typeof(string));
            dt2.Columns.Add("CongNhan_CAT", typeof(string));
            dt2.Columns.Add("MaMay_CAT", typeof(string));

            dt2.Columns.Add("ID_VTHH_Vao_DOT", typeof(string));
            dt2.Columns.Add("ID_VTHH_Ra_DOT", typeof(string));
            dt2.Columns.Add("MaVT_Vao_DOT", typeof(string));
            dt2.Columns.Add("MaVT_Ra_DOT", typeof(string));
            dt2.Columns.Add("DonViTinh_Vao_DOT", typeof(string));
            dt2.Columns.Add("DonViTinh_Ra_DOT", typeof(string));
            dt2.Columns.Add("TenVatTu_Vao_DOT", typeof(string));
            dt2.Columns.Add("TenVatTu_Ra_DOT", typeof(string));
            dt2.Columns.Add("SoLuong_Vao_DOT", typeof(string));
            dt2.Columns.Add("SoLuong_Ra_DOT", typeof(string));
            dt2.Columns.Add("PhePham_DOT", typeof(string));
            dt2.Columns.Add("NgaySanXuat_DOT", typeof(string));
            dt2.Columns.Add("CaSanXuat_DOT", typeof(string));
            dt2.Columns.Add("CongNhan_DOT", typeof(string));
            dt2.Columns.Add("MaMay_DOT", typeof(string));

            clsTbVatTuHangHoa clsVT_Vao = new clsTbVatTuHangHoa();
            clsTbVatTuHangHoa clsVT_Ra = new clsTbVatTuHangHoa();
            clsNhanSu_tbNhanSu clsnhansu = new clsNhanSu_tbNhanSu();
            clsPhieu_ChiTietPhieu_New cls = new clsPhieu_ChiTietPhieu_New();
            clsPhieu_tbPhieu clsphieu = new clsPhieu_tbPhieu();
            clsT_MayMoc clsmaymoc = new clsT_MayMoc();
            DataTable daaa = clsphieu.SelectAll();

            DataView dvaaa = daaa.DefaultView;
            dvaaa.Sort = "NgayLapPhieu DESC, ID_SoPhieu DESC";
            DataTable dtphieu = dvaaa.ToTable();
           // textBox1.Text = dt.Rows.Count.ToString();

            if (dtphieu.Rows.Count > 0)
            {
                for (int i = 0; i < dtphieu.Rows.Count; i++)
                {

                    int ID_SoPhieu = Convert.ToInt32(dtphieu.Rows[i]["ID_SoPhieu"].ToString());

                    DataRow _ravi = dt2.NewRow();
                    _ravi["ID_SoPhieu"] = ID_SoPhieu;
                    _ravi["MaPhieu"] = dtphieu.Rows[i]["MaPhieu"].ToString();

                    cls.iID_SoPhieu = ID_SoPhieu;
                    DataTable dt12222 = cls.SelectAll_W_iID_SoPhieu();
                    if (dt12222.Rows.Count > 0)
                    {
                        dt12222.DefaultView.RowFilter = "bMay_IN = True";
                        DataView dv1222 = dt12222.DefaultView;
                        DataTable dt1 = dv1222.ToTable();

                        dt12222.DefaultView.RowFilter = "bMay_CAT = True";
                        DataView dvmaycat = dt12222.DefaultView;
                        DataTable dtmaycat = dvmaycat.ToTable();

                        dt12222.DefaultView.RowFilter = "bMay_DOT = True";
                        DataView dvmaydot = dt12222.DefaultView;
                        DataTable dtmaydot = dvmaydot.ToTable();

                        if (dt1.Rows.Count > 0)
                        {
                            int ID_CongNhan = Convert.ToInt32(dt1.Rows[0]["ID_CongNhan"].ToString());
                            clsnhansu.iID_NhanSu = ID_CongNhan;
                            DataTable dtnhansu = clsnhansu.SelectOne();
                            string CongNhan = clsnhansu.sTenNhanVien.Value;
                            DateTime daNgaySanXuat = Convert.ToDateTime(dt1.Rows[0]["NgaySanXuat"].ToString());
                            string NgaySanXuat = daNgaySanXuat.ToString("dd/MM/yyyy");
                            string CaSanXuat = dt1.Rows[0]["CaSanXuat"].ToString();
                            int ID_VTHH_Vao = Convert.ToInt32(dt1.Rows[0]["ID_VTHH_Vao"].ToString());
                            clsVT_Vao.iID_VTHH = ID_VTHH_Vao;
                            DataTable dtvtvao = clsVT_Vao.SelectOne();
                            string MaVT_Vao = clsVT_Vao.sMaVT.Value;
                            string DonViTinh_Vao = clsVT_Vao.sDonViTinh.Value;
                            string TenVatTu_Vao = clsVT_Vao.sTenVTHH.Value;
                            double SoLuong_Vao = Convert.ToDouble(dt1.Rows[0]["SoLuong_Vao"].ToString());
                            int ID_VTHH_Ra = Convert.ToInt32(dt1.Rows[0]["ID_VTHH_Ra"].ToString());
                            clsVT_Ra.iID_VTHH = ID_VTHH_Ra;
                            DataTable dtvt_Ra = clsVT_Ra.SelectOne();
                            string MaVT_Ra = clsVT_Ra.sMaVT.Value;
                            string DonViTinh_Ra = clsVT_Ra.sDonViTinh.Value;
                            string TenVatTu_Ra = clsVT_Ra.sTenVTHH.Value;
                            double SanLuong_Tong = Convert.ToDouble(dt1.Rows[0]["SanLuong_Tong"].ToString());
                            double PhePham = Convert.ToDouble(dt1.Rows[0]["PhePham"].ToString());
                            int ID_Mayxxx = Convert.ToInt32(dt1.Rows[0]["ID_May"].ToString());
                            clsmaymoc.iId = ID_Mayxxx;
                            DataTable dtmay = clsmaymoc.SelectOne();
                            string MaMay_IN = clsmaymoc.sMaMay.Value;
                            // dt2.Columns.Add("MaMay_DOT", typeof(string));
                            _ravi["ID_VTHH_Vao_IN"] = ID_VTHH_Vao;
                            _ravi["ID_VTHH_Ra_IN"] = ID_VTHH_Ra;
                            _ravi["MaVT_Vao_IN"] = MaVT_Vao;
                            _ravi["MaVT_Ra_IN"] = MaVT_Ra;
                            _ravi["DonViTinh_Vao_IN"] = DonViTinh_Vao;
                            _ravi["DonViTinh_Ra_IN"] = DonViTinh_Ra;
                            _ravi["TenVatTu_Vao_IN"] = TenVatTu_Vao;
                            _ravi["TenVatTu_Ra_IN"] = TenVatTu_Ra;
                            _ravi["SoLuong_Vao_IN"] = SoLuong_Vao.ToString();
                            _ravi["SoLuong_Ra_IN"] = SanLuong_Tong.ToString();
                            _ravi["PhePham_IN"] = PhePham;
                            _ravi["NgaySanXuat_IN"] = NgaySanXuat;
                            _ravi["CaSanXuat_IN"] = CaSanXuat;
                            _ravi["CongNhan_IN"] = CongNhan;
                            _ravi["MaMay_IN"] = MaMay_IN;
                        }
                        //else
                        //{
                        //    _ravi["ID_VTHH_Vao_IN"] = "";
                        //    _ravi["ID_VTHH_Ra_IN"] = "";
                        //    _ravi["MaVT_Vao_IN"] = "";
                        //    _ravi["MaVT_Ra_IN"] = "";
                        //    _ravi["DonViTinh_Vao_IN"] = "";
                        //    _ravi["DonViTinh_Ra_IN"] = "";
                        //    _ravi["TenVatTu_Vao_IN"] = "";
                        //    _ravi["TenVatTu_Ra_IN"] = "";
                        //    _ravi["SoLuong_Vao_IN"] = "";
                        //    _ravi["SoLuong_Ra_IN"] = "";
                        //    _ravi["PhePham_IN"] = "";
                        //    _ravi["NgaySanXuat_IN"] = "";
                        //    _ravi["CaSanXuat_IN"] = "";
                        //    _ravi["CongNhan_IN"] = "";
                        //    _ravi["MaMay_IN"] = "";
                        //}
                        if (dtmaycat.Rows.Count > 0)
                        {
                            int ID_CongNhan = Convert.ToInt32(dtmaycat.Rows[0]["ID_CongNhan"].ToString());
                            clsnhansu.iID_NhanSu = ID_CongNhan;
                            DataTable dtnhansu = clsnhansu.SelectOne();
                            string CongNhan = clsnhansu.sTenNhanVien.Value;
                            DateTime daNgaySanXuat = Convert.ToDateTime(dtmaycat.Rows[0]["NgaySanXuat"].ToString());
                            string NgaySanXuat = daNgaySanXuat.ToString("dd/MM/yyyy");
                            string CaSanXuat = dtmaycat.Rows[0]["CaSanXuat"].ToString();
                            int ID_VTHH_Vao = Convert.ToInt32(dtmaycat.Rows[0]["ID_VTHH_Vao"].ToString());
                            clsVT_Vao.iID_VTHH = ID_VTHH_Vao;
                            DataTable dtvtvao = clsVT_Vao.SelectOne();
                            string MaVT_Vao = clsVT_Vao.sMaVT.Value;
                            string DonViTinh_Vao = clsVT_Vao.sDonViTinh.Value;
                            string TenVatTu_Vao = clsVT_Vao.sTenVTHH.Value;
                            double SoLuong_Vao = Convert.ToDouble(dtmaycat.Rows[0]["SoLuong_Vao"].ToString());
                            int ID_VTHH_Ra = Convert.ToInt32(dtmaycat.Rows[0]["ID_VTHH_Ra"].ToString());
                            clsVT_Ra.iID_VTHH = ID_VTHH_Ra;
                            DataTable dtvt_Ra = clsVT_Ra.SelectOne();
                            string MaVT_Ra = clsVT_Ra.sMaVT.Value;
                            string DonViTinh_Ra = clsVT_Ra.sDonViTinh.Value;
                            string TenVatTu_Ra = clsVT_Ra.sTenVTHH.Value;
                            double SanLuong_Tong = Convert.ToDouble(dtmaycat.Rows[0]["SanLuong_Tong"].ToString());
                            double PhePham = Convert.ToDouble(dtmaycat.Rows[0]["PhePham"].ToString());
                            int ID_Mayxxx = Convert.ToInt32(dtmaycat.Rows[0]["ID_May"].ToString());
                            clsmaymoc.iId = ID_Mayxxx;
                            DataTable dtmay = clsmaymoc.SelectOne();
                            string MaMay_CAT = clsmaymoc.sMaMay.Value;

                            _ravi["ID_VTHH_Vao_CAT"] = ID_VTHH_Vao;
                            _ravi["ID_VTHH_Ra_CAT"] = ID_VTHH_Ra;
                            _ravi["MaVT_Vao_CAT"] = MaVT_Vao;
                            _ravi["MaVT_Ra_CAT"] = MaVT_Ra;
                            _ravi["DonViTinh_Vao_CAT"] = DonViTinh_Vao;
                            _ravi["DonViTinh_Ra_CAT"] = DonViTinh_Ra;
                            _ravi["TenVatTu_Vao_CAT"] = TenVatTu_Vao;
                            _ravi["TenVatTu_Ra_CAT"] = TenVatTu_Ra;
                            _ravi["SoLuong_Vao_CAT"] = SoLuong_Vao.ToString();
                            _ravi["SoLuong_Ra_CAT"] = SanLuong_Tong.ToString();
                            _ravi["PhePham_CAT"] = PhePham;
                            _ravi["NgaySanXuat_CAT"] = NgaySanXuat;
                            _ravi["CaSanXuat_CAT"] = CaSanXuat;
                            _ravi["CongNhan_CAT"] = CongNhan;
                            _ravi["MaMay_CAT"] = MaMay_CAT;
                        }
                        //else
                        //{
                        //    _ravi["ID_VTHH_Vao_CAT"] = "";
                        //    _ravi["ID_VTHH_Ra_CAT"] = "";
                        //    _ravi["MaVT_Vao_CAT"] = "";
                        //    _ravi["MaVT_Ra_CAT"] = "";
                        //    _ravi["DonViTinh_Vao_CAT"] = "";
                        //    _ravi["DonViTinh_Ra_CAT"] = "";
                        //    _ravi["TenVatTu_Vao_CAT"] = "";
                        //    _ravi["TenVatTu_Ra_CAT"] = "";
                        //    _ravi["SoLuong_Vao_CAT"] = "";
                        //    _ravi["SoLuong_Ra_CAT"] = "";
                        //    _ravi["PhePham_CAT"] = "";
                        //    _ravi["NgaySanXuat_CAT"] = "";
                        //    _ravi["CaSanXuat_CAT"] = "";
                        //    _ravi["CongNhan_CAT"] = "";
                        //    _ravi["MaMay_CAT"] = "";
                        //}

                        if (dtmaydot.Rows.Count > 0)
                        {
                            int ID_CongNhan = Convert.ToInt32(dtmaydot.Rows[0]["ID_CongNhan"].ToString());
                            clsnhansu.iID_NhanSu = ID_CongNhan;
                            DataTable dtnhansu = clsnhansu.SelectOne();
                            string CongNhan = clsnhansu.sTenNhanVien.Value;
                            DateTime daNgaySanXuat = Convert.ToDateTime(dtmaydot.Rows[0]["NgaySanXuat"].ToString());
                            string NgaySanXuat = daNgaySanXuat.ToString("dd/MM/yyyy");
                            string CaSanXuat = dtmaydot.Rows[0]["CaSanXuat"].ToString();
                            int ID_VTHH_Vao = Convert.ToInt32(dtmaydot.Rows[0]["ID_VTHH_Vao"].ToString());
                            clsVT_Vao.iID_VTHH = ID_VTHH_Vao;
                            DataTable dtvtvao = clsVT_Vao.SelectOne();
                            string MaVT_Vao = clsVT_Vao.sMaVT.Value;
                            string DonViTinh_Vao = clsVT_Vao.sDonViTinh.Value;
                            string TenVatTu_Vao = clsVT_Vao.sTenVTHH.Value;
                            double SoLuong_Vao = Convert.ToDouble(dtmaydot.Rows[0]["SoLuong_Vao"].ToString());
                            int ID_VTHH_Ra = Convert.ToInt32(dtmaydot.Rows[0]["ID_VTHH_Ra"].ToString());
                            clsVT_Ra.iID_VTHH = ID_VTHH_Ra;
                            DataTable dtvt_Ra = clsVT_Ra.SelectOne();
                            string MaVT_Ra = clsVT_Ra.sMaVT.Value;
                            string DonViTinh_Ra = clsVT_Ra.sDonViTinh.Value;
                            string TenVatTu_Ra = clsVT_Ra.sTenVTHH.Value;
                            double SanLuong_Tong = Convert.ToDouble(dtmaydot.Rows[0]["SanLuong_Tong"].ToString());
                            double PhePham = Convert.ToDouble(dtmaydot.Rows[0]["PhePham"].ToString());
                            int ID_Mayxxx = Convert.ToInt32(dtmaydot.Rows[0]["ID_May"].ToString());
                            clsmaymoc.iId = ID_Mayxxx;
                            DataTable dtmay = clsmaymoc.SelectOne();
                            string MaMay_DOT = clsmaymoc.sMaMay.Value;
                            _ravi["ID_VTHH_Vao_DOT"] = ID_VTHH_Vao;
                            _ravi["ID_VTHH_Ra_DOT"] = ID_VTHH_Ra;
                            _ravi["MaVT_Vao_DOT"] = MaVT_Vao;
                            _ravi["MaVT_Ra_DOT"] = MaVT_Ra;
                            _ravi["DonViTinh_Vao_DOT"] = DonViTinh_Vao;
                            _ravi["DonViTinh_Ra_DOT"] = DonViTinh_Ra;
                            _ravi["TenVatTu_Vao_DOT"] = TenVatTu_Vao;
                            _ravi["TenVatTu_Ra_DOT"] = TenVatTu_Ra;
                            _ravi["SoLuong_Vao_DOT"] = SoLuong_Vao.ToString();
                            _ravi["SoLuong_Ra_DOT"] = SanLuong_Tong.ToString();
                            _ravi["PhePham_DOT"] = PhePham;
                            _ravi["NgaySanXuat_DOT"] = NgaySanXuat;
                            _ravi["CaSanXuat_DOT"] = CaSanXuat;
                            _ravi["CongNhan_DOT"] = CongNhan;
                            _ravi["MaMay_DOT"] = MaMay_DOT;
                        }
                        //else
                        //{
                        //    _ravi["ID_VTHH_Vao_DOT"] = "";
                        //    _ravi["ID_VTHH_Ra_DOT"] = "";
                        //    _ravi["MaVT_Vao_DOT"] = "";
                        //    _ravi["MaVT_Ra_DOT"] = "";
                        //    _ravi["DonViTinh_Vao_DOT"] = "";
                        //    _ravi["DonViTinh_Ra_DOT"] = "";
                        //    _ravi["TenVatTu_Vao_DOT"] = "";
                        //    _ravi["TenVatTu_Ra_DOT"] = "";
                        //    _ravi["SoLuong_Vao_DOT"] = "";
                        //    _ravi["SoLuong_Ra_DOT"] = "";
                        //    _ravi["PhePham_DOT"] = "";
                        //    _ravi["NgaySanXuat_DOT"] = "";
                        //    _ravi["CaSanXuat_DOT"] = "";
                        //    _ravi["CongNhan_DOT"] = "";
                        //    _ravi["MaMay_DOT"] = "";
                        //}
                        dt2.Rows.Add(_ravi);
                    }
                }
                gridControl1.DataSource = dt2;
            }
           
           
        }
        public SanXuat_frmChiTietSoPhieu_RutGon()
        {
            InitializeComponent();
        }

        private void SanXuat_frmChiTietSoPhieu_RutGon_Load(object sender, EventArgs e)
        {
            dteDenNgay.EditValue = null;
            dteTuNgay.EditValue = null;
            HienThi_ALL();           
            bandedGridView1.OptionsFind.AlwaysVisible = false;
        }

        private void bandedGridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void btTImKiem_Click(object sender, EventArgs e)
        {
            bandedGridView1.OptionsFind.AlwaysVisible = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SanXuat_frmChiTietSoPhieu_RutGon_Load(sender, e);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {

            DataTable DatatableABC = (DataTable)gridControl1.DataSource;
            CriteriaOperator op = bandedGridView1.ActiveFilterCriteria; // filterControl1.FilterCriteria
            string filterString = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(op);
            DataView dv1212 = new DataView(DatatableABC);
            dv1212.RowFilter = filterString;
            mdtPrint_tbChiTietPhieu = dv1212.ToTable();

            frmPrintChiTietPhieuSanXuat ff = new frmPrintChiTietPhieuSanXuat();
            ff.Show();
            
            
        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            if (dteDenNgay.EditValue != null & dteTuNgay.EditValue != null)
            {
                HienThi();
            }
        }
    }
}
