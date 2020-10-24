namespace Smart_FTY
{
    partial class FORM_MOLD_ACTUAL_PLAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_MOLD_ACTUAL_PLAN));
            this.axGrid = new AxFPSpreadADO.AxfpSpread();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmr_blind = new System.Windows.Forms.Timer(this.components);
            this.lblDmp = new System.Windows.Forms.Label();
            this.lblDmc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_actual = new System.Windows.Forms.Label();
            this.lbl_plan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Shift = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // axGrid
            // 
            this.axGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.axGrid.DataSource = null;
            this.axGrid.Location = new System.Drawing.Point(12, 160);
            this.axGrid.Name = "axGrid";
            this.axGrid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrid.OcxState")));
            this.axGrid.Size = new System.Drawing.Size(1893, 910);
            this.axGrid.TabIndex = 660;
            this.axGrid.ClickEvent += new AxFPSpreadADO._DSpreadEvents_ClickEventHandler(this.axGrid_ClickEvent);
            this.axGrid.BeforeEditMode += new AxFPSpreadADO._DSpreadEvents_BeforeEditModeEventHandler(this.axGrid_BeforeEditMode);
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
            // lblDmp
            // 
            this.lblDmp.BackColor = System.Drawing.Color.IndianRed;
            this.lblDmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDmp.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDmp.ForeColor = System.Drawing.Color.Black;
            this.lblDmp.Location = new System.Drawing.Point(1023, 39);
            this.lblDmp.Name = "lblDmp";
            this.lblDmp.Size = new System.Drawing.Size(120, 50);
            this.lblDmp.TabIndex = 685;
            this.lblDmp.Text = "DMP";
            this.lblDmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDmp.Visible = false;
            this.lblDmp.Click += new System.EventHandler(this.lblDmp_Click);
            // 
            // lblDmc
            // 
            this.lblDmc.BackColor = System.Drawing.Color.Gray;
            this.lblDmc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDmc.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDmc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDmc.Location = new System.Drawing.Point(897, 39);
            this.lblDmc.Name = "lblDmc";
            this.lblDmc.Size = new System.Drawing.Size(120, 50);
            this.lblDmc.TabIndex = 684;
            this.lblDmc.Text = "DMC";
            this.lblDmc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDmc.Visible = false;
            this.lblDmc.Click += new System.EventHandler(this.lblDmc_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 45.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1920, 109);
            this.lblTitle.TabIndex = 686;
            this.lblTitle.Text = "DMC APS Planing && Actual Production";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDate.Location = new System.Drawing.Point(1666, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(253, 109);
            this.lblDate.TabIndex = 687;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1128, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 31);
            this.label6.TabIndex = 690;
            this.label6.Text = "Mold Change";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1127, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 38);
            this.label1.TabIndex = 693;
            this.label1.Text = "No Plan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_actual
            // 
            this.lbl_actual.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_actual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_actual.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actual.ForeColor = System.Drawing.Color.White;
            this.lbl_actual.Location = new System.Drawing.Point(1489, 3);
            this.lbl_actual.Name = "lbl_actual";
            this.lbl_actual.Size = new System.Drawing.Size(172, 104);
            this.lbl_actual.TabIndex = 695;
            this.lbl_actual.Text = "Total Actual 450";
            this.lbl_actual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_actual.Click += new System.EventHandler(this.lbl_actual_Click);
            // 
            // lbl_plan
            // 
            this.lbl_plan.BackColor = System.Drawing.Color.Green;
            this.lbl_plan.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plan.ForeColor = System.Drawing.Color.White;
            this.lbl_plan.Location = new System.Drawing.Point(1310, 3);
            this.lbl_plan.Name = "lbl_plan";
            this.lbl_plan.Size = new System.Drawing.Size(178, 104);
            this.lbl_plan.TabIndex = 694;
            this.lbl_plan.Text = "Total Plan  458";
            this.lbl_plan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_plan.Click += new System.EventHandler(this.lbl_plan_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.BackgroundImage = global::Smart_FTY.Properties.Resources.Back_Icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1013, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 101);
            this.button1.TabIndex = 696;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Shift
            // 
            this.lbl_Shift.BackColor = System.Drawing.Color.Blue;
            this.lbl_Shift.Font = new System.Drawing.Font("Calibri", 20.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Shift.ForeColor = System.Drawing.Color.White;
            this.lbl_Shift.Location = new System.Drawing.Point(958, 115);
            this.lbl_Shift.Name = "lbl_Shift";
            this.lbl_Shift.Size = new System.Drawing.Size(154, 38);
            this.lbl_Shift.TabIndex = 697;
            this.lbl_Shift.Text = "SHIFT 1";
            this.lbl_Shift.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Shift.Visible = false;
            // 
            // FORM_MOLD_ACTUAL_PLAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1920, 1072);
            this.Controls.Add(this.lbl_Shift);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_actual);
            this.Controls.Add(this.lbl_plan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDmp);
            this.Controls.Add(this.lblDmc);
            this.Controls.Add(this.axGrid);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FORM_MOLD_ACTUAL_PLAN";
            this.Text = "Production Status";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Mold_WS_Change_By_Shift_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Mold_WS_Change_By_Shift_Load);
            this.VisibleChanged += new System.EventHandler(this.Frm_Mold_WS_Change_By_Shift_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxFPSpreadADO.AxfpSpread axGrid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmr_blind;
        private System.Windows.Forms.Label lblDmp;
        private System.Windows.Forms.Label lblDmc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_actual;
        private System.Windows.Forms.Label lbl_plan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Shift;
    }
}