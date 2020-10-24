namespace Smart_FTY
{
    partial class FRM_DMP_OSD_EXTERNAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DMP_OSD_EXTERNAL));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pn_body = new System.Windows.Forms.Panel();
            this.lbl_avg_month = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart4 = new ChartDirector.WinChartViewer();
            this.chart3 = new ChartDirector.WinChartViewer();
            this.chart2 = new ChartDirector.WinChartViewer();
            this.chart1 = new ChartDirector.WinChartViewer();
            this.chart_center = new ChartDirector.WinChartViewer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_daily_chart = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.axfpSpread1 = new AxFPSpreadADO.AxfpSpread();
            this.pn_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_center)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axfpSpread1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1914, 109);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "External OS&&D";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDate.Location = new System.Drawing.Point(1662, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(253, 109);
            this.lblDate.TabIndex = 47;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // pn_body
            // 
            this.pn_body.Controls.Add(this.lbl_avg_month);
            this.pn_body.Controls.Add(this.label3);
            this.pn_body.Controls.Add(this.label2);
            this.pn_body.Controls.Add(this.label1);
            this.pn_body.Controls.Add(this.axfpSpread1);
            this.pn_body.Controls.Add(this.chart4);
            this.pn_body.Controls.Add(this.chart3);
            this.pn_body.Controls.Add(this.chart2);
            this.pn_body.Controls.Add(this.chart1);
            this.pn_body.Controls.Add(this.chart_center);
            this.pn_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_body.Location = new System.Drawing.Point(0, 109);
            this.pn_body.Name = "pn_body";
            this.pn_body.Size = new System.Drawing.Size(1914, 945);
            this.pn_body.TabIndex = 48;
            // 
            // lbl_avg_month
            // 
            this.lbl_avg_month.AutoSize = true;
            this.lbl_avg_month.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_avg_month.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avg_month.ForeColor = System.Drawing.Color.White;
            this.lbl_avg_month.Location = new System.Drawing.Point(698, 15);
            this.lbl_avg_month.Name = "lbl_avg_month";
            this.lbl_avg_month.Size = new System.Drawing.Size(195, 33);
            this.lbl_avg_month.TabIndex = 92;
            this.lbl_avg_month.Text = "Average Month:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1793, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 33);
            this.label3.TabIndex = 91;
            this.label3.Text = "Unit: PRS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1054, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 33);
            this.label2.TabIndex = 88;
            this.label2.Text = "Weekly Defective";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 33);
            this.label1.TabIndex = 87;
            this.label1.Text = "Daily Defective";
            // 
            // chart4
            // 
            this.chart4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chart4.Location = new System.Drawing.Point(1485, 501);
            this.chart4.Name = "chart4";
            this.chart4.Size = new System.Drawing.Size(425, 440);
            this.chart4.TabIndex = 85;
            this.chart4.TabStop = false;
            // 
            // chart3
            // 
            this.chart3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chart3.Location = new System.Drawing.Point(1052, 501);
            this.chart3.Name = "chart3";
            this.chart3.Size = new System.Drawing.Size(425, 440);
            this.chart3.TabIndex = 84;
            this.chart3.TabStop = false;
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chart2.Location = new System.Drawing.Point(1485, 54);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(425, 440);
            this.chart2.TabIndex = 83;
            this.chart2.TabStop = false;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.Location = new System.Drawing.Point(1052, 53);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(425, 440);
            this.chart1.TabIndex = 82;
            this.chart1.TabStop = false;
            // 
            // chart_center
            // 
            this.chart_center.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_center.Location = new System.Drawing.Point(4, 53);
            this.chart_center.Name = "chart_center";
            this.chart_center.Size = new System.Drawing.Size(1036, 550);
            this.chart_center.TabIndex = 81;
            this.chart_center.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_daily_chart
            // 
            this.timer_daily_chart.Tick += new System.EventHandler(this.timer_daily_chart_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1533, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 109);
            this.button1.TabIndex = 59;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // axfpSpread1
            // 
            this.axfpSpread1.DataSource = null;
            this.axfpSpread1.Location = new System.Drawing.Point(4, 628);
            this.axfpSpread1.Name = "axfpSpread1";
            this.axfpSpread1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axfpSpread1.OcxState")));
            this.axfpSpread1.Size = new System.Drawing.Size(1036, 305);
            this.axfpSpread1.TabIndex = 86;
            // 
            // FRM_DMP_OSD_EXTERNAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1914, 1054);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pn_body);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Name = "FRM_DMP_OSD_EXTERNAL";
            this.Text = "FORM_DMP_OSD_EXTERNAL";
            this.Load += new System.EventHandler(this.FORM_IPEX3_LOGISTIC_Load);
            this.VisibleChanged += new System.EventHandler(this.FORM_IPEX3_LOGISTIC_VisibleChanged);
            this.pn_body.ResumeLayout(false);
            this.pn_body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_center)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axfpSpread1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pn_body;
        private System.Windows.Forms.Timer timer1;
        private ChartDirector.WinChartViewer chart4;
        private ChartDirector.WinChartViewer chart3;
        private ChartDirector.WinChartViewer chart2;
        private ChartDirector.WinChartViewer chart1;
        private ChartDirector.WinChartViewer chart_center;
        private AxFPSpreadADO.AxfpSpread axfpSpread1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_daily_chart;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_avg_month;
        private System.Windows.Forms.Button button1;
       
    }
}