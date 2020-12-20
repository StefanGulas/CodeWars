using CodeWars;
using Xunit;

namespace CodeWarsTests
{
  public class ValidParenthesesTest
  {
    [Fact]
    public void Test0()
    {

      string expected = "1,2";
      string actual = "1,2";

      Assert.Equal(expected, actual);
    }
    [Fact]
    public void BuddyPairsLarge()
    {
      static void testing(bool expected, string parentheses)
      {

        Assert.Equal(expected, ValidParentheses.ValidParenthesis(parentheses));
      }

      testing(true, "()");
      testing(true, "34543(1081184 1331967)");
      testing(false, ")((((");
      testing(false, "()(areztzr)()()()()()((((((()))))(((((((((((()))(()))()())()((");
      testing(true, "()(areztzr)()()()()()((((((()))))(((((((((((()))(()))()())()(()))))))))))");
    }
  }
}
