namespace Smart_FTY
{
    partial class FORM_DMP_MOLD_REPAIR_WEEKLY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_DMP_MOLD_REPAIR_WEEKLY));
            this.lbl_header = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pn_defective = new System.Windows.Forms.Panel();
            this.axGridModel = new AxFPSpreadADO.AxfpSpread();
            this.chartStyle = new ChartDirector.WinChartViewer();
            this.chartModel = new ChartDirector.WinChartViewer();
            this.axfpHeaderData = new AxFPSpreadADO.AxfpSpread();
            this.chartErrorCounter = new ChartDirector.WinChartViewer();
            this.tmr_style = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pn_defective.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGridModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axfpHeaderData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartErrorCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_header.Font = new System.Drawing.Font("Calibri", 45.25F, System.Drawing.FontStyle.Bold);
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Location = new System.Drawing.Point(0, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(1914, 109);
            this.lbl_header.TabIndex = 647;
            this.lbl_header.Text = "Mold Change Report";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDate.Location = new System.Drawing.Point(1660, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(254, 109);
            this.lblDate.TabIndex = 658;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pn_defective
            // 
            this.pn_defective.Controls.Add(this.axGridModel);
            this.pn_defective.Controls.Add(this.chartStyle);
            this.pn_defective.Controls.Add(this.chartModel);
            this.pn_defective.Controls.Add(this.axfpHeaderData);
            this.pn_defective.Controls.Add(this.chartErrorCounter);
            this.pn_defective.Location = new System.Drawing.Point(1, 111);
            this.pn_defective.Name = "pn_defective";
            this.pn_defective.Size = new System.Drawing.Size(1913, 945);
            this.pn_defective.TabIndex = 661;
            // 
            // axGridModel
            // 
            this.axGridModel.DataSource = null;
            this.axGridModel.Location = new System.Drawing.Point(912, 740);
            this.axGridModel.Name = "axGridModel";
            this.axGridModel.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGridModel.OcxState")));
            this.axGridModel.Size = new System.Drawing.Size(995, 159);
            this.axGridModel.TabIndex = 668;
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
            this.chartModel.Size = new System.Drawing.Size(999, 712);
            this.chartModel.TabIndex = 665;
            this.chartModel.TabStop = false;
            // 
            // axfpHeaderData
            // 
            this.axfpHeaderData.DataSource = null;
            this.axfpHeaderData.Location = new System.Drawing.Point(3, 740);
            this.axfpHeaderData.Name = "axfpHeaderData";
            this.axfpHeaderData.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axfpHeaderData.OcxState")));
            this.axfpHeaderData.Size = new System.Drawing.Size(901, 161);
            this.axfpHeaderData.TabIndex = 664;
            // 
            // chartErrorCounter
            // 
            this.chartErrorCounter.HotSpotCursor = System.Windows.Forms.Cursors.Hand;
            this.chartErrorCounter.Location = new System.Drawing.Point(3, 3);
            this.chartErrorCounter.Name = "chartErrorCounter";
            this.chartErrorCounter.Size = new System.Drawing.Size(900, 712);
            this.chartErrorCounter.TabIndex = 660;
            this.chartErrorCounter.TabStop = false;
            // 
            // tmr_style
            // 
            this.tmr_style.Interval = 50;
            this.tmr_style.Tick += new System.EventHandler(this.tmr_style_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.BackgroundImage = global::Smart_FTY.Properties.Resources.Back_Icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1467, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 101);
            this.button1.TabIndex = 662;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FORM_DMP_MOLD_REPAIR_WEEKLY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1054);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pn_defective);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lbl_header);
            this.Name = "FORM_DMP_MOLD_REPAIR_WEEKLY";
            this.Text = "FORM_DMP_MOLD_REPAIR_WEEKLY";
            this.Load += new System.EventHandler(this.Frm_Mold_Show_TV_Load);
            this.VisibleChanged += new System.EventHandler(this.FORM_MOLD_REPAIR_WEEKLY_VisibleChanged);
            this.pn_defective.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axGridModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axfpHeaderData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartErrorCounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel pn_defective;
        private ChartDirector.WinChartViewer chartErrorCounter;
        private AxFPSpreadADO.AxfpSpread axfpHeaderData;
        private System.Windows.Forms.Timer tmr_style;
        private ChartDirector.WinChartViewer chartModel;
        private ChartDirector.WinChartViewer chartStyle;
        private AxFPSpreadADO.AxfpSpread axGridModel;
        private System.Windows.Forms.Button button1;
    }
}