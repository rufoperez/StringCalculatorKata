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
    }
}