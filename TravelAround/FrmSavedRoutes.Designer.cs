namespace TravelAround
{
    partial class FrmSavedRoutes
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader  = new System.Windows.Forms.Panel();
            this.lblHeader  = new System.Windows.Forms.Label();
            this.lblSubtitle= new System.Windows.Forms.Label();
            this.pnlScroll  = new System.Windows.Forms.Panel();
            this.pnlFooter  = new System.Windows.Forms.Panel();
            this.btnBack    = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // ── pnlHeader ──────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height    = 72;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.lblSubtitle);

            this.lblHeader.AutoSize  = true;
            this.lblHeader.Font      = new System.Drawing.Font("Segoe UI", 16f, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location  = new System.Drawing.Point(18, 10);
            this.lblHeader.Text      = "My Saved Routes";

            this.lblSubtitle.AutoSize  = true;
            this.lblSubtitle.Font      = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(148, 180, 255);
            this.lblSubtitle.Location  = new System.Drawing.Point(20, 44);
            this.lblSubtitle.Text      = "View-only summary of all your routes";

            // ── pnlScroll ──────────────────────────────────────────
            this.pnlScroll.AutoScroll  = true;
            this.pnlScroll.BackColor   = System.Drawing.Color.FromArgb(240, 244, 255);
            this.pnlScroll.Dock        = System.Windows.Forms.DockStyle.Fill;
            this.pnlScroll.Padding     = new System.Windows.Forms.Padding(12, 10, 12, 10);

            // ── pnlFooter ──────────────────────────────────────────
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Height    = 48;
            this.pnlFooter.Controls.Add(this.btnBack);

            this.btnBack.BackColor  = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnBack.Font       = new System.Drawing.Font("Segoe UI", 9f);
            this.btnBack.ForeColor  = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnBack.Location   = new System.Drawing.Point(432, 10);
            this.btnBack.Size       = new System.Drawing.Size(90, 28);
            this.btnBack.TabIndex   = 0;
            this.btnBack.Text       = "←  Back";
            this.btnBack.Click     += new System.EventHandler(this.btnBack_Click);

            // ── Form ───────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(240, 244, 255);
            this.ClientSize          = new System.Drawing.Size(540, 520);
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox         = false;
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.pnlScroll);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmSavedRoutes";
            this.Text = "TravelAround – My Routes";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel  pnlHeader;
        private System.Windows.Forms.Label  lblHeader;
        private System.Windows.Forms.Label  lblSubtitle;
        private System.Windows.Forms.Panel  pnlScroll;
        private System.Windows.Forms.Panel  pnlFooter;
        private System.Windows.Forms.Button btnBack;
    }
}
