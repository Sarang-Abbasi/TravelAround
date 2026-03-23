namespace TravelAround
{
    partial class FrmLogin
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
            this.lblTagline  = new System.Windows.Forms.Label();
            this.pnlBody     = new System.Windows.Forms.Panel();
            this.lblEmail    = new System.Windows.Forms.Label();
            this.txtEmail    = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin    = new System.Windows.Forms.Button();
            this.pnlDivider  = new System.Windows.Forms.Panel();
            this.btnSignup   = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();

            // ── pnlHeader ──────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height    = 88;
            this.pnlHeader.Padding   = new System.Windows.Forms.Padding(18, 14, 0, 0);
            this.pnlHeader.Controls.Add(this.lblAppName);
            this.pnlHeader.Controls.Add(this.lblTagline);

            this.lblAppName.AutoSize  = true;
            this.lblAppName.Font      = new System.Drawing.Font("Segoe UI", 20f, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location  = new System.Drawing.Point(18, 14);
            this.lblAppName.Text      = "TravelAround";

            this.lblTagline.AutoSize  = true;
            this.lblTagline.Font      = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(148, 180, 255);
            this.lblTagline.Location  = new System.Drawing.Point(20, 52);
            this.lblTagline.Text      = "Plan your journey across Britain";

            // ── pnlBody ────────────────────────────────────────────
            this.pnlBody.BackColor  = System.Drawing.Color.FromArgb(240, 244, 255);
            this.pnlBody.Dock       = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Padding    = new System.Windows.Forms.Padding(24, 22, 24, 22);
            this.pnlBody.Controls.Add(this.lblEmail);
            this.pnlBody.Controls.Add(this.txtEmail);
            this.pnlBody.Controls.Add(this.lblPassword);
            this.pnlBody.Controls.Add(this.txtPassword);
            this.pnlBody.Controls.Add(this.btnLogin);
            this.pnlBody.Controls.Add(this.pnlDivider);
            this.pnlBody.Controls.Add(this.btnSignup);

            // Email
            this.lblEmail.AutoSize  = true;
            this.lblEmail.Font      = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.lblEmail.Location  = new System.Drawing.Point(24, 22);
            this.lblEmail.Text      = "EMAIL ADDRESS";

            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font        = new System.Drawing.Font("Segoe UI", 10.5f);
            this.txtEmail.BackColor   = System.Drawing.Color.White;
            this.txtEmail.ForeColor   = System.Drawing.Color.FromArgb(13, 17, 23);
            this.txtEmail.Location    = new System.Drawing.Point(24, 42);
            this.txtEmail.Size        = new System.Drawing.Size(237, 28);
            this.txtEmail.TabIndex    = 0;

            // Password
            this.lblPassword.AutoSize  = true;
            this.lblPassword.Font      = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.lblPassword.Location  = new System.Drawing.Point(24, 84);
            this.lblPassword.Text      = "PASSWORD";

            this.txtPassword.BorderStyle  = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font         = new System.Drawing.Font("Segoe UI", 10.5f);
            this.txtPassword.BackColor    = System.Drawing.Color.White;
            this.txtPassword.ForeColor    = System.Drawing.Color.FromArgb(13, 17, 23);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Location     = new System.Drawing.Point(24, 104);
            this.txtPassword.Size         = new System.Drawing.Size(237, 28);
            this.txtPassword.TabIndex     = 1;

            // Login button
            this.btnLogin.BackColor  = System.Drawing.Color.FromArgb(26, 79, 160);
            this.btnLogin.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font       = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor  = System.Drawing.Color.White;
            this.btnLogin.Location   = new System.Drawing.Point(24, 150);
            this.btnLogin.Size       = new System.Drawing.Size(237, 38);
            this.btnLogin.TabIndex   = 2;
            this.btnLogin.Text       = "Sign In  →";
            this.btnLogin.Click     += new System.EventHandler(this.btnLogin_Click);

            // Divider
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pnlDivider.Location  = new System.Drawing.Point(24, 202);
            this.pnlDivider.Size      = new System.Drawing.Size(237, 1);

            // Signup button
            this.btnSignup.BackColor  = System.Drawing.Color.Transparent;
            this.btnSignup.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnSignup.Font       = new System.Drawing.Font("Segoe UI", 9f);
            this.btnSignup.ForeColor  = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnSignup.Location   = new System.Drawing.Point(24, 214);
            this.btnSignup.Size       = new System.Drawing.Size(237, 32);
            this.btnSignup.TabIndex   = 3;
            this.btnSignup.Text       = "Don't have an account?  Sign Up";
            this.btnSignup.Click     += new System.EventHandler(this.btnSignup_Click);

            // ── Form ───────────────────────────────────────────────
            this.AcceptButton        = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(240, 244, 255);
            this.ClientSize          = new System.Drawing.Size(285, 354);
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox         = false;
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmLogin";
            this.Text = "TravelAround";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel   pnlHeader;
        private System.Windows.Forms.Label   lblAppName;
        private System.Windows.Forms.Label   lblTagline;
        private System.Windows.Forms.Panel   pnlBody;
        private System.Windows.Forms.Label   lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label   lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button  btnLogin;
        private System.Windows.Forms.Panel   pnlDivider;
        private System.Windows.Forms.Button  btnSignup;
    }
}
