using graph_breadth_first_CC36;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Graph_AddEdge_ShouldAddEdge()
        {
            // Arrange
            Graph graph = new Graph(3);
            Node node1 = new Node("Node 1", 0);
            Node node2 = new Node("Node 2", 1);

            // Act
            graph.AddEdge(node1, node2);

            // Assert
            Assert.Contains(node2, graph.BreadthFirst(node1));
        }

        [Fact]
        public void Graph_BreadthFirst_ShouldReturnCorrectOrder()
        {
            // Arrange
            Graph graph = new Graph(3);
            Node node1 = new Node("Node 1", 0);
            Node node2 = new Node("Node 2", 1);
            Node node3 = new Node("Node 3", 2);

            graph.AddEdge(node1, node2);
            graph.AddEdge(node1, node3);

            // Act
            List<Node> visitedNodes = graph.BreadthFirst(node1);

            // Assert
            Assert.Equal(node1, visitedNodes[0]);
            Assert.Equal(node2, visitedNodes[1]);
            Assert.Equal(node3, visitedNodes[2]);
        }

        [Fact]
        public void Node_Constructor_ShouldSetProperties()
        {
            // Arrange
            string nodeName = "Test Node";
            int nodeId = 42;

            // Act
            Node node = new Node(nodeName, nodeId);

            // Assert
            Assert.Equal(nodeName, node.Name);
            Assert.Equal(nodeId, node.Id);
        }
    }
}