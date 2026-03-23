namespace TravelAround
{
    // Transport model class: represents a transport type in the system
    public class Transport
    {
        // Unique ID of transport (Primary Key in database)
        public int TransportID { get; set; }

        // Name of transport type (e.g., Car, Bike, Walking)
        public string TransportType { get; set; }
    }
}
