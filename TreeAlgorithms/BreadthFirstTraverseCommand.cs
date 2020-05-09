using System;
using System.Collections.Generic;

namespace TreeAlgorithms
{
    public class BreadthFirstTraverseCommand
    {

        public void Traverse<T>(ITraversableTreeNode<T> root)
        {
            Queue<ITraversableTreeNode<T>> queue = new Queue<ITraversableTreeNode<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                Console.WriteLine(item.Value);

                foreach (var child in item.Children)
                {
                    queue.Enqueue(child);
                }
            }
        }
    }
}
