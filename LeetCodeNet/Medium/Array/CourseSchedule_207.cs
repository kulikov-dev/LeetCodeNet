namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/course-schedule
    /// </summary>
    /// <remarks>
    /// There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 1. You are given an array prerequisites where prerequisites[i] = [ai, bi] indicates that you must take course bi first if you want to take course ai.
    /// For example, the pair[0, 1], indicates that to take course 0 you have to first take course 1.
    /// Return true if you can finish all courses.Otherwise, return false.
    /// </remarks>
    internal sealed class CourseSchedule_207
    {
        /// <summary>
        /// Based on the description we can find out, that it's kind of graph tasks. As we have prerequisites, we need to find out is there any cycle in the graph
        /// To solve it, we can use DFS:
        /// If node v hasn't been visited yet, set it to 0.
        /// If node v is being visited, set it to 1. There is a ring if we find a vertex marked as 1 in DFS.
        /// If node v has been visited, set it to 2. If a vertex is marked as 2, no ring contains v or its descendants.
        /// </summary>
        /// <param name="numCourses"> Num courses </param>
        /// <param name="prerequisites"> Prerequisites </param>
        /// <returns> True, if can attend </returns>
        /// <remarks>
        /// Time complexity: O(V+E)
        /// Space complexity: O(V+E)
        /// </remarks>
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var nodes = new List<int>?[numCourses];
            var isVisited = new byte[numCourses];

            foreach (var item in prerequisites)
            {
                if (nodes[item[1]] == null)
                {
                    nodes[item[1]] = new List<int>();
                }

                nodes[item[1]]!.Add(item[0]);
            }

            for (var i = 0; i < numCourses; i++)
            {
                if (IsCycle(nodes, isVisited, i))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Void to check all connected nodes
        /// </summary>
        /// <param name="nodes"> All nodes </param>
        /// <param name="visited"> Visited nodes </param>
        /// <param name="nodeIndex"> Current node </param>
        /// <returns> True, if cycle </returns>
        private bool IsCycle(List<int>?[] nodes, byte[] visited, int nodeIndex)
        {
            if (nodes[nodeIndex] == null || visited[nodeIndex] == 2)
            {
                return false;
            }

            if (visited[nodeIndex] == 1)
            {
                return true;
            }

            visited[nodeIndex] = 1;

            foreach (var child in nodes[nodeIndex]!)
            {
                if (IsCycle(nodes, visited, child))
                {
                    return true;
                }
            }

            visited[nodeIndex] = 2;

            return false;
        }
    }
}
