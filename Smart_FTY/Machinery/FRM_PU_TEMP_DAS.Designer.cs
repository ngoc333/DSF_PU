namespace Smart_FTY
{
    partial class FRM_PU_TEMP_DAS
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gridBand12 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.cboShift = new System.Windows.Forms.ComboBox();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmdBack = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboMC = new DevExpress.XtraEditors.LookUpEdit();
            this.dt_ymd = new DevExpress.XtraEditors.DateEdit();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboMC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ymd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ymd.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gridBand12
            // 
            this.gridBand12.Name = "gridBand12";
            this.gridBand12.VisibleIndex = -1;
            // 
            // cboShift
            // 
            this.cboShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboShift.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboShift.FormattingEnabled = true;
            this.cboShift.Location = new System.Drawing.Point(959, 115);
            this.cboShift.Name = "cboShift";
            this.cboShift.Size = new System.Drawing.Size(138, 37);
            this.cboShift.TabIndex = 669;
            this.cboShift.Visible = false;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnHeader.Controls.Add(this.lblTitle);
            this.pnHeader.Controls.Add(this.cmdBack);
            this.pnHeader.Controls.Add(this.lblDate);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1920, 106);
            this.pnHeader.TabIndex = 670;
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
            this.lblTitle.Text = "PU Machine Temperature";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboMC);
            this.panel2.Controls.Add(this.dt_ymd);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 46);
            this.panel2.TabIndex = 674;
            // 
            // cboMC
            // 
            this.cboMC.Location = new System.Drawing.Point(502, 4);
            this.cboMC.Name = "cboMC";
            this.cboMC.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.cboMC.Properties.Appearance.Options.UseFont = true;
            this.cboMC.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.cboMC.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboMC.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.cboMC.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.cboMC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", 50, true, true, false, editorButtonImageOptions1)});
            this.cboMC.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cboMC.Properties.NullText = "";
            this.cboMC.Size = new System.Drawing.Size(230, 40);
            this.cboMC.TabIndex = 677;
            this.cboMC.EditValueChanged += new System.EventHandler(this.cboMC_EditValueChanged);
            // 
            // dt_ymd
            // 
            this.dt_ymd.EditValue = null;
            this.dt_ymd.Location = new System.Drawing.Point(109, 4);
            this.dt_ymd.Name = "dt_ymd";
            this.dt_ymd.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.dt_ymd.Properties.Appearance.Options.UseFont = true;
            this.dt_ymd.Properties.AppearanceCalendar.Button.Font = new System.Drawing.Font("Tahoma", 22F);
            this.dt_ymd.Properties.AppearanceCalendar.Button.Options.UseFont = true;
            this.dt_ymd.Properties.AppearanceCalendar.CalendarHeader.Font = new System.Drawing.Font("Tahoma", 18F);
            this.dt_ymd.Properties.AppearanceCalendar.CalendarHeader.Options.UseFont = true;
            this.dt_ymd.Properties.AppearanceCalendar.DayCell.Font = new System.Drawing.Font("Tahoma", 18F);
            this.dt_ymd.Properties.AppearanceCalendar.DayCell.Options.UseFont = true;
            this.dt_ymd.Properties.AppearanceCalendar.DayCellDisabled.Font = new System.Drawing.Font("Tahoma", 18F);
            this.dt_ymd.Properties.AppearanceCalendar.DayCellDisabled.Options.UseFont = true;
            this.dt_ymd.Properties.AppearanceCalendar.DayCellHighlighted.Font = new System.Drawing.Font("Tahoma", 18F);
            this.dt_ymd.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = true;
            this.dt_ymd.Properties.AppearanceCalendar.DayCellHoliday.Font = new System.Drawing.Font("Tahoma", 18F);
            this.dt_ymd.Properties.AppearanceCalendar.DayCellHoliday.Options.UseFont = true;
            this.dt_ymd.Properties.AppearanceCalendar.DayCellInactive.Font = new System.Drawing.Font("Tahoma", 18F);
            this.dt_ymd.Properties.AppearanceCalendar.DayCellInactive.Options.UseFont = true;
            this.dt_ymd.Properties.AppearanceCalendar.DayCellPressed.Font = new System.Drawing.Font("Tahoma", 18F);
            this.dt_ymd.Properties.AppearanceCalendar.DayCellPressed.Options.UseFont = true;
            this.dt_ymd.Properties.AppearanceCalendar.DayCellSelected.Font = new System.Drawing.Font("Tahoma", 18F);
            this.dt_ymd.Properties.AppearanceCalendar.DayCellSelected.Options.UseFont = true;
            this.dt_ymd.Properties.AppearanceCalendar.DayCellSpecial.Font = new System.Drawing.Font("Tahoma", 18F);
            this.dt_ymd.Properties.AppearanceCalendar.DayCellSpecial.Options.UseFont = true;
            this.dt_ymd.Properties.AppearanceCalendar.DayCellSpecialHighlighted.Font = new System.Drawing.Font("Tahoma", 18F);
            this.dt_ymd.Properties.AppearanceCalendar.DayCellSpecialHighlighted.Options.UseFont = true;
            this.dt_ymd.Properties.AppearanceCalendar.DayCellSpecialPressed.Font = new System.Drawing.Font("Tahoma", 18F);
            this.dt_ymd.Properties.AppearanceCalendar.DayCellSpecialPressed.Options.UseFont = true;
            this.dt_ymd.Properties.AppearanceCalendar.DayCellSpecialSelected.Font = new System.Drawing.Font("Tahoma", 18F);
            this.dt_ymd.Properties.AppearanceCalendar.DayCellSpecialSelected.Options.UseFont = true;
            this.dt_ymd.Properties.AppearanceCalendar.DayCellToday.Font = new System.Drawing.Font("Tahoma", 18F);
            this.dt_ymd.Properties.AppearanceCalendar.DayCellToday.Options.UseFont = true;
            this.dt_ymd.Properties.AppearanceCalendar.Header.Font = new System.Drawing.Font("Tahoma", 18F);
            this.dt_ymd.Properties.AppearanceCalendar.Header.Options.UseFont = true;
            this.dt_ymd.Properties.AppearanceCalendar.HeaderHighlighted.Font = new System.Drawing.Font("Tahoma", 18F);
            this.dt_ymd.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = true;
            this.dt_ymd.Properties.AppearanceCalendar.HeaderPressed.Font = new System.Drawing.Font("Tahoma", 18F);
            this.dt_ymd.Properties.AppearanceCalendar.HeaderPressed.Options.UseFont = true;
            this.dt_ymd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", 50, true, true, false, editorButtonImageOptions2)});
            this.dt_ymd.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dt_ymd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ymd.Size = new System.Drawing.Size(230, 40);
            this.dt_ymd.TabIndex = 676;
            this.dt_ymd.EditValueChanged += new System.EventHandler(this.dt_ymd_EditValueChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(401, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 39);
            this.button2.TabIndex = 674;
            this.button2.Text = "Machine";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(8, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 675;
            this.button1.Text = "Date";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tblMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 928);
            this.panel1.TabIndex = 675;
            // 
            // tblMain
            // 
            this.tblMain.AutoScroll = true;
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.Size = new System.Drawing.Size(1916, 924);
            this.tblMain.TabIndex = 676;
            // 
            // FRM_PU_TEMP_DAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.cboShift);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_PU_TEMP_DAS";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRM_ROLL_SLABTEST_MON_Load);
            this.VisibleChanged += new System.EventHandler(this.FRM_ROLL_SLABTEST_MON_VisibleChanged);
            this.pnHeader.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboMC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ymd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ymd.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand12;
        private System.Windows.Forms.ComboBox cboShift;
        protected System.Windows.Forms.Panel pnHeader;
        protected System.Windows.Forms.Label lblTitle;
        protected System.Windows.Forms.Button cmdBack;
        protected System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LookUpEdit cboMC;
        private DevExpress.XtraEditors.DateEdit dt_ymd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tblMain;
    }
}