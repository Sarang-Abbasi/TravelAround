namespace TravelAround
{
    partial class FrmCreateRoute
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader        = new System.Windows.Forms.Panel();
            this.lblTitle         = new System.Windows.Forms.Label();
            this.lblSubtitle      = new System.Windows.Forms.Label();
            this.pnlBody          = new System.Windows.Forms.Panel();
            this.pnlModeRow       = new System.Windows.Forms.Panel();
            this.lblModeTitle     = new System.Windows.Forms.Label();
            this.rbDefault        = new System.Windows.Forms.RadioButton();
            this.rbCustom         = new System.Windows.Forms.RadioButton();
            this.lblStart         = new System.Windows.Forms.Label();
            this.cmbStart         = new System.Windows.Forms.ComboBox();
            this.txtStart         = new System.Windows.Forms.TextBox();
            this.lblStopHdr       = new System.Windows.Forms.Label();
            this.cmbStop          = new System.Windows.Forms.ComboBox();
            this.btnAddStop       = new System.Windows.Forms.Button();
            this.txtStop          = new System.Windows.Forms.TextBox();
            this.btnAddStopCustom = new System.Windows.Forms.Button();
            this.lblStopList      = new System.Windows.Forms.Label();
            this.lstStops         = new System.Windows.Forms.ListBox();
            this.btnDeleteStop    = new System.Windows.Forms.Button();
            this.lblEnd           = new System.Windows.Forms.Label();
            this.cmbEnd           = new System.Windows.Forms.ComboBox();
            this.txtEnd           = new System.Windows.Forms.TextBox();
            this.lblDistance      = new System.Windows.Forms.Label();
            this.txtDistance      = new System.Windows.Forms.TextBox();
            this.lblDistanceKm    = new System.Windows.Forms.Label();
            this.lblTransport     = new System.Windows.Forms.Label();
            this.cmbTransport     = new System.Windows.Forms.ComboBox();
            this.btnCreateRoute   = new System.Windows.Forms.Button();
            this.pnlResultBox     = new System.Windows.Forms.Panel();
            this.lblResultHdr     = new System.Windows.Forms.Label();
            this.lblResult        = new System.Windows.Forms.Label();
            this.btnSaveRoute     = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlModeRow.SuspendLayout();
            this.pnlResultBox.SuspendLayout();
            this.SuspendLayout();

            // ── pnlHeader ────────────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock     = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name     = "pnlHeader";
            this.pnlHeader.Size     = new System.Drawing.Size(360, 68);
            this.pnlHeader.TabIndex = 0;

            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location  = new System.Drawing.Point(14, 10);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.TabIndex  = 0;
            this.lblTitle.Text      = "Create Route";

            this.lblSubtitle.AutoSize  = true;
            this.lblSubtitle.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(155, 185, 230);
            this.lblSubtitle.Location  = new System.Drawing.Point(16, 44);
            this.lblSubtitle.Name      = "lblSubtitle";
            this.lblSubtitle.TabIndex  = 1;
            this.lblSubtitle.Text      = "Plan a new journey";

            // ── pnlBody ──────────────────────────────────────────────────
            this.pnlBody.AutoScroll = false;
            this.pnlBody.BackColor  = System.Drawing.Color.FromArgb(240, 244, 255);
            this.pnlBody.Controls.Add(this.btnSaveRoute);
            this.pnlBody.Controls.Add(this.pnlResultBox);
            this.pnlBody.Controls.Add(this.btnCreateRoute);
            this.pnlBody.Controls.Add(this.cmbTransport);
            this.pnlBody.Controls.Add(this.lblTransport);
            this.pnlBody.Controls.Add(this.lblDistanceKm);
            this.pnlBody.Controls.Add(this.txtDistance);
            this.pnlBody.Controls.Add(this.lblDistance);
            this.pnlBody.Controls.Add(this.txtEnd);
            this.pnlBody.Controls.Add(this.cmbEnd);
            this.pnlBody.Controls.Add(this.lblEnd);
            this.pnlBody.Controls.Add(this.btnDeleteStop);
            this.pnlBody.Controls.Add(this.lstStops);
            this.pnlBody.Controls.Add(this.lblStopList);
            this.pnlBody.Controls.Add(this.btnAddStopCustom);
            this.pnlBody.Controls.Add(this.txtStop);
            this.pnlBody.Controls.Add(this.btnAddStop);
            this.pnlBody.Controls.Add(this.cmbStop);
            this.pnlBody.Controls.Add(this.lblStopHdr);
            this.pnlBody.Controls.Add(this.txtStart);
            this.pnlBody.Controls.Add(this.cmbStart);
            this.pnlBody.Controls.Add(this.lblStart);
            this.pnlBody.Controls.Add(this.pnlModeRow);
            this.pnlBody.Dock     = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 68);
            this.pnlBody.Name     = "pnlBody";
            this.pnlBody.Size     = new System.Drawing.Size(360, 492);
            this.pnlBody.TabIndex = 1;

            // ── pnlModeRow ───────────────────────────────────────────────
            this.pnlModeRow.BackColor = System.Drawing.Color.White;
            this.pnlModeRow.Controls.Add(this.rbCustom);
            this.pnlModeRow.Controls.Add(this.rbDefault);
            this.pnlModeRow.Controls.Add(this.lblModeTitle);
            this.pnlModeRow.Location = new System.Drawing.Point(10, 10);
            this.pnlModeRow.Name     = "pnlModeRow";
            this.pnlModeRow.Size     = new System.Drawing.Size(330, 36);
            this.pnlModeRow.TabIndex = 0;

            this.lblModeTitle.AutoSize  = true;
            this.lblModeTitle.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblModeTitle.ForeColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.lblModeTitle.Location  = new System.Drawing.Point(10, 10);
            this.lblModeTitle.Name      = "lblModeTitle";
            this.lblModeTitle.TabIndex  = 0;
            this.lblModeTitle.Text      = "Route type:";

            this.rbDefault.AutoSize  = true;
            this.rbDefault.Checked   = true;
            this.rbDefault.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.rbDefault.ForeColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.rbDefault.Location  = new System.Drawing.Point(100, 9);
            this.rbDefault.Name      = "rbDefault";
            this.rbDefault.Size      = new System.Drawing.Size(100, 19);
            this.rbDefault.TabIndex  = 1;
            this.rbDefault.TabStop   = true;
            this.rbDefault.Text      = "Default Cities";
            this.rbDefault.CheckedChanged += new System.EventHandler(this.rbMode_CheckedChanged);

            this.rbCustom.AutoSize  = true;
            this.rbCustom.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.rbCustom.ForeColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.rbCustom.Location  = new System.Drawing.Point(215, 9);
            this.rbCustom.Name      = "rbCustom";
            this.rbCustom.Size      = new System.Drawing.Size(70, 19);
            this.rbCustom.TabIndex  = 2;
            this.rbCustom.Text      = "Custom";

            // ── Row: Start Location  y=58 ────────────────────────────────
            this.lblStart.AutoSize  = true;
            this.lblStart.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStart.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblStart.Location  = new System.Drawing.Point(14, 63);
            this.lblStart.Name      = "lblStart";
            this.lblStart.TabIndex  = 1;
            this.lblStart.Text      = "Start Location";

            this.cmbStart.BackColor     = System.Drawing.Color.White;
            this.cmbStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStart.FlatStyle     = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStart.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStart.Location      = new System.Drawing.Point(136, 59);
            this.cmbStart.Name          = "cmbStart";
            this.cmbStart.Size          = new System.Drawing.Size(194, 23);
            this.cmbStart.TabIndex      = 2;

            this.txtStart.BackColor   = System.Drawing.Color.White;
            this.txtStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStart.Font        = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStart.Location    = new System.Drawing.Point(136, 59);
            this.txtStart.Name        = "txtStart";
            this.txtStart.Size        = new System.Drawing.Size(194, 23);
            this.txtStart.TabIndex    = 3;
            this.txtStart.Visible     = false;

            // ── Row: Add Stop  y=92 ──────────────────────────────────────
            this.lblStopHdr.AutoSize  = true;
            this.lblStopHdr.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStopHdr.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblStopHdr.Location  = new System.Drawing.Point(14, 97);
            this.lblStopHdr.Name      = "lblStopHdr";
            this.lblStopHdr.TabIndex  = 4;
            this.lblStopHdr.Text      = "Add Stop";

            this.cmbStop.BackColor     = System.Drawing.Color.White;
            this.cmbStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStop.FlatStyle     = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStop.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStop.Location      = new System.Drawing.Point(136, 93);
            this.cmbStop.Name          = "cmbStop";
            this.cmbStop.Size          = new System.Drawing.Size(150, 23);
            this.cmbStop.TabIndex      = 5;

            this.btnAddStop.BackColor                  = System.Drawing.Color.FromArgb(26, 79, 160);
            this.btnAddStop.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStop.FlatAppearance.BorderSize  = 0;
            this.btnAddStop.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddStop.ForeColor                  = System.Drawing.Color.White;
            this.btnAddStop.Location                   = new System.Drawing.Point(290, 93);
            this.btnAddStop.Name                       = "btnAddStop";
            this.btnAddStop.Size                       = new System.Drawing.Size(40, 24);
            this.btnAddStop.TabIndex                   = 6;
            this.btnAddStop.Text                       = "+";
            this.btnAddStop.Click += new System.EventHandler(this.btnAddStop_Click);

            this.txtStop.BackColor   = System.Drawing.Color.White;
            this.txtStop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStop.Font        = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStop.Location    = new System.Drawing.Point(136, 93);
            this.txtStop.Name        = "txtStop";
            this.txtStop.Size        = new System.Drawing.Size(150, 23);
            this.txtStop.TabIndex    = 7;
            this.txtStop.Visible     = false;

            this.btnAddStopCustom.BackColor                 = System.Drawing.Color.FromArgb(26, 79, 160);
            this.btnAddStopCustom.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStopCustom.FlatAppearance.BorderSize = 0;
            this.btnAddStopCustom.Font                      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddStopCustom.ForeColor                 = System.Drawing.Color.White;
            this.btnAddStopCustom.Location                  = new System.Drawing.Point(290, 93);
            this.btnAddStopCustom.Name                      = "btnAddStopCustom";
            this.btnAddStopCustom.Size                      = new System.Drawing.Size(40, 24);
            this.btnAddStopCustom.TabIndex                  = 8;
            this.btnAddStopCustom.Text                      = "+";
            this.btnAddStopCustom.Visible                   = false;
            this.btnAddStopCustom.Click += new System.EventHandler(this.btnAddStopCustom_Click);

            // ── Row: Stop List  y=126 ────────────────────────────────────
            this.lblStopList.AutoSize  = true;
            this.lblStopList.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStopList.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblStopList.Location  = new System.Drawing.Point(14, 130);
            this.lblStopList.Name      = "lblStopList";
            this.lblStopList.TabIndex  = 9;
            this.lblStopList.Text      = "Stops";

            this.lstStops.BackColor   = System.Drawing.Color.FromArgb(248, 250, 255);
            this.lstStops.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstStops.Font        = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lstStops.Location    = new System.Drawing.Point(136, 126);
            this.lstStops.Name        = "lstStops";
            this.lstStops.Size        = new System.Drawing.Size(194, 68);
            this.lstStops.TabIndex    = 10;

            this.btnDeleteStop.BackColor                 = System.Drawing.Color.White;
            this.btnDeleteStop.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 210, 230);
            this.btnDeleteStop.FlatAppearance.BorderSize = 1;
            this.btnDeleteStop.Font                      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnDeleteStop.ForeColor                 = System.Drawing.Color.FromArgb(80, 100, 150);
            this.btnDeleteStop.Location                  = new System.Drawing.Point(244, 198);
            this.btnDeleteStop.Name                      = "btnDeleteStop";
            this.btnDeleteStop.Size                      = new System.Drawing.Size(86, 24);
            this.btnDeleteStop.TabIndex                  = 11;
            this.btnDeleteStop.Text                      = "✕ Remove";
            this.btnDeleteStop.Click += new System.EventHandler(this.btnDeleteStop_Click);

            // ── Row: End Location  y=232 ─────────────────────────────────
            this.lblEnd.AutoSize  = true;
            this.lblEnd.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEnd.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblEnd.Location  = new System.Drawing.Point(14, 237);
            this.lblEnd.Name      = "lblEnd";
            this.lblEnd.TabIndex  = 12;
            this.lblEnd.Text      = "End Location";

            this.cmbEnd.BackColor     = System.Drawing.Color.White;
            this.cmbEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnd.FlatStyle     = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEnd.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbEnd.Location      = new System.Drawing.Point(136, 233);
            this.cmbEnd.Name          = "cmbEnd";
            this.cmbEnd.Size          = new System.Drawing.Size(194, 23);
            this.cmbEnd.TabIndex      = 13;

            this.txtEnd.BackColor   = System.Drawing.Color.White;
            this.txtEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnd.Font        = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEnd.Location    = new System.Drawing.Point(136, 233);
            this.txtEnd.Name        = "txtEnd";
            this.txtEnd.Size        = new System.Drawing.Size(194, 23);
            this.txtEnd.TabIndex    = 14;
            this.txtEnd.Visible     = false;

            // ── Row: Distance (custom only)  y=267 ──────────────────────
            this.lblDistance.AutoSize  = true;
            this.lblDistance.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDistance.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblDistance.Location  = new System.Drawing.Point(14, 272);
            this.lblDistance.Name      = "lblDistance";
            this.lblDistance.TabIndex  = 15;
            this.lblDistance.Text      = "Distance";
            this.lblDistance.Visible   = false;

            this.txtDistance.BackColor   = System.Drawing.Color.White;
            this.txtDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDistance.Font        = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDistance.Location    = new System.Drawing.Point(136, 267);
            this.txtDistance.Name        = "txtDistance";
            this.txtDistance.Size        = new System.Drawing.Size(158, 23);
            this.txtDistance.TabIndex    = 16;
            this.txtDistance.Visible     = false;

            this.lblDistanceKm.AutoSize  = true;
            this.lblDistanceKm.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDistanceKm.ForeColor = System.Drawing.Color.FromArgb(80, 100, 140);
            this.lblDistanceKm.Location  = new System.Drawing.Point(298, 272);
            this.lblDistanceKm.Name      = "lblDistanceKm";
            this.lblDistanceKm.TabIndex  = 17;
            this.lblDistanceKm.Text      = "km";
            this.lblDistanceKm.Visible   = false;

            // ── Row: Transport  y=267 (same as Distance hidden) ──────────
            this.lblTransport.AutoSize  = true;
            this.lblTransport.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTransport.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblTransport.Location  = new System.Drawing.Point(14, 272);
            this.lblTransport.Name      = "lblTransport";
            this.lblTransport.TabIndex  = 18;
            this.lblTransport.Text      = "Transport";

            this.cmbTransport.BackColor     = System.Drawing.Color.White;
            this.cmbTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransport.FlatStyle     = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTransport.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTransport.Location      = new System.Drawing.Point(136, 267);
            this.cmbTransport.Name          = "cmbTransport";
            this.cmbTransport.Size          = new System.Drawing.Size(194, 23);
            this.cmbTransport.TabIndex      = 19;

            // ── Calculate button  y=304 ──────────────────────────────────
            this.btnCreateRoute.BackColor                 = System.Drawing.Color.FromArgb(26, 79, 160);
            this.btnCreateRoute.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRoute.FlatAppearance.BorderSize = 0;
            this.btnCreateRoute.Font                      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCreateRoute.ForeColor                 = System.Drawing.Color.White;
            this.btnCreateRoute.Location                  = new System.Drawing.Point(136, 304);
            this.btnCreateRoute.Name                      = "btnCreateRoute";
            this.btnCreateRoute.Size                      = new System.Drawing.Size(194, 34);
            this.btnCreateRoute.TabIndex                  = 20;
            this.btnCreateRoute.Text                      = "Calculate";
            this.btnCreateRoute.Click += new System.EventHandler(this.btnCreateRoute_Click);

            // ── Result panel  y=350 ──────────────────────────────────────
            this.pnlResultBox.BackColor = System.Drawing.Color.White;
            this.pnlResultBox.Controls.Add(this.lblResult);
            this.pnlResultBox.Controls.Add(this.lblResultHdr);
            this.pnlResultBox.Location  = new System.Drawing.Point(10, 350);
            this.pnlResultBox.Name      = "pnlResultBox";
            this.pnlResultBox.Size      = new System.Drawing.Size(330, 52);
            this.pnlResultBox.TabIndex  = 21;

            this.lblResultHdr.AutoSize  = true;
            this.lblResultHdr.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblResultHdr.ForeColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.lblResultHdr.Location  = new System.Drawing.Point(10, 6);
            this.lblResultHdr.Name      = "lblResultHdr";
            this.lblResultHdr.TabIndex  = 0;
            this.lblResultHdr.Text      = "Result";

            this.lblResult.AutoSize  = false;
            this.lblResult.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.lblResult.Location  = new System.Drawing.Point(10, 24);
            this.lblResult.Name      = "lblResult";
            this.lblResult.Size      = new System.Drawing.Size(310, 22);
            this.lblResult.TabIndex  = 1;
            this.lblResult.Text      = "";

            // ── Save Route button  y=414 ─────────────────────────────────
            this.btnSaveRoute.BackColor                 = System.Drawing.Color.FromArgb(26, 79, 160);
            this.btnSaveRoute.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRoute.FlatAppearance.BorderSize = 0;
            this.btnSaveRoute.Font                      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSaveRoute.ForeColor                 = System.Drawing.Color.White;
            this.btnSaveRoute.Location                  = new System.Drawing.Point(136, 414);
            this.btnSaveRoute.Name                      = "btnSaveRoute";
            this.btnSaveRoute.Size                      = new System.Drawing.Size(194, 34);
            this.btnSaveRoute.TabIndex                  = 22;
            this.btnSaveRoute.Text                      = "Save Route";
            this.btnSaveRoute.Click += new System.EventHandler(this.btnSaveRoute_Click);

            // ── Form ─────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(240, 244, 255);
            this.ClientSize          = new System.Drawing.Size(360, 568);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "FrmCreateRoute";
            this.Text            = "Create Route";
            this.Load           += new System.EventHandler(this.FrmCreateRoute_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlModeRow.ResumeLayout(false);
            this.pnlModeRow.PerformLayout();
            this.pnlResultBox.ResumeLayout(false);
            this.pnlResultBox.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel       pnlHeader;
        private System.Windows.Forms.Label       lblTitle;
        private System.Windows.Forms.Label       lblSubtitle;
        private System.Windows.Forms.Panel       pnlBody;
        private System.Windows.Forms.Panel       pnlModeRow;
        private System.Windows.Forms.Label       lblModeTitle;
        private System.Windows.Forms.RadioButton rbDefault;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.Label       lblStart;
        private System.Windows.Forms.ComboBox    cmbStart;
        private System.Windows.Forms.TextBox     txtStart;
        private System.Windows.Forms.Label       lblStopHdr;
        private System.Windows.Forms.ComboBox    cmbStop;
        private System.Windows.Forms.Button      btnAddStop;
        private System.Windows.Forms.TextBox     txtStop;
        private System.Windows.Forms.Button      btnAddStopCustom;
        private System.Windows.Forms.Label       lblStopList;
        private System.Windows.Forms.ListBox     lstStops;
        private System.Windows.Forms.Button      btnDeleteStop;
        private System.Windows.Forms.Label       lblEnd;
        private System.Windows.Forms.ComboBox    cmbEnd;
        private System.Windows.Forms.TextBox     txtEnd;
        private System.Windows.Forms.Label       lblDistance;
        private System.Windows.Forms.TextBox     txtDistance;
        private System.Windows.Forms.Label       lblDistanceKm;
        private System.Windows.Forms.Label       lblTransport;
        private System.Windows.Forms.ComboBox    cmbTransport;
        private System.Windows.Forms.Button      btnCreateRoute;
        private System.Windows.Forms.Panel       pnlResultBox;
        private System.Windows.Forms.Label       lblResultHdr;
        private System.Windows.Forms.Label       lblResult;
        private System.Windows.Forms.Button      btnSaveRoute;
    }
}
