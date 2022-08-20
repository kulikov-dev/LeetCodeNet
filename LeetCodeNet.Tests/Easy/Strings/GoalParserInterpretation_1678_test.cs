using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public sealed class GoalParserInterpretation_1678_test
    {
        [Theory, ClassData(typeof(GoalParserInterpretationTestData))]
        public void CheckReplace(string inputData, string expected)
        {
            var solver = new GoalParserInterpretation_1678();
            Assert.Equal(expected, solver.InterpretReplace(inputData));
        }

        [Theory, ClassData(typeof(GoalParserInterpretationTestData))]
        public void CheckPointers(string inputData, string expected)
        {
            var solver = new GoalParserInterpretation_1678();
            Assert.Equal(expected, solver.InterpretPointers(inputData));
        }
    }

    public sealed class GoalParserInterpretationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //// Explanation: The Goal Parser interprets the command as follows:
            /// G->G
            /// ()->o
            /// (al)->al
            /// The final concatenated result is "Goal".
            yield return new object[]
            {
                "G()(al)",
                "Goal"
            };

            yield return new object[]
            {
                "G()()()()(al)",
                "Gooooal"
            };

            yield return new object[]
            {
                "(al)G(al)()()G",
                "alGalooG"
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
