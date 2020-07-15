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
      List<int> numberList = NumberList(number);
      int prime = numberList[0];
      while(prime < number)
      {
        if(numberList.Contains(prime))
        {
          for(int i = prime*2; i<=number; i+=prime)
          {
            numberList.Remove(i);
          }
        }
        prime ++;
      }
      return numberList;
    }
  }
}