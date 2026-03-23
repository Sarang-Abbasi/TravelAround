using System.Drawing;
using System.Windows.Forms;

namespace TravelAround
{
    // UITheme: centralised styling engine for the entire application.
    // Provides a two-palette system (Normal / High-Contrast) that can be applied
    // to any Form by calling ApplyTheme().  All forms call this from ApplySettings()
    // so the theme is consistent and can be changed from a single location.
    public static class UITheme
    {
        // ── Normal mode palette ───────────────────────────────────────────────
        static readonly Color N_FormBg   = Color.FromArgb(240, 244, 255); // Light blue-grey
        static readonly Color N_HeaderBg = Color.FromArgb(13,  28,  64);  // Dark navy
        static readonly Color N_PanelBg  = Color.FromArgb(240, 244, 255); // Same as form bg
        static readonly Color N_InputBg  = Color.White;
        static readonly Color N_Text     = Color.FromArgb(13,  17,  23);  // Near-black

        // ── High-contrast mode palette ────────────────────────────────────────
        // Designed for maximum legibility: dark backgrounds, bright text
        static readonly Color HC_FormBg    = Color.Black;
        static readonly Color HC_HeaderBg  = Color.FromArgb(20,  20,  20); // Slightly lighter black
        static readonly Color HC_PanelBg   = Color.Black;
        static readonly Color HC_InputBg   = Color.FromArgb(30,  30,  30); // Dark grey for inputs
        static readonly Color HC_Text      = Color.White;
        static readonly Color HC_BtnPrimBg = Color.FromArgb(30,  80, 180); // Bright blue primary button
        static readonly Color HC_BtnSecBg  = Color.FromArgb(40,  40,  40); // Dark grey secondary button

        // ── Entry point ───────────────────────────────────────────────────────

        // Applies the appropriate colour palette to a form and all its child controls.
        // Call this from every form's ApplySettings() method.
        //   form – the Form to style
        //   hc   – true to apply the high-contrast palette, false for normal
        public static void ApplyTheme(Form form, bool hc)
        {
            form.SuspendLayout(); // Batch all property changes before redrawing
            form.BackColor = hc ? HC_FormBg : N_FormBg;
            form.ForeColor = hc ? HC_Text   : N_Text;
            Walk(form, hc, isHeader: false); // Recursively style all child controls
            form.ResumeLayout(true);
        }

        // ── Recursive control walker ──────────────────────────────────────────

        // Walks the control tree depth-first and applies colours to each control
        // based on its type.  The isHeader parameter prevents overwriting the
        // navy header labels that should always stay white/light-blue.
        static void Walk(Control parent, bool hc, bool isHeader)
        {
            foreach (Control c in parent.Controls)
            {
                // Track whether this specific child is the navy header panel
                bool childIsHeader = c.Name == "pnlHeader";

                if (c is Panel pnl)
                {
                    // pnlModeRow (the radio-button pill) gets a slightly lighter background
                    // in HC mode so the white radio text has readable contrast
                    bool isModeRow = pnl.Name == "pnlModeRow";

                    pnl.BackColor = childIsHeader
                        ? (hc ? HC_HeaderBg : N_HeaderBg)   // Navy header stays navy
                        : isModeRow
                            ? (hc ? HC_InputBg : Color.White) // Mode row: dark grey / white
                            : (hc ? HC_PanelBg : N_PanelBg);  // All other panels

                    // Recurse into this panel, marking children as inside-header if needed
                    Walk(pnl, hc, childIsHeader);
                }
                else if (c is Label lbl)
                {
                    // Leave labels inside the header panel untouched (they are styled
                    // at design time with white/light-blue and must not be overridden)
                    if (!isHeader)
                    {
                        lbl.ForeColor = hc ? HC_Text : N_Text;
                        lbl.BackColor = Color.Transparent; // Ensure panel background shows through
                    }
                }
                else if (c is Button btn)
                {
                    // Classify buttons as Primary (solid fill) or Secondary (outlined).
                    // Primary buttons: FlatStyle=Flat, BorderSize=0, non-transparent background
                    bool isPrimary = btn.FlatStyle == FlatStyle.Flat &&
                                     btn.FlatAppearance.BorderSize == 0 &&
                                     btn.BackColor != Color.Transparent;
                    if (isPrimary)
                    {
                        btn.BackColor = hc ? HC_BtnPrimBg : Color.FromArgb(26, 79, 160); // Blue fill
                        btn.ForeColor = Color.White; // Always white text on primary buttons
                    }
                    else
                    {
                        // Secondary / outlined buttons
                        btn.BackColor = hc ? HC_BtnSecBg : Color.White;
                        btn.ForeColor = hc ? HC_Text     : Color.FromArgb(13, 28, 64); // Navy text
                    }
                }
                else if (c is TextBox txt)
                {
                    txt.BackColor = hc ? HC_InputBg : N_InputBg;
                    txt.ForeColor = hc ? HC_Text    : N_Text;
                }
                else if (c is ComboBox cmb)
                {
                    cmb.BackColor = hc ? HC_InputBg : N_InputBg;
                    cmb.ForeColor = hc ? HC_Text    : N_Text;
                }
                else if (c is ListBox lst)
                {
                    lst.BackColor = hc ? HC_InputBg : N_InputBg;
                    lst.ForeColor = hc ? HC_Text    : N_Text;
                }
                else if (c is CheckBox chk)
                {
                    chk.ForeColor = hc ? HC_Text : N_Text;
                    chk.BackColor = Color.Transparent; // Let the panel background show through
                }
                else if (c is RadioButton rb)
                {
                    // RadioButtons need explicit styling; without this the form's
                    // inherited ForeColor (white in HC mode) causes invisible text
                    // on a dark radio button background
                    rb.ForeColor = hc ? HC_Text : Color.FromArgb(13, 28, 64);
                    rb.BackColor = Color.Transparent;
                }
                else if (c is DataGridView dgv)
                {
                    dgv.BackgroundColor = hc ? HC_PanelBg : N_PanelBg;

                    // Standard row style
                    dgv.DefaultCellStyle.BackColor = hc ? HC_InputBg : Color.White;
                    dgv.DefaultCellStyle.ForeColor = hc ? HC_Text    : N_Text;

                    // Alternate row: subtle stripe for readability
                    dgv.AlternatingRowsDefaultCellStyle.BackColor =
                        hc ? Color.FromArgb(25, 25, 25) : Color.FromArgb(250, 251, 255);

                    // Selected row: navy in both modes so it is always clearly visible
                    dgv.DefaultCellStyle.SelectionBackColor =
                        hc ? Color.FromArgb(30, 80, 180) : Color.FromArgb(26, 79, 160);
                    dgv.DefaultCellStyle.SelectionForeColor = Color.White;

                    // Grid line colour
                    dgv.GridColor = hc ? Color.FromArgb(60, 60, 60) : Color.FromArgb(226, 232, 240);
                }

                // Recurse into any non-Panel container (e.g. GroupBox) that has children
                if (!(c is Panel) && c.HasChildren)
                    Walk(c, hc, isHeader || childIsHeader);
            }
        }
    }
}
