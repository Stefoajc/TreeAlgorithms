using System.Collections.Generic;

namespace TreeAlgorithms
{
    public class TreeNode<T> : ITraversableTreeNode<T>
    {
        public TreeNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public ICollection<ITraversableTreeNode<T>> Children { get; set; } = new List<ITraversableTreeNode<T>>();
        public TreeNode<T>? Parent { get; set; }

    }

    public class TreeNodeWithoutParent<T> : ITraversableTreeNode<T>
    {
        public TreeNodeWithoutParent(T value)
        {
            Value = value;
        }

        public T Value { get; }
        public ICollection<ITraversableTreeNode<T>> Children { get; set; } = new List<ITraversableTreeNode<T>>();

    }
}
