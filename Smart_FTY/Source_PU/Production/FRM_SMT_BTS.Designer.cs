using Smart_FTY.Source_PU.UC;
namespace Smart_FTY
{
    partial class FRM_SMT_BTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SMT_BTS));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Legend legend1 = new DevExpress.XtraCharts.Legend();
            DevExpress.XtraCharts.CustomLegendItem customLegendItem1 = new DevExpress.XtraCharts.CustomLegendItem();
            DevExpress.XtraCharts.CustomLegendItem customLegendItem2 = new DevExpress.XtraCharts.CustomLegendItem();
            DevExpress.XtraCharts.CustomLegendItem customLegendItem3 = new DevExpress.XtraCharts.CustomLegendItem();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.axfpSpread = new AxFPSpreadADO.AxfpSpread();
            this.chartBTS = new DevExpress.XtraCharts.ChartControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.UC_MONTH = new Smart_FTY.Source_PU.UC.UC_MONTH_SELECTION();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axfpSpread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lbltitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(1920, 109);
            this.panel1.MinimumSize = new System.Drawing.Size(1920, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 109);
            this.panel1.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.Enabled = false;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1278, 57);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(175, 48);
            this.simpleButton1.TabIndex = 58;
            this.simpleButton1.Text = "Week";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton4.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton4.Enabled = false;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(1278, 3);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(175, 48);
            this.simpleButton4.TabIndex = 57;
            this.simpleButton4.Text = "Day";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(1459, 58);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(175, 48);
            this.simpleButton3.TabIndex = 56;
            this.simpleButton3.Text = "Year";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton2.Enabled = false;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(1459, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(175, 48);
            this.simpleButton2.TabIndex = 55;
            this.simpleButton2.Text = "Month";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Smart_FTY.Properties.Resources.Back_Icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1164, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 101);
            this.button1.TabIndex = 51;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDate.Location = new System.Drawing.Point(1639, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(281, 109);
            this.lblDate.TabIndex = 49;
            this.lblDate.Text = "lblDate";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lbltitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbltitle.Font = new System.Drawing.Font("Calibri", 62.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(0, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(1920, 109);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "BTS Tracking by Month";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbltitle.Click += new System.EventHandler(this.lbltitle_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Enabled = false;
            this.splitContainer1.Location = new System.Drawing.Point(0, 159);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.axfpSpread);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chartBTS);
            this.splitContainer1.Size = new System.Drawing.Size(1920, 920);
            this.splitContainer1.SplitterDistance = 222;
            this.splitContainer1.TabIndex = 5;
            // 
            // axfpSpread
            // 
            this.axfpSpread.DataSource = null;
            this.axfpSpread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axfpSpread.Location = new System.Drawing.Point(0, 0);
            this.axfpSpread.Name = "axfpSpread";
            this.axfpSpread.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axfpSpread.OcxState")));
            this.axfpSpread.Size = new System.Drawing.Size(1920, 222);
            this.axfpSpread.TabIndex = 0;
            // 
            // chartBTS
            // 
            this.chartBTS.AppearanceNameSerializable = "Chameleon";
            this.chartBTS.DataBindings = null;
            xyDiagram1.AxisX.Label.Font = new System.Drawing.Font("Tahoma", 14F);
            xyDiagram1.AxisX.Title.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            xyDiagram1.AxisX.Title.Text = "Date";
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.Font = new System.Drawing.Font("Tahoma", 14F);
            xyDiagram1.AxisY.Title.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xyDiagram1.AxisY.Title.Text = "(%)";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartBTS.Diagram = xyDiagram1;
            this.chartBTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartBTS.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            this.chartBTS.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chartBTS.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartBTS.Legend.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartBTS.Legend.Name = "Default Legend";
            legend1.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            legend1.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            customLegendItem1.MarkerColor = System.Drawing.Color.LimeGreen;
            customLegendItem1.Name = ">=90%";
            customLegendItem2.MarkerColor = System.Drawing.Color.Yellow;
            customLegendItem2.Name = ">=85% and <90%";
            customLegendItem3.MarkerColor = System.Drawing.Color.Red;
            customLegendItem3.Name = "<85%";
            legend1.CustomItems.AddRange(new DevExpress.XtraCharts.CustomLegendItem[] {
            customLegendItem1,
            customLegendItem2,
            customLegendItem3});
            legend1.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            legend1.Font = new System.Drawing.Font("Tahoma", 12F);
            legend1.Name = "Legend1";
            this.chartBTS.Legends.AddRange(new DevExpress.XtraCharts.Legend[] {
            legend1});
            this.chartBTS.Location = new System.Drawing.Point(0, 0);
            this.chartBTS.Name = "chartBTS";
            this.chartBTS.PaletteName = "Chameleon";
            sideBySideBarSeriesLabel1.TextPattern = "{V:%}";
            series1.Label = sideBySideBarSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "BTS";
            sideBySideBarSeriesView1.Color = System.Drawing.Color.DodgerBlue;
            sideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
            series1.View = sideBySideBarSeriesView1;
            series2.Name = "Target";
            lineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.View = lineSeriesView1;
            this.chartBTS.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartBTS.Size = new System.Drawing.Size(1920, 694);
            this.chartBTS.TabIndex = 0;
            this.chartBTS.CustomDrawAxisLabel += new DevExpress.XtraCharts.CustomDrawAxisLabelEventHandler(this.chartBTS_CustomDrawAxisLabel);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // UC_MONTH
            // 
            this.UC_MONTH.AutoSize = true;
            this.UC_MONTH.Location = new System.Drawing.Point(3, 109);
            this.UC_MONTH.Name = "UC_MONTH";
            this.UC_MONTH.Size = new System.Drawing.Size(472, 46);
            this.UC_MONTH.TabIndex = 6;
            this.UC_MONTH.ValueChangeEvent += new System.EventHandler(this.UC_MONTH_ValueChangeEvent);
            // 
            // FRM_SMT_BTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.UC_MONTH);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_SMT_BTS";
            this.Text = "FRM_SMT_BTS";
            this.Load += new System.EventHandler(this.FRM_SMT_BTS_Load);
            this.VisibleChanged += new System.EventHandler(this.FRM_SMT_BTS_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axfpSpread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraCharts.ChartControl chartBTS;
        private AxFPSpreadADO.AxfpSpread axfpSpread;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private UC_MONTH_SELECTION UC_MONTH;
    }
}