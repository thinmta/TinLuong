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
    public partial class frmBaoCaoSanLuong_Theo_CongNhan : Form
    {
        
        public static DateTime GetFistDayInMonth(int year, int month)
        {
            DateTime aDateTime = new DateTime(year, month, 1);
            return aDateTime;
        }
       
        public frmBaoCaoSanLuong_Theo_CongNhan()
        {
            InitializeComponent();
        }

        private void frmBaoCaoSanLuong_Theo_CongNhan_Load(object sender, EventArgs e)
        {
         
        }

     
    }
}
