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
//using Smart_FTY.ClassLib;


namespace Smart_FTY
{

    

    public partial class FORM_MOLD_ACTUAL_PLAN : Form
    {
        public FORM_MOLD_ACTUAL_PLAN()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }


        #region Init

        string _status ;
        public int _Izone = 1;
       // string _lbl1, _lbl2, _lbl3;
        public int _time = 0;
        int _time_load = 20;
        int _time_auto = 0;
        DataTable _dt_layout_DMC = null;
        DataTable _dt_layout_DMP = null;
      //  string[] str_yellow;
        int _iColor = 0;
        bool _load_form = true;
        int _iCount = 0;
        bool _bLoad = true;
        //int _bf_clickRow=0, _bf_clickCol=0;
    

        
        //FORM_MOLD_PRODUCTION_POP _pop_change = new FORM_MOLD_PRODUCTION_POP();
        //FORM_MOLD_PRODUCTION_POP_PRE _pop_change_pre = new FORM_MOLD_PRODUCTION_POP_PRE();
      //  Thread th;
         
        List<string> _Loc_change_DMC = new List<string>();
        List<string> _Loc_plan_DMC = new List<string>();
        List<string> _Loc_change_DMP = new List<string>();
        List<string> _Loc_plan_DMP = new List<string>();

        ArrayList a = new ArrayList();

        #endregion Init

        #region Function

        
        
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

