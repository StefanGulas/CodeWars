namespace CodeWars
{
  public class NumberTranslation
  {
    public string Number2Words(int n)
    {
      string number = n.ToString();
      string stringNumber = string.Empty;
      string numberInPosition;
      string stringNumber1 = string.Empty;
      string previousNumberInPosition = string.Empty;
      int counter = 0;
      for (int i = number.Length - 1; i >= 0; i--)
      {
        numberInPosition = number[i].ToString();
        counter++;
        if (counter == 1)
        {
          switch (numberInPosition)
          {
            case "0":
              stringNumber = "";
              break;
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
        // für 10er Stellen unter 20
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
        // für 10er Stelle ab 20
        else if (counter == 2 && numberInPosition != "1" && numberInPosition != "0")
        {
          switch (numberInPosition)
          {

            case "2":
              stringNumber = "twenty";
              break;
            case "3":
              stringNumber = "thirty";
              break;
            case "4":
              stringNumber = "fourty";
              break;
            case "5":
              stringNumber = "fifty";
              break;
            case "6":
              stringNumber = "sixty";
              break;
            case "7":
              stringNumber = "seventy";
              break;
            case "8":
              stringNumber = "eighty";
              break;
            case "9":
              stringNumber = "ninety";
              break;

            default:
              stringNumber = "Id do not know";
              break;
          }
          if (stringNumber1 != "")
          {
            stringNumber = stringNumber + "-" + stringNumber1;
          }

        }
        // für 100er Stelle
        else if (counter == 3 && numberInPosition != "0")
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
          if (stringNumber1 != "") stringNumber = stringNumber + " hundred " + stringNumber1;
          else stringNumber += " hundred"; //Case: keine 1er und 10er Stellen
        }
        // 1000er Stellen+
        int a = 1;
        if (number.Length < 5) a = 0;
        if (counter == 4 && numberInPosition != "0" && number[i - a].ToString() != "1")
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
          if (stringNumber1 != "") stringNumber = stringNumber + " thousand " + stringNumber1;
          else stringNumber += " thousand"; //Case: keine 1.000er bis 9999er Stellen
        }
        // 10.000 - 19.999 Stellen
        else if (counter == 5 && numberInPosition == "1")
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
          if (stringNumber1 != "") stringNumber = stringNumber + " thousand " + stringNumber1;
          else stringNumber += " thousand"; //Case: keine 11er und 19.999er Stellen

        }
        if (counter == 5 && numberInPosition != "0" && numberInPosition != "1")
        {
          switch (numberInPosition)
          {

            case "2":
              stringNumber = "twenty";
              break;
            case "3":
              stringNumber = "thirty";
              break;
            case "4":
              stringNumber = "fourty";
              break;
            case "5":
              stringNumber = "fifty";
              break;
            case "6":
              stringNumber = "sixty";
              break;
            case "7":
              stringNumber = "seventy";
              break;
            case "8":
              stringNumber = "eighty";
              break;
            case "9":
              stringNumber = "ninety";
              break;

            default:
              stringNumber = "Id do not know";
              break;

          }

          if (stringNumber1 != "") stringNumber = stringNumber + "-" + stringNumber1;
          else stringNumber += " thousand"; //Case: keine 1er und 10er Stellen
        }
        //if (counter == 6 && numberInPosition != "0")
        //{
        //  switch (numberInPosition)
        //  {
        //    case "1":
        //      stringNumber = "one";
        //      break;
        //    case "2":
        //      stringNumber = "two";
        //      break;
        //    case "3":
        //      stringNumber = "three";
        //      break;
        //    case "4":
        //      stringNumber = "four";
        //      break;
        //    case "5":
        //      stringNumber = "five";
        //      break;
        //    case "6":
        //      stringNumber = "six";
        //      break;
        //    case "7":
        //      stringNumber = "seven";
        //      break;
        //    case "8":
        //      stringNumber = "eight";
        //      break;
        //    case "9":
        //      stringNumber = "nine";
        //      break;

        //    default:
        //      stringNumber = "Id do not know";
        //      break;

        //  }
        //  if (stringNumber1 != "") stringNumber = stringNumber + " thousand " + stringNumber1;
        //  else stringNumber += " thousand"; //Case: keine 1er und 10er Stellen
        //}
        else if (counter == 6)
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
          if (stringNumber1 != "") stringNumber = stringNumber + " hundred " + stringNumber1;
          else stringNumber += " hundred thousand"; //Case: keine 1er und 10er Stellen
        }
        previousNumberInPosition = numberInPosition;
        stringNumber1 = stringNumber;
      }
      return stringNumber;
    }
  }
}

