using TreeAlgorithms.Interfaces;

namespace TreeAlgorithms.Types
{
    public class BinaryTreeNode<T> : IBinaryTreeNode<T>
    {
        public BinaryTreeNode(T value)
        {
            Value = value;
        }

        public T Value { get; }

        public IBinaryTreeNode<T>? Left { get; set; }
        public IBinaryTreeNode<T>? Right { get; set; }
    }
}
