using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.OracleClient;
//using MaterialSetRate;
using System.Data.SqlClient;
using ChartDirector;
using System.Threading;


namespace Smart_FTY
{
    public partial class FORM_SMT_PU_MOLD_OVERHAUL : Form
    {
        public FORM_SMT_PU_MOLD_OVERHAUL()
        {
            
            InitializeComponent();
           // lblTitle2.Text = "Outsole Mold Overhaul by Week ";
            lblTitle2.Text = "PU Mold Overhaul by Week (" + DateTime.Now.AddDays(-7).ToString("MMM-dd") + " ~ " + DateTime.Now.ToString("MMM-dd") + ")";
        }


        string viewMode = "50";
        private int chartWidth = 1400;
        private int chartHeight = 700;
        private int plottWidth = 1300;
        private int plotHeight = 550;
        int masterColor = 0xffffff;
       // private int numRows = 2;
        private int numCols = 16;
        private int percentage = 0;
       // private int per = 0;
        public int _frm;
        private int _time_change = 0;

        DataTable _dt_model = null;
        DataTable dt_top = null;
        int DayOfMonth =0;
        double[] data0;
        double[] data1;
        double[] data2;
        string[] labels;
      //  Thread th;
     //   bool _IsKey = true;
      //  int icount = 0;

      

        #region Function

        //private void addUC()
        //{
        //    Smart_FTY.UC.UC_DWMY ucMenu = new UC.UC_DWMY(5);
        //    pnMenu.Controls.Add(ucMenu);
        //    ucMenu.OnDWMYClick += mnBtnClick;
            
        //}

        //private void mnBtnClick(string ButtonCap, string ButtonCD)
        //{
        //    switch (ButtonCap)
        //    {
        //        case "btnClose":
        //            this.Close();
        //            break;
        //    }
             
        //}
                
      
        #region Chart

        public void createChart(WinChartViewer viewer, int per)
        {
            Chart.setLicenseCode("DEVP-2LSU-B4LX-YCTY-2DF2-77EE");


            double[] d0 = new double[DayOfMonth];
            double[] d1 = new double[DayOfMonth];
            double[] d2 = new double[DayOfMonth];
            // The data for the bar chart

            // Create a XYChart object of size 580 x 280 pixels
            XYChart c = new XYChart(1900, 500);

            // Set the plot area at (50, 50) and of size 500 x 200. Use two
            // alternative background colors (f8f8f8 and ffffff)
            c.setPlotArea(50, 50, 1720, 400, 0xf8f8f8, 0xffffff);

            // Add a legend box at (50, 25) using horizontal layout. Use 8pts Arial
            // as font, with transparent background.
            c.addLegend(c.getWidth() - 120, 25, false, "Calibri Bold", 18).setBackground(Chart.Transparent);

            // Set the x axis labels
            c.xAxis().setLabels(labels);

            // Draw the ticks between label positions (instead of at label positions)
            c.xAxis().setTickOffset(0.5);


            c.xAxis().setLabelStyle("Calibri Bold", 12);
            c.yAxis().setLabelStyle("Calibri Bold", 12);

            // Add a multi-bar layer with 3 data sets
            BarLayer layer = c.addBarLayer2(Chart.Side);
            ArrayMath am0 = new ArrayMath(data0);
            ArrayMath am1 = new ArrayMath(data1);
            ArrayMath am2 = new ArrayMath(data2);

            c.yAxis().setLinearScale(0, am2.max());


            d0 = am0.mul(percentage / 100.0).result();
            d1 = am1.mul(percentage / 100.0).result();
            d2 = am2.mul(percentage / 100.0).result();

            layer.addDataSet(d0, 0xff8080, "1 Color");
            layer.addDataSet(d1, 0x008800, "2 Color");
            layer.addDataSet(d2, 0x8080ff, "Total");
            // Output the chart
            viewer.Chart = c;

            //include tool tip for the chart
            viewer.ImageMap = c.getHTMLImageMap("clickable", "",
                "title='Day:{xLabel} - {value} prs'");
        }

        private void LoadDataToChart(WinChartViewer viewer, DataTable errorData, int per)
        {
            Chart.setLicenseCode("DEVP-2LSU-B4LX-YCTY-2DF2-77EE");
            this.chartWidth = this.Width;
            plottWidth = chartWidth - 80;
            double[] data = null;
            int[] color = null;
            string[] labels = null;
            GetDataForChart(errorData, ref labels, ref data, ref color);

            XYChart c = new XYChart(chartWidth, chartHeight);

            c.setBackground(0xFFFFFF);


            c.setPlotArea(40, 80, plottWidth, plotHeight, 0xf8f8f8, 0xffffff);

            ArrayMath am = new ArrayMath(data);
            viewer.BorderStyle = BorderStyle.None;

            c.yAxis().setLinearScale(0, am.max());
            BarLayer layer = c.addBarLayer3(am.mul(percentage / 100.0).result());
           


            layer.set3D(20, 10);

            layer.setAggregateLabelStyle("Arial Bold", 14, layer.yZoneColor(0,
                0xcc3300, 0x3333ff));

            c.xAxis().setLabels(labels);
            c.xAxis().setLabelStyle("Calibri Bold", 12);
            c.yAxis().setLabelStyle("Calibri Bold", 12);

            viewer.Chart = c;
            viewer.ImageMap = c.getHTMLImageMap("clickable", "",
                "title='{xLabel}: {value}'");
        }

