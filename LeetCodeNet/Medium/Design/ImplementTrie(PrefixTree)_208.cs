namespace LeetCodeNet.Medium.Design
{
    /// <summary>
    /// https://leetcode.com/problems/implement-trie-prefix-tree/
    /// </summary>
    /// <remarks>
    /// A trie (pronounced as "try") or prefix tree is a tree data structure used to efficiently store and retrieve keys in a dataset of strings.
    /// There are various applications of this data structure, such as autocomplete and spellchecker.
    /// </remarks>
    public class Trie
    {
        //// The idea is to create a node which has array of nodes (one for each symbol). We also need to understand the ending of the word in the tree, so we add flag to detect it.
        /// So, we just need to go through this array to get the information about the word

        /// <summary>
        /// Tree root
        /// </summary>
        private readonly TrieTreeNode root;

        /// <summary>
        /// Constructor
        /// </summary>
        public Trie()
        {
            root = new TrieTreeNode(-1);
        }

        /// <summary>
        /// Insert the new word
        /// </summary>
        /// <param name="word"> Word </param>
        public void Insert(string word)
        {
            var currentNode = root;
            for (var i = 0; i < word.Length; ++i)
            {
                var ch = word[i] - 'a';
                if (currentNode.Children[ch] == null)
                {
                    currentNode.Children[ch] = new TrieTreeNode(ch);
                }

                currentNode = currentNode.Children[ch];
            }

            currentNode.IsEndWord = true;
        }

        /// <summary>
        /// Search if tree contains the word
        /// </summary>
        /// <param name="word"> Word </param>
        /// <returns> True, if contains </returns>
        public bool Search(string word)
        {
            var node = FindLastNode(word);
            return node != null && node.IsEndWord;
        }

        /// <summary>
        /// Search, if tree contains prefix
        /// </summary>
        /// <param name="prefix"> Prefix </param>
        /// <returns> True, if contains prefix </returns>
        public bool StartsWith(string prefix)
        {
            return FindLastNode(prefix) != null;
        }

        /// <summary>
        /// Find last char node in the tree
        /// </summary>
        /// <param name="word"> Word </param>
        /// <returns> Last char node</returns>
        private TrieTreeNode? FindLastNode(string word)
        {
            var currentNode = root;
            for (var i = 0; i < word.Length; ++i)
            {
                var ch = word[i] - 'a';
                currentNode = currentNode.Children[ch];
                if (currentNode == null)
                {
                    return null;
                }
            }

            return currentNode;
        }

        /// <summary>
        /// Tree node for the trie tree
        /// </summary>
        private class TrieTreeNode
        {
            /// <summary>
            /// True, if the word ended here
            /// </summary>
            public bool IsEndWord;

            /// <summary>
            /// Children
            /// </summary>
            public readonly TrieTreeNode[] Children;

            /// <summary>
            /// Char in 0-26 representation
            /// </summary>
            public int Val;

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="val"> Char in 0-26 </param>
            public TrieTreeNode(int val)
            {
                this.Val = val;
                Children = new TrieTreeNode[26];
            }
        }
    }
}
