namespace TravelAround
{
    partial class MainMenu
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
            this.pnlHeader   = new System.Windows.Forms.Panel();
            this.lblAppName  = new System.Windows.Forms.Label();
            this.lblWelcome  = new System.Windows.Forms.Label();
            this.pnlBody     = new System.Windows.Forms.Panel();
            this.btnRoute    = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlDivider  = new System.Windows.Forms.Panel();
            this.btnExit     = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();

            // ── pnlHeader ──────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height    = 88;
            this.pnlHeader.Controls.Add(this.lblAppName);
            this.pnlHeader.Controls.Add(this.lblWelcome);

            this.lblAppName.AutoSize  = true;
            this.lblAppName.Font      = new System.Drawing.Font("Segoe UI", 20f, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location  = new System.Drawing.Point(18, 14);
            this.lblAppName.Text      = "TravelAround";

            this.lblWelcome.AutoSize  = true;
            this.lblWelcome.Font      = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(148, 180, 255);
            this.lblWelcome.Location  = new System.Drawing.Point(20, 52);
            this.lblWelcome.Text      = "Where would you like to go today?";

            // ── pnlBody ────────────────────────────────────────────
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.pnlBody.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Controls.Add(this.btnRoute);
            this.pnlBody.Controls.Add(this.btnSettings);
            this.pnlBody.Controls.Add(this.pnlDivider);
            this.pnlBody.Controls.Add(this.btnExit);

            // Routes tile
            this.btnRoute.BackColor = System.Drawing.Color.White;
            this.btnRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnRoute.FlatAppearance.BorderSize  = 1;
            this.btnRoute.Font      = new System.Drawing.Font("Segoe UI", 10.5f, System.Drawing.FontStyle.Bold);
            this.btnRoute.ForeColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.btnRoute.Location  = new System.Drawing.Point(20, 22);
            this.btnRoute.Size      = new System.Drawing.Size(245, 52);
            this.btnRoute.TabIndex  = 0;
            this.btnRoute.Text      = "Routes";
            this.btnRoute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoute.Padding   = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRoute.Click    += new System.EventHandler(this.btnRoute_Click);

            // Settings tile
            this.btnSettings.BackColor = System.Drawing.Color.White;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnSettings.FlatAppearance.BorderSize  = 1;
            this.btnSettings.Font      = new System.Drawing.Font("Segoe UI", 10.5f, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.btnSettings.Location  = new System.Drawing.Point(20, 84);
            this.btnSettings.Size      = new System.Drawing.Size(245, 52);
            this.btnSettings.TabIndex  = 1;
            this.btnSettings.Text      = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Padding   = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSettings.Click    += new System.EventHandler(this.btnSettings_Click);

            // Divider
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pnlDivider.Location  = new System.Drawing.Point(20, 150);
            this.pnlDivider.Size      = new System.Drawing.Size(245, 1);

            // Exit
            this.btnExit.BackColor  = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(254, 202, 202);
            this.btnExit.Font       = new System.Drawing.Font("Segoe UI", 9f);
            this.btnExit.ForeColor  = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnExit.Location   = new System.Drawing.Point(20, 162);
            this.btnExit.Size       = new System.Drawing.Size(245, 30);
            this.btnExit.TabIndex   = 2;
            this.btnExit.Text       = "Exit Application";
            this.btnExit.Click     += new System.EventHandler(this.btnExit_Click);

            // ── Form ───────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(240, 244, 255);
            this.ClientSize          = new System.Drawing.Size(285, 296);
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox         = false;
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Name = "MainMenu";
            this.Text = "TravelAround";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel  pnlHeader;
        private System.Windows.Forms.Label  lblAppName;
        private System.Windows.Forms.Label  lblWelcome;
        private System.Windows.Forms.Panel  pnlBody;
        private System.Windows.Forms.Button btnRoute;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel  pnlDivider;
        private System.Windows.Forms.Button btnExit;
    }
}
