namespace LeetCodeNet.Easy.Design
{
    /// <summary>
    /// https://leetcode.com/problems/min-stack/
    /// </summary>
    /// <remarks> Design a stack that supports push, pop, top, and retrieving the minimum element in constant time. </remarks>
    public sealed class MinStack
    {
        /// <summary>
        /// We need to use just one stack, but this stack contains value itself as well as minimum value from all previous values
        /// </summary>
        private readonly Stack<StackNode> _stack = new();

        /// <summary>
        /// Constructor
        /// </summary>
        public MinStack()
        {

        }

        /// <summary>
        /// Push operation
        /// </summary>
        /// <param name="val"> Value </param>
        public void Push(int val)
        {
            //// So, before adding the new value, we will check - is it the minimum value from all previous values? If no - use the previous minimum
            var prevValue = _stack.Count == 0 ? val : _stack.Peek().StackMinValue;

            _stack.Push(new StackNode(val, Math.Min(prevValue, val)));
        }

        /// <summary>
        /// Pop operation
        /// </summary>
        public void Pop()
        {
            _stack.Pop();
        }

        /// <summary>
        /// Top operation
        /// </summary>
        /// <returns> Top value </returns>
        public int Top()
        {
            return _stack.Peek().Value;
        }

        /// <summary>
        /// Get minimum operation for the current stack
        /// </summary>
        /// <returns> Minimum value </returns>
        public int GetMin()
        {
            //// And our last value in stack now contains the minimum from all previous values in stack
            return _stack.Peek().StackMinValue;
        }

        /// <summary>
        /// Struct to store information
        /// </summary>
        private struct StackNode
        {
            /// <summary>
            /// Current value in the stack
            /// </summary>
            public int Value;

            /// <summary>
            /// Minimum for previous values
            /// </summary>
            public int StackMinValue;

            /// <summary>
            /// Constructor
            /// </summary>
            public StackNode(int value, int stackMinValue)
            {
                StackMinValue = stackMinValue;
                Value = value;
            }
        }
    }
}
