using graph_breadth_first_CC36;
using System;
using System.Collections.Generic;
using System.Linq;



class Program
{
    public static void Main(string[] args)
    {
        Graph graph = new Graph(6);

        Node pandora = new Node("Pandora", 0);
        Node arendelle = new Node("Arendelle", 1);
        Node metroville = new Node("Metroville", 2);
        Node monstropolis = new Node("Monstropolis", 3);
        Node narnia = new Node("Narnia", 4);
        Node naboo = new Node("Naboo", 5);

        graph.AddEdge(pandora, arendelle);
        graph.AddEdge(pandora, metroville);
        graph.AddEdge(arendelle, monstropolis);
        graph.AddEdge(arendelle, narnia);
        graph.AddEdge(metroville, narnia);
        graph.AddEdge(metroville, naboo);
        List<Node> visitedNodes = graph.BreadthFirst(pandora);

        foreach (Node node in visitedNodes)
        {
            Console.WriteLine(node.Name);
        }

    }

}