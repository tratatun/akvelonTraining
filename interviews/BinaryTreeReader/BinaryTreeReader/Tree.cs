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

        // traversal print tree using Dictionary
        public override string ToString()
        {
            string result = String.Empty;
            Dictionary<int, Tree> q1 = new Dictionary<int, Tree>();
            int first = 0, last = 0;
            q1[first] = this;
            while (q1.Any())
            {
                Tree curr = q1.ContainsKey(last) ? q1[last] : null;
                q1.Remove(last--);
                if (curr != null)
                {
                    result += curr.Data + " ";
                    q1.Add(--first, curr.Left);
                    q1.Add(--first, curr.Right);
                }
            }

            return result;
        }
    }
}
