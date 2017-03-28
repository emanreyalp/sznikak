using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape.Library;

namespace Shape.Library.Tests
{
    [TestFixture]
    public class ShapesTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.Pass();
        }

        [Test]
        public void SetXforCircle([Values(0,1,12)] int x)
        {
            int y = 0;
            Circle c = new Circle(x, y);
            Assert.AreEqual(x, c.GetX());
        }

        [Test]
        public void SetYforCicle([Values(1)] int y)
        {
            int x = 0;
            Circle c = new Circle(x, y);
            Assert.AreEqual(y, c.GetY());
        }

        [Test]
        public void GetTypeforCircle()
        {
            Circle c = new Circle(0, 0);
            Assert.AreEqual("Circle", c.GetType());
        }

        [Test]
        public void GetAreaforCicle([Values(1,2,3)] int r)
        {
            Circle c = new Circle(0, 0, r);
            double expectedArea = r * r * 3.14; 
            Assert.AreEqual(expectedArea, c.GetArea());
        }

        [Test]
        public void GetInfoforCircle()
        {
            Circle c = new Circle(1, 2, 3);
            string expectedInfo = "";
            Assert.AreEqual(expectedInfo, c.GetInfo());
        }


    }
}
