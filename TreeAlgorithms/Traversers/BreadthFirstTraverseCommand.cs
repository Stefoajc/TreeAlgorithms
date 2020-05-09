using System;
using System.Collections.Generic;
using TreeAlgorithms.Interfaces;

namespace TreeAlgorithms.Traversers
{
    public class BreadthFirstTraverseCommand
    {

        public void Traverse<T>(ITraversableTreeNode<T> root, Action<T> action)
        {
            Queue<ITraversableTreeNode<T>> queue = new Queue<ITraversableTreeNode<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                action(item.Value);

                foreach (var child in item.Children)
                {
                    queue.Enqueue(child);
                }
            }
        }
    }
}
