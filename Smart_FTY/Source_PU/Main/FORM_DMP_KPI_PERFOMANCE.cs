using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Drawing.Drawing2D;
using Microsoft.VisualBasic.PowerPacks;
using ChartDirector;

namespace Smart_FTY
{
    public partial class FORM_DMP_KPI_PERFOMANCE : Form
    {
        //System.Drawing.Color _lineColor = System.Drawing.Color.Blue;
        //System.Drawing.Pen _myPen = new System.Drawing.Pen(System.Drawing.Color.Blue);
        //int _wlr = 6;
        //int _wn = 3;
        //DataTable _dt_daily = null;
        //DataTable _dt_model = null;
        DataTable _dt_chart = null;
        int _cnt = 0;
        //double[] data_w1;
        //double[] data_w2;
        //double[] data_w3;
        //double[] data_w4;
        //string[] label_w1;
        //string[] label_w2;
        //string[] label_w3;
        //string[] label_w4;
        int _icount = 0;
        bool _load = true;
        double[] _C1;
        double[] _C2 ;
        double[] _C3;
        double[] _C4 ;
        double[] _C5;
        double[] _C6;
        int[] _colors ;
        string[] _strLabel ;

        public FORM_DMP_KPI_PERFOMANCE()
        {
            InitializeComponent();
        }

        #region Func

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

        private void add_data(Panel arg_pn, DataTable arg_dt)
        {
            foreach (Control con in arg_pn.Controls)
            {
                if (con.Name.Substring(0, 3) == "lbl")
                {

                    // Label lbl = (Label)con;
                    // str_column = con.Name.ToUpper();
                    con.Text = arg_dt.Rows[0][con.Name].ToString();

                }

            }
        }

        private void BindingDataGird()
        {
            load_grid(axGrid_C3);
            load_grid(axGrid_C2);
            load_grid(axGrid_C1);
            load_grid(axGrid_C5);
            load_grid(axGrid_C4);
            load_grid(axGrid_C6);

            setImage(cmd_C1);
            setImage(cmd_C2);
            setImage(cmd_C3);
            setImage(cmd_C4);
            setImage(cmd_C5);
            setImage(cmd_C6);
        }
       
