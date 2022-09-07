using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaComputer.Test
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Area_a3b4c5_Returned6()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            bool expectedAngelCheck = true;
            double expected = 6;
            Triangle triangle;
            //act
            triangle = new Triangle(a, b, c);
            //assert
            Assert.AreEqual(expected, triangle.Area);
            Assert.AreEqual(expectedAngelCheck, triangle.HasSquareAngle);
        }

        [TestMethod]
        public void HasSquareAngle_a3b4c5_ReturnedTrue()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            bool expectedAngelCheck = true;
            Triangle triangle;

            //act
            triangle = new Triangle(a, b, c);

            //assert
            Assert.AreEqual(expectedAngelCheck, triangle.HasSquareAngle);
        }

        [TestMethod]
        public void HasSquareAngle_a3b4c6_ReturnedFalse()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 6;
            bool expectedAngelCheck = false;
            Triangle triangle;

            //act
            triangle = new Triangle(a, b, c);

            //assert
            Assert.AreEqual(expectedAngelCheck, triangle.HasSquareAngle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input data")]
        public void TriangleExistanceCheck_a100b4c6_Exception()
        {
            //arrange
            double a = 100;
            double b = 4;
            double c = 6;
            Triangle triangle;

            //act
            triangle = new Triangle(a, b, c);

            //assert
           
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input data")]
        public void SetSides_aMinus3b4c6_ArgumentException()
        {
            //arrange
            double a = -3;
            double b = 4;
            double c = 6;
            Triangle triangle;

            //act
            triangle = new Triangle(a, b, c);

            //assert

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input data")]
        public void SetSides_a0b4c6_ArgumentException()
        {
            //arrange
            double a = 0;
            double b = 4;
            double c = 6;
            Triangle triangle;

            //act
            triangle = new Triangle(a, b, c);

            //assert

        }
    }
}
