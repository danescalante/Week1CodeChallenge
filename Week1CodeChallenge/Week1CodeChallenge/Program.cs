using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }

            for (int i = 92; i >= 79; i--)
            {
                Console.WriteLine(FizzBuzz(i));
            }


            Yodaizer("I like code");

        }
     
        public static string FizzBuzz(int number)
        {
            if ( (number % 5) == 0 && (number % 3) == 0)
            {
                return "FizzBuzz";
            }
            else if ((number % 5) == 0)
            {
                return "Fizz";
            }
            else if ((number % 3) == 0)
            {
                return "Buzz";
            }
            return number.ToString();
        }

        public static string Yodaizer(string text)
        {
           var someText = text;
           string[] textArray = someText.Split(' ');
           List<string> textList = textArray.ToList();
            if (textList.Count == 2)
            {
             List<string>.textList.Insert(0, [3]);
            }
            
        }
        public static bool IsPrime(int number)
        {
            return true;
        }
        public static string DashInsert(int number)
        {
            return string.Empty;
        }

        static void TextStats(string input)
        {
            Console.WriteLine("Number of characters: " + input.Length);
            Console.WriteLine("Number of Words: " + List<string> inputList = input.ToList());

        }
    }
}
