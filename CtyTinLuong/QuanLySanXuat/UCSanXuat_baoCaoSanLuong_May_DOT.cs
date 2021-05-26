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
    public partial class UCSanXuat_baoCaoSanLuong_May_DOT : UserControl
    {
        private void HienThi()
        {
            DateTime tungay, dennagy;
            tungay = dteTuNgay.DateTime;
            dennagy = dteDenNgay.DateTime;
            clsPhieu_ChiTietPhieu_May_DOT cls = new CtyTinLuong.clsPhieu_ChiTietPhieu_May_DOT();
            DataTable dt = cls.SelectAll_BaoCaoSanLuong();

            //dt.DefaultView.RowFilter = "'" + tungay + "'<= NgayLapPhieu <='" + dennagy + "'";
            dt.DefaultView.RowFilter = " NgayLapPhieu <='" + dennagy + "'";
            DataView dv = dt.DefaultView;
            DataTable dxxxx = dv.ToTable();

            dxxxx.DefaultView.RowFilter = " NgayLapPhieu >='" + tungay + "'";
            DataView dv222 = dxxxx.DefaultView;
            DataTable dt222 = dv222.ToTable();

            gridControl1.DataSource = dt222;
        }
        public UCSanXuat_baoCaoSanLuong_May_DOT()
        {
            InitializeComponent();
        }

        private void UCSanXuat_baoCaoSanLuong_May_DOT_Load(object sender, EventArgs e)
        {
            DateTime ngayhomnay = DateTime.Today;
            DateTime ngaydautien, ngaycuoicung;
            int nam = Convert.ToInt16(ngayhomnay.ToString("yyyy"));
            int thang = Convert.ToInt16(ngayhomnay.ToString("MM"));
            ngaydautien = new DateTime(DateTime.Now.Year, thang, 1);
            ngaydautien = ngaydautien.AddDays((-ngaydautien.Day) + 1);
            dteTuNgay.EditValue = ngaydautien;
            ngaycuoicung = ngayhomnay.AddMonths(1);
            ngaycuoicung = ngaycuoicung.AddDays(-(ngaycuoicung.Day));
            dteDenNgay.EditValue = ngaycuoicung;
            if (dteTuNgay.EditValue != null & dteDenNgay.EditValue != null)
            {
                HienThi();

            }
        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            if (dteTuNgay.EditValue != null & dteDenNgay.EditValue != null)
            {
                HienThi();

            }
        }

        private void dteTuNgay_EditValueChanged(object sender, EventArgs e)
        {
            if (dteTuNgay.EditValue != null & dteDenNgay.EditValue != null)
            {
                if (dteTuNgay.DateTime > dteDenNgay.DateTime)
                {
                    MessageBox.Show("Chọn Sai Từ ngay");
                    return;
                }
            }
        }

        private void dteDenNgay_EditValueChanged(object sender, EventArgs e)
        {

            if (dteTuNgay.EditValue != null & dteDenNgay.EditValue != null)
            {
                if (dteTuNgay.DateTime > dteDenNgay.DateTime)
                {
                    MessageBox.Show("Chọn Sai Từ ngay");
                    return;
                }
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UCSanXuat_baoCaoSanLuong_May_DOT_Load( sender,  e);
        }
    }
}
