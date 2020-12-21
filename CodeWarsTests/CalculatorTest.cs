using CodeWars;
using Xunit;

namespace CodeWarsTests
{
  public class CalculatorTest
  {
    [Fact]
    public void Test0()
    {

      string expected = "1,2";
      string actual = "1,2";

      Assert.Equal(expected, actual);
    }
    [Fact]
    public void Calculator1()
    {
      Calculator calculator = new Calculator();


      Assert.Equal(1, calculator.Evaluate("1-1 +1"));
      Assert.Equal(2, calculator.Evaluate("1+1"));
      Assert.Equal(0, calculator.Evaluate("1-2 +1*1"));
      Assert.Equal(1, calculator.Evaluate("1-10 +1*10"));
      Assert.Equal(1, calculator.Evaluate("(1-1 +1)*1"));
      
    }
    [Fact]
    public void BuddyPairsSmall()
    {
      static void testing(long start, long limit, string expected)
      {

        Assert.Equal(expected, BuddyPairs.Buddy(start, limit));
      }

      testing(48, 48, "(48 75)");

    }
  }
}
