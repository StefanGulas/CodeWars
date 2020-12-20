namespace CodeWars
{
  public class BuddyPairs
  {
    public static string Buddy(long start, long limit)
    {
      long resultSum1 = 0;
      long resultSum2 = 0;
      for (int i = (int)start; i <= limit; i++)
      {
        for (int j = 1; j <= i / 2; j++)
        {
          if (i % j == 0) resultSum1 += j;
        }
        long k = resultSum1 - 1;
        for (int l = 1; l <= k / 2; l++)
        {
          if (k % l == 0) resultSum2 += l;
        }
        if (resultSum2 - 1 == i && resultSum1 - 1 == k) return "(" + i + " " + k + ")";
        resultSum1 = 0;
        resultSum2 = 0;
      }
      return "Nothing";
    }
  }
}

