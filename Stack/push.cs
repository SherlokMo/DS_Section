using System;
namespace Datastructure_task.Stack
{
    class push
    {
        static void Main(string[] args)
        {

            /**
             * Intiating the stack by creating an instance of it
             * Using System.Collections because we have the namespace of this directory as Stack
             */
            System.Collections.Stack st = new System.Collections.Stack();

            /*
             * using Push method to push the element on top of the stack
             * pushing 1 to the top of the stack
             */
            st.Push(1); // Stack => {1}

            // pushing 2 to the top of the stack
            st.Push(2); // Stack => {2,1}

            // pushing 3 to the top of the stack
            st.Push(3); // Stack => {3,2,1}

            // pushing 4 to the top of the stack
            st.Push(4); // Stack => {4,3,2,1}

            Console.WriteLine("Stack Elements are: ");
            foreach (int i in st)
            {
                Console.WriteLine(i);
            }

            /**
             * Output is: Stack Elements are: 4 3 2 1 
             */
        }
    }
}
