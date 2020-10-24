using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Text.RegularExpressions;
using System.Threading;
using DevExpress.XtraCharts;

//using FPSpreadADO;
using ChartDirector;
using System.Media;


using DevExpress.XtraGauges.Win;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Win.Gauges.Digital;

using DevExpress.XtraGauges.Base;
using DevExpress.XtraGauges.Win.Base;


namespace Smart_FTY
{
    public partial class FORM_EVA_TEMP_TRACKING : SampleFrm1
    {
        DataTable _dt = null;
        int _IReload = 0;

       // 


        #region Method

        private void CreateChartLine_Test(ChartControl arg_chart, DataTable arg_dt, string arg_name)
        {
            try
            {
                arg_chart.Update();
                Series series = new Series("Line 1", ViewType.Spline);
                arg_chart.Series.Add(series);

                series.BindToData(arg_dt, "HMS", new string[] { "VALUE1" });

                //series.DataSource = arg_dt;
                //series.ArgumentScaleType = ScaleType.Qualitative;
                //series.ArgumentDataMember = "HMS";
                //series.ValueScaleType = ScaleType.Numerical;
                //series.ValueDataMembers.AddRange(new string[] { "VALUE1" });

                

                ((SplineSeriesView)series.View).ColorEach = true;
                ((XYDiagram)arg_chart.Diagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.False;
                arg_chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

                // Dock the chart into its parent and add it to the current form.
                //arg_chart.Dock = DockStyle.Fill;
                groupBoxEx2.Controls.Add(arg_chart);
            }
            catch (Exception)
            {
                
                
            }
            
        }


        private void CreateChartLine(ChartControl arg_chart, DataTable arg_dt, string arg_name)
        {
            try
            {
                if (arg_dt == null || arg_dt.Rows.Count == 0) return;
                arg_chart.Series.Clear();
                arg_chart.Titles.Clear();

                //----------create--------------------
                Series series1 = new Series("Line 1", ViewType.Spline);
                Series series2 = new Series("Line 2", ViewType.Spline);
                //Series series2 = new Series("Chart Line 5", ViewType.Spline);

                DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
                DevExpress.XtraCharts.SplineSeriesView splineSeriesView2 = new DevExpress.XtraCharts.SplineSeriesView();
                //DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
                //DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
                //DevExpress.XtraCharts.BarWidenAnimation barWidenAnimation1 = new DevExpress.XtraCharts.BarWidenAnimation();
                //DevExpress.XtraCharts.ElasticEasingFunction elasticEasingFunction1 = new DevExpress.XtraCharts.ElasticEasingFunction();
                //DevExpress.XtraCharts.XYSeriesBlowUpAnimation xySeriesBlowUpAnimation1 = new DevExpress.XtraCharts.XYSeriesBlowUpAnimation();
                DevExpress.XtraCharts.XYSeriesUnwindAnimation xySeriesUnwindAnimation1 = new DevExpress.XtraCharts.XYSeriesUnwindAnimation();
                //DevExpress.XtraCharts.XYSeriesUnwrapAnimation xySeriesUnwrapAnimation1 = new DevExpress.XtraCharts.XYSeriesUnwrapAnimation();

                //DevExpress.XtraCharts.PowerEasingFunction powerEasingFunction1 = new DevExpress.XtraCharts.PowerEasingFunction();
                DevExpress.XtraCharts.SineEasingFunction sineEasingFunction1 = new DevExpress.XtraCharts.SineEasingFunction();
                DevExpress.XtraCharts.ConstantLine MinLine = new DevExpress.XtraCharts.ConstantLine();
                DevExpress.XtraCharts.ConstantLine MaxLine = new DevExpress.XtraCharts.ConstantLine();
                DevExpress.XtraCharts.ConstantLine NearMinLine = new DevExpress.XtraCharts.ConstantLine();
                DevExpress.XtraCharts.ConstantLine NearMaxLine = new DevExpress.XtraCharts.ConstantLine();

                //--------- Add data Point------------

                for (int i = 0; i < arg_dt.Rows.Count; i++)
                {

                    if (arg_dt.Rows[i]["VALUE1"] == null || arg_dt.Rows[i]["VALUE1"].ToString() == "")
                        series1.Points.Add(new SeriesPoint(arg_dt.Rows[i]["HMS"].ToString()));
                    else
                        series1.Points.Add(new SeriesPoint(arg_dt.Rows[i]["HMS"].ToString(), arg_dt.Rows[i]["VALUE1"].ToString()));

                    if (arg_dt.Rows[i]["VALUE2"] == null || arg_dt.Rows[i]["VALUE2"].ToString() == "")
                        series2.Points.Add(new SeriesPoint(arg_dt.Rows[i]["HMS"].ToString()));
                    else
                        series2.Points.Add(new SeriesPoint(arg_dt.Rows[i]["HMS"].ToString(), arg_dt.Rows[i]["VALUE2"].ToString()));
                }

                arg_chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] { series1, series2 };
                series1.ArgumentScaleType = ScaleType.Qualitative;
                series2.ArgumentScaleType = ScaleType.Qualitative;


                ((XYDiagram)arg_chart.Diagram).AxisY.ConstantLines.Clear();
                //Min line
                MinLine.AxisValueSerializable = arg_dt.Rows[0]["MIN_VALUE"].ToString();
                MinLine.Color = System.Drawing.Color.Red;
                MinLine.LineStyle.Thickness = 2;
                MinLine.ShowBehind = true;                
                ((XYDiagram)arg_chart.Diagram).AxisY.ConstantLines.AddRange(new DevExpress.XtraCharts.ConstantLine[] { MinLine });
                //Near Min line
                NearMinLine.AxisValueSerializable = (Convert.ToInt32(arg_dt.Rows[0]["MIN_VALUE"].ToString()) + Convert.ToInt32(arg_dt.Rows[0]["NEAR"].ToString())).ToString();
                NearMinLine.Color = System.Drawing.Color.Yellow;
                NearMinLine.LineStyle.Thickness = 2;
                NearMinLine.ShowBehind = true;
                ((XYDiagram)arg_chart.Diagram).AxisY.ConstantLines.AddRange(new DevExpress.XtraCharts.ConstantLine[] { NearMinLine });
                //Max line
                MaxLine.AxisValueSerializable = arg_dt.Rows[0]["MAX_VALUE"].ToString();
                MaxLine.Color = System.Drawing.Color.Red;
                MaxLine.LineStyle.Thickness = 2;
                MaxLine.ShowBehind = true;
                ((XYDiagram)arg_chart.Diagram).AxisY.ConstantLines.AddRange(new DevExpress.XtraCharts.ConstantLine[] { MaxLine });
                //Near Max line
                NearMaxLine.AxisValueSerializable = (Convert.ToInt32(arg_dt.Rows[0]["MAX_VALUE"].ToString()) - Convert.ToInt32(arg_dt.Rows[0]["NEAR"].ToString())).ToString();
                NearMaxLine.Color = System.Drawing.Color.Yellow;
                NearMaxLine.LineStyle.Thickness = 2;
                NearMaxLine.ShowBehind = true;
                ((XYDiagram)arg_chart.Diagram).AxisY.ConstantLines.AddRange(new DevExpress.XtraCharts.ConstantLine[] { NearMaxLine });

                
                //title
                arg_chart.Titles.Add(new ChartTitle());
                arg_chart.Titles[0].Text = arg_name;//arg_name;
                arg_chart.Titles[0].Visibility = DevExpress.Utils.DefaultBoolean.True;
                arg_chart.Titles[0].Font = new Font("Tahoma", 12, FontStyle.Bold);
                arg_chart.Titles[0].Alignment = StringAlignment.Center;
                arg_chart.Titles[0].Dock = ChartTitleDockStyle.Left;
                // format Series 
                //splineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                //splineSeriesView1.Color = System.Drawing.Color.Green;
                //splineSeriesView1.LineMarkerOptions.BorderColor = System.Drawing.Color.DodgerBlue;
                //splineSeriesView1.LineMarkerOptions.BorderVisible = false;
                //splineSeriesView1.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Circle;
                //splineSeriesView1.LineMarkerOptions.Color = System.Drawing.Color.Green;
                //splineSeriesView1.LineMarkerOptions.Size = 1;
                //splineSeriesView1.LineStyle.Thickness = 2;

                //splineSeriesView2.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                //splineSeriesView2.Color = System.Drawing.Color.Black;
                //splineSeriesView2.LineMarkerOptions.BorderColor = System.Drawing.Color.DodgerBlue;
                //splineSeriesView2.LineMarkerOptions.BorderVisible = false;
                //splineSeriesView2.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Circle;
                //splineSeriesView2.LineMarkerOptions.Color = System.Drawing.Color.Green;
                //splineSeriesView2.LineMarkerOptions.Size = 1;
                //splineSeriesView2.LineStyle.Thickness = 2;
                //series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                //series1.Label.TextPattern = "{V:#,#}";
                //series1.View = splineSeriesView1;
                //series2.View = splineSeriesView2;

                

                ((SplineSeriesView)series2.View).Color = Color.Black;
                ((SplineSeriesView)series1.View).Color = Color.Green;
                
                //series1.ShowInLegend = true;

                xySeriesUnwindAnimation1.EasingFunction = sineEasingFunction1;
                splineSeriesView1.SeriesAnimation = xySeriesUnwindAnimation1;
                splineSeriesView2.SeriesAnimation = xySeriesUnwindAnimation1;

                

                arg_chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
                arg_chart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside;
                arg_chart.Legend.AlignmentVertical = LegendAlignmentVertical.Center;
                arg_chart.Legend.Direction = LegendDirection.TopToBottom;
               // arg_chart.Legend.Direction = LegendDirection.TopToBottom;
                arg_chart.Legend.Margins.All = 0;
                arg_chart.Legend.Padding.All = 0;
                arg_chart.Legend.Font = new Font("Tahoma", 10, FontStyle.Bold);
                MaxLine.ShowInLegend = false;
                NearMaxLine.ShowInLegend = false;
                MinLine.ShowInLegend = false;
                NearMinLine.ShowInLegend = false;


                //format Chart
                // ChartLine5.Size = new System.Drawing.Size(858, 157);
                ((XYDiagram)arg_chart.Diagram).AxisX.AutoScaleBreaks.MaxCount = 1;
                ((XYDiagram)arg_chart.Diagram).AxisX.GridLines.Visible = false;
                ((XYDiagram)arg_chart.Diagram).AxisX.Label.ResolveOverlappingOptions.MinIndent = 1;
                ((XYDiagram)arg_chart.Diagram).AxisX.NumericScaleOptions.AutoGrid = true;


                ((XYDiagram)arg_chart.Diagram).AxisX.Label.ResolveOverlappingOptions.AllowHide = false;
                ((XYDiagram)arg_chart.Diagram).AxisX.Label.ResolveOverlappingOptions.AllowStagger = false;
                ((XYDiagram)arg_chart.Diagram).AxisX.Label.Font = new Font("Tahoma", 10, FontStyle.Bold);
                ((XYDiagram)arg_chart.Diagram).AxisY.Label.Font = new Font("Tahoma", 10, FontStyle.Bold);

                ((XYDiagram)arg_chart.Diagram).AxisX.Label.Visible = true;
                //((XYDiagram)arg_chart.Diagram).AxisY.NumericScaleOptions.AutoGrid = false;

                
                ((XYDiagram)arg_chart.Diagram).AxisY.WholeRange.Auto = true;

                

                ((XYDiagram)arg_chart.Diagram).AxisY.WholeRange.SetMinMaxValues(Convert.ToInt32(arg_dt.Rows[0]["MIN_VALUE"].ToString()) - 1, Convert.ToInt32(arg_dt.Rows[0]["MAX_VALUE"].ToString()) + 1);
                //((XYDiagram)arg_chart.Diagram).Margins.Bottom = 20;
                //((XYDiagram)arg_chart.Diagram).Margins.Left = 20;
                //((XYDiagram)arg_chart.Diagram).Margins.Right = 20;
                //((XYDiagram)arg_chart.Diagram).Margins.Top = 20;
                //---------------add chart in panel
                groupBoxEx2.Controls.Add(arg_chart);
            }
            catch 
            { }

            
        }

