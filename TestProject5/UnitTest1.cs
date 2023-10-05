using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using graph_breadth_first_CC36;

namespace graph_breadth_first_CC36.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void HasPath_ValidPath_ReturnsTrue()
        {
            // Arrange
            Graph graph = new Graph(6);

            // Create two nodes with a path between them.
            Node pandora = new Node("Pandora", 0);
            Node naboo = new Node("Naboo", 5);

            graph.AddEdge(pandora, naboo);

            // Act
            bool hasPath = graph.HasPath(pandora, naboo);

            // Assert
            Assert.IsTrue(hasPath);
        }

        [Fact]
        public void HasPath_NoPath_ReturnsFalse()
        {
            // Arrange
            Graph graph = new Graph(6);

            // Create two nodes with no path between them.
            Node pandora = new Node("Pandora", 0);
            Node narnia = new Node("Narnia", 4);

            graph.AddEdge(pandora, naboo);

            // Act
            bool hasPath = graph.HasPath(pandora, narnia);

            // Assert
            Assert.IsFalse(hasPath);
        }

        [Fact]
        public void HasPath_SelfLoop_ReturnsTrue()
        {
            // Arrange
            Graph graph = new Graph(1);

            // Create a node with a self-loop.
            Node pandora = new Node("Pandora", 0);
            graph.AddEdge(pandora, pandora);

            // Act
            bool hasPath = graph.HasPath(pandora, pandora);

            // Assert
            Assert.IsTrue(hasPath);
        }
    }
}
