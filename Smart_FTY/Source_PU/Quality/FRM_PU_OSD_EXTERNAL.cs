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
    public partial class FRM_PU_OSD_EXTERNAL : Form
    {
        //System.Drawing.Color _lineColor = System.Drawing.Color.Blue;
        //System.Drawing.Pen _myPen = new System.Drawing.Pen(System.Drawing.Color.Blue);
        //int _wlr = 6;
        //int _wn = 3;
        DataTable _dt_grid = null;
        DataTable _dt_week = null;
        DataTable _dt_avg = null;
        int _cnt = 0;
        int icount = 0;
        int ichart = 0;
        double[] data_w1;
        double[] data_w2;
        double[] data_w3;
        double[] data_w4;
        string[] label_w1;
        string[] label_w2;
        string[] label_w3;
        string[] label_w4;
        double[] data0 = new double[24];
        double[] data1 = new double[24];
        double[] data2 = new double[24];
        double[] data3 = new double[24];
        string[] labels = new string[24];
        string _txtTit1 = "1st ";
        string _txtTit2 = "2nd ";
        string _txtTit3 = "3rd ";
        string _txtTit4 = "4th ";
        double _max_chart =0;

        public FRM_PU_OSD_EXTERNAL()
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


        private void Cal_max()
        {
            for (int i = 0; i < _dt_grid.Rows.Count; i++)
            {
                if (Convert.ToDouble(_dt_grid.Rows[i]["ORD"].ToString()) <13)
                {
                    if (_max_chart <Convert.ToDouble(_dt_grid.Rows[i]["F1"].ToString()))
                        _max_chart = Convert.ToDouble(_dt_grid.Rows[i]["F1"].ToString());
                    if (_max_chart < Convert.ToDouble(_dt_grid.Rows[i]["F2"].ToString()))
                        _max_chart = Convert.ToDouble(_dt_grid.Rows[i]["F2"].ToString());
                    if (_max_chart < Convert.ToDouble(_dt_grid.Rows[i]["F3"].ToString()))
                        _max_chart = Convert.ToDouble(_dt_grid.Rows[i]["F3"].ToString());
                    if (_max_chart < Convert.ToDouble(_dt_grid.Rows[i]["F4"].ToString()))
                        _max_chart = Convert.ToDouble(_dt_grid.Rows[i]["F4"].ToString());
               }
            }

           // _max_chart += 50;
        }



        private void data_chart_daily()
        {
            int idate;
            //double[] data0 = { 185, 176, 135, 144,99, 120, 175, 128, 175, 142, 172, 120, 175, 123, 120, 185, 145, 185, 152, 142, 156, 156, 175, 185, 175, 148, 142 };
            //double[] data1 = { 145, 153, 123, 175, 120, 105, 142, 147, 145, 184, 124, 132, 102, 125, 165, 156, 125, 156, 125, 143, 142, 148, 129, 145, 169, 136, 187 };
            //double[] data2 = { 135, 120, 145, 126, 100, 145, 120, 120, 156, 129, 168, 185, 165, 135, 158, 125, 126, 125, 163, 165, 132, 143, 138, 136, 185, 159, 144 };
            //double[] data3 = { 150, 110, 187, 173, 85, 100, 135, 156, 155, 120, 127, 122, 125, 145, 134, 185, 132, 185, 128, 123, 185, 129, 136, 162, 125, 189, 165 };
            if (_dt_grid != null && _dt_grid.Rows.Count > 0)
            {
                idate = _dt_grid.Rows.Count;

                _txtTit1 = "1st (" + _dt_grid.Rows[0]["DD"].ToString().Replace("  ", " - ") + " To "
                                    + _dt_grid.Rows[5]["DD"].ToString().Replace("  ", " - ") + ") AVG: " + _dt_avg.Rows[0]["avg_w1"].ToString();

                _txtTit2 = "2nd (" + _dt_grid.Rows[6]["DD"].ToString().Replace("  ", " - ") + " To "
                                    + _dt_grid.Rows[12]["DD"].ToString().Replace("  ", " - ") + ") AVG: " + _dt_avg.Rows[0]["avg_w2"].ToString();

                _txtTit3 = "3rd (" + _dt_grid.Rows[13]["DD"].ToString().Replace("  ", " - ") + " To "
                                    + _dt_grid.Rows[17]["DD"].ToString().Replace("  ", " - ") + ") AVG: " + _dt_avg.Rows[0]["avg_w3"].ToString();

                _txtTit4 = "4th (" + _dt_grid.Rows[18]["DD"].ToString().Replace("  ", " - ") + " To "
                                    + _dt_grid.Rows[23]["DD"].ToString().Replace("  ", " - ") + ") AVG: " + _dt_avg.Rows[0]["avg_w4"].ToString();

                lbl_avg_month.Text = _dt_avg.Rows[0]["avg_month"].ToString();

                 for (int i = 0; i < 24; i++)
                {
                    data0[i] = Chart.NoValue;
                    data1[i] = Chart.NoValue;
                    data2[i] = Chart.NoValue;
                    data3[i] = Chart.NoValue;
                    labels[i] = _dt_grid.Rows[i]["DD"].ToString().Replace("  ","\n");

                }

                for (int i = 0; i < ichart; i++)
                {
                    data0[i] = Convert.ToDouble(_dt_grid.Rows[i]["F1"].ToString());
                    data1[i] = Convert.ToDouble(_dt_grid.Rows[i]["F2"].ToString());
                    data2[i] = Convert.ToDouble(_dt_grid.Rows[i]["F3"].ToString());
                    data3[i] = Convert.ToDouble(_dt_grid.Rows[i]["F4"].ToString());
                    
                }

                
            }
            else return;
            ichart++;
            if (ichart > 24)
            {
                ichart = 0;
                timer_daily_chart.Stop();
            }
        }



        public void createChart1(WinChartViewer viewer, string img)
        {
            // The data for the chart
            Chart.setLicenseCode("DEVP-2LSU-B4LX-YCTY-2DF2-77EE");
            double[] data = data_w1;

            // The labels for the chart
            string[] labels = label_w1;

            // In the pareto chart, the line data are just the accumulation of the
            // raw data, scaled to a range of 0 - 100%
            ArrayMath lineData = new ArrayMath(data);
            lineData.acc();
            double scaleFactor = lineData.max() / 100;
            if (scaleFactor == 0)
            {
                // Avoid division by zero error for zero data
                scaleFactor = 1;
            }
            lineData.div2(scaleFactor);

            // Create a XYChart object of size 480 x 300 pixels. Set background color
            // to brushed silver, with a grey (bbbbbb) border and 2 pixel 3D raised
            // effect. Use rounded corners. Enable soft drop shadow.
            // XYChart c = new XYChart(400, 300, Chart.brushedSilverColor(), 0xbbbbbb, 2);
            XYChart c = new XYChart(viewer.Width, viewer.Height);
            c.setBorder(10);
            // c.setRoundedFrame();
            // c.setDropShadow();

            // Add a title to the chart using 15 points Arial Italic. Set top/bottom
            // margins to 12 pixels.

            ChartDirector.TextBox title = c.addTitle(Chart.Top, _txtTit1,
                "Arial Bold", 12, 0xffffff, 0x1c86ee);
            title.setMargin2(10, 10, 6, 12);
            title.setPos(10, 3);
            title.setSize(viewer.Width - 20, 30);

            // Tentatively set the plotarea at (50, 40). Set the width to 100 pixels
            // less than the chart width, and the height to 80 pixels less than the
            // chart height. Use pale grey (f4f4f4) background, transparent border,
            // and dark grey (444444) dotted grid lines.
            //c.setPlotArea(50, 40, c.getWidth() - 100, c.getHeight() - 80, 0xf4f4f4,
            //    -1, Chart.Transparent, c.dashLineColor(0x444444, Chart.DotLine));
            c.setPlotArea(50, 50, c.getWidth() - 110, c.getHeight() - 250, 0xf4f4f4,
                -1, Chart.Transparent, c.dashLineColor(0xffffff, Chart.Transparent));

            // Add a line layer for the pareto line
            LineLayer lineLayer = c.addLineLayer2();

            // Add the pareto line using deep blue (0000ff) as the color, with circle
            // symbols
            ArrayMath li = new ArrayMath(lineData.result());
            ArrayMath am = new ArrayMath(data);

            //lineLayer.addDataSet(li.mul(_cnt / 100.0).result(), 0x0000ff).setDataSymbol(
            //    Chart.CircleShape, 9, 0x0000ff, 0x0000ff);
            lineLayer.addDataSet(lineData.result(), 0x0000ff).setDataSymbol(
                Chart.CircleShape, 9, 0x0000ff, 0x0000ff);

            // Set the line width to 2 pixel
            lineLayer.setLineWidth(2);

            // Bind the line layer to the secondary (right) y-axis.
            lineLayer.setUseYAxis2();

            // Tool tip for the line layer
            lineLayer.setHTMLImageMap("", "",
                "title='Top {={x}+1} items: {value|2}%'");

            // Add a multi-color bar layer using the given data.
           // BarLayer barLayer = c.addBarLayer(am.mul(_cnt / 100.0).result(), 0xfc83c7);
            BarLayer barLayer = c.addBarLayer(data, 0xfc83c7);

            // Set soft lighting for the bars with light direction from the right
            barLayer.setBorderColor(Chart.Transparent, Chart.softLighting(Chart.Right
                ));


            c.xAxis().setLabelStyle("Arial Bold", 8).setFontAngle(70);
            c.yAxis().setLabelStyle("Arial Bold", 9);
            c.yAxis2().setLabelStyle("Arial Bold", 9);

            // Tool tip for the bar layer
            // barLayer.setHTMLImageMap("", "", "title='{xLabel}: {value} pieces'");

            // Set the labels on the x axis.
            c.xAxis().setLabels(labels);

            // Set the secondary (right) y-axis scale as 0 - 100 with a tick every 20
            // units
            c.yAxis2().setLinearScale(0, 100, 10);

            // Set the format of the secondary (right) y-axis label to include a
            // percentage sign
            c.yAxis2().setLabelFormat("{value}%");

            // Set the relationship between the two y-axes, which only differ by a
            // scaling factor
            c.yAxis().setLinearScale(0, 1600, 160);
           // c.yAxis().syncAxis(c.yAxis2(), scaleFactor);

            // Set the format of the primary y-axis label foramt to show no decimal
            // point
            c.yAxis().setLabelFormat("{value|0}");
            c.setNumberFormat(',');

            // Add a title to the primary y-axis
           // c.yAxis().setTitle("Frequency");

             

            // Set all axes to transparent
          //  c.xAxis().setColors(Chart.Transparent);
          //  c.yAxis().setColors(Chart.Transparent);
           // c.yAxis2().setColors(Chart.Transparent);

            // Adjust the plot area size, such that the bounding box (inclusive of
            // axes) is 10 pixels from the left edge, just below the title, 10 pixels
            // from the right edge, and 20 pixels from the bottom edge.
            //c.packPlotArea(10, title.getHeight(), c.getWidth() - 10, c.getHeight() -
            //    20);

            // Output the chart
            viewer.Chart = c;

            // Include tool tip for the chart
           // viewer.ImageMap = c.getHTMLImageMap("clickable");
        }

        public void createChart2(WinChartViewer viewer, string img)
        {
            // The data for the chart
            Chart.setLicenseCode("DEVP-2LSU-B4LX-YCTY-2DF2-77EE");
            double[] data = data_w2;

            // The labels for the chart
            string[] labels = label_w2;

            // In the pareto chart, the line data are just the accumulation of the
            // raw data, scaled to a range of 0 - 100%
            ArrayMath lineData = new ArrayMath(data);


            lineData.acc();
            double scaleFactor = lineData.max() / 100;
            if (scaleFactor == 0)
            {
                // Avoid division by zero error for zero data
                scaleFactor = 1;
            }
            lineData.div2(scaleFactor);

            // Create a XYChart object of size 480 x 300 pixels. Set background color
            // to brushed silver, with a grey (bbbbbb) border and 2 pixel 3D raised
            // effect. Use rounded corners. Enable soft drop shadow.
            // XYChart c = new XYChart(400, 300, Chart.brushedSilverColor(), 0xbbbbbb, 2);
            XYChart c = new XYChart(viewer.Width, viewer.Height);
            c.setBorder(10);
            // c.setRoundedFrame();
            // c.setDropShadow();

            // Add a title to the chart using 15 points Arial Italic. Set top/bottom
            // margins to 12 pixels.

            ChartDirector.TextBox title = c.addTitle(Chart.Top, _txtTit2,
                "Arial Bold", 12, 0xffffff, 0x1c86ee);
            title.setMargin2(10, 10, 6, 12);
            title.setPos(10, 3);
            title.setSize(viewer.Width - 20, 30);

            // Tentatively set the plotarea at (50, 40). Set the width to 100 pixels
            // less than the chart width, and the height to 80 pixels less than the
            // chart height. Use pale grey (f4f4f4) background, transparent border,
            // and dark grey (444444) dotted grid lines.
            //c.setPlotArea(50, 40, c.getWidth() - 100, c.getHeight() - 80, 0xf4f4f4,
            //    -1, Chart.Transparent, c.dashLineColor(0x444444, Chart.DotLine));
            c.setPlotArea(50, 50, c.getWidth() - 110, c.getHeight() - 250, 0xf4f4f4,
                -1, Chart.Transparent, c.dashLineColor(0xffffff, Chart.Transparent));

            // Add a line layer for the pareto line
            LineLayer lineLayer = c.addLineLayer2();

            // Add the pareto line using deep blue (0000ff) as the color, with circle
            // symbols
            ArrayMath li = new ArrayMath(lineData.result());
            ArrayMath am = new ArrayMath(data);

            //lineLayer.addDataSet(li.mul(_cnt / 100.0).result(), 0x0000ff).setDataSymbol(
            //    Chart.CircleShape, 9, 0x0000ff, 0x0000ff);

            lineLayer.addDataSet(lineData.result(), 0x0000ff).setDataSymbol(
               Chart.CircleShape, 9, 0x0000ff, 0x0000ff);

            // Set the line width to 2 pixel
            lineLayer.setLineWidth(2);

            // Bind the line layer to the secondary (right) y-axis.
            lineLayer.setUseYAxis2();

            // Tool tip for the line layer
            lineLayer.setHTMLImageMap("", "",
                "title='Top {={x}+1} items: {value|2}%'");

            // Add a multi-color bar layer using the given data.
            //BarLayer barLayer = c.addBarLayer(am.mul(_cnt / 100.0).result(), 0x2dff64);
            BarLayer barLayer = c.addBarLayer(data, 0x2dff64);

            // Set soft lighting for the bars with light direction from the right
            barLayer.setBorderColor(Chart.Transparent, Chart.softLighting(Chart.Right
                ));


            c.xAxis().setLabelStyle("Arial Bold", 8).setFontAngle(70);
            c.yAxis().setLabelStyle("Arial Bold", 9);
            c.yAxis2().setLabelStyle("Arial Bold", 9);

            // Tool tip for the bar layer
            // barLayer.setHTMLImageMap("", "", "title='{xLabel}: {value} pieces'");

            // Set the labels on the x axis.
            c.xAxis().setLabels(labels);

            // Set the secondary (right) y-axis scale as 0 - 100 with a tick every 20
            // units
            c.yAxis2().setLinearScale(0, 100, 10);

            // Set the format of the secondary (right) y-axis label to include a
            // percentage sign
            c.yAxis2().setLabelFormat("{value}%");

            // Set the relationship between the two y-axes, which only differ by a
            // scaling factor
            c.yAxis().setLinearScale(0, 1600, 160);
            //c.yAxis().syncAxis(c.yAxis2(), scaleFactor);

            // Set the format of the primary y-axis label foramt to show no decimal
            // point
            c.yAxis().setLabelFormat("{value|0}");
            c.setNumberFormat(',');

            // Add a title to the primary y-axis
            // c.yAxis().setTitle("Frequency");



            // Set all axes to transparent
            //  c.xAxis().setColors(Chart.Transparent);
            //  c.yAxis().setColors(Chart.Transparent);
            // c.yAxis2().setColors(Chart.Transparent);

            // Adjust the plot area size, such that the bounding box (inclusive of
            // axes) is 10 pixels from the left edge, just below the title, 10 pixels
            // from the right edge, and 20 pixels from the bottom edge.
            //c.packPlotArea(10, title.getHeight(), c.getWidth() - 10, c.getHeight() -
            //    20);

            // Output the chart
            viewer.Chart = c;

            // Include tool tip for the chart
            // viewer.ImageMap = c.getHTMLImageMap("clickable");
        }

        public void createChart3(WinChartViewer viewer, string img)
        {
            // The data for the chart
            Chart.setLicenseCode("DEVP-2LSU-B4LX-YCTY-2DF2-77EE");
            double[] data = data_w3;

            // The labels for the chart
            string[] labels = label_w3;

            // In the pareto chart, the line data are just the accumulation of the
            // raw data, scaled to a range of 0 - 100%
            ArrayMath lineData = new ArrayMath(data);
            lineData.acc();
            double scaleFactor = lineData.max() / 100;
            if (scaleFactor == 0)
            {
                // Avoid division by zero error for zero data
                scaleFactor = 1;
            }
            lineData.div2(scaleFactor);

            // Create a XYChart object of size 480 x 300 pixels. Set background color
            // to brushed silver, with a grey (bbbbbb) border and 2 pixel 3D raised
            // effect. Use rounded corners. Enable soft drop shadow.
            // XYChart c = new XYChart(400, 300, Chart.brushedSilverColor(), 0xbbbbbb, 2);
            XYChart c = new XYChart(viewer.Width, viewer.Height);
            c.setBorder(10);
            // c.setRoundedFrame();
            // c.setDropShadow();

            // Add a title to the chart using 15 points Arial Italic. Set top/bottom
            // margins to 12 pixels.

            ChartDirector.TextBox title = c.addTitle(Chart.Top, _txtTit3,
                "Arial Bold", 12, 0xffffff, 0x1c86ee);
            title.setMargin2(10, 10, 6, 12);
            title.setPos(10, 3);
            title.setSize(viewer.Width - 20, 30);

            // Tentatively set the plotarea at (50, 40). Set the width to 100 pixels
            // less than the chart width, and the height to 80 pixels less than the
            // chart height. Use pale grey (f4f4f4) background, transparent border,
            // and dark grey (444444) dotted grid lines.
            //c.setPlotArea(50, 40, c.getWidth() - 100, c.getHeight() - 80, 0xf4f4f4,
            //    -1, Chart.Transparent, c.dashLineColor(0x444444, Chart.DotLine));
            c.setPlotArea(50, 50, c.getWidth() - 110, c.getHeight() - 250, 0xf4f4f4,
                -1, Chart.Transparent, c.dashLineColor(0xffffff, Chart.Transparent));

            // Add a line layer for the pareto line
            LineLayer lineLayer = c.addLineLayer2();

            // Add the pareto line using deep blue (0000ff) as the color, with circle
            // symbols
            ArrayMath li = new ArrayMath(lineData.result());
            ArrayMath am = new ArrayMath(data);

            //lineLayer.addDataSet(li.mul(_cnt / 100.0).result(), 0x0000ff).setDataSymbol(
            //    Chart.CircleShape, 9, 0x0000ff, 0x0000ff);
            lineLayer.addDataSet(lineData.result(), 0x0000ff).setDataSymbol(
                Chart.CircleShape, 9, 0x0000ff, 0x0000ff);

            // Set the line width to 2 pixel
            lineLayer.setLineWidth(2);

            // Bind the line layer to the secondary (right) y-axis.
            lineLayer.setUseYAxis2();

            // Tool tip for the line layer
            lineLayer.setHTMLImageMap("", "",
                "title='Top {={x}+1} items: {value|2}%'");

            // Add a multi-color bar layer using the given data.
           // BarLayer barLayer = c.addBarLayer(am.mul(_cnt / 100.0).result(), 0xff992d);
            BarLayer barLayer = c.addBarLayer(data, 0xff992d);

            // Set soft lighting for the bars with light direction from the right
            barLayer.setBorderColor(Chart.Transparent, Chart.softLighting(Chart.Right
                ));


            c.xAxis().setLabelStyle("Arial Bold", 8).setFontAngle(70);
            c.yAxis().setLabelStyle("Arial Bold", 9);
            c.yAxis2().setLabelStyle("Arial Bold", 9);

            // Tool tip for the bar layer
            // barLayer.setHTMLImageMap("", "", "title='{xLabel}: {value} pieces'");

            // Set the labels on the x axis.
            c.xAxis().setLabels(labels);

            // Set the secondary (right) y-axis scale as 0 - 100 with a tick every 20
            // units
            c.yAxis2().setLinearScale(0, 100, 10);

            // Set the format of the secondary (right) y-axis label to include a
            // percentage sign
            c.yAxis2().setLabelFormat("{value}%");

            // Set the relationship between the two y-axes, which only differ by a
            // scaling factor
            c.yAxis().setLinearScale(0, 1600, 160);
           // c.yAxis().syncAxis(c.yAxis2(), scaleFactor);

            // Set the format of the primary y-axis label foramt to show no decimal
            // point
            c.yAxis().setLabelFormat("{value|0}");
            c.setNumberFormat(',');

            // Add a title to the primary y-axis
            // c.yAxis().setTitle("Frequency");



            // Set all axes to transparent
            //  c.xAxis().setColors(Chart.Transparent);
            //  c.yAxis().setColors(Chart.Transparent);
            // c.yAxis2().setColors(Chart.Transparent);

            // Adjust the plot area size, such that the bounding box (inclusive of
            // axes) is 10 pixels from the left edge, just below the title, 10 pixels
            // from the right edge, and 20 pixels from the bottom edge.
            //c.packPlotArea(10, title.getHeight(), c.getWidth() - 10, c.getHeight() -
            //    20);

            // Output the chart
            viewer.Chart = c;

            // Include tool tip for the chart
            // viewer.ImageMap = c.getHTMLImageMap("clickable");
        }

        public void createChart4(WinChartViewer viewer, string img)
        {
            // The data for the chart
            Chart.setLicenseCode("DEVP-2LSU-B4LX-YCTY-2DF2-77EE");
            double[] data = data_w4;

            // The labels for the chart
            string[] labels = label_w4;

            // In the pareto chart, the line data are just the accumulation of the
            // raw data, scaled to a range of 0 - 100%
            ArrayMath lineData = new ArrayMath(data);
            lineData.acc();
            double scaleFactor = lineData.max() / 100;
            if (scaleFactor == 0)
            {
                // Avoid division by zero error for zero data
                scaleFactor = 1;
            }
            lineData.div2(scaleFactor);

            // Create a XYChart object of size 480 x 300 pixels. Set background color
            // to brushed silver, with a grey (bbbbbb) border and 2 pixel 3D raised
            // effect. Use rounded corners. Enable soft drop shadow.
            // XYChart c = new XYChart(400, 300, Chart.brushedSilverColor(), 0xbbbbbb, 2);
            XYChart c = new XYChart(viewer.Width, viewer.Height);
            c.setBorder(10);
            // c.setRoundedFrame();
            // c.setDropShadow();

            // Add a title to the chart using 15 points Arial Italic. Set top/bottom
            // margins to 12 pixels.

            ChartDirector.TextBox title = c.addTitle(Chart.Top, _txtTit4,
                "Arial Bold", 12, 0xffffff, 0x1c86ee);
            title.setMargin2(10, 10, 6, 12);
            title.setPos(10, 3);
            title.setSize(viewer.Width - 20, 30);

            // Tentatively set the plotarea at (50, 40). Set the width to 100 pixels
            // less than the chart width, and the height to 80 pixels less than the
            // chart height. Use pale grey (f4f4f4) background, transparent border,
            // and dark grey (444444) dotted grid lines.
            //c.setPlotArea(50, 40, c.getWidth() - 100, c.getHeight() - 80, 0xf4f4f4,
            //    -1, Chart.Transparent, c.dashLineColor(0x444444, Chart.DotLine));
            c.setPlotArea(50, 50, c.getWidth() - 110, c.getHeight() - 250, 0xf4f4f4,
                -1, Chart.Transparent, c.dashLineColor(0xffffff, Chart.Transparent));

            // Add a line layer for the pareto line
            LineLayer lineLayer = c.addLineLayer2();

            // Add the pareto line using deep blue (0000ff) as the color, with circle
            // symbols
            ArrayMath li = new ArrayMath(lineData.result());
            ArrayMath am = new ArrayMath(data);

            //lineLayer.addDataSet(li.mul(_cnt / 100.0).result(), 0x0000ff).setDataSymbol(
            //    Chart.CircleShape, 9, 0x0000ff, 0x0000ff);
            lineLayer.addDataSet(lineData.result(), 0x0000ff).setDataSymbol(
                Chart.CircleShape, 9, 0x0000ff, 0x0000ff);

            // Set the line width to 2 pixel
            lineLayer.setLineWidth(2);

            // Bind the line layer to the secondary (right) y-axis.
            lineLayer.setUseYAxis2();

            // Tool tip for the line layer
            lineLayer.setHTMLImageMap("", "",
                "title='Top {={x}+1} items: {value|2}%'");

            // Add a multi-color bar layer using the given data.
            BarLayer barLayer = c.addBarLayer(data, 0xfc8a8a);
           // BarLayer barLayer = c.addBarLayer(am.mul(_cnt / 100.0).result(), 0xfc8a8a);

            // Set soft lighting for the bars with light direction from the right
            barLayer.setBorderColor(Chart.Transparent, Chart.softLighting(Chart.Right
                ));


            c.xAxis().setLabelStyle("Arial Bold", 8).setFontAngle(70);
            c.yAxis().setLabelStyle("Arial Bold", 9);
            c.yAxis2().setLabelStyle("Arial Bold", 9);

            // Tool tip for the bar layer
            // barLayer.setHTMLImageMap("", "", "title='{xLabel}: {value} pieces'");

            // Set the labels on the x axis.
            c.xAxis().setLabels(labels);

            // Set the secondary (right) y-axis scale as 0 - 100 with a tick every 20
            // units
            c.yAxis2().setLinearScale(0, 100, 10);

            // Set the format of the secondary (right) y-axis label to include a
            // percentage sign
            c.yAxis2().setLabelFormat("{value}%");

            // Set the relationship between the two y-axes, which only differ by a
            // scaling factor
            c.yAxis().setLinearScale(0, 1600, 160);
            //c.yAxis().syncAxis(c.yAxis2(), scaleFactor);

            // Set the format of the primary y-axis label foramt to show no decimal
            // point
            c.yAxis().setLabelFormat("{value|0}");
            c.setNumberFormat(',');

            // Add a title to the primary y-axis
            // c.yAxis().setTitle("Frequency");



            // Set all axes to transparent
            //  c.xAxis().setColors(Chart.Transparent);
            //  c.yAxis().setColors(Chart.Transparent);
            // c.yAxis2().setColors(Chart.Transparent);

            // Adjust the plot area size, such that the bounding box (inclusive of
            // axes) is 10 pixels from the left edge, just below the title, 10 pixels
            // from the right edge, and 20 pixels from the bottom edge.
            //c.packPlotArea(10, title.getHeight(), c.getWidth() - 10, c.getHeight() -
            //    20);

            // Output the chart
            viewer.Chart = c;

            // Include tool tip for the chart
            // viewer.ImageMap = c.getHTMLImageMap("clickable");
        }

        public void createChartCenter(WinChartViewer viewer, string img)
        {
            // The data for the chart
            //double[] data0;
            //double[] data1;
            //double[] data2;
            //double[] data3;
            //string[] labels;
            //int idate;
            ////double[] data0 = { 185, 176, 135, 144,99, 120, 175, 128, 175, 142, 172, 120, 175, 123, 120, 185, 145, 185, 152, 142, 156, 156, 175, 185, 175, 148, 142 };
            ////double[] data1 = { 145, 153, 123, 175, 120, 105, 142, 147, 145, 184, 124, 132, 102, 125, 165, 156, 125, 156, 125, 143, 142, 148, 129, 145, 169, 136, 187 };
            ////double[] data2 = { 135, 120, 145, 126, 100, 145, 120, 120, 156, 129, 168, 185, 165, 135, 158, 125, 126, 125, 163, 165, 132, 143, 138, 136, 185, 159, 144 };
            ////double[] data3 = { 150, 110, 187, 173, 85, 100, 135, 156, 155, 120, 127, 122, 125, 145, 134, 185, 132, 185, 128, 123, 185, 129, 136, 162, 125, 189, 165 };
            //if (_dt_grid != null && _dt_grid.Rows.Count > 0)
            //{
            //    idate = _dt_grid.Rows.Count;
            //    data0 = new double[idate];
            //    data1 = new double[idate];
            //    data2 = new double[idate];
            //    data3 = new double[idate];
            //    labels = new string[idate];
            //    for (int i = 0; i < idate - 1; i++)
            //    {
            //        data0[i] = Convert.ToDouble(_dt_grid.Rows[i]["F1"].ToString());
            //        data1[i] = Convert.ToDouble(_dt_grid.Rows[i]["F2"].ToString());
            //        data2[i] = Convert.ToDouble(_dt_grid.Rows[i]["F3"].ToString());
            //        data3[i] = Convert.ToDouble(_dt_grid.Rows[i]["F4"].ToString());
            //        labels[i] = _dt_grid.Rows[i]["DD"].ToString();
            //    }
            //}
            //else return;

            // The labels for the chart
            //string[] labels = { "0", "1", "2", "3", "4", "5", "6", "7", "8" 
                              
            //                  };

            // Create a XYChart object of size 600 x 300 pixels, with a pale red
            // (ffdddd) background, black border, 1 pixel 3D border effect and
            // rounded corners.

            XYChart c = new XYChart(viewer.Width, viewer.Height);
            c.setBorder(10);
            // c.setRoundedFrame();

            // Set the plotarea at (55, 58) and of size 520 x 195 pixels, with white
            // (ffffff) background. Set horizontal and vertical grid lines to grey
            // (cccccc).
            c.setPlotArea(55, 58, c.getWidth() - 110, c.getHeight() - 150, 0xf4f4f4,
                -1, Chart.Transparent, c.dashLineColor(0xffffff, Chart.Transparent));
            // , Chart.Transparent, -1, 0xffffff, 0xffffff
            // Add a legend box at (55, 32) (top of the chart) with horizontal
            // layout. Use 9 pts Arial Bold font. Set the background and border color
            // to Transparent.
            //c.addLegend(55, 32, false, "Arial Bold", 9).setBackground(
            //    Chart.Transparent);

            // Add a title box to the chart using 15 pts Times Bold Italic font. The
            // title is in CDML and includes embedded images for highlight. The text
            // is white (ffffff) on a dark red (880000) background, with soft
            // lighting effect from the right side.
            //c.addTitle(
            //    "<*block,valign=absmiddle*><*img=star.png*><*img=star.png*> " +
            //    "Performance Enhancer <*img=star.png*><*img=star.png*><*/*>",
            //    "Times New Roman Bold Italic", 15, 0xffffff).setBackground(0x880000,
            //    -1, Chart.softLighting(Chart.Right));

            // Add a title to the y axis
            // c.yAxis().setTitle("Energy Concentration (KJ per liter)");

            // Set the labels on the x axis
              c.xAxis().setLabels(labels);

            // Add a title to the x axis using CMDL
            //c.xAxis().setTitle(
            //    "<*block,valign=absmiddle*><*img=clock.png*>  Elapsed Time (hour)" +
            //    "<*/*>");
              c.yAxis().setLinearScale(0, _max_chart+50);
            // Set the axes width to 2 pixels
            c.xAxis().setWidth(2);
            //c.yAxis().setWidth(2);

            c.xAxis().setTitle(" (Date)  ", "Arial Bold ", 15);
            

            c.addLegend(55, 5, false, "Arial Bold", 13).setBackground(
                Chart.Transparent);

            // Add a spline layer to the chart

            c.yAxis().setLabelStyle("Calibri Bold", 12);
            c.xAxis().setLabelStyle("Calibri Bold", 11);
            c.yAxis().setWidth(2);

            c.setNumberFormat(',');

            SplineLayer layer = c.addSplineLayer();

            // Set the default line width to 2 pixels
            layer.setLineWidth(5);

            // Add a data set to the spline layer, using blue (0000c0) as the line
            // color, with yellow (ffff00) circle symbols.
            layer.addDataSet(data0, 0x0000c0, "Fatory 1").setDataSymbol(
                Chart.NoShape, 20, 0xffff00);

            // Add a data set to the spline layer, using brown (982810) as the line
            // color, with pink (f040f0) diamond symbols.
            layer.addDataSet(data1, 0x982810, "Fatory 2").setDataSymbol(
                Chart.NoShape, 20, 0xf040f0);

            layer.addDataSet(data2, 0xdb6e25, "Fatory 3").setDataSymbol(
               Chart.NoShape, 20, 0x0050f0);

            layer.addDataSet(data3, 0x004000, "Fatory 4").setDataSymbol(
               Chart.NoShape, 20, 0xf04000);

            // Add a custom CDML text at the bottom right of the plot area as the
            // logo
            //c.addText(575, 250,
            //    "<*block,valign=absmiddle*><*img=small_molecule.png*> <*block*>" +
            //    "<*font=Times New Roman Bold Italic,size=10,color=804040*>" +
            //    "Molecular\nEngineering<*/*>").setAlignment(Chart.BottomRight);

            // Output the chart
            viewer.Chart = c;

            //include tool tip for the chart
            //viewer.ImageMap = c.getHTMLImageMap("clickable", "",
            //    "title='{dataSetName} at t = {xLabel} hour: {value} KJ/liter'");
        }

        private void add_data_chart()
        {
            int w1 = 0;
            int w2 = 0;
            int w3 = 0;
            int w4 = 0;
            for (int i = 0; i < _dt_week.Rows.Count; i++)
            {
                if (_dt_week.Rows[i]["w1_qty"].ToString() != "") w1++;
                if (_dt_week.Rows[i]["w2_qty"].ToString() != "") w2++;
                if (_dt_week.Rows[i]["w3_qty"].ToString() != "") w3++;
                if (_dt_week.Rows[i]["w4_qty"].ToString() != "") w4++;
            }
            data_w1 = new double[w1];
            data_w2 = new double[w2];
            data_w3 = new double[w3];
            data_w4 = new double[w4];
            label_w1 = new string[w1];
            label_w2 = new string[w2];
            label_w3 = new string[w3];
            label_w4 = new string[w4];


            for (int i = 0; i < data_w1.Length; i++)
            {
                if (i < w1)
                {
                    data_w1[i] = Convert.ToDouble(_dt_week.Rows[i]["w1_qty"].ToString());
                    label_w1[i] = _dt_week.Rows[i]["w1_lbl"].ToString();
                }
                if (i < w2)
                {
                    data_w2[i] = Convert.ToDouble(_dt_week.Rows[i]["w2_qty"].ToString());
                    label_w2[i] = _dt_week.Rows[i]["w2_lbl"].ToString();
                }
                if (i < w3)
                {
                    data_w3[i] = Convert.ToDouble(_dt_week.Rows[i]["w3_qty"].ToString());
                    label_w3[i] = _dt_week.Rows[i]["w3_lbl"].ToString();
                }
                if (i < w4)
                {
                    data_w4[i] = Convert.ToDouble(_dt_week.Rows[i]["w4_qty"].ToString());
                    label_w4[i] = _dt_week.Rows[i]["w4_lbl"].ToString();
                }
            }
        }



        private void load_grid(DataTable arg_dt)
        {
            int max_col = arg_dt.Rows.Count-1;
           // if (29 > max_col) axfpSpread1.DeleteCols(10, 1);
            for (int icol = 0; icol <= max_col; icol++)
            {
                for (int irow = 1; irow < arg_dt.Columns.Count ; irow++)
                {
                    axfpSpread1.Row = irow ;
                    axfpSpread1.Col = icol + 2;
                    axfpSpread1.Text = arg_dt.Rows[icol][irow].ToString().Replace("  ","\n");
                }
            }
            Cal_max();

        }


        #endregion Func


        #region DB
        private System.Data.DataSet LOAD_DATA_OSD_EXT()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_PU.SELECT_PU_OSD_EXT_V3";
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
                //if (ds_ret == null) return null;
                //return ds_ret.Tables[process_name];
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
                icount++;
                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
                //blink_oval(oval_Z1_CND);
                //blink_oval(oval_Z2_CND);
                //blink_oval(oval_Z3_CND);
                //blink_oval(oval_Z4_CND);
                //blink_oval(oval_Z5_CND);
                //blink_oval(oval_Z6_CND);

                if (icount == 10)
                {
                    icount = 0;
                    loadata();
                } 
            }
            catch (Exception)
            {
            } 
        }


        #endregion Timer
        //private void blink_oval(OvalShape arg_oval)
        //{
        //    if (arg_oval.FillColor == Color.Red)
        //    {
        //        arg_oval.FillColor = Color.Yellow;
        //        arg_oval.BorderColor = Color.Yellow;
        //        foreach (Control con in pn_body.Controls)
        //        {
        //            if (con.Name.Length >= 10 && con.Name.Substring(0, 10) == "lbl" + arg_oval.Name.Replace("oval","") && con.BackColor==Color.Red)
        //            {
        //                con.BackColor = Color.Yellow;
        //                con.ForeColor = Color.Black;
        //            }

        //        }
        //    }
        //    else
        //    {
        //        arg_oval.FillColor = Color.Red;
        //        arg_oval.BorderColor = Color.Red;
        //        foreach (Control con in pn_body.Controls)
        //        {
        //            if (con.Name.Length >= 10 && con.Name.Substring(0, 10) == "lbl" + arg_oval.Name.Replace("oval", "") && con.BackColor == Color.Yellow)
        //            {
        //                con.BackColor = Color.Red;
        //                con.ForeColor = Color.White;

        //            }

        //        }
        //    }
        //}

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
            try
            {
               
                if (this.Visible)
                {
                    _max_chart = 0;
                    // pn_body.Hide();
                    timer1.Start();
                    load_grid(_dt_grid);

                    createChart1(chart1, "");
                    createChart2(chart2, "");
                    createChart3(chart3, "");
                    createChart4(chart4, "");
                    timer_daily_chart.Start();
                   
                   // timer2.Start();


                    //  MaterialReport.ClassLib.WinAPI.AnimateWindow(pn_body.Handle, 500, MaterialReport.ClassLib.WinAPI.getSlidType("1"));

                    //   pn_body.Show();


                }
                else
                {
                    timer1.Stop();
                }
            }
            catch (Exception)
            {
            }
                
        }

        private void loadata()
        {
            System.Data.DataSet ds = LOAD_DATA_OSD_EXT();
            if (ds != null || ds.Tables.Count > 0)
            {
                _dt_grid = ds.Tables[0];
                _dt_week = ds.Tables[1];
                _dt_avg = ds.Tables[2];
                add_data_chart();
            }
        }

        private void FORM_IPEX3_LOGISTIC_Load(object sender, EventArgs e)
        {
            try
            {
                //this.button1.BackgroundImage = global::IPEX_Monitor.Properties.Resources.back7;
                GoFullscreen(true);
                loadata();
                data_chart_daily();
            }
            catch (Exception)
            {
                
            }
            
            
          //  _myPen.Width = _wlr;

           // lblTitle.Text = "Logistic Status(Between Blending And IPP)";
           // load_data(LOAD_DATA_LOGISTIC());
           
           // lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
        }

        

        #endregion Event

        private void timer_daily_chart_Tick(object sender, EventArgs e)
        {
            data_chart_daily();
            createChartCenter(chart_center, "");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (_cnt > 100)
            {
                timer2.Stop();
                _cnt = 0;
            }
            else
            {
                createChart1(chart1, "");
                createChart2(chart2, "");
                createChart3(chart3, "");
                createChart4(chart4, "");
                _cnt += 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Smart_FTY.ComVar._frm_home.Show();
            this.Hide();
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





    }
}
