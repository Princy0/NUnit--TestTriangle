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
            [Test]

            public void AnalyzeTriangle_ScaleneTriangle()
            {
                //Arrange
                int firstSide = 2;
                int secondSide = 3;
                int thirdSide = 4;

                string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

                //Act
                string actual = testObject.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_1_ScaleneTriangle()
            {
                //Arrange
                int firstSide = 14;
                int secondSide = 13;
                int thirdSide = 9;

                string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

                //Act
                string actual = testObject.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_2_ScaleneTriangle()
            {
                //Arrange
                int firstSide = 9;
                int secondSide = 13;
                int thirdSide = 14;

                string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

                //Act
                string actual = testObject.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_3_ScaleneTriangle()
            {
                //Arrange
                int firstSide = 15;
                int secondSide = 34;
                int thirdSide = 32;

                string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

                //Act
                string actual = testObject.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_4_ScaleneTriangle()
            {
                //Arrange
                int firstSide = 29;
                int secondSide = 36;
                int thirdSide = 44;

                string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

                //Act
                string actual = testObject.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_InvalidTriangle()
            {
                //Arrange
                int firstSide = 0;
                int secondSide = 3;
                int thirdSide = 4;

                string expected = "At least one side of your triangle has a zero length and is thus invalid";

                //Act
                string actual = testObject.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_2_InvalidTriangle()
            {
                //Arrange
                int firstSide = 0;
                int secondSide = 0;
                int thirdSide = 4;

                string expected = "At least one side of your triangle has a zero length and is thus invalid";

                //Act
                string actual = testObject.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }


            [Test]

            public void AnalyzeTriangle_3_InvalidTriangle()
            {
                //Arrange
                int firstSide = 0;
                int secondSide = 0;
                int thirdSide = 0;

                string expected = "At least one side of your triangle has a zero length and is thus invalid";

                //Act
                string actual = testObject.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_4_InvalidTriangle()
            {
                //Arrange
                int firstSide = -1;
                int secondSide = 3;
                int thirdSide = -4;

                string expected = "Based on the values entered, the triangle is INVALID";

                //Act
                string actual = testObject.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_5_InvalidTriangle()
            {
                //Arrange
                int firstSide = -3;
                int secondSide = -6;
                int thirdSide = 7;

                string expected = "Based on the values entered, the triangle is INVALID";

                //Act
                string actual = testObject.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_6_InvalidTriangle()
            {
                //Arrange
                int firstSide = 8;
                int secondSide = -10;
                int thirdSide = -8;

                string expected = "Based on the values entered, the triangle is INVALID";

                //Act
                string actual = testObject.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}

