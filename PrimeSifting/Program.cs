using System;
using System.Collections.Generic; 
using PrimeSifting;

class Program
{
  static void Main()
  {
    Console.WriteLine("Give me a number, and I shall tell you all prime numbers it contains!");
    int userNumber = GetNumber();

    List<int> primeList = Prime.PrimeCalculatorList(userNumber);

    string output = "Prime Numbers: ";
    foreach (int index in primeList)
    {
      output = output + " " + index;
    }

    Console.WriteLine(output);
  }

  private static int GetNumber()
  {
    Console.WriteLine("Please enter a number more than or equal to 2");
    string userInput = Console.ReadLine();
    int acceptableNumber;
    bool canBeParsed = int.TryParse(userInput, out acceptableNumber);

    if (canBeParsed)
    {
      acceptableNumber = int.Parse(userInput);
      if(acceptableNumber < 2)
      {
        Console.WriteLine("Invalid Submission: number is too low!");
				acceptableNumber = GetNumber();
				return acceptableNumber;  
      }
      else
      {
        return acceptableNumber;
      }
    }
    else
    {
      Console.WriteLine("Invalid Submission: Only positive integers!");
			acceptableNumber = GetNumber();
			return acceptableNumber; 
    }
  }
}