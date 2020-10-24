using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Collections.Generic;

namespace Smart_FTY
{
    public partial class UCGrid : UserControl
    {
        public UCGrid( string argForm)
        {
            InitializeComponent();
            tmrLoad.Interval = 40000;
            _TypeForm = argForm;
            setData();
        }
        string _TypeForm;

        private void setData()
        {
            try
            {
                DataTable dtsource = SEL_DATA_PROD_DAILY("Q", "PHP");
                if (dtsource == null || dtsource.Rows.Count == 0) return;
                switch (_TypeForm)
                {
                    case "A1":
                        dataGrid(dtsource, "STT >= '001' and STT <= '009'", 1, 9);
                        break;
                    case "A2":
                        dataGrid(dtsource, "STT >= '010' and STT <= '018'", 10, 18);
                        break;
                    case "B1":
                        dataGrid(dtsource, "STT >= '013' and STT <= '021'", 13, 21);
                        break;
                    case "B2":
                        dataGrid(dtsource, "STT >= '022' and STT <= '030'", 22, 30);
                        break;
                    case "C1":
                        dataGrid(dtsource, "STT >= '027' and STT <= '035'", 27, 35);
                        break;
                    case "C2":
                        dataGrid(dtsource, "STT >= '036' and STT <= '044'", 36, 44);
                        break;
                }
            }
            catch 
            {}
            
        }

        private void dataGrid(DataTable argDt, string argSelect, int argStart, int argEnd)
        {
            try
            {
                if (argDt != null && argDt.Rows.Count > 0)
                {
                    Dictionary<string, int> dicCol = new Dictionary<string, int>();
                    axGrid.MaxCols = argEnd - argStart + 2;
                    //Set Header Line Grid
                    for (int i = 0; i <= argEnd - argStart; i++)
                    {
                        axGrid.SetText(i + 2, 1, (argStart + i).ToString());
                        dicCol.Add((argStart + i).ToString("000"), i + 2);
                    }


                    List<int> ls = new List<int>();
                    DataTable dt = argDt.Select(argSelect + " and STT <> '000'", "STT ASC").CopyToDataTable();
                    if (dt == null || dt.Rows.Count == 0) return;

                    double iPer;

                    //Set Data
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        axGrid.Col = dicCol[dt.Rows[i]["STT"].ToString()];
                        ls.Add(axGrid.Col);
                        axGrid.Row = 2;
                        axGrid.Text = dt.Rows[i]["TOT_PLAN"].ToString();
                        axGrid.Row = 3;
                        axGrid.Text = dt.Rows[i]["TOT_RPLAN"].ToString();
                        axGrid.Row = 4;
                        axGrid.Text = dt.Rows[i]["TOT_ACT"].ToString();
                        axGrid.Row = 5;
                        axGrid.Text = dt.Rows[i]["TOT_RATE"].ToString();
                        double.TryParse(dt.Rows[i]["TOT_RATE"].ToString().Replace("%", ""), out iPer);
                        axGrid.SetCellBorder(dicCol[dt.Rows[i]["STT"].ToString()], 5
                                            , dicCol[dt.Rows[i]["STT"].ToString()], 5
                                            , FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
                        if (iPer > 98)
                        {
                            axGrid.BackColor = Color.Green;
                            axGrid.ForeColor = Color.White;
                        }
                        else if (iPer >= 95)
                        {
                            axGrid.BackColor = Color.Yellow;
                            axGrid.ForeColor = Color.Black;
                        }
                        else
                        {
                            axGrid.BackColor = Color.Red;
                            axGrid.ForeColor = Color.White;
                        }
                    }

                    // Clear Col No Data
                    for (int i = 2; i < axGrid.MaxCols; i++)
                    {
                        if (!ls.Contains(i))
                        {
                            axGrid.Col = i;
                            for (int j = 2; j <= axGrid.MaxRows; j++)
                            {
                                axGrid.Row = j;
                                axGrid.Text = "";
                                axGrid.BackColor = Color.White;
                            }
                        }
                    }
                }
                else
                {
                    // Clear Col No Data
                    for (int i = 2; i < axGrid.MaxCols; i++)
                    {
                        
                            axGrid.Col = i;
                            for (int j = 2; j <= axGrid.MaxRows; j++)
                            {
                                axGrid.Row = j;
                                axGrid.Text = "";
                                axGrid.BackColor = Color.White;
                            }
                        
                    }
                }

            }
            catch 
            {}
            

        }


        #region DB
        public DataTable SEL_DATA_PROD_DAILY(string Qtype, string arg_op)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_B1.SP_PH_PROD_DAILY_NEW"; //SP_SMT_ANDON_DAILY

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "V_P_TYPE";
                MyOraDB.Parameter_Name[1] = "V_P_OP";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = Qtype;
                MyOraDB.Parameter_Values[1] = arg_op;
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
        #endregion DB



        private void button_MouseHover(object sender, EventArgs e)
        {
            Button cmd = (Button)sender;
            cmd.BackColor = Color.DarkOrange;
            cmd.ForeColor = Color.White;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button cmd = (Button)sender;
            cmd.BackColor = Color.RoyalBlue;
            cmd.ForeColor = Color.White;
        }

        private void cmdLine_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
        }

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            setData();
        }

        private void UCGrid_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                tmrLoad.Enabled = true;
            }
            else
                tmrLoad.Enabled = false;
        }
    }
}
