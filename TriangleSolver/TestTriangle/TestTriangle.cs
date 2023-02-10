//Prince Prajapati
//Professor : Tapas Mandal
//Assignment2


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TestTriangle
{
    public class TestTriangle
    {
        [TestFixture]

        public class TriangleTest1
        {
            Triangle testObject = new Triangle();

            [Test]

            public void AnalyzeTriangle_EquilateralTriangle()
            {
                //Arrange
                int firstSide = 5;
                int secondSide = 5;
                int thirdSide = 5;

                string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";

                //Act
                string actual = testObject.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]

            public void AnalyzeTriangle_IsoscelesTriangle()
            {
                //Arrange
                int firstSide = 3;
                int secondSide = 2;
                int thirdSide = 3;

                string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

                //Act
                string actual = testObject.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_1_IsoscelesTriangle()
            {
                //Arrange
                int firstSide = 2;
                int secondSide = 3;
                int thirdSide = 3;

                string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

                //Act
                string actual = testObject.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_2_IsoscelesTriangle()
            {
                //Arrange
                int firstSide = 3;
                int secondSide = 3;
                int thirdSide = 2;

                string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

                //Act
                string actual = testObject.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}

