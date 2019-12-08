using Work;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Work.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void Circle_areaTest()
        {
            double radius = 2 * Math.PI * Math.PI;
            Assert.AreEqual(Biblio.Circle_area(2), radius);
        }

        [TestMethod()]
        public void Triangle_AreaTest()
        {
            double a = 24;
            double b = 10;
            double c = 26;
            Assert.AreEqual(Biblio.Triangle_Area(a, b, c), 120);
        }

        [TestMethod()]
        public void IsTriangleRealTest()
        {
            double a = 24;
            double b = 10;
            double c = 26;
            Assert.AreEqual(Biblio.IsTriangleReal(24, 10, 26),true);
        }
    }
}

