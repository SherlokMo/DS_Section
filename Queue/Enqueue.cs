using System;

namespace Datastructure_task.Queue
{
    class Enqueue
    {
        static void Main(string[] args)
        {

            /**
             * Intiating the Queue by creating an instance of it
             * Using System.Collections because we have the namespace of this directory as Queue
             */
            System.Collections.Queue q = new System.Collections.Queue();

            /**
             * Enqueue method is used to add an element to the queue (in the end)
             */
            q.Enqueue(1); // Queue => {1}
            q.Enqueue(2); // Queue => {1, 2}
            q.Enqueue(3); // Queue => {1, 2, 3}
            q.Enqueue(4); // Queue => {1, 2, 3, 4}

            Console.WriteLine("Queue elements are:");

            /**
             * Iterating over Queue elements
             */
            foreach (int i in q)
            {
                Console.Write(i + " ");
            }

            /**
             * Output : Queue elemnts are: 1 2 3 4
             */

        }
    }
}
