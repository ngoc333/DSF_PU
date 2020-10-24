namespace Smart_FTY
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.backstageViewTabItem2 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.pnForm = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.backstageViewTabItem1.Appearance.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.backstageViewTabItem1.Appearance.Options.UseBackColor = true;
            this.backstageViewTabItem1.Appearance.Options.UseFont = true;
            this.backstageViewTabItem1.AppearanceHover.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Bold);
            this.backstageViewTabItem1.AppearanceHover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.backstageViewTabItem1.AppearanceHover.Options.UseFont = true;
            this.backstageViewTabItem1.AppearanceHover.Options.UseForeColor = true;
            this.backstageViewTabItem1.AppearanceSelected.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.backstageViewTabItem1.AppearanceSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.backstageViewTabItem1.AppearanceSelected.Options.UseFont = true;
            this.backstageViewTabItem1.AppearanceSelected.Options.UseForeColor = true;
            this.backstageViewTabItem1.Caption = "Quality";
            this.backstageViewTabItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("backstageViewTabItem1.Glyph")));
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            // 
            // backstageViewTabItem2
            // 
            this.backstageViewTabItem2.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.backstageViewTabItem2.Appearance.BackColor2 = System.Drawing.SystemColors.Control;
            this.backstageViewTabItem2.Appearance.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.backstageViewTabItem2.Appearance.Options.UseBackColor = true;
            this.backstageViewTabItem2.Appearance.Options.UseFont = true;
            this.backstageViewTabItem2.AppearanceHover.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Bold);
            this.backstageViewTabItem2.AppearanceHover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.backstageViewTabItem2.AppearanceHover.Options.UseFont = true;
            this.backstageViewTabItem2.AppearanceHover.Options.UseForeColor = true;
            this.backstageViewTabItem2.AppearanceSelected.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.backstageViewTabItem2.AppearanceSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.backstageViewTabItem2.AppearanceSelected.Options.UseFont = true;
            this.backstageViewTabItem2.AppearanceSelected.Options.UseForeColor = true;
            this.backstageViewTabItem2.Caption = "Production\r\n";
            this.backstageViewTabItem2.CaptionVerticalAlignment = DevExpress.Utils.Drawing.ItemVerticalAlignment.Top;
            this.backstageViewTabItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("backstageViewTabItem2.Glyph")));
            this.backstageViewTabItem2.Name = "backstageViewTabItem2";
            superToolTip1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            superToolTip1.DistanceBetweenItems = 1;
            toolTipTitleItem1.Text = "Sản Xuất";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.backstageViewTabItem2.SuperTip = superToolTip1;
            // 
            // pnForm
            // 
            this.pnForm.Location = new System.Drawing.Point(12, 12);
            this.pnForm.Name = "pnForm";
            this.pnForm.Size = new System.Drawing.Size(906, 526);
            this.pnForm.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 550);
            this.Controls.Add(this.pnForm);
            this.KeyPreview = true;
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrTime;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem2;
        private System.Windows.Forms.Panel pnForm;
    }
}