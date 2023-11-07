using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class TreeNode<T>
    {
        public TreeNode()
        {
        }

        public TreeNode(T data)
        {
            Data = data;
        }

        public TreeNode(T data, TreeNode<T> left, TreeNode<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }



        public T Data { get; set; }
        public TreeNode<T> Parent { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
    }
}
