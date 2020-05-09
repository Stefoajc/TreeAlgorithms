using TreeAlgorithms.Interfaces;
using TreeAlgorithms.Types;

namespace TreeAlgorithms.Common
{
    public class CloneBinaryTreeCommand
    {
        public IBinaryTreeNode<T>? Clone<T>(IBinaryTreeNode<T>? root)
        {            
            if(root == null)
            {
                return null;
            }

            IBinaryTreeNode<T> newNode = new BinaryTreeNode<T>(root.Value);

            newNode.Left = Clone(root.Left);
            newNode.Right = Clone(root.Right);

            return newNode;
        }
    }
}
