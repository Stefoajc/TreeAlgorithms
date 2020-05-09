using TreeAlgorithms.Interfaces;
using TreeAlgorithms.Types;

namespace TreeAlgorithms.Transformers
{
    public class BinaryToRegularTreeCommand
    {
        public ITraversableTreeNode<T>? Transform<T>(IBinaryTreeNode<T>? root)
        {
            if (root == null)
            {
                return null;
            }

            ITraversableTreeNode<T> newNode = new TreeNode<T>(root.Value);

            var leftSubTree = Transform(root.Left);
            if (leftSubTree != null)
                newNode.Children.Add(leftSubTree);

            var rightSubTree = Transform(root.Right);
            if (rightSubTree != null)
                newNode.Children.Add(rightSubTree);

            return newNode;
        }
    }
}
