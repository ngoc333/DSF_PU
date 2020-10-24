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
    public partial class UC_Main_Machinery2 : UserControl
    {
        public UC_Main_Machinery2()
        {
            InitializeComponent();
        }


        
        public void setData(string[] argData)
        {            
            axGrid.Col = 1;
            axGrid.Row = 1;
            axGrid.Text = argData[0];
            //axGrid.BackColor = Color.FromName(argData[1]);
            //axGrid.ForeColor = Color.White;
            axGrid.Row = 2;
            axGrid.Text = argData[1];
            //axGrid.BackColor = Color.FromName(argData[2]);
            //if (argData[3].ToUpper() == "YELLOW")
            //    axGrid.ForeColor = Color.Black;
            //else
            //    axGrid.ForeColor = Color.White;
 
        }
    }
}
