namespace LeetCodeNet.Easy.Design
{
    /// <summary>
    /// https://leetcode.com/problems/implement-queue-using-stacks/description/
    /// </summary>
    /// <remarks>
    /// Implement a first in first out (FIFO) queue using only two stacks. The implemented queue should support all the functions of a normal queue (push, peek, pop, and empty).
    /// </remarks>
    internal sealed class MyQueue
    {
        /// <summary>
        /// Parameter-less constructor
        /// </summary>
        public MyQueue()
        {
            inputStack = new Stack<int>();
            queueStack = new Stack<int>();
        }

        /// <summary>
        /// The idea is to use first stack only for all Push operations
        /// </summary>
        private Stack<int> inputStack { get; }
        /// <summary>
        /// The second stack is necessary to upload all data from input stack, so it reverses order and will represent an queue order
        /// </summary>
        private Stack<int> queueStack { get; }

        /// <summary>
        /// For push operations - just add to input stack
        /// </summary>
        /// <param name="x"> Input value </param>
        public void Push(int x)
        {
            inputStack.Push(x);
        }

        /// <summary>
        /// For pop operations - we try to recreate queue from input stack (if necessary)
        /// </summary>
        /// <returns> Queue value </returns>
        public int Pop()
        {
            Recreate();
            return queueStack.Pop();
        }

        /// <summary>
        /// Same for peek operations
        /// </summary>
        /// <returns> Queue peek value </returns>
        public int Peek()
        {
            Recreate();
            return queueStack.Peek();
        }

        /// <summary>
        /// Check if the queue is empty
        /// </summary>
        /// <returns> True, if empty </returns>
        public bool Empty()
        {
            return inputStack.Count == 0 && queueStack.Count == 0;
        }

        /// <summary>
        /// The key void for this solution. If we don't have any values in our queue stack - reverse value by moving values from one stack to another
        /// </summary>
        /// <remarks> So, 1-2-3 in first stack will convert to 3-2-1. And this stack will return values in queue order. </remarks>
        private void Recreate()
        {
            if (queueStack.Count > 0)
            {
                return;
            }

            while (inputStack.Count > 0)
            {
                queueStack.Push(inputStack.Pop());
            }
        }
    }
}
