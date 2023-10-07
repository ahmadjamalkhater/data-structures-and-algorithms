namespace graphs
{
    public class Program
    {
        static void Main(string[] args)
        {

            //    var routeMap = new RouteMap();
            //    // Add routes to the route map
            //    routeMap.AddRoute("Metroville", "Pandora", 82);
            //    routeMap.AddRoute("Arendelle", "New Monstropolis", 115);
            //    routeMap.AddRoute("New Monstropolis", "Naboo", 150);

            //    // Test cases
            //    string[] itinerary1 = { "Metroville", "Pandora" };
            //    string[] itinerary2 = { "Arendelle", "New Monstropolis", "Naboo" };
            //    string[] itinerary3 = { "Naboo", "Pandora" };
            //    string[] itinerary4 = { "Narnia", "Arendelle", "Naboo" };

            //    Console.WriteLine("Input: [" + string.Join(", ", itinerary1) + "]");
            //    int? result1 = BusinessTrip(routeMap, itinerary1);
            //    Console.WriteLine("Output: " + (result1.HasValue ? "$" + result1 : "null"));
            //    Console.WriteLine();

            //    Console.WriteLine("Input: [" + string.Join(", ", itinerary2) + "]");
            //    int? result2 = BusinessTrip(routeMap, itinerary2);
            //    Console.WriteLine("Output: " + (result2.HasValue ? "$" + result2 : "null"));
            //    Console.WriteLine();

            //    Console.WriteLine("Input: [" + string.Join(", ", itinerary3) + "]");
            //    int? result3 = BusinessTrip(routeMap, itinerary3);
            //    Console.WriteLine("Output: " + (result3.HasValue ? "$" + result3 : "null"));
            //    Console.WriteLine();

            //    Console.WriteLine("Input: [" + string.Join(", ", itinerary4) + "]");
            //    int? result4 = BusinessTrip(routeMap, itinerary4);
            //    Console.WriteLine("Output: " + (result4.HasValue ? "$" + result4 : "null"));

            //}

            //public static int? BusinessTrip(RouteMap routeMap, string[] itinerary)
            //{
            //    int totalCost = 0;

            //    for (int i = 0; i < itinerary.Length - 1; i++)
            //    {
            //        string source = itinerary[i];
            //        string destination = itinerary[i + 1];

            //        int cost = routeMap.GetCost(source, destination);

            //        if (cost == -1)
            //        {
            //            return null; // Direct flight not available, return null
            //        }

            //        totalCost += cost;
            //    }

            //    return totalCost;
            //}



            //CC38

            var graph = new Graph();
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");
            graph.AddVertex("D");
            graph.AddEdge("A", "B");
            graph.AddEdge("A", "C");
            graph.AddEdge("B", "D");

            var result = graph.DepthFirstPreOrder("A");

            Console.WriteLine("Depth-First Pre-Order Traversal:");
            Console.WriteLine(string.Join(" -> ", result));
        }
    }
}