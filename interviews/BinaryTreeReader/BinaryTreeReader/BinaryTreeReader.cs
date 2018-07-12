using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace BinaryTreeReader
{
    public class BinaryTreeReader
    {
        // creating tree using Dictionary instead Queue
        public static Tree BuildTree(StreamReader stream)
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

                length++;
                Tree tree = Tree.ParseTree(line);
                trees.Add(--first, tree);
            }

            if (length > 0)
            {
                seed = trees[-1];
            }

            while (trees.Count > 0)
            {
                seed = GrowSeed(trees, seed, ref first, ref last);
                atempts++;
                if (atempts > 1 + length * length)
                {
                    throw new InvalidDataException("Input data is invalid, this is not a tree, some nodes are disconnected");
                }
            }
            return seed;
        }

        // linking tree nodes using Dictionary
        private static Tree GrowSeed(Dictionary<int, Tree> parentList, Tree seed, ref int first, ref int last)
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