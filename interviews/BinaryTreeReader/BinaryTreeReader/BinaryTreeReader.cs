using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace BinaryTreeReader
{
    public class BinaryTreeReader
    {
        public static Tree BuildTree(StreamReader stream)
        {
            if (stream == null)
            {
                throw new FileLoadException();
            }
            bool isInit = true;
            long length = 0, atempts = 0;
            Queue<Tree> trees = new Queue<Tree>();
            Regex regex = new Regex("^[A-Za-z#,\\s]+$");
            Tree seed = new Tree();
            while (!stream.EndOfStream)
            {
                string line = stream.ReadLine();
                string[] treeParts = line?.Split(',');

                if (string.IsNullOrWhiteSpace(line) || !regex.IsMatch(line) || treeParts.Length != 3)
                {
                    throw new InvalidDataException(string.Format("Input data is invalid, line: '{0}'", line));
                }

                if (isInit)
                {
                    seed = Tree.ParseTree(line);
                    isInit = false;
                }

                length++;
                Tree tree = Tree.ParseTree(line);
                trees.Enqueue(tree);
            }

            while (trees.Any())
            {
                seed = GrowSeed(trees, seed);
                atempts++;
                if (atempts > 1 + length * length)
                {
                    throw new InvalidDataException("Input data is invalid, this is not a tree, some nodes are disconnected");
                }
            }
            return seed;
        }
        private static Tree GrowSeed(Queue<Tree> parentList, Tree seed)
        {
            Tree tree = parentList.Dequeue();
            if (seed.Data == tree.Data)
            {
                return seed;
            }

            if (!seed.AddBranch(tree))
            {
                if (tree.Left.Data == seed.Data)
                {
                    tree.Left = seed;
                    return tree;
                }

                if (tree.Right.Data == seed.Data)
                {
                    tree.Right = seed;
                    return tree;
                }

                parentList.Enqueue(tree);
            }
            return seed;
        }

        // creating tree using Dictionary instead Queue
        public static Tree BuildTreeDictionary(StreamReader stream)
        {
            if (stream == null)
            {
                throw new FileLoadException();
            }
            bool isInit = true;
            long length = 0, atempts = 0;
            int first = 0, last = -1;
            Dictionary<int,Tree> trees = new Dictionary<int, Tree>();
            Regex regex = new Regex("^[A-Za-z#,\\s]+$");
            Tree seed = new Tree();
            while (!stream.EndOfStream)
            {
                string line = stream.ReadLine();
                string[] treeParts = line?.Split(',');

                if (string.IsNullOrWhiteSpace(line) || !regex.IsMatch(line) || treeParts.Length != 3)
                {
                    throw new InvalidDataException(string.Format("Input data is invalid, line: '{0}'", line));
                }

                if (isInit)
                {
                    seed = Tree.ParseTree(line);
                    isInit = false;
                }

                length++;
                Tree tree = Tree.ParseTree(line);
                trees.Add(--first, tree);
            }

            while (trees.Any())
            {
                seed = GrowSeedDictionary(trees, seed, ref first, ref last);
                atempts++;
                if (atempts > 1 + length * length)
                {
                    throw new InvalidDataException("Input data is invalid, this is not a tree, some nodes are disconnected");
                }
            }
            return seed;
        }


        // linking tree nodes using Dictionary instead Queue
        private static Tree GrowSeedDictionary(Dictionary<int, Tree> parentList, Tree seed, ref int first, ref int last)
        {
            Tree tree = parentList.ContainsKey(last) ? parentList[last] : null;
            parentList.Remove(last--);
            if (tree != null && seed.Data == tree.Data)
            {
                return seed;
            }

            if (!seed.AddBranch(tree))
            {
                if (tree.Left.Data == seed.Data)
                {
                    tree.Left = seed;
                    return tree;
                }

                if (tree.Right.Data == seed.Data)
                {
                    tree.Right = seed;
                    return tree;
                }

                parentList.Add(--first, tree);
            }
            return seed;
        }
    }
}