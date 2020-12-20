namespace CodeWars
{
  public class ValidParentheses
  {
    public static bool ValidParenthesis(string input)
    {
      foreach (var item in input)
      {
        if (item.ToString() != "(" && item.ToString() != ")") input = input.Replace(item.ToString(), "");
      }
      
      if (input == "" || input == null) return true;
      if (!(input[0].ToString() == "(" && input[input.Length - 1].ToString() == ")")) return false; 
      int count = 0;
      foreach (var item in input)
      {
        if (item.ToString() == "(") count++;
        else if (item.ToString() == ")") count--;
        if (count < 0) return false;
      }
      if (count == 0) return true;
      else return false;
    }
  }
}
