using System.Collections.Generic;

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
    };
    public static string ConvertToString(int input) {
      //384 into "three hundred eighty four"
      if(input <= 20)
      {
        return Convert._dict[input];
      } 
      else 
      {
        // separate the "tens" value 20 from the "ones" digit/value into separate variables
        int tensValue = (input / 10) * 10;
        int onesValue = input % 10;
        // access the strings from the dict using those variables
        // concat them to result
        string result = "";

        result += Convert._dict[tensValue];
        result += " ";
        result += Convert._dict[onesValue];

        return result;
      }
    }  


    //decide a classname
    //decide properties - declare
    //method name
    //write a test - decide what parameters
  }
}