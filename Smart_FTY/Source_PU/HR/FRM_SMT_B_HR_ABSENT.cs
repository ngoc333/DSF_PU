using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using DevExpress.XtraGauges.Core.Model;

namespace Smart_FTY
{
    public partial class FRM_SMT_B_HR_ABSENT : SampleFrm2
    {
        public FRM_SMT_B_HR_ABSENT()
        {
            InitializeComponent();
            tmrTime.Stop();
            tmrLoad.Stop();
        }

        int iCount = 0;

        #region Proc
        private void GoFullscreen()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

        }

        #region Absent
        private void loadChartAbsent(DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent
                                    , DevExpress.XtraCharts.ChartControl argChart
                                    , DevExpress.XtraGauges.Win.Base.LabelComponent arglbl
                                    , string argPer, string argPlan, string argNoPlan)
        {
            try
            {
                float value = 0;
                //Chart Per
                arcScaleComponent.EnableAnimation = false;
                arcScaleComponent.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseInOut;
                arcScaleComponent.EasingFunction = new BackEase();
                arglbl.Text = "0";
                arcScaleComponent.Value = 0;

                arcScaleComponent.EnableAnimation = true;
                arcScaleComponent.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseInOut;
                arcScaleComponent.EasingFunction = new BackEase();
                arglbl.Text = argPer;
                float.TryParse(argPer, out value);
                arglbl.Text = value.ToString("##0.#");
                arcScaleComponent.Value = value;

                arcScaleComponent.MinValue = 0f;
                arcScaleComponent.MaxValue = 20f;
                //arcScaleComponent.Ranges[0].StartValue = 0;
                //arcScaleComponent.Ranges[0].EndValue = arcScaleComponent.Ranges[1].StartValue = (float)9; ;
                //arcScaleComponent.Ranges[1].EndValue = arcScaleComponent.Ranges[2].StartValue = (float)10;
                //arcScaleComponent.Ranges[2].EndValue = (float)10;

                //Chart Absent
                /*DataTable dt_tmp = new DataTable();
                dt_tmp.Columns.Add("CAPTION");
                dt_tmp.Columns.Add("VALUE", typeof(double));

                dt_tmp.Rows.Add();
                dt_tmp.Rows[0]["CAPTION"] = "NO PLAN";
                dt_tmp.Rows[0]["VALUE"] = argNoPlan == "" ? "0" : argNoPlan;
                dt_tmp.Rows.Add();
                dt_tmp.Rows[1]["CAPTION"] = "PLAN";
                dt_tmp.Rows[1]["VALUE"] = argPlan;

                argChart.DataSource = dt_tmp;
                argChart.Series[0].ArgumentDataMember = "CAPTION";
                argChart.Series[0].ValueDataMembers.AddRange(new string[] { "VALUE" });
                argChart.Series[0].ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;

                */
            }
            catch
            { }
        }

        private void loadDataGridAbsent(DataTable argDt)
        {
            try
            {
                if (argDt == null || argDt.Rows.Count == 0) return;
                string[] arr = {"MON", "THEDATE" 
                            ,"TOT_MAN", "TOT_NO_PLAN", "TOT_PLAN", "TOT_PER", "TOT_TUNOVER",  "TOT_TUNOVER_PER"
                            ,"MAN1", "NO_PLAN1", "PLAN1", "PER1", "TUNOVER1",  "TUNOVER_PER1"
                            ,"MAN2", "NO_PLAN2", "PLAN2", "PER2", "TUNOVER2",  "TUNOVER_PER2"                            
                           };
                axfpAbsent.Visible = false;
                int iNumRow = argDt.Rows.Count;
                axfpAbsent.MaxRows = 20;
                axfpAbsent.MaxCols = 5;
                axfpAbsent.MaxCols = 50;
                for (int i = 0; i < argDt.Rows.Count; i++)
                {
                    axfpAbsent.set_ColWidth(i + 4, Convert.ToDouble(argDt.Rows[0]["COL_W"].ToString()));
                    for (int j = 0; j < arr.Length; j++)
                    {
                        axfpAbsent.Col = i + 4;
                        axfpAbsent.Row = j + 1;
                        axfpAbsent.Text = argDt.Rows[i][arr[j]].ToString();
                        if (j + 1 > 2)
                        {
                            axfpAbsent.BackColor = Color.White;
                            axfpAbsent.ForeColor = Color.Black;
                            axfpAbsent.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignRight;
                           
                        }
                        else if (j + 1 == 1)
                        {
                            axfpAbsent.BackColor = Color.Gray;
                            axfpAbsent.ForeColor = Color.White;
                            axfpAbsent.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
                        }
                        else if (j + 1 == 2)
                        {
                            axfpAbsent.BackColor = Color.Silver;
                            axfpAbsent.ForeColor = Color.White;
                            axfpAbsent.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
                        }


                        // axfpAbsent.SetText(i + 4, j + 1, argDt.Rows[i][arr[j]].ToString());
                    }

                    if (argDt.Rows[i]["TODAY"].ToString() == argDt.Rows[i]["THEDATE"].ToString())
                    {
                        loadChartAbsent(arcScaleComponentRub, chartHrCmp, lblRubValueG, argDt.Rows[i]["PER1"].ToString(), argDt.Rows[i]["PLAN1"].ToString(), argDt.Rows[i]["NO_PLAN1"].ToString());
                        loadChartAbsent(arcScaleComponentEva, chartHrPhy, lblEvaValueG, argDt.Rows[i]["PER2"].ToString(), argDt.Rows[i]["PLAN2"].ToString(), argDt.Rows[i]["NO_PLAN2"].ToString());
                    }

                }
                
                axfpAbsent.Row = -1;
                axfpAbsent.Col = iNumRow + 3;
                axfpAbsent.BackColor = Color.Orange;
                axfpAbsent.ForeColor = Color.White;

                axfpAbsent.SetCellBorder(iNumRow + 3, 1, iNumRow + 3, axfpAbsent.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);

                axfpAbsent.AddCellSpan(4, 1, iNumRow - 1, 1);
                axfpAbsent.AddCellSpan(iNumRow + 3, 1, 1, 2);
                axfpAbsent.set_ColWidth(iNumRow + 3, 8);
                axfpAbsent.MaxCols = iNumRow + 3;

                
            }
            catch
            { }
            finally { axfpAbsent.Visible = true; }


        }

