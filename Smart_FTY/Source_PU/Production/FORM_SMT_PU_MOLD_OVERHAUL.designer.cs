namespace Smart_FTY
{
    partial class FORM_SMT_PU_MOLD_OVERHAUL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_SMT_PU_MOLD_OVERHAUL));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pn_defective = new System.Windows.Forms.Panel();
            this.axfpHeaderData = new AxFPUSpreadADO.AxfpSpread();
            this.axGridModel = new AxFPUSpreadADO.AxfpSpread();
            this.chartStyle = new ChartDirector.WinChartViewer();
            this.chartModel = new ChartDirector.WinChartViewer();
            this.chartErrorCounter = new ChartDirector.WinChartViewer();
            this.tmr_style = new System.Windows.Forms.Timer(this.components);
            this.pnHeader = new System.Windows.Forms.Panel();
            this.cmdBack = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.pn_defective.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axfpHeaderData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGridModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartErrorCounter)).BeginInit();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pn_defective
            // 
            this.pn_defective.Controls.Add(this.axfpHeaderData);
            this.pn_defective.Controls.Add(this.axGridModel);
            this.pn_defective.Controls.Add(this.chartStyle);
            this.pn_defective.Controls.Add(this.chartModel);
            this.pn_defective.Controls.Add(this.chartErrorCounter);
            this.pn_defective.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_defective.Location = new System.Drawing.Point(0, 104);
            this.pn_defective.Name = "pn_defective";
            this.pn_defective.Size = new System.Drawing.Size(1914, 950);
            this.pn_defective.TabIndex = 661;
            // 
            // axfpHeaderData
            // 
            this.axfpHeaderData.DataSource = null;
            this.axfpHeaderData.Location = new System.Drawing.Point(3, 765);
            this.axfpHeaderData.Name = "axfpHeaderData";
            this.axfpHeaderData.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axfpHeaderData.OcxState")));
            this.axfpHeaderData.Size = new System.Drawing.Size(900, 182);
            this.axfpHeaderData.TabIndex = 670;
            // 
            // axGridModel
            // 
            this.axGridModel.DataSource = null;
            this.axGridModel.Location = new System.Drawing.Point(909, 765);
            this.axGridModel.Name = "axGridModel";
            this.axGridModel.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGridModel.OcxState")));
            this.axGridModel.Size = new System.Drawing.Size(999, 182);
            this.axGridModel.TabIndex = 669;
            // 
            // chartStyle
            // 
            this.chartStyle.HotSpotCursor = System.Windows.Forms.Cursors.Hand;
            this.chartStyle.Location = new System.Drawing.Point(0, 611);
            this.chartStyle.Name = "chartStyle";
            this.chartStyle.Size = new System.Drawing.Size(30, 21);
            this.chartStyle.TabIndex = 667;
            this.chartStyle.TabStop = false;
            // 
            // chartModel
            // 
            this.chartModel.HotSpotCursor = System.Windows.Forms.Cursors.Hand;
            this.chartModel.Location = new System.Drawing.Point(909, 3);
            this.chartModel.Name = "chartModel";
            this.chartModel.Size = new System.Drawing.Size(999, 758);
            this.chartModel.TabIndex = 665;
            this.chartModel.TabStop = false;
            // 
            // chartErrorCounter
            // 
            this.chartErrorCounter.HotSpotCursor = System.Windows.Forms.Cursors.Hand;
            this.chartErrorCounter.Location = new System.Drawing.Point(3, 3);
            this.chartErrorCounter.Name = "chartErrorCounter";
            this.chartErrorCounter.Size = new System.Drawing.Size(900, 757);
            this.chartErrorCounter.TabIndex = 660;
            this.chartErrorCounter.TabStop = false;
            // 
            // tmr_style
            // 
            this.tmr_style.Interval = 50;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnHeader.Controls.Add(this.cmdBack);
            this.pnHeader.Controls.Add(this.lblDate);
            this.pnHeader.Controls.Add(this.lblTitle2);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1914, 103);
            this.pnHeader.TabIndex = 662;
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.Color.Transparent;
            this.cmdBack.BackgroundImage = global::Smart_FTY.Properties.Resources.Back_Icon;
            this.cmdBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBack.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.cmdBack.FlatAppearance.BorderSize = 0;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Location = new System.Drawing.Point(1297, -1);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(108, 101);
            this.cmdBack.TabIndex = 690;
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(1683, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(231, 103);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "20-10-2018\r\n00:00:00";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblDate_MouseDoubleClick);
            // 
            // lblTitle2
            // 
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle2.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(0, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(1291, 103);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "PU Mold Overhaul by Week";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FORM_SMT_PU_MOLD_OVERHAUL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1054);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.pn_defective);
            this.Name = "FORM_SMT_PU_MOLD_OVERHAUL";
            this.Text = "FORM_MOLD_REPAIR_WEEKLY";
            this.Load += new System.EventHandler(this.Frm_Mold_Show_TV_Load);
            this.VisibleChanged += new System.EventHandler(this.FORM_MOLD_REPAIR_WEEKLY_VisibleChanged);
            this.pn_defective.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axfpHeaderData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGridModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartErrorCounter)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel pn_defective;
        private ChartDirector.WinChartViewer chartErrorCounter;
        private System.Windows.Forms.Timer tmr_style;
        private ChartDirector.WinChartViewer chartModel;
        private ChartDirector.WinChartViewer chartStyle;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitle2;
        private AxFPUSpreadADO.AxfpSpread axfpHeaderData;
        private AxFPUSpreadADO.AxfpSpread axGridModel;
        protected System.Windows.Forms.Button cmdBack;
    }
}