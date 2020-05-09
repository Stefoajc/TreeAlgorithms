namespace TreeAlgorithms
{
    public interface IBinaryTreeNode<T>
    {
        public T Value { get; }

        public IBinaryTreeNode<T>? Left { get; set; }
        public IBinaryTreeNode<T>? Right { get; set; }
    }
}
