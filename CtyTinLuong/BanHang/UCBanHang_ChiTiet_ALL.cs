﻿using System;
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
    public partial class UCBanHang_ChiTiet_ALL : UserControl
    {
        private void HienThi()
        {
            if (dteTuNgay.EditValue != null & dteNgay.EditValue != null)
            {
                DateTime denngay = dteNgay.DateTime;
                DateTime tungay = dteTuNgay.DateTime;
                DataTable dt2 = new DataTable();
                dt2.Columns.Add("ID_VTHH", typeof(int));
                dt2.Columns.Add("MaVT", typeof(string));
                dt2.Columns.Add("TenVTHH", typeof(string));
                dt2.Columns.Add("SoLuong", typeof(double));
                dt2.Columns.Add("DonViTinh", typeof(string));
                dt2.Columns.Add("DonGia", typeof(double));
                dt2.Columns.Add("ThanhTien", typeof(double));
                dt2.Columns.Add("NgayChungTu", typeof(DateTime));
                dt2.Columns.Add("TenKH", typeof(string));
                //NgayThang

                clsBanHang_ChiTietBanHang cls = new CtyTinLuong.clsBanHang_ChiTietBanHang();
                DataTable dt = cls.SelectAll_HienThi_ALL();
                dt.DefaultView.RowFilter = " NgayChungTu<='" + denngay + "'";
                DataView dv = dt.DefaultView;
                DataTable dt22 = dv.ToTable();
                dt22.DefaultView.RowFilter = " NgayChungTu>='" + tungay + "'";
                DataView dv2 = dt22.DefaultView;
                dv2.Sort = "NgayChungTu DESC, ID_BanHang DESC";
                DataTable dxxxx = dv2.ToTable();
                for (int i = 0; i < dxxxx.Rows.Count; i++)
                {
                   
                    double DonGia = Convert.ToDouble(dxxxx.Rows[i]["DonGia"].ToString());
                    double SoLuong = Convert.ToDouble(dxxxx.Rows[i]["SoLuong"].ToString());
                    DataRow _ravi = dt2.NewRow();
                    _ravi["ID_VTHH"] = Convert.ToInt16(dxxxx.Rows[i]["ID_VTHH"].ToString());
                    _ravi["TenKH"] = dxxxx.Rows[i]["TenKH"].ToString();
                    _ravi["MaVT"] = dxxxx.Rows[i]["MaVT"].ToString();
                    _ravi["TenVTHH"] = dxxxx.Rows[i]["TenVTHH"].ToString();
                    _ravi["SoLuong"] = SoLuong;
                    _ravi["NgayChungTu"] = Convert.ToDateTime(dxxxx.Rows[i]["NgayChungTu"].ToString());
                    _ravi["DonViTinh"] = dxxxx.Rows[i]["DonViTinh"].ToString();
                    _ravi["DonGia"] = DonGia;
                    _ravi["ThanhTien"] = SoLuong * DonGia;
                    dt2.Rows.Add(_ravi);
                }
                gridControl1.DataSource = dt2;
            }

        }
        private void HienThi_ALL()
        {
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID_VTHH", typeof(int));
            dt2.Columns.Add("MaVT", typeof(string));
            dt2.Columns.Add("TenVTHH", typeof(string));
            dt2.Columns.Add("SoLuong", typeof(double));
            dt2.Columns.Add("DonViTinh", typeof(string));
            dt2.Columns.Add("DonGia", typeof(double));
            dt2.Columns.Add("ThanhTien", typeof(double));
            dt2.Columns.Add("NgayChungTu", typeof(DateTime));
            dt2.Columns.Add("TenKH", typeof(string));
            //NgayThang

            clsBanHang_ChiTietBanHang cls = new CtyTinLuong.clsBanHang_ChiTietBanHang();
            DataTable dt22 = cls.SelectAll_HienThi_ALL();          
            DataView dv2 = dt22.DefaultView;
            dv2.Sort = "NgayChungTu DESC, ID_BanHang DESC";
            DataTable dxxxx = dv2.ToTable();
            for (int i = 0; i < dxxxx.Rows.Count; i++)
            {

                double DonGia = Convert.ToDouble(dxxxx.Rows[i]["DonGia"].ToString());
                double SoLuong = Convert.ToDouble(dxxxx.Rows[i]["SoLuong"].ToString());
                DataRow _ravi = dt2.NewRow();
                _ravi["ID_VTHH"] = Convert.ToInt16(dxxxx.Rows[i]["ID_VTHH"].ToString());
                _ravi["TenKH"] = dxxxx.Rows[i]["TenKH"].ToString();
                _ravi["MaVT"] = dxxxx.Rows[i]["MaVT"].ToString();
                _ravi["TenVTHH"] = dxxxx.Rows[i]["TenVTHH"].ToString();
                _ravi["SoLuong"] = SoLuong;
                _ravi["NgayChungTu"] = Convert.ToDateTime(dxxxx.Rows[i]["NgayChungTu"].ToString());
                _ravi["DonViTinh"] = dxxxx.Rows[i]["DonViTinh"].ToString();
                _ravi["DonGia"] = DonGia;
                _ravi["ThanhTien"] = SoLuong * DonGia;
                dt2.Rows.Add(_ravi);
            }
            gridControl1.DataSource = dt2;


        }
        public UCBanHang_ChiTiet_ALL()
        {
            InitializeComponent();
        }

        private void UCBanHang_ChiTiet_ALL_Load(object sender, EventArgs e)
        {
            dteNgay.EditValue = null;
            dteTuNgay.EditValue = null;
            HienThi_ALL();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UCBanHang_ChiTiet_ALL_Load( sender,  e);
        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            if (dteNgay.EditValue != null & dteTuNgay.EditValue != null)
            {
                HienThi();
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
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
