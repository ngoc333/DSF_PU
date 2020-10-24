using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.IO;
using System.Reflection;

namespace Smart_FTY.UC
{
    public partial class UC_GRID_PERFORMANCE_DASHBOARD : UserControl
    {
        public UC_GRID_PERFORMANCE_DASHBOARD()
        {
            InitializeComponent();
        }
        string _TITLE = null;
        public UC_GRID_PERFORMANCE_DASHBOARD(string TITLE)
        {
            InitializeComponent();
            lblTitile.Text = TITLE;
            _TITLE = TITLE;
        }


        private DataTable SP_SMT_PERFORMANCE(string ARG_QTYPE, string ARG_LINE_CD, string ARG_MLINE_CD)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_PHUOC.SP_SMT_PERFORMANCE";

                MyOraDB.ReDim_Parameter(4);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_QTYPE";
                MyOraDB.Parameter_Name[1] = "ARG_LINE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_MLINE_CD";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
              

                MyOraDB.Parameter_Values[0] = ARG_QTYPE;
                MyOraDB.Parameter_Values[1] = ARG_LINE_CD;
                MyOraDB.Parameter_Values[2] = ARG_MLINE_CD;
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

        private void ClearGird(string _title)
        {
            //string[] strHeader = null;
            //switch (_title)
            //{ 
            //    case "LEADTIME_FG":
            //    case "LEADTIME_WIP":
            //        strHeader = new string[] { "Q1", "TARGET", "ACTUAL", "Days" };
            //        break;
            //    default:
            //        strHeader = new string[] { "Q1", "TARGET", "ACTUAL", "RATIO (%)" };
            //        break;
            //}
           
            for (int iRow = 1; iRow <= axfpSpread1.MaxRows; iRow++)
            {
                for (int iCol = 1; iCol <= axfpSpread1.MaxCols; iCol++)
                {
                    if (iRow == 1)
                    { } //if (iCol -1 < axfpSpread1.MaxCols - 1)
                    //axfpSpread1.SetText(iCol, 1, strHeader[iCol -1]);
                    else
                        axfpSpread1.SetText(iCol, iRow, null);
                }
            }
        }
     
        public void BindingData(string _title,string line,string mline)
        {
            progressPanel1.Visible = true;
            string Smile = null, Normal = null, Sad = null;
            DataTable dt = null;
            dt = SP_SMT_PERFORMANCE("Q", line, mline);
           
            //Smile = Application.StartupPath + "\\smile\\ok.jpg";
            //Normal = Application.StartupPath + "\\smile\\Normal.jpg";
            //Sad = Application.StartupPath + "\\smile\\Cry.jpg";

            Smile = Application.StartupPath + "\\smile\\ok.png";
            Normal = Application.StartupPath + "\\smile\\Normal.png";
            Sad = Application.StartupPath + "\\smile\\Cry.png";

            ClearGird(_title);
            try
            {

                string[] Arr_Smile = new string[] { Sad, Normal, Smile };
                dt = SP_SMT_PERFORMANCE(_title, line, mline);
                //switch (_title)
                //{
                //    case "PRODUCTION":
                //        dt = SP_SMT_PERFORMANCE("PRODUCTION", line, mline);
                //        break;
                //    case "PRODUCTIVITY":
                //       // dt = DS.Tables[1];
                //        dt = SP_SMT_PERFORMANCE("PRODUCTIVITY", line, mline);
                //        break;
                //    case "Internal Defective Return":
                //       // dt = DS.Tables[2];
                //        dt = SP_SMT_PERFORMANCE("INTERNAL", line, mline);
                //        break;
                //    case "External Defective Return":
                //        //dt = DS.Tables[3];
                //        dt = SP_SMT_PERFORMANCE("EXTERNAL", line, mline);
                //        break;
                //    case "BTS":
                //       // dt = DS.Tables[4];
                //        dt = SP_SMT_PERFORMANCE("BTS", line, mline);
                //        break;
                //    case "LEADTIME_FG":
                //        //dt = DS.Tables[5];
                //        dt = SP_SMT_PERFORMANCE("LEADTIME", line, mline);
                //        break;
                //    case "DOWNTIME":
                //       // dt = DS.Tables[6];
                //        dt = SP_SMT_PERFORMANCE("DOWNTIME", line, mline);
                //        break;
                //    case "ABSENT":
                //        //dt = DS.Tables[7];
                //        dt = SP_SMT_PERFORMANCE("ABSENT", line, mline);
                //        break;
                //    case "TURNOVER":
                //       // dt = DS.Tables[8];
                //        dt = SP_SMT_PERFORMANCE("TURNOVER", line, mline);
                //        break;
               //}
                if (dt != null && dt.Rows.Count > 0)
                {
                    axfpSpread1.SetText(1, 1, dt.Rows[0]["QUARTER"].ToString());
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        axfpSpread1.SetText(1, i + 2, dt.Rows[i]["YM"].ToString());
                        axfpSpread1.SetText(2, i + 2, dt.Rows[i]["TAR"].ToString());
                        axfpSpread1.SetText(3, i + 2, dt.Rows[i]["ACT"].ToString());
                        axfpSpread1.SetText(4, i + 2, dt.Rows[i]["RATE"].ToString());
                        
                        switch (dt.Rows[i]["SMILE"].ToString())
                        {
                            case "R":
                                LoadSmile(i + 2, axfpSpread1.MaxCols, Arr_Smile[0]);
                                break;
                            case "Y":
                                LoadSmile(i + 2, axfpSpread1.MaxCols, Arr_Smile[1]);
                                break;
                            case "G":
                                LoadSmile(i + 2, axfpSpread1.MaxCols, Arr_Smile[2]);
                                break;
                        }

                    }
                }
                progressPanel1.Visible = false;
            }
            catch 
            {
                progressPanel1.Visible = false;
                //throw ex;
               // MessageBox.Show("Binding Data Error: " + ex);
            }

        }

        private void LoadSmile(int Row, int Col, string Picture)
        {
            axfpSpread1.Row = Row;
            axfpSpread1.Col = Col;
            axfpSpread1.CellType = FPSpreadADO.CellTypeConstants.CellTypePicture;
            axfpSpread1.TypePictPicture = axfpSpread1.LoadPicture(Picture, FPSpreadADO.PictureTypeConstants.PictureTypeJPEG);
            axfpSpread1.TypePictStretch = true;
            //axfpSpread1.TypePictCenter = true;
        }
    }
}
