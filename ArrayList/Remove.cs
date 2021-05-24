using System;
using System.Collections;

namespace Datastructure_task.ArrayList
{
    class Remove
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

            arr.Remove(1);
            arr.Remove(8);
            arr.Remove(5);
            Console.WriteLine();
            Console.Write("ArrayList elements after deletion: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

        }
    }
}