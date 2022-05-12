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

        [Test]
        public void when_value_is_2_then_return_2()
        {
            int result = StringCalculator.Add("2");
            Assert.AreEqual(2, result);
        }

        [Test]
        public void when_value_is_1_comma_1_then_return_2()
        {
            int result = StringCalculator.Add("1,1");
            Assert.AreEqual(2, result);
        }

        [Test]
        public void when_value_is_2_comma_3_then_return_5()
        {
            int result = StringCalculator.Add("2,3");
            Assert.AreEqual(5, result);
        }
    }
}