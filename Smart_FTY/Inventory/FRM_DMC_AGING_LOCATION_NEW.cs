using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OracleClient;
using System.Windows.Forms.Integration;

namespace IPEX_Monitor
{
    public partial class FRM_DMC_AGING_LOCATION_NEW : Form
    {
        public FRM_DMC_AGING_LOCATION_NEW()
        {
            InitializeComponent();
        }
        #region Variable
        DataTable _dt_Shelf = null;
        DataTable dt = null;
        DataTable dtHeader = null;
        DataTable dtSummary = null;
        DataTable dtRTNLocate = null;
        DataTable dtGroupBox = null;
        int intC = 0;
        int rows_dt_shelf;
        int index = 1;
        Color Color_CanAging = Color.Green;
        Color Color_NotAging = Color.Red;
        Color BackColor_Default = Color.White;
        Dictionary<string, int>[] _Dic_Location = new Dictionary<string, int>[1];
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X4;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;
        const int AW_HIDE = 0x00010000;
        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);
        #endregion

        #region Oracle
        public DataTable SELECT_DMP_SHELF_MASTER()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_DMC_LOCATION.SEL_DMP_SHELF_MASTER_NEW";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";


                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;


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


        public DataTable SEL_DMC_DETAIL_BY_CELL(string ARG_LOCATE)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_DMC_AGING_LOCATION.SEL_DMC_DETAIL_BY_CELL";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_LOCATE";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = ARG_LOCATE;
                MyOraDB.Parameter_Values[1] = "";


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


        public DataTable SEL_DMC_HEADER_INFOR(string ARG_LOCATE)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_DMC_AGING_LOCATION.SEL_DMC_HEADER_INFOR";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_LOCATE";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = ARG_LOCATE;
                MyOraDB.Parameter_Values[1] = "";


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
        // SEL_DMC_SUMPROD_BY_CELL
        public DataTable SEL_DMC_SUMPROD_BY_CELL(string ARG_LOCATE)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_DMC_AGING_LOCATION.SEL_DMC_SUMPROD_BY_CELL";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_LOCATE";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = ARG_LOCATE;
                MyOraDB.Parameter_Values[1] = "";


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


        // SEL_DMC_SUMPROD_BY_CELL
        public DataTable SEL_DMC_SUMPROD_BY_TOTAL()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_DMC_AGING_LOCATION.SEL_DMC_SUMPROD_BY_TOTAL";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = process_name;


                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";


                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;


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



        public DataTable SEL_DMC_CELL_FULL_CAPA()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_DMC_AGING_LOCATION.SEL_DMC_CELL_FULL_CAPA";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";


                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;


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


        public DataTable SEL_RTN_LOCATE()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_DMC_AGING_LOCATION.SEL_RTN_LOCATE";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";


                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;


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

        #endregion


        private void Animation(Control ctl)
        {
            ctl.Hide();
            this.Cursor = Cursors.WaitCursor;
            AnimateWindow(ctl.Handle, 500, AW_SLIDE | 0X4); //IPEX_Monitor.ClassLib.WinAPI.getSlidType("2")
            ctl.Show();
            this.Cursor = Cursors.Default;

        }


        //FullScreen
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

        //Box
        private void InitLocation()
        {
            try
            {
                rows_dt_shelf = _dt_Shelf.Rows.Count;
                //int x1 = Convert.ToInt32(_dt_Shelf.Rows[0]["group1_x"]);
                //int y1 = Convert.ToInt32(_dt_Shelf.Rows[0]["group1_y"]);

                //int x2 = Convert.ToInt32(_dt_Shelf.Rows[0]["group1_x"]);
                //int y2 = Convert.ToInt32(_dt_Shelf.Rows[0]["group1_y"]);

                int y0 = 100;
                int x, y, w_element, h_element, w_box, h_box, plus_x;
                x = Convert.ToInt32(_dt_Shelf.Rows[0]["col_x"]);
                y = Convert.ToInt32(_dt_Shelf.Rows[0]["col_y"]);
                plus_x = Convert.ToInt32(_dt_Shelf.Rows[0]["plus_x"]);
                bool b_background = false;

                //CreateBox(x, y, _dt_Shelf.Rows[0]["shelf"].ToString(), "", _dt_Shelf.Rows[0]["cell"].ToString(), w, h, false);

                for (int i = 0; i < rows_dt_shelf; i++)
                {
                    switch (_dt_Shelf.Rows[i]["status"].ToString())
                    {
                        case "":
                            x += Convert.ToInt32(_dt_Shelf.Rows[i]["plus_x"]); ;
                            y = y0;
                            b_background = true;
                            break;
                        case "NEW_LINE":
                            x = Convert.ToInt32(_dt_Shelf.Rows[i]["col_x"]);
                            y = Convert.ToInt32(_dt_Shelf.Rows[i]["col_y"]);
                            y0 = y;
                            b_background = false;
                            break;

                    }
                    w_element = Convert.ToInt32(_dt_Shelf.Rows[i]["element_host_W"]);
                    h_element = Convert.ToInt32(_dt_Shelf.Rows[i]["element_host_H"]);
                    w_box = Convert.ToInt32(_dt_Shelf.Rows[i]["box_W"]);
                    h_box = Convert.ToInt32(_dt_Shelf.Rows[i]["box_H"]);

                    CreateBox(x, y, _dt_Shelf.Rows[i]["shelf"].ToString(), _dt_Shelf.Rows[i]["info"].ToString(), "", _dt_Shelf.Rows[i]["cell"].ToString(), w_element, h_element, w_box, h_box, b_background);
                    _Dic_Location[0] = new Dictionary<string, int>();


                }
                for (int i = 0; i < splMain.Panel1.Controls.Count; i++)
                {
                    _Dic_Location[0].Add(splMain.Panel1.Controls[i].Name, i);
                }

            }
            catch (Exception) { }
        }

