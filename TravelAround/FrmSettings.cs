using System;
using System.Drawing;
using System.Windows.Forms;

namespace TravelAround
{
    // FrmSettings: lets the user adjust accessibility preferences.
    // Currently exposes two settings:
    //   FontSize    – a 1–5 scale that maps to point sizes 9pt–17pt
    //   HighContrast – toggles the dark colour palette across all forms
    public partial class FrmSettings : Form
    {
        // Constructor: builds the UI and immediately loads the saved settings
        public FrmSettings()
        {
            InitializeComponent();
            LoadSettings(); // Populate controls with stored values
        }

        // Populates the form controls with the current saved settings,
        // then applies the theme so the Settings form itself reflects the choices
        private void LoadSettings()
        {
            // Populate the font-size dropdown with levels 1 through 5
            cmbFontSize.Items.Clear();
            cmbFontSize.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });

            // Read the currently saved preferences from the database
            AppSettings s = SettingsStorage.Load();

            // Pre-select the stored font size level in the dropdown
            cmbFontSize.SelectedItem = s.FontSize.ToString();

            // Check the high-contrast checkbox if the setting is enabled
            chkHighContrast.Checked = s.HighContrast;

            // Apply the stored settings to this form so it previews correctly
            ApplyUI(s);
        }

        // Scales the form font and applies the colour theme for the given settings.
        // Used both on initial load and after Apply so changes are visible immediately.
        private void ApplyUI(AppSettings s)
        {
            float finalSize = 9f + (s.FontSize - 1) * 2f; // 1→9pt, 2→11pt … 5→17pt
            this.Font = new Font(this.Font.FontFamily, finalSize);
            UITheme.ApplyTheme(this, s.HighContrast);
        }

        // Validates the selection, saves settings to the database, and closes the form.
        // The MainMenu calls ApplySettings() after this form closes so all open
        // forms pick up the new preferences on their next visit.
        private void btnApply_Click(object sender, EventArgs e)
        {
            // Ensure the user has chosen a font size before saving
            if (cmbFontSize.SelectedItem == null)
            {
                MessageBox.Show("Please select font size");
                return;
            }

            int  fontSize     = int.Parse(cmbFontSize.SelectedItem.ToString());
            bool highContrast = chkHighContrast.Checked;

            // Persist to tblAccessibility for the current user
            SettingsStorage.Save(fontSize, highContrast);

            MessageBox.Show("Settings saved successfully.");
            this.Close(); // Return to the caller (MainMenu)
        }

        // Closes the form without saving any changes
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
