using System;
using System.Collections.Generic;
using TreeAlgorithms.Interfaces;

namespace TreeAlgorithms.Traversers
{
    public class BreadthFirstBinaryTreeTraverseCommand
    {
        public void Traverse<T>(IBinaryTreeNode<T> root, Action<T> action)
        {
            Queue<IBinaryTreeNode<T>> q = new Queue<IBinaryTreeNode<T>>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                IBinaryTreeNode<T> n = q.Dequeue();
                action(n.Value);

                if (n.Left != null)
                {
                    q.Enqueue(n.Left);
                }

                if (n.Right != null)
                {
                    q.Enqueue(n.Right);
                }
            }
        }

    }


}
