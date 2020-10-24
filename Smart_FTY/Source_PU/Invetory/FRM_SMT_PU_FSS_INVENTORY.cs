using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace Smart_FTY
{
    public partial class FRM_SMT_PU_FSS_INVENTORY : Form
    {
        public FRM_SMT_PU_FSS_INVENTORY()
        {
            InitializeComponent();
           
        }

        int cnt = 0;
        string str_op = "";
        public delegate void MenuHandler();
        public MenuHandler OnClick = null;

        private void FRM_ROLL_SLABTEST_MON_Load(object sender, EventArgs e)
        {            
            timer2.Enabled = true;
            timer2.Start();
            timer2.Interval = 1000;
        }


        public DataTable SEL_OS_INVENTORY(string ARG_QTYPE, string ARG_OP, string ARG_FS)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "MES.PKG_SMT_B2.SP_PU_INVENTORY";

                MyOraDB.ReDim_Parameter(4);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "V_P_TYPE";
                MyOraDB.Parameter_Name[1] = "V_P_OP";
                MyOraDB.Parameter_Name[2] = "V_P_FS";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = ARG_QTYPE;
                MyOraDB.Parameter_Values[1] = ARG_OP;
                MyOraDB.Parameter_Values[2] = ARG_FS;
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

        private void BindingData(string arg_op, string arg_fs)
        {
            try
            {
                //grdView.Refresh();
                DataTable dtsource = null;
                dtsource = SEL_OS_INVENTORY("Q", arg_op, arg_fs);
                //formatband();

                bandPlan.Caption = "0";
                bandFSINV.Caption = "0";
                bandFSLT.Caption = "0";
                bandUVINV.Caption = "0";
                bandUVLT.Caption = "0";
                bandSPINV.Caption = "0";
                bandSPLT.Caption = "0";

                if (dtsource != null && dtsource.Rows.Count > 0)
                {
                    bandPlan.Caption = Convert.ToDouble(dtsource.Rows[0]["PLAN_QTY"].ToString()).ToString("#,0");
                    bandFSINV.Caption = Convert.ToDouble(dtsource.Rows[0]["FS_INV"].ToString()).ToString("#,0");
                    bandFSLT.Caption = Convert.ToDouble(dtsource.Rows[0]["FS_LT"].ToString()).ToString("#,0.0");
                    bandUVINV.Caption = Convert.ToDouble(dtsource.Rows[0]["UV_INV"].ToString()).ToString("#,0");
                    bandUVLT.Caption = Convert.ToDouble(dtsource.Rows[0]["UV_LT"].ToString()).ToString("#,0.0");
                    bandSPINV.Caption = Convert.ToDouble(dtsource.Rows[0]["SP_INV"].ToString()).ToString("#,0");
                    bandSPLT.Caption = Convert.ToDouble(dtsource.Rows[0]["SP_LT"].ToString()).ToString("#,0.0");

                    bandTotal_INV.Caption = Convert.ToDouble(dtsource.Rows[0]["TOTAL_INV"].ToString()).ToString("#,0");
                    bandTotal_LT.Caption = Convert.ToDouble(dtsource.Rows[0]["TOTAL_LT"].ToString()).ToString("#,0.0");
                    grdView.DataSource = dtsource.Select("MODEL_NM <> 'TOTAL'").CopyToDataTable();
                    for (int i = 0; i < gvwView.Columns.Count; i++)
                    {
                        gvwView.Columns[i].OptionsColumn.ReadOnly = true;
                        gvwView.Columns[i].OptionsColumn.AllowEdit = false;
                        gvwView.Columns[i].OptionsFilter.AllowFilter = false;
                        gvwView.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                        gvwView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gvwView.Columns[i].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                        if (i >= 0)
                        {
                            gvwView.Columns[i].AppearanceCell.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Regular);
                            if (i == 1 ||  i == 2 ||i == 4 ||i == 6 || i == 8)
                            {
                                gvwView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                                gvwView.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                                gvwView.Columns[i].DisplayFormat.FormatString = "#,0";
                            }
                            else if (i == 3 || i== 5 || i == 7 || i == 9)
                            {
                                gvwView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                                gvwView.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                                gvwView.Columns[i].DisplayFormat.FormatString = "#,0.0";
                            }
                        }

                    }
                    DataTable dttmp = dtsource.Select("MODEL_NM <> 'TOTAL' AND FS_INV <> '0'").CopyToDataTable();
                    bindingdatachart(dtsource.Select("MODEL_NM <> 'TOTAL' AND FS_INV <> '0'").CopyToDataTable());
                }
                else
                {
                    grdView.DataSource = dtsource;
                    bindingdatachart(dtsource);
                }
            }
            catch { }
        }

        private void bindingdatachart(DataTable dt)
        {
           
                chartSlabtest.DataSource = dt;
                chartSlabtest.Series[0].ArgumentDataMember = "MODEL_NM";
                chartSlabtest.Series[0].ValueDataMembers.AddRange(new string[] { "FS_INV" });
                chartSlabtest.Series[1].ArgumentDataMember = "MODEL_NM";
                chartSlabtest.Series[1].ValueDataMembers.AddRange(new string[] { "FS_LT" });
                //chartControl1.Series[1].ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
         
        }

        private void gvwView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //if (e.RowHandle == 0)
            //{
            //    e.Appearance.BackColor = Color.LightGray;//Color.FromArgb(80, 209, 244);
            //    e.Appearance.ForeColor = Color.Black;
            //    e.Appearance.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);
            //}
            //else
            //{
                
            //}
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            if (cnt < 30)
            {
                cnt++;                
            }
            else
            {
                cnt = 0;
                BindingData("PUP","FS");
                //bindingdatachart("OSP");
            }
        }

        private void FRM_ROLL_SLABTEST_MON_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    timer2.Start();
                    cnt = 30;
                }
                else
                    timer2.Stop();
            }
            catch
            {

            }
        }

        private void chartSlabtest_CustomDrawAxisLabel(object sender, DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs e)
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

        private void cmdBack_Click(object sender, EventArgs e)
        {
            Smart_FTY.ComVar._frm_home.Show();
            this.Hide();
        }
    }
}
