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
            linkedList.AddAtBack(70);
            linkedList.InsertAtParticularPosition(2, 30);
            linkedList.InsertAfterElement(30,77);
            linkedList.Display();

        }
    }
}
