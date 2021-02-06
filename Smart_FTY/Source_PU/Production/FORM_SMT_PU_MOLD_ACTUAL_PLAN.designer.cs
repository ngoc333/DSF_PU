namespace Smart_FTY
{
    partial class FORM_SMT_PU_MOLD_ACTUAL_PLAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_SMT_PU_MOLD_ACTUAL_PLAN));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmr_blind = new System.Windows.Forms.Timer(this.components);
            this.lblPH3 = new System.Windows.Forms.Label();
            this.lblPH2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbl_change = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Actual = new System.Windows.Forms.Label();
            this.lbl_Plan = new System.Windows.Forms.Label();
            this.lblPH1 = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.cmdBack = new System.Windows.Forms.Button();
            this.pnButton = new System.Windows.Forms.Panel();
            this.cmdMonth = new DevExpress.XtraEditors.SimpleButton();
            this.cmdYear = new DevExpress.XtraEditors.SimpleButton();
            this.cmdDay = new DevExpress.XtraEditors.SimpleButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.axGrid = new AxFPSpreadADO.AxfpSpread();
            this.lbl_dif3 = new System.Windows.Forms.Label();
            this.dtpDate = new DevExpress.XtraEditors.DateEdit();
            this.pnShift = new System.Windows.Forms.Panel();
            this.lbl_dif2 = new System.Windows.Forms.Label();
            this.lbl_dif1 = new System.Windows.Forms.Label();
            this.lbl_Shift2 = new System.Windows.Forms.Label();
            this.lbl_Shift1 = new System.Windows.Forms.Label();
            this.lbl_Shift3 = new System.Windows.Forms.Label();
            this.pnHeader.SuspendLayout();
            this.pnButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).BeginInit();
            this.pnShift.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPH3
            // 
            this.lblPH3.BackColor = System.Drawing.Color.IndianRed;
            this.lblPH3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPH3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPH3.ForeColor = System.Drawing.Color.Black;
            this.lblPH3.Location = new System.Drawing.Point(1773, 119);
            this.lblPH3.Name = "lblPH3";
            this.lblPH3.Size = new System.Drawing.Size(143, 50);
            this.lblPH3.TabIndex = 685;
            this.lblPH3.Text = "C";
            this.lblPH3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPH3.Visible = false;
            // 
            // lblPH2
            // 
            this.lblPH2.BackColor = System.Drawing.Color.Gray;
            this.lblPH2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPH2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPH2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPH2.Location = new System.Drawing.Point(1629, 119);
            this.lblPH2.Name = "lblPH2";
            this.lblPH2.Size = new System.Drawing.Size(143, 50);
            this.lblPH2.TabIndex = 684;
            this.lblPH2.Text = "B";
            this.lblPH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPH2.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // lbl_change
            // 
            this.lbl_change.BackColor = System.Drawing.Color.Yellow;
            this.lbl_change.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_change.ForeColor = System.Drawing.Color.Black;
            this.lbl_change.Location = new System.Drawing.Point(911, 114);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(227, 31);
            this.lbl_change.TabIndex = 690;
            this.lbl_change.Text = "Difference Plan";
            this.lbl_change.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_change.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(973, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 693;
            this.label1.Text = "Plan/Acual";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // lbl_Actual
            // 
            this.lbl_Actual.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_Actual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Actual.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Actual.ForeColor = System.Drawing.Color.White;
            this.lbl_Actual.Location = new System.Drawing.Point(1156, 146);
            this.lbl_Actual.Name = "lbl_Actual";
            this.lbl_Actual.Size = new System.Drawing.Size(225, 32);
            this.lbl_Actual.TabIndex = 695;
            this.lbl_Actual.Text = "Total Actual: 704";
            this.lbl_Actual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Plan
            // 
            this.lbl_Plan.BackColor = System.Drawing.Color.Green;
            this.lbl_Plan.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Plan.ForeColor = System.Drawing.Color.White;
            this.lbl_Plan.Location = new System.Drawing.Point(1156, 115);
            this.lbl_Plan.Name = "lbl_Plan";
            this.lbl_Plan.Size = new System.Drawing.Size(225, 30);
            this.lbl_Plan.TabIndex = 694;
            this.lbl_Plan.Text = "Total Plan:  704";
            this.lbl_Plan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPH1
            // 
            this.lblPH1.BackColor = System.Drawing.Color.Gray;
            this.lblPH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPH1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPH1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPH1.Location = new System.Drawing.Point(1485, 119);
            this.lblPH1.Name = "lblPH1";
            this.lblPH1.Size = new System.Drawing.Size(143, 50);
            this.lblPH1.TabIndex = 697;
            this.lblPH1.Text = "A";
            this.lblPH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPH1.Visible = false;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnHeader.Controls.Add(this.cmdBack);
            this.pnHeader.Controls.Add(this.pnButton);
            this.pnHeader.Controls.Add(this.lblDate);
            this.pnHeader.Controls.Add(this.lblTitle2);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1924, 103);
            this.pnHeader.TabIndex = 698;
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.Color.Transparent;
            this.cmdBack.BackgroundImage = global::Smart_FTY.Properties.Resources.Back_Icon;
            this.cmdBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBack.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.cmdBack.FlatAppearance.BorderSize = 0;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Location = new System.Drawing.Point(1177, -1);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(108, 101);
            this.cmdBack.TabIndex = 690;
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.cmdMonth);
            this.pnButton.Controls.Add(this.cmdYear);
            this.pnButton.Controls.Add(this.cmdDay);
            this.pnButton.Location = new System.Drawing.Point(1306, -2);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(373, 103);
            this.pnButton.TabIndex = 689;
            this.pnButton.Visible = false;
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
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(1693, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(231, 103);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "20-10-2018\r\n00:00:00";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle2
            // 
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle2.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(0, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(961, 103);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "PU Mold APS Plan && Actual";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // axGrid
            // 
            this.axGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.axGrid.DataSource = null;
            this.axGrid.Location = new System.Drawing.Point(3, 233);
            this.axGrid.Name = "axGrid";
            this.axGrid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrid.OcxState")));
            this.axGrid.Size = new System.Drawing.Size(1919, 693);
            this.axGrid.TabIndex = 660;
            this.axGrid.BeforeEditMode += new AxFPSpreadADO._DSpreadEvents_BeforeEditModeEventHandler(this.axGrid_BeforeEditMode);
            // 
            // lbl_dif3
            // 
            this.lbl_dif3.BackColor = System.Drawing.Color.White;
            this.lbl_dif3.Font = new System.Drawing.Font("Calibri", 20.75F, System.Drawing.FontStyle.Bold);
            this.lbl_dif3.ForeColor = System.Drawing.Color.Blue;
            this.lbl_dif3.Location = new System.Drawing.Point(413, 48);
            this.lbl_dif3.Name = "lbl_dif3";
            this.lbl_dif3.Size = new System.Drawing.Size(205, 31);
            this.lbl_dif3.TabIndex = 708;
            this.lbl_dif3.Text = "Difference Plan";
            this.lbl_dif3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpDate
            // 
            this.dtpDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpDate.EditValue = new System.DateTime(2021, 1, 5, 16, 0, 56, 0);
            this.dtpDate.Location = new System.Drawing.Point(19, 109);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtpDate.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 24.25F, System.Drawing.FontStyle.Bold);
            this.dtpDate.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.dtpDate.Properties.Appearance.Options.UseFont = true;
            this.dtpDate.Properties.Appearance.Options.UseForeColor = true;
            this.dtpDate.Properties.AppearanceCalendar.CalendarHeader.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Properties.AppearanceCalendar.CalendarHeader.Options.UseFont = true;
            this.dtpDate.Properties.AppearanceCalendar.DayCell.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Properties.AppearanceCalendar.DayCell.Options.UseFont = true;
            this.dtpDate.Properties.AppearanceCalendar.DayCellHighlighted.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = true;
            this.dtpDate.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Calibri", 24.25F, System.Drawing.FontStyle.Bold);
            this.dtpDate.Properties.AppearanceDisabled.Options.UseFont = true;
            this.dtpDate.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dtpDate.Properties.AppearanceFocused.Font = new System.Drawing.Font("Calibri", 24.25F, System.Drawing.FontStyle.Bold);
            this.dtpDate.Properties.AppearanceFocused.Options.UseFont = true;
            this.dtpDate.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Calibri", 24.25F, System.Drawing.FontStyle.Bold);
            this.dtpDate.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.dtpDate.Properties.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            serializableAppearanceObject9.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject9.Options.UseFont = true;
            serializableAppearanceObject10.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject10.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            serializableAppearanceObject10.Options.UseFont = true;
            serializableAppearanceObject11.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject11.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            serializableAppearanceObject11.Options.UseFont = true;
            serializableAppearanceObject12.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject12.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            serializableAppearanceObject12.Options.UseFont = true;
            this.dtpDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 50, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null)});
            this.dtpDate.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            editorButtonImageOptions4.Location = DevExpress.XtraEditors.ImageLocation.Default;
            serializableAppearanceObject13.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject13.Options.UseFont = true;
            serializableAppearanceObject14.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject14.Options.UseFont = true;
            serializableAppearanceObject15.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject15.Options.UseFont = true;
            serializableAppearanceObject16.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject16.Options.UseFont = true;
            this.dtpDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close, "", 50, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null)});
            this.dtpDate.Properties.CalendarTimeProperties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpDate.Properties.CalendarTimeProperties.ReadOnly = true;
            this.dtpDate.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dtpDate.Properties.ContextImageOptions.SvgImageSize = new System.Drawing.Size(1, 10);
            this.dtpDate.Properties.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.dtpDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtpDate.Properties.EditFormat.FormatString = "yyyy/MM/dd";
            this.dtpDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpDate.Properties.Mask.EditMask = "yyyy/MM/dd";
            this.dtpDate.Properties.ShowNullValuePromptWhenFocused = true;
            this.dtpDate.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.MonthView;
            this.dtpDate.Size = new System.Drawing.Size(237, 47);
            this.dtpDate.TabIndex = 711;
            this.dtpDate.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.dtpDate.ToolTipTitle = "Click vào để chọn ngày";
            this.dtpDate.EditValueChanged += new System.EventHandler(this.dtpDate_EditValueChanged);
            // 
            // pnShift
            // 
            this.pnShift.Controls.Add(this.lbl_dif3);
            this.pnShift.Controls.Add(this.lbl_dif2);
            this.pnShift.Controls.Add(this.lbl_dif1);
            this.pnShift.Controls.Add(this.lbl_Shift2);
            this.pnShift.Controls.Add(this.lbl_Shift1);
            this.pnShift.Controls.Add(this.lbl_Shift3);
            this.pnShift.Location = new System.Drawing.Point(261, 109);
            this.pnShift.Name = "pnShift";
            this.pnShift.Size = new System.Drawing.Size(628, 82);
            this.pnShift.TabIndex = 712;
            // 
            // lbl_dif2
            // 
            this.lbl_dif2.BackColor = System.Drawing.Color.White;
            this.lbl_dif2.Font = new System.Drawing.Font("Calibri", 20.75F, System.Drawing.FontStyle.Bold);
            this.lbl_dif2.ForeColor = System.Drawing.Color.Blue;
            this.lbl_dif2.Location = new System.Drawing.Point(208, 48);
            this.lbl_dif2.Name = "lbl_dif2";
            this.lbl_dif2.Size = new System.Drawing.Size(205, 31);
            this.lbl_dif2.TabIndex = 707;
            this.lbl_dif2.Text = "Difference Plan";
            this.lbl_dif2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_dif1
            // 
            this.lbl_dif1.BackColor = System.Drawing.Color.White;
            this.lbl_dif1.Font = new System.Drawing.Font("Calibri", 20.75F, System.Drawing.FontStyle.Bold);
            this.lbl_dif1.ForeColor = System.Drawing.Color.Blue;
            this.lbl_dif1.Location = new System.Drawing.Point(3, 48);
            this.lbl_dif1.Name = "lbl_dif1";
            this.lbl_dif1.Size = new System.Drawing.Size(205, 31);
            this.lbl_dif1.TabIndex = 706;
            this.lbl_dif1.Text = "Difference Plan";
            this.lbl_dif1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Shift2
            // 
            this.lbl_Shift2.BackColor = System.Drawing.Color.Gray;
            this.lbl_Shift2.Font = new System.Drawing.Font("Calibri", 28.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Shift2.ForeColor = System.Drawing.Color.White;
            this.lbl_Shift2.Location = new System.Drawing.Point(209, 1);
            this.lbl_Shift2.Name = "lbl_Shift2";
            this.lbl_Shift2.Size = new System.Drawing.Size(204, 45);
            this.lbl_Shift2.TabIndex = 705;
            this.lbl_Shift2.Tag = "2";
            this.lbl_Shift2.Text = "Shift 2";
            this.lbl_Shift2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Shift2.Click += new System.EventHandler(this.lbl_Shift_Click);
            // 
            // lbl_Shift1
            // 
            this.lbl_Shift1.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Shift1.Font = new System.Drawing.Font("Calibri", 28.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Shift1.ForeColor = System.Drawing.Color.White;
            this.lbl_Shift1.Location = new System.Drawing.Point(4, 1);
            this.lbl_Shift1.Name = "lbl_Shift1";
            this.lbl_Shift1.Size = new System.Drawing.Size(204, 45);
            this.lbl_Shift1.TabIndex = 696;
            this.lbl_Shift1.Tag = "1";
            this.lbl_Shift1.Text = "Shift 1";
            this.lbl_Shift1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Shift1.Click += new System.EventHandler(this.lbl_Shift_Click);
            // 
            // lbl_Shift3
            // 
            this.lbl_Shift3.BackColor = System.Drawing.Color.Gray;
            this.lbl_Shift3.Font = new System.Drawing.Font("Calibri", 28.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Shift3.ForeColor = System.Drawing.Color.White;
            this.lbl_Shift3.Location = new System.Drawing.Point(414, 1);
            this.lbl_Shift3.Name = "lbl_Shift3";
            this.lbl_Shift3.Size = new System.Drawing.Size(204, 45);
            this.lbl_Shift3.TabIndex = 704;
            this.lbl_Shift3.Tag = "3";
            this.lbl_Shift3.Text = "Shift 3";
            this.lbl_Shift3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Shift3.Click += new System.EventHandler(this.lbl_Shift_Click);
            // 
            // FORM_SMT_PU_MOLD_ACTUAL_PLAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 952);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.pnShift);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.lblPH1);
            this.Controls.Add(this.lbl_Actual);
            this.Controls.Add(this.lbl_Plan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_change);
            this.Controls.Add(this.lblPH3);
            this.Controls.Add(this.lblPH2);
            this.Controls.Add(this.axGrid);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FORM_SMT_PU_MOLD_ACTUAL_PLAN";
            this.Text = "APS Plan && Actual";
            this.Load += new System.EventHandler(this.Frm_Mold_WS_Change_By_Shift_Load);
            this.VisibleChanged += new System.EventHandler(this.Frm_Mold_WS_Change_By_Shift_VisibleChanged);
            this.pnHeader.ResumeLayout(false);
            this.pnButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).EndInit();
            this.pnShift.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxFPSpreadADO.AxfpSpread axGrid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmr_blind;
        private System.Windows.Forms.Label lblPH3;
        private System.Windows.Forms.Label lblPH2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbl_change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Actual;
        private System.Windows.Forms.Label lbl_Plan;
        private System.Windows.Forms.Label lblPH1;
        private System.Windows.Forms.Panel pnHeader;
        protected System.Windows.Forms.Button cmdBack;
        protected System.Windows.Forms.Panel pnButton;
        protected DevExpress.XtraEditors.SimpleButton cmdMonth;
        protected DevExpress.XtraEditors.SimpleButton cmdYear;
        protected DevExpress.XtraEditors.SimpleButton cmdDay;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lbl_dif3;
        private DevExpress.XtraEditors.DateEdit dtpDate;
        private System.Windows.Forms.Panel pnShift;
        private System.Windows.Forms.Label lbl_dif2;
        private System.Windows.Forms.Label lbl_dif1;
        private System.Windows.Forms.Label lbl_Shift2;
        private System.Windows.Forms.Label lbl_Shift1;
        private System.Windows.Forms.Label lbl_Shift3;
    }
}