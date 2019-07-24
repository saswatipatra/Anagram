using System.Collections.Generic;
using System;
namespace Anagram.Models
{
  public class Word
  {
    public string Alphabetize(string word)
    {
      char[] a = word.ToCharArray();
      Array.Sort(a);
      return new string(a);
    }

  }
}
