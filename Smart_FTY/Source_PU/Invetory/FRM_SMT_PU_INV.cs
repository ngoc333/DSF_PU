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
    public partial class FRM_SMT_PU_INV : Form
    {
        public FRM_SMT_PU_INV()
        {
            InitializeComponent();
            //formName = "FRM_SMT_PU_INV";
            this.Name = "FRM_SMT_PU_INV";
            this.Text = "FRM_SMT_PU_INV";
            lblTitle.Text = "Pour Inventory";
            if (_sProcess == "CMP")
                lblRubber_Click(null, null);
            else
                lblEVA_Click(null, null);
        }

        public static string _sProcess = "CMP";
        public int iCount = 0;
        bool _bLoad = true;

        public FRM_SMT_PU_INV( string argFrm)
        {
            InitializeComponent();
            //formName = "FRM_SMT_PU_INV";
            this.Name = "FRM_SMT_PU_INV";
            this.Text = "FRM_SMT_PU_INV";
            //lblTitle.Text = "PU Inventory";
            _sProcess = "PHP";
            this.Text = "INV2";
            pnRubber.Visible = false;
            pnEVA.Visible = false;
            //pnHeader.BackColor = Color.RoyalBlue;
           // pnHeader.BackColor = Color.RoyalBlue;

            if (_sProcess == "CMP")
                lblRubber_Click(null, null);
            else
                lblEVA_Click(null, null);

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
                MyOraDB.Parameter_Values[2] = ARG_OP;
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
                grdView.Refresh();
                DataTable dtsource = null;
                dtsource = SEL_OS_INVENTORY("Q", arg_op, arg_fs);
                //formatband();

                bandPlan.Caption = "0";
                bandInv.Caption = "0";
                bandLT.Caption = "0";

                if (dtsource != null && dtsource.Rows.Count > 0)
                {
                    bandPlan.Caption = Convert.ToDouble(dtsource.Rows[0]["PLAN_QTY"].ToString()).ToString("#,0");
                    bandInv.Caption = Convert.ToDouble(dtsource.Rows[0]["INV"].ToString()).ToString("#,0");
                    bandLT.Caption = Convert.ToDouble(dtsource.Rows[0]["LT"].ToString()).ToString("#,0.0");
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
                            if (i > 0 && i < 3)
                            {
                                gvwView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                                gvwView.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                                gvwView.Columns[i].DisplayFormat.FormatString = "#,0";
                            }
                            else if (i == 3)
                            {
                                gvwView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                                gvwView.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                                gvwView.Columns[i].DisplayFormat.FormatString = "#,0.0";
                            }
                        }

                    }
                    bindingdatachart(dtsource.Select("MODEL_NM <> 'TOTAL'").CopyToDataTable());
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
            chartSlabtest.Series[0].ValueDataMembers.AddRange(new string[] { "INV" });
            chartSlabtest.Series[1].ArgumentDataMember = "MODEL_NM";
            chartSlabtest.Series[1].ValueDataMembers.AddRange(new string[] { "LT" });
            //chartControl1.Series[1].ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
        }


        private void FORM_SMT_B_PROD_MONTHLY_Load(object sender, EventArgs e)
        {
            //lblRubber_Click(null, null);
            //Search_Data();
            tmr_Load.Interval = 1000;
            lblDateTime.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            
        }
       
        
        private void tmr_Load_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            iCount++;
            if (iCount >= 40)
            {
                iCount = 0;
                if (_sProcess == "PUP")
                    lblRubber_Click(null, null);
                else
                    lblEVA_Click(null, null);
                
            }
        }

        private void lblEVA_Click(object sender, EventArgs e)
        {
            pnEVA.GradientEndColor = Color.White; //Color.FromArgb(255, 128, 128);
            pnRubber.GradientEndColor = Color.Gray;
            PnTotal.GradientEndColor = Color.Gray;
            pnEVA.Enabled = false;
            pnRubber.Enabled = true;
            PnTotal.Enabled = true;
            lblTitle.Text = "Spray Inventory";
            _sProcess = "PUB";
            BindingData(_sProcess,"PU");
            iCount = 0;
        }

        private void lblRubber_Click(object sender, EventArgs e)
        {
            pnRubber.GradientEndColor = Color.White;//Color.FromArgb(255, 128, 128);
            pnEVA.GradientEndColor = Color.Gray;
            PnTotal.GradientEndColor = Color.Gray;
            pnEVA.Enabled = true;
            pnRubber.Enabled = false;
            PnTotal.Enabled = true;
            lblTitle.Text = "Pour Inventory";
            _sProcess = "PUP";
            BindingData(_sProcess,"PU");
            iCount = 0;
        }

        private void FRM_SMT_PU_INV_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                if (_bLoad) iCount = 0;
                else iCount = 39;
                _bLoad = false;
                
                tmr_Load.Start();
            }
            else
            {
                tmr_Load.Start();
            }
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            Smart_FTY.ComVar._frm_home.Show();
            this.Hide();
        }

        private void lblPUT_Click(object sender, EventArgs e)
        {
            pnRubber.GradientEndColor = Color.Gray;//Color.FromArgb(255, 128, 128);
            pnEVA.GradientEndColor = Color.Gray;
            PnTotal.GradientEndColor = Color.White;
            PnTotal.Enabled = false;
            pnEVA.Enabled = true;
            pnRubber.Enabled = true;
            lblTitle.Text = "PU Total Inventory";
            _sProcess = "PUT";
            BindingData(_sProcess, "PU");
            iCount = 0;
        }


    }
}
