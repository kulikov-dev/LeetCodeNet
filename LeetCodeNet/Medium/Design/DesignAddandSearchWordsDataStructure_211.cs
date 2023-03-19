namespace LeetCodeNet.Medium.Design
{
    /// <summary>
    /// https://leetcode.com/problems/design-add-and-search-words-data-structure/
    /// </summary>
    /// <remarks> Design a data structure that supports adding new words and finding if a string matches any previously added string. </remarks>
    internal sealed class WordDictionary
    {
        //// Here is the same idea, like in problem 208 <see cref="Trie"/>
        /// But with some complexity as '.' char. Let's apply recursion/backtracking approach to find if any possible variants can be used

        /// <summary>
        /// Prefix tree node
        /// </summary>
        private class CharTreeNode
        {
            /// <summary>
            /// Children
            /// </summary>
            public readonly CharTreeNode?[] Children;

            /// <summary>
            /// Char
            /// </summary>
            public int ch;

            /// <summary>
            /// True if end of word
            /// </summary>
            public bool IsEndWord;

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="ch"> Char </param>
            public CharTreeNode(int ch)
            {
                this.ch = ch;
                Children = new CharTreeNode[26];
            }
        }

        /// <summary>
        /// Root of the prefix tree
        /// </summary>
        private readonly CharTreeNode _root;

        /// <summary>
        /// Constructor
        /// </summary>
        public WordDictionary()
        {
            _root = new CharTreeNode(-1);
        }

        /// <summary>
        /// Add new word
        /// </summary>
        /// <param name="word"> The new word </param>
        public void AddWord(string word)
        {
            var node = _root;

            for (var i = 0; i < word.Length; i++)
            {
                var newNode = node.Children[word[i] - 'a'] ?? new CharTreeNode(word[i] - 'a');

                node.Children[word[i] - 'a'] = newNode;
                node = newNode;
            }

            node.IsEndWord = true;
        }

        /// <summary>
        /// Search the word
        /// </summary>
        /// <param name="word"> The word </param>
        /// <returns> True, if success </returns>
        public bool Search(string word)
        {
            var result = Match(word, 0, _root);

            return result != null && result.IsEndWord;
        }

        /// <summary>
        /// Try to find the word through the tree
        /// </summary>
        /// <param name="word"> Word </param>
        /// <param name="currentIndex"> Current char index </param>
        /// <param name="currentNode"> Current node </param>
        /// <returns> Last node </returns>
        private CharTreeNode? Match(string word, int currentIndex, CharTreeNode? currentNode)
        {
            if (currentNode == null)
            {
                return null;
            }

            if (currentIndex == word.Length)
            {
                return currentNode;
            }

            if (word[currentIndex] == '.')
            {
                //// Backtracking here
                for (var j = 0; j < 26; ++j)
                {
                    var result = Match(word, currentIndex + 1, currentNode.Children[j]);

                    if (result != null && result.IsEndWord)
                    {
                        return result;
                    }
                }

                return null;
            }

            var nextNode = currentNode.Children[word[currentIndex] - 'a'];

            return Match(word, currentIndex + 1, nextNode);
        }
    }
}
