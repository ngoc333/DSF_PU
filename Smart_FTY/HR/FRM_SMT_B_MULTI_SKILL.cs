using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Smart_FTY
{
    public partial class FRM_SMT_B_MULTI_SKILL : Form
    {
        public FRM_SMT_B_MULTI_SKILL()
        {
            InitializeComponent();
        }
        int indexScreen;
        string line, mline, Lang;
        int int_count = 0;
        public FRM_SMT_B_MULTI_SKILL(string title, int _indexScreen, string _line, string _mline, string _Lang)
        {
            InitializeComponent();
            lbltitle.Text = title;
            indexScreen = _indexScreen;
            line = _line;
            mline = _mline;
            Lang = _Lang;
            timer1.Stop();
            timer2.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (int_count < 20)
                    int_count++;
                else
                {
                    int_count = 0;
                    load_data();
                }
            }
            catch { }
        }

        public DataTable SEL_HR_MANAGEMENT(string Qtype, string ARG_LINE_CD, string ARG_MLINE_CD)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "MES.PKG_SMT_PHUOC.SP_SMT_HR_MANAGEMENT";

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

                MyOraDB.Parameter_Values[0] = Qtype;
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


        private void BindingChartType()
        {
            chartControl3.DataSource = SEL_HR_MANAGEMENT("TYPE", line, mline);
            chartControl3.Series[0].ArgumentDataMember = "TYPE";
            chartControl3.Series[0].ValueDataMembers.AddRange(new string[] { "TOT_MAN" });
        }


        private void load_data()
        {
            try
            {
                DataTable dt = SEL_SMT_MULTI_SKILL("Q1", line, mline, "");
                DataTable dt1 = SEL_SMT_MULTI_SKILL("Q2", line, mline, "");
                if (dt != null && dt.Rows.Count > 0)
                {
                    bindingdatachart(chartControl1, dt);
                }

                if (dt1 != null && dt1.Rows.Count > 0)
                {
                    bindingdatachart1(chartControl2, dt1);
                }
                BindingChartType();

            }
            catch
            {
            }
        }

        private void bindingdatachart(DevExpress.XtraCharts.ChartControl _chart, DataTable dt)
        {
            _chart.DataSource = dt;
            _chart.Series[0].ArgumentDataMember = "OP_NAME";
            _chart.Series[0].ValueDataMembers.AddRange(new string[] { "'1~3'" });
            //chartControl1.Series[0].ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            _chart.Series[1].ArgumentDataMember = "OP_NAME";
            _chart.Series[1].ValueDataMembers.AddRange(new string[] { "'4~6'" });
            //chartControl1.Series[1].ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            _chart.Series[2].ArgumentDataMember = "OP_NAME";
            _chart.Series[2].ValueDataMembers.AddRange(new string[] { "'7~9'" });
            _chart.Series[3].ArgumentDataMember = "OP_NAME";
            _chart.Series[3].ValueDataMembers.AddRange(new string[] { "'>9'" });
        }

        private void bindingdatachart1(DevExpress.XtraCharts.ChartControl _chart, DataTable dt)
        {
            _chart.DataSource = dt;
            _chart.Series[0].ArgumentDataMember = "MULTI_SKILL";
            _chart.Series[0].ValueDataMembers.AddRange(new string[] { "QTY" });
        }

        public DataTable SEL_SMT_MULTI_SKILL(string ARG_QTYPE, string ARG_LINE, string ARG_MLINE, string ARG_DATE)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_PROD.SP_SMT_MULTI_SKILL";

                MyOraDB.ReDim_Parameter(5);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "V_P_TYPE";
                MyOraDB.Parameter_Name[1] = "V_P_LINE";
                MyOraDB.Parameter_Name[2] = "V_P_MLINE";
                MyOraDB.Parameter_Name[3] = "V_P_DATE";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = ARG_QTYPE;
                MyOraDB.Parameter_Values[1] = ARG_LINE;
                MyOraDB.Parameter_Values[2] = ARG_MLINE;
                MyOraDB.Parameter_Values[3] = ARG_DATE;
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

        private void FRM_SMT_MULTI_SKILL_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FRM_SMT_MULTI_SKILL_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                int_count = 19;
                timer1.Start();
                timer2.Start();
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fc = Application.OpenForms["FRM_MUILTISKILL_QUATERLY"];
            if (fc != null)
                fc.Close();


            string Caption = "Multi-Skill by Quarter";
            switch (Lang)
            {
                case "Vn":
                    Caption = "Đa Kỹ Năng theo Quý";
                    break;
                default:
                    Caption = "Multi-Skill by Quarter";
                    break;
            }
           // FRM_MUILTISKILL_QUATERLY f = new FRM_MUILTISKILL_QUATERLY(Caption, 1, line, mline, Lang);
            f.Show();


        }
    }
}
