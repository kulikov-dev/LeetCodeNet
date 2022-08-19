using System.Collections;
using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.Trees;

namespace LeetCodeNet.Tests.Easy.Trees
{
    public class PathSum_112_test
    {
        [Theory, ClassData(typeof(PathSumTestData))]
        public void CheckRecursive(TreeNode inputData1, int inputData2, bool expected)
        {
            var solver = new PathSum_112();
            var result = solver.HasPathSumRecursive(inputData1, inputData2);
            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(PathSumTestData))]
        public void CheckIterative(TreeNode inputData1, int inputData2, bool expected)
        {
            var solver = new PathSum_112();
            var result = solver.HasPathSumIterative(inputData1, inputData2);
            Assert.Equal(expected, result);
        }
    }

    public class PathSumTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new TreeNode(5, left: new TreeNode(4,left: new TreeNode(11,left: new TreeNode(7), right: new TreeNode(2))), right: new TreeNode(8,left:new TreeNode(13), right: new TreeNode(4,right: new TreeNode(1)))),
                22,
                true
            };

            yield return new object[]
            {
                new TreeNode(1, left: new TreeNode(2), right: new TreeNode(3)),
                5,
                false
            };

            yield return new object[]
            {
                null,
                0,
                false
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
