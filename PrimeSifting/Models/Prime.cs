using System.Collections.Generic;

namespace PrimeSifting
{
  public class Prime
  {
    public static List<int> NumberList(int number)
    {
      List<int> resultList = new List<int>();
      for(int i = 2; i<=number; i++)
      {
        resultList.Add(i);
      }
      return resultList;
    }
    //int number;
    //Prime.methodToGetPrimes(number);
    // properties, constructors, methods, etc. go here
    
    //private List<int> NumberList(int number)
    // {
    //   // Generates list of all numbers
    // }

    // public list PrimeCalculator()
    // {
    //   return primeList;
    // }

  }
}