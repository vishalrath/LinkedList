using System;

namespace Uc4_InsertBetweenLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n \nInsert the middle node 56 and70 between 30  opration");
            InsertLinkedList uc4list = new InsertLinkedList();
            uc4list.InsertFront(56);
            uc4list.InsertFront(70);
            uc4list.MidInsert(30);
            uc4list.Display();
        }
    }
}
