namespace Smart_FTY
{
    partial class FORM_PH_KPI_PERFOMANCE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_PH_KPI_PERFOMANCE));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pn_body = new System.Windows.Forms.Panel();
            this.cmd_C1 = new System.Windows.Forms.Button();
            this.cmd_C4 = new System.Windows.Forms.Button();
            this.cmd_C2 = new System.Windows.Forms.Button();
            this.cmd_C3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.axGrid_C4 = new AxFPUSpreadADO.AxfpSpread();
            this.chart_C2 = new ChartDirector.WinChartViewer();
            this.chart_C3 = new ChartDirector.WinChartViewer();
            this.axGrid_C1 = new AxFPUSpreadADO.AxfpSpread();
            this.axGrid_C2 = new AxFPUSpreadADO.AxfpSpread();
            this.axGrid_C3 = new AxFPUSpreadADO.AxfpSpread();
            this.chart_C1 = new ChartDirector.WinChartViewer();
            this.chart_C4 = new ChartDirector.WinChartViewer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pn_body.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGrid_C4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_C3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGrid_C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGrid_C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGrid_C3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_C4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Turquoise;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 45.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1916, 100);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "KPI Performance";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.BackColor = System.Drawing.Color.Turquoise;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDate.Location = new System.Drawing.Point(1662, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(255, 93);
            this.lblDate.TabIndex = 47;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // pn_body
            // 
            this.pn_body.Controls.Add(this.cmd_C1);
            this.pn_body.Controls.Add(this.cmd_C4);
            this.pn_body.Controls.Add(this.cmd_C2);
            this.pn_body.Controls.Add(this.cmd_C3);
            this.pn_body.Controls.Add(this.panel1);
            this.pn_body.Controls.Add(this.axGrid_C4);
            this.pn_body.Controls.Add(this.chart_C2);
            this.pn_body.Controls.Add(this.chart_C3);
            this.pn_body.Controls.Add(this.axGrid_C1);
            this.pn_body.Controls.Add(this.axGrid_C2);
            this.pn_body.Controls.Add(this.axGrid_C3);
            this.pn_body.Controls.Add(this.chart_C1);
            this.pn_body.Controls.Add(this.chart_C4);
            this.pn_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_body.Location = new System.Drawing.Point(0, 100);
            this.pn_body.Name = "pn_body";
            this.pn_body.Size = new System.Drawing.Size(1916, 954);
            this.pn_body.TabIndex = 48;
            // 
            // cmd_C1
            // 
            this.cmd_C1.BackColor = System.Drawing.Color.Navy;
            this.cmd_C1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_C1.FlatAppearance.BorderSize = 0;
            this.cmd_C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_C1.Location = new System.Drawing.Point(613, 435);
            this.cmd_C1.Name = "cmd_C1";
            this.cmd_C1.Size = new System.Drawing.Size(61, 53);
            this.cmd_C1.TabIndex = 103;
            this.cmd_C1.UseVisualStyleBackColor = false;
            // 
            // cmd_C4
            // 
            this.cmd_C4.BackColor = System.Drawing.Color.Navy;
            this.cmd_C4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_C4.FlatAppearance.BorderSize = 0;
            this.cmd_C4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_C4.Location = new System.Drawing.Point(1575, 887);
            this.cmd_C4.Name = "cmd_C4";
            this.cmd_C4.Size = new System.Drawing.Size(61, 55);
            this.cmd_C4.TabIndex = 102;
            this.cmd_C4.UseVisualStyleBackColor = false;
            // 
            // cmd_C2
            // 
            this.cmd_C2.BackColor = System.Drawing.Color.Navy;
            this.cmd_C2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_C2.FlatAppearance.BorderSize = 0;
            this.cmd_C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_C2.Location = new System.Drawing.Point(1575, 433);
            this.cmd_C2.Name = "cmd_C2";
            this.cmd_C2.Size = new System.Drawing.Size(61, 55);
            this.cmd_C2.TabIndex = 101;
            this.cmd_C2.UseVisualStyleBackColor = false;
            // 
            // cmd_C3
            // 
            this.cmd_C3.BackColor = System.Drawing.Color.Navy;
            this.cmd_C3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_C3.FlatAppearance.BorderSize = 0;
            this.cmd_C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_C3.Location = new System.Drawing.Point(604, 890);
            this.cmd_C3.Name = "cmd_C3";
            this.cmd_C3.Size = new System.Drawing.Size(61, 55);
            this.cmd_C3.TabIndex = 100;
            this.cmd_C3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1916, 34);
            this.panel1.TabIndex = 99;
            this.panel1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1287, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(626, 33);
            this.label3.TabIndex = 90;
            this.label3.Text = "APS 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(173)))), ((int)(((byte)(71)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(651, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 33);
            this.label1.TabIndex = 88;
            this.label1.Text = "APS 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(626, 33);
            this.label2.TabIndex = 89;
            this.label2.Text = "APS 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axGrid_C4
            // 
            this.axGrid_C4.DataSource = null;
            this.axGrid_C4.Location = new System.Drawing.Point(969, 820);
            this.axGrid_C4.Name = "axGrid_C4";
            this.axGrid_C4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrid_C4.OcxState")));
            this.axGrid_C4.Size = new System.Drawing.Size(940, 125);
            this.axGrid_C4.TabIndex = 97;
            // 
            // chart_C2
            // 
            this.chart_C2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_C2.Location = new System.Drawing.Point(970, 42);
            this.chart_C2.Name = "chart_C2";
            this.chart_C2.Size = new System.Drawing.Size(940, 322);
            this.chart_C2.TabIndex = 96;
            this.chart_C2.TabStop = false;
            // 
            // chart_C3
            // 
            this.chart_C3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_C3.Location = new System.Drawing.Point(12, 495);
            this.chart_C3.Name = "chart_C3";
            this.chart_C3.Size = new System.Drawing.Size(940, 322);
            this.chart_C3.TabIndex = 94;
            this.chart_C3.TabStop = false;
            // 
            // axGrid_C1
            // 
            this.axGrid_C1.DataSource = null;
            this.axGrid_C1.Location = new System.Drawing.Point(12, 368);
            this.axGrid_C1.Name = "axGrid_C1";
            this.axGrid_C1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrid_C1.OcxState")));
            this.axGrid_C1.Size = new System.Drawing.Size(940, 123);
            this.axGrid_C1.TabIndex = 93;
            // 
            // axGrid_C2
            // 
            this.axGrid_C2.DataSource = null;
            this.axGrid_C2.Location = new System.Drawing.Point(969, 366);
            this.axGrid_C2.Name = "axGrid_C2";
            this.axGrid_C2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrid_C2.OcxState")));
            this.axGrid_C2.Size = new System.Drawing.Size(940, 125);
            this.axGrid_C2.TabIndex = 92;
            // 
            // axGrid_C3
            // 
            this.axGrid_C3.DataSource = null;
            this.axGrid_C3.Location = new System.Drawing.Point(12, 820);
            this.axGrid_C3.Name = "axGrid_C3";
            this.axGrid_C3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrid_C3.OcxState")));
            this.axGrid_C3.Size = new System.Drawing.Size(940, 128);
            this.axGrid_C3.TabIndex = 91;
            // 
            // chart_C1
            // 
            this.chart_C1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_C1.Location = new System.Drawing.Point(12, 43);
            this.chart_C1.Name = "chart_C1";
            this.chart_C1.Size = new System.Drawing.Size(940, 322);
            this.chart_C1.TabIndex = 85;
            this.chart_C1.TabStop = false;
            // 
            // chart_C4
            // 
            this.chart_C4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_C4.Location = new System.Drawing.Point(969, 495);
            this.chart_C4.Name = "chart_C4";
            this.chart_C4.Size = new System.Drawing.Size(940, 322);
            this.chart_C4.TabIndex = 83;
            this.chart_C4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.BackgroundImage = global::Smart_FTY.Properties.Resources.Back_Icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1493, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 96);
            this.button1.TabIndex = 53;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // FORM_PH_KPI_PERFOMANCE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1916, 1054);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pn_body);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Name = "FORM_PH_KPI_PERFOMANCE";
            this.Text = "FORM_OSD_EXTERNAL";
            this.Load += new System.EventHandler(this.FORM_IPEX3_LOGISTIC_Load);
            this.VisibleChanged += new System.EventHandler(this.FORM_IPEX3_LOGISTIC_VisibleChanged);
            this.pn_body.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axGrid_C4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_C3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGrid_C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGrid_C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGrid_C3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_C4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pn_body;
        private System.Windows.Forms.Timer timer1;
        private ChartDirector.WinChartViewer chart_C1;
        private ChartDirector.WinChartViewer chart_C4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private AxFPUSpreadADO.AxfpSpread axGrid_C3;
        private System.Windows.Forms.Label label3;
        private AxFPUSpreadADO.AxfpSpread axGrid_C2;
        private AxFPUSpreadADO.AxfpSpread axGrid_C1;
        private ChartDirector.WinChartViewer chart_C3;
        private ChartDirector.WinChartViewer chart_C2;
        private AxFPUSpreadADO.AxfpSpread axGrid_C4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmd_C2;
        private System.Windows.Forms.Button cmd_C3;
        private System.Windows.Forms.Button cmd_C1;
        private System.Windows.Forms.Button cmd_C4;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button button1;
       
    }
}