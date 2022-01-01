using System.Collections.Generic;
using FluentAssertions;
using KataPrimeFactors;
using Xunit;

namespace KataPrimeFactorsTests
{
    public class PrimeFactorsTests
    {
        [Fact]
        public void Generate_FirstPrime_ReturnFirstPrime()
        {
            var target = new PrimeFactors();
            var input = 2;
            List<int> expected = new List<int>() { 2 };

            var actual = target.Generate(input);

            actual.Should().Equal(expected);
        }
        
        [Fact]
        public void Generate_SecondPrime_ReturnSecondPrime()
        {
            var target = new PrimeFactors();
            var input = 3;
            List<int> expected = new List<int>() { 3 };

            var actual = target.Generate(input);

            actual.Should().Equal(expected);
        }
        
    }
}