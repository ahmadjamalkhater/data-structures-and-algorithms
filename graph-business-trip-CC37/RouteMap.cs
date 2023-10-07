using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphs
{
    public class RouteMap
    {
        public Dictionary<string, Dictionary<string, int>> graph;

        public RouteMap()
        {
            graph = new Dictionary<string, Dictionary<string, int>>();
        }

        public void AddRoute(string source, string destination, int cost)
        {
            if (!graph.ContainsKey(source))
            {
                graph[source] = new Dictionary<string, int>();
            }
            graph[source][destination] = cost;
        }

        public int GetCost(string source, string destination)
        {
            if (graph.ContainsKey(source) && graph[source].ContainsKey(destination))
            {
                return graph[source][destination];
            }
            return -1; // Return -1 if the route is not found
        }
    

    
        public static int? BusinessTrip(RouteMap routeMap, string[] itinerary)
        {
            int totalCost = 0;

            for (int i = 0; i < itinerary.Length - 1; i++)
            {
                string source = itinerary[i];
                string destination = itinerary[i + 1];

                int cost = routeMap.GetCost(source, destination);

                if (cost == -1)
                {
                    return null; // Direct flight not available, return null
                }

                totalCost += cost;
            }

            return totalCost;
        }
    }
}
