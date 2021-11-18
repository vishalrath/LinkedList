using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc10_OrderedLinkedLIst
{
    class OrderedLinked
    {
        internal Node head;

        internal void Add(int data)        //the add method of sorted linked list class
        {
            Node node = new Node(data);    //creating a node object of the Node class 
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        internal void Display()          //the display method
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        internal void Sort()                 //the sort method to sort the list entries
        {
            Node current = head;             //declaring the current node and asssigning it to head
            Node index = null;               //declaring an index node that will always take the next value to that of the current node
            int temp = 0;                    // just a temporary variable to store the data
            if (this.head == null)
            {
                Console.WriteLine("The list is empty!");
            }

            else
            {
                while (current != null)                   //till the current node isnt the last
                {
                    index = current.next;
                    while (index != null)
                    {
                        if (current.data > index.data)          //taking the comparision between the current data and the next node's data
                        {
                            temp = index.data;
                            index.data = current.data;
                            current.data = temp;
                        }
                        index = index.next;
                    }

                    current = current.next;
                }
            }

        }
    }
}
