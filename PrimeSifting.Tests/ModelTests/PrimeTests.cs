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
  }
}