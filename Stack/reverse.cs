using System;

namespace Datastructure_task.Stack
{
    class reverse
    {
        static void Main(string[] args)
        {
            /**
            * Intiating the stack by creating an instance of it
            * Using System.Collections because we have the namespace of this directory as Stack
            */
            System.Collections.Stack currentStack = new System.Collections.Stack();
            System.Collections.Stack revStack = new System.Collections.Stack();
            
            /**
             * Pushing elements to the stack
             */
            currentStack.Push('A');
            currentStack.Push('B');
            currentStack.Push('C');
            currentStack.Push('D');
            currentStack.Push('E');
            currentStack.Push('F');

            /**
             * Using while statement to iterate over stack elements
             * Every iteration we pop an element from the currentStack  (returns value and removes it)
             * and pushing the returned value from pop while decreasing the stack count by 1
             * since we're pushing to the top then the upper element of current stack will be the lower element of the reversed
             */
            while (currentStack.Count != 0)
            {
                revStack.Push(currentStack.Pop()); // returns (n) and pushing that (n) to the revStack 
            }

            Console.WriteLine("Reversed stack... ");
            foreach (char cH in revStack)
            {
                Console.WriteLine(cH);
            }

            /**
             * Output is: Reversed stack... 
             * A
             * B
             * C
             * D
             * E
             * F
             */

        }

    }
}
