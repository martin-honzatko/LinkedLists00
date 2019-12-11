using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class TreeNode<T> where T: IComparable
    {
        internal T value;
 
        internal TreeNode<T> left;
        internal TreeNode<T> right;

        public TreeNode(T value)
        {
            this.value = value;
        }
    }
}
