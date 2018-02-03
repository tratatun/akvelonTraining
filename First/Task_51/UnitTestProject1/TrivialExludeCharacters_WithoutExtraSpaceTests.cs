using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExcluder_starter;

namespace UnitTestProject1
{
    [TestClass]
    public class TrivialExludeCharacters_WithoutExtraSpaceTests
    {
        [TestMethod]
        public void TestEmptyInput()
        {
            string s1 = string.Empty;
            string s2 = string.Empty;

            string result = Program.TrivialExludeCharacters_WithoutExtraSpace(s1, s2);

            Assert.AreEqual(result, string.Empty);
        }

        [TestMethod]
        public void TestEmptyS1Input()
        {
            string s1 = string.Empty;
            string s2 = "Hello world";

            string result = Program.TrivialExludeCharacters_WithoutExtraSpace(s1, s2);

            Assert.AreEqual(result, "Hello world");
        }

        [TestMethod]
        public void TestEmptyS2Input()
        {
            string s1 = "Helw";
            string s2 = string.Empty;

            string result = Program.TrivialExludeCharacters_WithoutExtraSpace(s1, s2);

            Assert.AreEqual(result, string.Empty);
        }

        [TestMethod]
        public void TestNullInput()
        {
            string s1 = null;
            string s2 = "Hello world";
            string err = String.Empty;
            try
            {
                Program.TrivialExludeCharacters_WithoutExtraSpace(s1, s2);
            }
            catch (Exception e)
            {
                err = e.Message;
            }

            Assert.AreEqual(err, "Wrong Input");
        }

        [TestMethod]
        public void TestS1NothingCommonWithS2Input()
        {
            string s1 = "qtyu";
            string s2 = "Hello world";

            string result = Program.TrivialExludeCharacters_WithoutExtraSpace(s1, s2);

            Assert.AreEqual(result, "Hello world");
        }

        [TestMethod]
        public void TestS1MoreCharsThanS2Input()
        {
            string s1 = "qtyu asdl";
            string s2 = "Hell";

            string result = Program.TrivialExludeCharacters_WithoutExtraSpace(s1, s2);

            Assert.AreEqual(result, "He");
        }

        [TestMethod]
        public void TestS1LessCharsThanS2Input()
        {
            string s1 = "dgfw H";
            string s2 = "Hello world";

            string result = Program.TrivialExludeCharacters_WithoutExtraSpace(s1, s2);

            Assert.AreEqual(result, "elloorl");
        }
    }
}
