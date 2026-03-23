namespace TravelAround
{
    partial class FrmEditSavedRoute
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
            this.lblTitle    = new System.Windows.Forms.Label();
            this.lblSub      = new System.Windows.Forms.Label();
            this.dgvRoutes   = new System.Windows.Forms.DataGridView();
            this.pnlFooter   = new System.Windows.Forms.Panel();
            this.btnBack     = new System.Windows.Forms.Button();
            this.colRouteNo  = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRouteName= new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colView     = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEdit     = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete   = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // ── pnlHeader ──────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height    = 72;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSub);

            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 16f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location  = new System.Drawing.Point(18, 10);
            this.lblTitle.Text      = "Edit Saved Routes";

            this.lblSub.AutoSize  = true;
            this.lblSub.Font      = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(148, 180, 255);
            this.lblSub.Location  = new System.Drawing.Point(20, 44);
            this.lblSub.Text      = "View, edit or delete your saved journeys";

            // ── DataGridView ───────────────────────────────────────
            this.dgvRoutes.AllowUserToAddRows  = false;
            this.dgvRoutes.BackgroundColor     = System.Drawing.Color.FromArgb(240, 244, 255);
            this.dgvRoutes.BorderStyle         = System.Windows.Forms.BorderStyle.None;
            this.dgvRoutes.CellBorderStyle     = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRoutes.GridColor           = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvRoutes.RowHeadersVisible   = false;
            this.dgvRoutes.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoutes.ReadOnly            = true;

            // Column header style
            this.dgvRoutes.ColumnHeadersDefaultCellStyle.BackColor  = System.Drawing.Color.FromArgb(13, 28, 64);
            this.dgvRoutes.ColumnHeadersDefaultCellStyle.ForeColor  = System.Drawing.Color.White;
            this.dgvRoutes.ColumnHeadersDefaultCellStyle.Font       = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.dgvRoutes.ColumnHeadersDefaultCellStyle.Padding    = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.dgvRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRoutes.ColumnHeadersHeight = 36;
            this.dgvRoutes.EnableHeadersVisualStyles = false;

            // Row style
            this.dgvRoutes.DefaultCellStyle.BackColor  = System.Drawing.Color.White;
            this.dgvRoutes.DefaultCellStyle.ForeColor  = System.Drawing.Color.FromArgb(13, 17, 23);
            this.dgvRoutes.DefaultCellStyle.Font       = new System.Drawing.Font("Segoe UI", 9.5f);
            this.dgvRoutes.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(239, 244, 255);
            this.dgvRoutes.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.dgvRoutes.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 251, 255);
            this.dgvRoutes.RowTemplate.Height = 36;

            this.dgvRoutes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colRouteNo, this.colRouteName, this.colView, this.colEdit, this.colDelete });
            this.dgvRoutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoutes.TabIndex = 0;
            this.dgvRoutes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoutes_CellContentClick);

            // Columns
            this.colRouteNo.AutoSizeMode  = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRouteNo.HeaderText    = "#";
            this.colRouteNo.Name          = "colRouteNo";
            this.colRouteNo.ReadOnly      = true;
            this.colRouteNo.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);

            this.colRouteName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRouteName.HeaderText   = "Route";
            this.colRouteName.Name         = "colRouteName";
            this.colRouteName.ReadOnly     = true;
            this.colRouteName.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);

            this.colView.AutoSizeMode              = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colView.HeaderText                = "";
            this.colView.Name                      = "colView";
            this.colView.ReadOnly                  = true;
            this.colView.Text                      = "View";
            this.colView.UseColumnTextForButtonValue = true;
            this.colView.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.colView.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(239, 244, 255);
            this.colView.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(26, 79, 160);
            this.colView.DefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);

            this.colEdit.AutoSizeMode              = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEdit.HeaderText                = "";
            this.colEdit.Name                      = "colEdit";
            this.colEdit.ReadOnly                  = true;
            this.colEdit.Text                      = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            this.colEdit.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.colEdit.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            this.colEdit.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.colEdit.DefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);

            this.colDelete.AutoSizeMode              = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDelete.HeaderText                = "";
            this.colDelete.Name                      = "colDelete";
            this.colDelete.ReadOnly                  = true;
            this.colDelete.Text                      = "Delete";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.colDelete.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            this.colDelete.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.colDelete.DefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);

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
            this.btnBack.TabIndex   = 1;
            this.btnBack.Text       = "←  Back";
            this.btnBack.Click     += new System.EventHandler(this.btnBack_Click);

            // ── Form ───────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(240, 244, 255);
            this.ClientSize          = new System.Drawing.Size(540, 440);
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox         = false;
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.dgvRoutes);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmEditSavedRoute";
            this.Text = "TravelAround – Edit Routes";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel                     pnlHeader;
        private System.Windows.Forms.Label                     lblTitle;
        private System.Windows.Forms.Label                     lblSub;
        private System.Windows.Forms.DataGridView              dgvRoutes;
        private System.Windows.Forms.Panel                     pnlFooter;
        private System.Windows.Forms.Button                    btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn  colRouteNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn  colRouteName;
        private System.Windows.Forms.DataGridViewButtonColumn   colView;
        private System.Windows.Forms.DataGridViewButtonColumn   colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn   colDelete;
    }
}