        public void createChartWeekly(WinChartViewer viewer, DataTable errorData, int per)
        {
            try
            {
                Chart.setLicenseCode("DEVP-2LSU-B4LX-YCTY-2DF2-77EE");


                double[] data = null;
                int[] color = null;
                string[] labels = null;
                //  this.chartWidth = this.Width;
                //plottWidth = 900;

                GetDataForChart(errorData, ref labels, ref data, ref color);

                PieChart c = new PieChart(viewer.Width, viewer.Height);
                c.setBorder(10);

                c.addTitle(" BY TYPE", "Calibri Bold", 30
                    ).setBackground(Chart.metalColor(0xff9999));


                c.setPieSize(450, viewer.Height / 2, 150);

                c.set3D(40);

                c.setLabelLayout(Chart.SideLayout);


                ChartDirector.TextBox t = c.setLabelStyle("Arial Bold", 10, Chart.CColor(Color.Blue));
                t.setBackground(Chart.SameAsMainColor, Chart.Transparent,
                    Chart.glassEffect());
                t.setText("{label} ({value})");

                t.setRoundedCorners(4);

                c.setLineColor(Chart.SameAsMainColor);

                c.setStartAngle(15);

                c.setData(data, labels);

                viewer.Chart = c;

                viewer.ImageMap = c.getHTMLImageMap("clickable", "",
                    "title='{label}'");
            }
            catch (Exception)
            {

            }

        }

        private void GetDataForChart(DataTable source, ref string[] lablles, ref double[] values, ref int[] colors)
        {
            try
            {
                lablles = new string[source.Rows.Count];
                values = new double[source.Rows.Count];
                colors = new int[source.Rows.Count];
                for (int i = 0; i < source.Rows.Count; i++)
                {
                        lablles[i] = lablles[i] = source.Rows[i]["ERR_NAME"].ToString() + '/' + source.Rows[i]["ERR_NAME_EN"].ToString();
                   
                    values[i] = Convert.ToDouble(source.Rows[i]["CNT"].ToString());
                    colors[i] = masterColor;
                }
            }
            catch (Exception)
            {
            }

        }

        private void createChartModel(WinChartViewer viewer, DataTable errorData, int per)
        {
            try
            {
                Chart.setLicenseCode("DEVP-2LSU-B4LX-YCTY-2DF2-77EE");
                this.chartWidth = this.Width;
                //  plottWidth = chartWidth - 80;
                double[] data = null;
                //int[] color = null;
                string[] labels = null;
                GetDataFChartModel(errorData, ref labels, ref data);

                XYChart c = new XYChart(viewer.Width, viewer.Height);
                c.setBorder(10);
                //c.setBackground(0xFFFFFF);


                c.setPlotArea(70, 90, viewer.Width - 100, viewer.Height - 270, Chart.Transparent,
                    -1, Chart.Transparent, c.dashLineColor(0xffffff, Chart.Transparent));
                ArrayMath am = new ArrayMath(data);
                viewer.BorderStyle = BorderStyle.None;


                c.yAxis().setLinearScale(0, am.max() + 10);
                BarLayer layer = c.addBarLayer(am.mul(percentage / 100.0).result(), 0x30c2f7);

                c.addTitle(" BY MODEL", "Calibri Bold", 30).setBackground(Chart.metalColor(0xff9999));

                //title.setMargin2(10, 10, 12, 12);
                layer.setBarShape(Chart.CircleShape, 0);


                layer.set3D(20, 10);

                layer.setAggregateLabelStyle("Arial Bold", 14, layer.yZoneColor(0,
                    0xcc3300, 0x3333ff));

                c.xAxis().setLabels(labels);
                c.xAxis().setLabelStyle("Arial Bold", 9).setFontAngle(45);
                c.yAxis().setLabelStyle("Arial Bold", 12);

                viewer.Chart = c;
                //viewer.ImageMap = c.getHTMLImageMap("clickable", "",
                //    "title='{xLabel}: {value}'");
            }
            catch (Exception)
            {

            }
        }

