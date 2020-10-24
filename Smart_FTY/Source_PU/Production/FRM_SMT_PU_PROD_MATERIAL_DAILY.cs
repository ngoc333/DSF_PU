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
    public partial class FRM_SMT_PU_PROD_MATERIAL_DAILY : Form
    {
        public FRM_SMT_PU_PROD_MATERIAL_DAILY()
        {
            InitializeComponent();
        }

        int cnt = 0, i_max = 0, i_min = 0;
        string str_op = "",strCol="";

        private void FRM_ROLL_SLABTEST_MON_Load(object sender, EventArgs e)
        {            
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            //cmdDay.Visible = false;
            lblTitle.Text = "PU Material Tallysheet By Day";
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
            this.WindowState = FormWindowState.Maximized;
        }

        public DataTable SEL_DATA_PROD_DAILY(string Qtype, string arg_op)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "MES.PKG_SMT_PU.SEL_PROD_MATERIAL_DAILY";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_TYPE";
                MyOraDB.Parameter_Name[1] = "ARG_FRM_LINE";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_op;
                MyOraDB.Parameter_Values[1] = "";
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

        public DataTable SEL_DATA_IMG(string Qtype, string arg_op)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "MES.PKG_SMT_PU.GET_IMG";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_FORM_NAME";
                MyOraDB.Parameter_Name[1] = "ARG_CNTR_NAME";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_op;
                MyOraDB.Parameter_Values[1] = "";
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

        private void formatband()
        {
            try
            {
                int n;
                DataTable dtsource = null;
                dtsource = SEL_DATA_PROD_DAILY("H", "");
                if (dtsource != null && dtsource.Rows.Count > 0)
                {
                    string name;
                    bandMon.Caption = dtsource.Rows[0]["MON"].ToString();
                    if (dtsource.Rows.Count > 0)
                    {
                        foreach (DevExpress.XtraGrid.Views.BandedGrid.GridBand band in gvwView.Bands[1].Children)
                        {
                            double num;
                            if (double.TryParse(band.Caption, out num))
                            {
                                for (int i = 0; i < dtsource.Rows.Count; i++)
                                {
                                    if (band.Name.Contains(dtsource.Rows[i][0].ToString().Substring(dtsource.Rows[i][0].ToString().Length - 2)))
                                    {
                                        band.Visible = true;
                                        break;
                                    }
                                    if (i == dtsource.Rows.Count - 1)
                                    {
                                        band.Visible = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                return;
            }
        }


      

        private void addImg(string pic_name, object picture, string lbl_name, string name)
        {
            try
            {

                Control cntr = panel1.Controls.Find(pic_name, true).FirstOrDefault();
                PictureBox pic = (PictureBox)cntr;
                pic.BackgroundImage = (Bitmap)((new ImageConverter()).ConvertFrom((byte[])picture));
                cntr = panel1.Controls.Find(lbl_name, true).FirstOrDefault();
                cntr.Text = name;
                cntr.Visible = true;
               // byte[] MyData = (byte[])picture;
                //using (System.IO.MemoryStream ms = new System.IO.MemoryStream((byte[])picture))
                //{
                  

                //    pic_S1.BackgroundImage = (Bitmap)((new ImageConverter()).ConvertFrom((byte[])picture));
                //}
            }
            catch (Exception)
            {}
        }
        private void addLabelText(string label_name, string text)
        {
            try
            {
                Control cntr = panel1.Controls.Find("", true).FirstOrDefault();
                cntr.Text = text;
            }
            catch (Exception)
            {}
            
        }

        


        private void setAllImage()
        {
            try
            {
                DataTable dt = SEL_DATA_IMG("", "");
               // addImg(dt.Rows[0]["CNTR_NAME"].ToString(), dt.Rows[0]["IMG"]);
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        addImg(dt.Rows[i]["PIC_NAME"].ToString(), dt.Rows[i]["IMG"], dt.Rows[i]["LBL_NAME"].ToString(), dt.Rows[i]["NAME"].ToString());
                    }
                }
            }
            catch (Exception)
            {}
            
        }

        string setTextShift(string value, string div)
        {
            if (value == "") return "";
           // else (value =="0.0") return "0" + div
            else return value  + div;
        }


        private void BindingData(string arg_op)
        {
            try
            {
                grdView.Refresh();
                DataTable dtsource = null;
                dtsource = SEL_DATA_PROD_DAILY("Q", arg_op);
                //formatband();
               // DataTable dt = null;
                if (dtsource == null)
                {
                    grdView.DataSource = dtsource;
                    return;
                }
                grdView.DataSource = dtsource.Rows.Count > 0 ? dtsource.Select("MC <> 'TOTAL'", "STT, MC").CopyToDataTable() : dtsource;
              //  grdView.DataSource = dtsource;
                lblPlan_S1.Text = "0";
                lblRPlan_S1.Text = "0";
                lblAct_S1.Text = "0";
                lblRate_S1.Text = "0";
                strCol = dtsource.Rows[0]["COL"].ToString();
                for (int i = 0; i < gvwView.Columns.Count; i++)
                {
                    gvwView.Columns[i].OwnerBand.Caption = "";
                }
                if (dtsource != null && dtsource.Rows.Count > 0)
                {
                    lblPlan_S1.Text = setTextShift(dtsource.Rows[0]["S1_TOT_PLAN"].ToString(), " Kg");
                    lblRPlan_S1.Text = setTextShift(dtsource.Rows[0]["S1_TOT_RPLAN"].ToString(), " Kg");
                    lblAct_S1.Text = setTextShift(dtsource.Rows[0]["S1_TOT_ACT"].ToString(), " Kg");
                    lblRate_S1.Text = setTextShift(dtsource.Rows[0]["S1_TOT_RATE"].ToString(), " %");

                    lblPlan_S2.Text = setTextShift(dtsource.Rows[0]["S2_TOT_PLAN"].ToString(), " Kg");
                    lblRPlan_S2.Text = setTextShift(dtsource.Rows[0]["S2_TOT_RPLAN"].ToString(), " Kg");
                    lblAct_S2.Text = setTextShift(dtsource.Rows[0]["S2_TOT_ACT"].ToString(), " Kg");

                    lblRate_S2.Text = setTextShift(dtsource.Rows[0]["S2_TOT_RATE"].ToString(), " %");

                    lblPlan_S3.Text = setTextShift(dtsource.Rows[0]["S3_TOT_PLAN"].ToString(), " Kg");
                    lblRPlan_S3.Text = setTextShift(dtsource.Rows[0]["S3_TOT_RPLAN"].ToString(), " Kg");
                    lblAct_S3.Text = setTextShift(dtsource.Rows[0]["S3_TOT_ACT"].ToString(), " Kg");
                    lblRate_S3.Text = setTextShift(dtsource.Rows[0]["S3_TOT_RATE"].ToString(), " %");

                    i_max = Convert.ToInt32(dtsource.Rows[0]["MAX"].ToString());
                    i_min = Convert.ToInt32(dtsource.Rows[0]["MIN"].ToString());
                    lbl1.Text = ">" + i_max + "%";
                    lbl2.Text = i_min + "%-" + i_max + "%";
                    lbl3.Text = "<" + i_min + "%";
                    for (int i = 1; i < gvwView.Columns.Count; i++)
                    {
                        gvwView.Columns[i].OptionsColumn.ReadOnly = true;
                        gvwView.Columns[i].OptionsColumn.AllowEdit = false;
                        gvwView.Columns[i].OptionsFilter.AllowFilter = false;
                        gvwView.Columns[i].OwnerBand.Caption = dtsource.Rows[0][gvwView.Columns[i].FieldName].ToString();
                        gvwView.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                       // gvwView.Columns[1].View.Appearance.Row.Options.UseTextOptions
                        if (i <= 1)
                        {
                            gvwView.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                        }
                        else
                        {
                            gvwView.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                        }
                      //  
                        gvwView.Columns[i].AppearanceCell.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Regular);
                        if (i > 2)
                        {
                            //gvwView.Columns[i].AppearanceCell.Font = new System.Drawing.Font("Calibri", 13, FontStyle.Regular);
                            gvwView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                            gvwView.Columns[i].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                        }
                        else
                        {
                            gvwView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                            gvwView.Columns[i].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                        }
                    }

                }
            }
            catch
            {}
            
            //axfpSpread.MaxRows = 2;
            //if (dtsource != null && dtsource.Rows.Count > 0)
            //{
            //    for (int i_row = 0; i_row < dtsource.Rows.Count; i_row++)
            //    {
            //        for (int i_col = 0; i_col < dtsource.Columns.Count; i_col++)
            //        {
            //            axfpSpread.Col = i_col + 1;
            //            axfpSpread.Row = i_row + 3;
            //            axfpSpread.ForeColor = Color.Black;
            //            //axfpSpread.TypeHAlign= FPUSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
            //            //axfpSpread.TypeVAlign = FPUSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
            //            //axfpSpread.Font = new System.Drawing.Font("Calibri", 22, FontStyle.Regular);
            //            axfpSpread.set_RowHeight(i_row+3, 27);
            //            axfpSpread.SetText(i_col + 1, i_row + 3, dtsource.Rows[i_row][i_col].ToString());
            //            //axfpSpread.CellBorderStyle = FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleDot;
            //        }
            //    }
            //}
        }

        private void gvwView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            
            if (e.Column.FieldName.Contains("RATE"))
            {
                if (e.CellValue.ToString().Replace("%", "") != "")
                {
                    if (Convert.ToDouble(e.CellValue.ToString().Replace("%", "").Trim()) > i_max)
                    {
                        e.Appearance.BackColor = Color.Green;
                        e.Appearance.ForeColor = Color.White;
                    }
                    else if (Convert.ToDouble(e.CellValue.ToString().Replace("%", "").Trim()) >= i_min && Convert.ToDouble(e.CellValue.ToString().Replace("%", "").Trim()) <= i_max)
                    {
                        e.Appearance.BackColor = Color.Yellow;
                        e.Appearance.ForeColor = Color.Black;
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.ForeColor = Color.White;
                    }
                }

            }
            else
            {

            }
            
        }

        

       // private void

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
            
            if (cnt < 40)
            {
                cnt++;                
            }
            else
            {
                cnt = 0;
                BindingData("PUP");
                
            }
        }

        private void FRM_ROLL_SLABTEST_MON_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {

                    cnt = 40;
                    timer1.Start();
                    setAllImage();

                }
                else
                {
                    timer1.Stop();
                    //tmrTime.Stop();
                }
            }
            catch
            {

            }
        }

        private void cmdMonth_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fc = Application.OpenForms["FRM_SMT_PU_PROD_MATERIAL_MONTH"];
            if (fc != null)
                fc.Show();
            else
            {
                FRM_SMT_PU_PROD_MATERIAL_MONTH f = new FRM_SMT_PU_PROD_MATERIAL_MONTH();
                f.Show();
            }
        }

        private void cmdYear_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form fc = Application.OpenForms["FRM_SMT_PU_PROD_YEAR"];
            //if (fc != null)
            //    fc.Show();
            //else
            //{
            //    FRM_SMT_PU_PROD_YEAR f = new FRM_SMT_PU_PROD_YEAR();
            //    f.Show();
            //}
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            Smart_FTY.ComVar._frm_home.Show();
            this.Hide();
        }

        private void gvwBase_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                //return;
                Rectangle rect = e.Bounds;
                rect.Inflate(new Size(1, 1));

                Brush brush = new SolidBrush(e.Appearance.BackColor);
                e.Graphics.FillRectangle(brush, rect);
                Pen pen_horizental = new Pen(Color.Blue, 3F);
                Pen pen_vertical = new Pen(Color.Blue, 4F);

                if (e.Column.FieldName.Contains("COL"))
                {
                    if (e.Column.FieldName == strCol)
                    {
                        // draw bottom
                        //e.Graphics.DrawLine(pen_horizental, rect.X, rect.Y + rect.Height - 1, rect.X + rect.Width, rect.Y + rect.Height - 1);
                        //// draw top
                        //e.Graphics.DrawLine(pen_horizental, rect.X, rect.Y, rect.X + rect.Width, rect.Y);

                        if (e.RowHandle == 0)
                        {
                            //e.Graphics.DrawLine(pen_horizental, rect.X, rect.Y, rect.X + rect.Width, rect.Y);
                        }
                        else if (e.RowHandle == gvwView.RowCount - 1)
                        {
                            e.Graphics.DrawLine(pen_horizental, rect.X, rect.Y + rect.Height - 1, rect.X + rect.Width, rect.Y + rect.Height - 1);
                        }
                        // draw right
                        e.Graphics.DrawLine(pen_vertical, rect.X + rect.Width, rect.Y, rect.X + rect.Width, rect.Y + rect.Height);


                        // draw left
                        e.Graphics.DrawLine(pen_horizental, rect.X, rect.Y, rect.X, rect.Y + rect.Height);


                    }

                    string[] ls = e.DisplayText.Split('\n');
                    //if (e.RowHandle < gvwBase.RowCount - 1)
                    //{
                    //    e.Graphics.DrawString(ls[0], new Font("Calibri", 12), new SolidBrush(Color.Black), rect, e.Appearance.GetStringFormat());
                    //}
                    //else
                    //{
                    //    e.Graphics.DrawString(ls[0], new Font("Calibri", 12), new SolidBrush(Color.Black), rect, e.Appearance.GetStringFormat());
                    //}

                    if (e.RowHandle < gvwView.RowCount - 1)
                    {
                        if (e.Appearance.BackColor == Color.Red || e.Appearance.BackColor == Color.Green)
                        {
                            e.Graphics.DrawString(ls[0], new System.Drawing.Font("Calibri", 16, FontStyle.Regular), new SolidBrush(Color.White), rect, e.Appearance.GetStringFormat());
                        }
                        else
                        {
                            e.Graphics.DrawString(ls[0], new System.Drawing.Font("Calibri", 16, FontStyle.Regular), new SolidBrush(Color.Black), rect, e.Appearance.GetStringFormat());
                        }
                    }
                    else
                    {
                        e.Graphics.DrawString(ls[0], new System.Drawing.Font("Calibri", 16, FontStyle.Regular), new SolidBrush(Color.Black), rect, e.Appearance.GetStringFormat());
                    }

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void gvwBase_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column == null) return;
            if (e.Column.AppearanceHeader.BackColor != Color.Empty)
            {
                //e.Appearance.BackColor = Color.Red;
                e.Info.AllowColoring = true;
                //e.Appearance.BackColor = Color.Red;
            }
            if (e.Column.AppearanceHeader.ForeColor != Color.Empty)
            {
                //e.Appearance.BackColor = Color.Red;
                e.Info.AllowColoring = true;
                //e.Appearance.BackColor = Color.Red;
            }
        }

        private void gvwBase_CustomDrawBandHeader(object sender, DevExpress.XtraGrid.Views.BandedGrid.BandHeaderCustomDrawEventArgs e)
        {
            try
            {
                //return;
                Rectangle rect = e.Bounds;
                rect.Inflate(new Size(1, 1));

                Brush brush = new SolidBrush(e.Appearance.BackColor);
                e.Graphics.FillRectangle(brush, rect);
                Pen pen_horizental = new Pen(Color.Blue, 3F);
                Pen pen_vertical = new Pen(Color.Blue, 4F);
                Pen line = new Pen(Color.White, 3F);
                bool boBorder = false;
                string[] ls = e.Band.Caption.Split('\n');

                if (e.Band.HasChildren)
                {
                    if (e.Band.Children[0].Columns.Count > 0)
                        if (e.Band.Children[0].Columns[0].Caption == strCol)
                        {
                            boBorder = true;
                        }
                }
                else
                {
                    if (e.Band.Columns.Count > 0)
                        if (e.Band.Columns[0].Caption == strCol)
                        {
                            boBorder = true;
                        }
                }

                if (boBorder)
                {
                    if (e.Band.HasChildren)
                        e.Graphics.DrawLine(pen_horizental, rect.X, rect.Y, rect.X + rect.Width, rect.Y);
                    else
                    {
                        //e.Graphics.DrawLine(line, rect.X, rect.Y, rect.X + rect.Width, rect.Y);
                    }
                    // draw right
                    e.Graphics.DrawLine(pen_vertical, rect.X + rect.Width - 2, rect.Y, rect.X + rect.Width - 2, rect.Y + rect.Height);


                    // draw left
                    e.Graphics.DrawLine(pen_horizental, rect.X + 1, rect.Y, rect.X + 1, rect.Y + rect.Height);


                    e.Graphics.DrawString(ls[0], e.Appearance.GetFont(), new SolidBrush(e.Appearance.GetForeColor()), rect, e.Appearance.GetStringFormat());
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

    }
}
