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
  }
}