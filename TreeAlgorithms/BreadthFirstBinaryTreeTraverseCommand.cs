using System;
using System.Collections.Generic;

namespace TreeAlgorithms
{
    public class BreadthFirstBinaryTreeTraverseCommand
    {
        public void Traverse<T>(IBinaryTreeNode<T> root)
        {
            Queue<IBinaryTreeNode<T>> q = new Queue<IBinaryTreeNode<T>>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                IBinaryTreeNode<T> n = q.Dequeue();
                Console.WriteLine(n.Value);

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