        private LocationBox.BoxSmall1 get_box(string arg_name)
        {
            try
            {
                if (_Dic_Location[0].ContainsKey(arg_name))
                {
                    ElementHost element = (ElementHost)splMain.Panel1.Controls[_Dic_Location[0][arg_name]];
                    return (LocationBox.BoxSmall1)element.Child;
                }
                else return null;
            }
            catch (Exception ex)
            { return null; }
        }


        private void LoadDataCaptionBox(DataTable dt)
        {
            try
            {
                //   int iShelf = 0;

                for (int i = 0; i < dt.Rows.Count; i++) //splMain.Panel1.Controls.Count - 5
                {
                    for (int j = 0; j < splMain.Panel1.Controls.Count ; j++)
                    {
                        if (get_box(splMain.Panel1.Controls[j].Name.ToString()) != null)
                        {
                            if (get_box(splMain.Panel1.Controls[j].Name.ToString()).Caption1.Equals(dt.Rows[i]["SHELF"].ToString()))
                            {
                                get_box(splMain.Panel1.Controls[j].Name.ToString()).Caption = dt.Rows[i]["INFO"].ToString();
                                get_box(splMain.Panel1.Controls[j].Name.ToString()).SetCaption();
                            }
                        }
                    }



                    //if (get_box(dt.Rows[i]["SHELF"].ToString()) != null)
                    //{
                    //    if (get_box(dt.Rows[iShelf]["SHELF"].ToString()).Caption1.Equals(dt.Rows[i]["SHELF"].ToString()))
                    //    {
                    //        get_box(dt.Rows[iShelf]["SHELF"].ToString()).Caption = dt.Rows[i]["INFO"].ToString();
                    //        get_box(dt.Rows[iShelf]["SHELF"].ToString()).SetCaption();
                    //        iShelf++;
                    //    }
                    //}

                }
            }
            catch (Exception ex)
            { }
        }

