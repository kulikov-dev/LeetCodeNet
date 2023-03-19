using LeetCodeNet.Medium.Design;

namespace LeetCodeNet.Tests.Medium.Design
{
    public sealed class DesignAddandSearchWordsDataStructure_211_test
    {
        [Fact]
        public void Check()
        {
            var searcher = new WordDictionary();

            searcher.AddWord("bad");
            searcher.AddWord("dad");
            searcher.AddWord("mad");

            Assert.False(searcher.Search("pad"));
            Assert.True(searcher.Search("bad"));
            Assert.True(searcher.Search(".ad"));
            Assert.True(searcher.Search("b.."));
        }

        [Fact]
        public void Check1()
        {
            var searcher = new WordDictionary();

            searcher.AddWord("a");
            searcher.AddWord("a");

            Assert.True(searcher.Search("."));
            Assert.True(searcher.Search("a"));
            Assert.False(searcher.Search("aa"));
            Assert.True(searcher.Search("a"));
            Assert.False(searcher.Search(".a"));
            Assert.False(searcher.Search("a."));
        }

        [Fact]
        public void Check2()
        {
            var searcher = new WordDictionary();

            searcher.AddWord("a");
            searcher.AddWord("ab");

            Assert.True(searcher.Search("a"));
            Assert.True(searcher.Search("a."));
            Assert.True(searcher.Search("ab"));
            Assert.False(searcher.Search(".a"));
            Assert.True(searcher.Search(".b"));
            Assert.False(searcher.Search("ab."));
            Assert.True(searcher.Search("."));
            Assert.True(searcher.Search(".."));
        }
    }
}