namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/validate-stack-sequences
    /// </summary>
    /// <remarks>
    /// Given two integer arrays pushed and popped each with distinct values, return true if this could have been the result of a sequence of push and pop operations on an initially empty stack, or false otherwise.
    /// </remarks>
    internal sealed class ValidateStackSequences_946
    {
        /// <summary>
        /// The problem can be solved by simulating all push and pop operations on the actual stack.
        /// We create the stack to store all values from the pushed array, as well as the pointer for the popped array.
        /// We will increase the pointer each time the 'stack.Peek' will equal the current element in the popped array.
        /// </summary>
        /// <param name="pushed"> Pushed operations array </param>
        /// <param name="popped"> Popped operations array </param>
        /// <returns> True, is stack is valid </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public bool ValidateStackSequencesStack(int[] pushed, int[] popped)
        {
            var stack = new Stack<int>();
            var poppedIndex = 0;

            for (var i = 0; i < pushed.Length; ++i)
            {
                stack.Push(pushed[i]);
                while (stack.Count > 0 && stack.Peek() == popped[poppedIndex])
                {
                    stack.Pop();
                    ++poppedIndex;
                }
            }

            return stack.Count == 0;
        }

        /// <summary>
        /// We can reduce the space complexity by replacing stack with two pointers approach
        /// Where the first pointer is for pushed elements and the second one for popped elements
        /// Note, that here we do it in-place, which is not a good practice,
        /// to modify input parameters.
        /// </summary>
        /// <param name="pushed"> Pushed operations array </param>
        /// <param name="popped"> Popped operations array </param>
        /// <returns> True, is stack is valid </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </remarks>
        public bool ValidateStackSequencesArray(int[] pushed, int[] popped)
        {
            var pushedIndex = -1;
            var poppedIndex = 0;

            for (var i = 0; i < pushed.Length; ++i)
            {
                ++pushedIndex;

                pushed[pushedIndex] = pushed[i];

                while (pushedIndex >= 0 && pushed[pushedIndex] == popped[poppedIndex])
                {
                    --pushedIndex;
                    ++poppedIndex;
                }
            }

            return pushedIndex < 0;
        }
    }
}
