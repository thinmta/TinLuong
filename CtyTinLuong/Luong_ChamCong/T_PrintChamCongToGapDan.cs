using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CtyTinLuong.Luong_ChamCong
{
    public partial class T_PrintChamCongToGapDan : DevExpress.XtraReports.UI.XtraReport
    {
        public T_PrintChamCongToGapDan()
        {
            InitializeComponent();

        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            pMonth.Value = DateTime.Now.Month;
            pYear.Value = DateTime.Now.Year;
        }
    }
}
