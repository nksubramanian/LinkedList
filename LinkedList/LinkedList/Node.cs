using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public Node _next;

        public int _value;

        public Node(int value)
        {
            _value = value;
            _next = null;
        }

        public void AddNode(Node node)
        {
            _next = node;
        }

    }
}
