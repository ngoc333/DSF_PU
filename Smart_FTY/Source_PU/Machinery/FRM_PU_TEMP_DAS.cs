using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//using JPlatform.Client.Controls;


namespace Smart_FTY
{
    public partial class FRM_PU_TEMP_DAS : Form
    {
        public FRM_PU_TEMP_DAS()
        {
            InitializeComponent();
        }

        public FRM_PU_TEMP_DAS(string strmc)
        {
            InitializeComponent();
            if (strmc != "000")
            {
                _mc = strmc;
                cboMC.Visible = false;
                flag = false;
            }
            else
            {
                cboMC.Visible = true;
                flag = true;
            }
        }

        int cnt = 0;
        string str_op = "";
        bool flag = false;
        public string _mc = "000";

        private void FRM_ROLL_SLABTEST_MON_Load(object sender, EventArgs e)
        {                     
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            dt_ymd.EditValue = DateTime.Now;
            if (_mc == "000")
            {
                loadcbo("");                
            }
            else
            {
            }               
        }

        #region UserControl
        //================1==========================================================      

        #endregion

        public DataTable SEL_DATA_CTM_TEMP(string Qtype, string arg_op, string arg_mc)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_B2.SP_PU_TEMP"; //SP_SMT_ANDON_DAILY

                MyOraDB.ReDim_Parameter(5);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "V_P_TYPE";
                MyOraDB.Parameter_Name[1] = "V_P_YMD";
                MyOraDB.Parameter_Name[2] = "V_P_OP";
                MyOraDB.Parameter_Name[3] = "V_P_MC";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
               

                MyOraDB.Parameter_Values[0] = Qtype;
                MyOraDB.Parameter_Values[1] = dt_ymd.DateTime.ToString("yyyyMMdd");
                MyOraDB.Parameter_Values[2] = arg_op;
                MyOraDB.Parameter_Values[3] = arg_mc;
                MyOraDB.Parameter_Values[4] = "";


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

        //public DataTable SEL_DATA_TEMP_STOP(string Qtype, string arg_op, string arg_mc)
        //{
        //    COM.OraDB MyOraDB = new COM.OraDB();
        //    DataSet ds_ret;
        //    try
        //    {
        //        string process_name = "MES.PKG_SMT_B2.SP_PU_TEMP"; //SP_SMT_ANDON_DAILY

        //        MyOraDB.ReDim_Parameter(5);
        //        MyOraDB.Process_Name = process_name;

        //        MyOraDB.Parameter_Name[0] = "V_P_TYPE";
        //        MyOraDB.Parameter_Name[1] = "V_P_YMD";
        //        MyOraDB.Parameter_Name[2] = "V_P_OP";
        //        MyOraDB.Parameter_Name[3] = "V_P_MC";
        //        MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

        //        MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;


        //        MyOraDB.Parameter_Values[0] = Qtype;
        //        MyOraDB.Parameter_Values[1] = dt_ymd.DateTime.ToString("yyyyMMdd");
        //        MyOraDB.Parameter_Values[2] = arg_op;
        //        MyOraDB.Parameter_Values[3] = arg_mc;
        //        MyOraDB.Parameter_Values[4] = "";


        //        MyOraDB.Add_Select_Parameter(true);
        //        ds_ret = MyOraDB.Exe_Select_Procedure();

        //        if (ds_ret == null) return null;
        //        return ds_ret.Tables[process_name];
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        private void loadcbo(string arg_op)
        {
            try
            {
                DataTable dt_mc = null;
                dt_mc = SEL_DATA_CTM_TEMP("C2", "PUP", "");
                
                if (dt_mc != null && dt_mc.Rows.Count > 0)
                {
                    cboMC.Properties.DataSource = dt_mc;
                    //cboMC.Properties.Columns[0].Visible = false;
                    cboMC.Properties.ValueMember = "CODE";
                    cboMC.Properties.DisplayMember = "NAME";
                    cboMC.ItemIndex = 0;
                    cboMC.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(cboMC.Properties.DisplayMember));
                }
            }
            catch
            {

            }
        }

        public void LOAD_DATA()
        {
            try
            {
                tblMain.Visible = false;
                creat_layout_new();
                Bindingdata();
                tblMain.Visible = true;
            }
            catch
            {
                tblMain.Visible = true;
            }
        }

