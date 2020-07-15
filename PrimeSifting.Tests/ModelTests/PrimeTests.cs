using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifting;
using System.Collections.Generic;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimeTests
  {
    [TestMethod]
    public void PrimeConstructor_CreatesInstanceOfPrime_Prime()
    {
      Prime newPrime = new Prime();
      Assert.AreEqual(typeof(Prime), newPrime.GetType());
    }

    [TestMethod]
    public void NumberList_CreatesListOfNumbersFromTwoToNumber_ListOfIntegersNumbers()
    {
      List<int> testList = new List<int>{2, 3, 4, 5};
      List<int> resultList = Prime.NumberList(5);
      CollectionAssert.AreEqual(testList, resultList);
    }

    [TestMethod]
    public void PrimeCalculatorList_ReturnListOfPrimeNumbersFromTwoToNumber_ListOfPrimeIntegersNumbers()
    {
      List<int> testList = new List<int>{2, 3, 5, 7, 11, 13};
      List<int> primeList = Prime.PrimeCalculatorList(15);
      CollectionAssert.AreEqual(testList, primeList);
    }
  }
}