using CodeWars;
using Xunit;

namespace CodeWarsTests
{
  public class HumanReadableTimeTest
  {
    [Fact]
    public void Test0()
    {

      string expected = "1,2";
      string actual = "1,2";

      Assert.Equal(expected, actual);
    }
    [Fact]
    public void HumanReadableTest()
    {
      Assert.Equal("00:00:00", HumanReadableTime.GetReadableTime(0));
      Assert.Equal("00:00:05", HumanReadableTime.GetReadableTime(5));
      Assert.Equal("00:01:00", HumanReadableTime.GetReadableTime(60));
      Assert.Equal("23:59:59", HumanReadableTime.GetReadableTime(86399));
      Assert.Equal("99:59:59", HumanReadableTime.GetReadableTime(359999));
    }
  }
}

