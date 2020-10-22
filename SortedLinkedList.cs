using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    class SortedLinkedList
    {
        public Node head;

        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                var temp = head;
                Node prev = null;
                while (temp.next != null && temp.data <= data)
                {
                    prev = temp;
                    temp = temp.next;
                }
                if(temp.next == null && temp.data < data)
                {
                    temp.next = node;
                                       
                }
                else
                {
                    node.next = temp;
                    if (prev == null)
                        head = node;
                    else
                        prev.next = node;
                }  
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            while (temp != null)
            {
                Console.Write("->" + temp.data);
                temp = temp.next;
            }
        }
    }
}
