using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList._SinglyLinkedList
{
    public class _SinglyLinkedList<T>
    {
        public Node<T> head;
        public void InsertFront(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            new_node.next = head;
            head = new_node;
        }
        public void InsertLast(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            if (head == null)
            {
                head = new_node;
            }
            Node<T> lastNode = GetLastNode();
            lastNode.next = new_node;
        }
        private Node<T> GetLastNode()
        {
            Node<T> tmp = head;
            while (tmp.next != null)
            {
                tmp = tmp.next;
            }
            return tmp;
        }
        public void InsertAfter(Node<T> prev_node, T new_data)
        {
            if (prev_node == null)
            {
                throw new NullReferenceException("The given previous node Cannot be null");
            }
            Node<T> new_node = new Node<T>(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }
        public void DeleteNodebyKey(T key)
        {
            Node<T> tmp = head;
            Node<T> prev = null;
            if (tmp != null && tmp.data.Equals(key))
            {
                head = tmp.next;
                return;
            }
            while (tmp != null && !tmp.data.Equals(key))
            {
                prev = tmp;
                tmp = tmp.next;
            }
            if (tmp == null)
            {
                return;
            }
            prev.next = tmp.next;
        }
        public void ReverseLinkedList()
        {
            Node<T> prev = null;
            Node<T> current = head;
            Node<T> tmp = null;
            while(current != null)
            {
                tmp = current.next;
                current.next = prev;
                prev = current;
                current = tmp;
            }
            head = prev;
        }
    }
}
