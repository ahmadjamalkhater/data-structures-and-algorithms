using System;
using System.Collections.Generic;

public class Graph
{
    public Dictionary<string, List<(string, int)>> vertices;

    public Graph()
    {
        vertices = new Dictionary<string, List<(string, int)>>();
    }

    public string AddVertex(string value)
    {
        if (!vertices.ContainsKey(value))
        {
            vertices[value] = new List<(string, int)>();
        }
        return value;
    }

    public void AddEdge(string vertex1, string vertex2, int? weight = null)
    {
        if (vertices.ContainsKey(vertex1) && vertices.ContainsKey(vertex2))
        {
            vertices[vertex1].Add((vertex2, weight.GetValueOrDefault()));
            vertices[vertex2].Add((vertex1, weight.GetValueOrDefault()));
        }
    }

    public List<string> GetVertices()
    {
        return new List<string>(vertices.Keys);
    }

    public List<(string, int)> GetNeighbors(string vertex)
    {
        return vertices.ContainsKey(vertex) ? vertices[vertex] : new List<(string, int)>();
    }

    public int Size()
    {
        return vertices.Count;
    }
    public class Program
    {
        public static void Main()
        {
            Graph graph = new Graph();


            string vertex1 = graph.AddVertex("A");
            string vertex2 = graph.AddVertex("B");
            string vertex3 = graph.AddVertex("C");


            graph.AddEdge(vertex1, vertex2, 5);
            graph.AddEdge(vertex2, vertex3, 10);
            graph.AddEdge(vertex1, vertex3, 8);


            Console.WriteLine("Vertices: " + string.Join(", ", graph.GetVertices()));


            Console.WriteLine($"Neighbors of {vertex1}: {string.Join(", ", graph.GetNeighbors(vertex1))}");


            Console.WriteLine("Graph size: " + graph.Size());
        }
    }
}
