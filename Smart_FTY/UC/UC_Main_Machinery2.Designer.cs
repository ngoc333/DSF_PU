namespace Smart_FTY.UC
{
    partial class UC_Main_Machinery2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Main_Machinery2));
            this.axGrid = new AxFPUSpreadADO.AxfpSpread();
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // axGrid
            // 
            this.axGrid.DataSource = null;
            this.axGrid.Location = new System.Drawing.Point(0, 0);
            this.axGrid.Name = "axGrid";
            this.axGrid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrid.OcxState")));
            this.axGrid.Size = new System.Drawing.Size(200, 75);
            this.axGrid.TabIndex = 0;
            // 
            // UC_Main_Machinery2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axGrid);
            this.Name = "UC_Main_Machinery2";
            this.Size = new System.Drawing.Size(200, 75);
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxFPUSpreadADO.AxfpSpread axGrid;
    }
}
