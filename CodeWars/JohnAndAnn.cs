using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
  public class JohnAndAnn
  {
    public static List<long> John(long n)
    {
      List<long> result = new List<long>();
      if (n == 0)
      {
        result.Add(0);
        return result;
      }
      if (n == 1)
      {
        result.Add(0);
        return result;
      }
      return null;
    }
    public static List<long> Ann(long n)
    {
      List<long> result = new List<long>();
      if (n == 0)
      {
        result.Add(1);
        return result;
      }
      if (n == 1)
      {
        result.Add(1);
        return result;
      }
      return null;
    }
    public static long SumJohn(long n)
    {

      return 0;
    }
    public static long SumAnn(long n)
    {

      return 0;
    }
  }
}
