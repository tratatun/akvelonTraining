using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeavesOnSameLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Check if all leaves are at same level
            /// Recursive
            //int n = int.Parse(Console.ReadLine());
            Tree root = null, current = root;
            root = new Tree(0);
            root.Left = new Tree(1);
            root.Right = new Tree(2);
            root.Left.Left = new Tree(3);
            root.Left.Right = new Tree(4);

            root.Right.Left = new Tree(5);
            root.Right.Right = new Tree(6);

            root.Right.Right.Left = new Tree(7);
            bool isTheSame = root.IsLeavesAtSameLevel();
            Console.WriteLine(isTheSame);
        }
    }

    public class Tree
    {
        public Tree Left { get; set; }
        public Tree Right { get; set; }
        public int Data { get; set; }
        public Tree(int data)
        {
            Data = data;
        }

        public bool IsLeavesAtSameLevel()
        {
            int level = 0;
            return CheckIsLeavesAtSameLevel(this, ref level, 0);
        }
        private static bool CheckIsLeavesAtSameLevel(Tree root, ref int level, int current)
        {
            if(root == null)
            {
                return true;
            }
            if (root.Left == null && root.Right == null)
            {
                if (level == 0)
                {
                    level = current;
                    return true;
                }

                return level == current;
            }

            return CheckIsLeavesAtSameLevel(root.Left, ref level, current + 1) && CheckIsLeavesAtSameLevel(root.Right, ref level, current + 1);
        }
    }
}