        private void GetDataFChartModel(DataTable source, ref string[] lablles, ref double[] values)
        {
            try
            {
                lablles = new string[source.Rows.Count];
                values = new double[source.Rows.Count];
                for (int i = 0; i < source.Rows.Count; i++)
                {
                    lablles[i] = source.Rows[i]["MODEL_NM"].ToString();
                    values[i] = Convert.ToDouble(source.Rows[i]["CNT"].ToString());
                }
            }
            catch (Exception)
            {
            }

        }

       /*
        

        
        }

        private void createChartStyle(WinChartViewer viewer, DataTable errorData, int per)
        {
            try
            {
                Chart.setLicenseCode("DEVP-2LSU-B4LX-YCTY-2DF2-77EE");
                this.chartWidth = this.Width;
                //  plottWidth = chartWidth - 80;
                double[] data = null;
                //int[] color = null;
                string[] labels = null;
                GetDataFChartStyle(errorData, ref labels, ref data);

                XYChart c = new XYChart(viewer.Width, viewer.Height, Chart.brushedSilverColor(), 0, 2);
                //c.setBackground(0xFFFFFF);


                c.setPlotArea(70, 80, viewer.Width - 100, viewer.Height - 150, Chart.Transparent,
                    -1, Chart.Transparent, c.dashLineColor(0xffffff, Chart.Transparent));
                ArrayMath am = new ArrayMath(data);
                viewer.BorderStyle = BorderStyle.None;


                c.yAxis().setLinearScale(0, am.max() + 10);
                BarLayer layer = c.addBarLayer(am.mul(percentage / 100.0).result(), 0x9f72ff);

                c.addTitle(" BY STYLE", "Calibri Bold", 30).setBackground(Chart.metalColor(0xff9999));

                //title.setMargin2(10, 10, 12, 12);
                //  layer.setBarShape(Chart., 0);


                layer.set3D(20, 10);

                layer.setAggregateLabelStyle("Arial Bold", 14, layer.yZoneColor(0,
                    0xcc3300, 0x3333ff));

                c.xAxis().setLabels(labels);
                c.xAxis().setLabelStyle("Arial Bold", 9).setFontAngle(10);
                c.yAxis().setLabelStyle("Arial Bold", 12);

                viewer.Chart = c;
                //viewer.ImageMap = c.getHTMLImageMap("clickable", "",
                //    "title='{xLabel}: {value}'");
            }
            catch (Exception)
            {

            }
            
        }

        

        

        private void GetDataFChartStyle(DataTable source, ref string[] lablles, ref double[] values)
        {
            try
            {
                lablles = new string[source.Rows.Count];
                values = new double[source.Rows.Count];
                for (int i = 0; i < source.Rows.Count; i++)
                {
                    lablles[i] = source.Rows[i]["STYLE_NM"].ToString();
                    values[i] = Convert.ToDouble(source.Rows[i]["CNT"].ToString());
                }
            }
            catch (Exception)
            {
            }
            
        }
        */
        #endregion Chart

        private void LoadDataToGrid(DataTable source)
        {
            try
            {
                double col_size;
                numCols = source.Rows.Count;
                col_size = Math.Round(Convert.ToDouble(source.Rows[0]["COL_WIDTH"].ToString()) / numCols - 1, 2);
                axfpHeaderData.MaxCols = 0;
                axfpHeaderData.MaxRows = 3;
                //axfpHeaderData.RowsFrozen = 3;
                axfpHeaderData.MaxCols = numCols;
                
                for (int i = 1; i <= numCols; i++)
                {
                    axfpHeaderData.set_ColWidth(i, col_size);
                }               
                for (int i = 0; i < source.Rows.Count; i++)
                {
                    axfpHeaderData.SetText(i + 1, 1, source.Rows[i][1].ToString().Replace(" ", "\n"));
                    axfpHeaderData.SetText(i + 1, 2, source.Rows[i]["ERR_NAME_EN"].ToString().Replace(" ", "\n"));
                    axfpHeaderData.SetText(i + 1, 3, source.Rows[i][2].ToString());
                }
            }
            catch (Exception)
            {
                
            }

            


        }

        private void LoadDataToGridModel(DataTable source)
        {
            try
            {
                double col_size;
                numCols = source.Rows.Count;
                col_size = Math.Round(Convert.ToDouble(source.Rows[0]["COL_WIDTH"].ToString()) / numCols - 1, 2);
                axGridModel.MaxCols = 0;
                axGridModel.MaxRows = 2;
                axGridModel.MaxCols = numCols;
                
                
                for (int i = 1; i <= numCols; i++)
                {
                    axGridModel.set_ColWidth(i, col_size);
                }
                
                for (int i = 0; i < numCols; i++)
                {
                    // axGridModel.SetText(i + 1, 1, source.Rows[i][0].ToString().Replace(" ", "\n") + "\n\n" + source.Rows[i]["MODEL_NM"].ToString().Replace(" ", "\n"));
                    axGridModel.SetText(i + 1, 1, source.Rows[i][0].ToString().Replace(" ", "\n"));
                    axGridModel.SetText(i + 1, 2, source.Rows[i][1].ToString());
                }
                axGridModel.MaxCols = numCols;
            }
            catch (Exception)
            {

            }
        }

