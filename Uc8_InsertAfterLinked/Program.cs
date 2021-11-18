using System;

namespace Uc8_InsertAfterLinked
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n \nAddAfter  Node  opration");
            InsertAfter uc8add = new InsertAfter();
            uc8add.Add(56);
            uc8add.Add(30);
            uc8add.Add(70);
            uc8add.Display();
            uc8add.AddAfter(40);
            uc8add.Display();
        }
    }
}
