using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph_breadth_first_CC36
{
    public class Node
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Node(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}