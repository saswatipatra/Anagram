using System.Collections.Generic;
using System;
using Anagram.Models;
namespace Anagram
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter the word");
      string userInput= Console.ReadLine();
      if (userInput != null)
      {
        Console.WriteLine("Anagram for the inputted word: ");
        Word anagram= new Word ();
        //string anagram= Word.Alphabetize(userInput);
        Console.WriteLine(anagram.Alphabetize(userInput));
      }

    }
  }
}
