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

    public static List<int> PrimeCalculatorList(int number)
    {
      return new List<int>();
    }
  }
}