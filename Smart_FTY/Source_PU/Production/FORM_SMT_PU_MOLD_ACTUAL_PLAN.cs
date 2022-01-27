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
//using MaterialSetRate;
using System.Data.SqlClient;
//using ChartDirector;
using System.Threading;
using System.Diagnostics;

namespace Smart_FTY
{

    

    public partial class FORM_SMT_PU_MOLD_ACTUAL_PLAN : Form
    {
        public FORM_SMT_PU_MOLD_ACTUAL_PLAN()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }


        #region Init

        public int _time = 0;
        DataTable _dt_layout = null;
        int _count = 0;
        string _shift = "1";
        bool _isLoad = true;

        #endregion Init

        #region Function

        private void setDefaultGrid(AxFPSpreadADO.AxfpSpread arg_grid)
        {
            // Set Default Grid
            arg_grid.Visible = false;

            arg_grid.Reset();
            arg_grid.BorderStyle = FPSpreadADO.BorderStyleConstants.BorderStyleNone;
            arg_grid.DisplayColHeaders = false;
            arg_grid.DisplayRowHeaders = false;
            arg_grid.ActiveCellHighlightStyle = FPSpreadADO.ActiveCellHighlightStyleConstants.ActiveCellHighlightStyleOff;
            arg_grid.GrayAreaBackColor = Color.White;
            // arg_grid.ScrollBarExtMode = true;
            arg_grid.ColHeaderRows = 0;
            arg_grid.ScrollBars = FPSpreadADO.ScrollBarsConstants.ScrollBarsHorizontal;
            arg_grid.Font = new System.Drawing.Font("Calibri Bold", 11);
            arg_grid.set_RowHeight(1, 0.5);
            arg_grid.set_ColWidth(1, 0.5);
            arg_grid.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
            arg_grid.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
            arg_grid.TypeEditMultiLine = true;
            arg_grid.SetCellBorder(1, 1, 150, arg_grid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
            arg_grid.SetCellBorder(1, 1, 150, arg_grid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);

            for (int ic = 2; ic <= 150; ic++)
                arg_grid.set_ColWidth(ic, 4.2);
        }

        #region Binding Data Grid

        public void set_qty_actual(bool arg_status)
        {

            int iPlan = (int)_dt_layout.Compute("count(MOLD_SIZE_CD)", "");
            int iActual = (int)_dt_layout.Compute("count(USE_SIZE)", "");
            int iYellow = (int)_dt_layout.Compute("count(STATUS)", "STATUS = '1'");
 

            lbl_Plan.Text = "Total Plan: " + iPlan;
            lbl_Actual.Text = "Total Actual: " + iActual;

            if (_shift == "1")
            {
                lbl_dif1.Text = iPlan == 0 ? "" : ((float)iYellow / iPlan * 100.0).ToString("###,##0.#") + "%";
            }
            else if (_shift == "2")
            {
                lbl_dif2.Text = iPlan == 0 ? "" : ((float)iYellow / iPlan * 100.0).ToString("###,##0.#") + "%";
            }
            else
            {
                lbl_dif3.Text = iPlan == 0 ? "" : ((float)iYellow / iPlan * 100.0).ToString("###,##0.#") + "%";
            }

            if (!arg_status) return;

            if (_shift == "1")
            {
                DataTable dtShif2 = SEL_APS_PLAN_ACTUAL("2");
                SetTextDif(dtShif2, lbl_dif2);

                DataTable dtShif3 = SEL_APS_PLAN_ACTUAL("3");
                SetTextDif(dtShif3, lbl_dif3);

            }
            else if (_shift == "2")
            {
                DataTable dtShif1 = SEL_APS_PLAN_ACTUAL("1");
                SetTextDif(dtShif1, lbl_dif1);

                DataTable dtShif3 = SEL_APS_PLAN_ACTUAL("3");
                SetTextDif(dtShif3, lbl_dif3);
            }
            else
            {
                DataTable dtShif2 = SEL_APS_PLAN_ACTUAL("2");
                SetTextDif(dtShif2, lbl_dif2);

                DataTable dtShif1 = SEL_APS_PLAN_ACTUAL("3");
                SetTextDif(dtShif1, lbl_dif1);
            }
        }

        private void SetTextDif(DataTable dtShift, Label lbl_dif)
        {
            try
            {
                

                if (dtShift == null || dtShift.Rows.Count == 0)
                {
                    lbl_dif.Text = "";
                    return;
                }
                int iPlan = (int)dtShift.Compute("count(MOLD_SIZE_CD)", "");
                int iYellow = (int)dtShift.Compute("count(STATUS)", "STATUS = '1'");
                if (iPlan == 0)
                {
                    lbl_dif.Text = "";
                    return;
                }
                lbl_dif.Text = ((double)iYellow  / iPlan * 100.0).ToString("###,##0.#") + "%";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private int GetShift()
        {
            if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 14 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 22)
            {
                return 1;
            }
            else if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 6 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 14)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }


        private void DisplayGrid(DataTable arg_dt, AxFPSpreadADO.AxfpSpread arg_grid)
        {
           
            try
            {
                if (arg_dt == null || arg_dt.Rows.Count == 0) return;

                

                int row_s = 2;
                int irow = row_s;
                int icol = 3;
                _count = 0;
                arg_grid.MaxRows = row_s + 25;
                MachineHead(icol, irow, 0, arg_dt, arg_grid);
                irow = row_s + 2;
                MachineBody(icol, irow, 0, arg_dt, arg_grid);
                for (int i = 1; i < arg_dt.Rows.Count; i++)
                {
                    if (arg_dt.Rows[i]["MACHINE_NAME"].ToString() == arg_dt.Rows[i - 1]["MACHINE_NAME"].ToString())
                    {
                        if (arg_dt.Rows[i]["machine_row"].ToString() == "1")
                        {
                            irow = row_s + 2;
                            icol += 3;

                        }
                        else
                        {
                            irow++;
                        }

                        //if (arg_dt.Rows[i]["LINE"].ToString() == arg_dt.Rows[i - 1]["LINE"].ToString())
                        //{
                        //    irow++;
                        //}
                        //else
                        //{
                        //    irow = row_s + 2;
                        //    icol += 3;
                        //}
                        MachineBody(icol, irow, i, arg_dt, arg_grid);
                    }
                    else
                    {
                        arg_grid.set_ColWidth(icol + 3, 0.7);
                        icol += 5;
                        irow = row_s;
                        MachineHead(icol, irow, i, arg_dt, arg_grid);
                        irow = row_s + 2;
                        MachineBody(icol, irow, i, arg_dt, arg_grid);
                    }
                }
                arg_grid.MaxCols = icol + 3;
            }
            catch (Exception ex)
            { }
            finally
            {
               // WarehouseMaterialSystem.ClassLib.WinAPI.AnimateWindow(arg_grid.Handle, 200, WarehouseMaterialSystem.ClassLib.WinAPI.getSlidType("2"));
             //   arg_grid.Visible = true;
            }
            
        }

        private void MachineHead(int arg_icol, int arg_irow, int arg_idt, DataTable arg_dt, AxFPSpreadADO.AxfpSpread arg_grid)
        {
            try
            {
                int iRow = Convert.ToInt32(arg_dt.Rows[arg_idt]["LINE"]);
                arg_grid.Col = arg_icol;
                arg_grid.Row = arg_irow;
                arg_grid.Text = arg_dt.Rows[arg_idt]["MACHINE_NAME"].ToString();
                arg_grid.FontSize = 15;
                arg_grid.FontBold = true;

                arg_grid.BackColor = Color.DodgerBlue;
                arg_grid.ForeColor = Color.White;
                arg_grid.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
                arg_grid.AddCellSpan(arg_icol, arg_irow, iRow * 3, 1);

                //arg_grid.SetCellBorder(arg_icol, arg_irow, arg_icol, arg_irow, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexOutline, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                // arg_grid.SetCellBorder(icol, irow, icol + 3, irow + 1, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                //arg_grid.SetCellBorder(icol, irow, icol + 2, irow +1, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                //arg_grid.SetCellBorder(icol, irow, icol + 2, irow, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexTop, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);


                arg_irow++;
                arg_grid.Row = arg_irow;
                for (int i = 0; i < iRow; i++)
                {
                  //  if (arg_dt.Rows[arg_idt]["LINE_NAME"].ToString() == "E")
                   //     arg_grid.set_ColWidth(arg_icol + (i * 3), 6.0);

                    arg_grid.Col = arg_icol + (i * 3);
                    arg_grid.Text = "M/C";
                    arg_grid.BackColor = Color.LightSkyBlue;
                    //  arg_grid.ForeColor = Color.White;
                    arg_grid.FontSize = 9;
                    arg_grid.FontBold = true;

                    arg_grid.Col = arg_icol + (i * 3) + 1;
                    arg_grid.Text = "Plan";
                    arg_grid.BackColor = Color.Green;
                    arg_grid.ForeColor = Color.White;
                    arg_grid.FontSize = 9;
                    arg_grid.FontBold = true;

                    arg_grid.Col = arg_icol + (i * 3) + 2;
                    arg_grid.Text = "Act";
                    arg_grid.BackColor = Color.Orange;
                    arg_grid.ForeColor = Color.White;
                    arg_grid.FontSize = 9;
                    arg_grid.FontBold = true;
                }
                arg_grid.Col = -1;
                arg_grid.set_RowHeight(arg_irow, 20);

                //arg_grid.Col = arg_icol + 2;
                //arg_grid.Text = "R";
                //arg_grid.BackColor = Color.LightSkyBlue;
                ////  arg_grid.ForeColor = Color.White;
                //arg_grid.Font = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);


            }
            catch (Exception ex)
            { }

        }

        public void MachineBody(int arg_icol, int arg_irow, int arg_idt, DataTable arg_dt, AxFPSpreadADO.AxfpSpread arg_grid)
        {
            try
            {
                
                    arg_grid.SetCellBorder(arg_icol + 1, arg_irow, arg_icol + 2, arg_irow, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                    arg_grid.SetCellBorder(arg_icol , arg_irow, arg_icol + 3, arg_irow, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                    arg_grid.SetCellBorder(arg_icol , arg_irow, arg_icol + 2, arg_irow, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
              

                arg_grid.set_RowHeight(arg_irow, 20);

                arg_grid.Col = arg_icol;
                arg_grid.Row = arg_irow;
                arg_grid.Text = arg_dt.Rows[arg_idt]["STATION_CD"].ToString();
                arg_grid.FontSize = 11;
                arg_grid.FontBold = true;
                arg_grid.BackColor = Color.LightGreen;

                ///Plan
                arg_grid.Col = arg_icol + 1;
                arg_grid.Text = arg_dt.Rows[arg_idt]["MOLD_SIZE_CD"].ToString();
                if (arg_dt.Rows[arg_idt]["STATUS"].ToString() == "1")
                {
                    arg_grid.BackColor = Color.Yellow;
                    _count++;
                }
                else
                {
                    arg_grid.BackColor = Color.White;
                }

                ///Act
                arg_grid.Col = arg_icol + 2;
                arg_grid.Text = arg_dt.Rows[arg_idt]["USE_SIZE"].ToString();
                if (arg_dt.Rows[arg_idt]["STATUS"].ToString() == "1")
                {
                    arg_grid.BackColor = Color.Yellow;
                }
                else
                {
                    arg_grid.BackColor = Color.White;
                }
                

            }
            catch (Exception ex)
            { }

        }

        #endregion Binding Data Grid
        
        
        private void GoFullscreen()
        {
           
            //if (fullscreen)
            //{
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            //}
            //else
            //{
            //    this.WindowState = FormWindowState.Maximized;
            //    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            //}
        }

      

        public void loaddata( bool arg_status)
        {
            try
            {
                axGrid.Visible = false;
                _dt_layout = SEL_APS_PLAN_ACTUAL(_shift);
                DisplayGrid(_dt_layout, axGrid);
                set_qty_actual(arg_status);
            }
            catch 
            { }
            finally
            {
                
                this.axGrid.Show(); 
            }
        }
     


                

        #endregion Fuction

        #region DB
        public DataTable SEL_APS_PLAN_ACTUAL(string arg_shift)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

            try
            {
                string process_name = "PKG_SPB_MOLD_WMS_V2.SEL_MOLD_APS_ACTUAL_V2";

                MyOraDB.ReDim_Parameter(4);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_WH_CD";
                MyOraDB.Parameter_Name[1] = "ARG_DATE";
                MyOraDB.Parameter_Name[2] = "ARG_SHIFT";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "50";
                MyOraDB.Parameter_Values[1] = dtpDate.DateTime.ToString("yyyyMMdd");
                MyOraDB.Parameter_Values[2] = arg_shift;
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
        public DataTable SEL_TOTAL_PLAN_ACTUAL()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

           
                string process_name = "PKG_SPB_MOLD_WMS_V2.SEL_QTY_ACTUAL";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;


                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";
                MyOraDB.Parameter_Name[1] = "ARG_WH_CD";

                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;

                MyOraDB.Parameter_Values[0] = "";
                MyOraDB.Parameter_Values[1] = "50";

                MyOraDB.Add_Select_Parameter(true);

                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            
        }

    


        #endregion DB

        #region Event

        public void Frm_Mold_WS_Change_By_Shift_Load(object sender, EventArgs e)
        {
           // GoFullscreen();
            //timer2.Start();
            //lblDmc_Click(lblDmc, null);
            GoFullscreen();
            setDefaultGrid(axGrid);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                _time++;
                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + "\n\r" + string.Format(DateTime.Now.ToString("HH:mm:ss"));
                if (_time == 60)
                {
                    
                    loaddata(false);
                    _time = 0;
                }

                //if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 14 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 22)
                //    lbl_Shift1.Text = "SHIFT 2";
                //else if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 6 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 14)
                //    lbl_Shift1.Text = "SHIFT 1";
                //else
                //    lbl_Shift1.Text = "SHIFT 3";
            }
            catch
            {
            }
        }

        private void Frm_Mold_WS_Change_By_Shift_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    _isLoad = true;
                    lbl_dif1.Text = "";
                    lbl_dif2.Text = "";
                    lbl_dif3.Text = "";

                    dtpDate.EditValue = DateTime.Now;

                    if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 14 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 22)
                    {
                        lbl_Shift_Click(lbl_Shift2, null);
                    }
                    else if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 6 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 14)
                    {
                        lbl_Shift_Click(lbl_Shift1, null);
                    }
                    else
                    {
                        lbl_Shift_Click(lbl_Shift3, null);
                    }
                    loaddata(true);
                    _time = 0;                  
                    timer1.Start();          
                }
                else
                {
                    timer1.Stop();
                }
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                _isLoad = false;
            }
        }

        private void axGrid_BeforeEditMode(object sender, AxFPSpreadADO._DSpreadEvents_BeforeEditModeEvent e)
        {
            e.cancel = true;
        }

        
        #endregion Event

        private void cmdBack_Click(object sender, EventArgs e)
        {
            Smart_FTY.ComVar._frm_home.Show();
            this.Hide();
        }

        private void lbl_Shift_Click(object sender, EventArgs e)
        {
            Control cmd = (Control)sender;
            foreach (Control ctr in pnShift.Controls)
            {
                if (!ctr.Name.Contains("lbl_Shift")) continue;
                if (ctr.Name == cmd.Name)
                {
                    cmd.BackColor = Color.DodgerBlue;
                    cmd.ForeColor = Color.White;
                    _shift = cmd.Tag.ToString();
                    if (!_isLoad)
                    {
                        loaddata(false);
                    }
                    _time = 0;
                }
                else
                {
                    ctr.BackColor = Color.Gray;
                    ctr.ForeColor = Color.White;
                }
            }
        }

        private void dtpDate_EditValueChanged(object sender, EventArgs e)
        {
            if (_isLoad) return;

            loaddata(true);
            _time = 0;
        }


    }
}
