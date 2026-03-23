using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAround
{
    // Entry point of the application
    internal static class Program
    {
        // Main method: the first method that runs when the program starts
        [STAThread] // Required for Windows Forms (Single Threaded Apartment)
        static void Main()
        {
            // Enables modern Windows visual styles for UI controls
            Application.EnableVisualStyles();

            // Ensures text rendering is compatible with Windows Forms
            Application.SetCompatibleTextRenderingDefault(false);

            // Starts the application with the Login form
            Application.Run(new FrmLogin());
        }
    }
}
