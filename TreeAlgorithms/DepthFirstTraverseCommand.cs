using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeAlgorithms
{
    public class DepthFirstTraverseCommand
    {
        public void Traverse<T>(ITraversableTreeNode<T> root)
        {
            Stack<ITraversableTreeNode<T>> queue = new Stack<ITraversableTreeNode<T>>();
            queue.Push(root);

            while (queue.Count > 0)
            {
                var item = queue.Pop();
                Console.WriteLine(item.Value);

                foreach (var child in item.Children.Reverse())
                {
                    queue.Push(child);
                }
            }
        }
    }
}
