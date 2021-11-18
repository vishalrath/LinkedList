using System;

namespace Uc1_InsertLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Linked list opration");
            InsertLinkedList list = new InsertLinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
        }
    }
}
