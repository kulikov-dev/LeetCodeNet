using LeetCodeNet.Medium.Array;
using System.Collections;

namespace LeetCodeNet.Tests.Medium.Array
{
    public sealed class ValidateStackSequences_946_test
    {
        [Theory, ClassData(typeof(ValidateStackSequencesTestData))]
        public void CheckStack(int[] inputData1, int[] inputData2, bool expected)
        {
            var solver = new ValidateStackSequences_946();

            Assert.Equal(expected, solver.ValidateStackSequencesStack(inputData1, inputData2));
        }

        [Theory, ClassData(typeof(ValidateStackSequencesTestData))]
        public void CheckArray(int[] inputData1, int[] inputData2, bool expected)
        {
            var solver = new ValidateStackSequences_946();

            Assert.Equal(expected, solver.ValidateStackSequencesArray(inputData1, inputData2));
        }
    }

    public sealed class ValidateStackSequencesTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: We might do the following sequence:
            /// push(1), push(2), push(3), push(4),
            /// pop()-> 4,
            /// push(5),
            /// pop()-> 5, pop()-> 3, pop()-> 2, pop()-> 1
            yield return new object[]
            {
                new[] { 1,2,3,4,5 },
                new[] { 4,5,3,2,1 },
                true
            };

            //// Explanation: 1 cannot be popped before 2.
            yield return new object[]
            {
                new[] { 1,2,3,4,5 },
                new[] { 4,3,5,1,2 },
                false
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
