﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTreeReader;

namespace RunTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader("..\\..\\inputData\\inputData.txt");
            //Tree tree = BinaryTreeReader.BinaryTreeReader.BuildTree(stream);
            Tree tree = BinaryTreeReader.BinaryTreeReader.BuildTreeDictionary(stream);
            //Console.Write(tree.ToString());
            Console.Write(tree.ToStringDictionary());
            Console.ReadKey();
        }
    }
}
