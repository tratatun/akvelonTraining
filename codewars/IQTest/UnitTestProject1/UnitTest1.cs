using IQTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(3, Program.Test("2 4 7 8 10"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(1, Program.Test("1 2 2"));
        }

        [TestMethod]
        public void Test10()
        {
            Assert.AreEqual(32, Program.Test("9 31 27 93 17 77 75 9 9 53 89 39 51 99 5 1 11 39 27 49 91 17 27 79 81 71 37 75 35 13 93 4 99 55 85 11 23 57 5 43 5 61 15 35 23 91 3 81 99 85 43 37 39 27 5 67 7 33 75 59 13 71 51 27 15 93 51 63 91 53 43 99 25 47 17 71 81 15 53 31 59 83 41 23 73 25 91 9"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(4, Program.Test("88 96 66 51 14 88 2 92 18 72 18 88 20 30 4 82 90 100 24 46"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(2, Program.Test("100 99 100"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(3, Program.Test("5 3 2"));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(2, Program.Test("43 28 1 91"));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(26, Program.Test("20 94 56 50 10 98 52 32 14 22 24 60 4 8 98 46 34 68 82 82 98 90 50 20 78 49 52 94 64 36"));
        }

        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual(48, Program.Test("79 27 77 57 37 45 27 49 65 33 57 21 71 19 75 85 65 61 23 97 85 9 23 1 9 3 99 77 77 21 79 69 15 37 15 7 93 81 13 89 91 31 45 93 15 97 55 80 85 83"));
        }

        [TestMethod]
        public void Test9()
        {
            Assert.AreEqual(3, Program.Test("100 100 1"));
        }


    }
}
