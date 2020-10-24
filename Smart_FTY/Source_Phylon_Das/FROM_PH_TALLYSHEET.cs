using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.OracleClient;
//using Com_Base;
using System.Data.SqlClient;
//using ChartDirector;
using System.Threading;

namespace Smart_FTY
{
     public partial class FROM_PH_TALLYSHEET : Form
    {
        public FROM_PH_TALLYSHEET()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        public string _SOPCD="",_SMCF = "", _SMCT;
        //string OP_CD, string MOLD, string MC_F, string MC_T
        public FROM_PH_TALLYSHEET(string title, string opcd, string mc_f, string mc_t)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _SOPCD = opcd;
            _SMCF = mc_f;
            _SMCT = mc_t;
        }
        int col;
        int row;
        Color lastColor;
       
        private DataTable dtcalwork = null;
        private DataTable sharedData = null;
        Color colorActive = Color.LightSeaGreen;
        Color colordActive = Color.White;
        bool Model = true;
        string strCOL = "";
        string strLine_CD;
        #region Init
        

        #endregion Init
        #region Function

        private void GoFullscreen()
        {
            //if (fullscreen)
            //{
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            //}
            //else
            //{
            //    this.WindowState = FormWindowState.Maximized;
            //    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            //}
        }

        private void create_default()
        {

        }

        private string GetShift(string arg_shift, string arg_date)
        {
            string str_shift, str_date;
            if (arg_date == DateTime.Now.ToString("yyyyMMdd")) str_date = " (Today)";
            else str_date = " (Yesterday)";
            if (arg_shift == "10") str_shift = "Shift 1";
            else if (arg_shift == "20") str_shift = "Shift 2";
            else str_shift = "Shift 3";
            return str_shift + str_date;
        }

        private string NVZ(string a)
        {
            if (a == "")
                a = "0";
            return a;
        }



        #endregion Fuction


        private void Set_Format_Grid()
        {
            gvwBase.BeginUpdate();
            for (int i = 0; i < gvwBase.Columns.Count; i++)
            {
                gvwBase.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                
                gvwBase.Columns[i].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gvwBase.Columns[i].AppearanceCell.Options.UseTextOptions = true;
                gvwBase.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;



                gvwBase.Columns[i].OptionsColumn.ReadOnly = true;
                gvwBase.Columns[i].OptionsColumn.AllowEdit = false;
                gvwBase.Columns[i].OptionsFilter.AllowFilter = false;
                gvwBase.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                //if (Model)
                //{
                //    gvwBase.Columns["MODEL_MOLD"].Width = 230;
                //}
                //else
                //{
                //    gvwBase.Columns["MODEL_MOLD"].Width = 200;
                //}
                if (i > 1)
                {
                    gvwBase.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    // gvwBase.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    // gvwBase.Columns[i].DisplayFormat.FormatString = "#,#";
                }
                else
                {
                    gvwBase.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                }
            }

            //gvwBase.BestFitColumns();
            gvwBase.OptionsView.ColumnAutoWidth = true;
            gvwBase.TopRowIndex = 0;
            gvwBase.RowHeight = 34;
            gvwBase.ColumnPanelRowHeight = 35;
            gvwBase.EndUpdate();
        }

