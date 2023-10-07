using graphs;
using Xunit;

namespace testGraph
{
    public class UnitTest1
    {

        //[Fact]
        //public void Test_BusinessTrip_Valid()
        //{
        //    var routeMap = new RouteMap();
        //    // Add routes to the route map
        //    routeMap.AddRoute("Metroville", "Pandora", 82);
        //    routeMap.AddRoute("Arendelle", "New Monstropolis", 115);
        //    routeMap.AddRoute("New Monstropolis", "Naboo", 150);

        //    string[] itinerary = { "Metroville", "Pandora" };
        //    int? result = Program.BusinessTrip(routeMap, itinerary);

        //    // Assert
        //    Assert.NotNull(result);
        //    Assert.Equal(82, result);
        //}

        //[Fact]
        //public void Test_BusinessTrip_Invalid()
        //{
        //    var routeMap = new RouteMap();
        //    // Add routes to the route map
        //    routeMap.AddRoute("Metroville", "Pandora", 82);
        //    routeMap.AddRoute("Arendelle", "New Monstropolis", 115);

        //    string[] itinerary = { "Metroville", "Naboo" };
        //    int? result = Program.BusinessTrip(routeMap, itinerary);

        //    // Assert
        //    Assert.Null(result);
        //}

        //[Fact]
        //public void Test_BusinessTrip_EmptyItinerary()
        //{
        //    var routeMap = new RouteMap();
        //    // Add routes to the route map
        //    routeMap.AddRoute("Metroville", "Pandora", 82);

        //    string[] itinerary = new string[0];
        //    int? result = Program.BusinessTrip(routeMap, itinerary);

        //    // Assert
        //    Assert.NotNull(result);
        //    Assert.Equal(0, result);
        //}

//CC38
        [Fact]
        public void Test_DepthFirstPreOrder_Valid()
        {
            // Arrange
            var graph = new Graph();
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");
            graph.AddVertex("D");
            graph.AddEdge("A", "B");
            graph.AddEdge("A", "C");
            graph.AddEdge("B", "D");

            // Act
            var result = graph.DepthFirstPreOrder("A");

            // Assert
            var expected = new[] { "A", "B", "D", "C" };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_DepthFirstPreOrder_StartNodeNotInGraph()
        {
            // Arrange
            var graph = new Graph();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => graph.DepthFirstPreOrder("A"));
        }

        [Fact]
        public void Test_DepthFirstPreOrder_EmptyGraph()
        {
            // Arrange
            var graph = new Graph();
            graph.AddVertex("A"); // Add a vertex to the graph

            // Act
            var result = graph.DepthFirstPreOrder("A"); // Use the added vertex as the start node

            // Assert
            var expected = new[] { "A" }; // The result should contain only the start node
            Assert.Equal(expected, result);
        }
    }



    }

    
