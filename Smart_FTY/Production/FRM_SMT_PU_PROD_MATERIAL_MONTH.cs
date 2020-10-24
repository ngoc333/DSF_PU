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
    public partial class FRM_SMT_PU_PROD_MATERIAL_MONTH : Form
    {
        public FRM_SMT_PU_PROD_MATERIAL_MONTH()
        {
            InitializeComponent();
            lblTitle.Text = "PU Material Tallysheet By Month";
            
        }

        public static string _sProcess = "PUP";
        public int iCount = 0;

        private void FRM_SMT_PU_PROD_MONTH_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //lblRubber_Click(null, null);
            //Search_Data();
            tmr_Load.Interval = 1000;
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
            //tmr_Load.Start();
        }

        public DataTable SEL_OS_PROD_MONTH(string ARG_QTYPE, string ARG_OP)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "MES.PKG_SMT_PU.SEL_PROD_MATERIAL_MONTH";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_OP_CD";
                MyOraDB.Parameter_Name[1] = "ARG_YM";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = ARG_OP;
                MyOraDB.Parameter_Values[1] = uc_month.GetValue();
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
                    //bandMon.Caption = dtsource.Rows[0]["MON"].ToString();
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

        string convert(string value, string textPlus)
        {
            double dValue;
            //string strReturn;
            double.TryParse(value, out dValue);
            if (dValue == 0)
                return value;
            else
            {
                if (textPlus == "")
                    return dValue.ToString("###,###,###");
                else
                    return dValue.ToString("###,###,##0.#") + textPlus;
            }


        }

        private void BindingData(string arg_op)
        {
            DataTable dtsource = SEL_OS_PROD_MONTH("Q", arg_op);
            axGrid.MaxRows = 5;
            axGrid.MaxRows = 50;
            axGrid.ColsFrozen = 3;
            axGrid.set_ColWidth(3, 0.1);
            //double dValue;
            for (int iColDt = 1; iColDt < dtsource.Columns.Count; iColDt++)
            {
                for (int iRowDt = 0; iRowDt < dtsource.Rows.Count; iRowDt++)
                {
                    if (iColDt >2)
                        axGrid.Col = iColDt +1;
                    else
                        axGrid.Col = iColDt;
                    axGrid.Row = iRowDt +4;
                    if (iColDt >2 && (iColDt-2)%3 == 0)
                        axGrid.Text = convert(dtsource.Rows[iRowDt][iColDt].ToString(),"%");
                    else
                        axGrid.Text = convert(dtsource.Rows[iRowDt][iColDt].ToString(), "");

                }
            }
            axGrid.MaxCols = dtsource.Columns.Count -1;
            axGrid.MaxRows = dtsource.Rows.Count +3;
            
            string strPrvText;
            Color clPrev = Color.FromArgb(242, 242, 242);
            for (int i = 5; i <= axGrid.MaxRows; i++)
            {
                axGrid.Col = 1;
                axGrid.Row =  i-1;
                strPrvText = axGrid.Text;

                axGrid.Row = i;
                if (axGrid.Text != strPrvText)
                {
                    if (clPrev == Color.FromArgb(242, 242, 242))
                    {
                        clPrev = Color.FromArgb(224, 224, 235);
                    }
                    else
                    {
                        clPrev = Color.FromArgb(242, 242, 242);
                    }
                    //Color.FromArgb(255, 229, 204);
                }
                axGrid.Col = 2;
                if (axGrid.Text == "TOTAL")
                {
                    axGrid.Col = -1;
                    axGrid.BackColor = Color.Orange;
                }
                else
                {
                    axGrid.Col = -1;
                    axGrid.BackColor = clPrev;
                }
                
                    


                
            }
            axGrid.SetCellBorder(1, 4, axGrid.MaxCols, axGrid.MaxRows, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            axGrid.SetCellBorder(1, 4, axGrid.MaxCols, axGrid.MaxRows, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);

            
            axGrid.Col = 1;
            axGrid.ColMerge = FPUSpreadADO.MergeConstants.MergeAlways;
            

            /*
            grdView.Refresh();
            DataTable dtsource = null;
            dtsource = SEL_OS_PROD_MONTH("Q", arg_op);
          //  formatband();
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

            */
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
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
            iCount++;
            if (iCount >= 40)
            {
                BindingData(_sProcess);
                //if (_sProcess == "PUP")
                //    lblRubber_Click(null, null);
                //else
                //    lblEVA_Click(null, null);
                iCount = 0;
            }
        }


        private void FRM_SMT_PU_PROD_MONTH_VisibleChanged(object sender, EventArgs e)
        {

            if (this.Visible)
            {
                iCount = 39;
                tmr_Load.Start();
            }
            else
            {
                tmr_Load.Stop();
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

        private void lblRubber_Click(object sender, EventArgs e)
        {
            pnRubber.GradientEndColor = Color.White;//Color.FromArgb(255, 128, 128);
            pnEVA.GradientEndColor = Color.Gray;
            lblTitle.Text = "Pouring Production Status by Month";
            _sProcess = "PUP";            
            BindingData(_sProcess);
            bindingdatachart(_sProcess);
            iCount = 0;
        }

        private void lblEVA_Click(object sender, EventArgs e)
        {
            pnEVA.GradientEndColor = Color.White; //Color.FromArgb(255, 128, 128);
            pnRubber.GradientEndColor = Color.Gray;
            lblTitle.Text = "Spray Production Status by Month";
            _sProcess = "PUB";
            BindingData(_sProcess);
            bindingdatachart(_sProcess);
            iCount = 0;
        }

        private void cmdDay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fc = Application.OpenForms["FRM_SMT_PU_PROD_MATERIAL_DAILY"];
            if (fc != null)
                fc.Show();
            else
            {
                FRM_SMT_PU_PROD_MATERIAL_DAILY f = new FRM_SMT_PU_PROD_MATERIAL_DAILY();
                f.Show();
            }
        }

        private void cmdYear_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form fc = Application.OpenForms["FRM_SMT_PU_PROD_YEAR"];
            //if (fc != null)
            //    fc.Show();
            //else
            //{
            //    FRM_SMT_PU_PROD_YEAR f = new FRM_SMT_PU_PROD_YEAR();
            //    f.Show();
            //}
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            Smart_FTY.ComVar._frm_home.Show();
            this.Hide();
        }

        private void uc_month_ValueChangeEvent(object sender, EventArgs e)
        {
            BindingData(_sProcess);
        }
    }
}
