using System.Collections;
using LeetCodeNet.Easy.Array;

namespace LeetCodeNet.Tests.Easy.Array
{
    public sealed class CheckIfNandItsDoubleExist_1346_test
    {
        [Theory, ClassData(typeof(CheckIfNandItsDoubleExistTestData))]
        public void CheckHash(int[] inputData, bool expected)
        {
            var solver = new CheckIfNandItsDoubleExist_1346();

            Assert.Equal(expected, solver.CheckIfExistHash(inputData));
        }
    }

    public sealed class CheckIfNandItsDoubleExistTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new []{10,2,5,3},
                true
            };

            yield return new object[]
            {
                new []{ 3,1,7,11 },
                false
            };

            yield return new object[]
            {
                new []{ 7,1,14,11 },
                true
            };

            yield return new object[]
            {
                new []{ 4,-7,11,4,18 },
                false
            };

            yield return new object[]
            {
                new []{ 2,3,3,0,0 },
                true
            };

            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
