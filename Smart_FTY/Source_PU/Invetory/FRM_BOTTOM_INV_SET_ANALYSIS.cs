using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using DevExpress.XtraCharts;
using DevExpress.XtraGrid.Views.Grid;

namespace Smart_FTY.Source_PU
{
    public partial class FRM_BOTTOM_INV_SET_ANALYSIS : Form
    {
        public FRM_BOTTOM_INV_SET_ANALYSIS()
        {
            InitializeComponent();
        }
        #region Variable
        private int cCount = 0;
        private const string ComponentNM = "PU";

        int _start_column = 0;
        #endregion

        #region DB


        private DataSet SEL_DATA(string WorkType, string Date, string Comp, string SetYN)
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB(1);

            MyOraDB.ReDim_Parameter(13);
            MyOraDB.Process_Name = "LMES.P_MSIV90002A_Q_V05";

            MyOraDB.Parameter_Type[0] = (char)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (char)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (char)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (char)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (char)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (char)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (char)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (char)OracleType.VarChar;
            MyOraDB.Parameter_Type[8] = (char)OracleType.VarChar;
            MyOraDB.Parameter_Type[9] = (char)OracleType.VarChar;
            MyOraDB.Parameter_Type[10] = (char)OracleType.VarChar;
            MyOraDB.Parameter_Type[11] = (char)OracleType.Cursor;
            MyOraDB.Parameter_Type[12] = (char)OracleType.Cursor;
            //V_P_TYPE,V_P_OPTION
            MyOraDB.Parameter_Name[0] = "V_P_WORK_TYPE";
            MyOraDB.Parameter_Name[1] = "V_P_DATE";
            MyOraDB.Parameter_Name[2] = "V_P_COMP";
            MyOraDB.Parameter_Name[3] = "V_P_SET_YN";
            MyOraDB.Parameter_Name[4] = "V_P_ERROR_CODE";
            MyOraDB.Parameter_Name[5] = "V_P_ROW_COUNT";
            MyOraDB.Parameter_Name[6] = "V_P_ERROR_NOTE";
            MyOraDB.Parameter_Name[7] = "V_P_RETURN_STR";
            MyOraDB.Parameter_Name[8] = "V_P_ERROR_STR";
            MyOraDB.Parameter_Name[9] = "V_ERRORSTATE";
            MyOraDB.Parameter_Name[10] = "V_ERRORPROCEDURE";
            MyOraDB.Parameter_Name[11] = "CV_1";
            MyOraDB.Parameter_Name[12] = "CV_2";

            MyOraDB.Parameter_Values[0] = WorkType;
            MyOraDB.Parameter_Values[1] = Date;
            MyOraDB.Parameter_Values[2] = Comp;
            MyOraDB.Parameter_Values[3] = SetYN;
            MyOraDB.Parameter_Values[4] = "";
            MyOraDB.Parameter_Values[5] = "";
            MyOraDB.Parameter_Values[6] = "";
            MyOraDB.Parameter_Values[7] = "";
            MyOraDB.Parameter_Values[8] = "";
            MyOraDB.Parameter_Values[9] = "";
            MyOraDB.Parameter_Values[10] = "";
            MyOraDB.Parameter_Values[11] = "";

