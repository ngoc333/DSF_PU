namespace Smart_FTY
{
    partial class FORM_DMP_PROD_SET_STATUS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_DMP_PROD_SET_STATUS));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pn_body = new System.Windows.Forms.Panel();
            this.panel2 = new ClassLib.TransparentPanel();
            this.axGrid = new AxFPUSpreadADO.AxfpSpread();
            this.button1 = new System.Windows.Forms.Button();
            this.pn_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 45.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1914, 109);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Cold Shot Production Status";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDate.Location = new System.Drawing.Point(1662, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(253, 109);
            this.lblDate.TabIndex = 47;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pn_body
            // 
            this.pn_body.BackColor = System.Drawing.Color.Transparent;
            this.pn_body.Controls.Add(this.panel2);
            this.pn_body.Controls.Add(this.axGrid);
            this.pn_body.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_body.Location = new System.Drawing.Point(0, 109);
            this.pn_body.Name = "pn_body";
            this.pn_body.Size = new System.Drawing.Size(1914, 961);
            this.pn_body.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(640, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 48);
            this.panel2.TabIndex = 63;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // axGrid
            // 
            this.axGrid.DataSource = null;
            this.axGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axGrid.Location = new System.Drawing.Point(0, 0);
            this.axGrid.Name = "axGrid";
            this.axGrid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrid.OcxState")));
            this.axGrid.Size = new System.Drawing.Size(1914, 961);
            this.axGrid.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.BackgroundImage = global::Smart_FTY.Properties.Resources.Back_Icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1509, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 101);
            this.button1.TabIndex = 53;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FORM_DMC_PROD_SET_STATUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1914, 1054);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pn_body);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Name = "FORM_DMC_PROD_SET_STATUS";
            this.Text = "FORM_IPEX3_LOGISTIC";
            this.Load += new System.EventHandler(this.FORM_IPEX3_LOGISTIC_Load);
            this.VisibleChanged += new System.EventHandler(this.FORM_IPEX3_LOGISTIC_VisibleChanged);
            this.pn_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pn_body;
        private AxFPUSpreadADO.AxfpSpread axGrid;
        private ClassLib.TransparentPanel panel2;
        private System.Windows.Forms.Button button1;
       
    }
}