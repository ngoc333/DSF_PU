namespace Smart_FTY
{
    partial class FRM_PH_TEMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PH_TEMP));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMC = new System.Windows.Forms.ComboBox();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.gridBand12 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.pnHeader.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.pnFormType.SuspendLayout();
            this.pn2.SuspendLayout();
            this.pn1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Text = "2018-11-30\n14:47:59";
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
            // pnButton
            // 
            this.pnButton.BackColor = System.Drawing.Color.Transparent;
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.Color.Transparent;
            this.cmdBack.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.cmdBack.FlatAppearance.BorderSize = 0;
            // 
            // lblShift
            // 
            this.lblShift.Size = new System.Drawing.Size(413, 53);
            this.lblShift.Text = "Shift 2 (14:00 ~ 22:00)";
            // 
            // pnFormType
            // 
            this.pnFormType.Size = new System.Drawing.Size(1920, 10);
            // 
            // lblPhylon
            // 
            this.lblPhylon.Click += new System.EventHandler(this.lblPhylon_Click);
            // 
            // lblCMP
            // 
            this.lblCMP.Click += new System.EventHandler(this.lblCMP_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboMC);
            this.panel1.Controls.Add(this.xtraScrollableControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 1080);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Machine";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboMC
            // 
            this.cboMC.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMC.FormattingEnabled = true;
            this.cboMC.Location = new System.Drawing.Point(180, 119);
            this.cboMC.Name = "cboMC";
            this.cboMC.Size = new System.Drawing.Size(283, 37);
            this.cboMC.TabIndex = 1;
            this.cboMC.SelectedValueChanged += new System.EventHandler(this.cboMC_SelectedValueChanged);
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.tblMain);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xtraScrollableControl1.FireScrollEventOnMouseWheel = true;
            this.xtraScrollableControl1.InvertTouchScroll = true;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 159);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.ScrollBarSmallChange = 10;
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1920, 921);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Location = new System.Drawing.Point(0, 3);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.88987F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.11013F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.Size = new System.Drawing.Size(1903, 908);
            this.tblMain.TabIndex = 2;
            // 
            // gridBand12
            // 
            this.gridBand12.Name = "gridBand12";
            this.gridBand12.VisibleIndex = -1;
            // 
            // FRM_PH_TEMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_PH_TEMP";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRM_ROLL_SLABTEST_MON_Load);
            this.VisibleChanged += new System.EventHandler(this.FRM_ROLL_SLABTEST_MON_VisibleChanged);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnHeader, 0);
            this.Controls.SetChildIndex(this.pnFormType, 0);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.pnFormType.ResumeLayout(false);
            this.pn2.ResumeLayout(false);
            this.pn1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand12;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMC;
    }
}