using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TravelAround
{
    // FrmSavedRoutes: read-only view of all saved routes rendered as styled cards.
    // Each card shows: route number badge, title (Start → End), a divider,
    // a stats row (transport / distance / time) and a stops summary line.
    public partial class FrmSavedRoutes : Form
    {
        // In-memory list of saved routes loaded from the database
        private List<Route> routes;

        // Constructor: applies settings, loads routes, then builds the card list
        public FrmSavedRoutes()
        {
            InitializeComponent();
            ApplySettings();                         // Font size + colour theme
            routes = RouteStorage.LoadSavedRoutes(); // Fetch saved routes from DB
            BuildRouteCards();                       // Render cards into the scroll panel
        }

        // Reads the user's saved preferences and applies them to this form
        private void ApplySettings()
        {
            var s = SettingsStorage.Load();
            float finalSize = 9f + (s.FontSize - 1) * 2f; // 1→9pt … 5→17pt
            this.Font = new Font(this.Font.FontFamily, finalSize);
            UITheme.ApplyTheme(this, s.HighContrast);
        }

        // Clears pnlScroll and rebuilds all route cards from the routes list.
        // Called once on construction; can be called again if data changes.
        private void BuildRouteCards()
        {
            pnlScroll.Controls.Clear();

            // Detect high-contrast mode by comparing the current form background colour
            bool hc = this.BackColor == Color.Black;

            // Show a friendly placeholder when the user has no saved routes
            if (routes.Count == 0)
            {
                pnlScroll.Controls.Add(new Label
                {
                    Text      = "No saved routes found.",
                    AutoSize  = true,
                    Font      = new Font("Segoe UI", 10f, FontStyle.Italic),
                    ForeColor = hc ? Color.LightGray : Color.Gray,
                    Location  = new System.Drawing.Point(16, 16)
                });
                return;
            }

            int y     = 10;                   // Vertical cursor for stacking cards
            int cardW = pnlScroll.Width - 28; // Leave room for the scrollbar

            // Create and stack one card per route
            for (int i = 0; i < routes.Count; i++)
            {
                var card = BuildCard(routes[i], i + 1, cardW, hc);
                card.Location = new System.Drawing.Point(10, y);
                pnlScroll.Controls.Add(card);
                y += card.Height + 12; // 12 px vertical gap between cards
            }
        }

        // Builds and returns a single route card Panel.
        // Parameters:
        //   r    – the Route data to display
        //   num  – 1-based sequential number shown in the badge
        //   w    – card width in pixels
        //   hc   – true when high-contrast mode is active
        private Panel BuildCard(Route r, int num, int w, bool hc)
        {
            // Outer panel: white in normal mode, near-black in high-contrast
            var card = new Panel
            {
                Width     = w,
                Height    = 110,
                BackColor = hc ? Color.FromArgb(28, 28, 28) : Color.White
            };

            // Paint a rounded-corner border using GDI+ on every repaint
            card.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                // Border colour: dark grey in HC mode, light blue-grey in normal mode
                using (var p = new Pen(Color.FromArgb(hc ? 60 : 200, hc ? 60 : 200, hc ? 60 : 220), 1.4f))
                {
                    var rc   = new Rectangle(0, 0, card.Width - 1, card.Height - 1);
                    var path = RoundedRect(rc, 8); // 8 px corner radius
                    e.Graphics.DrawPath(p, path);
                }
            };

            // Choose colours appropriate to the current contrast mode
            Color headClr = hc ? Color.White                   : Color.FromArgb(13, 28, 64);
            Color subClr  = hc ? Color.FromArgb(160, 160, 160) : Color.FromArgb(100, 116, 139);
            Color divClr  = hc ? Color.FromArgb(60, 60, 60)    : Color.FromArgb(226, 232, 240);

            // ── Route number badge (top-left corner) ─────────────────────────
            card.Controls.Add(new Label
            {
                Text      = $"#{num}",
                AutoSize  = false,
                Size      = new System.Drawing.Size(34, 20),
                Location  = new System.Drawing.Point(12, 12),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font      = new Font("Segoe UI", 8f, FontStyle.Bold),
                ForeColor = hc ? Color.White                 : Color.FromArgb(26, 79, 160),
                BackColor = hc ? Color.FromArgb(40, 40, 40) : Color.FromArgb(230, 236, 250)
            });

            // ── Route title: "Start  →  End" ─────────────────────────────────
            card.Controls.Add(new Label
            {
                Text      = $"{r.Start}  →  {r.End}",
                AutoSize  = true,
                Location  = new System.Drawing.Point(54, 12),
                Font      = new Font("Segoe UI", 11f, FontStyle.Bold),
                ForeColor = headClr
            });

            // ── Horizontal divider below the title ────────────────────────────
            card.Controls.Add(new Panel
            {
                BackColor = divClr,
                Location  = new System.Drawing.Point(12, 38),
                Size      = new System.Drawing.Size(w - 34, 1)
            });

            // ── Stats row: transport icon · distance · estimated time ─────────
            int mins       = (int)(r.Time * 60);
            string timeStr = mins >= 60 ? $"{mins / 60}h {mins % 60}m" : $"{mins}m";

            card.Controls.Add(new Label
            {
                Text      = $"🚗 {r.Transport}   📍 {r.Distance:F0} km   ⏱ {timeStr}",
                AutoSize  = true,
                Location  = new System.Drawing.Point(12, 48),
                Font      = new Font("Segoe UI", 9f),
                ForeColor = subClr
            });

            // ── Stops summary (bottom row) ────────────────────────────────────
            string stopsText = r.Stops.Count > 0 ? string.Join(" → ", r.Stops) : "No stops";
            card.Controls.Add(new Label
            {
                Text      = $"Stops: {stopsText}",
                AutoSize  = false,
                Size      = new System.Drawing.Size(w - 34, 22),
                Location  = new System.Drawing.Point(12, 76),
                Font      = new Font("Segoe UI", 8.5f, FontStyle.Italic),
                ForeColor = subClr
            });

            return card;
        }

        // Builds a GraphicsPath with rounded corners for drawing the card border.
        // Each corner is an arc of radius 'rad'; arcs are drawn clockwise starting
        // from the top-left corner.
        private GraphicsPath RoundedRect(Rectangle r, int rad)
        {
            var path = new GraphicsPath();
            path.AddArc(r.X,              r.Y,              rad * 2, rad * 2, 180, 90); // top-left
            path.AddArc(r.Right - rad*2,  r.Y,              rad * 2, rad * 2, 270, 90); // top-right
            path.AddArc(r.Right - rad*2,  r.Bottom - rad*2, rad * 2, rad * 2,   0, 90); // bottom-right
            path.AddArc(r.X,              r.Bottom - rad*2, rad * 2, rad * 2,  90, 90); // bottom-left
            path.CloseFigure();
            return path;
        }

        // Closes this form and returns to the Routes menu
        private void btnBack_Click(object sender, EventArgs e) { this.Close(); }
    }
}