        private void setImage(Button arg_cmd)
        {
            if (_dt_chart.Rows[0][arg_cmd.Name.Replace("cmd_", "") + "_STATUS"].ToString().ToUpper() == "UP")
            {
                arg_cmd.BackgroundImage = Smart_FTY.Properties.Resources.arrow_165_xxl;
            }
            else
            {
                arg_cmd.BackgroundImage = Smart_FTY.Properties.Resources.arrow_165_down;
            }
            arg_cmd.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private double NulltoZeroDouble(object arg)
        {
            if (arg != null && arg.ToString() != "")
            {
                return Convert.ToDouble(arg);
            }
            else
                return 0;
        }

        public void createChart(WinChartViewer viewer, double[] data, string img)
        {
            // The data for the chart
            Chart.setLicenseCode("DEVP-2LSU-B4LX-YCTY-2DF2-77EE");
            //double[] data = {16, 15, 9.7, 5.2, 3};

            // double[] data1 = { Chart.NoValue, -131, 35, 46 };
            // The labels for the chart
           // string[] labels = _strLabel;

            //int[] _colors = { 3394815, 0x33ccff, 0x33ccff, 0x33ccff, 28864 };

            double dMax = NulltoZeroDouble(_dt_chart.Rows[_dt_chart.Rows.Count - 3][viewer.Name.Replace("chart_", "")]);
            double dMin = NulltoZeroDouble(_dt_chart.Rows[_dt_chart.Rows.Count - 2][viewer.Name.Replace("chart_", "")]);
            double dIncr = NulltoZeroDouble(_dt_chart.Rows[_dt_chart.Rows.Count - 1][viewer.Name.Replace("chart_", "")]);

            // Create a XYChart object of size 480 x 300 pixels. Set background color
            // to brushed silver, with a grey (bbbbbb) border and 2 pixel 3D raised
            // effect. Use rounded corners. Enable soft drop shadow.
            // XYChart c = new XYChart(400, 300, Chart.brushedSilverColor(), 0xbbbbbb, 2);
            XYChart c = new XYChart(viewer.Width, viewer.Height);
            c.setBorder(10);

            // Add a title to the chart using 15 points Arial Italic. Set top/bottom
            // margins to 12 pixels.

            ChartDirector.TextBox title = c.addTitle(Chart.Top, _dt_chart.Rows[0][viewer.Name.Replace("chart_", "") + "_CNAME"].ToString(),
                "Arial Bold", 12);
            title.setMargin2(10, 10, 6, 12);
            title.setPos(10, 3);
            title.setSize(viewer.Width - 20, 30);

            // Tentatively set the plotarea at (50, 40). Set the width to 100 pixels
            // less than the chart width, and the height to 80 pixels less than the
            // chart height. Use pale grey (f4f4f4) background, transparent border,
            // and dark grey (444444) dotted grid lines.
            c.setPlotArea(70, 50, c.getWidth() - 110, c.getHeight() - 100, 0xf4f4f4,
                -1, Chart.Transparent, c.dashLineColor(0xffffff, Chart.Transparent));

            // Add a line layer for the pareto line
            // ArrayMath li = new ArrayMath(data1);
            ArrayMath am = new ArrayMath(data);

            //LineLayer lineLayer = c.addLineLayer2();

            //lineLayer.addDataSet(li.mul(_cnt / 100.0).result(), 0x0000ff).setDataSymbol(
            //    Chart.CircleShape, 9, 0x0000ff, 0x0000ff);

            //// Set the line width to 2 pixel
            //lineLayer.setLineWidth(2);

            //// Bind the line layer to the secondary (right) y-axis.
            //lineLayer.setUseYAxis2();

            //lineLayer.setDataLabelFormat("{value}%");

            // Add a multi-color bar layer using the given data            
            BarLayer barLayer = c.addBarLayer3(am.mul(_cnt / 100.0).result(), _colors);
            barLayer.setBorderColor(Chart.Transparent);
            barLayer.setAggregateLabelStyle();

            //  c.xAxis().setLabelStyle("Arial Bold", 8).setFontAngle(70);
            c.xAxis().setLabelStyle("Arial Bold", 8);
            c.yAxis().setLabelStyle("Arial   Bold", 9);
            // c.yAxis2().setLabelStyle("Arial Bold", 9);

            // Set the labels on the x axis.
            c.xAxis().setLabels(_strLabel);

            // Set the secondary (right) y-axis scale as 0 - 100 with a tick every 20
            // units
            c.yAxis().setLinearScale(dMin, dMax, dIncr);
            //  c.yAxis2().setLinearScale(-140, 60, 20);

            // Set the format of the secondary (right) y-axis label to include a
            // percentage sign
            //  c.yAxis2().setLabelFormat("{value}%");

            // Set the format of the primary y-axis label foramt to show no decimal
            // point
            c.yAxis().setLabelFormat("{value|0}");
            c.setNumberFormat(',');

            // Output the chart
            viewer.Chart = c;
        }


        public string EmptyIfNull(object value)
        {
            if (value == null || value.ToString() == "%")
                return "";
            return value.ToString();
        }

        public string EmptyIfNull2(object value)
        {
            if (value == null || value.ToString() == "%")
                return "";
            return Convert.ToDouble(value).ToString("###,###,###.##");
        }

        private void load_grid(AxFPSpreadADO.AxfpSpread axGrid)
        {
            int imax = Convert.ToInt16(_dt_chart.Rows[0]["COL_COUNT"]);
            int iColSpan = Convert.ToInt16(_dt_chart.Rows[0]["COL_SPAN"]);
            axGrid.MaxCols = imax + 2;

            axGrid.AddCellSpan(3, 4, iColSpan, 1);

            axGrid.SetText(1, 1, EmptyIfNull(_dt_chart.Rows[0][axGrid.Name.Replace("axGrid_", "") + "_GNAME"].ToString()));
            for (int i = 0; i < imax; i++)
            {
                
                axGrid.SetText(i + 3, 1, _dt_chart.Rows[i]["TITLE"].ToString());
                axGrid.SetText(i + 3, 2,EmptyIfNull2(_dt_chart.Rows[i][axGrid.Name.Replace("axGrid_", "")].ToString()));
                axGrid.SetText(i + 3, 3, EmptyIfNull(_dt_chart.Rows[i][axGrid.Name.Replace("axGrid_", "") + "_PER"].ToString() + "%"));
                axGrid.SetText(3, 4, EmptyIfNull(_dt_chart.Rows[0][axGrid.Name.Replace("axGrid_", "") + "_IM"].ToString() + "%"));
                axGrid.set_ColWidth(i + 3, Convert.ToDouble(_dt_chart.Rows[i]["COL_WIDTH"]));

                axGrid.Col = i + 3;
                axGrid.Row = 1;
                axGrid.FontSize = Convert.ToSingle(_dt_chart.Rows[i]["FONT"]);
                axGrid.Row = 4;

                if (i >= iColSpan)
                    axGrid.BackColor = Color.White;
                else
                    axGrid.BackColor = Color.Navy;
                axGrid.FontSize = 35f;
                axGrid.FontBold = true;
            }

            axGrid.SetCellBorder(1, 1, axGrid.MaxCols, axGrid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            axGrid.SetCellBorder(1, 2, axGrid.MaxCols, axGrid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            axGrid.SetCellBorder(1, 2, axGrid.MaxCols, axGrid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexTop, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            
        }
 
        private void load_data_chart(DataTable arg_data)
        {
            int index = 0;
            int ir;
            

            if (arg_data != null && arg_data.Rows.Count > 0)
            {
                ir = Convert.ToInt16(arg_data.Rows[0]["COL_COUNT"]);
                _C1 = new double[ir];
                _C2 = new double[ir];
                _C3 = new double[ir];
                _C4 = new double[ir];
                _C5 = new double[ir];
                _C6 = new double[ir];
                _strLabel = new string[ir];
                _colors = new int[ir];

                for (int i = 0; i < ir; i++)
                {

                    _C1[index] = Convert.ToDouble(EmptyIfNull(arg_data.Rows[i][chart_C1.Name.Replace("chart_","") ]));
                    _C2[index] = Convert.ToDouble(EmptyIfNull(arg_data.Rows[i][chart_C2.Name.Replace("chart_", "")]));
                    _C3[index] = Convert.ToDouble(EmptyIfNull(arg_data.Rows[i][chart_C3.Name.Replace("chart_", "")]));
                    _C4[index] = Convert.ToDouble(EmptyIfNull(arg_data.Rows[i][chart_C4.Name.Replace("chart_", "")]));
                    _C5[index] = Convert.ToDouble(EmptyIfNull(arg_data.Rows[i][chart_C5.Name.Replace("chart_", "")]));
                    _C6[index] = Convert.ToDouble(EmptyIfNull(arg_data.Rows[i][chart_C6.Name.Replace("chart_", "")]));
                    _strLabel[index] = arg_data.Rows[i]["TITLE"].ToString();
                    _colors[index] = Convert.ToInt32(arg_data.Rows[i]["COLOR"]);
                    index++;
                }
            }


        

        }


        #endregion Func


        #region DB
        private DataTable SELECT_KPI_PER()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;
            try
            {
                string process_name = "SEPHIROTH.PKG_DMC.SELECT_KPI_PER";
                //ARGMODE
                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = process_name;
                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";
                MyOraDB.Parameter_Type[0] = (char)OracleType.Cursor;
                MyOraDB.Parameter_Values[0] = "";
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


        private System.Data.DataSet LOAD_DATA_LOGISTIC()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;
            try
            {
                string process_name = "SEPHIROTH.PKG_IPEX3.SELECT_OSD_EXT_TOUCH_v2";
                //ARGMODE
                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;
                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";
                MyOraDB.Parameter_Name[1] = "OUT1_CURSOR";
                MyOraDB.Parameter_Name[2] = "OUT2_CURSOR";
                MyOraDB.Parameter_Type[0] = (char)OracleType.Cursor;
                MyOraDB.Parameter_Type[1] = (char)OracleType.Cursor;
                MyOraDB.Parameter_Type[2] = (char)OracleType.Cursor;
                MyOraDB.Parameter_Values[0] = "";
                MyOraDB.Parameter_Values[1] = "";
                MyOraDB.Parameter_Values[2] = "";
                MyOraDB.Add_Select_Parameter(true);
                return ds_ret = MyOraDB.Exe_Select_Procedure();
                //  if (ds_ret == null) return null;
                // return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }

        #endregion DB

        #region event
        #region Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));


               // blink_oval(cmd_C1);
                //blink_oval(oval_Z2_CND);
                //blink_oval(oval_Z3_CND);
                //blink_oval(oval_Z4_CND);
                //blink_oval(oval_Z5_CND);
                //blink_oval(oval_Z6_CND);
                _icount++;
                if (_icount >= 55 )
                {

                    DataTable dt = SELECT_KPI_PER();
                    if (dt != null || dt.Rows.Count > 0)
                    {
                        
                        _dt_chart = dt;
                        lblTitle.Text = _dt_chart.Rows[0]["FORM_TITLE"].ToString();
                        BindingDataGird();

                        load_data_chart(_dt_chart);

                        timer2.Start();
                    }
                    _icount = 0;
                   // _load = false;
                }
                
            }
            catch (Exception)
            {
            }
        }


        #endregion Timer
      
        private void lblDate_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {

            }

        }

        private void FORM_IPEX3_LOGISTIC_VisibleChanged(object sender, EventArgs e)
        {

            if (this.Visible)
            {
                // pn_body.Hide();

                _icount = 54;
                timer1.Start();
                timer3.Start();
                //timer2.Start();
               
                //  MaterialReport.ClassLib.WinAPI.AnimateWindow(pn_body.Handle, 500, MaterialReport.ClassLib.WinAPI.getSlidType("1"));

                //   pn_body.Show();


            }
            else
            {
                //_load = false;
                //timer1.Stop();
                
                //timer3.Stop();
            }
        }

        private void FORM_IPEX3_LOGISTIC_Load(object sender, EventArgs e)
        {
            try
            {
                GoFullscreen(true);
                //_dt_chart = SELECT_KPI_PER();

                //BindingDataGird();

                //load_data_chart(_dt_chart);
                timer1.Interval = 1000;

                // createChart2(chart2, "");

                timer2.Start();
                timer2.Interval = 50;
            }
            catch (Exception)
            {

            }
            
            // createChartCenter(chart_center, "");
            //  _myPen.Width = _wlr;

            // lblTitle.Text = "Logistic Status(Between Blending And IPP)";
            //load_grid_daily(_dt_daily);
            // load_grid_model(_dt_model);


            // lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
        }



        #endregion Event

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (_cnt > 100)
                {
                    timer2.Stop();
                    _cnt = 0;
                }
                else
                {
                    createChart(chart_C1, _C1, "");
                    createChart(chart_C2, _C2, "");
                    createChart(chart_C3, _C3, "");
                    createChart(chart_C4, _C4, "");
                    createChart(chart_C5, _C5, "");
                    createChart(chart_C6, _C6, "");

                    //createChart5(chart_C5, "");
                    //createChart4(chart_C4, "");
                    //createChart6(chart_C6, "");
                    //createChart1(chart_C1, "");
                    //createChart3(chart_C3, "");
                    //createChart2(chart_C2, "");
                    _cnt += 5;
                }
            }
            catch (Exception)
            {

            }
            


        }


        private void blink(Button arg_cmd)
        {
            if (arg_cmd.Visible)
            {
                arg_cmd.Visible = false;
            }
            else
            {
                arg_cmd.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (checkWindowOpen("FORM_TOUCH_SCREEN_MAIN_CONTROL") == true)
            //{
            //    FORM_TOUCH_SCREEN_MAIN_CONTROL frm = new FORM_TOUCH_SCREEN_MAIN_CONTROL();
            //    frm.Show();
            //}

            //this.Hide();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            blink(cmd_C2);
            blink(cmd_C3);
            blink(cmd_C1);
            blink(cmd_C6);
            blink(cmd_C4);
            blink(cmd_C5);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.Cursor = new Cursor(Cursor.Current.Handle);
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Smart_FTY.ComVar._frm_home.Show();
            this.Hide();
        }







    }
}
