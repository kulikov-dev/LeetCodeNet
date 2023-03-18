using System.Collections;
using LeetCodeNet.DataStructs;
using LeetCodeNet.Easy.Trees;

namespace LeetCodeNet.Tests.Easy.Trees
{
    public sealed class N_aryTreePreorderTraversal_589_test
    {
        [Theory, ClassData(typeof(N_aryTreePreorderTraversalTestData))]
        public void CheckRecursive(NaryTreeNode inputData, List<int> expected)
        {
            var solver = new N_aryTreePreorderTraversal_589();
            var result = solver.PreorderRecursive(inputData);

            Assert.True(expected.SequenceEqual(result));
        }

        [Theory, ClassData(typeof(N_aryTreePreorderTraversalTestData))]
        public void CheckIterative(NaryTreeNode inputData, List<int> expected)
        {
            var solver = new N_aryTreePreorderTraversal_589();
            var result = solver.PreorderIterative(inputData);

            Assert.True(expected.SequenceEqual(result));
        }
    }

    public sealed class N_aryTreePreorderTraversalTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NaryTreeNode(1, new List<NaryTreeNode>
                {
                    new(3)
                    {
                        children = new List<NaryTreeNode> {new(5), new(6)}
                    },
                    new(2),
                    new(4)}),
                new List<int> {1,3,5,6,2,4}
            };

            yield return new object[]
            {
                new NaryTreeNode(1, new List<NaryTreeNode>
                {
                    new(2),
                    new(3){children = new List<NaryTreeNode>()
                    {
                        new(6),
                        new(7){children = new List<NaryTreeNode>()
                        {
                            new(11){children = new List<NaryTreeNode>()
                            {
                                new(14)
                            }}
                        }}
                    }},
                    new(4) {children = new List<NaryTreeNode>()
                    {
                        new(8){children = new List<NaryTreeNode>()
                        {
                            new(12)
                        }}
                    }},
                    new(5){children = new List<NaryTreeNode>()
                    {
                        new(9){children = new List<NaryTreeNode>()
                        {
                            new(13)
                        }},
                        new(10)
                        }
                    }
                }),
                new List<int> { 1, 2, 3, 6, 7, 11, 14, 4, 8, 12, 5, 9, 13, 10 }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
