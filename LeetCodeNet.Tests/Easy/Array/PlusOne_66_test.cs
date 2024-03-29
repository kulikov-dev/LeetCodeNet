﻿using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class PlusOne_66_test
    {
        [Theory, ClassData(typeof(PlusOneTestData))]
        public void Check(int[] inputData, int[] expected)
        {
            var solver = new PlusOne_66();

            Assert.Equal(expected, solver.PlusOne(inputData));
        }
    }

    public sealed class PlusOneTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The array represents the integer 123. Incrementing by one gives 123 + 1 = 124.
            /// Thus, the result should be[1, 2, 4].
            yield return new object[]
            {
                new[] { 1, 2, 3 },
                new[] { 1, 2, 4 }
            };

            yield return new object[]
            {
                new[] { 4, 3, 2, 1 },
                new[] { 4, 3, 2, 2 }
            };

            yield return new object[]
            {
                new[] { 9 },
                new[] { 1, 0 }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
