namespace TravelAround
{
    partial class FrmSettings
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.cmbFontSize = new System.Windows.Forms.ComboBox();
            this.pnlSepA = new System.Windows.Forms.Panel();
            this.lblAccessHd = new System.Windows.Forms.Label();
            this.chkHighContrast = new System.Windows.Forms.CheckBox();
            this.pnlSepB = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSub);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(285, 80);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(18, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(107, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Settings";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.lblSub.Location = new System.Drawing.Point(20, 48);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(139, 15);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Accessibility & preferences";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlBody.Controls.Add(this.lblFontSize);
            this.pnlBody.Controls.Add(this.cmbFontSize);
            this.pnlBody.Controls.Add(this.pnlSepA);
            this.pnlBody.Controls.Add(this.lblAccessHd);
            this.pnlBody.Controls.Add(this.chkHighContrast);
            this.pnlBody.Controls.Add(this.pnlSepB);
            this.pnlBody.Controls.Add(this.btnApply);
            this.pnlBody.Controls.Add(this.btnBack);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 80);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(285, 286);
            this.pnlBody.TabIndex = 0;
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFontSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.lblFontSize.Location = new System.Drawing.Point(24, 20);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(61, 13);
            this.lblFontSize.TabIndex = 0;
            this.lblFontSize.Text = "FONT SIZE";
            // 
            // cmbFontSize
            // 
            this.cmbFontSize.BackColor = System.Drawing.Color.White;
            this.cmbFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFontSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFontSize.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbFontSize.FormattingEnabled = true;
            this.cmbFontSize.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "14",
            "16",
            "18"});
            this.cmbFontSize.Location = new System.Drawing.Point(24, 38);
            this.cmbFontSize.Name = "cmbFontSize";
            this.cmbFontSize.Size = new System.Drawing.Size(237, 27);
            this.cmbFontSize.TabIndex = 0;
            // 
            // pnlSepA
            // 
            this.pnlSepA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlSepA.Location = new System.Drawing.Point(24, 80);
            this.pnlSepA.Name = "pnlSepA";
            this.pnlSepA.Size = new System.Drawing.Size(237, 1);
            this.pnlSepA.TabIndex = 1;
            // 
            // lblAccessHd
            // 
            this.lblAccessHd.AutoSize = true;
            this.lblAccessHd.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblAccessHd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAccessHd.Location = new System.Drawing.Point(24, 92);
            this.lblAccessHd.Name = "lblAccessHd";
            this.lblAccessHd.Size = new System.Drawing.Size(82, 13);
            this.lblAccessHd.TabIndex = 2;
            this.lblAccessHd.Text = "ACCESSIBILITY";
            // 
            // chkHighContrast
            // 
            this.chkHighContrast.AutoSize = true;
            this.chkHighContrast.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkHighContrast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.chkHighContrast.Location = new System.Drawing.Point(24, 114);
            this.chkHighContrast.Name = "chkHighContrast";
            this.chkHighContrast.Size = new System.Drawing.Size(154, 23);
            this.chkHighContrast.TabIndex = 1;
            this.chkHighContrast.Text = "High Contrast Mode";
            // 
            // pnlSepB
            // 
            this.pnlSepB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlSepB.Location = new System.Drawing.Point(24, 184);
            this.pnlSepB.Name = "pnlSepB";
            this.pnlSepB.Size = new System.Drawing.Size(237, 1);
            this.pnlSepB.TabIndex = 3;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(79)))), ((int)(((byte)(160)))));
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(24, 196);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(237, 38);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply Settings";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnBack.Location = new System.Drawing.Point(24, 246);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(237, 30);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "←  Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(285, 366);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TravelAround – Settings";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel    pnlHeader;
        private System.Windows.Forms.Label    lblTitle;
        private System.Windows.Forms.Label    lblSub;
        private System.Windows.Forms.Panel    pnlBody;
        private System.Windows.Forms.Label    lblFontSize;
        private System.Windows.Forms.ComboBox cmbFontSize;
        private System.Windows.Forms.Panel    pnlSepA;
        private System.Windows.Forms.Label    lblAccessHd;
        private System.Windows.Forms.CheckBox chkHighContrast;
        private System.Windows.Forms.Panel    pnlSepB;
        private System.Windows.Forms.Button   btnApply;
        private System.Windows.Forms.Button   btnBack;
    }
}