            MyOraDB.Add_Select_Parameter(true);
            retDS = MyOraDB.Exe_Select_Procedure();
            if (retDS == null) return null;
            return retDS;
        }
        #endregion
        //---------------------------------------//
        private void LoadChart()
        {
            try
            {
                DataSet ds = SEL_DATA("Q", DateTime.Now.ToString("yyyyMMdd"), ComponentNM, "N");
                DataTable dtChart = ds.Tables[0];
                chart.DataSource = dtChart;
                chart.Series[0].ArgumentDataMember = "LINE_NM";
                chart.Series[0].ValueDataMembers.AddRange(new string[] { "INV_QTY" });
                chart.Series[1].ArgumentDataMember = "LINE_NM";
                chart.Series[1].ValueDataMembers.AddRange(new string[] { "SET_QTY" });
                chart.Series[2].ArgumentDataMember = "LINE_NM";
                chart.Series[2].ValueDataMembers.AddRange(new string[] { "TAR_QTY" });

                ((XYDiagram)chart.Diagram).AxisX.Label.Staggered = false;

            }
            catch (Exception ex)
            {
            }
        }
        //---------//
        private void BindingData(string arg_type, string arg_ymd, string arg_comp)
        {
            LoadChart();
            LoadGrid();
        }
        private void LoadGrid()
        {
            try
            {
                DataSet ds = SEL_DATA("Q", DateTime.Now.ToString("yyyyMMdd"), ComponentNM, "N");
                DataTable dt = ds.Tables[1];
                DataTable dtSource = new DataTable();
                if (ds == null) return;
                if (buildHeader_detail(dtSource, dt))
                {
                    if (bindingDataSource_detail(dtSource, dt))
                    {
                        grdBase2.DataSource = dtSource;
                        formatgrid();
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }
        private bool buildHeader_detail(DataTable dtSource, DataTable dt)
        {
            try
            {
                int.TryParse(dt.Rows[0]["START_COLUMN"].ToString(), out _start_column);
                for (int i = 0; i < _start_column - 1; i++)
                {
                    if (i == _start_column - 2 || i == _start_column - 3)
                        dtSource.Columns.Add(dt.Columns[i].Caption, typeof(decimal));
                    else
                        dtSource.Columns.Add(dt.Columns[i].Caption);
                }
                dtSource.Columns.Add("Total", typeof(decimal));
                DataRow[] row = dt.Select("", "SIZE_NUM ASC");
                double min = 1, max = 22;
                double.TryParse(row[0]["SIZE_NUM"].ToString(), out min);
                double.TryParse(row[row.Length - 1]["SIZE_NUM"].ToString(), out max);
                for (double i = min; i <= max; i = i + 0.5)
                {
                    dtSource.Columns.Add(i.ToString().Replace(".5", "T"), typeof(decimal));
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private bool bindingDataSource_detail(DataTable dtSource, DataTable dtTemp)
        {
            int cnt = 0;
            try
            {
                int[] rowtotal = new int[dtSource.Columns.Count];
                string distinct_row = "";
                int temp1, temp2;

                for (int i = 0; i < dtTemp.Rows.Count; i++)
                {
                    cnt = i;
                    if (distinct_row != dtTemp.Rows[i]["DISTINCTROW"].ToString())
                    {
                        dtSource.Rows.Add();
                    }
                    distinct_row = dtTemp.Rows[i]["DISTINCTROW"].ToString();
                    for (int j = 0; j < _start_column - 1; j++)
                    {
                        dtSource.Rows[dtSource.Rows.Count - 1][j] = dtTemp.Rows[i][j];
                    }

                    int.TryParse(dtTemp.Rows[i]["QTY"].ToString(), out temp1);
                    int.TryParse(dtSource.Rows[dtSource.Rows.Count - 1][dtTemp.Rows[i]["CS_SIZE"].ToString()].ToString(), out temp2);
                    dtSource.Rows[dtSource.Rows.Count - 1][dtTemp.Rows[i]["CS_SIZE"].ToString()] = Convert.ToDecimal(temp1 + temp2);
                    int.TryParse(dtSource.Rows[dtSource.Rows.Count - 1][_start_column - 1].ToString(), out temp2);
                    dtSource.Rows[dtSource.Rows.Count - 1][_start_column - 1] = (temp1 + temp2).ToString();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //----------------------------//
        private void formatgrid()
        {
            try
            {
                gvwBase2.BeginUpdate();
                gvwBase2.OptionsView.ColumnAutoWidth = false;
                for (int i = 0; i < gvwBase2.Columns.Count; i++)
                {
                    gvwBase2.Columns[i].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    gvwBase2.Columns[i].AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    gvwBase2.Columns[i].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    gvwBase2.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                    gvwBase2.Columns[i].OptionsColumn.ReadOnly = true;
                    gvwBase2.Columns[i].OptionsColumn.AllowEdit = false;
                    if (i > 5)
                    {
                        gvwBase2.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                        gvwBase2.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                        gvwBase2.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        gvwBase2.Columns[i].DisplayFormat.FormatString = i <= 8 ? "#,0" : "#,#";
                        gvwBase2.Columns[i].Width = 50;
                        if (gvwBase2.Columns[i].FieldName.Equals("Total"))
                        {
                            gvwBase2.Columns[i].Visible = false;

                        }

                        if (i <= 7)
                        {
                            gvwBase2.Columns[i].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                            gvwBase2.Columns[i].Width = 65;
                        }
                    }
                    else
                    {
                        gvwBase2.Columns[i].Width = 180;
                        gvwBase2.Columns[i].OptionsColumn.AllowMerge = i <= 4 ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
                        gvwBase2.Columns[i].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                        gvwBase2.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                    }
                }
                gvwBase2.Columns[0].Visible = false;
                gvwBase2.Columns[1].Visible = false;
                gvwBase2.Columns[2].Width = 90;
                gvwBase2.Columns[3].Width = 65;
                gvwBase2.Columns[4].Width = 65;
                gvwBase2.Columns[5].Width = 100;
                gvwBase2.Columns[5].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                gvwBase2.EndUpdate();
            }
            catch { }
        }

        //--------------------------------------------------//
        //Event
        private void gvwBase2_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView ex = sender as GridView;

            if (e.Column.ColumnHandle > 4)
            {
                if (ex.GetRowCellValue(e.RowHandle, "Div").ToString().ToUpper().Equals("BOTTOM SET"))
                {
                    e.Appearance.BackColor = Color.FromArgb(242, 242, 242);
                }
                else if (ex.GetRowCellValue(e.RowHandle, "Div").ToString().ToUpper().Equals("STOCKFIT INCOMING SET"))
                {
                    e.Appearance.BackColor = Color.White;
                }
            }

            if (e.Column.ColumnHandle > 5 && (!ex.GetRowCellValue(e.RowHandle, "Plant").ToString().Contains("Total") && !ex.GetRowCellValue(e.RowHandle, "Factory").ToString().Contains("Total")))
            {

                if (e.CellValue == null || e.CellValue.ToString() == "") return;
                if (e.Column.FieldName.Contains("Total Inv"))
                {
                    if (Convert.ToDouble(e.CellValue.ToString().Replace(",", "")) < 0)
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.ForeColor = Color.White;
                    }
                    else if (Convert.ToDouble(e.CellValue.ToString().Replace(",", "")) >= Convert.ToDouble(ex.GetRowCellValue(e.RowHandle, "Target").ToString().Replace(",", "")))
                    {
                        e.Appearance.BackColor = Color.Green;
                        e.Appearance.ForeColor = Color.White;
                    }
                    else if (Convert.ToDouble(e.CellValue.ToString().Replace(",", "")) < Convert.ToDouble(ex.GetRowCellValue(e.RowHandle, "Target").ToString().Replace(",", "")))
                    {
                        e.Appearance.BackColor = Color.Yellow;
                    }
                }
            }
            if (e.Column.ColumnHandle > 2)
            {
                if (ex.GetRowCellValue(e.RowHandle, "Plant").ToString() == "Total")
                {
                    e.Appearance.BackColor = Color.LightCyan;
                    e.Appearance.ForeColor = Color.Coral;
                }
            }
            if (e.Column.ColumnHandle > 1)
            {
                if (ex.GetRowCellValue(e.RowHandle, "Factory").ToString() == "G-Total")
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                    e.Appearance.ForeColor = Color.Black;
                }
            }
        }

        //MAIN
        private void FRM_BOTTOM_INV_SET_ANALYSIS_Load_1(object sender, EventArgs e)
        {
            lblDateTime.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            cCount++;
            lblDateTime.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
            if (cCount >= 60)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    splashScreenManager1.ShowWaitForm();
                    cCount = 0;
                    BindingData("Q", DateTime.Now.ToString("yyyyMMdd"), ComponentNM);
                    splashScreenManager1.CloseWaitForm();
                    this.Cursor = Cursors.Default;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    splashScreenManager1.CloseWaitForm();
                    this.Cursor = Cursors.Default;
                }


            }
        }

        private void FRM_BOTTOM_INV_SET_ANALYSIS_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                cCount = 60;
                tmr.Start();
            }
            else
            {
                tmr.Stop();

            }
        }
    }
}
