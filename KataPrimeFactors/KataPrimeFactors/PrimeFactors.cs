using System.Collections.Generic;

namespace KataPrimeFactors
{
    public class PrimeFactors   
    {   
        public List<int> Generate(int input)
        {
            var result = new List<int>();

            for (int divisor = 2; divisor < input; divisor++)
            {
                while (input % divisor == 0)
                {
                    result.Add(divisor);
                    input /= divisor;
                }
            }

            if (input > 1)
            {
                result.Add(input);
            }

            return result;
        }
    }
}