using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeavesOnSameLevel;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullTest()
        {
            //assign
            Tree root = null;
            int level = 0;
            //act
            
            bool isTheSameLevel = root.IsLeavesAtSameLevel();
            //assert
        }

        [TestMethod]
        public void SameLevelTest()
        {
            //assign
            Tree root = new Tree(1);
            root.Left = new Tree(2);
            root.Right = new Tree(3);

            root.Left.Left = new Tree(4);
            root.Left.Left.Left = new Tree(55);
            root.Right.Left = new Tree(8);
            root.Right.Left.Left = new Tree(77);
            //act
            bool result = root.IsLeavesAtSameLevel();

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DifferentLevelTest()
        {
            //assign
            Tree root = new Tree(1);
            root.Left = new Tree(2);
            root.Right = new Tree(3);

            root.Left.Left = new Tree(4);
            root.Left.Left.Left = new Tree(55);
            root.Right.Left = new Tree(8);
            root.Right.Left.Left = new Tree(77);
            root.Right.Left.Left.Left = new Tree(44);
            //act
            bool result = root.IsLeavesAtSameLevel();

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void OneLevelTest()
        {
            //assign
            Tree root = new Tree(1);
            //act
            bool result = root.IsLeavesAtSameLevel();

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LevelTest()
        {
            //assign
            Tree root = new Tree(1);
            root.Left = new Tree(2);
            root.Right = new Tree(3);

            root.Left.Left = new Tree(4);
            root.Left.Left.Left = new Tree(55);
            root.Right.Left = new Tree(8);
            root.Right.Left.Left = new Tree(77);
            root.Right.Left.Left.Left = new Tree(44);
            //act
            bool result = root.IsLeavesAtSameLevel();

            //assert
            Assert.IsFalse(result);
        }

    }
}
