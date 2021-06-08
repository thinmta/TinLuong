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

            if (DateTime.Now.Month <= 9) pMonth.Value = "0" + DateTime.Now.Month.ToString();
            else pMonth.Value = DateTime.Now.Month.ToString();
            pYear.Value = DateTime.Now.Year;

            Ngay31.Visible = false;

            Ngay30.Visible = false;
            Ngay30.WidthF = 0;
            Ngay31.WidthF = 0;
            //Ngay30.Padding = 0;
            //Ngay31.Padding = 0;
            setThu();
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            DateTime d = Convert.ToDateTime(pNgay.Value);
            if (d.Day > 9)
            {
                if (d.Month > 9)
                {
                    lbNgayThangNam.Text = "Ngày " + d.Day
                                        + " tháng " + d.Month
                                        + " năm " + d.Year;
                }
                else
                {
                    lbNgayThangNam.Text = "Ngày " + d.Day
                                        + " tháng 0" + d.Month
                                        + " năm " + d.Year;
                }

            }
            else
            {
                if (d.Month > 9)
                {
                    lbNgayThangNam.Text = "Ngày 0" + d.Day
                                        + " tháng " + d.Month
                                        + " năm " + d.Year;
                }
                else
                {
                    lbNgayThangNam.Text = "Ngày 0" + d.Day
                                        + " tháng 0" + d.Month
                                        + " năm " + d.Year;
                }
            }

        }

        private string LayThu(DateTime date)
        {
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    return "T2";
                case DayOfWeek.Tuesday:
                    return "T3";
                case DayOfWeek.Wednesday:
                    return "T4";
                case DayOfWeek.Thursday:
                    return "T5";
                case DayOfWeek.Friday:
                    return "T6";
                case DayOfWeek.Saturday:
                    return "T7";
                case DayOfWeek.Sunday:
                    return "CN";
            }
            return "";
        }

        public void setThu()
        {
            DateTime dtnow = DateTime.Now;
            DateTime date_ = new DateTime(dtnow.Year, dtnow.Month, 1);
            int ngaycuathang_ = (((new DateTime(dtnow.Year, dtnow.Month, 1)).AddMonths(1)).AddDays(-1)).Day;
            string thu_ = LayThu(date_);

            ng1.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (1)));
            if (ng1.Text.Contains("CN"))
            {
                ng1.BackColor = Color.LightGray;
            }

            ng2.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (2)));
            if (ng2.Text.Contains("CN"))
            {
                ng2.BackColor = Color.LightGray;
            }

            ng3.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (3)));
            if (ng3.Text.Contains("CN"))
            {
                ng3.BackColor = Color.LightGray;
            }


            ng3.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (3)));
            if (ng3.Text.Contains("CN"))
            {
                ng3.BackColor = Color.LightGray;
            }


            ng3.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (3)));
            if (ng3.Text.Contains("CN"))
            {
                ng3.BackColor = Color.LightGray;
            }


            ng4.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (4)));
            if (ng4.Text.Contains("CN"))
            {
                ng4.BackColor = Color.LightGray;
            }


            ng5.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (5)));
            if (ng5.Text.Contains("CN"))
            {
                ng5.BackColor = Color.LightGray;
            }


            ng6.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (6)));
            if (ng6.Text.Contains("CN"))
            {
                ng6.BackColor = Color.LightGray;
            }


            ng7.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (7)));
            if (ng7.Text.Contains("CN"))
            {
                ng7.BackColor = Color.LightGray;
            }


            ng8.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (8)));
            if (ng8.Text.Contains("CN"))
            {
                ng8.BackColor = Color.LightGray;
            }


            ng9.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (9)));
            if (ng9.Text.Contains("CN"))
            {
                ng9.BackColor = Color.LightGray;
            }
        }
    }
}
