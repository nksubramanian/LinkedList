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

        public void DeleteNodeAtEnd()
        {
            if ( _head is null)
            {
                throw new Exception("there are no nodes");
            }

            if(_head._next is null)
            {
                _head = null;
                return;
            }
            var iter = _head;
            while(iter._next._next != null)
            {
                iter = iter._next;
            }

            iter._next = null;

        }

        public void DeleteNodeAtBeginning()
        {
            if (_head is null)
            {
                throw new Exception("there are no nodes");
            }
            _head = _head._next;

        }


        public int GetLength()
        {
            Node iter = _head;
            int count = 0;
            while(iter!=null)
            {
                count++;
                iter = iter._next;
            }
            return count;

        }

        public bool IsKeyExists(int value)
        {
            var iter = _head;
            while(iter != null)
            {
                if(iter._value == value)
                {
                    return true;
                }
                iter = iter._next;
            }
            return false;

        }

        public int GetLastNode()
        {
            Node iter = _head;
            while (iter._next != null)
            {
                iter = iter._next;
            }
            return iter._value;
        }

        public int GetLastNode(int i)
        {
            int count = 0;
            Node res = _head;
            Node iter = _head;
            while (iter != null)
            {
                count++;
                if (count > i+1)
                {
                    res = res._next;
                }

                iter = iter._next;
            }
            return res._value;
        }


        public void Reverse()
        {
            Node newHead = null;
            while (_head != null) 
            {

                if (newHead is null)
                {
                    newHead = _head;
                    _head = _head._next;
                    newHead._next = null;
                }
                else
                {
                    var temp = newHead;
                    newHead = _head;
                    _head = _head._next;
                    newHead._next = temp;
                }

            }
            _head = newHead;


        }
    }
}
