using System;
using System.Collections.Generic;
using System.Text;
using CodeWars;
using Xunit;

namespace CodeWarsTests
{
  public class FizzBuzzTest
  {
    
    [Fact]
    public void Test1()
    {
      string actual = FizzBuzz.RunTest();
      Assert.Equal("122", actual);

    }

  }
}
