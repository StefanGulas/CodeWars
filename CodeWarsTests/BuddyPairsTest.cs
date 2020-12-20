using CodeWars;
using Xunit;
using CodeWars;

namespace CodeWarsTests
{
  public class BuddyPairsTest
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
      static void testing(long start, long limit, string expected)
      {
 
        Assert.Equal(expected, BuddyPairs.Buddy(start, limit));
      }

        testing(1071625, 1103735, "(1081184 1331967)");
        testing(2382, 3679, "Nothing");
        testing(8983, 13355, "(9504 20735)");
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
  

