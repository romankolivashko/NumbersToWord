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
      {100,"one hundred"},
      {200,"two hundred"},
      {300,"three hundred"},
      {1000, "thousand"},
    };
    public static string ConvertToString(int input) {
      string result = "";
      if(input >= 100)
      {
        int hundredsValue = (input / 100) * 100;
        result += Convert._dict[hundredsValue];
        input -= hundredsValue;
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


    //decide a classname
    //decide properties - declare
    //method name
    //write a test - decide what parameters
  }
}