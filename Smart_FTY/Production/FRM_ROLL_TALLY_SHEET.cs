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
using System.Drawing;


//using COM.eBiz.Framework.Data;
//using COM.eBiz.Framework.Lib;


namespace Smart_FTY
{
    public partial class FRM_ROLL_TALLY_SHEET : SampleFrm1
    {
        #region Declare
        int iNumRow = 0;
        
        DataTable dt_Daily_Report = null;
        Thread th;
        int _time = 0;
		int cnt_load = 0;
        
        private int idx_form;
        #endregion

        #region Creation
        public FRM_ROLL_TALLY_SHEET(int arg_idx = 0)
        {
            InitializeComponent();
            idx_form = arg_idx;
        }

        int indexScreen;
        int int_count = 0;
        string str_op = "";
        public FRM_ROLL_TALLY_SHEET(string title, int _indexScreen)
        {
            InitializeComponent();
            indexScreen = _indexScreen;
        }

        #endregion

        #region Method

        private void nextForm()
        {

            //Application.Run(new MaterialSetRate.IPP_MACHINE_LAYOUT());
        }
        private void previousForm()
        {

            //Application.Run(new MaterialSetRate.Frm_Mold_WS_Change_By_Shift());
        }
        #endregion

        private void FORM_WORK_TALLY_SHEET_Load(object sender, EventArgs e)
        {
            try{
                //Com_Base.Functions.Form_Maximized(this, int.Parse(Com_Base.Variables.Form[idx_form]["monitor"]));
                GoFullscreen(true);
                
                //lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
           
				//panel1.BackColor = Color.FromArgb(255, 165, 0);
				//this.lblDate.BackColor = Color.FromArgb(255, 165,0);
				//panel1.BackColor = Color.DarkOrange;
				//this.lblDate.BackColor = Color.DarkOrange;
                DataTable dt = null;
                dt = SELECT_ASSY_DATE();
                if (dt != null && dt.Rows.Count > 0)
                {
                    lblWrkDate.Text = dt.Rows[0]["TODATE"].ToString();
                    lblAssyDate.Text = dt.Rows[0]["ASSY_DATE"].ToString();
                }
                else
                {
                    lblAssyDate.Text = "";
                    lblWrkDate.Text = "";
                }
       
              
                axfDailyReport_Header.Visible = false;
            
                
                lblWrkDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                lblAssyDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                timer2.Interval = 1000;
                timer2.Start();
                timer1.Interval = 1000;
                timer1.Start();
 
              
            }
            catch (System.Exception ex)
            {
               
            }

        }
        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }
      
        private Color SetColorGrid(string strValue)
        {           
            try
            {         
                switch (strValue)
                {
                    case "RED" :
                        return Color.Red;
                        break;
                    case "WHITE":
                        return Color.White;
                        break;
                    case "YELLOW":
                        return Color.Yellow;
                        break;
                    case "GREEN":
                        return Color.Green;
                        break;
                    case "BLUE":
                        return Color.Blue;
                        break;
                    case  "DodgerBlue":
                        return Color.DodgerBlue;
                        break;

                    case "BLACK":
                        return Color.Black;
                        break;
                    case "TOTAL_COL":
                        return Color.FromArgb(255,255,196) ;
                        break;
                }
                return Color.White;
                 
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                return Color.Red;
            }
        }
        private Color getColor(string strValue)
        {

            try
            {
                if (strValue.Trim().Equals(""))
                    return Color.Red;

                string[] s = strValue.Split('/');

                if (s[0].ToString().Trim() == s[1].ToString().Trim())
                {
                    return Color.SeaGreen;
                }
                return Color.SkyBlue;
            }
            catch (Exception ex)
            {
                
                //MessageBox.Show(ex.ToString());
                return Color.Red;
            }
        }

        private void menu1_Load(object sender, EventArgs e)
        {

        }

        private void menu1_buttonClicked()
        {

        }