        private void CreateBox(int x, int y, string shelf, string info, string floor, string cell, int w_element, int h_element, int w_box, int h_box, bool bg_clolor)
        {
            //this.BeginInvoke((Action)(() =>
            //{

            System.Windows.Forms.Integration.ElementHost Element = new System.Windows.Forms.Integration.ElementHost();
            LocationBox.BoxSmall1 box = new LocationBox.BoxSmall1();

            box.setSizeBox(w_box, h_box);
            box.setVisible(bg_clolor);
            //   box.Caption = shelf.Substring(0, 1);
            box.Caption = info;
            box.SetCaption();
            // box.Caption1 = shelf.Substring(1, 2);
            box.Caption1 = shelf; //shelf;
            box.SetCaption1();
            box.TabIndex = index;

            box.Name = "A" + shelf.Substring(0, 3);
            box.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(BoxHead_MouseLeftButtonUp);

            Element.Name = shelf;
            Element.Location = new Point(x, y);
            Element.Size = new Size(w_element, h_element);
            Element.TabIndex = index;
            //  if (bg_clolor) Element.BackColor = Color.SkyBlue;
            Element.Child = box;
            //  if (bf== true) 
            //     Element.SendToBack();
            // Element.BringToFront();
            // Element.BackColor = Color.White;

            //perform on the UI thread
            //     this.Controls.Add(Element);

            splMain.Panel1.Controls.Add(Element);

            //this.Controls.Add(Element);
            Element.BringToFront();
            index++;
            //}));
        }
        string Box_Name_;
        private void BoxHead_MouseLeftButtonUp(object sender, System.EventArgs e)
        {
            LocationBox.BoxSmall1 box = (LocationBox.BoxSmall1)sender;
            //  axfpData.SetText(1, 1, "SHELF TESTING: " + box.Name.Replace("A", ""));
            //  lblModel.Text = "TESTING INDEX: " + box.TabIndex.ToString();

            // ResetBoxClick();
            // box.BoxColorChange();
            intC = 0;
            this.Cursor = Cursors.WaitCursor;
            lblShelf_TEXT.Text = box.Name.Replace("A", "");
            LoadDetailByCell(box.Name.Replace("A", ""));
            Box_Name_ = box.Name.Replace("A", "");
            _dt_Shelf = SELECT_DMP_SHELF_MASTER();
            LoadDataCaptionBox(_dt_Shelf);

            /*--------phuoc tam dong
             */
            ElementHost element;
            foreach (Control cont in splMain.Panel1.Controls)
            {
                if (cont is ElementHost && cont.TabIndex == box.TabIndex + 1)
                {
                    element = (ElementHost)cont;
                    box = (LocationBox.BoxSmall1)element.Child;
                    string str = box.Name.ToString();
                    //box.BoxPolygonColor(false);
                }
            }


            BoxFully();
            intC = 0;

            this.Cursor = Cursors.Default;
            // if (!bgwGrid.IsBusy)
            //   bgwGrid.RunWorkerAsync();
        }

