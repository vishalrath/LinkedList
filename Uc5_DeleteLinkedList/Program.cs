using System;

namespace Uc5_DeleteLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n \nDelete first Node  opration");
            DeletLinkedList uc5list = new DeletLinkedList();
            uc5list.InserLast(56);
            uc5list.InserLast(30);
            uc5list.InserLast(70);
            uc5list.Display();
            Console.WriteLine(" \nDeleted first node valus is:" + uc5list.DeleteFirstNode());
            uc5list.DeleteFirstNode();
        }
    }
}
