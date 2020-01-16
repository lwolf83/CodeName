using System;
using System.Collections.Generic;
using System.Text;

namespace codeName
{
    class RepresentationCalculator
    {
        public static string GetName()
        {
            string name;
            do
            {
                Console.WriteLine("Enter your name : ");
                name = Console.ReadLine();

            } while (!IsWordOk(name));

            return name;
        }

        public static bool IsWordOk(string word)
        {
            bool result = true;
            foreach (char c in word)
            {
                if (!char.IsLetter(c))
                {
                    result = false;
                    Console.WriteLine("Letter '" + c + "' forbidden");
                }

            }
            return result;
        }

        public static int CodeName(string name)
        {
            int sumOfLetter = 0;
            foreach (char c in name)
            {
                char letter = c;
                letter = char.ToLower(c);
                sumOfLetter = sumOfLetter + (((int)letter - 97) % 9) + 1;
            }
            return sumOfLetter;
        }

        public static void DisplayCodedName(String name, int number)
        {
            Console.WriteLine(name + " will be coded as " + Convert.ToString(number));
        }

        public static int SumOfEachDigitUntilOneDigit(int number)
        {
            while(number >= 10)
            {
                number = SumOfEachDigit(number);
            }
            return number;
        }

        public static int SumOfEachDigit(int number)
        {
            int result = 0;
            string numberString = Convert.ToString(number);
            foreach(char c in numberString)
            {
                double digitDouble = Char.GetNumericValue(c);
                int digit = Convert.ToInt32(digitDouble);
                result = result + digit;
            }
            return result;
        }

    }
}
