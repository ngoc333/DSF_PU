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
using System.Globalization;

namespace Smart_FTY
{
    public partial class FORM_SMT_PU_LEADTIME_MONTH : Form
    {
        public FORM_SMT_PU_LEADTIME_MONTH()
        {
            InitializeComponent();
            lblTitle.Text = "Lead Time By Month";
           
        }

        public static string _sProcess = "PUP";
        public int iCount = 0;

        private void FORM_SMT_PH_PROD_MONTH_Load(object sender, EventArgs e)
        {
            //lblRubber_Click(null, null);
            //Search_Data();
            tmr_Load.Interval = 1000;
            //tmr_Load.Start();
            GoFullscreen();
        }

        private void GoFullscreen()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

        }

        public DataSet SEL_OS_PROD_MONTH(string ARG_QTYPE, string ARG_YMD, string ARG_OP)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "MES.PKG_SMT_B_LEADTIME.SEL_LEAD_TIME_BY_MONTH";

                MyOraDB.ReDim_Parameter(5);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_OP_CD";
                MyOraDB.Parameter_Name[1] = "ARG_TYPE";
                MyOraDB.Parameter_Name[2] = "ARG_YMD";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR1";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = ARG_OP;
                MyOraDB.Parameter_Values[1] = ARG_QTYPE;
                MyOraDB.Parameter_Values[2] = ARG_YMD;
                MyOraDB.Parameter_Values[3] = "";
                MyOraDB.Parameter_Values[4] = "";

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

