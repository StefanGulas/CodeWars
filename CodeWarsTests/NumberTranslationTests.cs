using CodeWars;
using System;
using Xunit;

namespace CodeWarsTests
{
  public class NumberTranslationTests
  {
    [Fact]
    public void Test1()
    {
      var translation = new NumberTranslation();
      string expected = "one";
      string actual = translation.Number2Words(1);

      Assert.Equal(expected, actual);
    }
    [Fact]
    public void TestFour()
    {
      var translation = new NumberTranslation();
      string expected = "four";
      string actual = translation.Number2Words(4);

      Assert.Equal(expected, actual);
    }
  }
}
