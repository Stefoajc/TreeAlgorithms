using System;

namespace TreeAlgorithms
{
    public class RecursiveDepthFirstTraverseCommand
    {
        public void Traverse<T>(ITraversableTreeNode<T> root)
        {
            Console.WriteLine(root.Value);
            foreach (var child in root.Children)
            {
                Traverse(child);
            }
        }
    }
}
