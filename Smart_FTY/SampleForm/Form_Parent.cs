using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Smart_FTY
{
    public partial class Form_Parent : Form
    {
        public Form_Parent()
        {
            InitializeComponent();
           // lblTitle.Font = new System.Drawing.Font("Calibri", 37.75F, System.Drawing.FontStyle.Bold);
        }

        

        private void GoFullscreen()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));

            //if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 14 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 22)
            //    lblShift.Text = "Shift 2 (14:00 ~ 22:00)";
            //else if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 6 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 14)
            //    lblShift.Text = "Shift 1 (06:00 ~ 14:00)";
            //else
            //    lblShift.Text = "Shift 3 (22:00 ~ 06:00)";
        }

       

        private void cmdMonth_Click(object sender, EventArgs e)
        {
            //if (Form_Home_DMP_DMC.Form_Group.ContainsKey(this.Name))
            //{
            //    switch (Form_Home_DMP_DMC.Form_Group[this.Name])
            //    {
            //       // case "101":
            //         //   Form_Home_Phylon._frmQua_In_OSD_Month.Show();
            //            //  Form_Home_Phylon._frmQuality_SlabtestMonth.Show();
            //        //    break;
            //        //case "102":
            //        //    Form_Home_DMP_DMC._frmQua_Ex_OSD_Month.Show();
            //        //    break;
            //        //case "201":
            //        //    Form_Home_DMP_DMC._frmProd_In_Month.Show();
            //        //    //Form_Home_Phylon._frmQual_Month.Show();
            //        //    break;
            //        //case "301":
            //        //    Form_Home_DMP_DMC._frmMc_OEE_Month.Show();
            //        //    break;
            //    }

            //    this.Hide();
            //}
        }

        private void cmdYear_Click(object sender, EventArgs e)
        {
            //if (Form_Home_DMP_DMC.Form_Group.ContainsKey(this.Name))
            //{
            //    switch (Form_Home_DMP_DMC.Form_Group[this.Name])
            //    {
            //        //case "101":
            //        //    Form_Home_Phylon._frmQua_Ex_OSD_Year.Show();
            //        //    break;
            //    //    case "102":
            //    //        Form_Home_DMP_DMC._frmQua_Ex_OSD_Year.Show();
            //    //        break;
            //    //    case "201":
            //    //        Form_Home_DMP_DMC._frmProd_In_Year.Show();
            //    //        break;
            //    //    case "301":
            //    //        Form_Home_DMP_DMC._frmMc_OEE_Year.Show();
            //    //        break;
            //    }

            //    this.Hide();
            //}
        }

        private void cmdDay_Click(object sender, EventArgs e)
        {
            //if (Form_Home_DMP_DMC.Form_Group.ContainsKey(this.Name))
            //{
            //    switch (Form_Home_DMP_DMC.Form_Group[this.Name])
            //    {
            //        //case "101":
            //        //    //Form_Home_Phylon._frmProd_In_Month.Show();
            //        //    //  Form_Home_Phylon._frmQuality_SlabtestMonth.Show();
            //        //    break;
            //        //case "201":
            //        //    Form_Home_DMP_DMC._frmProd_DMC.Show();
            //        //    //Form_Home_Phylon._frmQual_Month.Show();

            //        //    break;
            //    }

            //    this.Hide();
            //    //  cmdMonth.Enabled = true;
            //}
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            ////FormVar._frmHome.Show();
            //if (this.Name == "FRM_PH_PROD_DAILY_DAS" || this.Text == "Mold2" || this.Text == "INV2" || this.Text == "Temp2")
            //    this.Hide();
            //else
            //{
            //    Smart_FTY.ComVar._frm_home.Show();
            //    this.Hide();
            //}
        }

        private void lblDate_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Minimized;
            
        }

        private void SampleFrm1_Load(object sender, EventArgs e)
        {
            GoFullscreen();
            switch (this.Name)
            {
                //case "FRM_PH_OSD_MONTH":
                //case "FRM_PH_OSD_YEAR":
                //    cmdDay.Visible = false;
                //    break;
                
                //case "FORM_PH_MOLD_REPAIR":
                //case "FORM_SMT_B_MOLD_LAYOUT":
                //case "FORM_SMT_B_MOLD_ACTUAL_PLAN":
                //    pnButton.Visible = false;
                //    break;

  
                //case "FRM_SMT_PH_OEE":
                //case "FRM_SMT_PH_OEE_YEAR":
                //    pnFormType.Visible = false;
                //    cmdDay.Visible = false;
                //    break;

                //case "FRM_PH_TEMP":
                //    pnButton.Visible = false;
                //    pnFormType.Visible = false;
                //    break;
            }

            //lblCMP_Click(null, null);

            //if (Form_Home_DMP_DMC.Form_Type.ContainsKey(this.Name))
            //{
            //    switch (Form_Home_DMP_DMC.Form_Type[this.Name])
            //    {
            //        case "D":
            //            cmdDay.Enabled = false;
            //            break;
            //        case "M":
            //            cmdMonth.Enabled = false;
            //            break;
            //        case "Y":
            //            cmdYear.Enabled = false;
            //            break;
            //    }
            //}
        }

        private void lblCMP_Click(object sender, EventArgs e)
        {
            pn1.GradientEndColor = Color.White;
            pn2.GradientEndColor = Color.Gray;
            pn1.Enabled = false;
            pn2.Enabled = true;
        }

        private void lblPhylon_Click(object sender, EventArgs e)
        {
            pn1.GradientEndColor = Color.Gray;
            pn2.GradientEndColor = Color.White;
            pn1.Enabled = true;
            pn2.Enabled = false;

            
        }

        private void pnFormType_VisibleChanged(object sender, EventArgs e)
        {
            //if (Form_Home_DMP_DMC._type == "CMP")
            //    lblCMP_Click(null, null);
            //else
            //    lblPhylon_Click(null, null);
           // if (this.Visible)
           //     lblCMP_Click(null, null);
        }




    }
}
