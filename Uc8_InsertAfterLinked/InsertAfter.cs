﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc8_InsertAfterLinked
{
    class InsertAfter
    {
        public Node head;   //defining the head possition of link list
        public void Add(int deta)  // create add method in this class
        {
            Node node = new Node(deta);    // defining and creating object of node class and push the data of node class
            if (this.head == null)
            {
                this.head = node;          // is null then push the node deta that have add into the head
            }
            else
            {
                Node temp = head;             // creating temp veriable of node
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("inserted into the link list:{0}", node.data);
        }
        public void AddAfter(int data) //insert between two node
        {
            Node previousnode = new Node(data);
            previousnode = this.head;
            if (previousnode.next.next == null)
            {
                Console.WriteLine(" previous node is null");
                return;
            }
            Node newNode = new Node(data);          //creade a obj of Node newNode Address the memory And data
            newNode.next = previousnode.next.next;  // previous node to next to is assign after next node
            previousnode.next.next = newNode;      // previous.next.next is assign value of new node

        }
        public void Display()  //display the data in linked list
        {
            Console.WriteLine("Display Nodes");
            Node temp = this.head;               // initializethe temp veriable in the node class
            if (temp == null)                  // checking linklist empty or not
            {
                Console.Write("Linked list is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + "");
                    temp = temp.next;
                }
            }
        }
    }
}