        private void create_default()
        {
            try
            {
                int iRowHeight, iFontSize;
                double iColWidth;

                if (_status == "DMC")
                {
                    iRowHeight = 27;
                    iColWidth = 6.5;
                    iFontSize = 14;
                }
                else
                {
                    iRowHeight = 32;
                    iColWidth = 9.8;
                    iFontSize = 15;
                }

                axGrid.Reset();
                axGrid.DisplayColHeaders = false;
                axGrid.DisplayRowHeaders = false;
                axGrid.ActiveCellHighlightStyle = FPSpreadADO.ActiveCellHighlightStyleConstants.ActiveCellHighlightStyleOff;
                axGrid.ColHeaderRows = 0;
                axGrid.ScrollBars = FPSpreadADO.ScrollBarsConstants.ScrollBarsNone;
                axGrid.Font = new System.Drawing.Font("Calibri", iFontSize);
                axGrid.BorderStyle = FPSpreadADO.BorderStyleConstants.BorderStyleNone;

                // axGrid.BorderStyle = FPSpreadADO.BorderStyleConstants.BorderStyleNone;
                axGrid.set_RowHeight(1, 0.5);
                //axGrid.set_RowHeight(20, 9);
                //axGrid.set_ColWidth((int)G.S1_Blank, 5.37);
                axGrid.set_ColWidth(1, 0.5);
                //axGrid.set_ColWidth((int)G.S3_Blank, 5.37);
                //axGrid.set_ColWidth((int)G.Blank1, 13.62);
                //axGrid.set_ColWidth((int)G.Blank2, 13.62);
                axGrid.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
                axGrid.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
                axGrid.SetCellBorder(1, 1, 150, axGrid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
                axGrid.SetCellBorder(1, 1, 150, axGrid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
                //  axGrid.SetCellBorder((int)G.S1_M1_L_Plan, 1, (int)G.S3_M2_R_Act, axGrid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexTop, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);


                //  axGrid.SetCellBorder((int)G.S1_M1_L_Tar, 1, (int)G.S3_M2_R_Cur, axGrid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexOutline, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
                

                for (int irow = 2; irow <= 50; irow++)
                    axGrid.set_RowHeight(irow, iRowHeight);

                for (int icol = 2; icol <= 150; icol++)
                    axGrid.set_ColWidth(icol, iColWidth);
            }
            catch (Exception)
            {}            
        }

        #region DMC

        private void MachineCenterText(int arg_col, int arg_row, int arg_idt, DataTable arg_dt, AxFPSpreadADO.AxfpSpread arg_grid)
        {
            int iColPlus = Convert.ToInt32(arg_dt.Rows[arg_idt]["col_cen"]);
            int iRowPlus = Convert.ToInt32(arg_dt.Rows[arg_idt]["row_cen"]);
            //arg_grid.AddCellSpan(arg_col + (iColPlus - 1), arg_row + (iRowPlus - 1), iColPlus, iRowPlus);
            arg_grid.AddCellSpan(arg_col + 1, arg_row - (iRowPlus -1), iColPlus, iRowPlus);
            arg_grid.Col = arg_col + 1;
            arg_grid.Row = arg_row - (iRowPlus - 1);
            arg_grid.TypeEditMultiLine = true;
            arg_grid.FontBold = true;
            arg_grid.FontSize = 18f;
            arg_grid.BackColor = Color.FromArgb(242, 226, 213);
            
            arg_grid.SetText(arg_col + 1, arg_row - (iRowPlus -1),
                             arg_dt.Rows[arg_idt]["text_cen"].ToString().Replace("-","\n"));


            //int c = Convert.ToInt32(arg_dt.Rows[arg_idt]["line"].ToString());

            //for (int i = 1; i <= c; i++)
            //{

            //    arg_grid.Row = arg_row;
            //    arg_grid.Col = arg_col + i;
            //    arg_grid.BackColor = Color.FromArgb(244, 140, 65);
            //}
                
            //arg_grid.SetCellBorder(arg_col + 1, arg_row, arg_col + c, arg_row
            //                          , FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0x418cf4
            //                          , FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            //arg_grid.SetCellBorder(arg_col + 1, arg_row, arg_col + c, arg_row
            //                      , FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0x418cf4
            //                      , FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
           
        }

        //private void MachineCenterBG(int arg_col, int arg_row, int arg_idt, DataTable arg_dt, AxFPSpreadADO.AxfpSpread arg_grid)
        //{
        //    int c = Convert.ToInt32(arg_dt.Rows[arg_idt]["line"].ToString());

        //    for (int i = 1; i <= c; i++)
        //    {

        //        arg_grid.Row = arg_row;
        //        arg_grid.Col = arg_col + i;
        //        arg_grid.BackColor = Color.FromArgb(242, 226, 213);
        //    }

        //    arg_grid.SetCellBorder(arg_col + 1, arg_row, arg_col + c, arg_row
        //                              , FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0xd5e2f2
        //                              , FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
        //    arg_grid.SetCellBorder(arg_col + 1, arg_row, arg_col + c, arg_row
        //                          , FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0xd5e2f2
        //                          , FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);

        //}


        private void MachineHeadDMC(int arg_col, int arg_row, int arg_idt, DataTable arg_dt, AxFPSpreadADO.AxfpSpread arg_grid)
        {
            try
            {
                //axGrid.AddCellSpan(icol, irow
                //                    , Convert.ToInt32(_dt_layout.Rows[idt]["line"].ToString()) * 2
                //                    , 1);
                arg_grid.Col = arg_col;
                arg_grid.Row = arg_row;
                arg_grid.set_RowHeight(arg_row, 30);
                arg_grid.Text = arg_dt.Rows[arg_idt]["MACHINE_NAME"].ToString();
                arg_grid.Font = new System.Drawing.Font("Calibri", 20, FontStyle.Bold);
                arg_grid.BackColor = Color.DodgerBlue;
                arg_grid.ForeColor = Color.White;
                arg_grid.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;

                arg_grid.AddCellSpan(arg_col, arg_row
                                    , Convert.ToInt32(arg_dt.Rows[arg_idt]["line"].ToString())
                                    , 1);
            }
            catch
            {
            }
        }

        public void MachineBodyDMC(int arg_col, int arg_row, int arg_idt, DataTable arg_dt, AxFPSpreadADO.AxfpSpread arg_grid)
        {
            try
            {

                arg_grid.SetCellBorder(arg_col, arg_row, arg_col, arg_row, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                arg_grid.SetCellBorder(arg_col + 1, arg_row, arg_col + 1, arg_row, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                arg_grid.SetCellBorder(arg_col, arg_row, arg_col, arg_row, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                arg_grid.SetCellBorder(arg_col, arg_row, arg_col, arg_row, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexTop, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);

                arg_grid.Row = arg_row;
                arg_grid.Col = arg_col;
                arg_grid.Text = _dt_layout_DMC.Rows[arg_idt]["size_plan"].ToString();
                arg_grid.BackColor = Color.FromName(arg_dt.Rows[arg_idt]["color_B_value"].ToString());
                arg_grid.ForeColor = Color.FromName(arg_dt.Rows[arg_idt]["color_F_value"].ToString());


                //if (arg_dt.Rows[arg_idt]["Status"].ToString() == "1")
                //    _Loc_plan_DMC.Add(arg_col + " " + arg_row + " " + arg_dt.Rows[arg_idt]["machine_id"].ToString());
                //if (arg_dt.Rows[arg_idt]["Status"].ToString() == "2")
                //    _Loc_change_DMC.Add(arg_col  + " " + arg_row + " " + arg_dt.Rows[arg_idt]["machine_id"].ToString());

                //if (arg_dt.Rows[arg_idt]["direction"].ToString() == "1")
                //{
                //    arg_col++;
                //}
                //else if (arg_dt.Rows[arg_idt]["direction"].ToString() == "2")
                //{
                //    arg_row++;
                //}
                //else if (arg_dt.Rows[arg_idt]["direction"].ToString() == "3")
                //{
                //    arg_col--;
                //}
                //else if (arg_dt.Rows[arg_idt]["direction"].ToString() == "4")
                //{
                //    arg_row--;
                //}

                //arg_grid.Row = arg_row;
                //arg_grid.Col = arg_col;

                //switch (_dt_layout_DMC.Rows[arg_idt]["STATION_CD"].ToString())
                //{
                //    case "05":
                //    case "09":
                //    case "13":
                //    case "16":
                //        arg_grid.Text += "/" + _dt_layout_DMC.Rows[arg_idt]["STATION_CD"].ToString();
                //        break;
                //    default:
                //        arg_grid.Text = _dt_layout_DMC.Rows[arg_idt]["STATION_CD"].ToString();
                //        break;
                //}
            }
            catch (Exception)
            {}
            
        }

        private void DisplayGridDMC(DataTable arg_dt, AxFPSpreadADO.AxfpSpread arg_grid)
        {
           try
            {
                if (arg_dt == null || arg_dt.Rows.Count == 0) return;
                axGrid.ClearRange(0, 0, 50, 50, true);
                create_default();
                _Loc_change_DMC.Clear();
                int row_s2 = 15;
                int row_s1 = 7;
                int row_s3 = 23;
                int col_s3 = 6;
                int irow = row_s2;
                int icol = 2;

                MachineBodyDMC(icol, irow, 0, arg_dt, arg_grid);
                MachineCenterText(icol, irow, 0, arg_dt, arg_grid);
                //MachineCenterBG(icol, irow, 0, arg_dt, arg_grid);
                lbl_plan.Text = arg_dt.Rows[0]["TOT_PLAN"].ToString();
                lbl_actual.Text = arg_dt.Rows[0]["TOT_ACT"].ToString();
                for (int i = 1; i < arg_dt.Rows.Count; i++)
                {

                    if (arg_dt.Rows[i]["machine_cd"].ToString() == arg_dt.Rows[i - 1]["machine_cd"].ToString())
                    {
                        if (arg_dt.Rows[i]["direction"].ToString() == arg_dt.Rows[i - 1]["direction"].ToString())
                        {
                            if (arg_dt.Rows[i]["direction"].ToString() == "1")
                            {
                                irow--;
                             //   MachineCenterBG(icol, irow, i, arg_dt, arg_grid); 
                            }
                            else if (arg_dt.Rows[i]["direction"].ToString() == "2") icol++;
                            else if (arg_dt.Rows[i]["direction"].ToString() == "3") irow++;
                            else icol--;
                            MachineBodyDMC(icol, irow, i, arg_dt, arg_grid);
                                                     
                        }
                        else
                        {
                            if (arg_dt.Rows[i]["direction"].ToString() == "2")
                            {
                                irow--;
                                icol++;
                                MachineHeadDMC(icol, irow - 1, i, arg_dt, arg_grid);
                            }
                            else if (arg_dt.Rows[i]["direction"].ToString() == "3")
                            {
                                icol++;
                                irow++;
                            }
                            else if (arg_dt.Rows[i]["direction"].ToString() == "4")
                            {
                                irow++;
                                icol--;
                            }
                            MachineBodyDMC(icol, irow, i, arg_dt, arg_grid);
                        }
                    }
                    else
                    {
                        if (arg_dt.Rows[i]["line_id"].ToString() == "2")
                        {
                            irow = row_s2;
                            icol = icol + 6;
                          //  axGrid.SetText(icol, irow, "2");
                        }
                        else if (arg_dt.Rows[i]["line_id"].ToString() == "1")
                        {
                            irow = row_s1;
                            icol--;
                            //   axGrid.SetText(icol, irow,"1");
                        }
                        else 
                        {
                            irow = row_s3;
                            col_s3 += 8;
                            icol= col_s3 ;
                        }
                        MachineBodyDMC(icol, irow, i, arg_dt, arg_grid);
                        MachineCenterText(icol, irow, i, arg_dt, arg_grid);
                      //  MachineCenterBG(icol, irow, i, arg_dt, arg_grid); 
                    }
                }

               // if (_Loc_change.Count > 0) tmr_blind.Start();
               // else tmr_blind.Stop();
            }
           catch
           {}
        }


        #endregion DMC


        #region DMP
        private void DisplayGridDMP(DataTable arg_dt, AxFPSpreadADO.AxfpSpread arg_grid)
        {
            try
            {
                if (arg_dt == null || arg_dt.Rows.Count == 0) return;
                // axGrid.ClearRange(0, 0, 50, 50, true);
                create_default();
                _Loc_plan_DMP.Clear();
                //_row1 = Convert.ToInt32(arg_dt.Rows[0]["Row1"]);
                //_row2 = Convert.ToInt32(arg_dt.Rows[0]["Row2"]);
                //_row3 = Convert.ToInt32(arg_dt.Rows[0]["Row3"]);
                int row_s = 3;
                int irow = row_s;
                int icol = 2;
                lbl_plan.Text = arg_dt.Rows[0]["TOT_PLAN"].ToString();
                lbl_actual.Text = arg_dt.Rows[0]["TOT_ACT"].ToString();

                arg_grid.set_ColWidth(icol, 5);
                MachineHeadDMP(icol, irow, 0, arg_dt, arg_grid);
                irow += 2;               
                MachineBodyDMP(icol, irow, 0, arg_dt, arg_grid);
                irow++;

                for (int i = 1; i < arg_dt.Rows.Count; i++)
                {
                    if (arg_dt.Rows[i]["MACHINE_NAME"].ToString() == arg_dt.Rows[i - 1]["MACHINE_NAME"].ToString())
                    {
                        MachineBodyDMP(icol, irow, i, arg_dt, arg_grid);
                        irow++;
                    }
                    else
                    {

                        icol += 4;
                        arg_grid.set_ColWidth(icol, 5);
                        irow = row_s;
                        MachineHeadDMP(icol, irow, i, arg_dt, arg_grid);
                        irow += 2;
                        MachineBodyDMP(icol, irow, i, arg_dt, arg_grid);
                        irow++; 
                    }
                }
               // if (_Loc_yellow.Count > 0) tmr_blind.Start();
               // else tmr_blind.Stop();
            }
            catch
            {
            }
        }

        private void MachineHeadDMP(int arg_icol, int arg_irow, int arg_idt, DataTable arg_dt, AxFPSpreadADO.AxfpSpread arg_grid)
        {
            try
            {
                arg_grid.Col = arg_icol;
                arg_grid.Row = arg_irow;
                arg_grid.Text = arg_dt.Rows[arg_idt]["MACHINE_NAME"].ToString();
                arg_grid.Font = new System.Drawing.Font("Calibri", 20, FontStyle.Bold);
                arg_grid.BackColor = Color.DodgerBlue;
                arg_grid.ForeColor = Color.White;
                arg_grid.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
                arg_grid.AddCellSpan(arg_icol, arg_irow, 3, 1);

                //arg_grid.SetCellBorder(icol, irow, icol + 2, irow + 1, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexOutline, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                // arg_grid.SetCellBorder(icol, irow, icol + 3, irow + 1, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                //arg_grid.SetCellBorder(icol, irow, icol + 2, irow +1, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                //arg_grid.SetCellBorder(icol, irow, icol + 2, irow, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexTop, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);


                arg_irow++;
                arg_grid.Row = arg_irow;
                arg_grid.Col = arg_icol;
                arg_grid.Text = "STA";
                arg_grid.BackColor = Color.LightSkyBlue;
                //  arg_grid.ForeColor = Color.White;
                arg_grid.Font = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);

                arg_grid.Col = arg_icol + 1;
                arg_grid.Text = "L";
                arg_grid.BackColor = Color.LightSkyBlue;
                //  arg_grid.ForeColor = Color.White;
                arg_grid.Font = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);

                arg_grid.Col = arg_icol + 2;
                arg_grid.Text = "R";
                arg_grid.BackColor = Color.LightSkyBlue;
                //  arg_grid.ForeColor = Color.White;
                arg_grid.Font = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);


            }
            catch
            {}
        }

        public void MachineBodyDMP(int arg_icol, int arg_irow, int arg_idt, DataTable arg_dt, AxFPSpreadADO.AxfpSpread arg_grid)
        {
            try
            {
                arg_grid.SetCellBorder(arg_icol, arg_irow, arg_icol + 2, arg_irow, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                arg_grid.SetCellBorder(arg_icol, arg_irow, arg_icol + 3, arg_irow, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                arg_grid.SetCellBorder(arg_icol, arg_irow, arg_icol + 2, arg_irow, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);

                arg_grid.set_RowHeight(arg_irow, 45);


                arg_grid.Col = arg_icol;
                arg_grid.Row = arg_irow;
                arg_grid.Text = arg_dt.Rows[arg_idt]["STA"].ToString();

                arg_grid.Col = arg_icol + 1;
                arg_grid.Text =  arg_dt.Rows[arg_idt]["PLAN_L"].ToString();
                arg_grid.BackColor = Color.FromName(arg_dt.Rows[arg_idt]["L_color_B_value"].ToString());
                arg_grid.ForeColor = Color.FromName(arg_dt.Rows[arg_idt]["L_color_F_value"].ToString());

                arg_grid.Col = arg_icol + 2;
                arg_grid.Text = arg_dt.Rows[arg_idt]["PLAN_R"].ToString();
                arg_grid.BackColor = Color.FromName(arg_dt.Rows[arg_idt]["R_color_B_value"].ToString());
                arg_grid.ForeColor = Color.FromName(arg_dt.Rows[arg_idt]["R_color_F_value"].ToString());

                
                if (arg_dt.Rows[arg_idt]["L_Status"].ToString() == "1")
                    _Loc_plan_DMP.Add((arg_icol + 1) + " " + arg_irow + " " + arg_dt.Rows[arg_idt]["machine_cd"].ToString());
                if (arg_dt.Rows[arg_idt]["R_Status"].ToString() == "1")
                    _Loc_plan_DMP.Add((arg_icol + 2) + " " + arg_irow + " " + arg_dt.Rows[arg_idt]["machine_cd"].ToString());

                if (arg_dt.Rows[arg_idt]["L_Status"].ToString() == "2")
                    _Loc_change_DMP.Add((arg_icol + 1) + " " + arg_irow + " " + arg_dt.Rows[arg_idt]["machine_cd"].ToString());
                if (arg_dt.Rows[arg_idt]["R_Status"].ToString() == "2")
                    _Loc_change_DMP.Add((arg_icol + 2) + " " + arg_irow + " " + arg_dt.Rows[arg_idt]["machine_cd"].ToString());

            }
            catch (Exception)
            {}

        }

       


        #endregion DMP

        private void blind( List<string> arg_list)
        {
            try
            {
                if (arg_list.Count <= 0) return;
                string[] str;

                for (int i = _iColor; i < arg_list.Count; i += 3)
                {
                    str = arg_list[i].Split(' ');
                    axGrid.Col = Convert.ToInt32(str[0].ToString());
                    axGrid.Row = Convert.ToInt32(str[1].ToString());
                    if (axGrid.BackColor == Color.Yellow)
                    {
                        if (axGrid.Text == "")
                        {
                            axGrid.BackColor = Color.Gray;
                        }
                        else
                        {
                            axGrid.BackColor = Color.Green;
                        }

                        axGrid.ForeColor = Color.White;
                    }
                    else
                    {
                        axGrid.BackColor = Color.Yellow;
                        axGrid.ForeColor = Color.Black;
                    }
                }
                if (_iColor == 3) _iColor = 0;
                else _iColor++;
            }
            catch (Exception)
            {}          
        }

        public void loaddata( bool arg_status)
        {
            try
            {
                
               // if (arg_status)
                  //  this.axGrid.Hide();
                DataTable dt = null;
                if (_status == "DMC")
                {
                    dt = SEL_APS_PLAN_ACTUAL("90_1");
                    if (dt != null && dt.Rows.Count > 0)
                        _dt_layout_DMC = dt;

                    this.axGrid.Hide();
                    DisplayGridDMC(_dt_layout_DMC, axGrid);
                }
                else
                {
                    dt = SEL_APS_PLAN_ACTUAL("90");
                    if (dt != null && dt.Rows.Count > 0)
                        _dt_layout_DMP = dt;

                    this.axGrid.Hide();
                    DisplayGridDMP(_dt_layout_DMP, axGrid);
                }
                

                //autoClick();
               // if (arg_status)
               // {
                   // WarehouseMaterialSystem.ClassLib.WinAPI.AnimateWindow(this.axGrid.Handle, 400, WarehouseMaterialSystem.ClassLib.WinAPI.getSlidType("2"));
                    this.axGrid.Show();
                //}
            }
            catch (Exception)
            {}
        }

        private void autoClick(List<string> arg_list)
        {
            try
            {
                if (arg_list.Count > 0)
                {
                    string str = arg_list.ElementAt(_iCount);
                    string[] st = str.Split(' ');
                    AxFPSpreadADO._DSpreadEvents_ClickEvent ev = new AxFPSpreadADO._DSpreadEvents_ClickEvent(Convert.ToInt32(st[0]), Convert.ToInt32(st[1]));
                    axGrid_ClickEvent(axGrid, ev);
                    if (_iCount == arg_list.Count - 1) _iCount = 0;
                    else _iCount++;
                }
            }
            catch (Exception)
            {}
        }
                

        #endregion Fuction

        #region DB
        public DataTable SEL_APS_PLAN_ACTUAL(string arg_wh)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

            try
            {
                string process_name = "PKG_DMC.SEL_MOLD_PRODUCTION_LAYOUT";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;

 
                MyOraDB.Parameter_Name[0] = "ARG_WH_CD";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_wh;
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

    


        #endregion DB

        #region Event

        public void Frm_Mold_WS_Change_By_Shift_Load(object sender, EventArgs e)
        {
            GoFullscreen();
            timer2.Start();
            //lblDmc_Click(lblDmc, null);
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


       

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + "\n\r" + string.Format(DateTime.Now.ToString("HH:mm:ss"));
                //blind();
                _time++;
                _time_auto++;
               // if (_time_auto == 10) _pop_change.Hide();
                //if (_time_auto >= 40)
                //{
                //    if (_status == "DMC") autoClick(_Loc_change_DMC);
                //    else autoClick(_Loc_change_DMP);
                //    _time_auto = 0;
                //}
                 


                if (_time >= _time_load)
                {
                    loaddata(true);
                    
                    _time = 0;
                }

                if (_bLoad && _time == 1)
                {
                    lblDmc_Click(lblDmc, null);
                    _load_form = false;
                }

                //if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 14 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 22)
                //    lblShift.Text = "SHIFT 2";
                //else if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 6 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 14)
                //    lblShift.Text = "SHIFT 1";
                //else
                //    lblShift.Text = "SHIFT 3";
            }
            catch
            {
            }
        }


        private void tmr_blind_Tick(object sender, EventArgs e)
        {
            if (_status=="DMC") blind(_Loc_change_DMC);
            else blind(_Loc_change_DMP);
        }



        private void Frm_Mold_WS_Change_By_Shift_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            this.Dispose();
            base.Dispose(true);
        }


        private void Frm_Mold_WS_Change_By_Shift_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    //_time_auto = 10;
                    //if (_load_form)
                    //{
                        timer1.Start();

                        
                        //lblDmp_Click(lblDmc, null);
                        _load_form = false;
                    //}                 
                }
                else
                {
                    _load_form = true;
                 //   timer1.Stop();
                }
                
            }
            catch (Exception)
            {}
        }


