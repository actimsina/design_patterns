using System.Collections.Generic;

namespace tdd
{
  public class PrimeFactor
  {
    public static List<int> Of(int number)
    {
      List<int> primes = new List<int>();
      for (int factor = 2; factor <= number; factor++)
      {
        while (number % factor == 0)
        {
          primes.Add(factor);
          number /= factor;
        }
      }
      return primes;
    }
  }
}