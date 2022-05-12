using NUnit.Framework;
using StringCalculatorKata;

namespace StringCalculatorKataTest
{
    public class StringCalculatorKataSpecs
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void when_value_is_empty_then_return_0()
        {
            int result = StringCalculator.Add("");
            Assert.AreEqual(0, result);
        }

        [Test]
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("3", 3)]
        public void when_value_is_number_then_return_number(string value, int expectedResult)
        {
            int result = StringCalculator.Add(value);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase("1,1", 2)]
        [TestCase("2,2", 4)]
        [TestCase("3,5", 8)]
        public void when_value_are_two_numbers_then_return_sum(string value, int expectedResult)
        {
            int result = StringCalculator.Add(value);
            Assert.AreEqual(expectedResult, result);
        }
    }
}