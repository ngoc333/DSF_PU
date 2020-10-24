namespace Smart_FTY
{
    partial class FORM_SMT_B_PROD_MONTHLY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_SMT_B_PROD_MONTHLY));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnRubber = new Smart_FTY.A1Panel();
            this.lblRubber = new System.Windows.Forms.Label();
            this.pnEVA = new Smart_FTY.A1Panel();
            this.lblEVA = new System.Windows.Forms.Label();
            this.axfpSpread = new AxFPUSpreadADO.AxfpSpread();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.tmr_Load = new System.Windows.Forms.Timer(this.components);
            this.pnHeader.SuspendLayout();
            this.pnButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnRubber.SuspendLayout();
            this.pnEVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axfpSpread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Size = new System.Drawing.Size(1904, 106);
            // 
            // lblDate
            // 
            this.lblDate.Size = new System.Drawing.Size(253, 106);
            this.lblDate.Text = "2018-10-03\n14:51:08";
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
            // lblTitle
            // 
            this.lblTitle.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Calibri", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Appearance.Options.UseBackColor = true;
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Appearance.Options.UseForeColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1272, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 103);
            this.panel1.TabIndex = 64;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 106);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnRubber);
            this.splitContainer1.Panel1.Controls.Add(this.pnEVA);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.axfpSpread);
            this.splitContainer1.Panel2.Controls.Add(this.chartControl);
            this.splitContainer1.Size = new System.Drawing.Size(1904, 948);
            this.splitContainer1.SplitterDistance = 62;
            this.splitContainer1.TabIndex = 15;
            // 
            // pnRubber
            // 
            this.pnRubber.AccessibleDescription = "";
            this.pnRubber.AccessibleName = "";
            this.pnRubber.BorderColor = System.Drawing.Color.Empty;
            this.pnRubber.BorderWidth = 2;
            this.pnRubber.Controls.Add(this.lblRubber);
            this.pnRubber.GradientEndColor = System.Drawing.Color.Gray;
            this.pnRubber.GradientStartColor = System.Drawing.Color.White;
            this.pnRubber.Image = null;
            this.pnRubber.ImageLocation = new System.Drawing.Point(4, 4);
            this.pnRubber.Location = new System.Drawing.Point(4, 7);
            this.pnRubber.Name = "pnRubber";
            this.pnRubber.RoundCornerRadius = 20;
            this.pnRubber.ShadowOffSet = 3;
            this.pnRubber.Size = new System.Drawing.Size(153, 49);
            this.pnRubber.TabIndex = 5;
            // 
            // lblRubber
            // 
            this.lblRubber.BackColor = System.Drawing.Color.Transparent;
            this.lblRubber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRubber.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubber.Location = new System.Drawing.Point(0, 0);
            this.lblRubber.Name = "lblRubber";
            this.lblRubber.Size = new System.Drawing.Size(153, 49);
            this.lblRubber.TabIndex = 0;
            this.lblRubber.Text = "Rubber";
            this.lblRubber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRubber.Click += new System.EventHandler(this.lblRubber_Click);
            // 
            // pnEVA
            // 
            this.pnEVA.AccessibleDescription = "";
            this.pnEVA.AccessibleName = "";
            this.pnEVA.BorderColor = System.Drawing.Color.Empty;
            this.pnEVA.BorderWidth = 2;
            this.pnEVA.Controls.Add(this.lblEVA);
            this.pnEVA.GradientEndColor = System.Drawing.Color.White;
            this.pnEVA.GradientStartColor = System.Drawing.Color.White;
            this.pnEVA.Image = null;
            this.pnEVA.ImageLocation = new System.Drawing.Point(4, 4);
            this.pnEVA.Location = new System.Drawing.Point(157, 7);
            this.pnEVA.Name = "pnEVA";
            this.pnEVA.RoundCornerRadius = 20;
            this.pnEVA.ShadowOffSet = 3;
            this.pnEVA.Size = new System.Drawing.Size(153, 49);
            this.pnEVA.TabIndex = 4;
            // 
            // lblEVA
            // 
            this.lblEVA.BackColor = System.Drawing.Color.Transparent;
            this.lblEVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEVA.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEVA.Location = new System.Drawing.Point(0, 0);
            this.lblEVA.Name = "lblEVA";
            this.lblEVA.Size = new System.Drawing.Size(153, 49);
            this.lblEVA.TabIndex = 1;
            this.lblEVA.Text = "EVA";
            this.lblEVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEVA.Click += new System.EventHandler(this.lblEVA_Click);
            // 
            // axfpSpread
            // 
            this.axfpSpread.DataSource = null;
            this.axfpSpread.Location = new System.Drawing.Point(3, 556);
            this.axfpSpread.Name = "axfpSpread";
            this.axfpSpread.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axfpSpread.OcxState")));
            this.axfpSpread.Size = new System.Drawing.Size(1889, 314);
            this.axfpSpread.TabIndex = 1;
            // 
            // chartControl
            // 
            this.chartControl.DataBindings = null;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl.Diagram = xyDiagram1;
            this.chartControl.Legend.Name = "Default Legend";
            this.chartControl.Location = new System.Drawing.Point(4, 2);
            this.chartControl.Name = "chartControl";
            series1.Name = "Series 1";
            series2.Name = "Series 2";
            series2.View = splineSeriesView1;
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartControl.Size = new System.Drawing.Size(1889, 532);
            this.chartControl.TabIndex = 0;
            // 
            // tmr_Load
            // 
            this.tmr_Load.Interval = 1000;
            this.tmr_Load.Tick += new System.EventHandler(this.tmr_Load_Tick);
            // 
            // FORM_SMT_B_PROD_MONTHLY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1054);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FORM_SMT_B_PROD_MONTHLY";
            this.Load += new System.EventHandler(this.FORM_SMT_B_PROD_MONTHLY_Load);
            this.Controls.SetChildIndex(this.pnHeader, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnRubber.ResumeLayout(false);
            this.pnEVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axfpSpread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
       
      
        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private AxFPUSpreadADO.AxfpSpread axfpSpread;
        private System.Windows.Forms.Timer tmr_Load;
        private A1Panel pnEVA;
        private System.Windows.Forms.Label lblEVA;
        private A1Panel pnRubber;
        private System.Windows.Forms.Label lblRubber;
    }
}