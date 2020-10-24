using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Smart_FTY
{
    public partial class UCMainMenu : UserControl
    {
        public UCMainMenu( string argText, string argFrmLine, string argToLine)
        {
            InitializeComponent();
            cmdLine.Text = argText;
            _frmProd._frmLine = argFrmLine;
            _frmProd._toLine = argToLine;

            _frmTallySheet._SOPCD = "PHP";
            _frmTallySheet._SMCF = argFrmLine;
            _frmTallySheet._SMCT = argToLine;

            int frm , to;
            int.TryParse(argFrmLine, out frm);
            int.TryParse(argToLine, out to);
            _frmTemp._frmLine = frm;
            _frmTemp._toLine = to;
        }

       // public static string _frmLine="", _toLine="";

        FRM_PH_PROD_DAILY_DAS _frmProd = new FRM_PH_PROD_DAILY_DAS();
        FROM_PH_TALLYSHEET _frmTallySheet = new FROM_PH_TALLYSHEET();

        FRM_PH_TEMP_DAS _frmTemp = new FRM_PH_TEMP_DAS("");

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

        private void cmdProduction_Click(object sender, EventArgs e)
        {
            _frmProd.Show();
        }

        private void cmdTallySheet_Click(object sender, EventArgs e)
        {
            _frmTallySheet.Show();
        }

        private void cmdTemp_Click(object sender, EventArgs e)
        {
            _frmTemp.Show();
        }
    }
}
