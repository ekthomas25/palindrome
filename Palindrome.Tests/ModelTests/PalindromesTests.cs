using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromesTests
  {
      [TestMethod]
      public void PalindromeTester_GetStringInput_SameStringAsInputted()
      {
        Palindromes testString = new Palindromes();
        Assert.AreEqual("lunch", testString.PalindromeTester("lunch"));
        // LeapYear testLeapYear = new LeapYear();
        // string testString = "stringnirts";
        // Assert.AreEqual("stringnirts", PalindromeTester("stringnirts"));
      }
  }
}

/*
  using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName;

namespace ProjectName.Tests
{
  [TestClass]
  public class ClassNameTests
  {
      [TestMethod]
      public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
      {
        // any necessary logic to prep for test; instantiating new classes, etc.
        Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
      }
  }
}
*/