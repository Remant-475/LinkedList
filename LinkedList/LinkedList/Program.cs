using System;

namespace LinkedList
{
    class Program
    {
        public static void Main(string[]args)
        {
            Linkedlist linkedlist = new Linkedlist();
            Node node1 = new Node(23);
            Node node2 = new Node(24);
            Node node3 = new Node(25);

            linkedlist.AddNode(node1);
            linkedlist.AddNode(node2);
            linkedlist.AddNode(node3);

            linkedlist.Display();
            Node node4 = new Node(25);
            linkedlist.AppendNode(node4);
            linkedlist.Display();

            Node node5 = new Node(29);
            linkedlist.AddNodeatStart(node5);
            linkedlist.Display();
            
            linkedlist.DeleteNodeatFirst();
            linkedlist.Display();
            
            linkedlist.DeleteEndNode();
            linkedlist.Display();
            Console.WriteLine("Enter Number want to Search");
            
            int data = int.Parse(Console.ReadLine());
            bool res = linkedlist.search(data);
            if (res == true)
            {
                Console.WriteLine("Data is found");
            }
            else
            {
                Console.WriteLine("Data is not found");
            }
        }
    }
}

