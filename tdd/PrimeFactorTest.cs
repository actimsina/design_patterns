using System;
using Xunit;

namespace tdd
{
  public class PrimeFactorTest
  {

    [Theory]
    [InlineData(0, new int[] { })]
    [InlineData(1, new int[] { })]
    [InlineData(2, new int[] { 2 })]
    [InlineData(3, new int[] { 3 })]
    [InlineData(4, new int[] { 2, 2 })]
    [InlineData(5, new int[] { 5 })]
    [InlineData(6, new int[] { 2, 3 })]
    [InlineData(7, new int[] { 7 })]
    [InlineData(8, new int[] { 2, 2, 2 })]
    [InlineData(9, new int[] { 3, 3 })]
    [InlineData(2 * 3 * 5 * 7 * 13 * 17 * 29, new int[] { 2, 3, 5, 7, 13, 17, 29 })]
    public void TestOfPrimFactors(int number, int[] expected)
    {
      Assert.Equal(expected, PrimeFactor.Of(number));
    }

  }
}
