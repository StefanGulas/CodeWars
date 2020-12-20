namespace CodeWars
{
  public class HumanReadableTime
  {
    public static string GetReadableTime(int seconds)
    {
      string resultString = "";
      int SS = seconds % 60;
      int MM = ((seconds - SS) / 60) % 60;
      int HH = ((seconds / 60 - MM) / 60);

      resultString = Convert(HH) + ":" + Convert(MM) + ":" + Convert(SS);

      return resultString;
    }

    private static string Convert(int time)
    {
      string result = time.ToString();
      if (result.Length == 0) return "00";
      if (result.Length == 1) return "0" + result;
      return result;
    }
  }
}
