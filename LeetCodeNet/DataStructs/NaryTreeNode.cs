namespace LeetCodeNet.DataStructs
{
    /// <summary>
    /// Definition for a N-ary Tree node
    /// </summary>
    public class NaryTreeNode
    {
        /// <summary>
        /// Value
        /// </summary>
        public int val;

        /// <summary>
        /// Children nodes
        /// </summary>
        public IList<NaryTreeNode> children;

        /// <summary>
        /// Parameterless constructor
        /// </summary>
        public NaryTreeNode()
        {
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="_val"> Value </param>
        public NaryTreeNode(int _val)
        {
            val = _val;
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="_val"> Value </param>
        /// <param name="_children"> Children nodes </param>
        public NaryTreeNode(int _val, IList<NaryTreeNode> _children)
        {
            val = _val;
            children = _children;
        }
    }
}