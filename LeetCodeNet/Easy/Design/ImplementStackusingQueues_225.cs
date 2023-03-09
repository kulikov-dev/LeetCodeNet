namespace LeetCodeNet.Easy.Design
{
    /// <summary>
    /// https://leetcode.com/problems/implement-stack-using-queues/
    /// </summary>
    /// <remarks> Implement a last-in-first-out (LIFO) stack using only two queues. The implemented stack should support all the functions of a normal stack (push, top, pop, and empty). </remarks>
    public sealed class MyStack
    {
        /// <summary>
        /// Queue
        /// </summary>
        private readonly Queue<int> _queue = new Queue<int>();

        /// <summary>
        /// Top value in the stack
        /// </summary>
        private int? _top;

        /// <summary>
        /// For better optimization - each time we save last value (in case, if next will few top operations)
        /// </summary>
        /// <param name="x"> Value</param>
        public void Push(int x)
        {
            _top = x;

            _queue.Enqueue(x);
        }

        /// <summary>
        /// For pop operations we go through the queue and save the value
        /// The last item in the queue - is the first in the stack which we need to return
        /// </summary>
        /// <returns> Value </returns>
        public int Pop()
        {
            var length = _queue.Count;

            for (var i = 0; i < length - 1; i++)
            {
                _top = _queue.Dequeue();

                _queue.Enqueue(_top.Value);
            }

            return _queue.Dequeue();
        }

        /// <summary>
        /// Get last value in stack
        /// </summary>
        /// <returns> Last value </returns>
        public int Top()
        {
            return _top ?? -1;
        }

        /// <summary>
        /// Check if empty
        /// </summary>
        /// <returns> True if empty </returns>
        public bool Empty()
        {
            return _queue.Count == 0;
        }
    }
}
