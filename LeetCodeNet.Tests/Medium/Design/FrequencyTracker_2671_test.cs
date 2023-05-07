using LeetCodeNet.Medium.Design;

namespace LeetCodeNet.Tests.Medium.Design
{
    public sealed class FrequencyTracker_2671_test
    {
        [Fact]
        public void Check()
        {
            var searcher = new FrequencyTracker();

            searcher.Add(3);
            searcher.Add(3);
            
            Assert.True(searcher.HasFrequency(2));
        }

        [Fact]
        public void Check1()
        {
            var searcher = new FrequencyTracker();

            searcher.Add(1);
            searcher.DeleteOne(1);

            Assert.False(searcher.HasFrequency(1));
        }

        [Fact]
        public void Check3()
        {
            var searcher = new FrequencyTracker();

            Assert.False(searcher.HasFrequency(2));

            searcher.Add(3);

            Assert.True(searcher.HasFrequency(1));
        }
    }
}