        private void axGrid_BeforeEditMode(object sender, AxFPSpreadADO._DSpreadEvents_BeforeEditModeEvent e)
        {
            e.cancel = true;
        }
        
        private void axGrid_ClickEvent(object sender, AxFPSpreadADO._DSpreadEvents_ClickEvent e)
        {
            try
            {
                string str ;
                string str1 ;
                string[] st;
                string[] st1;

                //if (_status == "DMC")
                //{
                //    str = _Loc_change_DMC.Find(x => x.StartsWith(e.col + " " + e.row));
                //    str1 = _Loc_plan_DMC.Find(x => x.StartsWith(e.col + " " + e.row));
                //    _pop_change_pre._wh = "90_1";
                //}
                //else
                //{
                //    str = _Loc_change_DMP.Find(x => x.StartsWith(e.col + " " + e.row));
                //    str1 = _Loc_plan_DMP.Find(x => x.StartsWith(e.col + " " + e.row));
                //    _pop_change_pre._wh = "90";
                //}

                //if (str != null)
                //{
                //    st = str.Split(' ');
                //    _pop_change._machine = st[2];
                //    _pop_change.Hide();
                //    _pop_change.Show();

                //}
                //else if (str1 != null)
                //{
                   

                //}
                //else
                //{
                //    _pop_change.Hide();
                //    _pop_change_pre.Hide();
                //}
            }
            catch (Exception)
            {}          
        }
        #endregion Event

