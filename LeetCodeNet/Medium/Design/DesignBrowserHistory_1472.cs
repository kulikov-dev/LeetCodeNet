namespace LeetCodeNet.Medium.Design
{
    /// <summary>
    /// https://leetcode.com/problems/design-browser-history
    /// </summary>
    /// <remarks>
    /// You have a browser of one tab where you start on the homepage and you can visit another url, get back in the history number of steps or move forward in the history number of steps.
    /// </remarks>
    internal sealed class BrowserHistoryDLL
    {
        //// The solution for this task depends on what the interviewer requires: if they need constant time back/forward or space efficiency.
        /// Space efficiency solution. We create double linked-list and iterate through on Back/Forward operations

        /// <summary>
        /// Link to the current node
        /// </summary>
        private DoubleLinkedListNode _currentNode;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="homepage"> Homepage URL </param>
        public BrowserHistoryDLL(string homepage)
        {
            var newNode = new DoubleLinkedListNode(homepage);
            _currentNode = newNode;
        }

        /// <summary>
        /// Visit URL
        /// </summary>
        /// <param name="url"> URL </param>
        public void Visit(string url)
        {
            var newNode = new DoubleLinkedListNode(url);
            newNode.prev = _currentNode;
            _currentNode.next = newNode;

            _currentNode = newNode;
        }

        /// <summary>
        /// Back in the history
        /// </summary>
        /// <param name="steps"> Steps amount </param>
        /// <returns> URL </returns>
        public string Back(int steps)
        {
            var counter = 0;

            while (counter < steps && _currentNode.prev != null)
            {
                _currentNode = _currentNode.prev;

                counter++;
            }

            return _currentNode.url;
        }

        /// <summary>
        /// Forward in the history
        /// </summary>
        /// <param name="steps"> Steps amount </param>
        /// <returns> URL </returns>
        public string Forward(int steps)
        {
            var counter = 0;

            while (counter < steps && _currentNode.next != null)
            {
                _currentNode = _currentNode.next;

                counter++;
            }

            return _currentNode.url;
        }

        /// <summary>
        /// Class to preset double linked list node
        /// </summary>
        private class DoubleLinkedListNode
        {
            /// <summary>
            /// Link to the next node
            /// </summary>
            public DoubleLinkedListNode prev;

            /// <summary>
            /// Link to the previous node
            /// </summary>
            public DoubleLinkedListNode next;

            /// <summary>
            /// URL
            /// </summary>
            public readonly string url;

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="url"> URL </param>
            public DoubleLinkedListNode(string url)
            {
                this.url = url;
            }
        }
    }

    /// <summary>
    /// Constant time back/forward. We use built-in List class and save current position of the history and total elements in the history
    /// However, we met allocation issue. So, it depends. I'll prefer more DLL solution.
    /// </summary>
    internal sealed class BrowserHistorArray
    {
        /// <summary>
        /// History in the list presentation
        /// </summary>
        private readonly List<string> _history = new();

        /// <summary>
        /// Current position
        /// </summary>
        private int _currentPosition = 0;

        /// <summary>
        /// Total amount of url's in the history
        /// </summary>
        private int _totalAmount = 0;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="homepage"> Homepage URL </param>
        public BrowserHistorArray(string homepage)
        {
            _history.Add(homepage);
        }

        /// <summary>
        /// Visit URL
        /// </summary>
        /// <param name="url"> URL </param>
        public void Visit(string url)
        {
            ++_currentPosition;
            if (_currentPosition == _history.Count)
            {
                _history.Add(url);
            }
            else
            {
                _history[_currentPosition] = url;
            }

            _totalAmount = _currentPosition;
        }

        /// <summary>
        /// Back in the history
        /// </summary>
        /// <param name="steps"> Steps amount </param>
        /// <returns> URL </returns>
        public string Back(int steps)
        {
            _currentPosition -= steps;

            _currentPosition = _currentPosition < 0 ? 0 : _currentPosition;

            return _history[_currentPosition];
        }

        /// <summary>
        /// Forward in the history
        /// </summary>
        /// <param name="steps"> Steps amount </param>
        /// <returns> URL </returns>
        public string Forward(int steps)
        {
            _currentPosition += steps;

            _currentPosition = _currentPosition > _totalAmount ? _totalAmount : _currentPosition;

            return _history[_currentPosition];
        }
    }
}
