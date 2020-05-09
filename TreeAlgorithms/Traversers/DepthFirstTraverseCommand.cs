using System;
using System.Collections.Generic;
using System.Linq;
using TreeAlgorithms.Interfaces;

namespace TreeAlgorithms.Traversers
{
    public class DepthFirstTraverseCommand
    {
        public void Traverse<T>(ITraversableTreeNode<T> root, Action<T> action)
        {
            Stack<ITraversableTreeNode<T>> queue = new Stack<ITraversableTreeNode<T>>();
            queue.Push(root);

            while (queue.Count > 0)
            {
                var item = queue.Pop();
                action(item.Value);

                foreach (var child in item.Children.Reverse())
                {
                    queue.Push(child);
                }
            }
        }
    }
}
