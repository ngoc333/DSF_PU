using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Text.RegularExpressions;
using ChartDirector;
using System.Threading;



//using COM.eBiz.Framework.Data;
//using COM.eBiz.Framework.Lib;
using FPSpreadADO;
using System.Globalization;



namespace IPEX_Monitor
{
    public partial class FORM_DMC_SET_BALANCE: Form
    {
        #region Declare
        int iNumRow = 0;
        int iMove = 4;
        
        DataTable dt_Daily_Report = null;
        Thread th;
        int _time = 0;
        
        private int idx_form;
        #endregion

        #region Creation
		public FORM_DMC_SET_BALANCE(int arg_idx = 0)
        {
            InitializeComponent();
            idx_form = arg_idx;
        }
        #endregion

        #region Method
        private void SearchData()
        {
            
               
        }
        private void nextForm()
        {

            //Application.Run(new MaterialSetRate.IPP_MACHINE_LAYOUT());
        }
        private void previousForm()
        {

            //Application.Run(new MaterialSetRate.Frm_Mold_WS_Change_By_Shift());
        }
        #endregion

        #region Event
        private void FORM_DMC_SET_BALANCE_Load(object sender, EventArgs e)
        {
            try
            {
                //Com_Base.Functions.Form_Maximized(this, int.Parse(Com_Base.Variables.Form[idx_form]["monitor"]));
                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

               // panel1.BackColor = Color.DodgerBlue;
               // this.lblDate.BackColor = Color.DodgerBlue;
                DataTable dt = null;

                //dt = Get_Work_Date("VJ", "1", "ABG", "000", "20170213");

                //Search_Daily_Report();
                //InitGrid();
                //load_view();
				
				//InitGrid();
				load_view();
				
                timer2.Interval = 1000;
                timer2.Start();
                timer1.Interval = 2000;
                timer1.Start();



            }
            catch (System.Exception ex)
            {

            }

        }

		private DataTable select_dmc_set_balance()
		{
			System.Data.DataSet retDS;
			COM.OraDB MyOraDB = new COM.OraDB();
			//MyOraDB.ReDim_Parameter(1);
			//MyOraDB.Process_Name = "PKG_SFC_ROLL_SO.IP_HOT_KNIFE_WIP";

			////02.ARGURMENT ¢¬i
			//MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

			////03.DATA TYPE A¢´AC

			//MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

			//MyOraDB.Parameter_Values[0] = "";

			//MyOraDB.Add_Select_Parameter(true);

			//retDS = MyOraDB.Exe_Select_Procedure();

			//if (retDS == null) return null;

			//return retDS.Tables[MyOraDB.Process_Name];


			try
			{
                string process_name = "PKG_IPP_IPEX3.DMC_SET_BALANCE";

				MyOraDB.ReDim_Parameter(1);
				MyOraDB.Process_Name = process_name;

				
				MyOraDB.Parameter_Name[0] = "OUT_CURSOR";
				
				MyOraDB.Parameter_Type[0] = (char)OracleType.Cursor;

				MyOraDB.Parameter_Values[0] = "";

				MyOraDB.Add_Select_Parameter(true);
				retDS = MyOraDB.Exe_Select_Procedure();

				if (retDS == null) return null;
				return retDS.Tables[process_name];
			}
			catch
			{
				return null;
			}
		}

