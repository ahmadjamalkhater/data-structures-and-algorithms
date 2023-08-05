namespace Async___Inn.Models
{
    public class RoomAmenities
    {
        public int AmenitiesID { get; set; }
        public int RoomID { get; set; }
        // Navigation Propabilities
        public Room? Room { get; set; }
        public Amenity? Amenity { get; set; }
    }
}