        private void Bindingdata()
        {
            try
            {
                DataTable dtsource = null, dt_stop = null, dtstand = null;
                UC.UC_Temp_PU_AUTO uc_info;
                UC.UC_Temp_PU_MANUAL uc_info2;
                //UC.UC_Temp_PU_SPRAY uc_info3;
                if (_mc == "000") return;
                dtsource = SEL_DATA_CTM_TEMP("Q2", "PUP", _mc);
                dt_stop = SEL_DATA_CTM_TEMP("CHECK", "PUP", _mc);
                dtstand = SEL_DATA_CTM_TEMP("STAND", "PUP", _mc);
                if (!_mc.Contains("S"))
                {
                    if (dtsource != null && dtsource.Rows.Count > 0)
                    {
                        for (int x = 0; x < 3; x++)
                        {
                            if (Convert.ToInt32(_mc) < 4)
                            {
                                uc_info = (UC.UC_Temp_PU_AUTO)tblMain.GetControlFromPosition(0, x);
                                uc_info.Bindingdata(dtsource, x + 1, dt_stop, dtstand);
                            }
                            else
                            {
                                uc_info2 = (UC.UC_Temp_PU_MANUAL)tblMain.GetControlFromPosition(0, x);
                                uc_info2.Bindingdata(dtsource, x + 1, dt_stop, dtstand);
                            }
                        }

                    }
                    else
                    {
                        for (int x = 0; x < 3; x++)
                        {
                            if (Convert.ToInt32(_mc) < 4)
                            {
                                uc_info = (UC.UC_Temp_PU_AUTO)tblMain.GetControlFromPosition(0, x);
                                uc_info.Bindingdata(dtsource, x + 1, dt_stop, dtstand);
                            }
                            else
                            {
                                uc_info2 = (UC.UC_Temp_PU_MANUAL)tblMain.GetControlFromPosition(0, x);
                                uc_info2.Bindingdata(dtsource, x + 1, dt_stop, dtstand);
                            }

                        }

                    }
                }
                else
                {
                    //if (dtsource != null && dtsource.Rows.Count > 0)
                    //{
                    //    for (int x = 0; x < 5; x++)
                    //    {
                    //        uc_info3 = (UC.UC_Temp_PU_SPRAY)tblMain.GetControlFromPosition(0, x);
                    //        uc_info3.Bindingdata(dtsource, x + 1);
                    //    }
                    //}
                    //else
                    //{
                    //    for (int x = 0; x < 5; x++)
                    //    {
                    //        uc_info3 = (UC.UC_Temp_PU_SPRAY)tblMain.GetControlFromPosition(0, x);
                    //        uc_info3.Bindingdata(dtsource, x + 1);
                    //    }
                    //}
                }
                tblMain.Padding = new Padding(0, 0, System.Windows.Forms.SystemInformation.VerticalScrollBarWidth, 0);
            }
            catch
            {
            }
        }       

        private void creat_layout_new()
        {
            try
            {
                tblMain.Visible = false;
                tblMain = new TableLayoutPanel();
                panel1.Controls.Clear();
                panel1.Controls.Add(tblMain);
                tblMain.Hide();
                tblMain.Controls.Clear();
                tblMain.RowStyles.Clear();
                tblMain.ColumnStyles.Clear();
                tblMain.AutoScroll = true;
                tblMain.AutoSize = true;
                tblMain.ColumnCount = 1;
               
                tblMain.Dock = DockStyle.Fill;
                if (!_mc.Contains("S"))
                {
                    tblMain.RowCount = 3;
                    for (int x = 0; x < 3; x++)
                    {
                        tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                        if (Convert.ToInt32(_mc) < 4)
                        {
                            UC.UC_Temp_PU_AUTO uc_info = new UC.UC_Temp_PU_AUTO();
                            tblMain.Controls.Add(uc_info, 0, x);
                            uc_info.Dock = DockStyle.Fill;
                            uc_info.Bindingdata(null, x + 1, null, null);
                        }
                        else
                        {
                            UC.UC_Temp_PU_MANUAL uc_info = new UC.UC_Temp_PU_MANUAL();
                            tblMain.Controls.Add(uc_info, 0, x);
                            uc_info.Dock = DockStyle.Fill;
                            uc_info.Bindingdata(null, x + 1, null, null);
                        }
                    }
                }
                else
                {
                    //tblMain.RowCount = 5;
                    //for (int x = 0; x < 5; x++)
                    //{
                    //    tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                    //    UC.UC_Temp_PU_SPRAY uc_info = new UC.UC_Temp_PU_SPRAY();
                    //    tblMain.Controls.Add(uc_info, 0, x);
                    //    uc_info.Dock = DockStyle.Fill;
                    //    uc_info.Bindingdata(null, x + 1);
                    //}
                }
            }
            catch
            {
            }
            finally
            {
                tblMain.Show();
            }           
        }              

        private void gvwView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.ColumnHandle == 4 || e.Column.ColumnHandle == 7 || e.Column.ColumnHandle == 10 || e.Column.ColumnHandle == 13)
            {
                e.Appearance.BackColor = Color.FromArgb(255, 255, 192);
                e.Appearance.ForeColor = Color.Black;
                e.Appearance.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Regular);
            }
            else
            {
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
            if (cnt < 40)
            {
                cnt++;                
            }
            else
            {
                cnt = 0;
                Bindingdata();             
            }
        }

        private void FRM_ROLL_SLABTEST_MON_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {                    
                    timer1.Start();
                    cnt = 0;                    
                }
                else
                    timer1.Stop();
            }
            catch
            {
                //throw EX;
            }
        }

        private void dt_ymd_EditValueChanged(object sender, EventArgs e)
        {
            LOAD_DATA();
        }

        private void cboMC_EditValueChanged(object sender, EventArgs e)
        {
            if (cboMC != null && flag == true)
            {
                _mc = cboMC.EditValue.ToString();
                LOAD_DATA();
            }
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

     
    }
}
