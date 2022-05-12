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
        public void when_value_is_1_then_return_1()
        {
            int result = StringCalculator.Add("1");
            Assert.AreEqual(1, result);
        }
    }
}