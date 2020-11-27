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
    [Fact]
    public void Test15368()
    {
      var translation = new NumberTranslation();
      string expected = "fifteen thousand three hundred sixty-eight";
      string actual = translation.Number2Words(15368);

      Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test700000()
    {
      var translation = new NumberTranslation();
      string expected = "seven hundred thousand";
      string actual = translation.Number2Words(700000);

      Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test999999()
    {
      var translation = new NumberTranslation();
      string expected = "nine hundred ninety-nine thousand nine hundred ninety-nine";
      string actual = translation.Number2Words(999999);

      Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test800()
    {
      var translation = new NumberTranslation();
      string expected = "eight hundred";
      string actual = translation.Number2Words(800);

      Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test1000()
    {
      var translation = new NumberTranslation();
      string expected = "one thousand";
      string actual = translation.Number2Words(1000);

      Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test0()
    {
      var translation = new NumberTranslation();
      string expected = "zero";
      string actual = translation.Number2Words(0);

      Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Test890069()
    {
      var translation = new NumberTranslation();
      string expected = "eight hundred ninety thousand sixty-nine";
      string actual = translation.Number2Words(890069);

      Assert.Equal(expected, actual);
    }
  }
}
