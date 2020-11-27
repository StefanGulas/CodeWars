namespace CodeWars
{
  public class NumberTranslation
  {
    public string Number2Words(int n)
    {
      string number = n.ToString();
      string stringNumber = string.Empty;
      string numberInPosition;
      string previousNumberInPosition = string.Empty;
      int counter = 0;
      for (int i = number.Length - 1; i >= 0; i--)
      {
        numberInPosition = number[i].ToString();
        counter++;
        if (counter == 1 && number.Length == 1)
        {
          switch (numberInPosition)
          {

            case "1":
              stringNumber = "one";
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

        }
        else if (counter == 2 && numberInPosition == "1")
        {
          switch (previousNumberInPosition)
          {
            case "0":
              stringNumber = "ten";
              break;
            case "1":
              stringNumber = "eleven";
              break;
            case "2":
              stringNumber = "twelve";
              break;
            case "3":
              stringNumber = "thirteen";
              break;
            case "4":
              stringNumber = "fourteen";
              break;
            case "5":
              stringNumber = "fifteen";
              break;
            case "6":
              stringNumber = "sixteen";
              break;
            case "7":
              stringNumber = "seventeen";
              break;
            case "8":
              stringNumber = "eighteen";
              break;
            case "9":
              stringNumber = "nineteen";
              break;

            default:
              stringNumber = "Id do not know";
              break;
          }

        }
        else if (counter == 2 && numberInPosition != "1")
        {
          switch (previousNumberInPosition)
          {
            case "0":
              stringNumber = "ten";
              break;
            case "1":
              stringNumber = "eleven";
              break;
            case "2":
              stringNumber = "twelve";
              break;
            case "3":
              stringNumber = "thirteen";
              break;
            case "4":
              stringNumber = "fourteen";
              break;
            case "5":
              stringNumber = "fifteen";
              break;
            case "6":
              stringNumber = "sixteen";
              break;
            case "7":
              stringNumber = "seventeen";
              break;
            case "8":
              stringNumber = "eighteen";
              break;
            case "9":
              stringNumber = "nineteen";
              break;

            default:
              stringNumber = "Id do not know";
              break;
          }

        }
        previousNumberInPosition = numberInPosition;
      }
        return stringNumber;
    }
  }
}

