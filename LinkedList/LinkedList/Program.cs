using System;

namespace LinkedList
{
    class Program
    {
        static void Main()
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
        }
    }
}

