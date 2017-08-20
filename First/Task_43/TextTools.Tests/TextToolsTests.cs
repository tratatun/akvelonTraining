using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextTools.Tests
{
    [TestClass]
    public class TextToolsTests
    {
        [TestMethod]
        public void EmptyStringTest()
        {
            char[] input = String.Empty.ToCharArray();

            char[] result = TextTools.ReverseSentence(input);

            CollectionAssert.AreEqual(String.Empty.ToCharArray(), result);
        }

        [TestMethod]
        public void OneWordStringTest()
        {
            char[] input = "Hello".ToCharArray();

            char[] result = TextTools.ReverseSentence(input);

            CollectionAssert.AreEqual("Hello".ToCharArray(), result);
        }

        [TestMethod]
        public void FewWordsStringTest()
        {
            char[] input = "Hello test world!".ToCharArray();

            char[] result = TextTools.ReverseSentence(input);

            CollectionAssert.AreEqual("world! test Hello".ToCharArray(), result);
        }

        [TestMethod]
        public void WordSeparatedMoreThanOneSpaceTest()
        {
            char[] input = "Hello   tes   t world!".ToCharArray();

            char[] result = TextTools.ReverseSentence(input);

            CollectionAssert.AreEqual("world! t   tes   Hello".ToCharArray(), result);
        }

        [TestMethod]
        public void NullStringTest()
        {
            char[] input = null;

            char[] result = TextTools.ReverseSentence(input);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void OneSpaceTest()
        {
            char[] input = " ".ToCharArray();

            char[] result = TextTools.ReverseSentence(input);

            CollectionAssert.AreEqual(" ".ToCharArray(), result);
        }

        [TestMethod]
        public void FewSpacesTest()
        {
            char[] input = "   ".ToCharArray();

            char[] result = TextTools.ReverseSentence(input);

            CollectionAssert.AreEqual("   ".ToCharArray(), result);
        }
    }
}
