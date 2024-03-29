﻿using LeetCodeNet.Easy.Strings;
using System.Collections;

namespace LeetCodeNet.Tests.Easy.Strings
{
    public sealed class ReverseWordsinaStringIII_557_test
    {
        [Theory, ClassData(typeof(ReverseWordsinaStringIIITestData))]
        public void CheckLinq(string inputData, string expected)
        {
            var solver = new ReverseWordsinaStringIII_557();

            Assert.Equal(expected, solver.ReverseWordsLinq(inputData));
        }

        [Theory, ClassData(typeof(ReverseWordsinaStringIIITestData))]
        public void CheckTwoPointers(string inputData, string expected)
        {
            var solver = new ReverseWordsinaStringIII_557();

            Assert.Equal(expected, solver.ReverseStringTwoPointers(inputData));
        }
    }

    public sealed class ReverseWordsinaStringIIITestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "Let's take LeetCode contest",
                "s'teL ekat edoCteeL tsetnoc"
            };

            yield return new object[]
            {
                "God Ding",
                "doG gniD"
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
