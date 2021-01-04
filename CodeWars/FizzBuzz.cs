using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
  public class FizzBuzz
  {
    public static string RunTest()
    {
      int number = 100;
      int fizz= 0;
      int buzz = 0;
      int fizzBuzz = 0;
      for (int i = 0; i < number; i++)
      {
        if (i % 3 == 0)
        {
          if (i % 5 == 0)
          {
            fizzBuzz++;
          }
          fizz++;
        }
        if (i % 5 == 0) buzz++;
      }
      return fizz.ToString() + buzz.ToString() + fizzBuzz.ToString();
    }



  }
}
