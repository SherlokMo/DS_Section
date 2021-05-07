using System;

namespace Datastructure_task.Stack
{
    class pop
    {

        static void Main(string[] args)
        {
            /**
            * Intiating the stack by creating an instance of it
            * Using System.Collections because we have the namespace of this directory as Stack
            */
            System.Collections.Stack st = new System.Collections.Stack();

            st.Push(1); // Stack => {1}
            st.Push(2); // Stack => {2,1}
            st.Push(3); // Stack => {3,2,1}
            st.Push(4); // Stack => {4,3,2,1}

            /**
             * using Pop method to remove the top of the stack 
             */

            st.Pop(); // Stack => {3, 2, 1}
            st.Pop(); // Stack => {2, 1}

            Console.WriteLine("Stack after Pop() operation: ");
            foreach (int i in st)
            {
                Console.WriteLine(i);
            }

            /**
            * Output is: Stack after Pop() operation: 2 1 
            */

        }



    }
}
