using System.Collections.Generic;
using System;

namespace NumbersToWords
{
  public class Convert
  {
    private static Dictionary<int,string> _dict= new Dictionary<int,string>() 
    {
      {0,"zero"},
      {1,"one"},
      {2,"two"},
      {3,"three"},
      {4,"four"},
      {5,"five"},
      {6,"six"},
      {7,"seven"},
      {8,"eight"},
      {9,"nine"},
      {10,"ten"},
      {11,"eleven"},
      {12,"twelve"},
      {13,"thirteen"},
      {14,"fourteen"},
      {15,"fifteen"},
      {16,"sixteen"},
      {17,"seventeen"},
      {18,"eighteen"},
      {19,"nineteen"},
      {20,"twenty"},
      {30,"thirty"},
      {40,"fourty"},
      {50,"fifty"},
      {60,"sixty"},
      {70,"seventy"},
      {80,"eighty"},
      {90,"ninety"},
      {100,"hundred"},
      {1000, "thousand"},
    };
    public static string ConvertToString(int input) {
      string result = "";
      //from 1000 - 9999
      if(input >= 1000)
      {
        int thousandDigits = input / 1000;
        // int hundredsValue = (input / 1000) * 1000;
        result += Convert._dict[thousandDigits];
        result += " ";
        result += Convert._dict[1000];
        input -= (thousandDigits * 1000);
        if (input == 0) 
        {
          return result;
        } 
        else
        {
          result += " ";
        }
      }
  
      //from 100 - 999
      if(input >= 100)
      {
        int hundredsDigit = input / 100;
        // int hundredsValue = (input / 100) * 100;
        result += Convert._dict[hundredsDigit];
        result += " ";
        result += Convert._dict[100];
        input -= (hundredsDigit * 100);
        if (input == 0) 
        {
          return result;
        } 
        else
        {
          result += " ";
        }
      }
      //hardcoded case
      if((input <= 20) || (input % 10 == 0))
      {
        // return Convert._dict[input];

        result += Convert._dict[input];
      } 
      else 
      //case where it's not hardcoded
      {
        // access the strings from the dict using those variables
        // concat them to result
        int tensValue = (input / 10) * 10;
        int onesValue = input % 10;
        result += Convert._dict[tensValue];
        result += " ";
        result += Convert._dict[onesValue];
      }
      return result;
    }  


    /*
   Failed ConvertToString_ReturnString_ExpectedStringOneThousand [61 ms]
  Error Message:
   Assert.AreEqual failed. Expected:<one thousand>. Actual:<ten hundred>.
  Stack Trace:
     at NumbersToWords.Tests.ClassNameTests.ConvertToString_ReturnString_ExpectedStringOneThousand() in C:\Users\john smith\Desktop\epicodus\C#\NumbersToWords.Solution\NumbersToWords.Tests\ModelTests\NumbersToWordsTests.cs:line 114

  Failed ConvertToString_ReturnString_ExpectedStringOneThousandAndTwenty [1 ms]
  Error Message:
   Assert.AreEqual failed. Expected:<one thousand twenty>. Actual:<ten hundred twenty>.
  Stack Trace:
     at NumbersToWords.Tests.ClassNameTests.ConvertToString_ReturnString_ExpectedStringOneThousandAndTwenty() in C:\Users\john smith\Desktop\epicodus\C#\NumbersToWords.Solution\NumbersToWords.Tests\ModelTests\NumbersToWordsTests.cs:line 125


Failed!  - Failed:     2, Passed:     8, Skipped:     0, Total:    10, Duration: 276 ms - NumbersToWords.Tests.dll (net5.0)
      
    */
  }
}