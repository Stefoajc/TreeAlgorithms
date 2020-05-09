using System;
using System.Collections.Generic;
using System.Text;

namespace TreeAlgorithms
{
    public class BinaryTreeNode<T> : IBinaryTreeNode<T>
    {
        public BinaryTreeNode(T value)
        {
            Value = value;
        }

        public T Value { get; }

        public IBinaryTreeNode<T>? Left { get; set; }
        public IBinaryTreeNode<T>? Right { get; set; }
    }
}
