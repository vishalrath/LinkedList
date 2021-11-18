using System;

namespace UC3_ApendingLinkdList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("\n \nWelcome to the Linked list Apending  opration");
            ApendiLinkedList uc3list = new ApendiLinkedList();
            uc3list.InsertFront(70);
            // uc3list.InsertFront(30);
            uc3list.InsertFront(56);
            uc3list.Display();
            // uc3list.Append(56);
            uc3list.Append(30);
            //uc3list.Append(70);
            uc3list.Display();
        }
    }
}
