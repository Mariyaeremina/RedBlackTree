using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBlackTreeSolution
{
    public class Node<T>
    {
        public T Key;
        public Node<T> LeftChild;
        public Node<T> RightChild;
        public Node<T> Parent;
        public char Color;

        public Node(T element, Node<T> parent)
        {
            Key = element;
            Parent = parent;
            Color = 'R';
            LeftChild = null;
            RightChild = null;
        }
    }
}

