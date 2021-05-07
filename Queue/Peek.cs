using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure_task.Queue
{
    class Peek
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
             * Peek method returns the top element (next element to be dqueued) without actually removing it.
             */
            Console.Write("Element at the beginning of the queue is: {0}", q.Peek());

            /**
             * Output: Element at the beginning of the queue is: 1
             */
        }


    }
}
