﻿using LeetCodeNet.Easy.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class RemoveDuplicatesFromSortedArray_26_test
    {
        [Theory, ClassData(typeof(RemoveDuplicatesFromSortedArrayTestData))]
        public void Check(int[] inputData, int expectedCount, int[] expectedArray)
        {
            var solver = new RemoveDuplicatesFromSortedArray_26();
            var result = solver.RemoveDuplicates(inputData);

            Assert.Equal(expectedCount, result);
            Assert.Equal(expectedArray, inputData);
        }
    }

    public sealed class RemoveDuplicatesFromSortedArrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] { 1, 1, 2 },
                2,
                new[] { 1, 2, -101 }
            };

            yield return new object[]
            {
                new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 },
                5,
                new[] { 0, 1, 2, 3, 4, -101, -101, -101, -101, -101 }
            };
            
            yield return new object[]
            {
                new[] { 1 },
                1,
                new[] { 1 }
            };

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
