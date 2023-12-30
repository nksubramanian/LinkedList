using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListImp
    {
        private Node _head = null;
        
        public Node GetHead()
        {
            if(_head is null)
            {
                throw new Exception("There is no head");
            }
            return _head;
        }

        public void AddNodeAtBeginning(int value)
        {
            if(_head is null)
            {
                _head = new Node(value);
            }
            else
            {
                var temp = new Node(value);
                temp._next = _head;
                _head = temp;
            }
        }

        public void AddNodeAtEnd(int value)
        {
            if (_head is null)
            {
                _head = new Node(value);
            }
            else
            {
                var iter = _head;
                while(iter._next != null) 
                { 
                    iter = iter._next;
                }
                iter._next = new Node(value);

            }
        }

        public void PrintAll()
        {
            if (_head is null)
            {
                throw new Exception("There is no head");
            }

            var iter = _head;
            while(iter != null)
            {
                Console.WriteLine(iter._value);
                iter = iter._next;  
            }
        }

    }
}
