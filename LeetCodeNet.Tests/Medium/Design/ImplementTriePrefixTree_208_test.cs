using LeetCodeNet.Easy.Design;
using LeetCodeNet.Medium.Design;

namespace LeetCodeNet.Tests.Medium.Design
{
    public sealed class ImplementTriePrefixTree_208_test
    {
        [Fact]
        public void Check()
        {
            var trie = new Trie();
            trie.Insert("apple");
            Assert.True(trie.Search("apple"));
            Assert.False(trie.Search("app"));
            Assert.True(trie.StartsWith("app"));
            trie.Insert("app");
            Assert.True(trie.Search("app"));
        }

        [Fact]
        public void Check1()
        {
            var trie = new Trie();
            trie.Insert("hello");
            Assert.False(trie.Search("hell"));
            Assert.False(trie.Search("helloa"));
            Assert.True(trie.Search("hello"));


            Assert.True(trie.StartsWith("hell"));
            Assert.False(trie.StartsWith("helloa"));
            Assert.True(trie.StartsWith("hello"));
        }

        [Fact]
        public void Check2()
        {
            var trie = new Trie();
            trie.Insert("app");
            trie.Insert("apple");
            trie.Insert("beer");
            trie.Insert("add");
            trie.Insert("jam");
            trie.Insert("rental");

            Assert.False(trie.Search("apps"));
            Assert.True(trie.Search("app"));
            Assert.False(trie.Search("ad"));
            Assert.False(trie.Search("applepie"));
            Assert.False(trie.Search("rest"));
            Assert.False(trie.Search("jan"));
            Assert.False(trie.Search("rent"));
            Assert.True(trie.Search("beer"));
            Assert.True(trie.Search("jam"));

            Assert.False(trie.StartsWith("apps"));
            Assert.True(trie.StartsWith("app"));
            Assert.True(trie.StartsWith("ad"));
            Assert.False(trie.StartsWith("applepie"));
            Assert.False(trie.StartsWith("rest"));
            Assert.False(trie.StartsWith("jan"));
            Assert.True(trie.StartsWith("rent"));
            Assert.True(trie.StartsWith("beer"));
            Assert.True(trie.StartsWith("jam"));
        }
    }
}