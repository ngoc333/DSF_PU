namespace Smart_FTY
{
    public partial class Form_Parent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Parent));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.cmdBack = new System.Windows.Forms.Button();
            this.pnButton = new System.Windows.Forms.Panel();
            this.cmdMonth = new DevExpress.XtraEditors.SimpleButton();
            this.cmdYear = new DevExpress.XtraEditors.SimpleButton();
            this.cmdDay = new DevExpress.XtraEditors.SimpleButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.pnFormType = new System.Windows.Forms.Panel();
            this.pn2 = new Smart_FTY.A1Panel();
            this.lblPhylon = new System.Windows.Forms.Label();
            this.pn1 = new Smart_FTY.A1Panel();
            this.lblCMP = new System.Windows.Forms.Label();
            this.pnHeader.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.pnFormType.SuspendLayout();
            this.pn2.SuspendLayout();
            this.pn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnHeader.Controls.Add(this.lblTitle);
            this.pnHeader.Controls.Add(this.lblShift);
            this.pnHeader.Controls.Add(this.cmdBack);
            this.pnHeader.Controls.Add(this.pnButton);
            this.pnHeader.Controls.Add(this.lblDate);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1920, 106);
            this.pnHeader.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1124, 106);
            this.lblTitle.TabIndex = 686;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
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
            this.cmdDay.Location = new System.Drawing.Point(5, 3);
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
            this.lblDate.Size = new System.Drawing.Size(269, 106);
            this.lblDate.TabIndex = 48;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.DoubleClick += new System.EventHandler(this.lblDate_DoubleClick);
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnFormType
            // 
            this.pnFormType.Controls.Add(this.pn2);
            this.pnFormType.Controls.Add(this.pn1);
            this.pnFormType.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnFormType.Location = new System.Drawing.Point(0, 106);
            this.pnFormType.Name = "pnFormType";
            this.pnFormType.Size = new System.Drawing.Size(1920, 57);
            this.pnFormType.TabIndex = 18;
            this.pnFormType.VisibleChanged += new System.EventHandler(this.pnFormType_VisibleChanged);
            // 
            // pn2
            // 
            this.pn2.AccessibleDescription = "";
            this.pn2.AccessibleName = "";
            this.pn2.BorderColor = System.Drawing.Color.Empty;
            this.pn2.BorderWidth = 2;
            this.pn2.Controls.Add(this.lblPhylon);
            this.pn2.GradientEndColor = System.Drawing.Color.White;
            this.pn2.GradientStartColor = System.Drawing.Color.White;
            this.pn2.Image = null;
            this.pn2.ImageLocation = new System.Drawing.Point(4, 4);
            this.pn2.Location = new System.Drawing.Point(160, 5);
            this.pn2.Name = "pn2";
            this.pn2.RoundCornerRadius = 20;
            this.pn2.ShadowOffSet = 3;
            this.pn2.Size = new System.Drawing.Size(153, 49);
            this.pn2.TabIndex = 0;
            // 
            // lblPhylon
            // 
            this.lblPhylon.BackColor = System.Drawing.Color.Transparent;
            this.lblPhylon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhylon.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhylon.Location = new System.Drawing.Point(0, 0);
            this.lblPhylon.Name = "lblPhylon";
            this.lblPhylon.Size = new System.Drawing.Size(153, 49);
            this.lblPhylon.TabIndex = 1;
            this.lblPhylon.Text = "Phylon";
            this.lblPhylon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPhylon.Click += new System.EventHandler(this.lblPhylon_Click);
            // 
            // pn1
            // 
            this.pn1.AccessibleDescription = "";
            this.pn1.AccessibleName = "";
            this.pn1.BorderColor = System.Drawing.Color.Empty;
            this.pn1.BorderWidth = 2;
            this.pn1.Controls.Add(this.lblCMP);
            this.pn1.GradientEndColor = System.Drawing.Color.Gray;
            this.pn1.GradientStartColor = System.Drawing.Color.White;
            this.pn1.Image = null;
            this.pn1.ImageLocation = new System.Drawing.Point(4, 4);
            this.pn1.Location = new System.Drawing.Point(3, 5);
            this.pn1.Name = "pn1";
            this.pn1.RoundCornerRadius = 20;
            this.pn1.ShadowOffSet = 3;
            this.pn1.Size = new System.Drawing.Size(153, 49);
            this.pn1.TabIndex = 0;
            // 
            // lblCMP
            // 
            this.lblCMP.BackColor = System.Drawing.Color.Transparent;
            this.lblCMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCMP.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMP.Location = new System.Drawing.Point(0, 0);
            this.lblCMP.Name = "lblCMP";
            this.lblCMP.Size = new System.Drawing.Size(153, 49);
            this.lblCMP.TabIndex = 0;
            this.lblCMP.Text = "CMP";
            this.lblCMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCMP.Click += new System.EventHandler(this.lblCMP_Click);
            // 
            // Form_Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pnFormType);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Parent";
            this.Text = "Form_Sample";
            this.Load += new System.EventHandler(this.SampleFrm1_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.pnFormType.ResumeLayout(false);
            this.pn2.ResumeLayout(false);
            this.pn1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnHeader;
        protected System.Windows.Forms.Label lblDate;
        protected DevExpress.XtraEditors.SimpleButton cmdYear;
        protected DevExpress.XtraEditors.SimpleButton cmdMonth;
        protected DevExpress.XtraEditors.SimpleButton cmdDay;
        protected System.Windows.Forms.Panel pnButton;
        protected System.Windows.Forms.Timer tmrTime;
        protected System.Windows.Forms.Button cmdBack;
        protected System.Windows.Forms.Label lblShift;
        protected System.Windows.Forms.Label lblTitle;
        protected System.Windows.Forms.Panel pnFormType;
        protected A1Panel pn2;
        protected System.Windows.Forms.Label lblPhylon;
        protected A1Panel pn1;
        protected System.Windows.Forms.Label lblCMP;
    }
}