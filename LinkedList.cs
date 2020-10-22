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

        internal void InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid position");
                return;
            }
            else if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                var newNode = new Node(data);
                int current = 1;
                var temp = head;
                var prev = head;
                while (current < position)
                {
                    if(temp == null)
                    {
                        Console.WriteLine("Position out of range");
                        return;
                    }
                    prev = temp;
                    temp = temp.next;
                    current++;
                }
                
                newNode.next = temp;
                prev.next = newNode;
                Console.WriteLine("Element added at position {0}", position);

            }

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
