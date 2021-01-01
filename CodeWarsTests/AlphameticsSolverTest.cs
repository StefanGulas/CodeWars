using CodeWars;
using Xunit;

namespace CodeWarsTests
{
  public class AlphameticsSolverTest
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
      //      AlphameticsSolver alphameticsSolver = new AlphameticsSolver();


      Assert.Equal("", AlphameticsSolver.Alphametics("1-1 +1"));
      Assert.Equal("", AlphameticsSolver.Alphametics("1-1 +1"));
      Assert.Equal("", AlphameticsSolver.Alphametics("1-1 +1"));
      Assert.Equal("", AlphameticsSolver.Alphametics("1-1 +1"));
      Assert.Equal("", AlphameticsSolver.Alphametics("1-1 +1"));

    }
  }
}
