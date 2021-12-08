using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;
using System.Collections.Generic;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromesTests
  {
      // [TestMethod]
      // public void PalindromeTester_GetBool_SameStringAsInputted()
      // {
      //   Palindromes testString = new Palindromes();
      //   Assert.AreEqual("lunch", testString.PalindromeTester("lunch"));
      // }
      [TestMethod]
      public void PalindromeTester_StringArray_True()
      //NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
      {
        Palindromes testString = new Palindromes();
        Assert.AreEqual( true , testString.PalindromeTester("lunch"));
        // LeapYear testLeapYear = new LeapYear();
        // string testString = "stringnirts";
        // Assert.AreEqual("stringnirts", PalindromeTester("stringnirts"));
      }
  }
}

// > string[] fruits = { "apples", "oranges", "bananas", "pears" };
// > fruits
// string[4] { "apples", "oranges", "bananas", "pears" }

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