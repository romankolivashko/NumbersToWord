using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class ClassNameTests
  {
    [TestMethod]
    public void ConvertToString_ReturnString_ExpectedStringOne()
    {
      //arrange (put hardcoded stuff in vars)
      int input = 1;
      string expected = "one";
      //act (call the function, assign to var)
      string result = Convert.ConvertToString(input);
    
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ConvertToString_ReturnString_ExpectedStringTwo()
    {
      //arrange (put hardcoded stuff in vars)
      int input = 2;
      string expected = "two";
      //act (call the function, assign to var)
      string result = Convert.ConvertToString(input);
    
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void ConvertToString_ReturnString_ExpectedStringTwentyOne()
    {
      //arrange (put hardcoded stuff in vars)
      int input = 30;
      string expected = "thirty";
      //act (call the function, assign to var)
      string result = Convert.ConvertToString(input);
    
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual(expected, result);
    }
  }
}