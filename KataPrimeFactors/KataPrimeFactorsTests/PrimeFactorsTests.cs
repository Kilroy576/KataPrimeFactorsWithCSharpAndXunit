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
        [InlineData(7, new int[]{ 7 }, "should contain 4. prime")]
        [InlineData(8, new int[]{ 2, 2, 2 }, "should contain prime factors 2x2x2")]
        [InlineData(9, new int[]{ 3, 3 }, "should contain prime factors 3x3")]
        [InlineData(10, new int[]{ 2, 5 }, "should contain prime factors 2x5")]
        [InlineData(11, new int[]{ 11 }, "should contain 5. prime")]
        [InlineData(12, new int[]{ 2, 2, 3 }, "should contain prime factors 2x2x3")]
        [InlineData(13, new int[]{ 13 }, "should contain 6. prime")]
        [InlineData(14, new int[]{ 2, 7 }, "should contain prime factors 2x7")]
        [InlineData(15, new int[]{ 3, 5 }, "should contain prime factors 3x5")]
        [InlineData(16, new int[]{ 2, 2, 2, 2 }, "should contain prime factors 2x2x2x2")]
        [InlineData(17, new int[]{ 17 }, "should contain 7. prime")]
        [InlineData(18, new int[]{ 2, 3, 3 }, "should contain prime factors 2x3x3")]
        [InlineData(19, new int[]{ 19 }, "should contain 8. prime")]
        [InlineData(20, new int[]{ 2, 2, 5 }, "should contain prime factors 2x2x5")]
        [InlineData(21, new int[]{ 3, 7 }, "should contain prime factors 3x7")]
        [InlineData(22, new int[]{ 2, 11 }, "should contain prime factors 2x11")]
        [InlineData(23, new int[]{ 23 }, "should contain 9. prime")]
        [InlineData(24, new int[]{ 2, 2, 2, 3 }, "should contain prime factors 2x2x2x3")]
        [InlineData(25, new int[]{ 5, 5 }, "should contain prime factors 5x5")]
        [InlineData(26, new int[]{ 2, 13 }, "should contain prime factors 2x13")]
        [InlineData(27, new int[]{ 3, 3, 3 }, "should contain prime factors 3x3x3")]
        public void Generate_GetParameterFromData_ReturnExpected(int input, int[] expected, string message)
        {
            var target = new PrimeFactors();

            var actual = target.Generate(input);

            actual.Should().Equal(expected, message);
        }
    }
}