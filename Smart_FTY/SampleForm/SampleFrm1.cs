using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Smart_FTY
{
    public partial class SampleFrm1 : Form
    {
        public SampleFrm1()
        {
            InitializeComponent();
           // lblTitle.Font = new System.Drawing.Font("Calibri", 37.75F, System.Drawing.FontStyle.Bold);
        }

        [DllImport("user32.dll")]
        public static extern void SwitchToThisWindow(IntPtr hWnd, bool turnon);

        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 SWP_SHOWWINDOW = 0x0040;

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
            
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process result = System.Diagnostics.Process.GetProcessesByName("B1_DASHBOARD").FirstOrDefault();
                SwitchToThisWindow(result.MainWindowHandle, true);
            }
            catch
            { }
            
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
            
        }




    }
}
