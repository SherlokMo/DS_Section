using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure_task.Queue
{
    class Dequeue
    {
        static void Main(string[] args)
        {
            /**
             * Intiating the Queue by creating an instance of it
             * Using System.Collections because we have the namespace of this directory as Queue
             */
            System.Collections.Queue q = new System.Collections.Queue();

            q.Enqueue(1); // Queue => {1}
            q.Enqueue(2); // Queue => {1, 2}
            q.Enqueue(3); // Queue => {1, 2, 3}
            q.Enqueue(4); // Queue => {1, 2, 3, 4}

            /**
             * Dequeue returns the top element and remove it from queue (First In)
             */
            q.Dequeue(); // Queue => {2, 3, 4} (retrun 1)
            q.Dequeue(); // Queue => {3, 4} (return 2)

            Console.Write("Queue after Dequeue() operation: ");
            foreach (int i in q)
            {
                Console.Write(i + " ");
            }

            // Output: Queue after Dequeue() operation: 3 4


        }
    }
}
