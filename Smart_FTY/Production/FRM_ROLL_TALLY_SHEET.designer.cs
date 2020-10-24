namespace Smart_FTY
{
    partial class FRM_ROLL_TALLY_SHEET
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ROLL_TALLY_SHEET));
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lblWrkDate = new System.Windows.Forms.Label();
            this.lblAssyDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblS2Rate = new System.Windows.Forms.Label();
            this.lblS2Weight = new System.Windows.Forms.Label();
            this.lblS2Plan = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblS3Rate = new System.Windows.Forms.Label();
            this.lblS3Weight = new System.Windows.Forms.Label();
            this.lblS3Plan = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblS1Rate = new System.Windows.Forms.Label();
            this.lblS1Weight = new System.Windows.Forms.Label();
            this.lblS1Plan = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new Smart_FTY.ClassLib.TransparentPanel();
            this.axfpSpread = new AxFPSpreadADO.AxfpSpread();
            this.axfDailyReport_Header = new AxFPSpreadADO.AxfpSpread();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnEVA = new Smart_FTY.A1Panel();
            this.lblEVA = new System.Windows.Forms.Label();
            this.pnRubber = new Smart_FTY.A1Panel();
            this.lblRubber = new System.Windows.Forms.Label();
            this.pnHeader.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axfpSpread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axfDailyReport_Header)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnEVA.SuspendLayout();
            this.pnRubber.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Size = new System.Drawing.Size(1920, 106);
            // 
            // lblDate
            // 
            this.lblDate.Size = new System.Drawing.Size(269, 106);
            this.lblDate.Text = "2018-09-29\n14:51:51";
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
            // cmdBack
            // 
            this.cmdBack.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.cmdBack.FlatAppearance.BorderSize = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Appearance.Options.UseBackColor = true;
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Appearance.Options.UseForeColor = true;
            this.lblTitle.Location = new System.Drawing.Point(1, 13);
            this.lblTitle.Size = new System.Drawing.Size(122, 82);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 38);
            this.label5.TabIndex = 53;
            this.label5.Text = "WORKING DATE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWrkDate
            // 
            this.lblWrkDate.BackColor = System.Drawing.Color.White;
            this.lblWrkDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWrkDate.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.lblWrkDate.Location = new System.Drawing.Point(265, 191);
            this.lblWrkDate.Name = "lblWrkDate";
            this.lblWrkDate.Size = new System.Drawing.Size(187, 38);
            this.lblWrkDate.TabIndex = 54;
            this.lblWrkDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAssyDate
            // 
            this.lblAssyDate.BackColor = System.Drawing.Color.White;
            this.lblAssyDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAssyDate.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.lblAssyDate.Location = new System.Drawing.Point(265, 239);
            this.lblAssyDate.Name = "lblAssyDate";
            this.lblAssyDate.Size = new System.Drawing.Size(187, 38);
            this.lblAssyDate.TabIndex = 56;
            this.lblAssyDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(4, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 38);
            this.label8.TabIndex = 55;
            this.label8.Text = "ASSY DATE";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lblS2Rate);
            this.groupBox1.Controls.Add(this.lblS2Weight);
            this.groupBox1.Controls.Add(this.lblS2Plan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(875, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 121);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SHIFT 2";
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Blue;
            this.label24.Location = new System.Drawing.Point(245, 91);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 29);
            this.label24.TabIndex = 73;
            this.label24.Text = "%";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(240, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 29);
            this.label17.TabIndex = 72;
            this.label17.Text = "Batch";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(240, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 29);
            this.label16.TabIndex = 71;
            this.label16.Text = "Batch";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblS2Rate
            // 
            this.lblS2Rate.BackColor = System.Drawing.Color.White;
            this.lblS2Rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblS2Rate.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS2Rate.Location = new System.Drawing.Point(131, 91);
            this.lblS2Rate.Name = "lblS2Rate";
            this.lblS2Rate.Size = new System.Drawing.Size(108, 29);
            this.lblS2Rate.TabIndex = 70;
            this.lblS2Rate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblS2Weight
            // 
            this.lblS2Weight.BackColor = System.Drawing.Color.White;
            this.lblS2Weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblS2Weight.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS2Weight.Location = new System.Drawing.Point(131, 58);
            this.lblS2Weight.Name = "lblS2Weight";
            this.lblS2Weight.Size = new System.Drawing.Size(108, 29);
            this.lblS2Weight.TabIndex = 68;
            this.lblS2Weight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblS2Plan
            // 
            this.lblS2Plan.BackColor = System.Drawing.Color.White;
            this.lblS2Plan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblS2Plan.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS2Plan.Location = new System.Drawing.Point(131, 25);
            this.lblS2Plan.Name = "lblS2Plan";
            this.lblS2Plan.Size = new System.Drawing.Size(108, 29);
            this.lblS2Plan.TabIndex = 67;
            this.lblS2Plan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 29);
            this.label9.TabIndex = 69;
            this.label9.Text = "RATE";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 29);
            this.label7.TabIndex = 68;
            this.label7.Text = "WEIGHT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 67;
            this.label4.Text = "PLAN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lblS3Rate);
            this.groupBox2.Controls.Add(this.lblS3Weight);
            this.groupBox2.Controls.Add(this.lblS3Plan);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(1222, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 121);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SHIFT 3";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Blue;
            this.label25.Location = new System.Drawing.Point(241, 88);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(95, 29);
            this.label25.TabIndex = 78;
            this.label25.Text = "%";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(245, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 29);
            this.label19.TabIndex = 77;
            this.label19.Text = "Batch";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(241, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 29);
            this.label18.TabIndex = 76;
            this.label18.Text = "Batch";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblS3Rate
            // 
            this.lblS3Rate.BackColor = System.Drawing.Color.White;
            this.lblS3Rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblS3Rate.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS3Rate.Location = new System.Drawing.Point(131, 89);
            this.lblS3Rate.Name = "lblS3Rate";
            this.lblS3Rate.Size = new System.Drawing.Size(108, 29);
            this.lblS3Rate.TabIndex = 75;
            this.lblS3Rate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblS3Weight
            // 
            this.lblS3Weight.BackColor = System.Drawing.Color.White;
            this.lblS3Weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblS3Weight.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS3Weight.Location = new System.Drawing.Point(131, 56);
            this.lblS3Weight.Name = "lblS3Weight";
            this.lblS3Weight.Size = new System.Drawing.Size(108, 29);
            this.lblS3Weight.TabIndex = 74;
            this.lblS3Weight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblS3Plan
            // 
            this.lblS3Plan.BackColor = System.Drawing.Color.White;
            this.lblS3Plan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblS3Plan.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS3Plan.Location = new System.Drawing.Point(131, 23);
            this.lblS3Plan.Name = "lblS3Plan";
            this.lblS3Plan.Size = new System.Drawing.Size(108, 29);
            this.lblS3Plan.TabIndex = 73;
            this.lblS3Plan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 29);
            this.label10.TabIndex = 72;
            this.label10.Text = "RATE";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 29);
            this.label11.TabIndex = 71;
            this.label11.Text = "WEIGHT";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 29);
            this.label12.TabIndex = 70;
            this.label12.Text = "PLAN";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.lblS1Rate);
            this.groupBox3.Controls.Add(this.lblS1Weight);
            this.groupBox3.Controls.Add(this.lblS1Plan);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(528, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 121);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SHIFT 1";
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label26.ForeColor = System.Drawing.Color.Blue;
            this.label26.Location = new System.Drawing.Point(241, 87);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(95, 29);
            this.label26.TabIndex = 80;
            this.label26.Text = "%";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(243, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 29);
            this.label20.TabIndex = 79;
            this.label20.Text = "Batch";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.Blue;
            this.label21.Location = new System.Drawing.Point(242, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 29);
            this.label21.TabIndex = 78;
            this.label21.Text = "Batch";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblS1Rate
            // 
            this.lblS1Rate.BackColor = System.Drawing.Color.White;
            this.lblS1Rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblS1Rate.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblS1Rate.Location = new System.Drawing.Point(133, 91);
            this.lblS1Rate.Name = "lblS1Rate";
            this.lblS1Rate.Size = new System.Drawing.Size(108, 29);
            this.lblS1Rate.TabIndex = 75;
            this.lblS1Rate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblS1Weight
            // 
            this.lblS1Weight.BackColor = System.Drawing.Color.White;
            this.lblS1Weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblS1Weight.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblS1Weight.Location = new System.Drawing.Point(133, 58);
            this.lblS1Weight.Name = "lblS1Weight";
            this.lblS1Weight.Size = new System.Drawing.Size(108, 29);
            this.lblS1Weight.TabIndex = 74;
            this.lblS1Weight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblS1Plan
            // 
            this.lblS1Plan.BackColor = System.Drawing.Color.White;
            this.lblS1Plan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblS1Plan.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblS1Plan.Location = new System.Drawing.Point(133, 25);
            this.lblS1Plan.Name = "lblS1Plan";
            this.lblS1Plan.Size = new System.Drawing.Size(108, 29);
            this.lblS1Plan.TabIndex = 73;
            this.lblS1Plan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(8, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 29);
            this.label13.TabIndex = 72;
            this.label13.Text = "RATE";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label14.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(8, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 29);
            this.label14.TabIndex = 71;
            this.label14.Text = "WEIGHT";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label15.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(8, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 29);
            this.label15.TabIndex = 70;
            this.label15.Text = "PLAN";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.lblRate);
            this.groupBox4.Controls.Add(this.lblWeight);
            this.groupBox4.Controls.Add(this.lblPlan);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox4.Location = new System.Drawing.Point(1569, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(341, 121);
            this.groupBox4.TabIndex = 67;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TOTAL";
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Blue;
            this.label30.Location = new System.Drawing.Point(243, 88);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(95, 29);
            this.label30.TabIndex = 80;
            this.label30.Text = "%";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Blue;
            this.label22.Location = new System.Drawing.Point(245, 56);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 29);
            this.label22.TabIndex = 79;
            this.label22.Text = "Batch";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Blue;
            this.label23.Location = new System.Drawing.Point(242, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(95, 29);
            this.label23.TabIndex = 78;
            this.label23.Text = "Batch";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRate
            // 
            this.lblRate.BackColor = System.Drawing.Color.White;
            this.lblRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRate.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(133, 89);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(108, 29);
            this.lblRate.TabIndex = 75;
            this.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeight
            // 
            this.lblWeight.BackColor = System.Drawing.Color.White;
            this.lblWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeight.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(133, 56);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(108, 29);
            this.lblWeight.TabIndex = 74;
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlan
            // 
            this.lblPlan.BackColor = System.Drawing.Color.White;
            this.lblPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlan.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlan.Location = new System.Drawing.Point(133, 23);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(108, 29);
            this.lblPlan.TabIndex = 73;
            this.lblPlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label27.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(8, 89);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(124, 29);
            this.label27.TabIndex = 72;
            this.label27.Text = "RATE";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label28.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(8, 56);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(124, 29);
            this.label28.TabIndex = 71;
            this.label28.Text = "WEIGHT";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label29.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(8, 23);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(124, 29);
            this.label29.TabIndex = 70;
            this.label29.Text = "PLAN";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(458, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(67, 39);
            this.panel2.TabIndex = 62;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // axfpSpread
            // 
            this.axfpSpread.DataSource = null;
            this.axfpSpread.Location = new System.Drawing.Point(5, 304);
            this.axfpSpread.Name = "axfpSpread";
            this.axfpSpread.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axfpSpread.OcxState")));
            this.axfpSpread.Size = new System.Drawing.Size(1911, 773);
            this.axfpSpread.TabIndex = 63;
            // 
            // axfDailyReport_Header
            // 
            this.axfDailyReport_Header.DataSource = null;
            this.axfDailyReport_Header.Location = new System.Drawing.Point(8, 162);
            this.axfDailyReport_Header.Name = "axfDailyReport_Header";
            this.axfDailyReport_Header.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axfDailyReport_Header.OcxState")));
            this.axfDailyReport_Header.Size = new System.Drawing.Size(1912, 92);
            this.axfDailyReport_Header.TabIndex = 61;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnEVA);
            this.panel3.Controls.Add(this.pnRubber);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1920, 57);
            this.panel3.TabIndex = 68;
            // 
            // pnEVA
            // 
            this.pnEVA.AccessibleDescription = "";
            this.pnEVA.AccessibleName = "";
            this.pnEVA.BorderColor = System.Drawing.Color.Empty;
            this.pnEVA.BorderWidth = 2;
            this.pnEVA.Controls.Add(this.lblEVA);
            this.pnEVA.GradientEndColor = System.Drawing.Color.White;
            this.pnEVA.GradientStartColor = System.Drawing.Color.White;
            this.pnEVA.Image = null;
            this.pnEVA.ImageLocation = new System.Drawing.Point(4, 4);
            this.pnEVA.Location = new System.Drawing.Point(160, 5);
            this.pnEVA.Name = "pnEVA";
            this.pnEVA.RoundCornerRadius = 20;
            this.pnEVA.ShadowOffSet = 3;
            this.pnEVA.Size = new System.Drawing.Size(153, 49);
            this.pnEVA.TabIndex = 0;
            // 
            // lblEVA
            // 
            this.lblEVA.BackColor = System.Drawing.Color.Transparent;
            this.lblEVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEVA.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEVA.Location = new System.Drawing.Point(0, 0);
            this.lblEVA.Name = "lblEVA";
            this.lblEVA.Size = new System.Drawing.Size(153, 49);
            this.lblEVA.TabIndex = 1;
            this.lblEVA.Text = "EVA";
            this.lblEVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEVA.Click += new System.EventHandler(this.lblEVA_Click);
            // 
            // pnRubber
            // 
            this.pnRubber.AccessibleDescription = "";
            this.pnRubber.AccessibleName = "";
            this.pnRubber.BorderColor = System.Drawing.Color.Empty;
            this.pnRubber.BorderWidth = 2;
            this.pnRubber.Controls.Add(this.lblRubber);
            this.pnRubber.GradientEndColor = System.Drawing.Color.Gray;
            this.pnRubber.GradientStartColor = System.Drawing.Color.White;
            this.pnRubber.Image = null;
            this.pnRubber.ImageLocation = new System.Drawing.Point(4, 4);
            this.pnRubber.Location = new System.Drawing.Point(3, 5);
            this.pnRubber.Name = "pnRubber";
            this.pnRubber.RoundCornerRadius = 20;
            this.pnRubber.ShadowOffSet = 3;
            this.pnRubber.Size = new System.Drawing.Size(153, 49);
            this.pnRubber.TabIndex = 0;
            // 
            // lblRubber
            // 
            this.lblRubber.BackColor = System.Drawing.Color.Transparent;
            this.lblRubber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRubber.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubber.Location = new System.Drawing.Point(0, 0);
            this.lblRubber.Name = "lblRubber";
            this.lblRubber.Size = new System.Drawing.Size(153, 49);
            this.lblRubber.TabIndex = 0;
            this.lblRubber.Text = "Rubber";
            this.lblRubber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRubber.Click += new System.EventHandler(this.lblRubber_Click);
            // 
            // FRM_ROLL_TALLY_SHEET
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblAssyDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblWrkDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.axfpSpread);
            this.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FRM_ROLL_TALLY_SHEET";
            this.Text = "FORM_WORK_TALLY_SHEET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORM_WORK_TALLY_SHEET_FormClosing);
            this.Load += new System.EventHandler(this.FORM_WORK_TALLY_SHEET_Load);
            this.VisibleChanged += new System.EventHandler(this.FORM_WORK_TALLY_SHEET_VisibleChanged);
            this.Controls.SetChildIndex(this.pnHeader, 0);
            this.Controls.SetChildIndex(this.axfpSpread, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lblWrkDate, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.lblAssyDate, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axfpSpread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axfDailyReport_Header)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pnEVA.ResumeLayout(false);
            this.pnRubber.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWrkDate;
        private System.Windows.Forms.Label lblAssyDate;
        private System.Windows.Forms.Label label8;
        private AxFPSpreadADO.AxfpSpread axfDailyReport_Header;
        private ClassLib.TransparentPanel panel2;
        private AxFPSpreadADO.AxfpSpread axfpSpread;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblS2Rate;
        private System.Windows.Forms.Label lblS2Weight;
        private System.Windows.Forms.Label lblS2Plan;
        private System.Windows.Forms.Label lblS3Rate;
        private System.Windows.Forms.Label lblS3Weight;
        private System.Windows.Forms.Label lblS3Plan;
        private System.Windows.Forms.Label lblS1Rate;
        private System.Windows.Forms.Label lblS1Weight;
        private System.Windows.Forms.Label lblS1Plan;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private A1Panel pnEVA;
        private System.Windows.Forms.Label lblEVA;
        private A1Panel pnRubber;
        private System.Windows.Forms.Label lblRubber;
    }
}

