namespace CodeWars
{
  public class RangeExtraction
  {
    public static string Extract(int[] args)
    {
      string ergebnisString = "";
      int tail = args[0];
      if (args.Length == 1) return args[0].ToString();
      if (args.Length == 2) return args[0] + "," + args[1];
      for (int i = 0; i < args.Length; i++)
      {
        if (i == args.Length - 1)
        {
          if (tail == args[i]) ergebnisString = ergebnisString + "," + args[i];
          if (tail + 1 == args[i]) ergebnisString = ergebnisString + "," + args[i - 1] + "," + args[i];
          else if (args[i] - tail > 1) ergebnisString = ergebnisString + "," + tail + "-" + args[i];
          break;
        }


        if (tail == args[i] && args[i] + 1 != args[i + 1])
        {
          ergebnisString = ergebnisString + "," + args[i];
          tail = args[i + 1];

          continue;
        }
        if (tail + 1 == args[i] && args[i] + 1 != args[i+1])
        {
          ergebnisString = ergebnisString + "," + args[i-1] + "," + args[i];
          tail = args[i + 1];
          continue;
        }
        
        if (args[i] - tail > 1 && args[i] + 1 != args[i+1])
        {
          ergebnisString = ergebnisString + "," + tail + "-" + args[i];
          tail = args[i + 1];
          continue;
        }
      }
      if(ergebnisString[0].ToString() == ",") ergebnisString = ergebnisString.Remove(0,1);
      return ergebnisString;
    }
  }
}
