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
    public partial class User_Chart : UserControl
    {
        public User_Chart()
        {
            InitializeComponent();
        }

        public void Bindingdata(DataTable dt, string strdiv, string strmc)
        {
            DataTable dtchart = null;
            double d_min = 0, d_max = 0;
            try
            {
                
                if (dt.Rows.Count == 1)
                {
                    if (strdiv == "H" && dt.Rows[0]["STATION_H"].ToString() == "") dtchart = null;
                    else if (strdiv == "C" && dt.Rows[0]["STATION_C"].ToString() == "") dtchart = null;
                }
                else dtchart = strdiv == "H" ? dt.Select("STATION_H IS NOT NULL").CopyToDataTable() : dt.Select("STATION_C IS NOT NULL").CopyToDataTable();
                d_min = strdiv == "H" ? Convert.ToDouble(dt.Rows[0]["MIN1"].ToString() == "" ? "0" : dt.Rows[0]["MIN1"].ToString()) : Convert.ToDouble(dt.Rows[0]["MIN2"].ToString() == "" ? "0" : dt.Rows[0]["MIN2"].ToString());
                d_max = strdiv == "H" ? Convert.ToDouble(dt.Rows[0]["MAX1"].ToString() == "" ? "0" : dt.Rows[0]["MAX1"].ToString()) : Convert.ToDouble(dt.Rows[0]["MAX2"].ToString() == "" ? "0" : dt.Rows[0]["MAX2"].ToString());
                            
                if (strdiv == "H")
                {
                    chart_temp.Titles.Clear();
                    chart_temp.Titles.Add(new ChartTitle());
                    chart_temp.DataSource = dtchart;
                    chart_temp.Series[0].ArgumentDataMember = "HH";
                    chart_temp.Series[0].ValueDataMembers.AddRange(new string[] { "MAX1" });
                    chart_temp.Series[1].ArgumentDataMember = "HH";
                    chart_temp.Series[1].ValueDataMembers.AddRange(new string[] { "MIN1" });
                    chart_temp.Series[2].ArgumentDataMember = "HH";
                    chart_temp.Series[2].ValueDataMembers.AddRange(new string[] { "TEMP1" });
                    chart_temp.Series[2].View.Color = Color.Salmon;
                    chart_temp.Titles[0].Text = strmc + " Heat temperature °C";
                    chart_temp.Titles[0].Visibility = DevExpress.Utils.DefaultBoolean.True;
                    chart_temp.Titles[0].Font = new System.Drawing.Font("Calibri", 14, FontStyle.Bold);
                    chart_temp.Titles[0].Indent = 0;
                    ((XYDiagram)chart_temp.Diagram).AxisY.WholeRange.Auto = true;
                    ((XYDiagram)chart_temp.Diagram).AxisY.WholeRange.SetMinMaxValues(d_min, d_max);
                }
                else
                {
                    chart_temp.Titles.Clear();
                    chart_temp.Titles.Add(new ChartTitle());
                    chart_temp.DataSource = dtchart;
                    chart_temp.Series[0].ArgumentDataMember = "HH";
                    chart_temp.Series[0].ValueDataMembers.AddRange(new string[] { "MAX2" });
                    chart_temp.Series[1].ArgumentDataMember = "HH";
                    chart_temp.Series[1].ValueDataMembers.AddRange(new string[] { "MIN2" });
                    chart_temp.Series[2].ArgumentDataMember = "HH";
                    chart_temp.Series[2].ValueDataMembers.AddRange(new string[] { "TEMP2" });
                    chart_temp.Series[2].View.Color = Color.DodgerBlue;
                    chart_temp.Titles[0].Text = strmc + " Cool temperature °C";
                    chart_temp.Titles[0].Visibility = DevExpress.Utils.DefaultBoolean.True;
                    chart_temp.Titles[0].Font = new System.Drawing.Font("Calibri", 14, FontStyle.Bold);
                    chart_temp.Titles[0].Indent = 0;
                    ((XYDiagram)chart_temp.Diagram).AxisY.WholeRange.Auto = true;
                    ((XYDiagram)chart_temp.Diagram).AxisY.WholeRange.SetMinMaxValues(d_min, d_max);
                }
            }
            catch(Exception ex)
            {
                if (strdiv == "H")
                {
                    chart_temp.Titles.Clear();
                    chart_temp.Titles.Add(new ChartTitle());
                    chart_temp.DataSource = dtchart;
                    chart_temp.Series[0].ArgumentDataMember = "HH";
                    chart_temp.Series[0].ValueDataMembers.AddRange(new string[] { "MAX1" });
                    chart_temp.Series[1].ArgumentDataMember = "HH";
                    chart_temp.Series[1].ValueDataMembers.AddRange(new string[] { "MIN1" });
                    chart_temp.Series[2].ArgumentDataMember = "HH";
                    chart_temp.Series[2].ValueDataMembers.AddRange(new string[] { "TEMP1" });
                    chart_temp.Series[2].View.Color = Color.Salmon;
                    chart_temp.Titles[0].Text = strmc + " Heat temperature °C";
                    chart_temp.Titles[0].Visibility = DevExpress.Utils.DefaultBoolean.True;
                    chart_temp.Titles[0].Font = new System.Drawing.Font("Calibri", 14, FontStyle.Bold);
                    chart_temp.Titles[0].Indent = 0;
                    ((XYDiagram)chart_temp.Diagram).AxisY.WholeRange.Auto = true;
                    ((XYDiagram)chart_temp.Diagram).AxisY.WholeRange.SetMinMaxValues(d_min, d_max);
                }
                else
                {
                    chart_temp.Titles.Clear();
                    chart_temp.Titles.Add(new ChartTitle());
                    chart_temp.DataSource = dtchart;
                    chart_temp.Series[0].ArgumentDataMember = "HH";
                    chart_temp.Series[0].ValueDataMembers.AddRange(new string[] { "MAX2" });
                    chart_temp.Series[1].ArgumentDataMember = "HH";
                    chart_temp.Series[1].ValueDataMembers.AddRange(new string[] { "MIN2" });
                    chart_temp.Series[2].ArgumentDataMember = "HH";
                    chart_temp.Series[2].ValueDataMembers.AddRange(new string[] { "TEMP2" });
                    chart_temp.Series[2].View.Color = Color.DodgerBlue;
                    chart_temp.Titles[0].Text = strmc + " Cool temperature °C";
                    chart_temp.Titles[0].Visibility = DevExpress.Utils.DefaultBoolean.True;
                    chart_temp.Titles[0].Font = new System.Drawing.Font("Calibri", 14, FontStyle.Bold);
                    chart_temp.Titles[0].Indent = 0;
                    ((XYDiagram)chart_temp.Diagram).AxisY.WholeRange.Auto = true;
                    ((XYDiagram)chart_temp.Diagram).AxisY.WholeRange.SetMinMaxValues(d_min, d_max);
                }
            }
        }
    }
}
