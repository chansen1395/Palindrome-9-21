using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeTests
  {

    [TestMethod]
    public void IsPalindrome_Palindrome_False()
    {
      PalindromeChecker testPalindrome = new PalindromeChecker();
      Assert.AreEqual(false, testPalindrome.IsPalindrome("dog"));
    }

    [TestMethod]
    public void IsPalindrome_Palindrome_True()
    {
      PalindromeChecker testPalindrome = new PalindromeChecker();
      Assert.AreEqual(true, testPalindrome.IsPalindrome("racecar"));
    }

    [TestMethod]
    public void IsPalindrome_PalindromeCapitals_True()
    {
      PalindromeChecker testPalindrome = new PalindromeChecker();
      Assert.AreEqual(true, testPalindrome.IsPalindrome("racecaR"));
    }
  }
}