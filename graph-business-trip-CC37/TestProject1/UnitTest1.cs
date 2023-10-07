using graphs;
using Xunit;

namespace testGraph
{
    public class UnitTest1
    {

        [Fact]
        public void Test_BusinessTrip_Valid()
        {
            var routeMap = new RouteMap();
            // Add routes to the route map
            routeMap.AddRoute("Metroville", "Pandora", 82);
            routeMap.AddRoute("Arendelle", "New Monstropolis", 115);
            routeMap.AddRoute("New Monstropolis", "Naboo", 150);

            string[] itinerary = { "Metroville", "Pandora" };
            int? result = Program.BusinessTrip(routeMap, itinerary);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(82, result);
        }

        [Fact]
        public void Test_BusinessTrip_Invalid()
        {
            var routeMap = new RouteMap();
            // Add routes to the route map
            routeMap.AddRoute("Metroville", "Pandora", 82);
            routeMap.AddRoute("Arendelle", "New Monstropolis", 115);

            string[] itinerary = { "Metroville", "Naboo" };
            int? result = Program.BusinessTrip(routeMap, itinerary);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void Test_BusinessTrip_EmptyItinerary()
        {
            var routeMap = new RouteMap();
            // Add routes to the route map
            routeMap.AddRoute("Metroville", "Pandora", 82);

            string[] itinerary = new string[0];
            int? result = Program.BusinessTrip(routeMap, itinerary);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(0, result);
        }

    }



    }

    
