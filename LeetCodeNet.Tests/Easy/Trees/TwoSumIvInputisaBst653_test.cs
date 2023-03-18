using System.Collections;
using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.Trees;

namespace LeetCodeNet.Tests.Easy.Trees
{
    public sealed class TwoSumIvInputisaBst653_test
    {
        [Theory, ClassData(typeof(TwoSumIV_InputisaBSTTestData))]
        public void CheckBFS(TreeNode inputData1, int inputData2, bool expected)
        {
            var solver = new TwoSumIVInputisaBST_653();
            var result = solver.FindTargetBFS(inputData1, inputData2);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(TwoSumIV_InputisaBSTTestData))]
        public void CheckTwoPointers(TreeNode inputData1, int inputData2, bool expected)
        {
            var solver = new TwoSumIVInputisaBST_653();
            var result = solver.FindTargetPointers(inputData1, inputData2);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(TwoSumIV_InputisaBSTTestData))]
        public void CheckBinarySearch(TreeNode inputData1, int inputData2, bool expected)
        {
            var solver = new TwoSumIVInputisaBST_653();
            var result = solver.FindTargetBinarySearch(inputData1, inputData2);

            Assert.Equal(expected, result);
        }
    }

    public sealed class TwoSumIV_InputisaBSTTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new TreeNode(5, left: new TreeNode(3, left: new TreeNode(2), right: new TreeNode(4)), right: new TreeNode(6, right: new TreeNode(7))),
                9,
                true
            };

            yield return new object[]
            {
                new TreeNode(5, left: new TreeNode(3, left: new TreeNode(2), right: new TreeNode(4)), right: new TreeNode(6, right: new TreeNode(7))),
                28,
                false
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
