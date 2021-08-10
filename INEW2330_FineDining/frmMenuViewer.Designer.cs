namespace INEW2330_FineDining
{
    partial class frmViewer
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
            this.crvMenuViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvMenuViewer
            // 
            this.crvMenuViewer.ActiveViewIndex = -1;
            this.crvMenuViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvMenuViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvMenuViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvMenuViewer.Location = new System.Drawing.Point(0, 0);
            this.crvMenuViewer.Name = "crvMenuViewer";
            this.crvMenuViewer.Size = new System.Drawing.Size(800, 450);
            this.crvMenuViewer.TabIndex = 0;
            this.crvMenuViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvMenuViewer);
            this.Name = "frmViewer";
            this.Text = "View";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvMenuViewer;
    }
}