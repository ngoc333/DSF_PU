namespace Smart_FTY
{
    partial class Form_Home_Phylon_Das
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
            this.pnHeader = new System.Windows.Forms.Panel();
            this.cmdInv = new System.Windows.Forms.Button();
            this.cmdDef = new System.Windows.Forms.Button();
            this.cmdPMSche = new System.Windows.Forms.Button();
            this.cmdLayout = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.pnBody = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cmdLine = new System.Windows.Forms.Button();
            this.tblGrid = new System.Windows.Forms.TableLayoutPanel();
            this.tblMenu = new System.Windows.Forms.TableLayoutPanel();
            this.pnHeader.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnHeader.Controls.Add(this.cmdInv);
            this.pnHeader.Controls.Add(this.cmdDef);
            this.pnHeader.Controls.Add(this.cmdPMSche);
            this.pnHeader.Controls.Add(this.cmdLayout);
            this.pnHeader.Controls.Add(this.lblDateTime);
            this.pnHeader.Controls.Add(this.lblTitle);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1916, 107);
            this.pnHeader.TabIndex = 1;
            // 
            // cmdInv
            // 
            this.cmdInv.BackgroundImage = global::Smart_FTY.Properties.Resources.BtnMainG;
            this.cmdInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdInv.FlatAppearance.BorderSize = 0;
            this.cmdInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdInv.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.cmdInv.ForeColor = System.Drawing.Color.Yellow;
            this.cmdInv.Location = new System.Drawing.Point(1522, 2);
            this.cmdInv.Name = "cmdInv";
            this.cmdInv.Size = new System.Drawing.Size(120, 105);
            this.cmdInv.TabIndex = 690;
            this.cmdInv.Text = "Inventory";
            this.cmdInv.UseVisualStyleBackColor = true;
            this.cmdInv.Click += new System.EventHandler(this.cmdInv_Click);
            // 
            // cmdDef
            // 
            this.cmdDef.BackgroundImage = global::Smart_FTY.Properties.Resources.BtnMainG;
            this.cmdDef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdDef.FlatAppearance.BorderSize = 0;
            this.cmdDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDef.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.cmdDef.ForeColor = System.Drawing.Color.Yellow;
            this.cmdDef.Location = new System.Drawing.Point(1396, 3);
            this.cmdDef.Name = "cmdDef";
            this.cmdDef.Size = new System.Drawing.Size(120, 105);
            this.cmdDef.TabIndex = 689;
            this.cmdDef.Text = "Defective";
            this.cmdDef.UseVisualStyleBackColor = true;
            this.cmdDef.Click += new System.EventHandler(this.cmdDef_Click);
            // 
            // cmdPMSche
            // 
            this.cmdPMSche.BackgroundImage = global::Smart_FTY.Properties.Resources.BtnMainG;
            this.cmdPMSche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdPMSche.FlatAppearance.BorderSize = 0;
            this.cmdPMSche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPMSche.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.cmdPMSche.ForeColor = System.Drawing.Color.Yellow;
            this.cmdPMSche.Location = new System.Drawing.Point(1270, 1);
            this.cmdPMSche.Name = "cmdPMSche";
            this.cmdPMSche.Size = new System.Drawing.Size(120, 105);
            this.cmdPMSche.TabIndex = 688;
            this.cmdPMSche.Text = "PM\r\nSchedule";
            this.cmdPMSche.UseVisualStyleBackColor = true;
            // 
            // cmdLayout
            // 
            this.cmdLayout.BackgroundImage = global::Smart_FTY.Properties.Resources.BtnMainG;
            this.cmdLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdLayout.FlatAppearance.BorderSize = 0;
            this.cmdLayout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLayout.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.cmdLayout.ForeColor = System.Drawing.Color.Yellow;
            this.cmdLayout.Location = new System.Drawing.Point(1144, 1);
            this.cmdLayout.Name = "cmdLayout";
            this.cmdLayout.Size = new System.Drawing.Size(120, 105);
            this.cmdLayout.TabIndex = 687;
            this.cmdLayout.Text = "Machine\r\nLayout";
            this.cmdLayout.UseVisualStyleBackColor = true;
            this.cmdLayout.Click += new System.EventHandler(this.cmdLayout_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(1685, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(225, 100);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDateTime.DoubleClick += new System.EventHandler(this.lblDateTime_DoubleClick);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1145, 100);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Digital Shop Floor For Phylon Workshop";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.White;
            this.pnBody.Controls.Add(this.label18);
            this.pnBody.Controls.Add(this.label19);
            this.pnBody.Controls.Add(this.label20);
            this.pnBody.Controls.Add(this.cmdLine);
            this.pnBody.Controls.Add(this.tblGrid);
            this.pnBody.Controls.Add(this.tblMenu);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 107);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1916, 993);
            this.pnBody.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Red;
            this.label18.Font = new System.Drawing.Font("Calibri", 15.25F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(1804, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 30);
            this.label18.TabIndex = 12;
            this.label18.Text = "<95%";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Yellow;
            this.label19.Font = new System.Drawing.Font("Calibri", 15.25F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(1698, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 30);
            this.label19.TabIndex = 11;
            this.label19.Text = "95-98%";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Green;
            this.label20.Font = new System.Drawing.Font("Calibri", 15.25F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(1592, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 30);
            this.label20.TabIndex = 10;
            this.label20.Text = ">98%";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdLine
            // 
            this.cmdLine.BackColor = System.Drawing.Color.White;
            this.cmdLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdLine.FlatAppearance.BorderSize = 0;
            this.cmdLine.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cmdLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.cmdLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.cmdLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLine.Font = new System.Drawing.Font("Calibri", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdLine.ForeColor = System.Drawing.Color.MediumBlue;
            this.cmdLine.Location = new System.Drawing.Point(801, 3);
            this.cmdLine.Name = "cmdLine";
            this.cmdLine.Size = new System.Drawing.Size(500, 74);
            this.cmdLine.TabIndex = 9;
            this.cmdLine.Tag = "1";
            this.cmdLine.Text = "Production Status";
            this.cmdLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdLine.UseVisualStyleBackColor = false;
            this.cmdLine.MouseEnter += new System.EventHandler(this.cmdLine_MouseEnter);
            // 
            // tblGrid
            // 
            this.tblGrid.ColumnCount = 1;
            this.tblGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGrid.Location = new System.Drawing.Point(798, 80);
            this.tblGrid.Name = "tblGrid";
            this.tblGrid.RowCount = 2;
            this.tblGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblGrid.Size = new System.Drawing.Size(1113, 908);
            this.tblGrid.TabIndex = 1;
            // 
            // tblMenu
            // 
            this.tblMenu.ColumnCount = 1;
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMenu.Location = new System.Drawing.Point(3, 12);
            this.tblMenu.Name = "tblMenu";
            this.tblMenu.RowCount = 3;
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMenu.Size = new System.Drawing.Size(789, 976);
            this.tblMenu.TabIndex = 0;
            // 
            // Form_Home_Phylon_Das
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 1100);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Home_Phylon_Das";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Home_Phylon_Das";
            this.VisibleChanged += new System.EventHandler(this.Form_Home_Phylon_Das_VisibleChanged);
            this.pnHeader.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer tmrDateTime;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.TableLayoutPanel tblMenu;
        private System.Windows.Forms.TableLayoutPanel tblGrid;
        private System.Windows.Forms.Button cmdLine;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button cmdLayout;
        private System.Windows.Forms.Button cmdInv;
        private System.Windows.Forms.Button cmdDef;
        private System.Windows.Forms.Button cmdPMSche;
    }
}