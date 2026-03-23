using System.Collections.Generic;

namespace TravelAround
{
    // Route model class: represents a complete travel route
    public class Route
    {
        // Unique identifier of the route (Primary Key in database)
        public int RouteID { get; set; }

        // Foreign key: identifies transport type used for this route
        public int TransportID { get; set; }

        // Starting location of the route
        public string Start { get; set; }

        // Destination location of the route
        public string End { get; set; }

        // Transport name (e.g., Car, Bike, Walking)
        public string Transport { get; set; }

        // Total distance of the route (calculated)
        public double Distance { get; set; }

        // Estimated time to complete route (calculated)
        public double Time { get; set; }

        // List of intermediate stops in the route
        public List<string> Stops { get; set; } = new List<string>();
    }
}
