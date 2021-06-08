using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace CtyTinLuong.Luong_ChamCong
{
    public partial class T_PrintChamCongToGapDan : DevExpress.XtraReports.UI.XtraReport
    {
        List<XRTableCell> Ds_Ngay;
        List<XRTableCell> Ds_Ngay_Header;
        public T_PrintChamCongToGapDan()
        {
            InitializeComponent();
            Ds_Ngay.Add(Ngay1);
            Ds_Ngay.Add(Ngay2);
            Ds_Ngay.Add(Ngay3);
            Ds_Ngay.Add(Ngay4);
            Ds_Ngay.Add(Ngay5);
            Ds_Ngay.Add(Ngay6);
            Ds_Ngay.Add(Ngay7);
            Ds_Ngay.Add(Ngay8);
            Ds_Ngay.Add(Ngay9);
            Ds_Ngay.Add(Ngay10);
            Ds_Ngay.Add(Ngay11);
            Ds_Ngay.Add(Ngay12);
            Ds_Ngay.Add(Ngay13);
            Ds_Ngay.Add(Ngay14);
            Ds_Ngay.Add(Ngay15);
            Ds_Ngay.Add(Ngay16);
            Ds_Ngay.Add(Ngay17);
            Ds_Ngay.Add(Ngay18);
            Ds_Ngay.Add(Ngay19);
            Ds_Ngay.Add(Ngay20);
            Ds_Ngay.Add(Ngay21);
            Ds_Ngay.Add(Ngay22);
            Ds_Ngay.Add(Ngay23);
            Ds_Ngay.Add(Ngay24);
            Ds_Ngay.Add(Ngay25);
            Ds_Ngay.Add(Ngay26);
            Ds_Ngay.Add(Ngay27);
            Ds_Ngay.Add(Ngay28);
            Ds_Ngay.Add(Ngay29);
            Ds_Ngay.Add(Ngay30);
            Ds_Ngay.Add(Ngay31);
            //
            Ds_Ngay_Header.Add(ng1);
            Ds_Ngay_Header.Add(ng2);
            Ds_Ngay_Header.Add(ng3);
            Ds_Ngay_Header.Add(ng4);
            Ds_Ngay_Header.Add(ng5);
            Ds_Ngay_Header.Add(ng6);
            Ds_Ngay_Header.Add(ng7);
            Ds_Ngay_Header.Add(ng8);
            Ds_Ngay_Header.Add(ng9);
            Ds_Ngay_Header.Add(ng10);
            Ds_Ngay_Header.Add(ng11);
            Ds_Ngay_Header.Add(ng12);
            Ds_Ngay_Header.Add(ng13);
            Ds_Ngay_Header.Add(ng14);
            Ds_Ngay_Header.Add(ng15);
            Ds_Ngay_Header.Add(ng16);
            Ds_Ngay_Header.Add(ng17);
            Ds_Ngay_Header.Add(ng18);
            Ds_Ngay_Header.Add(ng19);
            Ds_Ngay_Header.Add(ng20);
            Ds_Ngay_Header.Add(ng21);
            Ds_Ngay_Header.Add(ng22);
            Ds_Ngay_Header.Add(ng23);
            Ds_Ngay_Header.Add(ng24);
            Ds_Ngay_Header.Add(ng25);
            Ds_Ngay_Header.Add(ng26);
            Ds_Ngay_Header.Add(ng27);
            Ds_Ngay_Header.Add(ng28);
            Ds_Ngay_Header.Add(ng29);
            Ds_Ngay_Header.Add(ng30);
            Ds_Ngay_Header.Add(ng31);

            if (DateTime.Now.Month <= 9) pMonth.Value = "0" + DateTime.Now.Month.ToString();
            else pMonth.Value = DateTime.Now.Month.ToString();
            pYear.Value = DateTime.Now.Year;
            setThu();
           // setMauTableDetail();
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
            // 
            int ngaycuathang_ = (((new DateTime(dtnow.Year, dtnow.Month, 1)).AddMonths(1)).AddDays(-1)).Day;

            for (int i = 0; i < ngaycuathang_; ++i)
            {
                Ds_Ngay_Header[i].Text = (i + 1) + "\n" + LayThu(new DateTime(dtnow.Year, dtnow.Month, (i + 1)));
                if (Ds_Ngay_Header[i].Text.Contains("CN"))
                {
                    Ds_Ngay_Header[i].BackColor = Color.LightGray;
                    Ds_Ngay_Header[i].BackColor = Color.LightGray;
                    Ds_Ngay_Header[i].ForeColor = Color.Red;
                    Ds_Ngay_Header[i].ForeColor = Color.Red;
                }
            }
            //
            for (int i = 0; i < ngaycuathang_; ++i)
            {
                Ds_Ngay[i].Text = (i + 1) + "\n" + LayThu(new DateTime(dtnow.Year, dtnow.Month, (i + 1)));
                if (Ds_Ngay[i].Text.Contains("CN"))
                {
                    Ds_Ngay[i].BackColor = Color.LightGray;
                    Ds_Ngay[i].BackColor = Color.LightGray;
                    Ds_Ngay[i].ForeColor = Color.Red;
                    Ds_Ngay[i].ForeColor = Color.Red;
                }
            }
            ////
            //DateTime date_ = new DateTime(dtnow.Year, dtnow.Month, 1);
            //int ngaycuathang_ = (((new DateTime(dtnow.Year, dtnow.Month, 1)).AddMonths(1)).AddDays(-1)).Day;
            //string thu_ = LayThu(date_);

            //ng1.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (1)));
            //if (ng1.Text.Contains("CN"))
            //{
            //    ng1.BackColor = Color.LightGray;
            //}

            //ng2.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (2)));
            //if (ng2.Text.Contains("CN"))
            //{
            //    ng2.BackColor = Color.LightGray;
            //}

            //ng3.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (3)));
            //if (ng3.Text.Contains("CN"))
            //{
            //    ng3.BackColor = Color.LightGray;
            //}


            //ng4.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (4)));
            //if (ng4.Text.Contains("CN"))
            //{
            //    ng4.BackColor = Color.LightGray;
            //}


            //ng5.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (5)));
            //if (ng5.Text.Contains("CN"))
            //{
            //    ng5.BackColor = Color.LightGray;
            //}


            //ng6.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (6)));
            //if (ng6.Text.Contains("CN"))
            //{
            //    ng6.BackColor = Color.LightGray;
            //}


            //ng7.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (7)));
            //if (ng7.Text.Contains("CN"))
            //{
            //    ng7.BackColor = Color.LightGray;
            //}


            //ng8.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (8)));
            //if (ng8.Text.Contains("CN"))
            //{
            //    ng8.BackColor = Color.LightGray;
            //}


            //ng9.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (9)));
            //if (ng9.Text.Contains("CN"))
            //{
            //    ng9.BackColor = Color.LightGray;
            //}

            //ng10.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (10)));
            //if (ng10.Text.Contains("CN"))
            //{
            //    ng10.BackColor = Color.LightGray;
            //}

            //ng11.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (11)));
            //if (ng11.Text.Contains("CN"))
            //{
            //    ng11.BackColor = Color.LightGray;
            //}

            //ng12.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (12)));
            //if (ng12.Text.Contains("CN"))
            //{
            //    ng12.BackColor = Color.LightGray;
            //}

            //ng13.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (13)));
            //if (ng13.Text.Contains("CN"))
            //{
            //    ng13.BackColor = Color.LightGray;
            //}


            //ng14.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (14)));
            //if (ng14.Text.Contains("CN"))
            //{
            //    ng14.BackColor = Color.LightGray;
            //}


            //ng15.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (15)));
            //if (ng15.Text.Contains("CN"))
            //{
            //    ng15.BackColor = Color.LightGray;
            //}


            //ng16.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (16)));
            //if (ng16.Text.Contains("CN"))
            //{
            //    ng16.BackColor = Color.LightGray;
            //}


            //ng17.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (17)));
            //if (ng17.Text.Contains("CN"))
            //{
            //    ng17.BackColor = Color.LightGray;
            //}


            //ng18.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (18)));
            //if (ng18.Text.Contains("CN"))
            //{
            //    ng18.BackColor = Color.LightGray;
            //}


            //ng19.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (19)));
            //if (ng19.Text.Contains("CN"))
            //{
            //    ng19.BackColor = Color.LightGray;
            //}

            //ng20.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (20)));
            //if (ng20.Text.Contains("CN"))
            //{
            //    ng20.BackColor = Color.LightGray;
            //}


            //ng21.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (21)));
            //if (ng21.Text.Contains("CN"))
            //{
            //    ng21.BackColor = Color.LightGray;
            //}

            //ng22.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (22)));
            //if (ng22.Text.Contains("CN"))
            //{
            //    ng22.BackColor = Color.LightGray;
            //}

            //ng23.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (23)));
            //if (ng23.Text.Contains("CN"))
            //{
            //    ng23.BackColor = Color.LightGray;
            //}


            //ng24.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (24)));
            //if (ng24.Text.Contains("CN"))
            //{
            //    ng24.BackColor = Color.LightGray;
            //}


            //ng25.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (25)));
            //if (ng25.Text.Contains("CN"))
            //{
            //    ng25.BackColor = Color.LightGray;
            //}


            //ng26.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (26)));
            //if (ng26.Text.Contains("CN"))
            //{
            //    ng26.BackColor = Color.LightGray;
            //}


            //ng27.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (27)));
            //if (ng27.Text.Contains("CN"))
            //{
            //    ng27.BackColor = Color.LightGray;
            //}


            //ng28.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (28)));
            //if (ng28.Text.Contains("CN"))
            //{
            //    ng28.BackColor = Color.LightGray;
            //}


            //ng29.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (29)));
            //if (ng29.Text.Contains("CN"))
            //{
            //    ng29.BackColor = Color.LightGray;
            //}

            //ng30.Text = LayThu(new DateTime(dtnow.Year, dtnow.Month, (30)));
            //if (ng30.Text.Contains("CN"))
            //{
            //    ng30.BackColor = Color.LightGray;
            //}

        }

        //set mau bang du lieu:
        public void setMauTableDetail2()
        {
            DateTime dtnow = DateTime.Now;
            DateTime date_ = new DateTime(dtnow.Year, dtnow.Month, 1);
            int ngaycuathang_ = (((new DateTime(dtnow.Year, dtnow.Month, 1)).AddMonths(1)).AddDays(-1)).Day;
            string thu_ = "";

            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (1)));
            if (thu_.Contains("CN"))
            {
                Ngay1.BackColor = Color.LightGray;
            }

            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (2)));
            if (thu_.Contains("CN"))
            {
                Ngay2.BackColor = Color.LightGray;
            }

            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (3)));
            if (thu_.Contains("CN"))
            {
                Ngay3.BackColor = Color.LightGray;
            }


            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (4)));
            if (thu_.Contains("CN"))
            {
                Ngay4.BackColor = Color.LightGray;
            }


            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (5)));
            if (thu_.Contains("CN"))
            {
                Ngay5.BackColor = Color.LightGray;
            }


            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (6)));
            if (thu_.Contains("CN"))
            {
                Ngay6.BackColor = Color.LightGray;
            }


            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (7)));
            if (thu_.Contains("CN"))
            {
                Ngay7.BackColor = Color.LightGray;
            }


            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (8)));
            if (thu_.Contains("CN"))
            {
                Ngay8.BackColor = Color.LightGray;
            }


            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (9)));
            if (thu_.Contains("CN"))
            {
                Ngay9.BackColor = Color.LightGray;
            }

            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (10)));
            if (thu_.Contains("CN"))
            {
                Ngay10.BackColor = Color.LightGray;
            }

            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (11)));
            if (thu_.Contains("CN"))
            {
                Ngay11.BackColor = Color.LightGray;
            }

            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (12)));
            if (thu_.Contains("CN"))
            {
                Ngay12.BackColor = Color.LightGray;
            }

            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (13)));
            if (thu_.Contains("CN"))
            {
                Ngay13.BackColor = Color.LightGray;
            }


            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (14)));
            if (thu_.Contains("CN"))
            {
                Ngay14.BackColor = Color.LightGray;
            }


            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (15)));
            if (thu_.Contains("CN"))
            {
                Ngay15.BackColor = Color.LightGray;
            }


            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (16)));
            if (thu_.Contains("CN"))
            {
                Ngay16.BackColor = Color.LightGray;
            }


            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (17)));
            if (thu_.Contains("CN"))
            {
                Ngay17.BackColor = Color.LightGray;
            }


            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (18)));
            if (thu_.Contains("CN"))
            {
                Ngay18.BackColor = Color.LightGray;
            }


            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (19)));
            if (thu_.Contains("CN"))
            {
                Ngay19.BackColor = Color.LightGray;
            }

            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (20)));
            if (thu_.Contains("CN"))
            {
                Ngay20.BackColor = Color.LightGray;
            }


            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (21)));
            if (thu_.Contains("CN"))
            {
                Ngay21.BackColor = Color.LightGray;
            }

            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (22)));
            if (thu_.Contains("CN"))
            {
                Ngay22.BackColor = Color.LightGray;
            }

            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (23)));
            if (thu_.Contains("CN"))
            {
                Ngay23.BackColor = Color.LightGray;
            }


            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (24)));
            if (thu_.Contains("CN"))
            {
                Ngay24.BackColor = Color.LightGray;
            }


            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (25)));
            if (thu_.Contains("CN"))
            {
                Ngay25.BackColor = Color.LightGray;
            }


            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (26)));
            if (thu_.Contains("CN"))
            {
                Ngay26.BackColor = Color.LightGray;
            }


            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (27)));
            if (thu_.Contains("CN"))
            {
                Ngay27.BackColor = Color.LightGray;
            }


            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (28)));
            if (thu_.Contains("CN"))
            {
                Ngay28.BackColor = Color.LightGray;
            }


            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (29)));
            if (thu_.Contains("CN"))
            {
                Ngay29.BackColor = Color.LightGray;
            }

            thu_ = LayThu(new DateTime(dtnow.Year, dtnow.Month, (30)));
            if (thu_.Contains("CN"))
            {
                Ngay30.BackColor = Color.LightGray;
            }

        }
    }
}
