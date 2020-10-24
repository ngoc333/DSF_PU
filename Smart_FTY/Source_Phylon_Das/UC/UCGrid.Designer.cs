namespace Smart_FTY
{
    partial class UCGrid
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCGrid));
            this.axGrid = new AxFPUSpreadADO.AxfpSpread();
            this.tmrLoad = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // axGrid
            // 
            this.axGrid.DataSource = null;
            this.axGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axGrid.Location = new System.Drawing.Point(0, 0);
            this.axGrid.Name = "axGrid";
            this.axGrid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrid.OcxState")));
            this.axGrid.Size = new System.Drawing.Size(1128, 419);
            this.axGrid.TabIndex = 0;
            // 
            // tmrLoad
            // 
            this.tmrLoad.Tick += new System.EventHandler(this.tmrLoad_Tick);
            // 
            // UCGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.axGrid);
            this.Name = "UCGrid";
            this.Size = new System.Drawing.Size(1128, 419);
            this.VisibleChanged += new System.EventHandler(this.UCGrid_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxFPUSpreadADO.AxfpSpread axGrid;
        private System.Windows.Forms.Timer tmrLoad;

    }
}
