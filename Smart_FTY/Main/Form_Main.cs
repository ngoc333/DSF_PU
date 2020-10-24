using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Smart_FTY
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();           
            
        }

        public static string Next_Form = "";
        string _this_form = "Form_Home";
        public static string This_Form_Type = "";

       // public static FRM_ROLL_SLABTEST_MONTH _frmQuality_SlabtestMonth = new FRM_ROLL_SLABTEST_MONTH();
        // static FRM_ROLL_SLABTEST_YEAR _frmQuality_SlabtestYear = new FRM_ROLL_SLABTEST_YEAR();
        public static Form_Home _frmHome = new Form_Home();

        private Dictionary<string, string> _List_Form = new Dictionary<string, string>();
        private Dictionary<string, string> _List_Form_Group = new Dictionary<string, string>();

        //public static Panel pnForm;

        #region Add Form
        private void add_form()
        {
            try
            {
                addFormToPanel(_frmHome);
                //addFormToPanel(_frmQuality_SlabtestMonth);
                //addFormToPanel(_frmQuality_SlabtestYear);

                addFormToList(_frmHome.Name, "000", "");
              //  addFormToList(_frmQuality_SlabtestMonth.Name, "101", "M");
              //  addFormToList(_frmQuality_SlabtestYear.Name, "101", "Y");
            }
            catch (Exception)
            {
            }
        }     

        private void addFormToPanel(Form arg_form)
        {
            try
            {
                arg_form.FormBorderStyle = FormBorderStyle.None;
                arg_form.TopLevel = false;
                arg_form.AutoScroll = false;
                arg_form.Dock = DockStyle.Fill;
                pnForm.Controls.Add(arg_form);
            }
            catch (Exception)
            {
            }
        }

        private void addFormToList(string arg_form, string argGroup, string argType)
        {
            try
            {
                _List_Form_Group.Add(arg_form, argGroup);
                _List_Form.Add(argGroup + argType, arg_form);
            }
            catch (Exception)
            {
            }
        }




        public void showForm(string form_load)
        {
            try
            {
                //  tmrColor.Enabled = false;
                //  pn_status.Visible = false;
                //  WarehouseMaterialSystem.ClassLib.ComVar.Type_form = form_load;
                //pnMenu.Hide();
               // pnHeader.Hide();
               // tmr_Date.Enabled = false;
                for (int i = 0; i < pnForm.Controls.Count; i++)
                {
                    if (pnForm.Controls[i].Name == form_load)
                    {
                        //lbl_header.Text = pn_main.Controls[i].Text;
                        pnForm.Controls[i].Show();

                        // break;
                    }
                    else
                        pnForm.Controls[i].Hide();
                }
                _this_form = form_load;

                // _frm_cur = form_load;
                // cmdBack.Show();


            }
            catch (Exception)
            {
            }
        }

        #endregion Add Form

        private void InitPanel()
        {
            
            
        }
                

        private void GoFullscreen()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            GoFullscreen();
            //this.Controls.Add(pnForm);
           // pnForm.Dock = DockStyle.Fill;

            add_form();
            _frmHome.Show();
            
        }


        private void pnForm_Layout(object sender, LayoutEventArgs e)
        {
            //if (This_Form_Type == "") return;
            //if (This_Form_Type != "H")
            //    showForm(_List_Form[_List_Form_Group[Next_Form] + This_Form_Type]);
            //else
            //    showForm("Form_Home");

        }

        






        /*
        private void lblDate_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            pn_status.Visible = false;
            Smart_FTY.ClassLib.ComVar.Type_form = "";
            pnMenu.Show();
            cmdBack.Hide();
            lbl_header.Text = "Outsole Mold Management System";
            if (Com_Base.Variables.Form[0]["monitor"].ToLower() == "touch" || Com_Base.Variables.Form[0]["monitor"].ToLower() == "touch1")
                cmdMain.Show();
            for (int i = 0; i < pn_main.Controls.Count; i++)
            {
                if (pn_main.Controls[i].Name == _frm_cur)
                {
                    pn_main.Controls[i].Hide();
                    break;
                }
            }
            cmdCleanHis.Hide();
            _frm_cur = "Form_Main";
            tmrColor.Enabled = true;
            
        }

        public void ChangeTitle(string arg_form)
        {
            lbl_header.Text = arg_form;
        }


        private void cmdMoldProduction_Click(object sender, EventArgs e)
        {
            showform("FORM_MOLD_PRODUCTION");
            
        }

        private void cmdMoldChange_Click(object sender, EventArgs e)
        {
            mold_change_list.Text = "Change Schedule By Daily";
            Smart_FTY.ClassLib.ComVar.Cleaning_form = "Cleaning";
            showform("FORM_MOLD_CHANGE_LIST");
            
        }

        private void MoldChangeRpt_Click(object sender, EventArgs e)
        {
            mold_change_report.Text = "Change History";
            showform("FORM_MOLD_CHANGE_REPORT");
        }

        private void cmdCleaningHis_Click(object sender, EventArgs e)
        {

            //_frm_cur = mold_clean_list.Name;
           // mold_clean_list.Hide();
            mold_cleaning_report.Text = "Cleaning History";
            showform("FORM_MOLD_CLEANING_REPORT");
        }

        private void cmdMoldControl_Click(object sender, EventArgs e)
        {
            mold_inventory.Text = "Inventory" ;
            showform("FORM_MOLD_INVENTORY");
        }

        private void cmdMoldClean_Click(object sender, EventArgs e)
        {
            Smart_FTY.ClassLib.ComVar.Cleaning_form = "Cleaning";
            Smart_FTY.ClassLib.ComVar.Type_form = "";
            mold_clean_list.Text = "To-Do Cleaning List By Daily";
            showform("FORM_MOLD_CLEAN_LIST");
           // cmdCleanHis.Show();
        }

        

        private void cmdQualityMonth_Click(object sender, EventArgs e)
        {
            Smart_FTY.ClassLib.ComVar.Type_form = "RepaiMonthly";
            mold_repair.Text = "Repair Type By Mothly (" + DateTime.Today.AddDays(-30).ToString("MMM-dd") + " ~ " + DateTime.Today.ToString("MMM-dd") + ")";
            showform("FORM_MOLD_REPAIR");

            mold_repair.monthlyClick();

        }

        private void cmdQualityWeek_Click(object sender, EventArgs e)
        {
            mold_repair.Text = "Repair Management By Week";
            showform("FORM_MOLD_REPAIR");
            mold_repair.weekllyClick();
        }

        private void cmdQualityDay_Click(object sender, EventArgs e)
        {
            
            //mold_repair.Text = "Repair Management By Monthly";

            showform("FORM_MOLD_REPAIR");
            mold_repair.dailyClick();
        }

        private void cmdLocationWH_Click(object sender, EventArgs e)
        {
            mold_location.Text = "Location Warehouse";
            showform("FORM_MOLD_LOCATION");
        }

        private void cmdLocationWS_Click(object sender, EventArgs e)
        {
            mold_location.Text = "Location Workshop";
            showform("FORM_MOLD_LOCATION");
            mold_location.WsClick();
        }

        private void PressingTime_Click(object sender, EventArgs e)
        {
            // mold_location.Text = "Location Workshop";
             mold_life_cycle.Text = "Life Cycle";
            showform("FORM_MOLD_LIFE_CYCLE");
            // mold_location.WsClick();
        }

        private void MoldNano_Click(object sender, EventArgs e)
        {
            Smart_FTY.ClassLib.ComVar.Cleaning_form = "Nano";
            Smart_FTY.ClassLib.ComVar.Type_form = "";
            mold_clean_list.Text = "To-Do Nano List";
            showform("FORM_MOLD_CLEAN_LIST");
        }

        private void cmd_plan_actual_Click(object sender, EventArgs e)
        {
            showform("FORM_MOLD_ACTUAL_PLAN");
        }


        private void pn_main_Layout(object sender, LayoutEventArgs e)
        {
           
            switch (Smart_FTY.ClassLib.ComVar.Type_form)
            {
                case "CleaningHis":
                    Smart_FTY.ClassLib.ComVar.Type_form = "";
                    Smart_FTY.ClassLib.ComVar.Cleaning_form = "CleaningHis";
                    cmdCleaningHis_Click(cmdCleanHis, e);
                    break;
                case "Nano":
                    Smart_FTY.ClassLib.ComVar.Cleaning_form = "Nano";
                    Smart_FTY.ClassLib.ComVar.Type_form = "";
                    MoldNano_Click(cmdMoldNano, e);
                    break;
                case "Cleaning":
                    Smart_FTY.ClassLib.ComVar.Cleaning_form = "Cleaning";
                    Smart_FTY.ClassLib.ComVar.Type_form = "";
                    cmdMoldClean_Click(cmdMoldClean, e);
                    break;
                case "RepairDaily":
                    lbl_header.Text = "Repair Set By Daily (" + DateTime.Today.AddDays(-30).ToString("MMM-dd") + " ~ " + DateTime.Today.ToString("MMM-dd") + ")";
                    break;
                case "RepairMonthly":
                    lbl_header.Text = "Repair Type By Monthly (" + DateTime.Today.AddDays(-30).ToString("MMM-dd") + " ~ " + DateTime.Today.ToString("MMM-dd") + ")";
                    break;
                case "RepairWeekly":
                    lbl_header.Text = "Repair Type By Weekly (" + DateTime.Today.AddDays(-7).ToString("MMM-dd") + " ~ " + DateTime.Today.ToString("MMM-dd") + ")";
                    break;
                case "LocWH":
                    lbl_header.Text = "Location Warehouse";
                    break;
                case "LocWS":
                    lbl_header.Text = "Location Workshop";
                    break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
        }


        private void setClick(Button cmd)
        {
            Smart_FTY.ClassLib.WinAPI.AnimateWindow(gp1.Handle, 200, Smart_FTY.ClassLib.WinAPI.getSlidType("14"));
            Smart_FTY.ClassLib.WinAPI.AnimateWindow(gp2.Handle, 200, Smart_FTY.ClassLib.WinAPI.getSlidType("14"));
            Smart_FTY.ClassLib.WinAPI.AnimateWindow(gp3.Handle, 200, Smart_FTY.ClassLib.WinAPI.getSlidType("14"));
            gp1.Visible = false;
            gp2.Visible = false;
            gp3.Visible = false;
            switch (cmd.Name)
            {                   
                case "cmdProduction":

                    Smart_FTY.ClassLib.WinAPI.AnimateWindow(gp1.Handle, 300, Smart_FTY.ClassLib.WinAPI.getSlidType("3"));
                    gp1.Visible = true;
                    break;
                case "cmdQuality":
                    Smart_FTY.ClassLib.WinAPI.AnimateWindow(gp2.Handle, 300, Smart_FTY.ClassLib.WinAPI.getSlidType("3"));
                    gp2.Visible = true;
                    break;
                case "cmdInventory":
                    Smart_FTY.ClassLib.WinAPI.AnimateWindow(gp3.Handle, 300, Smart_FTY.ClassLib.WinAPI.getSlidType("3"));
                    gp3.Visible = true;
                    break;
            }
        }
        private void pnMenu_Click(object sender, EventArgs e)
        {
            gp1.Visible = false;
            gp2.Visible = false;
            gp3.Visible = false;
        }

        private void cmdProduction_MouseHover(object sender, EventArgs e)
        {
            setClick(cmdProduction);
        }

        private void cmdQuality_MouseHover(object sender, EventArgs e)
        {
            setClick(cmdQuality);
        }

        private void cmdInventory_MouseHover(object sender, EventArgs e)
        {
            setClick(cmdInventory);
        }

        private void cmd_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }

        private void lbl_header_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblDate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }



        #region Run
        string[] FullText = new string[]
        {
            "Not Found, Please Close Program and Open Again!"
        };
        static char[] specChars = new char[] { '.', '\'', ',', '-', ')', '(' };
        int lockTimerCounter;
        int visibleSymbolsCount1 = 0;
        int substringStartIndex1 = 0;

        private void tmrColor_Tick(object sender, EventArgs e)
        {
            if (lockTimerCounter == 0)
            {
                lockTimerCounter++;
                UpdateText(0);
                lockTimerCounter--;
            }
        }

        protected void Init(int index)
        {
            tmrColor.Stop();
            tmrColor.Interval = 300;
            tmrColor.Start();

            //FullText[index] = new string(' ', digitalGaugeLine1.DigitCount) + FullText[index] + new string(' ', digitalGaugeLine1.DigitCount);
            visibleSymbolsCount1 = digitalGaugeLine1.DigitCount;
            substringStartIndex1 = 0;
            
        }
        private bool IsSpecialCharacter(char character)
        {
            return Array.IndexOf(specChars, character) != -1;
        }
        protected void UpdateText(int index)
        {
            int additionalSymbolsCount1 = 0;
            additionalSymbolsCount1 = Array.FindAll(FullText[index].Substring(substringStartIndex1, visibleSymbolsCount1).ToCharArray(), IsSpecialCharacter).Length;
            digitalGaugeLine1.Text = FullText[index].Substring(substringStartIndex1, visibleSymbolsCount1 + additionalSymbolsCount1);
            substringStartIndex1 += 1;
            if (substringStartIndex1 < 0)
                substringStartIndex1 = FullText[index].Length - visibleSymbolsCount1;
            else if (substringStartIndex1 > FullText[index].Length - visibleSymbolsCount1)
                substringStartIndex1 = 0;
            if (IsSpecialCharacter(FullText[index][substringStartIndex1]))
                substringStartIndex1 += 1;
           

        }

        public DataTable Ora_Load_Infor()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_SPB_MOLD_WMS_V2.SEL_INFOR_MAIN";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";
                MyOraDB.Parameter_Name[1] = "ARG_WH";

                MyOraDB.Parameter_Type[0] = (int)System.Data.OracleClient.OracleType.Cursor;
                MyOraDB.Parameter_Type[1] = (int)System.Data.OracleClient.OracleType.VarChar;

                MyOraDB.Parameter_Values[0] = "";
                MyOraDB.Parameter_Values[1] = Com_Base.Variables.Form[0]["WH_CD"].ToString();

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
        

        #endregion Run
        */
        
    }
}