        private void fm_master1()
        {
            //gvw_style.BeginUpdate();

            //gvw_style.BestFitColumns();
           // gvw_style.OptionsView.ColumnAutoWidth = false;



            //for (int i = 0; i < gvw_style.Columns.Count; i++)
            //{

            //    gvw_style.Columns[i].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //    gvw_style.Columns["STYLE_CD"].Width = 100;
            //    gvw_style.Columns["STYLE_CD"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //    gvw_style.Columns["STYLE_CD"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            //    gvw_style.Columns["STYLE_NAME"].Width = 260;
            //    gvw_style.Columns["STYLE_NAME"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            //    gvw_style.Columns["COMPONENT_NAME"].Width = 150;
            //    gvw_style.Columns["COMPONENT_NAME"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;

            //    if (i < _start_column)
            //    {
            //        gvw_style.Columns[i].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            //    }

            //    gvw_style.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            //    gvw_style.Columns[i].Caption = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(gvw_style.Columns[i].GetCaption().Replace("_", " ").ToLower());
            //    gvw_style.Columns[i].Caption = gvw_style.Columns[i].GetCaption().Replace("Style Cd", "Style Code");
            //    if (i > _start_column - 2)
            //    {
            //        gvw_style.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            //        gvw_style.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            //        gvw_style.Columns[i].DisplayFormat.FormatString = "#,###.#";
            //    }
            //    gvw_style.Columns[i].OptionsColumn.ReadOnly = true;
            //    gvw_style.Columns[i].OptionsColumn.AllowEdit = false;
            //    gvw_style.Columns[i].OptionsFilter.AllowFilter = false;
            //    gvw_style.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            //    gvw_style.Columns[1].Width = 120;
            //    gvw_style.Columns[2].Width = 180;
            //    gvw_style.Columns[3].Width = 80;
            //    if (i >= _start_column)
            //    {
            //        //if (gvw_style.Columns[i].Width < 40)
            //        //{
            //            gvw_style.Columns[i].Width = 60;
            //       // }
            //    }

            //    gvw_style.ColumnPanelRowHeight = 40;
            //    gvw_style.Columns["STYLE_NAME"].VisibleIndex = 0;
            //}
            //gvw_style.Columns[_start_column].VisibleIndex = 1;
            //gvw_style.TopRowIndex = 0;

            //gvw_style.EndUpdate();
        }

		string strymd = "", strtype = "", strdd = "", strd1 = "", strd2 = "", strd3 = "", strd4 = "", strd5 = "";
        private void InitGrid()
        {
			
        }

