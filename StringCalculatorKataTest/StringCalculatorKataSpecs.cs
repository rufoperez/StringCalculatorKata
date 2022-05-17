using System;
using FluentAssertions;
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
        public void when_value_is_empty_then_return_zero()
        {
            var result = StringCalculator.Add(string.Empty);

            result.Should().Be(0);
        }

        [Test]
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("3", 3)]
        public void when_value_is_number_then_return_the_number(string value, int expectedResult)
        {
            var result = StringCalculator.Add(value);

            result.Should().Be(expectedResult);
        }

        [Test]
        [TestCase("1,1", 2)]
        [TestCase("2,3", 5)]
        [TestCase("4,8", 12)]
        public void when_value_are_two_numbers_comma_separated_then_sum_numbers(string value, int expectedResult)
        {
            var result = StringCalculator.Add(value);

            result.Should().Be(expectedResult);
        }

        [Test]
        [TestCase("1,1,1,1", 4)]
        [TestCase("1,2,3,4", 10)]
        public void when_value_are_comma_separated_numbers_then_sum_all_numbers(string value, int expectedResult)
        {
            var result = StringCalculator.Add(value);

            result.Should().Be(expectedResult);
        }

        [Test]
        [TestCase("1\n2\n3,4", 10)]
        [TestCase("1,3,5\n6", 15)]
        public void when_value_are_comma_and_enter_separated_numbers_then_sum_all_numbers(string value, int expectedResult)
        {
            var result = StringCalculator.Add(value);

            result.Should().Be(expectedResult);
        }

        [Test]
        [TestCase("//:\n1:2:3:4", 10)]
        public void when_delimiters_are_informed_then_use_it_as_delimiter(string value, int expectedResult)
        {
            var result = StringCalculator.Add(value);

            result.Should().Be(expectedResult);
        }

        [Test]
        public void when_there_is_a_negative_number_then_return_exception()
        {
            Action sum = () => StringCalculator.Add("-1");

            sum.Should().Throw<Exception>();
        }
    }
}