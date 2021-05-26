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
    public partial class SanXuat_frmThemMoi_SoPhieu : Form
    {
        private bool KiemTraLuu_SoPhieu()
        {
           
            DateTime tungay = DateTime.Today.AddDays(-90);
            DateTime denngay = DateTime.Today;
            clsPhieu_tbPhieu cls = new clsPhieu_tbPhieu();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.RowFilter = "TonTai= True and NgungTheoDoi=False and NgayLapPhieu<='" + denngay + "'";
            DataView dv = dt.DefaultView;
            DataTable dt22 = dv.ToTable();
            dt22.DefaultView.RowFilter = " TonTai= True and NgungTheoDoi=False and NgayLapPhieu>='" + tungay + "'";
            DataView dv2 = dt22.DefaultView;           
            DataTable dxxxx = dv2.ToTable();
            string maphieu = txtMaPhieu.Text.ToString();
            string filterExpression = "";
            filterExpression = "MaPhieu ='"+maphieu+"'";
            DataRow[] rows = dxxxx.Select(filterExpression);
            if (rows.Length>0)
            {
                MessageBox.Show("Đã có Mã phiếu: " + maphieu + "\n Vui lòng chọn lại tên mã phiếu khác");
                return false;
            }
            else if (txtMaPhieu.Text.ToString() == "")
            {
                MessageBox.Show("Chưa chọn Mã phiếu ");
                return false;
            }
            else if (gridMaCaTruong.EditValue == null)
            {
                MessageBox.Show("Chưa chọn ca trưởng ");
                return false;
            }
            else if (cbCaLamViec.Text.ToString() == "")
            {
                MessageBox.Show("Chưa chọn ca làm việc ");
                return false;
            }
            else if (dteNgayLap.EditValue == null)
            {
                MessageBox.Show("Chưa chọn ngày lập ");
                return false;
            }

            else return true;

        }
        private bool LuuDuLieu_ChiLuu()
        {
            if (!KiemTraLuu_SoPhieu()) return false;
            else
            {
                clsPhieu_tbPhieu cls = new clsPhieu_tbPhieu();               
                cls.sMaPhieu = txtMaPhieu.Text.ToString();
                cls.daNgayLapPhieu = dteNgayLap.DateTime;
                cls.sCaSanXuat = cbCaLamViec.Text.ToString();
                cls.iID_CaTruong = Convert.ToInt16(gridMaCaTruong.EditValue.ToString());
                cls.sGhiChu = txtGhiChu.Text.ToString();               
                cls.bTonTai = true;
                cls.bNgungTheoDoi = false;
                cls.bGuiDuLieu = false;
                
                cls.bCheck_In = false;
                cls.bCheck_Cat = false;
                cls.bCheck_Dot = false;
                cls.iBienTrangThai = 0;
                cls.Insert();
                return true;
            }
        }
        private bool LuuDuLieu_VaGui()
        {
            if (!KiemTraLuu_SoPhieu()) return false;
            else
            {
                clsPhieu_tbPhieu cls = new clsPhieu_tbPhieu();
                cls.sMaPhieu = txtMaPhieu.Text.ToString();
                cls.daNgayLapPhieu = dteNgayLap.DateTime;
                cls.sCaSanXuat = cbCaLamViec.Text.ToString();
                cls.iID_CaTruong = Convert.ToInt16(gridMaCaTruong.EditValue.ToString());
                cls.sGhiChu = txtGhiChu.Text.ToString();
                cls.bTonTai = true;
                cls.bNgungTheoDoi = false;
                cls.bGuiDuLieu = false;              
               
                cls.bCheck_In = false;
                cls.bCheck_Cat = false;
                cls.bCheck_Dot = false;
                cls.iBienTrangThai = 0;
                cls.bDaKetThuc = false;
                cls.Insert();
                return true;
              
            }
        }
        public SanXuat_frmThemMoi_SoPhieu()
        {
            InitializeComponent();
        }
      
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (!LuuDuLieu_ChiLuu()) return;
            else
            {
                MessageBox.Show("Đã lưu");
                this.Close();
            }
            
            
        }

        private void SanXuat_frmThemMoi_SoPhieu_Load(object sender, EventArgs e)
        {
          //  checkBoxInCatDot.Checked = true;
            dteNgayLap.DateTime = DateTime.Today;

            

            clsNhanSu_tbNhanSu clsNguoi = new clsNhanSu_tbNhanSu();
            DataTable dtNguoi = clsNguoi.SelectAll();
            dtNguoi.DefaultView.RowFilter = "TonTai=True and NgungTheoDoi=False and ID_BoPhan=8";
            DataView dvCaTruong = dtNguoi.DefaultView;
            DataTable newdtCaTruong = dvCaTruong.ToTable();

            gridMaCaTruong.Properties.DataSource = newdtCaTruong;
            gridMaCaTruong.Properties.ValueMember = "ID_NhanSu";
            gridMaCaTruong.Properties.DisplayMember = "MaNhanVien";
        }

       

        private void gridMaCaTruong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsNhanSu_tbNhanSu clsncc = new clsNhanSu_tbNhanSu();
                clsncc.iID_NhanSu = Convert.ToInt16(gridMaCaTruong.EditValue.ToString());
                DataTable dt = clsncc.SelectOne();
                if (dt.Rows.Count > 0)
                {
                    txtTenCaTruong.Text = dt.Rows[0]["TenNhanVien"].ToString();

                }


            }
            catch
            {

            }
        }

        private void btLuuVaCopy_Click(object sender, EventArgs e)
        {
            if (!LuuDuLieu_VaGui()) return;
            else
            {
                MessageBox.Show("Đã lưu và gửi dữ liệu");
                txtMaPhieu.ResetText();
            }

          
        }

        private void btLuu_Gui_Dong_Click(object sender, EventArgs e)
        {
            if (!LuuDuLieu_VaGui()) return;
            else
            {
                MessageBox.Show("Đã lưu và gửi dữ liệu");
                this.Close();
            }
            
            
        }

        
    }
}