		private void load_view()
        {
            try
            {
                DataTable dt_temp = select_dmc_set_balance();
                //grd_style.Visible = false;
                int i_row = 2, i_count = 1, i_row1 = 2, i_count1 = 1;
                if (dt_temp != null & dt_temp.Rows.Count > 0)
                {
                    //DtSource = dt_temp;

                    DataTable dt = dt_temp;

                    if (dt.Rows.Count > 0)
                    {
                        DataTable dtSource = new DataTable();


                        if (!buildHeader(dtSource, dt)) return;
                        if (!bindingDataSource(dtSource, dt)) return;
                        axfpSpread.Enabled = false;
                        axfpSpread.Visible = false;
                        axfpSpread.MaxRows = 1 + dtSource.Rows.Count;
                        axfpSpread.set_RowHeight(1, 30);
                        axfpSpread.Row = 1;
                        axfpSpread.TypeHAlign = TypeHAlignConstants.TypeHAlignCenter;
                        axfpSpread.TypeVAlign = TypeVAlignConstants.TypeVAlignCenter;
                        axfpSpread.Font = new Font("Calibri", 14, FontStyle.Bold);
                        axfpSpread.BackColor = Color.Salmon;
                        axfpSpread.ForeColor = Color.White;
                        axfpSpread.SetCellBorder(1, 1, axfpSpread.MaxCols, axfpSpread.MaxRows, CellBorderIndexConstants.CellBorderIndexBottom, 0, CellBorderStyleConstants.CellBorderStyleSolid);
                        axfpSpread.SetCellBorder(1, 1, axfpSpread.MaxCols, axfpSpread.MaxRows, CellBorderIndexConstants.CellBorderIndexTop, 0, CellBorderStyleConstants.CellBorderStyleSolid);
                        axfpSpread.SetCellBorder(1, 1, axfpSpread.MaxCols, axfpSpread.MaxRows, CellBorderIndexConstants.CellBorderIndexLeft, 0, CellBorderStyleConstants.CellBorderStyleSolid);
                        axfpSpread.SetCellBorder(1, 1, axfpSpread.MaxCols, axfpSpread.MaxRows, CellBorderIndexConstants.CellBorderIndexRight, 0, CellBorderStyleConstants.CellBorderStyleSolid);
                        for (int j = 0; j < dtSource.Columns.Count; j++)
                        {

                            axfpSpread.set_RowHeight(2, 27);

                            if (j > 2)
                            {
                                axfpSpread.SetText(j + 1, 2, dtSource.Rows[dtSource.Rows.Count - 1][j].ToString() == "" ? " " : Convert.ToDouble(dtSource.Rows[dtSource.Rows.Count - 1][j].ToString()).ToString("#,0"));
                                axfpSpread.Row = 2;
                                axfpSpread.Col = j + 1;
                                axfpSpread.TypeHAlign = TypeHAlignConstants.TypeHAlignRight;
                                axfpSpread.TypeVAlign = TypeVAlignConstants.TypeVAlignCenter;
                                axfpSpread.Font = new Font("Calibri", 13, FontStyle.Regular);

                                axfpSpread.set_ColWidth(j + 1, j + 1 == 3 ? 10 : 8);
                            }
                            else
                            {
                                axfpSpread.SetText(j + 1, 2, dtSource.Rows[dtSource.Rows.Count - 1][j].ToString());
                                axfpSpread.set_ColWidth(j + 1, j + 1 == 1 ? 30 : 15);
                                axfpSpread.Row = 2;
                                axfpSpread.Col = j + 1;
                                axfpSpread.TypeHAlign = j + 1 == 1 ? TypeHAlignConstants.TypeHAlignCenter : TypeHAlignConstants.TypeHAlignLeft;
                                axfpSpread.TypeVAlign = TypeVAlignConstants.TypeVAlignCenter;
                                axfpSpread.Font = new Font("Calibri", 13, FontStyle.Regular);
                            }
                            if (j > 1)
                            {
                                if (dtSource.Rows[dtSource.Rows.Count - 1][2].ToString().Equals("Set"))
                                {
                                    axfpSpread.Row = 2;
                                    axfpSpread.Col = j + 1;
                                    axfpSpread.BackColor = Color.LightCyan;
                                    axfpSpread.ForeColor = Color.Coral;
                                    axfpSpread.Font = new Font("Calibri", 13, FontStyle.Bold);
                                }
                            }
                            if (dtSource.Rows[dtSource.Rows.Count - 1][0].ToString().Equals("Total Set"))
                            {
                                axfpSpread.Row = 2;
                                axfpSpread.Col = j + 1;
                                axfpSpread.BackColor = Color.LightGray;
                                axfpSpread.Font = new Font("Calibri", 13, FontStyle.Bold);
                            }


                        }
                        for (int i = 0; i < dtSource.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < dtSource.Columns.Count; j++)
                            {

                                axfpSpread.set_RowHeight(i + 3, 24.5);

                                if (j > 2)
                                {
                                    axfpSpread.SetText(j + 1, i + 3, dtSource.Rows[i][j].ToString() == "" ? " " : Convert.ToDouble(dtSource.Rows[i][j].ToString()).ToString("#,0"));
                                    axfpSpread.Row = i + 3;
                                    axfpSpread.Col = j + 1;
                                    axfpSpread.TypeHAlign = TypeHAlignConstants.TypeHAlignRight;
                                    axfpSpread.TypeVAlign = TypeVAlignConstants.TypeVAlignCenter;
                                    axfpSpread.Font = new Font("Calibri", 13, FontStyle.Regular);

                                    axfpSpread.set_ColWidth(j + 1, j + 1 == 4 ? 12 : 7.5);
                                }
                                else
                                {
                                    axfpSpread.SetText(j + 1, i + 3, dtSource.Rows[i][j].ToString());
                                    axfpSpread.set_ColWidth(j + 1, j + 1 == 1 ? 35 : 16);
                                    axfpSpread.Row = i + 3;
                                    axfpSpread.Col = j + 1;
                                    axfpSpread.TypeHAlign = j + 1 == 1 ? TypeHAlignConstants.TypeHAlignLeft : TypeHAlignConstants.TypeHAlignCenter;
                                    axfpSpread.TypeVAlign = TypeVAlignConstants.TypeVAlignCenter;
                                    axfpSpread.Font = new Font("Calibri", 13, FontStyle.Regular);
                                }
                                if (j > 1)
                                {
                                    if (dtSource.Rows[i][2].ToString().Equals("Set"))
                                    {
                                        axfpSpread.Row = i + 3;
                                        axfpSpread.Col = j + 1;
                                        axfpSpread.BackColor = Color.LightCyan;
                                        axfpSpread.ForeColor = Color.Coral;
                                        axfpSpread.Font = new Font("Calibri", 13, FontStyle.Bold);
                                    }
                                }
                                if (dtSource.Rows[i][0].ToString().Equals("Total Set"))
                                {
                                    axfpSpread.Row = i + 3;
                                    axfpSpread.Col = j + 1;
                                    axfpSpread.BackColor = Color.LightGray;
                                    axfpSpread.Font = new Font("Calibri", 13, FontStyle.Bold);
                                }


                            }
                        }
                        for (int i = 2; i <= axfpSpread.MaxRows - 1; i++)
                        {
                            if (GetText(axfpSpread, 1, i) == GetText(axfpSpread, 1, i + 1))
                            {
                                i_count++;
                                if (GetText(axfpSpread, 2, i) == GetText(axfpSpread, 2, i + 1))
                                {
                                    i_count1++;
                                }
                                else
                                {
                                    axfpSpread.AddCellSpan(2, i_row1, 1, i_count1);
                                    i_count1 = 1;
                                    i_row1 = i + 1;
                                }
                            }
                            else
                            {
                                axfpSpread.AddCellSpan(2, i_row1, 1, i_count1);
                                i_count1 = 1;
                                i_row1 = i + 1;
                                axfpSpread.AddCellSpan(1, i_row, 1, i_count);
                                i_count = 1;
                                i_row = i + 1;
                            }
                            if (i == axfpSpread.MaxRows - 1)
                            {
                                axfpSpread.AddCellSpan(1, i_row, 1, i_count);
                                axfpSpread.AddCellSpan(2, i_row1, 1, i_count1);
                            }
                            
                        }
                        //grd_style.DataSource = dtSource;
                        //SetData(grd_style, dtSource);
                        //fm_master1();

                    }
                    axfpSpread.RowsFrozen = 2;
                    axfpSpread.Enabled = true;
                    axfpSpread.Visible = true;
                }
            }
            catch 
            { 

            }
            
        }