        private void Search_Daily_Report(string arg_op)
        {
            try
            { 
              
                DataTable dt = null;
                dt = SELECT_ASSY_DATE();
                if (dt != null && dt.Rows.Count > 0)
                {
                    lblWrkDate.Text = dt.Rows[0]["TODATE"].ToString();
                    lblAssyDate.Text = dt.Rows[0]["ASSY_DATE"].ToString();
					axfpSpread.SetText(3, 1, "Shift 1 ( 06:00- 14:00 )"); //(" + dt.Rows[0]["YESTERDAY"].ToString() +")");
					axfpSpread.SetText(13, 1, "Shift 2 ( 14:00- 22:00 )");// (" + dt.Rows[0]["TODAY"].ToString() + ")");
					axfpSpread.SetText(23, 1, "Shift 3 ( 22:00- 06:00 )");// (" + dt.Rows[0]["TODAY"].ToString() + ")");
                }
                else
                {
                    lblAssyDate.Text = "";
                    lblWrkDate.Text = "";
                }

                dt = null;
                dt = SELECT_WORK_TALLY_SHEET(arg_op);
                if (dt != null & dt.Rows.Count > 1)
                {
                    iNumRow = dt.Rows.Count;
                    dt_Daily_Report = dt;

                    axfpSpread.Visible = false;
                    axfDailyReport_Header.Visible = false;
                  

                    if (dt_Daily_Report != null && dt_Daily_Report.Rows.Count > 1)
                    {
                        for (int i = 0; i < dt_Daily_Report.Rows.Count; i++)
                        {
                            axfpSpread.Row = i + 3;
                            //axfpSpread.set_RowHeight(i + 3, 40.0);
                            axfpSpread.set_RowHeight(i + 3, 36);
                            if (i != dt_Daily_Report.Rows.Count - 1)
                            {
                                this.axfpSpread.SetText(1, i + 3, dt_Daily_Report.Rows[i]["MC"].ToString());
                            }

                            this.axfpSpread.SetText(2, i + 3, dt_Daily_Report.Rows[i]["MCS_NAME"].ToString());


                            this.axfpSpread.SetText(3, i + 3, dt_Daily_Report.Rows[i]["S1H1"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 3;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S1H1_COLOR"].ToString());

                            this.axfpSpread.SetText(4, i + 3, dt_Daily_Report.Rows[i]["S1H2"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 4;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S1H2_COLOR"].ToString());

                            this.axfpSpread.SetText(5, i + 3, dt_Daily_Report.Rows[i]["S1H3"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 5;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S1H3_COLOR"].ToString());

                            this.axfpSpread.SetText(6, i + 3, dt_Daily_Report.Rows[i]["S1H4"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 6;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S1H4_COLOR"].ToString());

                            this.axfpSpread.SetText(7, i + 3, dt_Daily_Report.Rows[i]["S1H5"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 7;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S1H5_COLOR"].ToString());

                            this.axfpSpread.SetText(8, i + 3, dt_Daily_Report.Rows[i]["S1H6"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 8;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S1H6_COLOR"].ToString());

                            this.axfpSpread.SetText(9, i + 3, dt_Daily_Report.Rows[i]["S1H7"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 9;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S1H7_COLOR"].ToString());

                            this.axfpSpread.SetText(10, i + 3, dt_Daily_Report.Rows[i]["S1H8"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 10;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S1H8_COLOR"].ToString());


                            this.axfpSpread.SetText(11, i + 3, dt_Daily_Report.Rows[i]["S1_TOTAL"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 11;
                            axfpSpread.BackColor = SetColorGrid("TOTAL_COL");

                            this.axfpSpread.SetText(12, i + 3, "");
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 12;
                            axfpSpread.BackColor = SetColorGrid("BLACK");

                            this.axfpSpread.SetText(13, i + 3, dt_Daily_Report.Rows[i]["S2H1"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 13;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S2H1_COLOR"].ToString());

                            this.axfpSpread.SetText(14, i + 3, dt_Daily_Report.Rows[i]["S2H2"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 14;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S2H2_COLOR"].ToString());

                            this.axfpSpread.SetText(15, i + 3, dt_Daily_Report.Rows[i]["S2H3"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 15;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S2H3_COLOR"].ToString());

                            this.axfpSpread.SetText(16, i + 3, dt_Daily_Report.Rows[i]["S2H4"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 16;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S2H4_COLOR"].ToString());

                            this.axfpSpread.SetText(17, i + 3, dt_Daily_Report.Rows[i]["S2H5"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 17;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S2H5_COLOR"].ToString());

                            this.axfpSpread.SetText(18, i + 3, dt_Daily_Report.Rows[i]["S2H6"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 18;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S2H6_COLOR"].ToString());

                            this.axfpSpread.SetText(19, i + 3, dt_Daily_Report.Rows[i]["S2H7"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 19;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S2H7_COLOR"].ToString());

                            this.axfpSpread.SetText(20, i + 3, dt_Daily_Report.Rows[i]["S2H8"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 20;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S2H8_COLOR"].ToString());


                            this.axfpSpread.SetText(21, i + 3, dt_Daily_Report.Rows[i]["S2_TOTAL"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 21;
                            axfpSpread.BackColor = SetColorGrid("TOTAL_COL");

                            this.axfpSpread.SetText(22, i + 3, "");
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 22;
                            axfpSpread.BackColor = SetColorGrid("BLACK");


                            this.axfpSpread.SetText(23, i + 3, dt_Daily_Report.Rows[i]["S3H1"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 23;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S3H1_COLOR"].ToString());

                            this.axfpSpread.SetText(24, i + 3, dt_Daily_Report.Rows[i]["S3H2"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 24;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S3H2_COLOR"].ToString());

                            this.axfpSpread.SetText(25, i + 3, dt_Daily_Report.Rows[i]["S3H3"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 25;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S3H3_COLOR"].ToString());

                            this.axfpSpread.SetText(26, i + 3, dt_Daily_Report.Rows[i]["S3H4"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 26;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S3H4_COLOR"].ToString());


                            this.axfpSpread.SetText(27, i + 3, dt_Daily_Report.Rows[i]["S3H5"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 27;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S3H5_COLOR"].ToString());

                            this.axfpSpread.SetText(28, i + 3, dt_Daily_Report.Rows[i]["S3H6"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 28;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S3H6_COLOR"].ToString());

                            this.axfpSpread.SetText(29, i + 3, dt_Daily_Report.Rows[i]["S3H7"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 29;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S3H7_COLOR"].ToString());

                            this.axfpSpread.SetText(30, i + 3, dt_Daily_Report.Rows[i]["S3H8"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 30;
                            axfpSpread.BackColor = SetColorGrid(dt_Daily_Report.Rows[i]["S3H8_COLOR"].ToString());

                            this.axfpSpread.SetText(31, i + 3, dt_Daily_Report.Rows[i]["S3_TOTAL"].ToString());
                            axfpSpread.Row = i + 3;
                            axfpSpread.Col = 31;
                            axfpSpread.BackColor = SetColorGrid("TOTAL_COL");
                   
                            

                        }
                        
                        //if (getCurrentHHLocation() != 0)
                        //{

                        //    this.panel2.Location = new System.Drawing.Point(getCurrentHHLocation(), 340);
                        //    //this.panel2.Location = new System.Drawing.Point(242, 268);
                        //    panel2.Size = new Size(75, 905);
                        //    panel2.Refresh();
                        //}
                        string[] s = new string[2];
                        int iElement1 = 0;
                        int iElement2 = 0;
                        double dPlan  = 0;
                        double dWeight = 0;
                        char[] delimiterChars = {  '/' };
                        s = dt.Rows[dt.Rows.Count - 1]["S2_TOTAL"].ToString().Split(delimiterChars);
                        if (s.Length > 1)
                        {
                            iElement2 = 1;
                        }
                        else
                        {
                            iElement2 = 0;
                        }

                        dWeight = dWeight + Convert.ToDouble(s[iElement1].ToString());
                        dPlan = dPlan + Convert.ToDouble(s[iElement2].ToString());
                        lblS2Weight.Text = s[iElement1].ToString();
                        lblS2Plan.Text = s[iElement2].ToString();
                        if (Convert.ToDouble(s[iElement2].ToString()) == 0)
                        {
                            lblS2Rate.Text = "0";
                        }
                        else
                        {
                            lblS2Rate.Text = Math.Round(Convert.ToDouble(s[iElement1].ToString()) / Convert.ToDouble(s[iElement2].ToString()) * 100, 1).ToString();
                        }

                        s = null;
                        s = dt.Rows[dt.Rows.Count - 1]["S3_TOTAL"].ToString().Split(delimiterChars);
                        if (s.Length> 1)
                        {
                            iElement2 = 1;
                        }
                        else
                        {
                            iElement2 = 0;
                        }
                        lblS3Plan.Text = s[iElement2].ToString();
                        lblS3Weight.Text = s[iElement1].ToString();
                        dWeight = dWeight + Convert.ToDouble(s[iElement1].ToString());
                        dPlan = dPlan + Convert.ToDouble(s[iElement2].ToString());
                        if (Convert.ToDouble(s[iElement2].ToString()) == 0)
                        {
                            lblS3Rate.Text = "0";

                        } else
                        {
                            lblS3Rate.Text = Math.Round(Convert.ToDouble(s[iElement1].ToString()) / Convert.ToDouble(s[iElement2].ToString()) * 100, 1).ToString();
                        }

                        s = null;
                        s = dt.Rows[dt.Rows.Count - 1]["S1_TOTAL"].ToString().Split(delimiterChars);
                        if (s.Length > 1)
                        {
                            iElement2 = 1;
                        }
                        else
                        {
                            iElement2 = 0;
                        }
                        lblS1Plan.Text = s[iElement2].ToString();
                        lblS1Weight.Text = s[iElement1].ToString();
                        dWeight = dWeight + Convert.ToDouble(s[iElement1].ToString());
                        dPlan = dPlan + Convert.ToDouble(s[iElement2].ToString());
                        if (Convert.ToDouble(s[iElement2].ToString()) == 0)
                        {
                            lblS1Rate.Text = "0";
                        }
                        else
                        {
                            lblS1Rate.Text = Math.Round(Convert.ToDouble(s[iElement1].ToString()) / Convert.ToDouble(s[iElement2].ToString()) * 100, 1).ToString();
                        }

                        lblPlan.Text = dPlan.ToString();
                        lblWeight.Text = dWeight.ToString();
                        lblRate.Text = Math.Round(dWeight/dPlan*100,2).ToString() ;

                        for (int i = dt.Rows.Count + 3; i < axfpSpread.MaxRows + 1; i++)
                        {
                            axfpSpread.set_RowHeight(i, 0);
                        }
                        MergeCol(axfpSpread, 3, 1);
                        MergeCol(axfpSpread, 3, 2);
                        panel2.Visible = false;
                        //showAnimation(axfpSpread);
                        panel2.Visible = true;
                        if (getCurrentHHLocation() != 0)
                        {

                            this.panel2.Location = new System.Drawing.Point(getCurrentHHLocation(), 330);
							//this.panel2.Location = new System.Drawing.Point(238, 268);
                            panel2.Size = new Size(75, 905);
                            panel2.Refresh();
                            panel2.BringToFront();
                        }
                    }
                    else
                    {
                        //for (int i = dt.Rows.Count + 3; i < axfDailyReport.MaxRows + 1; i++)
                        //{
                        //    axfDailyReport.set_RowHeight(i, 0);
                        //}
                    }
                }
                else
                {

                    axfDailyReport_Header.Visible = true;
                    //axfDailyReport.Visible = false;

                    for (int i = 3; i <= axfpSpread.MaxRows; i++)
                    {
                        axfpSpread.set_RowHeight(i, 0);
                    }
               
                    iNumRow = 0;
                    if (getCurrentHHLocation() != 0)
                    {

                        this.panel2.Location = new System.Drawing.Point(getCurrentHHLocation(), 330);
                        panel2.Size = new Size(75, 905);
                        panel2.Refresh();
                    }

                }
                axfpSpread.Visible = true;
                
              
            }
            catch (Exception ex)
            {

            }

        }
        private int getCurrentHH ()
        {
            string sHH = "";
            sHH = DateTime.Now.ToString("HH");
            try
            {
                switch (sHH)
                {
                    case "14":
                        return 10;
                        break;
                    case "15":
                        return 10;
                        break;
                    case "16":
                        return 11;
                        break;         
                    case "17":
                        return 11;
                        break;
                    case "18":
                        return 12;
                        break;
                    case "19":
                        return 12;
                        break;
                    case "20":
                        return 13;
                        break;
                    case "21":
                        return 13;
                        break;
                    case "22":
                        return 15;
                        break;
                    case "23":
                        return 15;
                        break;
                    case "00":
                        return 16;
                        break;
                    case "01":
                        return 16;
                        break;
                    case "02":
                        return 17;
                        break;
                    case "03":
                        return 17;
                        break;
                    case "04":
                        return 18;
                        break;
                    case "05":
                        return 18;
                        break;
                    case "06":
                        return 20;
                        break;
                    case "07":
                        return 20;
                        break;

                    case "08":
                        return 21;
                        break;
                    case "09":
                        return 21;
                        break;
                    case "10":
                        return 22;
                        break;
                    case "11":
                        return 22;
                        break;
                    case "12":
                        return 23;
                        break;
                    case "13":
                        return 23;
                        break;
                }
                return 0;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                return 0;
            }
            return 0;
        }

        private int getCurrentHHLocation()
        {
            string sHH = "";
            sHH = DateTime.Now.ToString("HH");
            try
            {
                switch (sHH)
                {
                    case "06":
                        return 238;
                        break;
                    case "07":
                        return 299;
                        break;
                    case "08":
                        return 360;
                        break;
                    case "09":
                        return 421;
                        break;
                    case "10":
                        return 482;
                        break;
                    case "11":
                        return 541;
                        break;
                    case "12":
                        return 602;
                        break;
                    case "13":
						return 664;
                        break;
                    case "14":
                        return 794;
                        break;
                    case "15":
						return 855;
                        break;
                    case "16":
						return 917;
                        break;
                    case "17":
						return 977;
                        break;
                    case "18":
						return 1039;
                        break;
                    case "19":
						return 1100;
                        break;
                    case "20":
						return 1161;
                        break;
                    case "21":
						return 1222;
                        break;
                    case "22":
						return 1352;
                        break;
                    case "23":
						return 1412;
                        break;
                    case "00":
						return 1474;
                        break;
                    case "01":
						return 1534;
                        break;
                    case "02":
						return 1596;
                        break;
                    case "03":
						return 1657;
                        break;
                    case "04":
                        return 1718;
                        break;
                    case "05":
                        return 1779;
                        break;
                }
                return 0;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                return 0;
            }
            return 0;
        }
        
        private DataTable SELECT_WORK_TALLY_SHEET(string arg_op) 
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "MES.PKG_SFC_ROLL_SO.SELECT_ROLL_TALLY_SHEET";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "ARG_OP_CD";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC

            MyOraDB.Parameter_Type[0] = (int)OracleType.NVarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_op;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }


        private DataTable SELECT_ASSY_DATE()
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "MES.PKG_SFC_ROLL_SO.SELECT_ASSY_DATE";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "ARG_OP_CD";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC
            MyOraDB.Parameter_Type[0] = (int)OracleType.NVarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = "OS";
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }
        
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                sTemp1 = gridObject.Value;
                for (int i = iStartRow; i < gridObject.MaxRows + 4; i++)
                {
                    gridObject.Row = i;
                    gridObject.Col = iCol;
                    sTemp2 = gridObject.Value;
                    if (sTemp1 != sTemp2)
                    {
                        gridObject.AddCellSpan(iCol, iRow, 1, i - iRow);
                        sTemp1 = sTemp2;
                        sTemp2 = "";
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
        private void timer2_Tick(object sender, EventArgs e)
        {              
			cnt_load++;
			if (cnt_load >= 30)
			{
                Search_Daily_Report(str_op);
				cnt_load = 0;
			}
           
        }

        private void FORM_WORK_TALLY_SHEET_FormClosing(object sender, FormClosingEventArgs e)
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
                
        private void panel2_Paint(object sender, PaintEventArgs e)
        {         
               Size size = new Size(58, iNumRow*52 + 52);
              // Size size = new Size(58, 5 * 57 + 49);
                System.Drawing.Point location = new System.Drawing.Point(10, 20 + 50 * 0);               
                Pen pen = new Pen(Color.Blue, 5);
                e.Graphics.DrawRectangle(pen, new System.Drawing.Rectangle(location, size));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {			
        }

		private void FORM_WORK_TALLY_SHEET_VisibleChanged(object sender, EventArgs e)
		{
			if (this.Visible)
			{
				try
				{
                    //Util.Animate(axfpSpread, Util.Effect.Slide, 1, 180);
                    timer2.Start();
                    lblRubber_Click(sender, e);

				}
				catch (Exception)
				{

				}
			}
			else
			{
				timer2.Stop();
                cnt_load = 0;
			}
		}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblRubber_Click(object sender, EventArgs e)
        {            
            str_op = "OS";
            
            Search_Daily_Report(str_op);
            lblTitle.Text = "Rubber Tallysheet";
            cnt_load = 0;
            //Util.Animate(axfpSpread, Util.Effect.Slide, 1, 180);
            pnRubber.GradientEndColor = Color.White;//Color.FromArgb(255, 128, 128);
            pnEVA.GradientEndColor = Color.Gray;
        }

        private void lblEVA_Click(object sender, EventArgs e)
        {           
            str_op = "EVA";
            
            Search_Daily_Report(str_op);
            lblTitle.Text = "EVA Tallysheet";
            cnt_load = 0;
            //Util.Animate(axfpSpread, Util.Effect.Slide, 1, 180);
            pnRubber.GradientEndColor = Color.Gray;//Color.FromArgb(255, 128, 128);
            pnEVA.GradientEndColor = Color.White;
        }
    }
}
