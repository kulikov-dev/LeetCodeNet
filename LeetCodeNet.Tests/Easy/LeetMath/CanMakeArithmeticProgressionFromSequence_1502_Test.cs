﻿using System.Collections;
using LeetCodeNet.Easy.LeetMath;

namespace LeetCodeNet.Tests.Easy.LeetMath
{
    public sealed class CanMakeArithmeticProgressionFromSequence_1502_Test
    {
        [Theory, ClassData(typeof(CanMakeArithmeticProgressionFromSequenceTestData))]
        public void CheckSimple(int[] inputData, bool expected)
        {
            var solver = new CanMakeArithmeticProgressionFromSequence_1502();
            var result = solver.CanMakeArithmeticProgressionSimple(inputData);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(CanMakeArithmeticProgressionFromSequenceTestData))]
        public void CheckMath(int[] inputData, bool expected)
        {
            var solver = new CanMakeArithmeticProgressionFromSequence_1502();
            var result = solver.CanMakeArithmeticProgressionMath(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class CanMakeArithmeticProgressionFromSequenceTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: We can reorder the elements as [1,3,5] or [5,3,1] with differences 2 and -2 respectively, between each consecutive elements.
            yield return new object[]
            {
                new []{3,5,1},
                true
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
