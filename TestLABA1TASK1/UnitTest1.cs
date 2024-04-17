using RationalNumberExample;
using Xunit;

namespace RationalNumberExample.Tests
{
    public class RationalNumberTests
    {
        [Fact]
        public void AdditionTest()
        {
            RationalNumber r1 = new RationalNumber(1, 2);
            RationalNumber r2 = new RationalNumber(1, 3);

            RationalNumber result = r1 + r2;
            RationalNumber result2 = new RationalNumber(5,6);


            Assert.True(result==result2);
        }

        [Fact]
        public void SubtractionTest()
        {
            RationalNumber r1 = new RationalNumber(3, 4);
            RationalNumber r2 = new RationalNumber(1, 2);

            RationalNumber result = r1 - r2;
            RationalNumber result2 = new RationalNumber(1, 4);

            Assert.True(result2==result);
        }

        [Fact]
        public void MultiplicationTest()
        {
            RationalNumber r1 = new RationalNumber(2, 3);
            RationalNumber r2 = new RationalNumber(3, 4);

            RationalNumber result = r1 * r2;
            RationalNumber result2= new RationalNumber(1, 2);

            Assert.True(result2==result);
        }

        [Fact]
        public void DivisionTest()
        {
            RationalNumber r1 = new RationalNumber(1, 2);
            RationalNumber r2 = new RationalNumber(2, 3);

            RationalNumber result = r1 / r2;
            RationalNumber result2 = new RationalNumber(3, 4);

            Assert.True(result==result2);
        }

        [Fact]
        public void NegationTest()
        {
            RationalNumber r = new RationalNumber(3, 4);

            RationalNumber result = -r;
            RationalNumber result2 = new RationalNumber(-3, 4);

            Assert.True(result2==result);
        }

        [Fact]
        public void EqualityTest()
        {
            RationalNumber r1 = new RationalNumber(3, 4);
            RationalNumber r2 = new RationalNumber(6, 8);

            Assert.True(r1== r2);
        }

        [Fact]
        public void LessThanTest()
        {
            RationalNumber r1 = new RationalNumber(1, 2);
            RationalNumber r2 = new RationalNumber(3, 4);

            Assert.True(r1 < r2);
        }
    }
}