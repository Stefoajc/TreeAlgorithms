using System;
using System.Collections.Generic;
using TreeAlgorithms.Traversers;
using TreeAlgorithms.Types;

namespace TreeAlgorithms
{
    class Program
    {
        static void Main()
        {
            TreeNodeWithoutParent<int> root = CreateExampleTree();

            var traverseCommand = new DepthFirstTraverseCommand();

            var list = new List<int>();
            Action<int> actionToExecute = (int x) => list.Add(x);

            traverseCommand.Traverse(root, actionToExecute);

            list.ForEach(x => Console.WriteLine(x));
        }


        private static TreeNodeWithoutParent<int> CreateExampleTree()
        {
            var node19 = new TreeNodeWithoutParent<int>(19);
            node19.Children.Add(new TreeNodeWithoutParent<int>(1));
            node19.Children.Add(new TreeNodeWithoutParent<int>(12));
            node19.Children.Add(new TreeNodeWithoutParent<int>(31));

            var node21 = new TreeNodeWithoutParent<int>(21);

            var node14 = new TreeNodeWithoutParent<int>(14);
            node14.Children.Add(new TreeNodeWithoutParent<int>(23));
            node14.Children.Add(new TreeNodeWithoutParent<int>(6));

            var root = new TreeNodeWithoutParent<int>(7);
            root.Children.Add(node19);
            root.Children.Add(node21);
            root.Children.Add(node14);
            return root;
        }
    }
}
