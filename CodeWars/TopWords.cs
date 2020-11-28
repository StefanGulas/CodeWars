using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
  public class TopWords
  {

    public static List<string> Top3(string s)
    {
    int top1Counter = 0;
    int top2Counter = 0;
    int top3Counter = 0;
      
      if (s == "") return new List<string>() { };
      s = s.ToLower();
      List<string> result = s.Split(' ').ToList();
      result.Remove("");
      if (result.Count < 3) return result;
      var topWords = new Dictionary<string, int>();
      var top2Words = new Dictionary<string, int>();
      var top3Words = new Dictionary<string, int>();
      string actualWord;
      int counter = 0;
      for (int i = 0; i < result.Count; i++)
      {
        for (int j = 0; j < result.Count; j++)
        {
          if (result[j] == result[i]) counter++;
        }
        topWords.Add(result[i], counter);
      }

      
      //  if (counter > top3Words[,])
      //    if (counter > top2Counter)
      //    {
      //      top3Counter = top2Counter;
      //      if (counter > top1Counter)
      //      {
      //        top2Counter = top1Counter;
      //        top1Counter = counter;
      //      }
      //      else
      //      {
      //        top2Counter = counter;
      //      }
      //    }
      //    else top3Counter = counter;
      //topWords = { top1Conter, top2Counter, top3Counter};
        
        // Your code here
      return result;
    }
  }
}
