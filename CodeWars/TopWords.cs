using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
  public class TopWords
  {

    public static List<string> Top3(string s)
    {

      if (s == "") return new List<string>() { };
      s = s.ToLower();
      s = s.Replace("''", "");
      //s = s.Replace(" ' ", "");
      s = s.Replace("' ", "");
      s = s.Replace(" '", "");
      s = s.Replace(",", "");
      s = s.Replace("/", "");
      s = s.Replace(".", "");
      s = s.Replace("?", "");
      s = s.Replace(":", "");
      s = s.Replace("!", "");
      s = s.Replace("-", "");
      s = s.Replace("(", "");
      s = s.Replace(")", "");
      s = s.Replace("\r\n", "");
      s = s.Replace("\n", "");
      s = s.Replace("\r", "");


      List<string> result = s.Split(' ').ToList();
      result.RemoveAll(item => item == "");
      if (result.Count < 3) return result;
      var topWords = new SortedDictionary<string, int>();
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
      result.Clear();
      var output = topWords.OrderBy(e => e.Value).Select(e => new { e.Key }).ToList();

      for (int i = output.Count - 1; i >= 0; i--)
      {
        result.Add(output[i].Key.ToString());
        counter++;
        if (counter > 2) break;
      }

      return result;
    }
  }
}
