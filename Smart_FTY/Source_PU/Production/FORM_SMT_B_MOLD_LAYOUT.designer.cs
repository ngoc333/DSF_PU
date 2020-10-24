namespace Smart_FTY
{
    partial class FORM_SMT_B_MOLD_LAYOUT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_SMT_B_MOLD_LAYOUT));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmr_blind = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblPH3 = new System.Windows.Forms.Label();
            this.lblPH2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPH1 = new System.Windows.Forms.Label();
            this.lblCMP2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.blTotal = new System.Windows.Forms.Label();
            this.lbl_Actual = new System.Windows.Forms.Label();
            this.lblbalace = new System.Windows.Forms.Label();
            this.lbl_Plan = new System.Windows.Forms.Label();
            this.axGrid = new AxFPSpreadADO.AxfpSpread();
            this.pnHeader.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.pnFormType.SuspendLayout();
            this.pn2.SuspendLayout();
            this.pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Text = "2019-09-18\n11:44:07";
            // 
            // cmdYear
            // 
            this.cmdYear.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdYear.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdYear.Appearance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdYear.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cmdYear.Appearance.Options.UseBackColor = true;
            this.cmdYear.Appearance.Options.UseFont = true;
            this.cmdYear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdYear.ImageOptions.Image")));
            // 
            // cmdMonth
            // 
            this.cmdMonth.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdMonth.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdMonth.Appearance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold);
            this.cmdMonth.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cmdMonth.Appearance.Options.UseBackColor = true;
            this.cmdMonth.Appearance.Options.UseFont = true;
            this.cmdMonth.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdMonth.ImageOptions.Image")));
            // 
            // cmdDay
            // 
            this.cmdDay.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdDay.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdDay.Appearance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold);
            this.cmdDay.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cmdDay.Appearance.Options.UseBackColor = true;
            this.cmdDay.Appearance.Options.UseFont = true;
            this.cmdDay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdDay.ImageOptions.Image")));
            // 
            // pnButton
            // 
            this.pnButton.BackColor = System.Drawing.Color.Transparent;
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.Color.Transparent;
            this.cmdBack.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.cmdBack.FlatAppearance.BorderSize = 0;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // lblShift
            // 
            this.lblShift.Size = new System.Drawing.Size(413, 53);
            this.lblShift.Text = "Shift 2 (14:00 ~ 22:00)";
            // 
            // lblPhylon
            // 
            this.lblPhylon.ForeColor = System.Drawing.Color.Black;
            this.lblPhylon.Click += new System.EventHandler(this.lblPH1_Click);
            // 
            // lblCMP
            // 
            this.lblCMP.ForeColor = System.Drawing.Color.Black;
            this.lblCMP.Click += new System.EventHandler(this.lblCMP_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmr_blind
            // 
            this.tmr_blind.Tick += new System.EventHandler(this.tmr_blind_Tick);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(718, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 27);
            this.label8.TabIndex = 675;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 16.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(767, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 27);
            this.label9.TabIndex = 676;
            this.label9.Text = "Mold Change";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 16.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(960, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 27);
            this.label10.TabIndex = 678;
            this.label10.Text = "No Plan";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(911, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 26);
            this.label11.TabIndex = 677;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 16.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(767, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 27);
            this.label12.TabIndex = 680;
            this.label12.Text = "Mold Isues";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(718, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 27);
            this.label13.TabIndex = 679;
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Calibri", 16.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(1133, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 27);
            this.label14.TabIndex = 682;
            this.label14.Text = "Mold Cleaning";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Orange;
            this.label15.Location = new System.Drawing.Point(1084, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 27);
            this.label15.TabIndex = 681;
            this.label15.Visible = false;
            // 
            // lblPH3
            // 
            this.lblPH3.BackColor = System.Drawing.Color.Gray;
            this.lblPH3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPH3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPH3.ForeColor = System.Drawing.Color.Black;
            this.lblPH3.Location = new System.Drawing.Point(1778, 165);
            this.lblPH3.Name = "lblPH3";
            this.lblPH3.Size = new System.Drawing.Size(90, 40);
            this.lblPH3.TabIndex = 685;
            this.lblPH3.Text = "C";
            this.lblPH3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPH3.Click += new System.EventHandler(this.lblPH3_Click);
            // 
            // lblPH2
            // 
            this.lblPH2.BackColor = System.Drawing.Color.Gray;
            this.lblPH2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPH2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPH2.ForeColor = System.Drawing.Color.Black;
            this.lblPH2.Location = new System.Drawing.Point(1687, 165);
            this.lblPH2.Name = "lblPH2";
            this.lblPH2.Size = new System.Drawing.Size(90, 40);
            this.lblPH2.TabIndex = 684;
            this.lblPH2.Text = "B";
            this.lblPH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPH2.Click += new System.EventHandler(this.lblPH2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(960, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 27);
            this.label1.TabIndex = 687;
            this.label1.Text = "Plan";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(911, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 26);
            this.label2.TabIndex = 686;
            // 
            // lblPH1
            // 
            this.lblPH1.BackColor = System.Drawing.Color.LightGray;
            this.lblPH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPH1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPH1.ForeColor = System.Drawing.Color.Black;
            this.lblPH1.Location = new System.Drawing.Point(1596, 165);
            this.lblPH1.Name = "lblPH1";
            this.lblPH1.Size = new System.Drawing.Size(90, 40);
            this.lblPH1.TabIndex = 688;
            this.lblPH1.Text = "A";
            this.lblPH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPH1.Click += new System.EventHandler(this.lblPH1_Click);
            // 
            // lblCMP2
            // 
            this.lblCMP2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCMP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCMP2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMP2.ForeColor = System.Drawing.Color.White;
            this.lblCMP2.Location = new System.Drawing.Point(1553, 2);
            this.lblCMP2.Name = "lblCMP2";
            this.lblCMP2.Size = new System.Drawing.Size(121, 67);
            this.lblCMP2.TabIndex = 689;
            this.lblCMP2.Text = "CMP";
            this.lblCMP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCMP2.Click += new System.EventHandler(this.lblCMP_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(892, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 30);
            this.label3.TabIndex = 694;
            this.label3.Text = "Plan";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1049, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 30);
            this.label4.TabIndex = 695;
            this.label4.Text = "No Plan";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // blTotal
            // 
            this.blTotal.BackColor = System.Drawing.Color.Gray;
            this.blTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blTotal.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blTotal.ForeColor = System.Drawing.Color.Black;
            this.blTotal.Location = new System.Drawing.Point(1459, 165);
            this.blTotal.Name = "blTotal";
            this.blTotal.Size = new System.Drawing.Size(136, 40);
            this.blTotal.TabIndex = 696;
            this.blTotal.Text = "Total";
            this.blTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.blTotal.Click += new System.EventHandler(this.blTotal_Click);
            // 
            // lbl_Actual
            // 
            this.lbl_Actual.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_Actual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Actual.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Actual.ForeColor = System.Drawing.Color.White;
            this.lbl_Actual.Location = new System.Drawing.Point(936, 170);
            this.lbl_Actual.Name = "lbl_Actual";
            this.lbl_Actual.Size = new System.Drawing.Size(225, 32);
            this.lbl_Actual.TabIndex = 699;
            this.lbl_Actual.Text = "Total Actual: 704";
            this.lbl_Actual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Actual.Visible = false;
            // 
            // lblbalace
            // 
            this.lblbalace.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblbalace.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.lblbalace.ForeColor = System.Drawing.Color.White;
            this.lblbalace.Location = new System.Drawing.Point(1187, 172);
            this.lblbalace.Name = "lblbalace";
            this.lblbalace.Size = new System.Drawing.Size(225, 30);
            this.lblbalace.TabIndex = 698;
            this.lblbalace.Text = "Total Balance:  704";
            this.lblbalace.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblbalace.Visible = false;
            // 
            // lbl_Plan
            // 
            this.lbl_Plan.BackColor = System.Drawing.Color.Green;
            this.lbl_Plan.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Plan.ForeColor = System.Drawing.Color.White;
            this.lbl_Plan.Location = new System.Drawing.Point(693, 170);
            this.lbl_Plan.Name = "lbl_Plan";
            this.lbl_Plan.Size = new System.Drawing.Size(225, 30);
            this.lbl_Plan.TabIndex = 697;
            this.lbl_Plan.Text = "Total Plan:  704";
            this.lbl_Plan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Plan.Visible = false;
            // 
            // axGrid
            // 
            this.axGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.axGrid.DataSource = null;
            this.axGrid.Location = new System.Drawing.Point(6, 212);
            this.axGrid.Name = "axGrid";
            this.axGrid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrid.OcxState")));
            this.axGrid.Size = new System.Drawing.Size(1909, 882);
            this.axGrid.TabIndex = 660;
            this.axGrid.Advance += new AxFPSpreadADO._DSpreadEvents_AdvanceEventHandler(this.axGrid_Advance);
            this.axGrid.ClickEvent += new AxFPSpreadADO._DSpreadEvents_ClickEventHandler(this.axGrid_ClickEvent);
            this.axGrid.BeforeEditMode += new AxFPSpreadADO._DSpreadEvents_BeforeEditModeEventHandler(this.axGrid_BeforeEditMode);
            // 
            // FORM_SMT_B_MOLD_LAYOUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1092);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Actual);
            this.Controls.Add(this.lblbalace);
            this.Controls.Add(this.lbl_Plan);
            this.Controls.Add(this.blTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCMP2);
            this.Controls.Add(this.lblPH1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPH3);
            this.Controls.Add(this.lblPH2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.axGrid);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Name = "FORM_SMT_B_MOLD_LAYOUT";
            this.Text = "Mold";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Mold_WS_Change_By_Shift_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Mold_WS_Change_By_Shift_Load);
            this.VisibleChanged += new System.EventHandler(this.Frm_Mold_WS_Change_By_Shift_VisibleChanged);
            this.Controls.SetChildIndex(this.axGrid, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.lblPH2, 0);
            this.Controls.SetChildIndex(this.lblPH3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblPH1, 0);
            this.Controls.SetChildIndex(this.lblCMP2, 0);
            this.Controls.SetChildIndex(this.pnHeader, 0);
            this.Controls.SetChildIndex(this.pnFormType, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.blTotal, 0);
            this.Controls.SetChildIndex(this.lbl_Plan, 0);
            this.Controls.SetChildIndex(this.lblbalace, 0);
            this.Controls.SetChildIndex(this.lbl_Actual, 0);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.pnFormType.ResumeLayout(false);
            this.pn2.ResumeLayout(false);
            this.pn1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxFPSpreadADO.AxfpSpread axGrid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmr_blind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblPH3;
        private System.Windows.Forms.Label lblPH2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPH1;
        private System.Windows.Forms.Label lblCMP2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label blTotal;
        private System.Windows.Forms.Label lbl_Actual;
        private System.Windows.Forms.Label lblbalace;
        private System.Windows.Forms.Label lbl_Plan;
    }
}