using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Text.RegularExpressions;
using ChartDirector;
using System.Threading;



//using COM.eBiz.Framework.Data;
//using COM.eBiz.Framework.Lib;
using FPSpreadADO;

namespace Smart_FTY
{
    public partial class FORM_OS_DEFFECTIVE_STATUS: Form
    {
        #region Declare
        int iNumRow = 0;
        
        DataTable dt_Daily_Report = null;
       
        //Thread th;
       // int _time = 0;
        int _load = 0;
        private int idx_form;
        #endregion

        #region Creation
        public FORM_OS_DEFFECTIVE_STATUS(int arg_idx = 0)
        {
            InitializeComponent();
            idx_form = arg_idx;
        }
        #endregion

        #region Method
        private void MergeCol(AxFPSpreadADO.AxfpSpread gridObject, int iStartRow, int iCol)
        {
            try
            {
                string sTemp1 = "";
                string sTemp2 = "";
                int iRow = iStartRow;
                gridObject.Row = iStartRow;
                gridObject.Col = iCol;
                sTemp1 = gridObject.Value;
                for (int i = iStartRow; i < gridObject.MaxRows + 4; i++)
                {
                    gridObject.Row = i;
                    gridObject.Col = iCol;
                    sTemp2 = gridObject.Value;
                    if (sTemp1 != sTemp2)
                    {
                        gridObject.AddCellSpan(iCol, iRow, 1, i - iRow);
                        sTemp1 = sTemp2;
                        sTemp2 = "";
                        iRow = i;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public bool IsNumeric(string text)
        {
            return Regex.IsMatch(text, "^\\d+$");
        }

        private void showAnimation(ChartDirector.WinChartViewer flg)
        {
            //flg.Hide();
            //IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(flg.Handle, 2000, IPEX_Monitor.ClassLib.WinAPI.getSlidType("2"));
            //flg.Show();
        }

        private void showAnimation(AxFPSpreadADO.AxfpSpread flg)
        {
            //flg.Hide();
            //Smart_FTY.ClassLib.WinAPI.AnimateWindow(flg.Handle, 500, Smart_FTY.ClassLib.WinAPI.getSlidType("2"));
            //flg.Show();
        }


        private void GoFullscreen()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        public void createChart(WinChartViewer viewer, DataTable dt_chart, string title)
        {
            try
            {
                Chart.setLicenseCode("DEVP-2LSU-B4LX-YCTY-2DF2-77EE");

                double[] data = new double[dt_chart.Rows.Count];
                string[] labels = new string[dt_chart.Rows.Count];

                for (int i = 0; i < dt_chart.Rows.Count; i++)
                {
                    data[i] = Convert.ToDouble(dt_chart.Rows[i]["RATE"].ToString());
                    labels[i] = dt_chart.Rows[i]["reason_tail_nm"].ToString();
                }



                // The colors to use for the sectors
                int[] colors = {0x66aaee, 0xeebb22, 0xbbbbbb, 0x8844ff, 0xdd2222,
                0x009900, 0xff8040, 0xaa0023};

                // Create a PieChart object of size 600 x 320 pixels. Use a vertical
                // gradient color from light blue (99ccff) to white (ffffff) spanning the
                // top 100 pixels as background. Set border to grey (888888). Use rounded
                // corners. Enable soft drop shadow.
                PieChart c = new PieChart(690, 310);
                c.setBackground(c.linearGradientColor(0, 0, 0, 100, 0x99ccff, 0xffffff),
                    0x888888);
                c.setRoundedFrame();
                c.setDropShadow();

                // Add a title using 18 pts Times New Roman Bold Italic font. Add 16
                // pixels top margin to the title.
                c.addTitle(title,
                    "Times New Roman Bold Italic", 18).setMargin2(0, 0, 1, 0);

                // Set the center of the pie at (160, 165) and the radius to 110 pixels
                c.setPieSize(230, 170, 140);

                // Draw the pie in 3D with a pie thickness of 25 pixels
                c.set3D(25);

                // Set the pie data and the pie labels
                c.setData(data, labels);

                // Set the sector colors
                c.setColors2(Chart.DataColor, colors);

                // Use local gradient shading for the sectors
                c.setSectorStyle(Chart.LocalGradientShading);

                // Use the side label layout method, with the labels positioned 16 pixels
                // from the pie bounding box
                c.setLabelLayout(Chart.SideLayout, 5);

                // Show only the sector number as the sector label
                c.setLabelFormat("{percent} % ");

                // Set the sector label style to Arial Bold 10pt, with a dark grey
                // (444444) border
                c.setLabelStyle("Arial Bold", 10).setBackground(Chart.Transparent,
                    0x444444);

                // Add a legend box, with the center of the left side anchored at (330,
                // 175), and using 10 pts Arial Bold Italic font
                LegendBox b = new LegendBox();
                b = c.addLegend(470, 150, true, "Arial Bold Italic", 12);
                b.setAlignment(Chart.Left);

                // Set the legend box border to dark grey (444444), and with rounded
                // conerns
                b.setBackground(Chart.Transparent, 0x444444);
                b.setRoundedCorners();

                // Set the legend box margin to 16 pixels, and the extra line spacing
                // between the legend entries as 5 pixels
                b.setMargin(16);
                b.setKeySpacing(0, 5);

                // Set the legend box icon to have no border (border color same as fill
                // color)
                b.setKeyBorder(Chart.SameAsMainColor);

                // Set the legend text to show the sector number, followed by a 120
                // pixels wide block showing the sector label, and a 40 pixels wide block
                // showing the percentage
                b.setText(
                    "<*block,valign=top*> <*advanceTo=22*>" +
                    "<*block,width=140*>{label}<*/*>");

                // Output the chart
                viewer.Chart = c;

                //include tool tip for the chart
                viewer.ImageMap = c.getHTMLImageMap("clickable", "",
                    "title='{label}: {percent} % '");
            }
            catch 
            {
                
               
            }
            // The data for the pie chart
            //dt_chart = this.select_chart_1();
            
        }

        private string FormatData(object arg_obj)
        {
            try
            {
                if (arg_obj != null && arg_obj.ToString() != "0")
                {
                    return Convert.ToDouble(arg_obj).ToString("#,###,##0.##");
                }
                else
                {
                    return "";
                }

            }
            catch (Exception)
            {
                return "";
            }
            
        }

        private void InitGridHeader()
        {

            for (int i = 5; i <= 31; i++)
            {
                this.axfpSpread.SetText(i, 1, "DATE_" + (i - 4).ToString());
            }
            DataTable dt = null;
            dt = select_work_date(UC_MONTH.GetValue());
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.axfpSpread.SetText(i + 5, 1, dt.Rows[i]["THEDATE"].ToString());
                }

                axfpSpread.LeftCol = dt.Rows.Count - 1;

            }
            for (int i = 5; i <= 31; i++)
            {
                string sHeader = "";
                axfpSpread.Col = i;
                axfpSpread.Row = 1;
                sHeader = axfpSpread.Value.ToString();
                if (sHeader.Contains("DATE_"))
                {
                    axfpSpread.set_ColWidth(i, 0);

                }
                else
                {
                    axfpSpread.set_ColWidth(i, 10.37);
                }
            }


            //for (int i = 2; i < axfpSpread.MaxRows; i++)
            //{
            //    axfpSpread.set_RowHeight(i, 20.5);
            //    axfpSpread.Row = i;
            //    axfpSpread.BackColor = Color.White;
            //}
        }


        private DataTable select_work_date(string arg_month)
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "MES.PKG_SMT_DMP_DMC.SELECT_WORK_DATE";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "ARG_MONTH";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC

            MyOraDB.Parameter_Type[0] = (int)OracleType.NVarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_month;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }

        private DataTable select_deffect_monitor(string arg_month)
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "MES.PKG_SMT_OS_DEFECTIVE.SEL_OS_DEFFECT_MONITOR_V2";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "ARG_MONTH";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC

            MyOraDB.Parameter_Type[0] = (int)OracleType.NVarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_month;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }


