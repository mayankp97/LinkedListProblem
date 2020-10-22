using System;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Problem");
            
            var linkedList = new LinkedList();
            linkedList.AddAtBack(56);
            linkedList.AddAtBack(30);
            linkedList.AddAtBack(70);
            linkedList.Display();

        }
    }
}
