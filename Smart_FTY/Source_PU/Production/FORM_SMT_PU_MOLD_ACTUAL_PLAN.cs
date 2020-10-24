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
        public void set_qty_actual(DataTable arg_dt)
        {
            lbl_Plan.Text = "Total Plan: " + arg_dt.Rows[0]["PLAN"].ToString();
            lbl_Actual.Text = "Total Actual: " + arg_dt.Rows[0]["ACTUAL"].ToString();


            double d;
            int x = _count;
            int y = Convert.ToInt32(arg_dt.Rows[0]["PLAN"]);
            d = (float)x / y * 100.0;
            lbl_change.Text = "Difference Plan: " + d.ToString("###,###") + "%";




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
            catch
            { }
            finally
            {
               // WarehouseMaterialSystem.ClassLib.WinAPI.AnimateWindow(arg_grid.Handle, 200, WarehouseMaterialSystem.ClassLib.WinAPI.getSlidType("2"));
             //   arg_grid.Visible = true;
            }
            set_qty_actual(arg_dt = SEL_TOTAL_PLAN_ACTUAL());
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
            catch
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
            catch (Exception)
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
                if (_dt_layout == null) _dt_layout = SEL_APS_PLAN_ACTUAL();
                DisplayGrid(_dt_layout, axGrid);
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
        public DataTable SEL_APS_PLAN_ACTUAL()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

            try
            {
                string process_name = "PKG_SPB_MOLD_WMS_V2.SEL_MOLD_APS_ACTUAL";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;

 
                MyOraDB.Parameter_Name[0] = "ARG_WH_CD";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "50";
                MyOraDB.Parameter_Values[1] = "";

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
                    _dt_layout = SEL_APS_PLAN_ACTUAL();
                    loaddata(true);
                    _time = 0;
                }

                if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 14 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 22)
                    lbl_Shift.Text = "SHIFT 2";
                else if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 6 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 14)
                    lbl_Shift.Text = "SHIFT 1";
                else
                    lbl_Shift.Text = "SHIFT 3";
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
                    
                    _time = 59;                  
                    timer1.Start();          
                }
                else
                {
                    timer1.Stop();
                }
                
            }
            catch (Exception)
            {}
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


    }
}
