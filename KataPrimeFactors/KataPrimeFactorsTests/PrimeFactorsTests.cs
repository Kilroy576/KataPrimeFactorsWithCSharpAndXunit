using System.Collections.Generic;
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
    }
}