        private void lblDmp_Click(object sender, EventArgs e)
        {
            try 
	        {
                _iCount = 0;
		        lblDmp.BackColor = Color.Gray;
                lblDmp.ForeColor = Color.White;
                lblDmc.BackColor = Color.White;
                lblDmc.ForeColor = Color.Black;
                _status = "DMP";
                loaddata(true);
                
	        }
	        catch (Exception)
	        {}
            
        }

        private void lblDmc_Click(object sender, EventArgs e)
        {
            try
            {
                _iCount = 0;
                lblDmc.BackColor = Color.Gray;
                lblDmc.ForeColor = Color.White;
                lblDmp.BackColor = Color.White;
                lblDmp.ForeColor = Color.Black;
                _status = "DMC";
                loaddata(true);
                

            }
            catch (Exception)
            {}
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 14) lbl_Shift.Text = "Shift 1";
            else if (DateTime.Now.Hour >= 14 && DateTime.Now.Hour < 22) lbl_Shift.Text = "Shift 2";
            else lbl_Shift.Text = "Shift 3";
        }

        private void lbl_plan_Click(object sender, EventArgs e)
        {
            lblDmc_Click(lblDmc, null);
        }

        private void lbl_actual_Click(object sender, EventArgs e)
        {
            lblDmp_Click(lblDmc, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }




    }
}
