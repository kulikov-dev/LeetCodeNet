using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Easy.Trees
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum-iv-input-is-a-bst/
    /// </summary>
    /// <remarks> Given the node of a Binary Search Tree and a target number k, return true if there exist two elements in the BST such that their sum is equal to the given target. </remarks>
    internal sealed class TwoSumIVInputisaBST_653
    {
        /// <summary>
        /// Use BFS approach to go through each element and store it's values in a hashtable. Not very effective approach
        /// </summary>
        /// <param name="root"> Root </param>
        /// <param name="k"> Desired sum </param>
        /// <returns> Flag if has sum </returns>
        /// <remarks>
        /// Time complexity: O(n), to go through a whole tree
        /// Space complexity: O(n), to store a queue
        /// </remarks>
        public bool FindTargetBFS(TreeNode root, int k)
        {
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            //// The idea is to use a hashtable to keep visited node values
            var hashset = new HashSet<int>();

            while (queue.Any())
            {
                var node = queue.Dequeue();

                if (node == null)
                {
                    continue;
                }

                //// If we already have diff value - than it's our result
                if (hashset.Contains(k - node.val))
                {
                    return true;
                }

                //// Add current node to a hashtable
                hashset.Add(node.val);
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }

            return false;
        }

        /// <summary>
        /// Binary tree with inorder traversal + two pointers approach
        /// </summary>
        /// <param name="root"> Root </param>
        /// <param name="k"> Desired sum </param>
        /// <returns> Flag if has sum </returns>
        /// <remarks>
        /// Time complexity: O(n), to go through a whole array in a bad case
        /// Space complexity: O(n), to store a sorted array
        /// </remarks>
        public bool FindTargetPointers(TreeNode root, int k)
        {
            //// Use the condition that we have a binary tree, so we can convert it to a sorted array
            var array = new List<int>();

            //// The best way to do it: inorder traversal
            /// We also can use two stacks (left and right) without convertint to an array
            InorderTraversal(root, ref array);

            //// Then we use two pointers approach which begins from the start and end of the array to find if there is a sum of K.
            var leftPointer = 0;
            var rightPointer = array.Count - 1;

            while (leftPointer < rightPointer)
            {
                if (array[leftPointer] + array[rightPointer] == k)
                {
                    return true;
                }

                if (array[leftPointer] + array[rightPointer] < k)
                {
                    ++leftPointer;
                }
                else
                {
                    --rightPointer;
                }
            }

            return false;
        }

        /// <summary>
        /// Helper void to do in-order traversal through the tree
        /// </summary>
        /// <param name="node"> Node </param>
        /// <param name="array"> Sorted array</param>
        private void InorderTraversal(TreeNode? node, ref List<int> array)
        {
            if (node == null)
            {
                return;
            }

            InorderTraversal(node.left, ref array);

            array.Add(node.val);

            InorderTraversal(node.right, ref array);
        }

        /// <summary>
        /// Variable for the binary search method
        /// </summary>
        private TreeNode? _root;

        //DFS each node, and try to SearchInBinaryTree the target 'node' such that 'node'.val = k-node.val
        //make sure you don't pick the node itself, like if k = 2 and node.val = 1, don't return node itself!

        /// <summary>
        /// The idea is to use binary search method with recursive DFS.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        /// <remarks>
        /// Time complexity: O(nh)
        /// Space complexity: O(h), where h is a height of a tree
        /// </remarks>
        public bool FindTargetBinarySearch(TreeNode node, int k)
        {
            if (_root == null)
            {
                //// Initialize a root
                _root = node;
            }

            if (node == null)
            {
                return false;

            }

            //// Try to find desired value with DFS
            if (SearchInBinaryTree(node, k - node.val))
            {
                return true;
            }

            //// If not found = recursively try to find another variants deeper in a tree
            return FindTargetBinarySearch(node.left, k) || FindTargetBinarySearch(node.right, k);
        }

        /// <summary>
        /// Support void to make binary search in a tree
        /// </summary>
        /// <param name="node"> Node </param>
        /// <param name="k"> Desired value </param>
        /// <returns> Flag if contains </returns>
        public bool SearchInBinaryTree(TreeNode node, int k)
        {
            var current = _root;

            while (current != null)
            {
                if (k > current.val)
                {
                    current = current.right;
                }
                else if (k < current.val)
                {
                    current = current.left;
                }
                else
                {
                    //// The trick case - we can't return the same node (!)
                    return current != node;
                }
            }
            return false;
        }
    }
}