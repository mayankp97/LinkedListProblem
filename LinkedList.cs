using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    class LinkedList
    {
        internal Node head;

        internal void AddAtBack(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);


        }

        internal void AddAtFront(int data)
        {
            var node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                var temp = head;
                head = node;
                node.next = temp;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            while (temp != null)
            {
                Console.Write("->"+temp.data);
                temp = temp.next;
            }
        }
    }
}
