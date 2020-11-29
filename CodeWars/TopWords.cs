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
      result.RemoveAll(item => item == "");
      if (result.Count < 3) return result;
      var topWords = new Dictionary<string, int>();
      var top2Words = new Dictionary<string, int>();
      var top3Words = new Dictionary<string, int>();
      string actualWord;
      int counter = 0;
      for (int i = 0; i < result.Count; i++)
      {
        if (topWords.ContainsKey(result[i]) == true) continue;

        for (int j = 0; j < result.Count; j++)
        {
          if (result[j] == result[i]) counter++;
        }
        topWords.Add(result[i], counter);
        counter = 0;
      }
      foreach (KeyValuePair<string, int> item in topWords.OrderBy(key => key.Value))
      {
        result.Clear();
        result.Add(topWords.Keys())

      }



      return result;
    }
  }
}
