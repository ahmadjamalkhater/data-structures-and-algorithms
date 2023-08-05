using Async___Inn.Models;
using Microsoft.EntityFrameworkCore;

namespace Async___Inn.Data
{
    public class AsyncInnDbContext : DbContext
    {
        public AsyncInnDbContext(DbContextOptions options) : base(options)
        {

        }



        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<HotelRoom> HotelRoom { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().HasData(
               new Hotel() { ID = 1, Name = "SahNoom", StreetAdress = "st60", City = "Ammman", Country = "Jordan", Phone = "0785531521", State = "aljama'astreet" },
               new Hotel() { ID = 2, Name = "Castle", StreetAdress = "st30", City = "Ammman", Country = "Jordan", Phone = "0795412587", State = "36 street" },
               new Hotel() { ID = 3, Name = "Diamond", StreetAdress = "st100", City = "Ammman", Country = "Jordan", Phone = "0792222222", State = "16 street" }
               );
            modelBuilder.Entity<Room>().HasData(
                new Room() { ID = 1, Name = "Bedroom", Layout = 20 },
                new Room() { ID = 2, Name = "livingroom", Layout = 30 },
                new Room() { ID = 3, Name = "Kitchen", Layout = 10 }
                );
            modelBuilder.Entity<Amenity>().HasData(
                new Room() { ID = 1, Name = "fitness center" },
                new Room() { ID = 2, Name = "swiming pool" },
                new Room() { ID = 3, Name = "buisiness center" }
                );

            modelBuilder.Entity<HotelRoom>().HasKey(
                hotelRoom => new { hotelRoom.HotelID, hotelRoom.RoomID, hotelRoom.RoomNumber, hotelRoom.Rate, hotelRoom.PetFreindly }
                );
            modelBuilder.Entity<RoomAmenities>().HasKey(
                roomAmenities => new { roomAmenities.AmenitiesID, roomAmenities.RoomID }
                );

        }



    }
}
