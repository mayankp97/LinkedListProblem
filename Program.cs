using System;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Problem");
            
            var linkedList = new LinkedList();
            linkedList.AddAtFront(70);
            linkedList.AddAtFront(30);
            linkedList.AddAtFront(56);
            linkedList.Display();

        }
    }
}
