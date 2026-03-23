using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TravelAround
{
    // FrmCreateRoute: allows users to plan a new route or edit an existing one.
    // Supports two modes:
    //   Default Cities – start/end/stop picked from predefined UK city dropdowns
    //   Custom Route   – user types any location names and enters distance manually
    public partial class FrmCreateRoute : Form
    {
        // Holds the route object after Calculate is clicked, ready to be saved
        private Route lastCreatedRoute = null;

        // In-memory list of intermediate stops added by the user during this session
        private List<string> stops = new List<string>();

        // True when this form was opened by FrmEditSavedRoute to edit an existing route
        private bool isEditMode = false;

        // Convenience property – returns true when the Custom radio button is selected
        private bool IsCustom => rbCustom.Checked;

        // Pixels to shift controls below the Distance row when Custom mode is active
        private const int DistRowH = 38;

        // ── Stored base Y positions ───────────────────────────────────────────────
        // Captured once in Load from the designer layout (Default mode).
        // SetMode() shifts controls relative to these values, not hardcoded numbers.
        private int _baseYTransport, _baseYCalc, _baseYResult, _baseYSave, _baseFormH;

        // ─────────────────────────────────────────────────────────────────────────
        // CONSTRUCTORS
        // ─────────────────────────────────────────────────────────────────────────

        // Default constructor: opens a blank form for creating a brand-new route
        public FrmCreateRoute()
        {
            InitializeComponent();
            ApplySettings(); // Apply saved font size and high-contrast theme
        }

        // Edit constructor: opens the form pre-filled with an existing route's data.
        // Called from FrmEditSavedRoute when the user clicks the Edit button.
        public FrmCreateRoute(Route routeToEdit)
        {
            InitializeComponent();
            ApplySettings();

            isEditMode       = true;
            lastCreatedRoute = routeToEdit; // Keep reference so Save() can update it

            // Pre-fill the stop list from the existing route
            stops.Clear();
            lstStops.Items.Clear();
            foreach (var st in routeToEdit.Stops)
            {
                stops.Add(st);
                lstStops.Items.Add(st);
            }

            // Show a brief summary of the existing route in the result area
            lblResult.Text = $"{routeToEdit.Start} → {routeToEdit.End}   {routeToEdit.Distance:F0} km";
        }

        // ─────────────────────────────────────────────────────────────────────────
        // FORM LOAD
        // ─────────────────────────────────────────────────────────────────────────

        private void FrmCreateRoute_Load(object sender, EventArgs e)
        {
            // Populate all three city dropdowns from tblCities in the database
            var cities = RouteStorage.GetCities();
            cmbStart.Items.AddRange(cities.ToArray());
            cmbStop.Items.AddRange(cities.ToArray());
            cmbEnd.Items.AddRange(cities.ToArray());

            // Bind transport types from tblTransport to the transport dropdown
            var transports = RouteStorage.GetTransports();
            cmbTransport.DataSource    = transports;
            cmbTransport.DisplayMember = "TransportType"; // Text shown to user
            cmbTransport.ValueMember   = "TransportID";   // Value used internally
            cmbTransport.SelectedIndex = -1;              // No default selection

            // If editing, pre-select the existing route's values in all inputs
            if (isEditMode && lastCreatedRoute != null)
            {
                cmbTransport.SelectedValue = lastCreatedRoute.TransportID;
                TrySetCombo(cmbStart, lastCreatedRoute.Start);
                TrySetCombo(cmbEnd,   lastCreatedRoute.End);
                txtStart.Text = lastCreatedRoute.Start; // Also fill custom text boxes
                txtEnd.Text   = lastCreatedRoute.End;   // in case user switches mode
            }

            // Snapshot current Y positions BEFORE SetMode() moves anything.
            // These become the reference points for all subsequent layout shifts.
            _baseYTransport = lblTransport.Location.Y;
            _baseYCalc      = btnCreateRoute.Location.Y;
            _baseYResult    = pnlResultBox.Location.Y;
            _baseYSave      = btnSaveRoute.Location.Y;
            _baseFormH      = this.ClientSize.Height;

            // Start in Default Cities mode
            SetMode(false);
        }

        // ─────────────────────────────────────────────────────────────────────────
        // MODE SWITCHING
        // ─────────────────────────────────────────────────────────────────────────

        // Fired whenever either radio button changes.
        // CheckedChanged fires for both the button being unchecked and the one
        // being checked, so only the newly-checked button needs to act.
        private void rbMode_CheckedChanged(object sender, EventArgs e)
        {
            SetMode(IsCustom);

            // Reset all state when switching modes to avoid stale data
            lblResult.Text   = "";
            lastCreatedRoute = null;
            stops.Clear();
            lstStops.Items.Clear();
        }

        // Shows/hides controls and repositions shifted rows for the given mode.
        //   custom = false → Default Cities mode (dropdowns, database distance)
        //   custom = true  → Custom mode (free-text, manual distance entry)
        private void SetMode(bool custom)
        {
            int shift = custom ? DistRowH : 0; // 0 = no shift, DistRowH = shift down

            // ── Swap Start input ──────────────────────────────────────────────
            cmbStart.Visible = !custom; // Dropdown visible in Default mode only
            txtStart.Visible =  custom; // Free-text visible in Custom mode only

            // ── Swap Stop input ───────────────────────────────────────────────
            cmbStop.Visible          = !custom;
            btnAddStop.Visible       = !custom;
            txtStop.Visible          =  custom;
            btnAddStopCustom.Visible =  custom;

            // ── Swap End input ────────────────────────────────────────────────
            cmbEnd.Visible = !custom;
            txtEnd.Visible =  custom;

            // ── Distance row (Custom mode only) ───────────────────────────────
            // Default mode looks distance up from the database – no manual entry needed
            lblDistance.Visible   = custom;
            txtDistance.Visible   = custom;
            lblDistanceKm.Visible = custom;

            // ── Shift controls below the Distance row ─────────────────────────
            MoveY(lblTransport,   _baseYTransport + shift);
            MoveY(cmbTransport,   _baseYTransport + shift);
            MoveY(btnCreateRoute, _baseYCalc      + shift);
            MoveY(pnlResultBox,   _baseYResult    + shift);
            MoveY(btnSaveRoute,   _baseYSave      + shift);

            // Grow or shrink the form height to match the new layout
            this.ClientSize = new Size(this.ClientSize.Width, _baseFormH + shift);
        }

        // Moves a control to a new Y position while leaving its X coordinate unchanged
        private static void MoveY(Control c, int y)
        {
            c.Location = new Point(c.Location.X, y);
        }

        // ─────────────────────────────────────────────────────────────────────────
        // STOP MANAGEMENT
        // ─────────────────────────────────────────────────────────────────────────

        // Adds the city selected from the dropdown (Default mode) to the stop list
        private void btnAddStop_Click(object sender, EventArgs e)
        {
            if (cmbStop.SelectedItem == null) { MessageBox.Show("Please select a stop."); return; }

            string stop = cmbStop.SelectedItem.ToString();

            // Reject duplicates
            if (stops.Contains(stop))
            { MessageBox.Show($"{stop} is already in the stop list."); return; }

            // Reject a stop that matches the chosen start city
            if (stop == (cmbStart.SelectedItem?.ToString() ?? ""))
            { MessageBox.Show("Stop cannot be the same as the start location."); return; }

            // Reject a stop that matches the chosen destination city
            if (stop == (cmbEnd.SelectedItem?.ToString() ?? ""))
            { MessageBox.Show("Stop cannot be the same as the destination."); return; }

            stops.Add(stop);
            lstStops.Items.Add(stop);
            cmbStop.SelectedIndex = -1; // Reset ready for next entry
        }

        // Adds the free-text location (Custom mode) to the stop list
        private void btnAddStopCustom_Click(object sender, EventArgs e)
        {
            string stop = txtStop.Text.Trim();
            if (stop == "") { MessageBox.Show("Please enter a stop location."); return; }

            // Case-insensitive duplicate check (free-text may differ in capitalisation)
            if (stops.Exists(s => s.Equals(stop, System.StringComparison.OrdinalIgnoreCase)))
            { MessageBox.Show($"{stop} is already in the stop list."); return; }

            stops.Add(stop);
            lstStops.Items.Add(stop);
            txtStop.Clear(); // Clear ready for next entry
        }

        // Removes the highlighted stop from both the display list and internal list
        private void btnDeleteStop_Click(object sender, EventArgs e)
        {
            if (lstStops.SelectedIndex == -1) { MessageBox.Show("Please select a stop to remove."); return; }

            int idx = lstStops.SelectedIndex;
            stops.RemoveAt(idx);
            lstStops.Items.RemoveAt(idx);
        }

        // ─────────────────────────────────────────────────────────────────────────
        // CALCULATE ROUTE
        // ─────────────────────────────────────────────────────────────────────────

        // Validates all inputs, calculates distance and travel time,
        // stores the result in lastCreatedRoute, and updates the result label
        private void btnCreateRoute_Click(object sender, EventArgs e)
        {
            // Transport must be selected regardless of mode
            if (cmbTransport.SelectedItem == null)
            { MessageBox.Show("Please select a transport type."); return; }

            Transport t = (Transport)cmbTransport.SelectedItem;
            double distance;
            string start, end;

            if (IsCustom)
            {
                // ── Custom mode validation ────────────────────────────────────
                start = txtStart.Text.Trim();
                end   = txtEnd.Text.Trim();

                if (start == "" || end == "")
                { MessageBox.Show("Please enter start and destination."); return; }

                if (start.Equals(end, StringComparison.OrdinalIgnoreCase))
                { MessageBox.Show("Start and destination cannot be the same."); return; }

                // Block start/end that conflict with stops already in the list
                if (stops.Exists(s => s.Equals(start, StringComparison.OrdinalIgnoreCase)))
                { MessageBox.Show($"Start location '{start}' is already in the stop list."); return; }

                if (stops.Exists(s => s.Equals(end, StringComparison.OrdinalIgnoreCase)))
                { MessageBox.Show($"Destination '{end}' is already in the stop list."); return; }

                // Parse and validate the manually entered distance
                if (!double.TryParse(txtDistance.Text.Trim(), out distance) || distance <= 0)
                { MessageBox.Show("Please enter a valid distance in km."); return; }

                distance += stops.Count * 15; // Add 15 km per stop for detours
            }
            else
            {
                // ── Default Cities mode validation ────────────────────────────
                if (cmbStart.SelectedItem == null || cmbEnd.SelectedItem == null)
                { MessageBox.Show("Please select start and destination."); return; }

                start = cmbStart.SelectedItem.ToString();
                end   = cmbEnd.SelectedItem.ToString();

                if (start == end)
                { MessageBox.Show("Start and destination cannot be the same."); return; }

                // Block start/end that conflict with stops already in the list
                if (stops.Contains(start))
                { MessageBox.Show($"Start location '{start}' is already in the stop list."); return; }

                if (stops.Contains(end))
                { MessageBox.Show($"Destination '{end}' is already in the stop list."); return; }

                // Look up road distance from tblCityDistances
                distance = RouteStorage.GetDistance(start, end);
                if (distance < 0)
                {
                    // GetDistance returns -1 when no matching row is found
                    MessageBox.Show(
                        $"No distance data found between {start} and {end}.\nPlease choose a different city pair.",
                        "Distance Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                distance += stops.Count * 15; // Add 15 km per stop for detours
            }

            // time (hours) = distance ÷ average speed for this transport type
            double time = distance / GetSpeed(t.TransportType);

            // Populate (or update) lastCreatedRoute so btnSaveRoute_Click can persist it
            if (lastCreatedRoute == null) lastCreatedRoute = new Route();
            lastCreatedRoute.Start       = start;
            lastCreatedRoute.End         = end;
            lastCreatedRoute.TransportID = t.TransportID;
            lastCreatedRoute.Transport   = t.TransportType;
            lastCreatedRoute.Distance    = distance;
            lastCreatedRoute.Time        = time;
            lastCreatedRoute.Stops       = new List<string>(stops); // Snapshot current stops

            // Format time as "2h 35m" or "45m" depending on duration
            int mins       = (int)(time * 60);
            string timeStr = mins >= 60 ? $"{mins / 60}h {mins % 60}m" : $"{mins}m";

            // Display the summary to the user
            lblResult.Text = $"{start} → {end}  ·  {distance:F0} km  ·  {timeStr}  ·  {stops.Count} stop(s)";
        }

        // ─────────────────────────────────────────────────────────────────────────
        // SAVE ROUTE
        // ─────────────────────────────────────────────────────────────────────────

        // Persists the calculated route to the database.
        //   Edit mode   → updates the existing tblroutes row
        //   Create mode → inserts a new row and creates a tblsavedroutes entry
        private void btnSaveRoute_Click(object sender, EventArgs e)
        {
            if (lastCreatedRoute == null)
            { MessageBox.Show("Please calculate a route first."); return; }

            // Sync the live stop list in case the user added/removed stops after
            // the last Calculate click
            lastCreatedRoute.Stops = new List<string>(stops);

            if (isEditMode)
            {
                // Update existing record in tblroutes and sync tblsavedroutes.savedName
                RouteStorage.UpdateRoute(lastCreatedRoute);
                MessageBox.Show("Route updated successfully!");
            }
            else
            {
                // Insert into tblroutes and create a tblsavedroutes entry for this user
                int newId = RouteStorage.InsertRoute(lastCreatedRoute);
                RouteStorage.SaveToSavedRoutes(newId);
                MessageBox.Show("Route saved successfully!");
            }

            // Reset the form ready for the next route
            lastCreatedRoute = null;
            stops.Clear();
            lstStops.Items.Clear();
            lblResult.Text = "";

            // Clear the inputs appropriate to the currently active mode
            if (!IsCustom) { cmbStart.SelectedIndex = -1; cmbEnd.SelectedIndex = -1; }
            else { txtStart.Clear(); txtEnd.Clear(); txtDistance.Clear(); }
        }

        // ─────────────────────────────────────────────────────────────────────────
        // HELPERS
        // ─────────────────────────────────────────────────────────────────────────

        // Reads the user's saved preferences and applies them to this form.
        //   FontSize  – scales the form font (levels 1–5 → 9pt to 17pt)
        //   HighContrast – switches between normal and dark colour palette
        private void ApplySettings()
        {
            var s = SettingsStorage.Load();
            float sz = 9f + (s.FontSize - 1) * 2f; // 1→9pt, 2→11pt, 3→13pt, 4→15pt, 5→17pt
            this.Font = new Font(this.Font.FontFamily, sz);
            UITheme.ApplyTheme(this, s.HighContrast);
        }

        // Returns the average cruising/travelling speed in km/h for a transport type.
        // ToLower().Trim() ensures database values like "Walk" or "WALK" both match.
        private static double GetSpeed(string transport)
        {
            switch (transport.ToLower().Trim())
            {
                case "walk":
                case "walking":    return 5;    // Comfortable walking pace
                case "bike":
                case "bicycle":
                case "cycling":    return 15;   // Leisure cycling average
                case "plane":
                case "aeroplane":
                case "airplane":   return 800;  // Approximate cruising speed
                case "train":      return 130;  // UK intercity average
                case "bus":        return 50;   // Average including scheduled stops
                case "car":
                default:           return 80;   // Average UK road driving speed
            }
        }

        // Selects a value in a ComboBox by its display text.
        // Does nothing silently if the value is not present in the list.
        private static void TrySetCombo(ComboBox c, string v)
        {
            int i = c.Items.IndexOf(v);
            if (i >= 0) c.SelectedIndex = i;
        }
    }
}
