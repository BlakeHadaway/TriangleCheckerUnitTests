﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace UnitTest
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void Triangle_Equilateral_Valid()
        {
            // Arrange
            int side1 = 4;
            int side2 = 4;
            int side3 = 4;

            string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Triangle_Input_3_3_6_VerifyIsosceles()
        {
            //Arrange
            int side1 = 4;
            int side2 = 4;
            int side3 = 6;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Triangle_Input_9_4_9_VerifyIsosceles()
        {
            //Arrange
            int side1 = 9;
            int side2 = 4;
            int side3 = 9;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Triangle_Input_27_32_32_VerifyIsosceles()
        {
            //Arrange
            int side1 = 27;
            int side2 = 32;
            int side3 = 32;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Triangle_Input_4_6_8_VerifyScalene()
        {
            //Arrange
            int side1 = 4;
            int side2 = 6;
            int side3 = 8;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Triangle_Input_6_10_8_VerifyScalene()
        {
            //Arrange
            int side1 = 6;
            int side2 = 10;
            int side3 = 8;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Triangle_Input_32_27_24_VerifyScalene()
        {
            //Arrange
            int side1 = 32;
            int side2 = 27;
            int side3 = 24;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Triangle_Input_25_23_27_VerifyScalene()
        {
            //Arrange
            int side1 = 25;
            int side2 = 23;
            int side3 = 27;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Triangle_Input_9_15_18_VerifyScalene()
        {
            //Arrange
            int side1 = 29;
            int side2 = 47;
            int side3 = 58;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
