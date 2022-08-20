namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/next-greater-element-i/
    /// </summary>
    /// <remarks>
    /// For each 0 <= i < nums1.length, find the index j such that nums1[i] == nums2[j] and determine the next greater element of nums2[j] in nums2.
    /// If there is no next greater element, then the answer for this query is -1.
    /// </remarks>
    public sealed class NextGreaterElement_I_496
    {
        /// <summary>
        /// The obvious way is to brute force. As usual - it's not enough to pass time limits and show good knowlegde to interviewers
        /// </summary>
        /// <param name="nums1"> Array, subset of nums2 </param>
        /// <param name="nums2"> Array </param>
        /// <returns> An array ans of length nums1.length such that ans[i] is the next greater element as described above </returns>
        /// <remarks>
        /// Time complexity: O(n^2)
        /// Space complexity: O(n)
        /// </remarks>
        public int[] NextGreaterElementBruteForce(int[] nums1, int[] nums2)
        {
            var result = Enumerable.Repeat(-1, nums1.Length).ToArray();
            for (var i = 0; i < nums1.Length; i++)
            {
                var currentNum = nums1[i];
                var startSearch = false;
                for (int j = 0; j < nums2.Length; j++)
                {
                    //// Find the current position of nums1 element in nums2
                    if (currentNum == nums2[j])
                    {
                        startSearch = true;
                    }
                    else if (startSearch && nums2[j] > currentNum)
                    {
                        //// And find next greater element. Straight solution
                        result[i] = nums2[j];
                        break;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// The best way to solve it accurate is to use Monotonic stack
        /// </summary>
        /// <param name="nums1"> Array, subset of nums2 </param>
        /// <param name="nums2"> Array </param>
        /// <returns> An array ans of length nums1.length such that ans[i] is the next greater element as described above </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n*m), for dictionary and result array
        /// </remarks>
        public int[] NextGreaterElementStack(int[] nums1, int[] nums2)
        {
            //// Parse all nums2 array and keep number and his next greater element in dictionary
            var dict = new Dictionary<int, int>();

            //// Use a stack to keep all decreasing sub-sequence until current number is greater than stack element
            var stack = new Stack<int>();
            for (var i = 0; i < nums2.Length; ++i)
            {
                //// Example. If we have [4,3,2,5], we have these values in the stack by steps:
                /// Step 1. [4]
                /// Step 2. [4, 3]
                /// Step 3. [4, 3, 2]
                /// Step 4. Empty stack, but dictionary with values [4-5, 3-5, 2-5]
                while (stack.Any() && stack.Peek() < nums2[i])
                {
                    var prevLessValue = stack.Pop();
                    dict.Add(prevLessValue, nums2[i]);
                }

                stack.Push(nums2[i]);
            }

            //// At this step we have greater elements for each nums2 number. So just go through subarray and get value in the dictionary.
            var result = new int[nums1.Length];
            for (var i = 0; i < nums1.Length; ++i)
            {
                result[i] = dict.ContainsKey(nums1[i]) ? dict[nums1[i]] : -1;
            }

            return result;
        }
    }
}
