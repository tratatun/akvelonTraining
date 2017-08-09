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
            string input = String.Empty;

            string result = TextTools.ReverseSentence(input);

            Assert.AreEqual(String.Empty, result);
        }

        [TestMethod]
        public void OneWordStringTest()
        {
            string input = "Hello";

            string result = TextTools.ReverseSentence(input);

            Assert.AreEqual("Hello", result);
        }

        [TestMethod]
        public void FewWordsStringTest()
        {
            string input = "Hello test world!";

            string result = TextTools.ReverseSentence(input);

            Assert.AreEqual("world! test Hello", result);
        }

        [TestMethod]
        public void NullStringTest()
        {
            string input = null;

            string result = TextTools.ReverseSentence(input);

            Assert.IsNull(result);
        }
    }
}
