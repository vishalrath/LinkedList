using System;

namespace Uc2_AddLinkedList
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
            Console.WriteLine("\n \nWelcome to the Linked list InsertFront opration");
            InsertLinkedList uc2list = new InsertLinkedList();
            uc2list.InsertFront(70);
            uc2list.InsertFront(30);
            uc2list.InsertFront(56);
            uc2list.Display();

        }
    }
}
