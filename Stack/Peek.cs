using System;

namespace Datastructure_task.Stack
{
    class Peek
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
             * Peek method is used to return the top element on the stack without actually removing it. 
             * otherwise pop that returns the top element and removes it.
             */
            int topElement = (int)st.Peek();

            Console.WriteLine("Element at top is {0}", topElement);

            /**
             * Output: Element at top is 4
             */
        }
    }
}
