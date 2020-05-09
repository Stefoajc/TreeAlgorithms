using System.Collections.Generic;

namespace TreeAlgorithms
{
    public interface ITraversableTreeNode<T>
    {
        public T Value { get; }
        public ICollection<ITraversableTreeNode<T>> Children { get;}
    }
}
