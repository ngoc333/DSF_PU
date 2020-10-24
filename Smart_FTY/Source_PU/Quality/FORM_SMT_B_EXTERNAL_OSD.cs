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
    public partial class FORM_SMT_B_EXTERNAL_OSD: SampleFrm2
    {
        public FORM_SMT_B_EXTERNAL_OSD()
        {
            InitializeComponent();
           // formName = "FORM_SMT_B_EXTERNAL_OSD";
            lblTitle.Text = "Phylon External OS&&D";
            this.Name = "FORM_SMT_B_EXTERNAL_OSD";
            this.Text = "FORM_SMT_B_EXTERNAL_OSD";
        }

        public static string _sProcess = "CMP";
        public int iCount = 0;


        public DataTable SMT_B_PHP_OSD_EXT_MONTHLY(string V_P_MONTH, string V_P_PROCESS)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_B_PRODUCTION.SMT_B_PHP_OSD_EXT_MONTHLY";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "V_P_MONTH";
                MyOraDB.Parameter_Name[1] = "V_P_PROCESS";
                MyOraDB.Parameter_Name[2] = "CV_1";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;             
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = V_P_MONTH;
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

        public DataTable SMT_B_PHP_OSD_EXT_PARETO(string V_P_MONTH, string V_P_FACTORY)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_B_PRODUCTION.SMT_B_PHP_OSD_EXT_PARETO";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "V_P_MONTH";
                MyOraDB.Parameter_Name[1] = "V_P_FACTORY";
                MyOraDB.Parameter_Name[2] = "CV_1";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = V_P_MONTH;
                MyOraDB.Parameter_Values[1] = V_P_FACTORY;
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
            
            string sDate = DateTime.Now.ToString("yyyyMM");

            DataTable dt = SMT_B_PHP_OSD_EXT_MONTHLY(sDate, _sProcess);
            if (dt != null && dt.Rows.Count > 0)
            {
                CreateChart(dt, chartControl);
                Display_Grid(axfpSpread, dt);
            }

            dt = null;
            dt = SMT_B_PHP_OSD_EXT_PARETO(sDate, "FTY01");
            if (dt != null && dt.Rows.Count > 0)
            {
                string sTitle = "1st (" + DateTime.ParseExact(dt.Rows[0]["DATE_FROM"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MMM/dd") + " - " + DateTime.ParseExact(dt.Rows[0]["DATE_TO"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MMM/dd") + " )";
                BindingPareto(chartControl1, dt, "MODEL_NAME", "QTY", "PERC", sTitle, "OS&D", "MODEL");
            }

            dt = null;
            dt = SMT_B_PHP_OSD_EXT_PARETO(sDate, "FTY02");
            if (dt != null && dt.Rows.Count > 0)
            {
                string sTitle = "2nd (" + DateTime.ParseExact(dt.Rows[0]["DATE_FROM"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MMM/dd") + " - " + DateTime.ParseExact(dt.Rows[0]["DATE_TO"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MMM/dd") + " )";
                BindingPareto(chartControl2, dt, "MODEL_NAME", "QTY", "PERC", sTitle, "OS&D", "MODEL");
            }
                    

            dt = null;
            dt = SMT_B_PHP_OSD_EXT_PARETO(sDate, "FTY03");
            if (dt != null && dt.Rows.Count > 0)
            {
                string sTitle = "3rd (" + DateTime.ParseExact(dt.Rows[0]["DATE_FROM"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MMM/dd") + " - " + DateTime.ParseExact(dt.Rows[0]["DATE_TO"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MMM/dd") + " )";
                BindingPareto(chartControl3, dt, "MODEL_NAME", "QTY", "PERC", sTitle, "OS&D", "MODEL");
            }

            dt = null;
            dt = SMT_B_PHP_OSD_EXT_PARETO(sDate, "FTY04");
            if (dt != null && dt.Rows.Count > 0)
            {
                string sTitle = "4th (" + DateTime.ParseExact(dt.Rows[0]["DATE_FROM"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MMM/dd") + " - " + DateTime.ParseExact(dt.Rows[0]["DATE_TO"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MMM/dd") + " )";
                BindingPareto(chartControl4, dt, "MODEL_NAME", "QTY", "PERC", sTitle, "OS&D", "MODEL");
            }

        }

        private void FORM_SMT_B_PROD_MONTHLY_Load(object sender, EventArgs e)
        {
            //lblCMP_Click(null, null);
            //Search_Data();
            tmr_Load.Interval = 1000;
           // tmr_Load.Start();
        }
        private void ClearGrid(AxFPUSpreadADO.AxfpSpread _axfpSpread)
        {
            for (int iRow = 1; iRow < _axfpSpread.MaxRows; iRow++)
            {
                _axfpSpread.AddCellSpan(1, _axfpSpread.MaxCols - 1, _axfpSpread.MaxCols - 1, 1);
            }
            for (int iCol = 1; iCol < _axfpSpread.MaxCols; iCol++)
            {
                _axfpSpread.AddCellSpan(iCol, _axfpSpread.MaxRows - 1, 1, _axfpSpread.MaxRows - 1);
            }
        }

        private void BindingPareto(DevExpress.XtraCharts.ChartControl charControl, DataTable dt, string iColPoint, string iColValue, string iColPercent, string _ChartTitle, string _sYTitle, string _sXTitle)
        {
            try
            {

                ((XYDiagram)charControl.Diagram).AxisX.NumericScaleOptions.AutoGrid = true;
                ((XYDiagram)charControl.Diagram).AxisX.Title.TextColor = Color.DarkOrange;
                ((XYDiagram)charControl.Diagram).AxisX.Title.Text = _sXTitle;
                ((XYDiagram)charControl.Diagram).AxisY.Title.TextColor = Color.DarkOrange;
                ((XYDiagram)charControl.Diagram).AxisY.Title.Text = _sYTitle;
                ((XYDiagram)charControl.Diagram).AxisX.Title.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ((XYDiagram)charControl.Diagram).AxisX.Label.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ((XYDiagram)charControl.Diagram).AxisY.Title.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ((XYDiagram)charControl.Diagram).AxisY.Label.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                ((XYDiagram)charControl.Diagram).AxisX.Label.Angle = 50;
                

                DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
                DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
                DevExpress.XtraCharts.XYSeriesUnwindAnimation xySeriesSlideAnimation1 = new DevExpress.XtraCharts.XYSeriesUnwindAnimation();


                sideBySideBarSeriesView1.ColorEach = true;

                charControl.Series.Clear();
                charControl.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;

                //charControl.SeriesSorting = SortingMode.Descending;


                Series series1 = new Series(_ChartTitle, ViewType.Bar);
                Series series2 = new Series("%", ViewType.Spline);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    series1.Points.Add(new SeriesPoint(dt.Rows[i][iColPoint].ToString(), dt.Rows[i][iColValue].ToString()));
                    series2.Points.Add(new SeriesPoint(dt.Rows[i][iColPoint].ToString(), dt.Rows[i][iColPercent].ToString()));


                }


                series1.ArgumentScaleType = ScaleType.Qualitative;
                series2.ArgumentScaleType = ScaleType.Qualitative;
                series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                sideBySideBarSeriesView1.ColorEach = false;
                series1.View = sideBySideBarSeriesView1;
                series1.Label.Font = new System.Drawing.Font("Calibri", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                splineSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                splineSeriesView1.LineStyle.Thickness = 2;
                splineSeriesView1.SeriesAnimation = xySeriesSlideAnimation1;

                splineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                splineSeriesView1.LineMarkerOptions.Size = 15;
                splineSeriesView1.LineMarkerOptions.Color = Color.DodgerBlue;

                series2.Label.BackColor = Color.White;
                series2.Label.Font = new System.Drawing.Font("Calibri", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                series2.Label.TextPattern = "{V:###.##}%";
                series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                series2.View = splineSeriesView1;


                charControl.Series.AddRange(new Series[] { series1, series2 });


                //((XYDiagram)charControl.Diagram).AxisY.VisualRange.SideMarginsValue = 1;

                charControl.Titles[0].Text = _ChartTitle;
                charControl.Titles[0].Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                SecondaryAxisY myAxisY = new SecondaryAxisY("my Y-Axis");
                ((XYDiagram)charControl.Diagram).SecondaryAxesY.Clear();
                ((XYDiagram)charControl.Diagram).SecondaryAxesY.Add(myAxisY);
                myAxisY.VisualRange.SetMinMaxValues(0, 95);
                myAxisY.Title.Text = "%";
                myAxisY.Tickmarks.MinorVisible = false;

                //((XYDiagram)barChartControl.Diagram).AxisY.WholeRange.SetMinMaxValues(90, 100);
                myAxisY.Label.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                myAxisY.Title.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                myAxisY.Label.TextPattern = "{V:###.##}";
                myAxisY.Title.TextColor = Color.DarkOrange;
                myAxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;

                ((SplineSeriesView)series2.View).AxisY = myAxisY;
                ((XYDiagram)charControl.Diagram).AxisX.QualitativeScaleOptions.AutoGrid = false;
            }
            catch (Exception ex)
            {
            }


        }
        private void CreateChart(DataTable _dt, DevExpress.XtraCharts.ChartControl _chartControl)
        {
            try
            {
                ((XYDiagram)_chartControl.Diagram).EnableAxisXZooming = true;
               
                ((XYDiagram)_chartControl.Diagram).AxisX.VisualRange.Auto = false;
                ((XYDiagram)_chartControl.Diagram).AxisX.VisualRange.AutoSideMargins = false;
                ((XYDiagram)_chartControl.Diagram).AxisX.VisualRange.SideMarginsValue = 1;
                ((XYDiagram)_chartControl.Diagram).AxisX.Label.Angle = 0;
                ((XYDiagram)_chartControl.Diagram).AxisX.Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
                ((XYDiagram)_chartControl.Diagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                ((XYDiagram)_chartControl.Diagram).AxisX.Title.Text = "Date";
                ((XYDiagram)_chartControl.Diagram).AxisX.Title.Font = new Font("Calibri", 14F, System.Drawing.FontStyle.Bold);

                ((XYDiagram)_chartControl.Diagram).AxisY.Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
                ((XYDiagram)_chartControl.Diagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                ((XYDiagram)_chartControl.Diagram).AxisY.Title.Text = " OS&D (Prs)";
                ((XYDiagram)_chartControl.Diagram).AxisY.Label.TextPattern = "{V:###,###}";
                ((XYDiagram)_chartControl.Diagram).AxisY.Title.Font = new Font("Calibri", 14F, System.Drawing.FontStyle.Bold);

                ((XYDiagram)_chartControl.Diagram).AxisY.Title.TextColor = Color.DarkOrange;
                ((XYDiagram)_chartControl.Diagram).AxisX.Title.TextColor = Color.DarkOrange;
                          
                DevExpress.XtraCharts.XYSeriesUnwindAnimation xySeriesSlideAnimation1 = new DevExpress.XtraCharts.XYSeriesUnwindAnimation();

                _chartControl.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;

                _chartControl.Series.Clear();
                _chartControl.Titles.Clear(); 

                Legend lgBox = new Legend();
                Series[] arrSeries= new Series[_dt.Rows.Count-1];
                lgBox.Visibility = DevExpress.Utils.DefaultBoolean.True;
                lgBox.Font = new Font("Calibri", 16F, System.Drawing.FontStyle.Bold);

                if (_dt != null && _dt.Rows.Count > 0)
                {                   
                 
                    for (int iRow = 0; iRow < _dt.Rows.Count; iRow++)
                    {                        
                        if (_dt.Rows[iRow]["DIV"].ToString() == "1")
                        {
                            arrSeries[iRow] = new Series(_dt.Rows[iRow]["LINE_CD"].ToString(), ViewType.Spline);
                            for (int iCol = 2; iCol < _dt.Columns.Count; iCol++)
                            {

                                if (_dt.Rows[iRow][iCol].ToString() != "" && _dt.Rows[iRow][iCol] != null)
                                {
                                    arrSeries[iRow].Points.Add(new SeriesPoint(DateTime.ParseExact(_dt.Columns[iCol].Caption.ToString().Substring(1, 8), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MMM\ndd"), Convert.ToDouble(_dt.Rows[iRow][iCol].ToString())));
                                }
                                else
                                {
                                    arrSeries[iRow].Points.Add(new SeriesPoint(DateTime.ParseExact(_dt.Columns[iCol].Caption.ToString().Substring(1, 8), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MMM\ndd"), 0));
                                }
                            }
                        }
                                              

                    }

                }


       
                for (int i = 0; i < arrSeries.Length; i++)
                {

                    DevExpress.XtraCharts.SplineSeriesView splineSeriesView = new DevExpress.XtraCharts.SplineSeriesView();

                    splineSeriesView.LineStyle.Thickness = 2;
                    splineSeriesView.SeriesAnimation = xySeriesSlideAnimation1;
                    splineSeriesView.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                    splineSeriesView.LineMarkerOptions.Size = 15;
                    splineSeriesView.LineMarkerOptions.Color = Color.DodgerBlue;
                    splineSeriesView.Color = getColor(arrSeries[i].Name.ToString());                         
                    
                    arrSeries[i].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                    arrSeries[i].Label.TextPattern = "{V:###,###.#}";
                    arrSeries[i].ArgumentScaleType = ScaleType.Qualitative;
                    arrSeries[i].View = splineSeriesView;
                    
                }


                
                // Access the type-specific options of the diagram.                
                _chartControl.Series.AddRange(arrSeries);               
                _chartControl.Legends.Add(lgBox);
                ((XYDiagram)_chartControl.Diagram).AxisX.QualitativeScaleOptions.AutoGrid = false;
       

       


              

            }
            catch (Exception EX)
            {
            }
        }
        private Color getColor(string _sFactory)
        {

            if (_sFactory == "Factory 1")
                return Color.LimeGreen;
            if (_sFactory == "Factory 2")
                return Color.Black;
            if (_sFactory == "Factory 3")
                return Color.Blue;
            if (_sFactory == "Factory 4")
                return System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            return Color.White;
        }

        private void MergeRowGroupCol(AxFPUSpreadADO.AxfpSpread gridObject, int iStartCol, int iEndCol, int iRow)
        {
            
            try
            {

                string sTemp1 = "";
                string sTemp2 = "";
                int iCol = iStartCol;
                gridObject.Row = iRow;
                gridObject.Col = iStartCol;
                sTemp1 = gridObject.Value;
                for (int i = iStartCol; i <= iEndCol; i++)
                {
                    gridObject.Row = iRow;
                    gridObject.Col = i;
                    sTemp2 = gridObject.Value;
                    if (sTemp1 != sTemp2)
                    {
                        gridObject.AddCellSpan(iCol, iRow, i - iCol, 1);
                        sTemp1 = sTemp2;
                        sTemp2 = "";
                        iCol = i;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Display_Grid(AxFPUSpreadADO.AxfpSpread _axfpSpread , DataTable _dt)
        {
            //_axfpSpread.AddCellSpan(2, 1, _dt.Columns.Count-2, 1);
            //_axfpSpread.SetText(2, 1, DateTime.ParseExact(_dt.Columns[2].Caption.ToString().Substring(1, 8), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MMMM", CultureInfo.InvariantCulture));
            ClearGrid(_axfpSpread);
            for (int iRow = 0; iRow < _dt.Rows.Count; iRow++)
            {
                int iNumber = 0;
                double dTotal = 0;
                double d = Math.Round((159 -10.75-10 *2) / (_dt.Columns.Count-2),2);
                for (int iCol = 1; iCol < _dt.Columns.Count; iCol++)
                {
                    _axfpSpread.set_ColWidth(iCol + 1, d);
                    if (iRow == 0 && iCol > 1)
                    {
                        _axfpSpread.SetText(iCol, iRow + 1, DateTime.ParseExact(_dt.Columns[iCol].Caption.ToString().Substring(1, 8), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MMM", CultureInfo.InvariantCulture));
                        _axfpSpread.SetText(iCol, iRow + 2, _dt.Columns[iCol].Caption.ToString().Substring(7, 2));
                    }
                    _axfpSpread.SetText(iCol, iRow + 3, _dt.Rows[iRow][iCol].ToString());
                    if (_dt.Rows[iRow][iCol].ToString() != "" && _dt.Rows[iRow][iCol].ToString() != "0" && iCol > 1)
                    {
                        dTotal += Convert.ToDouble( _dt.Rows[iRow][iCol].ToString());
                        iNumber++;
                    }
                }
               
                if (iNumber != 0)
                {
                    _axfpSpread.SetText(_dt.Columns.Count , iRow + 3, Math.Round(dTotal / iNumber, 1));
                    _axfpSpread.SetText(_dt.Columns.Count+1, iRow + 3, Math.Round(dTotal, 1));
                }
                else
                {
                    _axfpSpread.SetText(_dt.Columns.Count , iRow + 3, 0);
                    _axfpSpread.SetText(_dt.Columns.Count+1, iRow + 3, 0);
                }

                
            }

            double dd = 159 - 10.75 - (_dt.Columns.Count - 1) * (_axfpSpread.get_ColWidth(_dt.Columns.Count - 2));
            _axfpSpread.AddCellSpan(_dt.Columns.Count, 1, 1, 2);
            _axfpSpread.SetText(_dt.Columns.Count,  1, "Avg");
            _axfpSpread.Row =  1;
            _axfpSpread.Col = _dt.Columns.Count;
            _axfpSpread.BackColor = Color.Orange;
            _axfpSpread.ForeColor = Color.White;
            _axfpSpread.set_ColWidth(_dt.Columns.Count, dd / 2);


            _axfpSpread.AddCellSpan(_dt.Columns.Count + 1, 1, 1, 2);
            _axfpSpread.SetText(_dt.Columns.Count + 1, + 1, "Total");
            _axfpSpread.Row =  1;
            _axfpSpread.Col = _dt.Columns.Count + 1;
            _axfpSpread.BackColor = Color.DodgerBlue;
            _axfpSpread.ForeColor = Color.White;
            _axfpSpread.set_ColWidth(_dt.Columns.Count + 1, dd / 2);

            for (int iCol = _dt.Columns.Count + 2; iCol <= _axfpSpread.MaxCols; iCol++)
            {
                _axfpSpread.set_ColWidth(iCol, 0);
            }
            for (int i = _dt.Rows.Count+1; i <= _axfpSpread.MaxRows; i++)
            {
                _axfpSpread.set_RowHeight(i+2, 0);
            }

            MergeRowGroupCol(_axfpSpread, 2, _dt.Columns.Count , 1);
           
            
        }

        private void tmr_Load_Tick(object sender, EventArgs e)
        {
            iCount++;
            if (iCount >= 40)
            {
                lblCMP_Click(null, null);
                iCount = 0;
            }
        }
        

        private void lblCMP_Click(object sender, EventArgs e)
        {
  
            
            _sProcess = "CMP";
            Search_Data();
            iCount = 0;
        }

        private void FORM_SMT_B_EXTERNAL_OSD_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                tmr_Load.Start();
                tmrTime.Start();
                iCount = 39;
            }
            else
            {
                tmr_Load.Start();
                tmrTime.Stop();
            }
        }


    }
}
