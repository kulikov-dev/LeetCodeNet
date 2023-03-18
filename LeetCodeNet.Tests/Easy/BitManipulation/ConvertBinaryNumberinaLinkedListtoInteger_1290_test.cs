using System.Collections;
using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.LeetMath;

namespace LeetCodeNet.Tests.Easy.BitManipulation
{
    public sealed class ConvertBinaryNumberinaLinkedListtoInteger_1290_test
    {
        [Theory, ClassData(typeof(ConvertBinaryNumberinaLinkedListtoIntegerTestData))]
        public void CheckShift(ListNode inputData, int expected)
        {
            var solver = new ConvertBinaryNumberinaLinkedListtoInteger_1290();
            var result = solver.GetDecimalValueSimple(inputData);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(ConvertBinaryNumberinaLinkedListtoIntegerTestData))]
        public void CheckBit(ListNode inputData, int expected)
        {
            var solver = new ConvertBinaryNumberinaLinkedListtoInteger_1290();
            var result = solver.GetDecimalValueBinary(inputData);

            Assert.Equal(expected, result);
        }
    }

    public sealed class ConvertBinaryNumberinaLinkedListtoIntegerTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// (101) in base 2 = (5) in base 10
            yield return new object[]
            {
                new ListNode(1) {next = new ListNode(0) { next = new ListNode(1)}},
                5
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}