using System;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTreeReader.Tests
{
    [TestClass]
    public class BinaryTreeReaderTests
    {
        MemoryStream Stream = new MemoryStream();
        StreamWriter Writer;
        [TestInitialize]
        public void Init()
        {
            Writer = new StreamWriter(Stream);
        }
        [TestMethod]
        public void ReaderReturnIsNotEmptyTest()
        {
            //arrange
            Writer.WriteLine("Brown, #, Over");
            Writer.WriteLine("Fox, The, Lazy");
            Writer.WriteLine("Jumps, Dog, #");
            Writer.WriteLine("Quick, Fox, Jumps");
            Writer.WriteLine("A, Quick, Brown");

            StreamReader sr = new StreamReader(Stream);
            Writer.Flush();
            Stream.Position = 0;

            //act
            Tree tree = BinaryTreeReader.BuildTree(sr);

            //assert
            Assert.IsNotNull(tree);
        }

        [TestMethod]
        public void ReaderReturnsCorrectTreeTest()
        {
            //arrange
            Writer.WriteLine("Brown, #, Over");
            Writer.WriteLine("Fox, The, Lazy");
            Writer.WriteLine("Jumps, Dog, #");
            Writer.WriteLine("Quick, Fox, Jumps");
            Writer.WriteLine("A, Quick, Brown");
            Tree expectedTree = new Tree
            {
                Data = "A",
                Left = new Tree
                {
                    Data = "Quick",
                    Left = new Tree {Data = "Fox",Left = new Tree {Data = "The"},Right = new Tree {Data = "Lazy"}},
                    Right = new Tree {Data = "Jumps",Left = new Tree {Data = "Dog"},Right = new Tree {Data = "#"}}
                },
                Right = new Tree
                {
                    Data = "Brown",
                    Left = new Tree {Data = "#"},
                    Right = new Tree {Data = "Over"}
                }
            };
            StreamReader sr = new StreamReader(Stream);
            Writer.Flush();
            Stream.Position = 0;

            //act
            Tree tree = BinaryTreeReader.BuildTree(sr);

            //assert
            Assert.AreEqual(expectedTree.ToString(), tree.ToString());
        }

        [TestMethod]
        public void ReaderFailsOnDisconnectedTree()
        {
            //arrange
            Writer.WriteLine("Brown, #, Over");
            Writer.WriteLine("Fox, The, Lazy");
            Writer.WriteLine("Jumps, Dog, #");
            Writer.WriteLine("Quick, Fox, JumpsDISCONNECTED");
            Writer.WriteLine("A, Quick, Brown");
            
            StreamReader sr = new StreamReader(Stream);
            Writer.Flush();
            Stream.Position = 0;
            string exceptiomMessage = String.Empty;

            //act
            try
            {
                Tree tree = BinaryTreeReader.BuildTree(sr);

            }
            catch (Exception e)
            {
                exceptiomMessage = e.Message;
            }

            //assert
            Assert.AreEqual(exceptiomMessage, "Input data is invalid, this is not a tree, some nodes are disconnected");
        }

        [TestMethod]
        public void ReaderFailsOnInvalidInput_WrongNumberOfLineParts()
        {
            //arrange
            Writer.WriteLine("Brown, #, Over");
            Writer.WriteLine("Fox,"); // invalid line
            Writer.WriteLine("Jumps, Dog, #");
            Writer.WriteLine("Quick, Fox, Jumps");
            Writer.WriteLine("A, Quick, Brown");

            StreamReader sr = new StreamReader(Stream);
            Writer.Flush();
            Stream.Position = 0;
            string exceptiomMessage = String.Empty;

            //act
            try
            {
                Tree tree = BinaryTreeReader.BuildTree(sr);

            }
            catch (Exception e)
            {
                exceptiomMessage = e.Message;
            }

            //assert
            Assert.AreEqual(exceptiomMessage, "Input data is invalid, line: 'Fox,'");
        }

        [TestMethod]
        public void ReaderFailsOnInvalidInput_NotMatchExpectedRegex()
        {
            //arrange
            Writer.WriteLine("Brown, #, Over");
            Writer.WriteLine("Fox, The, 1Lazy"); // invalid line
            Writer.WriteLine("Jumps, Dog, #");
            Writer.WriteLine("Quick, Fox, Jumps");
            Writer.WriteLine("A, Quick, Brown");

            StreamReader sr = new StreamReader(Stream);
            Writer.Flush();
            Stream.Position = 0;
            string exceptiomMessage = String.Empty;

            //act
            try
            {
                Tree tree = BinaryTreeReader.BuildTree(sr);

            }
            catch (Exception e)
            {
                exceptiomMessage = e.Message;
            }

            //assert
            Assert.AreEqual(exceptiomMessage, "Input data is invalid, line: 'Fox, The, 1Lazy'");
        }

        [TestMethod]
        public void ReaderFailsOnInvalidInput_EmptyStream()
        {
            //arrange
            Writer.WriteLine(""); // invalid line

            StreamReader sr = new StreamReader(Stream);
            Writer.Flush();
            Stream.Position = 0;
            string exceptiomMessage = String.Empty;

            //act
            try
            {
                Tree tree = BinaryTreeReader.BuildTree(sr);

            }
            catch (Exception e)
            {
                exceptiomMessage = e.Message;
            }

            //assert
            Assert.AreEqual(exceptiomMessage, "Input data is invalid, line: ''");
        }

        [TestMethod]
        public void ReaderFailsOnInvalidInput_StreamIsNullThrowsFileLoadException()
        {
            //arrange
            object expected = null;

            //act
            try
            {
                Tree tree = BinaryTreeReader.BuildTree(null);

            }
            catch (FileLoadException e)
            {
                expected = e;
            }
            catch (Exception e)
            {
                Assert.Fail("Raised exception of wrong type");
            }

            //assert
            Assert.IsInstanceOfType(expected, typeof(FileLoadException));

        }

    }
}
