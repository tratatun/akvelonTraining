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

            Tree tree = new Tree();
            tree.Left = new Tree();
            tree.Left.Left = new Tree();
            tree.Left.Left.Right = new Tree();
            tree.Left.Left.Right.Left = new Tree();
            tree.Right = new Tree();
            tree.Right.Left = new Tree();
            tree.Right.Left.Right = new Tree();

            int depth = tree.GetDepth();

            Assert.AreEqual(depth, 5);

        }
    }
}
