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
    public partial class FORM_SMT_PH_PROD_MONTH : SampleFrm2
    {
        public FORM_SMT_PH_PROD_MONTH()
        {
            InitializeComponent();
            lblTitle.Text = "CMP Production Status by Month";
           // formName = "FORM_SMT_PH_PROD_MONTH";
            this.Name = "FORM_SMT_PH_PROD_MONTH";
            this.Text = "FORM_SMT_PH_PROD_MONTH";
        }

        public static string _sProcess = "CMP";
        public int iCount = 0;

        private void FORM_SMT_PH_PROD_MONTH_Load(object sender, EventArgs e)
        {
            //lblRubber_Click(null, null);
            //Search_Data();
            tmr_Load.Interval = 1000;
            //tmr_Load.Start();
        }

        public DataTable SEL_OS_PROD_MONTH(string ARG_QTYPE, string ARG_OP)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "MES.PKG_SMT_B1.SP_OS_PROD_MONTH";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "V_P_TYPE";
                MyOraDB.Parameter_Name[1] = "V_P_OP";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = ARG_QTYPE;
                MyOraDB.Parameter_Values[1] = ARG_OP;
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
                dtsource = SEL_OS_PROD_MONTH("H", "");
                if (dtsource != null && dtsource.Rows.Count > 0)
                {
                    string name;
                    bandMon.Caption = dtsource.Rows[0]["MON"].ToString();
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
            grdView.Refresh();
            DataTable dtsource = null;
            dtsource = SEL_OS_PROD_MONTH("Q", arg_op);
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
                    gvwView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    gvwView.Columns[i].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    if (i > 0)
                    {
                        gvwView.Columns[i].AppearanceCell.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                    }

                }

            }
        }

        private void bindingdatachart(string arg_op)
        {
            DataTable dt = null;
            dt = SEL_OS_PROD_MONTH("C", arg_op);
            chartSlabtest.DataSource = dt;
            chartSlabtest.Series[0].ArgumentDataMember = "YMD";
            chartSlabtest.Series[0].ValueDataMembers.AddRange(new string[] { "PLAN_QTY" });
            chartSlabtest.Series[1].ArgumentDataMember = "YMD";
            chartSlabtest.Series[1].ValueDataMembers.AddRange(new string[] { "PROD_QTY" });
            chartSlabtest.Series[2].ArgumentDataMember = "YMD";
            chartSlabtest.Series[2].ValueDataMembers.AddRange(new string[] { "POD" });
            //chartControl1.Series[1].ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
        }

        private void tmr_Load_Tick(object sender, EventArgs e)
        {
            iCount++;
            if (iCount >= 40)
            {
                if (Form_Home_DMP_DMC._type == "CMP")
                    lblRubber_Click(null, null);
                else
                    lblEVA_Click(null, null);
                iCount = 0;
            }
        }

        private void lblEVA_Click(object sender, EventArgs e)
        {
            pnEVA.GradientEndColor = Color.White; //Color.FromArgb(255, 128, 128);
            pnRubber.GradientEndColor = Color.Gray;
            lblTitle.Text = "Phylon Production Status by Month";
            _sProcess = "PHP";
            Form_Home_DMP_DMC._type = "PHP";
            BindingData(_sProcess);
            bindingdatachart(_sProcess);
            iCount = 0;
        }

        private void lblRubber_Click(object sender, EventArgs e)
        {
            pnRubber.GradientEndColor = Color.White;//Color.FromArgb(255, 128, 128);
            pnEVA.GradientEndColor = Color.Gray;
            lblTitle.Text = "CMP Production Status by Month";
            _sProcess = "CMP";
            Form_Home_DMP_DMC._type = "CMP";
            BindingData(_sProcess);
            bindingdatachart(_sProcess);
            iCount = 0;
        }

        private void FORM_SMT_PH_PROD_MONTH_VisibleChanged(object sender, EventArgs e)
        {

            if (this.Visible)
            {
                iCount = 39;
                tmr_Load.Start();
                tmrTime.Start();
            }
            else
            {
                tmr_Load.Stop();
                tmrTime.Stop();
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
            if (e.Column.ColumnHandle == 1)
            {
                e.Appearance.BackColor = Color.LightGray;//Color.FromArgb(80, 209, 244);
                e.Appearance.ForeColor = Color.Black;
                e.Appearance.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);
            }
            else
            {

            }
        }
    }
}
