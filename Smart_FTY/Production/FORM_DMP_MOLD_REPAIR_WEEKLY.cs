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
    public partial class FORM_DMP_MOLD_REPAIR_WEEKLY : Form
    {
        public FORM_DMP_MOLD_REPAIR_WEEKLY()
        {
            
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }


        private string viewMode = "DAILY";
        private int chartWidth = 1400;
        private int chartHeight = 700;
        private int plottWidth = 1300;
        private int plotHeight = 550;
        int masterColor = 0xffffff;
        private int numRows = 2;
        private int numCols = 16;
        private int percentage = 0;
        private int per = 0;
        private DataTable dt_top = null;
        public int _frm;
     //   private int _time_change = 0;
        DataTable dtCleamingMold = null;
        private Color _filter = Color.Transparent;
        int countedRed = 0;
        int countedYellow = 0;
        int countedBlack = 0;
        public int max_frm = 9;
        DataTable _dt = null;
        DataTable _dt_model = null;
        DataTable _dt_style = null;
        int DayOfMonth =0;
        double[] data0;
        double[] data1;
        double[] data2;
        string[] labels;
        int _time_change = 0;
      //  Thread th;
     //   bool _IsKey = true;
        int icount = 0;

        #region No use
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
            if (viewMode == "WEEKLY")
            {

            }
            else if (viewMode == "MONTHLY")
            {
                c.addTitle("MOLD REPAIR TYPE BY MONTHLY", "Calibri Bold", 30);
                layer.setBarShape(Chart.StarShape(5), 0);
            }
            else
            {
                c.addTitle("MOLD REPAIR TYPE BY DAILY", "Calibri Bold", 30);
                layer.setBarShape(Chart.CrossShape(), 0);
            }


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
       

        private void InitGrid(DataTable source)
        {

            double row_size = 29;
            numRows = source.Rows.Count;

            axfpHeaderData.MaxCols = numCols + 1;
            axfpHeaderData.MaxRows = numRows + 1;
            axfpHeaderData.RowsFrozen = 1;




            axfpHeaderData.ForeColor = Color.Black;
            axfpHeaderData.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
            axfpHeaderData.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
            axfpHeaderData.Font = new System.Drawing.Font("Calibri", 20, FontStyle.Bold);
            axfpHeaderData.BackColor = Color.White;
            axfpHeaderData.ForeColor = Color.Black;


            axfpHeaderData.Row = 1;
            axfpHeaderData.Col = 1;
            axfpHeaderData.Font = new System.Drawing.Font("Calibri", 28, FontStyle.Bold);
            axfpHeaderData.SetText(1, 1, "MOLD CODE");
            axfpHeaderData.Col = 2;
            axfpHeaderData.Font = new System.Drawing.Font("Calibri", 28, FontStyle.Bold);
            axfpHeaderData.SetText(2, 1, "MOLDEL NAME");
            axfpHeaderData.Col = 3;
            axfpHeaderData.Font = new System.Drawing.Font("Calibri", 28, FontStyle.Bold);
            axfpHeaderData.SetText(3, 1, "SIZE");
            axfpHeaderData.Col = 4;
            axfpHeaderData.Font = new System.Drawing.Font("Calibri", 28, FontStyle.Bold);
            axfpHeaderData.SetText(4, 1, "SEQ");
            axfpHeaderData.Col = 5;
            axfpHeaderData.Font = new System.Drawing.Font("Calibri", 28, FontStyle.Bold);
            axfpHeaderData.SetText(5, 1, "PROD QTY");
            axfpHeaderData.Col = 6;
            axfpHeaderData.Font = new System.Drawing.Font("Calibri", 28, FontStyle.Bold);
            axfpHeaderData.SetText(5, 1, "CLEAN PROD\nQTY");
            axfpHeaderData.Col = 7;
            axfpHeaderData.Font = new System.Drawing.Font("Calibri", 28, FontStyle.Bold);
            axfpHeaderData.SetText(6, 1, "AFTER CLEAN\nPROD QTY");

            axfpHeaderData.ScrollBars = FPSpreadADO.ScrollBarsConstants.ScrollBarsVertical;
            axfpHeaderData.ScrollBarWidth = 50;
            axfpHeaderData.set_ColWidth(1, 34);
            axfpHeaderData.set_ColWidth(2, 50);
            axfpHeaderData.set_ColWidth(3, 27);
            axfpHeaderData.set_ColWidth(4, 25);
            axfpHeaderData.set_ColWidth(5, 30);
            axfpHeaderData.set_ColWidth(6, 30);
            axfpHeaderData.set_ColWidth(7, 30);
            axfpHeaderData.set_ColWidth(0, 0);
            axfpHeaderData.set_RowHeight(0, 0);
            axfpHeaderData.Row = 1;
            axfpHeaderData.Col = -1;
            axfpHeaderData.BackColor = Color.DeepSkyBlue;
            axfpHeaderData.ForeColor = Color.White;
            axfpHeaderData.SetCellBorder(1, 1, numCols, numRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0xFFCCAC, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            axfpHeaderData.SetCellBorder(1, 1, numCols, numRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexRight, 0xFFCCAC, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            axfpHeaderData.SetCellBorder(1, 1, numCols, numRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexTop, 0xFFCCAC, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            axfpHeaderData.SetCellBorder(1, 1, numCols, numRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0xFFCCAC, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);

            axfpHeaderData.set_RowHeight(1, 100);


            for (int i = 2; i <= numRows; i++)
            {
                axfpHeaderData.set_RowHeight(i, row_size);
            }
        }
        private void set_time_chage()
        {
            tmr_style.Stop();
            if (Com_Base.Variables._iskeypress)
                tmr_style.Interval = Com_Base.Variables._time_keypress;
            else
                tmr_style.Interval = Com_Base.Variables._time_auto;
            tmr_style.Start();
        }
        #region Grid_Mold_Clean
        private void Init_Grid_Clean()
        {
            //axfpHeaderData.Location = new Point(1, 1);
            //axfpHeaderData.Size = new Size(1916, 940);

            double[] w = { 0, 35, 68, 25, 25, 25,
                           30, 30
                         };
            string[] str = { "", "Mold Code", "Model Name", "Size", "Seq", "Prod Qty",
                                 "Clean\nProd Qty", "After Clean\nProd Qty"};

            Init_Head_Grid(w, 90, str, Color.DeepSkyBlue, Color.White);
        }

        private void Init_Head_Grid(double[] w_row, int h_row, string[] text, Color back, Color fore)
        {
            axfpHeaderData.Reset();
            axfpHeaderData.MaxCols = numCols + 1;
            axfpHeaderData.MaxRows = numRows + 1;
            axfpHeaderData.RowsFrozen = 1;
            axfpHeaderData.MaxCols = w_row.Length - 1;
            axfpHeaderData.ScrollBars = FPSpreadADO.ScrollBarsConstants.ScrollBarsVertical;
            //axfpHeaderData.ScrollBarWidth = 50;
            axfpHeaderData.ScrollBars = FPSpreadADO.ScrollBarsConstants.ScrollBarsNone;
            axfpHeaderData.ActiveCellHighlightStyle = FPSpreadADO.ActiveCellHighlightStyleConstants.ActiveCellHighlightStyleOff;
            axfpHeaderData.DisplayRowHeaders = false;
            axfpHeaderData.set_RowHeight(0, 0);
            axfpHeaderData.set_RowHeight(1, h_row);
            axfpHeaderData.Font = new System.Drawing.Font("Calibri", 22.25F);

            axfpHeaderData.Col = -1;
            axfpHeaderData.Row = 1;
            axfpHeaderData.BackColor = back;
            axfpHeaderData.ForeColor = fore;
            axfpHeaderData.Font = new System.Drawing.Font("Calibri", 28.25F, FontStyle.Bold);
            axfpHeaderData.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
            axfpHeaderData.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
            axfpHeaderData.TypeEditMultiLine = true;
            axfpHeaderData.SetCellBorder(1, 1, w_row.Length - 1, 1, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexRight, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);

            for (int i = 0; i < w_row.Length; i++)
            {
                axfpHeaderData.set_ColWidth(i, w_row[i]);
                axfpHeaderData.SetText(i, 1, text[i]);
            }
        }

        #endregion Grid_Mold_Clean

        #region Daily_mold_cleaning_status

        private void Init_Grid_Daily_Clean_Status()
        {
            //axfpHeaderData.Location = new Point(1, 1);
            //axfpHeaderData.Size = new Size(1916, 940);

            double[] w = { 0, 25, 49, 14, 14, 16,
                             3,
                             25, 49, 14, 14, 15
                         };
            string[] str1 = { "Cleaning", "Coating"
                           };
            string[] str = { "", "Mold Code", "Model Name", "Size", "Seq", "Status",
                               "",
                                 "Mold Code", "Model Name", "Size", "Seq", "Status"
                                 };

            Init_Head_Grid_Clean_Status(w, 50, str, str1, Color.DeepSkyBlue, Color.White, Color.LightCoral, Color.White);
        }

        private void Init_Head_Grid_Clean_Status(double[] w_row, int h_row, string[] text, string[] text1, Color back, Color fore, Color back1, Color fore1)
        {
            //int col1 = w_row.Length / 2;
            int col_head2 = (w_row.Length / 2);
            axfpHeaderData.Reset();
            axfpHeaderData.MaxCols = w_row.Length;
            //  axfpHeaderData.MaxRows = numRows + 1;
            axfpHeaderData.RowsFrozen = 2;
            axfpHeaderData.MaxCols = w_row.Length - 1;
            axfpHeaderData.ScrollBars = FPSpreadADO.ScrollBarsConstants.ScrollBarsVertical;
            //axfpHeaderData.ScrollBarWidth = 50;
            axfpHeaderData.ScrollBars = FPSpreadADO.ScrollBarsConstants.ScrollBarsNone;
            axfpHeaderData.ActiveCellHighlightStyle = FPSpreadADO.ActiveCellHighlightStyleConstants.ActiveCellHighlightStyleOff;
            axfpHeaderData.DisplayRowHeaders = false;
            axfpHeaderData.DisplayColHeaders = false;
            axfpHeaderData.set_RowHeight(0, 0);
            axfpHeaderData.set_RowHeight(1, h_row);
            axfpHeaderData.set_RowHeight(0, h_row);
            axfpHeaderData.Font = new System.Drawing.Font("Calibri", 22.25F);

            axfpHeaderData.Col = col_head2;
            axfpHeaderData.Row = 1;
            axfpHeaderData.BackColor = Color.Blue;
            axfpHeaderData.Col = col_head2;
            axfpHeaderData.Row = 2;
            axfpHeaderData.BackColor = Color.Blue;


            axfpHeaderData.AddCellSpan(1, 1, col_head2 - 1, 1);

            axfpHeaderData.AddCellSpan(col_head2 + 1, 1, col_head2, 1);
            for (int i = 1; i < col_head2; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    axfpHeaderData.Col = i;
                    axfpHeaderData.Row = j;
                    if (j == 1)
                    {
                        axfpHeaderData.BackColor = back;
                        axfpHeaderData.ForeColor = fore;
                        axfpHeaderData.Text = text1[0];

                    }
                    else
                    {
                        axfpHeaderData.BackColor = back;
                        axfpHeaderData.ForeColor = fore;
                    }
                }

            }
            for (int i = col_head2 + 1; i < w_row.Length; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    axfpHeaderData.Col = i;
                    axfpHeaderData.Row = j;
                    if (j == 1)
                    {
                        axfpHeaderData.BackColor = back1;
                        axfpHeaderData.ForeColor = fore1;
                        axfpHeaderData.Text = text1[1];

                    }
                    else
                    {
                        axfpHeaderData.BackColor = back1;
                        axfpHeaderData.ForeColor = fore1;
                    }
                }
            }

            for (int i = 1; i <= 2; i++)
            {
                axfpHeaderData.Col = -1;
                axfpHeaderData.Row = i;
                axfpHeaderData.Font = new System.Drawing.Font("Calibri", 28.25F, FontStyle.Bold);
                axfpHeaderData.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
                axfpHeaderData.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
            }

            axfpHeaderData.TypeEditMultiLine = true;
            axfpHeaderData.SetCellBorder(1, 1, w_row.Length - 1, 1, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexRight, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            axfpHeaderData.SetCellBorder(1, 1, w_row.Length - 1, 1, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            axfpHeaderData.SetCellBorder(1, 2, w_row.Length - 1, 2, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexRight, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);



            for (int i = 0; i < w_row.Length; i++)
            {
                axfpHeaderData.set_ColWidth(i, w_row[i]);
                axfpHeaderData.SetText(i, 2, text[i]);
            }
        }

        private void Display_Clean_Status(DataTable arg_dt)
        {
            int Iclean = 0;
            int Icoating = 0;
            int irow = 3;
            int maxrow = 0;
            int Iclean_TT = 0;
            int Icoating_TT = 0;
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                if (arg_dt.Rows[i]["TYPE_CD"].ToString() == "1")
                {
                    Add_data_clean(1, irow, arg_dt.Rows[i]["MOLD_CD"].ToString(), "C");
                    Add_data_clean(2, irow, arg_dt.Rows[i]["MODEL_NM"].ToString(), "L");
                    Add_data_clean(3, irow, arg_dt.Rows[i]["CS_SIZE"].ToString(), "C");
                    Add_data_clean(4, irow, arg_dt.Rows[i]["SEQ"].ToString(), "C");
                    Add_data_clean(5, irow, arg_dt.Rows[i]["STATUS"].ToString(), "C");

                    Add_color_clean(5, irow, arg_dt.Rows[i]["STATUS"].ToString(), arg_dt.Rows[0]["FN"].ToString(), ref Iclean);

                    if (arg_dt.Rows[i]["TYPE_CD"].ToString() == arg_dt.Rows[i + 1]["TYPE_CD"].ToString())
                        irow++;
                    else
                    {
                        maxrow = irow;
                        irow = 3;
                    }
                    Iclean_TT++;
                }
                else
                {
                    Add_data_clean(7, irow, arg_dt.Rows[i]["MOLD_CD"].ToString(), "C");

                    Add_data_clean(8, irow, arg_dt.Rows[i]["MODEL_NM"].ToString(), "L");

                    Add_data_clean(9, irow, arg_dt.Rows[i]["CS_SIZE"].ToString(), "C");
                    Add_data_clean(10, irow, arg_dt.Rows[i]["SEQ"].ToString(), "C");
                    Add_data_clean(11, irow, arg_dt.Rows[i]["STATUS"].ToString(), "C");

                    Add_color_clean(11, irow, arg_dt.Rows[i]["STATUS"].ToString(), arg_dt.Rows[0]["FN"].ToString(), ref Icoating);
                    irow++;
                    Icoating_TT++;
                }

                axfpHeaderData.Col = 6;
                axfpHeaderData.Row = irow;
                axfpHeaderData.BackColor = Color.Blue;

            }



            axfpHeaderData.MaxRows = maxrow >= irow - 1 ? maxrow : irow - 1;



        }

        private void Add_data_clean(int arg_col, int arg_row, string arg_text, string arg_align)
        {

            axfpHeaderData.Col = arg_col;
            axfpHeaderData.Row = arg_row;
            if (arg_align == "L")
                axfpHeaderData.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignLeft;
            else if (arg_align == "C")
                axfpHeaderData.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
            else
                axfpHeaderData.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignRight;

            axfpHeaderData.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
            axfpHeaderData.Text = arg_text;
        }

        private void Add_color_clean(int arg_col, int arg_row, string arg_status, string arg_status_dk, ref int arg_qty)
        {

            axfpHeaderData.Col = arg_col;
            axfpHeaderData.Row = arg_row;
            if (arg_status == arg_status_dk)
            {
                axfpHeaderData.BackColor = Color.Green;
                axfpHeaderData.ForeColor = Color.White;
                arg_qty++;
            }
            else
            {
                axfpHeaderData.BackColor = Color.White;
                axfpHeaderData.ForeColor = Color.Black;
            }
        }


        #endregion Grid_Daily_mold_cleaning_status

        private Color GetStatusColor(double quantity)
        {
            double min = 1.3d;
            double max = 1.6d;
            double std = 800.0d;
            if (quantity >= std * max)
            {
                countedBlack++;
                return Color.FromArgb(64, 64, 64);
            }

            if (quantity >= std * min && quantity < std * max)
            {
                countedRed++;
                return Color.Red;
            }

            if (quantity >= std && quantity < std * min)
            {
                countedYellow++;
                return Color.Yellow;
            }

            return Color.White;
        }

        private void LoadDataToGrid(DataTable source, Color filter)
        {

            // InitGrid(source);

            numRows = source.Rows.Count;
            Init_Grid_Clean();

            //show chart data
            int index = 2;
            for (int i = 0; i < source.Rows.Count; i++)
            {
                Color force = GetStatusColor(Convert.ToDouble(source.Rows[i][4].ToString()));
                for (int j = 0; j < 7; j++)
                {
                    if (j == 4 || j == 5 || j == 6)
                    {
                        axfpHeaderData.Col = j + 1;
                        axfpHeaderData.Row = i + 2;
                        axfpHeaderData.CellType = FPSpreadADO.CellTypeConstants.CellTypeStaticText;
                        axfpHeaderData.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignRight;
                        axfpHeaderData.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;

                    }
                    else if (j == 0 || j == 2 || j == 3)
                    {
                        axfpHeaderData.Col = j + 1;
                        axfpHeaderData.Row = i + 2;
                        axfpHeaderData.CellType = FPSpreadADO.CellTypeConstants.CellTypeStaticText;
                        axfpHeaderData.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
                        axfpHeaderData.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
                    }


                    if (filter == Color.Transparent)
                    {
                        if (j == 4 || j == 5 || j == 6)
                        {

                            axfpHeaderData.SetText(j + 1, i + 2, Convert.ToDouble(source.Rows[i][j].ToString()).ToString("#,###,###"));
                        }
                        else
                        {
                            axfpHeaderData.SetText(j + 1, i + 2, source.Rows[i][j].ToString());
                        }
                        if (j == 4)
                        {

                            axfpHeaderData.Row = i + 2;
                            axfpHeaderData.Col = j + 3;
                            axfpHeaderData.BackColor = force;
                            axfpHeaderData.ForeColor = force == Color.FromArgb(64, 64, 64) ? Color.White : Color.Black;
                        }
                    }
                    else if (force == filter)
                    {
                        if (j == 4 || j == 5 || j == 5)
                        {

                            axfpHeaderData.SetText(j + 1, index, Convert.ToDouble(source.Rows[i][j].ToString()).ToString("#,###,###"));
                        }
                        else
                        {
                            axfpHeaderData.SetText(j + 1, index, source.Rows[i][j].ToString());
                        }
                        if (j == 4)
                        {
                            axfpHeaderData.Row = index;
                            axfpHeaderData.Col = j + 3;
                            axfpHeaderData.BackColor = force;
                            axfpHeaderData.ForeColor = force == Color.FromArgb(64, 64, 64) ? Color.White : Color.Black;

                        }

                    }
                }
                if (force == filter)
                {
                    index++;
                }
            }
            if (filter == Color.Transparent)
            {
                axfpHeaderData.MaxRows = numRows + 1;
            }
            else
            {
                axfpHeaderData.MaxRows = index - 1;
            }



        }

        private void ShowData(Color color)
        {
            dtCleamingMold = LOAD_DATA();
            LoadDataToGrid(dtCleamingMold, _filter);
        }

        public void createChart(WinChartViewer viewer, string img, DataTable dataTable)
        {
            try
            {
                // The data for the bar chart
                int iRowNum = dataTable.Rows.Count / 3;
                double[] data0 = new double[iRowNum];
                double[] data1 = new double[iRowNum];
                double[] data2 = new double[iRowNum];

                // The labels for the bar chart
                string[] labels = new string[iRowNum];
                for (int i = 0; i < iRowNum; i++)
                {
                    data0[i] = Convert.ToDouble(dataTable.Rows[i * 3]["cnt"].ToString());
                    data1[i] = Convert.ToDouble(dataTable.Rows[i * 3 + 1]["cnt"].ToString());
                    data2[i] = Convert.ToDouble(dataTable.Rows[i * 3 + 2]["cnt"].ToString());
                    labels[i] = dataTable.Rows[i * 3]["err_name"].ToString();
                }

                // Create a XYChart object of size 500 x 320 pixels
                XYChart c = new XYChart(1900, 1000);
                // XYChart c = new XYChart(viewer.Width, viewer.Height );
                Chart.setLicenseCode("DEVP-2LSU-B4LX-YCTY-2DF2-77EE");

                // Set the plotarea at (100, 40) and of size 280 x 240 pixels
                // c.setPlotArea(140, 60, c.getWidth() - 250, c.getHeight() - 310);
                c.setPlotArea(100, 60, 1800, 600);
                // Add a legend box at (400, 100)
                c.addLegend(c.getWidth() - 90, 100);

                // Add a title to the chart using 14 points Times Bold Itatic font
                //  c.addTitle("MOLD CLEANING REPORT", "Calibri Bold", 30);


                c.yAxis().setLabelStyle("Times New Roman Bold", 15);
                // Set the labels on the x axis
                c.xAxis().setLabels(labels);

                c.setNumberFormat(',');


                BarLayer layer = c.addBarLayer2(Chart.Stack, 10);

                // Add the three data sets to the bar layer
                layer.setBarShape(Chart.CircleShape);
                layer.addDataSet(data0, 0x00FF21, "SHIFT A");
                layer.addDataSet(data1, 0xFF6A00, "SHIFT B");
                layer.addDataSet(data2, 0x004A08, "SHIFT C");


                layer.setAggregateLabelStyle("Times New Roman Bold", 15, 0xFF006E);


                layer.setDataLabelStyle("Times New Roman Bold", 15, 0x0026FF);


                CDMLTable table = c.xAxis().makeLabelTable();

                ChartDirector.TextBox cellStyle = table.getStyle();
                cellStyle.setMargin2(5, 5, 4, 1);
                cellStyle.setFontSize(10);


                ChartDirector.TextBox firstRowStyle = table.getRowStyle(0);
                firstRowStyle.setFontStyle("Calibri Bold", 20);
                firstRowStyle.setFontColor(0xFFFFFF);
                firstRowStyle.setBackground(0x00bfff, Chart.LineColor);
                firstRowStyle.setHeight(40);
                table.appendRow().setBackground(Chart.Transparent, Chart.LineColor);

                ChartDirector.TextBox secondRowStyle = table.getRowStyle(1);
                secondRowStyle.setHeight(50);
                secondRowStyle.setFontStyle("Arial Bold", 20);
                table.appendRow().setBackground(Chart.Transparent, Chart.LineColor);

                ChartDirector.TextBox thirdRowStyle = table.getRowStyle(2);
                thirdRowStyle.setHeight(50);
                thirdRowStyle.setFontStyle("Arial Bold", 14);
                table.appendRow().setBackground(Chart.Transparent, Chart.LineColor);

                ChartDirector.TextBox forthRowStyle = table.getRowStyle(3);
                forthRowStyle.setHeight(50);
                forthRowStyle.setFontStyle("Arial Bold", 14);
                table.appendRow().setBackground(0xFFD800, Chart.LineColor);

                ChartDirector.TextBox fifRowStyle = table.getRowStyle(4);
                fifRowStyle.setHeight(50);
                fifRowStyle.setFontStyle("Arial Bold", 14);
                table.appendRow();

                int cnt0 = 0;
                int cnt1 = 0;
                int cnt2 = 0;
                int cntTotal = 0;
                for (int i = 0; i < data0.Length; ++i)
                {
                    if (data0[i] != 0)
                    {
                        table.setText(i, 1, (data0[i]).ToString());
                        cnt0++;
                    }
                    if (data1[i] != 0)
                    {
                        table.setText(i, 2, (data1[i]).ToString());
                        cnt1++;
                    }
                    if (data2[i] != 0)
                    {
                        table.setText(i, 3, (data2[i]).ToString());
                        cnt2++;
                    }
                    if ((data0[i] + data1[i] + data2[i]) != 0)
                    {
                        table.setText(i, 4, (data0[i] + data1[i] + data2[i]).ToString());
                        cntTotal++;
                    }


                }


                table.insertCol(0);
                ChartDirector.TextBox firsCol = table.getColStyle(0);
                table.getCell(0, 0).setBackground(Chart.Transparent, Chart.Transparent);
                firsCol.setFontSize(13);
                table.setText(0, 1, layer.getLegendIcon(0) + "  SHIFT A");
                table.setText(0, 2, layer.getLegendIcon(1) + "  SHIFT B");
                table.setText(0, 3, layer.getLegendIcon(2) + "  SHIFT C");


                table.setText(0, 4, "TOTAL");

                table.appendCol().setBackground(0x00FFFF, Chart.LineColor);
                table.setText(table.getColCount() - 1, 0, "Avg");
                ChartDirector.TextBox lastCol = table.getColStyle(table.getColCount() - 1);
                lastCol.setWidth(70);
                lastCol.setFontColor(0x000000);

                lastCol.setFontSize(14);

                double total0 = new ArrayMath(data0).sum();
                double total1 = new ArrayMath(data1).sum();
                double total2 = new ArrayMath(data2).sum();
                double avg0 = 0;
                double avg1 = 0;
                double avg2 = 0;
                if (cnt0 != 0)
                {
                    avg0 = Math.Round(total0 / cnt0, 0);
                    table.setText(table.getColCount() - 1, 1, (avg0).ToString());

                }
                if (cnt1 != 0)
                {
                    avg1 = Math.Round(total1 / cnt1, 0);
                    table.setText(table.getColCount() - 1, 2, (avg1).ToString());

                }
                if (cnt2 != 0)
                {
                    avg2 = Math.Round(total2 / cnt2, 0);
                    table.setText(table.getColCount() - 1, 3, (avg2).ToString());

                }

                for (int i = 1; i < table.getColCount() - 2; i++)
                {
                    for (int j = 1; j < table.getRowCount() - 1; j++)
                    {
                        ChartDirector.TextBox cell = table.getCell(i, j);
                        cell.setFontStyle("Calibri Bold");
                        cell.setFontSize(14);
                        cell.setFontColor(0x0026FF);

                    }

                    table.getCell(i, table.getRowCount() - 2).setFontColor(0xFF006E);

                }




                // Output the chart
                viewer.Chart = c;

                //include tool tip for the chart
                viewer.ImageMap = c.getHTMLImageMap("clickable", "",
                    "title='{dataSetName} on {xLabel}: {value} MBytes/hour'");
            }
            catch
            {
                //   MessageBox.Show(ex.ToString());
            }
        }

        private void DisplayGrid(DataTable arg_dt)
        {
            //int avg;
            //int _row = 0;

            //int dt_row = arg_dt.Rows.Count;
            //DayOfMonth = Convert.ToInt32(arg_dt.Rows[0]["DAY_OF_MONTH"].ToString());
            //for (int i = 0; i < DayOfMonth; i++)
            //{
            //    axGrid.SetText(i + 3, 1, arg_dt.Rows[i]["DD"].ToString());
            //}
            //axGrid.SetText(DayOfMonth + 3, 1, "Total");

            //for (int irow = 0; irow < 9; irow++)
            //{
            //    avg = 0;
            //    for (int icol = 0; icol < DayOfMonth; icol++)
            //    {
            //        //  for (int i = 0 * DayOfMonth; i < (irow + 1) * DayOfMonth; i++)

            //        axGrid.SetText(icol + 3, irow + 2, arg_dt.Rows[_row]["QTY"].ToString() == "0" ? "" : arg_dt.Rows[_row]["QTY"].ToString());
            //        avg += arg_dt.Rows[_row]["QTY"].ToString() == "" ? 0 : Convert.ToInt32(arg_dt.Rows[_row]["QTY"].ToString());
            //        _row++;
            //    }
            //    axGrid.SetText(DayOfMonth + 3, irow + 2, avg == 0 ? "" : avg.ToString());
            //}
        }


        private void GetDataChart()
        {

            int d0 = 0;
            int d1 = 0;
            int d2 = 0;
            data0 = new double[DayOfMonth];
            data1 = new double[DayOfMonth];
            data2 = new double[DayOfMonth];
            labels = new string[DayOfMonth];

            for (int i = 0; i < _dt.Rows.Count; i++)
            {
                switch (_dt.Rows[i]["MC_CD"].ToString())
                {
                    case "110":
                        data0[d0] = _dt.Rows[i]["QTY"].ToString() == "" ? 0 : Convert.ToDouble(_dt.Rows[i]["QTY"].ToString());
                        d0++;
                        break;
                    case "210":
                        data1[d1] = _dt.Rows[i]["QTY"].ToString() == "" ? 0 : Convert.ToDouble(_dt.Rows[i]["QTY"].ToString());
                        d1++;
                        break;
                    case "300":
                        data2[d2] = _dt.Rows[i]["QTY"].ToString() == "" ? 0 : Convert.ToDouble(_dt.Rows[i]["QTY"].ToString());
                        d2++;
                        break;

                }
            }
            for (int i = 0; i < DayOfMonth; i++)
                labels[i] = _dt.Rows[i]["DD"].ToString();
        }

        public void createChart(WinChartViewer viewer, int per)
        {
            Chart.setLicenseCode("DEVP-2LSU-B4LX-YCTY-2DF2-77EE");


            double[] d0 = new double[DayOfMonth];
            double[] d1 = new double[DayOfMonth];
            double[] d2 = new double[DayOfMonth];
            // The data for the bar chart


            //double[] data0 = {50, 25, 56, 47, 87, 24, 78, 19, 40, 16, 19,
            //    22};
            //double[] data1 = {22, 56, 79, 21, 19, 17, 16, 22, 19, 18, 22,
            //    27};
            //double[] data2 = {67, 19, 21, 67, 50, 32, 21, 19, 45, 67, 40,
            //    31};
            //string[] labels = {"1", "2", "3", "4", "5", "6", "7",
            //    "8", "9", "10", "11", "12"};

            // Create a XYChart object of size 580 x 280 pixels
            XYChart c = new XYChart(1900, 500);

            // Add a title to the chart using 14 pts Arial Bold Italic font
            // c.addTitle("Mold Change Report", "Calibri Bold ", 25);

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

            //BarLayer layer0 = c.addBarLayer3(am0.mul(percentage / 100.0).result());
            //BarLayer layer1 = c.addBarLayer3(am1.mul(percentage / 100.0).result());
            //BarLayer layer2 = c.addBarLayer3(am0.mul(percentage / 100.0).result());



            layer.addDataSet(d0, 0xff8080, "1 Color");
            layer.addDataSet(d1, 0x008800, "2 Color");
            layer.addDataSet(d2, 0x8080ff, "Total");



            // Set 50% overlap between bars
            //  layer.setOverlapRatio(0.5);

            // Add a title to the y-axis
            //c.yAxis().setTitle("Revenue (USD in millions)");

            // Output the chart
            viewer.Chart = c;

            //include tool tip for the chart
            viewer.ImageMap = c.getHTMLImageMap("clickable", "",
                "title='Day:{xLabel} - {value} prs'");
        }

        private void SetGrid()
        {
            //axGrid.Row = 1;
            //axGrid.BackColor = Color.DeepSkyBlue;
            //axGrid.ForeColor = Color.White;
            //axGrid.Row = 5;
            //axGrid.BackColor = Color.Salmon;
            //axGrid.ForeColor = Color.White;


            //axGrid.Row = 9;
            //axGrid.BackColor = Color.ForestGreen;
            //axGrid.ForeColor = Color.White;
            //axGrid.Row = 10;
            //axGrid.BackColor = Color.SlateBlue;
            //axGrid.ForeColor = Color.White;


            //axGrid.Col = DayOfMonth + 3;
            //axGrid.SetCellBorder(DayOfMonth + 3, 1, DayOfMonth + 3, 10, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);

            //for (int i = 2; i <= 10; i++)
            //{
            //    axGrid.Row = i;
            //    axGrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber;
            //    axGrid.TypeNumberDecPlaces = 0;
            //    axGrid.TypeNumberShowSep = true;
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    axGrid.Row = i;
            //    axGrid.BackColor = Color.Gray;
            //    axGrid.ForeColor = Color.White;
            //}
            //axGrid.MaxCols = DayOfMonth + 3;
            //switch (DayOfMonth)
            //{
            //    case 27:
            //        axGrid.set_ColWidth(2, 15);
            //        axGrid.set_ColWidth(DayOfMonth + 2, 7.25);
            //        axGrid.set_ColWidth(DayOfMonth + 3, 9.20);
            //        break;
            //    case 26:
            //        axGrid.set_ColWidth(1, 18);
            //        axGrid.set_ColWidth(2, 16);
            //        axGrid.set_ColWidth(DayOfMonth + 3, 9.20);
            //        break;
            //    case 20:
            //        axGrid.set_ColWidth(1, 16);
            //        axGrid.set_ColWidth(2, 17);
            //        axGrid.set_ColWidth(DayOfMonth + 3, 9.20);
            //        break;
            //    case 28:
            //        break;
            //}
        }

        private bool checkWindowOpen(string windowName)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name.Equals(windowName))
                {

                    Application.OpenForms[i].Show();

                    return false;
                }
            }
            return true;
        }

        

        private void pre_form()
        {

            //  Application.Run(new IPEX_Monitor.FORM_KNEADER_TEMPERATURE_STATUS());
        }
        private void next_form()
        {

            //  Application.Run(new IPEX_Monitor.FORM_IP_CHAMBER());
        }

        //private void prevform()
        //{

        //    Application.Run(new IPEX_Monitor.Frm_Mold_Show_TV());
        //}
       



        #endregion

        #region Function
        #region Chart
       
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


                c.setPieSize(450, viewer.Height/2, 150);

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

        private void GetDataForChart(DataTable source, ref string[] lablles, ref double[] values, ref int[] colors)
        {
            try
            {
                lablles = new string[source.Rows.Count];
                values = new double[source.Rows.Count];
                colors = new int[source.Rows.Count];
                for (int i = 0; i < source.Rows.Count; i++)
                {
                    if (viewMode == "WEEKLY")
                    {
                        lablles[i] = lablles[i] = source.Rows[i]["ERR_NAME"].ToString() + '/' + source.Rows[i]["ERR_NAME_EN"].ToString();
                    }
                    else if (viewMode == "MONTHLY")
                    {
                        lablles[i] = source.Rows[i]["ERR_NAME_EN"].ToString();
                    }
                    else
                    {
                        lablles[i] = source.Rows[i]["ERR_NAME"].ToString();
                    }
                    values[i] = Convert.ToDouble(source.Rows[i]["CNT"].ToString());
                    colors[i] = masterColor;
                }
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
        
        #endregion Chart

        private void LoadDataToGrid(DataTable source)
        {
            try
            {
                double col_size;
                numCols = source.Rows.Count;
                col_size = Math.Round(124.0 / numCols - 1, 2);
               // col_size = 20;
                axfpHeaderData.MaxRows = 3;
                axfpHeaderData.RowsFrozen = 3;
                axfpHeaderData.MaxCols = numCols;
                axfpHeaderData.ScrollBars = FPSpreadADO.ScrollBarsConstants.ScrollBarsNone;
                for (int i = 1; i <= numCols; i++)
                {
                    axfpHeaderData.set_ColWidth(i, col_size);
                }
                axfpHeaderData.ColHeadersShow = false;
                axfpHeaderData.RowHeadersShow = false;
                axfpHeaderData.set_RowHeight(1, 50);
                axfpHeaderData.set_RowHeight(2, 50);
                axfpHeaderData.set_RowHeight(3, 30);

                axfpHeaderData.Row = 1;
                axfpHeaderData.BackColor = Color.DeepSkyBlue;
                axfpHeaderData.ForeColor = Color.White;
                axfpHeaderData.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit;
                axfpHeaderData.TypeEditMultiLine = true;
                axfpHeaderData.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
                axfpHeaderData.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
                axfpHeaderData.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                axfpHeaderData.ActiveCellHighlightStyle = FPSpreadADO.ActiveCellHighlightStyleConstants.ActiveCellHighlightStyleOff;
                axfpHeaderData.BackColor = Color.Gray;
                axfpHeaderData.ForeColor = Color.White;

                axfpHeaderData.Row = 2;
                axfpHeaderData.BackColor = Color.DeepSkyBlue;
                axfpHeaderData.ForeColor = Color.White;
                axfpHeaderData.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit;
                axfpHeaderData.TypeEditMultiLine = true;
                axfpHeaderData.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
                axfpHeaderData.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
                axfpHeaderData.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                axfpHeaderData.ActiveCellHighlightStyle = FPSpreadADO.ActiveCellHighlightStyleConstants.ActiveCellHighlightStyleOff;
                axfpHeaderData.BackColor = Color.Gray;
                axfpHeaderData.ForeColor = Color.White;

                axfpHeaderData.SetCellBorder(1, 1, numCols, 2, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
                axfpHeaderData.SetCellBorder(1, 1, numCols, 2, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexRight, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
                axfpHeaderData.SetCellBorder(1, 1, numCols, 2, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexTop, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
                axfpHeaderData.SetCellBorder(1, 1, numCols, 2, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);

                axfpHeaderData.Row = 3;
                //axfpHeaderData.ForeColor = Color.Black;
                axfpHeaderData.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
                axfpHeaderData.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
                axfpHeaderData.Font = new System.Drawing.Font("Calibri", 20, FontStyle.Bold);
                axfpHeaderData.Height = 180;

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
                col_size = Math.Round(132.0 / numCols - 1, 2);
                axGridModel.MaxRows = numRows;
                axGridModel.RowsFrozen = numRows;
                axGridModel.ScrollBars = FPSpreadADO.ScrollBarsConstants.ScrollBarsNone;
                for (int i = 1; i <= numCols; i++)
                {
                    axGridModel.set_ColWidth(i, col_size);
                }
                axGridModel.ColHeadersShow = false;
                axGridModel.RowHeadersShow = false;
                axGridModel.set_RowHeight(1, 100);
                axGridModel.set_RowHeight(2, 30);
                axGridModel.Row = 1;
                axGridModel.BackColor = Color.DeepSkyBlue;
                axGridModel.ForeColor = Color.White;
                axGridModel.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit;
                axGridModel.TypeEditMultiLine = true;
                axGridModel.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
                axGridModel.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
                axGridModel.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                axGridModel.ActiveCellHighlightStyle = FPSpreadADO.ActiveCellHighlightStyleConstants.ActiveCellHighlightStyleOff;
                axGridModel.BackColor = Color.Gray;
                axGridModel.ForeColor = Color.White;

                axGridModel.SetCellBorder(1, 1, numCols, 1, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
                axGridModel.SetCellBorder(1, 1, numCols, 1, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexRight, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
                axGridModel.SetCellBorder(1, 1, numCols, 1, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexTop, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
                axGridModel.SetCellBorder(1, 1, numCols, 1, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);

                axGridModel.Row = 2;
                //axGridModel.ForeColor = Color.Black;
                axGridModel.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
                axGridModel.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
                axGridModel.Font = new System.Drawing.Font("Calibri", 20, FontStyle.Bold);
                axGridModel.Height = 180;

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

                axfpHeaderData.Reset();
                switch (_frm)
                {
                    case 1:
                       

                        //th = new Thread(pre_form);
                        //th.SetApartmentState(ApartmentState.STA);
                        //th.Start();
                        //this.Dispose();
                        //this.Close();
                        //Application.ExitThread();
                        break;
                    case 2:

                        lbl_header.Text = "MOLD REPAIR TYPE";
                        viewMode = "DAILY";
                        //pn_header_clean.Visible = false;
                        chartErrorCounter.Visible = true;
                        axfpHeaderData.Visible = true;
                        //   pn_mold_change.Visible = false;
                        //   pn_clean_status.Visible = false;
                        axfpHeaderData.Hide();
                        load_defective();
                        axfpHeaderData.MaxRows = 2;
                        axfpHeaderData.Dock = DockStyle.None;
                        chartErrorCounter.Dock = DockStyle.None;
                        //    pn_mold_change.Location = new Point(5, 5);
                        
                        //    pn_clean_status2.Visible = false;
                        axfpHeaderData.Height = 140;

                       // Smart_FTY.ClassLib.WinAPI.AnimateWindow(this.axfpHeaderData.Handle, 1000, Smart_FTY.ClassLib.WinAPI.getSlidType("4"));
                        axfpHeaderData.Show();
                        break;
                    case 3:

                        lbl_header.Text = "Weekly Mold Repair By DMC && DMP" ;
                        viewMode = "WEEKLY";
                        axfpHeaderData.Hide();
                        ////  pn_header_clean.Visible = false;
                        ////axfpHeaderData.Visible = true;
                        ////axfpHeaderData.Dock = DockStyle.None;
                        ////axfpHeaderData.MaxRows = 2;
                        ////chartErrorCounter.Visible = true;
                        ////chartErrorCounter.Dock = DockStyle.None;
                        ////  pn_mold_change.Location = new Point(5, 5);
                        _dt_model = LOAD_MOLD_RP_W();
                        _dt_style = LOAD_MOLD_RP_STYLE();
                        //// pn_mold_change.Visible = false;
                        ////  pn_clean_status.Visible = false;
                        ////pn_clean_status2.Visible = false;
                        
                        axGridModel.Hide();
                        dt_top = LOAD_TOP15(viewMode);
                        LoadDataToGrid(dt_top);
                        LoadDataToGridModel(_dt_model);
                        percentage = 0;

                        this.chartErrorCounter.Hide();
                        createChartWeekly(this.chartErrorCounter, dt_top, percentage += 5);
                       // IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.chartErrorCounter.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("4"));
                        this.chartErrorCounter.Show();

                        timer2.Start();
                        //tmr_style.Start();
                        //IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.axfpHeaderData.Handle, 1000, IPEX_Monitor.ClassLib.WinAPI.getSlidType("4"));
                        axfpHeaderData.Show();

                       // IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.axGridModel.Handle, 1000, IPEX_Monitor.ClassLib.WinAPI.getSlidType("4"));
                        axGridModel.Show();
                        break;
                    case 4:

                        lbl_header.Text = "MOLD REPAIR TYPE";
                        viewMode = "MONTHLY";

                        //  axfpHeaderData.Hide();
                        axfpHeaderData.MaxRows = 2;
                        //   pn_header_clean.Visible = false;
                        axfpHeaderData.Visible = true;
                        //  pn_mold_change.Visible = false;
                        axfpHeaderData.Dock = DockStyle.None;
                        chartErrorCounter.Visible = true;
                        chartErrorCounter.Dock = DockStyle.None;
                        //  pn_mold_change.Location = new Point(5, 5);

                        //    pn_clean_status.Visible = false;
                        //    pn_clean_status2.Visible = false;


                        axfpHeaderData.Reset();
                        load_defective();
                        axfpHeaderData.Location = new Point(3, 783);

                      //  Smart_FTY.ClassLib.WinAPI.AnimateWindow(this.axfpHeaderData.Handle, 1000, Smart_FTY.ClassLib.WinAPI.getSlidType("4"));
                        axfpHeaderData.Show();
                        break;
                    case 5:

                        lbl_header.Text = "MOLD CLEANING CYCLE";
                        //   pn_header_clean.Visible = true;
                        chartErrorCounter.Visible = false;
                        //   pn_mold_change.Visible = false;
                        axfpHeaderData.Dock = DockStyle.Fill;
                        axfpHeaderData.Location = new Point(3, 3);
                        //   pn_clean_status.Visible = false;
                        //   pn_clean_status2.Visible = false;
                        //   pn_mold_change.Location = new Point(5, 500);
                        axfpHeaderData.Height = 950;
                        axfpHeaderData.Hide();
                        ShowData(_filter);
                        //Smart_FTY.ClassLib.WinAPI.AnimateWindow(this.axfpHeaderData.Handle, 1000, Smart_FTY.ClassLib.WinAPI.getSlidType("3"));
                        axfpHeaderData.Show();
                        break;
                    case 6:

                        lbl_header.Text = "DAILY MOLD CLEANING/COATING";
                        lbl_header.Font = new System.Drawing.Font("Calibri", 64.25F, FontStyle.Bold);
                        //pn_header_clean.Visible = false;
                        chartErrorCounter.Visible = false;

                        //  pn_mold_change.Visible = false;
                        axfpHeaderData.Dock = DockStyle.Fill;
                        axfpHeaderData.Location = new Point(3, 3);
                        axfpHeaderData.Hide();

                        Init_Grid_Daily_Clean_Status();
                        Display_Clean_Status(SELECT_MOLD_CLEAN_STATUS());
                        // pn_clean_status.Visible = true;
                        // pn_clean_status2.Visible = true;
                        // pn_mold_change.Location = new Point(5, 500);
                        axfpHeaderData.Height = 950;


                        // ShowData(_filter);
                       // Smart_FTY.ClassLib.WinAPI.AnimateWindow(this.axfpHeaderData.Handle, 1000, Smart_FTY.ClassLib.WinAPI.getSlidType("3"));
                        axfpHeaderData.Show();
                        break;
                    //lbl_header.Text = "MOLD CLEANING CYCLE";
                    //break;

                    case 7:
                        lbl_header.Text = " MOLD CLEANING";
                        //pn_header_clean.Visible = false;
                        //   pn_mold_change.Visible = false;
                        DataTable dt = MOLD_CLEANING_REPORT();
                        chartErrorCounter.Visible = true;
                        axfpHeaderData.Visible = false;
                        chartErrorCounter.Dock = DockStyle.Fill;
                        createChart(chartErrorCounter, null, dt);
                        axfpHeaderData.Location = new Point(3, 3);
                        //   pn_clean_status.Visible = false;
                        //   pn_clean_status2.Visible = false;
                        //    pn_mold_change.Location = new Point(5, 500);
                        chartErrorCounter.Hide();
                        //Smart_FTY.ClassLib.WinAPI.AnimateWindow(this.chartErrorCounter.Handle, 1000, Smart_FTY.ClassLib.WinAPI.getSlidType("4"));
                        chartErrorCounter.Show();
                        break;
                    case 8:
                        percentage = 0;
                        lbl_header.Text = "MOLD CHANGE";
                        axfpHeaderData.Location = new Point(3, 3);
                        chartErrorCounter.Dock = DockStyle.None;
                        axfpHeaderData.Visible = false;
                        //  pn_mold_change.Location = new Point(5, 500);
                        //   pn_header_clean.Visible = false;
                        //pn_clean_status.Visible = false;
                        //  pn_clean_status2.Visible = false;
                        _dt = SELECT_MOLD_CHANGE();
                        DisplayGrid(_dt);
                        SetGrid();
                        GetDataChart();
                        //   pn_mold_change.Visible = true;
                        timer2.Start();
                        //this.Close();
                        // axGrid.Size = new Size(1909, 385);
                        break;
                    case 9:

                        //if (checkWindowOpen("FORM_IP_CHAMBER"))
                        //{
                        //    FORM_IP_CHAMBER frm = new FORM_IP_CHAMBER();
                        //    frm.Show();
                        //    this.Hide();
                        //}
                        //else
                        //{
                        //    this.Hide();
                        //}

                        //th = new Thread(next_form);
                        //th.SetApartmentState(ApartmentState.STA);
                        //th.Start();
                        //this.Dispose();
                        //this.Close();
                        //Application.ExitThread();
                        break;

                }
                // axfpHeaderData.SetActiveCell(0, 0);
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
            dt_top = LOAD_TOP15(viewMode);
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
        private DataTable LOAD_TOP15(string argMode)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;
            try
            {
                string process_name = "SEPHIROTH.pkg_DMC.MOLD_DEFECTIVE";
                //ARGMODE
                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;
                MyOraDB.Parameter_Name[0] = "ARGMODE";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (char)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = argMode;
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

        private DataTable LOAD_MOLD_RP_W()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;
            try
            {
                string process_name = "SEPHIROTH.PKG_DMC.SELECT_MOLD_REPAIR_W";
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

        private DataTable LOAD_MOLD_RP_STYLE()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;
            try
            {
                string process_name = "SEPHIROTH.PKG_IPEX3.SELECT_MOLD_REPAIR_STYLE";
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

        private DataTable LOAD_ERR_DETAIl(string argErrName, string mode)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;
            try
            {
                string process_name = "SEPHIROTH.pkg_sdt_mold_touch.MOLD_DEFECTIVE_DETAIL";
                //ARGMODE
                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;
                MyOraDB.Parameter_Name[0] = "ARG_MODE";
                MyOraDB.Parameter_Type[0] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Values[0] = mode;

                MyOraDB.Parameter_Name[1] = "ARG_ERR_NAME";
                MyOraDB.Parameter_Type[1] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Values[1] = argErrName;

                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
                MyOraDB.Parameter_Type[2] = (char)OracleType.Cursor;
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

        private DataTable LOAD_DATA()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;
            try
            {
                string process_name = "SEPHIROTH.pkg_sdt_mold_touch.MOLD_CLEANING_CYCLE_LOAD_v2";
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


        private DataTable MOLD_CLEANING_REPORT()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;
            try
            {
                string process_name = "SEPHIROTH.pkg_sdt_mold_touch.MOLD_CLEANING_REPORT";
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

        public DataTable SELECT_MOLD_CHANGE()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

            try
            {
                string process_name = "PKG_SPB_MOLD_WMS.SEL_MOLD_CHANGE";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

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

        public DataTable SELECT_MOLD_CLEAN_STATUS()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

            try
            {
                string process_name = "PKG_SPB_MOLD_WMS.SEL_MOLD_CLEAN_STATUS";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

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

        #endregion DB

        #region Event
        private void Frm_Mold_Show_TV_Load(object sender, EventArgs e)
        {
            try
            {
                // lbl_header.Text = "MOLD DEFECTIVE TYPE";
                //  pn_defective.Size = new Size(1913, 968);
                // pn_clean.Size = new Size(1912, 971);

                // axGrid.Size = new Size(1909, 385);
                icount++;

                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + "\n\r" + string.Format(DateTime.Now.ToString("HH:mm:ss"));

                // load_defective();
              //  axfpHeaderData.Location = new Point(3, 770);
                //axGridModel.Location = new Point(924, 750);
                axfpHeaderData.Width = 896;
                //axfpHeaderData.Height = 225;
                //axGridModel.Height = 200; 983
                GoFullscreen(true);
                //pn_header_clean.Visible = false;
               // pn_mold_change.Visible = false;
                _frm = 3;

                //if (icount == 20)
                //{
                //    load_frm();
                //    icount = 0;
                //}

              //  load_frm();

              //  timer1.Start();

            }
            catch
            {
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (_frm == 8)
                {
                    createChart(chartErrorCounter, percentage += 5);
                }
                else if (viewMode == "WEEKLY")
                {
                    createChartModel(chartModel, _dt_model, percentage += 5);
                }
                else
                {                   
                    LoadDataToChart(this.chartErrorCounter, dt_top, percentage += 5);
                }
                if (percentage >= 100)
                    timer2.Stop();
            }
            catch (Exception)
            {

                //   throw;
            }

        }

        private void tmr_style_Tick(object sender, EventArgs e)
        {
            createChartStyle(chartStyle, _dt_style, per);
            if (per >= 100)
                tmr_style.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + "\n\r" + string.Format(DateTime.Now.ToString("HH:mm:ss"));
                //_time_change++;
                //if (_time_change >= 45)
                //{                  
                //    _time_change = 0;
                //    load_frm();
                //}
            }
            catch
            {
            }
        }

        private void Frm_Mold_Show_TV_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion Event

        private void Frm_Mold_Show_TV_Activated(object sender, EventArgs e)
        {
            //GoFullscreen(true);
            //pn_header_clean.Visible = false;
            //pn_mold_change.Visible = false;
            //_frm = Com_Base.Variables.frm_show;

            //load_frm();
            //if (Com_Base.Variables._iskeypress)
            //    tmr_change_form.Interval = Com_Base.Variables._time_keypress;
            //else
            //    tmr_change_form.Interval = Com_Base.Variables._time_auto;
            //tmr_change_form.Start();


        }



        private void tmr_change_form_Tick(object sender, EventArgs e)
        {
            //_frm++;
            //if (_frm == 5) _frm++;
            //if (_frm > max_frm) _frm = 1;
            //load_frm();
            //Com_Base.Variables._iskeypress = false;
        }

        private void FORM_MOLD_REPAIR_WEEKLY_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                timer1.Start();
                load_frm();
            }
            else
            {
                //timer1.Stop();
                //timer2.Stop();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        

        

        
        
    }
}
