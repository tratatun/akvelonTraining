using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordsInSentence;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NullTest()
        {
            string str = null;

            int num = Program.GetBiggestSentence(str);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyTest()
        {
            string str = string.Empty;

            int num = Program.GetBiggestSentence(str);

        }

        [TestMethod]
        public void SimpleTest()
        {
            string str = "asd aasdad. asdasd. asdasd asd asda sdasad. asd asd."; 

            int num = Program.GetBiggestSentence(str);

            Assert.AreEqual(2, num);
        }

        [TestMethod]
        public void MultipleSentenceSeparatorTest()
        {
            string str = "asd aasdad. asdasd!.. asdasd asd asda sdasad. asd asd."; 

            int num = Program.GetBiggestSentence(str);

            Assert.AreEqual(2, num);
        }

        [TestMethod]
        public void MultipleSentenceSeparatorWithoutWordsTest()
        {
            string str = "...."; 

            int num = Program.GetBiggestSentence(str);

            Assert.AreEqual(-1, num);
        }

        [TestMethod]
        public void OneWordTest()
        {
            string str = "d"; 

            int num = Program.GetBiggestSentence(str);

            Assert.AreEqual(0, num);
        }

        [TestMethod]
        public void FewWordsTest()
        {
            string str = "d asd dadad"; 

            int num = Program.GetBiggestSentence(str);

            Assert.AreEqual(0, num);
        }

        [TestMethod]
        public void StartsFromFewSeparatorsTest()
        {
            string str = ".!!d asd dadad. asdasd. asdasd. dasdas adsas adasda asdad! ads dad"; 

            int num = Program.GetBiggestSentence(str);

            Assert.AreEqual(3, num);
        }

        [TestMethod]
        public void SymbolsDevideWordsTest()
        {
            string str = "asd dadad. asdasd. a@s#da$s%d. dasdas adsas adasda asdad! ads dad";

            int num = Program.GetBiggestSentence(str);

            Assert.AreEqual(2, num);
        }
    }
}
