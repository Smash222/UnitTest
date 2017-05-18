
using NUnit.Framework;
namespace AssertDemo.Tests
{
    [TestFixture]
    public class NameJoinerTests
    {
        [Test]
        public void ShouldJoinNames()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("John", "Smith");

            Assert.That(fullName, Is.EqualTo("John Smith"));
        }

        [Test]
        public void ShouldJoinNames_CaseSensitive()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("john", "smith");

            // will return fail
            // demo purposes
            Assert.That(fullName, Is.EqualTo("JOHN SMITH").IgnoreCase);
        }

        [Test]
        public void ShouldJoinNames_NotEqual()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("john", "smith");

            Assert.That(fullName, Is.EqualTo("Guy Smith"));
        }


    }
}
