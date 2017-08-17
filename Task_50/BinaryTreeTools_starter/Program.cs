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
            
            for (int i = 0; i < 10; i++)
            {
                if (i % 3 == 0)
                {
                    tree = new Tree(i, tree, tree);
                }
                else if (i % 2 == 0)
                {
                    tree = new Tree(i, null, tree);
                }
                else
                {
                    tree = new Tree(i, tree, null);
                }
            }

            Console.WriteLine(tree.GetDepthRecur());

            Console.ReadKey();
        }
    }
}
