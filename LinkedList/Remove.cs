using System;
using System.Collections.Generic;

namespace Datastructure_task.LinkedList
{
    class Remove
    {
        static void Main(string[] args)
        {
            LinkedList<int> L = new LinkedList<int>();
            L.AddFirst(5); // {5}
            L.AddFirst(2); // {2,5}
            L.AddFirst(8); // {8,2,5}
            L.AddLast(4);  // {8,2,5,4}
            L.AddLast(9);  // {8,2,5,4,9}
            L.AddLast(1);  // {8,2,5,4,9,1}


            L.RemoveFirst(); // {2,5,4,9,1}
            L.RemoveLast(); // {2,5,4,9}
            Console.Write("Linked List after deletion: ");
            foreach (int i in L)
            {
                Console.Write(i + " ");
            }

        }
    }
}