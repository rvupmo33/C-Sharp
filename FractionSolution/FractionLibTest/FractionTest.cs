using System;
using NUnit.Framework;
using ClassLibrary1;


namespace FractionLibTest
{
    [TestFixture]
    public class FractionTest
    {
        [Test]
        public void Constructor_WithZeroArgument()
        {
            //arrange
            int expectedTop = 0;
            int expectedBottom = 1;
            
            //act
            Frac result = new Frac();
            
            //assert
            Assert.AreEqual(expectedTop, result.Top);
            Assert.AreEqual(expectedBottom, result.Bottom);
        }

        [Test]
        public void Constructor_WithOneArgument()
        {
            //arrange
            int expectedTop = 10;
            int expectedBottom = 1;

            //act
            Frac result = new Frac(expectedTop);

            //assert
            Assert.AreEqual(expectedTop, result.Top);
            Assert.AreEqual(expectedBottom, result.Bottom);
        }
    }
}