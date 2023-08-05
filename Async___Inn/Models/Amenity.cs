namespace Async___Inn.Models
{
    public class Amenity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<RoomAmenities>? RoomAmenities { get; set; }
    }
}
