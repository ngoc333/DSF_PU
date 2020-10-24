namespace Smart_FTY
{
    partial class Form_Def_PHP
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
       // public virtual System.Drawing.ContentAlignment TextAlign { get; set; }

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
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedLineSeriesLabel stackedLineSeriesLabel1 = new DevExpress.XtraCharts.StackedLineSeriesLabel();
            DevExpress.XtraCharts.StackedLineSeriesView stackedLineSeriesView1 = new DevExpress.XtraCharts.StackedLineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Def_PHP));
            this.pnTitle = new System.Windows.Forms.Panel();
            this.btnCMP = new System.Windows.Forms.Button();
            this.btnOS = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTilte = new System.Windows.Forms.Label();
            this.pnChart = new System.Windows.Forms.Panel();
            this.chartqty2 = new DevExpress.XtraCharts.ChartControl();
            this.axGrid = new AxFPUSpreadADO.AxfpSpread();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnTitle.SuspendLayout();
            this.pnChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartqty2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedLineSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedLineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnTitle.Controls.Add(this.btnCMP);
            this.pnTitle.Controls.Add(this.btnOS);
            this.pnTitle.Controls.Add(this.cmdBack);
            this.pnTitle.Controls.Add(this.lblDate);
            this.pnTitle.Controls.Add(this.lblTilte);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1924, 106);
            this.pnTitle.TabIndex = 0;
            // 
            // btnCMP
            // 
            this.btnCMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCMP.Location = new System.Drawing.Point(1163, 53);
            this.btnCMP.Name = "btnCMP";
            this.btnCMP.Size = new System.Drawing.Size(115, 39);
            this.btnCMP.TabIndex = 4;
            this.btnCMP.Text = "CMP";
            this.btnCMP.UseVisualStyleBackColor = true;
            this.btnCMP.Click += new System.EventHandler(this.btnCMP_Click);
            // 
            // btnOS
            // 
            this.btnOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOS.Location = new System.Drawing.Point(1294, 53);
            this.btnOS.Name = "btnOS";
            this.btnOS.Size = new System.Drawing.Size(115, 39);
            this.btnOS.TabIndex = 4;
            this.btnOS.Text = "OutSole";
            this.btnOS.UseVisualStyleBackColor = true;
            this.btnOS.Click += new System.EventHandler(this.btnOS_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.BackgroundImage = global::Smart_FTY.Properties.Resources.Back_Icon;
            this.cmdBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBack.FlatAppearance.BorderSize = 0;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Location = new System.Drawing.Point(1474, 3);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(110, 102);
            this.cmdBack.TabIndex = 2;
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(1687, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(237, 106);
            this.lblDate.TabIndex = 1;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblTilte
            // 
            this.lblTilte.AutoSize = true;
            this.lblTilte.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Bold);
            this.lblTilte.ForeColor = System.Drawing.Color.White;
            this.lblTilte.Location = new System.Drawing.Point(5, 10);
            this.lblTilte.Name = "lblTilte";
            this.lblTilte.Size = new System.Drawing.Size(783, 82);
            this.lblTilte.TabIndex = 0;
            this.lblTilte.Text = "Phylon Defective By Model";
            // 
            // pnChart
            // 
            this.pnChart.Controls.Add(this.chartqty2);
            this.pnChart.Location = new System.Drawing.Point(2, 108);
            this.pnChart.Name = "pnChart";
            this.pnChart.Size = new System.Drawing.Size(1922, 532);
            this.pnChart.TabIndex = 3;
            // 
            // chartqty2
            // 
            this.chartqty2.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartqty2.DataBindings = null;
            xyDiagram1.AxisX.CrosshairAxisLabelOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xyDiagram1.AxisX.Label.Angle = -45;
            xyDiagram1.AxisX.Label.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xyDiagram1.AxisX.Title.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            xyDiagram1.AxisX.Title.Text = "Date";
            xyDiagram1.AxisX.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.Font = new System.Drawing.Font("Tahoma", 10F);
            xyDiagram1.AxisY.Label.TextPattern = "{V:#,#}";
            xyDiagram1.AxisY.Title.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            xyDiagram1.AxisY.Title.Text = "(Prs)";
            xyDiagram1.AxisY.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            xyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            secondaryAxisY1.AxisID = 0;
            secondaryAxisY1.Name = "Secondary AxisY 1";
            secondaryAxisY1.Tickmarks.MinorVisible = false;
            secondaryAxisY1.VisibleInPanesSerializable = "-1";
            xyDiagram1.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY1});
            this.chartqty2.Diagram = xyDiagram1;
            this.chartqty2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartqty2.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chartqty2.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chartqty2.Legend.Border.Thickness = 2;
            this.chartqty2.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartqty2.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartqty2.Legend.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartqty2.Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.chartqty2.Legend.Name = "Default Legend";
            this.chartqty2.Legend.Shadow.Size = 1;
            this.chartqty2.Legend.Title.Alignment = System.Drawing.StringAlignment.Far;
            this.chartqty2.Legend.Title.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartqty2.Legend.Title.MaxLineCount = 2;
            this.chartqty2.Legend.Title.Text = "Slab Test";
            this.chartqty2.Legend.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chartqty2.Legend.Title.WordWrap = true;
            this.chartqty2.Legend.VerticalIndent = 1;
            this.chartqty2.Location = new System.Drawing.Point(0, 0);
            this.chartqty2.Name = "chartqty2";
            this.chartqty2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            sideBySideBarSeriesLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top;
            sideBySideBarSeriesLabel1.TextPattern = "{V:#,#}";
            series1.Label = sideBySideBarSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "Defect";
            sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            series1.View = sideBySideBarSeriesView1;
            stackedLineSeriesLabel1.TextPattern = "{V}%";
            series2.Label = stackedLineSeriesLabel1;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.Name = "%";
            stackedLineSeriesView1.AxisYName = "Secondary AxisY 1";
            stackedLineSeriesView1.LineMarkerOptions.Size = 13;
            stackedLineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.View = stackedLineSeriesView1;
            this.chartqty2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartqty2.Size = new System.Drawing.Size(1922, 532);
            this.chartqty2.TabIndex = 8;
            chartTitle1.Alignment = System.Drawing.StringAlignment.Near;
            chartTitle1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            chartTitle1.Indent = 0;
            chartTitle1.Text = "Stitching 1";
            chartTitle1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            chartTitle1.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartqty2.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // axGrid
            // 
            this.axGrid.DataSource = null;
            this.axGrid.Location = new System.Drawing.Point(18, 652);
            this.axGrid.Name = "axGrid";
            this.axGrid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrid.OcxState")));
            this.axGrid.Size = new System.Drawing.Size(1890, 410);
            this.axGrid.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Def_PHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1062);
            this.Controls.Add(this.axGrid);
            this.Controls.Add(this.pnChart);
            this.Controls.Add(this.pnTitle);
            this.Name = "Form_Def_PHP";
            this.Text = "Form_Defective_Model";
            this.Load += new System.EventHandler(this.Form_Def_PHP_Load);
            this.VisibleChanged += new System.EventHandler(this.Form_Def_PHP_VisibleChanged);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.pnChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedLineSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedLineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartqty2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lblTilte;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnChart;
        private AxFPUSpreadADO.AxfpSpread axGrid;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraCharts.ChartControl chartqty2;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.Button btnOS;
        private System.Windows.Forms.Button btnCMP;
    }
}