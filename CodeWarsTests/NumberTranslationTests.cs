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
    public void Test4()
    {
      var translation = new NumberTranslation();
      string expected = "four";
      string actual = translation.Number2Words(4);

      Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test13()
    {
      var translation = new NumberTranslation();
      string expected = "thirteen";
      string actual = translation.Number2Words(13);

      Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test80()
    {
      var translation = new NumberTranslation();
      string expected = "eighty";
      string actual = translation.Number2Words(80);

      Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test200()
    {
      var translation = new NumberTranslation();
      string expected = "two hundred";
      string actual = translation.Number2Words(200);

      Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test630()
    {
      var translation = new NumberTranslation();
      string expected = "six hundred thirty";
      string actual = translation.Number2Words(630);

      Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test958()
    {
      var translation = new NumberTranslation();
      string expected = "nine hundred fifty-eight";
      string actual = translation.Number2Words(958);

      Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test8000()
    {
      var translation = new NumberTranslation();
      string expected = "eight thousand";
      string actual = translation.Number2Words(8000);

      Assert.Equal(expected, actual);
    }

  }
}
