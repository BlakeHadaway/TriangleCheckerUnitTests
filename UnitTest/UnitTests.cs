using System;
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
    }
}