        private DataTable getDataChart(DataSet arg_ds)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("YMD");
                dt.Columns.Add("QTY", typeof(double));
                DataRow dr;
                for (int i = 0; i < arg_ds.Tables[1].Rows.Count; i++)
                {
                    if (arg_ds.Tables[1].Rows[i]["HOLI_YN"].ToString() == "N")
                    {
                        dr = dt.NewRow();
                        dr["YMD"] = arg_ds.Tables[1].Rows[i]["DA"].ToString();
                        dr["QTY"] = arg_ds.Tables[0].Rows[0][i + 1];
                        dt.Rows.Add(dr);
                    }
                }
                return dt;
            }
            catch
            {
                return null;
            }

        }

        private void formatband( DataTable arg_dt)
        {
            try
            {
                int i = 0;
              //  DataTable arg_dt = null;
              //  dtsource = SEL_OS_PROD_MONTH("H", uc_month.GetValue().ToString(), "");
                if (arg_dt != null && arg_dt.Rows.Count > 0)
                {
                  //  string name;
                    bandMon.Caption = arg_dt.Rows[0]["MON"].ToString();
                    if (arg_dt.Rows.Count > 0)
                    {
                        foreach (DevExpress.XtraGrid.Views.BandedGrid.GridBand band in gvwView.Bands[1].Children)
                        {
                            if (arg_dt.Rows[i]["HOLI_YN"].ToString() == "Y")
                            {
                                band.Visible = false;                              
                            }
                            else
                            {
                                band.Visible = true;
                            }
                            i++;
                            //if (i == arg_dt.Rows.Count - 1)
                            //{
                            //    band.Visible = false;
                            //}

                            //double num;
                            //if (double.TryParse(band.Caption, out num))
                            //{
                            //    for (int i = 0; i < arg_dt.Rows.Count; i++)
                            //    {
                            //        if (band.Name.Contains(arg_dt.Rows[i][0].ToString().Substring(arg_dt.Rows[i][0].ToString().Length - 2)))
                            //        {
                            //            band.Visible = true;
                            //            break;
                            //        }
                            //        if (i == arg_dt.Rows.Count - 1)
                            //        {
                            //            band.Visible = false;
                            //        }
                            //    }
                            //}
                        }
                    }
                    //bandDate.Width = 140;
                    //bandAVG.Width = 80;
                    //bandMon.Width = (grdView.Width - 220) / dtsource.Rows.Count;
                    //gvwView.OptionsView.ColumnAutoWidth = false;
                }
            }
            catch
            {
                return;
            }
        }

        private void BindingData(string arg_op)
        {
            try
            {
                grdView.Refresh();
                DataSet ds = SEL_OS_PROD_MONTH("Q", uc_month.GetValue().ToString(), arg_op);
                DataTable dtsource = null;
                dtsource = ds.Tables[0];
                formatband(ds.Tables[1]);
                grdView.DataSource = dtsource;
                if (dtsource != null && dtsource.Rows.Count > 0)
                {

                    for (int i = 0; i < gvwView.Columns.Count; i++)
                    {
                        gvwView.Columns[i].OptionsColumn.ReadOnly = true;
                        gvwView.Columns[i].OptionsColumn.AllowEdit = false;
                        gvwView.Columns[i].OptionsFilter.AllowFilter = false;
                        gvwView.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        gvwView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gvwView.Columns[i].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                        gvwView.Columns[i].AppearanceCell.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);

                    }
                    bindingdatachart(getDataChart(ds));

                }
            }
            catch 
            {}
           
        }

        private void bindingdatachart(DataTable arg_dt)
        {
            // DataTable dt = null;
            // dt = SEL_OS_PROD_MONTH("C", uc_month.GetValue().ToString(), arg_op);
            chartSlabtest.DataSource = arg_dt;
            chartSlabtest.Series[0].ArgumentDataMember = "YMD";
            chartSlabtest.Series[0].ValueDataMembers.AddRange(new string[] { "QTY" });
            //chartSlabtest.Series[1].ArgumentDataMember = "YMD";
            //chartSlabtest.Series[1].ValueDataMembers.AddRange(new string[] { "PROD_QTY" });
            //chartSlabtest.Series[2].ArgumentDataMember = "YMD";
            //chartSlabtest.Series[2].ValueDataMembers.AddRange(new string[] { "POD" });
            //chartControl1.Series[1].ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
        }

        private void tmr_Load_Tick(object sender, EventArgs e)
        {
            iCount++;
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
            if (iCount >= 40)
            {
                iCount = 0;
                BindingData("PUP");
            }
        }

       

        private void FORM_SMT_PH_PROD_MONTH_VisibleChanged(object sender, EventArgs e)
        {

            if (this.Visible)
            {
                iCount = 38;
                tmr_Load.Start();
               // tmrTime.Start();
            }
            else
            {
                tmr_Load.Stop();
             //   tmrTime.Stop();
            }
        }

        private void chartSlabtest_CustomDrawAxisLabel(object sender, CustomDrawAxisLabelEventArgs e)
        {
            try
            {
                if (e.Item.Axis is AxisX)
                {
                    e.Item.Text = e.Item.Text.Replace("_", "\n");
                }
            }
            catch
            {

            }
        }

        private void gvwView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //if (e.Column.ColumnHandle == 1)
            //{
            //    e.Appearance.BackColor = Color.LightGray;//Color.FromArgb(80, 209, 244);
            //    e.Appearance.ForeColor = Color.Black;
            //    e.Appearance.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);
            //}
            //else
            //{

            //}
        }

        private void uc_month_ValueChangeEvent(object sender, EventArgs e)
        {
            try
            {
                BindingData("PUP");
                iCount = 0;
            }
            catch
            { 
            }
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmdYear_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FORM_SMT_PU_LEADTIME_YEAR"];
            if (fc != null)
            {

                fc.Show();
                this.Hide();
            }
            else
            {
                FORM_SMT_PU_LEADTIME_YEAR f = new FORM_SMT_PU_LEADTIME_YEAR();
                f.Show();
                this.Hide();
            }
        }

        private void cmdDay_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FORM_SMT_PU_LEADTIME"];
            if (fc != null)
            {

                fc.Show();
                this.Hide();
            }
            else
            {
                FORM_SMT_PU_LEADTIME f = new FORM_SMT_PU_LEADTIME();
                f.Show();
                this.Hide();
            }
        }
       
        private void cmdWeek_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FORM_SMT_PU_LEADTIME_WEEK"];
            if (fc != null)
            {

                fc.Show();
                this.Hide();
            }
            else
            {
                FORM_SMT_PU_LEADTIME_WEEK f = new FORM_SMT_PU_LEADTIME_WEEK();
                f.Show();
                this.Hide();
            }
        }
    }
}
