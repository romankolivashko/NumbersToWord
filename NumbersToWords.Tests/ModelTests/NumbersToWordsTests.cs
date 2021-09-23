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
      int input = 21;
      string expected = "twenty one";
      //act (call the function, assign to var)
      string result = Convert.ConvertToString(input);
    
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ConvertToString_ReturnString_ExpectedStringThrity()
    {
      //arrange (put hardcoded stuff in vars)
      int input = 30;
      string expected = "thirty";
      //act (call the function, assign to var)
      string result = Convert.ConvertToString(input);
    
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void ConvertToString_ReturnString_ExpectedStringOneHundred()
    {
      //arrange (put hardcoded stuff in vars)
      int input = 100;
      string expected = "one hundred";
      //act (call the function, assign to var)
      string result = Convert.ConvertToString(input);
    
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void ConvertToString_ReturnString_ExpectedStringTwoHundred()
    {
      //arrange (put hardcoded stuff in vars)
      int input = 200;
      string expected = "two hundred";
      //act (call the function, assign to var)
      string result = Convert.ConvertToString(input);
    
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void ConvertToString_ReturnString_ExpectedStringOneHundredAndOne()
    {
      //arrange (put hardcoded stuff in vars)
      int input = 120;
      string expected = "one hundred twenty";
      //act (call the function, assign to var)
      string result = Convert.ConvertToString(input);
      //assert
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void ConvertToString_ReturnString_ExpectedStringOneHundredTwentyOne()
    {
      //arrange (put hardcoded stuff in vars)
      int input = 121;
      string expected = "one hundred twenty one";
      //act (call the function, assign to var)
      string result = Convert.ConvertToString(input);
      //assert
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void ConvertToString_ReturnString_ExpectedStringOneThousand()
    {
      //arrange (put hardcoded stuff in vars)
      int input = 1000;
      string expected = "one thousand";
      //act (call the function, assign to var)
      string result = Convert.ConvertToString(input);
      //assert
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void ConvertToString_ReturnString_ExpectedStringOneThousandAndTwenty()
    {
      //arrange (put hardcoded stuff in vars)
      int input = 9909;
      string expected = "nine thousand nine hundred nine";
      //act (call the function, assign to var)
      string result = Convert.ConvertToString(input);
      //assert
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void ConvertToString_ReturnString_ExpectedStringOneHundredThousandAndNine()
    {
      //arrange (put hardcoded stuff in vars)
      int input = 100009;
      string expected = "one hundred thousand nine";
      //act (call the function, assign to var)
      string result = Convert.ConvertToString(input);
      //assert
      Assert.AreEqual(expected, result);
    }
  }
}