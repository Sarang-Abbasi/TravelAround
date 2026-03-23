namespace TravelAround
{
    // This class represents application-wide user settings
    // It is used to store and transfer settings between forms and database
    public class AppSettings
    {
        // Stores the selected font size level (1 = small, 5 = very large)
        // Used to calculate actual font size in UI
        public int FontSize { get; set; }

        // Enables or disables high contrast mode for accessibility
        // true  = dark background, light text
        // false = normal Windows colors
        public bool HighContrast { get; set; }

        // Enables or disables voice navigation feature
        // true  = voice navigation enabled
        // false = voice navigation disabled
        public bool VoiceNavigation { get; set; }
    }
}
