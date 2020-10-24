using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace Smart_FTY.UC
{
    public partial class UC_Temp_PU_AUTO : UserControl
    {
        public UC_Temp_PU_AUTO()
        {
            InitializeComponent();
        }

        private void bindingchart(DataTable dtchart, string col, ChartControl chart_tmp, string title, string flag, DataTable dt1, DataTable dt2)
        {
            try
            {
                string col_min = "", col_max = "";
                double min = 0, max = 0, _min = 0, _max = 0;
                switch (flag)
                {
                    case "ISO":
                        col_min = "ISO_MIN";
                        col_max = "ISO_MAX";
                        break;
                    case "OIL":
                        col_min = "OIL_MIN";
                        col_max = "OIL_MAX";
                        break;
                    case "POLY":
                        col_min = "POLY_MIN";
                        col_max = "POLY_MAX";
                        break;

                }


                if (dtchart != null)
                {
                    DataTable dtmin = dtchart.Select("",col + " ASC").CopyToDataTable();
                    _min = Convert.ToDouble(dt2.Rows[0]["STAND_" + col.Substring(4, 2)]) - Convert.ToDouble(dt2.Rows[0]["SPEC_" + col.Substring(4, 2)]);
                    _max = Convert.ToDouble(dt2.Rows[0]["STAND_" + col.Substring(4, 2)]) + Convert.ToDouble(dt2.Rows[0]["SPEC_" + col.Substring(4, 2)]);
                    if (_min > Convert.ToDouble(dtmin.Rows[0][col]) && Convert.ToDouble(dtmin.Rows[0][col]) > 0)
                    {
                        min = Convert.ToDouble(dtmin.Rows[0][col]);
                    }
                    else
                    {
                        min = _min;
                    }

                    DataTable dtmax = dtchart.Select("",col + " DESC").CopyToDataTable();
                    if (_max < Convert.ToDouble(dtmax.Rows[0][col]) && Convert.ToDouble(dtmax.Rows[0][col]) > 0)
                    {
                        max = Convert.ToDouble(dtmax.Rows[0][col]);
                    }
                    else
                    {
                        max = _max;
                    }
                }
                chart_tmp.Titles.Clear();
                chart_tmp.Titles.Add(new ChartTitle());
                DevExpress.XtraCharts.ConstantLine constantLine1 = new DevExpress.XtraCharts.ConstantLine();
                DevExpress.XtraCharts.ConstantLine constantLine2 = new DevExpress.XtraCharts.ConstantLine();

                if (dtchart.Rows.Count > 0)
                {
                    constantLine1.AxisValueSerializable = _min.ToString();
                    constantLine1.Color = System.Drawing.Color.Red;
                    constantLine1.LineStyle.Thickness = 4;
                    constantLine1.LineStyle.DashStyle = DashStyle.Solid;
                    constantLine1.Name = "";
                    constantLine1.ShowInLegend = false;

                    constantLine2.AxisValueSerializable = _max.ToString();
                    constantLine2.Color = System.Drawing.Color.Red;
                    constantLine2.LineStyle.Thickness = 4;
                    constantLine2.LineStyle.DashStyle = DashStyle.Solid;
                    constantLine2.Name = "";
                    constantLine2.ShowInLegend = false;

                    ((XYDiagram)chart_tmp.Diagram).AxisY.ConstantLines.Clear();
                    ((XYDiagram)chart_tmp.Diagram).AxisY.ConstantLines.AddRange(new DevExpress.XtraCharts.ConstantLine[] { constantLine1, constantLine2 });
                }

                chart_tmp.DataSource = dtchart;
                //chart_tmp.Series[0].ArgumentDataMember = "HMS";
                //chart_tmp.Series[0].ValueDataMembers.AddRange(new string[] { col_max });
                //chart_tmp.Series[1].ArgumentDataMember = "HMS";
                //chart_tmp.Series[1].ValueDataMembers.AddRange(new string[] { col_min });
                chart_tmp.Series[2].ArgumentDataMember = "HMS";
                chart_tmp.Series[2].ValueDataMembers.AddRange(new string[] { col });
                chart_tmp.Series[2].View.Color = Color.DodgerBlue;
                chart_tmp.Titles[0].Text = title + " °C";
                chart_tmp.Titles[0].Visibility = DevExpress.Utils.DefaultBoolean.True;
                chart_tmp.Titles[0].Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                chart_tmp.Titles[0].Indent = 0;
                chart_tmp.Titles[0].TextColor = Color.HotPink;
                ((XYDiagram)chart_tmp.Diagram).AxisY.WholeRange.Auto = true;
                ((XYDiagram)chart_tmp.Diagram).AxisY.WholeRange.SetMinMaxValues(min, max);
                //((XYDiagram)chart_tmp.Diagram).AxisY.WholeRange.SetMinMaxValues(Convert.ToDouble(dtchart.Rows[0][col_min]), Convert.ToDouble(dtchart.Rows[0][col_max]));
            }
            catch
            {
            }
        }

        public void Bindingdata(DataTable dt, int vitri, DataTable dt1, DataTable dt2)
        {
            double d_min_i = 0, d_max_i = 0, d_min_p = 0, d_max_p = 0, d_min_o = 0, d_max_o = 0;
            try
            {
                if (dt.Rows.Count > 0)
                {
                    d_min_i = Convert.ToDouble(dt.Rows[0]["ISO_MIN"].ToString());
                    d_max_i = Convert.ToDouble(dt.Rows[0]["ISO_MAX"].ToString());
                    d_min_o = Convert.ToDouble(dt.Rows[0]["OIL_MIN"].ToString());
                    d_max_o = Convert.ToDouble(dt.Rows[0]["OIL_MAX"].ToString());
                    d_min_p = Convert.ToDouble(dt.Rows[0]["POLY_MIN"].ToString());
                    d_max_p = Convert.ToDouble(dt.Rows[0]["POLY_MAX"].ToString());
                }
                switch (vitri)
                {
                    case 1:
                        lblTitle.Text = "ISO 1";
                        bindingchart(dt, "VAL_07", chart_1, "MATERIAL TEMPERATURE", "ISO", dt1, dt2);
                        bindingchart(dt, "VAL_08", chart_2, "OIL TEMPERATURE", "OIL", dt1, dt2);
                        bindingchart(dt, "VAL_09", chart_3, "HOSE TEMPERATURE", "ISO", dt1, dt2);


                        break;
                    case 2:

                        lblTitle.Text = "POLY 1";
                        bindingchart(dt, "VAL_04", chart_1, "MATERIAL TEMPERATURE", "POLY", dt1, dt2);
                        bindingchart(dt, "VAL_05", chart_2, "OIL TEMPERATURE", "OIL", dt1, dt2);
                        bindingchart(dt, "VAL_06", chart_3, "HOSE TEMPERATURE", "POLY", dt1, dt2);

                        break;
                    case 3:

                        lblTitle.Text = "POLY 2";
                        bindingchart(dt, "VAL_01", chart_1, "MATERIAL TEMPERATURE", "POLY", dt1, dt2);
                        bindingchart(dt, "VAL_02", chart_2, "OIL TEMPERATURE", "OIL", dt1, dt2);
                        bindingchart(dt, "VAL_03", chart_3, "HOSE TEMPERATURE", "POLY", dt1, dt2);

                        break;
                }

            }
            catch
            {
                switch (vitri)
                {
                    case 1:
                        lblTitle.Text = "ISO 1";
                        bindingchart(dt, "VAL_07", chart_1, "MATERIAL TEMPERATURE", "ISO", dt1, dt2);
                        bindingchart(dt, "VAL_08", chart_2, "OIL TEMPERATURE", "OIL", dt1, dt2);
                        bindingchart(dt, "VAL_09", chart_3, "HOSE TEMPERATURE", "ISO", dt1, dt2);


                        break;
                    case 2:

                        lblTitle.Text = "POLY 1";
                        bindingchart(dt, "VAL_04", chart_1, "MATERIAL TEMPERATURE", "POLY", dt1, dt2);
                        bindingchart(dt, "VAL_05", chart_2, "OIL TEMPERATURE", "OIL", dt1, dt2);
                        bindingchart(dt, "VAL_06", chart_3, "HOSE TEMPERATURE", "POLY", dt1, dt2);

                        break;
                    case 3:

                        lblTitle.Text = "POLY 2";
                        bindingchart(dt, "VAL_01", chart_1, "MATERIAL TEMPERATURE", "POLY", dt1, dt2);
                        bindingchart(dt, "VAL_02", chart_2, "OIL TEMPERATURE", "OIL", dt1, dt2);
                        bindingchart(dt, "VAL_03", chart_3, "HOSE TEMPERATURE", "POLY", dt1, dt2);

                        break;
                }
            }
            finally
            {
               
            }
        }
    }
}
