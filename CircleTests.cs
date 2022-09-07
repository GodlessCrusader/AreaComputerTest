using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaComputer.Test
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Area_radius5_Returned25xPi()
        {
            //arrange
            double radius = 5;
            double expected = 25 * Math.PI;
            Circle circle;
            
            //act
            circle = new Circle(radius);
            
            //assert
            Assert.AreEqual(expected, circle.Area);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input data")]
        public void Radius_radius0_ArgumentException()
        {
            //arrange
            double radius = 0;
            Circle circle;

            //act
            circle = new Circle(radius);

            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input data")]
        public void Radius_radiusLessThen0_ArgumentException()
        {
            //arrange
            double radius = -1;
            Circle circle;

            //act
            circle = new Circle(radius);

            //assert
        }
    }
}
