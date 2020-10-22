using System;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Problem");

            var sortedList = new SortedLinkedList();
            sortedList.Add(56);
            sortedList.Add(30);
            sortedList.Add(40);
            sortedList.Add(70);
            sortedList.Add(587);
            sortedList.Display();


        }
    }
}
