using System;
using System.Drawing;
using System.Windows.Forms;

namespace TravelAround
{
    // MainMenu: the application's home screen, shown after a successful login.
    // Provides navigation to the Routes section and the Settings form.
    // Also re-applies accessibility settings after returning from either child form,
    // so any changes the user made in Settings take effect immediately on the menu.
    public partial class MainMenu : Form
    {
        // Constructor: builds the UI and applies the user's saved accessibility settings
        public MainMenu()
        {
            InitializeComponent();
            ApplySettings(); // Apply stored font size and colour theme on first load
        }

        // Reads the user's saved preferences and applies them to this form.
        // Called both on construction and after returning from child forms.
        private void ApplySettings()
        {
            var s = SettingsStorage.Load();
            float finalSize = 9f + (s.FontSize - 1) * 2f; // 1→9pt, 2→11pt … 5→17pt
            this.Font = new Font(this.Font.FontFamily, finalSize);
            UITheme.ApplyTheme(this, s.HighContrast);
        }

        // Opens the Routes hub (create / view / edit saved routes).
        // ApplySettings() is called on return so theme changes made in Settings
        // during that session are immediately visible on the main menu.
        private void btnRoute_Click(object sender, EventArgs e)
        {
            new Routes().ShowDialog(); // Block until the Routes form is closed
            ApplySettings();           // Refresh theme in case settings changed
        }

        // Opens the Settings form.
        // ApplySettings() is called on return so font and contrast changes are
        // applied to the main menu straight away without needing a restart.
        private void btnSettings_Click(object sender, EventArgs e)
        {
            new FrmSettings().ShowDialog(); // Block until Settings form is closed
            ApplySettings();                // Refresh theme with newly saved values
        }

        // Exits the entire application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
