using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Drawing.Drawing2D;
using Microsoft.VisualBasic.PowerPacks;
using System.Threading;
//using System.Windows.Media.Animation;

namespace Smart_FTY
{
    public partial class FORM_LEADTIME_COMP_DMP : Form
    {
        System.Drawing.Color _lineColor = System.Drawing.Color.Black;
        System.Drawing.Pen _myPen = new System.Drawing.Pen(System.Drawing.Color.Black, 3);
        Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 3);
        int _wlr = 6;
        int _wn = 3;
        DataTable _dt = null;
        int _speed = 20;
        int icount = 0;
        int iStopTruck;
        int[] _pEnd = new int[23];
        bool[] _pStatus = new bool[23];
        public FORM_LEADTIME_COMP_DMP()
        {
            InitializeComponent();
          
        }

        #region Func

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        public void DrawRoundRect(Graphics g, Pen p, float X, float Y, float width, float height, float radius, int corner)
        {
            GraphicsPath gp = new GraphicsPath();

            switch (corner)
            {
                case 0:
                    gp.AddLine(X + radius, Y, X + width - (radius * 2), Y);
                    gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
                    gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2));
                    gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);

                    gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height);
                    gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
                    gp.AddLine(X, Y + height - (radius * 2), X, Y + radius);
                    gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
                    break;
                case 1:

                    break;
                case 2:
                    gp.AddLine(X, Y, X + width - (radius * 2), Y);
                    gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
                    gp.AddLine(X + width, Y + radius, X + width, Y + height);
                    gp.AddLine(X + width , Y + height, X , Y + height);
                    gp.AddLine(X, Y + height , X, Y );
                    break;
                case 3: 
                    break;
                case 4:
                    gp.AddLine(X , Y, X + width, Y);
                   
                    gp.AddLine(X + width, Y , X + width, Y + height);
                    

                    gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height);
                    gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
                    gp.AddLine(X, Y + height - (radius * 2), X, Y + radius);
                   
                    break;

                case 5:
                    gp.AddLine(X +  width/2, Y, X , Y + height/2);
                    gp.AddLine(X + width / 2, Y, X + width, Y + height / 2);
                    gp.AddLine(X + width / 2, Y + height, X, Y + height / 2);

                  //  gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
                   // gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2));
                   // gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);

                  //  gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height);
                 //   gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
                //    gp.AddLine(X, Y + height - (radius * 2), X, Y + radius);
                 //   gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
                    break;
                     
            }
           
            gp.CloseFigure();
            g.DrawPath(p, gp);
            gp.Dispose();
        }

        //private void animation()
        //{
        //    pn_left.Hide();
        //    pn_z1.Hide();
        //    pn_z2.Hide();
        //    pn_z3.Hide();
        //    pn_z4.Hide();
        //    pn_z5.Hide();
        //    pn_z6.Hide();
        //    pn_bottom.Hide();


        //    IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.pn_bottom.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("4"));
        //    pn_bottom.Show();
        //    IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.pn_z6.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("4"));
        //    pn_z6.Show();
        //    IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.pn_z5.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("4"));
        //    pn_z5.Show();
        //    IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.pn_z4.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("4"));
        //    pn_z4.Show();
        //    IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.pn_z3.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("4"));
        //    pn_z3.Show();
        //    IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.pn_z2.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("4"));
        //    pn_z2.Show();
        //    pn_z1.Show();

        //    IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.pn_left.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("4"));
        //    pn_left.Show();
        //}

        private void load_data(DataTable arg_dt)
        {
            //string str_column = "";
            if (arg_dt != null && arg_dt.Rows.Count > 0)
            {

                lblCompoundMin.Text = arg_dt.Rows[0]["COMPOUD_MIN"].ToString();
                lblCompoundMinBottom.Text = arg_dt.Rows[0]["COMPOUD_MIN_BOTTOM"].ToString();

                lblCompoundInvent.Text = arg_dt.Rows[0]["COMPOUND_INVENT"].ToString();
                lblCompoundInventBottom.Text = arg_dt.Rows[0]["COMPOUND_INVENT_BOTTOM"].ToString();

                lblColdShotIn.Text = arg_dt.Rows[0]["COLD_SHOT_IN"].ToString();
                lblColdShotInBottom.Text = arg_dt.Rows[0]["COLD_SHOT_IN_BOTTOM"].ToString();


                lblColdShotMin.Text = arg_dt.Rows[0]["COLD_SHOT_MIN"].ToString();
                lblColdShotMinBottom.Text = arg_dt.Rows[0]["COLD_SHOT_MIN_BOTTOM"].ToString();

                lblColdShotOut.Text = arg_dt.Rows[0]["COLD_SHOT_OUT"].ToString();
                lblColdShotOutBottom.Text = arg_dt.Rows[0]["COLD_SHOT_OUT_BOTTOM"].ToString();

                lblColdShotAging.Text = arg_dt.Rows[0]["COLD_SHOT_AGIN"].ToString();
                lblColdShotAgingBottom.Text = arg_dt.Rows[0]["COLD_SHOT_AGIN_BOTTOM"].ToString();

                //lblColdShotAging.Text = arg_dt.Rows[0]["COLD_SHOT_AGIN"].ToString();
                //lblColdShotAgingBottom.Text = arg_dt.Rows[0]["COLD_SHOT_AGIN_BOTTOM"].ToString();

                lblDMPIn.Text = arg_dt.Rows[0]["DMP_IN"].ToString();
                lblDMPInBottom.Text = arg_dt.Rows[0]["DMP_IN_BOTTOM"].ToString();

                lblDMPMin.Text = arg_dt.Rows[0]["DMP_MIN"].ToString();
                lblStabilizatinMin.Text = arg_dt.Rows[0]["STABILIZATION_MIN"].ToString();
                lblWashingMin.Text = arg_dt.Rows[0]["WASHING_MIN"].ToString();
                lblTrimmingMin.Text = arg_dt.Rows[0]["TRIMMING_MIN"].ToString();
                lblTotalDMPMinBottom.Text = arg_dt.Rows[0]["TOTAL_DMP_MIN_BOTTOM"].ToString();


                lblTrimmingOut.Text = arg_dt.Rows[0]["TRIM_OUT"].ToString();
                lblTrimmingOutBottom.Text = arg_dt.Rows[0]["TRIM_OUT_BOTTOM"].ToString();

                lblHotKnifeIn.Text = arg_dt.Rows[0]["HOTKNIFE_IN"].ToString();
                lblLaserIn.Text = arg_dt.Rows[0]["LASER_IN"].ToString();
                lblTotalHotKnifeInBottom.Text = arg_dt.Rows[0]["TOTAL_HOTKNIFE_IN_BOTTOM"].ToString();

                lblHotKnifeMin.Text = arg_dt.Rows[0]["HOTKNIFE_MIN"].ToString();
                lblLaserMin.Text = arg_dt.Rows[0]["LASER_MIN"].ToString();
                lblTotalHotKnifeMinBottom.Text = arg_dt.Rows[0]["TOTAL_HOTKNIFE_MIN_BOTTOM"].ToString();

                lblHotKnifeOut.Text = arg_dt.Rows[0]["HOTKNIFE_OUT"].ToString();
                lblLaserOut.Text = arg_dt.Rows[0]["LASER_OUT"].ToString();
                lblTotalHotKnifeOutBottom.Text = arg_dt.Rows[0]["TOTAL_HOTKNIFE_OUT_BOTTOM"].ToString();


                lblUVIn.Text = arg_dt.Rows[0]["UV_IN"].ToString();
                lblUVInBottom.Text = arg_dt.Rows[0]["UV_IN_BOTTOM"].ToString();

                lblUVMin.Text = arg_dt.Rows[0]["UV_MIN"].ToString();
                lblUVMinBottom.Text = arg_dt.Rows[0]["UV_MIN_BOTTOM"].ToString();

                lblUVOut.Text = arg_dt.Rows[0]["UV_OUT"].ToString();
                lblUVOutBottom.Text = arg_dt.Rows[0]["UV_OUT_BOTTOM"].ToString();

                lblUVInvent.Text = arg_dt.Rows[0]["UV_INVENT"].ToString();
                lblUVInventBottom.Text = arg_dt.Rows[0]["UV_INVENT_BOTTOM"].ToString();

                lblSprayMin.Text = arg_dt.Rows[0]["SPRAY_MIN"].ToString();
                lblSprayMinBottom.Text = arg_dt.Rows[0]["SPRAY_MIN_BOTTOM"].ToString();

                lblDaily_Plan.Text = "Daily Plan: " + arg_dt.Rows[0]["DAILY_PLAN"].ToString();

                lblPT_Day.Text = "Lead Time = " + arg_dt.Rows[0]["LT_DAY"].ToString();
                lblPT_Sec.Text = "Processing Time = " + arg_dt.Rows[0]["PROCESS_TIME"].ToString();


               
            }
        }

        private void add_data(Panel arg_pn, DataTable arg_dt)
        {


            foreach (Label con in arg_pn.Controls.OfType<Label>())
            {
                if (con.Name.Substring(0, 3) == "lbl")
                {

                    // Label lbl = (Label)con;
                    // str_column = con.Name.ToUpper();
                    con.Text = arg_dt.Rows[0][con.Name.Remove(0,3)].ToString();

                }

            }
        }

        private void add_pEnd(Panel arg_pn )
        {
           
            _pEnd[1] = lnX2.EndPoint.X;
            _pEnd[2] = lnX3.EndPoint.X;
           
            
            _pEnd[5] = lnY6.EndPoint.Y;
            _pEnd[6] = lnY7.EndPoint.Y;
            _pEnd[7] = lnY8.EndPoint.Y;
           
            for (int i = 0; i < _pStatus.Length; i++)
            {
                _pStatus[i] = true;
            }

        }


        #endregion Func


        #region DB
        private DataTable LOAD_DATA_LEADTIME()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;
            try
            {
                string process_name = "SEPHIROTH.PKG_IPEX3.SELECT_LEAD_TIME_COMP_DMP";
                //ARGMODE
                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = process_name;
                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";
                MyOraDB.Parameter_Type[0] = (char)OracleType.Cursor;
                MyOraDB.Parameter_Values[0] = "";
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

        #endregion DB


        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                icount++;
                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
                //blink_oval(oval_Z1_CND);
                //blink_oval(oval_Z2_CND);
                //blink_oval(oval_Z3_CND);
                //blink_oval(oval_Z4_CND);
                //blink_oval(oval_Z5_CND);
                //blink_oval(oval_Z6_CND);
                //blind();
                if (icount == 10)
                {
                    icount = 0;
                    DataTable dt = LOAD_DATA_LEADTIME();
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        load_data(dt);
                    }
                } 
            }
            catch (Exception)
            {
            } 
        }

        void blind()
        {
            if (lblPT_Day.BackColor == Color.DeepSkyBlue)
            {
                lblPT_Day.BackColor = Color.Yellow;
                lblPT_Day.ForeColor = Color.Black;
                lblPT_Sec.BackColor = Color.Yellow;
                lblPT_Sec.ForeColor = Color.Black;
            }
            else
            {
                lblPT_Day.BackColor = Color.DeepSkyBlue;
                lblPT_Day.ForeColor = Color.White;
                lblPT_Sec.BackColor = Color.DeepSkyBlue;
                lblPT_Sec.ForeColor = Color.White;
            }
        }



        private void setup_pn_truck(Panel arg_pn_truck, bool visible, Panel arg_pn_hide)
        {
            //if (visible)
            //{
            //    arg_pn_truck.Width = 110;
            //    arg_pn_truck.Height = pn_z1.Height;
            //    arg_pn_truck.Location = new Point(0, 0);
            //    arg_pn_truck.Visible = true;

            //    arg_pn_hide.Width = pn_z1.Width - arg_pn_truck.Width;
            //    arg_pn_hide.Height = arg_pn_truck.Height;
            //    arg_pn_hide.Location = new Point(arg_pn_truck.Width, 0);
            //    arg_pn_hide.Visible = true;
            //}
            //else
            //{
            //    arg_pn_truck.Visible = false;
            //    arg_pn_hide.Visible = false;
            //}
        }

        private void animation()
        {
            //setup_pn_truck(pnZ1_truck, true, pnZ1_hide);
            //timerZ1.Interval = 10;
            //timerZ1.Start();

            //setup_pn_truck(pnZ2_truck, true, pnZ2_hide);
            //timerZ2.Interval = 10;
            //timerZ2.Start();

            //setup_pn_truck(pnZ3_truck, true, pnZ3_hide);
            //timerZ3.Interval = 10;
            //timerZ3.Start();

            //setup_pn_truck(pnZ4_truck, true, pnZ4_hide);
            //timerZ4.Interval = 10;
            //timerZ4.Start();

            //setup_pn_truck(pnZ5_truck, true, pnZ5_hide);
            //timerZ5.Interval = 10;
            //timerZ5.Start();

            //setup_pn_truck(pnZ6_truck, true, pnZ6_hide);
            //timerZ6.Interval = 10;
            //timerZ6.Start();
        }

        private void blink_oval(OvalShape arg_oval)
        {
            //if (arg_oval.FillColor == Color.Red)
            //{
            //    arg_oval.FillColor = Color.Yellow;
            //    arg_oval.BorderColor = Color.Yellow;
            //    foreach (Control con in pn_body.Controls)
            //    {
            //        if (con.Name.Length >= 10 && con.Name.Substring(0, 10) == "lbl" + arg_oval.Name.Replace("oval","") && con.BackColor==Color.Red)
            //        {
            //            con.BackColor = Color.Yellow;
            //            con.ForeColor = Color.Black;
            //        }

            //    }
            //}
            //else
            //{
            //    arg_oval.FillColor = Color.Red;
            //    arg_oval.BorderColor = Color.Red;
            //    foreach (Control con in pn_body.Controls)
            //    {
            //        if (con.Name.Length >= 10 && con.Name.Substring(0, 10) == "lbl" + arg_oval.Name.Replace("oval", "") && con.BackColor == Color.Yellow)
            //        {
            //            con.BackColor = Color.Red;
            //            con.ForeColor = Color.White;

            //        }

            //    }
            //}
        }

        private void FORM_IPEX3_LOGISTIC_VisibleChanged(object sender, EventArgs e)
        {

                if (this.Visible)
                {
                   // pn_body.Hide();
                    timer1.Start();
                    DataTable dt = LOAD_DATA_LEADTIME();
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        load_data(dt);
                    }
                  //  animation();
                    
                    

                    
                    
                 //   pn_body.Show();
                    
                    
                }
                else
                {
                    
                    timer1.Stop();
                    timerZ1.Stop();
                    timerZ2.Stop();
                    timerZ3.Stop();
                    timerZ4.Stop();
                    timerZ5.Stop();
                    timerZ6.Stop();
                    
                }
        }

        
       

        private void FORM_IPEX3_LOGISTIC_Load(object sender, EventArgs e)
        {
         //   pn_z1.Hide();

            GoFullscreen(true);
           // _myPen.Width = _wlr;

            lblTitle.Text = "Cold Shot - DMP (Lead Time)";

            add_pEnd(pn_body);

           // iStopTruck = picZ1.Location.X ;
            
         //   IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.pn_z1.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("1"));           
         //   pn_z1.Show();    
          //  load_data(LOAD_DATA_LEADTIME());
           
           // lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
            
            
        }




        private void lblDate_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {

            }

        }

        #region Lable Paint

        private void lblLeft_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = (Label)sender;
            Graphics v = e.Graphics;
            DrawRoundRect(v, _myPen, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 20, 2);
        }

        private void lblRec_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = (Label)sender;
            Graphics v = e.Graphics;
            DrawRoundRect(v, _myPen, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 20, 5);
        }

        private void lblRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNomal_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = (Label)sender;
            Graphics v = e.Graphics;
          //  DrawRoundRect(v, _myPen, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 20, 0);

            ControlPaint.DrawBorder(e.Graphics, lbl.DisplayRectangle, Color.Blue, _wn, ButtonBorderStyle.Solid,
                                                                      Color.Blue, _wn, ButtonBorderStyle.Solid,
                                                                      Color.Blue, _wn, ButtonBorderStyle.Solid,
                                                                      Color.Blue, _wn, ButtonBorderStyle.Solid);
        }


        private void lineArrow_Paint(object sender, PaintEventArgs e)
        {
            LineShape line = (LineShape)sender;
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 3);
            pen.StartCap = LineCap.ArrowAnchor;
            pen.EndCap = LineCap.NoAnchor;
            e.Graphics.DrawLine(pen, line.EndPoint, line.StartPoint);    
        }


        private void lineArrow_Paint2(object sender, PaintEventArgs e)
        {
            LineShape line = (LineShape)sender;
            int stt;
            
           // pen.StartCap = LineCap.ArrowAnchor;
            //pen.EndCap = LineCap.NoAnchor;
          //  line.EndPoint = new Point(line.EndPoint.X + 5, line.EndPoint.Y);
            stt = Convert.ToInt32(line.Name.Replace("lnX", "").Replace("lnY", ""));
            if (line.Name.Substring(1, 3) == "lnX")
            {
                if (line.StartPoint.X < line.EndPoint.X && _pStatus[stt - 1] == true)
                {
                    line.X2 = line.X2 - 1;

                }
                else
                {
                    _pStatus[stt - 1] = false;
                }

                if (line.EndPoint.X < _pEnd[stt - 1] && _pStatus[stt - 1] == false)
                {
                    line.X2 = line.X2 + 1;
                }
                else
                {
                    _pStatus[stt - 1] = true;
                }
            }
            else
            {
                if (line.StartPoint.Y < line.EndPoint.Y && _pStatus[stt - 1] == true)
                {
                    line.Y2 = line.Y2 - 1;

                }
                else
                {
                    _pStatus[stt - 1] = false;
                }

                if (line.EndPoint.Y < _pEnd[stt - 1] && _pStatus[stt - 1] == false)
                {
                    line.Y2 = line.Y2 + 1;
                }
                else
                {
                    _pStatus[stt - 1] = true;
                }
            }

           // e.Graphics.DrawLine(pen, line.EndPoint, line.StartPoint);
        }




        private void draw_lineArrow(LineShape line, string X_Y)
        {
            if (X_Y == "X")
            {
                line.EndPoint = new Point(line.EndPoint.X - 5, line.EndPoint.Y);
            }
            else
                line.EndPoint = new Point(line.EndPoint.X, line.EndPoint.Y-5);
            
        }

        private void lblDaily_Plan_Click(object sender, EventArgs e)
        {
            // draw_lineArrow(lineShape78,"X");
      
            lnX2.Visible = false;
            lnX2.Visible = true;
            lnX3.Visible = false;
            lnX3.Visible = true;

           
            lnX2.Paint += lineArrow_Paint2;
            lnX3.Paint += lineArrow_Paint2;

        }

        private void panel94_Click(object sender, EventArgs e)
        {
           // lnX1.Paint -= lineArrow_Paint2;
        }

        #endregion Lable Paint


        private void timerZ1_Tick(object sender, EventArgs e)
        {
            //lineArrow_Paint2(lnX1);
            //lineArrow_Paint2(lnX2);
            //lineArrow_Paint2(lnX3);
            //if (pnZ1_truck.Location.X >= iStopTruck)
            //{
            //    setup_pn_truck(pnZ1_truck, false, pnZ1_hide);
            //    timerZ1.Stop();

            //}
            //else
            //{
            //    pnZ1_truck.Location = new Point(pnZ1_truck.Location.X + _speed, pnZ1_truck.Location.Y);
            //    pnZ1_hide.Location = new Point(pnZ1_hide.Location.X + _speed, pnZ1_hide.Location.Y);
            //    pnZ1_hide.Width = pnZ1_hide.Width - _speed;
            //}
        }

        private void timerZ2_Tick(object sender, EventArgs e)
        {
            //if (pnZ2_truck.Location.X >= iStopTruck)
            //{
            //    setup_pn_truck(pnZ2_truck, false, pnZ2_hide);
            //    timerZ2.Stop();
            //}
            //else
            //{
            //    pnZ2_truck.Location = new Point(pnZ2_truck.Location.X + _speed, pnZ2_truck.Location.Y);
            //    pnZ2_hide.Location = new Point(pnZ2_hide.Location.X + _speed, pnZ2_hide.Location.Y);
            //    pnZ2_hide.Width = pnZ2_hide.Width - _speed;
            //}
        }

        private void timerZ3_Tick(object sender, EventArgs e)
        {
            //if (pnZ3_truck.Location.X >= iStopTruck)
            //{
            //    setup_pn_truck(pnZ3_truck, false, pnZ3_hide);
            //    timerZ3.Stop();
            //}
            //else
            //{
            //    pnZ3_truck.Location = new Point(pnZ3_truck.Location.X + _speed, pnZ3_truck.Location.Y);
            //    pnZ3_hide.Location = new Point(pnZ3_hide.Location.X + _speed, pnZ3_hide.Location.Y);
            //    pnZ3_hide.Width = pnZ3_hide.Width - _speed;
            //}
        }

        private void timerZ4_Tick(object sender, EventArgs e)
        {
            //if (pnZ4_truck.Location.X >= iStopTruck)
            //{
            //    setup_pn_truck(pnZ4_truck, false, pnZ4_hide);
            //    timerZ4.Stop();
            //}
            //else
            //{
            //    pnZ4_truck.Location = new Point(pnZ4_truck.Location.X + _speed, pnZ4_truck.Location.Y);
            //    pnZ4_hide.Location = new Point(pnZ4_hide.Location.X + _speed, pnZ4_hide.Location.Y);
            //    pnZ4_hide.Width = pnZ4_hide.Width - _speed;
            //}
        }

        private void timerZ5_Tick(object sender, EventArgs e)
        {
            //if (pnZ5_truck.Location.X >= iStopTruck)
            //{
            //    setup_pn_truck(pnZ5_truck, false, pnZ5_hide);
            //    timerZ5.Stop();
            //}
            //else
            //{
            //    pnZ5_truck.Location = new Point(pnZ5_truck.Location.X + _speed, pnZ5_truck.Location.Y);
            //    pnZ5_hide.Location = new Point(pnZ5_hide.Location.X + _speed, pnZ5_hide.Location.Y);
            //    pnZ5_hide.Width = pnZ5_hide.Width - _speed;
            //}
        }

        private void timerZ6_Tick(object sender, EventArgs e)
        {
            //if (pnZ6_truck.Location.X >= iStopTruck)
            //{
            //    setup_pn_truck(pnZ6_truck, false, pnZ6_hide);
            //    timerZ6.Stop();






            //}
            //else
            //{
            //    pnZ6_truck.Location = new Point(pnZ6_truck.Location.X + _speed, pnZ6_truck.Location.Y);
            //    pnZ6_hide.Location = new Point(pnZ6_hide.Location.X + _speed, pnZ6_hide.Location.Y);
            //    pnZ6_hide.Width = pnZ6_hide.Width - _speed;







            //}
        }

        private void pn_left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lineShape82_Paint(object sender, PaintEventArgs e)
        {
            LineShape line = (LineShape)sender;
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 3);
            pen.StartCap = LineCap.ArrowAnchor;
            pen.EndCap = LineCap.NoAnchor;
            e.Graphics.DrawLine(pen, line.EndPoint, line.StartPoint);   
        }

        private void pn_bottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       

        

       




    }
}
