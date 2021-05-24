using System;
using System.Collections.Generic;

namespace Datastructure_task.LinkedList
{
    class Search
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(4); // {4}
            list.AddLast(9); // {4,9}
            list.AddLast(1); // {4,9,1}
            list.AddLast(3); // {4,9,1,3}
            list.AddLast(6); // {4,9,1,3,6}
            list.AddLast(2); // {4,9,1,3,6,2}

            Console.WriteLine("The value 3 is present in Linked List: " + list.Contains(3)); // true
            Console.WriteLine("The value 5 is present in Linked List: " + list.Contains(5)); // false

        }
    }
}