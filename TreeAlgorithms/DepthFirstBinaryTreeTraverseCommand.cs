using System;
using System.Collections.Generic;

namespace TreeAlgorithms
{
    public class DepthFirstBinaryTreeTraverseCommand
    {
        public void Traverse<T>(IBinaryTreeNode<T> root)
        {
            Stack<IBinaryTreeNode<T>> q = new Stack<IBinaryTreeNode<T>>();
            q.Push(root);
            while (q.Count > 0)
            {
                IBinaryTreeNode<T> n = q.Pop();
                Console.WriteLine(n.Value);

                if (n.Right != null)
                {
                    q.Push(n.Right);
                }

                if (n.Left != null)
                {
                    q.Push(n.Left);
                }
            }
        }
    }
}
