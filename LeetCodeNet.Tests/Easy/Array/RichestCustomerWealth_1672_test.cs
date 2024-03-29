﻿using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class RichestCustomerWealth_1672_test
    {
        [Theory, ClassData(typeof(RichestCustomerWealthTestData))]
        public void CheckLinq(int[][] inputMatrix, int expected)
        {
            var solver = new RichestCustomerWealth_1672();

            Assert.Equal(expected, solver.MaximumWealthLinq(inputMatrix));
        }

        [Theory, ClassData(typeof(RichestCustomerWealthTestData))]
        public void CheckPass(int[][] inputMatrix, int expected)
        {
            var solver = new RichestCustomerWealth_1672();

            Assert.Equal(expected, solver.MaximumWealthPass(inputMatrix));
        }
    }

    public sealed class RichestCustomerWealthTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation:
            /// 1st customer has wealth = 1 + 2 + 3 = 6
            /// 2nd customer has wealth = 3 + 2 + 1 = 6
            /// Both customers are considered the richest with a wealth of 6 each, so return 6.
            yield return new object[]
            {
                new[] { new[] { 1, 2, 3 }, new[] { 3, 2, 1 } },
                6
            };

            yield return new object[]
            {
                new[] { new[] { 1, 5 }, new[] { 7, 3 }, new[] { 3, 5 } },
                10
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}