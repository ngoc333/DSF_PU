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
    public partial class SampleFrm2 : Form
    {
        public SampleFrm2()
        {
            InitializeComponent();
           // lblTitle.Font = new System.Drawing.Font("Calibri", 37.75F, System.Drawing.FontStyle.Bold);
        }
        
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));

            if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 14 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 22)
                lblShift.Text = "Shift 2 (14:00 ~ 22:00)";
            else if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 6 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 14)
                lblShift.Text = "Shift 1 (06:00 ~ 14:00)";
            else
                lblShift.Text = "Shift 3 (22:00 ~ 06:00)";
        }

       

        private void cmdMonth_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdYear_Click(object sender, EventArgs e)
        {
            
            
        }

        private void cmdDay_Click(object sender, EventArgs e)
        {
            //if (Form_Home_DMP_DMC.Form_Group.ContainsKey(this.Name))
            //{
            //    switch (Form_Home_DMP_DMC.Form_Group[this.Name])
            //    {
            //        case "201":
            //            Form_Home_DMP_DMC._frmProd_DMC.Show();
            //            break;
            //    }
            //    this.Hide();
            //    //cmdDay.Enabled = true;
            //}
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            if (this.Name == "FRM_PH_PROD_DAILY_DAS" || this.Text == "Mold2" || this.Text == "INV2")
                this.Hide();
            else
            {
                Smart_FTY.ComVar._frm_home.Show();
                this.Hide();
            }
        }

        private void lblDate_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
        }

        private void GoFullscreen()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

        }

        private void SampleFrm1_Load(object sender, EventArgs e)
        {
            GoFullscreen();
        }




    }
}
