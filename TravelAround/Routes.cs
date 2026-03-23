using System;
using System.Drawing;
using System.Windows.Forms;

namespace TravelAround
{
    // Routes: a simple hub/menu that gives access to the three route-related actions.
    // Opened from the MainMenu and acts as a navigation layer before the actual forms.
    public partial class Routes : Form
    {
        // Constructor: builds the UI and applies the user's saved settings
        public Routes()
        {
            InitializeComponent();
            ApplySettings(); // Apply stored font size and colour theme
        }

        // Reads the user's saved preferences and applies them to this form
        private void ApplySettings()
        {
            var s = SettingsStorage.Load();
            float finalSize = 9f + (s.FontSize - 1) * 2f; // 1→9pt … 5→17pt
            this.Font = new Font(this.Font.FontFamily, finalSize);
            UITheme.ApplyTheme(this, s.HighContrast);
        }

        // Opens FrmCreateRoute in create mode (blank form for a new route)
        private void btnCreateNewRoute_Click(object sender, EventArgs e)
        {
            new FrmCreateRoute().ShowDialog();
        }

        // Opens FrmEditSavedRoute which lists all saved routes with Edit/Delete options
        private void btnEditSavedRoute_Click(object sender, EventArgs e)
        {
            new FrmEditSavedRoute().ShowDialog();
        }

        // Opens FrmSavedRoutes which shows all saved routes as styled read-only cards
        private void btnViewSavedRoutes_Click(object sender, EventArgs e)
        {
            new FrmSavedRoutes().ShowDialog();
        }

        // Closes this form and returns to the MainMenu
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