        private void Search_Daily_Report()
        {
            try
            {

                double[] total = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                //  DataTable dt = null;

                // dt = null;

                InitGridHeader();

                DataTable dt = select_deffect_monitor(UC_MONTH.GetValue());

                if (dt != null && dt.Rows.Count > 1)
                {
                    iNumRow = dt.Rows.Count;
                    dt_Daily_Report = dt;
                    axfpSpread.ClearRange(1, 2, axfpSpread.MaxCols, axfpSpread.MaxRows, true);
                    //   axfDailyReport_Header.Visible = false;
                    axfpSpread.Row = dt.Rows.Count + 2;
                    axfpSpread.BackColor = Color.Lime;

                    if (dt_Daily_Report != null && dt_Daily_Report.Rows.Count > 1)
                    {
                        for (int i = 0; i < dt_Daily_Report.Rows.Count; i++)
                        {
                            //  string sFormat = "#,###,##0.##";
                            if (dt_Daily_Report.Rows[i]["remark"].ToString() == "10"
                                || dt_Daily_Report.Rows[i]["remark"].ToString() == "20"
                                || dt_Daily_Report.Rows[i]["remark"].ToString() == "30")
                            {
                                axfpSpread.Row = i + 2;
                                axfpSpread.Col = 4;
                                axfpSpread.TypeHAlign = TypeHAlignConstants.TypeHAlignLeft;
                            }
                            axfpSpread.set_RowHeight(i + 2, 20.5);

                            this.axfpSpread.SetText(1, i + 2, dt_Daily_Report.Rows[i]["LEV"].ToString());
                            this.axfpSpread.SetText(2, i + 2, dt_Daily_Report.Rows[i]["PROCESS_NM"].ToString().Replace(" ", "\n"));
                            this.axfpSpread.SetText(3, i + 2, dt_Daily_Report.Rows[i]["REASON_HEAD_NM"].ToString());
                            this.axfpSpread.SetText(4, i + 2, dt_Daily_Report.Rows[i]["REASON_TAIL_NM"].ToString());
                            this.axfpSpread.SetText(5, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_1"]));
                            this.axfpSpread.SetText(6, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_2"]));
                            this.axfpSpread.SetText(7, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_3"]));
                            this.axfpSpread.SetText(8, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_4"]));
                            this.axfpSpread.SetText(9, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_5"]));
                            this.axfpSpread.SetText(10, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_6"]));
                            this.axfpSpread.SetText(11, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_7"]));
                            this.axfpSpread.SetText(12, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_8"]));
                            this.axfpSpread.SetText(13, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_9"]));
                            this.axfpSpread.SetText(14, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_10"]));
                            this.axfpSpread.SetText(15, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_11"]));
                            this.axfpSpread.SetText(16, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_12"]));
                            this.axfpSpread.SetText(17, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_13"]));
                            this.axfpSpread.SetText(18, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_14"]));
                            this.axfpSpread.SetText(19, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_15"]));
                            this.axfpSpread.SetText(20, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_16"]));
                            this.axfpSpread.SetText(21, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_17"]));
                            this.axfpSpread.SetText(22, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_18"]));
                            this.axfpSpread.SetText(23, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_19"]));
                            this.axfpSpread.SetText(24, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_20"]));
                            this.axfpSpread.SetText(25, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_21"]));
                            this.axfpSpread.SetText(26, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_22"]));
                            this.axfpSpread.SetText(27, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_23"]));
                            this.axfpSpread.SetText(28, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_24"]));
                            this.axfpSpread.SetText(29, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_25"]));
                            this.axfpSpread.SetText(30, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_26"]));
                            this.axfpSpread.SetText(31, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_27"]));
                            this.axfpSpread.SetText(32, i + 2, FormatData(dt_Daily_Report.Rows[i]["TOT"]));


                            if (dt_Daily_Report.Rows[i]["REASON_TAIL_CD"].ToString().Substring(0, 3) == "RAT")
                            {
                                for (int j = 3; j < dt_Daily_Report.Columns.Count; j++)
                                {
                                    axfpSpread.Col = j;
                                    axfpSpread.Row = i + 2;
                                    axfpSpread.BackColor = Color.DodgerBlue;

                                }

                            }
                            else if (dt_Daily_Report.Rows[i]["REASON_TAIL_CD"].ToString().Substring(0, 3) == "TOT")
                            {
                                for (int j = 4; j < dt_Daily_Report.Columns.Count; j++)
                                {
                                    axfpSpread.Col = j;
                                    axfpSpread.Row = i + 2;
                                    axfpSpread.BackColor = Color.Yellow;
                                    if (j >= 5 && j <= 35)
                                    {
                                        total[j - 5] += axfpSpread.Text == "" ? 0 : Convert.ToDouble(axfpSpread.Text);
                                    }

                                }

                            }
                            else
                            {
                                for (int j = 1; j < dt_Daily_Report.Columns.Count; j++)
                                {
                                    axfpSpread.Col = j;
                                    axfpSpread.Row = i + 2;
                                    axfpSpread.BackColor = Color.White;

                                }
                            }



                        }
                        //   axfpSpread.AddCellSpan(1, dt.Rows.Count + 2, 4, 1);

                        axfpSpread.SetText(2, dt.Rows.Count + 2, "Total");
                        axfpSpread.SetText(4, dt.Rows.Count + 2, "%");
                        axfpSpread.SetText(5, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_1"].ToString()) == 0 ? "0" : (total[0] / Convert.ToDouble(dt.Rows[0]["DATE_1"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(6, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_2"].ToString()) == 0 ? "0" : (total[1] / Convert.ToDouble(dt.Rows[0]["DATE_2"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(7, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_3"].ToString()) == 0 ? "0" : (total[2] / Convert.ToDouble(dt.Rows[0]["DATE_3"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(8, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_4"].ToString()) == 0 ? "0" : (total[3] / Convert.ToDouble(dt.Rows[0]["DATE_4"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(9, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_5"].ToString()) == 0 ? "0" : (total[4] / Convert.ToDouble(dt.Rows[0]["DATE_5"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(10, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_6"].ToString()) == 0 ? "0" : (total[5] / Convert.ToDouble(dt.Rows[0]["DATE_6"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(11, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_7"].ToString()) == 0 ? "0" : (total[6] / Convert.ToDouble(dt.Rows[0]["DATE_7"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(12, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_8"].ToString()) == 0 ? "0" : (total[7] / Convert.ToDouble(dt.Rows[0]["DATE_8"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(13, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_9"].ToString()) == 0 ? "0" : (total[8] / Convert.ToDouble(dt.Rows[0]["DATE_9"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(14, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_10"].ToString()) == 0 ? "0" : (total[9] / Convert.ToDouble(dt.Rows[0]["DATE_10"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(15, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_11"].ToString()) == 0 ? "0" : (total[10] / Convert.ToDouble(dt.Rows[0]["DATE_11"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(16, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_12"].ToString()) == 0 ? "0" : (total[11] / Convert.ToDouble(dt.Rows[0]["DATE_12"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(17, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_13"].ToString()) == 0 ? "0" : (total[12] / Convert.ToDouble(dt.Rows[0]["DATE_13"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(18, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_14"].ToString()) == 0 ? "0" : (total[13] / Convert.ToDouble(dt.Rows[0]["DATE_14"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(19, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_15"].ToString()) == 0 ? "0" : (total[14] / Convert.ToDouble(dt.Rows[0]["DATE_15"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(20, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_16"].ToString()) == 0 ? "0" : (total[15] / Convert.ToDouble(dt.Rows[0]["DATE_16"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(21, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_17"].ToString()) == 0 ? "0" : (total[16] / Convert.ToDouble(dt.Rows[0]["DATE_17"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(22, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_18"].ToString()) == 0 ? "0" : (total[17] / Convert.ToDouble(dt.Rows[0]["DATE_18"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(23, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_19"].ToString()) == 0 ? "0" : (total[18] / Convert.ToDouble(dt.Rows[0]["DATE_19"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(24, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_20"].ToString()) == 0 ? "0" : (total[19] / Convert.ToDouble(dt.Rows[0]["DATE_20"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(25, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_21"].ToString()) == 0 ? "0" : (total[20] / Convert.ToDouble(dt.Rows[0]["DATE_21"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(26, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_22"].ToString()) == 0 ? "0" : (total[21] / Convert.ToDouble(dt.Rows[0]["DATE_22"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(27, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_23"].ToString()) == 0 ? "0" : (total[22] / Convert.ToDouble(dt.Rows[0]["DATE_23"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(28, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_24"].ToString()) == 0 ? "0" : (total[23] / Convert.ToDouble(dt.Rows[0]["DATE_24"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(29, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_25"].ToString()) == 0 ? "0" : (total[24] / Convert.ToDouble(dt.Rows[0]["DATE_25"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(30, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_26"].ToString()) == 0 ? "0" : (total[25] / Convert.ToDouble(dt.Rows[0]["DATE_26"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(31, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_27"].ToString()) == 0 ? "0" : (total[26] / Convert.ToDouble(dt.Rows[0]["DATE_27"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(32, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["TOT"].ToString()) == 0 ? "0" : (total[27] / Convert.ToDouble(dt.Rows[0]["TOT"].ToString()) * 100).ToString("###,##0.00"));



                        for (int j = 1; j < dt_Daily_Report.Columns.Count; j++)
                        {
                            axfpSpread.Col = j;
                            axfpSpread.Row = dt.Rows.Count + 2;
                            axfpSpread.BackColor = Color.Lime;


                        }

                        int iTmp = dt.Rows.Count + 3;
                        for (int i = 2; i < iTmp; i++)
                        {
                            axfpSpread.set_RowHeight(i, 20.5);
                        }

                        for (int i = dt.Rows.Count + 3; i < axfpSpread.MaxRows + 1; i++)
                        {
                            axfpSpread.set_RowHeight(i, 0);
                        }
                        MergeCol(axfpSpread, 2, 1);
                        MergeCol(axfpSpread, 2, 2);
                        MergeCol(axfpSpread, 2, 3);

                        //  axfpSpread.TopRow = dt.Rows.Count - 15;



                        dt = null;

                        dt = select_chart_1(UC_MONTH.GetValue());
                        if (dt != null & dt.Rows.Count > 0)
                        {
                            createChart(chart1, dt, dt.Rows[0]["title"].ToString());
                        }

                        //dt = null;

                        //dt = select_chart_2(UC_MONTH.GetValue());
                        //if (dt != null & dt.Rows.Count > 0)
                        //{

                        //    createChart(chart2, dt, dt.Rows[0]["title"].ToString());
                        //}

                        //dt = select_chart_3();
                        //if (dt != null & dt.Rows.Count > 0)
                        //{

                        //    createChart(chart3, dt, dt.Rows[0]["title"].ToString());
                        //}

                        //  showAnimation(axfpSpread);
                    }

                    else
                    {

                    }
                }
                else
                {

                    //  axfDailyReport_Header.Visible = true;
                    iNumRow = 0;
                }
            }
            catch (Exception)
            {

            }




        }

        private DataTable select_chart_1(string arg_month)
        {


            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "MES.PKG_SMT_OS_DEFECTIVE.SEL_CHART_1_V2";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "ARG_MONTH";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC

            MyOraDB.Parameter_Type[0] = (int)OracleType.NVarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_month;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }


        #endregion


        #region DB
        private DataTable select_deffect_monitor()
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "MES.PKG_SMT_OS_DEFECTIVE.SEL_OS_DEFFECT_MONITOR";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC

            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }


        private DataTable select_work_date()
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "pkg_deffect_status.select_work_date";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC

            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }

        private DataTable select_chart_1()
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "MES.PKG_SMT_OS_DEFECTIVE.SEL_CHART_1";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC

            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }

        private DataTable select_chart_2()
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "pkg_DMC.sel_chart_2";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC

            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }

        private DataTable select_chart_3()
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "pkg_DMC.sel_chart_3";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC

            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }

        #endregion DB

        #region Event
        private void FORM_OS_DEFFECTIVE_STATUS_Load(object sender, EventArgs e)
        {
            try
            {
                //Com_Base.Functions.Form_Maximized(this, int.Parse(Com_Base.Variables.Form[idx_form]["monitor"]));
                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                GoFullscreen();
                
             //   panel1.BackColor = Color.FromArgb(255, 165, 0);
              //  this.lblDate.BackColor = Color.FromArgb(255, 165,0);

                timer2.Interval = 1000;

                Search_Daily_Report();

               // this.MaximumSize = new Size(500, 500);
            }
            catch (System.Exception )
            {
               
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
            _load++;
            if (_load == 300)
            {
                Search_Daily_Report();
                _load = 0;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Stop();
            //Com_Base.Variables._iskeypress = false;
            //nextForm();

        }


        private void lblDate_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FORM_OS_DEFFECTIVE_STATUS_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                //try
                //{
                    timer2.Start();
                    //DataTable dt = null;
                    //dt = select_work_date();

                    //if (dt != null && dt.Rows.Count > 0)
                    //{
                    //    this.axfpSpread.SetText(5, 1, dt.Rows[0]["THEDATE"].ToString());
                    //    this.axfpSpread.SetText(6, 1, dt.Rows[1]["THEDATE"].ToString());
                    //    this.axfpSpread.SetText(7, 1, dt.Rows[2]["THEDATE"].ToString());
                    //    this.axfpSpread.SetText(8, 1, dt.Rows[3]["THEDATE"].ToString());
                    //    this.axfpSpread.SetText(9, 1, dt.Rows[4]["THEDATE"].ToString());
                    //    this.axfpSpread.SetText(10, 1, dt.Rows[5]["THEDATE"].ToString());
                    //}


                   // axfDailyReport_Header.Visible = false;


                    
                    // set_time_chage();
                //}
                //catch (Exception)
                //{


                //}
            }
            else
            {
                timer2.Stop();
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Smart_FTY.ComVar._frm_home.Show();            
            this.Hide();
        }

        private void cmdYear_Click(object sender, EventArgs e)
        {
            Smart_FTY.ComVar._frmDefectiveYear.Show();
            this.Hide();
        }

        private void UC_MONTH_ValueChangeEvent(object sender, EventArgs e)
        {
            Search_Daily_Report();
        }

    }
}