        private string GetText(AxFPSpreadADO.AxfpSpread spread, int col, int row)
        {
            try
            {
                object data = null;
                spread.GetText(col, row, ref data);
                return data.ToString();
            }
            catch (Exception ex)
            {
                //return "";
                //log.Error(ex);
                return null;
            }

        }

        /// <summary>
        /// 종료
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        #endregion

        int _start_column = 0;
        int _start_column_master = 0;

        private bool buildHeader(DataTable dtSource, DataTable dt)
        {
            try
            {
                int.TryParse(dt.Rows[0]["START_COLUMN"].ToString(), out _start_column);
                axfpSpread.MaxRows = 1;
                axfpSpread.MaxCols = 1;
                _start_column_master = _start_column;
                for (int i = 0; i < _start_column - 1; i++)
                {
                    axfpSpread.SetText(axfpSpread.MaxCols, 1, dt.Columns[i].Caption.Replace("STYLE_CD","Style Code").Replace("STYLE_NAME","Style Name").Replace("COMPONENT_NAME","Component"));
                    axfpSpread.MaxCols = axfpSpread.MaxCols + 1;
                    dtSource.Columns.Add(dt.Columns[i].Caption, typeof(string));
                }
                dtSource.Columns.Add(dt.Columns[_start_column - 1].Caption, typeof(double));
                axfpSpread.SetText(axfpSpread.MaxCols, 1, dt.Columns[_start_column - 1].Caption);
                axfpSpread.MaxCols = axfpSpread.MaxCols + 1;
                DataRow[] row = dt.Select("", "SIZE_NUM ASC");
                double min = 1, max = 22;
                double.TryParse(row[0]["SIZE_NUM"].ToString(), out min);
                double.TryParse(row[row.Length - 1]["SIZE_NUM"].ToString(), out max);
                for (double i = min; i <= max; i = i + 0.5)
                {
                    axfpSpread.SetText(axfpSpread.MaxCols, 1, i.ToString().Replace(".5", "T"));
                    axfpSpread.MaxCols = axfpSpread.MaxCols + 1;
                    dtSource.Columns.Add(i.ToString().Replace(".5", "T"), typeof(double));
                }
                axfpSpread.MaxCols = axfpSpread.MaxCols - 1;
                return true;
            }
            catch (Exception ex)
            {                
                return false;
            }
        }

