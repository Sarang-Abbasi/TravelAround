namespace TravelAround
{
    partial class FrmSignup
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
            this.pnlBody     = new System.Windows.Forms.Panel();
            this.label1      = new System.Windows.Forms.Label();
            this.txtName     = new System.Windows.Forms.TextBox();
            this.label2      = new System.Windows.Forms.Label();
            this.txtEmail    = new System.Windows.Forms.TextBox();
            this.label3      = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSignup   = new System.Windows.Forms.Button();
            this.btnBack     = new System.Windows.Forms.Button();
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
            this.lblTitle.Text      = "Create Account";

            this.lblSub.AutoSize  = true;
            this.lblSub.Font      = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(148, 180, 255);
            this.lblSub.Location  = new System.Drawing.Point(20, 50);
            this.lblSub.Text      = "Join TravelAround";

            // ── pnlBody ────────────────────────────────────────────
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.pnlBody.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Controls.Add(this.txtName);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.txtEmail);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.txtPassword);
            this.pnlBody.Controls.Add(this.btnSignup);
            this.pnlBody.Controls.Add(this.btnBack);

            // Name
            this.label1.AutoSize  = true;
            this.label1.Font      = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.label1.Location  = new System.Drawing.Point(24, 20);
            this.label1.Text      = "FULL NAME";

            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font        = new System.Drawing.Font("Segoe UI", 10.5f);
            this.txtName.BackColor   = System.Drawing.Color.White;
            this.txtName.Location    = new System.Drawing.Point(24, 38);
            this.txtName.Size        = new System.Drawing.Size(237, 28);
            this.txtName.TabIndex    = 0;

            // Email
            this.label2.AutoSize  = true;
            this.label2.Font      = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.label2.Location  = new System.Drawing.Point(24, 78);
            this.label2.Text      = "EMAIL ADDRESS";

            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font        = new System.Drawing.Font("Segoe UI", 10.5f);
            this.txtEmail.BackColor   = System.Drawing.Color.White;
            this.txtEmail.Location    = new System.Drawing.Point(24, 96);
            this.txtEmail.Size        = new System.Drawing.Size(237, 28);
            this.txtEmail.TabIndex    = 1;

            // Password
            this.label3.AutoSize  = true;
            this.label3.Font      = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(13, 28, 64);
            this.label3.Location  = new System.Drawing.Point(24, 136);
            this.label3.Text      = "PASSWORD";

            this.txtPassword.BorderStyle  = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font         = new System.Drawing.Font("Segoe UI", 10.5f);
            this.txtPassword.BackColor    = System.Drawing.Color.White;
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Location     = new System.Drawing.Point(24, 154);
            this.txtPassword.Size         = new System.Drawing.Size(237, 28);
            this.txtPassword.TabIndex     = 2;

            // Sign Up button
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(26, 79, 160);
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location  = new System.Drawing.Point(24, 198);
            this.btnSignup.Size      = new System.Drawing.Size(237, 38);
            this.btnSignup.TabIndex  = 3;
            this.btnSignup.Text      = "Create Account  →";
            this.btnSignup.Click    += new System.EventHandler(this.btnSignup_Click);

            // Back button
            this.btnBack.BackColor  = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnBack.Font       = new System.Drawing.Font("Segoe UI", 9f);
            this.btnBack.ForeColor  = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnBack.Location   = new System.Drawing.Point(24, 248);
            this.btnBack.Size       = new System.Drawing.Size(237, 30);
            this.btnBack.TabIndex   = 4;
            this.btnBack.Text       = "←  Back to Login";
            this.btnBack.Click     += new System.EventHandler(this.btnBack_Click);

            // ── Form ───────────────────────────────────────────────
            this.AcceptButton        = this.btnSignup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(240, 244, 255);
            this.ClientSize          = new System.Drawing.Size(285, 370);
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox         = false;
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmSignup";
            this.Text = "TravelAround – Sign Up";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel   pnlHeader;
        private System.Windows.Forms.Label   lblTitle;
        private System.Windows.Forms.Label   lblSub;
        private System.Windows.Forms.Panel   pnlBody;
        private System.Windows.Forms.Label   label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label   label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label   label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button  btnSignup;
        private System.Windows.Forms.Button  btnBack;
    }
}
