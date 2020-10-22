using System;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedListDemo();
            StackDemo();

        }

        public static void LinkedListDemo()
        {
            Console.WriteLine("Welcome to Linked List Implementation");

            var sortedList = new SortedLinkedList();
            sortedList.Add(56);
            sortedList.Add(30);
            sortedList.Add(40);
            sortedList.Add(70);
            sortedList.Add(587);
            sortedList.Display();
        }
        public static void StackDemo()
        {
            Console.WriteLine("Welcome to Stack Implementation!");

            var linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
        }
    }
}