        private bool bindingDataSource(DataTable dtSource, DataTable dt)
        {
            try
            {
                DataTable dtSort = dt.Select("", "STYLE_CD ASC").CopyToDataTable();
                DataTable dtTemp = dtSort.DefaultView.ToTable(true, "COMPONENT_NAME");

                string[] distinct_component = new string[dtTemp.Rows.Count];

                decimal[] total_component = new decimal[dtSource.Columns.Count];
                decimal[] rowtotal = new decimal[dtSource.Columns.Count];
                decimal[] Grant_rowtotal = new decimal[dtSource.Columns.Count];
                string distinct_row = "";

                string color = "";
                decimal temp1, temp2;
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (distinct_row != dt.Rows[i]["DISTINCT_ROW"].ToString())
                    {
                        dtSource.Rows.Add();
                        if (color == "1")
                        {
                            color = "2";
                        }
                        else
                        {
                            color = "1";
                        }

                    }


                    distinct_row = dt.Rows[i]["DISTINCT_ROW"].ToString();

                    for (int j = 0; j < _start_column - 1; j++)
                    {
                        dtSource.Rows[dtSource.Rows.Count - 1][j] = dt.Rows[i][j];

                    }

                    if (dt.Rows[i]["SIZE_CD"].ToString() != "")
                    {
                        decimal.TryParse(dt.Rows[i]["QTY"].ToString(), out temp1);
                        decimal.TryParse(dtSource.Rows[dtSource.Rows.Count - 1][dt.Rows[i]["SIZE_CD"].ToString()].ToString(), out temp2);
                        dtSource.Rows[dtSource.Rows.Count - 1][dt.Rows[i]["SIZE_CD"].ToString()] = (temp1 + temp2).ToString();

                        decimal.TryParse(dtSource.Rows[dtSource.Rows.Count - 1][_start_column - 1].ToString(), out temp2);
                        dtSource.Rows[dtSource.Rows.Count - 1][_start_column - 1] = (temp1 + temp2).ToString();

                        rowtotal[dtSource.Columns[dt.Rows[i]["SIZE_CD"].ToString()].Ordinal] += temp1;
                        rowtotal[_start_column - 1] += temp1;


                        Grant_rowtotal[dtSource.Columns[dt.Rows[i]["SIZE_CD"].ToString()].Ordinal] += temp1;
                        Grant_rowtotal[_start_column - 1] += temp1;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {                   
                return false;
            }
        }
        
        private void MergeCol(AxFPSpreadADO.AxfpSpread gridObject, int iStartRow, int iCol)
        {
            try
            {
                string sTemp1 = "";
                string sTemp2 = "";
                int iRow = iStartRow;
                gridObject.Row = iStartRow;
                gridObject.Col = iCol;
                if (gridObject.Value.ToString() != "")
                {
                    sTemp1 = gridObject.Value;
                }
               
                    for (int i = iStartRow; i < gridObject.MaxRows + 4; i++)
                    {
                        gridObject.Row = i;
                        gridObject.Col = iCol;
                          sTemp2 = gridObject.Value;
                            if (sTemp1 != sTemp2 )
                            {
                                gridObject.AddCellSpan(iCol, iRow, 1, i - iRow);
                                sTemp1 = sTemp2;
                                sTemp2 = "";
                                iRow = i;
                            }
                            if (gridObject.Value.ToString() == "")
                            {
                                iRow = i;

                            }
                                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        public bool IsNumeric(string text)
        {
            return Regex.IsMatch(text,"^\\d+$");
        }

        private void showAnimation(AxFPSpreadADO.AxfpSpread flg)
        {
            flg.Hide();
			IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(flg.Handle, 2000, IPEX_Monitor.ClassLib.WinAPI.getSlidType("2"));
            flg.Show();
        }



        private void timer2_Tick(object sender, EventArgs e)
        {   
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            _time++;
            if (_time >= 20)
            {
				
				
				load_view();				
				_time = 0;
				
            }
           
        }

        private void FORM_DMC_SET_BALANCE_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
               
        private bool checkWindowOpen(string windowName)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name.Equals(windowName))
                {
                    Application.OpenForms[i].Show();

                    return false;
                }
            }
            return true;
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dt_Daily_Report == null) return;
            if (dt_Daily_Report.Rows.Count - 1 > 15)
            {
                if (iMove >= dt_Daily_Report.Rows.Count - 15)
                {
                    if (iMove > dt_Daily_Report.Rows.Count - 15 + 5)
                    {

                        iMove = 3;

                        timer1.Stop();
                        //axfpSpread.TopRow = 3;

                    }
                    else
                    {
                        iMove += 5; ;
                    }
                }
                else
                {
                    iMove += 5;
                    //axfpSpread.TopRow = iMove;
                }
            }   
        }

        private void FORM_DMC_SET_BALANCE_Activated(object sender, EventArgs e)
        {
            //timer1.Start();            
        }		

        private void lblDate_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                Application.Exit();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void FORM_DMC_SET_BALANCE_VisibleChanged(object sender, EventArgs e)
		{
			if (this.Visible)
			{
				try
				{
					timer2.Start();
					//axfpSpread.Visible = false;
					//axfpSpread.Enabled = false;
					//InitGrid();
					//load_view();
					//axfpSpread.Visible = true;
					//axfpSpread.Enabled = true;
					
					//  set_time_chage();
				}
				catch (Exception)
				{


				}
			}
			else
			{
				timer2.Stop();
			}
		}

        private void gvw_style_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //GridViewEx ex = sender as GridViewEx;
            //if (ex.GetRowCellValue(e.RowHandle, "COMPONENT_NAME").ToString() == "Set")
            //{
            //    e.Appearance.BackColor = Color.LightCyan;
            //    e.Appearance.ForeColor = Color.Coral;
            //}

            //if (ex.GetRowCellValue(e.RowHandle, "STYLE_NAME").ToString() == "Total Set")
            //{
            //    e.Appearance.BackColor = Color.LightGray;
            //    //e.Appearance.ForeColor = Color.Coral;
            //}

            //if (e.RowHandle == gvw_style.FocusedRowHandle)
            //{
            //    e.Appearance.BackColor = Color.LightSkyBlue;
            //}
        }

        private void gvw_style_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
        }
    }
   

}