        private void LoadDetailByCell(string ARG_LOCATE)
        {
            dt = SEL_DMC_DETAIL_BY_CELL(ARG_LOCATE);
            dtHeader = SEL_DMC_HEADER_INFOR(ARG_LOCATE);
            dtSummary = SEL_DMC_SUMPROD_BY_CELL(ARG_LOCATE);
            ClearGrid(axfpData);
            int iCol = 1;
            int iRow = 2;
            lblTotal_A_TEXT.Text = "000";
            lblAging_A_TEXT.Text = "000";
            lblNotAging_A_TEXT.Text = "000";
            //lblOver.Text = "000";
            if (dt != null && dt.Rows.Count > 0 && dtHeader != null && dtHeader.Rows.Count > 0 && dtSummary != null && dtSummary.Rows.Count > 0)
            {
                axfpData.SetText(1, 1, dtHeader.Rows[0][0].ToString());
                //lblModel.Text = dtHeader.Rows[0][1].ToString();
                //lblStyleCD.Text = dtHeader.Rows[0][2].ToString();
                lblTotal_A_TEXT.Text = Convert.ToDouble(dtSummary.Rows[0][0]).ToString("#,0#");
                lblAging_A_TEXT.Text = Convert.ToDouble(dtSummary.Rows[0][1]).ToString("#,0#");
                lblNotAging_A_TEXT.Text = Convert.ToDouble(dtSummary.Rows[0][2]).ToString("#,0#");
                //lblOver.Text = Convert.ToDouble(dtSummary.Rows[0][3]).ToString("#,0#");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    axfpData.SetText(iCol, iRow, dt.Rows[i]["info"].ToString());
                    axfpData.Row = iRow;
                    axfpData.Col = iCol;
                    switch (dt.Rows[i]["Color"].ToString())
                    {
                        case "BLACK":
                            axfpData.BackColor = Color.Black;
                            axfpData.ForeColor = Color.White;
                            break;
                        case "GREEN":
                            axfpData.BackColor = Color_CanAging;
                            axfpData.ForeColor = Color.White;
                            break;
                        case "RED":
                            axfpData.BackColor = Color_NotAging;
                            axfpData.ForeColor = Color.White;
                            break;
                        case "YELLOW":
                            axfpData.BackColor = Color.Yellow;
                            axfpData.ForeColor = Color.Black;
                            break;
                    }
                    iCol++;
                    if (iCol == 11)
                    {
                        iRow++;
                        iCol = 1;
                    }
                }
            }

        }




        private void BoxFully()
        {
            try
            {
                DataTable dt = SEL_DMC_CELL_FULL_CAPA();
                LocationBox.BoxSmall1 box;
                ElementHost element;
                int index = 0;
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["COLOR"].ToString() == "DOGBLUE")
                        {
                            foreach (Control cont in splMain.Panel1.Controls)
                            {
                                if (cont is ElementHost && (cont.Name == dt.Rows[i]["LOCATE"].ToString()))
                                {
                                    element = (ElementHost)cont;
                                    box = (LocationBox.BoxSmall1)element.Child;
                                    string str = box.Name.ToString();
                                    box.BoxColorFullCapa();

                                    index = cont.TabIndex + 1;
                                    foreach (Control cont1 in splMain.Panel1.Controls)
                                    {
                                        if (cont1 is ElementHost && cont1.TabIndex == index)
                                        {
                                            element = (ElementHost)cont1;
                                            box = (LocationBox.BoxSmall1)element.Child;
                                            box.BoxPolygonColorFullCapa(false);
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            //Have Data
                            //foreach (Control cont in splMain.Panel1.Controls)
                            //{
                            //    if (cont is ElementHost && (cont.Name == dt.Rows[i]["LOCATE"].ToString()))
                            //    {
                            //        element = (ElementHost)cont;
                            //        box = (LocationBox.BoxSmall1)element.Child;
                            //        string str = box.Name.ToString();
                            //        box.BoxColorHasData();

                            //        index = cont.TabIndex + 1;
                            //        foreach (Control cont1 in splMain.Panel1.Controls)
                            //        {
                            //            if (cont1 is ElementHost && cont1.TabIndex == index)
                            //            {
                            //                element = (ElementHost)cont1;
                            //                box = (LocationBox.BoxSmall1)element.Child;
                            //                box.BoxPolygonColorHasData(false);
                            //            }
                            //        }
                            //    }
                            //}

                        }
                    }

                }
            }
            catch { }
        }

        private void ResetBoxClick()
        {
            //ElementHost element;
            LocationBox.BoxSmall1 box;
            ElementHost element;

            foreach (Control cont in splMain.Panel1.Controls)
            {
                if (cont is ElementHost)
                {
                    element = (ElementHost)cont;
                    box = (LocationBox.BoxSmall1)element.Child;
                    box.BoxColorDefault();
                    box.BoxPolygonColor(true);
                }
            }



        }

        private void FRM_DMP_SET_BALANCE_Load(object sender, EventArgs e)
        {
            int index = 0;
            ClearGrid(axfpData);
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            GoFullscreen(true);
            _dt_Shelf = SELECT_DMP_SHELF_MASTER();
            dtGroupBox = SEL_DMC_SUMPROD_BY_TOTAL();


            InitLocation();
            Animation(axfpData);
            BoxFully();
            DataTable dtRTNLocate = SEL_RTN_LOCATE();
            Box_Name_ = dtRTNLocate.Rows[0][0].ToString();
            if (dtRTNLocate != null && dtRTNLocate.Rows.Count > 0)
            {
                LocationBox.BoxSmall1 box = new LocationBox.BoxSmall1();
                ElementHost element;
                foreach (Control cont in splMain.Panel1.Controls)
                {
                    if (cont is ElementHost && cont.Name == dtRTNLocate.Rows[0][0].ToString())
                    {

                        element = (ElementHost)cont;
                        box = (LocationBox.BoxSmall1)element.Child;
                        //box.BoxColorChange();



                        index = cont.TabIndex + 1;
                        foreach (Control cont1 in splMain.Panel1.Controls)
                        {
                            if (cont1 is ElementHost && cont1.TabIndex == index)
                            {
                                element = (ElementHost)cont1;
                                box = (LocationBox.BoxSmall1)element.Child;
                                //   box.BoxPolygonColor(false);
                            }
                        }
                    }
                }

                LoadDetailByCell(dtRTNLocate.Rows[0][0].ToString());
                lblShelf_TEXT.Text = dtRTNLocate.Rows[0][0].ToString();
                if (dtGroupBox != null && dtGroupBox.Rows.Count > 0)
                {
                    // lblSetArea.Text = dtGroupBox.Rows[0][0].ToString();
                    if (!bgwGrid.IsBusy)
                        bgwGrid.RunWorkerAsync();

                }
            }
            Control[] lbl = new Control[] { label1, lblFullCapa, lblAging_A_TEXT, lblEnough_A, lblTotal_A, lblTotal_A_TEXT, lblNotAging_A_TEXT, lblShelf, lblShelf_TEXT };
            //label1.BringToFront(); lblFullCapa.BringToFront();
            //lblTotal_A.BringToFront();
            for (int i = 0; i < lbl.Length; i++)
            {
                lbl[i].BringToFront();
            }
            gbAging.BringToFront();
        }

        //Clear Data & set default Color for Grid
        private void ClearGrid(AxFPSpreadADO.AxfpSpread Grid)
        {
            try
            {
                for (int irow = 2; irow <= Grid.MaxRows; irow++)
                {
                    Grid.Row = irow;
                    for (int icol = 1; icol <= Grid.MaxCols; icol++)
                    {
                        Grid.Col = icol;
                        Grid.SetText(icol, irow, "");
                        Grid.BackColor = BackColor_Default;
                        Grid.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            { }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblFullCapa_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            _dt_Shelf = SELECT_DMP_SHELF_MASTER();
            LoadDataCaptionBox(_dt_Shelf);
        }

        private void bgwGrid_DoWork(object sender, DoWorkEventArgs e)
        {
            // Animation(axfpData);
            if (lblSetArea.InvokeRequired)
                lblSetArea.Invoke((MethodInvoker)
                delegate
                {
                    lblSetArea.Text = dtGroupBox.Rows[0][0].ToString();

                });
            if (lblEnoughTotal.InvokeRequired)
                lblEnoughTotal.Invoke((MethodInvoker)
                delegate
                {

                    lblEnoughTotal.Text = dtGroupBox.Rows[0][1].ToString();

                });

            if (lblNotYetEnoughTotal.InvokeRequired)
                lblNotYetEnoughTotal.Invoke((MethodInvoker)
                delegate
                {


                    lblNotYetEnoughTotal.Text = dtGroupBox.Rows[0][2].ToString();
                });
        }

        private void axfpData_ClickEvent(object sender, AxFPSpreadADO._DSpreadEvents_ClickEvent e)
        {

        }

        private void elementHost31_ChildChanged(object sender, ChildChangedEventArgs e)
        {

        }

        private void elementHost25_ChildChanged(object sender, ChildChangedEventArgs e)
        {

        }

        private void elementHost26_ChildChanged(object sender, ChildChangedEventArgs e)
        {

        }

        private void elementHost27_ChildChanged(object sender, ChildChangedEventArgs e)
        {

        }

        private void elementHost28_ChildChanged(object sender, ChildChangedEventArgs e)
        {

        }

        private void elementHost29_ChildChanged(object sender, ChildChangedEventArgs e)
        {

        }

        private void elementHost30_ChildChanged(object sender, ChildChangedEventArgs e)
        {

        }

        private void tmr_Date_Tick(object sender, EventArgs e)
        {
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            intC++;
            if (intC >= 60)
            {
                int index = 0;
                ClearGrid(axfpData);

                dtGroupBox = SEL_DMC_SUMPROD_BY_TOTAL();

                ResetBoxClick();
                //InitLocation();
                _dt_Shelf = SELECT_DMP_SHELF_MASTER();
                LoadDataCaptionBox(_dt_Shelf);
                //Animation(axfpData);
                BoxFully();
                //===========================================================
                //DataTable dtRTNLocate = SEL_RTN_LOCATE();
                //if (dtRTNLocate != null && dtRTNLocate.Rows.Count > 0)
                //{
                    LocationBox.BoxSmall1 box = new LocationBox.BoxSmall1();
                    ElementHost element;
                    foreach (Control cont in splMain.Panel1.Controls)
                    {
                        if (cont is ElementHost && cont.Name == Box_Name_)
                        {

                            element = (ElementHost)cont;
                            box = (LocationBox.BoxSmall1)element.Child;
                            // box.BoxColorChange();

                            index = cont.TabIndex + 1;
                            foreach (Control cont1 in splMain.Panel1.Controls)
                            {
                                if (cont1 is ElementHost && cont1.TabIndex == index)
                                {
                                    element = (ElementHost)cont1;
                                    box = (LocationBox.BoxSmall1)element.Child;
                                  
                                }
                            }
                        }
                   }

                    LoadDetailByCell(Box_Name_);
                    lblShelf_TEXT.Text = Box_Name_;
                //===========================================================


                    if (dtGroupBox != null && dtGroupBox.Rows.Count > 0)
                    {
                        // lblSetArea.Text = dtGroupBox.Rows[0][0].ToString();
                        if (!bgwGrid.IsBusy)
                            bgwGrid.RunWorkerAsync();
                    }
               // }
                Control[] lbl = new Control[] { label1, lblFullCapa, lblAging_A_TEXT, lblEnough_A, lblTotal_A, lblTotal_A_TEXT, lblNotAging_A_TEXT, lblShelf, lblShelf_TEXT };
                //label1.BringToFront(); lblFullCapa.BringToFront();
                //lblTotal_A.BringToFront();
                for (int i = 0; i < lbl.Length; i++)
                {
                    lbl[i].BringToFront();
                }


                intC = 0;
            }
        }

        private void lblDate_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBoxEx1_Enter(object sender, EventArgs e)
        {

        }
    }
}
