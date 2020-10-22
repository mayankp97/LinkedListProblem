using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    class LinkedListQueue
    {
        Node head = null;

        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into queue ", node.data);

        }
        public void Dequeue()
        {
            Console.WriteLine("{0} is dequeued from the queue", head.data);
            head = head.next;
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write("->" + temp.data);
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
