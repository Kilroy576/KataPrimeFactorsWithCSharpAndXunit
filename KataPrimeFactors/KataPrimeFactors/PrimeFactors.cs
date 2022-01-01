using System.Collections.Generic;

namespace KataPrimeFactors
{
    public class PrimeFactors   
    {   
        public List<int> Generate(int input)
        {
            var result = new List<int>();

            if (input % 2 == 0)
            {
                result.Add(2);
                input /= 2;
            }

            if (input > 1)
            {
                result.Add(input);
            }

            return result;
        }
    }
}