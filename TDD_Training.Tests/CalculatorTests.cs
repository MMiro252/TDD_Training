using Moq;
using NUnit.Framework;

namespace TDD_Training.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Test_5MultiplyBy4_Returns20()
        {
            var calculator = new Calculator();
            var result = calculator.Multiply(5, 4);
            Assert.That(result, Is.EqualTo(20));
        }
    }
}
