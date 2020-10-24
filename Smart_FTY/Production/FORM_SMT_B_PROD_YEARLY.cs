using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using DevExpress.XtraCharts;
using System.Globalization;

namespace Smart_FTY
{
    public partial class FORM_SMT_B_PROD_YEARLY : SampleFrm1
    {
        public FORM_SMT_B_PROD_YEARLY()
        {
            InitializeComponent();
           // formName = "FORM_SMT_B_PROD_YEARLY";
            this.Name = "FORM_SMT_B_PROD_YEARLY";
            this.Text = "FORM_SMT_B_PROD_YEARLY";
        }

        public static string _sProcess = "OSR";
        public int iCount = 0;

        private void GoFullscreen()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

        }
      
       
        public DataTable SMT_B_PRODUCTION_YEARLY(string V_P_YEAR, string V_P_PROCESS)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_B_PRODUCTION.SMT_B_PRODUCTION_YEARLY";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "V_P_YEAR";
                MyOraDB.Parameter_Name[1] = "V_P_PROCESS";
                MyOraDB.Parameter_Name[2] = "CV_1";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;             
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = V_P_YEAR;
                MyOraDB.Parameter_Values[1] = V_P_PROCESS;          
                MyOraDB.Parameter_Values[2] = "";


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
        private void Search_Data()
        {
            string sDate = DateTime.Now.ToString("yyyy");
            DataTable dt = SMT_B_PRODUCTION_YEARLY(sDate, _sProcess);
            if (dt != null && dt.Rows.Count > 0)
            {
                CreateChart(dt, chartControl);
                Display_Grid(axfpSpread, dt);
            }
        }

