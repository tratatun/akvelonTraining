using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrawTools.Tests
{
    [TestClass]
    public class DrawToolsTests
    {
        [TestMethod]
        public void DrawCircleReturnsDataTest()
        {
            int R = 1;

            List<Pixel> list = DrawTools.DrawCircle(R);

            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void DrawCircleReturnsCorrectValueTest()
        {
            int R = 1;
            List<string> checkList = new List<string>
            {
                new Pixel(0, 1).ToString(),
                new Pixel(0, -1).ToString(),
                new Pixel(0, 1).ToString(),
                new Pixel(0, -1).ToString(),
                new Pixel(1, 1).ToString(),
                new Pixel(1, -1).ToString(),
                new Pixel(-1, 1).ToString(),
                new Pixel(-1, -1).ToString(),
                new Pixel(1, 0).ToString(),
                new Pixel(1, 0).ToString(),
                new Pixel(-1, 0).ToString(),
                new Pixel(-1, 0).ToString(),
            };

            List<string> list = DrawTools.DrawCircle(R).Select(x=>x.ToString()).ToList();

            CollectionAssert.AreEquivalent(checkList, list);
        }

        [TestMethod]
        public void DrawCircleRadiusIsZeroTest()
        {
            int R = 0;

            List<Pixel> list = DrawTools.DrawCircle(R);

            CollectionAssert.AreEquivalent(new List<Pixel>(), list);
        }

        [TestMethod]
        public void DrawCircleRadiusIsNegativeTest()
        {
            int R = -10;

            List<Pixel> list = DrawTools.DrawCircle(R);

            CollectionAssert.AreEquivalent(new List<Pixel>(), list);
        }

    }
}
