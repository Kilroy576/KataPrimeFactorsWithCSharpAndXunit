using System.Collections.Generic;
using FluentAssertions;
using KataPrimeFactors;
using Xunit;

namespace KataPrimeFactorsTests
{
    public class PrimeFactorsTests
    {
        [Theory]
        [InlineData(2, new int[]{ 2 })]
        [InlineData(3, new int[]{ 3 })]
        [InlineData(4, new int[]{ 2, 2 })]
        public void Generate_GetParameterFromData_ReturnExpected(int input, int[] expected)
        {
            var target = new PrimeFactors();

            var actual = target.Generate(input);

            actual.Should().Equal(expected);
        }
    }
}