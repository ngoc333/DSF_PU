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
    public partial class FRM_SMT_B_HR_ABSENT : SampleFrm1
    {
        public FRM_SMT_B_HR_ABSENT()
        {
            InitializeComponent();
        }

        #region Proc
        private void GoFullscreen()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

        }

        #region Absent
        private void loadChartAbsent(DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent
                                    ,DevExpress.XtraCharts.ChartControl argChart
                                    ,DevExpress.XtraGauges.Win.Base.LabelComponent arglbl
                                    , string argPer, string argPlan, string argNoPlan)
        {
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
            arcScaleComponent.Value = Convert.ToSingle(argPer);

            arcScaleComponent.MaxValue = (float)1;
            arcScaleComponent.Ranges[0].StartValue = 0;
            arcScaleComponent.Ranges[0].EndValue = arcScaleComponent.Ranges[1].StartValue = (float)0.9; ;
            arcScaleComponent.Ranges[1].EndValue = arcScaleComponent.Ranges[2].StartValue = (float)1.0;
            arcScaleComponent.Ranges[2].EndValue = (float)1;

            //Chart Absent
            DataTable dt_tmp = new DataTable();
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

        }

        private void loadDataGridAbsent(DataTable argDt)
        {
            if (argDt == null || argDt.Rows.Count ==0) return;
            string[] arr = {"MON", "THEDATE" 
                            ,"TOT_MAN",  "TOT_NO_PLAN", "TOT_PLAN", "TOT_PER"
                            ,"RUB_MAN", "RUB_NO_PLAN", "RUB_PLAN", "RUB_PER"
                            ,"EVA_MAN", "EVA_NO_PLAN", "EVA_PLAN", "EVA_PER"                            
                           };
            int iNumRow = argDt.Rows.Count;
            for (int i =0 ;i< argDt.Rows.Count;i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    axfpAbsent.SetText(i + 4, j + 1, argDt.Rows[i][arr[j]].ToString());
                }

                if (argDt.Rows[i]["TODAY"].ToString() == argDt.Rows[i]["THEDATE"].ToString())
                {
                    loadChartAbsent(arcScaleComponentRub, chartControlRub, lblRubValueG, argDt.Rows[i]["RUB_PER"].ToString(), argDt.Rows[i]["RUB_PLAN"].ToString(), argDt.Rows[i]["RUB_NO_PLAN"].ToString());
                    loadChartAbsent(arcScaleComponentEva, chartControlEva, lblEvaValueG, argDt.Rows[i]["EVA_PER"].ToString(), argDt.Rows[i]["EVA_PLAN"].ToString(), argDt.Rows[i]["EVA_NO_PLAN"].ToString());
                }
               
            }

            axfpAbsent.Col = iNumRow + 3;
            axfpAbsent.BackColor = Color.Orange;
            axfpAbsent.ForeColor = Color.White;           

            axfpAbsent.SetCellBorder(iNumRow + 3, 1, iNumRow + 3, axfpAbsent.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);


            axfpAbsent.AddCellSpan(4, 1, iNumRow - 1, 1);
            axfpAbsent.AddCellSpan(iNumRow + 3, 1, 1, 2);
            axfpAbsent.set_ColWidth(iNumRow + 3, 8);
            axfpAbsent.MaxCols = iNumRow + 3;

        }

        #endregion Absent

        #region Tunover
        private void loadDataGridTunover(DataTable argDt)
        {
            if (argDt == null || argDt.Rows.Count == 0) return;
            string[] arr = { "MON", "TOT_ABS_QTY", "TOT_ABS_PER", "RUB_ABS_QTY", "RUB_ABS_PER", "EVA_ABS_QTY", "EVA_ABS_PER" };
            int iNumRow = argDt.Rows.Count;
            for (int i = 0; i < iNumRow; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    axfpTurnOver.SetText(i + 3, j + 1, argDt.Rows[i][arr[j]].ToString());
                }

            }
            

        }
        #endregion Tunover




        private void loadData()
        {
            System.Data.DataSet ds = GET_DATA("ROLL");
            loadDataGridAbsent(ds.Tables[0]);
            loadDataGridTunover(ds.Tables[1]);
        }

        #endregion Proc

        #region DB
        private System.Data.DataSet GET_DATA(string argWH)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_B1_DIGITAL.SEL_DATA_FORM_HR_ABSENT";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_WH_CD";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR1";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;


                MyOraDB.Parameter_Values[0] = argWH;
                MyOraDB.Parameter_Values[1] = "";
                MyOraDB.Parameter_Values[2] = "";

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

            lblTitle.Text = "Human Absenteeism";
            pnButton.Visible = false;

            //BindingAbsent();
            //BindingTurnOver();
        }

        private void tmrDate_Tick(object sender, EventArgs e)
        {
            cCount++;
            if (cCount >= 30)
            {
                loadData();
                // BindingAbsent();
                //  BindingTurnOver();

                cCount = 0;
            }

        }

        private void FRM_SMT_HR_ABSENT_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                cCount = 29;
                tmrLoad.Start();
            }
            else
                tmrLoad.Stop();
        }

        #endregion Event







        #region No Use

        int indexScreen;
        string line, Mline,Lang;
        int cCount = 0;
        Form[] arrForm = new Form[3];
       

        public DataTable SP_SMT_HR_ABSENT(string ARG_QTYPE, string ARG_LINE_CD, string ARG_MLINE_CD)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_PHUOC.SP_SMT_HR_ABSENT";

                MyOraDB.ReDim_Parameter(4);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_QTYPE";
                MyOraDB.Parameter_Name[1] = "ARG_LINE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_MLINE_CD";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = ARG_QTYPE;
                MyOraDB.Parameter_Values[1] = ARG_LINE_CD;
                MyOraDB.Parameter_Values[2] = ARG_MLINE_CD;
                MyOraDB.Parameter_Values[3] = "";


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

        


        private void ClearGrid(AxFPSpreadADO.AxfpSpread Grid)
        {
            for (int iRow = 0; iRow <= Grid.MaxRows; iRow++)
            {
                for (int iCol = 3; iCol <= Grid.MaxCols; iCol++)
                {

                    Grid.SetText(iCol, iRow, "");
                    Grid.Row = iRow;
                    Grid.Col = iCol;
                    
                    switch (iRow)
                    { 
                        case 1:
                            Grid.Font = new Font("Calibri", 24, FontStyle.Bold);
                            Grid.BackColor = Color.DodgerBlue;
                            Grid.ForeColor = Color.White;
                            Grid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit;
                            Grid.TypeEditMultiLine = true;
                            Grid.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
                            Grid.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
                            break;
                        default:
                            Grid.Font = new Font("Calibri", 24, FontStyle.Regular);
                            Grid.BackColor = Color.White;
                            
                            break;
                    }
                    
                }
            }
            Grid.SetCellBorder(0, 0, Grid.MaxCols, Grid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexTop, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            Grid.SetCellBorder(0, 0, Grid.MaxCols, Grid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            Grid.SetCellBorder(0, 0, Grid.MaxCols, Grid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexRight, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            Grid.SetCellBorder(0, 0, Grid.MaxCols, Grid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            Grid.SetCellBorder(0, 0, Grid.MaxCols, Grid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
        }


        private void BindingAbsent()
        {
            DataTable dt = null;
            switch (btnYM)
            { 
                case "A":
                     dt = SP_SMT_HR_ABSENT("A", line, Mline);
                    break;
                case "Y":
                    dt = SP_SMT_HR_ABSENT("Y", line, Mline);
                    break;
            }
            
            double ValueGauges = 0;
            double Planed = 0, Unplaned = 0,TOT_MAN = 0;
            arcScaleComponentRub.EnableAnimation = false;
            arcScaleComponentRub.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseInOut;
            arcScaleComponentRub.EasingFunction = new BackEase();
            lblRubValueG.Text = ValueGauges.ToString();
            arcScaleComponentRub.Value = (float)ValueGauges;

            if (dt != null && dt.Rows.Count > 0)
            {
                axfpAbsent.MaxCols = dt.Rows.Count + 2;
                ClearGrid(axfpAbsent);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    axfpAbsent.SetText(i + 3, 1, dt.Rows[i]["DD"].ToString());
                    axfpAbsent.SetText(i + 3, 2, dt.Rows[i]["TOT_MAN"].ToString());
                    axfpAbsent.SetText(i + 3, 3, dt.Rows[i]["UNPLANED"].ToString());
                    axfpAbsent.SetText(i + 3, 4, dt.Rows[i]["PLANED"].ToString());
                    axfpAbsent.SetText(i + 3, 5, dt.Rows[i]["PER"].ToString());
                    axfpAbsent.SetText(i + 3, 6, dt.Rows[i]["RELIEF"].ToString());

                    axfpAbsent.set_ColWidth(i + 3, 190d / (axfpAbsent.MaxCols - 2));


                    if (i == dt.Rows.Count - 1)
                    {
                        ValueGauges = Convert.ToDouble(dt.Rows[dt.Rows.Count - 1]["PER"]);
                        Planed = Convert.ToDouble(dt.Rows[dt.Rows.Count - 1]["PLANED"]);
                        Unplaned = Convert.ToDouble(dt.Rows[dt.Rows.Count - 1]["UNPLANED"]);
                        TOT_MAN = Convert.ToDouble(dt.Rows[dt.Rows.Count - 1]["TOT_MAN"]);
                    }
                   
                        axfpAbsent.Row = 1;
                        axfpAbsent.Col = i + 3;
                        if (dt.Rows[i]["IS_TODAY"].ToString().Equals("Y"))
                        {

                            axfpAbsent.BackColor = Color.Salmon;
                            axfpAbsent.ForeColor = Color.White;
                        }
                        else
                        {
                          //  axfpAbsent.BackColor = Color.FromArgb(1, 143, 228);
                           // axfpAbsent.ForeColor = Color.White;
                        }
                    
                }

                axfpAbsent.set_ColWidth(axfpAbsent.MaxCols, 14d);

                for (int iRow = 2; iRow <= axfpAbsent.MaxRows; iRow++)
                {
                    axfpAbsent.Row = iRow;
                    axfpAbsent.Col = axfpAbsent.MaxCols;
                    axfpAbsent.TypeNumberDecPlaces = 1;
                    axfpAbsent.BackColor = Color.FromArgb(244, 212, 252);
                }
            }
            else
            {
              //  ClearGrid(axfpAbsent);
            }
            arcScaleComponentRub.EnableAnimation = true;
            arcScaleComponentRub.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseInOut;
            arcScaleComponentRub.EasingFunction = new BackEase();
            lblRubValueG.Text = ValueGauges.ToString();
            arcScaleComponentRub.Value = (float)ValueGauges;

            DataTable dt_tmp = new DataTable();
            dt_tmp.Columns.Add("CAPTION");
            dt_tmp.Columns.Add("VALUE",typeof(double));

            dt_tmp.Rows.Add();
            dt_tmp.Rows[dt_tmp.Rows.Count - 1]["CAPTION"] = "NO PLAN";
            dt_tmp.Rows[dt_tmp.Rows.Count - 1]["VALUE"] = dt.Rows[dt.Rows.Count - 1]["UNPLANED"].ToString();
            dt_tmp.Rows.Add();
            dt_tmp.Rows[dt_tmp.Rows.Count - 1]["CAPTION"] = "PLAN";
            dt_tmp.Rows[dt_tmp.Rows.Count - 1]["VALUE"] = dt.Rows[dt.Rows.Count - 1]["PLANED"].ToString();

            chartControlRub.DataSource = dt_tmp;
            chartControlRub.Series[0].ArgumentDataMember = "CAPTION";
            chartControlRub.Series[0].ValueDataMembers.AddRange(new string[] { "VALUE" });
            chartControlRub.Series[0].ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            chartTitle1.Font = new System.Drawing.Font("Tahoma", 20F);
            chartControlRub.Titles.Clear();
            switch (Lang)
            { 
                case "Vn":
                    chartTitle1.Text = "Vắng mặt";
                    break;
                case "En":
                    chartTitle1.Text = "Absenteeism";
                    break;
            }
            

            this.chartControlRub.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});

        }


        private void BindingTurnOver()
        { 
            DataTable dt = SP_SMT_HR_ABSENT("T", line, Mline);
            ClearGrid(axfpTurnOver);
            if (dt != null && dt.Rows.Count > 0)
            {
                axfpTurnOver.SetText(1, 1, dt.Rows[0]["THEYEAR"].ToString());
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    axfpTurnOver.SetText(i+3,1,dt.Rows[i]["THEDATE"].ToString());
                    axfpTurnOver.SetText(i + 3, 2, dt.Rows[i]["ABS_QTY"].ToString());
                    axfpTurnOver.SetText(i + 3, 3, dt.Rows[i]["PER"].ToString());
                }
               
            }
            //chartTurnOver.DataSource = dt.Select("THEYEAR <> 'AVG (%)'").CopyToDataTable();
            //chartTurnOver.Series[0].ArgumentDataMember = "THEDATE";
            //chartTurnOver.Series[0].ValueDataMembers.AddRange(new string[] { "ABS_QTY" });
            //chartTurnOver.Series[0].ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

            
            btnYM = "Y";
            BindingAbsent();
          
            
        }
        string btnYM;
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
            btnYM = "A";
            BindingAbsent();

        }

        #endregion No Use

        private void splMain_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splMain_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
