using LeetCodeNet.Easy.Design;
using LeetCodeNet.Medium.Design;

namespace LeetCodeNet.Tests.Medium.Design
{
    public sealed class DesignBrowserHistory_1472_test
    {
        [Fact]
        public void CheckDLL()
        {
            var history = new BrowserHistoryDLL("leetcode.com");

            history.Visit("google.com");
            history.Visit("facebook.com");
            history.Visit("youtube.com");

           Assert.Equal("facebook.com",  history.Back(1));
           Assert.Equal("google.com", history.Back(1));
           Assert.Equal("facebook.com", history.Forward(1));

           history.Visit("linkedin.com");

           Assert.Equal("linkedin.com", history.Forward(2));
           Assert.Equal("google.com", history.Back(2));
           Assert.Equal("leetcode.com", history.Back(7));
        }

        [Fact]
        public void CheckArray()
        {
            var history = new BrowserHistorArray("leetcode.com");

            history.Visit("google.com");
            history.Visit("facebook.com");
            history.Visit("youtube.com");

            Assert.Equal("facebook.com", history.Back(1));
            Assert.Equal("google.com", history.Back(1));
            Assert.Equal("facebook.com", history.Forward(1));

            history.Visit("linkedin.com");

            Assert.Equal("linkedin.com", history.Forward(2));
            Assert.Equal("google.com", history.Back(2));
            Assert.Equal("leetcode.com", history.Back(7));
        }
    }
}