namespace Smart_FTY
{
    partial class FORM_SMT_B_MOLD_ACTUAL_PLAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_SMT_B_MOLD_ACTUAL_PLAN));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmr_blind = new System.Windows.Forms.Timer(this.components);
            this.lblPH3 = new System.Windows.Forms.Label();
            this.lblPH2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblDiffPlan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Actual = new System.Windows.Forms.Label();
            this.lbl_Plan = new System.Windows.Forms.Label();
            this.lbl_Shift = new System.Windows.Forms.Label();
            this.lblPH1 = new System.Windows.Forms.Label();
            this.lblCMP2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.lblDate.Text = "2018-11-30\n14:00:47";
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
            // cmdBack
            // 
            this.cmdBack.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.cmdBack.FlatAppearance.BorderSize = 0;
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
            // lblPH3
            // 
            this.lblPH3.BackColor = System.Drawing.Color.LightGray;
            this.lblPH3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPH3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPH3.ForeColor = System.Drawing.Color.Black;
            this.lblPH3.Location = new System.Drawing.Point(1796, 165);
            this.lblPH3.Name = "lblPH3";
            this.lblPH3.Size = new System.Drawing.Size(96, 45);
            this.lblPH3.TabIndex = 685;
            this.lblPH3.Text = "C";
            this.lblPH3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPH3.Click += new System.EventHandler(this.lblPH3_Click);
            // 
            // lblPH2
            // 
            this.lblPH2.BackColor = System.Drawing.Color.LightGray;
            this.lblPH2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPH2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPH2.ForeColor = System.Drawing.Color.Black;
            this.lblPH2.Location = new System.Drawing.Point(1699, 165);
            this.lblPH2.Name = "lblPH2";
            this.lblPH2.Size = new System.Drawing.Size(96, 45);
            this.lblPH2.TabIndex = 684;
            this.lblPH2.Text = "B";
            this.lblPH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPH2.Click += new System.EventHandler(this.lblPH2_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // lblDiffPlan
            // 
            this.lblDiffPlan.BackColor = System.Drawing.Color.Yellow;
            this.lblDiffPlan.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiffPlan.ForeColor = System.Drawing.Color.Black;
            this.lblDiffPlan.Location = new System.Drawing.Point(742, 166);
            this.lblDiffPlan.Name = "lblDiffPlan";
            this.lblDiffPlan.Size = new System.Drawing.Size(225, 31);
            this.lblDiffPlan.TabIndex = 690;
            this.lblDiffPlan.Text = "Difference Plan";
            this.lblDiffPlan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(542, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 693;
            this.label1.Text = "Plan/Acual";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // lbl_Actual
            // 
            this.lbl_Actual.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_Actual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Actual.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Actual.ForeColor = System.Drawing.Color.White;
            this.lbl_Actual.Location = new System.Drawing.Point(1256, 162);
            this.lbl_Actual.Name = "lbl_Actual";
            this.lbl_Actual.Size = new System.Drawing.Size(225, 32);
            this.lbl_Actual.TabIndex = 695;
            this.lbl_Actual.Text = "Total Actual: 704";
            this.lbl_Actual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Plan
            // 
            this.lbl_Plan.BackColor = System.Drawing.Color.Green;
            this.lbl_Plan.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Plan.ForeColor = System.Drawing.Color.White;
            this.lbl_Plan.Location = new System.Drawing.Point(1029, 163);
            this.lbl_Plan.Name = "lbl_Plan";
            this.lbl_Plan.Size = new System.Drawing.Size(225, 30);
            this.lbl_Plan.TabIndex = 694;
            this.lbl_Plan.Text = "Total Plan:  704";
            this.lbl_Plan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Shift
            // 
            this.lbl_Shift.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Shift.Font = new System.Drawing.Font("Calibri", 30.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Shift.ForeColor = System.Drawing.Color.White;
            this.lbl_Shift.Location = new System.Drawing.Point(504, 9);
            this.lbl_Shift.Name = "lbl_Shift";
            this.lbl_Shift.Size = new System.Drawing.Size(204, 52);
            this.lbl_Shift.TabIndex = 696;
            this.lbl_Shift.Text = "Shift 1";
            this.lbl_Shift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPH1
            // 
            this.lblPH1.BackColor = System.Drawing.Color.LightGray;
            this.lblPH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPH1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPH1.ForeColor = System.Drawing.Color.Black;
            this.lblPH1.Location = new System.Drawing.Point(1602, 165);
            this.lblPH1.Name = "lblPH1";
            this.lblPH1.Size = new System.Drawing.Size(96, 45);
            this.lblPH1.TabIndex = 697;
            this.lblPH1.Text = "A";
            this.lblPH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPH1.Click += new System.EventHandler(this.lblPH1_Click);
            // 
            // lblCMP2
            // 
            this.lblCMP2.BackColor = System.Drawing.Color.Gray;
            this.lblCMP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCMP2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMP2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCMP2.Location = new System.Drawing.Point(1598, 6);
            this.lblCMP2.Name = "lblCMP2";
            this.lblCMP2.Size = new System.Drawing.Size(143, 81);
            this.lblCMP2.TabIndex = 698;
            this.lblCMP2.Text = "CMP";
            this.lblCMP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1307, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 35);
            this.label2.TabIndex = 699;
            this.label2.Text = "PHYLON";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axGrid
            // 
            this.axGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.axGrid.DataSource = null;
            this.axGrid.Location = new System.Drawing.Point(5, 216);
            this.axGrid.Name = "axGrid";
            this.axGrid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrid.OcxState")));
            this.axGrid.Size = new System.Drawing.Size(1910, 853);
            this.axGrid.TabIndex = 660;
            this.axGrid.BeforeEditMode += new AxFPSpreadADO._DSpreadEvents_BeforeEditModeEventHandler(this.axGrid_BeforeEditMode);
            // 
            // FORM_SMT_B_MOLD_ACTUAL_PLAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1064);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCMP2);
            this.Controls.Add(this.lblPH1);
            this.Controls.Add(this.lbl_Shift);
            this.Controls.Add(this.lbl_Actual);
            this.Controls.Add(this.lbl_Plan);
            this.Controls.Add(this.lblDiffPlan);
            this.Controls.Add(this.lblPH3);
            this.Controls.Add(this.lblPH2);
            this.Controls.Add(this.axGrid);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FORM_SMT_B_MOLD_ACTUAL_PLAN";
            this.Text = "APS Plan && Actual";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Mold_WS_Change_By_Shift_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Mold_WS_Change_By_Shift_Load);
            this.VisibleChanged += new System.EventHandler(this.Frm_Mold_WS_Change_By_Shift_VisibleChanged);
            this.Controls.SetChildIndex(this.axGrid, 0);
            this.Controls.SetChildIndex(this.lblPH2, 0);
            this.Controls.SetChildIndex(this.lblPH3, 0);
            this.Controls.SetChildIndex(this.lblDiffPlan, 0);
            this.Controls.SetChildIndex(this.lbl_Plan, 0);
            this.Controls.SetChildIndex(this.lbl_Actual, 0);
            this.Controls.SetChildIndex(this.lbl_Shift, 0);
            this.Controls.SetChildIndex(this.lblPH1, 0);
            this.Controls.SetChildIndex(this.lblCMP2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pnHeader, 0);
            this.Controls.SetChildIndex(this.pnFormType, 0);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.pnFormType.ResumeLayout(false);
            this.pn2.ResumeLayout(false);
            this.pn1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxFPSpreadADO.AxfpSpread axGrid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmr_blind;
        private System.Windows.Forms.Label lblPH3;
        private System.Windows.Forms.Label lblPH2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblDiffPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Actual;
        private System.Windows.Forms.Label lbl_Plan;
        private System.Windows.Forms.Label lbl_Shift;
        private System.Windows.Forms.Label lblPH1;
        private System.Windows.Forms.Label lblCMP2;
        private System.Windows.Forms.Label label2;
    }
}