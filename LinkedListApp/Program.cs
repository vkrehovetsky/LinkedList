using System;

namespace LinkedListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------SinglyLinkedList-------------------------");
            SinglyLinkedList slist = new SinglyLinkedList();
            slist.Add("A");
            slist.Add("B");
            slist.Add("C");

            Console.WriteLine("List: " + slist);

            Console.Write("Finding an item in the list...\n");
            if (slist.Contains("B"))
                Console.WriteLine("Item exists!");
            else
                Console.WriteLine("Item does not exist!");

            Console.Write("Delete an item from the list...\n");
            Link deletedsLink = slist.Delete();

            Console.WriteLine("List: " + slist);

            Console.WriteLine("----------------------------DoublyLinkedList-------------------------");

            DoublyLinkedList dlist = new DoublyLinkedList();
            dlist.Add("A");
            dlist.Add("B");
            dlist.Add("C");

            Link linkD = dlist.Add("D");
            dlist.Add("E");
            Console.WriteLine("List: " + dlist);

            dlist.AddAfter(linkD, "D1");
            Console.WriteLine("List: " + dlist);

            if (dlist.Contains("D1"))
                Console.WriteLine("Item exists!");
            else
                Console.WriteLine("Item does not exist!");

            Console.Write("Delete an item from the list...\n");
            Link deleteddLink = dlist.Delete();

            Console.WriteLine("List: " + dlist);

            Console.Read();
        }
    }
}
