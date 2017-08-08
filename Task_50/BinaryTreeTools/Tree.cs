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

        public int GetDepth()
        {
            int lDepth = 0, rDepth = 0;
            if (Left != null)
            {
                lDepth = Left.GetDepth();
            }
            if (Right != null)
            {
                rDepth = Right.GetDepth();
            }
            if (rDepth > lDepth)
            {
                return rDepth + 1;
            }
            return lDepth + 1;
        }
    }
}
