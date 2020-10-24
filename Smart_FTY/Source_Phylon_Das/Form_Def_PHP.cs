using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Smart_FTY
{
    public partial class Form_Def_PHP : Form
    {
        public Form_Def_PHP()
        {
            InitializeComponent();
        }
        //public virtual System.Drawing.ContentAlignment TextAlign { get; set; }
          //  string _Zone = "Z001";
        public int _Izone = 1;
      //  string _lbl1, _lbl2, _lbl3;
        public int _time = 0;
        int _time_load = 40;
        DataTable _dt_data = null;
        DataTable _dt_grid = null;
       // DataTable _dt_data1 = null;
        DataTable _dt_grid1 = null; 
      //  string[] _columnNames;

        

        #region Function



        private void GoFullscreen()
        {

           
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            
        }

        private void create_grid(AxFPUSpreadADO.AxfpSpread arg_Grid, DataTable dtData)//, DataTable dtGrid)
        {

            try
            {
                arg_Grid.Visible = false;
                int iMaxCol = dtData.Columns.Count - 1;
                arg_Grid.MaxRows = 3;
                arg_Grid.MaxRows = dtData.Rows.Count +3;
                /*
                
                // arg_Grid.MaxRows = dtData.Rows.Count -2;
              //  axGrid.ClearRange(0, 4, 100, 100, false);               

                arg_Grid.Reset();
                arg_Grid.DisplayColHeaders = false;
                arg_Grid.DisplayRowHeaders = false;
                arg_Grid.ActiveCellHighlightStyle = FPUSpreadADO.ActiveCellHighlightStyleConstants.ActiveCellHighlightStyleOff;
                arg_Grid.ColHeaderRows = 0;

                arg_Grid.TypeVAlign = FPUSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
                arg_Grid.Font = new System.Drawing.Font("Calibri", 10.25F, FontStyle.Bold);

                arg_Grid.RowsFrozen = 3;
                arg_Grid.ColsFrozen = 1;                

                //arg_Grid.Row = 1;
             //   arg_Grid.BackColor = Color.Gray;
              //  arg_Grid.ForeColor = Color.White;
                arg_Grid.AddCellSpan(2, 1, 4, 1);
                arg_Grid.AddCellSpan(6, 1, 4, 1);
                arg_Grid.AddCellSpan(10, 1, 4, 1);
                arg_Grid.AddCellSpan(14, 1, 4, 1);
                arg_Grid.AddCellSpan(18, 1, 4, 1);
                arg_Grid.AddCellSpan(22, 1, 4, 1);
                arg_Grid.AddCellSpan(26, 1, 4, 1);

                //// cells
                arg_Grid.TypeEditMultiLine = true;
                arg_Grid.MaxCols = iMaxCol;
                arg_Grid.SetCellBorder(1, 1, iMaxCol, arg_Grid.MaxRows, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                arg_Grid.SetCellBorder(1, 1, iMaxCol, arg_Grid.MaxRows, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                arg_Grid.SetCellBorder(1, 1, iMaxCol, arg_Grid.MaxRows, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexRight, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                arg_Grid.SetCellBorder(1, 2, iMaxCol, arg_Grid.MaxRows, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                arg_Grid.SetCellBorder(1, 2, iMaxCol, arg_Grid.MaxRows, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                arg_Grid.SetCellBorder(1, 2, iMaxCol, arg_Grid.MaxRows, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexRight, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);

                //for (int i = 1; i < arg_Grid.MaxRows; i++)
                //{

                //    arg_Grid.Row = i;
                //    // arg_Grid.Col = 1;
                //      arg_Grid.TypeHAlign = FPUSpreadADO.TypeHAlignConstants.TypeHAlignRight;
                //    if (i == 1)
                //    {
                //        arg_Grid.TypeHAlign = FPUSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
                //        arg_Grid.Font = new System.Drawing.Font("Calibri", 12.25F, FontStyle.Bold);
                //        arg_Grid.BackColor = Color.Gray;
                //        arg_Grid.ForeColor = Color.White;
                //    }
                //    else if (i == 2)
                //    {
                //        arg_Grid.TypeHAlign = FPUSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
                //        arg_Grid.Font = new System.Drawing.Font("Calibri", 10.25F, FontStyle.Bold);
                //        arg_Grid.BackColor = Color.LightGray;
                //        arg_Grid.ForeColor = Color.White;
                //    }
                //    else if (i == 3)
                //    {
                //        arg_Grid.TypeHAlign = FPUSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
                //        arg_Grid.Font = new System.Drawing.Font("Calibri", 10.25F, FontStyle.Bold);
                //        arg_Grid.BackColor = Color.LightSalmon;
                //        arg_Grid.ForeColor = Color.White;
                //    }
                //    //else if (i > 3)
                //    //{
                //    //    arg_Grid.TypeHAlign = FPUSpreadADO.TypeHAlignConstants.TypeHAlignRight;
                //    //    arg_Grid.BackColor = Color.White;
                //    //    arg_Grid.ForeColor = Color.Black;
                //    //}

                //    else
                //    {
                //        arg_Grid.BackColor = Color.White;
                //        arg_Grid.ForeColor = Color.Black;
                //    }
                //    arg_Grid.set_RowHeight(i, 25);

                //}
                arg_Grid.Row = -1;
                arg_Grid.Col = 1;
                */

                /// -----------row header------------------------------
                arg_Grid.Row = 1;              

                arg_Grid.set_RowHeight(1, 30);

                int iDtRow = dtData == null || dtData.Rows.Count == 0 ? 50 : dtData.Rows.Count;
                //   int iDtCol = dtData == null || dtData.Columns.Count == 0 ? 29 : dtData.Columns.Count;

               
                if (iDtRow > 8)
                {
                    //iColName = "COL_WIDTH_SCOLL";
                    arg_Grid.ScrollBars = FPUSpreadADO.ScrollBarsConstants.ScrollBarsVertical;
                    arg_Grid.ScrollBarWidth = 20;
                }

                else
                {
                    arg_Grid.ScrollBars = FPUSpreadADO.ScrollBarsConstants.ScrollBarsNone;
                }
              //  arg_Grid.MaxRows = iDtRow + arg_Grid.RowsFrozen;

                for (int i = 0; i < iMaxCol; i++)
                {
                    arg_Grid.Col = i + 1;
                  
                }
                ///
                /// --------add data------------------------------
                /// 
                if (dtData == null || dtData.Rows.Count == 0)
                {
                    return;
                }

                else
                {
                    double[] totalAvg = new double[dtData.Columns.Count];                    
                    double temp = 0.0;
                   
                    for (int icol = 0; icol < dtData.Columns.Count; icol++)
                    {

                        arg_Grid.SetText(icol + 1, 1, dtData.Columns[icol + 1].ColumnName.Replace("'", "").Split('\n')[0]);
                        if (icol < dtData.Columns.Count - 2)
                        {
                            arg_Grid.SetText(icol + 2, 2, dtData.Columns[icol + 2].ColumnName.Replace("'", "").Split('\n')[1]);
                        }
                        if (icol == 1)
                        {
                            arg_Grid.set_ColWidth(1, 26.5);


                        }
                        if (icol >= 2)
                        {
                            arg_Grid.set_ColWidth(icol, 7.25);


                        }

                        arg_Grid.SetText(1, 1, "Week");
                        arg_Grid.SetText(1, 2, "Model");
                        // arg_Grid.SetText( 1, 3, "Total");

                        for (int i = 0; i < dtData.Rows.Count - 1; i++)
                        {
                            //if (icol >= 2 && i >= 3)
                            //{
                            //    arg_Grid.TypeHAlign = FPUSpreadADO.TypeHAlignConstants.TypeHAlignRight;
                            //   // arg_Grid.Font = new System.Drawing.Font("Calibri", 10.25F, FontStyle.Regular);
                            //}
                            // Rate.
                            if (dtData.Columns[icol + 1].ColumnName.Contains("%"))
                            {
                                
                                double.TryParse(dtData.Rows[i][icol + 1].ToString(), out temp);
                                if (!string.IsNullOrWhiteSpace(dtData.Rows[i][icol + 1].ToString()) && temp > 0)
                                {
                                    string rate = dtData.Rows[i][icol + 1].ToString() + "%";
                                    arg_Grid.SetText(icol + 1, i + 3, rate);
                                }
                            }
                            // Remains.
                            else
                            {
                                double.TryParse(dtData.Rows[i][icol + 1].ToString(), out temp);
                                if (temp > 0)
                                {                                   
                                    arg_Grid.SetText(icol + 1, i + 3, FormatNumber(dtData.Rows[i][icol + 1].ToString()));                                   
                                }
                                else
                                {
                                    arg_Grid.SetText(icol + 1, i + 3, dtData.Rows[i][icol + 1].ToString());
                                }

                            }
                            //if (icol == 1)
                            //{
                            //    arg_Grid.Col = 1;
                            //    arg_Grid.Row = i;
                            //    arg_Grid.Font = new Font(arg_Grid.Font.FontFamily, arg_Grid.Font.Size, FontStyle.Bold);
                            //}
                            //if (icol >= 2 && i > 4)
                            //{
                            //    arg_Grid.TypeHAlign = FPUSpreadADO.TypeHAlignConstants.TypeHAlignRight;
                            //    arg_Grid.Font = new System.Drawing.Font("Calibri", 10.25F, FontStyle.Regular);
                            //}

                        }
                    }

                   // this.axGrid.Show();
                   // WarehouseMaterialSystem.ClassLib.WinAPI.AnimateWindow(this.axDetail.Handle, 400, WarehouseMaterialSystem.ClassLib.WinAPI.getSlidType("5"));

                }
            }
            catch (Exception)
            {
            }
        }

        private string FormatNumber(string value)
        {
            string result = "",
                   fmt = "";
            double temp = 0.0;

            double.TryParse(value, out temp);
            if (temp > 0)
            {
                fmt = temp % 1 == 0 ? "{0:n0}" : "{0:n2}";
                result = string.Format(fmt, temp);
            }
            return result;
        }

        private void chartqty(DataTable dt_data, DevExpress.XtraCharts.ChartControl chartqty2)
        {
            try
            {

                if (dt_data == null || dt_data.Rows.Count <= 0) return;


                DataTable dt = dt_data.Clone();

                dt.Columns["'Average\nDefect'"].DataType = typeof(double);
                dt.Columns["'Average\n%'"].DataType = typeof(double);

                //foreach (DataRow row in dt_data.Rows)
                //    dt.ImportRow(row);
                for (int i = 1; i < dt_data.Rows.Count; i++)
                {
                    dt.ImportRow( dt_data.Rows[i]);
                }
                chartqty2.DataSource = dt;

               
                //PKG_SPB_MODEL_TEMP.SEL_OS_DEFECTIVE:

                //chartqty2.Series["Defect"].ArgumentDataMember = "MODEL_NAME";
                //chartqty2.Series["Defect"].ValueDataMembers.AddRange(new string[] { "'Average\nDefect'" });

                //chartqty2.Series["%"].ArgumentDataMember = "MODEL_NAME";
                //chartqty2.Series["%"].ValueDataMembers.AddRange(new string[] { "'Average\n%'" });

                // PKG_SPB_MODEL_TEMP.SELECT_DEFECTIVE_MODEL_V2 :

                chartqty2.Series["Defect"].ArgumentDataMember = "MODEL";
                chartqty2.Series["Defect"].ValueDataMembers.AddRange(new string[] { "'Average\nDefect'" });

                chartqty2.Series["%"].ArgumentDataMember = "MODEL";
                chartqty2.Series["%"].ValueDataMembers.AddRange(new string[] { "'Average\n%'" });

                //  chartqty2.Series[0].Points[0].Color = Color.Green;
                //  chartqty2.Series[0].Points[1].Color = Color.Red;
            }

            catch
            {
            }
        }

        public void loadmain()
        {

            try
            {
                this.axGrid.Hide();
                DataSet ds = null;





                // PKG_SPB_MODEL_TEMP.SEL_OS_DEF_PHP 
              //  ds = SELECT_MODEL("SEL_OS_DEF_PHP");
                // PKG_SPB_MODEL_TEMP.SEL_OS_DEF_PHP_V2
                ds = SELECT_MODEL("SEL_OS_DEF_PHP_V2");


                //cmdCleaningHis.BackColor = Color.Gray;

                // DataTable dt_grid = null;
                DataTable dt_data = ds.Tables[0];

                //  _dt_grid = dt_data;
                // dt_grid = dt_data;
                if (dt_data == null || dt_data.Rows.Count <= 0) return;


                if (dt_data != null && dt_data.Rows.Count > 0)
                {
                    _dt_data = dt_data;
                }
                chartqty(dt_data, chartqty2);
                //Display_Grid(axGrid, dt_data);
                create_grid(axGrid, _dt_data);//, _dt_grid);
                this.axGrid.Show();
                btnCMP.Visible = false;
                btnOS.Visible = false;
                
            }

            catch (Exception)
            {

            }
        }
        public DataSet SELECT_MODEL(string str)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

            try
            {
                string process_name = "PKG_SPB_MODEL_TEMP." + str;

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = process_name;              

                MyOraDB.Parameter_Name[0] = "OUT_CURSOR"; 
                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Values[0] = "";                

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
       
        public void loaddata()
        {
          
            try
            {
                DataTable dt = SEL_DATA();
                if (dt == null || dt.Rows.Count == 0) return;
                axGrid.MaxRows =1;
                axGrid.MaxRows =100;
                int iRow = 1, iCol = 2;
                bool bTotal = false;
                for( int i =0; i<dt.Rows.Count;i++)
                {
                    if (bTotal == false && dt.Rows[i]["ORD"].ToString() == "3")
                    {
                        axGrid.Col = -1;
                        axGrid.Row = iRow;
                        //axGrid.BackColor = Color.LightGray;
                        axGrid.set_RowHeight(iRow, 30);
                        //axGrid.FontSize = 10;
                    }

                    axGrid.SetText(1, 1 + iRow, dt.Rows[i]["MODEL_NAME"].ToString());
                    if (dt.Rows[i]["RN"].ToString() == "99")
                        axGrid.SetText(axGrid.MaxCols, iRow, dt.Rows[i]["QTY"].ToString());
                    else
                    {
                        int.TryParse(dt.Rows[i]["RN"].ToString(),out iCol);
                        if (iCol >0)
                            axGrid.SetText(1 + iCol, iRow, dt.Rows[i]["QTY"].ToString());
                    }

                    if (i + 1 < dt.Rows.Count && dt.Rows[i]["MODEL_NAME"].ToString() != dt.Rows[i + 1]["MODEL_NAME"].ToString())
                    {
                        iCol = 2;
                        iRow++;
                    }
                    else
                        iCol++;
                }
                axGrid.MaxRows =iRow;


                chartqty(dt, chartqty2);
            }

            catch 
            {

            }
        }

       

        //private void chartqty(DataTable dt_data, DevExpress.XtraCharts.ChartControl argChart)
        //{
        //    try
        //    {                
        //        if (dt_data == null || dt_data.Rows.Count <= 0) return;

        //        DataTable dt = dt_data.Clone();
        //        dt.Columns["VALUE_CHART"].DataType = typeof(double);
        //        dt = dt_data.Select("RN = '99' and ORD = '4'").CopyToDataTable();

        //        argChart.DataSource = dt;
        //        argChart.Series[0].ArgumentDataMember = "MODEL_NAME";
        //        argChart.Series[0].ValueDataMembers.AddRange(new string[] { "VALUE_CHART" });
        //        //argChart.Series[0].Points[0].Color = Color.Green;
        //        //argChart.Series[0].Points[1].Color = Color.Red;
        //    }
        //    catch
        //    {
        //    }
        //}
               
        #endregion 
       
        #region DB

        public DataTable SEL_DATA()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

            try
            {
                string process_name = "PKG_SPB_MODEL_TEMP.SEL_OS_DEFECTIVE";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;


                MyOraDB.Parameter_Name[0] = "ARG_WH_CD";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "";
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name]; ;
            }
            catch
            {
                return null;
            }
        }

        public DataSet SEL_MODEL_DEF_LIST(string str)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

            try
            {
                string process_name = "PKG_SPB_MODEL_TEMP." + str;

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;


                MyOraDB.Parameter_Name[0] = "OUT_CURSOR1";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR2";

                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "";
                MyOraDB.Parameter_Values[1] = "";

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


        //public DataSet SELECT_MODEL(string str)
        //{
        //    COM.OraDB MyOraDB = new COM.OraDB();
        //    System.Data.DataSet ds_ret1;

        //    try
        //    {
        //        string process_name = "PKG_SPB_MODEL_TEMP." + str;

        //        MyOraDB.ReDim_Parameter(2);
        //        MyOraDB.Process_Name = process_name;


        //        MyOraDB.Parameter_Name[0] = "OUT_CURSOR1";
        //        MyOraDB.Parameter_Name[1] = "OUT_CURSOR2";

        //        MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
        //        MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

        //        MyOraDB.Parameter_Values[0] = "";
        //        MyOraDB.Parameter_Values[1] = "";

        //        MyOraDB.Add_Select_Parameter(true);
        //        ds_ret1 = MyOraDB.Exe_Select_Procedure();

        //        if (ds_ret1 == null) return null;
        //        return ds_ret1;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}


        #endregion DB

        private void Form_Def_PHP_Load(object sender, EventArgs e)
        {
            GoFullscreen();
                    loadmain();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + "\n" + string.Format(DateTime.Now.ToString("HH:mm:ss"));

                _time++;
                if (_time >= _time_load)
                {
                    _time = 0;
                   // loaddata();
                    //loadmain();
             
                }
            }
            catch
            {
            }
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {

            }
        }

        private void Form_Def_PHP_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                _time = _time_load - 1;
                timer1.Start();

            }
            else
            {
                timer1.Stop();
            }
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void btnOS_Click(object sender, EventArgs e)
        {

            //Form_Def_Mod fmOS = new Form_Def_Mod(); 
            //fmOS.MdiParent = this;
          //  fmOS.Show();
            
        }

        private void btnCMP_Click(object sender, EventArgs e)
        {
          //  Form_Def_CMP fmOS = new Form_Def_CMP(); 
            //fmOS.MdiParent = this;
           // fmOS.Show();
        }

        

        
    }
}
