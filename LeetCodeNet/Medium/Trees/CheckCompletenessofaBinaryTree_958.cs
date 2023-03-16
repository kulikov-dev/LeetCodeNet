using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Medium.Trees
{
    public sealed class CheckCompletenessofaBinaryTree_958
    {
        /// <summary>
        /// Use queue to perform BFS. We need to go through levels of the tree. It should have these rules:
        /// 1. Can have null nodes only on the last level
        /// 2. Shouldn't have any values on the level after any null node on the level
        /// </summary>
        /// <param name="root"> Root </param>
        /// <returns> True if tree is complete tree </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(N)
        /// </remarks>
        public bool IsCompleteTreeFirstAttempt(TreeNode root)
        {
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);
            var hasNullOnPrevLevel = false;

            while (queue.Count > 0)
            {
                var count = queue.Count;
                var hasNull = false;
                var hasAny = false;

                while (count != 0)
                {
                    var node = queue.Dequeue();

                    if (node == null)
                    {
                        hasNull = true;

                        queue.Enqueue(null);            // add fake nodes to check that all nodes are as far left as possible on the next level. 
                        queue.Enqueue(null);

                        --count;
                        continue;
                    }

                    if (hasNull)            // Second rule: situation when not all nodes are as far left as possible.
                    {
                        return false;
                    }

                    hasAny = true;

                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);

                    --count;
                }

                if (!hasAny)
                {
                    return true;
                }

                if (hasAny && hasNullOnPrevLevel)       // First rule.
                {
                    return false;
                }

                hasNullOnPrevLevel = hasNull;
            }

            return true;
        }

        /// <summary>
        /// The same BFS idea. We can notice, that our two rules can be interpreted like: no any nodes after first NULL node.
        /// So, the code can be much simple
        /// </summary>
        /// <param name="root"> Root </param>
        /// <returns> True if tree is complete tree </returns>
        /// <remarks>
        /// Time complexity: O(N)
        /// Space complexity: O(N)
        /// </remarks>
        public bool IsCompleteTreeOptimized(TreeNode root)
        {
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            var hasNull = false;

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (node == null)
                {
                    hasNull = true;

                    continue;
                }

                if (hasNull)
                {
                    return false;
                }

                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }

            return true;
        }
    }
}
