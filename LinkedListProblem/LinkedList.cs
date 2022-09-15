using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    internal class LinkedList
    {
        internal Node head;
        ///<summary>
        ///UC-1 - Create Simple LinkedList
        ///</summary>
        ///Adding Element in LinkedList
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        ///<summary>
        ///UC-2
        ///</summary>
        ///Adding Element in Reverse Order in LinkedList
        internal void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;//70
                head = newNode;//30
                head.next = temp;//70->30
            }
        }
        internal void Display()            
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " " + "\n");
                temp = temp.next;
            }
        }
    }
}
