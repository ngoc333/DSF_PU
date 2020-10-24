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
    public partial class FORM_PU_DEFFECTIVE_STATUS_YEAR: Form
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
        public FORM_PU_DEFFECTIVE_STATUS_YEAR(int arg_idx = 0)
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
                c.setPieSize(210, 150, 140);

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
                c.setLabelLayout(Chart.Transparent, 16);

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
                if (arg_obj != null)
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

        private void Search_Daily_Report()
        {
            try
            {
                axfpSpread.Visible = false;
                double[] total = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
              //  DataTable dt = null;

               // dt = null;

                DataTable dt = select_deffect_monitor(ucYear.GetValue().ToString());

                if (dt != null && dt.Rows.Count > 1)
                {
                    axfpSpread.Visible = false;
                    iNumRow = dt.Rows.Count;
                    dt_Daily_Report = dt;
                    axfpSpread.ClearRange(1, 2, axfpSpread.MaxCols, axfpSpread.MaxRows, true);
                    //for (int i = 2; i < axfpSpread.MaxRows; i++)
                    //{
                    //    axfpSpread.Row = i;
                    //    axfpSpread.BackColor = Color.White;
                    //}
                 
                  

                    if (dt_Daily_Report != null && dt_Daily_Report.Rows.Count > 1)
                    {
                       
                        for (int i = 0; i < dt_Daily_Report.Rows.Count; i++)
                        {
                          
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
                            this.axfpSpread.SetText(5, i + 2, FormatData(dt_Daily_Report.Rows[i]["MON_1"]));
                            this.axfpSpread.SetText(6, i + 2, FormatData(dt_Daily_Report.Rows[i]["MON_2"]));
                            this.axfpSpread.SetText(7, i + 2, FormatData(dt_Daily_Report.Rows[i]["MON_3"]));
                            this.axfpSpread.SetText(8, i + 2, FormatData(dt_Daily_Report.Rows[i]["MON_4"]));
                            this.axfpSpread.SetText(9, i + 2, FormatData(dt_Daily_Report.Rows[i]["MON_5"]));
                            this.axfpSpread.SetText(10, i + 2, FormatData(dt_Daily_Report.Rows[i]["MON_6"]));
                            this.axfpSpread.SetText(11, i + 2, FormatData(dt_Daily_Report.Rows[i]["MON_7"]));
                            this.axfpSpread.SetText(12, i + 2, FormatData(dt_Daily_Report.Rows[i]["MON_8"]));
                            this.axfpSpread.SetText(13, i + 2, FormatData(dt_Daily_Report.Rows[i]["MON_9"]));
                            this.axfpSpread.SetText(14, i + 2, FormatData(dt_Daily_Report.Rows[i]["MON_10"]));
                            this.axfpSpread.SetText(15, i + 2, FormatData(dt_Daily_Report.Rows[i]["MON_11"]));
                            this.axfpSpread.SetText(16, i + 2, FormatData(dt_Daily_Report.Rows[i]["MON_12"]));

                            this.axfpSpread.SetText(17, i + 2, FormatData(dt_Daily_Report.Rows[i]["TOT"]));


                            if (dt_Daily_Report.Rows[i]["REASON_TAIL_CD"].ToString().Substring(0, 3) == "RAT")
                            {
                                for (int j = 3; j < dt_Daily_Report.Columns.Count; j++)
                                {
                                    axfpSpread.Col = j;
                                    axfpSpread.Row = i + 2;
                                    axfpSpread.BackColor = Color.DodgerBlue;
                                    if (j >= 5 && j <= 11)
                                    {
                                        total[j - 5] += axfpSpread.Text == "" ? 0 : Convert.ToDouble(axfpSpread.Text);
                                    }
                                }

                            }
                            else if (dt_Daily_Report.Rows[i]["REASON_TAIL_CD"].ToString().Substring(0, 3) == "TOT")
                            {
                                for (int j = 4; j < dt_Daily_Report.Columns.Count; j++)
                                {
                                    axfpSpread.Col = j;
                                    axfpSpread.Row = i + 2;
                                    axfpSpread.BackColor = Color.Yellow;

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


                        axfpSpread.SetText(2, dt.Rows.Count + 2, "Total");
                        axfpSpread.SetText(4, dt.Rows.Count + 2, "%");
                        axfpSpread.SetText(5, dt.Rows.Count + 2, total[0] == 0 ? "" : total[0].ToString("###,##0.00"));
                        axfpSpread.SetText(6, dt.Rows.Count + 2, total[1] == 0 ? "" : total[1].ToString("###,##0.00"));
                        axfpSpread.SetText(7, dt.Rows.Count + 2, total[2] == 0 ? "" : total[2].ToString("###,##0.00"));
                        axfpSpread.SetText(8, dt.Rows.Count + 2, total[3] == 0 ? "" : total[3].ToString("###,##0.00"));
                        axfpSpread.SetText(9, dt.Rows.Count + 2, total[4] == 0 ? "" : total[4].ToString("###,##0.00"));
                        axfpSpread.SetText(10, dt.Rows.Count + 2, total[5] == 0 ? "" : total[5].ToString("###,##0.00"));
                        axfpSpread.SetText(11, dt.Rows.Count + 2, total[6] == 0 ? "" : total[6].ToString("###,##0.00"));
                        axfpSpread.SetText(12, dt.Rows.Count + 2, total[7] == 0 ? "" : total[7].ToString("###,##0.00"));
                        axfpSpread.SetText(13, dt.Rows.Count + 2, total[8] == 0 ? "" : total[8].ToString("###,##0.00"));
                        axfpSpread.SetText(14, dt.Rows.Count + 2, total[9] == 0 ? "" : total[9].ToString("###,##0.00"));
                        axfpSpread.SetText(15, dt.Rows.Count + 2, total[10] == 0 ? "" : total[10].ToString("###,##0.00"));
                        axfpSpread.SetText(16, dt.Rows.Count + 2, total[11] == 0 ? "" : total[11].ToString("###,##0.00"));
                      
                        

                        for (int i = 1; i < dt.Columns.Count; i++)
                        {
                            axfpSpread.Col = i;
                            axfpSpread.Row = dt.Rows.Count + 2;
                            axfpSpread.BackColor = Color.Lime;
                        }
                        int iTmp = dt.Rows.Count + 3;
                        for (int i = 2; i < iTmp; i++)
                        {
                             axfpSpread.set_RowHeight(i, 20.5);
                        }
                        for (int i =iTmp ; i < axfpSpread.MaxRows + 1; i++)
                        {
                            axfpSpread.set_RowHeight(i, 0); 
                        }
                        MergeCol(axfpSpread, 2, 1);
                        MergeCol(axfpSpread, 2, 2);
                        MergeCol(axfpSpread, 2, 3);

                        dt = null;

                        dt = select_chart_1(ucYear.GetValue().ToString());
                        if (dt != null & dt.Rows.Count > 0)
                        {
                            chart1.Visible = true;
                            createChart(chart1, dt, dt.Rows[0]["title"].ToString());
                        }
                        else
                        {
                            chart1.Visible = false;
                        }

                        //dt = null;

                        //dt = select_chart_2(ucYear.GetValue().ToString());
                        //if (dt != null & dt.Rows.Count > 0)
                        //{
                        //    chart2.Visible = true;
                        //    createChart(chart2, dt, dt.Rows[0]["title"].ToString());
                        //}
                        //else
                        //{
                        //    chart2.Visible = false;
                        //}

                        //dt = select_chart_3(ucYear.GetValue().ToString());
                        //if (dt != null & dt.Rows.Count > 0)
                        //{
                        //    chart3.Visible = true;
                        //    createChart(chart3, dt, dt.Rows[0]["title"].ToString());
                        //}
                        //else
                        //{
                        //    chart3.Visible = false;
                        //}

                      //  showAnimation(axfpSpread);
                    }

                    else
                    {

                    }
                   
                }
                else
                {

                    for (int i = 2; i < axfpSpread.MaxRows; i++)
                    {
                        axfpSpread.set_RowHeight(i, 0);
                    }
                    chart1.Visible = false;
                    chart2.Visible = false;
                    chart3.Visible = false;
                    iNumRow = 0;
                }
                axfpSpread.Visible = true;
            }
            catch (Exception)
            {
                
            }               
                   

        }




        #endregion


        #region DB
        private DataTable select_deffect_monitor(string sYear)
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "MES.PKG_SMT_PU.SEL_PU_DEFECT_MONITOR_YEAR";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "ARG_YEAR";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = sYear;
            MyOraDB.Parameter_Values[1] = "";

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

        private DataTable select_chart_1(string arg_year)
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "MES.PKG_SMT_PU.SEL_CHART_1_YEAR";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "ARG_YEAR";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC
            MyOraDB.Parameter_Type[0] = (int)OracleType.NVarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_year;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }

        private DataTable select_chart_2(string arg_year)
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "pkg_DMC.sel_chart_2_year";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "ARG_YEAR";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC
            MyOraDB.Parameter_Type[0] = (int)OracleType.NVarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_year;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }

        private DataTable select_chart_3(string arg_year)
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "pkg_DMC.sel_chart_3_year";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "ARG_YEAR";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC
            MyOraDB.Parameter_Type[0] = (int)OracleType.NVarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_year;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }

        #endregion DB

        #region Event
        private void FORM_DMP_DEFFECTIVE_STATUS_YEAR_Load(object sender, EventArgs e)
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
               // ucYear.SetValue("2018");
              //  ucYear.ValueChangeEvent += new EventHandler(UserControl_ValueChangeEvent);
            }
            catch (System.Exception )
            {
               
            }

        }

        //protected void UserControl_ValueChangeEvent(object sender, EventArgs e)
        //{
        //   // ucYear.EnableControl(false);
        //    Search_Daily_Report();
        //    //ucYear.EnableControl(true);
        //}

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
            _load++;
            if (_load == 1800)
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

        private void FORM_DMP_DEFFECTIVE_STATUS_YEAR_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                //try
                //{
                    timer2.Start();
                    DataTable dt = null;
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

        private void cmdMonth_Click(object sender, EventArgs e)
        {
            Smart_FTY.ComVar._frmDefective.Show();
            this.Hide();
        }

        private void ucYear_ValueChangeEvent(object sender, EventArgs e)
        {
            Search_Daily_Report();
        }
              

    }
}
