namespace Smart_FTY.Source_PU
{
    partial class FRM_BOTTOM_INV_SET_ANALYSIS
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY1 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView1 = new DevExpress.XtraCharts.StackedBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideStackedBarSeriesView sideBySideStackedBarSeriesView1 = new DevExpress.XtraCharts.SideBySideStackedBarSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Smart_FTY.WaitForm1), true, true);
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdBack = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdBase2 = new DevExpress.XtraGrid.GridControl();
            this.gvwBase2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBase2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwBase2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 54F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1898, 114);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "BOTTOM INVENTORY SET ANALYSIS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1904, 1041);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.cmdBack);
            this.panel1.Controls.Add(this.lblDateTime);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1898, 114);
            this.panel1.TabIndex = 0;
            // 
            // cmdBack
            // 
            this.cmdBack.BackgroundImage = global::Smart_FTY.Properties.Resources.Back_Icon;
            this.cmdBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBack.Location = new System.Drawing.Point(1536, 6);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(108, 101);
            this.cmdBack.TabIndex = 68;
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.Font = new System.Drawing.Font("Calibri", 32F, System.Drawing.FontStyle.Bold);
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDateTime.Location = new System.Drawing.Point(1651, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(244, 109);
            this.lblDateTime.TabIndex = 50;
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdBase2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 583);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1898, 455);
            this.panel2.TabIndex = 3;
            // 
            // grdBase2
            // 
            this.grdBase2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBase2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.grdBase2.Location = new System.Drawing.Point(0, 0);
            this.grdBase2.MainView = this.gvwBase2;
            this.grdBase2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grdBase2.Name = "grdBase2";
            this.grdBase2.Size = new System.Drawing.Size(1898, 455);
            this.grdBase2.TabIndex = 16;
            this.grdBase2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwBase2});
            // 
            // gvwBase2
            // 
            this.gvwBase2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvwBase2.GridControl = this.grdBase2;
            this.gvwBase2.Name = "gvwBase2";
            this.gvwBase2.OptionsView.AllowCellMerge = true;
            this.gvwBase2.OptionsView.ShowGroupPanel = false;
            this.gvwBase2.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvwBase2_RowCellStyle);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chart);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1898, 454);
            this.panel3.TabIndex = 4;
            // 
            // chart
            // 
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.CacheToMemory = true;
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.Default;
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.Label.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.MinIndent = 0;
            xyDiagram1.AxisX.Tag = "4";
            xyDiagram1.AxisX.Tickmarks.Length = 6;
            xyDiagram1.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisX.Title.Text = "Date";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Interlaced = true;
            xyDiagram1.AxisY.Label.Font = new System.Drawing.Font("DotumChe", 9F, System.Drawing.FontStyle.Bold);
            xyDiagram1.AxisY.Title.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            xyDiagram1.AxisY.Title.Text = "Quantity (Prs)";
            xyDiagram1.AxisY.Title.TextColor = System.Drawing.Color.Blue;
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.DependentAxesYRange = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.PaneDistance = 0;
            secondaryAxisY1.AxisID = 0;
            secondaryAxisY1.Label.Visible = false;
            secondaryAxisY1.Name = "Secondary AxisY 1";
            secondaryAxisY1.VisibleInPanesSerializable = "-1";
            secondaryAxisY1.VisualRange.Auto = false;
            secondaryAxisY1.VisualRange.MaxValueSerializable = "130";
            secondaryAxisY1.VisualRange.MinValueSerializable = "0";
            secondaryAxisY1.WholeRange.Auto = false;
            secondaryAxisY1.WholeRange.MaxValueSerializable = "130";
            secondaryAxisY1.WholeRange.MinValueSerializable = "0";
            xyDiagram1.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY1});
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.chart.Name = "chart";
            series1.CrosshairLabelPattern = "{S} : {V:#,0}";
            series1.LegendName = "Default Legend";
            series1.Name = "Inventory";
            stackedBarSeriesView1.Color = System.Drawing.Color.SteelBlue;
            series1.View = stackedBarSeriesView1;
            series2.LegendName = "Default Legend";
            series2.Name = "Set";
            sideBySideStackedBarSeriesView1.Color = System.Drawing.Color.YellowGreen;
            series2.View = sideBySideStackedBarSeriesView1;
            series3.CrosshairLabelPattern = "{S} : {V:#,0}";
            series3.Name = "Target";
            lineSeriesView1.Color = System.Drawing.Color.Red;
            series3.View = lineSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3};
            this.chart.Size = new System.Drawing.Size(1898, 454);
            this.chart.TabIndex = 198;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // FRM_BOTTOM_INV_SET_ANALYSIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_BOTTOM_INV_SET_ANALYSIS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_BOTTOM_INV_SET_ANALYSIS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_BOTTOM_INV_SET_ANALYSIS_Load_1);
            this.VisibleChanged += new System.EventHandler(this.FRM_BOTTOM_INV_SET_ANALYSIS_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBase2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwBase2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl grdBase2;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwBase2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraCharts.ChartControl chart;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Timer tmr;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}