        private void loadData(string line)
        {
            try
            {
                DataTable dt = new DataTable();
                //return;
                dt = SEL_DATA_TALLY_SHEET("Q",_SOPCD,"MODEL",_SMCF,_SMCT);
                if (dt.Rows.Count > 0)
                {

                    //
                    grdBase.DataSource = dt.Select().CopyToDataTable();
                    Set_Format_Grid();

                    strCOL = dt.Rows[0]["COL"].ToString();
                    band_Day1.Caption = dt.Rows[0]["D1"].ToString();
                    band_Day2.Caption = dt.Rows[0]["D2"].ToString();

                    ////line_cd = cbo_line.EditValue.ToString();
                    ////SetData(grdBase, dtf);
                    ////Set_Format_Grid();
                    //lbl_Total.Text = "Total: " + gvwBase.GetRowCellValue(gvwBase.RowCount - 1, "ACTUAL_PLAN").ToString().ToString();
                    //lbl_rate.Text = "Rate: " + gvwBase.GetRowCellValue(gvwBase.RowCount - 1, "RATE").ToString();
                    ////BAND_YMD.Caption = dtf.Rows[0]["D_1"].ToString();
                    ////BAND_YMD1.Caption = dtf.Rows[0]["D_3"].ToString();

                    //gridBand2_model_mold.Caption = "MOLD";
                    //if (Model)
                    //    gridBand2_model_mold.Caption = "MODEL";
                    //lbl_header.Text = "Outsole Tallysheet - Line " + dt.Rows[0][1].ToString().Substring(0, dt.Rows[0][1].ToString().IndexOf("-"));

                    //for (int i = 0; i < gvwBase.Columns.Count; i++)
                    //{
                    //    gvwBase.Columns[i].OwnerBand.Caption = dt.Rows[dt.Rows.Count - 1][gvwBase.Columns[i].FieldName].ToString();
                    //    gvwBase.Columns[i].OwnerBand.AppearanceHeader.BackColor = Color.FromArgb(255, 255, 255, 215);
                    //    gvwBase.Columns[i].OwnerBand.AppearanceHeader.Font = new Font(gvwBase.Columns[i].OwnerBand.AppearanceHeader.Font.FontFamily, 10, FontStyle.Bold);
                    //}

                   
                }
            }
            catch { }
        }
        private void Frm_Mold_WS_Change_By_Shift_Load(object sender, EventArgs e)
        {
            GoFullscreen();
            //timer1.Enabled = true;
            panel1.Visible = false;




            btnMold.BackColor = colordActive;
            btnModel.BackColor = colorActive;
            DataTable dt = new DataTable();
            string date1="";
            string LINE_CD="";
            string shift="";


            //strLine_CD = "LO101";
            //if(LINE_C !="")
            //    strLine_CD = LINE_C;
            
            date1 = DateTime.Now.ToString("yyyyMMdd");


            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 14)
                shift = "1";
            else if (DateTime.Now.Hour >= 14 && DateTime.Now.Hour < 22)
                shift = "2";
            else
            {
                shift = "3";
                date1 = DateTime.Now.AddDays(-1).ToString("yyyyMMdd");
            }




            loadData(strLine_CD);


