using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.Trees;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeNet.Tests.Easy.Trees
{
    public class MergeTwoBinaryTrees_617_test
    {
        [Theory, ClassData(typeof(MergeTwoBinaryTreesTestData))]
        public void CheckRecursive(TreeNode inputData1, TreeNode inputData2, TreeNode expected)
        {
            var solver = new MergeTwoBinaryTrees_617();
            var result = solver.MergeTreesRecursive(inputData1, inputData2);
            Assert.True(expected.Equals(result));
        }
    }

    public class MergeTwoBinaryTreesTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new TreeNode(1, left: new TreeNode(3, left: new TreeNode(5)), right: new TreeNode(2)),
                new TreeNode(2, left: new TreeNode(1, right: new TreeNode(4)), right: new TreeNode(3, right: new TreeNode(7))),
                new TreeNode(3, left: new TreeNode(4, left: new TreeNode(5), new TreeNode(4)), right: new TreeNode(5, right: new TreeNode(7)))
            };

            yield return new object[]
            {
                new TreeNode(1),
                new TreeNode(1, left:new TreeNode(2)),
                new TreeNode(2, left: new TreeNode(2))
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
