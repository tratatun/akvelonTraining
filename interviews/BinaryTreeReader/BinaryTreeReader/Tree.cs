using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeReader
{
    public class Tree : IBranchable
    {
        public string Data { get; set; }
        public Tree Left { get; set; }
        public Tree Right { get; set; }

        public bool AddBranch(Tree child)
        {
            if (Left != null)
            {
                if (Left.Data == child.Data)
                {
                    Left = child;
                    return true;
                }
                if (Left.AddBranch(child))
                {
                    return true;
                }
            }

            if (Right != null)
            {
                if (Right.Data == child.Data)
                {
                    Right = child;
                    return true;
                }
                if (Right.AddBranch(child))
                {
                    return true;
                }
            }

            return false;
        }

        public static Tree ParseTree(string line)
        {
            string[] treeParts = line.Split(',');

            return new Tree
            {
                Data = treeParts[0].Trim(),
                Left = new Tree { Data = treeParts[1].Trim() },
                Right = new Tree { Data = treeParts[2].Trim() }
            };
        }

        public override string ToString()
        {
            string result = String.Empty;
            Queue<Tree> q = new Queue<Tree>();
            q.Enqueue(this);
            while (q.Any())
            {
                Tree curr = q.Dequeue();
                if (curr != null)
                {
                    result += curr.Data + " ";
                    q.Enqueue(curr.Left);
                    q.Enqueue(curr.Right);
                }
            }
            return result;
        }
    }
}
