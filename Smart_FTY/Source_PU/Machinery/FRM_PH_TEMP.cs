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
    public partial class FRM_PH_TEMP : Form_Parent
    {
        public FRM_PH_TEMP()
        {
            InitializeComponent();
            
            
        }


        public FRM_PH_TEMP(string text)
        {
            InitializeComponent();
            this.Text = "Temp2";
            pnHeader.BackColor = Color.RoyalBlue;
            
        }
        int cnt = 0;
        string str_op = "";
        public string _frmLine, _toLine;

        private void FRM_ROLL_SLABTEST_MON_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "CTM Machine Temperature";
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            cmdDay.Visible = false;
        }

        #region UserControl
        //================1==========================================================
        UC.User_Chart uc_chart_1 = new UC.User_Chart();
        UC.User_Chart uc_chart_2 = new UC.User_Chart();
        UC.User_Chart uc_chart_3 = new UC.User_Chart();
        UC.User_Chart uc_chart_4 = new UC.User_Chart();
        UC.User_Chart uc_chart_5 = new UC.User_Chart();
        UC.User_Chart uc_chart_6 = new UC.User_Chart();
        UC.User_Chart uc_chart_7 = new UC.User_Chart();
        UC.User_Chart uc_chart_8 = new UC.User_Chart();
        UC.User_Chart uc_chart_9 = new UC.User_Chart();
        UC.User_Chart uc_chart_10 = new UC.User_Chart();

        #endregion

        public DataTable SEL_DATA_CTM_TEMP(string Qtype, string arg_op)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_B1.SP_PH_CTM_TEMP"; //SP_SMT_ANDON_DAILY

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

        private void loadcbo(string arg_op)
        {
            try
            {
                DataTable dt_mc = null;
                dt_mc = SEL_DATA_CTM_TEMP("C", arg_op);
                if (dt_mc != null && dt_mc.Rows.Count > 0)
                {
                    cboMC.DataSource = dt_mc;
                    cboMC.DisplayMember = "MC_NAME";
                    cboMC.ValueMember = "MC_CODE";                    
                }
            }
            catch
            {

            }
        }
        

        private void creat_layout_new(string arg_op, int mc_f, int mc_t)
        {
            tblMain.Hide();
            tblMain.Controls.Clear();
            tblMain.RowStyles.Clear();
            tblMain.ColumnStyles.Clear();
            tblMain.AutoScroll = true;
            tblMain.AutoSize = true;
                int t_row = 10;
                tblMain.ColumnCount = 2;
                tblMain.RowCount = t_row;
                DataTable dtsource = null;
                double d_min = 0;
                double d_max = 0;
                dtsource = SEL_DATA_CTM_TEMP("Q", arg_op);
                if (dtsource != null && dtsource.Rows.Count > 0)
                {
                    for (int x = 0; x < 2; x++)
                    {
                        tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                        //
                        //d_min = x == 0 ? Convert.ToDouble(dtsource.Rows[0]["MIN1"].ToString()) : Convert.ToDouble(dtsource.Rows[0]["MIN2"].ToString());
                        //d_max = x == 0 ? Convert.ToDouble(dtsource.Rows[0]["MAX1"].ToString()) : Convert.ToDouble(dtsource.Rows[0]["MAX2"].ToString());
                        for (int y = mc_f; y <= mc_t; y++)
                        {
                            UC.User_Chart uc_info = new UC.User_Chart();
                            tblMain.Controls.Add(uc_info, x, y);
                            uc_info.Dock = DockStyle.Fill;
                            uc_info.Bindingdata(dtsource.Select("MACHINE_CD = '" + y.ToString("000") + "'", "MACHINE_CD ASC, WORK_DATE ASC, HH ASC").CopyToDataTable(), x == 0 ? "H" : "C", y.ToString("000"));
                        }
                    }
                }

            //this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30));
            //tblMain.Controls.Add(uc_chart_1, 0, 0);
            //uc_chart_1.Dock = DockStyle.None;
            //uc_chart_1.Bindingdata(dt,"C");
            //tblMain.Controls.Add(uc_chart_2, 1, 0);
            //uc_chart_2.Dock = DockStyle.None;
            //uc_chart_2.Bindingdata(dt,"H");
            //tblMain.Controls.Add(uc_chart_3, 0, 1);
            //uc_chart_3.Dock = DockStyle.None;
            //uc_chart_3.Bindingdata(dt,"C");
            //tblMain.Controls.Add(uc_chart_4, 1, 1);
            //uc_chart_4.Dock = DockStyle.None;
            //uc_chart_4.Bindingdata(dt,"H");
            //tblMain.Controls.Add(uc_chart_5, 0, 2);
            //uc_chart_5.Dock = DockStyle.None;
            //uc_chart_5.Bindingdata(dt,"C");
            //tblMain.Controls.Add(uc_chart_6, 1, 2);
            //uc_chart_6.Dock = DockStyle.None;
            //uc_chart_6.Bindingdata(dt,"H");
            //tblMain.Controls.Add(uc_chart_7, 0, 3);
            //uc_chart_7.Dock = DockStyle.None;
            //uc_chart_7.Bindingdata(dt,"C");
            //tblMain.Controls.Add(uc_chart_8, 1, 3);
            //uc_chart_8.Dock = DockStyle.None;
            //uc_chart_8.Bindingdata(dt,"H");
            //tblMain.Controls.Add(uc_chart_9, 0, 4);
            //uc_chart_9.Dock = DockStyle.None;
            //uc_chart_9.Bindingdata(dt,"C");
            //tblMain.Controls.Add(uc_chart_10, 1, 4);
            //uc_chart_10.Dock = DockStyle.None;
            //uc_chart_10.Bindingdata(dt,"H");
            tblMain.Show();
        }

        private void creat_layout(string arg_op)
        {
            try
            {
                tblMain.Hide();
                tblMain.Controls.Clear();
                tblMain.RowStyles.Clear();
                tblMain.ColumnStyles.Clear();
                tblMain.AutoScroll = true;
                tblMain.AutoSize = true;

                DataTable dt_mc = null;
                dt_mc = SEL_DATA_CTM_TEMP("M", arg_op);
                if (dt_mc != null && dt_mc.Rows.Count > 0)
                {
                    int t_row = 10;
                    tblMain.ColumnCount = 2;
                    tblMain.RowCount = t_row;
                    DataTable dtsource = null;
                    double d_min = 0;
                    double d_max = 0;
                    dtsource = SEL_DATA_CTM_TEMP("Q", arg_op);
                    if (dtsource != null && dtsource.Rows.Count > 0)
                    {
                        for (int x = 0; x < 2; x++)
                        {
                            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                            //
                            for (int y = 0; y < dt_mc.Rows.Count; y++)
                            {                                
                                UC.User_Chart uc_info = new UC.User_Chart();
                                tblMain.Controls.Add(uc_info, x, y);
                                uc_info.Dock = DockStyle.Fill;
                                uc_info.Bindingdata(dtsource.Select("MACHINE_CD = '" + dt_mc.Rows[y][0].ToString() + "'", "MACHINE_CD ASC, WORK_DATE ASC, HH ASC").CopyToDataTable(), x == 0 ? "H" : "C", dt_mc.Rows[y][0].ToString());
                            }
                        }
                    }

                }

                //this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30));
                //tblMain.Controls.Add(uc_chart_1, 0, 0);
                //uc_chart_1.Dock = DockStyle.None;
                //uc_chart_1.Bindingdata(dt,"C");
                //tblMain.Controls.Add(uc_chart_2, 1, 0);
                //uc_chart_2.Dock = DockStyle.None;
                //uc_chart_2.Bindingdata(dt,"H");
                //tblMain.Controls.Add(uc_chart_3, 0, 1);
                //uc_chart_3.Dock = DockStyle.None;
                //uc_chart_3.Bindingdata(dt,"C");
                //tblMain.Controls.Add(uc_chart_4, 1, 1);
                //uc_chart_4.Dock = DockStyle.None;
                //uc_chart_4.Bindingdata(dt,"H");
                //tblMain.Controls.Add(uc_chart_5, 0, 2);
                //uc_chart_5.Dock = DockStyle.None;
                //uc_chart_5.Bindingdata(dt,"C");
                //tblMain.Controls.Add(uc_chart_6, 1, 2);
                //uc_chart_6.Dock = DockStyle.None;
                //uc_chart_6.Bindingdata(dt,"H");
                //tblMain.Controls.Add(uc_chart_7, 0, 3);
                //uc_chart_7.Dock = DockStyle.None;
                //uc_chart_7.Bindingdata(dt,"C");
                //tblMain.Controls.Add(uc_chart_8, 1, 3);
                //uc_chart_8.Dock = DockStyle.None;
                //uc_chart_8.Bindingdata(dt,"H");
                //tblMain.Controls.Add(uc_chart_9, 0, 4);
                //uc_chart_9.Dock = DockStyle.None;
                //uc_chart_9.Bindingdata(dt,"C");
                //tblMain.Controls.Add(uc_chart_10, 1, 4);
                //uc_chart_10.Dock = DockStyle.None;
                //uc_chart_10.Bindingdata(dt,"H");
                tblMain.Show();
            }
            catch(Exception ex)
            {

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
            if (cnt < 40)
            {
                cnt++;                
            }
            else
            {
                cnt = 0;
                cboMC_SelectedValueChanged(null,null);
            }
        }

        private void FRM_ROLL_SLABTEST_MON_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    lblCMP_Click(sender, e);
                    timer1.Start();
                    cnt = 0;
                    loadcbo("PHP");
                    //creat_layout("PHP");
                }
                else
                    timer1.Stop();
            }
            catch
            {
                //throw EX;
            }
        }

        private void lblCMP_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "CTM Machine Temperature";
            creat_layout("CMP");
            str_op = "CMP";
        }

        private void lblPhylon_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "CTM Machine Temperature";
            creat_layout("PHP");
            str_op = "PHP";
        }

        private void cboMC_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboMC == null || cboMC.SelectedValue.ToString() == "System.Data.DataRowView") return;
            try
            {
                int mc_f = 0, mc_t = 0;
                mc_f = Convert.ToInt32(cboMC.SelectedValue.ToString().Split('-')[0]);
                mc_t = Convert.ToInt32(cboMC.SelectedValue.ToString().Split('-')[1]);
                creat_layout_new("PHP", mc_f, mc_t);
            }
            catch
            {}
        }

        //private void lblRubber_Click(object sender, EventArgs e)
        //{
        //    //lblTitle.Text = "Rubber Slabtest Tracking by Month";
        //    BindingData("OS");
        //    bindingdatachart("OS");
        //    str_op = "OS";
        //    pnRubber.GradientEndColor = Color.White;//Color.FromArgb(255, 128, 128);
        //    pnEVA.GradientEndColor = Color.Gray;
        //}

        //private void lblEVA_Click(object sender, EventArgs e)
        //{
        //    //lblTitle.Text = "EVA Slabtest Tracking by Month";
        //    BindingData("PH");
        //    bindingdatachart("PH");
        //    str_op = "PH";
        //    pnEVA.GradientEndColor = Color.White; //Color.FromArgb(255, 128, 128);
        //    pnRubber.GradientEndColor = Color.Gray;
        //}

        //private void cmdYear_Click(object sender, EventArgs e)
        //{

        //}
    }
}
