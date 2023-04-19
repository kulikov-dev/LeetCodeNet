namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/top-k-frequent-words
    /// </summary>
    /// <remarks>
    /// Given an array of strings words and an integer k, return the k most frequent strings.
    /// Return the answer sorted by the frequency from highest to lowest.Sort the words with the same frequency by their lexicographical order.
    /// </remarks>
    internal class TopKFrequentWords_692
    {
        /// <summary>
        /// Use linq to group all elements and get their frequencies
        /// Than we make to sorting: by frequencies and by word after that
        /// Get the result
        /// </summary>
        /// <param name="words"> Words </param>
        /// <param name="k"> Amount of most frequent strings </param>
        /// <returns> List of most frequent strings </returns>
        /// <remarks>
        /// Time complexity: O(n * log(n))
        /// Space complexity: O(n)
        /// </remarks>
        public IList<string> TopKFrequentLinq(string[] words, int k)
        {
            var grouppedWords = words.GroupBy(x => x);
            var sortedWords = grouppedWords.OrderByDescending(x => x.Count()).ThenBy(x => x.Key).ToList();

            return sortedWords.Take(k > sortedWords.Count ? sortedWords.Count : k).Select(x => x.Key).ToList();
        }

        /// <summary>
        /// When you need to return 'K-most frequent elements', the idea is to use bucket sorting. Where:
        /// 1. Create the dict with key = word, value = frequency of this word
        /// 2. Make an array ranging from 0 to the maximum frequent amount. In our case, it's 500. It will list words with a certain frequency.
        /// 3. Go through the array and get the list of words with a certain frequency.
        /// To keep the words in the lexicographical order, we will use SortedSet
        /// </summary>
        /// <param name="words"> Words </param>
        /// <param name="k"> Amount of most frequent strings </param>
        /// <returns> List of most frequent strings </returns>
        /// <remarks>
        /// Time complexity: O(n * log(n))
        /// Space complexity: O(n)
        /// </remarks>
        public IList<string> TopKFrequentBucket(string[] words, int k)
        {
            var dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, 0);
                }

                dict[word]++;
            }

            var bucketARray = new SortedSet<string>?[501];

            foreach (var word in dict)
            {
                if (bucketARray[word.Value] == null)
                {
                    bucketARray[word.Value] = new SortedSet<string>();
                }

                bucketARray[word.Value]!.Add(word.Key);
            }

            var result = new List<string>();

            for (var i = bucketARray.Length - 1; i >= 0; --i)
            {
                if (k == 0)
                {
                    break;
                }

                if (bucketARray[i] == null)
                {
                    continue;
                }

                foreach (var word in bucketARray[i]!)
                {
                    if (k == 0)
                    {
                        break;
                    }

                    result.Add(word);
                    --k;
                }
            }

            return result;
        }
    }
}
