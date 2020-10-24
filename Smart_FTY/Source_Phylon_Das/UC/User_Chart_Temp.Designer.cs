namespace Smart_FTY.UC
{
    partial class User_Chart_Temp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.HatchFillOptions hatchFillOptions1 = new DevExpress.XtraCharts.HatchFillOptions();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedLineSeriesLabel stackedLineSeriesLabel1 = new DevExpress.XtraCharts.StackedLineSeriesLabel();
            DevExpress.XtraCharts.StackedLineSeriesView stackedLineSeriesView1 = new DevExpress.XtraCharts.StackedLineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart_temp = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chart_temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedLineSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedLineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_temp
            // 
            this.chart_temp.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chart_temp.CrosshairOptions.ArgumentLineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dash;
            this.chart_temp.CrosshairOptions.ArgumentLineStyle.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
            this.chart_temp.DataBindings = null;
            xyDiagram1.AxisX.Label.Font = new System.Drawing.Font("Tahoma", 10F);
            xyDiagram1.AxisX.Title.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xyDiagram1.AxisX.Title.Text = "Date";
            xyDiagram1.AxisX.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.Font = new System.Drawing.Font("Tahoma", 11F);
            xyDiagram1.AxisY.Label.TextPattern = "{V:#,#}";
            xyDiagram1.AxisY.Title.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xyDiagram1.AxisY.Title.Text = "Rate (%)";
            xyDiagram1.AxisY.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            xyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chart_temp.Diagram = xyDiagram1;
            this.chart_temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart_temp.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Hatch;
            hatchFillOptions1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            hatchFillOptions1.HatchStyle = System.Drawing.Drawing2D.HatchStyle.DiagonalCross;
            this.chart_temp.FillStyle.Options = hatchFillOptions1;
            this.chart_temp.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart_temp.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop;
            this.chart_temp.Legend.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.chart_temp.Legend.Name = "Default Legend";
            this.chart_temp.Legend.TextOffset = 5;
            this.chart_temp.Legend.Title.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart_temp.Legend.Title.Text = "Slab Test";
            this.chart_temp.Legend.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chart_temp.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart_temp.Location = new System.Drawing.Point(0, 0);
            this.chart_temp.Name = "chart_temp";
            stackedLineSeriesLabel1.Font = new System.Drawing.Font("Tahoma", 12F);
            stackedLineSeriesLabel1.TextPattern = "{V:#,#}";
            series1.Label = stackedLineSeriesLabel1;
            series1.Name = "Max";
            stackedLineSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(105)))), ((int)(((byte)(58)))));
            stackedLineSeriesView1.LineStyle.Thickness = 3;
            series1.View = stackedLineSeriesView1;
            series2.Name = "Min";
            lineSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(105)))), ((int)(((byte)(58)))));
            lineSeriesView1.LineStyle.Thickness = 3;
            series2.View = lineSeriesView1;
            pointSeriesLabel1.Font = new System.Drawing.Font("Tahoma", 12F);
            pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAroundPoint;
            pointSeriesLabel1.TextPattern = "{V:#,0.0#}";
            series3.Label = pointSeriesLabel1;
            series3.Name = "Value";
            lineSeriesView2.Color = System.Drawing.Color.DodgerBlue;
            lineSeriesView2.LineMarkerOptions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            lineSeriesView2.LineMarkerOptions.Color = System.Drawing.Color.Yellow;
            lineSeriesView2.LineMarkerOptions.Size = 7;
            lineSeriesView2.LineStyle.Thickness = 3;
            lineSeriesView2.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            series3.View = lineSeriesView2;
            this.chart_temp.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3};
            this.chart_temp.Size = new System.Drawing.Size(907, 183);
            this.chart_temp.TabIndex = 12;
            chartTitle1.Alignment = System.Drawing.StringAlignment.Near;
            chartTitle1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            chartTitle1.Indent = 0;
            chartTitle1.Text = "Heat temperature °C";
            chartTitle1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            chartTitle1.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart_temp.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // User_Chart_Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart_temp);
            this.Name = "User_Chart_Temp";
            this.Size = new System.Drawing.Size(907, 183);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedLineSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedLineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_temp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chart_temp;
    }
}
