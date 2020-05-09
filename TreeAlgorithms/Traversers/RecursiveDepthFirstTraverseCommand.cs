using System;
using TreeAlgorithms.Interfaces;

namespace TreeAlgorithms.Traversers
{
    public class RecursiveDepthFirstTraverseCommand
    {
        public void Traverse<T>(ITraversableTreeNode<T> root, Action<T> action)
        {
            action(root.Value);
            foreach (var child in root.Children)
            {
                Traverse(child, action);
            }
        }
    }
}
