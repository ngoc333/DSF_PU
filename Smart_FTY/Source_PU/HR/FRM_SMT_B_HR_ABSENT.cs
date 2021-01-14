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
                axfpAbsent.Visible = false;
                for (int i = 1; i <= axfpAbsent.MaxRows; i++)
                {
                    axfpAbsent.Row = i;
                    axfpAbsent.RowHidden = false;
                }

                int iMaxLine;
                int.TryParse(argDt.Compute("max([RN])", "").ToString(), out iMaxLine);


                int iNumCol = 32;
                axfpAbsent.MaxCols = 5;

                axfpAbsent.ScrollBars = iMaxLine > 1 ? FPSpreadADO.ScrollBarsConstants.ScrollBarsVertical : FPSpreadADO.ScrollBarsConstants.ScrollBarsNone;

                for (int i = 1; i <= iMaxLine; i++)
                {
                    DataTable dt = argDt.Select("RN = '" + i + "'", "THEDATE").CopyToDataTable();
                    iNumCol = dt.Rows.Count;
                    axfpAbsent.MaxCols = iNumCol + 3;

                    setDataGrid(dt, i);
                }

                for (int i = 2 + (6 * iMaxLine) + 1; i <= axfpAbsent.MaxRows; i++)
                {
                    axfpAbsent.Row = i;
                    axfpAbsent.RowHidden = true;
                }

                //merge Row Month
                axfpAbsent.AddCellSpan(4, 1, iNumCol - 1, 1);

                //merge column AVG
                axfpAbsent.AddCellSpan(iNumCol + 3, 1, 1, 2);
                //set color column AVG
                axfpAbsent.Row = -1;
                axfpAbsent.Col = iNumCol + 3;
                axfpAbsent.BackColor = Color.Orange;
                axfpAbsent.ForeColor = Color.White;

                axfpAbsent.SetCellBorder(iNumCol + 3, 1, iNumCol + 3, axfpAbsent.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);


            }
            catch
            { }
            finally { axfpAbsent.Visible = true; }

        }
        private void setDataGrid(DataTable argDt, int argLineNum)
        {
            string[] arr = {"MON", "THEDATE" 
                            ,"MAN1", "NO_PLAN1", "PLAN1", "PER1", "TUNOVER1",  "TUNOVER1_PER1"
                          //  ,"MAN2", "NO_PLAN2", "PLAN2", "PER2", "TUNOVER2",  "TUNOVER_PER2"                            
                           };
            int iCol = 4;


            for (int i = 0; i < argDt.Rows.Count; i++)
            {
                int iRow = argLineNum == 1 ? 1 : 3 + (6 * (argLineNum - 1));
                int iStartRow = argLineNum == 1 ? 0 : 2;
                axfpAbsent.SetText(1, argLineNum == 1 ? 3 : iRow, argDt.Rows[0]["LOC"].ToString());
                axfpAbsent.set_ColWidth(i + 4, Convert.ToDouble(argDt.Rows[0]["COL_W"].ToString()));
                for (int j = iStartRow; j < arr.Length; j++)
                {
                    axfpAbsent.Col = iCol;
                    axfpAbsent.Row = iRow;
                    axfpAbsent.Text = argDt.Rows[i][arr[j]].ToString();
                    if (iRow > 2)
                    {
                        axfpAbsent.BackColor = Color.White;
                        axfpAbsent.ForeColor = Color.Black;
                        axfpAbsent.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignRight;
                        axfpAbsent.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
                    }
                    else if (iRow == 1)
                    {
                        axfpAbsent.BackColor = Color.Gray;
                        axfpAbsent.ForeColor = Color.White;
                        axfpAbsent.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
                        axfpAbsent.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
                    }
                    else if (iRow == 2)
                    {
                        axfpAbsent.BackColor = Color.Silver;
                        axfpAbsent.ForeColor = Color.White;
                        axfpAbsent.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
                        axfpAbsent.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
                    }
                    iRow++;
                }
                iCol++;

            }
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
                double.TryParse(dt.Rows[0][3].ToString(), out iAbsent);
                double.TryParse(dt.Rows[1][3].ToString(), out iAttend);

                // return;
                totalMain = iAbsent + iAttend;

                strTotal = "Total Absent\n"
                       + totalMain.ToString() + " Person(s)\n"
                       + (Math.Round(totalMain * 100 / (totalMain + double.Parse(dt.Rows[2][3].ToString())), 1)).ToString() + " %";

                if (argChart.Name == "chartHrPUP")
                {
                    lblToPUP.Text = strTotal;
                }
                if (argChart.Name == "chartHrPUB")
                {
                    lblToPUB.Text = strTotal;
                }
                if (argChart.Name == "chartHrPUA")
                {
                    lblToPUA.Text = strTotal;
                }
                else
                {
                    lblToPUS.Text = strTotal; 
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
                System.Data.DataSet ds = GET_DATA();
                loadDataGridAbsent(ds.Tables[0]);
                // loadDataGridTunover(ds.Tables[1]);
                if (ds.Tables[1].Select("LINE_CD = 'PUP'", "RN").Count() > 0)
                    chartHr(ds.Tables[1].Select("LINE_CD = 'PUP'", "RN").CopyToDataTable(), chartHrPUP);
                else chartHrPUP.DataSource = null;
                if (ds.Tables[1].Select("LINE_CD = 'PUB'", "RN").Count() > 0)
                    chartHr(ds.Tables[1].Select("LINE_CD = 'PUB'", "RN").CopyToDataTable(), chartHrPUB);
                else chartHrPUP.DataSource = null;
                if (ds.Tables[1].Select("LINE_CD = 'PUA'", "RN").Count() > 0)
                    chartHr(ds.Tables[1].Select("LINE_CD = 'PUA'", "RN").CopyToDataTable(), chartHrPUA);
                else chartHrPUP.DataSource = null;
                if (ds.Tables[1].Select("LINE_CD = 'PUS'", "RN").Count() > 0)
                    chartHr(ds.Tables[1].Select("LINE_CD = 'PUS'", "RN").CopyToDataTable(), chartHrPUS);
                else chartHrPUP.DataSource = null;
            }
            catch
            { }

        }

        #endregion Proc

        #region DB
        private System.Data.DataSet GET_DATA()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_B_HR_STATUS_V02.SEL_B_HR_STATUS_V02";

                MyOraDB.ReDim_Parameter(4);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_P_OP";
                MyOraDB.Parameter_Name[1] = "ARG_YM";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR1";
                

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
               

                MyOraDB.Parameter_Values[0] = "000";
                MyOraDB.Parameter_Values[1] = uc_month.GetValue().ToString();
                MyOraDB.Parameter_Values[2] = "";
                MyOraDB.Parameter_Values[3] = "";
                

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
