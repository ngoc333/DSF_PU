using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Smart_FTY.UC
{
    public partial class UC_Main_Machinery : UserControl
    {
        public UC_Main_Machinery()
        {
            InitializeComponent();
        }


        
        public void setData(string[] argData)
        {            
            axGrid.Col = 1;
            axGrid.Row = 1;
            axGrid.Text = argData[0];
            axGrid.BackColor = Color.FromName(argData[1]);
            axGrid.ForeColor = Color.White;
            axGrid.Row = 3;
            axGrid.Text = argData[2];
            //axGrid.BackColor = Color.FromName(argData[3]);
            //if (argData[3].ToUpper() == "YELLOW")
            //    axGrid.ForeColor = Color.Black;
            //else
            //    axGrid.ForeColor = Color.White;
            
            axGrid.Col = 2;
            axGrid.Row = 3;
            axGrid.Text = argData[4];
            //axGrid.BackColor = Color.FromName(argData[5]);

            //if (argData[5].ToUpper() == "YELLOW")
            //    axGrid.ForeColor = Color.Black;
            //else
            //    axGrid.ForeColor = Color.White;
        }

        private void axGrid_Advance(object sender, AxFPUSpreadADO._DSpreadEvents_AdvanceEvent e)
        {

        }
    }
}