           // dt = SEL_DATA_OS_PRO();
            panel1.Visible = true;
        }
        private DataTable SEL_DATA_TALLY_SHEET(string QTYPE, string OP_CD, string MOLD, string MC_F, string MC_T)
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();

            MyOraDB.ReDim_Parameter(6);
            MyOraDB.Process_Name = "MES.PKG_SMT_B1.SP_PH_TALLY_SHEET";
            //  for (int i = 0; i < intParm; i++)
            MyOraDB.Parameter_Type[0] = (char)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (char)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (char)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (char)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (char)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;


         
            MyOraDB.Parameter_Name[0] = "V_P_TYPE";
            MyOraDB.Parameter_Name[1] = "V_P_OP";
            MyOraDB.Parameter_Name[2] = "V_P_MOLD";
            MyOraDB.Parameter_Name[3] = "V_P_MC_F";
            MyOraDB.Parameter_Name[4] = "V_P_MC_T";
            MyOraDB.Parameter_Name[5] = "OUT_CURSOR";


            MyOraDB.Parameter_Values[0] = QTYPE;
            MyOraDB.Parameter_Values[1] = OP_CD;
            MyOraDB.Parameter_Values[2] = MOLD;
            MyOraDB.Parameter_Values[3] = MC_F;
            MyOraDB.Parameter_Values[4] = MC_T;
            MyOraDB.Parameter_Values[5] = "";

            MyOraDB.Add_Select_Parameter(true);
            retDS = MyOraDB.Exe_Select_Procedure();
            if (retDS == null) return null;
            return retDS.Tables[MyOraDB.Process_Name];
        }
        private void IniGridComponent(DataTable dt)
        {
           
        }
        
        private string GetText(AxFPUSpreadADO.AxfpSpread spread, int col, int row)
        {
            try
            {
                object data = null;
                spread.GetText(col, row, ref data);
                return data.ToString();
            }
            catch (Exception ex)
            {
                return "";
                //log.Error(ex);
            }

        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + "\n\r" + string.Format(DateTime.Now.ToString("HH:mm:ss"));
            }
            catch
            {
            }


        }


        private void Frm_Mold_WS_Change_By_Shift_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

            }
            catch { }
        }

        private void axfpsView_Advance(object sender, AxFPUSpreadADO._DSpreadEvents_AdvanceEvent e)
        {

        }

        private void axfpsView_ClickEvent(object sender, AxFPUSpreadADO._DSpreadEvents_ClickEvent e)
        {
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            loadData(strLine_CD);
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void gvwBase_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {

                if (e.RowHandle < 0)
                    return;
                if (gvwBase.GetRowCellValue(e.RowHandle, "MACHINE_CD").ToString().Contains("TOTAL"))
                {
                    e.Appearance.ForeColor = Color.Black;
                    e.Appearance.BackColor = Color.FromArgb(255, 255, 192);
                    e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 12, FontStyle.Bold);

                }
                else
                {
                    if (e.CellValue.ToString().Contains("GREEN"))
                    {
                        e.Appearance.ForeColor = Color.White;
                        e.Appearance.BackColor = Color.Green;
                    }
                    else if (e.CellValue.ToString().Contains("RED"))
                    {
                        e.Appearance.ForeColor = Color.White;
                        e.Appearance.BackColor = Color.Red;
                    }
                    else if (e.CellValue.ToString().Contains("GREY"))
                    {
                        e.Appearance.ForeColor = Color.White;
                        e.Appearance.BackColor = Color.Gray;
                    }
                    else if (e.CellValue.ToString().Contains("YELLOW"))
                    {
                        e.Appearance.ForeColor = Color.Black;
                        e.Appearance.BackColor = Color.Yellow;
                    }
                    else if (e.CellValue.ToString().Contains("TOTCOLOR"))
                    {
                        e.Appearance.ForeColor = Color.Black;
                        e.Appearance.BackColor = Color.FromArgb(255, 255, 192);
                        e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 12, FontStyle.Bold);
                    }
                }
                
                //if (e.Column.AbsoluteIndex > 10)
                //{
                //    if (e.CellValue.ToString().Contains("GREEN"))
                //    {
                //        e.Appearance.BackColor = Color.LimeGreen;
                //    }
                //    if (e.CellValue.ToString().Contains("RED"))
                //    {
                //        e.Appearance.BackColor = Color.Red;
                //    }
                //    if (e.CellValue.ToString().Contains("YELLOW"))
                //    {
                //        e.Appearance.BackColor = Color.Yellow;
                //    }
                //    if (e.CellValue.ToString().Contains("GRAY"))
                //    {
                //        e.Appearance.BackColor = Color.SlateGray;
                //    }
                //}                
            }
            catch (Exception ex)
            {
               
            }
        }

        private void btnMold_Click(object sender, EventArgs e)
        {
            if (Model)
            {
                btnMold.BackColor = colorActive;
                btnMold.ForeColor = Color.Black;
                btnModel.BackColor = colordActive;
                btnModel.ForeColor = Color.Silver;
                Model = false;
                bandMold.Visible = true;
                bandModel.Visible = false;
                loadData(strLine_CD);
            }
            

        }
        private void btnModel_Click(object sender, EventArgs e)
        {
            if (!Model)
            {
                btnModel.BackColor = colorActive;
                btnModel.ForeColor = Color.Black;
                btnMold.BackColor = colordActive;
                btnMold.ForeColor = Color.Silver;
                Model = true;
                bandMold.Visible = false;
                bandModel.Visible = true;
                loadData(strLine_CD);
            }

        }

        private void gvwBase_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                //return;
                Rectangle rect = e.Bounds;
                rect.Inflate(new Size(1, 1));

                Brush brush = new SolidBrush(e.Appearance.BackColor);
                e.Graphics.FillRectangle(brush, rect);
                Pen pen_horizental = new Pen(Color.Blue, 3F);
                Pen pen_vertical = new Pen(Color.Blue, 4F);

                if (e.Column.FieldName.Contains("COL"))
                {
                    if (e.Column.FieldName == strCOL)
                    {
                        // draw bottom
                        //e.Graphics.DrawLine(pen_horizental, rect.X, rect.Y + rect.Height - 1, rect.X + rect.Width, rect.Y + rect.Height - 1);
                        //// draw top
                        //e.Graphics.DrawLine(pen_horizental, rect.X, rect.Y, rect.X + rect.Width, rect.Y);

                        if (e.RowHandle == 0)
                        {
                            e.Graphics.DrawLine(pen_horizental, rect.X, rect.Y, rect.X + rect.Width, rect.Y);
                        }
                        else if (e.RowHandle == gvwBase.RowCount - 1)
                        {
                            e.Graphics.DrawLine(pen_horizental, rect.X, rect.Y + rect.Height - 1, rect.X + rect.Width, rect.Y + rect.Height - 1);
                        }
                        // draw right
                        e.Graphics.DrawLine(pen_vertical, rect.X + rect.Width, rect.Y, rect.X + rect.Width, rect.Y + rect.Height);


                        // draw left
                        e.Graphics.DrawLine(pen_horizental, rect.X, rect.Y, rect.X, rect.Y + rect.Height);


                    }

                    string[] ls = e.DisplayText.Split('\n');
                    //if (e.RowHandle < gvwBase.RowCount - 1)
                    //{
                    //    e.Graphics.DrawString(ls[0], new Font("Calibri", 12), new SolidBrush(Color.Black), rect, e.Appearance.GetStringFormat());
                    //}
                    //else
                    //{
                    //    e.Graphics.DrawString(ls[0], new Font("Calibri", 12), new SolidBrush(Color.Black), rect, e.Appearance.GetStringFormat());
                    //}

                    if (e.RowHandle < gvwBase.RowCount - 1)
                    {
                        if (e.Appearance.BackColor == Color.Red || e.Appearance.BackColor == Color.Green)
                        {
                            e.Graphics.DrawString(ls[0], new System.Drawing.Font("Calibri", 12, FontStyle.Regular), new SolidBrush(Color.White), rect, e.Appearance.GetStringFormat());
                        }
                        else
                        {
                            e.Graphics.DrawString(ls[0], new System.Drawing.Font("Calibri", 12, FontStyle.Regular), new SolidBrush(Color.Black), rect, e.Appearance.GetStringFormat());
                        }
                    }
                    else
                    {
                        e.Graphics.DrawString(ls[0], new System.Drawing.Font("Calibri", 12, FontStyle.Bold), new SolidBrush(Color.Black), rect, e.Appearance.GetStringFormat());
                    }

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnModel_MouseClick(object sender, MouseEventArgs e)
        {
            //if(e.Clicks >1)
            //    loadData(strLine_CD);
        }

        private void gvwBase_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column == null) return;
            if (e.Column.AppearanceHeader.BackColor != Color.Empty)
            {
                //e.Appearance.BackColor = Color.Red;
                e.Info.AllowColoring = true;
                //e.Appearance.BackColor = Color.Red;
            }
            if (e.Column.AppearanceHeader.ForeColor != Color.Empty)
            {
                //e.Appearance.BackColor = Color.Red;
                e.Info.AllowColoring = true;
                //e.Appearance.BackColor = Color.Red;
            }
        }
       
    }
}
