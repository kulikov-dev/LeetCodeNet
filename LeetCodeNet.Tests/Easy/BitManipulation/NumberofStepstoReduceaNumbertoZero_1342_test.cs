using System.Collections;
using LeetCodeNet.Easy.BitManipulation;

namespace LeetCodeNet.Tests.Easy.BitManipulation
{
    public sealed class NumberofStepstoReduceaNumbertoZero_1342_test
    {
        [Theory, ClassData(typeof(NumberofStepstoReduceaNumbertoZeroTestData))]
        public void CheckMath(int inputData, int expected)
        {
            var solver = new NumberofStepstoReduceaNumbertoZero_1342();
            var result = solver.NumberOfStepsMath(inputData);
            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(NumberofStepstoReduceaNumbertoZeroTestData))]
        public void CheckBit(int inputData, int expected)
        {
            var solver = new NumberofStepstoReduceaNumbertoZero_1342();
            var result = solver.NumberOfStepsBit(inputData);
            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(NumberofStepstoReduceaNumbertoZeroTestData))]
        public void CheckBitOptimized(int inputData, int expected)
        {
            var solver = new NumberofStepstoReduceaNumbertoZero_1342();
            var result = solver.NumberOfStepsBitOptimized(inputData);
            Assert.Equal(expected, result);
        }
    }

    public sealed class NumberofStepstoReduceaNumbertoZeroTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: 
            /// Step 1) 14 is even; divide by 2 and obtain 7.
            /// Step 2) 7 is odd; subtract 1 and obtain 6.
            /// Step 3) 6 is even; divide by 2 and obtain 3.
            /// Step 4) 3 is odd; subtract 1 and obtain 2.
            /// Step 5) 2 is even; divide by 2 and obtain 1.
            /// Step 6) 1 is odd; subtract 1 and obtain 0.
            yield return new object[]
            {
                14,
                6
            };

            //// Explanation: 
            /// Step 1) 8 is even; divide by 2 and obtain 4.
            /// Step 2) 4 is even; divide by 2 and obtain 2.
            /// Step 3) 2 is even; divide by 2 and obtain 1.
            /// Step 4) 1 is odd; subtract 1 and obtain 0.
            yield return new object[]
            {
                8,
                4
            };

            yield return new object[]
            {
                123,
                12
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
