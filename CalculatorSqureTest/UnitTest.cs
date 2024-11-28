using CalculatorSqure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorSqureTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CicrleTestSqure()
        {
            var circle = new Circle("Circle", 4);
            var expected = 50.3;
            var actual = circle.CalcSquare();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleTestSqure()
        {
            var triangle = new Triangle("Triangle", 8, 8, 9);
            var expected = 29.8;
            var actual = triangle.CalcSquare();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRectagleTestFalse()
        {
            var triangle = new Triangle("Triangle", 2, 8, 9);
            Assert.IsFalse(triangle.IsRectangular());
        }

        [TestMethod]
        public void IsRectagleTestTrue()
        {
            var triangle = new Triangle("Triangle", 3, 4, 5);
            Assert.IsTrue(triangle.IsRectangular());
        }

    }
}
