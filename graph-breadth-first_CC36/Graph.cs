using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace graph_breadth_first_CC36
{
    public class Graph
    {
        private List<List<Node>> _adjList;

        public Graph(int numNodes)
        {
            _adjList = new List<List<Node>>(numNodes);
            for (int i = 0; i < numNodes; i++)
            {
                _adjList.Add(new List<Node>());
            }
        }

        public void AddEdge(Node start, Node end)
        {
            _adjList[start.Id].Add(end);
        }

        public List<Node> BreadthFirst(Node startNode)
        {
            Queue<Node> queue = new Queue<Node>();
            List<Node> visitedNodes = new List<Node>();

            queue.Enqueue(startNode);
            visitedNodes.Add(startNode);

            while (queue.Count > 0)
            {
                Node currentNode = queue.Dequeue();

                foreach (Node neighbor in _adjList[currentNode.Id])
                {
                    if (!visitedNodes.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        visitedNodes.Add(neighbor);
                    }
                }
            }

            return visitedNodes;
        }
    }
    



}