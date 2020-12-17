using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(uint candidate)
        {
            Console.WriteLine($"candidate = {candidate}");
            if (candidate < 2)
            {
                return false;
            }
            
            for (int div = 2; div <= Math.Round(Math.Sqrt(candidate)); div++)
            {
                if (candidate % div == 0) return false;
            }
            return true;
        }
    }
}
