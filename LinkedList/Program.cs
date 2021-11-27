using LinkedList._SinglyLinkedList;
using LinkedList._DoublyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _SinglyLinkedList<int> singlyLinkedList = new _SinglyLinkedList<int>();
            singlyLinkedList.InsertLast(1111);
            //singlyLinkedList.InsertLast(2222);
            singlyLinkedList.InsertLast(3333);
            singlyLinkedList.InsertLast(4444);
            singlyLinkedList.InsertAfter(singlyLinkedList.head, 0000);
            singlyLinkedList.ReverseLinkedList();
            singlyLinkedList.DeleteNodebyKey(1111);
            _DoublyLinkedList<int> doubleLinkedList = new _DoublyLinkedList<int>();
            doubleLinkedList.InsertLast(1111);
            doubleLinkedList.InsertLast(2222);
            doubleLinkedList.InsertLast(3333);
            doubleLinkedList.InsertLast(4444);
            doubleLinkedList.InsertLast(5555);
            doubleLinkedList.InsertAfter(doubleLinkedList.head.next, 0000);
            doubleLinkedList.ReverseLinkedList();
            doubleLinkedList.DeleteNodebyKey(0000);
            var node2 = doubleLinkedList.GetLastNode();
        }
    }
}
