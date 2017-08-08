using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTreeTools;
namespace BinaryTreeTools_starter
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Left = new Tree();
            tree.Left.Left = new Tree();
            tree.Left.Left.Right = new Tree();
            tree.Left.Left.Right.Left = new Tree();
            tree.Left.Left.Right.Left.Left = new Tree();
            tree.Left.Left.Right.Left.Left.Right = new Tree();
            tree.Left.Left.Right.Left.Left.Right.Right = new Tree();
            tree.Right = new Tree();
            tree.Right.Left = new Tree();
            tree.Right.Left.Right = new Tree();
            tree.Right.Left.Right.Left = new Tree();
            tree.Right.Left.Right.Left.Right = new Tree();
            tree.Right.Left.Right.Left.Right.Right = new Tree();

            Console.WriteLine(tree.GetDepth());
            Console.WriteLine(tree);

            Console.ReadKey();
        }
    }
}
