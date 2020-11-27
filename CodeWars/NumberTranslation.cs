namespace CodeWars
{
  public class NumberTranslation
  {
    public string Number2Words(int n)
    {
      string number = n.ToString();
      string stringNumber;


      switch (number)
      {
        case "0":
          stringNumber = "zero";
          break;
        case "2":
          stringNumber = "two";
          break;
        case "3":
          stringNumber = "three";
          break;
        case "4":
          stringNumber = "four";
          break;
        case "5":
          stringNumber = "five";
          break;
        case "6":
          stringNumber = "six";
          break;
        case "7":
          stringNumber = "seven";
          break;
        case "8":
          stringNumber = "eight";
          break;
        case "9":
          stringNumber = "nine";
          break;

        default:
          stringNumber = "Id do not know";
          break;
      }
      return stringNumber;
    }
  }
}

