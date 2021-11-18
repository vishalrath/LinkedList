using System;

namespace Uc7_SearchLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n \nSearch  Node  opration");
            SearchLinked uc7list = new SearchLinked();
            uc7list.InserLast(56);
            uc7list.InserLast(30);
            uc7list.InserLast(70);
            uc7list.Display();
            Console.WriteLine(" \nSearch  node valus is:" + uc7list.search(30));
            uc7list.Display();
        }
    }
}
