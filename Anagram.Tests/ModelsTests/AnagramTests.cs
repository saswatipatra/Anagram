using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
namespace Anagram.Tests
{
  [TestClass]
  public class WordTest
  {

    [TestMethod]
    public void GetAll_Anagram()
    {
      Word testWord = new Word();
      string word= "cat";
      string result= testWord.Alphabetize(word);
      Assert.AreEqual("act", result);
    }
  }
}
