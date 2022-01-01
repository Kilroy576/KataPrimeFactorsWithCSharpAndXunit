using System.Collections.Generic;
using FluentAssertions;
using KataPrimeFactors;
using Xunit;

namespace KataPrimeFactorsTests
{
    public class PrimeFactorsTests
    {
        [Theory]
        [InlineData(2, new int[]{ 2 }, "should contain first prime")]
        [InlineData(3, new int[]{ 3 }, "should contain second prime")]
        [InlineData(4, new int[]{ 2, 2 }, "should contain prime factors from first none prime")]
        [InlineData(5, new int[]{ 5 }, "should contain third prime")]
        [InlineData(6, new int[]{ 2, 3 }, "should contain prime factors from second none prime")]
        [InlineData(8, new int[]{ 2, 2, 2 }, "should contain prime factors 2x2x2")]
        [InlineData(12, new int[]{ 2, 2, 3 }, "should contain prime factors 2x2x3")]
        [InlineData(16, new int[]{ 2, 2, 2, 2 }, "should contain prime factors 2x2x2x2")]
        [InlineData(14, new int[]{ 2, 2, 2, 3 }, "should contain prime factors 2x2x2x3")]
        public void Generate_GetParameterFromData_ReturnExpected(int input, int[] expected, string message)
        {
            var target = new PrimeFactors();

            var actual = target.Generate(input);

            actual.Should().Equal(expected, message);
        }
    }
}