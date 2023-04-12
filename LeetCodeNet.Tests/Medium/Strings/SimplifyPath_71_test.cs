using System.Collections;
using LeetCodeNet.Medium.Strings;

namespace LeetCodeNet.Tests.Medium.Strings
{
    public sealed class SimplifyPath_71_test
    {
        [Theory, ClassData(typeof(SimplifyPathTestData))]
        public void Check(string inputData, string expected)
        {
            var solver = new SimplifyPath_71();

            Assert.Equal(expected, solver.SimplifyPath(inputData));
        }
    }

    public sealed class SimplifyPathTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: Note that there is no trailing slash after the last directory name.
            yield return new object[]
            {
                "/home/",
                "/home"
            };

            //// Explanation: Going one level up from the root directory is a no-op, as the root level is the highest level you can go.
            yield return new object[]
            {
                "/../",
                "/"
            };

            //// Explanation: In the canonical path, multiple consecutive slashes are replaced by a single one.
            yield return new object[]
            {
                "/home//foo/",
                "/home/foo"
            };

            yield return new object[]
            {
                "/a/./b/../../c/",
                "/c"
            };

            yield return new object[]
            {
                "/home/../../..",
                "/"
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