        private void showTemperature(DataTable dt, int _iPercent)
        {
            int min_kned1_mc, min_kned1_mat, min_roll1, min_extr1, min_pell1, min_kned2_mc, min_kned2_mat, min_roll2, min_cald;
            int max_kned1_mc, max_kned1_mat, max_roll1, max_extr1, max_pell1, max_kned2_mc, max_kned2_mat, max_roll2, max_cald;


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["MLINE_CD"].ToString() == "KD101")
                {
                    if (Convert.ToInt32(dt.Rows[i]["KNEADER_MC"].ToString()) * _iPercent / 100 > 0)
                    {
                        int.TryParse(dt.Rows[i]["KNED_MC_MIN"].ToString(), out min_kned1_mc);
                        int.TryParse(dt.Rows[i]["KNED_MC_MAX"].ToString(), out max_kned1_mc);

                        AddRange(lnScaleC2Line2KnMC, linearRangeLine2KnMC1, 0, min_kned1_mc, Color.Red, linearRangeLine2KnMC2, min_kned1_mc, max_kned1_mc, Color.Green, linearRangeLine2KnMC3, max_kned1_mc, Convert.ToInt32(dt.Rows[i]["KNEADER_MC"].ToString()) + 20, Color.Red);
                        showTempByGause(lnScaleC1Line2KnMC, Convert.ToInt32(dt.Rows[i]["KNEADER_MC"].ToString()) * _iPercent / 100, 0, Convert.ToInt32(dt.Rows[i]["KNEADER_MC"].ToString()) + 20, lblLine2KnMC);
                        showTempByGause(lnScaleC2Line2KnMC, 0, 0, Convert.ToInt32(dt.Rows[i]["KNEADER_MC"].ToString()) + 20, null);

                        if (lnScaleC1Line2KnMC.Value < min_kned1_mc || lnScaleC1Line2KnMC.Value > max_kned1_mc)
                        {
                            lblLine2KnMC.BackColor = Color.Red;
                        }
                        else
                        {
                            lblLine2KnMC.BackColor = Color.Green;
                        }


                    }
                    if (Convert.ToInt32(dt.Rows[i]["ROLL"].ToString()) * _iPercent / 100 > 0)
                    {
                        int.TryParse(dt.Rows[i]["ROLL_MC_MIN"].ToString(), out min_roll1);
                        int.TryParse(dt.Rows[i]["ROLL_MC_MAX"].ToString(), out max_roll1);

                        AddRange(lnScaleC2Line2RollMC, linearRangeLine2RollMC1, 0, min_roll1, Color.Red, linearRangeLine2RollMC2, min_roll1, max_roll1, Color.Green, linearRangeLine2RollMC3, max_roll1, Convert.ToInt32(dt.Rows[i]["ROLL"].ToString()) + 20, Color.Red);

                        showTempByGause(lnScaleC1Line2RollMC, Convert.ToInt32(dt.Rows[i]["ROLL"].ToString()) * _iPercent / 100, 0, Convert.ToInt32(dt.Rows[i]["ROLL"].ToString()) + 20, lblLine2RollMC);

                        showTempByGause(lnScaleC2Line2RollMC, 0, 0, Convert.ToInt32(dt.Rows[i]["ROLL"].ToString()) + 20, null);
                        if (lnScaleC1Line2RollMC.Value < min_roll1 || lnScaleC1Line2RollMC.Value > max_roll1)
                        {
                            lblLine2RollMC.BackColor = Color.Red;
                        }
                        else
                        {
                            lblLine2RollMC.BackColor = Color.Green;
                        }
                    }

                    if (Convert.ToInt32(dt.Rows[i]["KNEADER_MAT"].ToString()) * _iPercent / 100 > 0)
                    {
                        int.TryParse(dt.Rows[i]["KNED_SEED_MIN"].ToString(), out min_kned1_mat);
                        int.TryParse(dt.Rows[i]["KNED_SEED_MAX"].ToString(), out max_kned1_mat);

                        showTempByGause(arcScaleC1Line2KnMat, Convert.ToInt32(dt.Rows[i]["KNEADER_MAT"].ToString()) * _iPercent / 100, 0, Convert.ToInt32(dt.Rows[i]["KNEADER_MAT"].ToString()) + 20, lblLine2KnMat);
                        AddRange(arcScaleC1Line2KnMat, linearRangeLine2KnMtl1, 0, min_kned1_mat, Color.Red, linearRangeLine2KnMtl2, min_kned1_mat, max_kned1_mat, Color.Green, linearRangeLine2KnMtl3, max_kned1_mat, Convert.ToInt32(dt.Rows[i]["KNEADER_MAT"].ToString()) + 20, Color.Red);
                        if (arcScaleC1Line2KnMat.Value < min_kned1_mat || arcScaleC1Line2KnMat.Value > max_kned1_mat)
                        {
                            lblLine2KnMat.BackColor = Color.Red;

                        }
                        else
                        {
                            lblLine2KnMat.BackColor = Color.Green;
                        }
                    }
                    if (Convert.ToInt32(dt.Rows[i]["EXTRUDER"].ToString()) * _iPercent / 100 > 0)
                    {
                        int.TryParse(dt.Rows[i]["EXTR_MAT_MIN"].ToString(), out min_extr1);
                        int.TryParse(dt.Rows[i]["EXTR_MAT_MAX"].ToString(), out max_extr1);

                        showTempByGause(arcScaleC1Line2ExtMat, Convert.ToInt32(dt.Rows[i]["EXTRUDER"].ToString()) * _iPercent / 100, 0, Convert.ToInt32(dt.Rows[i]["EXTRUDER"].ToString()) + 20, lblLine2ExtMat);
                        AddRange(arcScaleC1Line2ExtMat, linearRangeLine2ExtMtl1, 0, min_extr1, Color.Red, linearRangeLine2ExtMtl2, min_extr1, max_extr1, Color.Green, linearRangeLine2ExtMtl3, max_extr1, Convert.ToInt32(dt.Rows[i]["EXTRUDER"].ToString()) + 20, Color.Red);

                        if (arcScaleC1Line2ExtMat.Value < min_extr1 || arcScaleC1Line2ExtMat.Value > max_extr1)
                        {
                            lblLine2ExtMat.BackColor = Color.Red;
                        }
                        else
                        {
                            lblLine2ExtMat.BackColor = Color.Green;
                        }
                    }
                    if (Convert.ToInt32(dt.Rows[i]["PELLET_SEED"].ToString()) * _iPercent / 100 > 0)
                    {
                        int.TryParse(dt.Rows[i]["PELL_SEED_MIN"].ToString(), out min_pell1);
                        int.TryParse(dt.Rows[i]["PELL_SEED_MAX"].ToString(), out max_pell1);

                        showTempByGause(arcScaleC1Line2PalSeed, Convert.ToInt32(dt.Rows[i]["PELLET_SEED"].ToString()) * _iPercent / 100, 0, Convert.ToInt32(dt.Rows[i]["PELLET_SEED"].ToString()) + 20, lblLine2PalSeed);
                        AddRange(arcScaleC1Line2PalSeed, linearRangeLine2PalSeed1, 0, min_pell1, Color.Red, linearRangeLine2PalSeed2, min_pell1, max_pell1, Color.Green, linearRangeLine2PalSeed3, max_pell1, Convert.ToInt32(dt.Rows[i]["PELLET_SEED"].ToString()) + 20, Color.Red);
                        if (arcScaleC1Line2PalSeed.Value < min_pell1 || arcScaleC1Line2PalSeed.Value > max_pell1)
                        {
                            lblLine2PalSeed.BackColor = Color.Red;
                        }
                        else
                        {
                            lblLine2PalSeed.BackColor = Color.Green;
                        }
                    }

                }

