﻿using CodeWars;
using Xunit;

namespace CodeWarsTests
{
  public class RangeExtractionTest
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
    [Fact]
    public void SimpleTests()
    {
      Assert.Equal("1,2", RangeExtraction.Extract(new[] { 1, 2 }));
      Assert.Equal("1-3", RangeExtraction.Extract(new[] { 1, 2, 3 }));

      Assert.Equal(
          "-6,-3-1,3-5,7-11,14,15,17-20",
          RangeExtraction.Extract(new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 })
      );

      Assert.Equal(
          "-3--1,2,10,15,16,18-20",
          RangeExtraction.Extract(new[] { -3, -2, -1, 2, 10, 15, 16, 18, 19, 20 })
      );
    }
  }
}

