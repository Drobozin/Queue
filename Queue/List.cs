using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{   
    public class List
    {
        private Node _first, _last;
        
        public void Enqueue(ComplexClass c)
        {
            Node temp = new Node(c);
            if (_last == null)
            {
                _first = temp;
                _last = temp;
            }
            else
            {
                _last.Next = temp;
                _last = _last.Next;
            }
            
        }

        public ComplexClass Deque()
        {
            if (_first == null) return null;
            Node temp = new Node(_first.Data);
            _first = _first.Next;
            return temp.Data;
        }

        public ComplexClass Peek()
        {
            return _first?.Data;
        }

        private class Node
        {
            public Node(ComplexClass data, Node next = null)
            {
                Data = data;
                Next = next;
            }
            public ComplexClass Data { get; set; }
            public Node Next { get; set; }
        }
      
        public int Count
        {
            get
            {
                int result = 0;
                Node node = _first;
                while (node != null)
                {
                    node = node.Next;
                    ++result;
                }

                return result;
            }
        }
        public void Print()
        {
            Node temp = _first;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
    }
}
