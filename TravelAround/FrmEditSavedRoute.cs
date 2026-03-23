using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TravelAround
{
    // FrmEditSavedRoute: displays all of the current user's saved routes in a grid.
    // Provides three actions per row:
    //   View   – shows full route details in a message box
    //   Edit   – opens FrmCreateRoute in edit mode for the selected route
    //   Delete – removes the route from the database after confirmation
    public partial class FrmEditSavedRoute : Form
    {
        // In-memory snapshot of saved routes; refreshed after every Edit or Delete
        private List<Route> routes;

        // Constructor: loads settings, fetches routes, and populates the grid
        public FrmEditSavedRoute()
        {
            InitializeComponent();
            ApplySettings();                         // Apply font size and colour theme
            routes = RouteStorage.LoadSavedRoutes(); // Fetch all routes for current user
            LoadRoutes();                            // Build DataGridView rows
        }

        // Reads the user's saved preferences and applies them to this form
        private void ApplySettings()
        {
            var s = SettingsStorage.Load();
            float finalSize = 9f + (s.FontSize - 1) * 2f; // 1→9pt … 5→17pt
            this.Font = new Font(this.Font.FontFamily, finalSize);
            UITheme.ApplyTheme(this, s.HighContrast);
        }

        // Clears the DataGridView and rebuilds it from the current routes list.
        // Called on construction and again after any Edit or Delete action.
        private void LoadRoutes()
        {
            dgvRoutes.Rows.Clear();

            // Each row: sequential number | "Start → End" | View | Edit | Delete
            for (int i = 0; i < routes.Count; i++)
                dgvRoutes.Rows.Add(i + 1, $"{routes[i].Start} → {routes[i].End}", "View", "Edit", "Delete");
        }

        // Handles a click on any button cell (View / Edit / Delete) in the grid
        private void dgvRoutes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks on the column header row
            if (e.RowIndex < 0) return;

            // Retrieve the Route object that corresponds to the clicked row
            Route r = routes[e.RowIndex];

            // Identify which action column was clicked using its Name property
            string col = dgvRoutes.Columns[e.ColumnIndex].Name;

            if (col == "colView")
            {
                // ── VIEW ─────────────────────────────────────────────────────
                // Build a multi-line string of all route details and show it
                string stopsText = r.Stops.Count > 0 ? string.Join(", ", r.Stops) : "None";
                MessageBox.Show(
                    $"Route No: {e.RowIndex + 1}\n\n" +
                    $"Start: {r.Start}\nStops: {stopsText}\nEnd: {r.End}\n" +
                    $"Transport: {r.Transport}\nDistance: {r.Distance} km\nTime: {r.Time:F2} hours",
                    "Route Details");
            }
            else if (col == "colEdit")
            {
                // ── EDIT ─────────────────────────────────────────────────────
                // Open FrmCreateRoute pre-filled with this route's data.
                // ShowDialog() blocks until the edit form is closed.
                new FrmCreateRoute(r).ShowDialog();

                // Refresh the grid in case the user saved changes
                routes = RouteStorage.LoadSavedRoutes();
                LoadRoutes();
            }
            else if (col == "colDelete")
            {
                // ── DELETE ───────────────────────────────────────────────────
                // Always ask for confirmation before a destructive action
                var res = MessageBox.Show("Are you sure you want to delete this route?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    // Remove from tblsavedroutes and tblroutes in the database
                    RouteStorage.DeleteSavedRoute(r.RouteID);

                    // Refresh the grid to reflect the deletion immediately
                    routes = RouteStorage.LoadSavedRoutes();
                    LoadRoutes();

                    MessageBox.Show("Route deleted successfully.");
                }
            }
        }

        // Closes this form and returns to the Routes menu
        private void btnBack_Click(object sender, EventArgs e) { this.Close(); }
    }
}
