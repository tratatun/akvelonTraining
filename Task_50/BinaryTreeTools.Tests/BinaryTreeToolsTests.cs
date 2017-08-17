using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTreeTools.Tests
{
    [TestClass]
    public class BinaryTreeToolsTests
    {
        [TestMethod]
        public void TreeDepthTest()
        {

            Tree tree = new Tree(5);
            for (int i = 0; i < 10; i++)
            {
                tree = new Tree(i, tree, tree);
            }

            int depth = tree.GetDepthRecur();

            Assert.AreEqual(depth, 11);

        }
    }
}
