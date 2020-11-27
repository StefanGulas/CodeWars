using System;
using System.Collections.Generic;

namespace ConvertStringToCamelCase
{
    public class Kata
    {
        static void Main(string[] args)
        {
            string sample = "t-d";
            Console.WriteLine(sample + " " + SampleString(sample));
        }

        public static string ToCamelCase(string str)
        {
            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '_') //|| (str[i] == '-'))
                {
                    //var s = char.ToUpper(str[i]);
                    str.Remove(i, 1);
                    //char.ToUpper(str[i]);
                }

            }
            return str;
        }
        
        static string SampleString(string str)
        {
            str = str.Remove(1, 1);
            
            return str;
        }


    }
}
