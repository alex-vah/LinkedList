using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList._DoublyLinkedList
{
    public class DNode<T>
    {
        public T data;
        public DNode<T> prev;
        public DNode<T> next;
        public DNode(T value)
        {
            data = value;
            prev = null;
            next = null;
        }
    }
}
