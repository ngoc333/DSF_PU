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
//using WarehouseMaterialSystem.ClassLib;


namespace Smart_FTY
{

    

    public partial class FORM_SMT_PU_MOLD_PRODUCTION : Form
    {
        public FORM_SMT_PU_MOLD_PRODUCTION()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }


        #region Init
        public int _time = 0;
        int _iCount = 0, _iColor =0;
        int _countP = 0, _countN = 0, _countR = 0, _countNU = 0;
        DataTable _dt_layout = null;
       // FORM_MOLD_PRODUCTION_POP_NEXT _pop_change = new FORM_MOLD_PRODUCTION_POP_NEXT();
       // FORM_MOLD_PRODUCTION_POP _pop_alarm = new FORM_MOLD_PRODUCTION_POP();
        Dictionary<string, string> _dicChange = new Dictionary<string, string>();
        Dictionary<string, string> _dicAlarm = new Dictionary<string, string>();
        List<string> _Loc_change = new List<string>();
        List<string> _Loc_plan = new List<string>();
       // List<string> _listAlarm = new List<string>();

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


        private void setDefaultGrid(AxFPSpreadADO.AxfpSpread arg_grid)
        {
            // Set Default Grid
            arg_grid.Visible = false;

            arg_grid.Reset();
            arg_grid.BorderStyle = FPSpreadADO.BorderStyleConstants.BorderStyleNone;
            arg_grid.DisplayColHeaders = false;
            arg_grid.DisplayRowHeaders = false;
            arg_grid.ActiveCellHighlightStyle = FPSpreadADO.ActiveCellHighlightStyleConstants.ActiveCellHighlightStyleOff;
            arg_grid.ColHeaderRows = 0;
            arg_grid.ScrollBars = FPSpreadADO.ScrollBarsConstants.ScrollBarsNone;
            arg_grid.Font = new System.Drawing.Font("Calibri Bold", 11);
            arg_grid.set_RowHeight(1, 0.5);
            arg_grid.set_ColWidth(1, 0.5);
            arg_grid.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
            arg_grid.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
            arg_grid.TypeEditMultiLine = true;
            arg_grid.SetCellBorder(1, 1, 150, arg_grid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
            arg_grid.SetCellBorder(1, 1, 150, arg_grid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
            for (int ic = 2; ic <= 150; ic++)
                arg_grid.set_ColWidth(ic, 4.0);
        }       

        #region Binding Data Grid

        private void set_qty()
        {
            lblPlan.Text = "Plan: " + _countP + " set";
            lblNoPlan.Text = "No Plan: " + _countN  + " set";
            lblMoldChange.Text = "Mold Change: " + _countR + " set";
            lblNoUse.Text = "No Use: " + _countNU + " set";
        }
        private void DisplayGrid(DataTable arg_dt, AxFPSpreadADO.AxfpSpread arg_grid)
        {
            try
            {
                _countP = 0;
                _countN = 0;
                _countR = 0;
                _countNU = 0;
                arg_grid.Visible = false;
                if (arg_dt == null || arg_dt.Rows.Count == 0) return;
                // axGrid.ClearRange(0, 0, 50, 50, true);
                create_default();
                _Loc_change.Clear();
                int row_s = 2;
                int irow = row_s;
                int icol = 2;

                //MachineHead(icol, irow, 0);
                //irow+=2;
                MachineHead(icol, irow - 1, 0);
                MachineBody(icol, irow, 0);
                //irow++;

                for (int i = 1; i < arg_dt.Rows.Count; i++)
                {
                    if (arg_dt.Rows[i]["machine_cd"].ToString() == arg_dt.Rows[i - 1]["machine_cd"].ToString())
                    {
                        if (arg_dt.Rows[i]["machine_row"].ToString() == "1")
                        {
                            icol += 2;
                            irow = row_s;
                            MachineBody(icol, irow, i);
                        }
                        else
                        {
                            irow++;
                            MachineBody(icol, irow, i);
                        }
                    }
                    else
                    {
                        axGrid.set_ColWidth(icol + 2, 7);
                        icol += 3;
                        irow = row_s;
                        MachineHead(icol, irow - 1, i);
                        MachineBody(icol, irow, i);
                    }
                }
                if (_Loc_change.Count > 0) tmr_blind.Start();
                else tmr_blind.Stop();
                set_qty();
            }
            catch
            { }
            finally
            {
              //  arg_grid.Visible = false;
                //Smart_FTY.ClassLib.WinAPI.AnimateWindow(arg_grid.Handle, 400, Smart_FTY.ClassLib.WinAPI.getSlidType("2"));
                arg_grid.Visible = true;
            }
        }

        private void create_default()
        {
            try
            {
                axGrid.Reset();
                axGrid.DisplayColHeaders = false;
                axGrid.DisplayRowHeaders = false;
                axGrid.ActiveCellHighlightStyle = FPSpreadADO.ActiveCellHighlightStyleConstants.ActiveCellHighlightStyleOff;
                axGrid.ColHeaderRows = 0;
                axGrid.ScrollBars = FPSpreadADO.ScrollBarsConstants.ScrollBarsNone;
                axGrid.Font = new System.Drawing.Font("Calibri", 12);
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
                {
                    axGrid.set_RowHeight(irow, 18);

                }

                for (int icol = 2; icol <= 150; icol++)
                {
                    axGrid.set_ColWidth(icol, 4.3);

                }
            }
            catch (Exception)
            { }
        }

        private void MachineHead(int icol, int irow, int idt)
        {
            try
            {
                //axGrid.AddCellSpan(icol, irow
                //                    , Convert.ToInt32(_dt_layout.Rows[idt]["line"].ToString()) * 2
                //                    , 1);
                axGrid.Col = icol;
                axGrid.Row = irow;
                axGrid.set_RowHeight(irow, 30);
                axGrid.Text = _dt_layout.Rows[idt]["MACHINE_NAME"].ToString();
                axGrid.Font = new System.Drawing.Font("Calibri", 20, FontStyle.Bold);
                axGrid.BackColor = Color.DodgerBlue;
                axGrid.ForeColor = Color.White;
                axGrid.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;

                axGrid.AddCellSpan(icol, irow
                                    , Convert.ToInt32(_dt_layout.Rows[idt]["line"].ToString()) * 2
                                    , 1);
            }
            catch
            {
            }
        }

        public void MachineBody(int icol, int irow, int idt)
        {
            try
            {

                int iColTemp;

               // if (_dt_layout.Rows[idt]["line"].ToString() == "2" && _dt_layout.Rows[idt]["l_R"].ToString() == "1") iColTemp = icol + 1;
              //  else 
                iColTemp = icol;
                axGrid.Row = irow;
                axGrid.Col = iColTemp;
                axGrid.Text = _dt_layout.Rows[idt]["station_cd"].ToString();
                axGrid.BackColor = Color.FromName(_dt_layout.Rows[idt]["color_B_no"].ToString());
                axGrid.ForeColor = Color.FromName(_dt_layout.Rows[idt]["color_F_no"].ToString());

                axGrid.SetCellBorder(iColTemp, irow, iColTemp, irow, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                axGrid.SetCellBorder(iColTemp + 1, irow, iColTemp + 1, irow, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                axGrid.SetCellBorder(iColTemp, irow, iColTemp, irow, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);


               // if (_dt_layout.Rows[idt]["line"].ToString() == "2" && _dt_layout.Rows[idt]["l_R"].ToString() == "1") iColTemp = icol;
              //  else 
           
                    iColTemp = icol + 1;
                axGrid.Col = iColTemp;
                axGrid.Text = _dt_layout.Rows[idt]["MOLD_SIZE_CD"].ToString();
                if (_dt_layout.Rows[idt]["USE_YN"].ToString() == "Y")
                {
                    if (_dt_layout.Rows[idt]["color_B_value"].ToString() == "Lime")
                    {
                        axGrid.BackColor = Color.Lime;
                        _countP++;
                    }
                    else if (_dt_layout.Rows[idt]["color_B_value"].ToString() == "RED")
                    {
                        axGrid.BackColor = Color.Red;
                        _countN++;
 
                    }
                    else
                        _countR++;
                    axGrid.BackColor = Color.FromName(_dt_layout.Rows[idt]["color_B_value"].ToString());
                }
                else
                {
                    axGrid.BackColor = Color.LightGray;
                    _countNU++;
                }
                //if (_dt_layout.Rows[idt]["color_B_value"].ToString() == "Lime")
                //    _countP++;
                //else if (_dt_layout.Rows[idt]["color_B_value"].ToString() == "RED")
                //    _countN++;
                //else
                //    _countR++;
                axGrid.ForeColor = Color.FromName(_dt_layout.Rows[idt]["color_F_value"].ToString());

                if (_dt_layout.Rows[idt]["color_B_value"] == _dt_layout.Rows[idt]["mold_change"])
                    _Loc_change.Add(iColTemp + " " + irow + " " + _dt_layout.Rows[idt]["machine_id"].ToString());
                else if (_dt_layout.Rows[idt]["color_B_value"] == _dt_layout.Rows[idt]["mold_plan"])
                    _Loc_plan.Add(iColTemp + " " + irow + " " + _dt_layout.Rows[idt]["machine_id"].ToString());
            }
            catch (Exception)
            { }

        }

        #endregion Binding Data Grid


        #region Mold Change
        /*        *         *
         * Show   TV     
         *        *         */
        private void showPopTV()
        {
            /*if (_dicAlarm.Count > 0)
            {
                _pop_alarm._machine = _dicAlarm.ElementAt(_iCount).Value;
           //     _pop_alarm._machine = _listAlarm[_iCount];
                _pop_alarm.Visible = false;
                _pop_alarm.Visible = true;
                _iCount++;
                if (_iCount >= _dicAlarm.Count) _iCount = 0;
            }
            else
            {
                tmrPopup.Enabled = false;
                _pop_alarm.Visible = false;
            }*/
        }

        /*        *         *
         * Show   Computer    
         *        *         */
        private void showBlinkComputer()
        {
            if (_dicAlarm.Count > 0)
            {
                for (int i = 0; i < _dicAlarm.Count; i++)
                {
                    axGrid.Col = Convert.ToInt32(_dicAlarm.ElementAt(i).Key.Substring(0, 2));
                    axGrid.Row = Convert.ToInt32(_dicAlarm.ElementAt(i).Key.Substring(2, 2));
                    if (axGrid.BackColor == Color.Yellow)
                        axGrid.BackColor = Color.White;
                    else
                        axGrid.BackColor = Color.Yellow;
                }
            }
            else tmr_blind.Enabled = false;
        }
        #endregion Mold Change


        private void blind(List<string> arg_list)
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
                            axGrid.BackColor = Color.Red;
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
                
                if (_dt_layout == null) _dt_layout = SEL_APS_PLAN_ACTUAL();
                DisplayGrid(_dt_layout, axGrid);
                setgrird();
                
            }
            catch (Exception)
            { }
            finally
            {
                //WarehouseMaterialSystem.ClassLib.WinAPI.AnimateWindow(axGrid.Handle, 500, WarehouseMaterialSystem.ClassLib.WinAPI.getSlidType("2"));
                //axGrid.Visible = true;
            }
        }


        private void setgrird()
        {
            try
            {

                DataTable _dt_layout_auto = null;
                DataTable _dt_layout_manu = null;
                DataTable _dt_layout_1 = SEL_LAYOUT().Tables[0];
                DataTable _dt_layout_2 = SEL_LAYOUT().Tables[1];

                _dt_layout_auto = SEL_APS_PLAN_ACTUAL_PU("AUTO");
                _dt_layout_manu = SEL_APS_PLAN_ACTUAL_PU("MANUAL");

                if(_dt_layout_auto != null)
                grdviewAUTO.DataSource = _dt_layout_auto;
                if (_dt_layout_manu != null)
                grdviewMANU.DataSource = _dt_layout_manu;
                if (_dt_layout_1 != null)
                {
                    gridControl1.DataSource = _dt_layout_1;
                }

                for (int i = 0; i < gvwviewAUTO.Columns.Count; i++)
                {

                    gvwviewAUTO.Columns[i].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    gvwviewAUTO.Columns[i].AppearanceCell.Options.UseTextOptions = true;
                    gvwviewAUTO.Columns[i].OptionsColumn.ReadOnly = true;
                    gvwviewAUTO.Columns[i].OptionsColumn.AllowEdit = false;
                    gvwviewAUTO.Columns[i].OptionsFilter.AllowFilter = false;
                    gvwviewAUTO.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                    gvwviewAUTO.Columns[i].AppearanceCell.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                    gvwviewAUTO.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    //if (i > 0)
                    //{
                    //    grdView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                    //    grdView.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    //    grdView.Columns[i].DisplayFormat.FormatString = "#,0.##";
                    //}
                }

                for (int i = 0; i < gvwviewMANU.Columns.Count; i++)
                {

                    gvwviewMANU.Columns[i].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    gvwviewMANU.Columns[i].AppearanceCell.Options.UseTextOptions = true;
                    gvwviewMANU.Columns[i].OptionsColumn.ReadOnly = true;
                    gvwviewMANU.Columns[i].OptionsColumn.AllowEdit = false;
                    gvwviewMANU.Columns[i].OptionsFilter.AllowFilter = false;
                    gvwviewMANU.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                    gvwviewMANU.Columns[i].AppearanceCell.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                    gvwviewMANU.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    //if (i > 0)
                    //{
                    //    grdView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                    //    grdView.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    //    grdView.Columns[i].DisplayFormat.FormatString = "#,0.##";
                    //}
                }

                for (int i = 0; i < bandedGridView1.Columns.Count; i++)
                {

                    bandedGridView1.Columns[i].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    bandedGridView1.Columns[i].AppearanceCell.Options.UseTextOptions = true;
                    bandedGridView1.Columns[i].OptionsColumn.ReadOnly = true;
                    bandedGridView1.Columns[i].OptionsColumn.AllowEdit = false;
                    bandedGridView1.Columns[i].OptionsFilter.AllowFilter = false;
                    bandedGridView1.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                    bandedGridView1.Columns[i].AppearanceCell.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                    bandedGridView1.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    //if (i > 0)
                    //{
                    //    grdView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                    //    grdView.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    //    grdView.Columns[i].DisplayFormat.FormatString = "#,0.##";
                    //}
                }
            }
            catch
            {
            }


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
        public DataTable SEL_APS_PLAN_ACTUAL()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

            try
            {
                string process_name = "PKG_SPB_MOLD_WMS_V2.SEL_MOLD_PRODUCTION_LAYOUT";

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


        public DataSet SEL_LAYOUT()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

            try
            {
                string process_name = "PKG_SPB_MOLD_WMS_V2.SEL_MOLD_LAYOUT_DETAIL";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;


                MyOraDB.Parameter_Name[0] = "ARG_TYPE";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR2";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "";
                MyOraDB.Parameter_Values[1] = "";
                MyOraDB.Parameter_Values[2] = "";

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

        public DataTable SEL_APS_PLAN_ACTUAL_PU(string TYPE)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

            try
            {
                string process_name = "PKG_SPB_MOLD_WMS_V2.SEL_MOLD_PRODUCTION_LAYOUT_PU";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;


                MyOraDB.Parameter_Name[0] = "ARG_MACHINE_TYPE";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = TYPE;
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
        }

        private void tmrPopup_Tick(object sender, EventArgs e)
        {
            
            showPopTV();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + "\n\r" + string.Format(DateTime.Now.ToString("HH:mm:ss"));
                _time++;
                if (_time == 60)
                {
                    _dt_layout = SEL_APS_PLAN_ACTUAL();
                    loaddata(true);
                    _time = 0;
                }


                if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 14 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 22)
                    lblShift.Text = "SHIFT 2";
                else if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 6 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 14)
                    lblShift.Text = "SHIFT 1";
                else
                    lblShift.Text = "SHIFT 3";
            }
            catch
            {
            }
        }

        private void tmr_blind_Tick(object sender, EventArgs e)
        {
            showBlinkComputer();
             //blind(_locChange);
           // else blind(_Loc_change_DMP);
        }

        private void Frm_Mold_WS_Change_By_Shift_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    setDefaultGrid(axGrid);
                    //Form_Main._bStatus = true;
                    _time = 59;
                    timer1.Start();
                    
                }
                else
                {
                   // Form_Main._bStatus = false;
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
        
        private void axGrid_ClickEvent(object sender, AxFPSpreadADO._DSpreadEvents_ClickEvent e)
        {
            try
            {
               /* _pop_change.Visible = false;
                if (_dicChange[e.col.ToString() + e.row.ToString()] != null)
                {
                    _pop_change._machine = _dicChange[e.col.ToString() + e.row.ToString()];

                    _pop_change.Visible = true;
                }
                else
                {
                    //_pop_change.Hide();
                }*/
            }
            catch (Exception)
            {}          
        }
        #endregion Event

        private void cmdBack_Click(object sender, EventArgs e)
        {
           // this.WindowState = FormWindowState.Minimized;
        //    Smart_FTY.ComVar._frm_home.Show();
            this.Hide();
        }

        private void gvwviewAUTO_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (gvwviewAUTO.GetRowCellValue(e.RowHandle, "MACHINE_NAME").ToString().Equals("TOTAL"))
            {
                e.Appearance.BackColor = Color.Lime;
                e.Appearance.ForeColor = Color.Black;
            }

            
        }

        private void gvwviewMANU_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (gvwviewMANU.GetRowCellValue(e.RowHandle, "MACHINE_NAME").ToString().Equals("TOTAL"))
            {
                e.Appearance.BackColor = Color.Lime;
                e.Appearance.ForeColor = Color.Black;
            }
        }

        private void bandedGridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (bandedGridView1.GetRowCellValue(e.RowHandle, "SHORT_NAME").ToString().Equals("TOTAL"))
            {
                e.Appearance.BackColor = Color.Lime;
                e.Appearance.ForeColor = Color.Black;
            }
        }

       

        

       
     

    }
}
