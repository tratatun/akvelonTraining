using System;
using System.IO;
using System.Text;
using BingTestTask;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestSorted
    {
        [TestMethod]
        public void TestFileStreamEmpty()
        {
            string data = "", err = string.Empty;
            try
            {
                using (MemoryStream file = new MemoryStream(Encoding.UTF8.GetBytes(data)))
                {
                    StreamReader sr = new StreamReader(file);
                    string res = CsvDuplicateReader.GetDuplicatesFromSortedFile(sr, "column1");
                }
            }
            catch (Exception e)
            {
                err = e.Message;
            }

            Assert.AreEqual("File load error", err);
        }

        [TestMethod]
        public void TestFileStream()
        {
            string data = "column1,column2\n" +
                          "1,a\r\n" +
                          "1,b\r\n" +
                          "1,c\r\n" +
                          "2,d\r\n" +
                          "3,d\r\n" +
                          "4,d\r\n" +
                          "4,e\r\n";
            string result;
            using (MemoryStream file = new MemoryStream(Encoding.UTF8.GetBytes(data)))
            {
                StreamReader sr = new StreamReader(file);
                result = CsvDuplicateReader.GetDuplicatesFromSortedFile(sr, "column1");
            }

            Assert.AreEqual("column1,column2\r\n" +
                                        "1,a\r\n" +
                                        "1,b\r\n" +
                                        "1,c\r\n" +
                                        "4,d\r\n" +
                                        "4,e\r\n"
                , result);
        }
        [TestMethod]
        public void TestFileStreamColumn2()
        {
            string data = "column1,column2\n" +
                          "1,a\r\n" +
                          "1,b\r\n" +
                          "1,c\r\n" +
                          "2,d\r\n" +
                          "3,d\r\n" +
                          "4,d\r\n" +
                          "4,e\r\n";
            string result;
            using (MemoryStream file = new MemoryStream(Encoding.UTF8.GetBytes(data)))
            {
                StreamReader sr = new StreamReader(file);
                result = CsvDuplicateReader.GetDuplicatesFromSortedFile(sr, "column2");
            }

            Assert.AreEqual("column1,column2\r\n" +
                            "2,d\r\n" +
                            "3,d\r\n" +
                            "4,d\r\n"
                , result);
        }
        [TestMethod]
        public void TestFileStreamNoDuplicates()
        {
            string data = "column1,column2\n" +
                          "1,a\r\n" +
                          "4,e\r\n" +
                          "2,d\r\n" +
                          "3,d\r\n" +
                          "5,d\r\n";
            string result;
            using (MemoryStream file = new MemoryStream(Encoding.UTF8.GetBytes(data)))
            {
                StreamReader sr = new StreamReader(file);
                result = CsvDuplicateReader.GetDuplicatesFromSortedFile(sr, "column1");
            }

            Assert.AreEqual("column1,column2\r\n"
                , result);
        }

        [TestMethod]
        public void TestWrongColumnName()
        {
            string data = "column1,column2\n" +
                          "1,a\r\n" +
                          "3,d\r\n" +
                          "1,b\r\n" +
                          "4,d\r\n", err = string.Empty;
            try
            {
                using (MemoryStream file = new MemoryStream(Encoding.UTF8.GetBytes(data)))
                {
                    StreamReader sr = new StreamReader(file);
                    string res = CsvDuplicateReader.GetDuplicatesFromSortedFile(sr, "column555");
                }
            }
            catch (Exception e)
            {
                err = e.Message;
            }

            Assert.AreEqual("Column doesn't exist", err);
        }
    }
}
