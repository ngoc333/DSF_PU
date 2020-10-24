using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGauges.Core.Model;
//using JPlatform.Client.Controls;


namespace Smart_FTY
{
    public partial class FRM_ROLL_INV_TRACKING : SampleFrm1
    {
        public FRM_ROLL_INV_TRACKING()
        {
            InitializeComponent();
        }

        int cnt = 0;
        string str_op = "";

        private void FRM_ROLL_SLABTEST_MON_Load(object sender, EventArgs e)
        {
            pnButton.Visible = false;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;            
        }

        public DataTable SEL_DATA_SLABTEST(string Qtype, string arg_op)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_ROLL.SP_ROLL_WIP"; //SP_SMT_ANDON_DAILY

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "V_P_TYPE";
                MyOraDB.Parameter_Name[1] = "V_P_OP";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = Qtype;
                MyOraDB.Parameter_Values[1] = arg_op;
                MyOraDB.Parameter_Values[2] = "";


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

        private void formatband()
        {
            try
            {
                int n;
                DataTable dtsource = null;
                dtsource = SEL_DATA_SLABTEST("H", "");
                if (dtsource != null && dtsource.Rows.Count > 0)
                {
                    string name;
                    if (dtsource.Rows.Count > 0)
                    {
                        foreach (DevExpress.XtraGrid.Views.BandedGrid.GridBand band in gvwView.Bands[1].Children)
                        {
                            double num;
                            if (double.TryParse(band.Caption, out num))
                            {
                                for (int i = 0; i < dtsource.Rows.Count; i++)
                                {
                                    if (band.Name.Contains(dtsource.Rows[i][0].ToString().Substring(dtsource.Rows[i][0].ToString().Length - 2)))
                                    {
                                        band.Visible = true;
                                        break;
                                    }
                                    if (i == dtsource.Rows.Count - 1)
                                    {
                                        band.Visible = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void BindingData(string arg_op)
        {
            grdView.Refresh();
            DataTable dtsource = null;
            dtsource = SEL_DATA_SLABTEST("Q", arg_op);
            formatband();
            grdView.DataSource = dtsource;
            if (dtsource != null && dtsource.Rows.Count > 0)
            {                
                for (int i = 0; i < gvwView.Columns.Count; i++)
                {
                    gvwView.Columns[i].OptionsColumn.ReadOnly = true;
                    gvwView.Columns[i].OptionsColumn.AllowEdit = false;
                    gvwView.Columns[i].OptionsFilter.AllowFilter = false;
                    gvwView.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                    if (i > 2)
                    {
                        gvwView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                        gvwView.Columns[i].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    }
                    else if (i < 1)
                    {
                        gvwView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gvwView.Columns[i].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    }
                    else
                    {
                        gvwView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                        gvwView.Columns[i].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    }
                    
                }
                gvwView.TopRowIndex = gvwView.RowCount - 11;
            }
        }

        private void bindingdatachart(string arg_op)
        {
            DataTable dt = null;
            dt = SEL_DATA_SLABTEST("C", arg_op);
            chartINV.DataSource = dt;
            chartINV.Series[0].ArgumentDataMember = "MON";
            chartINV.Series[0].ValueDataMembers.AddRange(new string[] { "QTY" });
            //chartControl1.Series[1].ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
        }

        private void BindingGauges(string arg_op)
        {
            DataTable dt = SEL_DATA_SLABTEST("G", arg_op);
            arcScaleGauges.EnableAnimation = false;
            arcScaleGauges.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseIn;
            arcScaleGauges.EasingFunction = new BackEase();
            arcScaleGauges.MinValue = 0;
            arcScaleGauges.MaxValue = Convert.ToInt32(dt.Rows[0]["DAYS"]) + 2;
            //arcScaleGauges.Ranges[0].EndValue = arcScaleGauges.Ranges[1].StartValue = Convert.ToSingle(10);
            //arcScaleGauges.Ranges[1].EndValue = arcScaleGauges.Ranges[2].StartValue = Convert.ToSingle(15);
            //arcScaleGauges.Ranges[2].EndValue = Convert.ToSingle(20);
            arcScaleGauges.Value = 0;
            labelGauges.Text = "0";
            //if (dt != null && dt.Rows.Count > 0)
            //{
            try
            {

                arcScaleGauges.MinValue = 0;
                arcScaleGauges.MaxValue = Convert.ToInt32(dt.Rows[0]["DAYS"]) + 2;
                //arcScaleGauges.Ranges[0].EndValue = arcScaleGauges.Ranges[1].StartValue = Convert.ToSingle(Convert.ToSingle(dt.Rows[0][0]) - 2);
                //arcScaleGauges.Ranges[1].EndValue = arcScaleGauges.Ranges[2].StartValue = Convert.ToSingle(Convert.ToSingle(dt.Rows[0][0]) + 2);
                //arcScaleGauges.Ranges[2].EndValue = Convert.ToSingle(Convert.ToSingle(dt.Rows[0][0]) + 5);

                arcScaleGauges.EnableAnimation = true;
                arcScaleGauges.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseInOut;
                arcScaleGauges.EasingFunction = new BackEase();
                double num = Convert.ToDouble(dt.Rows[0]["DAYS"]); //Convert.ToDouble(GetRandomNumber(20, 999));
                arcScaleGauges.Value = (float)num;
                labelGauges.Text = num.ToString();
                lblTar.Text = dt.Rows[0]["TARGET"].ToString();
                lblProd.Text = dt.Rows[0]["PROD_QTY"].ToString();
            }
            catch (Exception ex)
            { }
            // }
        }

        private void gvwView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

            if (gvwView.GetRowCellDisplayText(e.RowHandle, gvwView.Columns["MCS_NAME"]) == "TOTAL")
            {
                e.Appearance.BackColor = Color.LightYellow;
                e.Appearance.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);

            }
            else if (gvwView.GetRowCellDisplayText(e.RowHandle, gvwView.Columns["MCS_NAME"]) == "G-TOTAL")
            {
                e.Appearance.BackColor = Color.LightSeaGreen;
                e.Appearance.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cnt < 40)
            {
                cnt++;                
            }
            else
            {
                cnt = 0;
                BindingData(str_op);
                bindingdatachart(str_op);
            }
        }

        private void FRM_ROLL_SLABTEST_MON_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    lblRubber_Click(sender, e);
                    timer1.Start();
                    cnt = 0;
                }
                else
                    timer1.Stop();
            }
            catch
            {

            }
        }

        private void lblRubber_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Rubber Inventory";
            BindingData("OS");
            bindingdatachart("OS");
            BindingGauges("OS");
            str_op = "OS";
            pnRubber.GradientEndColor = Color.White;//Color.FromArgb(255, 128, 128);
            pnEVA.GradientEndColor = Color.Gray;
        }

        private void lblEVA_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "EVA Inventory";
            BindingData("EV");
            bindingdatachart("EV");
            BindingGauges("EV");
            str_op = "EV";
            pnEVA.GradientEndColor = Color.White; //Color.FromArgb(255, 128, 128);
            pnRubber.GradientEndColor = Color.Gray;
        }

        private void cmdYear_Click(object sender, EventArgs e)
        {

        }
    }
}
