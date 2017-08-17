using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeTools
{
    public class Tree
    {
        public int Data;
        public Tree Left;
        public Tree Right;

        public Tree()
        {
        }

        public Tree(int data, Tree left = null, Tree right = null)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        public int GetDepthRecur()
        {
            int lDepth = 0, rDepth = 0;
            if (Left != null)
            {
                lDepth = Left.GetDepthRecur();
            }
            if (Right != null)
            {
                rDepth = Right.GetDepthRecur();
            }
            if (rDepth > lDepth)
            {
                return rDepth + 1;
            }
            return lDepth + 1;
        }
    }
}
