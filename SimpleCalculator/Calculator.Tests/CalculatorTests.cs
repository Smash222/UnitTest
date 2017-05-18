using NUnit.Framework;



namespace Calculator.Tests
{
    [TestFixture]
    public class SimpleCalculatortests
    {
      
        [Test]
        public void ShouldAddTwoNumbers()
        {
            var sut = new SimpleCalculator();

            var result = sut.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void ShouldMultiplyTwoNumbers()
        {
            var sut = new SimpleCalculator();

            var result = sut.Multiply(2, 10);

            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void ShouldAddInts()
        {
            var sut = new SimpleCalculator();

            var result = sut.AddInts(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void ShouldAddDoubles_WithTolerance()
        {
            var sut = new SimpleCalculator();

            var result = sut.AddDoubles(1.1, 2.2);

            //between 3.1 + .21 OR 3.1 -.21
            Assert.That(result, Is.EqualTo(3.1).Within(0.21));
        }

        [Test]
        public void ShouldAddDoubles_WithPercentTolerance()
        {
            var sut = new SimpleCalculator();

            var result = sut.AddDoubles(25, 25);

            //between 45 + 15% Or 45 -15%
            Assert.That(result, Is.EqualTo(45).Within(15).Percent);
        }


        [Test]
        public void ShouldAddDoubles_WithBadTolerance()
        {
            var sut = new SimpleCalculator();

            var result = sut.AddDoubles(1.1, 2.2);

            // Bad test. double check tolerance values. 
            Assert.That(result, Is.EqualTo(30).Within(100));
        }


        [Test]
        public void ShouldDivide()
        {
            var sut = new SimpleCalculator();

            var result = sut.Divide(10, 2);

            Assert.That(result, Is.EqualTo(5));
        }
    }
}
