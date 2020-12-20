using CodeWars;
using Xunit;

namespace CodeWarsTests
{
  public class JohnAndAnnTest
  {
    [Fact]
    public void Test0()
    {

      string expected = "1,2";
      string actual = "1,2";

      Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test1()
    {

      string expected = "1,2";
      string actual = CodeWars.RangeExtraction.Extract(new[] { 1, 2 });

      Assert.Equal(expected, actual);
    }
  }
}
