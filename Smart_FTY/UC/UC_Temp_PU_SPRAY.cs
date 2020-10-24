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
    public partial class UC_Temp_PU_SPRAY : UserControl
    {
        public UC_Temp_PU_SPRAY()
        {
            InitializeComponent();
        }

        private void bindingchart(DataTable dtchart, string col, ChartControl chart_tmp, string title)
        {
            try
            {
                string col_min = "", col_max = "";
                double min=0, max=0;                
                if (dtchart != null)
                {
                    col_min = "V_MIN";
                    col_max = "V_MAX";
                    DataTable dtmin = dtchart.Select("",col + " ASC").CopyToDataTable();
                    if (Convert.ToDouble(dtchart.Rows[0][col_min]) > Convert.ToDouble(dtmin.Rows[0][col] == null ? "0" : dtmin.Rows[0][col]) && Convert.ToDouble(dtmin.Rows[0][col] == null ? "0" : dtmin.Rows[0][col]) > 0)
                    {
                        min = Convert.ToDouble(dtmin.Rows[0][col]);
                    }
                    else
                    {
                        min = Convert.ToDouble(dtchart.Rows[0][col_min]);
                    }

                    DataTable dtmax = dtchart.Select("",col + " DESC").CopyToDataTable();
                    if (Convert.ToDouble(dtchart.Rows[0][col_max]) < Convert.ToDouble(dtmax.Rows[0][col] == null ? "0" : dtmax.Rows[0][col]) && Convert.ToDouble(dtmax.Rows[0][col] == null ? "0" : dtmax.Rows[0][col]) > 0)
                    {
                        max = Convert.ToDouble(dtmax.Rows[0][col]);
                    }
                    else
                    {
                        max = Convert.ToDouble(dtchart.Rows[0][col_max]);
                    }
                }
                chart_tmp.Titles.Clear();
                chart_tmp.Titles.Add(new ChartTitle());
                DevExpress.XtraCharts.ConstantLine constantLine1 = new DevExpress.XtraCharts.ConstantLine();
                DevExpress.XtraCharts.ConstantLine constantLine2 = new DevExpress.XtraCharts.ConstantLine();

                if (dtchart.Rows.Count > 0)
                {
                    constantLine1.AxisValueSerializable = dtchart.Rows[0][col_min].ToString();
                    constantLine1.Color = System.Drawing.Color.Red;
                    constantLine1.LineStyle.Thickness = 4;
                    constantLine1.LineStyle.DashStyle = DashStyle.Solid;
                    constantLine1.Name = "";
                    constantLine1.ShowInLegend = false;

                    constantLine2.AxisValueSerializable = dtchart.Rows[0][col_max].ToString();
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
                chart_tmp.Titles[0].Text = title + " temperature °C";
                chart_tmp.Titles[0].Visibility = DevExpress.Utils.DefaultBoolean.True;
                chart_tmp.Titles[0].Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);
                chart_tmp.Titles[0].Indent = 0;
                chart_tmp.Titles[0].TextColor = Color.HotPink;
                ((XYDiagram)chart_tmp.Diagram).AxisY.WholeRange.Auto = true;
                ((XYDiagram)chart_tmp.Diagram).AxisY.WholeRange.SetMinMaxValues(min, max);
                //((XYDiagram)chart_tmp.Diagram).AxisY.WholeRange.SetMinMaxValues(Convert.ToDouble(dtchart.Rows[0][col_min]), Convert.ToDouble(dtchart.Rows[0][col_max]));
            }
            catch
            {
                chart_tmp.Titles.Clear();
                chart_tmp.Titles.Add(new ChartTitle());
                chart_tmp.DataSource = dtchart;
                chart_tmp.Titles[0].Text = title + " temperature °C";
                chart_tmp.Titles[0].Visibility = DevExpress.Utils.DefaultBoolean.True;
                chart_tmp.Titles[0].Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);
                chart_tmp.Titles[0].Indent = 0;
                chart_tmp.Titles[0].TextColor = Color.HotPink;
            }
        }

        public void Bindingdata(DataTable dt, int vitri)
        {
            double d_min_i = 0, d_max_i = 0, d_min_p = 0, d_max_p = 0, d_min_o = 0, d_max_o = 0;
            try
            {
                switch (vitri)
                {
                    case 1:
                        //lblTitle.Text = "ISO 1";
                        bindingchart(dt, "VAL01L", chart_1, "Champer 01L");
                        bindingchart(dt, "VAL01R", chart_2, "Champer 01R");   
                        break;
                    case 2:
                        //lblTitle.Text = "POLY 1";
                        bindingchart(dt, "VAL02L", chart_1, "Champer 02L");
                        bindingchart(dt, "VAL02R", chart_2, "Champer 02R");
                        break;
                    case 3:
                        //lblTitle.Text = "POLY 2";
                        bindingchart(dt, "VAL03L", chart_1, "Champer 03L");
                        bindingchart(dt, "VAL03R", chart_2, "Champer 03R");
                        break;
                    case 4:
                        //lblTitle.Text = "POLY 2";
                        bindingchart(dt, "VAL04L", chart_1, "Champer 04L");
                        bindingchart(dt, "VAL04R", chart_2, "Champer 04R");
                        break;
                    case 5:
                        //lblTitle.Text = "POLY 2";
                        bindingchart(dt, "VAL05L", chart_1, "Champer 05L");
                        bindingchart(dt, "VAL05R", chart_2, "Champer 05R");
                        break;
                }

            }
            catch
            {
                switch (vitri)
                {
                    case 1:
                        //lblTitle.Text = "ISO 1";
                        bindingchart(dt, "VAL01L", chart_1, "Champer 01L");
                        bindingchart(dt, "VAL01R", chart_2, "Champer 01R");
                        break;
                    case 2:
                        //lblTitle.Text = "POLY 1";
                        bindingchart(dt, "VAL02L", chart_1, "Champer 02L");
                        bindingchart(dt, "VAL02R", chart_2, "Champer 02R");
                        break;
                    case 3:
                        //lblTitle.Text = "POLY 2";
                        bindingchart(dt, "VAL03L", chart_1, "Champer 03L");
                        bindingchart(dt, "VAL03R", chart_2, "Champer 03R");
                        break;
                    case 4:
                        //lblTitle.Text = "POLY 2";
                        bindingchart(dt, "VAL04L", chart_1, "Champer 04L");
                        bindingchart(dt, "VAL04R", chart_2, "Champer 04R");
                        break;
                    case 5:
                        //lblTitle.Text = "POLY 2";
                        bindingchart(dt, "VAL05L", chart_1, "Champer 05L");
                        bindingchart(dt, "VAL05R", chart_2, "Champer 05R");
                        break;
                }
            }
            finally
            {
               
            }
        }
    }
}