        #region Human Resource

        private void chartHr(DataTable argDt, DevExpress.XtraCharts.ChartControl argChart)
        {
            try
            {
                string strTotal = "";
                double totalMain = 0;
                DataTable dt = argDt.Clone();
                dt.Columns["VALUE_DATA"].DataType = typeof(double);
                foreach (DataRow row in argDt.Rows)
                    dt.ImportRow(row);

                argChart.DataSource = dt;
                argChart.Series[0].ArgumentDataMember = "CAPTION";
                argChart.Series[0].ValueDataMembers.AddRange(new string[] { "VALUE_DATA" });

                double iAbsent, iAttend;
                double.TryParse(dt.Rows[0][1].ToString(), out iAbsent);
                double.TryParse(dt.Rows[1][1].ToString(), out iAttend);

                // return;
                totalMain = iAbsent + iAttend;

                strTotal = "Total Absent\n"
                       + totalMain.ToString() + " Person(s)\n"
                       + (Math.Round(totalMain * 100 / (totalMain + double.Parse(dt.Rows[2][1].ToString())), 1)).ToString() + " %";

                if (argChart.Name == "chartHrCmp")
                {
                    lblTotCMP.Text = strTotal;
                }
                else
                {
                    lblTotPhy.Text = strTotal;   //PHP
                }


                //if (iAbsent / (iAbsent + iAttend) * 100 >= 5)
                //    argChart.PaletteName = "Absent_Red";
                //else
                //    argChart.PaletteName = "Absent_Blue";
            }
            catch
            {
            }

            //argChart.Series[0].ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            //DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            // chartTitle1.Font = new System.Drawing.Font("Tahoma", 20F);
            //this.argChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] { chartTitle1 });
        }

        #endregion Human Resource

        #endregion Absent

        #region Tunover
        /* private void loadDataGridTunover(DataTable argDt)
        {
            try
            {
                if (argDt == null || argDt.Rows.Count == 0) return;
                string[] arr = { "MON", "TOT_ABS_QTY", "TOT_ABS_PER", "RUB_ABS_QTY", "RUB_ABS_PER", "EVA_ABS_QTY", "EVA_ABS_PER" };
                int iNumRow = argDt.Rows.Count;
                for (int i = 0; i < iNumRow; i++)
                {
                    for (int j = 0; j <= 6; j++)
                    {
                        axfpTurnOver.SetText(i + 3, j + 1, argDt.Rows[i][arr[j]].ToString());
                    }

                }
            }
            catch 
            {}
        }*/
        #endregion Tunover




        private void loadData()
        {
            try
            {
                System.Data.DataSet ds = GET_DATA("PUP");
                loadDataGridAbsent(ds.Tables[0]);
                // loadDataGridTunover(ds.Tables[1]);
                chartHr(ds.Tables[1], chartHrCmp);
                chartHr(ds.Tables[2], chartHrPhy);
            }
            catch
            { }

        }

        #endregion Proc

        #region DB
        private System.Data.DataSet GET_DATA(string argWH)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_B_HR_STATUS.SEL_B_HR_STATUS";

                MyOraDB.ReDim_Parameter(5);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_P_OP";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR1";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR2";
                MyOraDB.Parameter_Name[4] = "ARG_YM";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;

                MyOraDB.Parameter_Values[0] = argWH;
                MyOraDB.Parameter_Values[1] = "";
                MyOraDB.Parameter_Values[2] = "";
                MyOraDB.Parameter_Values[3] = "";
                MyOraDB.Parameter_Values[4] = uc_month.GetValue().ToString();

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret;
            }
            catch
            {
                return null;
            }
        }

        #endregion DB

        #region Event
        private void FRM_SMT_HR_ABSENT_Load(object sender, EventArgs e)
        {
            GoFullscreen();

            lblTitle.Text = "PU Human Attendance";
            pnButton.Visible = false;

            //BindingAbsent();
            //BindingTurnOver();
        }

        private void tmrDate_Tick(object sender, EventArgs e)
        {

        }

        private void FRM_SMT_HR_ABSENT_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    iCount = 39;
                    tmrTime.Start();
                    tmrLoad.Start();
                }
                else
                {
                    tmrTime.Stop();
                    tmrLoad.Stop();
                }
            }
            catch
            { }

        }


        private void uc_month_ValueChangeEvent(object sender, EventArgs e)
        {
            try
            {
                loadData();
                // BindingData("IPP");
                //  bindingdatachart("IPP");
            }
            catch
            {

            }
        }

        #endregion Event




        private void splMain_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splMain_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            iCount++;
            if (iCount >= 40)
            {
                iCount = 0;
                loadData();
            }
        }
    }
}