        private void FORM_SMT_B_PROD_YEARLY_Load(object sender, EventArgs e)
        {
            GoFullscreen();
            lblRubber_Click(null, null);
            //Search_Data();
            tmr_Load.Interval = 1000;
            tmr_Load.Start();
        }
        private void CreateChart(DataTable _dt, DevExpress.XtraCharts.ChartControl _chartControl)
        {
            try
            {
                ((XYDiagram)_chartControl.Diagram).EnableAxisXZooming = true;
                //((XYDiagram)barChartControl.Diagram).AxisX.NumericScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Automatic;
                ((XYDiagram)_chartControl.Diagram).AxisX.VisualRange.Auto = false;
                ((XYDiagram)_chartControl.Diagram).AxisX.VisualRange.AutoSideMargins = false;
                ((XYDiagram)_chartControl.Diagram).AxisX.VisualRange.SideMarginsValue = 2;
                ((XYDiagram)_chartControl.Diagram).AxisX.Label.Angle = 0;
                ((XYDiagram)_chartControl.Diagram).AxisX.Label.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
                ((XYDiagram)_chartControl.Diagram).AxisX.Title.Text = "Month";
                ((XYDiagram)_chartControl.Diagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                ((XYDiagram)_chartControl.Diagram).AxisX.Title.Font = new Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
                ((XYDiagram)_chartControl.Diagram).AxisX.Title.TextColor = Color.DarkOrange;

                ((XYDiagram)_chartControl.Diagram).AxisY.Label.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
                ((XYDiagram)_chartControl.Diagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                ((XYDiagram)_chartControl.Diagram).AxisY.Title.Text = "Qty ( Kilogram )";
                ((XYDiagram)_chartControl.Diagram).AxisY.Label.TextPattern = "{V:###,###}";
                ((XYDiagram)_chartControl.Diagram).AxisY.Title.Font = new Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
                ((XYDiagram)_chartControl.Diagram).AxisY.Title.TextColor = Color.DarkOrange;
                

                DevExpress.XtraCharts.LineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
                DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
                DevExpress.XtraCharts.XYSeriesUnwindAnimation xySeriesSlideAnimation1 = new DevExpress.XtraCharts.XYSeriesUnwindAnimation();

                _chartControl.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;

                _chartControl.Series.Clear();
                _chartControl.Titles.Clear();
              

                Series series1 = new Series("Production", ViewType.Bar);
                Series series2 = new Series("Plan", ViewType.Line);

                if (_dt != null && _dt.Rows.Count > 0)
                {                   
                 
                    for (int iRow = 0; iRow < _dt.Rows.Count; iRow++)
                    {
                        if (_dt.Rows[iRow]["DIV"].ToString() == "1")
                        {
                            for (int iCol = 1; iCol < _dt.Columns.Count; iCol++)
                            {
                                if (_dt.Rows[iRow][iCol].ToString() != "")
                                {
                                    series2.Points.Add(new SeriesPoint(DateTime.ParseExact(_dt.Columns[iCol].Caption.ToString().Substring(1, 6), "yyyyMM", CultureInfo.InvariantCulture).ToString("MMM", CultureInfo.InvariantCulture), Convert.ToInt32(_dt.Rows[iRow][iCol].ToString())));
                                }
                                else
                                {
                                    series2.Points.Add(new SeriesPoint(DateTime.ParseExact(_dt.Columns[iCol].Caption.ToString().Substring(1, 6), "yyyyMM", CultureInfo.InvariantCulture).ToString("MMM", CultureInfo.InvariantCulture), 0));
                                }
                            }
                        }
                        if (_dt.Rows[iRow]["DIV"].ToString() == "2")
                        {
                            for (int iCol = 1; iCol < _dt.Columns.Count; iCol++)
                            {
                                if (_dt.Rows[iRow][iCol].ToString() != "")
                                {
                                    series1.Points.Add(new SeriesPoint(DateTime.ParseExact(_dt.Columns[iCol].Caption.ToString().Substring(1, 6), "yyyyMM", CultureInfo.InvariantCulture).ToString("MMM", CultureInfo.InvariantCulture), Convert.ToInt32(_dt.Rows[iRow][iCol].ToString())));
                                }
                                else
                                {
                                    series1.Points.Add(new SeriesPoint(DateTime.ParseExact(_dt.Columns[iCol].Caption.ToString().Substring(1, 6), "yyyyMM", CultureInfo.InvariantCulture).ToString("MMM", CultureInfo.InvariantCulture), 0));
                                }
                            }
                        }                        

                    }

                }

                
                
                sideBySideBarSeriesView1.ColorEach = false;
                sideBySideBarSeriesView1.Shadow.Visible = false;
                series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                series1.ArgumentScaleType = ScaleType.Qualitative;
                series1.Label.TextPattern = "{V:#,###,###}";              
                series1.View = sideBySideBarSeriesView1;


                splineSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                series1.Label.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                splineSeriesView1.LineStyle.Thickness = 2;
                splineSeriesView1.SeriesAnimation = xySeriesSlideAnimation1;
                splineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                splineSeriesView1.LineMarkerOptions.Size = 15;
                splineSeriesView1.LineMarkerOptions.Color = Color.DodgerBlue;

                series2.Label.BackColor = Color.White;
                series2.Label.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                series2.Label.TextPattern = "{V:#,###,###}";
                series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                series2.ArgumentScaleType = ScaleType.Qualitative;
                series2.View = splineSeriesView1;

                // Access the type-specific options of the diagram.
                _chartControl.Series.AddRange(new Series[] { series1, series2 });
       

                // Add a title to the chart (if necessary).
                //_chartControl.Titles.Add(new ChartTitle());
               // _chartControl.Titles[0].Text = "Production";


              

            }
            catch (Exception EX)
            {
            }
        }
        private void Display_Grid(AxFPUSpreadADO.AxfpSpread _axfpSpread , DataTable _dt)
        {
            _axfpSpread.AddCellSpan(2, 1, _dt.Columns.Count-1, 1);
            _axfpSpread.SetText(2, 1, _dt.Columns[1].Caption.ToString().Substring(1,4));
            for (int iRow = 0; iRow < _dt.Rows.Count; iRow++)
            {
                int iNumber = 0;
                double dTotal = 0;
                double d = Math.Round((232.125 -22-18.75) / (_dt.Columns.Count-1),2);
                for (int iCol = 1; iCol < _dt.Columns.Count; iCol++)
                {
                    //_axfpSpread.set_ColWidth(iCol + 1, d);
                    //if (iRow == 0)
                    //{
                    //    _axfpSpread.SetText(iCol+1,iRow+2,_dt.Columns[iCol].Caption.ToString().Substring(7,2));
                    //}
                    if (_dt.Rows[iRow][iCol].ToString() != "0")
                    {
                        _axfpSpread.SetText(iCol + 1, iRow + 3, _dt.Rows[iRow][iCol].ToString());
                    }
                    if (_dt.Rows[iRow][iCol].ToString() != "" && _dt.Rows[iRow][iCol].ToString() != "0")
                    {
                        dTotal += Convert.ToDouble( _dt.Rows[iRow][iCol].ToString());
                        iNumber++;
                    }
                }
                if (iRow == 0)
                {
                    double dd = 232.125 -22- (_dt.Columns.Count-1)*(_axfpSpread.get_ColWidth(_dt.Columns.Count));
                    _axfpSpread.AddCellSpan(_dt.Columns.Count + 1, iRow + 1, 1, 2);
                    _axfpSpread.SetText(_dt.Columns.Count + 1, iRow + 1, "Average");
                    _axfpSpread.Row = iRow + 1;
                    _axfpSpread.Col = _dt.Columns.Count + 1;
                    _axfpSpread.BackColor = Color.Orange;
                    //_axfpSpread.set_ColWidth(_dt.Columns.Count + 1, dd);
                }
                if (iNumber != 0)
                {
                    _axfpSpread.SetText(_dt.Columns.Count + 1, iRow + 3, Math.Round(dTotal / iNumber, 1));
                }
                else
                {
                    _axfpSpread.SetText(_dt.Columns.Count + 1, iRow + 3, 0);
                }

                for (int iCol = _dt.Columns.Count+2; iCol <= _axfpSpread.MaxCols; iCol++)
                {
                    _axfpSpread.set_ColWidth(iCol, 0);
                }
            }
           
            
        }

        private void tmr_Load_Tick(object sender, EventArgs e)
        {
            iCount++;
            if (iCount >= 60)
            {
                Search_Data();
                iCount = 0;
            }
        }

        private void lblRubber_Click(object sender, EventArgs e)
        {
            pnRubber.GradientEndColor = Color.White;//Color.FromArgb(255, 128, 128);
            pnEVA.GradientEndColor = Color.Gray;
            lblTitle.Text = "Rubber Production Status by Year";
            _sProcess = "OSR";
            Search_Data();
            iCount = 0;
        }

        private void lblEVA_Click(object sender, EventArgs e)
        {
            pnEVA.GradientEndColor = Color.White; //Color.FromArgb(255, 128, 128);
            pnRubber.GradientEndColor = Color.Gray;
            lblTitle.Text = "EVA Production Status by Year";
            _sProcess = "EVA";
            Search_Data();
            iCount = 0;
        }


    }
}
