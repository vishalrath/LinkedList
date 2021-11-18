using System;

namespace Uc10_OrderedLinkedLIst
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedLinked list = new OrderedLinked();               //created the list object of the SortedLinkedList class
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            list.Display();
            Console.WriteLine();
            list.Sort();
            list.Display();

        }
    }
}
