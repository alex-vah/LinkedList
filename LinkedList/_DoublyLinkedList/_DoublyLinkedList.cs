using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList._DoublyLinkedList
{
    public class _DoublyLinkedList<T>
    {
        public DNode<T> head;
        public void InsertFront(T data)
        {
            DNode<T> newNode = new DNode<T>(data);
            newNode.next = head;
            newNode.prev = null;
            if (head != null)
            {
                head.prev = newNode;
            }
            head = newNode;
        }
        public void InsertLast(T data)
        {
            DNode<T> newNode = new DNode<T>(data);
            if (head == null)
            {
                newNode.prev = null;
                head = newNode;
                return;
            }
            DNode<T> lastNode = GetLastNode();
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }
        public DNode<T> GetLastNode()
        {
            DNode<T> tmp = head;
            while (tmp.next != null)
            {
                tmp = tmp.next;
            }
            return tmp;
        }
        public void InsertAfter(DNode<T> prev_node, T data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given prevoius node cannot be null");
            }
            DNode<T> newNode = new DNode<T>(data);
            newNode.next = prev_node.next;
            prev_node.next = newNode;
            newNode.prev = prev_node;
            if (newNode.next != null)
            {
                newNode.next.prev = newNode;
            }
        }
        public void DeleteNodebyKey(T key)
        {
            DNode<T> tmp = head;
            if (tmp != null && tmp.data.Equals(key))
            {
                head = tmp.next;
                head.prev = null;
            }
            while (tmp != null && tmp.data.Equals(key)==false)
            {
                tmp = tmp.next;
            }
            if (tmp == null)
            {
                return;
            }
            if (tmp.next != null)
            {
                tmp.next.prev = tmp.prev;
            }
            if (tmp.prev != null)
            {
                tmp.prev.next = tmp.next;
            }
        }
        public void ReverseLinkedList()
        {
            DNode<T> prev = null;
            DNode<T> current = head;
            DNode<T> tmp = null;
            while (current != null)
            {
                tmp = current.next;
                current.next = prev;
                if (current.prev != null)
                {
                    prev.prev = current;
                }
                prev = current;
                current = tmp;
            }
            head = prev;
            prev.prev = null;
        }

    }
}
