using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterCaseConverter.Tests
{
    [TestClass]
    public class CharacterCaseConverterTests
    {
        [TestMethod]
        public void OneCharacterTest()
        {
            char[] arr = {'e'};

            char[] result = CharacterCaseConverter.ToUpper(arr);

            CollectionAssert.AreEqual(new []{'E'}, result);
        }

        [TestMethod]
        public void EmpltyArrayTest()
        {
            char[] arr = new char[0];

            char[] result = CharacterCaseConverter.ToUpper(arr);

            CollectionAssert.AreEqual(new char[0] , result);
        }

        [TestMethod]
        public void UpperCaseTest()
        {
            char[] arr = {'D','G'};

            char[] result = CharacterCaseConverter.ToUpper(arr);

            CollectionAssert.AreEqual(new []{ 'D','G'}, result);
        }


        [TestMethod]
        public void ConvertLowerToUpperTest()
        {
            char[] arr = { 'f', 'g', 'e', 'q', 'z' };

            char[] result = CharacterCaseConverter.ToUpper(arr);

            CollectionAssert.AreEqual(new[] { 'F', 'G', 'E', 'Q', 'Z' }, result);
        }

    }
}
