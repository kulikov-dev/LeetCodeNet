using System.Text;

namespace LeetCodeNet.Medium.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/simplify-path/
    /// </summary>
    /// <remarks>
    /// Given a string path, which is an absolute path (starting with a slash '/') to a file or directory in a Unix-style file system, convert it to the simplified canonical path.
    /// In a Unix-style file system, a period '.' refers to the current directory, a double period '..' refers to the directory up a level, and any multiple consecutive slashes(i.e. '//') are treated as a single slash '/'. For this problem, any other format of periods such as '...' are treated as file/directory names.
    /// The canonical path should have the following format:
    ///  The path starts with a single slash '/'.
    ///  Any two directories are separated by a single slash '/'.
    ///  The path does not end with a trailing '/'.
    ///  The path only contains the directories on the path from the root directory to the target file or directory (i.e., no period '.' or double period '..')
    /// </remarks>
    internal sealed class SimplifyPath_71
    {
        /// <summary>
        /// We have commands like 'step back' or 'stay here', so we can keep all folders in the stack and manage it.
        /// Detailed explanation is here: https://leetcode.com/problems/simplify-path/solutions/1847526/best-explanation-ever-possible-not-a-clickbait/
        /// </summary>
        /// <param name="path"> Path </param>
        /// <returns> Canonical path </returns>
        /// <remarks>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </remarks>
        public string SimplifyPath(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return string.Empty;
            }

            var stack = new Stack<string>();
            var items = path.Split('/', StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in items)
            {
                if (item == ".")
                {
                    continue;
                }

                if (item == "..")
                {
                    stack.TryPop(out _);
                }
                else
                {
                    stack.Push(item);
                }
            }

            if (stack.Count == 0)
            {
                return "/";
            }

            var result = new StringBuilder();

            while (stack.Count > 0)
            {
                var item = stack.Pop();
                result = result.Insert(0, item).Insert(0, "/");
            }

            return result.ToString();
        }
    }
}