                if (dt.Rows[i]["MLINE_CD"].ToString() == "KD102")
                {
                    if (Convert.ToInt32(dt.Rows[i]["KNEADER_MC"].ToString()) * _iPercent / 100 > 0)
                    {
                        int.TryParse(dt.Rows[i]["KNED_MC_MIN"].ToString(), out min_kned2_mc);
                        int.TryParse(dt.Rows[i]["KNED_MC_MAX"].ToString(), out max_kned2_mc);

                        AddRange(lnScaleC2Line3KnMC, linearRangeLine3KnMC1, 0, min_kned2_mc, Color.Red, linearRangeLine3KnMC2, min_kned2_mc, max_kned2_mc, Color.Green, linearRangeLine3KnMC3, max_kned2_mc, Convert.ToInt32(dt.Rows[i]["KNEADER_MC"].ToString()) + 20, Color.Red);
                        showTempByGause(lnScaleC1Line3KnMC, Convert.ToInt32(dt.Rows[i]["KNEADER_MC"].ToString()) * _iPercent / 100, 0, Convert.ToInt32(dt.Rows[i]["KNEADER_MC"].ToString()) + 20, lblLine3KnMC);
                        showTempByGause(lnScaleC2Line3KnMC, 0, 0, Convert.ToInt32(dt.Rows[i]["KNEADER_MC"].ToString()) + 20, null);
                        if (lnScaleC1Line3KnMC.Value < min_kned2_mc || lnScaleC1Line3KnMC.Value > max_kned2_mc)
                        {
                            lblLine3KnMC.BackColor = Color.Red;
                        }
                        else
                        {
                            lblLine3KnMC.BackColor = Color.Green;
                        }

                    }
                    if (Convert.ToInt32(dt.Rows[i]["ROLL"].ToString()) * _iPercent / 100 > 0)
                    {
                        int.TryParse(dt.Rows[i]["ROLL_MC_MIN"].ToString(), out min_roll2);
                        int.TryParse(dt.Rows[i]["ROLL_MC_MAX"].ToString(), out max_roll2);
                        AddRange(lnScaleC2Line3RollMC, linearRangeLine3RollMC1, 0, min_roll2, Color.Red, linearRangeLine3RollMC2, min_roll2, max_roll2, Color.Green, linearRangeLine3RollMC3, max_roll2, Convert.ToInt32(dt.Rows[i]["ROLL"].ToString()) + 20, Color.Red);
                        showTempByGause(lnScaleC1Line3RollMC, Convert.ToInt32(dt.Rows[i]["ROLL"].ToString()) * _iPercent / 100, 0, Convert.ToInt32(dt.Rows[i]["ROLL"].ToString()) + 20, lblLine3RollMC);
                        showTempByGause(lnScaleC2Line3RollMC, 0, 0, Convert.ToInt32(dt.Rows[i]["ROLL"].ToString()) + 20, null);

                        if (lnScaleC1Line3RollMC.Value < min_roll2 || lnScaleC1Line3RollMC.Value > max_roll2)
                        {
                            lblLine3RollMC.BackColor = Color.Red;
                        }
                        else
                        {
                            lblLine3RollMC.BackColor = Color.Green;
                        }
                    }
                    if (Convert.ToInt32(dt.Rows[i]["KNEADER_MAT"].ToString()) * _iPercent / 100 > 0)
                    {
                        int.TryParse(dt.Rows[i]["KNED_SEED_MIN"].ToString(), out min_kned2_mat);
                        int.TryParse(dt.Rows[i]["KNED_SEED_MAX"].ToString(), out max_kned2_mat);

                        showTempByGause(arcScaleC1Line3KnMat, Convert.ToInt32(dt.Rows[i]["KNEADER_MAT"].ToString()) * _iPercent / 100, 0, Convert.ToInt32(dt.Rows[i]["KNEADER_MAT"].ToString()) + 20, lblLine3KnMat);
                        AddRange(arcScaleC1Line3KnMat, linearRangeLine3KnMtl1, 0, min_kned2_mat, Color.Red, linearRangeLine3KnMtl2, min_kned2_mat, max_kned2_mat, Color.Green, linearRangeLine3KnMtl3, max_kned2_mat, Convert.ToInt32(dt.Rows[i]["KNEADER_MAT"].ToString()) + 20, Color.Red);
                        if (arcScaleC1Line3KnMat.Value < min_kned2_mat || arcScaleC1Line3KnMat.Value > max_kned2_mat)
                        {
                            lblLine3KnMat.BackColor = Color.Red;

                        }
                        else
                        {
                            lblLine3KnMat.BackColor = Color.Green;
                        }
                    }
                    //if (Convert.ToInt32(dt.Rows[i]["EXTRUDER"].ToString()) * _iPercent / 100 > 0)
                    //{
                    //    showTempByGause(arcScaleC1Line3ExtMat, Convert.ToInt32(dt.Rows[i]["EXTRUDER"].ToString()) * _iPercent / 100, 0, Convert.ToInt32(dt.Rows[i]["EXTRUDER"].ToString()) + 20, lblLine3ExtMat);
                    //    AddRange(arcScaleC1Line3ExtMat, linearRangeLine3ExtMtl1, 0, 65, Color.Red, linearRangeLine3ExtMtl2, 65, 95, Color.Green, linearRangeLine3ExtMtl3, 95, Convert.ToInt32(dt.Rows[i]["EXTRUDER"].ToString()) + 20, Color.Red);
                    //    if (arcScaleC1Line3ExtMat.Value < 65 || arcScaleC1Line3ExtMat.Value > 95)
                    //    {
                    //        lblLine3ExtMat.BackColor = Color.Red;
                    //    }
                    //    else
                    //    {
                    //        lblLine3ExtMat.BackColor = Color.DodgerBlue;
                    //    }

                    //}
                    if (Convert.ToInt32(dt.Rows[i]["CALD_MC"].ToString()) * _iPercent / 100 > 0)
                    {
                        int.TryParse(dt.Rows[i]["CALD_SEED_MIN"].ToString(), out min_cald);
                        int.TryParse(dt.Rows[i]["CALD_SEED_MAX"].ToString(), out max_cald);

                        showTempByGause(arcScaleC1Line3PalSeed, Convert.ToInt32(dt.Rows[i]["CALD_MC"].ToString()) * _iPercent / 100, 0, Convert.ToInt32(dt.Rows[i]["CALD_MC"].ToString()) + 20, lblLine3PalSeed);
                        AddRange(arcScaleC1Line3PalSeed, linearRangeLine3PalSeed1, 0, min_cald, Color.Red, linearRangeLine3PalSeed2, min_cald, max_cald, Color.Green, linearRangeLine3PalSeed3, max_cald, Convert.ToInt32(dt.Rows[i]["CALD_MC"].ToString()) + 20, Color.Red);
                        if (arcScaleC1Line3PalSeed.Value < min_cald || arcScaleC1Line3PalSeed.Value > max_cald)
                        {
                            lblLine3PalSeed.BackColor = Color.Red;
                        }
                        else
                        {
                            lblLine3PalSeed.BackColor = Color.Green;
                        }

                    }
                }
            }
        }

        private void showTempByGause(DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent lnScaleComp, int iValue, int iMinValue, int iMaxValue, System.Windows.Forms.Label lblTitle)
        {
            lnScaleComp.Value = iValue;
            lnScaleComp.MinValue = iMinValue;
            lnScaleComp.MaxValue = iMaxValue;
            if (lblTitle != null)
            {
                lblTitle.Text = iValue.ToString();
            }



        }
      
        private void showTempByGause(DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComp, int iValue, int iMinValue, int iMaxValue, System.Windows.Forms.Label lblTitle)
        {
            arcScaleComp.Value = iValue;
            arcScaleComp.MinValue = iMinValue;
            arcScaleComp.MaxValue = iMaxValue;
            if (lblTitle != null)
            {
                lblTitle.Text = iValue.ToString();
            }
        }

        private void AddRange(DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent lnScaleComponent,
                      DevExpress.XtraGauges.Core.Model.LinearScaleRange lnScaleRange0, int iStartValue0, int iEndValue0, Color color0,
                      DevExpress.XtraGauges.Core.Model.LinearScaleRange lnScaleRange1, int iStartValue1, int iEndValue1, Color color1,
                      DevExpress.XtraGauges.Core.Model.LinearScaleRange lnScaleRange2, int iStartValue2, int iEndValue2, Color color2)
        {
            if (lnScaleComponent.Ranges.Count > 0)
                return;
            lnScaleRange0.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject(color0);
            lnScaleRange0.StartValue = iStartValue0;
            lnScaleRange0.EndValue = iEndValue0;
            lnScaleRange0.Name = lnScaleRange0.ToString();
            lnScaleComponent.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            lnScaleRange0});

            lnScaleRange1.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject(color1);
            lnScaleRange1.StartValue = iStartValue1;
            lnScaleRange1.EndValue = iEndValue1;
            lnScaleRange1.Name = lnScaleRange1.ToString();
            lnScaleComponent.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            lnScaleRange1});

            lnScaleRange2.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject(color2);
            lnScaleRange2.StartValue = iStartValue2;
            lnScaleRange2.EndValue = iEndValue2;
            lnScaleRange2.Name = lnScaleRange2.ToString();
            lnScaleComponent.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            lnScaleRange2});
        }

        private void AddRange(DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent lnScaleComponent, DevExpress.XtraGauges.Core.Model.LinearScaleRange lnScaleRange, int iStartValue, int iEndValue, Color color)
        {
            if (lnScaleComponent.Ranges.Count > 0)
                return;
            lnScaleRange.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject(color);
            lnScaleRange.StartValue = iStartValue;
            lnScaleRange.EndValue = iEndValue;
            lnScaleRange.Name = lnScaleRange.ToString();
            lnScaleComponent.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            lnScaleRange});
        }

        private void AddRange(DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent lnScaleComponent,
                              DevExpress.XtraGauges.Core.Model.LinearScaleRange lnScaleRange0, int iStartValue0, int iEndValue0, Color color0,
                              DevExpress.XtraGauges.Core.Model.LinearScaleRange lnScaleRange1, int iStartValue1, int iEndValue1, Color color1)
        {
            if (lnScaleComponent.Ranges.Count > 0)
                return;
            lnScaleRange0.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject(color0);
            lnScaleRange0.StartValue = iStartValue0;
            lnScaleRange0.EndValue = iEndValue0;
            lnScaleRange0.Name = lnScaleRange0.ToString();
            lnScaleComponent.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            lnScaleRange0});

            lnScaleRange1.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject(color1);
            lnScaleRange1.StartValue = iStartValue1;
            lnScaleRange1.EndValue = iEndValue1;
            lnScaleRange1.Name = lnScaleRange1.ToString();
            lnScaleComponent.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            lnScaleRange1});
        }

        private void AddRange(DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent,
              DevExpress.XtraGauges.Core.Model.ArcScaleRange lnScaleRange0, int iStartValue0, int iEndValue0, Color color0,
              DevExpress.XtraGauges.Core.Model.ArcScaleRange lnScaleRange1, int iStartValue1, int iEndValue1, Color color1,
              DevExpress.XtraGauges.Core.Model.ArcScaleRange lnScaleRange2, int iStartValue2, int iEndValue2, Color color2)
        {
            if (arcScaleComponent.Ranges.Count > 0)
                return;
            lnScaleRange0.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject(color0);
            lnScaleRange0.StartValue = iStartValue0;
            lnScaleRange0.EndValue = iEndValue0;
            lnScaleRange0.Name = lnScaleRange0.ToString();
            arcScaleComponent.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            lnScaleRange0});

            lnScaleRange1.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject(color1);
            lnScaleRange1.StartValue = iStartValue1;
            lnScaleRange1.EndValue = iEndValue1;
            lnScaleRange1.Name = lnScaleRange1.ToString();
            arcScaleComponent.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            lnScaleRange1});

            lnScaleRange2.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject(color2);
            lnScaleRange2.StartValue = iStartValue2;
            lnScaleRange2.EndValue = iEndValue2;
            lnScaleRange2.Name = lnScaleRange2.ToString();
            arcScaleComponent.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            lnScaleRange2});
        }


        private void LoadData()
        {
            dt_Data = this.select_temp();

            _time_load = 0;
            iPercent = 0;
            // cnt = 0;

            if (dt_Data != null)
                _dt = dt_Data;

            if (_dt != null)
            {
                timer3.Start();
            }
            CreateChartLine(ChartLine1, this.select_temp_sum("KNED", "001"), "Kneader - M/C");
            CreateChartLine(ChartLine2, this.select_temp_sum("ROLL", "001"), "Roll");
            CreateChartLine(ChartLine3, this.select_temp_sum("EXTR", "001"), "Extruder");
            CreateChartLine(ChartLine4, this.select_temp_sum("PELL", "001"), "Pelletizing");
            CreateChartLine(ChartLine5, this.select_temp_sum("CALD", "001"), "Calender");

        }

        private void blindLabel(DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent lnScaleComp, int iMinValue, int iMaxValue, System.Windows.Forms.Label lbl)
        {
            try
            {
                if (lnScaleComp.Value == 0) return;
                if (lnScaleComp.Value < iMinValue || lnScaleComp.Value > iMaxValue)
                {
                    lbl.BackColor = preverColor(lbl.BackColor);
                }
            }
            catch 
            {

            }
        }

        #endregion Method

        #region DB
        private DataTable select_temp_sum(string arg_mline_cd, string arg_mc_id)
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = "MES.PKG_SMT_PROD_SHOW.SEL_EVA_TEMP_TRACKING";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "ARG_MLINE_CD";
            MyOraDB.Parameter_Name[1] = "ARG_MC_ID";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_mline_cd;
            MyOraDB.Parameter_Values[1] = arg_mc_id;
            MyOraDB.Parameter_Values[2] = "";




            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }

        private DataTable select_temp()
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "MES.PKG_SMT_PROD_SHOW.SEL_EVA_SUMMARY_TEMP_TRACKING";

            //02.ARGURMENT ¢¬i

            MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC


            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;


            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }

        #endregion DB

        #region Event
        private void FORM_ROLL_DATA_TRACKING_V3_Load(object sender, EventArgs e)
        {
            try
            {
                //Com_Base.Functions.Form_Maximized(this, int.Parse(Com_Base.Variables.Form[idx_form]["monitor"]));
               // lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
                pnEVA.GradientEndColor = Color.White; //Color.FromArgb(255, 128, 128);
                pnRubber.GradientEndColor = Color.Gray;

                

                GoFullscreen(true);
                tmrLoad.Interval = 1000;
                timer3.Interval = 100;
                lblTitle.Text = "Eva Temperature Tracking";
                pnButton.Visible = false;
            }
            catch
            {}
        }

        private void FORM_ROLL_DATA_TRACKING_V3_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                _IReload = 29;
                tmrLoad.Start();
                
            }
            else
            {
                tmrLoad.Stop();
            }
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FORM_ROLL_DATA_TRACKING_V3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        #endregion Event


        #region Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            _IReload++;
            if (_IReload >= 30)
            {
                LoadData();
                _IReload = 0;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (iPercent >= 100)
            {
                iPercent = 0;
                timer3.Stop();
                tmrBlind.Interval = 500;
                tmrBlind.Start();
            }
            else
            {
                tmrBlind.Stop();
                iPercent += 2;
                showTemperature(_dt, iPercent);
            }
        }

        private void tmrBlind_Tick(object sender, EventArgs e)
        {


            blindLabel(this.lnScaleC1Line2KnMC, Convert.ToInt32(_dt.Rows[0]["KNED_MC_MIN"].ToString()), Convert.ToInt32(_dt.Rows[0]["KNED_MC_MAX"].ToString()), this.lblLine2KnMC);
            blindLabel(this.lnScaleC1Line3KnMC, Convert.ToInt32(_dt.Rows[1]["KNED_MC_MIN"].ToString()), Convert.ToInt32(_dt.Rows[1]["KNED_MC_MAX"].ToString()), this.lblLine3KnMC);
           // blindLabel(this.lnScaleC1Line4KnMC, 70, 80, this.lblLine4KnMC);

            blindLabel(this.arcScaleC1Line2KnMat, Convert.ToInt32(_dt.Rows[0]["KNED_SEED_MIN"].ToString()), Convert.ToInt32(_dt.Rows[0]["KNED_SEED_MAX"].ToString()), this.lblLine2KnMat);
            blindLabel(this.arcScaleC1Line3KnMat, Convert.ToInt32(_dt.Rows[1]["KNED_SEED_MIN"].ToString()), Convert.ToInt32(_dt.Rows[1]["KNED_SEED_MAX"].ToString()), this.lblLine3KnMat);
            //blindLabel(this.arcScaleC1Line4KnMat, 98, 118, this.lblLine4KnMat);


            blindLabel(this.lnScaleC1Line2RollMC, Convert.ToInt32(_dt.Rows[0]["ROLL_MC_MIN"].ToString()), Convert.ToInt32(_dt.Rows[0]["ROLL_MC_MAX"].ToString()), this.lblLine2RollMC);
            blindLabel(this.lnScaleC1Line3RollMC, Convert.ToInt32(_dt.Rows[1]["ROLL_MC_MIN"].ToString()), Convert.ToInt32(_dt.Rows[1]["ROLL_MC_MAX"].ToString()), this.lblLine3RollMC);
           // blindLabel(this.lnScaleC1Line4RollMC, 55, 65, this.lblLine4RollMC);

            blindLabel(this.arcScaleC1Line2ExtMat, Convert.ToInt32(_dt.Rows[0]["EXTR_MAT_MIN"].ToString()), Convert.ToInt32(_dt.Rows[0]["EXTR_MAT_MAX"].ToString()), this.lblLine2ExtMat);
           // blindLabel(this.arcScaleC1Line3ExtMat, 65, 95, this.lblLine3ExtMat);
           // blindLabel(this.arcScaleC1Line4ExtMat, 65, 95, this.lblLine4ExtMat);

            blindLabel(this.arcScaleC1Line2PalSeed, Convert.ToInt32(_dt.Rows[0]["PELL_SEED_MIN"].ToString()), Convert.ToInt32(_dt.Rows[0]["PELL_SEED_MAX"].ToString()), this.lblLine2PalSeed);
            blindLabel(this.arcScaleC1Line3PalSeed, Convert.ToInt32(_dt.Rows[1]["CALD_SEED_MIN"].ToString()), Convert.ToInt32(_dt.Rows[1]["CALD_SEED_MAX"].ToString()), this.lblLine3PalSeed);

            blindLabel(this.arcScaleC1Line4PalSeed, 18, 38, this.lblLine4PalSeed);


        }

        #endregion Timer







        #region No use

        #region Declare
        Thread th;
        //public Smart_FTY.ClassLib.Class_Sound sound = new Smart_FTY.ClassLib.Class_Sound("critical.wav");
        public static bool isAlarm = false;
        DataTable dt_Data = null;
        
        DataTable dt_Kneader_Label = null;
        DataTable dt_Roll_Label = null;
        DataTable dt_Extruder_Label = null;
        DataTable dt_Palletizing_Label = null;

        int iPercent = 0;

        int _time_load = 0;

        int chart_width = 855;
        int chart_height = 155;

        int plot_width = 800;
        int plot_hight = 125;

        int legend_x = 320;
        int legend_y = 25;

        public string[] dataMLINE = { "002", "003", "004" };

        public static int iIndex = 0;
        public static int iNumMC = 2;
        public static int iIndexMLine = 0;
        public static int iNumMLine = 3;
        public static int iWarningGap = 2;
        public static int _indexKneaderLine2 = 0;
        public static int _indexKneaderLine3 = 0;
        public static int _indexKneaderLine4 = 0;
        public static int _indexRollLine2 = 0;
        public static int _indexRollLine3 = 0;
        public static int _indexRollLine4 = 0;
        public static int _indexExtruderLine2 = 0;
        public static int _indexExtruderLine3 = 0;
        public static int _indexExtruderLine4 = 0;
        public static int _indexPelletingLine2 = 0;
        public static int _indexPelletingLine3 = 0;
        public static int _indexPelletingLine4 = 0;

        public static int iNumRowKneaderLine2 = 60;
        public static int iNumRowKneaderLine3 = 60;
        public static int iNumRowKneaderLine4 = 60;
        public static int iNumRowKneader = 60;
        double[] dataMinKneader = new double[iNumRowKneader];
        double[] dataNearMinKneader = new double[iNumRowKneader];
        double[] dataValueKneaderLine2 = new double[iNumRowKneader];
        double[] dataValueKneaderLine3 = new double[iNumRowKneader];
        double[] dataValueKneaderLine4 = new double[iNumRowKneader];
        double[] dataValueKneaderRTLine2 = new double[iNumRowKneader];
        double[] dataValueKneaderRTLine3 = new double[iNumRowKneader];
        double[] dataValueKneaderRTLine4 = new double[iNumRowKneader];
        string[] dataLabelKneader = new string[iNumRowKneader];
        double[] dataMaxKneader = new double[iNumRowKneader];
        double[] dataNearMaxKneader = new double[iNumRowKneader];
        double[] dataChartMaxKneader = { 0, 0 };
        string[] dataKneader = { "001", "002" };
        DataTable dt_Data_KneaderLine2 = null;
        DataTable dt_Data_KneaderLine3 = null;
        DataTable dt_Data_KneaderLine4 = null;
        DataTable dt_Data_Max_Kneader = null;


        public static int iNumRowRoll = 60;
        public static int iNumRowRollLine2 = 60;
        public static int iNumRowRollLine3 = 60;
        public static int iNumRowRollLine4 = 60;
        double[] dataMinRoll = new double[iNumRowRoll];
        double[] dataNearMinRoll = new double[iNumRowRoll];
        double[] dataValueRollLine2 = new double[iNumRowRoll];
        double[] dataValueRollLine3 = new double[iNumRowRoll];
        double[] dataValueRollLine4 = new double[iNumRowRoll];
        double[] dataValueRollRTLine2 = new double[iNumRowRoll];
        double[] dataValueRollRTLine3 = new double[iNumRowRoll];
        double[] dataValueRollRTLine4 = new double[iNumRowRoll];
        string[] dataLabelRoll = new string[iNumRowRoll];
        double[] dataMaxRoll = new double[iNumRowRoll];
        double[] dataNearMaxRoll = new double[iNumRowRoll];
        double[] dataChartMaxRoll = { 0, 0 };
        string[] dataRoll = { "003", "003" };
        DataTable dt_Data_RollLine2 = null;
        DataTable dt_Data_RollLine3 = null;
        DataTable dt_Data_RollLine4 = null;
        DataTable dt_Data_Max_Roll = null;


        public static int iNumRowExtruder = 60;
        public static int iNumRowExtruderLine2 = 60;
        public static int iNumRowExtruderLine3 = 60;
        public static int iNumRowExtruderLine4 = 60;
        double[] dataMinExtruder = new double[iNumRowExtruder];
        double[] dataNearMinExtruder = new double[iNumRowExtruder];
        double[] dataValueExtruderLine2 = new double[iNumRowExtruder];
        double[] dataValueExtruderLine3 = new double[iNumRowExtruder];
        double[] dataValueExtruderLine4 = new double[iNumRowExtruder];
        double[] dataValueExtruderRTLine2 = new double[iNumRowExtruder];
        double[] dataValueExtruderRTLine3 = new double[iNumRowExtruder];
        double[] dataValueExtruderRTLine4 = new double[iNumRowExtruder];
        string[] dataLabelExtruder = new string[iNumRowExtruder];
        double[] dataMaxExtruder = new double[iNumRowExtruder];
        double[] dataNearMaxExtruder = new double[iNumRowExtruder];
        double[] dataChartMaxExtruder = { 0, 0 };
        string[] dataExtruder = { "009", "009" };
        DataTable dt_Data_ExtruderLine2 = null;
        DataTable dt_Data_ExtruderLine3 = null;
        DataTable dt_Data_ExtruderLine4 = null;
        DataTable dt_Data_Max_Extruder = null;


        public static int iNumRowPelletizing = 60;
        public static int iNumRowPelletizingLine2 = 60;
        public static int iNumRowPelletizingLine3 = 60;
        public static int iNumRowPelletizingLine4 = 60;
        double[] dataMinPelletizing = new double[iNumRowPelletizing];
        double[] dataNearMinPelletizing = new double[iNumRowPelletizing];
        double[] dataValuePelletizingLine2 = new double[iNumRowPelletizing];
        double[] dataValuePelletizingLine3 = new double[iNumRowPelletizing];
        double[] dataValuePelletizingLine4 = new double[iNumRowPelletizing];
        double[] dataValuePelletizingRTLine2 = new double[iNumRowPelletizing];
        double[] dataValuePelletizingRTLine3 = new double[iNumRowPelletizing];
        double[] dataValuePelletizingRTLine4 = new double[iNumRowPelletizing];
        string[] dataLabelPelletizing = new string[iNumRowPelletizing];
        double[] dataMaxPelletizing = new double[iNumRowPelletizing];
        double[] dataNearMaxPelletizing = new double[iNumRowPelletizing];
        double[] dataChartMaxPelletizing = { 0, 0 };
        string[] dataPelletizing = { "008", "008" };
        DataTable dt_Data_PelletizingLine2 = null;
        DataTable dt_Data_PelletizingLine3 = null;
        DataTable dt_Data_PelletizingLine4 = null;
        DataTable dt_Data_Max_Pelletizing = null;


        private int idx_form;
        #endregion

        #region Creation
        public FORM_EVA_TEMP_TRACKING()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            //  idx_form = arg_idx;
            //sound = new ClassLib.Class_Sound("critical.wav");
        }

        public FORM_EVA_TEMP_TRACKING(int arg_idx = 0)
        {
            InitializeComponent();
            idx_form = arg_idx;
        }
        #endregion

       

        #region Method
        private void Search_Data()
        {
            dt_Data = this.select_summary_data_roll();
            if (dt_Data != null)
                _dt = dt_Data;

            if (_dt != null)
            {
                timer3.Interval = 100;
                timer3.Start();
                tmrUpdateKneader.Interval = 100;
                tmrUpdateKneader.Start();
                tmrUpdateRoll.Interval = 100;
                tmrUpdateRoll.Start();
                tmrUpdateExtruder.Interval = 100;
                tmrUpdateExtruder.Start();
                tmrUpdatePelleting.Interval = 100;
                tmrUpdatePelleting.Start();

            }


            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));

        }
        
     
        private void Search_Summary()
        {
            Set_Default_Array();

            SearchDataKneader();
            SearchDataRoll();
            SearchDataExtruder();
            SearchDataPelletizing();

            if (dt_Kneader_Label != null && dt_Kneader_Label.Rows.Count > 0)
            {
                for (int i = 0; i < iNumRowKneader; i++)
                {
                    if (i % 5 == 0)
                    {

                        dataLabelKneader[i] = dt_Kneader_Label.Rows[i]["hms"].ToString();
                    }
                    else
                    {
                        dataLabelKneader[i] = "";
                    }

                    dataMinKneader[i] = Convert.ToDouble(dt_Kneader_Label.Rows[i]["min_value"].ToString());
                    dataMaxKneader[i] = Convert.ToDouble(dt_Kneader_Label.Rows[i]["max_value"].ToString());

                    dataNearMinKneader[i] =  Convert.ToDouble(dt_Kneader_Label.Rows[i]["min_value"].ToString()) + iWarningGap;
                    dataNearMaxKneader[i] =  Convert.ToDouble(dt_Kneader_Label.Rows[i]["max_value"].ToString()) - iWarningGap;

                    //dataValueKneaderLine2[i] = Convert.ToDouble(dt_Data_KneaderLine2.Rows[i]["value1"].ToString());
                    //dataMinKneader[i] = 65;//Convert.ToDouble(dt_Kneader_Label.Rows[i]["min_value"].ToString());
                    //dataMaxKneader[i] = 80;//Convert.ToDouble(dt_Kneader_Label.Rows[i]["max_value"].ToString());

                    //dataNearMinKneader[i] = 65 + iWarningGap;// Convert.ToDouble(dt_Kneader_Label.Rows[i]["min_value"].ToString()) + iWarningGap;
                    //dataNearMaxKneader[i] = 80 - iWarningGap;// Convert.ToDouble(dt_Kneader_Label.Rows[i]["max_value"].ToString()) - iWarningGap;


                }

            }

            if (dt_Data_KneaderLine2 != null && dt_Data_KneaderLine2.Rows.Count > 0)
            {
                for (int i = 0; i < iNumRowKneaderLine2; i++)
                {

                    dataValueKneaderLine2[i] = Convert.ToDouble(dt_Data_KneaderLine2.Rows[i]["value1"].ToString());


                }

            }

            if (dt_Data_KneaderLine3 != null && dt_Data_KneaderLine3.Rows.Count > 0)
            {
                for (int i = 0; i < iNumRowKneaderLine3; i++)
                {
                   
                    dataValueKneaderLine3[i] = Convert.ToDouble(dt_Data_KneaderLine3.Rows[i]["value1"].ToString());
                 

                }

            }
            if (dt_Data_KneaderLine4 != null && dt_Data_KneaderLine4.Rows.Count > 0)
            {
                for (int i = 0; i < iNumRowKneaderLine4; i++)
                {
                   
                    dataValueKneaderLine4[i] = Convert.ToDouble(dt_Data_KneaderLine4.Rows[i]["value1"].ToString());
                   

                }

            }

            if (dt_Roll_Label != null && dt_Roll_Label.Rows.Count > 0)
            {
                for (int i = 0; i < iNumRowRoll; i++)
                {
                    if (i % 5 == 0)
                    {

                        dataLabelRoll[i] = dt_Roll_Label.Rows[i]["hms"].ToString();
                    }
                    else
                    {
                        dataLabelRoll[i] = "";
                    }


                    //dataValueRollLine2[i] = Convert.ToDouble(dt_Data_RollLine2.Rows[i]["value1"].ToString());
                    dataMinRoll[i] = Convert.ToDouble(dt_Roll_Label.Rows[i]["min_value"].ToString());
                    dataMaxRoll[i] = Convert.ToDouble(dt_Roll_Label.Rows[i]["max_value"].ToString());

                    dataNearMinRoll[i] = Convert.ToDouble(dt_Roll_Label.Rows[i]["min_value"].ToString()) + iWarningGap;
                    dataNearMaxRoll[i] = Convert.ToDouble(dt_Roll_Label.Rows[i]["max_value"].ToString()) - iWarningGap;

                }

            }

            if (dt_Data_RollLine2 != null && dt_Data_RollLine2.Rows.Count > 0)
            {
                for (int i = 0; i < iNumRowRollLine2; i++)
                {


                    dataValueRollLine2[i] = Convert.ToDouble(dt_Data_RollLine2.Rows[i]["value1"].ToString());


                }

            }

            if (dt_Data_RollLine3 != null && dt_Data_RollLine3.Rows.Count > 0)
            {
                for (int i = 0; i < iNumRowRollLine3; i++)
                {
                   

                    dataValueRollLine3[i] = Convert.ToDouble(dt_Data_RollLine3.Rows[i]["value1"].ToString());
                   

                }

            }

            if (dt_Data_RollLine4 != null && dt_Data_RollLine4.Rows.Count > 0)
            {
            
                for (int i = 0; i < iNumRowRollLine4; i++)
                {
                   

                    dataValueRollLine4[i] = Convert.ToDouble(dt_Data_RollLine4.Rows[i]["value1"].ToString());
                 
                }

            }


            if (dt_Extruder_Label != null && dt_Extruder_Label.Rows.Count > 0)
            {
                for (int i = 0; i < iNumRowExtruder; i++)
                {
                    if (i % 5 == 0)
                    {

                        dataLabelExtruder[i] = dt_Extruder_Label.Rows[i]["hms"].ToString();
                    }
                    else
                    {
                        dataLabelExtruder[i] = "";
                    }


                    //dataValueExtruderLine2[i] = Convert.ToDouble(dt_Data_ExtruderLine2.Rows[i]["value1"].ToString());
                    dataMinExtruder[i] = Convert.ToDouble(dt_Extruder_Label.Rows[i]["min_value"].ToString());
                    dataMaxExtruder[i] = Convert.ToDouble(dt_Extruder_Label.Rows[i]["max_value"].ToString());

                    dataNearMinExtruder[i] = Convert.ToDouble(dt_Extruder_Label.Rows[i]["min_value"].ToString()) + iWarningGap;
                    dataNearMaxExtruder[i] = Convert.ToDouble(dt_Extruder_Label.Rows[i]["max_value"].ToString()) - iWarningGap;

                }

            }


            if (dt_Data_ExtruderLine2 != null && dt_Data_ExtruderLine2.Rows.Count > 0)
            {
                for (int i = 0; i < iNumRowExtruderLine2; i++)
                {


                    dataValueExtruderLine2[i] = Convert.ToDouble(dt_Data_ExtruderLine2.Rows[i]["value1"].ToString());


                }

            }

            if (dt_Data_ExtruderLine3 != null && dt_Data_ExtruderLine3.Rows.Count > 0)
            {
                for (int i = 0; i < iNumRowExtruderLine3; i++)
                {


                    dataValueExtruderLine3[i] = Convert.ToDouble(dt_Data_ExtruderLine3.Rows[i]["value1"].ToString());


                }

            }

            if (dt_Data_ExtruderLine4 != null && dt_Data_ExtruderLine4.Rows.Count > 0)
            {
                for (int i = 0; i < iNumRowExtruderLine4; i++)
                {    
                    dataValueExtruderLine4[i] = Convert.ToDouble(dt_Data_ExtruderLine4.Rows[i]["value1"].ToString());
  

                }

            }



            if (dt_Palletizing_Label != null && dt_Palletizing_Label.Rows.Count > 0)
            {
                for (int i = 0; i < iNumRowPelletizing; i++)
                {
                    if (i % 5 == 0)
                    {

                        dataLabelPelletizing[i] = dt_Palletizing_Label.Rows[i]["hms"].ToString();
                    }
                    else
                    {
                        dataLabelPelletizing[i] = "";
                    }


                    //dataValuePelletizingLine2[i] = Convert.ToDouble(dt_Data_PelletizingLine2.Rows[i]["value1"].ToString());
                    dataMinPelletizing[i] = Convert.ToDouble(dt_Palletizing_Label.Rows[i]["min_value"].ToString());
                    dataMaxPelletizing[i] = Convert.ToDouble(dt_Palletizing_Label.Rows[i]["max_value"].ToString());

                    dataNearMinPelletizing[i] = Convert.ToDouble(dt_Palletizing_Label.Rows[i]["min_value"].ToString()) + iWarningGap;
                    dataNearMaxPelletizing[i] = Convert.ToDouble(dt_Palletizing_Label.Rows[i]["max_value"].ToString()) - iWarningGap;

                }

            }

            if (dt_Data_PelletizingLine2 != null && dt_Data_PelletizingLine2.Rows.Count > 0)
            {
                for (int i = 0; i < iNumRowPelletizingLine2; i++)
                {
                    dataValuePelletizingLine2[i] = Convert.ToDouble(dt_Data_PelletizingLine2.Rows[i]["value1"].ToString());

                }

            }

            if (dt_Data_PelletizingLine3 != null && dt_Data_PelletizingLine3.Rows.Count > 0)
            {
                for (int i = 0; i < iNumRowPelletizingLine3 ; i++)
                {
                    dataValuePelletizingLine3[i] = Convert.ToDouble(dt_Data_PelletizingLine3.Rows[i]["value1"].ToString());

                }

            }
            if (dt_Data_PelletizingLine4 != null && dt_Data_PelletizingLine4.Rows.Count > 0)
            {
                for (int i = 0; i < iNumRowPelletizingLine4 ; i++)
                {
                    
                    dataValuePelletizingLine4[i] = Convert.ToDouble(dt_Data_PelletizingLine4.Rows[i]["value1"].ToString());

                }

            }
                        
        }
       
        
        

		private int Max(DataTable[] numbers)
		{
			DataTable m = numbers[0];

			for (int i = 0; i < numbers.Length; i++)
				if (numbers[i] != null && m.Rows.Count < numbers[i].Rows.Count)
					m = numbers[i];

			return m.Rows.Count;
		}

        private int MaxIndex(int[] numbers)
        {
            int m = numbers[0];
            int iIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
                if (m < numbers[i])
                {
                    m = numbers[i];
                    iIndex = i;
                }
                

            return iIndex;
        }

        private DataTable MaxRowCount(DataTable[] numbers)
        {
            DataTable m = numbers[0];
            //DataTable = null;

            for (int i = 0; i < numbers.Length; i++)
                if ( numbers[i] !=null && m.Rows.Count < numbers[i].Rows.Count)
                {
                    m = numbers[i];
                   
                }


            return m;
        }

		DataTable[] maxKneader = new DataTable[3];
        DataTable[] maxRoll = new DataTable[3];
        DataTable[] maxExtruder = new DataTable[3];
        DataTable[] maxPalletizing = new DataTable[3];

        private void SearchDataKneader()
        {
            dt_Data_KneaderLine2 = null;
            dt_Data_KneaderLine3 = null;
            dt_Data_KneaderLine4 = null;
            dt_Data_KneaderLine2 = this.select_temp_sum("KD101", "001");
            dt_Data_KneaderLine3 = this.select_temp_sum("KD102", "001");
			//dt_Data_KneaderLine4 = this.select_summary_temperature("004", "001");
            maxKneader[0] = dt_Data_KneaderLine2;
            maxKneader[1] = dt_Data_KneaderLine3;
            maxKneader[2] = dt_Data_KneaderLine4;

            iNumRowKneader = Max(maxKneader);
             dt_Kneader_Label = MaxRowCount(maxKneader);
			
			
			
            if (dt_Data_KneaderLine2 != null && dt_Data_KneaderLine2.Rows.Count > 0)
            {

                iNumRowKneaderLine2 = dt_Data_KneaderLine2.Rows.Count;
                dataMinKneader = new double[iNumRowKneader];
                dataNearMinKneader = new double[iNumRowKneader];
                dataValueKneaderLine2 = new double[iNumRowKneader];
                //dataValueKneaderLine3 = new double[iNumRowKneader];
                dataLabelKneader = new string[iNumRowKneader];
                dataMaxKneader = new double[iNumRowKneader];
                dataNearMaxKneader = new double[iNumRowKneader];

            } else if (dt_Data_KneaderLine2.Rows.Count == 0)
            {
                iNumRowKneaderLine2 = 0;
            }

            
            if (dt_Data_KneaderLine3 != null && dt_Data_KneaderLine3.Rows.Count > 0)
            {
               
                 iNumRowKneaderLine3 = dt_Data_KneaderLine3.Rows.Count;
                
                dataMinKneader = new double[iNumRowKneader];
                dataNearMinKneader = new double[iNumRowKneader];
                dataValueKneaderLine3 = new double[iNumRowKneader];
                dataLabelKneader = new string[iNumRowKneader];
                dataMaxKneader = new double[iNumRowKneader];
                dataNearMaxKneader = new double[iNumRowKneader];

            }
            else if (dt_Data_KneaderLine3.Rows.Count == 0)
            {
                iNumRowKneaderLine3 = 0;
            }

            
            if (dt_Data_KneaderLine4 != null && dt_Data_KneaderLine4.Rows.Count > 0)
            {
               
                iNumRowKneaderLine4 = dt_Data_KneaderLine4.Rows.Count;
                
                dataMinKneader = new double[iNumRowKneader];
                dataNearMinKneader = new double[iNumRowKneader];
                dataValueKneaderLine4 = new double[iNumRowKneader];
                dataLabelKneader = new string[iNumRowKneader];
                dataMaxKneader = new double[iNumRowKneader];
                dataNearMaxKneader = new double[iNumRowKneader];

            } else 
            {
                iNumRowKneaderLine4 = 0;
            }

            dt_Data_Max_Kneader = null;
            dt_Data_Max_Kneader = this.SELECT_TEMPERATURE_MINMAX("002", "001");
            if (dt_Data_Max_Kneader != null)
            {
                dataChartMaxKneader[0] = Convert.ToDouble(dt_Data_Max_Kneader.Rows[0]["MIN_VALUE"].ToString());
                dataChartMaxKneader[1] = Convert.ToDouble(dt_Data_Max_Kneader.Rows[0]["MAX_VALUE"].ToString());

            }
        }

        private void SearchDataRoll()
        {
            dt_Data_RollLine2 = null;
            dt_Data_RollLine2 = this.select_summary_temperature("002", "003");
            dt_Data_RollLine3 = null;
            dt_Data_RollLine3 = this.select_summary_temperature("003", "003");
            dt_Data_RollLine4 = null;
           // dt_Data_RollLine4 = this.select_summary_temperature("004", "003");

            maxRoll[0] = dt_Data_RollLine2;
            maxRoll[1] = dt_Data_RollLine3;
            maxRoll[2] = dt_Data_RollLine4;

            iNumRowRoll = Max(maxRoll);
            dt_Roll_Label = MaxRowCount(maxRoll);

  

            if (dt_Data_RollLine2 != null && dt_Data_RollLine2.Rows.Count > 0)
            {
                iNumRowRollLine2 = dt_Data_RollLine2.Rows.Count - 1;

                dataNearMinRoll = new double[iNumRowRoll];
                dataMinRoll = new double[iNumRowRoll];
                dataValueRollLine2 = new double[iNumRowRoll];
                dataLabelRoll = new string[iNumRowRoll];
                dataMaxRoll = new double[iNumRowRoll];
                dataNearMaxRoll = new double[iNumRowRoll];

            }
            else if (dt_Data_RollLine2.Rows.Count == 0)
            {
                iNumRowRollLine2 = 0;
            }


            if (dt_Data_RollLine3 != null && dt_Data_RollLine3.Rows.Count > 0)
            {

                iNumRowRollLine3 = dt_Data_RollLine3.Rows.Count;


                dataNearMinRoll = new double[iNumRowRoll];
                dataMinRoll = new double[iNumRowRoll];
                dataValueRollLine3 = new double[iNumRowRoll];
                dataLabelRoll = new string[iNumRowRoll];
                dataMaxRoll = new double[iNumRowRoll];
                dataNearMaxRoll = new double[iNumRowRoll];

            }
            else if(dt_Data_RollLine3.Rows.Count == 0)
            {
                iNumRowRollLine3 = 0;
            }
           
            if (dt_Data_RollLine4 != null && dt_Data_RollLine4.Rows.Count > 0)
            {
                
                    iNumRowRollLine4 = dt_Data_RollLine4.Rows.Count;
                

                dataNearMinRoll = new double[iNumRowRoll];
                dataMinRoll = new double[iNumRowRoll];
                dataValueRollLine4 = new double[iNumRowRoll];
                dataLabelRoll = new string[iNumRowRoll];
                dataMaxRoll = new double[iNumRowRoll];
                dataNearMaxRoll = new double[iNumRowRoll];

            }
            else
            {
                iNumRowRollLine4 = 0;
            }

            //dt_Data_Max_Roll = null;
            //dt_Data_Max_Roll = this.SELECT_TEMPERATURE_MINMAX("002", "003");
            if (dt_Data_Max_Roll != null)
            {
                dataChartMaxRoll[0] = Convert.ToDouble(dt_Data_Max_Roll.Rows[0]["MIN_VALUE"].ToString());
                dataChartMaxRoll[1] = Convert.ToDouble(dt_Data_Max_Roll.Rows[0]["MAX_VALUE"].ToString());

            }



        }

        private void SearchDataExtruder()
        {
            dt_Data_ExtruderLine2 = null;
            dt_Data_ExtruderLine3 = null;
            dt_Data_ExtruderLine4 = null;
            dt_Data_ExtruderLine2 = this.select_summary_temperature("002", "009");
            dt_Data_ExtruderLine3 = this.select_summary_temperature("003", "009");
           // dt_Data_ExtruderLine4 = this.select_summary_temperature("004", "009");

            maxExtruder[0] = dt_Data_ExtruderLine2;
            maxExtruder[1] = dt_Data_ExtruderLine3;
            maxExtruder[2] = dt_Data_ExtruderLine4;

            iNumRowExtruder = Max(maxExtruder);
            dt_Extruder_Label = MaxRowCount(maxExtruder);

            if (dt_Data_ExtruderLine2 != null && dt_Data_ExtruderLine2.Rows.Count > 0)
            {
                iNumRowExtruderLine2 = dt_Data_ExtruderLine2.Rows.Count;

                dataMinExtruder = new double[iNumRowExtruder];
                dataNearMinExtruder = new double[iNumRowExtruder];
                dataValueExtruderLine2 = new double[iNumRowExtruder];
                dataLabelExtruder = new string[iNumRowExtruder];
                dataMaxExtruder = new double[iNumRowExtruder];
                dataNearMaxExtruder = new double[iNumRowExtruder];

            }
            else if (dt_Data_ExtruderLine2.Rows.Count == 0)
            {
                iNumRowExtruderLine2 = 0;
            }
            
            if (dt_Data_ExtruderLine3 != null && dt_Data_ExtruderLine3.Rows.Count > 0)
            {
                
                 iNumRowExtruderLine3 = dt_Data_ExtruderLine3.Rows.Count;
                

                dataMinExtruder = new double[iNumRowExtruder];
                dataNearMinExtruder = new double[iNumRowExtruder];
                dataValueExtruderLine3 = new double[iNumRowExtruder];
                dataLabelExtruder = new string[iNumRowExtruder];
                dataMaxExtruder = new double[iNumRowExtruder];
                dataNearMaxExtruder = new double[iNumRowExtruder];

            }
            else if (dt_Data_ExtruderLine3.Rows.Count == 0)
            {
                iNumRowExtruderLine3 = 0;
            }
            
            if (dt_Data_ExtruderLine4 != null && dt_Data_ExtruderLine4.Rows.Count > 0)
            {
                
                   iNumRowExtruderLine4 = dt_Data_ExtruderLine4.Rows.Count;
                

                dataMinExtruder = new double[iNumRowExtruder];
                dataNearMinExtruder = new double[iNumRowExtruder];
                dataValueExtruderLine4 = new double[iNumRowExtruder];
                dataLabelExtruder = new string[iNumRowExtruder];
                dataMaxExtruder = new double[iNumRowExtruder];
                dataNearMaxExtruder = new double[iNumRowExtruder];

            }
            else 
            {
                iNumRowExtruderLine4 = 0;
            }
            dt_Data_Max_Extruder = null;
            dt_Data_Max_Extruder = this.SELECT_TEMPERATURE_MINMAX("002", "009");
            if (dt_Data_Max_Extruder != null)
            {
                dataChartMaxExtruder[0] = Convert.ToDouble(dt_Data_Max_Extruder.Rows[0]["MIN_VALUE"].ToString());
                dataChartMaxExtruder[1] = Convert.ToDouble(dt_Data_Max_Extruder.Rows[0]["MAX_VALUE"].ToString());

            }
        }

        private void SearchDataPelletizing()
        {
            dt_Data_PelletizingLine2 = null;
            dt_Data_PelletizingLine3 = null;
            dt_Data_PelletizingLine4 = null;
            dt_Data_PelletizingLine2 = this.select_summary_temperature("002", "008");
            dt_Data_PelletizingLine3 = this.select_summary_temperature("003", "008");
            dt_Data_PelletizingLine4 = this.select_summary_temperature("004", "008");

            maxPalletizing[0] = dt_Data_PelletizingLine2;
            maxPalletizing[1] = dt_Data_PelletizingLine3;
            maxPalletizing[2] = dt_Data_PelletizingLine4;

            iNumRowExtruder = Max(maxPalletizing);
            dt_Palletizing_Label = MaxRowCount(maxPalletizing);

            if (dt_Data_PelletizingLine2 != null && dt_Data_PelletizingLine2.Rows.Count > 0)
            {
                iNumRowPelletizingLine2 = dt_Data_PelletizingLine2.Rows.Count;

                dataMinPelletizing = new double[iNumRowPelletizing];
                dataNearMinPelletizing = new double[iNumRowPelletizing];
                dataValuePelletizingLine2 = new double[iNumRowPelletizing];
                dataLabelPelletizing = new string[iNumRowPelletizing];
                dataMaxPelletizing = new double[iNumRowPelletizing];
                dataNearMaxPelletizing = new double[iNumRowPelletizing];

            }
            else if (dt_Data_PelletizingLine2.Rows.Count == 0)
            {
                iNumRowPelletizingLine2 = 0;
            }

            
            if (dt_Data_PelletizingLine3 != null && dt_Data_PelletizingLine3.Rows.Count > 0)
            {
                
                 iNumRowPelletizingLine3 = dt_Data_PelletizingLine3.Rows.Count;
                

                dataMinPelletizing = new double[iNumRowPelletizing];
                dataNearMinPelletizing = new double[iNumRowPelletizing];
                dataValuePelletizingLine3 = new double[iNumRowPelletizing];
                dataLabelPelletizing = new string[iNumRowPelletizing];
                dataMaxPelletizing = new double[iNumRowPelletizing];
                dataNearMaxPelletizing = new double[iNumRowPelletizing];

            }
            else if (dt_Data_PelletizingLine3.Rows.Count == 0)
            {
                iNumRowPelletizingLine3 = 0;
            }
            
            if (dt_Data_PelletizingLine4 != null && dt_Data_PelletizingLine4.Rows.Count > 0)
            {
                
                 iNumRowPelletizingLine4 = dt_Data_PelletizingLine4.Rows.Count;
                

                dataMinPelletizing = new double[iNumRowPelletizing];
                dataNearMinPelletizing = new double[iNumRowPelletizing];
                dataValuePelletizingLine4 = new double[iNumRowPelletizing];
                dataLabelPelletizing = new string[iNumRowPelletizing];
                dataMaxPelletizing = new double[iNumRowPelletizing];
                dataNearMaxPelletizing = new double[iNumRowPelletizing];

            }
            else if (dt_Data_PelletizingLine4.Rows.Count == 0)
            {
                iNumRowPelletizingLine4 = 0;
            }

            dt_Data_Max_Pelletizing = null;
            dt_Data_Max_Pelletizing = this.SELECT_TEMPERATURE_MINMAX("002", "008");
            if (dt_Data_Max_Pelletizing != null)
            {
                dataChartMaxPelletizing[0] = Convert.ToDouble(dt_Data_Max_Pelletizing.Rows[0]["MIN_VALUE"].ToString());
                dataChartMaxPelletizing[1] = Convert.ToDouble(dt_Data_Max_Pelletizing.Rows[0]["MAX_VALUE"].ToString());

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

        private Color SetColorGrid(string strValue)
        {
            try
            {
                switch (strValue)
                {
                    case "Red":
                        return Color.Red;
                        break;
                    case "White":
                        return Color.White;
                        break;
                    case "Yellow":
                        return Color.Yellow;
                        break;
                    case "Green":
                        return Color.Green;
                        break;
                    case "Blue":
                        return Color.Blue;
                        break;
                    case "DodgerBlue":
                        return Color.DodgerBlue;
                        break;
                }
                return Color.White;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                return Color.Red;
            }
        }

        private void MergeCol(AxFPSpreadADO.AxfpSpread gridObject, int iStartRow, int iCol)
        {
            try
            {
                string sTemp1 = "";
                string sTemp2 = "";
                int iRow = iStartRow;
                gridObject.Row = iStartRow;
                gridObject.Col = iCol;
                sTemp1 = gridObject.Value;
                for (int i = iStartRow; i < gridObject.MaxRows + 4; i++)
                {
                    gridObject.Row = i;
                    gridObject.Col = iCol;
                    sTemp2 = gridObject.Value;
                    if (sTemp1 != sTemp2)
                    {
                        gridObject.AddCellSpan(iCol, iRow, 1, i - iRow);
                        sTemp1 = sTemp2;
                        sTemp2 = "";
                        iRow = i;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void intNoValueDefaultArray(double[] dArray)
        {
            for (int i = 0; i < dArray.Length; i++)
            {
                dArray[i] = Chart.NoValue;
            }
        }
        private void Set_Default_Array()
        {
            intNoValueDefaultArray(this.dataValueKneaderRTLine2);
            intNoValueDefaultArray(this.dataValueKneaderRTLine3);
            intNoValueDefaultArray(this.dataValueKneaderRTLine4);
            intNoValueDefaultArray(this.dataValueRollRTLine2);
            intNoValueDefaultArray(this.dataValueRollRTLine3);
            intNoValueDefaultArray(this.dataValueRollRTLine4);
            intNoValueDefaultArray(this.dataValueExtruderRTLine2);
            intNoValueDefaultArray(this.dataValueExtruderRTLine3);
            intNoValueDefaultArray(this.dataValueExtruderRTLine4);
            intNoValueDefaultArray(this.dataValuePelletizingRTLine2);
            intNoValueDefaultArray(this.dataValuePelletizingRTLine3);
            intNoValueDefaultArray(this.dataValuePelletizingRTLine4);
        }

        public bool IsNumeric(string text)
        {
            return Regex.IsMatch(text, "^\\d+$");
        }

        private void showAnimation(AxFPSpreadADO.AxfpSpread flg)
        {
            //flg.Hide();
            //ClassLib.WinAPI.AnimateWindow(flg.Handle, 2000, ClassLib.Common.getSlidType("2"));
            //flg.Show();
        }

        private void showAnimation(ClassLib.GroupBoxEx flg)
        {
            
            //flg.Hide();
            //ClassLib.WinAPI.AnimateWindow(flg.Handle, 2000, ClassLib.Common.getSlidType("3"));
            //flg.Show();
        }


        private void showAnimation(ChartDirector.WinChartViewer flg)
        {
            //flg.Hide();
            
            //Smart_FTY.ClassLib.WinAPI.AnimateWindow(flg.Handle, 2000, Smart_FTY.ClassLib.Common.getSlidType("1"));
            //flg.Show();
        }

        private void showAnimation(System.Windows.Forms.Form flg)
        {
            //flg.Hide();
            //Smart_FTY.ClassLib.WinAPI.AnimateWindow(flg.Handle, 2000, Smart_FTY.ClassLib.Common.getSlidType("2"));
            //flg.Show();
        }

        private bool checkWindowOpen(string windowName)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name.Equals(windowName))
                {
                    Application.OpenForms[i].Show();
                   // showAnimation(Application.OpenForms[i]);
                    return false;
                }
            }
            return true;
        }

        #endregion Method

        #region Database
        private DataTable select_summary_data_roll()
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "PKG_IP_ROLL_CURRENT_STATUS.select_summary_data_roll";

            //02.ARGURMENT ¢¬i

            MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC


            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;


            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }


        private DataTable select_summary_temperature(string arg_mline_cd, string arg_mc_id)
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = "PKG_IP_ROLL_CURRENT_STATUS.select_summary_temperature";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "ARG_MLINE_CD";
            MyOraDB.Parameter_Name[1] = "ARG_MC_ID";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_mline_cd;
            MyOraDB.Parameter_Values[1] = arg_mc_id;
            MyOraDB.Parameter_Values[2] = "";




            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }

        



        private DataTable SELECT_TEMPERATURE_MINMAX(string arg_mline_cd, string arg_mc_id)
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = "PKG_IP_ROLL_CURRENT_STATUS.SELECT_TEMPERATURE_MINMAX";

            //02.ARGURMENT ¢¬i

            MyOraDB.Parameter_Name[0] = "ARG_MLINE_CD";
            MyOraDB.Parameter_Name[1] = "ARG_MC_ID";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_mline_cd;
            MyOraDB.Parameter_Values[1] = arg_mc_id;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region CreateChart

        public void createChart(WinChartViewer viewer, string sTitle, int iValue, int iValueMin, int iValueMax, int iValueNear, int iValueNearMax, int iBottomValue, int iTopValue, int iScale)
        {

            // Create an LinearMeter object of size 60 x 265 pixels, using silver
            // background with a 2 pixel black 3D depressed border.
            LinearMeter m = new LinearMeter(70, 175, Chart.silverColor(), 0, -2);


            //LinearMeter m1 = new LinearMeter(60, 265, Chart.silverColor(), 0, -2);

            // Set the scale region top-left corner at (25, 30), with size of 20 x
            // 200 pixels. The scale labels are located on the left (default -
            // implies vertical meter)

            m.setMeter(25, 35, 20, 110);
            // m1.setMeter(95, 30, 20, 200);


            // Set meter scale from 0 - 100, with a tick every 10 units

            m.setScale(iBottomValue, iTopValue, iScale);


            // Set 0 - 50 as green (99ff99) zone, 50 - 80 as yellow (ffff66) zone,
            // and 80 - 100 as red (ffcccc) zone
            if (iValueMin > 0)
            {
                m.addZone(iBottomValue, iValueMin, 0xFF0000);
            }
            m.addZone((iValueMin == 0) ? iBottomValue : iValueMin, (iValueMax == 0) ? iTopValue : iValueMax, 0x4CFF00);
            if (iValueMax > 0)
            {
                m.addZone(iValueMax, iTopValue, 0xFF0000);
            }

            // Add a deep blue (000080) pointer at the specified value
            m.addPointer(iValue, 0x000080, 0xFF0000);
            //m.addPointer(iValueMin + 2);

            // Add a text box label at top-center (30, 5) using Arial Bold/8 pts/deep
            // blue (000088), with a light blue (9999ff) background
            m.addText(30, 5, "Temp C", "Arial Bold", 8, 0x000088, Chart.TopCenter
                ).setBackground(0x9999ff);

            // Add a text box to show the value formatted to 2 decimal places at
            // bottom center (30, 260). Use white text on black background with a 1
            // pixel depressed 3D border.
            m.addText(35, 170, sTitle + " : " + m.formatValue(iValue, ""), "Arial Bold", 9, 0xffffff,
                Chart.BottomCenter).setBackground(0x1C86EE, 0, -1);

            // Output the chart

            viewer.Chart = m;


        }

        public void createChartSummary(WinChartViewer viewer, string img, string[] dataLabel, double[] dataChartMaxScale, double[] dataChartMax, double[] dataChartNearMax,
                                        double[] dataChartMin, double[] dataChartNearMin, double[] dataChartRTLine2, double[] dataChartRTLine3, double[] dataChartRTLine4,
                                        int iPercent)
        {


            //if (dataChartRTLine2 == null) return;

            XYChart c = new XYChart(chart_width, chart_height);
            Chart.setLicenseCode("DEVP-2LSU-B4LX-YCTY-2DF2-77EE");

            c.setPlotArea(30, 10, plot_width, plot_hight, c.linearGradientColor(0, 30, 0, 250,
              0xf9f9ff, 0xf9f9ff), -1, 0xffffff, 0xffffff);


            c.setBorder(10);
            //LegendBox legendbox = c.addLegend(legend_x, legend_y, true, "Arial Bold", 8);


            c.xAxis().setLabels(dataLabel);

            c.addTitle(img,
              "Times New Roman Bold Italic", 12);

            c.xAxis().setTickOffset(0.5);

            // Set axis label style to 8pts Arial Bold
            c.xAxis().setLabelStyle("Arial Bold", 8);
            c.yAxis().setLabelStyle("Arial Bold", 8);


            // Set axis line width to 2 pixels
            c.xAxis().setWidth(2);
            c.yAxis().setWidth(2);
            c.yAxis().setLinearScale(dataChartMaxScale[0], dataChartMaxScale[1]);

            // Add a line layer for the pareto line
            if (dataChartRTLine2 != null && dataChartRTLine2.Length > 0)
            {
                SplineLayer lineLayerLine2 = c.addSplineLayer();

                lineLayerLine2.addDataSet(dataChartRTLine2, 0x267f00, "Actual").setDataSymbol(
                    Chart.NoShape, 9, 0xFF006E, 0x4CFF00);
                lineLayerLine2.setLineWidth(2);
            }
            if (dataChartRTLine3 != null && dataChartRTLine3.Length > 0)
            {

                SplineLayer lineLayerLine3 = c.addSplineLayer();
                lineLayerLine3.addDataSet(dataChartRTLine3, 0x000000, "Actual").setDataSymbol(
                    Chart.NoShape, 9, 0xFF006E, 0x4CFF00);
                lineLayerLine3.setLineWidth(2);
            }

            if (dataChartRTLine4 != null && dataChartRTLine4.Length > 0)
            {

                SplineLayer lineLayerLine4 = c.addSplineLayer();
                lineLayerLine4.addDataSet(dataChartRTLine4, 0xff8080, "Actual").setDataSymbol(
                    Chart.NoShape, 9, 0xFF006E, 0x4CFF00);
                lineLayerLine4.setLineWidth(2);
            }

            // Set the line width to 2 pixel


            // Add a line layer for the pareto line
            SplineLayer lineLayer1 = c.addSplineLayer();

            lineLayer1.addDataSet(dataChartMin, 0xFF0000, "LCL").setDataSymbol(
                Chart.NoShape, 9, 0xFF006E, 0x4CFF00);

            // Set the line width to 2 pixel
            lineLayer1.setLineWidth(5);


            SplineLayer lineLayer1Near = c.addSplineLayer();

            lineLayer1Near.addDataSet(dataChartNearMin, 0xFFFF00, "LWL").setDataSymbol(
                Chart.NoShape, 9, 0xFF006E, 0x4CFF00);

            // Set the line width to 2 pixel
            lineLayer1Near.setLineWidth(5);



            SplineLayer lineLayer2 = c.addSplineLayer();

            lineLayer2.addDataSet(dataChartMax, 0xFF0000, "UCL").setDataSymbol(
                Chart.NoShape, 9, 0xFF006E, 0x4CFF00);

            // Set the line width to 2 pixel
            lineLayer2.setLineWidth(5);

            SplineLayer lineLayer2Near = c.addSplineLayer();

            lineLayer2Near.addDataSet(dataChartNearMax, 0xFFFF00, "UWL").setDataSymbol(
                Chart.NoShape, 9, 0xFF006E, 0x4CFF00);

            // Set the line width to 2 pixel
            lineLayer2Near.setLineWidth(5);


            c.addInterLineLayer(lineLayer1.getLine(0), lineLayer2.getLine(0), unchecked((int)0xFFFFFF), unchecked((int)0xFFFFFF));

            //c.addInterLineLayer(lineLayerLine2.getLine(0), lineLayer1.getLine(0), 0xFF0000, Chart.Transparent);

            //c.addInterLineLayer(lineLayerLine2.getLine(0), lineLayer2.getLine(0),
            //Chart.Transparent, 0xFF0000);


            // Output the chart
            viewer.Chart = c;

            //include tool tip for the chart
            viewer.ImageMap = c.getHTMLImageMap("clickable", "",
                "title='{dataSetName} on {xLabel}: {value}'");
        }
        #endregion CreateChart

        #region Timer
		int cnt = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                _time_load++;


                if (_time_load >= 20)
                {
                    _time_load = 0;
                    Search_Data();					
                }
				cnt++;
				if (cnt >= 120)
				{
					
					//Set_Default_Array();
					Search_Summary();
					iPercent = 0;
					cnt = 0;
				}
            }
            catch { }
        }

        

        #endregion Timer


        private void tmrUpdateKneader_Tick(object sender, EventArgs e)
        {
            try
            {
                /*
                for (int i = 0; i < iNumRowKneader + 1; i++)
                {
                    if (i == _indexKneaderLine2)
                    {
                        dataValueKneaderRTLine2[_indexKneaderLine2] = dataValueKneaderLine2[_indexKneaderLine2];

                    }
                    else if (i > _indexKneaderLine2)
                    {
                        dataValueKneaderRTLine2[i] = Chart.NoValue;
                    }

                    if (i == _indexKneaderLine3)
                    {
                        dataValueKneaderRTLine3[_indexKneaderLine3] = dataValueKneaderLine3[_indexKneaderLine3];

                    }
                    else if (i > _indexKneaderLine3)
                    {
                        dataValueKneaderRTLine3[i] = Chart.NoValue;
                    }

                    if (i == _indexKneaderLine4)
                    {
                        dataValueKneaderRTLine4[_indexKneaderLine4] = dataValueKneaderLine4[_indexKneaderLine4];

                    }
                    else if (i > _indexKneaderLine4)
                    {
                        dataValueKneaderRTLine4[i] = Chart.NoValue;
                    }

                }

                */

                for (int i = 0; i < iNumRowKneaderLine2; i++)
                {
                    if (i == _indexKneaderLine2)
                    {
                        dataValueKneaderRTLine2[_indexKneaderLine2] = dataValueKneaderLine2[_indexKneaderLine2];

                    }
                    else if (i > _indexKneaderLine2)
                    {
                        dataValueKneaderRTLine2[i] = Chart.NoValue;
                    }
                }
                for (int i = 0; i < iNumRowKneaderLine3; i++)
                {

                    if (i == _indexKneaderLine3)
                    {
                        dataValueKneaderRTLine3[_indexKneaderLine3] = dataValueKneaderLine3[_indexKneaderLine3];

                    }
                    else if (i > _indexKneaderLine3)
                    {
                        dataValueKneaderRTLine3[i] = Chart.NoValue;
                    }
                }
                for (int i = 0; i < iNumRowKneaderLine4; i++)
                {

                    if (i == _indexKneaderLine4)
                    {
                        dataValueKneaderRTLine4[_indexKneaderLine4] = dataValueKneaderLine4[_indexKneaderLine4];

                    }
                    else if (i > _indexKneaderLine4)
                    {
                        dataValueKneaderRTLine4[i] = Chart.NoValue;
                    }

                }
               

                _indexKneaderLine2++;
                _indexKneaderLine3++;
                _indexKneaderLine4++;
                if (_indexKneaderLine2 < iNumRowKneaderLine2 || _indexKneaderLine3 < iNumRowKneaderLine3 || _indexKneaderLine4 < iNumRowKneaderLine4)
                {

                }
                else
                {
                    tmrUpdateKneader.Stop();
                    _indexKneaderLine2 = 0;
                    _indexKneaderLine3 = 0;
                    _indexKneaderLine4 = 0;
         

                }
                chartSumKn.updateViewPort(true, false);
            }
            catch (Exception ex)
            {
                //MessageBox.Show( ex.Message.ToString());
            }
        }

        private void tmrUpdateExtruder_Tick(object sender, EventArgs e)
        {
            try
            {
                /*
                for (int i = 0; i < iNumRowExtruder + 1; i++)
                {
                    if (i == _indexExtruderLine2)
                    {
                        dataValueExtruderRTLine2[_indexExtruderLine2] = dataValueExtruderLine2[_indexExtruderLine2];

                    }
                    else if (i > _indexExtruderLine2)
                    {
                        dataValueExtruderRTLine2[i] = Chart.NoValue;
                    }

                    if (i == _indexExtruderLine3)
                    {
                        dataValueExtruderRTLine3[_indexExtruderLine3] = dataValueExtruderLine3[_indexExtruderLine3];

                    }
                    else if (i > _indexExtruderLine3)
                    {
                        dataValueExtruderRTLine3[i] = Chart.NoValue;
                    }
                    if (i == _indexExtruderLine4)
                    {
                        dataValueExtruderRTLine4[_indexExtruderLine4] = dataValueExtruderLine4[_indexExtruderLine4];

                    }
                    else if (i > _indexExtruderLine4)
                    {
                        dataValueExtruderRTLine4[i] = Chart.NoValue;
                    }
                }
                  */

                for (int i = 0; i < iNumRowExtruderLine2; i++)
                {
                    if (i == _indexExtruderLine2)
                    {
                        dataValueExtruderRTLine2[_indexExtruderLine2] = dataValueExtruderLine2[_indexExtruderLine2];

                    }
                    else if (i > _indexExtruderLine2)
                    {
                        dataValueExtruderRTLine2[i] = Chart.NoValue;
                    }
                }
                for (int i = 0; i < iNumRowExtruderLine3 ; i++)
                {

                    if (i == _indexExtruderLine3)
                    {
                        dataValueExtruderRTLine3[_indexExtruderLine3] = dataValueExtruderLine3[_indexExtruderLine3];

                    }
                    else if (i > _indexExtruderLine3)
                    {
                        dataValueExtruderRTLine3[i] = Chart.NoValue;
                    }
                }
                for (int i = 0; i < iNumRowExtruderLine4 ; i++)
                {
                    if (i == _indexExtruderLine4)
                    {
                        dataValueExtruderRTLine4[_indexExtruderLine4] = dataValueExtruderLine4[_indexExtruderLine4];

                    }
                    else if (i > _indexExtruderLine4)
                    {
                        dataValueExtruderRTLine4[i] = Chart.NoValue;
                    }
                }
                 

                _indexExtruderLine2++;
                _indexExtruderLine3++;
                _indexExtruderLine4++;
                if (_indexExtruderLine2 < iNumRowExtruderLine2 ||_indexExtruderLine3 < iNumRowExtruderLine3 || _indexExtruderLine4 < iNumRowExtruderLine4)
                {

                }
                else
                {
                    tmrUpdateExtruder.Stop();
                    _indexExtruderLine2 = 0;
                    _indexExtruderLine3 = 0;
                    _indexExtruderLine4 = 0;

                }
                chartSumEx.updateViewPort(true, false);
            }
            catch (Exception ex)
            {
                //MessageBox.Show( ex.Message.ToString());
            }
        }

        private void chartSumKn_ViewPortChanged(object sender, WinViewPortEventArgs e)
        {
            createChartSummary(chartSumKn, "Kneader", dataLabelKneader, dataChartMaxKneader,
                    dataMaxKneader, dataNearMaxKneader, dataMinKneader, dataNearMinKneader,
                    dataValueKneaderRTLine2, dataValueKneaderRTLine3, dataValueKneaderRTLine4, 0);
        }

        private void tmrUpdateRoll_Tick(object sender, EventArgs e)
        {
            try
            {
                /*
                for (int i = 0; i < iNumRowRoll + 1; i++)
                {
                    if (i == _indexRollLine2)
                    {
                        dataValueRollRTLine2[_indexRollLine2] = dataValueRollLine2[_indexRollLine2];

                    }
                    else if (i > _indexRollLine2)
                    {
                        dataValueRollRTLine2[i] = Chart.NoValue;
                    }

                    if (i == _indexRollLine3)
                    {
                        dataValueRollRTLine3[_indexRollLine3] = dataValueRollLine3[_indexRollLine3];

                    }
                    else if (i > _indexRollLine3)
                    {
                        dataValueRollRTLine3[i] = Chart.NoValue;
                    }
                    if (i == _indexRollLine4)
                    {
                        dataValueRollRTLine4[_indexRollLine4] = dataValueRollLine4[_indexRollLine4];

                    }
                    else if (i > _indexRollLine4)
                    {
                        dataValueRollRTLine4[i] = Chart.NoValue;
                    }
                }
                  */

                for (int i = 0; i < iNumRowRollLine2; i++)
                {
                    if (i == _indexRollLine2)
                    {
                        dataValueRollRTLine2[_indexRollLine2] = dataValueRollLine2[_indexRollLine2];

                    }
                    else if (i > _indexRollLine2)
                    {
                        dataValueRollRTLine2[i] = Chart.NoValue;
                    }
                }
                for (int i = 0; i < iNumRowRollLine3; i++)
                {
                  
                    if (i == _indexRollLine3)
                    {
                        dataValueRollRTLine3[_indexRollLine3] = dataValueRollLine3[_indexRollLine3];

                    }
                    else if (i > _indexRollLine3)
                    {
                        dataValueRollRTLine3[i] = Chart.NoValue;
                    }
                }
                for (int i = 0; i < iNumRowRollLine4; i++)
                {
                  
                    if (i == _indexRollLine4)
                    {
                        dataValueRollRTLine4[_indexRollLine4] = dataValueRollLine4[_indexRollLine4];

                    }
                    else if (i > _indexRollLine4)
                    {
                        dataValueRollRTLine4[i] = Chart.NoValue;
                    }
                }

                _indexRollLine2++;
                _indexRollLine3++;
                _indexRollLine4++;
                if (_indexRollLine2 < iNumRowRollLine2 || _indexRollLine3 < iNumRowRollLine3 || _indexRollLine4 < iNumRowRollLine4)
                {

                }
                else
                {
                    tmrUpdateRoll.Stop();
                    _indexRollLine2 = 0;
                    _indexRollLine3 = 0;
                    _indexRollLine4 = 0;

                }
                chartSumRo.updateViewPort(true, false);
            }
            catch (Exception ex)
            {
                //MessageBox.Show( ex.Message.ToString());
            }
        }

        private void chartSumRo_ViewPortChanged(object sender, WinViewPortEventArgs e)
        {
            createChartSummary(chartSumRo, "Roll", dataLabelRoll, dataChartMaxRoll,
                    dataMaxRoll, dataNearMaxRoll, dataMinRoll, dataNearMinRoll,
                    dataValueRollRTLine2, dataValueRollRTLine3, dataValueRollRTLine4, 0);
        }

        private void chartSumEx_ViewPortChanged(object sender, WinViewPortEventArgs e)
        {

            createChartSummary(chartSumEx, "Extruder", dataLabelExtruder, dataChartMaxExtruder,
                    dataMaxExtruder, dataNearMaxExtruder, dataMinExtruder, dataNearMinExtruder,
                    dataValueExtruderRTLine2, dataValueExtruderRTLine3, dataValueExtruderRTLine4, 0);
        }

        private void tmrUpdatePelleting_Tick(object sender, EventArgs e)
        {
            try
            {
                /*
                for (int i = 0; i < iNumRowPelletizing + 1; i++)
                {
                    if (i == _indexPelletingLine2)
                    {
                        dataValuePelletizingRTLine2[_indexPelletingLine2] = dataValuePelletizingLine2[_indexPelletingLine2];

                    }
                    else if (i > _indexPelletingLine2)
                    {
                        dataValuePelletizingRTLine2[i] = Chart.NoValue;
                    }

                    if (i == _indexPelletingLine3)
                    {
                        dataValuePelletizingRTLine3[_indexPelletingLine3] = dataValuePelletizingLine3[_indexPelletingLine3];

                    }
                    else if (i > _indexPelletingLine3)
                    {
                        dataValuePelletizingRTLine3[i] = Chart.NoValue;
                    }
                    if (i == _indexPelletingLine4)
                    {
                        dataValuePelletizingRTLine4[_indexPelletingLine4] = dataValuePelletizingLine4[_indexPelletingLine4];

                    }
                    else if (i > _indexPelletingLine4)
                    {
                        dataValuePelletizingRTLine4[i] = Chart.NoValue;
                    }
                }
                 */

                for (int i = 0; i < iNumRowPelletizingLine2 ; i++)
                {
                    if (i == _indexPelletingLine2)
                    {
                        dataValuePelletizingRTLine2[_indexPelletingLine2] = dataValuePelletizingLine2[_indexPelletingLine2];

                    }
                    else if (i > _indexPelletingLine2)
                    {
                        dataValuePelletizingRTLine2[i] = Chart.NoValue;
                    }
                }
                for (int i = 0; i < iNumRowPelletizingLine3 ; i++)
                {

                    if (i == _indexPelletingLine3)
                    {
                        dataValuePelletizingRTLine3[_indexPelletingLine3] = dataValuePelletizingLine3[_indexPelletingLine3];

                    }
                    else if (i > _indexPelletingLine3)
                    {
                        dataValuePelletizingRTLine3[i] = Chart.NoValue;
                    }
                }
                for (int i = 0; i < iNumRowPelletizingLine4 ; i++)
                {
                    if (i == _indexPelletingLine4)
                    {
                        dataValuePelletizingRTLine4[_indexPelletingLine4] = dataValuePelletizingLine4[_indexPelletingLine4];

                    }
                    else if (i > _indexPelletingLine4)
                    {
                        dataValuePelletizingRTLine4[i] = Chart.NoValue;
                    }
                }

                _indexPelletingLine2++;
                _indexPelletingLine3++;
                _indexPelletingLine4++;
                if (_indexPelletingLine2 < iNumRowPelletizingLine2 || _indexPelletingLine3 < iNumRowPelletizingLine3 || _indexPelletingLine4 < iNumRowPelletizingLine4)
                {

                }
                else
                {
                    tmrUpdatePelleting.Stop();
                    _indexPelletingLine2 = 0;
                    _indexPelletingLine3 = 0;
                    _indexPelletingLine4 = 0;

                }
                chartSumPa.updateViewPort(true, false);
            }
            catch (Exception ex)
            {
                //MessageBox.Show( ex.Message.ToString());
            }
        }

        private void chartSumPa_ViewPortChanged(object sender, WinViewPortEventArgs e)
        {
            createChartSummary(chartSumPa, "Palletizing", dataLabelPelletizing, dataChartMaxPelletizing,
                    dataMaxPelletizing, dataNearMaxPelletizing, dataMinPelletizing, dataNearMinPelletizing,
                    dataValuePelletizingRTLine2, dataValuePelletizingRTLine3, dataValuePelletizingRTLine4, 0);
        }

        private void chartSumKn_Click(object sender, EventArgs e)
        {

        }

        private void chartSumKn_ViewPortChanged_1(object sender, WinViewPortEventArgs e)
        {
            createChartSummary(chartSumKn, "Kneader - Machine", dataLabelKneader, dataChartMaxKneader,
                   dataMaxKneader, dataNearMaxKneader, dataMinKneader, dataNearMinKneader,
                   dataValueKneaderRTLine2, dataValueKneaderRTLine3, dataValueKneaderRTLine4, 0);
        }

        private void chartSumRo_ViewPortChanged_1(object sender, WinViewPortEventArgs e)
        {
            createChartSummary(chartSumRo, "Roll", dataLabelRoll, dataChartMaxRoll,
                    dataMaxRoll, dataNearMaxRoll, dataMinRoll, dataNearMinRoll,
                    dataValueRollRTLine2, dataValueRollRTLine3, dataValueRollRTLine4, 0);
        }

        private void chartSumEx_ViewPortChanged_1(object sender, WinViewPortEventArgs e)
        {
            createChartSummary(chartSumEx, "Extruder", dataLabelExtruder, dataChartMaxExtruder,
                   dataMaxExtruder, dataNearMaxExtruder, dataMinExtruder, dataNearMinExtruder,
                   dataValueExtruderRTLine2, dataValueExtruderRTLine3, dataValueExtruderRTLine4, 0);
        }

        private void chartSumPa_ViewPortChanged_1(object sender, WinViewPortEventArgs e)
        {
            createChartSummary(chartSumPa, "Palletizing - Seed", dataLabelPelletizing, dataChartMaxPelletizing,
                   dataMaxPelletizing, dataNearMaxPelletizing, dataMinPelletizing, dataNearMinPelletizing,
                   dataValuePelletizingRTLine2, dataValuePelletizingRTLine3, dataValuePelletizingRTLine4, 0);
        }

        
        

        private void blindLabel(DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent, int iMinValue, int iMaxValue, System.Windows.Forms.Label lbl)
        {
            if ( arcScaleComponent.Value == 0) return;
            if (arcScaleComponent.Value < iMinValue || arcScaleComponent.Value > iMaxValue)
            {
                lbl.BackColor = preverColor(lbl.BackColor);
            }
        }
        private Color preverColor(Color color)
        {
            if (color == Color.Red)
                return Color.DodgerBlue;
            if (color == Color.DodgerBlue)
                return Color.Red;
            return Color.Empty;
        
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRubber_Click(object sender, EventArgs e)
        {
          //  _frm_rub.Show();
            
        }

        

        private void lblEVA_Click(object sender, EventArgs e)
        {

        }

        #endregion No Use

        private void lblRubber_Click(object sender, EventArgs e)
        {
            Form_Home._frmMachinery_RubTemp.Show();
            this.Hide();
        }
    }
}



        