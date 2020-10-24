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
    public partial class FORM_SMT_B_PHP_INV : SampleFrm2
    {
        public FORM_SMT_B_PHP_INV()
        {
            InitializeComponent();
            //formName = "FORM_SMT_B_PHP_INV";
            this.Name = "FORM_SMT_B_PHP_INV";
            this.Text = "FORM_SMT_B_PHP_INV";
            lblTitle.Text = "Phylon Inventory";
            if (_sProcess == "CMP")
                lblRubber_Click(null, null);
            else
                lblEVA_Click(null, null);
        }

        public static string _sProcess = "CMP";
        public int iCount = 0;
        bool _bLoad = true;

        public FORM_SMT_B_PHP_INV( string argFrm)
        {
            InitializeComponent();
            //formName = "FORM_SMT_B_PHP_INV";
            this.Name = "FORM_SMT_B_PHP_INV";
            this.Text = "FORM_SMT_B_PHP_INV";
            lblTitle.Text = "Phylon Inventory";
            _sProcess = "PHP";
            this.Text = "INV2";
            pnRubber.Visible = false;
            pnEVA.Visible = false;
            pnHeader.BackColor = Color.RoyalBlue;
            pnHeader.BackColor = Color.RoyalBlue;

            if (_sProcess == "CMP")
                lblRubber_Click(null, null);
            else
                lblEVA_Click(null, null);

        }

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
                CreateChart(dt.Copy(), chartControl);
                if (_sProcess == "CMP")
                {
                    axfpSpeadPHP.SendToBack();
                    axfpSpread.BringToFront();
                    Display_Grid(axfpSpread, dt);
                }
                else
                {
                    axfpSpread.SendToBack();
                    axfpSpeadPHP.BringToFront();
                    Display_Grid(axfpSpeadPHP, dt);
                }
            }
        }

        private void FORM_SMT_B_PROD_MONTHLY_Load(object sender, EventArgs e)
        {
            //lblRubber_Click(null, null);
            //Search_Data();
            tmr_Load.Interval = 1000;
            
        }
        private void CreateChart(DataTable _dt, DevExpress.XtraCharts.ChartControl _chartControl)
        {
            try
            {
                
                 _dt.Rows.RemoveAt(0);
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
                ((XYDiagram)_chartControl.Diagram).AxisY.Title.Text = " Inventory (Prs)";
                ((XYDiagram)_chartControl.Diagram).AxisY.Label.TextPattern = "{V:###,###}";
                ((XYDiagram)_chartControl.Diagram).AxisY.Title.Font = new Font("Calibri", 14F, System.Drawing.FontStyle.Bold);

                ((XYDiagram)_chartControl.Diagram).AxisY.Title.TextColor = Color.DarkOrange;
                ((XYDiagram)_chartControl.Diagram).AxisX.Title.TextColor = Color.DarkOrange;

                ((XYDiagram)_chartControl.Diagram).AxisX.Label.Angle = 50;

                DevExpress.XtraCharts.LineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
                DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
                DevExpress.XtraCharts.XYSeriesUnwindAnimation xySeriesSlideAnimation1 = new DevExpress.XtraCharts.XYSeriesUnwindAnimation();

                _chartControl.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;

                _chartControl.Series.Clear();
                _chartControl.Titles.Clear();
              

                Series series1 = new Series("Inventory", ViewType.Bar);
                Series series2 = new Series("Leadtime", ViewType.Line);
                Legend lgBox = new Legend();
                lgBox.Visibility = DevExpress.Utils.DefaultBoolean.True;
                lgBox.Font = new Font("Calibri", 16F, System.Drawing.FontStyle.Bold);

                if (_dt != null && _dt.Rows.Count > 0)
                {

                    for (int iRow = 0; iRow < _dt.Rows.Count; iRow++)
                    {


                        if (_dt.Rows[iRow]["INV_QTY"].ToString() != "")
                        {
                            series1.Points.Add(new SeriesPoint(_dt.Rows[iRow]["MODEL_NAME"].ToString(), Convert.ToInt32(_dt.Rows[iRow]["INV_QTY"].ToString())));
                            
                        }
                        else
                        {
                            series1.Points.Add(new SeriesPoint(_dt.Rows[iRow]["MODEL_NAME"].ToString(), 0));
                        }

                        if (_dt.Rows[iRow]["LEADTIME"].ToString() != "")
                        {
                            series2.Points.Add(new SeriesPoint(_dt.Rows[iRow]["MODEL_NAME"].ToString(), Convert.ToDouble(_dt.Rows[iRow]["LEADTIME"].ToString())));

                        }
                        else
                        {
                            series2.Points.Add(new SeriesPoint(_dt.Rows[iRow]["MODEL_NAME"].ToString(), 0));
                        }

                    }

                }

                
                
                sideBySideBarSeriesView1.ColorEach = false;
                sideBySideBarSeriesView1.Shadow.Visible = false;
                series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                series1.Label.TextPattern = "{V:###,###}";
                series1.ArgumentScaleType = ScaleType.Qualitative;
              
                series1.View = sideBySideBarSeriesView1;


                splineSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                splineSeriesView1.LineStyle.Thickness = 2;
                splineSeriesView1.SeriesAnimation = xySeriesSlideAnimation1;
                splineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                splineSeriesView1.LineMarkerOptions.Size = 15;
                splineSeriesView1.LineMarkerOptions.Color = Color.DodgerBlue;

                series2.Label.BackColor = Color.White;
                series2.Label.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                series2.Label.TextPattern = "{V:##0.#}";                
                series2.ArgumentScaleType = ScaleType.Qualitative;
                series2.View = splineSeriesView1;

                // Access the type-specific options of the diagram.

                _chartControl.Series.AddRange(new Series[] { series1, series2 });

                SecondaryAxisY myAxisY = new SecondaryAxisY("my Y-Axis");
               
                //myAxisY.VisualRange.SetMinMaxValues(0, 20);
                myAxisY.Title.Text = "Leadtime (Days)";
                myAxisY.Tickmarks.MinorVisible = true;

                //((XYDiagram)barChartControl.Diagram).AxisY.WholeRange.SetMinMaxValues(90, 100);
                myAxisY.Label.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                myAxisY.Title.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                myAxisY.Label.TextPattern = "{V:##0.##}";
                myAxisY.Title.TextColor = Color.DarkOrange;
                myAxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;
                ((XYDiagram)_chartControl.Diagram).SecondaryAxesY.Clear();
                ((XYDiagram)_chartControl.Diagram).SecondaryAxesY.Add(myAxisY);

                ((LineSeriesView)series2.View).AxisY = myAxisY;

               

               // _chartControl.Legends.Add(lgBox);
       

                // Add a title to the chart (if necessary).
               // _chartControl.Titles.Add(new ChartTitle());
                //_chartControl.Titles[0].Text = "Production";


              

            }
            catch (Exception EX)
            {
            }
        }
        private void Display_Grid(AxFPUSpreadADO.AxfpSpread _axfpSpread , DataTable _dt)
        {
            _axfpSpread.RowsFrozen = 2;
            if (_sProcess == "CMP")
            {
                _axfpSpread.BringToFront();
                int iNumberRow = _dt.Rows.Count;
                if (iNumberRow > 99) iNumberRow = 99;

                for (int iRow = 0; iRow < iNumberRow; iRow++)
                {

                    if (_dt.Rows[iRow]["DIV"].ToString() =="0")
                    {
                        _axfpSpread.Col = -1;
                        _axfpSpread.Row = iRow +2;
                        _axfpSpread.BackColor = Color.LightGray;
                       
                    }

                    _axfpSpread.SetText(1, iRow + 2, _dt.Rows[iRow]["MODEL_NAME"].ToString());
                    if (_dt.Rows[iRow]["PLAN_QTY"].ToString() != "0")
                    {
                        _axfpSpread.SetText(2, iRow + 2, _dt.Rows[iRow]["PLAN_QTY"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(2, iRow + 2, "");
                    }
                    if (_dt.Rows[iRow]["BEF_QTY"].ToString() != "0")
                    {
                        _axfpSpread.SetText(3, iRow + 2, _dt.Rows[iRow]["BEF_QTY"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(3, iRow + 2, "");
                    }


                    if (_dt.Rows[iRow]["IN_QTY"].ToString() != "0")
                    {
                        _axfpSpread.SetText(4, iRow + 2, _dt.Rows[iRow]["IN_QTY"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(4, iRow + 2, "");
                    }

                    if (_dt.Rows[iRow]["OUT_QTY"].ToString() != "0")
                    {
                        _axfpSpread.SetText(5, iRow + 2, _dt.Rows[iRow]["OUT_QTY"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(5, iRow + 2, "");
                    }

                    if (_dt.Rows[iRow]["INV_QTY"].ToString() != "0")
                    {
                        _axfpSpread.SetText(6, iRow + 2, _dt.Rows[iRow]["INV_QTY"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(6, iRow + 2, "");
                    }

                    if (_dt.Rows[iRow]["LEADTIME"].ToString() != "0")
                    {
                        _axfpSpread.SetText(7, iRow + 2, _dt.Rows[iRow]["LEADTIME"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(7, iRow + 2, "");
                    }
                }
                for (int iRow = _dt.Rows.Count + 1; iRow < _axfpSpread.MaxRows; iRow++)
                {
                    _axfpSpread.set_RowHeight(iRow + 1, 0);
                }
            }

            if (_sProcess == "PHP")
            {
                int iNumberRow = _dt.Rows.Count;
                if (iNumberRow > 99) iNumberRow = 99;

                for (int iRow = 0; iRow < iNumberRow; iRow++)
                {
                    if (_dt.Rows[iRow]["DIV"].ToString() == "0")
                    {
                        _axfpSpread.Col = -1;
                        _axfpSpread.Row = iRow + 3;
                        _axfpSpread.BackColor = Color.LightGray;

                    }

                    _axfpSpread.SetText(1, iRow + 3, _dt.Rows[iRow]["MODEL_NAME"].ToString());
                    if (_dt.Rows[iRow]["PLAN_QTY"].ToString() != "0")
                    {
                        _axfpSpread.SetText(2, iRow + 3, _dt.Rows[iRow]["PLAN_QTY"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(2, iRow + 3, "");
                    }
                    if (_dt.Rows[iRow]["INV_QTY"].ToString() != "0")
                    {
                        _axfpSpread.SetText(3, iRow + 3, _dt.Rows[iRow]["INV_QTY"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(3, iRow + 3, "");
                    }


                    if (_dt.Rows[iRow]["LEADTIME"].ToString() != "0")
                    {
                        _axfpSpread.SetText(4, iRow + 3, _dt.Rows[iRow]["LEADTIME"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(4, iRow + 3, "");
                    }

                    if (_dt.Rows[iRow]["UV_INV_QTY"].ToString() != "0")
                    {
                        _axfpSpread.SetText(5, iRow + 3, _dt.Rows[iRow]["UV_INV_QTY"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(5, iRow + 3, "");
                    }

                    if (_dt.Rows[iRow]["UV_LT"].ToString() != "0")
                    {
                        _axfpSpread.SetText(6, iRow + 3, _dt.Rows[iRow]["UV_LT"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(6, iRow + 3, "");
                    }

                    if (_dt.Rows[iRow]["SP_INV_QTY"].ToString() != "0")
                    {
                        _axfpSpread.SetText(7, iRow + 3, _dt.Rows[iRow]["SP_INV_QTY"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(7, iRow + 3, "");
                    }

                    if (_dt.Rows[iRow]["SP_LT"].ToString() != "0")
                    {
                        _axfpSpread.SetText(8, iRow + 3, _dt.Rows[iRow]["SP_LT"].ToString());
                    }
                    else
                    {
                        _axfpSpread.SetText(8, iRow + 3, "");
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
                iCount = 0;
                if (_sProcess == "CMP")
                    lblRubber_Click(null, null);
                else
                    lblEVA_Click(null, null);
                
            }
        }

        private void lblEVA_Click(object sender, EventArgs e)
        {
            pnEVA.GradientEndColor = Color.White; //Color.FromArgb(255, 128, 128);
            pnRubber.GradientEndColor = Color.Gray;
            pnEVA.Enabled = false;
            pnRubber.Enabled = true;
            lblTitle.Text = "Phylon Inventory";
            _sProcess = "PHP";
            Search_Data();
            iCount = 0;
        }

        private void lblRubber_Click(object sender, EventArgs e)
        {
            pnRubber.GradientEndColor = Color.White;//Color.FromArgb(255, 128, 128);
            pnEVA.GradientEndColor = Color.Gray;
            pnEVA.Enabled = true;
            pnRubber.Enabled = false;
            lblTitle.Text = "CMP Inventory";
            _sProcess = "CMP";
            Search_Data();
            iCount = 0;
        }

        private void FORM_SMT_B_PHP_INV_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                if (_bLoad) iCount = 0;
                else iCount = 39;
                _bLoad = false;
                
                tmr_Load.Start();
                tmrTime.Start();
            }
            else
            {
                tmr_Load.Start();
                tmrTime.Start();
            }
        }


    }
}
