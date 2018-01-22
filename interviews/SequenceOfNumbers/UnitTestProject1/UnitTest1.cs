using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ZeroInputTest()
        {
            int input = 0;

            string res = Sequences.SequenceOfNumbers.WriteSequence(input);

            Assert.AreEqual("Invalid Input!", res);
        }
        [TestMethod]
        public void OverOneHundredInputTest()
        {
            int input = 101;

            string res = Sequences.SequenceOfNumbers.WriteSequence(input);

            Assert.AreEqual("Invalid Input!", res);
        }
        [TestMethod]
        public void OneInputTest()
        {
            int input = 1;

            string res = Sequences.SequenceOfNumbers.WriteSequence(input);

            Assert.AreEqual("1\n", res);
        }

        [TestMethod]
        public void OddNumberInputTest()
        {
            int input = 5;

            string res = Sequences.SequenceOfNumbers.WriteSequence(input);

            Assert.AreEqual("1*2*3*4*5\n" +
                            "11*12*13*14*15\n" +
                            "21*22*23*24*25\n" +
                            "16*17*18*19*20\n" +
                            "6*7*8*9*10\n", res);
        }

        [TestMethod]
        public void EvenNumberInputTest()
        {
            int input = 4;

            string res = Sequences.SequenceOfNumbers.WriteSequence(input);

            Assert.AreEqual("1*2*3*4\n" +
                            "9*10*11*12\n" +
                            "13*14*15*16\n" +
                            "5*6*7*8\n", res);
        }
    }
}
