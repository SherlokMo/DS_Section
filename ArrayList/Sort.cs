using System;
using System.Collections;

namespace Datastructure_task.ArrayList
{
    class Sort
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList arr = new System.Collections.ArrayList();
            arr.Add(5);
            arr.Add(1);
            arr.Add(9);
            arr.Add(6);
            arr.Add(2);
            arr.Add(8);
            arr.Add(3);
            arr.Add(7);

            arr.Sort();
            Console.Write("Sorted ArrayList elements: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }


        }
    }
}