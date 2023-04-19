namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/last-stone-weight
    /// </summary>
    /// <remarks>
    /// You are given an array of integers stones where stones[i] is the weight of the ith stone.
    /// We are playing a game with the stones.On each turn, we choose the heaviest two stones and smash them together. Suppose the heaviest two stones have weights x and y with x <= y.The result of this smash is:
    /// If x == y, both stones are destroyed, and
    /// If x != y, the stone of weight x is destroyed, and the stone of weight y has new weight y - x.
    /// At the end of the game, there is at most one stone left.
    /// Return the weight of the last remaining stone.If there are no stones left, return 0.
    /// </remarks>
    internal sealed class LastStoneWeight_1046
    {
        /// <summary>
        /// Simulating priority queue.
        /// Because we must "smash" the two heaviest stones, we must know which two stones are the heaviest at all iterations.
        /// As a result, in order to compare the two heaviest stones, we must first sort the stones by weight.
        /// </summary>
        /// <param name="stones"> Stones </param>
        /// <returns> Winner stone </returns>
        /// <remarks>
        /// Time complexity: O(n log n)
        /// Space complexity: O(n)
        /// </remarks>
        public int LastStoneWeightSort(int[] stones)
        {
            if (stones.Length == 0)
            {
                return 0;
            }

            var sortedStones = stones.OrderBy(x => x).ToList();

            while (sortedStones.Count > 1)
            {
                if (sortedStones[^1] == sortedStones[^2])
                {
                    sortedStones.RemoveAt(sortedStones.Count - 1);
                    sortedStones.RemoveAt(sortedStones.Count - 1);
                }
                else
                {
                    var newValue = sortedStones[^1] - sortedStones[^2];

                    sortedStones.RemoveAt(sortedStones.Count - 1);
                    sortedStones.RemoveAt(sortedStones.Count - 1);
                    sortedStones.Add(newValue);
                    sortedStones.Sort();
                }
            }

            return sortedStones.Count == 0 ? 0 : sortedStones[0];
        }

        /// <summary>
        /// The more appropriate way is to use built-in priority queue.
        /// Put all elements into a priority queue. Pop out the two biggest, push back the difference
        /// </summary>
        /// <param name="stones"> Stones </param>
        /// <returns> Winner stone </returns>
        /// <remarks>
        /// Time complexity: O(n log n)
        /// Space complexity: O(n)
        /// </remarks>
        public int LastStoneWeightQueue(int[] stones)
        {
            if (stones.Length == 0)
            {
                return 0;
            }

            var queue = new PriorityQueue<int, int>(stones.Length, Comparer<int>.Create((a, b) => b.CompareTo(a)));

            foreach (var stone in stones)
            {
                queue.Enqueue(stone, stone);
            }

            while (queue.Count > 1)
            {
                var stone1 = queue.Dequeue();
                var stone2 = queue.Dequeue();

                if (stone1 > stone2)
                {
                    var newValue = stone1 - stone2;

                    queue.Enqueue(newValue, newValue);
                }
            }

            return queue.Count == 0 ? 0 : queue.Dequeue();
        }
    }
}
