using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Triangle.Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleCheck_5and3and6_returnedTrue()
        {
            float a = 0;
            float b = 3; 
            float c = 6;
            bool expected = true;

            TriangleC t = new TriangleC();
            bool actual = t.TriangleCheck(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleCheck_10and0and10_returnedFalse()
        {
            float a = 10;
            float b = 0;
            float c = 10;
            bool expected = false;

            TriangleC t = new TriangleC();
            bool actual = t.TriangleCheck(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleCheck_0and10and10_returnedFalse()
        {
            float a = 0;
            float b = 10;
            float c = 10;
            bool expected = false;

            TriangleC t = new TriangleC();
            bool actual = t.TriangleCheck(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleCheck_10and10and0_returnedFalse()
        {
            float a = 10;
            float b = 10;
            float c = 0;
            bool expected = false;

            TriangleC t = new TriangleC();
            bool actual = t.TriangleCheck(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleCheck_0and0and10_returnedFalse()
        {
            float a = 0;
            float b = 0;
            float c = 10;
            bool expected = false;

            TriangleC t = new TriangleC();
            bool actual = t.TriangleCheck(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleCheck_0and10and0_returnedFalse()
        {
            float a = 0;
            float b = 10;
            float c = 0;
            bool expected = false;

            TriangleC t = new TriangleC();
            bool actual = t.TriangleCheck(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleCheck_10and0and0_returnedFalse()
        {
            float a = 10;
            float b = 0;
            float c = 0;
            bool expected = false;

            TriangleC t = new TriangleC();
            bool actual = t.TriangleCheck(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleCheck_1and2and5_returnedFalse()
        {
            float a = 1;
            float b = 2;
            float c = 5;
            bool expected = false;

            TriangleC t = new TriangleC();
            bool actual = t.TriangleCheck(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleCheck_10andMinus3and8_returnedFalse()
        {
            float a = 10;
            float b = -3;
            float c = 8;
            bool expected = false;

            TriangleC t = new TriangleC();
            bool actual = t.TriangleCheck(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleCheck_5and5andMinus5_returnedFalse()
        {
            float a = 5;
            float b = 5;
            float c = -5;
            bool expected = false;

            TriangleC t = new TriangleC();
            bool actual = t.TriangleCheck(a, b, c);

            Assert.AreEqual(expected, actual);
        }

    }
}
