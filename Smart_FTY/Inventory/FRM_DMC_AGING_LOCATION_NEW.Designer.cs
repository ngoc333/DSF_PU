namespace IPEX_Monitor
{
    partial class FRM_DMC_AGING_LOCATION_NEW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DMC_AGING_LOCATION_NEW));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.groupBoxEx1 = new IPEX_Monitor.ClassLib.GroupBoxEx();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNotYetEnoughTotal = new System.Windows.Forms.Label();
            this.lblEnoughTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSetArea = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblShelf = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblShelf_TEXT = new System.Windows.Forms.Label();
            this.lblEnough_A = new System.Windows.Forms.Label();
            this.lblTotal_A = new System.Windows.Forms.Label();
            this.lblNotAging_A_TEXT = new System.Windows.Forms.Label();
            this.lblAging_A_TEXT = new System.Windows.Forms.Label();
            this.lblTotal_A_TEXT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFullCapa = new System.Windows.Forms.Label();
            this.splMain = new System.Windows.Forms.SplitContainer();
            this.gbAging = new System.Windows.Forms.GroupBox();
            this.axfpData = new AxFPSpreadADO.AxfpSpread();
            this.bgwGrid = new System.ComponentModel.BackgroundWorker();
            this.tmr_Date = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnHeader.SuspendLayout();
            this.groupBoxEx1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
            this.splMain.Panel1.SuspendLayout();
            this.splMain.Panel2.SuspendLayout();
            this.splMain.SuspendLayout();
            this.gbAging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axfpData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnHeader.Controls.Add(this.groupBoxEx1);
            this.pnHeader.Controls.Add(this.lblDate);
            this.pnHeader.Controls.Add(this.lblShelf);
            this.pnHeader.Controls.Add(this.lblTitle);
            this.pnHeader.Controls.Add(this.lblShelf_TEXT);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1916, 100);
            this.pnHeader.TabIndex = 0;
            // 
            // groupBoxEx1
            // 
            this.groupBoxEx1.BackgroundPanelImage = null;
            this.groupBoxEx1.Controls.Add(this.groupBox1);
            this.groupBoxEx1.Controls.Add(this.lblSetArea);
            this.groupBoxEx1.Controls.Add(this.label3);
            this.groupBoxEx1.DrawGroupBorder = true;
            this.groupBoxEx1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.groupBoxEx1.ForeColor = System.Drawing.Color.White;
            this.groupBoxEx1.GroupBorderColor = System.Drawing.Color.Yellow;
            this.groupBoxEx1.GroupPanelColor = System.Drawing.Color.DodgerBlue;
            this.groupBoxEx1.GroupPanelShape = IPEX_Monitor.ClassLib.GroupBoxEx.PanelType.Rounded;
            this.groupBoxEx1.GroupPanelWith = 3F;
            this.groupBoxEx1.Location = new System.Drawing.Point(918, 1);
            this.groupBoxEx1.Name = "groupBoxEx1";
            this.groupBoxEx1.Size = new System.Drawing.Size(770, 97);
            this.groupBoxEx1.TabIndex = 57;
            this.groupBoxEx1.TabStop = false;
            this.groupBoxEx1.Text = "SET AREA";
            this.groupBoxEx1.TextBackColor = System.Drawing.Color.Silver;
            this.groupBoxEx1.TextBorderColor = System.Drawing.Color.Silver;
            this.groupBoxEx1.TextBorderWith = 3F;
            this.groupBoxEx1.Enter += new System.EventHandler(this.groupBoxEx1_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNotYetEnoughTotal);
            this.groupBox1.Controls.Add(this.lblEnoughTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(236, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 63);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            // 
            // lblNotYetEnoughTotal
            // 
            this.lblNotYetEnoughTotal.BackColor = System.Drawing.Color.Yellow;
            this.lblNotYetEnoughTotal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblNotYetEnoughTotal.ForeColor = System.Drawing.Color.Black;
            this.lblNotYetEnoughTotal.Location = new System.Drawing.Point(369, 25);
            this.lblNotYetEnoughTotal.Name = "lblNotYetEnoughTotal";
            this.lblNotYetEnoughTotal.Size = new System.Drawing.Size(153, 36);
            this.lblNotYetEnoughTotal.TabIndex = 57;
            this.lblNotYetEnoughTotal.Text = "000";
            this.lblNotYetEnoughTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnoughTotal
            // 
            this.lblEnoughTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblEnoughTotal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEnoughTotal.ForeColor = System.Drawing.Color.Black;
            this.lblEnoughTotal.Location = new System.Drawing.Point(88, 24);
            this.lblEnoughTotal.Name = "lblEnoughTotal";
            this.lblEnoughTotal.Size = new System.Drawing.Size(153, 36);
            this.lblEnoughTotal.TabIndex = 56;
            this.lblEnoughTotal.Text = "000";
            this.lblEnoughTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 26);
            this.label4.TabIndex = 58;
            this.label4.Text = "Can Use";
            // 
            // lblSetArea
            // 
            this.lblSetArea.BackColor = System.Drawing.Color.White;
            this.lblSetArea.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSetArea.ForeColor = System.Drawing.Color.Black;
            this.lblSetArea.Location = new System.Drawing.Point(77, 53);
            this.lblSetArea.Name = "lblSetArea";
            this.lblSetArea.Size = new System.Drawing.Size(153, 36);
            this.lblSetArea.TabIndex = 52;
            this.lblSetArea.Text = "000";
            this.lblSetArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 55;
            this.label3.Text = "TOTAL";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 28F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDate.Location = new System.Drawing.Point(1688, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(228, 100);
            this.lblDate.TabIndex = 56;
            this.lblDate.Text = "lblDate";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.DoubleClick += new System.EventHandler(this.lblDate_DoubleClick);
            // 
            // lblShelf
            // 
            this.lblShelf.AutoSize = true;
            this.lblShelf.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold);
            this.lblShelf.ForeColor = System.Drawing.Color.Black;
            this.lblShelf.Location = new System.Drawing.Point(665, 7);
            this.lblShelf.Name = "lblShelf";
            this.lblShelf.Size = new System.Drawing.Size(79, 37);
            this.lblShelf.TabIndex = 55;
            this.lblShelf.Text = "Shelf";
            this.lblShelf.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(883, 85);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DMP Set Balance System";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblShelf_TEXT
            // 
            this.lblShelf_TEXT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblShelf_TEXT.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold);
            this.lblShelf_TEXT.ForeColor = System.Drawing.Color.White;
            this.lblShelf_TEXT.Location = new System.Drawing.Point(750, 3);
            this.lblShelf_TEXT.Name = "lblShelf_TEXT";
            this.lblShelf_TEXT.Size = new System.Drawing.Size(113, 44);
            this.lblShelf_TEXT.TabIndex = 52;
            this.lblShelf_TEXT.Text = "000";
            this.lblShelf_TEXT.Visible = false;
            // 
            // lblEnough_A
            // 
            this.lblEnough_A.AutoSize = true;
            this.lblEnough_A.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold);
            this.lblEnough_A.ForeColor = System.Drawing.Color.Black;
            this.lblEnough_A.Location = new System.Drawing.Point(8, 11);
            this.lblEnough_A.Name = "lblEnough_A";
            this.lblEnough_A.Size = new System.Drawing.Size(118, 37);
            this.lblEnough_A.TabIndex = 54;
            this.lblEnough_A.Text = "Can Use";
            // 
            // lblTotal_A
            // 
            this.lblTotal_A.AutoSize = true;
            this.lblTotal_A.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotal_A.ForeColor = System.Drawing.Color.Black;
            this.lblTotal_A.Location = new System.Drawing.Point(3, 267);
            this.lblTotal_A.Name = "lblTotal_A";
            this.lblTotal_A.Size = new System.Drawing.Size(77, 37);
            this.lblTotal_A.TabIndex = 55;
            this.lblTotal_A.Text = "Total";
            // 
            // lblNotAging_A_TEXT
            // 
            this.lblNotAging_A_TEXT.BackColor = System.Drawing.Color.Yellow;
            this.lblNotAging_A_TEXT.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold);
            this.lblNotAging_A_TEXT.ForeColor = System.Drawing.Color.Black;
            this.lblNotAging_A_TEXT.Location = new System.Drawing.Point(389, 11);
            this.lblNotAging_A_TEXT.Name = "lblNotAging_A_TEXT";
            this.lblNotAging_A_TEXT.Size = new System.Drawing.Size(110, 39);
            this.lblNotAging_A_TEXT.TabIndex = 51;
            this.lblNotAging_A_TEXT.Text = "00";
            this.lblNotAging_A_TEXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAging_A_TEXT
            // 
            this.lblAging_A_TEXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAging_A_TEXT.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold);
            this.lblAging_A_TEXT.ForeColor = System.Drawing.Color.Black;
            this.lblAging_A_TEXT.Location = new System.Drawing.Point(132, 11);
            this.lblAging_A_TEXT.Name = "lblAging_A_TEXT";
            this.lblAging_A_TEXT.Size = new System.Drawing.Size(110, 39);
            this.lblAging_A_TEXT.TabIndex = 50;
            this.lblAging_A_TEXT.Text = "00";
            this.lblAging_A_TEXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal_A_TEXT
            // 
            this.lblTotal_A_TEXT.BackColor = System.Drawing.Color.YellowGreen;
            this.lblTotal_A_TEXT.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotal_A_TEXT.ForeColor = System.Drawing.Color.Black;
            this.lblTotal_A_TEXT.Location = new System.Drawing.Point(77, 265);
            this.lblTotal_A_TEXT.Name = "lblTotal_A_TEXT";
            this.lblTotal_A_TEXT.Size = new System.Drawing.Size(110, 39);
            this.lblTotal_A_TEXT.TabIndex = 52;
            this.lblTotal_A_TEXT.Text = "000";
            this.lblTotal_A_TEXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1469, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOT YET FULL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFullCapa
            // 
            this.lblFullCapa.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblFullCapa.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold);
            this.lblFullCapa.ForeColor = System.Drawing.Color.White;
            this.lblFullCapa.Location = new System.Drawing.Point(1694, 260);
            this.lblFullCapa.Name = "lblFullCapa";
            this.lblFullCapa.Size = new System.Drawing.Size(219, 44);
            this.lblFullCapa.TabIndex = 0;
            this.lblFullCapa.Text = "FULL (480 Prs)";
            this.lblFullCapa.Click += new System.EventHandler(this.lblFullCapa_Click);
            // 
            // splMain
            // 
            this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMain.Location = new System.Drawing.Point(0, 100);
            this.splMain.Name = "splMain";
            this.splMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splMain.Panel1
            // 
            this.splMain.Panel1.AutoScroll = true;
            this.splMain.Panel1.BackColor = System.Drawing.Color.White;
            this.splMain.Panel1.Controls.Add(this.gbAging);
            this.splMain.Panel1.Controls.Add(this.lblFullCapa);
            this.splMain.Panel1.Controls.Add(this.label1);
            this.splMain.Panel1.Controls.Add(this.lblTotal_A);
            this.splMain.Panel1.Controls.Add(this.lblTotal_A_TEXT);
            // 
            // splMain.Panel2
            // 
            this.splMain.Panel2.Controls.Add(this.axfpData);
            this.splMain.Size = new System.Drawing.Size(1916, 954);
            this.splMain.SplitterDistance = 314;
            this.splMain.SplitterWidth = 1;
            this.splMain.TabIndex = 1;
            // 
            // gbAging
            // 
            this.gbAging.Controls.Add(this.lblNotAging_A_TEXT);
            this.gbAging.Controls.Add(this.label2);
            this.gbAging.Controls.Add(this.lblEnough_A);
            this.gbAging.Controls.Add(this.lblAging_A_TEXT);
            this.gbAging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAging.Location = new System.Drawing.Point(193, 253);
            this.gbAging.Name = "gbAging";
            this.gbAging.Size = new System.Drawing.Size(510, 56);
            this.gbAging.TabIndex = 56;
            this.gbAging.TabStop = false;
            // 
            // axfpData
            // 
            this.axfpData.DataSource = null;
            this.axfpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axfpData.Location = new System.Drawing.Point(0, 0);
            this.axfpData.Name = "axfpData";
            this.axfpData.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axfpData.OcxState")));
            this.axfpData.Size = new System.Drawing.Size(1916, 639);
            this.axfpData.TabIndex = 0;
            this.axfpData.ClickEvent += new AxFPSpreadADO._DSpreadEvents_ClickEventHandler(this.axfpData_ClickEvent);
            // 
            // bgwGrid
            // 
            this.bgwGrid.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGrid_DoWork);
            // 
            // tmr_Date
            // 
            this.tmr_Date.Enabled = true;
            this.tmr_Date.Interval = 1000;
            this.tmr_Date.Tick += new System.EventHandler(this.tmr_Date_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(248, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 37);
            this.label2.TabIndex = 54;
            this.label2.Text = "Can\'t Use";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(269, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 26);
            this.label5.TabIndex = 58;
            this.label5.Text = "Can\'t Use";
            // 
            // FRM_DMC_AGING_LOCATION_NEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 1054);
            this.Controls.Add(this.splMain);
            this.Controls.Add(this.pnHeader);
            this.Name = "FRM_DMC_AGING_LOCATION_NEW";
            this.Text = "FRM_DMC_AGING_LOCATION";
            this.Load += new System.EventHandler(this.FRM_DMP_SET_BALANCE_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.groupBoxEx1.ResumeLayout(false);
            this.groupBoxEx1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splMain.Panel1.ResumeLayout(false);
            this.splMain.Panel1.PerformLayout();
            this.splMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
            this.splMain.ResumeLayout(false);
            this.gbAging.ResumeLayout(false);
            this.gbAging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axfpData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer splMain;
        private AxFPSpreadADO.AxfpSpread axfpData;
        private System.Windows.Forms.Label lblFullCapa;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker bgwGrid;
        private System.Windows.Forms.Label lblEnough_A;
        private System.Windows.Forms.Label lblTotal_A;
        private System.Windows.Forms.Label lblNotAging_A_TEXT;
        private System.Windows.Forms.Label lblAging_A_TEXT;
        private System.Windows.Forms.Label lblTotal_A_TEXT;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer tmr_Date;
        private System.Windows.Forms.Label lblShelf;
        private System.Windows.Forms.Label lblShelf_TEXT;
        private ClassLib.GroupBoxEx groupBoxEx1;
        private System.Windows.Forms.Label lblSetArea;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbAging;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNotYetEnoughTotal;
        private System.Windows.Forms.Label lblEnoughTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}