        private void load_frm()
        {
            try
            {

                _dt_model = LOAD_BY_MODEL(viewMode);
                
               // axfpHeaderData.Hide();
                //axGridModel.Hide();

                dt_top = LOAD_BY_TYPE(viewMode);
                LoadDataToGrid(dt_top);
                LoadDataToGridModel(_dt_model);
                percentage = 0;

                createChartWeekly(this.chartErrorCounter, dt_top, percentage += 5);
                // IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.chartErrorCounter.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("4"));
                this.chartErrorCounter.Show();
                timer2.Start();
                axfpHeaderData.Show();
                axGridModel.Show();
             
            }
            catch
            {
            }
        }
      
        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        private void load_defective()
        {
            dt_top = LOAD_BY_TYPE(viewMode);
            //LoadDataToGrid(dt_top);
           // LoadDataToGridModel(_dt_model);
            percentage = 0;

            this.chartErrorCounter.Hide();
            createChartWeekly(this.chartErrorCounter, dt_top, percentage += 5);
            //Smart_FTY.ClassLib.WinAPI.AnimateWindow(this.chartErrorCounter.Handle, 500, Smart_FTY.ClassLib.WinAPI.getSlidType("4"));
            this.chartErrorCounter.Show();

            timer2.Start();
        }

        #endregion Function

        #region DB
        private DataTable LOAD_BY_TYPE(string argMode)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_B1_DIGITAL.MOLD_REPAIR_BY_TYPE";
                //ARGMODE
                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;
                MyOraDB.Parameter_Name[0] = "ARG_WH_CD";
                MyOraDB.Parameter_Type[0] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Values[0] = argMode;
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
                MyOraDB.Parameter_Type[1] = (char)OracleType.Cursor;
                MyOraDB.Parameter_Values[1] = "";
                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();
                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }

        private DataTable LOAD_BY_MODEL(string argMode)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_B1_DIGITAL.MOLD_REPAIR_BY_MODEL";
                //ARGMODE
                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;
                MyOraDB.Parameter_Name[0] = "ARG_WH_CD";
                MyOraDB.Parameter_Type[0] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Values[0] = argMode;
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
                MyOraDB.Parameter_Type[1] = (char)OracleType.Cursor;
                MyOraDB.Parameter_Values[1] = "";
                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();
                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }
        
        #endregion DB

        #region Event
        private void Frm_Mold_Show_TV_Load(object sender, EventArgs e)
        {

            //addUC();
            try
            {
                axfpHeaderData.Width = 896;
                GoFullscreen(true);
                _frm = 3;
            }
            catch
            {
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {

                createChartModel(chartModel, _dt_model, percentage += 5);
               
                if (percentage >= 100)
                    timer2.Stop();
            }
            catch (Exception)
            {

                //   throw;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + "\n\r" + string.Format(DateTime.Now.ToString("HH:mm:ss"));
                _time_change++;
                if (_time_change >= 40)
                {
                    _time_change = 0;
                    load_frm();
                }
            }
            catch
            {
            }
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FORM_MOLD_REPAIR_WEEKLY_VisibleChanged(object sender, EventArgs e)
        {
            lblTitle2.Text = "PU Mold Overhaul by Week (" + DateTime.Now.AddDays(-7).ToString("MMM-dd") + " ~ " + DateTime.Now.ToString("MMM-dd") + ")";
            if (this.Visible)
            {
               // lblPhylon_Click(null, null);
                //lblTitle.Text = "CMP Mold Overhaul by Week"; //+ DateTime.Now.AddDays(-7).ToString("MMM-dd") + " ~ " +  DateTime.Now.ToString("MMM-DD") + ")";
                _time_change = 39;
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
            }
        }

        private void lblCMP_Click(object sender, EventArgs e)
        {
            viewMode = "40";
           // lblTitle.Text = "CMP Mold Overhaul by Week ";// +DateTime.Now.AddDays(-7).ToString("mmm-dd") + " ~ " + DateTime.Now.ToString("MMM-DD") + ")";
            _time_change = 0;
            load_frm();
        }

        private void lblPhylon_Click(object sender, EventArgs e)
        {
            viewMode = "70";
          //  lblTitle.Text = "Phylon Mold Overhaul by Week "; //+ DateTime.Now.AddDays(-7).ToString("MMM-DD") + " ~ " + DateTime.Now.ToString("MMM-DD") + ")";
            _time_change = 0;
            load_frm();
        }

        #endregion Event

        private void lblDate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            Smart_FTY.ComVar._frm_home.Show();
            this.Hide();
        }













    }
}
