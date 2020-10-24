namespace Smart_FTY
{
    public partial class SampleFrm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleFrm2));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lblShift = new System.Windows.Forms.Label();
            this.cmdBack = new System.Windows.Forms.Button();
            this.pnButton = new System.Windows.Forms.Panel();
            this.cmdMonth = new DevExpress.XtraEditors.SimpleButton();
            this.cmdYear = new DevExpress.XtraEditors.SimpleButton();
            this.cmdDay = new DevExpress.XtraEditors.SimpleButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.pnHeader.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnHeader.Controls.Add(this.lblShift);
            this.pnHeader.Controls.Add(this.cmdBack);
            this.pnHeader.Controls.Add(this.pnButton);
            this.pnHeader.Controls.Add(this.lblDate);
            this.pnHeader.Controls.Add(this.lblTitle);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1916, 106);
            this.pnHeader.TabIndex = 14;
            this.pnHeader.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.BackColor = System.Drawing.Color.Transparent;
            this.lblShift.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold);
            this.lblShift.ForeColor = System.Drawing.Color.White;
            this.lblShift.Location = new System.Drawing.Point(1273, 48);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(154, 53);
            this.lblShift.TabIndex = 685;
            this.lblShift.Text = "SHIFT 1";
            this.lblShift.Visible = false;
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdBack.BackgroundImage = global::Smart_FTY.Properties.Resources.Back_Icon;
            this.cmdBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBack.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.cmdBack.FlatAppearance.BorderSize = 0;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Location = new System.Drawing.Point(1143, 1);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(108, 101);
            this.cmdBack.TabIndex = 65;
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.cmdMonth);
            this.pnButton.Controls.Add(this.cmdYear);
            this.pnButton.Controls.Add(this.cmdDay);
            this.pnButton.Location = new System.Drawing.Point(1272, 1);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(373, 103);
            this.pnButton.TabIndex = 64;
            // 
            // cmdMonth
            // 
            this.cmdMonth.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdMonth.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdMonth.Appearance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold);
            this.cmdMonth.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cmdMonth.Appearance.Options.UseBackColor = true;
            this.cmdMonth.Appearance.Options.UseFont = true;
            this.cmdMonth.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdMonth.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdMonth.ImageOptions.Image")));
            this.cmdMonth.Location = new System.Drawing.Point(186, 3);
            this.cmdMonth.Name = "cmdMonth";
            this.cmdMonth.Size = new System.Drawing.Size(175, 48);
            this.cmdMonth.TabIndex = 62;
            this.cmdMonth.Text = "Month";
            this.cmdMonth.Click += new System.EventHandler(this.cmdMonth_Click);
            // 
            // cmdYear
            // 
            this.cmdYear.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdYear.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdYear.Appearance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdYear.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cmdYear.Appearance.Options.UseBackColor = true;
            this.cmdYear.Appearance.Options.UseFont = true;
            this.cmdYear.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdYear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdYear.ImageOptions.Image")));
            this.cmdYear.Location = new System.Drawing.Point(187, 55);
            this.cmdYear.Name = "cmdYear";
            this.cmdYear.Size = new System.Drawing.Size(175, 48);
            this.cmdYear.TabIndex = 63;
            this.cmdYear.Text = "Year";
            this.cmdYear.Click += new System.EventHandler(this.cmdYear_Click);
            // 
            // cmdDay
            // 
            this.cmdDay.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdDay.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdDay.Appearance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold);
            this.cmdDay.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cmdDay.Appearance.Options.UseBackColor = true;
            this.cmdDay.Appearance.Options.UseFont = true;
            this.cmdDay.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdDay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdDay.ImageOptions.Image")));
            this.cmdDay.Location = new System.Drawing.Point(5, 4);
            this.cmdDay.Name = "cmdDay";
            this.cmdDay.Size = new System.Drawing.Size(175, 48);
            this.cmdDay.TabIndex = 61;
            this.cmdDay.Text = "Day";
            this.cmdDay.Click += new System.EventHandler(this.cmdDay_Click);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDate.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDate.Location = new System.Drawing.Point(1651, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(265, 106);
            this.lblDate.TabIndex = 48;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.DoubleClick += new System.EventHandler(this.lblDate_DoubleClick);
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Appearance.Options.UseBackColor = true;
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Appearance.Options.UseForeColor = true;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblTitle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTitle.LineVisible = true;
            this.lblTitle.Location = new System.Drawing.Point(4, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 82);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SampleFrm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 1054);
            this.Controls.Add(this.pnHeader);
            this.Name = "SampleFrm2";
            this.Text = "Form_Sample";
            this.Load += new System.EventHandler(this.SampleFrm1_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnHeader;
        public System.Windows.Forms.Label lblDate;
        public DevExpress.XtraEditors.SimpleButton cmdYear;
        public DevExpress.XtraEditors.SimpleButton cmdMonth;
        public DevExpress.XtraEditors.SimpleButton cmdDay;
        public System.Windows.Forms.Panel pnButton;
        public System.Windows.Forms.Timer tmrTime;
        public System.Windows.Forms.Button cmdBack;
        protected DevExpress.XtraEditors.LabelControl lblTitle;
        public System.Windows.Forms.Label lblShift;
    }
}