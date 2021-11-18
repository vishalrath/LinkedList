using System;

namespace Uc6_DeletLastLink
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n \nDelete Last Node  opration");
            DeleteLastLink uc6list = new DeleteLastLink();
            uc6list.InserLast(56);
            uc6list.InserLast(30);
            uc6list.InserLast(70);
            uc6list.Display();
            Console.WriteLine(" \nDeleted Last node valus is:" + uc6list.DeleteLastNode());
            uc6list.Display();
        }
    }
}
