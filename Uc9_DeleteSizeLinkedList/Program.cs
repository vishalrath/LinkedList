using System;

namespace Uc9_DeleteSizeLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n \nSpecific delete  Node  opration");
            DeleteSizeLinked uc9list = new DeleteSizeLinked();
            uc9list.Add(56);
            uc9list.Add(30);
            uc9list.Add(70);
            uc9list.AddAfter(40);
            uc9list.Display();
            uc9list.DeleteNode(40);
            uc9list.Display();
            Console.ReadLine();

        }
    }
}
