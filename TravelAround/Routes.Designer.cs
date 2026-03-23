namespace TravelAround
{
    partial class Routes
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
            this.pnlHeader        = new System.Windows.Forms.Panel();
            this.lblTitle         = new System.Windows.Forms.Label();
            this.lblSub           = new System.Windows.Forms.Label();
            this.pnlBody          = new System.Windows.Forms.Panel();
            this.btnCreateNewRoute= new System.Windows.Forms.Button();
            this.btnEditRoute     = new System.Windows.Forms.Button();
            this.btnViewRoute     = new System.Windows.Forms.Button();
            this.pnlDivider       = new System.Windows.Forms.Panel();
            this.btnBack          = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();

            // ── pnlHeader ──────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height    = 80;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSub);

            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 18f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location  = new System.Drawing.Point(18, 12);
            this.lblTitle.Text      = "Routes";

            this.lblSub.AutoSize  = true;
            this.lblSub.Font      = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(148, 180, 255);
            this.lblSub.Location  = new System.Drawing.Point(20, 48);
            this.lblSub.Text      = "Manage your journeys";

            // ── pnlBody ────────────────────────────────────────────
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.pnlBody.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Controls.Add(this.btnCreateNewRoute);
            this.pnlBody.Controls.Add(this.btnEditRoute);
            this.pnlBody.Controls.Add(this.btnViewRoute);
            this.pnlBody.Controls.Add(this.pnlDivider);
            this.pnlBody.Controls.Add(this.btnBack);

            // Create New Route
            this.btnCreateNewRoute.BackColor = System.Drawing.Color.FromArgb(26, 79, 160);
            this.btnCreateNewRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNewRoute.FlatAppearance.BorderSize = 0;
            this.btnCreateNewRoute.Font      = new System.Drawing.Font("Segoe UI", 10.5f, System.Drawing.FontStyle.Bold);
            this.btnCreateNewRoute.ForeColor = System.Drawing.Color.White;
            this.btnCreateNewRoute.Location  = new System.Drawing.Point(20, 20);
            this.btnCreateNewRoute.Size      = new System.Drawing.Size(245, 48);
            this.btnCreateNewRoute.TabIndex  = 0;
            this.btnCreateNewRoute.Text      = "+ Create New Route";
            this.btnCreateNewRoute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNewRoute.Padding   = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCreateNewRoute.Click    += new System.EventHandler(this.btnCreateNewRoute_Click);

            // Edit Saved Route
            this.btnEditRoute.BackColor = System.Drawing.Color.White;
            this.btnEditRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRoute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnEditRoute.Font      = new System.Drawing.Font("Segoe UI", 10.5f, System.Drawing.FontStyle.Bold);
            this.btnEditRoute.ForeColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.btnEditRoute.Location  = new System.Drawing.Point(20, 78);
            this.btnEditRoute.Size      = new System.Drawing.Size(245, 48);
            this.btnEditRoute.TabIndex  = 1;
            this.btnEditRoute.Text      = "Edit Saved Route";
            this.btnEditRoute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditRoute.Padding   = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEditRoute.Click    += new System.EventHandler(this.btnEditSavedRoute_Click);

            // View Saved Routes
            this.btnViewRoute.BackColor = System.Drawing.Color.White;
            this.btnViewRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRoute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnViewRoute.Font      = new System.Drawing.Font("Segoe UI", 10.5f, System.Drawing.FontStyle.Bold);
            this.btnViewRoute.ForeColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.btnViewRoute.Location  = new System.Drawing.Point(20, 136);
            this.btnViewRoute.Size      = new System.Drawing.Size(245, 48);
            this.btnViewRoute.TabIndex  = 2;
            this.btnViewRoute.Text      = "View Saved Routes";
            this.btnViewRoute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewRoute.Padding   = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnViewRoute.Click    += new System.EventHandler(this.btnViewSavedRoutes_Click);

            // Divider
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pnlDivider.Location  = new System.Drawing.Point(20, 198);
            this.pnlDivider.Size      = new System.Drawing.Size(245, 1);

            // Back
            this.btnBack.BackColor  = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnBack.Font       = new System.Drawing.Font("Segoe UI", 9f);
            this.btnBack.ForeColor  = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnBack.Location   = new System.Drawing.Point(20, 210);
            this.btnBack.Size       = new System.Drawing.Size(245, 30);
            this.btnBack.TabIndex   = 3;
            this.btnBack.Text       = "←  Back";
            this.btnBack.Click     += new System.EventHandler(this.btnBack_Click);

            // ── Form ───────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(240, 244, 255);
            this.ClientSize          = new System.Drawing.Size(285, 328);
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox         = false;
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Routes";
            this.Text = "TravelAround – Routes";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel  pnlHeader;
        private System.Windows.Forms.Label  lblTitle;
        private System.Windows.Forms.Label  lblSub;
        private System.Windows.Forms.Panel  pnlBody;
        private System.Windows.Forms.Button btnCreateNewRoute;
        private System.Windows.Forms.Button btnEditRoute;
        private System.Windows.Forms.Button btnViewRoute;
        private System.Windows.Forms.Panel  pnlDivider;
        private System.Windows.Forms.Button btnBack;
    }
}
