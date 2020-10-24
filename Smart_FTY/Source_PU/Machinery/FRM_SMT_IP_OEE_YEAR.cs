using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using System.Data.OracleClient;

namespace Smart_FTY
{
    public partial class FRM_SMT_IP_OEE_YEAR : Form
    {
        public FRM_SMT_IP_OEE_YEAR()
        {
            InitializeComponent();
           // tmrTime.Stop();
        }
        #region Variable
        int cCount = 0;
        string BtnClick = "PH";
        Color ColorRow = Color.White;
        Color ColorEven = Color.FromArgb(247, 247, 247);
        #endregion
        #region UC
       // UC.UC_PH_MACHINE_GRID UC = new UC.UC_PH_MACHINE_GRID();
        //UC.UC_PH_MACHINE_GRID UC23_44 = new UC.UC_PH_MACHINE_GRID();
        UC.UC_DWMY uc = new UC.UC_DWMY(8);
        #endregion
        #region Oracle
        private DataTable SELECT_DATA_IP(string ARG_QTYPE, string ARG_DATE)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_PU.LOAD_OEE";
                 
                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_TYPE";
                MyOraDB.Parameter_Name[1] = "ARG_YMD";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = ARG_QTYPE;
                MyOraDB.Parameter_Values[1] = ARG_DATE;
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
        #endregion
        private void FRM_SMT_PH_OEE_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "PU Machine OEE by Year";
            lblDateTime.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
            pnYMD.Controls.Add(uc);
            uc.OnDWMYClick += DWMYClick;
        }
        void DWMYClick(string ButtonCap, string ButtonCD)
        {
            //MessageBox.Show(ButtonCap + "    " + ButtonCD);
            switch (ButtonCD)
            {
                case "C":
                    this.Close();
                    break;
                case "M":
                    this.Close();
                    Form fc = Application.OpenForms["FRM_SMT_IP_OEE"];
                    if (fc != null)
                        fc.Show();
                    else
                    {
                        FRM_SMT_PU_OEE f = new FRM_SMT_PU_OEE();
                        f.Show();
                    }
                    break;
                case "Y":
                    this.Close();
                    Form fc1 = Application.OpenForms["FRM_SMT_OS_OEE_YEAR"];
                    if (fc1 != null)
                        fc1.Show();
                    else
                    {
                        FRM_SMT_IP_OEE_YEAR f1 = new FRM_SMT_IP_OEE_YEAR();
                        f1.Show();
                    }
                    break;
            }
        }
        static DataTable GetTable()
        {
            // Here we create a DataTable with four columns.
            DataTable table = new DataTable();
            Random r = new Random();
            table.Columns.Add("Range", typeof(string));
            table.Columns.Add("Dosage", typeof(int));

            // Here we add five DataRows.
            for (int i = 1;i<=44;i++)
                table.Rows.Add("CTM " + i.ToString(), r.Next(70,102));
            //table.Rows.Add("value1",25);
            //table.Rows.Add("value2", 50);
            //table.Rows.Add("value3",10);
            //table.Rows.Add("value4",21);
            //table.Rows.Add("value5",100);
            return table;
        }

        private void BindingOEEChart(string ARG_QTYPE)
        {
            try
            {
                ChartOEE.DataSource = SELECT_DATA_IP(ARG_QTYPE,uc_year.GetValue().ToString());
                ChartOEE.Series[0].ArgumentDataMember = "OSP_LINE";
                ChartOEE.Series[0].ValueDataMembers.AddRange(new string[] { "OEE" });
                ((XYDiagram)ChartOEE.Diagram).AxisX.QualitativeScaleOptions.AutoGrid = false;
                 // ChartOEE.Series[0].ValueScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            }
            catch 
            { }
        }
         
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
            cCount++;
            if (cCount >= 40)
            {
                lblPhylon_Click(null, null);
                cCount = 0;
            }
        }

        private void FRM_SMT_PH_OEE_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                
                cCount = 39;
                tmrTime.Start();
            }
            else
                tmrTime.Stop();
        }

        private void lblPhylon_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            BtnClick = "PH";
            lblTitle.Text = "PU Machine OEE by Year";
            BindingGrid("GYEAR");
            BindingOEEChart("YEAR");
            this.Cursor = Cursors.Default;
            //Form_Home_Phylon._type = "PHP";
        }

        private void lblCMP_Click(object sender, EventArgs e)
        { 
        }

        private void splMain_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void BindingGrid(string ARG_QTYPE)
        {
            try
            {

                DataTable dt = SELECT_DATA_IP(ARG_QTYPE,uc_year.GetValue().ToString());

                grdBase.DataSource = dt;
                FormatGrid();
            }
            catch (Exception ex)
            { }
        }

        private void FormatGrid()
        {
            try
            {
                for (int i = 0; i < gvwBase.Columns.Count; i++)
                {
                    if (i == gvwBase.Columns.Count - 1)
                    {
                     gvwBase.Columns[i].AppearanceHeader.BackColor = Color.DarkOrange;
                     gvwBase.Columns[i].AppearanceHeader.ForeColor = Color.Black;
                    }
                    else
                    {
                    gvwBase.Columns[i].AppearanceHeader.BackColor = Color.Gray;
                    gvwBase.Columns[i].AppearanceHeader.ForeColor = Color.White;
                    }
                    if (gvwBase.Columns[i].Caption != "DATE")
                        gvwBase.Columns[i].Caption = gvwBase.Columns[i].Caption.Substring(5, 1);

                    if (i > 0)
                    {
                        gvwBase.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        gvwBase.Columns[i].DisplayFormat.FormatString = "#,#.#";
                    }
                }
                gvwBase.Columns[0].Width = 120;
            }
            catch (Exception ex)
            { }
        }

        private void gvwBase_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {

                if (e.RowHandle < 0)
                    return; 
                if (gvwBase.GetRowCellValue(e.RowHandle, "LINE").ToString() == "AVG")
                {
                    e.Appearance.ForeColor = Color.Black;
                    e.Appearance.BackColor = Color.DarkOrange;
                    //e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 16, FontStyle.Bold);

                }

                //if (e.Column.AbsoluteIndex > 10)
                //{
                //    if (e.CellValue.ToString().Contains("GREEN"))
                //    {
                //        e.Appearance.BackColor = Color.LimeGreen;
                //    }
                //    if (e.CellValue.ToString().Contains("RED"))
                //    {
                //        e.Appearance.BackColor = Color.Red;
                //    }
                //    if (e.CellValue.ToString().Contains("YELLOW"))
                //    {
                //        e.Appearance.BackColor = Color.Yellow;
                //    }
                //    if (e.CellValue.ToString().Contains("GRAY"))
                //    {
                //        e.Appearance.BackColor = Color.SlateGray;
                //    }
                //}
            }
            catch (Exception ex)
            {

            }
        }

        private void uc_year_ValueChangeEvent(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            BindingGrid("GYEAR");
            BindingOEEChart("YEAR");
            this.Cursor = Cursors.Default;
        }

    }
}
