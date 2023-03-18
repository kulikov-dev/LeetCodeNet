namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// https://leetcode.com/problems/flood-fill/
    /// </summary>
    /// <remarks>
    /// To perform a flood fill, consider the starting pixel, plus any pixels connected 4-directionally to the starting pixel of the same color as the starting pixel,
    /// plus any pixels connected 4-directionally to those pixels (also with the same color), and so on. Replace the color of all of the aforementioned pixels with color.
    /// </remarks>
    internal sealed class FloodFill_733
    {
        /// <summary>
        /// The best idea for these problem is to solve it in recursive way. It's easier to understand and then think about improvement
        /// </summary>
        /// <param name="image"> Image grid </param>
        /// <param name="sr"> Row index </param>
        /// <param name="sc"> Column index </param>
        /// <param name="color"> New color </param>
        /// <returns> Modified image grid</returns>
        /// <remarks>
        /// Time complexity: O(m * n)
        /// Space complexity: O(m * n), we can do O(1) of space if use the same input array.
        /// </remarks>
        public int[][] FloodFillRecursive(int[][] image, int sr, int sc, int color)
        {
            //// It's necessary to create a new variable, as the array was passed by reference.
            /// It's not a good idea to change source array.
            var newImage = image.Select(s => s.ToArray()).ToArray();

            //// We don't need to iterate and change picture if source color == new color
            if (image[sr][sc] == color)
            {
                return newImage;
            }

            Recursive(ref newImage, sr, sc, newImage[sr][sc], color);
            return newImage;
        }

        /// <summary>
        /// Recursive iteration through each valid cell in the grid. 
        /// </summary>
        /// <param name="image"> Image grid </param>
        /// <param name="sr"> Row index </param>
        /// <param name="sc"> Column index </param>
        /// <param name="oldColor"> Old color </param>
        /// <param name="color"> New Color </param>
        /// <remarks> We put ref to </remarks>
        private void Recursive(ref int[][] image, int sr, int sc, int oldColor, int color)
        {
            //// We have to check that current value mast equal to source color to change
            /// Also we have to check, that current value not equal to new color, to prevent overflow (check second test)
            if (sr < 0 || sc < 0 || sr >= image.Length || sc >= image[sr].Length || image[sr][sc] != oldColor || image[sr][sc] == color)
            {
                return;
            }

            image[sr][sc] = color;
            //// Just check all possible variants recursive. As we can move only straight, not diagonal the scheme is like this:
            ///+ = need to check, * = current position
            ///-|+|-
            ///+|*|+
            ///-|+|-
            Recursive(ref image, sr - 1, sc, oldColor, color);
            Recursive(ref image, sr + 1, sc, oldColor, color);
            Recursive(ref image, sr, sc - 1, oldColor, color);
            Recursive(ref image, sr, sc + 1, oldColor, color);
        }

        /// <summary>
        /// The better approach is to use Queue to implement Breadth-First Search (BFS) idea
        /// Keep in mind, that you can easily improve your first recursive solution to this approach.
        /// Don't try to come to a better solution right away, it can drive you crazy.
        /// </summary>
        /// <param name="image"> Image grid </param>
        /// <param name="sr"> Row index </param>
        /// <param name="sc"> Column index </param>
        /// <param name="color"> New color </param>
        /// <returns> Modified image grid </returns>
        /// <remarks>
        /// Time complexity: O(m * n)
        /// Space complexity: O(m * n)
        /// </remarks>
        public int[][] FloodFillBfs(int[][] image, int sr, int sc, int color)
        {
            var newImage = image.Select(s => s.ToArray()).ToArray();

            if (image[sr][sc] == color)
            {
                return newImage;
            }

            var queue = new Queue<Tuple<int, int>>();

            queue.Enqueue(new Tuple<int, int>(sr, sc));
            var oldColor = newImage[sr][sc];

            while (queue.Any())
            {
                var index = queue.Dequeue();

                //// As we have long condition - it's better to separate it to different variables for better readability
                var isNotValidIndexes = index.Item1 < 0 || index.Item2 < 0 || index.Item1 >= newImage.Length || index.Item2 >= newImage[index.Item1].Length;

                if (isNotValidIndexes)
                {
                    continue;
                }

                var isNotValidColors =  newImage[index.Item1][index.Item2] != oldColor || newImage[index.Item1][index.Item2] == color;

                if (isNotValidColors)
                {
                    continue;
                }

                newImage[index.Item1][index.Item2] = color;

                queue.Enqueue(new Tuple<int, int>(index.Item1 + 1, index.Item2));
                queue.Enqueue(new Tuple<int, int>(index.Item1 - 1, index.Item2));
                queue.Enqueue(new Tuple<int, int>(index.Item1, index.Item2 + 1));
                queue.Enqueue(new Tuple<int, int>(index.Item1, index.Item2 - 1));
            }

            return newImage;
        }
    }
}