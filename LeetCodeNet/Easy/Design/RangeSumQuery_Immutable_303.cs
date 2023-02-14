using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeNet.Easy.Design
{
    /// <summary>
    /// https://leetcode.com/problems/range-sum-query-immutable/
    /// </summary>
    /// <remarks>
    /// Given an integer array nums, handle multiple queries of the following type:
    /// Calculate the sum of the elements of nums between indices left and right inclusive where left <= right.
    /// </remarks>
    public sealed class NumArray
    {
        private int[] sumNums;

        public NumArray(int[] nums)
        {
            if (nums.Length == 0)
            {
                return;
            }

            sumNums = new int[nums.Length];

            var sum = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                sumNums[i] = sum;
            }
        }

        public int SumRange(int left, int right)
        {
            if (left == 0)
            {
                return sumNums[right];
            }

            return sumNums[right] - sumNums[left - 1];
        }
    }
}
