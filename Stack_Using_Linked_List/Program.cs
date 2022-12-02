using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList_CSharp
{
    class Node
    {
        public int info;
        public Node next;
        public Node(int i, Node n)
        {
            info = i;
            next = n;
        }
    }

    class Stacks
    {
        Node top;

        public Stacks()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void push(int element)
        {
            Node fresh;
            fresh = new Node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + " pushed.");

        }
        public void pop()
        {
            Console.WriteLine("\nThe popped element is: " + top.info);
            top = top.next;   //Make top point to the next node is sequence
        }

        public void display()
        {
            Node tmp;

            if (empty())  //If stack is empty
                Console.WriteLine("\nStack is empty");
            else
            {
                 //Traverse the list form beggining till end
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine();
            }

            static void Main(string[] args)
            {
                Stacks s = new Stacks();
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("\n***Stack Menu***\n");
                    Console.WriteLine("1. Push");
                    Console.WriteLine("2. Pop.");
                    Console.WriteLine("3. Display");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nEnter your choise: ");
                    string sInput = Console.ReadLine();
                    char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                    switch (ch)
                    {

                    }
                }
            }
        }
    }
}