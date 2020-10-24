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
    public partial class FORM_SMT_B_PHP_INV_TRACKING : SampleFrm2
    {
        public FORM_SMT_B_PHP_INV_TRACKING()
        {
            InitializeComponent();
            lblTitle.Text = "Phylon Inventory Tracking(PH-Stockfit)";
            //formName = "FORM_SMT_B_PHP_INV_TRACKING";
            this.Name = "FORM_SMT_B_PHP_INV_TRACKING";
            this.Text = "FORM_SMT_B_PHP_INV_TRACKING";
        }

        public static string _sProcess = "FSS";
        public int iCount = 0;


        public DataTable SMT_B_PHP_INVENTORY(string V_P_MONTH, string V_P_PROC)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_B_PRODUCTION.SMT_B_PHP_INVENTORY";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "V_P_MONTH";
                MyOraDB.Parameter_Name[1] = "V_P_PROC";
                MyOraDB.Parameter_Name[2] = "CV_1";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;             
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = V_P_MONTH;
                MyOraDB.Parameter_Values[1] = V_P_PROC;          
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

            DataTable dt = SMT_B_PHP_INVENTORY(sDate, _sProcess);
            if (dt != null && dt.Rows.Count > 0)
            {
                CreateChart(dt, chartControl);               
                 Display_Grid(axfpSpeadPHP, dt);                
            }
        }

        private void FORM_SMT_B_INV_TRACKING_Load(object sender, EventArgs e)
        {
            
            
            tmr_Load.Interval = 1000;
            //tmr_Load.Start();
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
                ((XYDiagram)_chartControl.Diagram).AxisX.Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
                ((XYDiagram)_chartControl.Diagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                ((XYDiagram)_chartControl.Diagram).AxisX.Title.Text = "Model";

                ((XYDiagram)_chartControl.Diagram).AxisX.Title.Font = new Font("Calibri", 14F, System.Drawing.FontStyle.Bold);

                ((XYDiagram)_chartControl.Diagram).AxisY.Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
                ((XYDiagram)_chartControl.Diagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                ((XYDiagram)_chartControl.Diagram).AxisY.Title.Text = " Leadtime (Hours) ";
                ((XYDiagram)_chartControl.Diagram).AxisY.Label.TextPattern = "{V:###,##0.#}";
                ((XYDiagram)_chartControl.Diagram).AxisY.Title.Font = new Font("Calibri", 14F, System.Drawing.FontStyle.Bold);

                ((XYDiagram)_chartControl.Diagram).AxisY.Title.TextColor = Color.DarkOrange;
                ((XYDiagram)_chartControl.Diagram).AxisX.Title.TextColor = Color.DarkOrange;

                ((XYDiagram)_chartControl.Diagram).AxisX.Label.Angle = 50;

               
                DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();

                DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView2 = new DevExpress.XtraCharts.SideBySideBarSeriesView();

                DevExpress.XtraCharts.XYSeriesUnwindAnimation xySeriesSlideAnimation1 = new DevExpress.XtraCharts.XYSeriesUnwindAnimation();

                _chartControl.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;

                _chartControl.Series.Clear();
                _chartControl.Titles.Clear();


                Series series1 = new Series("Stockfit Leadtime", ViewType.Bar);
                Series series2 = new Series("Phylon Leadtime", ViewType.Bar);
                Legend lgBox = new Legend();
                lgBox.Visibility = DevExpress.Utils.DefaultBoolean.True;
                lgBox.Font = new Font("Calibri", 16F, System.Drawing.FontStyle.Bold);

                if (_dt != null && _dt.Rows.Count > 0)
                {

                    for (int iRow = 0; iRow < _dt.Rows.Count; iRow++)
                    {
                        if (_dt.Rows[iRow]["DIV"].ToString() != "0")
                        {

                            if (_dt.Rows[iRow]["LEADTIME"].ToString() != "")
                            {
                                series1.Points.Add(new SeriesPoint(_dt.Rows[iRow]["MODEL_NAME"].ToString(), Convert.ToDouble(_dt.Rows[iRow]["LEADTIME"].ToString())));

                            }
                            else
                            {
                                series1.Points.Add(new SeriesPoint(_dt.Rows[iRow]["MODEL_NAME"].ToString(), 0));
                            }

                            double dUV_LT = 0;
                            double dSP_LT = 0;

                            if (_dt.Rows[iRow]["UV_LT"].ToString() != "")
                            {
                                dUV_LT = Convert.ToDouble(_dt.Rows[iRow]["UV_LT"].ToString());

                            }

                            if (_dt.Rows[iRow]["SP_LT"].ToString() != "")
                            {
                                 dSP_LT = Convert.ToDouble(_dt.Rows[iRow]["SP_LT"].ToString());

                            }
                            


                            
                            series2.Points.Add(new SeriesPoint(_dt.Rows[iRow]["MODEL_NAME"].ToString(), dUV_LT + dSP_LT));

                            
                        }

                    }

                }

                
                
                sideBySideBarSeriesView1.ColorEach = false;
                sideBySideBarSeriesView1.Shadow.Visible = false;
                series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                series1.Label.TextPattern = "{V:##0.#}";
                series1.ArgumentScaleType = ScaleType.Qualitative;
              
                series1.View = sideBySideBarSeriesView1;

                sideBySideBarSeriesView2.ColorEach = false;
                sideBySideBarSeriesView2.Shadow.Visible = false;     
                series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                series2.Label.TextPattern = "{V:##0.#}";
                series2.ArgumentScaleType = ScaleType.Qualitative;
                series2.View = sideBySideBarSeriesView2;
             

                // Access the type-specific options of the diagram.

                _chartControl.Series.AddRange(new Series[] { series1, series2 });                              

              

            }
            catch (Exception EX)
            {
            }
        }
        private void Display_Grid(AxFPUSpreadADO.AxfpSpread _axfpSpread , DataTable _dt)
        {            

            if (_sProcess == "FSS")
            {
                int iNumberRow = _dt.Rows.Count;
                if (iNumberRow > 99) iNumberRow = 99;

                for (int iRow = 0; iRow < iNumberRow; iRow++)
                {

                    _axfpSpread.SetText(1, iRow + 4, _dt.Rows[iRow]["MODEL_NAME"].ToString());
                    if (_dt.Rows[iRow]["PLAN_QTY"].ToString() != "0")
                    {
                        _axfpSpread.SetText(2, iRow + 4, _dt.Rows[iRow]["PLAN_QTY"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(2, iRow + 4, "");
                    }
                    if (_dt.Rows[iRow]["INV_QTY"].ToString() != "0")
                    {
                        _axfpSpread.SetText(3, iRow + 4, _dt.Rows[iRow]["INV_QTY"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(3, iRow + 4, "");
                    }


                    if (_dt.Rows[iRow]["LEADTIME"].ToString() != "0")
                    {
                        _axfpSpread.SetText(4, iRow + 4, _dt.Rows[iRow]["LEADTIME"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(4, iRow + 4, "");
                    }

                    if (_dt.Rows[iRow]["UV_INV_QTY"].ToString() != "0")
                    {
                        _axfpSpread.SetText(5, iRow + 4, _dt.Rows[iRow]["UV_INV_QTY"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(5, iRow + 4, "");
                    }

                    if (_dt.Rows[iRow]["UV_LT"].ToString() != "0")
                    {
                        _axfpSpread.SetText(6, iRow + 4, _dt.Rows[iRow]["UV_LT"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(6, iRow + 4, "");
                    }

                    if (_dt.Rows[iRow]["SP_INV_QTY"].ToString() != "0")
                    {
                        _axfpSpread.SetText(7, iRow + 4, _dt.Rows[iRow]["SP_INV_QTY"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(7, iRow + 4, "");
                    }

                    if (_dt.Rows[iRow]["SP_LT"].ToString() != "0")
                    {
                        _axfpSpread.SetText(8, iRow + 4, _dt.Rows[iRow]["SP_LT"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(8, iRow + 4, "");
                    }
                }
                for (int iRow = _dt.Rows.Count + 1; iRow < _axfpSpread.MaxRows; iRow++)
                {
                    _axfpSpread.set_RowHeight(iRow + 1, 0);
                }
            } 

           
            
        }

        private void tmr_Load_Tick(object sender, EventArgs e)
        {
            iCount++;
            if (iCount >= 40)
            {
                Search_Data();
                iCount = 0;
            }
        }

       

        private void Search()
        {
           
            
            Search_Data();
            
        }

        private void FORM_SMT_B_PHP_INV_TRACKING_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                
                _sProcess = "FSS";
                iCount = 39;
                tmr_Load.Start();
                tmrTime.Start();
            }
            else
            {
                tmr_Load.Stop();
                tmrTime.Stop();
            }
        }


    }
}
