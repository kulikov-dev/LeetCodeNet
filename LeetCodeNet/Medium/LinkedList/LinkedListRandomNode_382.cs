using LeetCodeNet.DataStructs;

namespace LeetCodeNet.Medium.LinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/linked-list-random-node/description/
    /// </summary>
    /// <remarks> Given a singly linked list, return a random node's value from the linked list. Each node must have the same probability of being chosen. </remarks>
    internal class SolutionEasy
    {
        //// One of the most intuitive ideas would be that we convert the linked list into an array. With the array, we would know its size and moreover we could have an instant access to its elements.

        /// <summary>
        /// Linked list in the list array representation
        /// </summary>
        private List<int> data;

        /// <summary>
        /// Randomizer
        /// </summary>
        private Random rnd;

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="head"> The linked list head </param>
        public SolutionEasy(ListNode head)
        {
            data = new List<int>();
            rnd = new Random();

            while (head != null)
            {
                data.Add(head.val);
                head = head.next;
            }
        }

        /// <summary>
        /// Get random number with equal probability
        /// </summary>
        /// <returns> Random number </returns>
        public int GetRandom()
        {
            //// As we have numbers with direct access - we can just use random to get the next number at the random position.
            return data[rnd.Next(data.Count)];
        }
    }

    /// <summary>
    /// What if the linked list is extremely large and its length is unknown to you?
    /// </summary>
    /// When I solved it the address-book problem comes to my mind. So I decided not to read this large list directly, but split the reading by chunks
    public class SolutionFollowUp1
    {
        /// <summary>
        /// Data splitted into chunks
        /// </summary>
        private List<List<int>> data;

        /// <summary>
        /// Page size of the chunk
        /// </summary>
        private const int pageSize = 256;

        /// <summary>
        /// Current node
        /// </summary>
        private ListNode currentNode;

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="head"> The linked list head </param>
        public SolutionFollowUp1(ListNode head)
        {
            currentNode = head;
            data = new List<List<int>>();
        }

        /// <summary>
        /// Get random number with equal probability
        /// </summary>
        /// <returns> Random number </returns>
        public int GetRandom()
        {
            LoadNextChunk();
            var rand = new Random();
            var chunk = data[rand.Next(data.Count)];
            return chunk[rand.Next(chunk.Count)];
        }

        /// <summary>
        /// Next chunk loader
        /// </summary>
        private void LoadNextChunk()
        {
            if (currentNode == null)
            {
                return;
            }

            var newChunk = new List<int>();
            while (currentNode != null && newChunk.Count < pageSize)
            {
                newChunk.Add(currentNode.val);
                currentNode = currentNode.next;
            }

            data.Add(newChunk);
        }
    }

    /// <summary>
    ///  Follow up question: Could you solve this efficiently without using extra space?
    /// </summary>
    /// <remarks> Recommended by LeetCode approach based on the math (Reservoir sampling) </remarks>
    public class SolutionMath
    {
        /// <summary>
        /// Linked list head
        /// </summary>
        ListNode head;

        /// <summary>
        /// Randomizer
        /// </summary>
        private Random rnd;

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="head"> The linked list head </param>
        public SolutionMath(ListNode head)
        {
            this.head = head;
            rnd = new Random();
        }

        /// <summary>
        /// Get random number with equal probability
        /// </summary>
        /// <returns> Random number </returns>
        public int GetRandom()
        {
            //// When we read the first node head, if the stream ListNode stops here, we can just return the head.val. The possibility is 1/1.
            /// When we read the second node, we can decide if we replace the result r or not. The possibility is 1/2.
            /// So we just generate a random number between 0 and 1, and check if it is equal to 1.
            /// If it is 1, replace r as the value of the current node, otherwise we don't touch r, so its value is still the value of head.
            /// When we read the third node, now the result r is one of value in the head or second node. We just decide if we replace the value of r as the value of current node(third node)
            /// The possibility of replacing it is 1/3, namely the possibility of we don't touch r is 2/3. So we just generate a random number between 0 ~ 2, and if the result is 2 we replace r.
            /// We can continue to do like this until the end of stream ListNode.

            var currentNode = head;
            var result = currentNode.val;
            for (int i = 1; currentNode.next != null; i++)
            {
                currentNode = currentNode.next;
                if (rnd.Next(i + 1) == i)
                {
                    result = currentNode.val;
                }
            }

            return result;
        }
    }

    /// <summary>
    /// Follow up question: Could you solve this efficiently without using extra space?
    /// </summary>
    /// Simple approach, where we try to optimize getting the next element by using subtype of binary sorting
    public class SolutionFollowUp2
    {
        /// <summary>
        /// Current random node index
        /// </summary>
        private int currentIndex = 0;

        /// <summary>
        /// Linked list length
        /// </summary>
        private int length = 0;

        /// <summary>
        /// Linked list head
        /// </summary>
        private ListNode head;

        /// <summary>
        /// Current random node
        /// </summary>
        private ListNode currentNode;

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="head"> The linked list head </param>
        public SolutionFollowUp2(ListNode head)
        {
            this.head = currentNode = head;
            currentIndex = 0;

            while (head != null)
            {
                ++length;
                head = head.next;
            }
        }

        /// <summary>
        /// Get random number with equal probability
        /// </summary>
        /// <returns> Random number </returns>
        public int GetRandom()
        {
            var rand = new Random();
            var nextIndex = rand.Next(length);

            if (nextIndex < currentIndex)
            {
                currentIndex = 0;
                currentNode = head;
            }

            while (currentIndex != nextIndex)
            {
                currentNode = currentNode.next;
                ++currentIndex;
            }

            return currentNode.val;
        }
    }
}
