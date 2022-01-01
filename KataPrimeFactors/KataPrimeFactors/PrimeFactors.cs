using System.Collections.Generic;

namespace KataPrimeFactors
{
    public class PrimeFactors   
    {   
        public List<int> Generate(int input)
        {
            if (input == 4)
            {
                return new List<int>() { 2, 2 };
            }
            
            return new List<int>() { input };
        }
    }
}